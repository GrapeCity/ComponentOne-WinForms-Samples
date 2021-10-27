using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataFilterExplorer.Samples
{
    public partial class LoadingView : UserControl
    {
        private float _angle;
        private string _label = "Loading..";

        public LoadingView()
        {
            InitializeComponent();
            Font = new Font("Microsoft Sans Serif", 18F);
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _angle = (_angle + 12) % 364;
            Invalidate();
        }

        private void LoadingView_Load(object sender, EventArgs e)
        {
            //timer1.Interval = 400;
            timer1.Enabled = Visible;
            _angle = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            var d = 320;
            var x = e.ClipRectangle.Width / 2 - d / 2;
            var y = e.ClipRectangle.Height / 2 - d / 2;
            var rect = new Rectangle(x, y, d, d);
            using (Pen glyphBackPen = new(Color.Silver, 66))
            {
                e.Graphics.DrawEllipse(glyphBackPen, rect);
            }
            using (Pen glyphPen = new(Color.SteelBlue, 66))
            {
                e.Graphics.DrawArc(glyphPen, rect, 0, _angle);
            }
            var textRect = TextRenderer.MeasureText(_label, Font);
            TextRenderer.DrawText(e.Graphics, "Loading..", Font, new Point(x + d / 2 - textRect.Width / 2, y + d / 2 - textRect.Height / 2), ForeColor);
        }
    }
}
