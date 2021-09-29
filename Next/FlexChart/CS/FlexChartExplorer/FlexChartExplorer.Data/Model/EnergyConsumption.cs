using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class EnergyConsumption
    {
        public int Year { get; set; }
        public double Petroleum { get; set; }
        public double Renewable { get; set; }
        public double NaturalGas { get; set; }
        public double Coal { get; set; }
        public double Nuclear { get; set; }
    }
}
