using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class Task
    {
        private DateTime _start, _end;
        public string Name { get; set; }
        public DateTime Start { get { return _start; } set { _start = value; } }
        public double DurationInDays { get { return _end.Subtract(_start).TotalDays; } }
        public double DurationInHours { get { return _end.Subtract(_start).TotalHours; } }
        public double DurationInWeeks { get { return Math.Round(_end.Subtract(_start).TotalDays / 7); } }
        public DateTime End { get { return _end; } set { _end = value; } }
    }
}
