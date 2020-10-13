using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Util;

namespace ControlExplorer.Tiles
{
    public class StyledButton : Button
    {
        private StyledImage _image;

        public StyledButton()
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

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            if(_image != null)
                base.Image = _image.GetImage(ForeColor);
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
