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
using Keyfactor.Logging;
using Keyfactor.Orchestrators.Extensions.Interfaces;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    // ReSharper disable once InconsistentNaming
    public class Inventory : IInventoryJobExtension
    {
        public string ExtensionName => CitrixAdcStore.StoreType;

        private ILogger _logger;

        private readonly IPAMSecretResolver resolver;

        private string serverUserName { get; set; }

        private string serverPassword { get; set; }

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
            serverPassword = ResolvePamField("ServerPassword", jobConfiguration.ServerPassword);
            serverUserName = ResolvePamField("ServerUserName", jobConfiguration.ServerUsername);


            _logger.LogDebug("Entering ProcessJob");
            var store = new CitrixAdcStore(jobConfiguration,serverUserName,serverPassword);

            _logger.LogDebug("Logging into Citrix...");
            store.Login();

            var result = ProcessJob(store, jobConfiguration, submitInventoryUpdate);

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

            try
            {
                var inventory = PerformCertificateInventory(store, jobConfiguration);
                if (inventory == null)
                {
                    return new JobResult()
                    {
                        Result = Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Failure,
                        JobHistoryId = jobConfiguration.JobHistoryId,
                        FailureMessage = "Error while performing certificate Inventory"
                    };
                }

                _logger.LogDebug("Sending results back to command");
                // Sends inventoried certificates back to KF Command
                submitInventoryUpdate.Invoke(inventory);

                _logger.LogDebug("Successfully Completed Job");
                // Status: 2=Success, 3=Warning, 4=Error
                return new JobResult()
                {
                    Result = Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Success,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = ""
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("Error performing or submitting certificate Inventory: " + ex.Message);
                _logger.LogDebug(ex.StackTrace);
                // Status: 2=Success, 3=Warning, 4=Error
                return new JobResult()
                {
                    Result = Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = "Failure while performing or submitting certificate Inventory"
                };
            }
        }

        private List<CurrentInventoryItem> PerformCertificateInventory(CitrixAdcStore store, InventoryJobConfiguration jobConfiguration)
        {
            var inventory = new List<CurrentInventoryItem>();
            try
            {
                _logger.LogDebug("Getting file list...");
                var files = store.ListFiles();

                var existing = jobConfiguration.LastInventory.ToDictionary(i => i.Alias, i => i.Thumbprints.First());
                var contentsToCheck = files?.Select(x => x.filename).Union(existing.Keys).ToList() ?? new List<string>();

                _logger.LogDebug("Getting KeyPair list...");
                var keyPairList = store.ListKeyPairs();
                _logger.LogDebug($"Found {keyPairList.Length} KeyPair results...");

                var keyPairMap = keyPairList.ToDictionary(i => i.cert, i => i.certkey);

                foreach (var s in contentsToCheck)
                {
                    _logger.LogDebug($"Checking alias (filename): {s}");
                    var x = store.GetX509Certificate(s, out var privateKeyEntry);

                    if (x == null) continue;
                    
                    var parameters = GetCertificateParameters(store, keyPairMap, s);

                    var aliasName = s;
                    var sslCertKey = store.FindCertKeyByCertLocation(s, store.storePath + "/" + s);
                    if (sslCertKey != null && sslCertKey.Length == 1)
                    {
                        aliasName = sslCertKey[0].certkey;
                    }

                    inventory.Add(new CurrentInventoryItem()
                    {
                        Alias = aliasName,
                        Certificates = new[] { Convert.ToBase64String(x.GetRawCertData()) },
                        ItemStatus = Orchestrators.Common.Enums.OrchestratorInventoryItemStatus.Unknown,
                        PrivateKeyEntry = privateKeyEntry,
                        UseChainLevel = false,
                        Parameters = parameters
                    });
                }

                _logger.LogDebug($"Found {inventory.Count} certificates at {jobConfiguration.CertificateStoreDetails.StorePath}");
                return inventory;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error performing certificate Inventory: " + ex.Message);
                _logger.LogDebug(ex.StackTrace);
                return null;
            }
        }

        private Dictionary<string, object> GetCertificateParameters(CitrixAdcStore store, Dictionary<string, string> keyPairMap, string alias)
        {
            var parameters = new Dictionary<string, object>();
            var pathName = store.storePath + "/" + alias;
            var containsKeyWithPath = keyPairMap.ContainsKey(pathName);
            if (!containsKeyWithPath)
                pathName = store.storePath + alias;
            containsKeyWithPath = keyPairMap.ContainsKey(pathName);
            var containsKey = keyPairMap.ContainsKey(alias);

            if (!containsKey && !containsKeyWithPath) return parameters;
            var keyPairName = containsKeyWithPath ? keyPairMap[pathName] : keyPairMap[alias];

            _logger.LogDebug($"Found keyPairName: {keyPairName}");

            var binding = store.GetBinding(keyPairName);

            var vserverBindings = binding?.sslcertkey_sslvserver_binding?.Distinct();
            if (vserverBindings == null) return parameters;
            try
            {
                var virtualServerName = String.Join(",", vserverBindings.Select(p => p.servername));
                _logger.LogDebug($"Found virtualServerName(s): {virtualServerName}");
                parameters.Add("virtualServerName", virtualServerName);
                var bindingsCsv = virtualServerName.Split(',').Select(store.GetBindingByVServer).Select(bindings => bindings.FirstOrDefault(b => b.certkeyname == keyPairName)).Where(first => first != null).Aggregate(string.Empty, (current, first) => current + (first.snicert + ","));
                parameters.Add("sniCert", bindingsCsv.TrimEnd(','));
            }
            catch (Exception e)
            {
                _logger.LogError($"Error handling SNI or VServerBindings {LogHandler.FlattenException(e)}");
            }
            return parameters;
        }

    }
}
