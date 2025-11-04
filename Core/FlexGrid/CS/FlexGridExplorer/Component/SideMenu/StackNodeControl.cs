using C1.Framework;
using FlexGridExplorer.Utility;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace FlexGridExplorer.Component.SideMenu
{
    public delegate void StackNodeEventHandler(object sender, StackNodeEventArgs e);
    /// <summary>
    /// A WinForms control that renders a collapsible/expandable node for a stacked side menu or tree.
    /// </summary>
    public partial class StackNodeControl : UserControl
    {
        #region Private Variables
        C1Icon _collapsedIcon;
        C1Icon _icon;
        StackedNodeCollection _nodes;
        int _level;
        bool _isExpanded;
        bool _filtered = true;
        bool _isVisible = false;
        bool _isHovered = false;

        #endregion
        #region events
        public event StackNodeEventHandler StackNodeClick;
        #endregion 
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string IconKey { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ExpandedKey { get; set; }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CollapsedKey { get; set; }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color BackColor { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public C1Icon ExpandedIcon { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public C1Icon Icon
        {
            get
            { return this._icon; }
            set
            {
                _icon = value;
                btnIcon.Icon = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public C1Icon CollapsedIcon
        {
            get
            { return this._collapsedIcon; }
            set
            {
                _collapsedIcon = value;
                if (!this._isExpanded)
                    btnChevron.Icon = value;
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StackTreeControl StackedTree
        { get; internal set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StackNodeControl ParentNode
        { get; internal set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Key { get; set; }

        [DefaultValue(null)]
        public string Status { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Level
        {
            get { return this._level; }
            internal set
            {
                this._level = value;
                this.tableLayoutPanel1.Padding = new Padding(_level * 10, 0, 0, 0);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSearchable { get; set; }  

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SearchString { get; set; }  
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsExpanded
        {
            get
            {
                return this._isExpanded;
            }
            set
            {
                _isExpanded = value;
                if (!_isExpanded)
                {
                    Collapse();
                }
                else
                {
                    Expand();
                }
            }
        }
        public bool IsSelected
        {
            get
            {
                if (StackedTree == null || StackedTree.SelectedNode == null)
                    return false;
                else if (StackedTree.Collapsed)
                {
                    return (StackedTree.SelectedNode == this || StackedTree.SelectedNodeRoot == this);
                }
                return StackedTree.SelectedNode == this;
            }
        }
        public StackNodeControl Root()
        {
            StackNodeControl root = this.ParentNode;
            StackNodeControl stackRoot = this.ParentNode;

            while (root != null)
            {
                root = root.ParentNode;
                if (root != null) { stackRoot = root; }
            }

            return stackRoot;
        }
        public StackNodeControl()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;

            lblText.Click += (s, e) => this.OnNodeClicked(this);
            mainPanel.Click += (s, e) => this.OnNodeClicked(this);
            pnlPB.Click += (s, e) => this.OnNodeClicked(this);
            btnIcon.Click += (s, e) => this.OnNodeClicked(this);
            this.Controls[1].Controls[0].Controls[1].Click += (s, e) => this.OnNodeClicked(this);

            btnChevron.Click += (s, e) => StateChangeRequest(s, e);
            lblText.DoubleClick += (s, e) => StateChangeRequest(s, e);
            mainPanel.DoubleClick += (s, e) => StateChangeRequest(s, e);
            this.Controls[1].Controls[0].Controls[1].DoubleClick += (s, e) => StateChangeRequest(s, e);

            this.Height = UnitHeight();
            SubscribeMouseEvents(this);
            mainPanel.Paint += PaintMainPanelBackground;
        }

        public void Expand(bool expandAll = false)
        {
            if (expandAll)
            {
                foreach (StackNodeControl child in this.Nodes)
                    child.Expand(expandAll);
            }
            _isExpanded = true;
            PerformExpandCollapse();
        }

        public void Collapse(bool collapseAll = false)
        {
            if (collapseAll)
            {
                foreach (StackNodeControl child in this.Nodes)
                    child.Collapse(collapseAll);
            }
            _isExpanded = false;
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

        #region Private Methods
        private void PaintMainPanelBackground(object sender, PaintEventArgs e)
        {
            if (IsSelected)
            {
                DrawBorder(e);
                DrawIndicator(e);
            }
            else
            {
                // Redraw for isHovered only when it's not selected
                if (_isHovered) { DrawBorder(e); }
            }
        }

        private void DrawIndicator(PaintEventArgs e)
        {
            using (Pen roundedPen = new Pen(SkinManager.HighlighterColor, 4))
            {
                roundedPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                roundedPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                roundedPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;

                e.Graphics.DrawLine(roundedPen, mainPanel.Location.X, btnIcon.Location.Y, mainPanel.Location.X, btnIcon.Location.Y + btnIcon.Height);
            }
        }

        private void DrawBorder(PaintEventArgs e)
        {
            int diameter = 6;
            int borderWidth = 2;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = mainPanel.ClientRectangle;
            rect.Inflate(-borderWidth, -borderWidth);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            Color burshColor = SkinManager.HighLightBackColor;
            using (Pen pen = new Pen(burshColor, borderWidth))
            {
                g.DrawPath(pen, path);
            }

            using (Brush brush = new SolidBrush(burshColor))
            {
                g.FillPath(brush, path);
            }
        }

        private int UnitHeight()
        {
            return this.lblText.Parent.Height;
        }
        private void PerformExpandCollapse()
        {
            btnChevron.Icon = this._isExpanded ? ExpandedIcon : CollapsedIcon;
            btnChevron.Refresh();

            foreach (StackNodeControl child in this.Nodes)
                child.IsVisible = _isExpanded;
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
            int totalHeight = UnitHeight();
            if (node.Nodes.Count == 0 || !node.IsExpanded)
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
            node.IsVisible = false;
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
            this.Cursor = Cursors.Hand;
            if (StackedTree.SelectedNode == this)
                return;
            _isHovered = true;
            mainPanel.Invalidate();
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            _isHovered = false;

            if (StackedTree.SelectedNode == this)
                return;
            mainPanel.Invalidate();
        }

        private void StateChangeRequest(object sender, EventArgs e)
        {
            this._isExpanded = !this._isExpanded;
            PerformExpandCollapse();
        }

        private void SubscribeMouseEvents(Control control)
        {
            control.MouseEnter += OnMouseEnter;
            control.MouseLeave += OnMouseLeave;
            foreach (Control child in control.Controls)
            {
                SubscribeMouseEvents(child);
            }
        }

        #endregion

        #region Protected Methods
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            lblText.ForeColor = this.ForeColor;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.lblText.Text = this.Text;
        }

        #endregion

        private void OnFlowLayoutPanelPaint(object sender, PaintEventArgs e)
        {
            //Draws the Status as superscripted text against the node 
            if (!string.IsNullOrEmpty(Status))
            {
                SolidBrush pLCBrush = new SolidBrush(SkinManager.PrimaryLightColor);
                StringFormat sf = new StringFormat();

                var sz = TextRenderer.MeasureText(Status, FontManager.SideBarStatusFont);
                var rect = new RectangleF
                {
                    X = lblText.Right,
                    Y = tableLayoutPanel1.Top + sz.Height / 2,
                    Width = sz.Width + 8,
                    Height = sz.Height + 6
                };
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Center;
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                var foreColorBrush = IsSelected ? pLCBrush : Brushes.White;
                var backColorBrush = IsSelected ? Brushes.White : pLCBrush;

                e.Graphics.FillRoundedRectangle(backColorBrush, rect, 8);
                e.Graphics.DrawString(Status, FontManager.SideBarStatusFont, foreColorBrush, rect, sf);
            }
        }
    } 
}
