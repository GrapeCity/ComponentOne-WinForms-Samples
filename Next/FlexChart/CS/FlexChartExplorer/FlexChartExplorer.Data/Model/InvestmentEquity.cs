using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class InvestmentEquity
    {
        public int Age { get; set; }
        public double Amount { get; set; }

        public double Rate { get; set; }
        public double Return
        {
            get
            {
                return CalculateReturn();
            }
        }

        private double CalculateReturn()
        {
            var gain = Amount * Rate;
            return (gain - Amount) / (float)Amount;
        }

    }
}
