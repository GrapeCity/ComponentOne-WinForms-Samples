using C1.Chart.Serialization;
using C1.Diagram;
using C1.Diagram.Parser;
using C1.Diagram.Serialization;
using C1.Win.Chart;
using DiagramEditor.Controls;
using DiagramEditor.Helpers;


namespace DiagramEditor;

public class MainForm : Form
{
    private readonly DiagramCanvas canvas = new();

    private readonly ToolStrip toolStrip = new();

    private readonly Panel leftPanel = new();
    private readonly Panel rightPanel = new();

    private readonly StatusStrip statusStrip = new();
    private readonly ToolStripStatusLabel statusLabel = new();
    private readonly ToolStripStatusLabel statusLabel2 = new();

    private readonly Controls.DiagramEditor diagramEditor = new();
    private readonly NodeEditor nodeEditor = new();
    private readonly EdgeEditor edgeEditor = new();

    private readonly TabControl tabs = new() { Dock = DockStyle.Fill };

    public MainForm()
    {
        ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new AppStyles.ModernColorTable());

        Text = "Diagram Editor";
        Width = 1180;
        Height = 760;
        StartPosition = FormStartPosition.CenterScreen;
        KeyPreview = true;

        BuildToolStrip();
        BuildLeftPanel();
        BuildRightPanel();
        BuildStatusStrip();

        Controls.Add(canvas);
        Controls.Add(leftPanel);
        Controls.Add(rightPanel);
        Controls.Add(toolStrip);
        Controls.Add(statusStrip);

        canvas.SelectionChanged += Canvas_SelectionChanged;

        KeyDown += MainForm_KeyDown;

        UpdateStatus();
    }

    // -------------------------------------------------------------- build

    private void BuildToolStrip()
    {
        toolStrip.Padding = new Padding(8);

        toolStrip.GripStyle = ToolStripGripStyle.Hidden;
        toolStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
        toolStrip.ImageScalingSize = new Size(24, 24);

        ToolStripSplitButton btnNew = new("New", Properties.Resources.new_diagram_24);
        btnNew.ButtonClick += (_, _) => canvas.ClearAll();

        var img = Properties.Resources.new_template_24;

        btnNew.DropDownItems.Add("New Linear Process", img, (_, _) => LoadFromResource("Templates.linear-process.mermaid"));
        btnNew.DropDownItems.Add("New Decision Process", img, (_, _) => LoadFromResource("Templates.process-decision.mermaid"));
        btnNew.DropDownItems.Add("New Org Chart", img, (_, _) => LoadFromResource("Templates.org-chart.mermaid"));
        btnNew.DropDownItems.Add("New Breakdown Structure", img, (_, _) => LoadFromResource("Templates.breakdown-structure.mermaid"));
        btnNew.DropDownItems.Add("New Milestone Chain", img, (_, _) => LoadFromResource("Templates.milestones.mermaid"));

        btnNew.DropDownItems.Add(new ToolStripSeparator());
        btnNew.DropDownItems.Add("Import Mermaid.js ..", Properties.Resources.import_mermaid_graph_24, (_, _) => ImportMermaid());

        toolStrip.Items.Add(btnNew);

        var btnOpen = new ToolStripButton("Open", Properties.Resources.open_diagram_24, (_, _) => Open());
        toolStrip.Items.Add(btnOpen);

        toolStrip.Items.Add(new ToolStripSeparator());

        var btnSave = new ToolStripButton("Save", Properties.Resources.save_diagram_24, (_, _) => Save());
        toolStrip.Items.Add(btnSave);

        var exportSplit = new ToolStripSplitButton("Export", Properties.Resources.export_diagram_24);
        exportSplit.DropDownItems.Add("Export as SVG", Properties.Resources.export_svg_24, (_, _) => Export(ImageFormat.Svg));
        exportSplit.DropDownItems.Add("Export as JPG", Properties.Resources.export_jpg_24, (_, _) => Export(ImageFormat.Jpg));
        exportSplit.DropDownItems.Add("Export as PNG", Properties.Resources.export_png_24, (_, _) => Export(ImageFormat.Png));
        exportSplit.ButtonClick += (_, _) => Export(ImageFormat.Png);
        toolStrip.Items.Add(exportSplit);
    }

    private void BuildLeftPanel()
    {
        leftPanel.Dock = DockStyle.Left;
        leftPanel.Width = 124;
        leftPanel.BackColor = AppStyles.PanelBackColor;

        var flow = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            AutoScroll = true,
            Padding = new Padding(4, 4, 0, 0)
        };

        var items = new List<ToolboxItem>();
        foreach (Shape shape in Enum.GetValues<Shape>())
        {
            if (shape != Shape.Default)
                items.Add(new ToolboxItem(canvas.Diagram, shape, AddNode));
        }

        AddToolboxGroup(flow, "Nodes", items.ToArray());

        leftPanel.Controls.Add(flow);
    }

    void AddNode(object? sender, EventArgs args)
    {
        if (sender is ToolboxItem item)
            canvas.AddNode(item.Shape);
    }

    private static void AddToolboxGroup(FlowLayoutPanel flow, string title, params Control[] items)
    {
        flow.Controls.Add(new Label()
        {
            Text = title,
            Font = AppStyles.BoldFont,
            ForeColor = AppStyles.HeaderColor,
            TextAlign = ContentAlignment.MiddleCenter
        });

        foreach (var item in items)
            flow.Controls.Add(item);
    }

    private void BuildRightPanel()
    {
        rightPanel.Dock = DockStyle.Right;
        rightPanel.Width = 240;
        rightPanel.BackColor = AppStyles.PanelBackColor;

        tabs.TabPages.Add(BuildDiagramTab());
        tabs.TabPages.Add(BuildNodeTab());
        tabs.TabPages.Add(BuildEdgeTab());

        rightPanel.Controls.Add(tabs);
    }

    private TabPage BuildDiagramTab()
    {
        var tab = new TabPage("Diagram");
        diagramEditor.Target = canvas.Diagram;
        tab.Controls.Add(diagramEditor);
        return tab;
    }

    private TabPage BuildNodeTab()
    {
        var tab = new TabPage("Node");
        tab.Controls.Add(nodeEditor);
        return tab;
    }

    private TabPage BuildEdgeTab()
    {
        var tab = new TabPage("Edge");
        tab.Controls.Add(edgeEditor);
        return tab;
    }


    private void BuildStatusStrip()
    {
        statusStrip.Items.Add(statusLabel);
        statusStrip.Items.Add(new ToolStripSeparator());

        statusStrip.Items.Add(statusLabel2);
    }

    // ------------------------------------------------------------- events

    private void Canvas_SelectionChanged(object? sender, EventArgs e)
    {
        UpdateStatus();

        nodeEditor.Target = canvas.SelectedNode;
        edgeEditor.Target = canvas.SelectedEdge;

        if (canvas.SelectedNode != null)
            tabs.SelectTab(1);
        else if (canvas.SelectedEdge != null)
            tabs.SelectTab(2);
        else
            tabs.SelectTab(0);
    }

    private void MainForm_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
            canvas.DeleteSelected();
    }

    // ------------------------------------------------------------- helpers

    private void UpdateStatus()
    {
        statusLabel.Text = $"{canvas.Diagram.Nodes.Count} node(s) | {canvas.Diagram.Edges.Count} edge(s)";
        statusLabel2.Text = canvas.SelectedNode != null
            ? "Ctrl+Click another node to connect them"
            : "Select a node, then Ctrl+Click another to connect them";
    }

    private void Export(ImageFormat format)
    {
        var diagram = canvas.Diagram;
        var fmt = format.ToString().ToLower();

        using var dlg = new SaveFileDialog { Filter = $"{fmt} Image|*.{fmt}", FileName = $"diagram.{fmt}" };

        if (dlg.ShowDialog(this) != DialogResult.OK)
            return;

        using (var stream = dlg.OpenFile())
        {
            using var g = diagram.CreateGraphics();
            using var e = new GraphicsRenderEngine();
            e.SetGraphics(g);
            var size = ((C1.Chart.ISizeProvider)diagram).Measure(e);
            diagram.SaveImage(stream, format, (int)size.Width, (int)size.Height);
        }
    }


    private void Save()
    {
        var diagram = canvas.Diagram;
        using var dlg = new SaveFileDialog { Filter = $"FlexDiagram|*.xml", FileName = "diagram.xml" };

        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            var xml = diagram.SerializeToXml();
            File.WriteAllText(dlg.FileName, xml);
        }
    }

    private void Open()
    {
        var diagram = canvas.Diagram;
        using var dlg = new OpenFileDialog { Filter = $"FlexDiagram|*.xml" };

        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            var xml = File.ReadAllText(dlg.FileName);
            diagram.DeserializeFromXml(xml);
            diagramEditor.RefreshFromTarget();
        }
    }

    private void LoadFromResource(string name)
    {
        canvas.Diagram.LoadDiagramFromResource(name);
        diagramEditor.RefreshFromTarget();
    }

    private void ImportMermaid()
    {
        var dlg = new OpenFileDialog() { Filter = $"MermaidJS graph|*.mermaid" };
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            var text = File.ReadAllText(dlg.FileName);
            canvas.Diagram.LoadMermaidGraph(text);
            diagramEditor.RefreshFromTarget();
            UpdateStatus();
        }
    }
}
