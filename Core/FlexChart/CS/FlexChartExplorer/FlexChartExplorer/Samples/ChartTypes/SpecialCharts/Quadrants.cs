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
    public partial class Quadrants : FlexChartBaseSample
    {
        private FlexChart chart;

        public Quadrants()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            chart.BeginUpdate();

            chart.Series.Clear();

            var langs = new List<object> { 
                // Fast & friendly (x>5, y>5)
                new { n = "Go", x = 7.5, y = 7.5, r = 20.0 },
                new { n = "Java", x = 6.5, y = 6.0, r = 22.0 },
                new { n = "Swift", x= 6.8, y= 7.2, r= 16.0 },
                new { n = "C#", x= 6.2, y= 6.8, r= 18.0 },
                // Bare metal (x>5, y<5)
                new { n = "Rust", x= 9.2, y= 4.5, r= 20.0 },
                new { n = "C++", x= 9.5, y= 2.5, r= 22.0 },
                new { n = "C", x = 9.0, y= 2.0, r= 18.0 },
                new { n = "Zig", x= 8.0, y= 4.2, r= 12.0 },
                // Approachable (x<5, y>5)
                new { n = "Python", x= 3.5, y = 9.0, r= 26.0 },
                new { n = "JavaScript", x= 4.0, y= 7.5, r= 24.0 },
                new { n= "Ruby", x= 2.8, y= 8.0, r= 16.0 },
                // Niche (x<5, y<5)
                new { n= "Perl", x= 3.2, y= 3.5, r= 14.0 },
                new { n= "Lua", x= 4.2, y= 4.0, r= 12.0 },
                new { n= "Tcl", x= 2.2, y= 2.4, r= 10.0 },
            };

            chart.Header.Content = "Runtime performance vs ease of use, bubbles sized by adoption";
            chart.Header.HorizontalAlignment = HorizontalAlignment.Left;

            chart.Binding = "y,r";
            chart.BindingX = "x";
            chart.DataSource = langs;
            chart.Options.BubbleMinSize = 50;
            chart.Options.BubbleMaxSize = 100;

            chart.ChartType = ChartType.Bubble;

            chart.AxisX.Title = "Runtime Performance →";
            chart.AxisX.Min = 0;
            chart.AxisX.Max = 10;
            chart.AxisX.MajorTickMarks = TickMark.None;
            chart.AxisX.AxisLine = false;

            chart.AxisY.Title = "Ease of Use →";
            chart.AxisY.Min = 0;
            chart.AxisY.Max = 10;

            chart.AxisX.MajorGrid = chart.AxisY.MajorGrid = chart.AxisX.Labels = chart.AxisY.Labels = true;

            chart.PlotStyle.StrokeColor = Color.Gray;

            var zone1 = new RangeZone(Color.FromArgb(0xff, 0xf6, 0xe2), name: "Approachable", maxX: 5, minY: 5);
            chart.Series.Add(zone1);

            var zone2 = new RangeZone(Color.FromArgb(0xf3, 0xf4, 0xf7), name: "Niche", maxX: 5, maxY: 5);
            chart.Series.Add(zone2);

            var zone3 = new RangeZone(Color.FromArgb(0xe7, 0xf6, 0xec), name: "Fast & friendly", minX: 5, minY: 5);
            chart.Series.Add(zone3);

            var zone4 = new RangeZone(Color.FromArgb(0xea, 0xf0, 0xfb), name: "Bare metal", minX: 5, maxY: 5);
            chart.Series.Add(zone4);

            var series = new Series();
            series.Style.FillColor = Color.FromArgb(0x70, 0x3b, 0x6f, 0xe0);
            chart.Series.Add(series);

            chart.DataLabel.Content = "{n}";
            chart.DataLabel.Position = LabelPosition.Center;

            chart.ToolTip.Content = null;

            chart.EndUpdate();
        }

        protected override void InitializeControls()
        {
            chart = new FlexChart();
            Chart = chart;
        }
    }
}
