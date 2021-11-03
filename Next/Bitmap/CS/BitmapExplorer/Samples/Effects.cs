using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapExplorer.Samples
{
    using C1.Win.Bitmap;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public static class Effects
    {
        /// <summary>
        /// Round up the image
        /// </summary>
        /// <param name="sourceBitmap"></param>
        /// <returns></returns>
        public static C1Bitmap RoundUpImage(C1Bitmap sourceBitmap)
        {
            var image = sourceBitmap.ToGdiBitmap();
            var width = image.Width;
            var height = image.Height;

            using (var transformBitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb))
            {
                using (var graphics = Graphics.FromImage(transformBitmap))
                {
                    graphics.Clear(Color.Transparent);
                    var path = new GraphicsPath(FillMode.Alternate);

                    int radius = 15;
                    int diameter = radius * 2;

                    path.StartFigure();
                    path.AddLine(radius, 0, width - radius, 0);
                    path.AddArc(new RectangleF(width - diameter, 0, diameter, diameter), -90, 90);
                    path.AddLine(width, radius, width, height - radius);
                    path.AddArc(new RectangleF(width - diameter, height - diameter, diameter, diameter), 0, 90);
                    path.AddLine(width - radius, height, radius, height);
                    path.AddArc(new RectangleF(0, height - diameter, diameter, diameter), 90, 90);
                    path.AddLine(0, height - radius, 0, radius);
                    path.AddArc(new RectangleF(0, 0, diameter, diameter), 180, 90);
                    path.CloseFigure();

                    graphics.SetClip(path);
                    graphics.DrawImage(image, Point.Empty);
                }

                sourceBitmap.Import(transformBitmap);
                return sourceBitmap;
            }
        }
    }
}
