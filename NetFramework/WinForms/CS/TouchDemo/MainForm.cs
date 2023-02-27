using C1.Win.TouchToolKit;
using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TouchDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(MainForm_Load);
            treemenu.AfterSelect += new TreeViewEventHandler(treemenu_AfterSelect);
            treemenu.AfterCollapse += new TreeViewEventHandler(treemenu_AfterCollapse);
            searchtext.TextChanged += new EventHandler(searchtext_TextChanged);
            searchlist.SelectedIndexChanged += new EventHandler(searchlist_SelectedIndexChanged);
            myTabControl1.SelectedIndexChanged += new EventHandler(myTabControl1_SelectedIndexChanged);
            
            // Since, the size increases each time you open the designer, if the FixedPanel nested properties
            // are set in the designer of VS2010, this can be avoided by setting them from code.
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int maxTouchPoints = C1TouchEventProvider.MaximunTouches;

            bool win8 = Environment.OSVersion.Version >= new Version(6, 2);
            if (maxTouchPoints == 0 || !win8)
            {
                string commonFile = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86);
                DialogResult r = MessageBox.Show(@"For the best possible experience, please view this demo on a touch-enabled device.

Environment request:
- Windows 8 Operating System or Higher.
- A Touch-Enabled Device. (Or Simulator in " + commonFile + @"\Microsoft Shared\Windows Simulator)

Would you like to continue?
Click 'Yes' to continue. Click 'No' to close.
                ", "Do not support touch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (r == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }
            }

            // Open first view
            this.setMainPanel(new FirstViewPage());
            treemenu.Select();
        }
        private void treemenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string text = e.Node.Text;
            var node = e.Node;
            while (node.Nodes.Count > 0)
            {
                node = node.Nodes[0];
                text = node.Text;
            }

            switch (text.Trim())
            {
                case "Basic (Zoom and Scroll)":
                    if (e.Node.Tag != null)
                    {
                        if (e.Node.Tag.ToString() == "C1Zoom")
                        {
                            this.setMainPanel(new TouchDemo.C1ZoomPages.C1ZoomCommenDemo());
                        }
                        if (e.Node.Tag.ToString() == "C1ZoomPanel")
                        {
                            this.setMainPanel(new TouchDemo.C1ZoomPanelPages.C1ZoomPanelDemo());
                        }
                    }
                    break;
                case "ControlBar":
                    this.setMainPanel(new TouchDemo.C1ZoomPages.ControlBarDemo());
                    break;
                case "Show Control":
                    this.setMainPanel(new TouchDemo.C1ZoomPages.ShowControlDemo());
                    break;
                case "Pan Window":
                    this.setMainPanel(new TouchDemo.C1ZoomPages.PanWindowDemo());
                    break;
                case "Zoom Policy":
                    this.setMainPanel(new TouchDemo.C1ZoomPages.ZoomPolicyDemo());
                    break;
                case "Misc":
                    this.setMainPanel(new TouchDemo.C1ZoomPages.MiscFeatureDemo());
                    break;

                case "Multiple window Business app example with the Component":
                    this.setMainPanel(new TouchDemo.C1ApplicationZoomPages.C1ApplicationZoomDemo());
                    break;

                case "C1Magnifier":
                    this.setMainPanel(new TouchDemo.C1MagnifierPages.C1MagnifierCommon());
                    break;

                case "Compare PictureBox and C1MultiScaleImage":
                    this.setMainPanel(new TouchDemo.MultiScaleImagePages.MultiScaleImageDemo());
                    break;

                case "Touch Events List":
                    this.setMainPanel(new TouchDemo.TouchEvent.TouchEventListener());
                    break;
                case "ContextualUI":
                    this.setMainPanel(new TouchDemo.TouchEvent.ContextualUIDemo());
                    break;
                case "AutoRepeat":
                    this.setMainPanel(new TouchDemo.TouchEvent.AutoRepeatDemo());
                    break;
                case "ImageViewer":
                    this.setMainPanel(new TouchDemo.TouchEvent.TouchEventDemo());
                    break;
                case "Drawing Board for Pen":
                    this.setMainPanel(new TouchDemo.TouchEvent.DrawingBoardDemo());
                    break;

                default:
                    break;
            }
        }

        private void treemenu_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            treemenu.SelectedNode = null;
        }

        #region Page navigation processing
        private void setMainPanel(FirstViewPage ucontrol)
        {
            ucontrol.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(ucontrol);
            if (this.splitContainer1.Panel2.Controls.Count > 1)
            {
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }
        }
        private void setMainPanel(DemoBase ucontrol)
        {
            ucontrol.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(ucontrol);
            if (this.splitContainer1.Panel2.Controls.Count > 1)
            {
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }
        }
        private void setMainPanel(DemoBase_settings ucontrol)
        {
            ucontrol.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(ucontrol);
            if (this.splitContainer1.Panel2.Controls.Count > 1)
            {
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }
        }
        #endregion

        #region Link processing
        private void firstView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Return to first view
            this.setMainPanel(new FirstViewPage());
            treemenu.SelectedNode = null;
            treemenu.ExpandAll();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/GrapeCityUS");
        }
        #endregion

        #region Search functionality
        // Collection of search node               
        ArrayList myNode = new ArrayList();

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            // Clear the search results(searchlist)
            searchlist.Items.Clear();
            myNode.Clear();

            if (searchtext.Text == "") return;

            // Get the tree control node
            foreach (TreeNode node in GetAllNodes(treemenu.Nodes))
            {
                if (node.Parent != null)
                {
                    string s = node.Text;
                    if (node.Tag != null) s += node.Tag.ToString();

                    // Extract only the nodes that contain the search word
                    if (s.ToUpper().Contains(searchtext.Text.ToUpper()))
                    {
                        myNode.Add(node);
                        searchlist.Items.Add(node.Text);
                    }
                }
            }
        }

        private ArrayList GetAllNodes(TreeNodeCollection Nodes)
        {
            ArrayList Ar = new ArrayList();
            // Get the tree control node
            foreach (TreeNode Node in Nodes) {
		        Ar.Add(Node);
		        if (Node.GetNodeCount(false) > 0) Ar.AddRange(GetAllNodes(Node.Nodes));
	        }
	        return Ar;
        }

        private void searchlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the pages that have been selected in the list box
            treemenu.SelectedNode = (TreeNode)myNode[searchlist.SelectedIndex];
        }

        private void myTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the focus on tree view, so that it is in selected state
            if (myTabControl1.SelectedIndex == 0)
            {
                treemenu.Select();
            }
        }
        #endregion

        private void treemenu_VisibleChanged(object sender, EventArgs e)
        {
            this.treemenu.Nodes[0].ExpandAll();
        }

    }

    // Opening and closing of tree view, on a single click
    class MyTreeView : TreeView
    {
        public MyTreeView()
            : base()
        {
            NodeMouseClick += new TreeNodeMouseClickEventHandler(MyTreeView_NodeMouseClick);
        }

        void MyTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null)
            {
                if (HitTest(e.Location).Location == TreeViewHitTestLocations.Label ||
                    HitTest(e.Location).Location == TreeViewHitTestLocations.Image)
                {
                    e.Node.Toggle();
                }
            }
        }
    }

    // Reduce flickering in the tab control
    class MyTabControl : TabControl
    {
        // Processing to reduce the flickering during resizing
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}