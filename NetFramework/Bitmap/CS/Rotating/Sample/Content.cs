using C1.Win.Bitmap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace Rotating
{
    public class RotateItem
    {
        public int Position { get; set; }
        public PictureBox Box { get; set; }
    }

    public enum RotateMode
    {
        None,
        Left,
        Right
    }

    [ToolboxItem(true)]
    public partial class SampleContent : UserControl
    {
        private List<RotateItem> _items;
        public SampleContent()
        {
            InitializeComponent();
        }

        public Control[] ThemeableControls => new Control[] { buttonRightRotate, buttonLeftRotate };

        public static C1Bitmap LoadImage(string resourceName)
        {
            C1Bitmap bitmap = null;
            var resource = "Rotating.Properties.Resources";
            Assembly assembly = Assembly.GetExecutingAssembly();
            var manager = new ResourceManager(resource, assembly);
            if(manager != null)
            {
                Bitmap image = manager.GetObject(resourceName, CultureInfo.InvariantCulture) as Bitmap;
                if (image != null)
                {
                    bitmap = new C1Bitmap();
                    using (MemoryStream stream = new MemoryStream())
                    {
                        image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        bitmap.Load(stream);
                    }
                }
            }

            return bitmap;
        }

        private void InitializeBitmaps()
        {
            var logo = LoadImage("GcLogo");
            if (logo == null) return;

            // Creating image list
            _items = Enumerable.Range(0, 4)
                .Select(x =>
                new RotateItem()
                {
                    Position = x,
                    Box = new PictureBox()
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = logo.ToGdiBitmap(),
                        Location = new Point(0, 0),
                        Width = 150,
                        Height = 100
                    }
                })
                .ToList();

            RotateImages(RotateMode.None);
            flowLayoutPanel1.Controls.AddRange(_items.Select(x => x.Box).ToArray());
        }

        private void RotateImages(RotateMode mode)
        {
            var logo = LoadImage("GcLogo");
            if (logo == null) return;

            // Each turn over
            _items
                .ForEach(x =>
                {
                    if(mode != RotateMode.None)
                    {
                        if(mode == RotateMode.Left)
                            x.Position = x.Position == 0 ? 3 : x.Position - 1;

                        if(mode == RotateMode.Right)
                            x.Position = x.Position == 3 ? 0 : x.Position + 1;
                    }

                    var rotateOption = (TransformOptions)Enum.ToObject(typeof(TransformOptions), x.Position);
                    var sourceBitmap = logo;

                    var transform = new FlipRotator(rotateOption);
                    var destBitmap = sourceBitmap.Transform(transform);

                    x.Box.Image = destBitmap.ToGdiBitmap();
                });
        }

        private void Rotating_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                InitializeBitmaps();
        }

        private void ButtonRightRotate_Click(object sender, System.EventArgs e)
        {
            RotateImages(RotateMode.Right);
        }

        private void ButtonLeftRotate_Click(object sender, System.EventArgs e)
        {
            RotateImages(RotateMode.Left);
        }
    }
}
