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
                Logger.MethodEntry(LogLevel.Debug);

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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public CitrixAdcStore(ManagementJobConfiguration config, string serverUserName, string serverPassword)
        {
            try
            {
                Logger = LogHandler.GetClassLogger<CitrixAdcStore>();
                Logger.MethodEntry(LogLevel.Debug);

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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        private ILogger Logger { get; }

        public void Login()
        {
            Logger.MethodEntry(LogLevel.Debug);
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
                Logger.MethodExit(LogLevel.Debug);
                if (response != null && !_nss.isLogin()) throw new Exception(response.message);
            }
        }

        public bool Logout()
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                _nss.logout();
            }
            catch (Exception e)
            {
                Logger.LogError($"Logout Error Occurred: {LogHandler.FlattenException(e)}");
                return false;
            }

            Logger.MethodExit(LogLevel.Debug);
            return true;
        }

        public sslcertkey_binding GetBinding(string certKey)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                Logger.LogDebug($"CertKey={certKey}");
                return sslcertkey_binding.get(_nss, certKey);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in GetBinding(): {LogHandler.FlattenException(e)}");
                return null;
            }
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public sslcertkey GetKeyPairByName(string name)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                return sslcertkey.get(_nss, name);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in ListKeyPairs(): {LogHandler.FlattenException(e)}");
                throw;
            }
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public sslcertkey[] GetCertificates()
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                return sslcertkey.get(_nss);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in ListKeyPairs(): {LogHandler.FlattenException(e)}");
                throw;
            }
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public systemfile[] ListFiles()
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                return systemfile.get(_nss, nitroServiceOptions);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in ListFiles(): {LogHandler.FlattenException(e)}");
                throw;
            }
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public (systemfile pemFile, systemfile privateKeyFile) UploadCertificate(string contents, string pwd,
            string alias, bool overwrite)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        private void UploadFile(systemfile f, bool overwrite)
        {
            Logger.MethodEntry(LogLevel.Debug);

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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public base_response DeleteFile(string alias)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        private base_response DeleteFile(systemfile f)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                Logger.LogTrace($"Deleting certificate at {f.filelocation}/{f.filename}");
                return systemfile.delete(_nss, f);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error Occurred in DeleteFile(): {LogHandler.FlattenException(e)}");
                throw;
            }
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public base_response DeleteKeyPair(sslcertkey f)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                Logger.LogTrace($"Deleting certificate at {f}");
                return sslcertkey.delete(_nss, f);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error Occurred in DeleteFile(): {LogHandler.FlattenException(e)}");
                throw;
            }
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }


        public string FindKeyPairByCertPath(string certPath)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        private string UpdateKeyPair(string keyPairName, string certPath, string keyPath)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
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

            Logger.MethodExit(LogLevel.Debug);
            return keyPairName;
        }

        public string UpdateKeyPair(string alias, string keyPairName, systemfile pemFile, systemfile privateKey)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public sslvserver_sslcertkey_binding[] GetBindingByVServer(string vServerName)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                Logger.LogDebug($"vServerName={vServerName}");
                return sslvserver_sslcertkey_binding.get(_nss, vServerName);
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in GetBinding(): {LogHandler.FlattenException(e)}");
                return null;
            }
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        private string GenerateKeyPairName(string alias)
        {
            Logger.MethodEntry(LogLevel.Debug);

            if (alias == alias.Substring(0, Math.Min(40, alias.Length)))
                alias = alias.Substring(0, Math.Min(40, alias.Length));
            else
                alias = alias.Substring(0, Math.Min(40, alias.Length));


            Logger.LogTrace($"keyPairName: {alias}");
            Logger.MethodExit(LogLevel.Debug);

            return alias;
        }

        public void UpdateBindings(string keyPairName, string virtualServerName, string sniCert)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public void LinkToIssuer(string cert, string privateKeyPassword, string keyPairName)
        {
            Logger.MethodEntry(LogLevel.Debug);

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

            Logger.MethodExit(LogLevel.Debug);
        }

        private (byte[], byte[]) GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        private (systemfile, systemfile) GetPem(string contents, string pwd, string alias)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public X509Certificate2 GetX509Certificate(sslcertkey certificate)
        {
            Logger.MethodEntry(LogLevel.Debug);

            string certString = null;
            X509Certificate2 x509Cert = null;

            try
            {
                Logger.LogTrace($"Trying GetSystemFile(fileLocation): {certificate.cert}");
                systemfile f = GetSystemFile(certificate.cert);
                Logger.LogTrace($"Finished GetSystemFile(fileLocation): {certificate.cert}");

                var b = Convert.FromBase64String(f.filecontent);
                var fileString = Encoding.Default.GetString(b);

                string endDelim = "-----END CERTIFICATE-----";
                int startIdx = fileString.IndexOf("-----BEGIN CERTIFICATE-----", StringComparison.Ordinal);
                int endIdx = fileString.IndexOf(endDelim, StringComparison.Ordinal);

                if (startIdx == -1 || endIdx == -1)
                {
                    Logger.LogWarning($"Certificate {certificate.certkey} does not contain a valid PEM formatted certificate");
                }

                certString = fileString.Substring(startIdx, endIdx - startIdx + endDelim.Length);

                if (certString == null)
                {
                    return null;
                }

                try
                {
                    x509Cert = ReadX509Certificate(certString);
                }
                catch (Exception e)
                {
                    Logger.LogError($"Error reading converting {certificate.certkey} to X509 certificate format: {LogHandler.FlattenException(e)}");
                    return null;
                }
            }
            catch (Exception e)
            {
                // Not a certificate file
                Logger.LogError($"Error reading/processing certificate {certificate.certkey}: {LogHandler.FlattenException(e)}");
            }

            Logger.MethodExit(LogLevel.Debug);
            return x509Cert;
        }

        private systemfile GetSystemFile(string fileName)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
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
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public bool IsDuplicateCertificate(string alias)
        {
            Logger.MethodEntry(LogLevel.Debug);

            var filters = new filtervalue[1];
            filters[0] = new filtervalue("certKey", alias);
            Logger.LogTrace($"Checking to see if existing certificate-key pair exists with name {alias}");
            var count = sslcertkey.count_filtered(_nss, filters);
            Logger.LogTrace($"Count of certkey with {alias}: {count}");

            if (count > 0)
                return true;

            Logger.MethodExit(LogLevel.Debug);
            return false;
        }

        private X509Certificate2 ReadX509Certificate(string certString)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
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

                return x;
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occurred in ReadX509Certificate(string certString): {LogHandler.FlattenException(e)}");
                throw;
            }
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }

        public void SaveConfiguration()
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                _ = _nss.save_config();
            }
            catch (Exception e)
            {
                Logger.LogError($"Error in SaveConfiguration: {LogHandler.FlattenException(e)}");
                throw;
            }
            finally
            {
                Logger.MethodExit(LogLevel.Debug);
            }
        }
    }

    public class LinkException : Exception 
    {
        public LinkException(string message) : base(message) { }
    }
}