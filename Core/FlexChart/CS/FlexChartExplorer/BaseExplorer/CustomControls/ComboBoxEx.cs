using BaseExplorer.Core;
using C1.Win.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer
{
    public class ComboBoxEx : C1ComboBox
    {
        [DefaultValue(typeof(Color), "Empty")]
        public Color BorderColor { get; set; }

        public ComboBoxEx(string comboName = null, int width = 130, int height = 21)
        {
            Size = GetSize(width, height);
            ForeColor = System.Drawing.Color.DimGray;
            Margin = new Padding(5);
            BorderColor = ForeColor;
            DropDownStyle = DropDownStyle.DropDownList;
        }

        private Size GetSize(int width, int height)
        {
            int dpi = base.DeviceDpi;
            if (dpi !=96)
            {
                double scale = (double)dpi / 96;
                width = (int) (width * scale);
                height = (int) (height * scale);
            }
            return new Size(width, height);
        }
    }
}

