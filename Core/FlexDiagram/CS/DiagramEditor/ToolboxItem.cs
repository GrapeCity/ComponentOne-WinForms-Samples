using C1.Diagram;
namespace DiagramEditor;

public class ToolboxItem : Panel
{
    public Shape Shape { get; }
    private readonly string _label;
    private bool _hover;
    private IDiagram _diagram;

    public ToolboxItem(IDiagram diagram, Shape shape, EventHandler click)
    {
        Shape = shape;
        _diagram = diagram;
        _label = GetLabel(shape);
        Size = new Size(86, 56);
        Margin = new Padding(8, 6, 8, 6);
        Cursor = Cursors.Hand;
        DoubleBuffered = true;

        Click += click;
        MouseEnter += (_, _) => { _hover = true; Invalidate(); };
        MouseLeave += (_, _) => { _hover = false; Invalidate(); };
    }

    private string GetLabel(Shape shape)
    {
        switch (shape)
        {
            case Shape.None:
                return "Text Only";
            case Shape.RoundedRectangle:
                return "Rounded";
            default:
                return shape.ToString();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        var back = _hover ? AppStyles.HoverColor : AppStyles.BackColor;
        using (var backBrush = new SolidBrush(back))
            g.FillRectangle(backBrush, ClientRectangle);
        using (var borderPen = new Pen(Color.FromArgb(0xD0, 0xD7, 0xDE)))
            g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);

        var iconBounds = new RectangleF(6, 6, Width - 12, 28);
        using var fill = new SolidBrush(AppStyles.SelectionFill);
        using var stroke = new Pen(AppStyles.SelectionStroke, 1.5f);
        ShapeRenderer.Draw( g, Shape, iconBounds, fill, stroke);

        using var textBrush = new SolidBrush(AppStyles.HeaderColor);
        using var format = new StringFormat { Alignment = StringAlignment.Center };

        var rect = Shape == Shape.None ? new RectangleF(0, 20, Width, 16) : new RectangleF(0, 38, Width, 16);

        g.DrawString(_label, AppStyles.Font, textBrush, rect, format);
    }
}
