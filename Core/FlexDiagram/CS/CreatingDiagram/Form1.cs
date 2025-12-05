using C1.Chart;
using C1.Diagram;
using C1.Diagram.Parser;
using C1.Win.Chart;
using C1.Win.Diagram;
using CreatingDiagram.Data;
using static C1.Util.Win.Win32;

namespace CreatingDiagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChartStyle nodeStyle = new ChartStyle() { StrokeWidth = 0 };
        ChartStyle hoverStyle = new ChartStyle() { StrokeWidth = 1 };
        Node? hoverNode = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateOverviewDiagram();
            InitUI();

            hoverStyle.Font = new Font(flexDiagram1.Font, FontStyle.Underline);

            flexDiagram1.MouseMove += FlexDiagram1_MouseMove;
            flexDiagram1.MouseClick += FlexDiagram1_MouseClick;
        }

        private void FlexDiagram1_MouseClick(object? sender, MouseEventArgs e)
        {
            var info = flexDiagram1.HitTest(e.X, e.Y);
            if (info != null && info.Distance == 0 && info.Element is Node node)
            {
                if (node.Data is DiagramInfo diagramInfo)
                {
                    var dataControl = diagramInfo.Builder?.Invoke(flexDiagram1);
                    codeSnippet1.Code = diagramInfo.Code;
                    buttonBack.Visible = true;
                    tabControl1.Visible = true;
                    tableLayoutPanel1.SetColumnSpan(flexDiagram1, 1);

                    toolStripLabel1.Text = diagramInfo.Header;
                    toolStripStatusLabel1.Text = "";

                    if (dataControl != null)
                    {
                        tabPage2.Controls.Clear();
                        tabPage2.Controls.Add(dataControl);
                        if (!tabControl1.TabPages.Contains(tabPage2))
                            tabControl1.TabPages.Add(tabPage2);
                    }
                    else
                    {
                        if (tabControl1.TabPages.Contains(tabPage2))
                            tabControl1.TabPages.Remove(tabPage2);
                    }
                }
            }
        }

        private void FlexDiagram1_MouseMove(object? sender, MouseEventArgs e)
        {
            var info = flexDiagram1.HitTest(e.X, e.Y);
            if (info != null && info.Distance == 0 && info.Element is Node node)
            {
                if (node.Data != null)
                {
                    hoverNode = node;
                    hoverNode.Style = hoverStyle;
                    Cursor = Cursors.Hand;
                }
                else
                {
                    Cursor = Cursors.Default;
                    if (hoverNode != null)
                    {
                        hoverNode.Style = nodeStyle;
                        hoverNode = null;
                    }
                }
            }
            else
            {
                Cursor = Cursors.Default;
                if (hoverNode != null)
                {
                    hoverNode.Style = nodeStyle;
                    hoverNode = null;
                }
            }
        }

        void CreateOverviewDiagram()
        {
            DiagramFactory.Clear(flexDiagram1);

            flexDiagram1.Legend.Position = Position.None;

            var rootNode = new Node() { Text = "Creating FlexDiagram", Shape = Shape.None };
            rootNode.Style.Font = new Font(flexDiagram1.Font.FontFamily, 14);

            var unboundNode = new Node()
            {
                Text = "Unbound",
                Shape = Shape.RoundedRectangle,
                LegendItem = "Unbound",
                Data = new DiagramInfo()
                {
                    Header = "Unbound FlexDiagram",
                    Builder = (d) => DiagramFactory.CreateUnboundDiagram(d),
                    Code = File.ReadAllText(@"Resources\unbound.txt")
                }
            };

            // dummy node for nice symmetrical alignment
            var dummyNode = new Node()
            {
                Appearance = NodeAppearance.Hidden
            };

            var mermaidNode = new Node()
            {
                Text = "MermaidJS Graph",
                Shape = Shape.RoundedRectangle,
                LegendItem = "Unbound",
                Data = new DiagramInfo()
                {
                    Header = "Parse Mermaid.JS Graph",
                    Builder = (d) => DiagramFactory.CreateMermaidDiagram(d),
                    Code = File.ReadAllText(@"Resources\mermaid.txt")
                }
            };

            var dataBindingNode = new Node() 
            { 
                Text = "Hierarchical Data",
                Shape = Shape.RoundedRectangle,
                LegendItem = "Bound",
                Data = new DiagramInfo()
                {
                    Header = "Hierarchical Data Source",
                    Builder = (d) => DiagramFactory.CreateBoundDiagram(d),
                    Code = File.ReadAllText(@"Resources\bound.txt")
                }
            };
            
            var dataBindingFlatNode = new Node() 
            { 
                Text = "Flat Data (Table)",
                Shape = Shape.RoundedRectangle,
                LegendItem = "Bound",
                Data = new DiagramInfo()
                {
                    Header = "Flat Data Source (Data Table)",
                    Builder = (d) => DiagramFactory.CreateTableBoundDiagram(d),
                    Code = File.ReadAllText(@"Resources\table.txt")
                }
            };

            flexDiagram1.Nodes.Add(unboundNode);
            flexDiagram1.Nodes.Add(mermaidNode);
            flexDiagram1.Nodes.Add(dummyNode);
            flexDiagram1.Nodes.Add((dataBindingNode));
            flexDiagram1.Nodes.Add((dataBindingFlatNode));

            flexDiagram1.Nodes.Add(rootNode);

            flexDiagram1.Edges.Add(new Edge() { Source = rootNode, Target = unboundNode, TargetArrow = ArrowStyle.Normal });
            flexDiagram1.Edges.Add(new Edge() { Source = rootNode, Target = mermaidNode, TargetArrow = ArrowStyle.Normal });
            flexDiagram1.Edges.Add(new Edge() { Source = rootNode, Target = dummyNode});
            flexDiagram1.Edges.Add(new Edge() { Source = rootNode, Target = dataBindingNode, TargetArrow = ArrowStyle.Normal });
            flexDiagram1.Edges.Add(new Edge() { Source = rootNode, Target = dataBindingFlatNode, TargetArrow = ArrowStyle.Normal });

            SetStyles();
        }

        void SetStyles()
        {
            foreach (var node in flexDiagram1.Nodes)
                node.Style.StrokeWidth = 0;
        }

        private void InitUI()
        {
            toolStripLabel1.Text = "Overview";
            buttonBack.Visible = false;
            tableLayoutPanel1.SetColumnSpan(flexDiagram1, 2);
            tabControl1.Visible = false;
            toolStripStatusLabel1.Text = "Click on the node to see demo";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CreateOverviewDiagram();
            InitUI();
        }
    }

    class DiagramInfo
    {
        public string Header { get; set; } = "";

        public Func<FlexDiagram,Control?>? Builder { get; set; }
        public string Code { get; set; } = "";
    }
}
