using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace RibbonUITest.Drivers
{
    /// <summary>
    /// Manages the lifecycle and initialization of the Windows Appium driver.
    /// </summary>
    public class DriverManager : IDisposable
    {
        private WindowsDriver? _driver;
        private readonly string _appPath;
        private readonly string _serverUrl;
        private readonly string _deviceName;
        private readonly string _automationName;

        /// <summary>
        /// Initializes the driver manager with configuration settings.
        /// </summary>
        public DriverManager(IConfiguration configuration)
        {
            var relativeAppPath = configuration["Appium:AppPath"] ?? throw new InvalidOperationException("Missing AppPath in configuration.");

            // Get the base directory where the test is running from
            var baseDir = AppContext.BaseDirectory;
            _appPath = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", relativeAppPath));

            _serverUrl = configuration["Appium:ServerUrl"] ?? throw new InvalidOperationException("Missing ServerUrl in configuration.");
            _deviceName = configuration["Appium:DeviceName"] ?? "WindowsPC";
            _automationName = configuration["Appium:AutomationName"] ?? "Windows";
        }

        /// <summary>
        /// Returns the Windows driver instance. Initializes if not already started.
        /// </summary>
        public WindowsDriver GetDriver()
        {
            if (_driver != null)
            {
                try
                {
                    _ = _driver.Title; // Check if driver is still active
                    return _driver;
                }
                catch
                {
                    CloseDriver();
                }
            }
            return InitializeDriver();
        }

        /// <summary>
        /// Initializes a new instance of the Windows driver with Appium options.
        /// </summary>
        private WindowsDriver InitializeDriver()
        {
            try
            {
                var options = new AppiumOptions
                {
                    App = _appPath,
                    DeviceName = _deviceName,
                    AutomationName = _automationName
                };

                _driver = new WindowsDriver(new Uri(_serverUrl), options);
                return _driver;
            }
            catch (UriFormatException ex)
            {
                throw new InvalidOperationException(
                    $"Driver initialization failed due to an invalid Appium Server URL: {_serverUrl}.\n" +
                    $"Please check your configuration.\n" +
                    $"Refer to 'USERMANUAL.md' in the project root for detailed instructions.\n\n" +
                    $"Error: {ex.Message}", ex);
            }
            catch (OpenQA.Selenium.WebDriverException ex)
            {
                throw new InvalidOperationException(
                    $"Driver initialization failed due to a WebDriver issue.\n" +
                    $"- Ensure WinAppDriver is running\n" +
                    $"- Confirm your app path is correct\n\n" +
                    $"Refer to 'USERMANUAL.md' in the project root for detailed instructions.\n\n" +
                    $"Error: {ex.Message}", ex);
            }
            catch (System.Net.WebException ex)
            {
                throw new InvalidOperationException(
                    $"Driver initialization failed due to a network issue while connecting to Appium server at {_serverUrl}.\n" +
                    $"Check if the server is reachable and not blocked by firewall or proxy settings.\n\n" +
                    $"Refer to 'USERMANUAL.md' in the project root for detailed instructions.\n\n" +
                    $"Error: {ex.Message}", ex);
            }
            catch (InvalidOperationException ex) when (ex.Message.Contains("Could not find a matching capability"))
            {
                throw new InvalidOperationException(
                    $"Driver initialization failed due to incorrect or unsupported Appium capabilities.\n" +
                    $"- Check App, DeviceName, and AutomationName values.\n\n" +
                    $"Refer to 'USERMANUAL.md' in the project root for detailed instructions.\n\n" +
                    $"Error: {ex.Message}", ex);
            }
        }
        /// <summary>
        /// Closes and disposes the current driver instance.
        /// </summary>
        public void CloseDriver()
        {
            _driver?.Quit();
            _driver?.Dispose();
        }

        /// <summary>
        /// Disposes the DriverManager and its resources.
        /// </summary>
        public void Dispose()
        {
            CloseDriver();
            GC.SuppressFinalize(this);
        }
    }
}