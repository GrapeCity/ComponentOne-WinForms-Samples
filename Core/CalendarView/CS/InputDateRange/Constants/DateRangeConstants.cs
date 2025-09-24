namespace InputDateRange.Constants
{
    /// <summary>
    /// Constants for date range operations and predefined ranges.
    /// </summary>
    public static class DateRangeConstants
    {
        // Predefined range keys (English)
        public const string CustomRange = "Custom Range";
        public const string ThisWeek = "This Week";
        public const string LastWeek = "Last Week";
        public const string NextWeek = "Next Week";
        public const string ThisMonth = "This Month";
        public const string LastMonth = "Last Month";
        public const string NextMonth = "Next Month";
        public const string ThisYear = "This Year";
        public const string LastYear = "Last Year";
        public const string NextYear = "Next Year";

        // Resource keys for localization
        public const string CustomRangeKey = "customRange";
        public const string ThisWeekKey = "thisWeek";
        public const string LastWeekKey = "lastWeek";
        public const string NextWeekKey = "nextWeek";
        public const string ThisMonthKey = "thisMonth";
        public const string LastMonthKey = "lastMonth";
        public const string NextMonthKey = "nextMonth";
        public const string ThisYearKey = "thisYear";
        public const string LastYearKey = "lastYear";
        public const string NextYearKey = "nextYear";

        // Default values
        public const int DefaultMaxSelectionCount = 366;
        public const int DefaultDateLimitYears = 10;
        public const int DefaultCornerRadius = 10;
        public const int DefaultListBoxItemPadding = 8;

        // Default messages
        public const string NoStartDateText = "No selected start date";
        public const string NoEndDateText = "No selected end date";
        public const string StartEndDatePlaceholder = "Start Date     -     End Date";

        public static readonly List<string> AllRangeKeys = new()
        {
            CustomRange, ThisWeek, LastWeek, NextWeek,
            ThisMonth, LastMonth, NextMonth,
            ThisYear, LastYear, NextYear
        };

        public static readonly Dictionary<string, string> RangeKeyToResourceKey = new()
        {
            { CustomRange, CustomRangeKey },
            { ThisWeek, ThisWeekKey },
            { LastWeek, LastWeekKey },
            { NextWeek, NextWeekKey },
            { ThisMonth, ThisMonthKey },
            { LastMonth, LastMonthKey },
            { NextMonth, NextMonthKey },
            { ThisYear, ThisYearKey },
            { LastYear, LastYearKey },
            { NextYear, NextYearKey }
        };
    }
}