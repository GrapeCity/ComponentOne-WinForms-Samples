using FlexGridExplorer.Properties;

namespace FlexGridExplorer.Core
{
    /// <summary>
    /// Generates and caches preview images for sample tiles displayed in the FlexGrid Explorer UI.
    /// </summary>
    public class TileImageGenerator : ITileImageGenerator
    {
        #region private variables
        readonly Dictionary<string, Image> _imgDict = new Dictionary<string, Image>();
        readonly object _imgLock = new object();
        string _entryAssembly;
        #endregion

        public Image GetImage(ItemInfo sample, Size imageSize)
        {
            if (sample == null) return ScaleBitmap(Resources.C1Icon, imageSize);

            try
            {
                string key = $"{sample.TypeName}_{imageSize.Width}_{imageSize.Height}";
                lock (_imgLock)
                {
                    if (_imgDict.TryGetValue(key, out var cached))
                        return cached;
                }

                if (string.IsNullOrEmpty(_entryAssembly))
                    _entryAssembly = typeof(Form1).Assembly.FullName;

                string asmQualifiedName = $"{sample.TypeName}, {_entryAssembly}";
                Type t = Type.GetType(asmQualifiedName, throwOnError: false);

                if (t == null || !typeof(Control).IsAssignableFrom(t))
                    return ScaleBitmap(Resources.C1Icon, imageSize);

                // Create the user control offscreen and render it
                using (var view = Activator.CreateInstance(t) as Control)
                {
                    if (view == null)
                        return ScaleBitmap(Resources.C1Icon, imageSize);

                    var renderW = Math.Max(imageSize.Width * 3, 800);
                    var renderH = Math.Max(imageSize.Height * 3, 500);
                    view.Bounds = new Rectangle(0, 0, renderW, renderH);
                    view.BackColor = Color.White;

                    using (var bmp = new Bitmap(renderW, renderH, System.Drawing.Imaging.PixelFormat.Format32bppPArgb))
                    {
                        view.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                        var thumb = ScaleBitmap(bmp, imageSize);

                        lock (_imgLock)
                        {
                            if (!_imgDict.ContainsKey(key))
                                _imgDict[key] = thumb;
                        }
                        return thumb;
                    }
                }
            }
            catch
            {
                return ScaleBitmap(Resources.C1Icon, imageSize);
            }
        }

        private static Bitmap ScaleBitmap(Image src, Size targetSize)
        {
            var result = new Bitmap(targetSize.Width, targetSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            using (var g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.DrawImage(src, new Rectangle(Point.Empty, targetSize));
            }
            return result;
        }
    }
}
