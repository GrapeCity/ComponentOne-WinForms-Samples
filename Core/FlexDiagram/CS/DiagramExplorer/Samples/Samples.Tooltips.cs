using C1.Diagram;
using C1.Diagram.Parser;
using C1.Win.Chart;
using C1.Win.Diagram;
using DiagramExplorer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramExplorer.Samples
{
    internal partial class Samples
    {
        public static Control CreateTooltipsDiagram(Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram();
            diagram.ForeColor = foreColor;
            diagram.BackColor = backColor;
            diagram.ScaleMode = ScaleMode.ScaleToFit;

            var nodes = diagram.Nodes;
            var edges = diagram.Edges;

            var titleStyle = new C1.Win.Chart.ChartStyle()
            {
                StrokeColor = Color.White,
                Font = new Font(diagram.Font.Name, 16)
            };
            var redNode = new Node() 
            { 
                Text = "Red", Shape = Shape.RoundedRectangle, 
                Style = new C1.Win.Chart.ChartStyle() { FillColor = Color.Red }, 
                TitleStyle = titleStyle
            };
            var greenNode = new Node() 
            { 
                Text = "Green", Shape = Shape.RoundedRectangle,
                Style = new C1.Win.Chart.ChartStyle() { FillColor = Color.Green },
                TitleStyle = titleStyle
            };
            var blueNode = new Node() 
            { 
                Text = "Blue", Shape = Shape.RoundedRectangle,
                Style = new C1.Win.Chart.ChartStyle() { FillColor = Color.Blue },
                TitleStyle = titleStyle
            };

            nodes.Add(redNode);
            nodes.Add(greenNode);
            nodes.Add(blueNode);

            var redNodes = new List<Node>();
            var greenNodes = new List<Node>();

            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                if ((int)color >= 28 && (int)color <=167)
                {
                    var c = Color.FromKnownColor(color);
                    var node = new Node() { Tooltip = $"{color}\nR:{c.R}\nG:{c.G}\nB:{c.B}", Shape = Shape.Circle };

                    var edgeStyle = new C1.Win.Chart.ChartStyle() { FillColor = c, StrokeColor = c, StrokeWidth = 2 };

                    node.Style = new C1.Win.Chart.ChartStyle() { StrokeWidth = 0.1f, FillColor = c };

                    var s = color.ToString();
                    if (s.Contains("Red"))
                    {
                        redNodes.Add(node);
                        nodes.Add(node);
                        edges.Add(new Edge() { Source = redNode, Target = node, Style = edgeStyle, TargetArrow = C1.Chart.ArrowStyle.Normal });
                    }
                    else if (s.Contains("Blue"))
                    {
                        nodes.Add(node);
                        edges.Add(new Edge() { Source = blueNode, Target = node, Style = edgeStyle, TargetArrow = C1.Chart.ArrowStyle.Normal });
                    }
                    else if (s.Contains("Green"))
                    {
                        greenNodes.Add(node);
                        nodes.Add(node);
                        edges.Add(new Edge() { Source = greenNode, Target = node, Style = edgeStyle, TargetArrow = C1.Chart.ArrowStyle.Normal });
                    }

                    //if (c.R == c.G && c.R == c.B)
                    //    edges.Add(new Edge() { Source = grayNode, Target = node });
                    //else if (c.R > c.G && c.R > c.B)
                    //    edges.Add(new Edge() { Source = redNode, Target = node });
                    //else if (c.G > c.R && c.G > c.B)
                    //    edges.Add(new Edge() { Source = greenNode, Target = node });
                    //else if (c.B > c.R && c.B > c.G)
                    //    edges.Add(new Edge() { Source = blueNode, Target = node });
                    //else
                    //    edges.Add(new Edge() { Source = neutralNode, Target = node });
                }
            };

            var emptyStyle = new ChartStyle() { StrokeColor = Color.Transparent };

            edges.Add(new Edge() { Source = redNodes[redNodes.Count / 2], Target = greenNode, Style = emptyStyle });
            edges.Add(new Edge() { Source = greenNodes[greenNodes.Count / 2], Target = blueNode, Style = emptyStyle });

            return diagram;
        }

    }
}
