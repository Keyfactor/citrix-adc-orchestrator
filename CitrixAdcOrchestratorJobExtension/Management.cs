using System;
using Keyfactor.Orchestrators.Extensions;
using Microsoft.Extensions.Logging;
using Keyfactor.Orchestrators.Common.Enums;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{

    //private ILogger _logger { get; }

    public class Management : IManagementJobExtension
    {
        private ILogger _logger { get; }
        public string ExtensionName => CitrixAdcStore.storeType;

        private string _thumbprint = string.Empty;

        public Management(ILogger<Management> logger)
        {
            _logger = logger;
        }

        private void performAdd(CitrixAdcStore store, ManagementJobCertificate cert, string keyPairName, string virtualServerName, bool overwrite)
        {
            _logger.LogTrace($"Enter performAdd");

            var alias = Guid.NewGuid().ToString();
            (var pemFile, var privateKeyFile) = store.uploadCertificate(cert.Contents, cert.PrivateKeyPassword, alias, overwrite);

            _logger.LogDebug($"Updating keyPair");
            //update keypair
            keyPairName = store.updateKeyPair(alias, keyPairName, pemFile, privateKeyFile);

            _logger.LogDebug($"Updating cert bindings");
            //update cert bindings
            store.updateBindings(keyPairName, virtualServerName);
        }

        private void performDelete(CitrixAdcStore store, ManagementJobCertificate cert)
        {           
            store.deleteFile(cert.Contents, cert.Alias);
        }

        public JobResult ProcessJob(ManagementJobConfiguration jobConfiguration)
        {
            CitrixAdcStore store = new CitrixAdcStore(jobConfiguration);
            _logger.LogDebug($"Logging into Citrix...");
            store.login();

            _logger.LogDebug($"Entering ProcessJob");
            JobResult result = ProcessJob(store, jobConfiguration);

            _logger.LogDebug($"Logging out of Citrix...");
            store.logout();

            _logger.LogDebug($"Exiting ProcessJob");

            return result;
        }

        private JobResult ProcessJob(CitrixAdcStore store, ManagementJobConfiguration jobConfiguration)
        {
            _logger.LogDebug($"Begin Management...");

            try
            {
                //Management jobs, unlike Discovery, Inventory, and Reenrollment jobs can have 3 different purposes:
                switch (jobConfiguration.OperationType)
                {
                    case CertStoreOperationType.Add:
                        string virtualServerName = (string)jobConfiguration.JobProperties["virtualServerName"];
                        string keyPairName = (string)jobConfiguration.JobProperties["keyPairName"];
                        if (jobConfiguration.JobProperties.ContainsKey("RenewalThumbprint"))
                        {
                            _thumbprint = jobConfiguration.JobProperties["RenewalThumbprint"].ToString();
                        }
                        //if there is no thumbprint from Keyfactor then it is an Add, else it is a renewal
                        if (string.IsNullOrEmpty(_thumbprint))
                        {
                            performAdd(store, jobConfiguration.JobCertificate, keyPairName, virtualServerName,
                                jobConfiguration.Overwrite);
                        }
                        else
                        {
                            //PerformRenewal
                            //1. Get All Keys /config/sslcertkey store.ListKeyPairs()
                            var keyPairList = store.listKeyPairs();
                            //2. For Each check the binding /config/sslcertkey_binding store.GetBinding(strKey)
                            foreach (var kp in keyPairList)
                            {
                                var binding = store.getBinding(kp.certkey);
                                if (binding != null)
                                {
                                    //4. Open the file and check the thumbprint
                                    var x = store.getX509Certificate(kp.cert.Substring(kp.cert.LastIndexOf("/")+1), out bool privateKeyEntry);
                                    //5. If the Thumbprint matches the cert renewed from KF then PerformAdd With Overwrite 
                                    if (x?.Thumbprint == _thumbprint)
                                    {
                                        foreach (var sBinding in binding.sslcertkey_sslvserver_binding)
                                        {
                                            performAdd(store, jobConfiguration.JobCertificate, kp.certkey, sBinding.servername, true);
                                        }
                                    }
                                }

                            }
                        }
                        break;
                    case CertStoreOperationType.Remove:
                        performDelete(store, jobConfiguration.JobCertificate);
                        break;
                    case CertStoreOperationType.Create:
                        // The certificate store is the directory
                        break;
                    default:
                        //Invalid OperationType.  Return error.  Should never happen though
                        return new JobResult()
                        {
                            Result = Keyfactor.Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Failure,
                            JobHistoryId = jobConfiguration.JobHistoryId,
                            FailureMessage = $"Site {jobConfiguration.CertificateStoreDetails.StorePath} on server {jobConfiguration.CertificateStoreDetails.ClientMachine}: Unsupported operation: {jobConfiguration.OperationType.ToString()}"
                        };
                }
            }
            catch (Exception ex)
            {
                //Status: 2=Success, 3=Warning, 4=Error
                return new JobResult()
                {
                    Result = Keyfactor.Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Failure,
                    JobHistoryId = jobConfiguration.JobHistoryId,
                    FailureMessage = ex.Message
                };
            }

            return new JobResult()
            {
                Result = Keyfactor.Orchestrators.Common.Enums.OrchestratorJobStatusJobResult.Success,
                JobHistoryId = jobConfiguration.JobHistoryId,
                FailureMessage = ""
            };
        }
    }
}
