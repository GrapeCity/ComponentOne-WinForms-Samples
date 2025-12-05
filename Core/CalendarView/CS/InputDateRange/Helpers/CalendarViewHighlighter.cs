using C1.Win.Calendar;

namespace InputDateRange.Helpers
{
    public static class CalendarViewHighlighter
    {
        public static void HighlightSelectedRange(DayFormattingEventArgs e, IEnumerable<DateTime> selectedDates)
        {
            var ordered = selectedDates.OrderBy(d => d).ToList();
            var day = e.Day.Date;

            if (!ordered.Contains(day)) return;

            if (day == ordered.First() && day == ordered.Last())
            {
                e.DayStyle.BackColor = ColorTranslator.FromHtml("#3c8ea4");
                e.DayStyle.ForeColor = Color.White;
            }
            else if (day > ordered.First() && day < ordered.Last())
            {
                e.DayStyle.BackColor = ColorTranslator.FromHtml("#e6eff0");
                e.DayStyle.ForeColor = Color.Black;
            }
        }
    }
}
