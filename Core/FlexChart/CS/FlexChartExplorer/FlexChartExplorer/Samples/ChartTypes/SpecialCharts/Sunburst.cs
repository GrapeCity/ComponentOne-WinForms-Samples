﻿using System;
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
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class Sunburst : FlexChartBaseSample
    {
        private LabelEx _lInnerRad, _lOffset, _lStartAngle;
        private NumericUpDownEx _udInnerRad, _udOffset, _udStartAngle;
        private ComboBoxEx _cbPalette;
        private LabelEx _lblPalette;
        private CheckBoxEx _chbReverse;
        public Sunburst()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var sunburst = this.Chart as C1.Win.Chart.Sunburst;            
            sunburst.Binding = "Value";
            sunburst.BindingName = "Year,Quarter,Month";
            sunburst.ChildItemsPath = "Items";
            sunburst.DataLabel.Position = PieLabelPosition.Center;
            sunburst.DataLabel.Content = "{name}";
            sunburst.ToolTip.Content = "In {name} Sales : {value}\nShare : {P:0}%";
            sunburst.DataSource = HierarchicalDataSource.GetSunburstData();
            sunburst.Header.Content = "Sales over the years";
            sunburst.Header.Style.Font = StyleInfo.ChartHeaderFont;
        }
        protected override void InitializeControls()
        {            
            //Sunburst chart
            this.Chart = new C1.Win.Chart.Sunburst { Dock=DockStyle.Fill};
            
            //Inner Radius
            _lInnerRad = new LabelEx("Inner Radius");
            
            _udInnerRad = new NumericUpDownEx { Minimum = 0, Maximum = 1, Increment = new decimal(new int[] { 1, 0, 0, 65536 }), Value = 0};
            _udInnerRad.ValueChanged += (s, e) => (this.Chart as C1.Win.Chart.Sunburst).InnerRadius = Convert.ToSingle(_udInnerRad.Value);
            
            //Offset
            _lOffset = new LabelEx("Offset");

            _udOffset = new NumericUpDownEx { Minimum = 0, Maximum = 1, Increment = new decimal(new int[] { 1, 0, 0, 65536 }), Value = 0 };
            _udOffset.ValueChanged += (s, e) => (this.Chart as C1.Win.Chart.Sunburst).Offset = Convert.ToSingle(_udOffset.Value);

            //Start Angle
            _lStartAngle = new LabelEx("Start Angle:");
            
            _udStartAngle = new NumericUpDownEx { Minimum = 0, Maximum = 360, Increment = 45, Value = 0 };
            _udStartAngle.ValueChanged += (s, e) => (this.Chart as C1.Win.Chart.Sunburst).StartAngle = Convert.ToDouble(_udStartAngle.Value);
            
            //Palette
            _cbPalette = ControlFactory.EnumBasedCombo(typeof(Palette), "Palette");
            _cbPalette.SelectedIndex = 0;
            _cbPalette.SelectedIndexChanged += (s, e) => (this.Chart as C1.Win.Chart.Sunburst).Palette = (Palette)Enum.Parse(typeof(Palette), _cbPalette.SelectedItem.DisplayText);
            
            //Reversed
            _chbReverse = new CheckBoxEx("Reversed");
            _chbReverse.CheckedChanged += (s, e) => (this.Chart as C1.Win.Chart.Sunburst).Reversed = _chbReverse.Checked;

            _lblPalette = new LabelEx("Palette");


            this.pnlControls.Controls.Add(_lInnerRad);
            this.pnlControls.Controls.Add(_udInnerRad);
            this.pnlControls.Controls.Add(_lOffset);
            this.pnlControls.Controls.Add(_udOffset);
            this.pnlControls.Controls.Add(_lStartAngle);
            this.pnlControls.Controls.Add(_udStartAngle);
            this.pnlControls.Controls.Add(_lblPalette);
            this.pnlControls.Controls.Add(_cbPalette);
            this.pnlControls.Controls.Add(_chbReverse);
        }
    }
}
