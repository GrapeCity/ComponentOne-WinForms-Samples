namespace InputDateRange.Models
{
    /// <summary>
    /// Value object representing a date range with start and end dates.
    /// </summary>
    public readonly record struct DateRange(DateTime StartDate, DateTime EndDate)
    {
        public int TotalDays => (EndDate - StartDate).Days + 1;

        public bool IsValid => StartDate <= EndDate;

        public IEnumerable<DateTime> GetDatesInRange()
        {
            if (!IsValid) yield break;

            for (var date = StartDate; date <= EndDate; date = date.AddDays(1))
            {
                yield return date;
            }
        }

        public bool Contains(DateTime date) => date >= StartDate && date <= EndDate;

        public static DateRange Create(DateTime startDate, DateTime endDate) => new(startDate, endDate);
    }
}