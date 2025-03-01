﻿// Copyright 2023 Keyfactor
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
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;

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
                StorePath = StripTrailingSlash(config.CertificateStoreDetails.StorePath);
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
                StorePath = StripTrailingSlash(config.CertificateStoreDetails.StorePath);
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
                Logger.LogError($"Error in GetKeyPairName(): {LogHandler.FlattenException(e)}");
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

        public void UpdateKeyPair(string keyPairName, string certFileName, string keyFileName)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                Logger.LogTrace($"keyPairName: {keyPairName} certFileName:{certFileName} keyFileName{keyFileName}");

                sslcertkey certKeyObject = new sslcertkey()
                {
                    certkey = keyPairName,
                    cert = certFileName,
                    key = keyFileName,
                    inform = "PEM",
                    nodomaincheck = true,
                    passplain = "0",
                    password = false
                };
                
                var filters = new filtervalue[1];
                filters[0] = new filtervalue("certKey", keyPairName);
                var count = sslcertkey.count_filtered(_nss, filters);

                if (count > 0)
                {
                    Logger.LogTrace($"Updating certificate-key pair with name {keyPairName}");

                    base_response updResponse = sslcertkey.update(_nss, certKeyObject);
                    Logger.LogDebug($"sslcertkey.update: ## Error Code ##: {updResponse.errorcode} ## Message ##: {updResponse.message}");

                    base_response chgResponse = sslcertkey.change(_nss, certKeyObject);
                    Logger.LogDebug($"sslcertkey.change: ## Error Code ##: {chgResponse.errorcode} ## Message ##: {chgResponse.message}");
                }
                else
                {
                    Logger.LogTrace($"Adding certificate-key pair with name {keyPairName}");
                    sslcertkey.add(_nss, certKeyObject);
                }
            }
            catch (nitro_exception ne)
            {
                Logger.LogError($"Exception occured while trying to add or update {keyPairName}.  {LogHandler.FlattenException(ne)}");
                throw;
            }

            Logger.MethodExit(LogLevel.Debug);
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

        public void UpdateBindings(string keyPairName, List<string> virtualServerNames, List<bool> sniCerts)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                if (virtualServerNames.Count != sniCerts.Count)
                {
                    Logger.LogError($"Error attempting to perform binding.  Mismatched number of virtual server names ({virtualServerNames.Count.ToString()} and SNI values {sniCerts.Count.ToString()}.  Certificate added, but binding not performed.");
                    return;
                }

                var i = 0;

                foreach (string vsName in virtualServerNames)
                {
                    bool sniBool = Convert.ToBoolean(sniCerts[virtualServerNames.IndexOf(vsName)]);
                    Logger.LogTrace($"Updating binding for {vsName}");
                    var ssb = new sslvserver_sslcertkey_binding
                    {
                        certkeyname = keyPairName,
                        vservername = vsName,
                        snicert = sniBool
                    };
                    Logger.LogTrace($"Adding binding {keyPairName} for virtual server {vsName} and sni {sniBool.ToString()}");

                    //Citrix Requires you do delete first when SNI with same domain or you will get a duplicate domain error
                    var filters = new filtervalue[1];
                    filters[0] = new filtervalue("certKeyName", keyPairName);
                    if (sniBool && sslvserver_sslcertkey_binding.count_filtered(_nss, vsName, filters) > 0)
                    {
                        Logger.LogTrace($"Removing binding for virtual server {vsName} and sni {sniBool.ToString()}");
                        base_response response = sslvserver_sslcertkey_binding.delete(_nss, ssb);
                        Logger.LogTrace($"Removing binding results: ErrorCode: {response.errorcode}, Message: {response.message}");
                    }
                    sslvserver_sslcertkey_binding.add(_nss, ssb);

                    i++;
                }
            }
            catch (Exception e)
            {
                Logger.LogError(
                    $"Error Occurred in UpdateBindings: {LogHandler.FlattenException(e)}");
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
            sslcertkey certKey = sslcertkey.get(_nss, keyPairName);

            X509Certificate2Collection x509CertCollection = new X509Certificate2Collection();
            x509CertCollection.Import(Convert.FromBase64String(cert), privateKeyPassword, X509KeyStorageFlags.Exportable | X509KeyStorageFlags.EphemeralKeySet);

            X509Certificate2 issuingCert = x509CertCollection.First(r => r.Subject == (x509CertCollection.First(p => p.HasPrivateKey).Issuer));

            if (chain.chaincomplete == 1)
            {
                foreach (string chainCertAlias in chain.chainlinked)
                {
                    X509Certificate2 x509ChainCert = GetX509Certificate(GetKeyPairByName(chainCertAlias));
                    if (x509ChainCert.Thumbprint == issuingCert.Thumbprint)
                    {
                        return;
                    }
                }
            }

            if (chain.chainpossiblelinks == null || chain.chainpossiblelinks.Length == 0)
            {
                string msg = $"Certificate added, but link not performed.  No Issuing CA Certificate exists for {keyPairName}.";
                Logger.LogWarning(msg);
                throw new LinkException(msg);
            }

            string chainCertName = string.Empty;
            foreach (string chainCertAlias in chain.chainpossiblelinks)
            {
                X509Certificate2 x509ChainCert = GetX509Certificate(GetKeyPairByName(chainCertAlias));
                if (x509ChainCert.Thumbprint == issuingCert.Thumbprint)
                {
                    chainCertName = chainCertAlias;
                    break;
                }
            }

            if (chainCertName == string.Empty)
            {
                string errMsg = "Issuing certificate not found in Citrix.  Link not performed.";
                Logger.LogWarning(errMsg);
                throw new LinkException(errMsg);
            }

            certKey.linkcertkeyname = chainCertName;
            sslcertkey.link(_nss, certKey);

            Logger.MethodExit(LogLevel.Debug);
        }

        private (string, string) GetPemFromPfx(byte[] pfxBytes, char[] pfxPassword)
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
                return (certPem, privateKeyString);
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
                var f = new systemfile { filelocation = StorePath, filename = fileName.Substring(fileName.LastIndexOf("/") + 1) };
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

        public (systemfile pemFile, systemfile privateKeyFile) UploadCertificate(string contents, string pwd,
            string alias, bool overwrite)
        {
            Logger.MethodEntry(LogLevel.Debug);

            try
            {
                var (certificate, privateKey) = GetPemFromPfx(Convert.FromBase64String(contents), pwd.ToCharArray());

                //upload certificate and key
                systemfile certificateFile = UploadFile(alias, certificate, true, 0);
                systemfile privateKeyFile = UploadFile(alias, privateKey, false, 0);

                return (certificateFile, privateKeyFile);
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

        private systemfile UploadFile(string alias, string contents, bool isCertificate, int fileNameSuffix)
        {
            Logger.LogDebug("Entering UploadFile() Method...");

            if (fileNameSuffix > 50)
            {
                string errMessage = $"Too many attempts (50) to upload file for {alias}";
                Logger.LogError(errMessage);
                throw new Exception(errMessage);
            }

            string fileNameSuffixString = fileNameSuffix == 0 ? string.Empty : fileNameSuffix.ToString();
            string fileName = alias + fileNameSuffixString + (isCertificate ? string.Empty : ".key");

            systemfile file = new systemfile()
            {
                filecontent = Convert.ToBase64String(Encoding.ASCII.GetBytes(contents)),
                filelocation = StorePath,
                filename = fileName
            };

            try
            {
                Logger.LogTrace($"Attempting to upload file {file.filelocation}/{file.filename}");
                var _ = systemfile.add(_nss, file);
                Logger.LogTrace($"File {file.filename} added for {alias}");
            }
            catch (nitro_exception ne)
            {
                // ReSharper disable once SuspiciousTypeConversion.Global
                if ((ne.HResult.Equals(0x80131500) || ne.Message.Contains("File already exists")))
                {
                    Logger.LogTrace($"File {file.filename} already exists.  Trying again with new name.");
                    file = UploadFile(alias, contents, isCertificate, fileNameSuffix + 1);
                }
                else
                {
                    throw new Exception($"Error attempting to upload certificate {alias} - {ne.Message}");
                }
            }

            return file;
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

        public bool AliasExists(string alias)
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
                    throw;
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

        private string StripTrailingSlash(string storePath)
        {
            return storePath.Substring(storePath.Length - 1, 1) == "/" ? storePath.Substring(0, storePath.Length - 1) : storePath;
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