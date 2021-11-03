using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyComparison.Model
{
    class Currency
    {
        public string DisplayName { get; set; }
        public string Symbol { get; set; }
        public ChartSeries ExchangeRateSeries { get; set; }
        public ChartSeries PercentageChangeSeries { get; set; }
    }
}
