using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer
{
    public class NumericUpDownEx : NumericUpDown
    {
        public NumericUpDownEx(int width=70, int height=21)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(width, height);
            this.Margin = new Padding(5);
        }
    }
}
