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
        public static Control CreateSelectionDiagram(Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram();
            diagram.ForeColor = foreColor;
            diagram.BackColor = backColor;
            diagram.ScaleMode = ScaleMode.ScaleToFit;

            var node = new Node() { Text = "1.1", Shape = Shape.Circle };
            diagram.Nodes.Add(node);
            CreateSubNodes(diagram, node, 0, ()=>3, 1);

            diagram.SelectionMode = DiagramSelectionMode.Node;
            diagram.SelectionStyle.StrokeColor = backColor;
            diagram.SelectionStyle.FillColor = foreColor;

            return diagram;
        }

        public static void CreateSubNodes(FlexDiagram diagram, Node node, int level, Func<int> n, int maxLevel = 2, Shape shape = Shape.Circle)
        {
            for (var i = 0; i < n(); i++)
            {
                var subNode = new Node() { Text = $"{level + 2}.{i + 1}", Shape = shape };
                diagram.Nodes.Add(subNode);
                diagram.Edges.Add(new Edge() { Source = node, Target = subNode });

                if (level < maxLevel)
                    CreateSubNodes(diagram, subNode, level + 1, n, maxLevel, shape);
            }
        }
    }
}
