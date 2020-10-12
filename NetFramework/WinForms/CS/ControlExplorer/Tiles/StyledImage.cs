using System;
using System.Drawing;
using System.Collections.Generic;
using C1.Win.Util;


namespace ControlExplorer.Tiles
{
    public class StyledImage: IDisposable
    {
        private Dictionary<Color, Bitmap> _images;

        private ImageRecolorer _recolorer;
        private Bitmap _defaultImage;

        public StyledImage()
        {
            _images = new Dictionary<Color, Bitmap>();           
            _recolorer = new ImageRecolorer();         
        }

        public Bitmap DefaultImage
        {
            get { return _defaultImage; }
            set
            {
                if(_defaultImage != value)
                {
                    _defaultImage = value;
                    ResetImages();
                }
            }
        }

        public Bitmap GetImage(Color color)
        {
            if (_images != null && color != Color.Transparent)
            {
                if (_images.ContainsKey(color))
                    return _images[color];

                return AddNewImage(color);
            }
            return null;
        }

        private Bitmap AddNewImage(Color color)
        {
            if (_defaultImage != null)
            {
                int w = _defaultImage.Width;
                int h = _defaultImage.Height;
                Bitmap img = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                _recolorer.ChannelWhite = color;
                _recolorer.MapPixels(_defaultImage, img, w, h);
                _images.Add(color, img);
                return img;
            }
            return null;
        }

        private void ResetImages()
        {
            if (_images != null)
            {
                foreach (var item in _images)
                    item.Value.Dispose();
                _images.Clear();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                ResetImages();
                _images = null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
