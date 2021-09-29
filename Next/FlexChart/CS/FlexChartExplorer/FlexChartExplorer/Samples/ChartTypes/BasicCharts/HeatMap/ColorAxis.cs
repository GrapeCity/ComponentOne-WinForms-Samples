using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexChartExplorer.Data;
using C1.Win.Chart.Extended;
using C1.Chart;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class ColorAxis : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public ColorAxis()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "2D Deformation Distribution";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            var data = DataService.Get2DDeformationData();

            var gradientScale = new GradientColorScale
            {
                Min=0,
                Max=4,
                Colors = new List<Color> { Color.Red, Color.Yellow },
                Axis = new C1.Win.Chart.Extended.ColorAxis { Position = Position.Right }
            };
            var heatmap = new Heatmap
            {
                ColorScale = gradientScale,
                DataSource = data.Values,
            };
            this.flexChart1.Series.Add(heatmap);
            this.flexChart1.Legend.Position = Position.None;

            this.flexChart1.AxisX.Min = heatmap.StartX;
            this.flexChart1.AxisX.Max = data.Values.GetLength(0) + heatmap.StartX;
            this.flexChart1.AxisY.MajorGrid = false;
            this.flexChart1.ToolTip.Content = "{item:0.0}";
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            this.pnlControls.Hide();
        }
    }
}
