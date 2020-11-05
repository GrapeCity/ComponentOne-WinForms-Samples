using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class Temperature
    {
        public DateTime Date { get; set; }
        public double HighTemp { get; set; }
        public double LowTemp { get; set; }
        public double Precipitation { get; set; }
    }
    public class CityDataItem
    {
        private List<Temperature> _data;
        public string Name { get; set; }
        public List<Temperature> Data
        {
            get
            {
                if (_data == null)
                {
                    _data = new List<Temperature>();
                }
                return _data;
            }
        }
    }
}
