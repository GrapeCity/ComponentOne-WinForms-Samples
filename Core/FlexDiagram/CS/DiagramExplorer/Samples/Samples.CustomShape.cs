using C1.Diagram;
using C1.Win.Chart;
using C1.Win.Diagram;

namespace DiagramExplorer.Samples
{
    internal partial class Samples
    {
        public static Control CreateCustomShapeDiagram(Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram()
            {
                ForeColor = foreColor,
                BackColor = backColor,
                Direction = DiagramDirection.LeftRight,
                ScaleMode = ScaleMode.ScaleToFit
            };
            diagram.Header.Content = "Custom Node Shape";
            SetHeaderStyle(diagram);

            var edgeStyle = new ChartStyle() { StrokeColor = Color.FromArgb(64, foreColor) };
            var palette = C1.Win.Chart.Palettes.Qualitative.Pastel1;

            var timer = new System.Windows.Forms.Timer() { Interval = 1000 };
            timer.Tick += (s, e) =>
            {
                var nodes = diagram.Nodes;
                var edges = diagram.Edges;

                if (nodes.Count >= 50)
                {
                    nodes.Clear();
                    edges.Clear();
                }

                
                nodes.Add(new Node() { 
                    Text = $"{nodes.Count}", 
                    Shape = Shape.None,
                    Style = new ChartStyle() { Fill = palette[rnd.Next(0, palette.Count)], StrokeColor = Color.Black }
                });

                var i = rnd.Next(0, nodes.Count - 1);
                if (i != nodes.Count - 1)
                    edges.Add(new Edge() { Source = nodes[i], Target = nodes[^1], Style = edgeStyle });
            };

            diagram.ParentChanged += (s, e) => timer.Enabled = diagram.Parent != null;
            diagram.Click += (s, e) => timer.Enabled = !timer.Enabled;
            diagram.Disposed += (s, e) => timer.Dispose();

            diagram.NodeRendering += (s, e) =>
            {
                var d = diagram as IDiagram;
                var (left, top, width, height) = d.GetRect(e.Node);

                e.Engine.SetStroke(Color.Transparent.ToArgb());
                e.Engine.SetFill(e.Node.Style.Fill);
                DrawBlob(e.Engine, left, top, width, height, d.GetNodes().IndexOf(e.Node));
            };

            return diagram;
        }

        public static void DrawBlob(C1.Chart.IRenderEngine e, double left, double top, double width, double height, int seed = 1)
        {
            var rnd = new Random(seed);

            int f1 = 3 + rnd.Next(0, 3);
            int f2 = 5 + rnd.Next(0, 3);
            int f3 = 7 + rnd.Next(0, 3);

            double p1 = rnd.NextDouble() * Math.PI * 2;
            double p2 = rnd.NextDouble() * Math.PI * 2;
            double p3 = rnd.NextDouble() * Math.PI * 2;

            const int steps = 120;

            var rx = 0.5 * width;
            var ry = 0.5 * height;

            var cx = left + rx;
            var cy = top + ry;

            var xs = new double[steps];
            var ys = new double[steps];

            for (int i = 0; i < steps; i++)
            {
                double t = i * 2.0 * Math.PI / steps;
                double r = 1.0 + 0.11 * Math.Sin(f1 * t + p1) + 0.06 * Math.Cos(f2 * t + p2) + 0.04 * Math.Sin(f3 * t + p3);
                xs[i] = cx + rx * r * Math.Cos(t);
                ys[i] = cy + ry * r * Math.Sin(t);
            }

            e.DrawPolygon(xs, ys);
        }
    }
}
