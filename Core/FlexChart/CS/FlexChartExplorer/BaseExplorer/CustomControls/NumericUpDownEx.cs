using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.Input;
using static C1.Util.Win.Win32;
using System.ComponentModel;

namespace BaseExplorer
{
    public class NumericUpDownEx : C1NumericEdit
    {
        [DefaultValue(0)]
        public float Minimum{ get; set; }

        [DefaultValue(0)]
        public float Maximum{ get; set; }

        public NumericUpDownEx(int width=70, int height=21)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Size = GetSize(width, height);
            this.Margin = new Padding(5);
            this.ValueChanged += ClampNumericValue;
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

        private void ClampNumericValue(object sender, EventArgs e)
        {
            float valueSelected = Convert.ToSingle(this.Value);
            if (valueSelected < Minimum)
            {
                this.Value = Minimum;
            }
            else if (valueSelected > Maximum)
            {
                this.Value = Maximum;
            }
        }
    }
}
