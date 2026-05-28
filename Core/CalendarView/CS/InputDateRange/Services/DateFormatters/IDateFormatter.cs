namespace InputDateRange.Services.Formatters
{
    /// <summary>
    /// Interface for culture-specific date formatting strategies.
    /// Add a new culture by implementing this and registering it in DateFormatterFactory.
    /// </summary>
    public interface IDateFormatter
    {
        string ShortDatePattern { get; }
        string FormatDateLabel(DateTime date);
    }
}
