using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;
using FlexChartExplorer.Data;
using BaseExplorer.Utilities;

namespace FlexChartExplorer.Samples
{
    public partial class TreeMapSelection : FlexChartBaseSample
    {
        Color[] _customPalette = new Color[]
        {
            Color.FromArgb(50, 150, 255),
            Color.FromArgb(255, 153, 51),
            Color.FromArgb(0, 170, 75),
            Color.FromArgb(255, 80, 170),
            Color.FromArgb(153, 76, 10),
            Color.FromArgb(153, 51, 255),
            Color.FromArgb(255, 255, 10),
            Color.FromArgb(204, 10, 102),
        };
        int index = -1;
        C1.Win.Chart.TreeMap treeMap;
        List<Product> _selectedGroup;

        public TreeMapSelection()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            treeMap = this.Chart as C1.Win.Chart.TreeMap;

            treeMap.Header.Content = "Sales Distribution by Product";
            treeMap.Header.Style.Font = StyleInfo.ChartHeaderFont;

            treeMap.DataSource = HierarchicalDataSource.GetProducts();
            treeMap.Binding = "Orders";
            treeMap.BindingName = "Name";
            treeMap.ChildItemsPath = "Items";
            treeMap.MaxDepth = 0;
            treeMap.Legend.Position = Position.None;

            treeMap.DataLabel.Content = "{name}";
            treeMap.DataLabel.Style.Stroke = Brushes.Black;
            treeMap.DataLabel.Position = LabelPosition.Center;
            treeMap.ToolTip.Content = "{name} Sales : {value}";

            treeMap.SelectionMode = ChartSelectionMode.Point;
            treeMap.SelectionStyle.StrokeColor = Color.Black;
            treeMap.SelectedItem = (treeMap.DataSource as List<Product>)[0].Items[0];
            treeMap.NodeRendering += TreeMap_NodeRendering;
            treeMap.Rendered += (s, e) => { index = -1; _selectedGroup.Clear(); };
        }

        private void TreeMap_NodeRendering(object sender, RenderNodeEventArgs e)
        {
            var selItem = treeMap.SelectedItem as Product;
            if(selItem!=null)
                _selectedGroup = SelectManyRecursive( selItem,x => x.Items).ToList();
            if (e.Depth == 1)
                index = (index + 1) % _customPalette.Length;
            var alpha = e.Item == selItem || _selectedGroup.Contains(e.Item) ? 110 : 50;
            var tAlpha = e.Item == selItem || _selectedGroup.Contains(e.Item) ? 200 : 130;
            if (e.IsTitle)
                e.Engine.SetFill(new SolidBrush(Color.FromArgb(tAlpha, _customPalette[index])));
            else
                e.Engine.SetFill(new SolidBrush(Color.FromArgb(alpha, _customPalette[index])));
            e.Engine.SetStroke(new SolidBrush(_customPalette[index]));
        }

        private IEnumerable<T> SelectManyRecursive<T>(T head, Func<T, IEnumerable<T>> selector)
        {
            if (head == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");

            yield return head;
            foreach (var node in selector(head))
            {
                foreach (var child in SelectManyRecursive(node, selector))
                {
                    yield return child;
                }
            }
        }

        protected override void InitializeControls()
        {
            this.Chart = new C1.Win.Chart.TreeMap() { Dock = DockStyle.Fill };
        }
    }
}
