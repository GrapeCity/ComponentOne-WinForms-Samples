using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    public class CustomTooltip : Control
    {

        #region Private Varaibles
        private Color _borderColor = Color.LightGray;
        private Color _tooltipBackColor = Color.White;
        private int _borderThickness = 2;
        #endregion

        #region Public Properties
        public int PointerWidth { get; set; } = 10;
        public int PointerHeight { get; set; } = 15;
        public int CornerRadius { get; set; } = 10;

        public CustomTooltip()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint, true);
            this.ForeColor = Color.Black;
            this.Padding = new Padding(8);
            this.Font = new Font("Segoe UI", 12);
        }
        #endregion

        #region Protected Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = CreateTooltipPath())
            {
                using (SolidBrush tooltipBrush = new SolidBrush(_tooltipBackColor))
                {
                    e.Graphics.FillPath(tooltipBrush, path);
                }
                using (Pen borderPen = new Pen(_borderColor, _borderThickness))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }

            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, GetTextRectangle(), this.ForeColor, TextFormatFlags.WordBreak);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Leave blank to ensure no background is painted
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            using (GraphicsPath path = CreateTooltipPath())
            {
                if (path != null)
                {
                    this.Region?.Dispose();
                    this.Region = new Region(path);
                }
            }
        }
        #endregion

        #region Private Methods
        private GraphicsPath CreateTooltipPath()
        {
            GraphicsPath path = new GraphicsPath();

            int arrowHalfHeight = PointerHeight / 2;
            int rectX = PointerWidth;
            int rectWidth = this.Width - PointerWidth;
            int rectHeight = this.Height;

            int arrowOffset = 10;

            path.AddArc(rectX, 0, CornerRadius, CornerRadius, 180, 90);
            path.AddLine(rectX + CornerRadius, 0, rectX + rectWidth - CornerRadius, 0);
            path.AddArc(rectX + rectWidth - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
            path.AddLine(rectX + rectWidth, CornerRadius, rectX + rectWidth, rectHeight - CornerRadius);
            path.AddArc(rectX + rectWidth - CornerRadius, rectHeight - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddLine(rectX + rectWidth - CornerRadius, rectHeight, rectX + CornerRadius, rectHeight);
            path.AddArc(rectX, rectHeight - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.AddLine(rectX, rectHeight - CornerRadius, rectX, arrowOffset + PointerHeight);

            path.AddLine(rectX, arrowOffset + PointerHeight, 0, arrowOffset + arrowHalfHeight);
            path.AddLine(0, arrowOffset + arrowHalfHeight, rectX, arrowOffset);

            path.CloseFigure();

            return path;
        }

        private Rectangle GetTextRectangle()
        {
            return new Rectangle(PointerWidth + Padding.Left, Padding.Top,
                                 this.Width - PointerWidth - Padding.Horizontal,
                                 this.Height - Padding.Vertical);
        }
        #endregion
    }
}
