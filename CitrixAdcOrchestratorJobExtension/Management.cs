// Copyright 2023 Keyfactor
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Keyfactor.Logging;
using Keyfactor.Orchestrators.Common.Enums;
using Keyfactor.Orchestrators.Extensions;
using Keyfactor.Orchestrators.Extensions.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO;
using static Org.BouncyCastle.Math.EC.ECCurve;
using com.citrix.netscaler.nitro.resource.config.pq;
using System.Collections.Generic;
using com.citrix.netscaler.nitro.resource.config.ssl;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    // ReSharper disable once InconsistentNaming
    public class Management : IManagementJobExtension
    {
        private string _thumbprint = string.Empty;

        private readonly IPAMSecretResolver resolver;

        private ILogger _logger;

        private string ServerUserName { get; set; }

        private string ServerPassword { get; set; }

        public Management(IPAMSecretResolver resolver)
        {
            this.resolver = resolver;
        }

        public string ExtensionName => CitrixAdcStore.StoreType;

        private string ResolvePamField(string name, string value)
        {
            _logger.LogTrace($"Attempting to resolved PAM eligible field {name}");
            return resolver.Resolve(value);
        }

        public JobResult ProcessJob(ManagementJobConfiguration jobConfiguration)
        {
            _logger = LogHandler.GetClassLogger<Management>();
            _logger.LogDebug($"Begin {jobConfiguration.Capability} for job id {jobConfiguration.JobId}...");
            _logger.MethodEntry(LogLevel.Debug);

            ServerPassword = ResolvePamField("ServerPassword", jobConfiguration.ServerPassword);
            ServerUserName = ResolvePamField("ServerUserName", jobConfiguration.ServerUsername);

            ApplicationSettings.Initialize(this.GetType().Assembly.Location);

            var store = new CitrixAdcStore(jobConfiguration, ServerUserName, ServerPassword);

            _logger.LogDebug("Logging into Citrix...");
            store.Login();

            try
            {
                //Management jobs, unlike Discovery, Inventory, and ReEnrollment jobs can have 3 different purposes:
                switch (jobConfiguration.OperationType)
                {
                    case CertStoreOperationType.Add:
                        List<string> virtualServerNames = new List<string>();
                        bool aliasExists = (store.AliasExists(jobConfiguration.JobCertificate.Alias));

                        if (aliasExists && !jobConfiguration.Overwrite)
                        {
                            throw new Exception($"Alias {jobConfiguration.JobCertificate.Alias} already exists in store {jobConfiguration.CertificateStoreDetails.StorePath} and overwrite is set to False.  Please try again with overwrite set to True if you wish to replace this entry.");
                        }

                        _logger.LogDebug("Begin Add...");
                        var virtualServerName = (string)jobConfiguration.JobProperties["virtualServerName"];
                        var sniCert = (string)jobConfiguration.JobProperties["sniCert"];

                        dynamic properties = JsonConvert.DeserializeObject(jobConfiguration.CertificateStoreDetails.Properties.ToString());
                        var linkToIssuer = properties.linkToIssuer == null || string.IsNullOrEmpty(properties.linkToIssuer.Value) ? false : Convert.ToBoolean(properties.linkToIssuer.Value);

                        _logger.LogTrace($"alias: {jobConfiguration.JobCertificate.Alias} virtualServerName {virtualServerName}");

                        if (aliasExists)
                        {
                            var binding = store.GetBinding(jobConfiguration.JobCertificate.Alias);

                            _logger.LogTrace($"binding: {JsonConvert.SerializeObject(binding)}");
                            if (binding != null && binding?.sslcertkey_sslvserver_binding != null)
                            {
                                foreach (var sBinding in binding?.sslcertkey_sslvserver_binding)
                                {
                                    virtualServerNames.Add(sBinding.servername);
                                }
                            }
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(virtualServerName))
                            {
                                foreach (var vsName in virtualServerName.Split(","))
                                    virtualServerNames.Add(virtualServerName);
                            }
                        }

                        PerformAdd(store, jobConfiguration.JobCertificate, virtualServerNames,
                            jobConfiguration.Overwrite, sniCert, linkToIssuer);

                        break;
                    case CertStoreOperationType.Remove:
                        _logger.LogDebug("Begin Delete...");
                        PerformDelete(store, jobConfiguration.JobCertificate);
                        _logger.LogDebug("End Delete...");
                        break;
                    case CertStoreOperationType.Create:
                        // The certificate store is the directory
                        break;
                    default:
                        //Invalid OperationType.  Return error.  Should never happen though
                        return new JobResult
                        {
                            Result = OrchestratorJobStatusJobResult.Failure,
                            JobHistoryId = jobConfiguration.JobHistoryId,
                            FailureMessage =
                                $"Site {jobConfiguration.CertificateStoreDetails.StorePath} on server {jobConfiguration.CertificateStoreDetails.ClientMachine}: Unsupported operation: {jobConfiguration.OperationType.ToString()}"
                        };
                }
            }
            catch (LinkException ex)
            {
                //Status: 2=Success, 3=Warning, 4=Error
                return new JobResult
                {
                    Result = OrchestratorJobStatusJobResult.Warning,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = ex.Message
                };
            }
            catch (Exception ex)
            {
                //Status: 2=Success, 3=Warning, 4=Error
                return new JobResult
                {
                    Result = OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = ex.Message
                };
            }

            return new JobResult
            {
                Result = OrchestratorJobStatusJobResult.Success,
                JobHistoryId = jobConfiguration.JobHistoryId,
                FailureMessage = ""
            };

            if (ApplicationSettings.AutoSaveConfig && result.Result == OrchestratorJobStatusJobResult.Success)
            {
                _logger.LogDebug("Saving configuration...");
                store.SaveConfiguration();
            }

            _logger.LogDebug("Logging out of Citrix...");
            store.Logout();

            _logger.LogDebug("Exiting ProcessJob");

            _logger.MethodExit(LogLevel.Debug);
            return result;
        }

        private void PerformAdd(CitrixAdcStore store, ManagementJobCertificate cert,
            List<string> virtualServerNames, bool overwrite, string sniCert, bool linkToIssuer)
        {
            _logger.MethodEntry(LogLevel.Debug);
            
            _logger.LogDebug("Updating keyPair");
            keyPairName = store.UpdateKeyPair(cert.Alias, pemFile, privateKeyFile);

            _logger.LogDebug("Updating cert bindings");
            //update cert bindings
            if (virtualServerName != null)
                store.UpdateBindings(keyPairName, virtualServerName, sniCert);

            if (linkToIssuer)
            {
                store.LinkToIssuer(cert.Contents, cert.PrivateKeyPassword, alias);
            }

            _logger.MethodExit(LogLevel.Debug);
        }

        private void PerformDelete(CitrixAdcStore store, ManagementJobCertificate cert)
        {
            _logger.LogTrace("Enter PerformDelete");
            var sslKeyFile = store.GetKeyPairByName(cert.Alias);
            
            //1. Delete the Keypair
            store.DeleteKeyPair(sslKeyFile);

            //2. Remove directory from file name, Delete the Key File
            store.DeleteFile(Path.GetFileName(sslKeyFile.key));

            //3. Remove directory from file name, Delete the Certificate File
            store.DeleteFile(Path.GetFileName(sslKeyFile.cert));

            _logger.LogTrace("Exit PerformDelete");
        }
    }
}