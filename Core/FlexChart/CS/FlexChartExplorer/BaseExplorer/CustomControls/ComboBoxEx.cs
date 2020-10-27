using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer
{
    public class ComboBoxEx : ComboBox
    {
        public Color BorderColor { get; set; }

        public ComboBoxEx(string comboName = null)
        {
            FlatStyle = FlatStyle.Flat;
            Size = GetSize();
            ForeColor = System.Drawing.Color.DimGray;
            FormattingEnabled = true;
            Margin = new Padding(5);
            BorderColor = ForeColor;
            DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboName != null)
            {
                this.Format += (s, e) =>
                {
                    e.Value = string.Format("{0}: {1}", comboName, e.Value);
                };
            }
        }

        private const int WM_PAINT = 0xF;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(BorderColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        private Size GetSize()
        {
            int dpi = base.DeviceDpi;
            int width = 130;
            int height = 21;
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

