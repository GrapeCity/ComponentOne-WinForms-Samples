using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class SymbolColor : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public SymbolColor()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Scatter;

            var series = new Series()
            {
                DataSource = DataService.CreateDataPoints(x => Math.Sin(0.1 * x), y => Math.Cos(0.15 * y), 360),
                Binding = "Y",
                BindingX = "X",
            };
            this.flexChart1.Series.Add(series);

            series.SymbolRendering += (s, e) =>
            {
                var y = ((PointD)e.Item).Y;
                var r = y >= 0 ? 255 : (255 * (1 + y));
                var b = y < 0 ? 255 : (255 * (1 - y));
                var g = (1 - Math.Abs(y)) * 255;
                e.Engine.SetFill(Color.FromArgb((int)r, (int)g, (int)b).ToArgb());
                e.Engine.SetStroke(null);
            };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
