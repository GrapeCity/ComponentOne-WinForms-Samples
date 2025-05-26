using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace RibbonUITest.Configurations
{
    public class ConfigLoader
    {
        public static IConfiguration LoadConfiguration(string configFilePath)
        {
            if (!File.Exists(configFilePath))
            {
                throw new FileNotFoundException($"Configuration file not found: {configFilePath}");
            }

            var builder = new ConfigurationBuilder()
                .AddJsonFile(configFilePath, optional: false, reloadOnChange: true);

            return builder.Build();
        }
    }
}