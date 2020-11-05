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
    public partial class Bar : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public Bar()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Bar;
            this.flexChart1.Header.Content = "Product Sales";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = SalesDataSource.GetSeasonSales(10);
            this.flexChart1.BindingX = "Name";

            var items = new Series
            {
                Name = "Sales",
                Binding = "TotalSales",
            };
            this.flexChart1.Series.Add(items);
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
