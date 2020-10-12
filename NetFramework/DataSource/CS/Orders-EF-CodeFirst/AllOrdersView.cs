using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.LiveLinq.LiveViews;
using C1.Data;
using C1.Data.DataSource;
using C1.Data.Entities;

namespace Orders
{
    public partial class AllOrdersView : UserControl
    {
        // The tab page containing this user control
        public TabPage TabPage;

        public AllOrdersView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
             // Remove the tab page on Close button click
            if (TabPage != null)
                ((TabControl)TabPage.Parent).TabPages.Remove(TabPage);
        }

    }
}
