using InputDateRange.Constants;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace InputDateRange.Services
{
    /// <summary>
    /// Service for handling localization and resource management.
    /// </summary>
    public class LocalizationService : ILocalizationService
    {
        private CultureInfo _currentCulture;
        private ResourceManager _resourceManager;

        public CultureInfo CurrentCulture => _currentCulture;

        public LocalizationService()
        {
            _currentCulture = new CultureInfo("en-US");
            _resourceManager = Properties.Resources.ResourceManager;
        }

        public void SetCulture(CultureInfo culture)
        {
            _currentCulture  = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            Properties.Resources.Culture = culture;
        }

        public string GetString(string key, string? fallback = null)
        {
            return _resourceManager.GetString(key,_currentCulture) ?? fallback ?? key;
        }

        public string GetRangeKeyFromDisplayText(string displayText)
        {
            var mappings = new Dictionary<string, string>();

            foreach (var kvp in DateRangeConstants.RangeKeyToResourceKey)
            {
                var localizedText = GetString(kvp.Value, kvp.Key);
                mappings[localizedText] = kvp.Key;
            }

            return mappings.TryGetValue(displayText, out var key) ? key : displayText;
        }

        public string GetDisplayTextFromRangeKey(string rangeKey)
        {
            if (DateRangeConstants.RangeKeyToResourceKey.TryGetValue(rangeKey, out var resourceKey))
            {
                return GetString(resourceKey, rangeKey);
            }
            return rangeKey;
        }
    }
}