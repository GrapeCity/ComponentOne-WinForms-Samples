using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1DynamicHelp;

namespace ControlExplorer.DynamicHelp
{
    public partial class DynamicHelp : C1DemoForm
    {
        public DynamicHelp()
        {
            InitializeComponent();

            // need to handle the following events to enable/disable Back/Forward buttons
            c1DynamicHelp1.Browser.CanGoBackChanged += new EventHandler(Browser_CanGoBackChanged);
            c1DynamicHelp1.Browser.CanGoForwardChanged += new EventHandler(Browser_CanGoForwardChanged);
        }

        private void DynamicHelp_Load(object sender, EventArgs e)
        {
            //Load Help Source
            c1DynamicHelp1.HelpSource = AppDomain.CurrentDomain.BaseDirectory + "DynamicHelp\\HelpFiles\\C1Sample.chm";
            //Create Topic mappings to Treeview
            MapItem mi0 = new MapItem();
            mi0.Url = "WordDocuments/howtousec1dynamichelp.htm";
            mi0.HelpTopicTrigger = HelpTopicTrigger.MouseEnter;
            mi0.UIElement = treeView1.Nodes[0];

            MapItem mi1 = new MapItem();
            mi1.Url = "WordDocuments/designtimesupport.htm";
            mi1.HelpTopicTrigger = HelpTopicTrigger.Enter;
            mi1.UIElement = treeView1.Nodes[0].Nodes[0];

            MapItem mi2 = new MapItem();
            mi2.Url = "WordDocuments/runtimesupport.htm";
            mi2.HelpTopicTrigger = HelpTopicTrigger.Enter;
            mi2.UIElement = treeView1.Nodes[0].Nodes[1];

            c1DynamicHelp1.TopicMap.Add(treeView1.Nodes[0], mi0);
            c1DynamicHelp1.TopicMap.Add(treeView1.Nodes[0].Nodes[0], mi1);
            c1DynamicHelp1.TopicMap.Add(treeView1.Nodes[0].Nodes[1], mi2);

            //Show default topic
            c1DynamicHelp1.ShowTopic("WordDocuments/overview.htm");
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
            else if (e.ClickedItem == btnSearch)
                c1DynamicHelp1.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab.Find);
                
        }

        private void btnAuthoringMode_CheckedChanged(object sender, EventArgs e)
        {
            c1DynamicHelp1.AuthoringMode = btnAuthoringMode.Checked;
        }

        // toggle authoring mode when the user hits ctrl+shift+a
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control && e.Shift)
            {
                c1DynamicHelp1.AuthoringMode = !c1DynamicHelp1.AuthoringMode;
                btnAuthoringMode.Checked = c1DynamicHelp1.AuthoringMode;
            }
            base.OnKeyDown(e);
        }

        private void btnPin_CheckedChanged(object sender, EventArgs e)
        {
            c1DynamicHelp1.IsPinnedDown = btnPin.Checked;
            btnPin.Image = btnPin.Checked ? ControlExplorer.Properties.Resources.Pinned : ControlExplorer.Properties.Resources.Unpinned;
            btnPin.ToolTipText = btnPin.Checked ? "Fixed topic" : "Fix topic";
        }

        void Browser_CanGoForwardChanged(object sender, EventArgs e)
        {
            btnForward.Enabled = c1DynamicHelp1.Browser.CanGoForward;
        }

        void Browser_CanGoBackChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = c1DynamicHelp1.Browser.CanGoBack;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            c1DynamicHelp1.ShowTopic("WordDocuments/overview.htm");
        }
    }
}
