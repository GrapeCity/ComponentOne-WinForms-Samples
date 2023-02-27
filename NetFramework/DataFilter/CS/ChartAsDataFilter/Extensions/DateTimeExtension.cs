using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartAsDataFilter
{
    public static class DateTimeExtensions
    {
        static GregorianCalendar _gc = new GregorianCalendar();
        public static int GetQuarterNumber(this DateTime date)
        {
            return (date.Date.Month - 1) / 3 + 1;
        }
        public static DateTime GetFirstDateOfQuarter(this DateTime date)
        {
            return new DateTime(date.Date.Year, (date.GetQuarterNumber() - 1) * 3 + 1, 1);
        }
        public static DateTime GetLastDateOfQuarter(this DateTime date)
        {
            return date.GetFirstDateOfQuarter().AddMonths(3).AddDays(-1);
        }
        public static int GetWeekOfMonth(this DateTime date)
        {
            var first = new DateTime(date.Year, date.Month, 1);
            return date.GetWeekOfYear() - first.GetWeekOfYear() + 1;
        }
        public static DateTime GetFirstDateOfWeek(this DateTime date)
        {
            var monthFirst = new DateTime(date.Year, date.Month, 1);
            var offset = (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek - (int)monthFirst.DayOfWeek;
            var weekNum = date.GetWeekOfMonth();
            return weekNum==1?monthFirst: monthFirst.AddDays((weekNum - 1) * 7 + offset);
        }
        public static DateTime GetLastDateOfWeek(this DateTime date)
        {
            var firstDate = date.GetFirstDateOfWeek();
            var lastDate = firstDate.AddDays(6 - (int)firstDate.DayOfWeek);
            return lastDate.Month != date.Month ? new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month)) : lastDate;
        }
        public static int GetWeekOfYear(this DateTime date)
        {
            return _gc.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }
    }
}
