using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BaseExplorer.Model;
using BaseExplorer.Utilities;

namespace BaseExplorer.Components
{
    public partial class SideBar : UserControl
    {
        public event EventHandler<SideBarEventArgs> SelectionChanged;

        private List<SampleItem> _samples;
        private Timer _textChangedTimer;

        public List<SampleItem> Samples
        {
            get { return _samples; }
            set
            {
                if (value != null)
                {
                    _samples = value;
                    PrepareSideBar();
                }
            }
        }
        public SideBar()
        {
            InitializeComponent();
            this.Load += SideBar_Load;
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            treeView.SelectionChanged += OnSelectionChanged;
        }

        private void OnSelectionChanged(object sender, StackNodeEventArgs e)
        {
            SampleItem sample = e.Node.Tag as SampleItem;
            if (sample != null)
                SelectionChanged(this, new SideBarEventArgs(sample));
        }

        private void OnAfterSelect(object sender, TreeViewEventArgs e)
        {
            SampleItem sample = e.Node.Tag as SampleItem;
            if (sample != null)
                SelectionChanged(this, new SideBarEventArgs(sample));
        }

        private void PrepareSideBar()
        {
            StackTreeControl.ImageList = new Dictionary<string, Image>();
            StackTreeControl.ImageList.Add("Home", Properties.Resources.icon_Home);
            StackTreeControl.ImageList.Add("Intro", Properties.Resources.icon_Intro);
            StackTreeControl.ImageList.Add("Plus", Properties.Resources.icon_Plus);
            StackTreeControl.ImageList.Add("Minus", Properties.Resources.icon_Minus);
            StackTreeControl.ImageList.Add("ExpandedArrow", Properties.Resources.icon_Triangle_Open);
            StackTreeControl.ImageList.Add("CollapsedArrow", Properties.Resources.icon_Triangle_Closed);
            StackTreeControl.ImageList.Add("Leaf", Properties.Resources.icon_leaf);
            treeView.Nodes.Clear();
            foreach (var sample in _samples)
                CreateNodes(sample, null);
            treeView.Nodes[0].ExpandedImage = treeView.Nodes[0].CollapsedImage = StackTreeControl.ImageList["Home"];
            treeView.Nodes[1].ExpandedImage = treeView.Nodes[1].CollapsedImage = StackTreeControl.ImageList["Intro"];
            if (treeView.Nodes.Count > 0)
                treeView.SelectedNode = treeView.Nodes[0];
        }

        private void CreateNodes(SampleItem sample, StackNodeControl parent = null)
        {
            StackNodeControl node;
            if (parent == null)
                node = treeView.Nodes.Add(sample.Guid.ToString(), sample.Name);
            else
            {
                node = parent.Nodes.Add(sample.Guid.ToString(), sample.Name);
                node.IsSearchable = true;
                /*
                 * A node can be searched based on the following parameters
                 * 1. Text of the parent node
                 * 2. Name and Title of the node itself
                 * 3. Keywords defined for the parent node
                 * 4. Keywords defined for the node itself
                 */
                node.SearchString = string.Format("{0} {1} {2} {3} {4}", parent.Text, sample.Name, sample.Title, sample.KeyWords, sample.Parent.KeyWords);
            }
            node.Tag = sample;
            node.Status = sample.Status;
            if (!sample.Items.IsNullOrEmpty())
            {
                node.ExpandedImage = node.Level == 0 ? StackTreeControl.ImageList["Minus"] : StackTreeControl.ImageList["ExpandedArrow"];
                node.CollapsedImage = node.Level == 0 ? StackTreeControl.ImageList["Plus"] : StackTreeControl.ImageList["CollapsedArrow"];
                foreach (var item in sample.Items)
                    CreateNodes(item, node);
            }
            else
                node.ExpandedImage = node.CollapsedImage = StackTreeControl.ImageList["Leaf"];
        }

        /// <summary>
        /// Changes the selected node of the TreeView to the given sample. 
        /// </summary>
        /// <param name="sample"></param>
        internal void SelectSample(SampleItem sample)
        {
            if (sample != null)
                treeView.SelectedNode = treeView.FindNode(sample.Guid.ToString());
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.IsExpanded)
                e.Node.Collapse();
            else
                e.Node.Expand();
        }

        private void textBoxEx1_TextChanged(object sender, EventArgs e)
        {
            pbCancel.Visible = !string.IsNullOrEmpty(textBoxEx1.Text);
            if (_textChangedTimer == null)
            {
                _textChangedTimer = new Timer() { Interval = 500 };
                _textChangedTimer.Tick += OnTick;
            }
            _textChangedTimer.Start();
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (textBoxEx1.Focused)
            {
                treeView.FilterString = textBoxEx1.Text;
                _textChangedTimer.Stop();
            }
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            textBoxEx1.Text = string.Empty;
        }
    }

    public class SideBarEventArgs : EventArgs
    {
        public SampleItem SelectedSample
        { get; private set; }
        public SideBarEventArgs(SampleItem sample)
        {
            this.SelectedSample = sample;
        }

    }
}
