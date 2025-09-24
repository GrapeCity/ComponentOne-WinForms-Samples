using System.Globalization;

namespace InputDateRange.Models
{
    /// <summary>
    /// Value object representing the current state of the calendar selection.
    /// </summary>
    public readonly record struct CalendarState
    {
        public DateRange? SelectedRange { get; init; }
        public List<DateTime> SelectedDates { get; init; }
        public CultureInfo Culture { get; init; }
        public DateTime MinDate { get; init; }
        public DateTime MaxDate { get; init; }
        public int MaxSelectionCount { get; init; }

        public CalendarState(
            DateRange? selectedRange = null,
            List<DateTime>? selectedDates = null,
            CultureInfo? culture = null,
            DateTime? minDate = null,
            DateTime? maxDate = null,
            int maxSelectionCount = 366)
        {
            SelectedRange = selectedRange;
            SelectedDates = selectedDates ?? new List<DateTime>();
            Culture = culture ?? new CultureInfo("en-US");
            MinDate = minDate ?? DateTime.Today.AddYears(-10);
            MaxDate = maxDate ?? DateTime.Today.AddYears(10);
            MaxSelectionCount = maxSelectionCount;
        }

        public bool HasSelection => SelectedDates.Count > 0;

        public int TotalSelectedDays => SelectedDates.Count;
    }
}