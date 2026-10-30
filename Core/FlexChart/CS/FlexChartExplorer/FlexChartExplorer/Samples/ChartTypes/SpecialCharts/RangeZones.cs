using BaseExplorer;
using C1.Chart;
using C1.Win.Chart;
using C1.Win.Chart.Palettes;
using FlexChartExplorer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FlexChartExplorer.Samples
{
    public partial class RangeZones : FlexChartBaseSample
    {
        private FlexChart chart;

        public RangeZones()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            chart.BeginUpdate();

            chart.Header.Content = "Ping";
            chart.Header.HorizontalAlignment = HorizontalAlignment.Left;

            var zone1 = new RangeZone(Color.FromArgb(0xe7, 0xf6, 0xec), name: "Good", maxY: 100);
            chart.Series.Add(zone1);

            var zone2 = new RangeZone(Color.FromArgb(0xff, 0xf6, 0xe2), name: "Fair", minY: 100, maxY: 200);
            chart.Series.Add(zone2);

            var zone3 = new RangeZone(Color.FromArgb(0xfd, 0xea, 0xea), name: "Poor", minY: 200);
            chart.Series.Add(zone3);

            foreach (var zone in new RangeZone[] { zone1, zone2, zone3 })
                zone.DataLabel.Position = LabelPosition.Right;

            var start = DateTime.Now.AddHours(-3);
            var duration = TimeSpan.FromHours(3);
            var interval = TimeSpan.FromSeconds(60);

            var data1 = DataService.GeneratePingData(new PingSampleProfile
            {
                BaseLatencyMs = 18,
                JitterMs = 5,
                SpikeChance = 0.02,
                PacketLossChance = 0.002
            }, start: start, duration: duration, interval: interval);

            var data2 = DataService.GeneratePingData(new PingSampleProfile
            {
                BaseLatencyMs = 85,
                JitterMs = 18,
                SpikeChance = 0.05,
                PacketLossChance = 0.01
            }, start: start, duration: duration, interval: interval);

            chart.Binding = "LatencyMs";
            chart.BindingX = "Timestamp";

            chart.ChartType = ChartType.Line;

            var series1 = new Series() { DataSource = data1, Name = "8.8.8.8 (Google)" };
            series1.Style.Stroke = Qualitative.Dark2[0];

            var series2 = new Series() { DataSource = data2, Name = "1.1.1.1 (Cloudflare)" };
            series2.Style.Stroke = Qualitative.Dark2[2];

            chart.Series.Add(series1);
            chart.Series.Add(series2);

            chart.AxisX.Title = "Time →";
            chart.AxisY.Title = "Ping, ms →";

            chart.AxisX.MajorGrid = chart.AxisY.MajorGrid = true;
            chart.AxesOnTop = true;

            chart.Legend.Position = Position.Top;

            chart.EndUpdate();

        }

        protected override void InitializeControls()
        {
            chart = new FlexChart();
            Chart = chart;
        }
    }
}
