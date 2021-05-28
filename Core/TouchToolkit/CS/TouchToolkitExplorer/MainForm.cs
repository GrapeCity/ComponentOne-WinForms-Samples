using C1.Win.TouchToolKit;
using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TouchToolkitExplorer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Load += MainForm_Load;
            treemenu.AfterSelect += treemenu_AfterSelect;
            treemenu.AfterCollapse += treemenu_AfterCollapse;
            firstView.LinkClicked += firstView_LinkClicked;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int maxTouchPoints = C1TouchEventProvider.MaximunTouches;

            bool win8 = Environment.OSVersion.Version >= new Version(6, 2);
            if (maxTouchPoints == 0 || !win8)
            {
                string commonFile = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86);
                DialogResult r = MessageBox.Show(@"To have better experience, please try this demo in a touchable environment.

Environment request:
- Windows 8 Oprating System or upper.
- A touchable device. (Or Simulator in " + commonFile + @"\Microsoft Shared\Windows Simulator)

Are you still want to contine try?
Click 'Yes' to continue. Click 'No' to close.
                ", "Do not support touch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (r == DialogResult.No)
                    Close();
            }

            setMainPanel(new FirstViewPage());
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
                            setMainPanel(new C1ZoomPages.C1ZoomCommenDemo());
                        if (e.Node.Tag.ToString() == "C1ZoomPanel")
                            setMainPanel(new C1ZoomPanelPages.C1ZoomPanelDemo());
                    }
                    break;
                case "ControlBar":
                    setMainPanel(new C1ZoomPages.ControlBarDemo());
                    break;
                case "Show Control":
                    setMainPanel(new C1ZoomPages.ShowControlDemo());
                    break;
                case "Pan Window":
                    setMainPanel(new C1ZoomPages.PanWindowDemo());
                    break;
                case "Zoom Policy":
                    setMainPanel(new C1ZoomPages.ZoomPolicyDemo());
                    break;
                case "Misc":
                    setMainPanel(new C1ZoomPages.MiscFeatureDemo());
                    break;
                case "Multiple window Business app example with the Component":
                    setMainPanel(new C1ApplicationZoomPages.C1ApplicationZoomDemo());
                    break;
                case "C1Magnify":
                    setMainPanel(new C1MagnifyPages.C1MagnifyCommon());
                    break;
                case "Compare PictureBox and C1MultiScaleImage":
                    setMainPanel(new MultiScaleImagePages.MultiScaleImageDemo());
                    break;
                case "Touch Events Listener":
                    setMainPanel(new TouchEvent.TouchEventListener());
                    break;
                case "ContextualUI":
                    setMainPanel(new TouchEvent.ContextualUIDemo());
                    break;
                case "AutoRepeat":
                    setMainPanel(new TouchEvent.AutoRepeatDemo());
                    break;
                case "ImageViewer":
                    setMainPanel(new TouchEvent.TouchEventDemo());
                    break;
                case "Drawing Board for Pen":
                    setMainPanel(new TouchEvent.DrawingBoardDemo());
                    break;
                default:
                    break;
            }
        }

        private void setMainPanel(Control control)
        {
            control.Dock = DockStyle.Fill;
            pnlSample.Controls.Clear();
            pnlSample.Controls.Add(control);
            if (control is DemoBase db)
            {
                lblTitle.Text = db.Title;
                lblDescription.Text = db.Description;
                lblDescription.Height = lblDescription.GetPreferredSize(lblDescription.Size).Height;
            }
            else
            {
                lblTitle.Text = string.Empty;
                lblDescription.Text = string.Empty;
                lblDescription.Height = 0;
            }
        }

        private void firstView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setMainPanel(new FirstViewPage());
            treemenu.SelectedNode = null;
            treemenu.ExpandAll();
        }

        private void treemenu_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            treemenu.SelectedNode = null;
        }

        private void treemenu_VisibleChanged(object sender, EventArgs e)
        {
            treemenu.Nodes[0].ExpandAll();
        }

        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            pnlDescription.Visible = chkInfo.Checked;
        }
    }

    class MyTreeView : TreeView
    {
        public MyTreeView() : base()
        {
            NodeMouseClick += MyTreeView_NodeMouseClick;
        }
        void MyTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null)
            {
                var pos = HitTest(e.Location).Location;
                if (pos == TreeViewHitTestLocations.Label || pos == TreeViewHitTestLocations.Image)
                    e.Node.Toggle();
            }
        }
    }
}