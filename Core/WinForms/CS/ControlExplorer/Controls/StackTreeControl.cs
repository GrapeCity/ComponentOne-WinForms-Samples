using ControlExplorer.Controls;
using ControlExplorer.Core;
using ControlExplorer.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlExplorer.Contrlols
{
    public partial class StackTreeControl : UserControl
    {
        #region Private Variables 
        private StackNodeControl _selectedNode;
        private StackNodeControl _selectedNodeRoot;
        private StackedNodeCollection _nodes;
        private Color _selectionColor = Color.Red;
        private Color _selectionForeColor = Color.Black;
        private string _filterString = "";
        private Boolean _collapsed = false;
        #endregion

        #region Static Methods 
        static Dictionary<string, Image> _imageList = null;
        #endregion

        #region Public Methods 
        public event StackNodeEventHandler SelectionChanged;
        #endregion 

        #region Public Methods

        public static Dictionary<string, Image> ImageList
        {
            get
            {
                if (_imageList == null)
                    _imageList = new Dictionary<string, Image>();
                return _imageList;
            }
            set { _imageList = value; }
        }

        public Boolean Collapsed
        {
            get { return _collapsed; }
            set
            {
                _collapsed = value;
                if (_collapsed == true)
                {
                    CollapseExpandedNodes();
                    pnlMain.AutoScroll = false;
                }
                else
                {
                    ExpandSelectedNode();
                    pnlMain.AutoScroll = true;
                }
            }
        }

        public Color HoverBackColor { get; set; }
        public Color HoverForeColor { get; set; }
        public Color SelectionColor
        {
            get { return _selectionColor; }
            set
            {
                if (_selectionColor != value)
                {
                    _selectionColor = value;
                    if (SelectedNode != null)
                        SelectedNode.BackColor = value;
                }
            }
        }
        public Color SelectionForeColor
        {
            get { return _selectionForeColor; }
            set
            {
                if (_selectionForeColor != value)
                {
                    _selectionForeColor = value;
                    if (SelectedNode != null)
                        SelectedNode.ForeColor = value;
                }
            }
        }
        public string FilterString
        {
            get { return _filterString; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    _filterString = "";
                else
                    _filterString = value.Trim();
                Filter();
            }
        }
        public StackNodeControl SelectedNode
        {
            get
            {
                return _selectedNode;
            }
            set
            {
                if (value != null && _selectedNode != value)
                {
                    OnSelectionChanged(new StackNodeEventArgs(value));
                }
            }
        }
        public StackNodeControl SelectedNodeRoot
        {
            get
            {
                return _selectedNodeRoot;
            }
            set
            {
                _selectedNodeRoot = value;
            }
        }
        public StackedNodeCollection Nodes
        {
            get
            {
                if (_nodes == null)
                {
                    _nodes = new StackedNodeCollection();
                    _nodes.NodeAdded -= OnNodeAdded;
                    _nodes.NodeAdded += OnNodeAdded;
                }
                return _nodes;
            }
        }
        public StackNodeControl FindNode(string key, bool searchAllChild = true)
        {
            StackNodeControl n = null;
            foreach (StackNodeControl node in this.Nodes)
            {
                if (node.Key == key)
                    n = node;
                else
                    n = node.FindNode(key);
                if (n == null)
                    continue;
                else
                    break;
            }
            return n;
        }
        public void OnSelectionChanged(StackNodeEventArgs e)
        {
            this.SuspendDrawing();

            if (_selectedNode != null)
            {
                _selectedNode.ForeColor = this.SelectionForeColor;
            }

            if (e.Node != null)
            {
                _selectedNode = e.Node;
                _selectedNode.BackColor = this.SelectionColor;
                _selectedNode.ForeColor = this.SelectionForeColor;

                CollapseAllExcept(_selectedNode);


                if (e.Node.Nodes.Count == 0)
                {
                    var p = SelectedNode.ParentNode;
                    while (p != null)
                    {
                        p.Expand();
                        p = p.ParentNode;
                    }
                    pnlMain.ScrollControlIntoView(SelectedNode.Parent);
                }

                this.ResumeDrawing();
                if (SelectionChanged != null)
                {
                    SelectionChanged(this, e);
                }

                if (Collapsed)
                {
                    if (SelectedNodeRoot != null) { SelectedNodeRoot.IsExpanded = true; }
                    SideBar parent = this.Parent as SideBar;
                    parent.Collapsed = !this.Collapsed;
                }
                else
                {
                    _selectedNode = e.Node;
                    _selectedNode.BackColor = this.SelectionColor;
                    _selectedNode.ForeColor = this.SelectionForeColor;

                    if (e.Node.Nodes.Count == 0)
                    {
                        var p = SelectedNode.ParentNode;
                        while (p != null)
                        {
                            p.Expand();
                            p = p.ParentNode;
                        }
                        pnlMain.ScrollControlIntoView(SelectedNode.Parent);
                    }

                    _selectedNodeRoot = _selectedNode.Root();

                    this.ResumeDrawing();
                    if (SelectionChanged != null)
                    {
                        SelectionChanged(this, e);
                    }
                }
            }
        }

        public StackTreeControl()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.Red;
            HoverBackColor = SkinManager.HighLightBackColor;
        }
        #endregion 

        #region Private Methods
        private void OnNodeAdded(object sender, StackNodeEventArgs e)
        {
            var node = e.Node;
            node.ForeColor = this.ForeColor;
            node.BackColor = this.BackColor;
            node.Width = Width;
            node.Level = 0;
            node.StackedTree = this;
            node.ParentNode = null;
            node.IsVisible = true;
            this.pnlMain.Controls.Add(node);
            node.StackNodeClick += (s, ev) => this.OnSelectionChanged(ev);
        }
        private void Filter()
        {
            this.SuspendDrawing();
            foreach (StackNodeControl node in this.Nodes)
            {
                if (_filterString == "")
                {
                    ClearFilters(node);
                    node.Collapse(true);
                    node.Expand(true);
                    pnlMain.ScrollControlIntoView(SelectedNode);
                }
                else
                {
                    node.Expand(true);
                    FilterNode(node);
                }
            }
            this.ResumeDrawing();
        }

        private void FilterNode(StackNodeControl node)
        {
            foreach (StackNodeControl child in node.Nodes)
                FilterNode(child);

            bool isVisible = !node.IsSearchable || node.SearchString.ToLower().Contains(_filterString.ToLower());
            bool isChildVisible = node.Nodes.Any(child => child.Filtered == true);
            node.Filtered = isVisible || isChildVisible;
        }

        private void ClearFilters(StackNodeControl node)
        {
            node.Filtered = true;
            foreach (StackNodeControl child in node.Nodes)
            {
                child.Filtered = true;
                ClearFilters(child);
            }
        }

        private void CollapseExpandedNodes()
        {
            foreach (StackNodeControl node in _nodes)
            {
                if (node.IsExpanded)
                {
                    node.IsExpanded = false;
                }
            }
        }

        private void ExpandSelectedNode()
        {
            if (SelectedNodeRoot != null) { SelectedNodeRoot.IsExpanded = true; }
            OnSelectionChanged(new StackNodeEventArgs(_selectedNode));
        }

        private void CollapseAllExcept(StackNodeControl selectedNode)
        {
            foreach (StackNodeControl node in this.Nodes)
            {
                CollapseAllRecursive(node, selectedNode);
            }
        }

        private void CollapseAllRecursive(StackNodeControl node, StackNodeControl selectedNode)
        {
            if (node != selectedNode && node != selectedNode.ParentNode)
            {
                node.Collapse(true);
            }

            foreach (StackNodeControl childNode in node.Nodes)
            {
                CollapseAllRecursive(childNode, selectedNode);
            }
        }

        #endregion

        #region Protected Methods
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion
    }
}
