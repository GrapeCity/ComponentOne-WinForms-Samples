using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchToolKitDemo.C1ZoomPages.Help_Forms
{
    public partial class KeyboadControlBar : UserControl
    {
        public KeyboadControlBar()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            SendKeys.Send((sender as Button).Tag.ToString());
        }

        Size? oldSize = null;
        private void button13_Click(object sender, EventArgs e)
        {
            if (oldSize == null)
            {
                oldSize = this.Size;
                this.Size = (sender as Control).Size;
            }
            else
            {
                this.Size = oldSize.Value;
                oldSize = null;
            }
        }
    }
}
