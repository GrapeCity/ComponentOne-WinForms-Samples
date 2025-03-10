using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

/// <summary>
/// This class is a custom implementation of a panel with rounded corners, extended from the standard Panel class.
/// </summary>
/// <remarks>
/// It includes a Radius property that can be dynamically modified in the designer.
/// </remarks>
namespace ControlExplorer.Controls
{
    public class CustomPanel : Panel
    {
        #region Private Variables

        private int _radius = 2;
        private int _defaultWidth = 150;
        private int _defaultHeight = 30;

        #endregion

        #region Public Methods
        public int Radius
        {
            get => _radius;
            set { _radius = Math.Max(0, value); this.Invalidate(); }
        }

        public CustomPanel()
        {
            this.Size = new Size(_defaultWidth, _defaultHeight);
            this.Resize += (s, e) => this.Invalidate();
        }
        #endregion

        #region Private Methods
        private GraphicsPath GetFigurePath(RectangleF rect)
        {
            GraphicsPath path = new GraphicsPath();

            rect.Inflate(-0.5f, -0.5f);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, _radius * 2, _radius * 2, 180, 90);
            path.AddArc(rect.Right - _radius * 2, rect.Y, _radius * 2, _radius * 2, 270, 90);
            path.AddArc(rect.Right - _radius * 2, rect.Bottom - _radius * 2, _radius * 2, _radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - _radius * 2, _radius * 2, _radius * 2, 90, 90);
            path.CloseFigure();

            return path;
        }
        #endregion

        #region Protected Methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);

            using (GraphicsPath path = GetFigurePath(rect))
            {
                this.Region = new Region(path);

                using (Brush backgroundBrush = new SolidBrush(this.BackColor))
                {
                    pevent.Graphics.FillPath(backgroundBrush, path);
                }
            }
        }
        #endregion
    }
}
