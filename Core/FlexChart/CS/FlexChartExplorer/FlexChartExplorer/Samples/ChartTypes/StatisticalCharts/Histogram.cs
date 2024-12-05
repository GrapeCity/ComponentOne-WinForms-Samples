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
using BaseExplorer;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class Histogram : FlexChartBaseSample
    {
        private C1.Win.Chart.Histogram _histogramSeries;
        private LabelEx _lBinWidth;
        private NumericUpDownEx _udBinWidth;
        private ComboBoxEx _cbAppearance;
        private CheckBoxEx _chbNormalCurve;
        private CheckBoxEx _chbCumulative;
        private FlexChart flexChart1;

        public Histogram()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = DataService.GetPointData();
            //Get height and weight in Feet and Pounds respectively.
            data = data.Select(x => new PointD { X = x.X * 0.032804, Y = x.Y * 2.20462 }).ToList();
            this.flexChart1.DataSource = data;
            this.flexChart1.BindingX = "X";
            this.flexChart1.ChartType = ChartType.Histogram;
            this.flexChart1.Header.Content = "HighSchool : Height Distribution";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            _histogramSeries = new C1.Win.Chart.Histogram()
            {
                Binding = "X",
                Name = "Frequency",
                BinWidth = 0.2,
            };
            _histogramSeries.NormalCurve.LineStyle = new ChartStyle { StrokeColor = Color.Maroon, StrokeWidth = 2 };

            var valueSeries = new Series
            {
                ChartType = ChartType.Scatter,
                Name = "Weight(lds)",
                Binding = "Y",
            };
            this.flexChart1.Series.Add(_histogramSeries);
            this.flexChart1.Series.Add(valueSeries);
            this.flexChart1.AxisX.Title = "Height(ft)";
            this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.ToolTip.Content = "X:{x}, Y:{y}";
            this.flexChart1.Rendered += (s, e) =>
            {
                _udBinWidth.Value = (decimal)_histogramSeries.BinWidth;
                _cbAppearance.SelectedItem = _histogramSeries.HistogramAppearance;                
            };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            

            _lBinWidth = new LabelEx("Bin Width :");
            _udBinWidth = new NumericUpDownEx() { Minimum = (decimal)0.1, Maximum = 2, Increment = (decimal)0.1, DecimalPlaces=1 };
            _udBinWidth.ValueChanged += (s, e) => { _histogramSeries.BinWidth = (double)_udBinWidth.Value; };

            _cbAppearance = ControlFactory.EnumBasedCombo(typeof(HistogramAppearance), "Appearance");
            _cbAppearance.Width = 160;
            _cbAppearance.SelectedIndexChanged += (s, e) => { _histogramSeries.HistogramAppearance = (HistogramAppearance)Enum.Parse(typeof(HistogramAppearance), _cbAppearance.SelectedItem.ToString()); };

            _chbNormalCurve = new CheckBoxEx("Normal Curve");
            _chbNormalCurve.CheckedChanged += (s, e) => { _histogramSeries.NormalCurve.Visible = _chbNormalCurve.Checked; };

            _chbCumulative = new CheckBoxEx("Cumulative");
            _chbCumulative.CheckedChanged += (s, e) => { _histogramSeries.CumulativeMode = _chbCumulative.Checked; };

            this.pnlControls.Controls.Add(_lBinWidth);
            this.pnlControls.Controls.Add(_udBinWidth);
            this.pnlControls.Controls.Add(_cbAppearance);
            this.pnlControls.Controls.Add(_chbNormalCurve);
            this.pnlControls.Controls.Add(_chbCumulative);
        }
    }
}
