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
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using com.citrix.netscaler.nitro.resource.config.system;
using Keyfactor.Logging;
using Keyfactor.Orchestrators.Common.Enums;
using Keyfactor.Orchestrators.Extensions;
using Keyfactor.Orchestrators.Extensions.Interfaces;
using Keyfactor.PKI.CryptographicObjects.Formatters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Org.BouncyCastle.Security;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    // ReSharper disable once InconsistentNaming
    public class Reenrollment : IReenrollmentJobExtension
    {
        private readonly IPAMSecretResolver resolver;

        private ILogger _logger;

        private string ServerUserName { get; set; }

        private string ServerPassword { get; set; }

        private string StorePassword { get; set; }

        public Reenrollment(IPAMSecretResolver resolver)
        {
            this.resolver = resolver;
        }

        public string ExtensionName => CitrixAdcStore.StoreType;

        private string ResolvePamField(string name, string value)
        {
            _logger.LogTrace($"Attempting to resolved PAM eligible field {name}");
            return string.IsNullOrEmpty(value) ? value : resolver.Resolve(value);
        }

        public JobResult ProcessJob(ReenrollmentJobConfiguration jobConfiguration, SubmitReenrollmentCSR submitReenrollment)
        {
            _logger = LogHandler.GetClassLogger<Reenrollment>();
            _logger.LogDebug($"Begin {jobConfiguration.Capability} for job id {jobConfiguration.JobId}...");
            _logger.MethodEntry(LogLevel.Debug);

            if (string.IsNullOrEmpty(jobConfiguration.Alias))
            {
                string errorMessage = "Error performing ODKG.  Alias is required.";
                _logger.LogError(errorMessage);
                return new JobResult
                {
                    Result = OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = $"Site {jobConfiguration.CertificateStoreDetails.StorePath} on server {jobConfiguration.CertificateStoreDetails.ClientMachine}: {errorMessage}"
                };
            }

            ServerPassword = ResolvePamField("ServerPassword", jobConfiguration.ServerPassword);
            ServerUserName = ResolvePamField("ServerUserName", jobConfiguration.ServerUsername);
            StorePassword = ResolvePamField("StorePassword", jobConfiguration.CertificateStoreDetails.StorePassword);

            dynamic properties = JsonConvert.DeserializeObject(jobConfiguration.CertificateStoreDetails.Properties.ToString());
            var linkToIssuer = properties.linkToIssuer == null || string.IsNullOrEmpty(properties.linkToIssuer.Value) ? false : Convert.ToBoolean(properties.linkToIssuer.Value);

            ApplicationSettings.Initialize(this.GetType().Assembly.Location);

            var store = new CitrixAdcStore(jobConfiguration, ServerUserName, ServerPassword);

            _logger.LogDebug("Logging into Citrix...");
            store.Login();

            try
            {
                bool aliasExists = store.AliasExists(jobConfiguration.Alias);

                if (aliasExists && !jobConfiguration.Overwrite)
                {
                    string errorMessage = $"Alias {jobConfiguration.Alias} already exists.  Overwrite must be set to True if you wish to perform ODKG on an existing alias.";
                    _logger.LogError(errorMessage);
                    return new JobResult
                    {
                        Result = OrchestratorJobStatusJobResult.Failure,
                        JobHistoryId = jobConfiguration.JobHistoryId,
                        FailureMessage = $"Site {jobConfiguration.CertificateStoreDetails.StorePath} on server {jobConfiguration.CertificateStoreDetails.ClientMachine}: {errorMessage}"
                    };
                }

                List<string> virtualServerNames = new List<string>();
                List<bool> sniCerts = new List<bool>();

                var virtualServerName = (string)jobConfiguration.JobProperties["virtualServerName"];
                var sniCert = (string)jobConfiguration.JobProperties["sniCert"];

                _logger.LogTrace($"alias: {jobConfiguration.Alias} virtualServerName {virtualServerName}");

                if (!aliasExists)
                {
                    if (!string.IsNullOrEmpty(virtualServerName))
                    {
                        foreach (string vsName in virtualServerName.Split(","))
                            virtualServerNames.Add(vsName);
                    }

                    if (!string.IsNullOrEmpty(sniCert))
                    {
                        foreach (string sni in sniCert.Split(","))
                        {
                            bool blnSni;
                            if (!Boolean.TryParse(sni.ToUpper(), out blnSni))
                            {
                                string errMessage = $"Invalid non boolean SNI value - {sni}";
                                _logger.LogError(errMessage);
                                throw new Exception(errMessage);
                            }

                            sniCerts.Add(blnSni);
                        }
                    }

                    if (virtualServerNames.Count != sniCerts.Count)
                    {
                        string errMsg = $"Number of virtual server Names ({virtualServerNames.Count.ToString()}) does not match the number of SNI cert values ({sniCerts.Count.ToString()}";
                        _logger.LogError(errMsg);
                        throw new Exception(errMsg);
                    }
                }

                string subjectText = !jobConfiguration.JobProperties.ContainsKey("subjectText") || jobConfiguration.JobProperties["subjectText"] == null
                    ? string.Empty
                    : jobConfiguration.JobProperties["subjectText"].ToString();

                string keyType = !jobConfiguration.JobProperties.ContainsKey("keyType") || jobConfiguration.JobProperties["keyType"] == null
                    ? string.Empty
                    : jobConfiguration.JobProperties["keyType"].ToString();

                int? keySize = !jobConfiguration.JobProperties.ContainsKey("keySize") || jobConfiguration.JobProperties["keySize"] == null || string.IsNullOrEmpty(jobConfiguration.JobProperties["keySize"].ToString())
                    ? null
                    : Convert.ToInt32(jobConfiguration.JobProperties["keySize"]);

                string sans = string.Empty;
                if (jobConfiguration.SANs != null && jobConfiguration.SANs.Count > 0)
                {
                    foreach (KeyValuePair<string, string[]> keyValue in jobConfiguration.SANs)
                    {
                        string key = keyValue.Key.Replace("ip4", "IP", StringComparison.OrdinalIgnoreCase).Replace("ip6", "IP", StringComparison.OrdinalIgnoreCase).Replace("dns", "DNS", StringComparison.OrdinalIgnoreCase);
                        foreach (string value in keyValue.Value)
                        {
                            sans += $"{key}:{value},";
                        }
                    }
                    if (sans.Length > 0)
                        sans = sans.Substring(0, sans.Length - 1);
                }

                _logger.LogDebug("Generating CSR on Citrix ADC appliance...");
                (string csr, string keyFileName) = store.GenerateCSR(jobConfiguration.Alias, subjectText, sans, StorePassword, keyType, keySize);

                X509Certificate2 cert = submitReenrollment.Invoke(csr);
                if (cert == null)
                {
                    string errorMessage = "Error retrieving certificate for CSR: certificate not returned.";
                    _logger.LogError(errorMessage);
                    return new JobResult
                    {
                        Result = OrchestratorJobStatusJobResult.Failure,
                        JobHistoryId = jobConfiguration.JobHistoryId,
                        FailureMessage = $"Site {jobConfiguration.CertificateStoreDetails.StorePath} on server {jobConfiguration.CertificateStoreDetails.ClientMachine}: {errorMessage}"
                    };
                }

                string certPem = CryptographicObjectFormatter.PEM.Format(DotNetUtilities.FromX509Certificate(cert), false);

                systemfile certificateFile = store.UploadCertificateFile(jobConfiguration.Alias, certPem);

                store.UpdateKeyPair(jobConfiguration.Alias, certificateFile.filename, keyFileName, StorePassword);

                _logger.LogDebug("Updating cert bindings");
                if (virtualServerNames.Count > 0)
                    store.UpdateBindings(jobConfiguration.Alias, virtualServerNames, sniCerts);

                if (linkToIssuer)
                {
                    store.LinkToIssuer(cert, jobConfiguration.Alias);
                }

                if (ApplicationSettings.AutoSaveConfig)
                {
                    _logger.LogDebug("Saving configuration...");
                    store.SaveConfiguration();
                }

                JobResult result = new JobResult
                {
                    Result = OrchestratorJobStatusJobResult.Success,
                    JobHistoryId = jobConfiguration.JobHistoryId
                };

                return result;
            }
            catch (LinkException ex)
            {
                return new JobResult
                {
                    Result = OrchestratorJobStatusJobResult.Warning,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = LogHandler.FlattenException(ex, true)
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception for {jobConfiguration.Capability}: {LogHandler.FlattenException(ex)} for job id {jobConfiguration.JobId}");
                return new JobResult
                {
                    Result = OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = LogHandler.FlattenException(ex, true)
                };
            }
            finally
            {
                store.Logout();
                _logger.MethodExit(LogLevel.Debug);
            }
        }
    }
}
