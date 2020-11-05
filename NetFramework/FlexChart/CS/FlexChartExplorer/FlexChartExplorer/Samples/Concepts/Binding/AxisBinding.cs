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
    public partial class AxisBinding : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public AxisBinding()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.DataSource = DataService.GetTotalEarnings();
            this.flexChart1.ChartType = ChartType.Line;
            this.flexChart1.Header.Content = "ACME Corporation Historical Earnings";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "Year";
            this.flexChart1.Binding = "Earning";
            this.flexChart1.Series.Add(new Series { Name = "Total Earning" });
            this.flexChart1.AxisY.DataSource = DataService.GetAxisBindinglabels();
            this.flexChart1.AxisY.Binding = "Value,Text";
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
