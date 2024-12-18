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
    public partial class PolarChart : FlexChartBaseSample
    {
        private LabelEx _lKValue, _lAValue;
        private NumericUpDownEx _udKValue, _udAValue;
        private double _kValue = 5, _aValue = 2;
        public PolarChart()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var polarChart = this.Chart as FlexRadar;
            polarChart.BindingX = "X";
            Series sine = new Series() { Binding = "SinX", Name = "Sin(kΦ) + a", SymbolSize=3 };
            Series cosine = new Series() { Binding = "CosX", Name = "Cos(kΦ) + a", SymbolSize=3 };
            polarChart.Series.Add(sine);
            polarChart.Series.Add(cosine);
            polarChart.AxisX.MajorUnit = 45;
            polarChart.AxisY.Min = 0;
            polarChart.ChartType = RadarChartType.LineSymbols;
            polarChart.DataSource = DataService.GetSineCosineData(_kValue, _aValue);
        }
        protected override void InitializeControls()
        {            
            this.Chart = new FlexRadar() { Dock = DockStyle.Fill };

            _lKValue = new LabelEx("k =") { Margin = new Padding(5, 5, 0, 5) };
            _udKValue = new NumericUpDownEx() { Minimum = 0, Maximum = 10, Increment = 1, Value = (decimal)_kValue, Margin = new Padding(0,5,0,5) };
            _udKValue.ValueChanged += (s, e) => (this.Chart as FlexRadar).DataSource = DataService.GetSineCosineData(Convert.ToSingle(_udKValue.Value), Convert.ToSingle(_udAValue.Value));

            _lAValue = new LabelEx("a =") { Margin = new Padding(5, 5, 0, 5) };
            _udAValue = new NumericUpDownEx() { Minimum = 0, Maximum = 5, Increment = new decimal(new int[] { 1, 0, 0, 65536 }), Value = (decimal)_aValue, Margin = new Padding(0, 5, 0, 5) };
            _udAValue.ValueChanged += (s, e) => (this.Chart as FlexRadar).DataSource = DataService.GetSineCosineData(Convert.ToSingle(_udKValue.Value), Convert.ToSingle(_udAValue.Value));
            
            this.pnlControls.Controls.Add(_lKValue);
            this.pnlControls.Controls.Add(_udKValue);
            this.pnlControls.Controls.Add(_lAValue);
            this.pnlControls.Controls.Add(_udAValue);
        }
    }
}
