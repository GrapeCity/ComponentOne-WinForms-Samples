using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class BreakEvenChart : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public BreakEvenChart()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            flexChart1.Series.Add(new BreakEven() { SalesPrice = 120, FixedCost = 1000000, VariableCost = 20 });
            flexChart1.Legend.Position = Position.Right;
            flexChart1.AxisX.Title = "Number Of Units";
            flexChart1.AxisY.Title = "USD";
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
        }
    }
}
