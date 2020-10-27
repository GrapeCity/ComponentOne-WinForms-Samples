using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer.CustomControls
{
    public class TextBoxEx : TextBox
    {
        const int WmPaint = 15;

        string _placeHolder = "";
        public string Placeholder
        {
            get
            {
                return _placeHolder;
            }
            set
            {
                _placeHolder = value;
                this.Refresh();
            }
        }
        public TextBoxEx()
        {
            Size = GetSize(130, 21);
            Margin = new Padding(5);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if(AutoSize)
            {
                var size = TextRenderer.MeasureText(Text, Font);
                var width = Math.Max(130,size.Width);
                var height = Math.Max(21,size.Height);
                Size = GetSize(width, height);
            }
            this.Refresh();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WmPaint:
                    using (var graphics = Graphics.FromHwnd(Handle))
                    {
                        if (string.IsNullOrEmpty(this.Text) && !string.IsNullOrEmpty(this.Placeholder))
                        {
                            graphics.DrawString(this.Placeholder, this.Font, Brushes.DimGray, new PointF(0, 0));
                        }
                    }
                    break;
            }
        }

        private Size GetSize(int width, int height)
        {
            int dpi = base.DeviceDpi;
            if (dpi != 96)
            {
                double scale = (double)dpi / 96;
                width = (int)(width * scale);
                height = (int)(height * scale);
            }
            return new Size(width, height);
        }

    }
}
