using C1.Diagram.Parser;
using C1.Diagram;
using C1.Win.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using C1.Win.Chart;

namespace DiagramExplorer.Samples
{
    internal partial class Samples
    {
        public static Control CreateHitTestingDiagram(Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram() { Font = new Font("Segoe UI Emoji", 12) };
            diagram.ForeColor = foreColor;
            diagram.BackColor = backColor;
            diagram.ScaleMode = ScaleMode.ScaleToFit;
            diagram.EdgeRouting = EdgeRouting.SugiyamaSplines;

            var nodes = diagram.Nodes;
            var edges = diagram.Edges;

            var persons = "👨,👩,👦,👧".Split(",");

            for (var i = 0; i < 15; i++)
            {
                var text = persons[rnd.Next(0, persons.Length)];
                var node = new Node() { Text = text, LegendItem = text, Shape = Shape.RoundedRectangle };
                nodes.Add(node);

                if (i == 0)
                    continue;

                var k = rnd.Next(0, nodes.Count - 2);
                edges.Add(new Edge() { Source = nodes[k], Target = nodes[nodes.Count - 1] });
                k = rnd.Next(0, nodes.Count - 1);
                edges.Add(new Edge() { Source = nodes[k], Target = nodes[nodes.Count - 1] });
            }

            var nodeStyle = new ChartStyle();
            var edgeStyle = new ChartStyle();

            diagram.MouseMove += (s, e) =>
            {
                foreach (var node in diagram.Nodes)
                    node.Style = nodeStyle;
                foreach (var edge in diagram.Edges)
                {
                    edge.Style = edgeStyle;
                    edge.SourceArrow = edge.TargetArrow = C1.Chart.ArrowStyle.None;
                }

                var info = diagram.HitTest(e.X, e.Y);

                if (info?.Distance <= 3)
                {

                    if (info?.Element is Node node1)
                    {
                        node1.Style = new ChartStyle() { StrokeWidth = 4 };
                    }
                    else if (info?.Element is Edge edge)
                    {
                        edge.Style = new ChartStyle() { StrokeWidth = 2 };
                        edge.SourceArrow = edge.TargetArrow = C1.Chart.ArrowStyle.Normal;
                    }
                }
            };

            return diagram;
        }
    }
}
