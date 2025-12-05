namespace InputDateRange.Helpers
{
    public static class DateRangeCalculator
    {
        // This is a private dictionary that maps range names to functions
        // that calculate the start and end dates.
        private static readonly Dictionary<string, Func<DateTime, (DateTime start, DateTime end)>> _rangeCalculators = new()
        {
            { "This Week", today => (StartOfWeek(today), StartOfWeek(today).AddDays(6)) },
            { "Last Week", today => (StartOfWeek(today).AddDays(-7), StartOfWeek(today).AddDays(-1)) },
            { "Next Week", today => (StartOfWeek(today).AddDays(7), StartOfWeek(today).AddDays(13)) },
            { "This Month", today => (new DateTime(today.Year, today.Month, 1), new DateTime(today.Year, today.Month, 1).AddMonths(1).AddDays(-1)) },
            { "Last Month", today => (new DateTime(today.Year, today.Month, 1).AddMonths(-1), new DateTime(today.Year, today.Month, 1).AddDays(-1)) },
            { "Next Month", today => (new DateTime(today.Year, today.Month, 1).AddMonths(1), new DateTime(today.Year, today.Month, 1).AddMonths(2).AddDays(-1)) },
            { "This Year", today => (new DateTime(today.Year, 1, 1), new DateTime(today.Year, 12, 31)) },
            { "Last Year", today => (new DateTime(today.Year - 1, 1, 1), new DateTime(today.Year - 1, 12, 31)) },
            { "Next Year", today => (new DateTime(today.Year + 1, 1, 1), new DateTime(today.Year + 1, 12, 31)) }
        };

        // This method retrieves a range by its name by invoking the corresponding function.
        public static (DateTime start, DateTime end)? GetRange(string rangeName)
        {
            return _rangeCalculators.TryGetValue(rangeName, out var calculator)
                ? calculator(DateTime.Today)
                : null;
        }

        // This method finds the name of a predefined range that matches the given dates.
        public static string? MatchPredefinedRange(DateTime selectedStart, DateTime selectedEnd, int totalDays)
        {
            var today = DateTime.Today;

            foreach (var kvp in _rangeCalculators)
            {
                var (start, end) = kvp.Value(today);
                if (selectedStart == start && selectedEnd == end && totalDays == (end - start).Days + 1)
                {
                    return kvp.Key;
                }
            }
            return null;
        }

        private static DateTime StartOfWeek(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Sunday)) % 7;
            return date.AddDays(-diff).Date;
        }
    }
}