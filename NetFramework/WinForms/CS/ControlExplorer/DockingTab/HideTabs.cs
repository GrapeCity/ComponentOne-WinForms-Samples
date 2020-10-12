using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.DockingTab
{
    public partial class HideTabs : C1DemoForm
    {
        public HideTabs()
        {
            InitializeComponent();
            AddProperty("ShowTabs", c1DockingTab1);
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            c1DockingTab1.SelectedIndex += 1;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            c1DockingTab1.SelectedIndex -= 1;
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
        }

        private void btnFinish4_Click(object sender, EventArgs e)
        {
            c1DockingTab1.SelectedIndex = 0;
        }

        private void HideTabs_Load(object sender, EventArgs e)
        {
            c1DockingTab1.ShowTabs = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnNext1.Enabled = checkBox1.Checked;
        }
    }
}
