using System.Globalization;

namespace InputDateRange.Services
{
    /// <summary>
    /// Interface for handling culture-specific date formatting.
    /// </summary>
    public interface IDateFormattingService
    {
        string FormatDateWithOrdinal(DateTime date, CultureInfo culture);

        string FormatDateRangeForLabel(DateTime startDate, DateTime endDate, CultureInfo culture);

        string GetDateFormatPattern(CultureInfo culture);
    }
}