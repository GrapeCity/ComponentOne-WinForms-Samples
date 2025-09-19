using C1.Chart;
using C1.Diagram;
using C1.Diagram.Parser;
using C1.Win.Diagram;
using CreatingDiagram.Data;

namespace CreatingDiagram
{
    public static class DiagramFactory
    {
        public static void Clear(FlexDiagram diagram)
        {
            ((IDiagram)diagram).Clear();
            diagram.Direction = DiagramDirection.TopBottom;
        }

        public static Control? CreateUnboundDiagram(FlexDiagram diagram)
        {
            Clear(diagram);

            var startNode = new Node() { Text = "Start Process" };
            var processNode = new Node() { Text = "Execute", Shape = Shape.RoundedRectangle };
            var endNode = new Node() { Text = "Complete" };

            diagram.Nodes.Add(startNode);
            diagram.Nodes.Add(processNode);
            diagram.Nodes.Add(endNode);

            diagram.Edges.Add(new Edge()
            {
                Source = startNode,
                Target = processNode,
                TargetArrow = ArrowStyle.Normal
            });

            diagram.Edges.Add(new Edge()
            {
                Source = processNode,
                Target = endNode,
                TargetArrow = ArrowStyle.Normal
            });

            return null;
        }

        public static Control? CreateBoundDiagram(FlexDiagram diagram)
        {
            Clear(diagram);
            diagram.Direction = DiagramDirection.LeftRight;

            var dataSource = DataService.CreateHierarchicalData();

            diagram.DataSource = dataSource;
            diagram.Binding = "Type";
            diagram.ChildItemsPath = "Items";


            var treeView = new TreeView() { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None };
            treeView.Nodes.Clear();

            foreach (var item in dataSource)
            {
                var node = treeView.Nodes.Add(item.Type);
                AddItems(node, item);
            }

            treeView.ExpandAll();

            return treeView;
        }

        static void AddItems(TreeNode node, SalesDataItem item)
        {
            if (item.Items == null)
                return;

            foreach (var n in item.Items)
            {
                var child = node.Nodes.Add(n.Type);
                AddItems(child, n);
            }
        }

        public static Control? CreateTableBoundDiagram(FlexDiagram diagram)
        {
            Clear(diagram);

            var table = DataService.CreateSkillsTable();

            diagram.Direction = DiagramDirection.LeftRight;
            diagram.DataSource = table;
            diagram.Binding = "Field,Domain,Specialty,Skill";

            var grid = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false, ColumnHeadersVisible = false };
            grid.DataSource = table;

            return grid;
        }

        public static Control? CreateMermaidDiagram(FlexDiagram diagram)
        {
            Clear(diagram);

            var text = File.ReadAllText("Resources\\pizza.txt");
            diagram.LoadMermaidGraph(text);

            var textBox = new TextBox() { Multiline = true, Dock = DockStyle.Fill };
            textBox.Font = new Font("Consolas", diagram.Font.Size);
            textBox.Text = text;

            return textBox;
        }
    }
}
