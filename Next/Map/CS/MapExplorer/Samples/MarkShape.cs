using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapExplorer.Samples.Layers
{
    using C1.Win.Map;
    using System.Drawing;
    using System.Globalization;
    using System.Drawing.Drawing2D;

    public class MarkShape : CustomShape
    {
        private readonly int _index;

        public MarkShape(int index)
        {
            _index = index;
        }

        public override RectangleF GetDrawingBounds(Graphics g, RectangleF bounds, Style style)
        {
            bounds.Y -= bounds.Height / 2;
            return bounds;
        }

        public override bool IsVisible(Graphics g, RectangleF bounds, PointF point, Style style)
        {
            using (var path = CreateBaloon(bounds))
                return path.IsVisible(point);
        }

        public override void Draw(Graphics g, RectangleF bounds, Style style)
        {
            using (var path = CreateBaloon(bounds))
            {
                using (var brush = new SolidBrush(style.BackColor))
                    g.FillPath(brush, path);

                using (var pen = new Pen(style.Stroke.Color, style.Stroke.Width))
                    g.DrawPath(pen, path);

                var rect = new RectangleF(bounds.Location, new SizeF(20, 20));
                using (var brush = new SolidBrush(style.ForeColor))
                using (var sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString(_index.ToString(CultureInfo.InstalledUICulture),
                        style.Font, brush, rect, sf);
                }
            }
        }

        private GraphicsPath CreateBaloon(RectangleF bounds)
        {
            var path = new GraphicsPath();
            var rect = new RectangleF(bounds.Location, new SizeF(20, 20));
            path.AddArc(rect, 120, 300);
            rect = new RectangleF(bounds.Right - 10, bounds.Bottom - 10, 20, 20);
            path.AddArc(rect, -120, -60);
            rect = new RectangleF(bounds.Left - 10, bounds.Bottom - 10, 20, 20);
            path.AddArc(rect, 0, -60);

            return path;
        }
    }
}
