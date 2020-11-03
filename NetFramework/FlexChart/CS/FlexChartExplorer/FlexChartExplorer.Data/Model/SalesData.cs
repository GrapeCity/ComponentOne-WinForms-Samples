using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class SalesData
    {
        public string Name { get; set; }
        public double EstimatedValue { get; set; }
        public double ActualValue { get; set; }

        public SalesData() { }

        public SalesData(string name,double estimate,double actual)
        {
            this.Name = name;
            this.EstimatedValue = estimate;
            this.ActualValue = actual;
        }
    }
    public class SeasonSale
    {
        public string Name { get; set; }
        public double WinterOnline { get; set; }
        public double WinterOffline { get; set; }
        public double SummerOnline { get; set; }
        public double SummerOffline { get; set; }
        public double TotalSales
        {
            get
            {
                return WinterOnline + WinterOffline + SummerOffline + SummerOnline;
            }
        }
        public double WinterTotal { get { return WinterOnline + WinterOffline; } }
        public double SummerTotal { get { return SummerOnline + SummerOffline; } }
        public double OnlineTotal { get { return WinterOnline + SummerOnline; } }
        public double OfflineTotal { get { return WinterOffline + SummerOffline; } }
    }
}
