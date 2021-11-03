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
using C1.Win.Chart.Extended;

namespace Samples
{
    public partial class Loading : UserControl
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            var chart = new FlexChart();
            chart.Legend.Position = Position.Bottom;
            chart.Dock = DockStyle.Fill;
            chart.AxisX.MajorGrid = false;
            chart.AxisX.MinorGrid = true;
            chart.AxisX.MajorTickMarks = TickMark.None;
            chart.AxisX.AxisLine = false;
            chart.AxisX.MinorGridStyle.StrokeColor = Color.LightGray;
            chart.AxisY.MajorGrid = false;
            chart.AxisY.MinorGrid = true;
            chart.AxisY.MinorGridStyle.StrokeColor = Color.LightGray;
            chart.Header.Content = "Weekly traffic intensity";
            chart.Header.Style.Font = new Font("Seqoe UI", 16);

            chart.ToolTip.Content = "{item:0.0}%";

            var scale = new DiscreteColorScale() { Intervals = new List<DiscreteColorScale.Interval>() };
            scale.Intervals.Add(new DiscreteColorScale.Interval(0, 10, Color.FromArgb(unchecked((int)0xFF0571B0)), "Very Low"));
            scale.Intervals.Add(new DiscreteColorScale.Interval(10, 25, Color.FromArgb(unchecked((int)0xFF92C5DE)), "Low"));
            scale.Intervals.Add(new DiscreteColorScale.Interval(25, 75, Color.FromArgb(unchecked((int)0xFFF7F7F7)), "Normal"));
            scale.Intervals.Add(new DiscreteColorScale.Interval(75, 90, Color.FromArgb(unchecked((int)0xFFF4A582)), "High"));
            scale.Intervals.Add(new DiscreteColorScale.Interval(90, 100, Color.FromArgb(unchecked((int)0xFFCA0020)), "Critical"));

            // generated some random data
            var rnd = new Random();
            var data = new double[24, 7];
            for (var j = 0; j < 7; j++)
                for (var i = 0; i < 24; i++)
                    data[i, j] = 10 * Math.Exp(-(i - 12) * (i - 12) / (2 * 4.0 * 4.0)) / Math.Sqrt(2 * Math.PI * 4.0 * 4.0) * ((j == 5 || j == 6) ? 50 : 100) * rnd.NextDouble();

            var hmap = new Heatmap();
            hmap.DataSource = data;
            hmap.ColorScale = scale;
            chart.Series.Add(hmap);

            var times = new string[24];
            for (var i = 0; i < 24; i++)
                times[i] = new DateTime(2000, 1, 1, i, 0, 0).ToShortTimeString();
            chart.AxisX.DataSource = times;
            chart.AxisX.LabelAngle = 45;

            chart.AxisY.DataSource = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            chart.AxisY.Reversed = true;

            Controls.Add(chart);
        }
    }
}
