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
                        //var keyPairName = Guid.NewGuid().ToString();
                        performAdd(store, jobConfiguration.JobCertificate, keyPairName, virtualServerName, jobConfiguration.Overwrite);
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
