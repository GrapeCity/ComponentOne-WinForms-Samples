using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyComparison.Model
{
    class ChartSeries : C1.Win.Chart.Series
    {
        public bool IsPercentage
        { get; set; }
    }
}
