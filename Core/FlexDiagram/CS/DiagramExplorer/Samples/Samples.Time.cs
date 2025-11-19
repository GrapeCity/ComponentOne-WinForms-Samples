using C1.Chart;
using C1.Diagram;
using C1.Diagram.Parser;
using C1.Win.Chart;
using C1.Win.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

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

            var time = DateTime.Now;

            var styleActive = new ChartStyle() { StrokeColor = diagram.ForeColor, StrokeWidth = 2 };
            var styleBlink = new ChartStyle() { FillColor = (time.Second % 2) == 0 ? diagram.ForeColor : diagram.BackColor, StrokeWidth = 2 };

            var minuteNode = new Node() { Shape = Shape.Circle, Style = styleBlink };
            nodes.Add(minuteNode);
            var secondNode = new Node() { Shape = Shape.Circle, Style = styleBlink  };
            nodes.Add(secondNode);

            for (var j = 0; j < 10; j++)
                AddTimeNode(diagram, null, minuteNode, time, (t) => t.Hour, "h", j, styleActive);

            for (var j = 0; j < 10; j++)
                AddTimeNode(diagram, minuteNode, secondNode, time, (t) => t.Minute, "m", j, styleActive);

            for (var j = 0; j < 10; j++)
                AddTimeNode(diagram, secondNode, null, time, (t) => t.Second, "s", j, styleActive);

            diagram.EndUpdate();
        }

        private static void AddTimeNode(FlexDiagram diagram, Node from, Node to, DateTime time, Func<DateTime,int> getValue, 
            string suffix, int i, ChartStyle styleActive)
        {
            var val = getValue(time);
            var node = new Node() { Text = $"{10 * (val / 10) + i: 00}{suffix}", Shape = Shape.RoundedRectangle };

            var pos = 1 - (double)Math.Abs((i - (val % 10)) / 9.0);
            var color = Interpolate(diagram.BackColor, diagram.ForeColor, pos * pos * pos);

            var active = val % 10 == i;
            node.Style = active ? styleActive : new ChartStyle() { StrokeColor = color }; ;

            diagram.Nodes.Add(node);

            if (from != null)
            {
                diagram.Edges.Add(new Edge()
                {
                    Source = from,
                    Target = node,
                    Style = node.Style,
                    TargetArrow = active ? ArrowStyle.Normal : ArrowStyle.None
                });
            }

            if (to != null)
            {
                diagram.Edges.Add(new Edge() { Source = node, Target = to, Style = node.Style,
                    TargetArrow = active ? ArrowStyle.Normal : ArrowStyle.None
                });
            }
        }
    }
}
