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
    public partial class RadarChart : FlexChartBaseSample
    {
        private ComboBoxEx _cbChartType, _cbStacking, _cbPalette;
        private LabelEx _lblChartType, _lblStacking, _lblPalette;
        private NumericUpDownEx _udStartAngle;
        private LabelEx _lStartAngle;
        private CheckBoxEx _chbReverse;
        public RadarChart()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var _flexRadar = this.Chart as FlexRadar;
            _flexRadar.Header.Content = "Revenue vs Expenses";
            _flexRadar.Header.Style.Font = StyleInfo.ChartHeaderFont;

            _flexRadar.BindingX = "Name";
            Series budget = new Series() { Binding = "Sales", Name = "Revenue" };
            Series expenditure = new Series() { Binding = "Expenses", Name = "Expenses" };
            _flexRadar.Series.Add(budget);
            _flexRadar.Series.Add(expenditure);

            _flexRadar.DataSource = SalesDataSource.GetCountrySales();
        }
        protected override void InitializeControls()
        {            
            this.Chart = new FlexRadar() { Dock = DockStyle.Fill };

            _cbChartType = ControlFactory.EnumBasedCombo(typeof(RadarChartType), "Chart Type");
            _cbChartType.SelectedIndexChanged += (s, e) => (this.Chart as FlexRadar).ChartType = (RadarChartType)Enum.Parse(typeof(RadarChartType), _cbChartType.SelectedItem.DisplayText);

            _cbStacking = ControlFactory.EnumBasedCombo(typeof(Stacking), "Stacking");
            _cbStacking.SelectedIndexChanged += (s, e) => (this.Chart as FlexRadar).Stacking = (Stacking)Enum.Parse(typeof(Stacking), _cbStacking.SelectedItem.DisplayText);

            _cbPalette = ControlFactory.EnumBasedCombo(typeof(Palette), "Palette");
            _cbPalette.SelectedIndexChanged += (s, e) => (this.Chart as FlexRadar).Palette = (Palette)Enum.Parse(typeof(Palette), _cbPalette.SelectedItem.DisplayText);

            _lStartAngle = new LabelEx("Start Angle:");
            _udStartAngle = new NumericUpDownEx() { Minimum = -360, Maximum = 360, Increment = 45, Value = 0 };
            _udStartAngle.ValueChanged += (s, e) => (this.Chart as FlexRadar).StartAngle = (int)_udStartAngle.Value;

            _chbReverse = new CheckBoxEx("Reverse");
            _chbReverse.CheckedChanged += (s, e) => (this.Chart as FlexRadar).Reversed = _chbReverse.Checked;

            _lblChartType = new LabelEx("Chart Type:");
            _lblStacking = new LabelEx("Stacking:");
            _lblPalette = new LabelEx("Palette:");

            this.pnlControls.Controls.Add(_lblChartType);
            this.pnlControls.Controls.Add(_cbChartType);
            this.pnlControls.Controls.Add(_lblStacking);
            this.pnlControls.Controls.Add(_cbStacking);
            this.pnlControls.Controls.Add(_lblPalette);
            this.pnlControls.Controls.Add(_cbPalette);
            this.pnlControls.Controls.Add(_lStartAngle);
            this.pnlControls.Controls.Add(_udStartAngle);
            this.pnlControls.Controls.Add(_chbReverse);
        }
    }
}
