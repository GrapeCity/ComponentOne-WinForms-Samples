using System.Drawing.Drawing2D;

namespace InputDateRange.Helpers
{
    /// <summary>
    /// Helper class for applying custom drawing effects, such as rounded corners, to controls.
    /// </summary>
    public class CustomDrawingHelper
    {
        public void ApplyRoundedCorners(Control control, PaintEventArgs e, int radius = 10)
        {
            using var path = CreateRoundedRectanglePath(control.ClientRectangle, radius);
            control.Region = new Region(path);
        }

        public GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            var path = new GraphicsPath();
            int diameter = cornerRadius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
