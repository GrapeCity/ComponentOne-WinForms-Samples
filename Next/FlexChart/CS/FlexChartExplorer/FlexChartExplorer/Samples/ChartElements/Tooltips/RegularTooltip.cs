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
    public partial class RegularTooltip : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public RegularTooltip()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Sales vs Expenses";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = SalesDataSource.GetCountrySales();
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Series.Add(new Series { Name = "Sales", Binding = "Sales" });
            this.flexChart1.Series.Add(new Series { Name = "Expenses", Binding = "Expenses", ChartType = ChartType.LineSymbols });
            this.flexChart1.ToolTip.Content = "Country : {name}\rSales: {Sales}\rExpenses: {Expenses}";
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
