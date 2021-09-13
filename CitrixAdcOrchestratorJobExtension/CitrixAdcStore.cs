using System;
using System.IO;
using System.Text;
using Keyfactor.Orchestrators.Extensions;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.resource.Base;

using Microsoft.Extensions.Logging;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;

using System.Linq;


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.config.ssl;
using com.citrix.netscaler.nitro.resource.config.system;

using System.Security.Cryptography.X509Certificates;
using com.citrix.netscaler.nitro.util;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    class CitrixAdcStore
    {
        public static readonly string storeType = "CitrixAdc";
        private ILogger _logger { get; }

        private string clientMachine;
        private bool useSsl;
        private string username;
        private string password;
        private uint timeout = 3600;
        private string storePath;

        private nitro_service nss;

        public CitrixAdcStore(InventoryJobConfiguration config) : this((JobConfiguration)config)
        {
            this.clientMachine = config.CertificateStoreDetails.ClientMachine;
            this.storePath = config.CertificateStoreDetails.StorePath;
        }

        public CitrixAdcStore(ManagementJobConfiguration config) : this((JobConfiguration)config)
        {
            this.clientMachine = config.CertificateStoreDetails.ClientMachine;
            this.storePath = config.CertificateStoreDetails.StorePath;
        }

        private CitrixAdcStore(JobConfiguration config)
        {
            this.useSsl = config.UseSSL;
            this.username = config.ServerUsername;
            this.password = config.ServerPassword;
        }
        public void login()
        {
            if (this.nss == null)
            {
                nss = new nitro_service(this.clientMachine, this.useSsl ? "https" : "http");
            }
            var response = nss.login(this.username, this.password, this.timeout);
            if (response.errorcode > 0)
            {
                throw new Exception(response.message);
            }

        }

        public void logout()
        {
            //base_response resp =
            nss.logout();

            //TODO: process resp
        }

        public X509Certificate2[] list()
        {
            //options o = new options();
            //String urlPath = HttpUtility.UrlEncode(config.Store.StorePath);
            //o.set_args($"filelocation:{urlPath}");
            //systemfile[] files = systemfile.get(nss, o);

            //X509Certificate2 x = getX509Certificate(nss, s, o, out privateKeyEntry);
            return null;
        }
        public (systemfile pemFile, systemfile privateKeyFile) uploadCertificate(string contents, string password, string alias, bool overwrite)
        {
            (systemfile pemFile, systemfile privateKeyFile) = getPem(contents, password, alias);

            //upload certificate
            uploadFile(pemFile, $"{this.storePath}/{alias}", overwrite);

            //upload private key
            if (privateKeyFile != null)
            {
                _logger.LogTrace($"Uploading Private Key");

                //we default overwrite private key as certificate upload has already succeeded and this file needs to be in sync
                uploadFile(privateKeyFile, $"{this.storePath}/{alias}.key", true);
            }

            return (pemFile, privateKeyFile);
        }

        private void uploadFile(systemfile f, string location, bool overwrite)
        {
            _logger.LogTrace($"Enter uploadFile");
            base_response b;
            try
            {
                _logger.LogTrace($"Adding file at {location}");
                b = systemfile.add(nss, f);
            }
            catch (nitro_exception ne)
            {
                if ((ne.HResult.Equals(0x80131500) || ne.Message.Contains("File already exists"))
                    && overwrite)
                {
                    systemfile fOld = new systemfile();
                    fOld.filename = f.filename;
                    fOld.filelocation = f.filelocation;
                    systemfile.delete(nss, fOld);
                    systemfile.add(nss, f);
                    _logger.LogTrace($"Overwrote file at {location}");
                }

                //else if (!String.IsNullOrWhiteSpace(JobConfigInfo.vserver))
                //{
                //    _logger.LogDebug($"Certificate was already present on file system; attempting to add to virtual server {JobConfigInfo.vserver}");
                //}
                else throw;
            }
        }

        public base_response deleteFile(string contents, string alias)
        {
            systemfile f = new systemfile();
            f.filecontent = contents;
            f.filename = alias;
            f.filelocation = this.storePath;
            return deleteFile(f);
        }

        private base_response deleteFile(systemfile f)
        {
            try
            {
                _logger.LogTrace($"Deleting certificate at {f.filelocation}/{f.filename}");
                return systemfile.delete(this.nss, f);
            }
            catch (Exception e)
            {
                _logger.LogError("Error removing file: " + e.Message);
                _logger.LogDebug(e.StackTrace);
                throw;
            }
        }

        private string updateKeyPair(nitro_service nss, string keyPairName, string certPath, string keyPath)
        {
            try
            {
                filtervalue[] filters = new filtervalue[1];
                filters[0] = new filtervalue("certKey", keyPairName);
                _logger.LogTrace("Checking " + storeType + $" to see if existing certificate-key pair exists with name {keyPairName}");
                uint count = sslcertkey.count_filtered(nss, filters);

                _logger.LogTrace($"Count of certkey with {keyPairName}: {count}");

                if (count > 0)
                {
                    //sslcertkey result = sslcertkey.get(nss, keyPairName);

                    sslcertkey result = new sslcertkey();
                    result.certkey = keyPairName;

                    keyPath = certPath + ".key";

                    //Existing keypair exists
                    result.cert = certPath;
                    if (keyPath != null)
                    {
                        result.key = keyPath;
                    }
                    result.inform = "PEM";
                    result.nodomaincheck = true;

                    _logger.LogTrace("Updating " + storeType + $" certificate-key pair with name {keyPairName}");
                    base_response response = sslcertkey.change(nss, result);
                }
                else
                {
                    sslcertkey s = new sslcertkey();
                    s.certkey = keyPairName;
                    s.cert = certPath;
                    if (keyPath != null)
                    {
                        s.key = keyPath;
                        s.password = false;
                        s.passplain = "0";  // Unused, but required, dummy variable
                    }
                    _logger.LogTrace("Adding " + storeType + $" certificate-key pair with name {keyPairName}");
                    sslcertkey.add(nss, s);
                }
            }
            catch (nitro_exception ne)
            {
                
                _logger.LogWarning($"Exception occured while trying to add or update {keyPairName}");
                if ((((UInt32)ne.HResult).Equals(0x80138500) || ((UInt32)ne.HResult).Equals(0x80131500)) && ne.Message.Contains("Resource already exists"))
                {
                    if (ne.Message.Contains("certkeyName Contents,"))
                    {
                        int start = ne.Message.IndexOf("Contents, ") + "Contents, ".Length;
                        int end = ne.Message.IndexOf(']', start);
                        keyPairName = ne.Message.Substring(start, end - start);
                        _logger.LogWarning("Certificate keypair already existed on " + storeType + " as " + keyPairName);
                    }
                    else
                    {
                        _logger.LogWarning("Certificate keypair already existed on " + storeType);
                    }
                }
                else throw;
            }

            return keyPairName;
        }

        public string updateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey)
        {
            _logger.LogTrace($"Enter updateKeyPair");
            //Dictionary<string, string> jobProperties = JsonConvert.DeserializeObject<Dictionary<string, string>>((string)config.Job.Properties);

            if (String.IsNullOrWhiteSpace(keyPairName))
            {
                // If keyPairName is not specified then create one based upon the alias and serial number
                X509Certificate2 cert = new X509Certificate2(Convert.FromBase64String(pemFile.filecontent));
                keyPairName = (alias.Substring(0, Math.Min(22, alias.Length))
                            + "-" + new String(cert.SerialNumber.ToString().Reverse().ToArray()));
                keyPairName = keyPairName.Substring(0, Math.Min(31, keyPairName.Length));
            }

            string certPath = this.storePath + "/" + alias;
            string keyPath = null;
            if (privateKey != null)
            {
                keyPath = this.storePath + "/" + alias + ".key";
            }

            return updateKeyPair(nss, keyPairName, certPath, keyPath);
        }

        public void updateBindings(string keyPairName, string virtualServerName)
        {
            _logger.LogTrace($"Enter updateBindings");

            if (!String.IsNullOrWhiteSpace(virtualServerName))
            {
                _logger.LogTrace($"Updating bindings for {virtualServerName}");
                base_response b = null;
                //bind key-pair to vserver
                sslvserver_sslcertkey_binding ssb = new sslvserver_sslcertkey_binding();
                ssb.certkeyname = keyPairName;
                ssb.vservername = virtualServerName;
                _logger.LogDebug($"Adding binding {keyPairName} for virtual server {virtualServerName}");
                b = sslvserver_sslcertkey_binding.add(nss, ssb);
            }
        }

        private (byte[], byte[]) GetPemFromPFX(byte[] pfxBytes, char[] pfxPassword)
        {
            Pkcs12Store p = new Pkcs12Store(new MemoryStream(pfxBytes), pfxPassword);

            // Extract private key
            MemoryStream memoryStream = new MemoryStream();
            TextWriter streamWriter = new StreamWriter(memoryStream);
            PemWriter pemWriter = new PemWriter(streamWriter);

            String alias = (p.Aliases.Cast<String>()).SingleOrDefault(a => p.IsKeyEntry(a));
            AsymmetricKeyParameter publicKey = p.GetCertificate(alias).Certificate.GetPublicKey();
            if (p.GetKey(alias) == null) { throw new Exception($"Unable to get the key for alias: {alias}"); }
            AsymmetricKeyParameter privateKey = p.GetKey(alias).Key;
            AsymmetricCipherKeyPair keyPair = new AsymmetricCipherKeyPair(publicKey, privateKey);

            pemWriter.WriteObject(keyPair.Private);
            streamWriter.Flush();
            String privateKeyString = Encoding.ASCII.GetString(memoryStream.GetBuffer()).Trim().Replace("\r", "").Replace("\0", "");
            memoryStream.Close();
            streamWriter.Close();

            // Extract server certificate
            String certStart = "-----BEGIN CERTIFICATE-----\n";
            String certEnd = "\n-----END CERTIFICATE-----";
            Func<String, String> pemify = null;
            pemify = (ss => ss.Length <= 64 ? ss : ss.Substring(0, 64) + "\n" + pemify(ss.Substring(64)));
            String certPem = certStart + pemify(Convert.ToBase64String(p.GetCertificate(alias).Certificate.GetEncoded())) + certEnd;
            return (Encoding.ASCII.GetBytes(certPem), Encoding.ASCII.GetBytes(privateKeyString));
        }

        private (systemfile, systemfile) getPem(string contents, string password, string alias)
        {

            systemfile pemFile = new systemfile();
            systemfile privateKeyFile = null;

            if (!String.IsNullOrWhiteSpace(password)) // PFX Entry
            {
                // Load PFX
                byte[] pfxBytes = Convert.FromBase64String(contents);
                (byte[] certPem, byte[] privateKey) = GetPemFromPFX(pfxBytes, password.ToCharArray());

                // create private key file
                privateKeyFile = new systemfile();
                privateKeyFile.filecontent = Convert.ToBase64String(privateKey);
                privateKeyFile.filename = alias + ".key";
                privateKeyFile.filelocation = this.storePath;

                // set pem file from cert in pfx
                pemFile.filecontent = Convert.ToBase64String(certPem);
            }
            else
            {
                pemFile.filecontent = contents;
            }
            pemFile.filename = alias;
            pemFile.filelocation = this.storePath;

            return (pemFile, privateKeyFile);
        }
    }
}
