namespace InputDateRange.Models
{
    /// <summary>
    /// Value object representing a date range with start and end dates.
    /// </summary>
    public readonly record struct DateRange(DateTime StartDate, DateTime EndDate)
    {
        public bool IsValid => StartDate <= EndDate;

        public IEnumerable<DateTime> GetDatesInRange()
        {
            if (!IsValid) yield break;

            for (var date = StartDate; date <= EndDate; date = date.AddDays(1))
            {
                yield return date;
            }
        }
    }
}