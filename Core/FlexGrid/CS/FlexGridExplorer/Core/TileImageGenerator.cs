// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlexGridExplorer.Properties;
using System.Drawing.Imaging;

namespace FlexGridExplorer.Core
{
    /// <summary>
    /// Generates and caches preview images for sample tiles displayed in the FlexGrid Explorer UI.
    /// </summary>
    public class TileImageGenerator
    {
        #region private variables
        readonly Dictionary<string, Image> _imgDict = new Dictionary<string, Image>();
        readonly object _imgLock = new object();
        string _entryAssembly;
        #endregion

        public Image GetImage(ItemInfo sample, Size imageSize)
        {
            if (sample == null) return ScaleBitmap(Resources.C1Icon, imageSize);

            if (sample.IsReferenced)
            {
                return ScaleBitmap((Image)Resources.ResourceManager.GetObject(sample.AssemblyName), imageSize);//make sure to keep the image name in the Resources.resx same as AssemblyName
            }
            try
            {
                string assemblyName;
                if (!string.IsNullOrEmpty(sample.AssemblyName))
                {
                    assemblyName = sample.AssemblyName;
                }
                else
                {
                    if (string.IsNullOrEmpty(_entryAssembly))
                        _entryAssembly = typeof(Form1).Assembly.FullName;

                    assemblyName = _entryAssembly;
                }

                string key = $"{assemblyName}|{sample.TypeName}|{imageSize.Width}x{imageSize.Height}";
                lock (_imgLock)
                {
                    if (_imgDict.TryGetValue(key, out var cached))
                        return cached;
                }

                string asmQualifiedName = $"{sample.TypeName}, {assemblyName}";
                Type t = Type.GetType(asmQualifiedName, throwOnError: false);

                if (t == null || !typeof(Control).IsAssignableFrom(t))
                    return ScaleBitmap(Resources.C1Icon, imageSize);

                using var view = Activator.CreateInstance(t) as Control;
                if (view == null)
                    return ScaleBitmap(Resources.C1Icon, imageSize);

                int renderW = Math.Max(imageSize.Width * 3, 800);
                int renderH = Math.Max(imageSize.Height * 3, 500);

                view.Bounds = new Rectangle(0, 0, renderW, renderH);
                view.BackColor = Color.White;

                view.CreateControl();
                view.PerformLayout();
                view.Refresh();

                Bitmap bmp = new Bitmap(renderW, renderH, PixelFormat.Format32bppPArgb);
                view.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));

                var thumb = ScaleBitmap(bmp, imageSize);

                lock (_imgLock)
                {
                    if (!_imgDict.ContainsKey(key))
                        _imgDict[key] = thumb;
                }

                return thumb;

            }
            catch
            {
                return ScaleBitmap(Resources.C1Icon, imageSize);
            }
        }

        private static Bitmap ScaleBitmap(Image src, Size targetSize)
        {
            var result = new Bitmap(targetSize.Width, targetSize.Height, PixelFormat.Format32bppPArgb);

            using var g = Graphics.FromImage(result);

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            g.DrawImage(src, new Rectangle(Point.Empty, targetSize));

            return result;
        }

    }
}
