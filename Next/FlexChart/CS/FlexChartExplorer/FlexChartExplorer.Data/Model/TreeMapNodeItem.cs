using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class TreeMapNodeItem
    {
        private double _currentSales, _prevSales;
        public string Type { get; set; }
        public double CurrentSales
        {
            get
            {
                if (Items != null)
                    _currentSales = Items.Sum(x => x.CurrentSales);
                return _currentSales;
            }
            set
            {
                if (Items == null)
                    _currentSales = value;
            }
        }
        public double PreviousSales
        {
            get
            {
                if (Items != null)
                    _prevSales = Items.Sum(x => x.PreviousSales);
                return _prevSales;
            }
            set
            {
                if (Items == null)
                    _prevSales = value;
            }
        }
        public TreeMapNodeItem[] Items { get; set; }
    }
}
