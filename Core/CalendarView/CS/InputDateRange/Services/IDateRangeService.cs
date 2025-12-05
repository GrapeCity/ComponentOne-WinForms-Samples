using InputDateRange.Models;

namespace InputDateRange.Services
{
    /// <summary>
    /// Interface for handling date range operations and matching.
    /// </summary>
    public interface IDateRangeService
    {
        DateRange? GetPredefinedRange(string rangeKey);

        string? MatchPredefinedRange(DateTime startDate, DateTime endDate, int totalDays);

        List<string> GetAllRangeKeys();
    }
}