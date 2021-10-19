using Keyfactor.Orchestrators.Extensions;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

using System.Linq;
using System.Security.Cryptography.X509Certificates;

using Keyfactor.Orchestrators.Common.Enums;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    public class Inventory : IInventoryJobExtension
    {
        private ILogger _logger { get; }

        public string ExtensionName => CitrixAdcStore.storeType;

        public Inventory(ILogger<Inventory> logger)
        {
            _logger = logger;
        }

        public JobResult ProcessJob(InventoryJobConfiguration jobConfiguration, SubmitInventoryUpdate submitInventoryUpdate)
        {
            _logger.LogDebug($"Client Machine: {jobConfiguration.CertificateStoreDetails.ClientMachine}");
            _logger.LogDebug($"UseSSL: {jobConfiguration.UseSSL}");
            _logger.LogDebug($"StorePath: {jobConfiguration.CertificateStoreDetails.StorePath}");

            _logger.LogDebug($"Entering ProcessJob");
            CitrixAdcStore store = new CitrixAdcStore(jobConfiguration);

            _logger.LogDebug($"Logging into Citrix...");
            store.login();

            JobResult result = ProcessJob(store, jobConfiguration, submitInventoryUpdate);

            _logger.LogDebug($"Logging out of Citrix...");
            store.logout();

            _logger.LogDebug($"Exiting ProcessJob");

            return result;
        }

        private JobResult ProcessJob(CitrixAdcStore store, InventoryJobConfiguration jobConfiguration, SubmitInventoryUpdate submitInventoryUpdate)
        {
            _logger.LogDebug($"Begin Inventory...");
            
            List<CurrentInventoryItem> inventory = new List<CurrentInventoryItem>();

            try
            {
                _logger.LogDebug($"Getting file list...");
                var files = store.listFiles();

                Dictionary<string, string> existing = jobConfiguration.LastInventory.ToDictionary(i => i.Alias, i => i.Thumbprints.First());
                HashSet<string> processedAliases = new HashSet<string>();

                //union the remote keys + last inventory
                List<String> contentsToCheck = files?.Select(x => x.filename)?.Union(existing.Keys)?.ToList() ?? new List<string>();

                _logger.LogDebug($"Getting KeyPair list...");
                var keyPairList = store.listKeyPairs();
                _logger.LogDebug($"Found {keyPairList.Length} KeyPair results...");

                //create a lookup by cert(alias) for certkey identifier
                Dictionary<string, string> keyPairMap = keyPairList.ToDictionary(i => i.cert, i => i.certkey);

                _logger.LogDebug($"For each file get contents by alias...");
                foreach (string s in contentsToCheck)
                {
                    _logger.LogDebug($"Checking alias (filename): {s}");
                    X509Certificate2 x = store.getX509Certificate(s, out bool privateKeyEntry);

                    if (x == null) continue;

                    processedAliases.Add(s);

                    Dictionary<string,object> parameters = new Dictionary<string, object>();

                    var containsKeyWithPath = keyPairMap.ContainsKey(store.storePath + "/" + s);
                    var containsKey = keyPairMap.ContainsKey(s);

                    if (containsKey || containsKeyWithPath)
                    {

                        string keyPairName = String.Empty;
                        if(containsKeyWithPath)
                        {
                            keyPairName= keyPairMap[store.storePath + "/" + s];
                        }
                        else
                        {
                            keyPairName = keyPairMap[s];
                        }

                        _logger.LogDebug($"Found keyPairName: {keyPairName}");
                        parameters.Add("keyPairName", keyPairName);

                        var binding = store.getBinding(keyPairName);

                        if (binding != null)
                        {
                            var vserver_bindings = binding.sslcertkey_sslvserver_binding;
                            if (vserver_bindings != null) { 
                                var virtualServerName = String.Join(",", vserver_bindings.Select(p=>p.servername));
                                _logger.LogDebug($"Found virtualServerName(s): {virtualServerName}");
                                parameters.Add("virtualServerName", virtualServerName);
                            }
                            //TODO: Other binding methods
                            //binding.sslcertkey_service_binding
                            //binding.sslcertkey_crldistribution_binding
                            //binding.sslcertkey_sslocspresponder_binding
                        }
                    }


                    inventory.Add(new CurrentInventoryItem()
                    {
                        Alias = s,
                        Certificates = new string[] { Convert.ToBase64String(x.GetRawCertData()) },
                        //ItemStatus = itemStatus,
                        PrivateKeyEntry = privateKeyEntry,
                        UseChainLevel = false,
                        Parameters = parameters
                    });
                }
                _logger.LogDebug($"Found {inventory.Count()} certificates at {jobConfiguration.CertificateStoreDetails.StorePath}");


            }
            catch (Exception ex)
            {
                _logger.LogError("Error performing certificate inventory: " + ex.Message);
                _logger.LogDebug(ex.StackTrace);

                //Status: 2=Success, 3=Warning, 4=Error
                return new JobResult()
                {
                    Result = Keyfactor.Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = "Error while performing certificate inventory"
                };
            }

            try
            {
                _logger.LogDebug($"Sending results back to command");
                //Sends inventoried certificates back to KF Command
                submitInventoryUpdate.Invoke(inventory);

                _logger.LogDebug($"Successfully Completed Job");
                //Status: 2=Success, 3=Warning, 4=Error
                return new JobResult()
                {
                    Result = Keyfactor.Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Success,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = ""
                };
            }
            catch (Exception ex)
            {
                _logger.LogError("Error submitting certificate inventory: " + ex.Message);
                _logger.LogDebug(ex.StackTrace);
                // NOTE: if the cause of the submitInventory.Invoke exception is a communication issue between the Orchestrator server and the Command server, the job status returned here
                //  may not be reflected in Keyfactor Command.
                return new JobResult()
                {
                    Result = Keyfactor.Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = "Failure while submitting certificate inventory"
                };
            }
        }
    }
}
