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
        public static Control CreateDynamicDiagram(Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram() { Font = new Font("Segoe UI Emoji", 12) };
            diagram.ForeColor = foreColor;
            diagram.BackColor = backColor;
            diagram.ScaleMode = ScaleMode.ScaleToFit;
            diagram.Direction = DiagramDirection.LeftRight;

            var timer = new System.Windows.Forms.Timer() { Interval = 1000 };

            var insects = "🐝,🦋,🐞,🐜,🐛,🦗,🦟,🐌".Split(",");

            var edgeStyle = new ChartStyle() { StrokeColor = Color.FromArgb(64, foreColor) };

            timer.Tick += (s, e) =>
            {
                var nodes = diagram.Nodes;
                var edges = diagram.Edges;

                if (nodes.Count >= 50)
                {
                    nodes.Clear();
                    edges.Clear();
                }

                var text = insects[rnd.Next(0, insects.Length)].Trim();
                nodes.Add(new Node() { Text = text, LegendItem = text, Shape = Shape.Circle });

                var i = rnd.Next(0, nodes.Count-1);
                if(i != nodes.Count-1)
                    edges.Add(new Edge() { Source = nodes[i], Target = nodes[nodes.Count-1], Style = edgeStyle });
                i = rnd.Next(0, nodes.Count - 1);
                if (i != nodes.Count - 1)
                    edges.Add(new Edge() { Source = nodes[i], Target = nodes[nodes.Count - 1], Style = edgeStyle });
            };

            diagram.ParentChanged += (s, e) => timer.Enabled = diagram.Parent != null;
            diagram.Click += (s, e) => timer.Enabled = !timer.Enabled;
            diagram.Disposed += (s, e) => timer.Dispose();

            return diagram;
        }
    }
}
