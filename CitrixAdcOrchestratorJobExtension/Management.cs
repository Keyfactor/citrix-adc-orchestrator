using System;
using Keyfactor.Logging;
using Keyfactor.Orchestrators.Common.Enums;
using Keyfactor.Orchestrators.Extensions;
using Keyfactor.Orchestrators.Extensions.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    // ReSharper disable once InconsistentNaming
    public class Management : IManagementJobExtension
    {
        private string _thumbprint = string.Empty;

        private readonly IPAMSecretResolver resolver;

        private ILogger logger;

        private string serverUserName { get; set; }

        private string serverPassword { get; set; }

        public Management(IPAMSecretResolver resolver)
        {
            this.resolver = resolver;
        }

        public string ExtensionName => CitrixAdcStore.StoreType;

        private string ResolvePamField(string name, string value)
        {
            logger.LogTrace($"Attempting to resolved PAM eligible field {name}");
            return resolver.Resolve(value);
        }

        public JobResult ProcessJob(ManagementJobConfiguration jobConfiguration)
        {
            logger = LogHandler.GetClassLogger<Management>();

            serverPassword = ResolvePamField("ServerPassword", jobConfiguration.ServerPassword);
            serverUserName = ResolvePamField("ServerUserName", jobConfiguration.ServerUsername);

            var store = new CitrixAdcStore(jobConfiguration, serverUserName, serverPassword);

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
            string virtualServerName, bool overwrite,bool sniCert)
        {
            logger.LogTrace("Enter performAdd");
            var alias = cert.Alias;
            AddBindCert(store, cert, keyPairName, virtualServerName, overwrite, alias,sniCert);
        }



        private void AddBindCert(CitrixAdcStore store, ManagementJobCertificate cert, string keyPairName,
            string virtualServerName, bool overwrite, string alias,bool sniCert)
        {
            var (pemFile, privateKeyFile) =
                store.UploadCertificate(cert.Contents, cert.PrivateKeyPassword, alias, overwrite);

            logger.LogDebug("Updating keyPair");
            //update KeyPair
            keyPairName = store.UpdateKeyPair(alias, keyPairName, pemFile, privateKeyFile);

            logger.LogDebug("Updating cert bindings");
            //update cert bindings
            store.UpdateBindings(keyPairName, virtualServerName,sniCert);
        }

        private void PerformDelete(CitrixAdcStore store, ManagementJobCertificate cert)
        {
            logger.LogTrace("Enter PerformDelete");
            var sslKeyFile = store.GetKeyPairByName(cert.Alias);

            //1. Delete the Keypair
            store.DeleteKeyPair(sslKeyFile);

            //2. Remove directory from file name, Delete the Key File
            store.DeleteFile(Path.GetFileName(sslKeyFile.key));

            //3. Remove directory from file name, Delete the Certificate File
            store.DeleteFile(Path.GetFileName(sslKeyFile.cert));

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
                        var dup = store.IsDuplicateCertificate(jobConfiguration.JobCertificate.Alias);
                        if ((dup && jobConfiguration.Overwrite) || !dup || (jobConfiguration.JobProperties.ContainsKey("RenewalThumbprint")))
                        {
                            logger.LogDebug("Begin Add...");
                            var virtualServerName = (string)jobConfiguration.JobProperties["virtualServerName"];
                            var sniCert = (bool) jobConfiguration.JobProperties["sniCert"];

                            //Check if Keypair name exists, if so, we need to append something to it so we don't get downtime
                            var keyPairName = jobConfiguration.JobCertificate.Alias;

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
                                    jobConfiguration.Overwrite, sniCert);
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
                                                logger.LogTrace(
                                                    $"Starting PerformAdd Binding Name: {sBinding.servername} kp.certkey: {kp.certkey}");
                                                PerformAdd(store, jobConfiguration.JobCertificate, kp.certkey,
                                                    sBinding.servername, true,sniCert);
                                                logger.LogTrace(
                                                    $"Finished PerformAdd Binding Name: {sBinding.servername} kp.certkey: {kp.certkey}");
                                            }
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