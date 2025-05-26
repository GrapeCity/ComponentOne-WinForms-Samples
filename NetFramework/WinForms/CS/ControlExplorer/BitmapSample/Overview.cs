using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using C1.Win.Bitmap;
using C1.Win.C1Input;

namespace ControlExplorer.BitmapSample
{
    public partial class Overview : C1DemoForm
    {
        private Random _random = new Random();
        private List<C1Picture> _items;
        private C1Picture _selectedPicture;

        public Overview()
        {
            InitializeComponent();
        }

        private void InitializeBitmaps()
        {
            var data = DemoDataSource("Select Picture, Description from Cars", true);

            // Create pictures.
            _items = data.Rows.Cast<DataRow>().Select(x => new C1Picture(x)).ToList();

            // Subscribe click event.
            _items.ForEach(x => x.Click += Image_Click);

            // Add controls to the panel.
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(_items.ToArray());

            // Update sizes.
            foreach (var item in _items)
                item.Size = SizeToDpi(item.Size);

            // Select random picture.
            SelectedPicture = _items[_random.Next(0, _items.Count - 1)];
        }

        private C1Picture SelectedPicture
        {
            get => _selectedPicture;
            set
            {
                if (value == null || _selectedPicture == value)
                    return;

                _selectedPicture = value;

                c1PictureBox1.Image = _selectedPicture.RoundedBitmap.ToGdiBitmap();
                richTextBox1.Text = _selectedPicture.Description;
            }
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
        private void Sample_Load(object sender, EventArgs e) => InitializeBitmaps();
        private void Image_Click(object sender, EventArgs e) => SelectedPicture = sender as C1Picture;

        // Nested class.
        private class C1Picture : C1PictureBox
        {
            private C1Bitmap _roundedBitmap;

            // C1Bitmap holder.
            public C1Picture(DataRow data)
            {
                // Store description.
                Description = data["Description"].ToString();

                // Create C1Bitmap from the source picture data.
                var picData = (byte[])data["Picture"];
                Bitmap = new C1Bitmap();
                using (var ms = new MemoryStream(picData, 0, picData.Length))
                    Bitmap.Load(ms);

                // Init PictureBox properties.
                SizeMode = PictureBoxSizeMode.StretchImage;
                Image = Bitmap.ToGdiBitmap();
                Width = 120;
                Height = 75;
            }

            public string Description { get; }
            public C1Bitmap Bitmap { get; }
            public C1Bitmap RoundedBitmap
            {
                get
                {
                    if (_roundedBitmap == null)
                        _roundedBitmap = RoundUp(Bitmap);
                    return _roundedBitmap;
                }
            }

            // Round up the image.
            private C1Bitmap RoundUp(C1Bitmap source)
            {
                var image = source.ToGdiBitmap();
                var w = image.Width;
                var h = image.Height;

                using (var transformBitmap = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppPArgb))
                {
                    using (var graphics = Graphics.FromImage(transformBitmap))
                    {
                        graphics.Clear(Color.Transparent);
                        var path = new GraphicsPath(FillMode.Alternate);

                        int radius = 15;
                        int diameter = radius * 2;

                        path.StartFigure();
                        path.AddLine(radius, 0, w - radius, 0);
                        path.AddArc(new RectangleF(w - diameter, 0, diameter, diameter), -90, 90);
                        path.AddLine(w, radius, w, h - radius);
                        path.AddArc(new RectangleF(w - diameter, h - diameter, diameter, diameter), 0, 90);
                        path.AddLine(w - radius, h, radius, h);
                        path.AddArc(new RectangleF(0, h - diameter, diameter, diameter), 90, 90);
                        path.AddLine(0, h - radius, 0, radius);
                        path.AddArc(new RectangleF(0, 0, diameter, diameter), 180, 90);
                        path.CloseFigure();

                        graphics.SetClip(path);
                        graphics.DrawImage(image, Point.Empty);
                    }

                    var rounded = new C1Bitmap();
                    rounded.Import(transformBitmap);
                    return rounded;
                }
            }

            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    Bitmap?.Dispose();
                    _roundedBitmap?.Dispose();
                    _roundedBitmap = null;
                }
                base.Dispose(disposing);
            }
        }
    }
}
