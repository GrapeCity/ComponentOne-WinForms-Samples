using System.Globalization;

namespace InputDateRange.Services.Formatters
{
    public class USDateFormatter : IDateFormatter
    {
        public string ShortDatePattern => "MM/dd/yy";

        public string FormatDateLabel(DateTime date) =>
            $"{date.ToString("MMMM", CultureInfo.InvariantCulture)} {Ordinal(date.Day)}, {date.Year}";

        private string Ordinal(int day)
        {
            if (day >= 11 && day <= 13)
                return $"{day}th";

            return (day % 10) switch
            {
                1 => $"{day}st",
                2 => $"{day}nd",
                3 => $"{day}rd",
                _ => $"{day}th"
            };
        }
    }
}
