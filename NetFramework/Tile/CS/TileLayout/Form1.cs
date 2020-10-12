using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TileLayout
{
    public partial class Form1 : Form
    {
        bool _tile4Flipped;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool a = _tile4Flipped;
            tile4.Template = a ? template41 : template42;
            _tile4Flipped = !a;
        }
    }
}
