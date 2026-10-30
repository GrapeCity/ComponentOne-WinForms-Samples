using C1.Chart;
using C1.Diagram;
using C1.Win.Chart;
using C1.Win.Diagram;
using DiagramEditor.Helpers;

namespace DiagramEditor.Controls;

public class DiagramCanvas : Control
{
    private FlexDiagram _diagram;
    private ContextMenuStrip _contextMenu = new() { ImageScalingSize = new Size(24, 24) };
    private Node? _selectedNode = null;
    private Edge? _selectedEdge = null;

    public DiagramCanvas()
    {
        DoubleBuffered = true;
        AllowDrop = true;
        BackColor = AppStyles.BackColor;
        SetStyle(ControlStyles.ResizeRedraw, true);
        Dock = DockStyle.Fill;

        _diagram = new FlexDiagram() { Dock = DockStyle.Fill, Font = new Font("Segoe UI Emoji", 12) };

        _diagram.Rendering += DiagramRendering;
        _diagram.Rendered += DiagramRendered;
        _diagram.NodeRendered += NodeRendered;

        _diagram.MouseDown += DiagramMouseDown;

        ContextMenuStrip = _contextMenu;
        Controls.Add(_diagram);
    }

    private void DiagramRendering(object? sender, RenderEventArgs e)
    {
        DrawGrid(e.Graphics);
        if (_diagram.Nodes.Count == 0)
        {
            using var textBrush = new SolidBrush(AppStyles.HeaderColor);
            using var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString("Click a shape on the left to add your first node", AppStyles.ItalicFont, textBrush, _diagram.ClientRectangle, format);
        }
    }

    private void DrawGrid(Graphics g)
    {
        var step = 20f;
        if (step < 4) return;
        using var pen = new Pen(Color.FromArgb(0x80, 0xEE, 0xEE, 0xEE));
        for (float x = 0; x < Width; x += step)
            g.DrawLine(pen, x, 0, x, Height);
        for (float y = 0; y < Height; y += step)
            g.DrawLine(pen, 0, y, Width, y);
    }

    private void DiagramRendered(object? sender, RenderEventArgs e)
    {
        if (SelectedEdge != null)
        {
            var engine = e.Engine;
            var rect1 = ((IDiagram)_diagram).GetRect(SelectedEdge.Source);
            var rect2 = ((IDiagram)_diagram).GetRect(SelectedEdge.Target);

            var p1 = new _Point(rect1.left + 0.5 * rect1.width, rect1.top + 0.5 * rect1.height);
            var p2 = new _Point(rect2.left + 0.5 * rect2.width, rect2.top + 0.5 * rect2.height);

            using var stroke = new SolidBrush(AppStyles.SelectionStroke2);
            engine.SetStroke(stroke);
            engine.SetStrokeThickness(20);
            engine.DrawLine(p1.X, p1.Y, p2.X, p2.Y);
        }
    }

    private void NodeRendered(object? sender, C1.Win.Diagram.NodeRenderedEventArgs e)
    {
        if (e.Node == SelectedNode)
        {
            var (left, top, width, height) = ((IDiagram)_diagram).GetRect(e.Node);
            using var stroke = new SolidBrush(AppStyles.SelectionStroke);

            e.Engine.SetFill(null);
            e.Engine.SetStrokePattern([2, 2]);
            e.Engine.SetStrokeThickness(2);
            e.Engine.SetStroke(stroke);
            e.Engine.DrawRect(left - 4, top - 4, width + 8, height + 8);
        }
    }

    private void DiagramMouseDown(object? sender, MouseEventArgs e)
    {
        var info = _diagram.HitTest(e.X, e.Y);

        if (info.Distance <= 4)
        {
            if (info.Element is Node node)
            {
                // add edge
                if ((ModifierKeys & Keys.Control) > 0 && SelectedNode != null)
                {
                    var edge = new Edge { Source = SelectedNode, Target = node };
                    _diagram.Edges.Add(edge);
                    SelectedEdge = edge;
                    SelectedNode = null;
                }
                else
                {
                    SelectedNode = node;
                    SelectedEdge = null;
                }
            }
            else if (info.Element is Edge edge)
            {
                SelectedEdge = edge;
                SelectedNode = null;
            }
        }
        else
        {
            SelectedNode = null;
            SelectedEdge = null;
        }
    }

    private void UpdateContextMenu()
    {
        _contextMenu.Items.Clear();

        var selectedNode = SelectedNode;

        if (selectedNode != null)
        {
            _contextMenu.Items.Add("Remove node", Properties.Resources.remove_node_24, (_, _) => _diagram.Nodes.Remove(selectedNode));

            if (selectedNode.GetEdges().Count > 0)
                _contextMenu.Items.Add("Remove all edges", Properties.Resources.remove_all_edges_24, (_, _) =>
                {
                    var edges = selectedNode.GetEdges();

                    foreach (var edge in edges)
                        _diagram.Edges.Remove(edge as Edge);
                });

            if (_diagram.Nodes.Count > 1)
            {
                _contextMenu.Items.Add(new ToolStripSeparator());
                foreach (Node node in _diagram.Nodes)
                {
                    if (node != selectedNode)
                        _contextMenu.Items.Add($"Add Edge to {node.Text}", Properties.Resources.add_edge_24, (_, _) => _diagram.Edges.Add(new Edge { Source = selectedNode, Target = node }));
                }
            }
        }
        else if (SelectedEdge != null)
        {
            _contextMenu.Items.Add($"Delete Edge {SelectedEdge.ToString()}", Properties.Resources.remove_edge_24, (_, _) =>
            {
                _diagram.Edges.Remove(SelectedEdge);
                SelectedEdge = null;
            });
        }
    }

    #region public

    public FlexDiagram Diagram => _diagram;

    public Node? SelectedNode
    {
        get => _selectedNode;

        private set
        {
            if (_selectedNode != value)
            {
                _selectedNode = value;
                _diagram.Invalidate();
                UpdateContextMenu();
                SelectionChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public Edge? SelectedEdge
    {
        get => _selectedEdge;

        private set
        {
            if (_selectedEdge != value)
            {
                _selectedEdge = value;
                _diagram.Invalidate();
                UpdateContextMenu();
                SelectionChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public event EventHandler? SelectionChanged;

    public void DeleteSelected()
    {
        if (SelectedNode != null)
        {
            Diagram.Nodes.Remove(SelectedNode);
            SelectedNode = null;
        }
        else if (SelectedEdge != null)
        {
            Diagram.Edges.Remove(SelectedEdge);
            SelectedEdge = null;
        }
    }

    public void ClearAll()
    {
        if (MessageBox.Show("Clear All?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            SelectedNode = null;
            SelectedEdge = null;
            ((IDiagram)Diagram).Clear();
            Diagram.Header.Content = Diagram.Footer.Content = "";
            Diagram.ResetForeColor();
            Diagram.ResetBackColor();
        }
    }

    public void AddNode(Shape shape)
    {
        var node = new Node() { Shape = shape, Text = $"Node {_diagram.Nodes.Count}" };
        _diagram.Nodes.Add(node);
        SelectedNode = node;
    }
    #endregion
}
