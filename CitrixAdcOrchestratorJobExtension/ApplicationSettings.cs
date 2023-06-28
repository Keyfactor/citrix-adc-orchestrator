using Keyfactor.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    internal class ApplicationSettings
    {
        private static Dictionary<string, string> configuration;

        public static bool AutoSaveConfig { get { return configuration.ContainsKey("AutoSaveConfig") ? configuration["AutoSaveConfig"]?.ToUpper() == "Y" : false; } }

        public static bool RenewAll { get { return configuration.ContainsKey("RenewAll") ? configuration["RenewAll"]?.ToUpper() == "Y" : false; } }

        public static void Initialize(string configLocation)
        {
            ILogger logger = LogHandler.GetClassLogger<ApplicationSettings>();
            logger.MethodEntry(LogLevel.Debug);

            configuration = new Dictionary<string, string>();
            configLocation = $"{Path.GetDirectoryName(configLocation)}{Path.DirectorySeparatorChar}config.json";
            string configContents = string.Empty;

            if (!File.Exists(configLocation))
            {
                logger.LogDebug("config.json missing.  Default values used for configuration.");
                return;
            }

            using (StreamReader sr = new StreamReader(configLocation))
            {
                configContents = sr.ReadToEnd();
                logger.LogDebug($"Raw config.json contents: {configContents}");
            }

            if (String.IsNullOrEmpty(configContents))
            {
                logger.LogDebug("config.json exists but empty.  Default values used for configuration.");
                return;
            }

            configuration = JsonConvert.DeserializeObject<Dictionary<string, string>>(configContents);
            ValidateConfiguration(logger);

            logger.LogDebug("Configuration Settings:");
            foreach (KeyValuePair<string, string> keyValue in configuration)
            {
                logger.LogDebug($"    {keyValue.Key}: {keyValue.Value}");
            }

            logger.MethodExit(LogLevel.Debug);
        }

        private static void ValidateConfiguration(ILogger logger) 
        {
            if (!configuration.ContainsKey("AutoSaveConfig"))
                logger.LogDebug($"Missing configuration parameter - AutoSaveConfig. The default will be set to false.");
        }

    }
}
