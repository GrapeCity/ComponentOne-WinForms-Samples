using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.Chart;
using C1.Chart;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class StepLine : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public StepLine()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Step;
            this.flexChart1.DataSource = DataService.GetPlantProduction();

            this.flexChart1.BindingX = "Year";
            this.flexChart1.Series.Add(new Series { Binding = "Units", Name = "Capacity" });
            this.flexChart1.AxisY.Min = 0;
            this.flexChart1.AxisY.Title = "Units (in tons)";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;

            this.flexChart1.Header.Content = "ACME Corporation : Production Capacity";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
