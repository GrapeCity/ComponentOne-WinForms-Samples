using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Util;
using C1.Win.C1Tile;

namespace ControlExplorer.Tiles
{
    public class StyledTile : Tile
    {
        private StyledImage _image;

        public StyledTile()
        {
            _image = new StyledImage();
        }

        public new Image Image
        {
            get { return base.Image; }
            set
            {
                if (_image != null && _image.DefaultImage != value)
                {
                    _image.DefaultImage = value as Bitmap;
                    base.Image = _image.GetImage(BackColor);
                }
                else
                    base.Image = value;
            }
        }

        public void UpdateImage()
        {
            if (_image != null)
                base.Image = _image.GetImage(TileControl.ForeColor);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                if (_image != null)
                {
                    _image.Dispose();
                    _image = null;
                }
            }
        }
    }
}
