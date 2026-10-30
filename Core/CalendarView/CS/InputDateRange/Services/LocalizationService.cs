using System.Globalization;

namespace InputDateRange.Services
{
    /// <summary>
    /// Service for handling localization and resource management.
    /// </summary>
    public class LocalizationService
    {
        private CultureInfo _currentCulture;

        public CultureInfo CurrentCulture => _currentCulture;

        public LocalizationService()
        {
            _currentCulture = new CultureInfo("en-US");
        }

        public void SetCulture(CultureInfo culture)
        {
            _currentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            Properties.Resources.Culture = culture;
        }
    }
}