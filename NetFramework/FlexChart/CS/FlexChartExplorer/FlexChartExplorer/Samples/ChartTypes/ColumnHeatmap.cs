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
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class ColumnHeatmap : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public ColumnHeatmap()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var clr1 = Color.FromArgb(unchecked((int)0xffa6cee3));
            var clr2 = Color.FromArgb(unchecked((int)0xfffdbf6f));

            var tempDiffData = DataService.GetTemperatureDifferenceData();
            flexChart1.DataSource = tempDiffData;
            flexChart1.Header.Content = "Temperature Difference New York vs San Francisco";
            flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            flexChart1.ToolTip.Content = "{Date:MMM-dd}\nNew York {Temp1}°C\nSan Francisco {Temp2}°C";
            flexChart1.Legend.Position = Position.Top;

            flexChart1.BindingX = "Date";

            var series1 = new Series() { Binding = "Temp1,Temp2" };
            series1.SymbolRendering += (s, e) =>
            {
                // set column color depending on temperature difference
                var clr = ((TemperatureDiff)e.Item).Diff >= 0 ? clr1.ToArgb() : clr2.ToArgb();
                e.Engine.SetFill(clr);
                e.Engine.SetStroke(clr);
            };

            // create heatmap data
            var data = new double[tempDiffData.Count, 1];
            for (int i = 0; i < tempDiffData.Count; i++)
                data[i, 0] = tempDiffData[i].Diff >= 0 ? 0 : 1;

            var gradientScale = new GradientColorScale
            {
                Min = 0,
                Max = 1,
                Colors = new List<Color> { clr1, clr2 },
            };

            var heatmap = new Heatmap() { DataSource = data, StartY = -10, StepY = 1,
                StartX = tempDiffData[0].Date.ToOADate(), StepX = 1, ColorScale = gradientScale,
                Visibility = SeriesVisibility.Plot, Tooltip = "{x:MMM-dd}"
            };

            flexChart1.AxisX.AxisLine = false;
            flexChart1.AxisX.MajorUnit = 1;
            flexChart1.AxisX.TimeUnit = TimeUnits.Month;
            flexChart1.AxisX.LabelAlignment = AxisLabelAlignment.Left;
            flexChart1.AxisX.Min = tempDiffData[0].Date.ToOADate() - 0.5;
            flexChart1.AxisX.Max = tempDiffData[tempDiffData.Count - 1].Date.ToOADate() + 0.5;

            flexChart1.AxisY.Title = "Temperature, °C";
            flexChart1.AxisY.Min = -10;
            flexChart1.AxisY.Max = 30;

            flexChart1.Series.Add(series1);
            flexChart1.Series.Add(heatmap);

            // legend items
            var legendSeries1 = new Series() { Name = "New York warmer" };
            legendSeries1.Style.FillColor =  clr2;
            flexChart1.Series.Add(legendSeries1);

            var legendSeries2 = new Series() { Name = "San Fransicco warmer" };
            legendSeries2.Style.FillColor = clr1;
            flexChart1.Series.Add(legendSeries2);
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
