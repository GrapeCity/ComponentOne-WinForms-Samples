using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockChart
{
    class CheckButtonEx : System.Windows.Forms.Button
    {
        public EventHandler<BooleanEventArgs> OnCheckedChanged;
        public CheckButtonEx()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);

            this.MouseEnter += (o, e) =>
            {
                this.BackColor = this.ForeColor = Checked ? System.Drawing.Color.FromArgb(28, 28, 28) : System.Drawing.Color.FromArgb(230, 230, 230);
                IsMouseOver = true;
            };
            this.MouseLeave += (o, e) =>
            {
                this.BackColor = this.ForeColor  = Checked ? System.Drawing.Color.FromArgb(28, 28, 28) : System.Drawing.Color.FromArgb(66, 66, 66);
                IsMouseOver = false;
            };
        }


        private bool _isMouseOver = false;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMouseOver
        {
            get { return _isMouseOver; }
            set { _isMouseOver = value; this.Invalidate(); }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (!this.Checked)
            {
                this.Checked = true;
                if (this.OnCheckedChanged != null)
                {
                    this.OnCheckedChanged(this, new BooleanEventArgs() { Value = this.Checked });
                }
            }
        }

        private bool _checked = false;
        public bool Checked
        {
            get { return _checked; }
            internal set
            {
                _checked = value;
                Stylization();
            }
        }

        private void Stylization()
        {
            this.BackColor = this.ForeColor = Checked ? System.Drawing.Color.FromArgb(28,28,28) : System.Drawing.Color.FromArgb(66, 66, 66);
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            
            Graphics g = pe.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            
            SizeF fontSize = g.MeasureString(this.Text, this.Font);
            g.DrawString(this.Text, this.Font, IsMouseOver && !Checked ? new SolidBrush(Color.FromArgb(80, 80, 80)) : new SolidBrush(Color.FromArgb(255, 255, 255)), new PointF((this.Width - fontSize.Width) / 2, (this.Height - fontSize.Height) / 2));
            
            
            
        }
    }
}
