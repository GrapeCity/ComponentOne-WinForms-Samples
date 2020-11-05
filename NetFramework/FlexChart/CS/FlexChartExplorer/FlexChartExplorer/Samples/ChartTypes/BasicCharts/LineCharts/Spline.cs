using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.Chart;
using FlexChartExplorer.Data;
using C1.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class Spline : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public Spline()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Spline;
            this.flexChart1.BindingX = "Date";
            flexChart1.DataSource = FinancialDataSource.GetQuotes();
            var series = new Series
            {
                Name = "Price",
                Binding = "Close",
             };
            flexChart1.Series.Add(series);
            this.flexChart1.Header.Content = "Daily Price Movement";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
