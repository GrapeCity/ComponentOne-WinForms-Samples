using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Data
{
    public class TwoDDataItem
    {
        public double[,] Values { get; set; }
        public string[] CatXData { get; set; }
        public string[] CatYData { get; set; }
        public TwoDDataItem() { }
        public TwoDDataItem(double[,] values, string[] catX, string[] catY)
        {
            Values = values;
            CatXData = catX;
            CatYData = catY;
        }
    }
}
