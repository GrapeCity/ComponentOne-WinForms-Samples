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
            flexPie.Rendered += (s, e) =>
            {
                _cbPieLabel.SelectedItem = flexPie.DataLabel.Position;
                _cbInnerRad.SelectedItem = flexPie.InnerRadius;
            };
        }
        protected override void InitializeControls()
        {
            this.Chart = new FlexPie { Dock = DockStyle.Fill };

            _cbPalette = ControlFactory.EnumBasedCombo(typeof(Palette), "Palette");
            _cbPalette.SelectedIndexChanged += (sender, eventArgs) => (this.Chart as FlexPie).Palette = (Palette)Enum.Parse(typeof(Palette), _cbPalette.SelectedItem.ToString());

            _cbInnerRad = new ComboBoxEx("Inner Radius");
            _cbInnerRad.DataSource = new double[] { 0, 0.25, 0.5, 0.75, 1 };
            _cbInnerRad.SelectedIndexChanged += (sender, eventArgs) => (this.Chart as FlexPie).InnerRadius = (double)_cbInnerRad.SelectedItem;

            _cbOffset = new ComboBoxEx("Offset");
            _cbOffset.DataSource = new double[] { 0, 0.25, 0.5, 0.75, 1 };
            _cbOffset.SelectedIndexChanged += (sender, eventArgs) => (this.Chart as FlexPie).Offset = (double)_cbOffset.SelectedItem;

            _cbStartAngle = new ComboBoxEx("Start Angle");
            _cbStartAngle.DataSource = new double[] { 0, 90, 180, 270, 360, -90, -180, -270, -360 };
            _cbStartAngle.SelectedIndexChanged += (sender, eventArgs) => (this.Chart as FlexPie).StartAngle = (double)_cbStartAngle.SelectedItem;

            _cbPieLabel = ControlFactory.EnumBasedCombo(typeof(PieLabelPosition), "Labels");
            _cbPieLabel.SelectedIndexChanged += (s, e) => { (this.Chart as FlexPie).DataLabel.Position = (PieLabelPosition)Enum.Parse(typeof(PieLabelPosition), _cbPieLabel.SelectedItem.ToString()); };

            this.pnlControls.Controls.Add(_cbPalette);
            this.pnlControls.Controls.Add(_cbInnerRad);
            this.pnlControls.Controls.Add(_cbOffset);
            this.pnlControls.Controls.Add(_cbStartAngle);
            this.pnlControls.Controls.Add(_cbPieLabel);
        }
    }
}
