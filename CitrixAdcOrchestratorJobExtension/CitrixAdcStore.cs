using System;
using System.IO;
using System.Text;
using System.Web;

using Keyfactor.Orchestrators.Extensions;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.resource.Base;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
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
        
        //private ILogger //_logger { get; }

        private readonly string clientMachine;
        private readonly bool useSsl;
        private readonly string username;
        private readonly string password;
        private readonly uint timeout = 3600;
        public readonly string storePath;

        private nitro_service nss;

        private readonly options nitro_service_options; 

        public CitrixAdcStore(InventoryJobConfiguration config) : this((JobConfiguration)config)
        {
            this.clientMachine = config.CertificateStoreDetails.ClientMachine;
            this.storePath = config.CertificateStoreDetails.StorePath;

            options o = new options();
            String urlPath = HttpUtility.UrlEncode(this.storePath);
            o.set_args($"filelocation:{urlPath}");

            this.nitro_service_options = o;
        }

        public CitrixAdcStore(ManagementJobConfiguration config) : this((JobConfiguration)config)
        {
            this.clientMachine = config.CertificateStoreDetails.ClientMachine;
            this.storePath = config.CertificateStoreDetails.StorePath;

            options o = new options();
            String urlPath = HttpUtility.UrlEncode(this.storePath);
            o.set_args($"filelocation:{urlPath}");

            this.nitro_service_options = o;
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
                
                //12.0
                //nss.set_certvalidation = false;
                //nss.set_hostnameverification = false;
            }
            base_response response = null;
            try
            {
                response = nss.login(this.username, this.password, this.timeout);
            }
            catch (Exception ex)
            {
                throw new Exception("Error logging in to CitrixAdc Device", ex);
            } finally
            {
                //(baseResponse.errorcode == 0 || baseResponse.errorcode == 1034)
                if (response!=null && !nss.isLogin())
                {
                    throw new Exception(response.message);
                }
            }
        }

        public bool logout()
        {
            //base_response resp =
            try {
                nss.logout();
                //TODO: process resp
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
            
        }

        public sslcertkey_binding getBinding(string certKey)
        {
            try { 
                return sslcertkey_binding.get(nss, certKey);
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public sslcertkey[] listKeyPairs()
        {
            return sslcertkey.get(nss);
        }

        public systemfile[] listFiles()
        {
            return systemfile.get(nss, this.nitro_service_options);
        }

        public (systemfile pemFile, systemfile privateKeyFile) uploadCertificate(string contents, string password, string alias, bool overwrite)
        {
            (systemfile pemFile, systemfile privateKeyFile) = getPem(contents, password, alias);

            //upload certificate
            uploadFile(pemFile, $"{this.storePath}/{alias}", overwrite);

            //upload private key
            if (privateKeyFile != null)
            {
                //_logger.LogTrace($"Uploading Private Key");

                //we default overwrite private key as certificate upload has already succeeded and this file needs to be in sync
                uploadFile(privateKeyFile, $"{this.storePath}/{alias}.key", true);
            }

            return (pemFile, privateKeyFile);
        }

        private void uploadFile(systemfile f, string location, bool overwrite)
        {
            //_logger.LogTrace($"Enter uploadFile");
            base_response b;
            try
            {
                //_logger.LogTrace($"Adding file at {location}");
                b = systemfile.add(nss, f);
            }
            catch (nitro_exception ne)
            {
                if ((ne.HResult.Equals(0x80131500) || ne.Message.Contains("File already exists"))
                    && overwrite)
                {
                    systemfile fOld = new systemfile()
                    {
                        filename = f.filename,
                        filelocation = f.filelocation
                    };
                    systemfile.delete(nss, fOld);
                    systemfile.add(nss, f);
                    //_logger.LogTrace($"Overwrote file at {location}");
                }

                //else if (!String.IsNullOrWhiteSpace(JobConfigInfo.vserver))
                //{
                //    //_logger.LogDebug($"Certificate was already present on file system; attempting to add to virtual server {JobConfigInfo.vserver}");
                //}
                else throw;
            }
        }

        public base_response deleteFile(string contents, string alias)
        {
            systemfile f = new systemfile()
            {
                filename = alias,
                filelocation = this.storePath
            };
            return deleteFile(f);
        }

        private base_response deleteFile(systemfile f)
        {
            try
            {
                //_logger.LogTrace($"Deleting certificate at {f.filelocation}/{f.filename}");
                return systemfile.delete(this.nss, f);
            }
            catch (Exception e)
            {
                //_logger.LogError("Error removing file: " + e.Message);
                //_logger.LogDebug(e.StackTrace);
                throw;
            }
        }

        public string findKeyPairByCertPath(string certPath)
        {
            filtervalue[] filters = new filtervalue[1];
            filters[0] = new filtervalue("cert", certPath);
            //_logger.LogTrace("Checking " + storeType + $" to see if existing certificate-key pair exists with name {keyPairName}");
            var filtered_results = sslcertkey.get_filtered(nss, filters);

            if (filtered_results != null && filtered_results.Length > 0)
            {
                return filtered_results[0].certkey;
            }

            return null;
        }

        private string updateKeyPair(string keyPairName, string certPath, string keyPath)
        {
            try
            {

                filtervalue[] filters = new filtervalue[1];
                filters[0] = new filtervalue("certKey", keyPairName);
                //_logger.LogTrace("Checking " + storeType + $" to see if existing certificate-key pair exists with name {keyPairName}");
                uint count = sslcertkey.count_filtered(nss, filters);

                //_logger.LogTrace($"Count of certkey with {keyPairName}: {count}");

                if (count > 0)
                {
                    //sslcertkey result = sslcertkey.get(nss, keyPairName);

                    sslcertkey result = new sslcertkey() {
                        certkey = keyPairName,
                        cert = certPath
                    };

                    keyPath = certPath + ".key";

                    //Existing keypair exists
                    if (keyPath != null)
                    {
                        result.key = keyPath;
                    }
                    result.inform = "PEM";
                    result.nodomaincheck = true;

                    //_logger.LogTrace("Updating " + storeType + $" certificate-key pair with name {keyPairName}");
                    base_response response = sslcertkey.change(nss, result);
                }
                else
                {
                    sslcertkey s = new sslcertkey
                    {
                        certkey = keyPairName,
                        cert = certPath
                    };
                    if (keyPath != null)
                    {
                        s.key = keyPath;
                        s.password = false;
                        s.passplain = "0";  // Unused, but required, dummy variable
                    }
                    //_logger.LogTrace("Adding " + storeType + $" certificate-key pair with name {keyPairName}");
                    sslcertkey.add(nss, s);
                }
            }
            catch (nitro_exception ne)
            {
                
                //_logger.LogWarning($"Exception occured while trying to add or update {keyPairName}");
                if ((((UInt32)ne.HResult).Equals(0x80138500) || ((UInt32)ne.HResult).Equals(0x80131500)) && ne.Message.Contains("Resource already exists"))
                {
                    if (ne.Message.Contains("certkeyName Contents,"))
                    {
                        int start = ne.Message.IndexOf("Contents, ") + "Contents, ".Length;
                        int end = ne.Message.IndexOf(']', start);
                        keyPairName = ne.Message.Substring(start, end - start);
                        //_logger.LogWarning("Certificate keypair already existed on " + storeType + " as " + keyPairName);
                    }
                    else
                    {
                        //_logger.LogWarning("Certificate keypair already existed on " + storeType);
                    }
                }
                else throw;
            }

            return keyPairName;
        }

        public string updateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey)
        {

            string certPath = this.storePath + "/" + alias;

            if (String.IsNullOrWhiteSpace(keyPairName))
            {
                var existingKeyPair = findKeyPairByCertPath(certPath);
                if (existingKeyPair != null)
                {
                    keyPairName = existingKeyPair;
                }
                else
                {
                    // If keyPairName is not specified then create one based upon the alias and serial number
                    X509Certificate2 cert = new X509Certificate2(Convert.FromBase64String(pemFile.filecontent));
                    keyPairName = (alias.Substring(0, Math.Min(22, alias.Length))
                                + "-" + new String(cert.SerialNumber.ToString().Reverse().ToArray()));
                    keyPairName = keyPairName.Substring(0, Math.Min(31, keyPairName.Length));
                }
            }

            
            string keyPath = null;
            if (privateKey != null)
            {
                keyPath = this.storePath + "/" + alias + ".key";
            }

            return updateKeyPair(keyPairName, certPath, keyPath);
        }

        public void updateBindings(string keyPairName, string virtualServerName)
        {
            //_logger.LogTrace($"Enter updateBindings");

            if (!String.IsNullOrWhiteSpace(virtualServerName))
            {
                foreach(var vsName in virtualServerName.Split(",")) { 

                //_logger.LogTrace($"Updating bindings for {virtualServerName}");
                //bind key-pair to vserver
                sslvserver_sslcertkey_binding ssb = new sslvserver_sslcertkey_binding()
                {
                    certkeyname = keyPairName,
                    vservername = vsName
                };
                //_logger.LogDebug($"Adding binding {keyPairName} for virtual server {virtualServerName}");
                //var base_response = 
                    sslvserver_sslcertkey_binding.add(nss, ssb);

                    //todo: check response
                }
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
            pemify = ss => ss.Length <= 64 ? ss : ss.Substring(0, 64) + "\n" + pemify(ss.Substring(64));
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
                privateKeyFile = new systemfile
                {
                    filecontent = Convert.ToBase64String(privateKey),
                    filename = alias + ".key",
                    filelocation = this.storePath
                };

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

        public X509Certificate2 getX509Certificate(string fileLocation, out bool hasKey)
        {
            systemfile f;

            string certString = null;
            string keyString = null;

            try
            {
                f = getSystemFile(fileLocation);
            }
            catch
            {
                hasKey = false;
                return null;
            }
            // Determine if it's a cert
            X509Certificate2 x = null;
            try
            {
                var b = Convert.FromBase64String(f.filecontent);
                string fileString = System.Text.Encoding.Default.GetString(b);

                // Check if private key is included with certificate
                bool containsKey = fileString.IndexOf("-----BEGIN RSA PRIVATE KEY-----") >= 0;
                bool containsCert = fileString.IndexOf("-----BEGIN CERTIFICATE-----") >= 0;

                if (containsCert && containsKey)
                {
                    //_logger.LogDebug($"File contains certificate and key: {fileLocation}");

                    int keyStart = fileString.IndexOf("-----BEGIN RSA PRIVATE KEY-----");
                    int keyEnd = fileString.IndexOf("-----END RSA PRIVATE KEY-----") + "-----END RSA PRIVATE KEY-----".Length;

                    // check if need to remove new line

                    keyString = fileString.Substring(keyStart, keyEnd - keyStart);
                    certString = fileString.Remove(keyStart, keyEnd - keyStart);

                }
                else if (containsCert)
                {
                    certString = fileString;
                    // check .key file
                    try
                    {
                        systemfile keyFile = getSystemFile(fileLocation + ".key");
                        keyString = Encoding.UTF8.GetString(Convert.FromBase64String(keyFile.filecontent));
                    }
                    catch (Exception e)
                    {
                        //_logger.LogInformation("Unable to evaluate private key - " + e.Message);
                        //Logger.Debug(LogHandler.FlattenException(e));
                    }
                }

                if (certString == null)
                {
                    hasKey = false;
                    return null;
                }

                try
                {
                    x = readX509Certificate(certString);
                }
                catch (Exception e)
                {
                    // Not a certificate file
                    //_logger.LogDebug($"Error reading x509Certificate at {fileLocation}");
                    //_logger.LogDebug(e.Message);
                    hasKey = false;
                    return null;
                }

                hasKey = evaluatePrivateKey(x, keyString);

            }
            catch (Exception e)
            {
                // Not a certificate file
                //_logger.LogDebug($"{fileLocation} is not a certificate");
                //_logger.LogDebug(e.Message);
                hasKey = false;
            }

            return x;
        }

        private systemfile getSystemFile(string fileName)
        {

            //UI uses
            //systemfile?args=fileLocation:/nsconfig/ssl/,filename:ns-root.key
            //f = systemfile.get(nss, fileLocation, this.nitro_service_options); // This requires the CSS, non-stock nitro SDK
            //nitro/v1/config/systemfile/ns-root.key?args=filelocation:%2Fnsconfig%2Fssl
            //systemfile file = systemfile.get(nss, fileLocation + ".key", this.nitro_service_options); // Again, CSS Nitro SDK, not Citrix

            options option = new options();

            String urlPath = HttpUtility.UrlEncode(this.storePath);
            option.set_args($"filelocation:{urlPath},filename:{fileName}");
            var results = systemfile.get(nss, option);
            if(results.Length>0)
            return results[0];

            //_logger.LogDebug($"filelocation:{urlPath},filename:{fileName} not found");
            throw new Exception("file not found");
        }

        private X509Certificate2 readX509Certificate(string certString)
        {
            // Determine if it's a cert
            byte[] b = null;
            X509Certificate2 x;
            try
            {
                b = System.Text.Encoding.Default.GetBytes(certString);
                x = new X509Certificate2(b);
                //_logger.LogDebug($"Found certificate with subject {x.Subject}");
            }
            catch (Exception e)
            {
                if (b != null)
                {
                    // Try to handle files that are base64'ed too many times. Possibly unnecessary but harmless.
                    b = Convert.FromBase64String(System.Text.Encoding.Default.GetString(b));
                    x = new X509Certificate2(b);
                    //_logger.LogDebug($"Found certificate with subject {x.Subject}");
                }

                throw e;
            }

            return x;
        }

        private bool evaluatePrivateKey(X509Certificate2 cert, string keyString)
        {
            if (keyString == "" || keyString == null) return false;
            try
            {
                AsymmetricCipherKeyPair keypair = (AsymmetricCipherKeyPair)new PemReader(new StringReader(keyString)).ReadObject();
                RsaPrivateCrtKeyParameters privateKey = (RsaPrivateCrtKeyParameters)keypair.Private;

                //RsaKeyParameters publicKey = (RsaKeyParameters)new PemReader(new StringReader(cert.GetPublicKeyString() ?? string.Empty)).ReadObject();

                RsaKeyParameters publicKey = (RsaKeyParameters)DotNetUtilities.FromX509Certificate(cert).GetPublicKey();
                return (privateKey.Modulus.Equals(publicKey.Modulus) && publicKey.Exponent.Equals(privateKey.PublicExponent));
            }
            catch (Exception e)
            {
                //_logger.LogInformation("Unable to evaluate private key - " + e.Message);
                ////_logger.LogDebug(LogHandler.FlattenException(e));
                return false;
            }
        }
    }
}
