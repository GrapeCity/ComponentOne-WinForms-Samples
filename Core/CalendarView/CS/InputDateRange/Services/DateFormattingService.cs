using System.Globalization;

namespace InputDateRange.Services
{
    /// <summary>
    /// Service for handling culture-specific date formatting.
    /// </summary>
    public class DateFormattingService : IDateFormattingService
    {
        public string FormatDateWithOrdinal(DateTime date, CultureInfo culture)
        {
            return culture.Name switch
            {
                "en-US" => $"{GetOrdinalDay(date.Day)} {date.ToString("MMM", culture)}, {date.Year}",
                "ko-KR" => date.ToString("yyyy년 M월 d일", culture),
                "ja-JP" => date.ToString("yyyy年M月d日", culture),
                _ => $"{GetOrdinalDay(date.Day)} {date.ToString("MMM", culture)}, {date.Year}"
            };
        }

        public string FormatDateRangeForLabel(DateTime startDate, DateTime endDate, CultureInfo culture)
        {
            var formatPattern = GetDateFormatPattern(culture);
            return $"{startDate.ToString(formatPattern)}     -     {endDate.ToString(formatPattern)}";
        }

        public string GetDateFormatPattern(CultureInfo culture)
        {
            return culture.Name switch
            {
                "en-US" => "MM/dd/yy",
                "ko-KR" => "yy-MM-dd",
                "ja-JP" => "yy/MM/dd",
                _ => "MM/dd/yy"
            };
        }

        private static string GetOrdinalDay(int day)
        {
            if (day >= 11 && day <= 13)
                return $"{day}th";

            int lastDigit = day % 10;
            return lastDigit switch
            {
                1 => $"{day}st",
                2 => $"{day}nd",
                3 => $"{day}rd",
                _ => $"{day}th"
            };
        }
    }
}