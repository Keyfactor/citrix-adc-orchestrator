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

using Keyfactor.Orchestrators.Extensions;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Keyfactor.Logging;
using Keyfactor.Orchestrators.Extensions.Interfaces;

using com.citrix.netscaler.nitro.resource.config.ssl;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    // ReSharper disable once InconsistentNaming
    public class Inventory : IInventoryJobExtension
    {
        public string ExtensionName => CitrixAdcStore.StoreType;

        private ILogger _logger;

        private readonly IPAMSecretResolver resolver;

        private string ServerUserName { get; set; }

        private string ServerPassword { get; set; }

        public Inventory(IPAMSecretResolver resolver)
        {
            this.resolver = resolver;
        }

        public JobResult ProcessJob(InventoryJobConfiguration jobConfiguration, SubmitInventoryUpdate submitInventoryUpdate)
        {
            _logger = LogHandler.GetClassLogger<Inventory>();
            _logger.LogDebug($"Client Machine: {jobConfiguration.CertificateStoreDetails.ClientMachine}");
            _logger.LogDebug($"UseSSL: {jobConfiguration.UseSSL}");
            _logger.LogDebug($"StorePath: {jobConfiguration.CertificateStoreDetails.StorePath}");
            ServerPassword = ResolvePamField("ServerPassword", jobConfiguration.ServerPassword);
            ServerUserName = ResolvePamField("ServerUserName", jobConfiguration.ServerUsername);


            _logger.LogDebug("Entering ProcessJob");
            CitrixAdcStore store = new CitrixAdcStore(jobConfiguration, ServerUserName, ServerPassword);

            _logger.LogDebug("Logging into Citrix...");
            store.Login();

            JobResult result = ProcessJob(store, jobConfiguration, submitInventoryUpdate);

            _logger.LogDebug("Logging out of Citrix...");
            store.Logout();

            _logger.LogDebug("Exiting ProcessJob");

            return result;
        }

        private string ResolvePamField(string name, string value)
        {
            _logger.LogTrace($"Attempting to resolved PAM eligible field {name}");
            return resolver.Resolve(value);
        }


        private JobResult ProcessJob(CitrixAdcStore store, InventoryJobConfiguration jobConfiguration, SubmitInventoryUpdate submitInventoryUpdate)
        {
            _logger.LogDebug("Begin New Bindings Fix Inventory...");
            _logger.LogTrace($"##### ClientMachine: {jobConfiguration.CertificateStoreDetails.ClientMachine}");
            _logger.LogTrace($"##### StorePath:{jobConfiguration.CertificateStoreDetails.StorePath}");

            List<CurrentInventoryItem> inventory = new List<CurrentInventoryItem>();

            try
            {
                _logger.LogDebug("Getting certificate list...");
                sslcertkey[] certificates = store.GetCertificates();
                _logger.LogDebug($"Found {certificates.Length} certificate results...");

                _logger.LogDebug("For each certificate...");
                foreach (sslcertkey certificate in certificates)
                {
                    _logger.LogDebug($"Retrieving certificate file: {certificate.cert} for alias {certificate.certkey}");
                    X509Certificate2 x = store.GetX509Certificate(s, out bool privateKeyEntry);

                    if (x == null) continue;

                    _logger.LogTrace($"##### privateKeyEntry: {privateKeyEntry.ToString()}");
                    if (!privateKeyEntry)
                    {
                        var certKey = keyPairList.FirstOrDefault(p => p.cert == s);
                        _logger.LogTrace($"##### certKey: {certKey}");
                        privateKeyEntry = certKey != null && !string.IsNullOrEmpty(certKey.key);
                    }
                    _logger.LogTrace($"##### privateKeyEntry: {privateKeyEntry.ToString()}");

                    processedAliases.Add(s);

                    Dictionary<string, object> parameters = new Dictionary<string, object>();

                    string tempStorePath = store.StorePath.Substring(store.StorePath.Length-1,1) == "/" ? store.StorePath : store.StorePath + "/";
                    var containsKeyWithPath = keyPairMap.ContainsKey(tempStorePath + s);
                    var containsKey = keyPairMap.ContainsKey(s);

                    _logger.LogTrace($"##### containsKeyWithPath: {containsKeyWithPath.ToString()}");
                    _logger.LogTrace($"##### containsKey: {containsKey.ToString()}");


                    if (containsKey || containsKeyWithPath)
                    {
                        var keyPairName = containsKeyWithPath ? keyPairMap[tempStorePath + s] : keyPairMap[s];

                        _logger.LogDebug($"Found keyPairName: {keyPairName}");
                        parameters.Add("keyPairName", keyPairName);

                        var binding = store.GetBinding(keyPairName);

                        var vserverBindings = binding?.sslcertkey_sslvserver_binding;
                        if (vserverBindings != null)
                        {
                            try
                            {
                                var virtualServerName = String.Join(",", vserverBindings.Select(p => p.servername));
                                _logger.LogDebug($"Found virtualServerName(s): {virtualServerName}");
                                parameters.Add("virtualServerName", virtualServerName);
                                string bindingsCsv = string.Empty;
                                foreach (string server in virtualServerName.Split(','))
                                {
                                    var bindings = store.GetBindingByVServer(server);
                                    var first = bindings.FirstOrDefault(b => b.certkeyname == keyPairName);
                                    if (first != null) bindingsCsv += first.snicert + ",";
                                }
                                parameters.Add("sniCert", bindingsCsv.TrimEnd(','));
                            }
                            catch (Exception e)
                            {
                                _logger.LogError($"Error handling SNI or VServerBindings {LogHandler.FlattenException(e)}");
                            }

                        }
                    }

                    inventory.Add(new CurrentInventoryItem()
                    {
                        Alias = s,
                        Certificates = new[] { Convert.ToBase64String(x.GetRawCertData()) },
                        //ItemStatus = itemStatus,
                        PrivateKeyEntry = privateKeyEntry,
                        UseChainLevel = false,
                        Parameters = parameters
                    });
                }
                _logger.LogDebug($"Found {inventory.Count} certificates at {jobConfiguration.CertificateStoreDetails.StorePath}");


            }
            catch (Exception ex)
            {
                _logger.LogError("Error performing certificate Inventory: " + ex.Message);
                _logger.LogDebug(ex.StackTrace);

                //Status: 2=Success, 3=Warning, 4=Error
                return new JobResult()
                {
                    Result = Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = "Error while performing certificate Inventory"
                };
            }

            try
            {
                _logger.LogDebug("Sending results back to command");
                //Sends inventoried certificates back to KF Command
                submitInventoryUpdate.Invoke(inventory);

                _logger.LogDebug("Successfully Completed Job");
                //Status: 2=Success, 3=Warning, 4=Error
                return new JobResult()
                {
                    Result = Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Success,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = ""
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("Error submitting certificate Inventory: " + ex.Message);
                _logger.LogDebug(ex.StackTrace);
                // NOTE: if the cause of the submitInventory.Invoke exception is a communication issue between the Orchestrator server and the Command server, the job status returned here
                //  may not be reflected in Keyfactor Command.
                return new JobResult()
                {
                    Result = Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = "Failure while submitting certificate Inventory"
                };
            }
        }
    }
}