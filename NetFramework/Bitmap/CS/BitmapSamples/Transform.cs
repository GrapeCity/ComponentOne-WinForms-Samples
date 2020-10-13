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
    public partial class Transform : UserControl
    {
        //----------------------------------------------------------------------
        #region ** fields and constants

        C1Bitmap _bitmap;
        C1Bitmap _savedCopy;
        RectF _selection = new RectF(1f, 1f);
        Point2L _start;
        bool _initialized;

        #endregion

        //----------------------------------------------------------------------
        #region ** ctor/Dispose

        public Transform()
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
                    _savedCopy.Dispose();
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

        void Transform_Load(object sender, EventArgs e)
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
                    _savedCopy.Dispose();
                    _bitmap.Load(ofd.FileName, new FormatConverter(PixelFormat.Format32bppPBGRA));
                    _savedCopy = _bitmap.Transform();
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png Files (*.png)|*.png";
            sfd.CheckPathExists = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _bitmap.SaveAsPng(sfd.FileName, null);
                _selection = new RectF(1f, 1f);
                pictureBox1.Invalidate();
            }
        }

        void btnRestart_Click(object sender, EventArgs e)
        {
            if (_savedCopy != null)
            {
                _bitmap.Dispose();
                _bitmap = _savedCopy.Transform();
                UpdateImage();
            }
        }

        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                _start = new Point2L(e.X, e.Y);
            }
        }

        void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                var dcs = SystemInformation.DoubleClickSize;
                if (Math.Abs(e.X - _start.X) < dcs.Width && Math.Abs(e.Y - _start.Y) < dcs.Height)
                {
                    _selection = new RectF(1f, 1f);
                    pictureBox1.Invalidate();
                }
            }
        }

        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                int w = pictureBox1.Width;
                int h = pictureBox1.Height;
                int x = Math.Max(0, Math.Min(e.X, w));
                int y = Math.Max(0, Math.Min(e.Y, h));

                _selection = new RectF(
                    (float)Math.Min(_start.X, x) / w,
                    (float)Math.Min(_start.Y, y) / h,
                    (float)Math.Abs(x - _start.X) / w,
                    (float)Math.Abs(y - _start.Y) / h);

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

        void btnCrop_Click(object sender, EventArgs e)
        {
            var rect = new RectF(
                _selection.X * _bitmap.PixelWidth,
                _selection.Y * _bitmap.PixelHeight,
                _selection.Width * _bitmap.PixelWidth,
                _selection.Height * _bitmap.PixelHeight);

            ApplyTransform(new Clipper(new ImageRect(rect.Round())));
        }

        void btnScaleIn_Click(object sender, EventArgs e)
        {
            int px = (int)(_bitmap.PixelWidth * 1.6f + 0.5f);
            int py = (int)(_bitmap.PixelHeight * 1.6f + 0.5f);
            ApplyTransform(new Scaler(px, py, C1.Win.Bitmap.InterpolationMode.HighQualityCubic));
        }

        void btnScaleOut_Click(object sender, EventArgs e)
        {
            int px = (int)(_bitmap.PixelWidth * 0.625f + 0.5f);
            int py = (int)(_bitmap.PixelHeight * 0.625f + 0.5f);
            if (px > 0 && py > 0)
            {
                ApplyTransform(new Scaler(px, py, C1.Win.Bitmap.InterpolationMode.HighQualityCubic));
            }
        }

        void btnFlipH_Click(object sender, EventArgs e)
        {
            ApplyTransform(new FlipRotator(TransformOptions.FlipHorizontal));
        }

        void btnFlipV_Click(object sender, EventArgs e)
        {
            ApplyTransform(new FlipRotator(TransformOptions.FlipVertical));
        }

        void btnRotateCW_Click(object sender, EventArgs e)
        {
            ApplyTransform(new FlipRotator(TransformOptions.Rotate90));
        }

        void btnRotateCCW_Click(object sender, EventArgs e)
        {
            ApplyTransform(new FlipRotator(TransformOptions.Rotate270));
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** other methods

        public void LoadDefaultImage()
        {
            Assembly asm = typeof(CropPage).Assembly;
            using (Stream stream = asm.GetManifestResourceStream("BitmapSamples.Resources.HousePlan.jpg"))
            {
                _bitmap.Load(stream, new FormatConverter(PixelFormat.Format32bppPBGRA));
                _savedCopy = _bitmap.Transform();
            }
            UpdateImage();
        }

        void ApplyTransform(BaseTransform t)
        {
            var newBitmap = _bitmap.Transform(t);
            _bitmap.Dispose();

            _bitmap = newBitmap;
            _selection = new RectF(1f, 1f);

            UpdateImage();
        }

        void UpdateImage()
        {
            if (_bitmap == null || !_bitmap.HasImage)
            {
                return;
            }
            var bmp = pictureBox1.Image as Bitmap;
            if (bmp != null)
            {
                bmp.Dispose();
            }
            bmp = _bitmap.ToGdiBitmap();
            pictureBox1.Image = bmp;
            pictureBox1.Width = bmp.Width;
            pictureBox1.Height = bmp.Height;
            _selection = new RectF(1f, 1f);
        }

        #endregion
    }
}
