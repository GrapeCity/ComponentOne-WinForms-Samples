using InputDateRange.Services.Formatters;
using System.Globalization;

namespace InputDateRange.Services
{
    /// <summary>
    /// Factory that maps a CultureInfo to its corresponding IDateFormatter.
    /// Each formatter is cached as a singleton — register new cultures here.
    /// </summary>
    public class DateFormatterFactory
    {
        private readonly Dictionary<string, IDateFormatter> _formattersByCulture = new()
        {
            ["en-US"] = new USDateFormatter(),
            ["ko-KR"] = new KoreanDateFormatter(),
            ["ja-JP"] = new JapaneseDateFormatter(),
        };

        public IDateFormatter CreateDateFormat(CultureInfo culture) =>
            _formattersByCulture.TryGetValue(culture.Name, out var formatter) 
            ? formatter
            : (_formattersByCulture.TryGetValue("en-US", out var fallback) ? fallback : new USDateFormatter());
    }
}
