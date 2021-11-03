using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class YFunctionSeriesSample : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public YFunctionSeriesSample()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var functionSeries = new YFunctionSeries();
            functionSeries.Name = "Y-Function Series";
            functionSeries.SampleCount = 300;
            functionSeries.Min = -10;
            functionSeries.Max = 10;
            functionSeries.Function = Calculate;
            this.flexChart1.Series.Add(functionSeries);
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
        private double Calculate(double x)
        {
            return Math.Sin(4 * x) * Math.Cos(3 * x);
        }
    }
}
