using C1.Win.Calendar;

namespace InputDateRange.Helpers
{
    /// <summary>
    /// Helper class for highlighting selected  date ranges in the CalendarView.
    /// </summary>
    public class CalendarViewHighlighter
    {
        private readonly Color StartAndEndColor = ColorTranslator.FromHtml("#3c8ea4");
        private readonly Color MiddleColor = ColorTranslator.FromHtml("#e6eff0");

        public void HighlightSelectedRange(DayFormattingEventArgs e, DateTime first, DateTime last)
        {
            var day = e.Day.Date;

            if (day < first || day > last) return;

            if (day == first || day == last)
            {
                e.DayStyle.BackColor = StartAndEndColor;
                e.DayStyle.ForeColor = Color.White;
            }
            else
            {
                e.DayStyle.BackColor = MiddleColor;
                e.DayStyle.ForeColor = Color.Black;
            }
        }
    }
}
