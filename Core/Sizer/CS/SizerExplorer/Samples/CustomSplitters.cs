using System.Drawing;
using System.Windows.Forms;
using C1.Win.Sizer;

namespace SizerExplorer.Samples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class CustomSplitters : UserControl
    {
        private Bitmap _imgGrip;
        private Bitmap _imgOpen;
        private Bitmap _imgClose;
        private Font _font;

        public CustomSplitters()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize images
        /// </summary>
        private void CustomSplitters_Load(object sender, System.EventArgs e)
        {
            _font = new Font("Tahoma", 8, FontStyle.Bold);
            _imgGrip = (Bitmap)pictureBox5.Image;
            _imgOpen = (Bitmap)pictureBox6.Image;
            _imgClose = (Bitmap)pictureBox7.Image;
            _imgOpen.MakeTransparent(Color.Red);
            _imgClose.MakeTransparent(Color.Red);
        }

        /// <summary>
        /// Custom painting for splitters
        /// </summary>
        private void c1Sizer1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < c1Sizer1.Grid.Rows.Count - 1; i++)
            {
                // draw grip area
                Rectangle rc = c1Sizer1.Grid.Rows[i].Bounds;
                rc.Y = rc.Bottom;
                rc.Height = c1Sizer1.Grid.Rows[i + 1].Bounds.Y - rc.Y;
                e.Graphics.DrawImage(_imgGrip, rc);

                // draw some text in the splitter
                Rectangle rct = rc;
                rct.X += rc.Height + 10;
                rct.Width -= rc.Height + 10;
                e.Graphics.DrawString("Splitter " + i.ToString(), _font, Brushes.Black, rct);

                // draw collapse/expand icon
                Image img = (c1Sizer1.Grid.Rows[i + 1].Bounds.Height > 0) ? _imgClose : _imgOpen;
                rc.Width = rc.Height;
                e.Graphics.DrawImage(img, rc);
            }
        }

        /// <summary>
        /// Use default cursor when moving over collapse/expand button
        /// </summary>
        private void c1Sizer1_MouseMove(object sender, MouseEventArgs e)
        {
            if (c1Sizer1.Cursor != Cursors.Default && HitTestSplitterRow(e.X, e.Y) is Row)
                c1Sizer1.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Expand/collapse panes when button is clicked
        /// </summary>
        private void c1Sizer1_MouseDown(object sender, MouseEventArgs e)
        {
            Row row = HitTestSplitterRow(e.X, e.Y);
            if (row != null)
            {
                int index = row.Index;
                if (row.Size > 0)
                    index = (index > 1) ? index - 1 : index + 1;

                int[] sz = new int[c1Sizer1.Grid.Rows.Count];
                sz[index] = 1000;
                c1Sizer1.Grid.Rows.SetSizes(sz);
                c1Sizer1.Invalidate();
            }
        }

        /// <summary>
        /// Get splitter pane that corresponds to a point
        /// </summary>
        private Row HitTestSplitterRow(int x, int y)
        {
            for (int i = 0; i < c1Sizer1.Grid.Rows.Count - 1; i++)
            {
                RowCollection rows = c1Sizer1.Grid.Rows;

                // get grip area
                Rectangle rc = rows[i].Bounds;
                rc.Y = rc.Bottom;
                rc.Height = rows[i + 1].Bounds.Y - rc.Y;

                // get icon area
                rc.Width = rc.Height;

                // check if the point is in the icon area
                if (rc.Contains(x, y))
                    return rows[i + 1];
            }
            return null;
        }
    }
}