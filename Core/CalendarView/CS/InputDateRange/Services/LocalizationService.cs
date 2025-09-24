using InputDateRange.Constants;
using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace InputDateRange.Services
{
    /// <summary>
    /// Service for handling localization and resource management.
    /// </summary>
    public class LocalizationService : ILocalizationService
    {
        private CultureInfo _currentCulture;
        private ComponentResourceManager _resourceManager;

        public CultureInfo CurrentCulture => _currentCulture;

        public LocalizationService()
        {
            _currentCulture = new CultureInfo("en-US");
            _resourceManager = new ComponentResourceManager(typeof(Form1));
        }

        public void SetCulture(CultureInfo culture)
        {
            _currentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            _resourceManager = new ComponentResourceManager(typeof(Form1));
        }

        public string GetString(string key, string? fallback = null)
        {
            return _resourceManager.GetString(key) ?? fallback ?? key;
        }

        public Dictionary<string, string> GetAllRangeDisplayTexts()
        {
            var result = new Dictionary<string, string>();

            foreach (var kvp in DateRangeConstants.RangeKeyToResourceKey)
            {
                var displayText = GetString(kvp.Value, kvp.Key);
                result[kvp.Key] = displayText;
            }

            return result;
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