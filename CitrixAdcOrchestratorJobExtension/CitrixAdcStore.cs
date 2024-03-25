// Copyright 2023 Keyfactor
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
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
        private readonly string _password;

        public readonly string StorePath;
        private readonly string _username;
        private readonly bool _useSsl;

        private nitro_service _nss;

        public CitrixAdcStore(InventoryJobConfiguration config, string serverUserName, string serverPassword)
        {
            try
            {
                Logger = LogHandler.GetClassLogger<CitrixAdcStore>();
                Logger.LogDebug(
                    "Begin CitrixAdcStore(InventoryJobConfiguration config) : this((JobConfiguration) config) Constructor...");
                _clientMachine = config.CertificateStoreDetails.ClientMachine;
                StorePath = config.CertificateStoreDetails.StorePath;
                var o = new systemfile_args();
                _useSsl = config.UseSSL;
                _username = serverUserName;
                _password = serverPassword;

                Logger.LogTrace($"Store Path: {StorePath}");
                o.filelocation = StorePath;
                nitroServiceOptions = o;

                Logger.LogDebug(
                    "Exit CitrixAdcStore(InventoryJobConfiguration config) : this((JobConfiguration) config) Constructor...");
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occured in CitrixAdcStore(InventoryJobConfiguration config) : this((JobConfiguration) config): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public CitrixAdcStore(ManagementJobConfiguration config, string serverUserName, string serverPassword)
        {
            try
            {
                Logger = LogHandler.GetClassLogger<CitrixAdcStore>();
                Logger.LogDebug(
                    "Begin CitrixAdcStore(ManagementJobConfiguration config) : this((JobConfiguration) config) Constructor...");
                _clientMachine = config.CertificateStoreDetails.ClientMachine;
                StorePath = config.CertificateStoreDetails.StorePath;
                _useSsl = config.UseSSL;
                _username = serverUserName;
                _password = serverPassword;
                var o = new systemfile_args();

                Logger.LogTrace($"UrlPath: {StorePath}");
                o.filelocation = StorePath;

                nitroServiceOptions = o;
                Logger.LogDebug(
                    "Exit CitrixAdcStore(ManagementJobConfiguration config) : this((JobConfiguration) config) Constructor...");
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occured in CitrixAdcStore(ManagementJobConfiguration config) : this((JobConfiguration) config): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        private ILogger Logger { get; }

        public void Login()
        {
            Logger.LogDebug("Entering CitrixAdcStore Login Method...");
            _nss ??= new nitro_service(_clientMachine, _useSsl ? "https" : "http");
            base_response response = null;
            try
            {
                response = _nss.login(_username, _password, Timeout);
                Logger.LogDebug($"Login Response: {JsonConvert.SerializeObject(response)}");
            }
            catch (Exception ex)
            {
                Logger.LogError($"Error in Login: {ex.Message}");
                throw new Exception("Error logging in to CitrixAdc Device", ex);
            }
            finally
            {
                if (response != null && !_nss.isLogin()) throw new Exception(response.message);
            }

            Logger.LogDebug("Exiting CitrixAdcStore Login Method...");
        }

        public bool Logout()
        {
            try
            {
                Logger.LogDebug("Entering Logout Method...");
                _nss.logout();
            }
            catch (Exception e)
            {
                Logger.LogError($"Logout Error Occurred: {LogHandler.FlattenException(e)}");
                return false;
            }

            Logger.LogDebug("Exiting Logout Method...");
            return true;
        }

        public sslcertkey_binding GetBinding(string certKey)
        {
            try
            {
                Logger.LogDebug($"Entering and Exiting GetBinding Method... CertKey={certKey}");
                return sslcertkey_binding.get(_nss, certKey);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in GetBinding(): {LogHandler.FlattenException(e)}");
                return null;
            }
        }

        public sslcertkey GetKeyPairByName(string name)
        {
            try
            {
                Logger.LogDebug("Entering and Exiting ListKeyPairs() Method...");
                return sslcertkey.get(_nss, name);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in ListKeyPairs(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public sslcertkey[] ListKeyPairs()
        {
            try
            {
                Logger.LogDebug("Entering and Exiting ListKeyPairs() Method...");
                return sslcertkey.get(_nss);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in ListKeyPairs(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public systemfile[] ListFiles()
        {
            try
            {
                Logger.LogDebug("Entering and Exiting ListFiles() Method...");
                return systemfile.get(_nss, nitroServiceOptions);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in ListFiles(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public (systemfile pemFile, systemfile privateKeyFile) UploadCertificate(string contents, string pwd,
            string alias, bool overwrite)
        {
            try
            {
                Logger.LogDebug("Entering UploadCertificate() Method...");
                var (pemFile, privateKeyFile) = GetPem(contents, pwd, alias);

                Logger.LogTrace("Starting UploadFile(pemFile,overwrite) call");
                //upload certificate
                UploadFile(pemFile, overwrite);
                Logger.LogTrace("Finishing UploadFile(pemFile,overwrite) call");


                //upload private key
                if (privateKeyFile != null)
                {
                    Logger.LogTrace("PrivateKeyFile is not null so uploading private key");
                    //we default overwrite private key as certificate upload has already succeeded and this file needs to be in sync
                    UploadFile(privateKeyFile, true);
                    Logger.LogTrace("Finished Uploading Private Key");
                }

                return (pemFile, privateKeyFile);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in UploadCertificate(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private void UploadFile(systemfile f, bool overwrite)
        {
            Logger.LogDebug("Entering UploadFile() Method...");
            try
            {
                Logger.LogDebug($"File Content: {JsonConvert.SerializeObject(f)}");
                Logger.LogTrace("Trying to add File");
                var _ = systemfile.add(_nss, f);
                Logger.LogTrace("File Added");
            }
            catch (nitro_exception ne)
            {
                Logger.LogTrace($"Nitro Exception Occured {ne.Message}");
                // ReSharper disable once SuspiciousTypeConversion.Global
                if ((ne.HResult.Equals(0x80131500) || ne.Message.Contains("File already exists"))
                    && overwrite)
                {
                    var fOld = new systemfile
                    {
                        filename = f.filename,
                        filelocation = f.filelocation
                    };
                    Logger.LogDebug($"Old File Content: {JsonConvert.SerializeObject(fOld)}");
                    systemfile.delete(_nss, fOld);
                    systemfile.add(_nss, f);
                }
                else
                {
                    Logger.LogError("Unexpected Nitro Error Occurred");
                    throw;
                }
            }
        }

        public base_response DeleteFile(string alias)
        {
            try
            {
                Logger.LogDebug("Entering DeleteFile(string contents, string alias) Method...");
                Logger.LogTrace($"alias: {alias} storePath: {StorePath}");
                var f = new systemfile
                {
                    filename = alias,
                    filelocation = StorePath
                };
                Logger.LogDebug("Exiting DeleteFile() Method...");
                return DeleteFile(f);
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occurred in DeleteFile(string contents, string alias): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private base_response DeleteFile(systemfile f)
        {
            try
            {
                Logger.LogDebug("Entering and Exiting DeleteFile() Method...");
                Logger.LogTrace($"Deleting certificate at {f.filelocation}/{f.filename}");
                return systemfile.delete(_nss, f);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error Occurred in DeleteFile(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public base_response DeleteKeyPair(sslcertkey f)
        {
            try
            {
                Logger.LogDebug("Entering and Exiting DeleteFile() Method...");
                Logger.LogTrace($"Deleting certificate at {f}");
                return sslcertkey.delete(_nss, f);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error Occurred in DeleteFile(): {LogHandler.FlattenException(e)}");
                throw;
            }
        }


        public string FindKeyPairByCertPath(string certPath)
        {
            try
            {
                Logger.LogDebug("Entering FindKeyPairByCertPath(string certPath) Method...");
                Logger.LogTrace($"certPath: {certPath}");
                var filters = new filtervalue[1];
                filters[0] = new filtervalue("cert", certPath);
                var filteredResults = sslcertkey.get_filtered(_nss, filters);
                Logger.LogTrace($"filteredResults: {JsonConvert.SerializeObject(filteredResults)}");
                if (filteredResults != null && filteredResults.Length > 0) return filteredResults[0].certkey;
                Logger.LogDebug("Exiting FindKeyPairByCertPath(string certPath) Method...");
                return null;
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occurred in FindKeyPairByCertPath(string certPath): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private string UpdateKeyPair(string keyPairName, string certPath, string keyPath)
        {
            try
            {
                Logger.LogDebug(
                    "Entering UpdateKeyPair(string keyPairName, string certPath, string keyPath) Method...");
                Logger.LogTrace($"keyPairName: {keyPairName} certPath:{certPath} keyPath{keyPath}");
                var filters = new filtervalue[1];
                filters[0] = new filtervalue("certKey", keyPairName);
                Logger.LogTrace($"Checking to see if existing certificate-key pair exists with name {keyPairName}");
                var count = sslcertkey.count_filtered(_nss, filters);
                Logger.LogTrace($"Count of certkey with {keyPairName}: {count}");

                if (count > 0)
                {
                    var result = new sslcertkey
                    {
                        certkey = keyPairName,
                        cert = certPath
                    };

                    Logger.LogTrace($"result: {JsonConvert.SerializeObject(result)}");
                    keyPath = certPath + ".key";
                    Logger.LogTrace($"keyPath: {keyPath}");

                    //Existing keypair exists
                    result.key = keyPath;
                    result.inform = "PEM";
                    result.nodomaincheck = true;

                    Logger.LogTrace($"Updating certificate-key pair with name {keyPairName}");
                    var _ = sslcertkey.change(_nss, result);
                    var unused = sslcertkey.update(_nss, result);
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

                    Logger.LogTrace($"Adding certificate-key pair with name {keyPairName}");
                    sslcertkey.add(_nss, s);
                    Logger.LogTrace($"Finished Adding certificate-key pair with name {keyPairName}");
                }
            }
            catch (nitro_exception ne)
            {
                Logger.LogError($"Exception occured while trying to add or update {keyPairName}");
                if ((((uint)ne.HResult).Equals(0x80138500) || ((uint)ne.HResult).Equals(0x80131500)) &&
                    ne.Message.Contains("Resource already exists"))
                {
                    if (ne.Message.Contains("certkeyName Contents,"))
                    {
                        var start = ne.Message.IndexOf("Contents, ", StringComparison.Ordinal) + "Contents, ".Length;
                        var end = ne.Message.IndexOf(']', start);
                        keyPairName = ne.Message.Substring(start, end - start);
                        Logger.LogError($"Certificate keypair already existed on as {keyPairName}");
                    }
                }
                else
                {
                    throw;
                }
            }

            Logger.LogDebug("Exiting UpdateKeyPair(string keyPairName, string certPath, string keyPath) Method...");
            return keyPairName;
        }

        public string UpdateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey)
        {
            try
            {
                Logger.LogDebug(
                    "Entering UpdateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey) Method...");
                Logger.LogTrace($"alias: {alias} keyPairName: {keyPairName}");

                var certPath = StorePath + "/" + keyPairName;
                Logger.LogTrace($"certPath: {certPath}");

                //see if keypair already exists, if it does then we have to generate a new name to prevent downtime
                Logger.LogTrace($"keyPairName: {keyPairName} certPath:{certPath} checking if already exists.");

                if (string.IsNullOrWhiteSpace(keyPairName))
                {
                    Logger.LogTrace("string.IsNullOrWhiteSpace(keyPairName) is True");
                    var existingKeyPair = FindKeyPairByCertPath(certPath);
                    Logger.LogTrace($"existingKeyPair: {existingKeyPair}");
                    if (existingKeyPair != null)
                    {
                        Logger.LogTrace($"existingKeyPair not Null: {existingKeyPair}");
                        keyPairName = existingKeyPair;
                    }
                    else
                    {
                        keyPairName = GenerateKeyPairName(alias);
                    }
                }

                string keyPath = null;
                if (privateKey != null) keyPath = StorePath + "/" + alias + ".key";
                Logger.LogTrace($"keyPath: {keyPath}");
                Logger.LogDebug(
                    "Exiting UpdateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey) Method...");
                return UpdateKeyPair(keyPairName, certPath, keyPath);
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occurred in UpdateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public sslvserver_sslcertkey_binding[] GetBindingByVServer(string vServerName)
        {
            try
            {
                Logger.LogDebug($"Entering and Exiting GetBindingByVServerKey Method... vServerName={vServerName}");
                return sslvserver_sslcertkey_binding.get(_nss, vServerName);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in GetBinding(): {LogHandler.FlattenException(e)}");
                return null;
            }
        }

        private string GenerateKeyPairName(string alias)
        {
            if (alias == alias.Substring(0, Math.Min(40, alias.Length)))
                alias = alias.Substring(0, Math.Min(40, alias.Length));
            else
                alias = alias.Substring(0, Math.Min(40, alias.Length));


            Logger.LogTrace($"keyPairName: {alias}");
            return alias;
        }

        public void UpdateBindings(string keyPairName, string virtualServerName, string sniCert)
        {
            try
            {
                Logger.LogDebug("Enter UpdateBindings(string keyPairName, string virtualServerName)");


                var sniArray = sniCert.Split(',');

                if (!string.IsNullOrWhiteSpace(virtualServerName))
                {
                    var i = 0;
                    foreach (var vsName in virtualServerName.Split(","))
                    {
                        var sniBool = false;
                        if (!string.IsNullOrEmpty(sniCert) &&
                            (sniArray[i].ToUpper() == "TRUE" || sniArray[i].ToUpper() == "FALSE"))
                            sniBool = Convert.ToBoolean(sniArray[i]);

                        Logger.LogTrace($"Updating bindings for {virtualServerName}");
                        //bind key-pair to vserver
                        var ssb = new sslvserver_sslcertkey_binding
                        {
                            certkeyname = keyPairName,
                            vservername = vsName,
                            snicert = sniBool
                        };
                        Logger.LogTrace($"Adding binding {keyPairName} for virtual server {virtualServerName}");

                        //Citrix Requires you do delete first when SNI with same domain or you will get a duplicate domain error
                        var filters = new filtervalue[1];
                        filters[0] = new filtervalue("certKeyName", keyPairName);
                        if (sniBool && sslvserver_sslcertkey_binding.count_filtered(_nss, vsName, filters) > 0)
                            sslvserver_sslcertkey_binding.delete(_nss, ssb);
                        sslvserver_sslcertkey_binding.add(_nss, ssb);

                        i++;
                        Logger.LogDebug("Exit UpdateBindings(string keyPairName, string virtualServerName)");
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occurred in UpdateBindings(string keyPairName, string virtualServerName): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public void LinkToIssuer(string cert, string privateKeyPassword, string keyPairName)
        {
            sslcertificatechain chain = sslcertificatechain.get(_nss, keyPairName);
            if (chain.chaincomplete == 1)
            {
                Logger.LogDebug($"Certificate {keyPairName} already linked to {chain.chainlinked}");
                return;
            }

            if (chain.chainpossiblelinks == null || string.IsNullOrEmpty(chain.chainpossiblelinks[0]) || chain.chainpossiblelinks.Length == 0)
            {
                string msg = $"Certificate added, but link not performed.  No Issuing CA Certificate exists for {keyPairName}.";
                Logger.LogWarning(msg);
                throw new LinkException(msg);
            }
            
            sslcertkey certKey = sslcertkey.get(_nss, keyPairName);
            certKey.linkcertkeyname = chain.chainpossiblelinks[0];
            sslcertkey.link(_nss, certKey);
        }

        private (byte[], byte[]) GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword)
        {
            try
            {
                Logger.LogDebug("Entering GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword)");
                var p = new Pkcs12Store(new MemoryStream(pfxBytes), pfxPassword);

                // Extract private key
                var memoryStream = new MemoryStream();
                TextWriter streamWriter = new StreamWriter(memoryStream);
                var pemWriter = new PemWriter(streamWriter);

                var alias = p.Aliases.Cast<string>().SingleOrDefault(a => p.IsKeyEntry(a));
                Logger.LogTrace($"alias: {alias}");

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
                Logger.LogDebug("Exiting GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword)");
                return (Encoding.ASCII.GetBytes(certPem), Encoding.ASCII.GetBytes(privateKeyString));
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occurred in GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private (systemfile, systemfile) GetPem(string contents, string pwd, string alias)
        {
            try
            {
                Logger.LogDebug("Entering GetPem(string contents, string pwd, string alias)");
                var pemFile = new systemfile();
                systemfile privateKeyFile = null;

                if (!string.IsNullOrWhiteSpace(pwd)) // PFX Entry
                {
                    // Load PFX
                    var pfxBytes = Convert.FromBase64String(contents);
                    var (certPem, privateKey) = GetPemFromPfx(pfxBytes, pwd.ToCharArray());

                    // create private key file
                    privateKeyFile = new systemfile
                    {
                        filecontent = Convert.ToBase64String(privateKey),
                        filename = alias + ".key",
                        filelocation = StorePath
                    };

                    // set pem file from cert in pfx
                    pemFile.filecontent = Convert.ToBase64String(certPem);
                }
                else
                {
                    pemFile.filecontent = contents;
                }

                pemFile.filename = alias;
                pemFile.filelocation = StorePath;
                Logger.LogDebug("Exiting GetPem(string contents, string pwd, string alias)");

                return (pemFile, privateKeyFile);
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occurred in GetPem(string contents, string pwd, string alias): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public X509Certificate2 GetX509Certificate(string fileLocation, out bool hasKey)
        {
            Logger.LogDebug("Entering GetX509Certificate(string fileLocation, out bool hasKey)");
            systemfile f;
            string[] privateKeyDelims = new string[3] { "-----BEGIN RSA PRIVATE KEY-----", "-----BEGIN PRIVATE KEY-----", "-----BEGIN ENCRYPTED PRIVATE KEY-----" };

            string certString = null;
            string keyString = null;

            try
            {
                Logger.LogTrace($"Trying GetSystemFile(fileLocation): {fileLocation}");
                f = GetSystemFile(fileLocation);
                Logger.LogTrace($"Finished GetSystemFile(fileLocation): {fileLocation}");
            }
            catch
            {
                Logger.LogError("Error Occurred in GetSystemFile(fileLocation)");
                hasKey = false;
                return null;
            }

            //Ignore Directories
            if (f.filemode != null && f.filemode[0].ToUpper() == "DIRECTORY")
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
                var privateKeyIdx = -1;
                foreach(string privateKeyDelim in privateKeyDelims)
                {
                    if (fileString.IndexOf(privateKeyDelim, StringComparison.Ordinal) >= 0)
                        privateKeyIdx = Array.IndexOf(privateKeyDelims, privateKeyDelim);
                }
                
                var containsCert = fileString.IndexOf("-----BEGIN CERTIFICATE-----", StringComparison.Ordinal) >= 0;

                Logger.LogTrace($"containsKey: {privateKeyIdx > -1} containsCert: {containsCert}");

                if (containsCert && privateKeyIdx > -1)
                {
                    Logger.LogTrace($"File contains certificate and key: {fileLocation}");

                    var keyStart = fileString.IndexOf(privateKeyDelims[privateKeyIdx], StringComparison.Ordinal);
                    var keyEnd = fileString.IndexOf(privateKeyDelims[privateKeyIdx].Replace("BEGIN","END"), StringComparison.Ordinal) +
                                 privateKeyDelims[privateKeyIdx].Replace("BEGIN", "END").Length;

                    // check if need to remove new line
                    keyString = fileString.Substring(keyStart, keyEnd - keyStart);
                    certString = fileString.Remove(keyStart, keyEnd - keyStart);
                }
                else if (containsCert)
                {
                    Logger.LogTrace("containsCert");
                    certString = fileString;
                    // check .key file
                    try
                    {
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileLocation);
                        var keyFile = GetSystemFile(fileNameWithoutExtension + ".key");
                        keyString = Encoding.UTF8.GetString(Convert.FromBase64String(keyFile.filecontent));
                    }
                    catch (Exception e)
                    {
                        Logger.LogError("Unable to evaluate private key - " + LogHandler.FlattenException(e));
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
                    Logger.LogError($"Error reading x509Certificate at {fileLocation}");
                    Logger.LogError(LogHandler.FlattenException(e));
                    hasKey = false;
                    return null;
                }

                hasKey = !string.IsNullOrEmpty(keyString);
            }
            catch (Exception e)
            {
                // Not a certificate file
                Logger.LogError($"{fileLocation} is not a certificate");
                Logger.LogError(LogHandler.FlattenException(e));
                hasKey = false;
            }

            Logger.LogDebug("Exiting GetX509Certificate(string fileLocation, out bool hasKey)");
            return x;
        }

        private systemfile GetSystemFile(string fileName)
        {
            try
            {
                Logger.LogDebug("Entering GetSystemFile(string fileName)");
                var option = new systemfile_args();
                Logger.LogTrace($"urlPath: {StorePath} fileName:{fileName}");

                //option.set_args($"filelocation:{urlPath},filename:{fileName}");
                option.filelocation = StorePath;
                var f = new systemfile { filelocation = StorePath, filename = fileName };
                var result = systemfile.get(_nss, f);
                Logger.LogDebug("Exiting GetSystemFile(string fileName)");
                return result;
            }
            catch (Exception e)
            {
                Logger.LogError($"Error Occurred in GetSystemFile(string fileName): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        public bool IsDuplicateCertificate(string alias)
        {
            var filters = new filtervalue[1];
            filters[0] = new filtervalue("certKey", alias);
            Logger.LogTrace($"Checking to see if existing certificate-key pair exists with name {alias}");
            var count = sslcertkey.count_filtered(_nss, filters);
            Logger.LogTrace($"Count of certkey with {alias}: {count}");

            if (count > 0)
                return true;
            return false;
        }

        private X509Certificate2 ReadX509Certificate(string certString)
        {
            try
            {
                Logger.LogDebug("Entering ReadX509Certificate(string certString)");
                // Determine if it's a cert
                byte[] b = null;
                X509Certificate2 x;
                try
                {
                    b = Encoding.Default.GetBytes(certString);
                    x = new X509Certificate2(b);
                    Logger.LogTrace($"Found certificate with subject {x.Subject}");
                }
                catch (Exception e)
                {
                    Logger.LogError(
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

                Logger.LogDebug("Exiting ReadX509Certificate(string certString)");
                return x;
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occurred in ReadX509Certificate(string certString): {LogHandler.FlattenException(e)}");
                throw;
            }
        }

        private bool EvaluatePrivateKey(X509Certificate2 cert, string keyString)
        {
            Logger.LogDebug("Entering EvaluatePrivateKey(X509Certificate2 cert, string keyString)");
            if (string.IsNullOrEmpty(keyString)) return false;
            try
            {
                var keypair = (AsymmetricCipherKeyPair)new PemReader(new StringReader(keyString)).ReadObject();
                var privateKey = (RsaPrivateCrtKeyParameters)keypair.Private;

                var publicKey = (RsaKeyParameters)DotNetUtilities.FromX509Certificate(cert).GetPublicKey();
                Logger.LogDebug("Exiting EvaluatePrivateKey(X509Certificate2 cert, string keyString)");

                return privateKey.Modulus.Equals(publicKey.Modulus) &&
                       publicKey.Exponent.Equals(privateKey.PublicExponent);
            }
            catch (Exception e)
            {
                Logger.LogError("Unable to evaluate private key - " + e.Message);
                Logger.LogError(LogHandler.FlattenException(e));
                return false;
            }
        }

        public void SaveConfiguration()
        {
            try
            {
                Logger.LogDebug("Entering and Exiting SaveConfiguration Method...");
                _ = _nss.save_config();
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in SaveConfiguration: {LogHandler.FlattenException(e)}");
                throw;
            }
        }
    }

    public class LinkException : Exception 
    {
        public LinkException(string message) : base(message) { }
    }
}