using System.Drawing;
using System.Windows.Forms;

namespace TileExplorer.Samples
{
    public partial class TileImages : UserControl
    {
        public TileImages()
        {
            InitializeComponent();
        }

        private void template8_Paint(object sender, C1.Win.Tile.TemplatePaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Rectangle rect = e.ClipRectangle;
            int sz = (int)(28 * g.DpiY / 96f + 0.5f);
            rect.X += (rect.Width - sz) / 2;
            rect.Y += (rect.Height - sz) / 2;
            rect.Width = sz;
            rect.Height = sz;
            using Brush brush = new SolidBrush(e.Tile.GetBackColor());
            using Pen pen = new Pen(e.Tile.GetForeColor());
            switch (e.Tile.IntValue)
            {
                case 1:
                    g.FillPie(brush, rect, 50f, 270f);
                    g.DrawPie(pen, rect, 50f, 270f);
                    break;
                case 2:
                    g.FillRectangle(brush, rect);
                    g.DrawRectangle(pen, rect);
                    break;
                default:
                    g.FillEllipse(brush, rect);
                    g.DrawEllipse(pen, rect);
                    break;
            }            
        }
    }
}
