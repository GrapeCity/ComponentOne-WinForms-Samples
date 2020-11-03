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
    public partial class ParametricFunctionSeriesSample : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public ParametricFunctionSeriesSample()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var functionSeries = new ParametricFunctionSeries();
            functionSeries.Name = "Parametric Function Series";
            functionSeries.SampleCount = 1000;
            functionSeries.Max = 2 * Math.PI;
            functionSeries.XFunction = CalculateX;
            functionSeries.YFunction = CalculateY;
            this.flexChart1.Series.Add(functionSeries);

            this.flexChart1.AxisX.Min = -1.5;
            this.flexChart1.AxisX.Max = 1.5;
            this.flexChart1.AxisX.MajorUnit = 0.2;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1; 
        }
        private double CalculateX(double v)
        {
            return Math.Cos(5 * v);
        }
        private double CalculateY(double v)
        {
            return Math.Sin(7 * v);
        }
    }
}
