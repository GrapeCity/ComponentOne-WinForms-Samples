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
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class ClusteredBar : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public ClusteredBar()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Bar;
            this.flexChart1.Header.Content = "Product Sales in Holidays";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = SalesDataSource.GetSeasonSales(10);
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Series.Add(new Series { Name = "Total", Binding = "TotalSales" });
            this.flexChart1.Series.Add(new Series { Name = "Winter", Binding = "WinterTotal" });
            this.flexChart1.Series.Add(new Series { Name = "Summer", Binding = "SummerTotal" });
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
