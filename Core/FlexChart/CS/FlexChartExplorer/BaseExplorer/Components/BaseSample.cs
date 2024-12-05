using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace BaseExplorer.Components
{
    public abstract partial class BaseSample : UserControl
    {
        private bool _showDescPanel = true;
        public string Id { get; private set; }

        public string Title { get; set; }

        public bool ShowDescriptionPanel
        {
            get { return _showDescPanel; }
            set
            {
                if (_showDescPanel != value)
                {
                    _showDescPanel = value;
                    pnlControls.Visible = value;
                }
            }
        }

        public BaseSample()
        {
            InitializeComponent();
        }


        private void DescPanel_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(500);
        }

        private void DescPanel_MouseEnter(object sender, EventArgs e)
        {
            Thread.Sleep(500);
        }

        /// <summary>
        /// Gets the thumbnail image of the sample
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public virtual Image GetImage(int width = 200, int height = 200)
        {
            var bmp = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            this.DrawToBitmap(bmp, this.DisplayRectangle);
            var thumb = bmp.GetThumbnailImage(width, height, null, IntPtr.Zero);
            return thumb;
        }

        private void BaseSample_SizeChanged(object sender, EventArgs e)
        {
        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {
            pnlControls.Visible = pnlControls.Controls.Count > 0;
        }
    }
}
