using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexChartExplorer.Data;
using C1.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class TreeMapDrill : FlexChartBaseSample
    {
        public TreeMapDrill()
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
            treeMap.MaxDepth = 1;
            treeMap.DataLabel.Content = "{name}";
            treeMap.DataLabel.Style.Stroke = Brushes.White;
            treeMap.DataLabel.Position = LabelPosition.Center;
        }
        protected override void InitializeControls()
        {
            this.Chart = new C1.Win.Chart.TreeMap() { Dock = DockStyle.Fill };
        }
    }
}
