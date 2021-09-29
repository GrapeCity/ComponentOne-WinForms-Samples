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
using C1.Win.Chart.Extended;

namespace Samples
{
    public partial class Temperature : UserControl
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private void Temperature_Load(object sender, EventArgs e)
        {
            var chart = new FlexChart();
            chart.Dock = DockStyle.Fill;
            chart.AxisY.MajorGrid = false;
            chart.AxisX.AxisLine = false;
            chart.AxisX.MajorTickMarks = C1.Chart.TickMark.None;
            chart.Header.Content = "Average temperature by month";
            chart.Header.Style.Font = new Font("Seqoe UI", 16);
            chart.Rotated = true;

            chart.PlotStyle.StrokeColor = Color.LightGray;
            chart.PlotStyle.StrokeWidth = 1;

            var scale = new GradientColorScale();
            scale.Colors = new List<Color> { Color.Blue, Color.White, Color.Red };
            scale.Min = -30;
            scale.Max = 30;

            var hmap = new Heatmap();
            hmap.DataSource = new double[,] {
                {  3.0, 3.1, 5.7, 8.2, 12.5, 15.0, 17.1, 17.1, 14.3, 10.6, 6.6, 4.3 },
                { -9.3, -7.7, -2.2, 5.8, 13.1, 16.6, 18.2, 16.4, 11.0, 5.1, -1.2, -6.1},
                 { -15.1, -12.5, -5.2, 3.1, 10.1, 15.5, 18.3, 15.0, 9.4, 1.4, -5.6, -11.4},
                };
            hmap.ColorScale = scale;
            hmap.DataLabel = new DataLabel();
            hmap.DataLabel.Position = C1.Chart.LabelPosition.Center;
            hmap.DataLabel.Content = "{item}";
            chart.Series.Add(hmap);

            chart.AxisX.DataSource = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            chart.AxisY.DataSource = new string[] { "Amsterdam", "Moscow", "Perm" };

            this.Controls.Add(chart);
        }
    }
}
