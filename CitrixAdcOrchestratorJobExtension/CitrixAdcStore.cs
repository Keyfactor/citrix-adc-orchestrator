using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.resource.config.ssl;
using com.citrix.netscaler.nitro.resource.config.system;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;
using Keyfactor.Orchestrators.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    // ReSharper disable once InconsistentNaming
    internal class CitrixAdcStore
    {
        private const uint Timeout = 3600;
        public static readonly string StoreType = "CitrixAdc";

        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        private ILogger logger { get; set; }

        private readonly string _clientMachine;

        private readonly options _nitroServiceOptions;
        private readonly string _password;
        private readonly string _username;
        private readonly bool _useSsl;

        public readonly string storePath;

        private nitro_service _nss;

        [ActivatorUtilitiesConstructor]
        public CitrixAdcStore(ILogger<CitrixAdcStore> logger)
        {
            this.logger = logger;
        }

        public CitrixAdcStore(InventoryJobConfiguration config) : this((JobConfiguration) config)
        {
            logger.LogDebug("Begin CitrixAdcStore Constructor...");
            _clientMachine = config.CertificateStoreDetails.ClientMachine;
            storePath = config.CertificateStoreDetails.StorePath;

            var o = new options();
            var urlPath = HttpUtility.UrlEncode(storePath);
            o.set_args($"filelocation:{urlPath}");

            _nitroServiceOptions = o;

            logger.LogDebug("Exit CitrixAdcStore Constructor...");
        }

        public CitrixAdcStore(ManagementJobConfiguration config) : this((JobConfiguration) config)
        {
            logger.LogDebug("Begin CitrixAdcStore Constructor...");
            _clientMachine = config.CertificateStoreDetails.ClientMachine;
            storePath = config.CertificateStoreDetails.StorePath;

            var o = new options();
            var urlPath = HttpUtility.UrlEncode(storePath);
            o.set_args($"filelocation:{urlPath}");

            _nitroServiceOptions = o;
            logger.LogDebug("Exit CitrixAdcStore Constructor...");
        }

        private CitrixAdcStore(JobConfiguration config)
        {
            logger.LogDebug("Begin CitrixAdcStore Constructor...");
            _useSsl = config.UseSSL;
            _username = config.ServerUsername;
            _password = config.ServerPassword;
            logger.LogDebug("Exit CitrixAdcStore Constructor...");

        }

        public void Login()
        {
            logger.LogDebug("Entering CitrixAdcStore Login Method...");
            _nss ??= new nitro_service(_clientMachine, _useSsl ? "https" : "http");
            base_response response = null;
            try
            {
                response = _nss.login(_username, _password, Timeout);
            }
            catch (Exception ex)
            {
                logger.LogError($"Error in Login: {ex.Message}");
                throw new Exception("Error logging in to CitrixAdc Device", ex);
            }
            finally
            {
                if (response != null && !_nss.isLogin()) throw new Exception(response.message);
            }

            logger.LogDebug("Exiting CitrixAdcStore Login Method...");
        }

        public bool Logout()
        {
            //base_response resp =
            try
            {
                _nss.logout();
                //TODO: process resp
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public sslcertkey_binding GetBinding(string certKey)
        {
            try
            {
                return sslcertkey_binding.get(_nss, certKey);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public sslcertkey[] ListKeyPairs()
        {
            return sslcertkey.get(_nss);
        }

        public systemfile[] ListFiles()
        {
            return systemfile.get(_nss, _nitroServiceOptions);
        }

        public (systemfile pemFile, systemfile privateKeyFile) UploadCertificate(string contents, string password,
            string alias, bool overwrite)
        {
            var (pemFile, privateKeyFile) = GetPem(contents, password, alias);

            //upload certificate
            UploadFile(pemFile, overwrite);

            //upload private key
            if (privateKeyFile != null)
                //_logger.LogTrace($"Uploading Private Key");

                //we default overwrite private key as certificate upload has already succeeded and this file needs to be in sync
                UploadFile(privateKeyFile, true);

            return (pemFile, privateKeyFile);
        }

        private void UploadFile(systemfile f, bool overwrite)
        {
            //_logger.LogTrace($"Enter uploadFile");
            try
            {
                //_logger.LogTrace($"Adding file at {location}");
                var _ = systemfile.add(_nss, f);
            }
            catch (nitro_exception ne)
            {
                // ReSharper disable once SuspiciousTypeConversion.Global
                if ((ne.HResult.Equals(0x80131500) || ne.Message.Contains("File already exists"))
                    && overwrite)
                {
                    var fOld = new systemfile
                    {
                        filename = f.filename,
                        filelocation = f.filelocation
                    };
                    systemfile.delete(_nss, fOld);
                    systemfile.add(_nss, f);
                    //_logger.LogTrace($"Overwrote file at {location}");
                }

                //else if (!String.IsNullOrWhiteSpace(JobConfigInfo.vserver))
                //{
                //    //_logger.LogDebug($"Certificate was already present on file system; attempting to add to virtual server {JobConfigInfo.vserver}");
                //}
                else
                {
                    throw;
                }
            }
        }

        public base_response DeleteFile(string contents, string alias)
        {
            var f = new systemfile
            {
                filename = alias,
                filelocation = storePath
            };
            return DeleteFile(f);
        }

        private base_response DeleteFile(systemfile f)
        {
            //_logger.LogTrace($"Deleting certificate at {f.filelocation}/{f.filename}");
            return systemfile.delete(_nss, f);
        }

        public string FindKeyPairByCertPath(string certPath)
        {
            var filters = new filtervalue[1];
            filters[0] = new filtervalue("cert", certPath);
            //_logger.LogTrace("Checking " + storeType + $" to see if existing certificate-key pair exists with name {keyPairName}");
            var filteredResults = sslcertkey.get_filtered(_nss, filters);

            if (filteredResults != null && filteredResults.Length > 0) return filteredResults[0].certkey;

            return null;
        }

        private string UpdateKeyPair(string keyPairName, string certPath, string keyPath)
        {
            try
            {
                var filters = new filtervalue[1];
                filters[0] = new filtervalue("certKey", keyPairName);
                //_logger.LogTrace("Checking " + storeType + $" to see if existing certificate-key pair exists with name {keyPairName}");
                var count = sslcertkey.count_filtered(_nss, filters);

                //_logger.LogTrace($"Count of certkey with {keyPairName}: {count}");

                if (count > 0)
                {
                    //sslcertkey result = sslcertkey.get(nss, keyPairName);

                    var result = new sslcertkey
                    {
                        certkey = keyPairName,
                        cert = certPath
                    };

                    keyPath = certPath + ".key";

                    //Existing keypair exists
                    result.key = keyPath;
                    result.inform = "PEM";
                    result.nodomaincheck = true;

                    //_logger.LogTrace("Updating " + storeType + $" certificate-key pair with name {keyPairName}");
                    var _ = sslcertkey.change(_nss, result);
                }
                else
                {
                    var s = new sslcertkey
                    {
                        certkey = keyPairName,
                        cert = certPath
                    };
                    if (keyPath != null)
                    {
                        s.key = keyPath;
                        s.password = false;
                        s.passplain = "0"; // Unused, but required, dummy variable
                    }

                    //_logger.LogTrace("Adding " + storeType + $" certificate-key pair with name {keyPairName}");
                    sslcertkey.add(_nss, s);
                }
            }
            catch (nitro_exception ne)
            {
                //_logger.LogWarning($"Exception occured while trying to add or update {keyPairName}");
                if ((((uint) ne.HResult).Equals(0x80138500) || ((uint) ne.HResult).Equals(0x80131500)) &&
                    ne.Message.Contains("Resource already exists"))
                {
                    if (ne.Message.Contains("certkeyName Contents,"))
                    {
                        var start = ne.Message.IndexOf("Contents, ", StringComparison.Ordinal) + "Contents, ".Length;
                        var end = ne.Message.IndexOf(']', start);
                        keyPairName = ne.Message.Substring(start, end - start);
                        //_logger.LogWarning("Certificate keypair already existed on " + storeType + " as " + keyPairName);
                    }
                }
                else
                {
                    throw;
                }
            }

            return keyPairName;
        }

        public string UpdateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey)
        {
            var certPath = storePath + "/" + alias;

            if (string.IsNullOrWhiteSpace(keyPairName))
            {
                var existingKeyPair = FindKeyPairByCertPath(certPath);
                if (existingKeyPair != null)
                {
                    keyPairName = existingKeyPair;
                }
                else
                {
                    // If keyPairName is not specified then create one based upon the alias and serial number
                    var cert = new X509Certificate2(Convert.FromBase64String(pemFile.filecontent));
                    keyPairName = alias.Substring(0, Math.Min(22, alias.Length))
                                  + "-" + new string(cert.SerialNumber?.Reverse().ToArray() ?? Array.Empty<char>());
                    keyPairName = keyPairName.Substring(0, Math.Min(31, keyPairName.Length));
                }
            }


            string keyPath = null;
            if (privateKey != null) keyPath = storePath + "/" + alias + ".key";

            return UpdateKeyPair(keyPairName, certPath, keyPath);
        }

        public void UpdateBindings(string keyPairName, string virtualServerName)
        {
            //_logger.LogTrace($"Enter updateBindings");

            if (!string.IsNullOrWhiteSpace(virtualServerName))
                foreach (var vsName in virtualServerName.Split(","))
                {
                    //_logger.LogTrace($"Updating bindings for {virtualServerName}");
                    //bind key-pair to vserver
                    var ssb = new sslvserver_sslcertkey_binding
                    {
                        certkeyname = keyPairName,
                        vservername = vsName
                    };
                    //_logger.LogDebug($"Adding binding {keyPairName} for virtual server {virtualServerName}");
                    //var base_response = 
                    sslvserver_sslcertkey_binding.add(_nss, ssb);

                    //todo: check response
                }
        }

        private (byte[], byte[]) GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword)
        {
            var p = new Pkcs12Store(new MemoryStream(pfxBytes), pfxPassword);

            // Extract private key
            var memoryStream = new MemoryStream();
            TextWriter streamWriter = new StreamWriter(memoryStream);
            var pemWriter = new PemWriter(streamWriter);

            var alias = p.Aliases.Cast<string>().SingleOrDefault(a => p.IsKeyEntry(a));
            var publicKey = p.GetCertificate(alias).Certificate.GetPublicKey();
            if (p.GetKey(alias) == null) throw new Exception($"Unable to get the key for alias: {alias}");
            var privateKey = p.GetKey(alias).Key;
            var keyPair = new AsymmetricCipherKeyPair(publicKey, privateKey);

            pemWriter.WriteObject(keyPair.Private);
            streamWriter.Flush();
            var privateKeyString = Encoding.ASCII.GetString(memoryStream.GetBuffer()).Trim().Replace("\r", "")
                .Replace("\0", "");
            memoryStream.Close();
            streamWriter.Close();

            // Extract server certificate
            var certStart = "-----BEGIN CERTIFICATE-----\n";
            var certEnd = "\n-----END CERTIFICATE-----";

            string Pemify(string ss)
            {
                return ss.Length <= 64 ? ss : ss.Substring(0, 64) + "\n" + Pemify(ss.Substring(64));
            }

            var certPem = certStart + Pemify(Convert.ToBase64String(p.GetCertificate(alias).Certificate.GetEncoded())) +
                          certEnd;
            return (Encoding.ASCII.GetBytes(certPem), Encoding.ASCII.GetBytes(privateKeyString));
        }

        private (systemfile, systemfile) GetPem(string contents, string password, string alias)
        {
            var pemFile = new systemfile();
            systemfile privateKeyFile = null;

            if (!string.IsNullOrWhiteSpace(password)) // PFX Entry
            {
                // Load PFX
                var pfxBytes = Convert.FromBase64String(contents);
                var (certPem, privateKey) = GetPemFromPfx(pfxBytes, password.ToCharArray());

                // create private key file
                privateKeyFile = new systemfile
                {
                    filecontent = Convert.ToBase64String(privateKey),
                    filename = alias + ".key",
                    filelocation = storePath
                };

                // set pem file from cert in pfx
                pemFile.filecontent = Convert.ToBase64String(certPem);
            }
            else
            {
                pemFile.filecontent = contents;
            }

            pemFile.filename = alias;
            pemFile.filelocation = storePath;

            return (pemFile, privateKeyFile);
        }

        public X509Certificate2 GetX509Certificate(string fileLocation, out bool hasKey)
        {
            systemfile f;

            string certString = null;
            string keyString = null;

            try
            {
                f = GetSystemFile(fileLocation);
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
                var fileString = Encoding.Default.GetString(b);

                // Check if private key is included with certificate
                var containsKey = fileString.IndexOf("-----BEGIN RSA PRIVATE KEY-----", StringComparison.Ordinal) >= 0;
                var containsCert = fileString.IndexOf("-----BEGIN CERTIFICATE-----", StringComparison.Ordinal) >= 0;

                if (containsCert && containsKey)
                {
                    //_logger.LogDebug($"File contains certificate and key: {fileLocation}");

                    var keyStart = fileString.IndexOf("-----BEGIN RSA PRIVATE KEY-----", StringComparison.Ordinal);
                    var keyEnd = fileString.IndexOf("-----END RSA PRIVATE KEY-----", StringComparison.Ordinal) +
                                 "-----END RSA PRIVATE KEY-----".Length;

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
                        var keyFile = GetSystemFile(fileLocation + ".key");
                        keyString = Encoding.UTF8.GetString(Convert.FromBase64String(keyFile.filecontent));
                    }
                    catch (Exception e)
                    {
                        logger.LogInformation("Unable to evaluate private key - " + e.Message);
                        logger.LogDebug(e.Message);
                    }
                }

                if (certString == null)
                {
                    hasKey = false;
                    return null;
                }

                try
                {
                    x = ReadX509Certificate(certString);
                }
                catch (Exception e)
                {
                    // Not a certificate file
                    logger.LogDebug($"Error reading x509Certificate at {fileLocation}");
                    logger.LogDebug(e.Message);
                    hasKey = false;
                    return null;
                }

                hasKey = EvaluatePrivateKey(x, keyString);
            }
            catch (Exception e)
            {
                // Not a certificate file
                logger.LogDebug($"{fileLocation} is not a certificate");
                logger.LogDebug(e.Message);
                hasKey = false;
            }

            return x;
        }

        private systemfile GetSystemFile(string fileName)
        {
            //UI uses
            //systemfile?args=fileLocation:/nsconfig/ssl/,filename:ns-root.key
            //f = systemfile.get(nss, fileLocation, this.nitro_service_options); // This requires the CSS, non-stock nitro SDK
            //nitro/v1/config/systemfile/ns-root.key?args=filelocation:%2Fnsconfig%2Fssl
            //systemfile file = systemfile.get(nss, fileLocation + ".key", this.nitro_service_options); // Again, CSS Nitro SDK, not Citrix

            var option = new options();

            var urlPath = HttpUtility.UrlEncode(storePath);
            option.set_args($"filelocation:{urlPath},filename:{fileName}");
            var results = systemfile.get(_nss, option);
            if (results.Length > 0)
                return results[0];

            //_logger.LogDebug($"filelocation:{urlPath},filename:{fileName} not found");
            throw new Exception("file not found");
        }

        private X509Certificate2 ReadX509Certificate(string certString)
        {
            // Determine if it's a cert
            byte[] b = null;
            X509Certificate2 x;
            try
            {
                b = Encoding.Default.GetBytes(certString);
                x = new X509Certificate2(b);
                //_logger.LogDebug($"Found certificate with subject {x.Subject}");
            }
            catch (Exception e)
            {
                if (b != null)
                {
                    // Try to handle files that are base64'ed too many times. Possibly unnecessary but harmless.
                    b = Convert.FromBase64String(Encoding.Default.GetString(b));
                    // ReSharper disable once RedundantAssignment
                    x = new X509Certificate2(b);
                    //_logger.LogDebug($"Found certificate with subject {x.Subject}");
                }

                // ReSharper disable once PossibleIntendedRethrow
                throw e;
            }

            return x;
        }

        private bool EvaluatePrivateKey(X509Certificate2 cert, string keyString)
        {
            if (string.IsNullOrEmpty(keyString)) return false;
            try
            {
                var keypair = (AsymmetricCipherKeyPair) new PemReader(new StringReader(keyString)).ReadObject();
                var privateKey = (RsaPrivateCrtKeyParameters) keypair.Private;

                //RsaKeyParameters publicKey = (RsaKeyParameters)new PemReader(new StringReader(cert.GetPublicKeyString() ?? string.Empty)).ReadObject();

                var publicKey = (RsaKeyParameters) DotNetUtilities.FromX509Certificate(cert).GetPublicKey();
                return privateKey.Modulus.Equals(publicKey.Modulus) &&
                       publicKey.Exponent.Equals(privateKey.PublicExponent);
            }
            catch (Exception)
            {
                //_logger.LogInformation("Unable to evaluate private key - " + e.Message);
                ////_logger.LogDebug(LogHandler.FlattenException(e));
                return false;
            }
        }
    }
}