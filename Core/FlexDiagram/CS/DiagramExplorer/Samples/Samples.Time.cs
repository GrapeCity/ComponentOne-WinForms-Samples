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
        public static Control CreateTimeDiagram(Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram();
            diagram.ForeColor = foreColor;
            diagram.BackColor = backColor;
            diagram.ScaleMode = ScaleMode.ScaleToFit;
            diagram.Direction = DiagramDirection.LeftRight;

            UpdateTimeDiagram(diagram);

            var timer = new System.Windows.Forms.Timer() { Interval = 1000 };
            timer.Tick += (s, e) =>  UpdateTimeDiagram(diagram);

            diagram.ParentChanged += (s, e) =>
            {
                if(diagram.Parent != null)
                    timer.Start();
                else
                    timer.Stop();
            };
            diagram.Disposed += (s, e) => timer.Dispose();

            return diagram;
        }

        static void UpdateTimeDiagram(FlexDiagram diagram)
        {
            diagram.BeginUpdate();

            var nodes = diagram.Nodes;
            var edges = diagram.Edges;
            nodes.Clear();
            edges.Clear();

            var shape = Shape.RoundedRectangle;

            var time = DateTime.Now;

            var styleActive = new ChartStyle() { StrokeColor = diagram.ForeColor, StrokeWidth = 2 };
            var style = new ChartStyle() { StrokeColor = Color.FromArgb(30, diagram.ForeColor) };

            var hourNode = new Node() { Text = $"{(int)(time.Hour / 10)}", Shape = shape, Style = styleActive };
            nodes.Add(hourNode);
            var minuteNode = new Node() { Text = $"{(int)(time.Minute / 10)}", Shape = shape, Style = styleActive };
            nodes.Add(minuteNode);
            var secondNode = new Node() { Text = $"{(int)(time.Second / 10)}", Shape = shape, Style = styleActive };
            nodes.Add(secondNode);

            for (var j = 0; j < 10; j++)
            {
                var node = new Node() { Text = $"{j}h", Shape = shape };
                var active = time.Hour % 10 == j;
                node.Style = active ? styleActive :
                    new ChartStyle() { StrokeColor = Color.FromArgb(60 - 6 * Math.Abs((time.Hour % 10) - j), diagram.ForeColor) }; ;
                nodes.Add(node);

                edges.Add(new Edge() { Source = hourNode, Target = node, Style = node.Style,
                    TargetArrow = active ? C1.Chart.ArrowStyle.Normal : C1.Chart.ArrowStyle.None
                });
                edges.Add(new Edge() { Source = node, Target = minuteNode, Style = node.Style,
                    TargetArrow = active ? C1.Chart.ArrowStyle.Normal : C1.Chart.ArrowStyle.None
                });
            }


            for (var j = 0; j < 10; j++)
            {
                var node = new Node() { Text = $"{j}m", Shape = shape };
                var active = time.Minute % 10 == j;
                node.Style = active ? styleActive :
                    new ChartStyle() { StrokeColor = Color.FromArgb(60 - 6 * Math.Abs((time.Minute % 10) - j), diagram.ForeColor) }; ;
                nodes.Add(node);
                edges.Add(new Edge() { Source = minuteNode, Target = node, Style = node.Style,
                    TargetArrow = active ? C1.Chart.ArrowStyle.Normal : C1.Chart.ArrowStyle.None
                });
                edges.Add(new Edge() { Source = node, Target = secondNode, Style = node.Style,
                    TargetArrow = active ? C1.Chart.ArrowStyle.Normal : C1.Chart.ArrowStyle.None
                });
            }

            for (var j = 0; j < 10; j++)
            {
                var node = new Node() { Text = $"{time.Second}s", Shape = shape };

                var active = time.Second % 10 == j;
                node.Style = active ? styleActive : 
                    new ChartStyle() { StrokeColor = Color.FromArgb( 60 - 6 * Math.Abs((time.Second % 10)-j), diagram.ForeColor) }; ;

                nodes.Add(node);
                edges.Add(new Edge() { Source = secondNode, Target = node, Style = node.Style, 
                    TargetArrow = active ? C1.Chart.ArrowStyle.Normal : C1.Chart.ArrowStyle.None });
            }

            diagram.EndUpdate();
        }
    }
}
