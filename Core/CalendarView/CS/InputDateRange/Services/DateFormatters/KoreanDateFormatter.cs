using System.Globalization;

namespace InputDateRange.Services.Formatters
{
    public class KoreanDateFormatter : IDateFormatter
    {
        public string ShortDatePattern => "yy-MM-dd";

        public string FormatDateLabel(DateTime date) =>
            date.ToString("yyyy년 M월 d일", CultureInfo.InvariantCulture);
    }
}
