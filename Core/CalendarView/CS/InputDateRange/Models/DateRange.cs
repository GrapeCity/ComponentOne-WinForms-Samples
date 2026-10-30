namespace InputDateRange.Models
{
    /// <summary>
    /// Model class representing a date range with a start and end date. 
    /// It includes validation to ensure the start date is not after the end date, and a method to retrieve all dates within the range.
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