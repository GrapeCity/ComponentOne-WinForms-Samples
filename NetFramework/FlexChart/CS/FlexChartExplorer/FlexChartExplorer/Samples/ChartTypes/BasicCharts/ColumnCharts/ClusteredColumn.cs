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
    public partial class ClusteredColumn : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public ClusteredColumn()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Sales and Downloads";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = SalesDataSource.GetCountrySales();
            this.flexChart1.BindingX = "Name";

            var sales = new Series
            {
                Name = "Sales",
                Binding = "Sales",
            };
            var downloads = new Series
            {
                Name = "Downloads",
                Binding = "Downloads",
            };

            this.flexChart1.Series.Add(sales);
            this.flexChart1.Series.Add(downloads);
            this.flexChart1.ToolTip.Content = "{y:0}";
            this.flexChart1.AxisX.AxisLine = false;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
