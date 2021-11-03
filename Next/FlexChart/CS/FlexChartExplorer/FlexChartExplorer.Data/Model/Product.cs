using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class Product
    {
        private List<Product> _items;
        public string Name { get; set; }
        public double? Orders { get; set; }
        public List<Product> Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new List<Product>();
                }
                return _items;
            }
            set
            {
                _items = value;
            }
        }
    }
}
