using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseExplorer.Core;
using BaseExplorer.Utilities;

namespace BaseExplorer.Components
{
    public delegate void StackNodeEventHandler(object sender, StackNodeEventArgs e);
    public partial class StackNodeControl : UserControl
    {
        #region events
        public event StackNodeEventHandler StackNodeClick;
        #endregion

        #region fields

        private Color _backColor = Color.FromArgb(241, 241, 241);
        private Image _collapsedImage;
        private StackedNodeCollection _nodes;
        private int _level;
        private bool isExpanded;
        private bool _filtered = true;
        private bool _isVisible = false;
        private StringFormat sf;
        private SolidBrush pLCBrush = new SolidBrush(SkinManager.PrimaryLightColor);

        #endregion

        public new Color BackColor
        {
            get { return _backColor; }
            set
            {
                _backColor = value;
                mainPanel.BackColor = value;
                pnlHighlighter.BackColor = value == Color.White? Color.White : SkinManager.PrimaryColor;
            }
        }
        public Image ExpandedImage { get; set; }
        public Image CollapsedImage
        {
            get
            { return this._collapsedImage; }
            set
            {
                _collapsedImage = value;
                if (!this.isExpanded)
                    pbMain.Image = value;
            }
        }
        public StackedNodeCollection Nodes
        {
            get
            {
                if (_nodes == null)
                {
                    _nodes = new StackedNodeCollection();
                    _nodes.NodeAdded += OnNodeAdded;

                }
                return _nodes;
            }
        }
        public StackTreeControl StackedTree
        { get; internal set; }
        public StackNodeControl ParentNode
        { get; internal set; }
        public string Key { get; set; }
        /// <summary>
        /// Get or set the superscripted text to be displayed against the node, e.g. New/Upd
        /// </summary>
        public string Status { get;set; }
        public int Level
        {
            get { return this._level; }
            internal set
            {
                this._level = value;
                this.mainPanel.Padding = new Padding(_level * 10, 0, 0, 0);
            }
        }
        public bool IsSearchable { get; set; } //= false;
        public string SearchString { get; set; } //= null;
 
        /// <summary>
        /// Get or set if the node is to remain visible while searching
        /// </summary>
        public bool Filtered
        {
            get
            {
                return _filtered;
            }
            set
            {
                if (_filtered != value)
                {
                    _filtered = value;
                }
                OnNodeVisibleChange();
            }
        }

        public bool IsVisible
        {
            get
            {
                return _isVisible;
            }
            set
            {
                if (_isVisible != value)
                {
                    _isVisible = value;
                }
                OnNodeVisibleChange();
            }
        }
        public bool IsExpanded
        {
            get
            {
                return this.isExpanded;
            }
        }
        public bool IsSelected
        {
            get
            {
                if (StackedTree == null || StackedTree.SelectedNode == null)
                    return false;
                else
                    return StackedTree.SelectedNode == this;
            }
        }

        public StackNodeControl()
        {
            InitializeComponent();

            lblText.Click += (s, e) => this.OnNodeClicked(this);
            flowLayoutPanel1.Click += (s, e) => this.OnNodeClicked(this);
            pnlHighlighter.Click += (s, e) => this.OnNodeClicked(this);
            mainPanel.Click += (s, e) => this.OnNodeClicked(this);

            pbMain.Click += (s, e) => StateChangeRequest(s, e);
            lblText.DoubleClick += (s, e) => StateChangeRequest(s, e);
            mainPanel.DoubleClick += (s, e) => StateChangeRequest(s, e);

            this.Height = 40;
            SubscribeMouseEvents(this);
        }

        public void Expand(bool expandAll = false)
        {
            if (expandAll)
            {
                foreach (StackNodeControl child in this.Nodes)
                    child.Expand(expandAll);
            }
            isExpanded = true;
            PerformExpandCollapse();
        }

        public void Collapse(bool collapseAll = false)
        {
            if (collapseAll)
            {
                foreach (StackNodeControl child in this.Nodes)
                    child.Collapse(collapseAll);
            }
            isExpanded = false;
            PerformExpandCollapse();
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

        public override string ToString()
        {
            return lblText.Text;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.lblText.Text = this.Text;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            lblText.ForeColor = this.ForeColor;
        }

        #region Implementation

        private void PerformExpandCollapse()
        {
            pbMain.Image = this.isExpanded ? ExpandedImage : CollapsedImage;
            pbMain.Refresh();

            foreach (StackNodeControl child in this.Nodes)
                child.IsVisible = isExpanded;
            UpdateHeight();
        }

        private void UpdateHeight()
        {
            this.Height = GetHeight(this);
            var pNode = this.ParentNode;
            while (pNode != null)
            {
                pNode.UpdateHeight();
                pNode = pNode.ParentNode;
            }
        }

        private int GetHeight(StackNodeControl node)
        {
            if (!node.IsVisible || !node.Filtered)
                return 0;
            int totalHeight = 40;
            if ( node.Nodes.Count == 0 || !node.IsExpanded)
                return totalHeight;
            else  //Get ChildPanel Height
            {
                //Immediate Nodes
                foreach (StackNodeControl child in node.Nodes)
                {
                    totalHeight += GetHeight(child);
                }
                return totalHeight;
            }
        }

        private void OnNodeClicked(StackNodeControl node)
        {
            if (this.StackNodeClick != null)
            {
                this.StackNodeClick(this.StackedTree, new StackNodeEventArgs(node));
            }
        }

        private void OnNodeClicked(StackNodeEventArgs e)
        {
            if (StackNodeClick != null)
            {
                StackNodeClick(this, e);
            }
        }

        private void OnNodeAdded(object sender, StackNodeEventArgs e)
        {
            var node = e.Node;
            node.ForeColor = this.ForeColor;
            node.BackColor = this.BackColor;
            node.Level = this.Level + 1;
            node.StackedTree = this.StackedTree;
            node.ParentNode = this;
            node.Width = Width;
            node.StackNodeClick += (s, ev) => this.OnNodeClicked(ev);
            this.childPanel.Controls.Add(node);
        }

        private void OnNodeVisibleChange()
        {
            this.Visible = Filtered && IsVisible;
            UpdateHeight();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            if (StackedTree.SelectedNode == this)
                return;
            BackColor = Color.White;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (StackedTree.SelectedNode == this)
                return;
            BackColor = StackedTree.HoverBackColor;
        }

        private void StateChangeRequest(object sender, EventArgs e)
        {
            this.isExpanded = !this.isExpanded;
            PerformExpandCollapse();
        }

        private void SubscribeMouseEvents(Control control)
        {
            control.MouseEnter += OnMouseLeave;
            control.MouseLeave += OnMouseEnter;
            foreach (Control child in control.Controls)
            {
                SubscribeMouseEvents(child);
            }
        }

        private void OnFlowLayoutPanelPaint(object sender, PaintEventArgs e)
        {
            //Draws the Status as superscripted text against the node 
            if(!string.IsNullOrEmpty(Status))
            {
                var sz = TextRenderer.MeasureText(Status, FontManager.SideBarStatusFont);
                var rect = new RectangleF
                {
                    X = lblText.Right,
                    Y = flowLayoutPanel1.Top + sz.Height/2,
                    Width = sz.Width + 8,
                    Height = sz.Height + 6
                };
                if(sf==null)
                {
                    sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Far;
                    sf.Alignment = StringAlignment.Center;
                }
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                var foreColorBrush = IsSelected ? pLCBrush  : Brushes.White;
                var backColorBrush = IsSelected ? Brushes.White : pLCBrush;

                e.Graphics.FillRoundedRectangle(backColorBrush, rect, 8);
                e.Graphics.DrawString(Status, FontManager.SideBarStatusFont, foreColorBrush, rect,sf);
            }
        }

        #endregion
    }

    public class StackNodeEventArgs : EventArgs
    {
        public StackNodeControl Node { get; private set; }

        public StackNodeEventArgs(StackNodeControl node)
        {
            this.Node = node;
        }
    }
}
