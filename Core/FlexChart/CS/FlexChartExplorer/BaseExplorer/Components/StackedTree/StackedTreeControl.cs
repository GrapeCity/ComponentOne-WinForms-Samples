using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseExplorer.Utilities;

namespace BaseExplorer.Components
{
    public partial class StackTreeControl : UserControl
    {
        #region fields
        private string _filterString = "";
        private StackNodeControl _selectedNode;
        private StackedNodeCollection _nodes;
        private Color _selectionColor = Color.FromArgb(241, 241, 241);
        private Color _selectionForeColor = Color.Black;
        #endregion

        public event StackNodeEventHandler SelectionChanged;

        #region Object Model

        static Dictionary<string, Image> _imageList = null;
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
        #endregion

        #region C'tor
        public StackTreeControl()
        {
            InitializeComponent();
            HoverBackColor = Color.Gainsboro;
        }
        #endregion

        #region Public Methods
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
                _selectedNode.BackColor = Color.White;
                _selectedNode.ForeColor = Color.Black;
            }
            _selectedNode = e.Node;
            _selectedNode.BackColor = this.SelectionColor;
            _selectedNode.ForeColor = this.SelectionForeColor;

            if ( e.Node.Nodes.Count == 0)
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
            if (SelectionChanged!=null)
            {
                SelectionChanged(this, e);
            }
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
        #endregion

    }
}
