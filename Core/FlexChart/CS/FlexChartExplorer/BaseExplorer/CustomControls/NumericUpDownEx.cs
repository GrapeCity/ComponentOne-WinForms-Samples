using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BaseExplorer
{
    public class NumericUpDownEx : NumericUpDown
    {
        public NumericUpDownEx(int width=70, int height=21)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Size = GetSize(width, height);
            this.Margin = new Padding(5);
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
