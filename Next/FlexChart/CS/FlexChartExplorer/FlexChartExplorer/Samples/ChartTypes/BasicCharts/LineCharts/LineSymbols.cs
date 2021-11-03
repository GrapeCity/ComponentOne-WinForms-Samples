using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using FlexChartExplorer.Data;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class LineSymbols : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public LineSymbols()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.LineSymbols;
            this.flexChart1.Header.Content = "Major News Resources";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = DataService.GetNewsSourcesInfo();
            this.flexChart1.BindingX = "Year";
            var tv = new Series
            {
                Name = "Television",
                Binding = "TV",
            };
            var newspaper = new Series
            {
                Name = "Newspaper",
                Binding = "Newspaper",
            };
            var radio = new Series
            {
                Name = "Radio",
                Binding = "Radio",
            };
            var internet = new Series
            {
                Name = "Internet",
                Binding = "Internet",
            };
            this.flexChart1.Series.Add(tv);
            this.flexChart1.Series.Add(newspaper);
            this.flexChart1.Series.Add(radio);
            this.flexChart1.Series.Add(internet);
            this.flexChart1.AxisY.Format = "p0";
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
