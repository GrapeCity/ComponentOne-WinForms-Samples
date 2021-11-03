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
    public partial class Binding : FlexChartBaseSample
    {
        private ComboBoxEx _cbChartType;
        private CheckBoxEx _chbInterpolateNulls, _chbLegendToggle;
        private string[] _chartTypes = new string[] { "Line","LineSymbols","Area"};
        private FlexChart flexChart1;

        public Binding()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.DataSource = SalesDataSource.GetSalesVsDownloadData(50);
            this.flexChart1.ChartType = ChartType.Line;
            this.flexChart1.Header.Content = "Sales and Downloads";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "Date";
            var ser1 = new Series { Binding = "Downloads", Name = "Downloads" };
            var ser2 = new Series { Binding = "Sales", Name = "Sales" };
            this.flexChart1.Series.Add(ser1);
            this.flexChart1.Series.Add(ser2);
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbChartType = new ComboBoxEx("Chart Type") { DataSource = _chartTypes };
            _cbChartType.SelectedIndexChanged += (s, e) => { flexChart1.ChartType = (ChartType)Enum.Parse(typeof(ChartType), _cbChartType.SelectedValue.ToString()); };

            _chbInterpolateNulls = new CheckBoxEx("Interpolate Nulls");
            _chbInterpolateNulls.CheckedChanged += (s, e) => { flexChart1.Options.InterpolateNulls = _chbInterpolateNulls.Checked; };

            _chbLegendToggle = new CheckBoxEx("Allow Legend Toggle");
            _chbLegendToggle.CheckedChanged += (s, e) => { flexChart1.LegendToggle = _chbLegendToggle.Checked; };

            this.pnlControls.Controls.Add(_cbChartType);
            this.pnlControls.Controls.Add(_chbInterpolateNulls);
            this.pnlControls.Controls.Add(_chbLegendToggle);
        }
    }
}
