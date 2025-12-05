// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlexGridExplorer.Utility;
using System.ComponentModel;

namespace FlexGridExplorer.Component.SideMenu
{
    /// <summary>
    /// Represents a hierarchical tree control used within the side menu,
    /// providing expandable and collapsible <see cref="StackNodeControl"/> nodes.
    /// </summary>
    public partial class StackTreeControl : UserControl
    {
        #region Private Variables 
        StackNodeControl _selectedNode;
        StackNodeControl _selectedNodeRoot;
        StackedNodeCollection _nodes;
        Color _selectionColor = Color.Red;
        Color _selectionForeColor = Color.Black;
        string _filterString = "";
        Boolean _collapsed = false;
        static Dictionary<string, Image> _imageList = null;
        #endregion 

        #region Events 
        public event StackNodeEventHandler SelectionChanged;
        #endregion 

        #region Properties

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Boolean Collapsed
        {
            get { return _collapsed; }
            set
            {
                _collapsed = value;
                if (_collapsed)
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverBackColor { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverForeColor { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
            StackNodeControl n = new StackNodeControl();
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

        #endregion

        #region Public Methods
        public StackTreeControl()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.Red;
            HoverBackColor = SkinManager.HighLightBackColor;
        }

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
                if (string.IsNullOrEmpty(_filterString))
                {
                    ClearFilters(node);
                    node.Collapse(true);
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
        //to remove flickering effect
        //Reference link https://stackoverflow.com/questions/3286373/flickering-in-a-windows-forms-app
        //https://web.archive.org/web/20160405111506/http://www.angryhacker.com/blog/archive/2010/07/21/how-to-get-rid-of-flicker-on-windows-forms-applications.aspx
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
