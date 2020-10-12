using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AddingUICommands.Properties;
using System.IO;

namespace AddingUICommands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // In design time, we use the "..\..\Data\C1Sample.chm" path;
            // at run time, C1Sample.chm is in the same folder as the .exe file, so we need only file name
            c1DynamicHelp1.HelpSource = Path.GetFileName(c1DynamicHelp1.HelpSource);

            // need to handle the following events to enable/disable Back/Forward buttons
            c1DynamicHelp1.Browser.CanGoBackChanged += new EventHandler(Browser_CanGoBackChanged);
            c1DynamicHelp1.Browser.CanGoForwardChanged += new EventHandler(Browser_CanGoForwardChanged);
        }

        void Browser_CanGoForwardChanged(object sender, EventArgs e)
        {
            btnForward.Enabled = c1DynamicHelp1.Browser.CanGoForward;
        }

        void Browser_CanGoBackChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = c1DynamicHelp1.Browser.CanGoBack;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Use the C1DynamicHelp.Browser property to implement Back/Forward buttons
            if (e.ClickedItem == btnBack)
                c1DynamicHelp1.Browser.GoBack();
            else if (e.ClickedItem == btnForward)
                c1DynamicHelp1.Browser.GoForward();
            // use C1DynamicHelp.ShowExternalHelp methods to open help in an external window
            else if (e.ClickedItem == btnContents)
                c1DynamicHelp1.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab.TableOfContents);
            else if (e.ClickedItem == btnIndex)
                c1DynamicHelp1.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab.Index);
            else if (e.ClickedItem == btnSearch)
                c1DynamicHelp1.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab.Find);
        }

        private void btnPin_CheckedChanged(object sender, EventArgs e)
        {
            c1DynamicHelp1.IsPinnedDown = btnPin.Checked;
            btnPin.Image = btnPin.Checked ? Resources.pinned : Resources.unpinned;
            btnPin.ToolTipText = btnPin.Checked ? "Fixed topic" : "Fix topic";
        }

    }
}