using System;
using Keyfactor.Orchestrators.Common.Enums;
using Keyfactor.Orchestrators.Extensions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    // ReSharper disable once InconsistentNaming
    public class Management : IManagementJobExtension
    {
        private string _thumbprint = string.Empty;

        public Management(ILogger<Management> logger)
        {
            this.logger = logger;
        }

        private ILogger logger { get; }
        public string ExtensionName => CitrixAdcStore.StoreType;

        public JobResult ProcessJob(ManagementJobConfiguration jobConfiguration)
        {
            var store = new CitrixAdcStore(jobConfiguration);
            logger.LogDebug("Logging into Citrix...");
            store.Login();

            logger.LogDebug("Entering ProcessJob");
            var result = ProcessJob(store, jobConfiguration);

            logger.LogDebug("Logging out of Citrix...");
            store.Logout();

            logger.LogDebug("Exiting ProcessJob");

            return result;
        }

        private void PerformAdd(CitrixAdcStore store, ManagementJobCertificate cert, string keyPairName,
            string virtualServerName, bool overwrite)
        {
            logger.LogTrace("Enter performAdd");

            var alias = Guid.NewGuid().ToString();
            var (pemFile, privateKeyFile) =
                store.UploadCertificate(cert.Contents, cert.PrivateKeyPassword, alias, overwrite);

            logger.LogDebug("Updating keyPair");
            //update KeyPair
            keyPairName = store.UpdateKeyPair(alias, keyPairName, pemFile, privateKeyFile);

            logger.LogDebug("Updating cert bindings");
            //update cert bindings
            store.UpdateBindings(keyPairName, virtualServerName);
        }

        private void PerformDelete(CitrixAdcStore store, ManagementJobCertificate cert)
        {
            logger.LogTrace("Enter PerformDelete");
            store.DeleteFile(cert.Contents, cert.Alias);
            logger.LogTrace("Exit PerformDelete");
        }

        private JobResult ProcessJob(CitrixAdcStore store, ManagementJobConfiguration jobConfiguration)
        {
            logger.LogDebug("Begin Management...");

            try
            {
                //Management jobs, unlike Discovery, Inventory, and ReEnrollment jobs can have 3 different purposes:
                switch (jobConfiguration.OperationType)
                {
                    case CertStoreOperationType.Add:
                        logger.LogDebug("Begin Add...");
                        var virtualServerName = (string) jobConfiguration.JobProperties["virtualServerName"];
                        var keyPairName = (string) jobConfiguration.JobProperties["keyPairName"];
                        logger.LogTrace($"keyPairName: {keyPairName} virtualServerName {virtualServerName}");
                        if (jobConfiguration.JobProperties.ContainsKey("RenewalThumbprint"))
                        {
                            _thumbprint = jobConfiguration.JobProperties["RenewalThumbprint"].ToString();
                            logger.LogDebug($"It's a renewal with thumbprint {_thumbprint}");
                        }

                        //if there is no thumbprint from Keyfactor then it is an Add, else it is a renewal
                        if (string.IsNullOrEmpty(_thumbprint))
                        {
                            logger.LogDebug($"Begin Add/Enrollment... overwrite: {jobConfiguration.Overwrite}");
                            PerformAdd(store, jobConfiguration.JobCertificate, keyPairName, virtualServerName,
                                jobConfiguration.Overwrite);
                            logger.LogDebug("End Add/Enrollment...");
                        }
                        else
                        {
                            //PerformRenewal
                            //1. Get All Keys /config/sslcertkey store.ListKeyPairs()
                            var keyPairList = store.ListKeyPairs();

                            logger.LogTrace($"KeyPairList: {JsonConvert.SerializeObject(keyPairList)}");

                            //2. For Each check the binding /config/sslcertkey_binding store.GetBinding(strKey)
                            foreach (var kp in keyPairList)
                            {
                                var binding = store.GetBinding(kp.certkey);
                                logger.LogTrace($"binding: {JsonConvert.SerializeObject(binding)}");
                                if (binding != null)
                                {
                                    //4. Open the file and check the thumbprint
                                    var x = store.GetX509Certificate(
                                        kp.cert.Substring(kp.cert.LastIndexOf("/", StringComparison.Ordinal) + 1),
                                        out _);
                                    //5. If the Thumbprint matches the cert renewed from KF then PerformAdd With Overwrite 
                                    if (x?.Thumbprint == _thumbprint)
                                    {
                                        logger.LogTrace($"Thumbprint Match: {_thumbprint}");
                                        foreach (var sBinding in binding.sslcertkey_sslvserver_binding)
                                        {
                                            logger.LogTrace($"Starting PerformAdd Binding Name: {sBinding.servername} kp.certkey: {kp.certkey}");
                                            PerformAdd(store, jobConfiguration.JobCertificate, kp.certkey,
                                                sBinding.servername, true);
                                            logger.LogTrace($"Finished PerformAdd Binding Name: {sBinding.servername} kp.certkey: {kp.certkey}");
                                        }
                                    }
                                }
                            }
                        }

                        break;
                    case CertStoreOperationType.Remove:
                        logger.LogDebug("Begin Delete...");
                        PerformDelete(store, jobConfiguration.JobCertificate);
                        logger.LogDebug("End Delete...");
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