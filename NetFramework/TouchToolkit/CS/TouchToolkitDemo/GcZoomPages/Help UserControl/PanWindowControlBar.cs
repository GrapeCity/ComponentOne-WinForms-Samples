using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.C1ZoomPages.Help_Forms
{
    public partial class ControlBarUserControl01 : UserControl
    {
        public ControlBarUserControl01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.C1ZoomCommandProvider1.OwnerForm.Close();
        }
    }
}
