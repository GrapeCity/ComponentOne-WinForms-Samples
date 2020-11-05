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
using FlexChartExplorer.Data;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class TreeMapNodeColor : FlexChartBaseSample
    {
        private LabelEx _lMaxDepth;
        private NumericUpDownEx _udMaxDepth;
        Dictionary<string, SolidBrush> _colorDict;
        public TreeMapNodeColor()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var treeMap = this.Chart as C1.Win.Chart.TreeMap;
            treeMap.Header.Content = "Sales Distribution by Product";
            treeMap.Header.Style.Font = StyleInfo.ChartHeaderFont;

            treeMap.DataSource = HierarchicalDataSource.GetTreeMapData();
            treeMap.Binding = "CurrentSales";
            treeMap.BindingName = "Type";
            treeMap.ChildItemsPath = "Items";
            treeMap.MaxDepth = 2;
            treeMap.DataLabel.Style.Stroke = Brushes.White;
            treeMap.ToolTip.Content = "Current Sales: {CurrentSales:C0}\nPrevious Sales: {PreviousSales:C0}";
            treeMap.NodeRendering += _treeMap_NodeRendering;
        }
        private void _treeMap_NodeRendering(object sender, RenderNodeEventArgs e)
        {
            var dataItem = e.Item as TreeMapNodeItem;
            if (dataItem == null)
                return;
            e.Engine.SetStroke(_colorDict["Border"]);
            SolidBrush fill = null;
            if (e.IsTitle)
                fill = _colorDict["Title"];
            else
                fill = dataItem.CurrentSales >= dataItem.PreviousSales ? _colorDict["LeafPos"] : _colorDict["LeafNeg"];
            e.Engine.SetFill(fill);
        }

        protected override void InitializeControls()
        {            
            this.Chart = new C1.Win.Chart.TreeMap() { Dock = DockStyle.Fill };

            //Init MaxDepth Label and Numeric Box
            _lMaxDepth = new LabelEx("Max Depth :");
            _udMaxDepth = new NumericUpDownEx { Minimum = 1, Maximum = 4, Value = 2, Increment = 1 };
            _udMaxDepth.ValueChanged += (s, e) => { (this.Chart as C1.Win.Chart.TreeMap).MaxDepth = (int)_udMaxDepth.Value; };

            this.pnlControls.Controls.Add(_lMaxDepth);
            this.pnlControls.Controls.Add(_udMaxDepth);

            //Init Color's Dictionary
            _colorDict = new Dictionary<string, SolidBrush>();
            _colorDict.Add("Title", new SolidBrush(Color.FromArgb(140, Color.Green)));
            _colorDict.Add("LeafPos", new SolidBrush(Color.FromArgb(90, Color.Green)));
            _colorDict.Add("LeafNeg", new SolidBrush(Color.FromArgb(120, Color.Red)));
            _colorDict.Add("Border", new SolidBrush(Color.Black));
        }
    }
}
