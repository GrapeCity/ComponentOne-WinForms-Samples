using System.Drawing.Drawing2D;

namespace InputDateRange.Helpers
{
    public static class CustomDrawingHelper
    {
        /// <summary>
        /// Custom draw for ListBox items with optional rounded background.
        /// </summary>
        public static void DrawListBoxItem(DrawItemEventArgs e, ListBox listBox)
        {
            if (e.Index < 0) return;

            string text = listBox.Items[e.Index].ToString();

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color bgColor = isSelected ? ColorTranslator.FromHtml("#edf4f7") : listBox.BackColor;
            Color fgColor = isSelected ? Color.Black : listBox.ForeColor;

            if (isSelected)
            {
                using var path = CreateRoundedRectanglePath(e.Bounds, 8);
                using var brush = new SolidBrush(bgColor);
                e.Graphics.FillPath(brush, path);
            }
            else
            {
                using var brush = new SolidBrush(bgColor);
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            var padding = new Rectangle(e.Bounds.X + 8, e.Bounds.Y + 2, e.Bounds.Width - 8, e.Bounds.Height - 4);
            TextRenderer.DrawText(e.Graphics, text, listBox.Font, padding, fgColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }

        /// <summary>
        /// Applies rounded corners to a control during Paint.
        /// </summary>
        public static void ApplyRoundedCorners(Control control, PaintEventArgs e, int radius = 10)
        {
            using var path = CreateRoundedRectanglePath(control.ClientRectangle, radius);
            control.Region = new Region(path);
        }


        /// <summary>
        /// Generates a GraphicsPath with rounded corners.
        /// </summary>
        public static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
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
