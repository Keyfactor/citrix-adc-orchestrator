using Keyfactor.Logging;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Keyfactor.Extensions.Orchestrator.CitricAdc
{
    internal class ApplicationSettings
    {
        private static Dictionary<string, string> _configuration;

        public static bool autoSaveConfig => _configuration.ContainsKey("AutoSaveConfig") && _configuration["AutoSaveConfig"]?.ToUpper() == "Y";

        public static bool renewAll => _configuration.ContainsKey("RenewAll") && _configuration["RenewAll"]?.ToUpper() == "Y";

        public static void Initialize(string configLocation)
        {
            ILogger logger = LogHandler.GetClassLogger<ApplicationSettings>();
            logger.MethodEntry(LogLevel.Debug);

            _configuration = new Dictionary<string, string>();
            configLocation = $"{Path.GetDirectoryName(configLocation)}{Path.DirectorySeparatorChar}config.json";
            string configContents;

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

            if (string.IsNullOrEmpty(configContents))
            {
                logger.LogDebug("config.json exists but empty.  Default values used for configuration.");
                return;
            }

            _configuration = JsonConvert.DeserializeObject<Dictionary<string, string>>(configContents);
            ValidateConfiguration(logger);

            logger.LogDebug("Configuration Settings:");
            foreach (KeyValuePair<string, string> keyValue in _configuration)
            {
                logger.LogDebug($"    {keyValue.Key}: {keyValue.Value}");
            }

            logger.MethodExit(LogLevel.Debug);
        }

        private static void ValidateConfiguration(ILogger logger) 
        {
            if (!_configuration.ContainsKey("AutoSaveConfig"))
                logger.LogDebug($"Missing configuration parameter - AutoSaveConfig. The default will be set to false.");
        }

    }
}
