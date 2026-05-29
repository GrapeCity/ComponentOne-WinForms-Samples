using C1.Diagram;
using C1.Win.Diagram;
using DiagramExplorer.Data;
using System.Windows.Forms;
using System.Xml;

namespace DiagramExplorer.Samples
{
    internal partial class Samples
    {
        public static Control CreateCountriesDiagram(Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram()
            {
                ForeColor = foreColor,
                BackColor = backColor
            };
            diagram.Header.Content = "Countries";
            diagram.Header.HorizontalAlignment = HorizontalAlignment.Left;
            diagram.ScaleMode = ScaleMode.ScaleToFit;
            SetHeaderStyle(diagram);

            diagram.NodeCreated += (s, args) =>
            {
                var node = args.Node;
                var country = args.Data as Country;

                if (country != null && country.Flag != null)
                {
                    node.Tooltip = country.Name;
                    node.TitleImage = country.Flag;
                    node.TitleImageAlignment = C1.Chart.ContentAlignment.MiddleCenter;
                    node.TitleImageSize = new Size(16, 16);
                    node.Shape = Shape.RoundedRectangle;
                }

                if (country != null)
                {
                    args.ParentNode.LegendItem = node.LegendItem = country.Continent;
                    // hide low-level nodes
                    args.ParentNode.Appearance = node.Appearance = NodeAppearance.None;
                }
                else
                {
                    var text = args.Data.ToString();
                    node.Content = text == "World" ? "➖" : "➕";
                    node.LegendItem = text;
                }
            };


            diagram.NodeStyle.Shape = Shape.RoundedRectangle;

            diagram.DataSource = dataService.GetCountryData();
            diagram.Binding = "World,Continent,Region,Code";
            diagram.Legend.Position = C1.Chart.Position.None;

            diagram.MouseClick += (s, e) =>
            {
                var info = diagram.HitTest(e.X, e.Y);
                if (info != null && info.Distance == 0 && info.Element is INode node)
                {
                    diagram.BeginUpdate();
                    ToggleNodeState(node);
                    diagram.EndUpdate();
                }
            };

            return diagram;
        }

        // expand or collapse the node
        static void ToggleNodeState(INode node)
        {
            var childs = GetChilds(node);

            if (childs.Count > 0)
            {
                var collapsed = childs[0].Appearance != NodeAppearance.Visible;

                if (collapsed)
                {
                    foreach (var child in childs)
                        child.Appearance = NodeAppearance.Visible;
                }
                else
                {
                    SetChildAppearance(node, NodeAppearance.None, 
                        (n) =>
                        {
                            if(n.Content.Text == "➖")
                                n.Content.Text = "➕";
                        }
                    );

                    // the first child is hidden to keep node on the same layout layer
                    childs[0].Appearance = NodeAppearance.Hidden;
                }

                node.Content.Text = collapsed ? "➖" : "➕";
            }
        }

        static void SetChildAppearance(INode node, NodeAppearance appearance, Action<INode>? action = null)
        {
            var childNodes = GetChilds(node);

            foreach (var child in childNodes)
            {
                child.Appearance = appearance;
                SetChildAppearance(child, appearance, action);
                action?.Invoke(child);
            }
        }

        static List<INode> GetChilds(INode node)
        {
            var list = new List<INode>();
            var diagram = node.Diagram;
            var edges = diagram.GetEdges();

            foreach (var edge in edges)
            {
                if (edge.Source == node && edge.Target != null)
                    list.Add(edge.Target);
            }

            return list;
        }
    }
}