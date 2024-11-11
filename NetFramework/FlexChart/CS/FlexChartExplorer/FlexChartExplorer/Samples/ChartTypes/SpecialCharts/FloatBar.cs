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
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class FloatBar : FlexChartBaseSample
    {
        float columnWidthPercentage = 0.8f;
        private List<CityDataItem> data;
        private FlexChart flexChart1;

        public FloatBar()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            string[] cities = { "Chicago","New York"};
            data = DataService.GetTemperatureData(cities,true,7, true);
            this.flexChart1.AxisY.Min = data.Select(x => x.Data.Min(y => y.LowTemp)).Min();
            this.flexChart1.AxisY.Max = data.Select(x => x.Data.Max(y => y.HighTemp)).Max();
            foreach(var dataItem in data)
            {
                Series series = new Series()
                {
                    Binding = "HighTemp",
                    BindingX = "Date",
                    Name = dataItem.Name,
                    DataSource = dataItem.Data,
                };
                series.SymbolRendering += Series_SymbolRendering;
                this.flexChart1.Series.Add(series);
            }

            this.flexChart1.DataLabel.Content = "{seriesName}";
            this.flexChart1.DataLabel.Position = LabelPosition.Bottom;
            this.flexChart1.LabelRendering += FlexChart1_LabelRendering;

            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.Header.Content = "Weather Report : Monthly Temperatures";
            this.flexChart1.AxisY.Format = "0 °F";
            this.flexChart1.Options.ClusterSize = new ElementSize { SizeType = ElementSizeType.Percentage, Value = columnWidthPercentage * 100 };
            this.flexChart1.DataLabel.Overlapping = LabelOverlapping.Show;
            this.flexChart1.AxisX.AxisLine = false;
        }

        private void FlexChart1_LabelRendering(object sender, RenderDataLabelEventArgs e)
        {
            var temp = (Temperature)e.Item;
            e.Text = string.Format("{0:0}:{1:0}", temp.LowTemp, temp.HighTemp);
        }

        private void Series_SymbolRendering(object sender, RenderSymbolEventArgs e)
        {
            e.Cancel = true;
            Temperature temperature = (Temperature)e.Item;
            var width = this.flexChart1.PlotRect.Width / ((List<Temperature>)this.flexChart1.Series[0].DataSource).Count * columnWidthPercentage / this.flexChart1.Series.Count;
            var bottom = 0d;
            bottom = this.flexChart1.AxisY.Convert(temperature.LowTemp);
            e.Engine.DrawRect(e.Point.X - width / 2 - 2, e.Point.Y, width - 4, bottom - e.Point.Y);
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
