using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncFilter
{
    public partial class Loader : UserControl
    {
        public Loader()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);

            InitializeComponent();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c1RadialGauge1.Value = (c1RadialGauge1.Value + 4) % 104;
        }

        private void Loader_VisibleChanged(object sender, EventArgs e)
        {
            timer1.Enabled = Visible;
            c1RadialGauge1.Value = 0;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x20;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var alpha = (50 * 255) / 100;
            Color frmColor = Parent.BackColor;
            int Rb = BackColor.R * alpha / 255 + frmColor.R * (255 - alpha) / 255;
            int Gb = BackColor.G * alpha / 255 + frmColor.G * (255 - alpha) / 255;
            int Bb = BackColor.B * alpha / 255 + frmColor.B * (255 - alpha) / 255;
            var color = Color.FromArgb(Rb, Gb, Bb);

            Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);

            using (var g = e.Graphics)
            using (var bckColor = new SolidBrush(Color.FromArgb(alpha, color)))
            {
                g.FillRectangle(bckColor, bounds);

            }
            base.OnPaint(e);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            if (Parent != null)
            {
                Parent.Invalidate(Bounds, true);
            }
            base.OnBackColorChanged(e);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            Invalidate();
            base.OnParentBackColorChanged(e);
        }

        public void ShowLoader()
        {
            Visible = true;
            BringToFront();
        }

        public void HideLoader()
        {
            Visible = false;
            SendToBack();
        }
    }
}
