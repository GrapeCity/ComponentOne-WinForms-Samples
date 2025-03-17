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
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class Axes : FlexChartBaseSample
    {
        private ComboBoxEx _cbLabelAngle;
        private LabelEx _lblLabelAngle;
        private FlexChart flexChart1;

        public Axes()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Weather Report : Temperature vs Precipitation";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = DataService.GetTemperatureData(new[] { "Tokyo"}, false, 30, true).First().Data;
            this.flexChart1.BindingX = "Date";

            var temp = new Series
            {
                Name = "Temperature",
                Binding = "HighTemp",
            };
            var precip = new Series
            {
                Name = "Precipitation",
                Binding = "Precipitation",
                ChartType = ChartType.LineSymbols,
                AxisY = new Axis { Title = "Precipitation (mm)", Position = Position.Right, Min=0},
            };
            precip.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.Series.Add(temp);
            this.flexChart1.Series.Add(precip);
            this.flexChart1.AxisY.Title = "Temperature (°F)";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.Rendered += (s, e) => { _cbLabelAngle.SelectedValue = flexChart1.AxisX.LabelAngle; };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbLabelAngle = new ComboBoxEx("X Label Angle");
            _cbLabelAngle.ItemsDataSource = new double[] { -90, -45, 0, 45, 90 };
            _cbLabelAngle.SelectedIndex = 2;
            _cbLabelAngle.SelectedIndexChanged += (s, e) => { flexChart1.AxisX.LabelAngle = (double)_cbLabelAngle.SelectedValue; };

            _lblLabelAngle = new LabelEx("X Label Angle:");

            this.pnlControls.Controls.Add(_lblLabelAngle);
            this.pnlControls.Controls.Add(_cbLabelAngle);
        }
    }
}
