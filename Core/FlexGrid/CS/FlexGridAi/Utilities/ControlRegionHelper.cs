using System.Drawing.Drawing2D;

public static class ControlRegionHelper
{
    /// <summary>
    /// Creates a rounded rectangle path for a control's current size and a given corner radius.
    /// </summary>
    /// <param name="control">The control to get dimensions from.</param>
    /// <param name="radius">The radius of the corners in pixels.</param>
    /// <returns>A GraphicsPath representing the rounded rectangle.</returns>
    public static GraphicsPath GetRoundedPath(Control control, int radius)
    {
        if (control.Width <= 0 || control.Height <= 0) return null;

        int d = radius * 2;
        var path = new GraphicsPath();

        path.AddArc(0, 0, d, d, 180, 90);                                   // Top-left
        path.AddArc(control.Width - d, 0, d, d, 270, 90);                  // Top-right
        path.AddArc(control.Width - d, control.Height - d, d, d, 0, 90);   // Bottom-right
        path.AddArc(0, control.Height - d, d, d, 90, 90);                  // Bottom-left
        path.CloseFigure();

        return path;
    }
}
