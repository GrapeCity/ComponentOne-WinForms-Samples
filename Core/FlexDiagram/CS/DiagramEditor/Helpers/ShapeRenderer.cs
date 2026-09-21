using C1.Diagram;
using System.Drawing.Drawing2D;

namespace DiagramEditor.Helpers;

public static class ShapeRenderer
{
    public static GraphicsPath GetPath(Shape shape, RectangleF bounds)
    {
        var path = new GraphicsPath();
        var size = Math.Min(bounds.Width, bounds.Height);
        var dx = 0.5f * (bounds.Width - size);
        var w = 0.3f * bounds.Width;
        var h = 0.5f * bounds.Height;
        var x = bounds.Left + 0.5f * bounds.Width;
        var y = bounds.Top + 0.5f * bounds.Height;


        switch (shape)
        {
            case Shape.RoundedRectangle:
                AddRoundedRect(path, bounds, Math.Min(bounds.Width, bounds.Height) * 0.25f);
                break;
            case Shape.Ellipse:
                path.AddEllipse(bounds);
                break;
            case Shape.Circle:
                path.AddEllipse(bounds.Left + dx, bounds.Top, size, size);
                break;
            case Shape.Diamond:
                path.AddPolygon(
                [
                    new PointF(bounds.Left + size / 2 + dx, bounds.Top),
                    new PointF(bounds.Left + size + dx, bounds.Top + size / 2),
                    new PointF(bounds.Left + size / 2 + dx, bounds.Bottom),
                    new PointF(bounds.Left + dx, bounds.Top + size / 2)
                ]);
                break;
            case Shape.Rhombus:
                path.AddPolygon(new[]
                {
                    new PointF(bounds.Left + bounds.Width / 2, bounds.Top),
                    new PointF(bounds.Right, bounds.Top + bounds.Height / 2),
                    new PointF(bounds.Left + bounds.Width / 2, bounds.Bottom),
                    new PointF(bounds.Left, bounds.Top + bounds.Height / 2)
                });
                break;
            case Shape.Hexagon:
                path.AddPolygon(
                [
                    new PointF(-w     + x, - h  + y),
                    new PointF( w     + x, - h  + y),
                    new PointF( w + h + x,  0  + y),
                    new PointF( w     + x, h + y),
                    new PointF(-w     + x, h + y),
                    new PointF(-w - h + x, 0  + y),
                ]);
                break;
            case Shape.None:
                break;
            case Shape.Octagon:
                AddOctagonPath(path, bounds);
                break;
            case Shape.House:
                AddHousePath(path, bounds);
                break;
            default:
                path.AddRectangle(bounds);
                break;
        }
        return path;
    }

    private static void AddRoundedRect(GraphicsPath path, RectangleF r, float radius)
    {
        float d = radius * 2;
        path.AddArc(r.X, r.Y, d, d, 180, 90);
        path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
    }

    static void AddOctagonPath(GraphicsPath path, RectangleF bounds)
    {
        float cut = (float)(1 - Math.Sqrt(2) / 2) * Math.Min(bounds.Width, bounds.Height);

        float l = bounds.Left, t = bounds.Top, r = bounds.Right, b = bounds.Bottom;

        // don't let the cuts overlap
        cut = Math.Min(cut, Math.Min(bounds.Width, bounds.Height) / 2f);

        var pts = new[]
        {
            new PointF(l + cut, t),
            new PointF(r - cut, t),
            new PointF(r, t + cut),
            new PointF(r, b - cut),
            new PointF(r - cut, b),
            new PointF(l + cut, b),
            new PointF(l, b - cut),
            new PointF(l, t + cut),
        };

        path.AddPolygon(pts);   // AddPolygon closes automatically
    }

    static void AddHousePath(GraphicsPath path, RectangleF bounds)
    {
        var w = bounds.Width / 2;
        var h = bounds.Height / 2;
        var x = bounds.X + w;
        var y = bounds.Y + h;
        h *= 0.8f;

        var pts = new[]
        {
            new PointF(x - w, y + h),
            new PointF(x + w, y + h),
            new PointF(x + w, y - h),
            new PointF(x, y - 1.5f * h),
            new PointF(x - w, y - h),
        };

        path.AddPolygon(pts);
    }


    public static void Draw(Graphics g, Shape shape, RectangleF bounds, Brush? fill, Pen stroke)
    {
        using var path = GetPath(shape, bounds);
        if (fill != null)
            g.FillPath(fill, path);
        g.DrawPath(stroke, path);
    }

    public static void DrawImageFit(Graphics g, Image image, RectangleF bounds)
    {
        if (image.Width <= 0 || image.Height <= 0) return;

        float scale = Math.Min(bounds.Width / image.Width, bounds.Height / image.Height);
        float w = image.Width * scale;
        float h = image.Height * scale;
        float x = bounds.X + (bounds.Width - w) / 2f;
        float y = bounds.Y + (bounds.Height - h) / 2f;
        g.DrawImage(image, x, y, w, h);
    }
}
