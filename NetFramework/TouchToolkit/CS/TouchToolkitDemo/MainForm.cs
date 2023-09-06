using C1.Win.TouchToolKit;
using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TouchToolkitDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(MainForm_Load);
            treemenu.AfterSelect += new TreeViewEventHandler(treemenu_AfterSelect);
            treemenu.AfterCollapse += new TreeViewEventHandler(treemenu_AfterCollapse);
            firstView.LinkClicked += new LinkLabelLinkClickedEventHandler(firstView_LinkClicked);
            product_info.LinkClicked += new LinkLabelLinkClickedEventHandler(product_info_LinkClicked);
            searchtext.TextChanged += new EventHandler(searchtext_TextChanged);
            searchlist.SelectedIndexChanged += new EventHandler(searchlist_SelectedIndexChanged);
            myTabControl1.SelectedIndexChanged += new EventHandler(myTabControl1_SelectedIndexChanged);

            // VS2010のデザイナで入れ子のFixedPanelプロパティを設定すると
            // デザイナを開くたびにサイズが大きくなるため、コードから設定して回避
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            // デザイナを開くたびに位置が変わるため、コードから設定して回避
            mescius_logo.Location = new Point(12, 27);
            copyright.Location = new Point(173, 35);

            // ちらつき防止
            // ヘッダ
            pictureBox1.Controls.Add(cube);
            pictureBox1.Controls.Add(product_logo);
            pictureBox1.Controls.Add(product_title);
            pictureBox1.Controls.Add(firstView);

            // フッタ
            pictureBox2.Controls.Add(mescius_logo);
            pictureBox2.Controls.Add(copyright);
            pictureBox2.Controls.Add(product_info);
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

                if (r == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }
            }

            // ファーストビューを開く
            this.setMainPanel(new FirstViewPage());
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
                            this.setMainPanel(new TouchToolkitDemo.C1ZoomPages.C1ZoomCommenDemo());
                        }
                        if (e.Node.Tag.ToString() == "C1ZoomPanel")
                        {
                            this.setMainPanel(new TouchToolkitDemo.C1ZoomPanelPages.C1ZoomPanelDemo());
                        }
                    }
                    break;
                case "ControlBar":
                    this.setMainPanel(new TouchToolkitDemo.C1ZoomPages.ControlBarDemo());
                    break;
                case "Show Control":
                    this.setMainPanel(new TouchToolkitDemo.C1ZoomPages.ShowControlDemo());
                    break;
                case "Pan Window":
                    this.setMainPanel(new TouchToolkitDemo.C1ZoomPages.PanWindowDemo());
                    break;
                case "Zoom Policy":
                    this.setMainPanel(new TouchToolkitDemo.C1ZoomPages.ZoomPolicyDemo());
                    break;
                case "Misc":
                    this.setMainPanel(new TouchToolkitDemo.C1ZoomPages.MiscFeatureDemo());
                    break;

                case "Multiple window Business app example with the Component":
                    this.setMainPanel(new TouchToolkitDemo.C1ApplicationZoomPages.C1ApplicationZoomDemo());
                    break;

                case "C1Magnify":
                    this.setMainPanel(new TouchToolkitDemo.C1MagnifyPages.C1MagnifyCommon());
                    break;

                case "Compare PictureBox and C1MultiScaleImage":
                    this.setMainPanel(new TouchToolkitDemo.MultiScaleImagePages.MultiScaleImageDemo());
                    break;

                case "Touch Events Listener":
                    this.setMainPanel(new TouchToolkitDemo.TouchEvent.TouchEventListener());
                    break;
                case "ContextualUI":
                    this.setMainPanel(new TouchToolkitDemo.TouchEvent.ContextualUIDemo());
                    break;
                case "AutoRepeat":
                    this.setMainPanel(new TouchToolkitDemo.TouchEvent.AutoRepeatDemo());
                    break;
                case "ImageViewer":
                    this.setMainPanel(new TouchToolkitDemo.TouchEvent.TouchEventDemo());
                    break;
                case "Drawing Board for Pen":
                    this.setMainPanel(new TouchToolkitDemo.TouchEvent.DrawingBoardDemo());
                    break;

                default:
                    break;
            }
        }

        private void treemenu_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            treemenu.SelectedNode = null;
        }

        #region ページ移動処理
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

        #region リンク処理
        private void firstView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ファーストビューに戻る
            this.setMainPanel(new FirstViewPage());
            treemenu.SelectedNode = null;
            treemenu.ExpandAll();
        }

        private void trial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // トライアル版へのリンク
            //System.Diagnostics.Process.Start("");
        }
        
        private void product_info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // フッタから製品情報へのリンク
            System.Diagnostics.Process.Start("https://developer.mescius.com");
        }

        #endregion

        #region 検索機能
        // 検索ノードのコレクション               
        ArrayList myNode = new ArrayList();

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            // 検索結果(searchlist)をクリア
            searchlist.Items.Clear();
            myNode.Clear();

            if (searchtext.Text == "") return;

            // ツリーコントロールのノードを取得
            foreach (TreeNode node in GetAllNodes(treemenu.Nodes))
            {
                if (node.Parent != null)
                {
                    string s = node.Text;
                    if (node.Tag != null) s += node.Tag.ToString();

                    // 検索ワードを含むノードのみ抽出
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
            // ツリーコントロールのノードを取得
            foreach (TreeNode Node in Nodes) {
		        Ar.Add(Node);
		        if (Node.GetNodeCount(false) > 0) Ar.AddRange(GetAllNodes(Node.Nodes));
	        }
	        return Ar;
        }

        private void searchlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // リストボックスで選択されたページを表示
            treemenu.SelectedNode = (TreeNode)myNode[searchlist.SelectedIndex];
        }

        private void myTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ツリービューにフォーカスを設定して選択状態にする
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

    // ツリービューのシングルクリックでの開閉
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

    // タブコントロール内のちらつきを抑える
    class MyTabControl : TabControl
    {
        // リサイズ途中のちらつきを抑える処理
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