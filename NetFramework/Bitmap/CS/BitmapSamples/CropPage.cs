using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using C1.Win.Bitmap;
using C1.Util.DX;

namespace BitmapSamples
{
    public partial class CropPage : UserControl
    {
        //----------------------------------------------------------------------
        #region ** fields and constants

        const int
            TopMargin = 37,
            BottomMargin = 3,
            SideMargin = 3;

        C1Bitmap _bitmap;
        float _scaleFactor = 1f;
        RectF _selection = new RectF(1f, 1f);
        Point2F _start;
        bool _initialized;

        #endregion

        //----------------------------------------------------------------------
        #region ** ctor/Dispose

        public CropPage()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_initialized)
                {
                    _initialized = false;
                    ClearImage();
                    _bitmap.Dispose();
                }
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** event handlers

        void CropPage_Load(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                _bitmap = new C1Bitmap();
                LoadDefaultImage();
                _initialized = true;
            }
        }

        void btnLoad_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.ico;*.bmp;*.gif;*.png;*.jpg;*.jpeg;*.jxr;*.tif;*.tiff";
            ofd.Title = "Select the Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _bitmap.Load(ofd.FileName, new FormatConverter(PixelFormat.Format32bppPBGRA));
                    UpdateImage();
                }
                catch (Exception ex)
                {
                    LoadDefaultImage();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void btnExport_Click(object sender, EventArgs e)
        {
            if (_selection.Width == 0f || _selection.Height == 0f)
            {
                MessageBox.Show("Can't export, selection is empty.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png Files (*.png)|*.png";
            sfd.CheckPathExists = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var cropRect = new RectF(
                    _selection.X * _bitmap.PixelWidth,
                    _selection.Y * _bitmap.PixelHeight,
                    _selection.Width * _bitmap.PixelWidth,
                    _selection.Height * _bitmap.PixelHeight);
                _bitmap.SaveAsPng(sfd.FileName, new PngOptions { SourceRect = new ImageRect(cropRect.Round()) });
                _selection = new RectF(1f, 1f);
                pictureBox1.Invalidate();
            }
        }

        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                _start = new Point2F(e.X, e.Y);
            }
        }

        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                float w = pictureBox1.Width;
                float h = pictureBox1.Height;
                float x = Math.Max(0f, Math.Min(e.X, w));
                float y = Math.Max(0f, Math.Min(e.Y, h));

                _selection = new RectF(
                    Math.Min(_start.X, x) / w,
                    Math.Min(_start.Y, y) / h,
                    Math.Abs(x - _start.X) / w,
                    Math.Abs(y - _start.Y) / h);

                pictureBox1.Invalidate();
            }
        }

        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;
            var path = new GraphicsPath(FillMode.Alternate);
            path.AddRectangle(new RectangleF(0, 0, w, h));
            path.AddRectangle(new RectangleF(_selection.X * w, _selection.Y * h, _selection.Width * w, _selection.Height * h));

            var brush = new SolidBrush(Color.FromArgb(0x66FFFFFF));
            e.Graphics.FillPath(brush, path);
            brush.Dispose();

            path.Dispose();
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** overridden methods

        protected override void OnResize(EventArgs e)
        {
            UpdateImageScale();
            base.OnResize(e);
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            _scaleFactor = (factor.Width + factor.Height) * 0.5f;
            base.ScaleControl(factor, specified);

            UpdateImageScale();
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** other methods

        public void LoadDefaultImage()
        {
            Assembly asm = typeof(CropPage).Assembly;
            using (Stream stream = asm.GetManifestResourceStream("BitmapSamples.Resources.GrapeCity.jpg"))
            {
                _bitmap.Load(stream, new FormatConverter(PixelFormat.Format32bppPBGRA));
            }
            UpdateImage();
        }

        void ClearImage()
        {
            var bmp = pictureBox1.Image as Bitmap;
            if (bmp != null)
            {
                pictureBox1.Image = null;
                bmp.Dispose();
            }
        }

        void UpdateImage()
        {
            ClearImage();
            pictureBox1.Image = _bitmap.ToGdiBitmap();
            _selection = new RectF(1f, 1f);
            UpdateImageScale();
        }

        void UpdateImageScale()
        {
            if (_bitmap == null || !_bitmap.HasImage)
            {
                return;
            }
            float hostW = this.Width;
            float hostH = this.Height;
            hostW -= _scaleFactor * SideMargin * 2;
            hostH -= _scaleFactor * (TopMargin + BottomMargin);
            float imgW = _bitmap.PixelWidth;
            float imgH = _bitmap.PixelHeight;
            if (hostW <= 0f || hostH <= 0f)
            {
                return;
            }
            float offsetX = _scaleFactor * SideMargin;
            float offsetY = _scaleFactor * TopMargin;
            if (imgW / imgH > hostW / hostH)
            {
                float newH = imgH * hostW / imgW;
                offsetY += (hostH - newH) / 2;
                hostH = newH;
            }
            else
            {
                float newW = imgW * hostH / imgH;
                offsetX += (hostW - newW) / 2;
                hostW = newW;
            }
            pictureBox1.SetBounds((int)(offsetX + 0.5f), (int)(offsetY + 0.5f), (int)(hostW + 0.5f), (int)(hostH + 0.5f));
        }

        #endregion
    }
}
