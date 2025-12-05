using System;
using Microsoft.Extensions.Configuration;
using RibbonUITest.Configurations;

namespace RibbonUITest.Drivers
{
    public class DriverFixture
    {
        public DriverManager DriverManager { get; private set; }
        public IConfiguration Configuration { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DriverFixture"/> class.
        /// Loads the configuration from the appsettings.json file and initializes the DriverManager.
        /// </summary>
        public DriverFixture()
        {
            string configFilePath = Path.Combine(AppContext.BaseDirectory, "Configurations", "appsetting.json");
            Configuration = ConfigLoader.LoadConfiguration(configFilePath);

            DriverManager = new DriverManager(Configuration);
        }

        /// <summary>
        /// Disposes the resources used by the DriverManager.
        /// This is called to clean up any resources when the fixture is no longer needed.
        /// </summary>

        public void Dispose()
        {
            DriverManager?.Dispose();
        }
    }
}