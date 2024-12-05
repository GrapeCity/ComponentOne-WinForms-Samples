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
    public partial class FunnelChart : FlexChartBaseSample
    {
        private ComboBoxEx _cbFunnelType, _cbPalette;
        private NumericUpDownEx _udNeckWidth, _udNeckHeight;
        private LabelEx _lNeckWidth, _lNeckHeight;
        private FlexChart flexChart1;

        public FunnelChart()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Recruitment Funnel";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.BindingX = "Name";
            this.flexChart1.DataLabel.Content = "{value}";
            this.flexChart1.DataLabel.Position = LabelPosition.Center;

            Series series = new Series() { Binding="Value"};
            this.flexChart1.Series.Add(series);

            this.flexChart1.DataSource = DataService.GetRecruitmentData();
            this.flexChart1.ChartType = ChartType.Funnel;
            this.flexChart1.Rendered += (s, e) => 
            {
                _udNeckHeight.Value = (decimal)this.flexChart1.Options.FunnelNeckHeight;
                _udNeckWidth.Value = (decimal)this.flexChart1.Options.FunnelNeckWidth;
            };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbPalette = ControlFactory.EnumBasedCombo(typeof(Palette), "Palette");
            _cbPalette.SelectedIndexChanged += (s, e) => this.flexChart1.Palette = (Palette)Enum.Parse(typeof(Palette), _cbPalette.SelectedItem.ToString());

            _cbFunnelType = ControlFactory.EnumBasedCombo(typeof(FunnelChartType), "Funnel Type");
            _cbFunnelType.SelectedIndexChanged += (s, e) =>
            {
                this.flexChart1.Options.FunnelType = (FunnelChartType)Enum.Parse(typeof(FunnelChartType), _cbFunnelType.SelectedItem.ToString());
                _udNeckWidth.Enabled = _udNeckHeight.Enabled = this.flexChart1.Options.FunnelType == FunnelChartType.Default;
            };

            _lNeckHeight = new LabelEx("Neck Height: ");
            _lNeckWidth = new LabelEx("Neck Width: ");

            _udNeckHeight = new NumericUpDownEx() { Minimum = 0M, Maximum = 1M, Increment = 0.1M, DecimalPlaces=1};
            _udNeckHeight.ValueChanged += (s, e) => this.flexChart1.Options.FunnelNeckHeight = (double)_udNeckHeight.Value;

            _udNeckWidth = new NumericUpDownEx() { Minimum = 0M, Maximum = 1M, Increment = 0.1M, DecimalPlaces = 1 };
            _udNeckWidth.ValueChanged += (s, e) => this.flexChart1.Options.FunnelNeckWidth = (double)_udNeckWidth.Value;

            this.pnlControls.Controls.Add(_cbPalette);
            this.pnlControls.Controls.Add(_cbFunnelType);
            this.pnlControls.Controls.Add(_lNeckHeight);
            this.pnlControls.Controls.Add(_udNeckHeight);
            this.pnlControls.Controls.Add(_lNeckWidth);
            this.pnlControls.Controls.Add(_udNeckWidth);
        }
    }
}
