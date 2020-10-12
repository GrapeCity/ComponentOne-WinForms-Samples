using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _superLabel.Paint += _superLabel_UpdateHeight;
        }

        void _superLabel_UpdateHeight(object sender, EventArgs e)
        {
            var lbl = sender as C1.Win.C1SuperTooltip.C1SuperLabel;
            var sz = lbl.Measure(lbl.Width - lbl.Padding.Left - lbl.Padding.Right);
            lbl.Height = sz.Height + lbl.Padding.Top + lbl.Padding.Bottom;
        }
    }
}
