using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class HierarchicalDataItem
    {
        List<HierarchicalDataItem> _items;

        public string Year { get; set; }
        public string Quarter { get; set; }
        public string Month { get; set; }
        public double Value { get; set; }
        public List<HierarchicalDataItem> Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new List<HierarchicalDataItem>();
                }

                return _items;
            }
        }
    }
    public class FlatDataItem
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double Amount { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public int Day { get; set; }
    }
}
