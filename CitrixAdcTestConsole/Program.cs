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
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Keyfactor.Extensions.Orchestrator.CitricAdc;
using Keyfactor.Orchestrators.Extensions;
using Keyfactor.Orchestrators.Extensions.Interfaces;
using Moq;
using Newtonsoft.Json;

namespace CitrixAdcTestConsole
{
    internal class Program
    {
        public static string userName { get; set; }
        public static string password { get; set; }
        public static string caseName { get; set; }
        public static string certAlias { get; set; }
        public static string clientMachine { get; set; }
        public static string storePath { get; set; }
        public static string virtualServerName { get; set; }
        public static string keyPairName { get; set; }
        public static string overwrite { get; set; }
        public static string renewal { get; set; }
        public static string managementType { get; set; }
        public static string certificateContent { get; set; }

#pragma warning disable 1998
        private static async Task Main(string[] args)
#pragma warning restore 1998
        {


            var arguments = new Dictionary<string, string>();
            Thread.Sleep(10000);
            foreach (var argument in args)
            {
                var splitted = argument.Split('=');

                if (splitted.Length == 2) arguments[splitted[0]] = splitted[1];
            }
            if (args.Length > 0)
            {
                caseName = arguments["-casename"];
                userName = arguments["-user"];
                password = arguments["-password"];
                storePath = arguments["-storepath"];
                clientMachine = arguments["-clientmachine"];
            }
            
            // Display message to user to provide parameters.
            Console.WriteLine("Running");

            switch (caseName)
            {
                case "Inventory":
                    Console.WriteLine("Running Inventory");
                    InventoryJobConfiguration invJobConfig;
                    invJobConfig =  GetInventoryJobConfiguration();
                    Console.WriteLine("Got Inventory Config");
                    SubmitInventoryUpdate sui = GetItems;
                    var secretResolver = new Mock<IPAMSecretResolver>();
                    secretResolver.Setup(m => m.Resolve(It.Is<string>(s => s == invJobConfig.ServerUsername)))
                        .Returns(() => invJobConfig.ServerUsername);
                    secretResolver.Setup(m => m.Resolve(It.Is<string>(s => s == invJobConfig.ServerPassword)))
                        .Returns(() => invJobConfig.ServerPassword);
                    var inv = new Inventory(secretResolver.Object);
                    Console.WriteLine("Created Inventory Object With Constructor");
                    var invResponse = inv.ProcessJob(invJobConfig, sui);
                    Console.WriteLine("Back From Inventory");
                    Console.Write(JsonConvert.SerializeObject(invResponse));
                    Console.ReadLine();
                    break;
                case "Management":
                    Console.WriteLine("Select Management Type Add or Remove");
                    string mgmtType;
                    mgmtType = args.Length == 0 ? Console.ReadLine() : arguments["-managementtype"];

                    if (mgmtType?.ToUpper() == "ADD")
                    {
                        if (args.Length > 0)
                        {
                            certAlias = arguments["-certalias"];
                            virtualServerName = arguments["-virtualservername"];
                            overwrite = arguments["-overwrite"];
                            renewal = arguments["-isrenew"];
                        }

                        Console.WriteLine("Start Generated Cert in KF API");
                        var client = new KeyfactorClient();
                        var kfResult = client.EnrollCertificate($"citrixadc.boingy.com").Result;
                        certificateContent = kfResult.CertificateInformation.Pkcs12Blob;
                        Console.WriteLine("End Generated Cert in KF API");
                        
                        if(renewal.ToUpper()=="FALSE") 
                            SetRenewThumbprint(kfResult.CertificateInformation.Thumbprint);

                        var jobConfiguration = GetManagementJobConfiguration(renewal.ToUpper() == "TRUE" ? "ManagementRenewModified" : "Management");

                        var mgmtSecretResolver = new Mock<IPAMSecretResolver>();
                        mgmtSecretResolver
                            .Setup(m => m.Resolve(It.Is<string>(s => s == jobConfiguration.ServerUsername)))
                            .Returns(() => jobConfiguration.ServerUsername);
                        mgmtSecretResolver
                            .Setup(m => m.Resolve(It.Is<string>(s => s == jobConfiguration.ServerPassword)))
                            .Returns(() => jobConfiguration.ServerPassword);
                        var mgmt = new Management(mgmtSecretResolver.Object);


                        var result = mgmt.ProcessJob(jobConfiguration);
                        Console.Write(JsonConvert.SerializeObject(result));
                        Console.ReadLine();
                    }

                    if (mgmtType != null && mgmtType.ToUpper() == "REMOVE")
                    {
                        if (args.Length > 0)
                        {
                            certAlias = arguments["-certalias"];
                        }

                        var jobConfig = GetRemoveJobConfiguration();

                        var mgmtSecretResolver = new Mock<IPAMSecretResolver>();
                        mgmtSecretResolver.Setup(m => m.Resolve(It.Is<string>(s => s == jobConfig.ServerUsername)))
                            .Returns(() => jobConfig.ServerUsername);
                        mgmtSecretResolver.Setup(m => m.Resolve(It.Is<string>(s => s == jobConfig.ServerPassword)))
                            .Returns(() => jobConfig.ServerPassword);
                        var mgmt = new Management(mgmtSecretResolver.Object);
                        var result = mgmt.ProcessJob(jobConfig);
                        Thread.Sleep(5000);
                        Console.Write(JsonConvert.SerializeObject(result));
                        Console.ReadLine();
                    }

                    break;
            }
        }

        public static bool GetItems(IEnumerable<CurrentInventoryItem> items)
        {
            return true;
        }

        public static InventoryJobConfiguration GetInventoryJobConfiguration()
        {
            var fileContent = File.ReadAllText("FirewallInventory.json").Replace("UserNameGoesHere", userName)
                .Replace("PasswordGoesHere", password).Replace("ClientMachineGoesHere", clientMachine);
            var result =
                JsonConvert.DeserializeObject<InventoryJobConfiguration>(fileContent);
            return result;
        }

        public static InventoryJobConfiguration GetPanoramaInventoryJobConfiguration()
        {
            var fileContent = File.ReadAllText("Inventory.json").Replace("UserNameGoesHere", userName)
                .Replace("PasswordGoesHere", password).Replace("TemplateNameGoesHere", storePath)
                .Replace("ClientMachineGoesHere", clientMachine);
            var result =
                JsonConvert.DeserializeObject<InventoryJobConfiguration>(fileContent);
            return result;
        }

        public static ManagementJobConfiguration GetManagementJobConfiguration(string fileName)
        {

            var overWriteReplaceString = "\"Overwrite\": false";
            if (overwrite.ToUpper() == "TRUE")
            {
                overWriteReplaceString = "\"Overwrite\": true";
            }

            var fileContent = File.ReadAllText($"{fileName}.json").Replace("UserNameGoesHere", userName)
                .Replace("PasswordGoesHere", password).Replace("TemplateNameGoesHere", storePath)
                .Replace("AliasGoesHere", certAlias)
                .Replace("ClientMachineGoesHere", clientMachine)
                .Replace("virtualServerNameGoesHere", virtualServerName)
                .Replace("\"Overwrite\": false", overWriteReplaceString)
                .Replace("CertificateContentGoesHere", certificateContent);
            var result =
                JsonConvert.DeserializeObject<ManagementJobConfiguration>(fileContent);
            return result;
        }

        public static void SetRenewThumbprint(string lastThumbprint)
        {
            var fileContent = File.ReadAllText("ManagementRenew.json")
                .Replace("ThumbprintGoesHere",lastThumbprint);
            File.WriteAllText("ManagementRenewModified.json", fileContent, Encoding.UTF8);
        }


        public static ManagementJobConfiguration GetRemoveJobConfiguration()
        {
            var fileContent = File.ReadAllText("ManagementRemove.json").Replace("UserNameGoesHere", userName)
                .Replace("PasswordGoesHere", password).Replace("TemplateNameGoesHere", storePath)
                .Replace("AliasGoesHere", certAlias)
                .Replace("ClientMachineGoesHere", clientMachine)
                .Replace("virtualServerNameGoesHere", virtualServerName);
            var result =
                JsonConvert.DeserializeObject<ManagementJobConfiguration>(fileContent);
            return result;
        }
    }
}