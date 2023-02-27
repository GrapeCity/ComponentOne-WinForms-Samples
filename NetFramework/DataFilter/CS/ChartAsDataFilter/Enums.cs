using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartAsDataFilter
{
    public enum SelectionMode
    {
        NormalSelect,
        RangeSelect,
    }
    public enum AggregateFunction
    {
        Sum,
        Avg,
        Max,
        Min,
    }
    public enum DateTimeGroupOption
    {
        ShowAll,
        Weekly,
        Monthly,
        Quarterly,
        Yearly,
    }
}
