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
    public partial class DiscreteColors : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public DiscreteColors()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Weekly Traffic Intensity";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            var data = DataService.Get2DTrafficData();

            var discreteScale = new DiscreteColorScale
            {
                Intervals = new List<DiscreteColorScale.Interval>
                {
                    new DiscreteColorScale.Interval(0, 10, Color.FromArgb(0x05,0x71,0xB0), "Very Low"),
                    new DiscreteColorScale.Interval(10, 25, Color.FromArgb(0x92, 0xC5, 0xDE), "Low"),
                    new DiscreteColorScale.Interval(25, 75, Color.FromArgb(0xD7, 0xD7, 0xD7), "Normal"),
                    new DiscreteColorScale.Interval(75, 90, Color.FromArgb(0xF4, 0xA5, 0x82), "High"),
                    new DiscreteColorScale.Interval(90, 100, Color.FromArgb(0xCA, 0x00, 0x20), "Critical"),
                }
            };
            var heatmap = new Heatmap
            {
                ColorScale = discreteScale,
                DataSource = data.Values,
            };
            this.flexChart1.Series.Add(heatmap);

            this.flexChart1.AxisX.Min = heatmap.StartX;
            this.flexChart1.AxisX.Max = data.Values.GetLength(0) + heatmap.StartX;

            this.flexChart1.AxisX.MinorGrid = true;
            this.flexChart1.AxisX.MinorGridStyle.StrokeColor = Color.White;
            this.flexChart1.AxisX.LabelAngle = 45;

            this.flexChart1.AxisY.MajorGrid = false;
            this.flexChart1.AxisY.MinorGrid = true;
            this.flexChart1.AxisY.MinorGridStyle.StrokeColor = Color.White;
            
            this.flexChart1.AxisX.DataSource = data.CatXData;
            this.flexChart1.AxisY.DataSource = data.CatYData;
            this.flexChart1.ToolTip.Content = "{item:0.00} %";
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            this.pnlControls.Hide();
        }
    }
}
