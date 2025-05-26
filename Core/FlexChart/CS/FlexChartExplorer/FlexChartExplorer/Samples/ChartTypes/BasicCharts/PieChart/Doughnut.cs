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
    public partial class Doughnut : FlexChartBaseSample
    {
        private LabelEx _lblPalette, _lblInnerRadius, _lblOffset, _lblStartAngle, _lblLabels;
        private ComboBoxEx _cbPalette, _cbInnerRad, _cbOffset, _cbStartAngle, _cbPieLabel;
        public Doughnut()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var flexPie = this.Chart as FlexPie;
            flexPie.Binding = "TotalSales";
            flexPie.BindingName = "Name";
            flexPie.DataLabel.Content = "{name} : {p:0}%";
            flexPie.DataLabel.Position = PieLabelPosition.Circular;
            flexPie.Header.Content = "Sales Distribution across Products";
            flexPie.Header.Style.Font = StyleInfo.ChartHeaderFont;
            flexPie.InnerRadius = 0.75;
            flexPie.DataSource = SalesDataSource.GetSeasonSales(5);
        }
        protected override void InitializeControls()
        {
            this.Chart = new FlexPie { Dock = DockStyle.Fill };

            _cbPalette = ControlFactory.EnumBasedCombo(typeof(Palette), "Palette");
            _cbPalette.SelectedIndex = 0;
            _cbPalette.SelectedIndexChanged += (sender, eventArgs) => (this.Chart as FlexPie).Palette = (Palette)Enum.Parse(typeof(Palette), _cbPalette.SelectedItem.DisplayText);

            _cbInnerRad = new ComboBoxEx("Inner Radius");
            _cbInnerRad.ItemsDataSource = new double[] { 0, 0.25, 0.5, 0.75, 1 };
            _cbInnerRad.SelectedIndex = 3;
            _cbInnerRad.SelectedIndexChanged += (sender, eventArgs) => (this.Chart as FlexPie).InnerRadius = (double)_cbInnerRad.SelectedValue;

            _cbOffset = new ComboBoxEx("Offset");
            _cbOffset.ItemsDataSource = new double[] { 0, 0.25, 0.5, 0.75, 1 };
            _cbOffset.SelectedIndex = 0;
            _cbOffset.SelectedIndexChanged += (sender, eventArgs) => (this.Chart as FlexPie).Offset = (double)_cbOffset.SelectedValue;

            _cbStartAngle = new ComboBoxEx("Start Angle");
            _cbStartAngle.ItemsDataSource = new double[] { 0, 90, 180, 270, 360, -90, -180, -270, -360 };
            _cbStartAngle.SelectedIndex = 0;
            _cbStartAngle.SelectedIndexChanged += (sender, eventArgs) => (this.Chart as FlexPie).StartAngle = (double)_cbStartAngle.SelectedValue;

            _cbPieLabel = ControlFactory.EnumBasedCombo(typeof(PieLabelPosition), "Labels");
            _cbPieLabel.SelectedIndex = 5;
            _cbPieLabel.SelectedIndexChanged += (s, e) => { (this.Chart as FlexPie).DataLabel.Position = (PieLabelPosition)Enum.Parse(typeof(PieLabelPosition), _cbPieLabel.SelectedItem.DisplayText); };

            _lblPalette = new LabelEx("Palette:");
            _lblInnerRadius = new LabelEx("Inner Radius:");
            _lblOffset = new LabelEx("Offset:");
            _lblStartAngle = new LabelEx("Start Angle:");
            _lblLabels = new LabelEx("Labels:");

            this.pnlControls.Controls.Add(_lblPalette);
            this.pnlControls.Controls.Add(_cbPalette);
            
            this.pnlControls.Controls.Add(_lblInnerRadius);
            this.pnlControls.Controls.Add(_cbInnerRad);
            
            this.pnlControls.Controls.Add(_lblOffset);
            this.pnlControls.Controls.Add(_cbOffset);

            this.pnlControls.Controls.Add(_lblStartAngle);
            this.pnlControls.Controls.Add(_cbStartAngle);

            this.pnlControls.Controls.Add(_lblLabels);
            this.pnlControls.Controls.Add(_cbPieLabel);
        }
    }
}
