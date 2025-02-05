using C1.Framework;
using ControlExplorer.Core;
using ControlExplorer.Utilities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    public delegate void StackNodeEventHandler(object sender, StackNodeEventArgs e);
    public partial class StackNodeControl : UserControl
    {
        #region events
        public event StackNodeEventHandler StackNodeClick;
        #endregion

        #region fields

        private C1Icon _collapsedIcon;
        private C1Icon _icon;
        private StackedNodeCollection _nodes;
        private int _level;
        private bool isExpanded;
        private bool _filtered = true;
        private bool _isVisible = false;
        private bool isHovered = false;

        #endregion
        public string IconKey { get; set; }
        public string ExpandedKey { get; set; }
        public string CollapsedKey { get; set; }
        public new Color BackColor { get; set; }
        public C1Icon ExpandedIcon { get; set; }
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
        public C1Icon CollapsedIcon
        {
            get
            { return this._collapsedIcon; }
            set
            {
                _collapsedIcon = value;
                if (!this.isExpanded)
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
        public StackTreeControl StackedTree
        { get; internal set; }
        public StackNodeControl ParentNode
        { get; internal set; }
        public string Key { get; set; }
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
            panel1.Paint += DrawMenuCount;
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
                if (isHovered) { DrawBorder(e); }
            }
        }

        private void DrawIndicator(PaintEventArgs e)
        {
            using (Pen roundedPen = new Pen(SkinManager.C1Color, 4))
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

        private void DrawMenuCount(object sender, PaintEventArgs e)
        {
            ItemInfo item = this.Tag as ItemInfo;
            if (item.Menus == null) return;

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int panelWidth = panel1.Width;
            int panelHeight = panel1.Height;

            int circleDiameter = Math.Min(panelWidth, panelHeight) * 2 / 3;

            int circleX = (panelWidth - circleDiameter) / 2;
            int circleY = (panelHeight - circleDiameter) / 2;

            SolidBrush circleBrush = new SolidBrush(Color.FromArgb(231, 230, 230));
            Brush textBrush = SystemBrushes.ControlText;
            if (IsSelected)
            {
                circleBrush = new SolidBrush(SkinManager.C1Color);
                textBrush = new SolidBrush(Color.White);
            }

            graphics.FillEllipse(circleBrush, circleX, circleY, circleDiameter, circleDiameter);

            string number = item.Menus.Count.ToString();
            Font numberFont = new Font("SegoeUI", 10, FontStyle.Regular);
            SizeF numberSize = graphics.MeasureString(number, numberFont);

            float numberX = circleX + (circleDiameter - numberSize.Width) / 2;
            float numberY = circleY + (circleDiameter - numberSize.Height) / 2;

            graphics.DrawString(number, numberFont, textBrush, numberX, numberY);
        }

        private int UnitHeight()
        {
            return this.lblText.Parent.Height;
        }
        private void PerformExpandCollapse()
        {
            btnChevron.Icon = this.isExpanded ? ExpandedIcon : CollapsedIcon;
            btnChevron.Refresh();

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
                ItemInfo sample = node.Tag as ItemInfo;
                this.StackNodeClick(this.StackedTree, new StackNodeEventArgs(ClosestFunctionalLeaf(sample, node)));
            }
        }

        private StackNodeControl ClosestFunctionalLeaf(ItemInfo selectedSample, StackNodeControl e)
        {
            ItemInfo selectedItem = selectedSample;
            StackNodeControl selectedNode = e;

            while (selectedItem.AssemblyName.IsNullOrEmpty())
            {
                if (selectedItem.Items.IsNullOrEmpty())
                {
                    selectedItem = selectedItem.Menus.FirstOrDefault();
                }
                else
                {
                    selectedItem = selectedItem.Items.FirstOrDefault();
                }
                selectedNode = selectedNode.Nodes.FirstOrDefault(node => node.Key == selectedItem.Guid.ToString()) ?? selectedNode;
            }
            return selectedNode;
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
