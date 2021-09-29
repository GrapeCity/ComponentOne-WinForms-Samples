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
    public partial class ColorAxis : UserControl
    {
        public ColorAxis()
        {
            InitializeComponent();
        }

        private void ColorAxis_Load(object sender, EventArgs e)
        {
            var chart = new FlexChart();
            chart.Legend.Position = Position.None;
            chart.Dock = DockStyle.Fill;
            chart.AxisY.Title = "y";
            chart.AxisY.MajorGrid = false;
            chart.AxisY.AxisLine = true;
            chart.AxisY.MajorTickMarks = TickMark.Outside;
            chart.AxisX.Title = "x";
            chart.ToolTip.Content = "{item:0.00}";
            chart.Header.Content = "2D deformation distribution";
            chart.Header.Style.Font = new Font("Seqoe UI", 16);

            var scale = new GradientColorScale()
            {
                Min = 0,
                Max = 4,
                Axis = new C1.Win.Chart.Extended.ColorAxis()
                { Position = Position.Right, Title = "deformation, mm" },
                Colors = new List<Color> { Color.Yellow, Color.Red }
            };

            var data = new double[150, 150];
            for (var i = 0; i < 150; i++)
                for (var j = 0; j < 150; j++)
                    data[i, j] =  2 + (Math.Sin(0.01 * i) + Math.Cos(0.1 * j));

            var hmap = new Heatmap();
            hmap.DataSource = data;
            hmap.ColorScale = scale;
            hmap.StartX = 0;
            hmap.StartY = 0;
            chart.Series.Add(hmap);

            Controls.Add(chart);
        }
    }
}
