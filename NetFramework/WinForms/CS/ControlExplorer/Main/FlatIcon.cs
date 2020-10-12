using C1.Win.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ControlExplorer.Main
{
    public class FlatIcon
    {
        private Bitmap _sourceImage;
        private Bitmap _cachedImage;
        private Color _cachedColor;

        public FlatIcon(Image sourceImage)
        {
            Foreground = Color.Transparent;
            _sourceImage = sourceImage as Bitmap;
            if (_sourceImage == null)
            {
                throw new ArgumentException("sourceImage can't be null");
            }
        }

        public Color Foreground
        {
            get;
            set;
        }

        internal ImageRecolorer Recolorer
        {
            get;
            set;
        }

        public Image Image
        {
            get
            {
                if (Recolorer == null || Foreground == Color.Transparent)
                {
                    return _sourceImage;
                }
                return GetImage(Foreground);
            }
        }

        private Image GetImage(Color newColor)
        {
            if (_cachedImage == null || _cachedColor != newColor)
            {
                int width = _sourceImage.Width;
                int height = _sourceImage.Height;
                if (_cachedImage == null)
                {
                    _cachedImage = new Bitmap(width, height, PixelFormat.Format32bppPArgb);
                }
                Recolorer.MapPixels(_sourceImage, _cachedImage, width, height);
                _cachedColor = newColor;
            }
            return _cachedImage;
        }
    }

    public class FlatIconList : Dictionary<string, FlatIcon>
    {
        private Color _foreground = Color.Transparent;
        private ImageRecolorer _recolorer;

        public FlatIconList()
        {
            _recolorer = new ImageRecolorer();
        }

        public Color Foreground
        {
            get { return _foreground; }
            set
            {
                if (_foreground != value)
                {
                    _foreground = value;
                    _recolorer.ChannelWhite = value;
                    foreach (KeyValuePair<string, FlatIcon> icon in this)
                    {
                        icon.Value.Foreground = Foreground;
                    }
                }
            }
        }

        internal ImageRecolorer Recolorer
        {
            get { return _recolorer; }
        }

        public void Add(string key, Image image)
        {
            Add(key, new FlatIcon(image) { Recolorer = _recolorer, Foreground = Foreground });
        }

    }
}
