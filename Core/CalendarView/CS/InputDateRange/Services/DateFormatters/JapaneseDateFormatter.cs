using System.Globalization;

namespace InputDateRange.Services.Formatters
{
    public class JapaneseDateFormatter : IDateFormatter
    {
        public string ShortDatePattern => "yy/MM/dd";

        public string FormatDateLabel(DateTime date) =>
            date.ToString("yyyy年M月d日", CultureInfo.InvariantCulture);
    }
}
