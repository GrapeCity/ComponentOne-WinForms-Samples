using InputDateRange.Constants;
using InputDateRange.Helpers;
using InputDateRange.Models;

namespace InputDateRange.Services
{
    /// <summary>
    /// Service for handling date range operations and matching.
    /// </summary>
    public class DateRangeService : IDateRangeService
    {
        public DateRange? GetPredefinedRange(string rangeKey)
        {
            var calculatorRange = DateRangeCalculator.GetRange(rangeKey);
            return calculatorRange.HasValue
                ? new DateRange(calculatorRange.Value.start, calculatorRange.Value.end)
                : null;
        }

        public string? MatchPredefinedRange(DateTime startDate, DateTime endDate, int totalDays)
        {
            return DateRangeCalculator.MatchPredefinedRange(startDate, endDate, totalDays);
        }

        public List<string> GetAllRangeKeys()
        {
            return DateRangeConstants.AllRangeKeys.ToList();
        }
    }
}