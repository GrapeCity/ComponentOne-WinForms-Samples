using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenamingTabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1DockingTab1.CanRenameTabs = true;
            c1DockingTab2.CanRenameTabs = true;
        }


        private void checkBox2_Click(object sender, EventArgs e)
        {
            c1DockingTab1.CanRenameTabs = checkBox1.Checked;
            c1DockingTab2.CanRenameTabs = checkBox2.Checked;
        }

    }
}
