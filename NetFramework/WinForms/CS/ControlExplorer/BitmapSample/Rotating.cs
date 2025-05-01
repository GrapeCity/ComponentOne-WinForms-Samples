using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using C1.Win.Bitmap;

namespace ControlExplorer.BitmapSample
{
    public partial class Rotating : C1DemoForm
    {
        private List<Picture> _items;

        public Rotating()
        {
            InitializeComponent();
        }

        private void InitializeBitmaps()
        {
            _items = new List<Picture>()
            {
                new Picture(ControlExplorer.Properties.Resources.m01),
                new Picture(ControlExplorer.Properties.Resources.m02),
                new Picture(ControlExplorer.Properties.Resources.m03),
                new Picture(ControlExplorer.Properties.Resources.m04)
            };

            // Add controls to the panel.
            flowLayoutPanel1.Controls.AddRange(_items.ToArray());

            // Update sizes.
            foreach (var item in _items)
                item.Size = SizeToDpi(item.Size);
        }
        
        private void RotateImages(bool isRight)
        {
            // Rotate the image by 90 degrees.
            var delta = isRight ? 1 : 3;
            foreach (var item in _items)
                item.Rotate(delta);
        }

        private Size SizeToDpi(Size size)
        {
            float dpi;
            using (Graphics g = this.CreateGraphics())
            {
                dpi = Math.Min(g.DpiX, g.DpiY);
            }
            if (dpi != 96)
            {
                double scale = (double)dpi / 96;
                size.Width = (int)(size.Width * scale);
                size.Height = (int)(size.Height * scale);
            }
            return size;
        }

        // Handlers.
        private void Rotating_Load(object sender, EventArgs e) => InitializeBitmaps();
        private void BtnRght_Click(object sender, EventArgs e) => RotateImages(true);
        private void BtnLeft_Click(object sender, EventArgs e) => RotateImages(false);

        // Nested
        private class Picture : PictureBox
        {
            // C1Bitmap holder.
            public Picture(Bitmap source)
            {
                Bitmap = new C1Bitmap();
                if (source != null)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        source.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        Bitmap.Load(stream);
                    }
                }
                SizeMode = PictureBoxSizeMode.StretchImage;
                Image = Bitmap.ToGdiBitmap();
                Width = 120;
                Height = 120;
            }

            public C1Bitmap Bitmap { get; private set; }

            public void Rotate(int delta)
            {
                var rotateOption = (TransformOptions)Enum.ToObject(typeof(TransformOptions), delta);
                var transform = new FlipRotator(rotateOption);
                Bitmap = Bitmap.Transform(transform);
                Image = Bitmap.ToGdiBitmap();
            }
        }
    }
}
