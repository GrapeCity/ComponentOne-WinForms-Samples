using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer
{
    public class ButtonEx : Button
    {
        public ButtonEx()
        {
            FlatStyle = FlatStyle.Flat;
            ForeColor = System.Drawing.Color.DimGray;
            Margin = new Padding(5);
            Size = GetSize();
        }
        public ButtonEx(string text) : this()
        {
            Text = text;            
        }

        private Size GetSize()
        {
            int dpi = base.DeviceDpi;
            int width = 130;
            int height = 26;
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
