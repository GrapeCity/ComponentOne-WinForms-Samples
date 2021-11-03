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
    public partial class GradientColors : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public GradientColors()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Average Temperature By Month";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            var data = DataService.Get2DTempData();
            
            var gradientScale = new GradientColorScale
            {
                Min = -30,
                Max = 30,
                Colors = new List<Color>
                {
                    Color.Blue,
                    Color.NavajoWhite,
                    Color.Red,
                }
            };
            var heatmap = new Heatmap()
            {
                ColorScale = gradientScale,
                DataSource = data.Values,
            };
            this.flexChart1.Series.Add(heatmap);

            this.flexChart1.DataLabel.Content = "{item:0.0}";
            this.flexChart1.DataLabel.Position = LabelPosition.Center;
            this.flexChart1.ToolTip.Active = false;

            this.flexChart1.AxisX.Position = Position.Top;
            this.flexChart1.AxisY.Min = heatmap.StartX;
            this.flexChart1.AxisY.Max = data.Values.GetLength(0) + heatmap.StartX;
            this.flexChart1.AxisY.MajorGrid = false;
            this.flexChart1.AxisY.AxisLine = true;

            this.flexChart1.AxisX.DataSource = data.CatXData;
            this.flexChart1.AxisY.DataSource = data.CatYData;
            this.flexChart1.Rotated = true;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            this.pnlControls.Hide();
        }
    }
}
