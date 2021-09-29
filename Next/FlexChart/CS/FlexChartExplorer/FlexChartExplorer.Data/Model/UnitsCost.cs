using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace FlexChartExplorer.Data
{
    public class UnitsCost
    {
        private int _cost;
        public int Units { get; set; }
        public int Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }
    }
}
