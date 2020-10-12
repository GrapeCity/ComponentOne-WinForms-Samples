using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace ControlExplorer.DockingTab
{
    public partial class Overview : C1DemoForm
    {
        public Overview()
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

        private void Overview_Load(object sender, EventArgs e)
        {
            //add demo properties 
            AddProperty("Alignment", c1DockingTab1);
            AddProperty("AlignTabs", c1DockingTab1);
            AddProperty("CanCloseTabs", c1DockingTab1);
            AddProperty("CanMoveTabs", c1DockingTab1);
            AddProperty("CloseBox", c1DockingTab1);
            AddProperty("HotTrack", c1DockingTab1);
            AddProperty("MultiLine", c1DockingTab1);
            AddProperty("SelectedTabBold", c1DockingTab1);
            AddProperty("ShowCaption", c1DockingTab1);
            AddProperty("ShowTabList", c1DockingTab1);
            AddProperty("ShowTabs", c1DockingTab1);
            AddProperty("TabLayout", c1DockingTab1);
            AddProperty("TabLook", c1DockingTab1);
            AddProperty("TabSizeMode", c1DockingTab1);
            AddProperty("TabsSpacing", c1DockingTab1);
            AddProperty("TabStyle", c1DockingTab1);
            AddProperty("TextDirection", c1DockingTab1);
        }
    }
}
