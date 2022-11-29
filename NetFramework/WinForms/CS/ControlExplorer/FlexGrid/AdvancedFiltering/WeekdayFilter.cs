using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExplorer.FlexGrid.AdvancedFiltering
{
    internal class WeekdayFilter : IC1ColumnFilter
    {
        public bool Monday = true;
        public bool Tuesday = true;
        public bool Wednesday = true;
        public bool Thursday = true;
        public bool Friday = true;
        public bool Saturday = true;
        public bool Sunday = true;

        public IC1ColumnFilterEditor GetEditor()
        {
            return new WeekdayFilterEditor();
        }

        /// <summary>
        /// Reset filter to default "no filter"
        /// </summary>
        public void Reset()
        {
            Monday = true;
            Tuesday = true;
            Wednesday = true;
            Thursday = true;
            Friday = true;
            Saturday = true;
            Sunday = true;
        }

        public bool Apply(object value)
        {
            var date = (DateTime)value;
            if (date.DayOfWeek == DayOfWeek.Monday && Monday)
            {
                return true;
            }
            else if (date.DayOfWeek == DayOfWeek.Tuesday && Tuesday)
            {
                return true;
            }
            else if (date.DayOfWeek == DayOfWeek.Wednesday && Wednesday)
            {
                return true;
            }
            else if (date.DayOfWeek == DayOfWeek.Thursday && Thursday)
            {
                return true;
            }
            else if (date.DayOfWeek == DayOfWeek.Friday && Friday)
            {
                return true;
            }
            else if (date.DayOfWeek == DayOfWeek.Saturday && Saturday)
            {
                return true;
            }
            else if (date.DayOfWeek == DayOfWeek.Sunday && Sunday)
            {
                return true;
            }
            return false;
        }

        public bool IsActive
        {
            get
            {
                return !Monday || !Tuesday || !Wednesday || !Thursday ||
                  !Friday || !Saturday || !Sunday;
            }
        }
    }
}
