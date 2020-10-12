using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C1Zipper
{
    public partial class ViewDialog : Form
    {
        public ViewDialog()
        {
            InitializeComponent();
            _tb.MaxLength = int.MaxValue;
        }
        public void SetContent(string text)
        {
            _tb.Text = text;
            _tb.Select(0, 0);
        }
        void ViewDialog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
