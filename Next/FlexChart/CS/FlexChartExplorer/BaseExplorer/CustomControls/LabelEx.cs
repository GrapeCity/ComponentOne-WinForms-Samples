using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer
{
    public class LabelEx : Label
    {
        public LabelEx(string text)
        {
            Text = text;
            AutoSize = true;
            Margin = new Padding(5);
            Padding = new Padding(0, 3, 0, 0);
            ForeColor = Color.DimGray;
        }
        public LabelEx(string text, int width, int height)
        {
            Text = text;
            Width = width;
            Height = height;
            Margin = new Padding(5);
            ForeColor = Color.DimGray;
        }
    }
}

