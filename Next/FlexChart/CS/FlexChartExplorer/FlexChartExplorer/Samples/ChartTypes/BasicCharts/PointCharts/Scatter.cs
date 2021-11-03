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
    public partial class Scatter : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public Scatter()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = DataService.GetPointData().Take(200);
            //convert SI unit values to ImperialUnit values
            data = data.Select(x => new PointD { X = x.X * 0.0328084, Y = x.Y * 2.20462 }).ToList();

            this.flexChart1.ChartType = ChartType.Scatter;
            this.flexChart1.DataSource = data;
            this.flexChart1.BindingX = "X";

            var strength = new Series { Binding = "Y" };
            this.flexChart1.Series.Add(strength);

            this.flexChart1.Header.Content = "ACME Corporation : Employee BMI Analysis";
            this.flexChart1.AxisX.DataSource = DataService.GetMonthAxisDataSource();
            this.flexChart1.AxisX.Title = "Height (ft)";
            this.flexChart1.AxisY.Title = "Weight (lbs)";

            this.flexChart1.ToolTip.Content = "Height = {X:0.00} Feet\nWeight = {Y:0.00} Pounds";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
