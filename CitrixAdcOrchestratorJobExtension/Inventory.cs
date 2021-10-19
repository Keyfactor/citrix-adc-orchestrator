using Keyfactor.Orchestrators.Extensions;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    public class inventory : IInventoryJobExtension
    {
        private ILogger logger { get; }

        public string ExtensionName => citrixAdcStore.StoreType;

        public inventory(ILogger<inventory> logger)
        {
            this.logger = logger;
        }

        public JobResult ProcessJob(InventoryJobConfiguration jobConfiguration, SubmitInventoryUpdate submitInventoryUpdate)
        {
            logger.LogDebug($"Client Machine: {jobConfiguration.CertificateStoreDetails.ClientMachine}");
            logger.LogDebug($"UseSSL: {jobConfiguration.UseSSL}");
            logger.LogDebug($"StorePath: {jobConfiguration.CertificateStoreDetails.StorePath}");

            logger.LogDebug("Entering ProcessJob");
            citrixAdcStore store = new citrixAdcStore(jobConfiguration);

            logger.LogDebug("Logging into Citrix...");
            store.Login();

            JobResult result = ProcessJob(store, jobConfiguration, submitInventoryUpdate);

            logger.LogDebug("Logging out of Citrix...");
            store.Logout();

            logger.LogDebug("Exiting ProcessJob");

            return result;
        }

        private JobResult ProcessJob(citrixAdcStore store, InventoryJobConfiguration jobConfiguration, SubmitInventoryUpdate submitInventoryUpdate)
        {
            logger.LogDebug("Begin Inventory...");
            
            List<CurrentInventoryItem> inventory = new List<CurrentInventoryItem>();

            try
            {
                logger.LogDebug("Getting file list...");
                var files = store.ListFiles();

                Dictionary<string, string> existing = jobConfiguration.LastInventory.ToDictionary(i => i.Alias, i => i.Thumbprints.First());
                // ReSharper disable once CollectionNeverQueried.Local
                HashSet<string> processedAliases = new HashSet<string>();

                //union the remote keys + last inventory
                List<String> contentsToCheck = files?.Select(x => x.filename).Union(existing.Keys).ToList() ?? new List<string>();

                logger.LogDebug("Getting KeyPair list...");
                var keyPairList = store.ListKeyPairs();
                logger.LogDebug($"Found {keyPairList.Length} KeyPair results...");

                //create a lookup by cert(alias) for certkey identifier
                Dictionary<string, string> keyPairMap = keyPairList.ToDictionary(i => i.cert, i => i.certkey);

                logger.LogDebug("For each file get contents by alias...");
                foreach (string s in contentsToCheck)
                {
                    logger.LogDebug($"Checking alias (filename): {s}");
                    X509Certificate2 x = store.GetX509Certificate(s, out bool privateKeyEntry);

                    if (x == null) continue;

                    processedAliases.Add(s);

                    Dictionary<string,object> parameters = new Dictionary<string, object>();

                    var containsKeyWithPath = keyPairMap.ContainsKey(store.storePath + "/" + s);
                    var containsKey = keyPairMap.ContainsKey(s);

                    if (containsKey || containsKeyWithPath)
                    {
                        var keyPairName = containsKeyWithPath ? keyPairMap[store.storePath + "/" + s] : keyPairMap[s];

                        logger.LogDebug($"Found keyPairName: {keyPairName}");
                        parameters.Add("keyPairName", keyPairName);

                        var binding = store.GetBinding(keyPairName);

                        var vserverBindings = binding?.sslcertkey_sslvserver_binding;
                        if (vserverBindings != null) { 
                            var virtualServerName = String.Join(",", vserverBindings.Select(p=>p.servername));
                            logger.LogDebug($"Found virtualServerName(s): {virtualServerName}");
                            parameters.Add("virtualServerName", virtualServerName);
                        }
                        //TODO: Other binding methods
                        //binding.sslcertkey_service_binding
                        //binding.sslcertkey_crldistribution_binding
                        //binding.sslcertkey_sslocspresponder_binding
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
                logger.LogDebug($"Found {inventory.Count} certificates at {jobConfiguration.CertificateStoreDetails.StorePath}");


            }
            catch (Exception ex)
            {
                logger.LogError("Error performing certificate inventory: " + ex.Message);
                logger.LogDebug(ex.StackTrace);

                //Status: 2=Success, 3=Warning, 4=Error
                return new JobResult()
                {
                    Result = Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = "Error while performing certificate inventory"
                };
            }

            try
            {
                logger.LogDebug("Sending results back to command");
                //Sends inventoried certificates back to KF Command
                submitInventoryUpdate.Invoke(inventory);

                logger.LogDebug("Successfully Completed Job");
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
                logger.LogError("Error submitting certificate inventory: " + ex.Message);
                logger.LogDebug(ex.StackTrace);
                // NOTE: if the cause of the submitInventory.Invoke exception is a communication issue between the Orchestrator server and the Command server, the job status returned here
                //  may not be reflected in Keyfactor Command.
                return new JobResult()
                {
                    Result = Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = "Failure while submitting certificate inventory"
                };
            }
        }
    }
}
