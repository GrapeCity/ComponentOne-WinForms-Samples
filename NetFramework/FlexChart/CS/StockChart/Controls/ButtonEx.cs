using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockChart
{
    class ButtonEx : System.Windows.Forms.Button
    {
        public ButtonEx()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);

            this.EnabledChanged += (o, e) =>
            {
                this.BackColor = this.ForeColor = Enabled ? System.Drawing.Color.FromArgb(40, 96, 144) : System.Drawing.Color.FromArgb(45, 91, 130);
            };
        }
        

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;

            SizeF fontSize = g.MeasureString(this.Text, this.Font);
            g.DrawString(this.Text, this.Font, Enabled ? new SolidBrush(Color.FromArgb(255,255,255)) : new SolidBrush(Color.FromArgb(160, 160, 160)), new PointF((this.Width - fontSize.Width) / 2, (this.Height - fontSize.Height) / 2));



        }
    }
}
