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

            ServerPassword = ResolvePamField("ServerPassword", jobConfiguration.ServerPassword);
            ServerUserName = ResolvePamField("ServerUserName", jobConfiguration.ServerUsername);

            ApplicationSettings.Initialize(this.GetType().Assembly.Location);

            var store = new CitrixAdcStore(jobConfiguration, ServerUserName, ServerPassword);

            _logger.LogDebug("Logging into Citrix...");
            store.Login();

            _logger.LogDebug("Entering ProcessJob");
            var result = ProcessJob(store, jobConfiguration);

            if (ApplicationSettings.AutoSaveConfig && result.Result == OrchestratorJobStatusJobResult.Success)
            {
                _logger.LogDebug("Saving configuration...");
                store.SaveConfiguration();
            }

            _logger.LogDebug("Logging out of Citrix...");
            store.Logout();

            _logger.LogDebug("Exiting ProcessJob");

            return result;
        }

        private void PerformAdd(CitrixAdcStore store, ManagementJobCertificate cert, string keyPairName,
            string virtualServerName, bool overwrite, string sniCert, bool linkToIssuer)
        {
            _logger.LogTrace("Enter performAdd");
            var alias = cert.Alias;
            AddBindCert(store, cert, keyPairName, virtualServerName, overwrite, alias, sniCert, linkToIssuer);
        }

        private void AddBindCert(CitrixAdcStore store, ManagementJobCertificate cert, string keyPairName,
            string virtualServerName, bool overwrite, string alias, string sniCert, bool linkToIssuer)
        {
            var (pemFile, privateKeyFile) =
                store.UploadCertificate(cert.Contents, cert.PrivateKeyPassword, alias, overwrite);

            _logger.LogDebug("Updating keyPair");
            //update KeyPair
            keyPairName = store.UpdateKeyPair(alias, keyPairName, pemFile, privateKeyFile);

            _logger.LogDebug("Updating cert bindings");
            //update cert bindings
            if (virtualServerName != null)
                store.UpdateBindings(keyPairName, virtualServerName, sniCert);

            if (linkToIssuer)
            {
                store.LinkToIssuer(cert.Contents, cert.PrivateKeyPassword, keyPairName);
            }
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

        private JobResult ProcessJob(CitrixAdcStore store, ManagementJobConfiguration jobConfiguration)
        {
            _logger.LogDebug("Begin Management...");

            try
            {
                //Management jobs, unlike Discovery, Inventory, and ReEnrollment jobs can have 3 different purposes:
                switch (jobConfiguration.OperationType)
                {
                    case CertStoreOperationType.Add:
                        var dup = store.IsDuplicateCertificate(jobConfiguration.JobCertificate.Alias);
                        if ((dup && jobConfiguration.Overwrite) || !dup || (jobConfiguration.JobProperties.ContainsKey("RenewalThumbprint")))
                        {
                            _logger.LogDebug("Begin Add...");
                            var virtualServerName = (string)jobConfiguration.JobProperties["virtualServerName"];
                            var sniCert =  (string)jobConfiguration.JobProperties["sniCert"];

                            dynamic properties = JsonConvert.DeserializeObject(jobConfiguration.CertificateStoreDetails.Properties.ToString());
                            var linkToIssuer = properties.linkToIssuer == null || string.IsNullOrEmpty(properties.linkToIssuer.Value) ? false : Convert.ToBoolean(properties.linkToIssuer.Value);

                            //Check if Keypair name exists, if so, we need to append something to it so we don't get downtime
                            var keyPairName = jobConfiguration.JobCertificate.Alias;

                            _logger.LogTrace($"keyPairName: {keyPairName} virtualServerName {virtualServerName}");
                            if (jobConfiguration.JobProperties.ContainsKey("RenewalThumbprint"))
                            {
                                _thumbprint = jobConfiguration.JobProperties["RenewalThumbprint"].ToString();
                                _logger.LogDebug($"It's a renewal with thumbprint {_thumbprint}");
                            }

                            //if there is no thumbprint from Keyfactor then it is an Add, else it is a renewal
                            if (string.IsNullOrEmpty(_thumbprint))
                            {
                                _logger.LogDebug($"Begin Add/Enrollment... overwrite: {jobConfiguration.Overwrite}");
                                PerformAdd(store, jobConfiguration.JobCertificate, keyPairName, virtualServerName,
                                    jobConfiguration.Overwrite, sniCert, linkToIssuer);
                                _logger.LogDebug("End Add/Enrollment...");
                            }
                            else
                            {
                                //PerformRenewal
                                //1. Get All Keys /config/sslcertkey store.ListKeyPairs()
                                var keyPairList = store.GetCertificates();

                                _logger.LogTrace($"KeyPairList: {JsonConvert.SerializeObject(keyPairList)}");

                                //2. For Each check the binding /config/sslcertkey_binding store.GetBinding(strKey)
                                foreach (var kp in keyPairList)
                                {
                                    //4. Open the file and check the thumbprint
                                    var x = store.GetX509Certificate(kp);
                                    
                                    //5. If the Thumbprint matches the cert renewed from KF then PerformAdd With Overwrite 
                                    if (x?.Thumbprint == _thumbprint)
                                    {
                                        _logger.LogTrace($"Thumbprint Match: {_thumbprint}");
                                        var binding = store.GetBinding(kp.certkey);
                                        _logger.LogTrace($"binding: {JsonConvert.SerializeObject(binding)}");
                                        if (binding != null)
                                        {
                                            if (binding?.sslcertkey_sslvserver_binding != null)
                                            {
                                                foreach (var sBinding in binding?.sslcertkey_sslvserver_binding)
                                                {
                                                    _logger.LogTrace(
                                                        $"Starting PerformAdd Binding Name: {sBinding?.servername} kp.certkey: {kp?.certkey}");
                                                    PerformAdd(store, jobConfiguration.JobCertificate, kp?.certkey,
                                                        sBinding?.servername, true, sniCert, linkToIssuer);
                                                    _logger.LogTrace(
                                                        $"Finished PerformAdd Binding Name: {sBinding?.servername} kp.certkey: {kp?.certkey}");
                                                }
                                            }
                                            else
                                            {
                                                _logger.LogTrace($"Renewing cert with no binding Information");
                                                PerformAdd(store, jobConfiguration.JobCertificate, kp?.certkey, null, true, null, linkToIssuer);
                                                _logger.LogTrace($"Finished Renewing cert with no binding Information");
                                            }
                                        }
                                        else
                                        {
                                            _logger.LogTrace($"Renewing cert with no binding Information");
                                            PerformAdd(store, jobConfiguration.JobCertificate, kp?.certkey,null, true, null,linkToIssuer);
                                            _logger.LogTrace($"Finished Renewing cert with no binding Information");
                                        }

                                    }

                                }
                            }
                        }
                        else
                        {
                            return new JobResult
                            {
                                Result = OrchestratorJobStatusJobResult.Failure,
                                JobHistoryId = jobConfiguration.JobHistoryId,
                                FailureMessage =
                                    $"You must use overwrite, a duplicate alias was found {jobConfiguration.JobCertificate.Alias}"
                            };
                        }

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
        }
    }
}