using Keyfactor.Orchestrators.Extensions;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.resource.config.system;
using com.citrix.netscaler.nitro.service;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    public class Inventory : IInventoryJobExtension
    {
        private ILogger _logger { get; }
        public string ExtensionName => CitrixAdcStore.storeType;


        public JobResult ProcessJob(InventoryJobConfiguration jobConfiguration, SubmitInventoryUpdate submitInventoryUpdate)
        {
            CitrixAdcStore store = new CitrixAdcStore(jobConfiguration);

            store.login();

            JobResult result = ProcessJob(store, jobConfiguration, submitInventoryUpdate);

            store.logout();

            return result;
        }

        private JobResult ProcessJob(CitrixAdcStore store, InventoryJobConfiguration jobConfiguration, SubmitInventoryUpdate submitInventoryUpdate)
        {
            _logger.LogDebug($"Begin Inventory...");
            
            List<CurrentInventoryItem> inventory = new List<CurrentInventoryItem>();

            try
            {
                // 2) Custom logic to retrieve certificates from certificate store.

                // Retrieve fileNAMEs from directory
                options o = new options();
                String urlPath = HttpUtility.UrlEncode(config.Store.StorePath);
                o.set_args($"filelocation:{urlPath}");
                systemfile[] files = systemfile.get(nss, o);
                Logger.Trace($"Found {files?.Count() ?? 0} files at {config.Store.StorePath}");

                Dictionary<string, string> extant = config.Store.Inventory.ToDictionary(i => i.Alias, i => i.Thumbprints[0]);
                HashSet<string> processedAliases = new HashSet<string>();

                // NetScaler API sometimes returns incomplete contents, so we want to make sure the previous inventory items 
                // are still checked in that case.
                List<String> contentsToCheck = files?.Select(x => x.filename)?.Union(extant.Keys)?.ToList() ?? new List<string>();

                // Get file contents 1-by-1
                foreach (string s in contentsToCheck)
                {
                    bool privateKeyEntry = false;
                    X509Certificate2 x = getX509Certificate(nss, s, o, out privateKeyEntry);

                    if (x == null) continue;

                    // Record inventory
                    AgentInventoryItemStatus aiis = extant.ContainsKey(s)
                                                    ? extant[s].Equals(x.Thumbprint, StringComparison.OrdinalIgnoreCase)
                                                        ? AgentInventoryItemStatus.Unchanged
                                                        : AgentInventoryItemStatus.Modified
                                                    : AgentInventoryItemStatus.New;
                    processedAliases.Add(s);
                    inventoryItems.Add(new AgentCertStoreInventoryItem()
                    {
                        Alias = s,
                        Certificates = new string[] { Convert.ToBase64String(x.GetRawCertData()) },
                        ItemStatus = aiis,
                        PrivateKeyEntry = privateKeyEntry,
                        UseChainLevel = false
                    });
                }
                Logger.Debug($"Found {inventoryItems.Count()} certificates at {config.Store.StorePath}");
                try
                {
                    resp = nss.logout();
                }
                catch
                {
                    Logger.Debug("Failed logout of " + GetStoreType() + " device");
                }
                // Identify previously inventoried certs that are now absent from directory
                foreach (string s in extant.Keys.Except(processedAliases))
                {
                    inventoryItems.Add(new AgentCertStoreInventoryItem()
                    {
                        Alias = s,
                        ItemStatus = AgentInventoryItemStatus.Deleted
                    });
                }


                // 3) Add certificates (no private keys) to the collection below.  If multiple certs in a store comprise a chain, the Certificates array will house multiple certs per InventoryItem.  If multiple certs
                //     in a store comprise separate unrelated certs, there will be one InventoryItem object created per certificate.

                //inventoryItems.Add(new AgentCertStoreInventoryItem()
                //{
                //    ItemStatus = AgentInventoryItemStatus.Unknown, //There are other statuses, but I always use this and let KF command figure out the actual status
                //    Alias = {valueRepresentingChainIdentifier}
                //    PrivateKeyEntry = true|false //You will not pass the private key back, but you can identify if the main certificate of the chain contains a private key
                //    UseChainLevel = true|false,  //true if Certificates will contain > 1 certificate, main cert => intermediate CA cert => root CA cert.  false if Certificates will contain an array of 1 certificate
                //    Certificates = //Array of single X509 certificates in Base64 string format (certificates if chain, single cert if not), something like:
                //    ****************************
                //          foreach(X509Certificate2 certificate in certificates)
                //              certList.Add(Convert.ToBase64String(certificate.Export(X509ContentType.Cert)));
                //              certList.ToArray();
                //    ****************************
                //});

            }
            catch (Exception ex)
            {
                Logger.Error("Error performing certificate inventory: " + ex.Message);
                Logger.Debug(ex.StackTrace);
                //Status: 2=Success, 3=Warning, 4=Error
                return new AnyJobCompleteInfo() { Status = 4, Message = ex.StackTrace };
            }

            try
            {
                //Sends inventoried certificates back to KF Command
                submitInventory.Invoke(inventoryItems);
                //Status: 2=Success, 3=Warning, 4=Error
                return new AnyJobCompleteInfo() { Status = 2, Message = "Successful" };
            }
            catch (Exception ex)
            {
                Logger.Error("Error submitting certificate inventory: " + ex.Message);
                Logger.Debug(ex.StackTrace);
                // NOTE: if the cause of the submitInventory.Invoke exception is a communication issue between the Orchestrator server and the Command server, the job status returned here
                //  may not be reflected in Keyfactor Command.
                return new AnyJobCompleteInfo() { Status = 4, Message = "Custom message you want to show to show up as the error message in Job History in KF Command" };
            }


            submitInventoryUpdate.Invoke(inventory);

            return new JobResult()
            {
                Result = Keyfactor.Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Success,
                JobHistoryId = jobConfiguration.JobHistoryId,
                FailureMessage = ""
            };
        }
    }
}
