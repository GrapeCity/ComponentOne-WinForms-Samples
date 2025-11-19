using System.Globalization;

namespace InputDateRange.Services
{
    /// <summary>
    /// Interface for handling localization and resource management.
    /// </summary>
    public interface ILocalizationService
    {
        CultureInfo CurrentCulture { get; }

        void SetCulture(CultureInfo culture);

        string GetString(string key, string? fallback = null);

        string GetRangeKeyFromDisplayText(string displayText);

        string GetDisplayTextFromRangeKey(string rangeKey);
    }
}