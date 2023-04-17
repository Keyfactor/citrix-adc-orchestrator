using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.resource.config.ssl;
using com.citrix.netscaler.nitro.resource.config.system;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;
using Keyfactor.Logging;
using Keyfactor.Orchestrators.Extensions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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

        private readonly string _clientMachine;

        private readonly systemfile_args nitroServiceOptions;
        private readonly string password;
        private readonly string username;
        private readonly bool useSsl;

        public readonly string storePath;

        private nitro_service nss;

        public CitrixAdcStore(InventoryJobConfiguration config, string serverUserName, string serverPassword)
        {
            try
            {
                logger = LogHandler.GetClassLogger<CitrixAdcStore>();
                logger.LogDebug(
                    "Begin CitrixAdcStore(InventoryJobConfiguration config) : this((JobConfiguration) config) Constructor...");
                _clientMachine = config.CertificateStoreDetails.ClientMachine;
                storePath = config.CertificateStoreDetails.StorePath;
                var o = new systemfile_args();
                useSsl = config.UseSSL;
                username = serverUserName;
                password = serverPassword;

                logger.LogTrace($"Store Path: {storePath}");
                o.filelocation = storePath;
                nitroServiceOptions = o;

                logger.LogDebug(
                    "Exit CitrixAdcStore(InventoryJobConfiguration config) : this((JobConfiguration) config) Constructor...");
            }
            catch (Exception e)
            {
                logger.LogError(
                    $"Error Occured in CitrixAdcStore(InventoryJobConfiguration config) : this((JobConfiguration) config): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public CitrixAdcStore(ManagementJobConfiguration config, string serverUserName, string serverPassword)
        {
            try
            {
                logger = LogHandler.GetClassLogger<CitrixAdcStore>();
                logger.LogDebug(
                    "Begin CitrixAdcStore(ManagementJobConfiguration config) : this((JobConfiguration) config) Constructor...");
                _clientMachine = config.CertificateStoreDetails.ClientMachine;
                storePath = config.CertificateStoreDetails.StorePath;
                useSsl = config.UseSSL;
                username = serverUserName;
                password = serverPassword;
                var o = new systemfile_args();

                logger.LogTrace($"UrlPath: {storePath}");
                o.filelocation = storePath;

                nitroServiceOptions = o;
                logger.LogDebug(
                    "Exit CitrixAdcStore(ManagementJobConfiguration config) : this((JobConfiguration) config) Constructor...");
            }
            catch (Exception e)
            {
                logger.LogError(
                    $"Error Occured in CitrixAdcStore(ManagementJobConfiguration config) : this((JobConfiguration) config): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        private ILogger logger { get; }

        public void Login()
        {
            logger.LogDebug("Entering CitrixAdcStore Login Method...");
            nss ??= new nitro_service(_clientMachine, useSsl ? "https" : "http");
            base_response response = null;
            try
            {
                response = nss.login(username, password, Timeout);
                logger.LogDebug($"Login Response: {JsonConvert.SerializeObject(response)}");
            }
            catch (Exception ex)
            {
                logger.LogError($"Error in Login: {ex.Message}");
                throw new Exception("Error logging in to CitrixAdc Device", ex);
            }
            finally
            {
                if (response != null && !nss.isLogin()) throw new Exception(response.message);
            }

            logger.LogDebug("Exiting CitrixAdcStore Login Method...");
        }

        public bool Logout()
        {
            try
            {
                logger.LogDebug("Entering Logout Method...");
                nss.logout();
                //TODO: process resp
            }
            catch (Exception e)
            {
                logger.LogError($"Logout Error Occurred: {LogHandler.FlattenException(e)}");
                return false;
            }

            logger.LogDebug("Exiting Logout Method...");
            return true;
        }

        public sslcertkey_binding GetBinding(string certKey)
        {
            try
            {
                logger.LogDebug($"Entering and Exiting GetBinding Method... CertKey={certKey}");
                return sslcertkey_binding.get(nss, certKey);
            }
            catch (Exception e)
            {
                logger.LogError($"Error in GetBinding(): {LogHandler.FlattenException(e)}");
                return null;
            }
        }

        public sslcertkey GetKeyPairByName(string name)
        {
            try
            {
                logger.LogDebug("Entering and Exiting ListKeyPairs() Method...");
                return sslcertkey.get(nss, name);
            }
            catch (Exception e)
            {
                logger.LogError($"Error in ListKeyPairs(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public sslcertkey[] ListKeyPairs()
        {
            try
            {
                logger.LogDebug("Entering and Exiting ListKeyPairs() Method...");
                return sslcertkey.get(nss);
            }
            catch (Exception e)
            {
                logger.LogError($"Error in ListKeyPairs(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public systemfile[] ListFiles()
        {
            try
            {
                logger.LogDebug("Entering and Exiting ListFiles() Method...");
                return systemfile.get(nss, nitroServiceOptions);
            }
            catch (Exception e)
            {
                logger.LogError($"Error in ListFiles(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public (systemfile pemFile, systemfile privateKeyFile) UploadCertificate(string contents, string pwd,
            string alias, bool overwrite)
        {
            try
            {
                logger.LogDebug("Entering UploadCertificate() Method...");
                var (pemFile, privateKeyFile) = GetPem(contents, pwd, alias);
                logger.LogTrace($"Contents: {contents} pwd: {pwd} alias: {alias} overwrite: {overwrite}");

                logger.LogTrace("Starting UploadFile(pemFile,overwrite) call");
                //upload certificate
                UploadFile(pemFile, overwrite);
                logger.LogTrace("Finishing UploadFile(pemFile,overwrite) call");


                //upload private key
                if (privateKeyFile != null)
                {
                    logger.LogTrace("PrivateKeyFile is not null so uploading private key");
                    //we default overwrite private key as certificate upload has already succeeded and this file needs to be in sync
                    UploadFile(privateKeyFile, true);
                    logger.LogTrace("Finished Uploading Private Key");
                }

                return (pemFile, privateKeyFile);
            }
            catch (Exception e)
            {
                logger.LogError($"Error in UploadCertificate(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private void UploadFile(systemfile f, bool overwrite)
        {
            logger.LogDebug("Entering UploadFile() Method...");
            try
            {
                logger.LogDebug($"File Content: {JsonConvert.SerializeObject(f)}");
                logger.LogTrace("Trying to add File");
                var _ = systemfile.add(nss, f);
                logger.LogTrace("File Added");
            }
            catch (nitro_exception ne)
            {
                logger.LogTrace($"Nitro Exception Occured {ne.Message}");
                // ReSharper disable once SuspiciousTypeConversion.Global
                if ((ne.HResult.Equals(0x80131500) || ne.Message.Contains("File already exists"))
                    && overwrite)
                {
                    var fOld = new systemfile
                    {
                        filename = f.filename,
                        filelocation = f.filelocation
                    };
                    logger.LogDebug($"Old File Content: {JsonConvert.SerializeObject(fOld)}");
                    systemfile.delete(nss, fOld);
                    systemfile.add(nss, f);
                }
                else
                {
                    logger.LogError("Unexpected Nitro Error Occurred");
                    throw;
                }
            }
        }

        public base_response DeleteFile(string alias)
        {
            try
            {
                logger.LogDebug("Entering DeleteFile(string contents, string alias) Method...");
                logger.LogTrace($"alias: {alias} storePath: {storePath}");
                var f = new systemfile
                {
                    filename = alias,
                    filelocation = storePath
                };
                logger.LogDebug("Exiting DeleteFile() Method...");
                return DeleteFile(f);
            }
            catch (Exception e)
            {
                logger.LogError(
                    $"Error Occurred in DeleteFile(string contents, string alias): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private base_response DeleteFile(systemfile f)
        {
            try
            {
                logger.LogDebug("Entering and Exiting DeleteFile() Method...");
                logger.LogTrace($"Deleting certificate at {f.filelocation}/{f.filename}");
                return systemfile.delete(nss, f);
            }
            catch (Exception e)
            {
                logger.LogError($"Error Occurred in DeleteFile(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public base_response DeleteKeyPair(sslcertkey f)
        {
            try
            {
                logger.LogDebug("Entering and Exiting DeleteFile() Method...");
                logger.LogTrace($"Deleting certificate at {f}");
                return sslcertkey.delete(nss, f);
            }
            catch (Exception e)
            {
                logger.LogError($"Error Occurred in DeleteFile(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }



        public string FindKeyPairByCertPath(string certPath)
        {
            try
            {
                logger.LogDebug("Entering FindKeyPairByCertPath(string certPath) Method...");
                logger.LogTrace($"certPath: {certPath}");
                var filters = new filtervalue[1];
                filters[0] = new filtervalue("cert", certPath);
                var filteredResults = sslcertkey.get_filtered(nss, filters);
                logger.LogTrace($"filteredResults: {JsonConvert.SerializeObject(filteredResults)}");
                if (filteredResults != null && filteredResults.Length > 0) return filteredResults[0].certkey;
                logger.LogDebug("Exiting FindKeyPairByCertPath(string certPath) Method...");
                return null;
            }
            catch (Exception e)
            {
                logger.LogError(
                    $"Error Occurred in FindKeyPairByCertPath(string certPath): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private string UpdateKeyPair(string keyPairName, string certPath, string keyPath)
        {
            try
            {
                logger.LogDebug(
                    "Entering UpdateKeyPair(string keyPairName, string certPath, string keyPath) Method...");
                logger.LogTrace($"keyPairName: {keyPairName} certPath:{certPath} keyPath{keyPath}");
                var filters = new filtervalue[1];
                filters[0] = new filtervalue("certKey", keyPairName);
                logger.LogTrace($"Checking to see if existing certificate-key pair exists with name {keyPairName}");
                var count = sslcertkey.count_filtered(nss, filters);
                logger.LogTrace($"Count of certkey with {keyPairName}: {count}");

                if (count > 0)
                {
                    var result = new sslcertkey
                    {
                        certkey = keyPairName,
                        cert = certPath
                    };

                    logger.LogTrace($"result: {JsonConvert.SerializeObject(result)}");
                    keyPath = certPath + ".key";
                    logger.LogTrace($"keyPath: {keyPath}");

                    //Existing keypair exists
                    result.key = keyPath;
                    result.inform = "PEM";
                    result.nodomaincheck = true;

                    logger.LogTrace($"Updating certificate-key pair with name {keyPairName}");
                    var _ = sslcertkey.change(nss, result);
                    var unused = sslcertkey.update(nss, result);
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

                    logger.LogTrace($"Adding certificate-key pair with name {keyPairName}");
                    sslcertkey.add(nss, s);
                    logger.LogTrace($"Finished Adding certificate-key pair with name {keyPairName}");
                }
            }
            catch (nitro_exception ne)
            {
                logger.LogError($"Exception occured while trying to add or update {keyPairName}");
                if ((((uint)ne.HResult).Equals(0x80138500) || ((uint)ne.HResult).Equals(0x80131500)) &&
                    ne.Message.Contains("Resource already exists"))
                {
                    if (ne.Message.Contains("certkeyName Contents,"))
                    {
                        var start = ne.Message.IndexOf("Contents, ", StringComparison.Ordinal) + "Contents, ".Length;
                        var end = ne.Message.IndexOf(']', start);
                        keyPairName = ne.Message.Substring(start, end - start);
                        logger.LogError($"Certificate keypair already existed on as {keyPairName}");
                    }
                }
                else
                {
                    throw;
                }
            }

            logger.LogDebug("Exiting UpdateKeyPair(string keyPairName, string certPath, string keyPath) Method...");
            return keyPairName;
        }

        public string UpdateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey)
        {
            try
            {
                logger.LogDebug(
                    "Entering UpdateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey) Method...");
                logger.LogTrace($"alias: {alias} keyPairName: {keyPairName}");
                logger.LogTrace($"pemFile Content: {JsonConvert.SerializeObject(pemFile)}");
                logger.LogTrace($"privateKey Content: {JsonConvert.SerializeObject(privateKey)}");

                var certPath = storePath + "/" + keyPairName;
                logger.LogTrace($"certPath: {certPath}");

                //see if keypair already exists, if it does then we have to generate a new name to prevent downtime
                logger.LogTrace($"keyPairName: {keyPairName} certPath:{certPath} checking if already exists.");

                if (string.IsNullOrWhiteSpace(keyPairName))
                {
                    logger.LogTrace("string.IsNullOrWhiteSpace(keyPairName) is True");
                    var existingKeyPair = FindKeyPairByCertPath(certPath);
                    logger.LogTrace($"existingKeyPair: {existingKeyPair}");
                    if (existingKeyPair != null)
                    {
                        logger.LogTrace($"existingKeyPair not Null: {existingKeyPair}");
                        keyPairName = existingKeyPair;
                    }
                    else
                    {
                        keyPairName = GenerateKeyPairName(alias);
                    }
                }

                string keyPath = null;
                if (privateKey != null) keyPath = storePath + "/" + alias + ".key";
                logger.LogTrace($"keyPath: {keyPath}");
                logger.LogDebug(
                    "Exiting UpdateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey) Method...");
                return UpdateKeyPair(keyPairName, certPath, keyPath);
            }
            catch (Exception e)
            {
                logger.LogError(
                    $"Error Occurred in UpdateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private string GenerateKeyPairName(string alias)
        {
            if (alias == alias.Substring(0, Math.Min(40, alias.Length)))
            {
                alias = alias.Substring(0, Math.Min(40, alias.Length));
            }
            else
            {
                alias = alias.Substring(0, Math.Min(40, alias.Length));
            }


            logger.LogTrace($"keyPairName: {alias}");
            return alias;
        }

        public void UpdateBindings(string keyPairName, string virtualServerName)
        {
            try
            {
                logger.LogDebug("Enter UpdateBindings(string keyPairName, string virtualServerName)");

                if (!string.IsNullOrWhiteSpace(virtualServerName))
                    foreach (var vsName in virtualServerName.Split(","))
                    {
                        logger.LogTrace($"Updating bindings for {virtualServerName}");
                        //bind key-pair to vserver
                        var ssb = new sslvserver_sslcertkey_binding
                        {
                            certkeyname = keyPairName,
                            vservername = vsName
                        };
                        logger.LogTrace($"Adding binding {keyPairName} for virtual server {virtualServerName}");
                        sslvserver_sslcertkey_binding.add(nss, ssb);

                        logger.LogDebug("Exit UpdateBindings(string keyPairName, string virtualServerName)");
                    }
            }
            catch (Exception e)
            {
                logger.LogError(
                    $"Error Occurred in UpdateBindings(string keyPairName, string virtualServerName): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private (byte[], byte[]) GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword)
        {
            try
            {
                logger.LogDebug("Entering GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword)");
                var p = new Pkcs12Store(new MemoryStream(pfxBytes), pfxPassword);

                // Extract private key
                var memoryStream = new MemoryStream();
                TextWriter streamWriter = new StreamWriter(memoryStream);
                var pemWriter = new PemWriter(streamWriter);

                var alias = p.Aliases.Cast<string>().SingleOrDefault(a => p.IsKeyEntry(a));
                logger.LogTrace($"alias: {alias}");

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

                var certPem =
                    certStart + Pemify(Convert.ToBase64String(p.GetCertificate(alias).Certificate.GetEncoded())) +
                    certEnd;
                logger.LogTrace($"certPem: {certPem}");
                logger.LogDebug("Exiting GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword)");
                return (Encoding.ASCII.GetBytes(certPem), Encoding.ASCII.GetBytes(privateKeyString));
            }
            catch (Exception e)
            {
                logger.LogError(
                    $"Error Occurred in GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private (systemfile, systemfile) GetPem(string contents, string pwd, string alias)
        {
            try
            {
                logger.LogDebug("Entering GetPem(string contents, string pwd, string alias)");
                var pemFile = new systemfile();
                systemfile privateKeyFile = null;

                if (!string.IsNullOrWhiteSpace(pwd)) // PFX Entry
                {
                    logger.LogTrace($"Has Password: {pwd}");
                    // Load PFX
                    var pfxBytes = Convert.FromBase64String(contents);
                    var (certPem, privateKey) = GetPemFromPfx(pfxBytes, pwd.ToCharArray());

                    // create private key file
                    privateKeyFile = new systemfile
                    {
                        filecontent = Convert.ToBase64String(privateKey),
                        filename = alias + ".key",
                        filelocation = storePath
                    };

                    logger.LogTrace($"privateKeyFile Content: {JsonConvert.SerializeObject(privateKeyFile)}");

                    // set pem file from cert in pfx
                    pemFile.filecontent = Convert.ToBase64String(certPem);
                }
                else
                {
                    pemFile.filecontent = contents;
                }

                pemFile.filename = alias;
                pemFile.filelocation = storePath;
                logger.LogTrace($"pemFile Content: {JsonConvert.SerializeObject(pemFile)}");
                logger.LogDebug("Exiting GetPem(string contents, string pwd, string alias)");

                return (pemFile, privateKeyFile);
            }
            catch (Exception e)
            {
                logger.LogError(
                    $"Error Occurred in GetPem(string contents, string pwd, string alias): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public X509Certificate2 GetX509Certificate(string fileLocation, out bool hasKey)
        {
            logger.LogDebug("Entering GetX509Certificate(string fileLocation, out bool hasKey)");
            systemfile f;

            string certString = null;
            string keyString = null;

            try
            {
                logger.LogTrace($"Trying GetSystemFile(fileLocation): {fileLocation}");
                f = GetSystemFile(fileLocation);
                logger.LogTrace($"Finished GetSystemFile(fileLocation): {fileLocation}");
            }
            catch
            {
                logger.LogError("Error Occurred in GetSystemFile(fileLocation)");
                hasKey = false;
                return null;
            }

            // Determine if it's a cert
            X509Certificate2 x = null;
            try
            {
                var b = Convert.FromBase64String(f.filecontent);
                var fileString = Encoding.Default.GetString(b);
                logger.LogTrace($"fileString: {fileString}");

                // Check if private key is included with certificate
                var containsKey = fileString.IndexOf("-----BEGIN RSA PRIVATE KEY-----", StringComparison.Ordinal) >= 0;
                var containsCert = fileString.IndexOf("-----BEGIN CERTIFICATE-----", StringComparison.Ordinal) >= 0;

                logger.LogTrace($"containsKey: {containsKey} containsCert: {containsCert}");

                if (containsCert && containsKey)
                {
                    logger.LogTrace($"File contains certificate and key: {fileLocation}");

                    var keyStart = fileString.IndexOf("-----BEGIN RSA PRIVATE KEY-----", StringComparison.Ordinal);
                    var keyEnd = fileString.IndexOf("-----END RSA PRIVATE KEY-----", StringComparison.Ordinal) +
                                 "-----END RSA PRIVATE KEY-----".Length;

                    // check if need to remove new line
                    keyString = fileString.Substring(keyStart, keyEnd - keyStart);
                    certString = fileString.Remove(keyStart, keyEnd - keyStart);
                }
                else if (containsCert)
                {
                    logger.LogTrace("containsCert");
                    certString = fileString;
                    // check .key file
                    try
                    {
                        var keyFile = GetSystemFile(fileLocation + ".key");
                        keyString = Encoding.UTF8.GetString(Convert.FromBase64String(keyFile.filecontent));
                        logger.LogTrace($"keyString: {keyString}");
                    }
                    catch (Exception e)
                    {
                        logger.LogError("Unable to evaluate private key - " + LogHandler.FlattenException(e));
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
                    logger.LogError($"Error reading x509Certificate at {fileLocation}");
                    logger.LogError(LogHandler.FlattenException(e));
                    hasKey = false;
                    return null;
                }

                hasKey = EvaluatePrivateKey(x, keyString);
            }
            catch (Exception e)
            {
                // Not a certificate file
                logger.LogError($"{fileLocation} is not a certificate");
                logger.LogError(LogHandler.FlattenException(e));
                hasKey = false;
            }

            logger.LogDebug("Exiting GetX509Certificate(string fileLocation, out bool hasKey)");
            return x;
        }

        private systemfile GetSystemFile(string fileName)
        {
            try
            {
                logger.LogDebug("Entering GetSystemFile(string fileName)");
                var option = new systemfile_args();
                logger.LogTrace($"urlPath: {storePath} fileName:{fileName}");

                //option.set_args($"filelocation:{urlPath},filename:{fileName}");
                option.filelocation = storePath;
                systemfile f = new systemfile();
                f.filelocation = storePath;
                f.filename = fileName;
                var result = systemfile.get(nss, f);
                logger.LogDebug("Exiting GetSystemFile(string fileName)");
                return result;
            }
            catch (Exception e)
            {
                logger.LogError($"Error Occurred in GetSystemFile(string fileName): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public bool IsDuplicateCertificate(string alias)
        {
            var filters = new filtervalue[1];
            filters[0] = new filtervalue("certKey", alias);
            logger.LogTrace($"Checking to see if existing certificate-key pair exists with name {alias}");
            var count = sslcertkey.count_filtered(nss, filters);
            logger.LogTrace($"Count of certkey with {alias}: {count}");

            if (count > 0)
                return true;
            return false;
        }

        private X509Certificate2 ReadX509Certificate(string certString)
        {
            try
            {
                logger.LogDebug("Entering ReadX509Certificate(string certString)");
                // Determine if it's a cert
                byte[] b = null;
                X509Certificate2 x;
                try
                {
                    b = Encoding.Default.GetBytes(certString);
                    x = new X509Certificate2(b);
                    logger.LogTrace($"Found certificate with subject {x.Subject}");
                }
                catch (Exception e)
                {
                    logger.LogError(
                        $"Error Occurred Trying to Load X509Certificate2: {LogHandler.FlattenException(e)}");
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

                logger.LogDebug("Exiting ReadX509Certificate(string certString)");
                return x;
            }
            catch (Exception e)
            {
                logger.LogError(
                    $"Error Occurred in ReadX509Certificate(string certString): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private bool EvaluatePrivateKey(X509Certificate2 cert, string keyString)
        {
            logger.LogDebug("Entering EvaluatePrivateKey(X509Certificate2 cert, string keyString)");
            if (string.IsNullOrEmpty(keyString)) return false;
            try
            {
                var keypair = (AsymmetricCipherKeyPair)new PemReader(new StringReader(keyString)).ReadObject();
                var privateKey = (RsaPrivateCrtKeyParameters)keypair.Private;

                var publicKey = (RsaKeyParameters)DotNetUtilities.FromX509Certificate(cert).GetPublicKey();
                logger.LogDebug("Exiting EvaluatePrivateKey(X509Certificate2 cert, string keyString)");

                return privateKey.Modulus.Equals(publicKey.Modulus) &&
                       publicKey.Exponent.Equals(privateKey.PublicExponent);
            }
            catch (Exception e)
            {
                logger.LogError("Unable to evaluate private key - " + e.Message);
                logger.LogError(LogHandler.FlattenException(e));
                return false;
            }
        }
    }
}