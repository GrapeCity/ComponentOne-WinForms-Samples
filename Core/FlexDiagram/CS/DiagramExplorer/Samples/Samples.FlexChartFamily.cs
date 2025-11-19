using C1.Chart;
using C1.Diagram;
using C1.Win.Diagram;
using C1.Win.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramExplorer.Samples
{
    partial class Samples
    {
        public static Control CreateFlexChartFamily(Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram() { BackColor = backColor, ForeColor = foreColor };
            diagram.Font = new Font("Segoe UI Emoji", 12);
            diagram.Header.Content = "FlexChart Family";

            var nodes = diagram.Nodes;
            var edges = diagram.Edges;

            var w = 120;
            var h = 80;

            nodes.Add(new Node() { Text = "📈 FlexChart", Content = "6 Charting Components" });// 0
            nodes.Add(new Node() { Text = "📋 Table-based Data" }); // 1
            nodes.Add(new Node() { Appearance = NodeAppearance.Hidden });//
            nodes.Add(new Node() { Text = "🌳 Hierarchical Data" }); // 2

            nodes.Add(new Node() { Text = "📈 FlexChart", TitleImage = CreateFlexChart(w, h, foreColor, backColor) });//3
            nodes.Add(new Node() { Text = "🥧 FlexPie", TitleImage = CreateFlexPie(w, h, foreColor, backColor) });// 4
            nodes.Add(new Node() { Text = "📡 FlexRadar", TitleImage = CreateRadarChart(w, h, foreColor, backColor) }); // 5

            nodes.Add(new Node() { Text = "🧱 TreeMap", TitleImage = CreateTreeMap(w, h, foreColor, backColor) }); // 6
            nodes.Add(new Node() { Text = "💥 Sunburst", TitleImage = CreateSunburstChart(w, h, foreColor, backColor) });// 7
            nodes.Add(new Node() { Text = "🔀 FlexDiagram", TitleImage = CreateDiagram(w, h, foreColor, backColor) });// 7

            edges.Add(new Edge() { Source = nodes[0], Target = nodes[1] });
            edges.Add(new Edge() { Source = nodes[0], Target = nodes[2] });
            edges.Add(new Edge() { Source = nodes[0], Target = nodes[3] });

            edges.Add(new Edge() { Source = nodes[1], Target = nodes[4] });
            edges.Add(new Edge() { Source = nodes[1], Target = nodes[5] });
            edges.Add(new Edge() { Source = nodes[1], Target = nodes[6] });

            edges.Add(new Edge() { Source = nodes[3], Target = nodes[7] });
            edges.Add(new Edge() { Source = nodes[3], Target = nodes[8] });
            edges.Add(new Edge() { Source = nodes[3], Target = nodes[9] });

            foreach (var node in nodes)
            {
                node.TitleDirection = Direction.Vertical;
                node.TitleOrder = LabelOrder.TextImage;
                node.Shape = Shape.RoundedRectangle;
            }
            diagram.ScaleMode = ScaleMode.ScaleToFit;

            SetHeaderStyle(diagram);
            return diagram;
        }

        static Image CreateFlexChart(int w, int h, Color foreColor, Color backColor)
        {
            var pts = new List<Point>();
            for (var i = 0; i < 6; i++)
                pts.Add(new Point(i, rnd.Next(100)));

            var chart = new FlexChart() { Binding = "Y", BindingX = "X", DataSource = pts, ForeColor = foreColor, BackColor = backColor };
            chart.Series.Add(new Series());
            chart.Margin = new Padding(0);
            var ms = new MemoryStream();
            chart.SaveImage(ms, ImageFormat.Png, w, h);
            return Image.FromStream(ms);
        }

        static Image CreateFlexPie(int w, int h, Color foreColor, Color backColor)
        {
            var pts = new List<Point>();
            for (var i = 0; i < 4; i++)
                pts.Add(new Point(i, rnd.Next(100)));

            var chart = new FlexPie() { Binding = "Y", BindingName = "X", DataSource = pts, ForeColor = foreColor, BackColor = backColor };
            chart.Legend.Position = Position.None;
            chart.Margin = new Padding(0);
            var ms = new MemoryStream();
            chart.SaveImage(ms, ImageFormat.Png, w, h);
            return Image.FromStream(ms);
        }

        static Image CreateTreeMap(int w, int h, Color foreColor, Color backColor)
        {
            var treeMap = new TreeMap() { Binding = "Value", BindingName = "Name", ForeColor = foreColor, BackColor = backColor };

            treeMap.DataSource = new object[] {
                            new { Name = "Group1", Value = 15 },
                            new { Name = "Group2", Value = 12},
                            new { Name = "Group3", Value = 8},
                        };
            treeMap.Margin = new Padding(0);
            var ms = new MemoryStream();
            treeMap.SaveImage(ms, ImageFormat.Png, w, h);
            return Image.FromStream(ms);
        }

        static Image CreateRadarChart(int w, int h, Color foreColor, Color backColor)
        {
            var chart = new FlexRadar() { ForeColor = foreColor, BackColor = backColor };
            chart.Binding = "Value";
            chart.BindingX = "Name";

            for (int iser = 0; iser < 3; iser++)
            {
                var data = new List<object>();
                for (var i = 0; i < 6; i++)
                    data.Add(new { Name = $"S{i}", Value = rnd.NextDouble() });
                var ser = new RadarSeries() { Name = $"ser {iser}", DataSource = data };

                chart.Series.Add(ser);
            }
            chart.Margin = new Padding(0);
            chart.Legend.Position = Position.None;
            var ms = new MemoryStream();
            chart.SaveImage(ms, ImageFormat.Png, w, h);
            return Image.FromStream(ms);
        }

        static Image CreateSunburstChart(int w, int h, Color foreColor, Color backColor)
        {
            var sunburst = new Sunburst()
            {
                Binding = "sales",
                BindingName = "type",
                ChildItemsPath = "items",
                ForeColor = foreColor,
                BackColor = backColor
            };
            sunburst.Offset = 0.2;
            sunburst.DataLabel.Position = PieLabelPosition.None;
            sunburst.Legend.Position = Position.None;
            sunburst.DataSource = DataService.CreateHierarchicalData();
            sunburst.Margin = new Padding(0);
            var ms = new MemoryStream();
            sunburst.SaveImage(ms, ImageFormat.Png, w, h);
            return Image.FromStream(ms);
        }

        static Image CreateDiagram(int w, int h, Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram() { ForeColor = foreColor, BackColor = backColor };
            diagram.Legend.Position = Position.None;
            var nodes = diagram.Nodes;
            var edges = diagram.Edges;

            for (var i = 0; i < 3; i++)
                nodes.Add(new Node() { Shape = Shape.Circle, LegendItem = $"{i + 1}" });
            edges.Add(new Edge() { Source = nodes[0], Target = nodes[1] });
            edges.Add(new Edge() { Source = nodes[0], Target = nodes[2] });
            diagram.Margin = new Padding(0);
            var ms = new MemoryStream();
            diagram.SaveImage(ms, ImageFormat.Png, w, h);
            return Image.FromStream(ms);
        }

        public class SalesDataItem
        {
            public string? type { get; set; }
            public double sales { get; set; }

            public SalesDataItem[]? items { get; set; }
        }

        static class DataService
        {
            static Random rnd = new Random();
            static int rand() => rnd.Next(10, 100);

            public static SalesDataItem[] CreateHierarchicalData()
            {
                var data = new SalesDataItem[] {
                    new SalesDataItem {
                        type = "Electronics",
                        items = new SalesDataItem[] {
                            new SalesDataItem{
                                type = "Camera",
                                items = new SalesDataItem[]
                                {
                                        new SalesDataItem{ type = "Digital", sales = rand() },
                                        new SalesDataItem{ type = "Film", sales = rand() },
                                }
                            },
                            new SalesDataItem{
                                type = "Headphones",
                                items = new SalesDataItem[]
                                {
                                        new SalesDataItem{ type = "Earbud", sales = rand() },
                                        new SalesDataItem{ type = "Over-ear", sales = rand() },
                                        new SalesDataItem{ type = "On-ear", sales = rand() },
                                }
                            }
                        }
                    },
                    new SalesDataItem{
                        type = "Computers\n& Tablets",
                        items = new SalesDataItem[]
                        {
                            new SalesDataItem
                            {
                                type = "Desktops",
                                items = new SalesDataItem[]
                                {
                                    new SalesDataItem{ type = "All-in-ones", sales = rand() },
                                    new SalesDataItem{ type = "Minis", sales = rand() },
                                }
                            },
                            new SalesDataItem
                            {
                                type = "Laptops",
                                items = new SalesDataItem[]
                                {
                                    new SalesDataItem{ type = "2 in 1", sales = rand() },
                                    new SalesDataItem{ type = "Traditional", sales = rand() }
                                }
                            },
                        }
                    }
                };
                return data;
            }
        }
    }
}
