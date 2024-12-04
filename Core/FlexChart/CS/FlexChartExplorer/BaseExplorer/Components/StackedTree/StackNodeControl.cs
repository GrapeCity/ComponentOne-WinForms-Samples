using System;
using System.Drawing;
using System.Windows.Forms;
using BaseExplorer.Core;
using BaseExplorer.Utilities;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Xml.Linq;

namespace BaseExplorer.Components
{
    public delegate void StackNodeEventHandler(object sender, StackNodeEventArgs e);
    public partial class StackNodeControl : UserControl
    {
        #region events
        public event StackNodeEventHandler StackNodeClick;
        #endregion

        #region fields

        private Image _collapsedImage;
        private Image _icon;
        private StackedNodeCollection _nodes;
        private int _level;
        private bool isExpanded;
        private bool _filtered = true;
        private bool _isVisible = false;
        private StringFormat sf;
        private SolidBrush pLCBrush = new SolidBrush(SkinManager.PrimaryLightColor);
        private bool isHovered = false;
        private string _theme = "Office365White";

        #endregion

        public string IconKey { get; set; }
        public string ExpandedKey { get; set; }
        public string CollapsedKey { get; set; }
        public new Color BackColor { get; set; }
        public Image ExpandedImage { get; set; }
        public string Theme 
        { 
            get
            {
                return _theme;
            }
            set
            {
                if (_theme != value) 
                {
                    _theme = value;
                    ApplyTheme();
                }
               
            }
        }
        public Image Icon 
        {
            get
            { return this._icon; }
            set
            {
                _icon = value;
                pbMain.Image = value;
            }
        }
        public Image CollapsedImage
        {

            get
            { return this._collapsedImage; }
            set
            {
                _collapsedImage = value;
                if (!this.isExpanded)
                    pbChevron.Image = value;
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
        public string Status { get; set; }
        public int Level
        {
            get { return this._level; }
            internal set
            {
                this._level = value;
                this.tableLayoutPanel1.Padding = new Padding(_level * 10, 0, 0, 0);
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
            set
            {
                isExpanded = value;
                if (!isExpanded)
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
                else
                    if(StackedTree.Collapsed)
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

            while(root!= null)
            {
                root = root.ParentNode;
                if (root != null) { stackRoot = root; }
            }

            return stackRoot;
        }

        public StackNodeControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            lblText.Click += (s, e) => this.OnNodeClicked(this);
            mainPanel.Click += (s, e) => this.OnNodeClicked(this);
            pnlPB.Click += (s, e) => this.OnNodeClicked(this);
            flowLayoutPanel1.Click += (s, e) => this.OnNodeClicked(this);

            pbChevron.Click += (s, e) => StateChangeRequest(s, e);
            lblText.DoubleClick += (s, e) => StateChangeRequest(s, e);
            mainPanel.DoubleClick += (s, e) => StateChangeRequest(s, e);
            flowLayoutPanel1.DoubleClick += (s, e) => StateChangeRequest(s, e);

            this.Height = UnitHeight();
            SubscribeMouseEvents(this);
            mainPanel.Paint += PaintMainPanelBackground;
        }

        private void PaintMainPanelBackground(object sender, PaintEventArgs e)
        {
            if(IsSelected)
            {
                DrawBorder(e);
                DrawIndicator(e);
            }
            else
            {
                // Redraw for isHovered only when it's not selected
                if (isHovered) { DrawBorder(e); }
            }
        }

        private void DrawIndicator(PaintEventArgs e)
        {
            using (Pen roundedPen = new Pen(SkinManager.Indicator, 4))
            {
                roundedPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                roundedPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                roundedPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;

                e.Graphics.DrawLine(roundedPen, mainPanel.Location.X, pbMain.Location.Y, mainPanel.Location.X, pbMain.Location.Y + pbMain.Height);
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

            Color burshColor = Theme == "Office365White" ? SkinManager.HighLightBackColor : SkinManager.BlackHighLightColor;
            using (Pen pen = new Pen(burshColor, borderWidth))
            {
                g.DrawPath(pen, path);
            }

            using (Brush brush = new SolidBrush(burshColor))
            {
                g.FillPath(brush, path);
            }
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

        // So that all items (parent and children) would have the same height 
        private int UnitHeight()
        {
            return this.lblText.Parent.Height;
        }


        #region Implementation

        private void PerformExpandCollapse()
        {
            pbChevron.Image = this.isExpanded ? ExpandedImage : CollapsedImage;
            pbChevron.Refresh();
            
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
            isHovered = true;
            mainPanel.Invalidate();
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            isHovered = false;

            if (StackedTree.SelectedNode == this)
                return;
            mainPanel.Invalidate();
        }

        private void StateChangeRequest(object sender, EventArgs e)
        {
            this.isExpanded = !this.isExpanded;
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

        private void ApplyTheme()
        {
            bool isWhite = Theme == "Office365White";
            ColorPanels(isWhite ? SkinManager.BackColor : SkinManager.BlackBackColor);
            SetNodeIcons(isWhite);
        }

        private void ColorPanels(Color color)
        {
            BackColor = color;
            pnlPB.BackColor = color;
            lblText.BackColor = color;
            panel1.BackColor = color;
            flowLayoutPanel1.BackColor = color;
            childPanel.BackColor = color;
        }

        private void SetNodeIcons(bool isWhite)
        {
            if (isWhite)
            {
                ForeColor = SystemColors.ControlText;
                Icon = IconKey == null ? null : (Image)Properties.Resources.ResourceManager.GetObject($"{IconKey}_black");
                ExpandedImage = ExpandedKey == null ? null : (Image)Properties.Resources.ResourceManager.GetObject($"{ExpandedKey}_black");
                CollapsedImage = CollapsedKey == null ? null : (Image)Properties.Resources.ResourceManager.GetObject($"{CollapsedKey}_black");
            }
            else
            {
                ForeColor = Color.White;
                Icon = IconKey == null ? null : (Image)Properties.Resources.ResourceManager.GetObject($"{IconKey}_white");
                ExpandedImage = ExpandedKey == null ? null : (Image)Properties.Resources.ResourceManager.GetObject($"{ExpandedKey}_white");
                CollapsedImage = CollapsedKey == null ? null : (Image)Properties.Resources.ResourceManager.GetObject($"{CollapsedKey}_white");
            }
        }

        private void OnFlowLayoutPanelPaint(object sender, PaintEventArgs e)
        {
            //Draws the Status as superscripted text against the node 
            if (!string.IsNullOrEmpty(Status))
            {
                var sz = TextRenderer.MeasureText(Status, FontManager.SideBarStatusFont);
                var rect = new RectangleF
                {
                    X = lblText.Right,
                    Y = tableLayoutPanel1.Top + sz.Height / 2,
                    Width = sz.Width + 8,
                    Height = sz.Height + 6
                };
                if (sf == null)
                {
                    sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Far;
                    sf.Alignment = StringAlignment.Center;
                }
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                var foreColorBrush = IsSelected ? pLCBrush : Brushes.White;
                var backColorBrush = IsSelected ? Brushes.White : pLCBrush;

                e.Graphics.FillRoundedRectangle(backColorBrush, rect, 8);
                e.Graphics.DrawString(Status, FontManager.SideBarStatusFont, foreColorBrush, rect, sf);
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
