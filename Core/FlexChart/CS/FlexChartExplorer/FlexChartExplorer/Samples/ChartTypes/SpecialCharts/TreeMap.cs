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
using BaseExplorer;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class TreeMap : FlexChartBaseSample
    {
        private ComboBoxEx _cbChartType, _cbPalette;
        private CheckBoxEx _chbLabel;
        private LabelEx _lMaxDepth;
        private NumericUpDownEx _udMaxDepth;
        private LabelEx _lblChartType, _lblPalette;

        public TreeMap()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var treeMap = this.Chart as C1.Win.Chart.TreeMap;
            treeMap.Header.Content = "Sales Distribution by Product";
            treeMap.Header.Style.Font = StyleInfo.ChartHeaderFont;

            treeMap.Binding = "CurrentSales";
            treeMap.BindingName = "Type";
            treeMap.ChildItemsPath = "Items";
            treeMap.DataSource = HierarchicalDataSource.GetTreeMapData();
            treeMap.MaxDepth = 2;
            treeMap.DataLabel.Content = "{name}";
            treeMap.DataLabel.Position = LabelPosition.Center;
        }
        protected override void InitializeControls()
        {
            this.Chart = new C1.Win.Chart.TreeMap() { Dock = DockStyle.Fill };
            
            _cbChartType = ControlFactory.EnumBasedCombo(typeof(TreeMapType), "Chart Type");
            _cbChartType.SelectedIndex = 0;
            _cbChartType.SelectedIndexChanged += (s, e) => (this.Chart as C1.Win.Chart.TreeMap).ChartType = (TreeMapType)Enum.Parse(typeof(TreeMapType), _cbChartType.SelectedItem.DisplayText);
          
            _cbPalette = ControlFactory.EnumBasedCombo(typeof(Palette), "Palette");
            _cbPalette.SelectedIndex = 0;
            _cbPalette.SelectedIndexChanged += (s, e) => (this.Chart as C1.Win.Chart.TreeMap).Palette = (Palette)Enum.Parse(typeof(Palette), _cbPalette.SelectedItem.DisplayText);
            
            _chbLabel = new CheckBoxEx("Labels") { Checked=true};
            _chbLabel.CheckedChanged += (s, e) => (this.Chart as C1.Win.Chart.TreeMap).DataLabel.Position = _chbLabel.Checked ? LabelPosition.Center : LabelPosition.None;
            
            _lMaxDepth = new LabelEx("MaxDepth");
            _udMaxDepth = new NumericUpDownEx { Minimum = 1, Maximum = 4, Increment = 1, Value = 2 };
            _udMaxDepth.ValueChanged += (s, e) => (this.Chart as C1.Win.Chart.TreeMap).MaxDepth = Convert.ToInt32(_udMaxDepth.Value);

            _lblChartType = new LabelEx("Chart Type:");
            _lblPalette = new LabelEx("Palette:");

            this.pnlControls.Controls.Add(_lblChartType);
            this.pnlControls.Controls.Add(_cbChartType);
            this.pnlControls.Controls.Add(_lblPalette);
            this.pnlControls.Controls.Add(_cbPalette);
            this.pnlControls.Controls.Add(_chbLabel);
            this.pnlControls.Controls.Add(_lMaxDepth);
            this.pnlControls.Controls.Add(_udMaxDepth);
        }
    }
}
