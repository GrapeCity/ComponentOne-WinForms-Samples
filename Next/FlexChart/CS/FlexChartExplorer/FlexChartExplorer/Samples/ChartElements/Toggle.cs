using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseExplorer;
using FlexChartExplorer.Data;
using C1.Chart;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class Toggle : FlexChartBaseSample
    {
        private CheckBoxEx _chbToggle;
        private FlexChart flexChart1;

        public Toggle()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Daily Price Movement";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.ChartType = ChartType.Spline;
            this.flexChart1.BindingX = "Date";
            var countries = "USA|China|Japan|India".Split('|');
            var bindings = "High|Low|Open|Close".Split('|');
            for (int i = 0; i < countries.Length; i++)
            {
                var seriesData = FinancialDataSource.GetFinancialData();
                var series = new Series
                {
                    Name = countries[i],
                    Binding = bindings[i],
                    DataSource = seriesData,
                    Visibility = i%2 == 0 ? SeriesVisibility.Visible : SeriesVisibility.Legend
                };
                flexChart1.Series.Add(series);
            }
            this.flexChart1.LegendToggle = true;            
            this.flexChart1.Rendered += (s, e) => { _chbToggle.Checked = flexChart1.LegendToggle; };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _chbToggle = new CheckBoxEx("Enable Toggling");
            _chbToggle.CheckedChanged += (s, e) => { this.flexChart1.LegendToggle = _chbToggle.Checked; };

            this.pnlControls.Controls.Add(_chbToggle);
        }
    }
}
