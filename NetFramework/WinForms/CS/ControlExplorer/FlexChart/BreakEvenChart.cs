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

namespace ControlExplorer.FlexChart
{
    public partial class BreakEvenChart : C1DemoForm
    {
        private C1.Win.Chart.FlexChart flexChart1;

        public BreakEvenChart()
        {
            flexChart1 = new C1.Win.Chart.FlexChart();
            flexChart1.Series.Add(new BreakEven() { SalesPrice = 120, FixedCost = 1000000, VariableCost = 20 });
            flexChart1.Legend.Position = Position.Right;
            flexChart1.AxisX.Title = "Number Of Units";
            flexChart1.AxisY.Title = "USD";
            this.Controls.Add(flexChart1);
        }

    }
}
