using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.Command;

namespace CommandExplorer.Samples
{
    public partial class DockingOverview : UserControl
    {
        public DockingOverview()
        {
            InitializeComponent();             
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            C1DockingTabPage page = new C1DockingTabPage();
            page.Text = "Page" + (c1DockingTab1.TabPages.Count + 1).ToString();
            page.ImageIndex = c1DockingTab1.TabPages.Count % 3;
            c1DockingTab1.TabPages.Add(page);
        }
    }
}
