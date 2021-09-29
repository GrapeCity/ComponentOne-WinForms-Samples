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
    public partial class StepSymbols : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public StepSymbols()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.StepSymbols;
            this.flexChart1.Header.Content = "ACME Corporation : Website Traffic";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = DataService.GetWebTrafficStats();
            this.flexChart1.BindingX = "Time";
            var traffic = new Series
            {
                Name = "Site Traffic",
                Binding = "Traffic",
            };
            this.flexChart1.Series.Add(traffic);

            this.flexChart1.AxisY.Title = "Number of visitors";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
