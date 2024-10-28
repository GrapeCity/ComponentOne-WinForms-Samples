using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace FlexReportExplorer
{
    public class AccordionNode : Control, ISupportInitialize
    {
        public AccordionNode()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            childIndent = textLeftSpace + 30;
        }

        private int collapsedHeight = 50;
        private int textLeftSpace = 10;
        private int indicatorWidth = 3;
        private int childIndent;
        private Color indicatorColor = ColorTranslator.FromHtml("#005FB8");
        private Helper.Roles role = Helper.Roles.parent;

        private bool _isHovered;
        private bool _isSelected;
        private bool _isExpanded;
        private Color hoverBackColor = ColorTranslator.FromHtml("#F5F5F5");
        private Color chevronColor = ColorTranslator.FromHtml("#646464");

        public int TextLeftSpace { get => textLeftSpace; set => textLeftSpace = value; }
        public bool IsSelected
        {
            get => _isSelected; set => _isSelected = value;
        }
        public Helper.Roles Role { get => role; set => role = value; }

        public void AccordionNode_NodeClick(object sender, EventArgs e)
        {
            Control cnt = (Control)sender;
            var p = cnt.Parent;
            if (cnt is AccordionNode node)
            {
                var prole = node.Role;
                if (prole is Helper.Roles.parent) { }
            }
        }

        private void UpdateForeColor()
        {
            this.ForeColor = Helper.GetContrastingForeColor(this.BackColor);
            if (Role is Helper.Roles.parent)
            {
                foreach (AccordionNode child in this.Controls)
                {
                    child.ForeColor = Helper.GetContrastingForeColor(child.BackColor);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SizeF stringSize = e.Graphics.MeasureString(this.Text, this.Font);
            float y1 = (collapsedHeight - stringSize.Height) / 2;
            float y2 = collapsedHeight - y1;

            GraphicsPath path = Helper.GetRoundedCornerPath(ClientRectangle, 10);

            DrawText(e, y1, y2, stringSize);

            PaintBackground(e);

            DrawIndicator(e, y1, y2);

            DrawChevron(e, y1);
            this.Region = new Region(path);
        }

        private void DrawText(PaintEventArgs e, float y1, float y2, SizeF stringSize)
        {
            using (Brush brush = new SolidBrush(this.ForeColor))
            {
                int startingPointX = role is Helper.Roles.parent ? textLeftSpace : childIndent;

                if (stringSize.Width + startingPointX > this.Width - 100)
                {
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Trimming = StringTrimming.EllipsisCharacter;
                    stringFormat.FormatFlags = StringFormatFlags.NoWrap;
                    e.Graphics.DrawString(this.Text, this.Font, brush, new RectangleF(startingPointX, y1, 300F, y2), stringFormat);
                }
                else
                {
                    e.Graphics.DrawString(this.Text, this.Font, brush, new PointF(startingPointX, y1));
                }
            }
        }

        private void PaintBackground(PaintEventArgs e)
        {
            if (Role is Helper.Roles.parent)
            {
                this.BackColor = _isHovered ? hoverBackColor : Color.Transparent;
            }
            else if (Role is Helper.Roles.child)
            {
                bool hoverXorSelected = (_isHovered && !_isSelected) || (!_isHovered && _isSelected);
                if (hoverXorSelected)
                {
                    this.BackColor = hoverBackColor;
                }
                else this.BackColor = Color.Transparent;
            }
            UpdateForeColor();
        }

        private void DrawIndicator(PaintEventArgs e, float y1, float y2)
        {
            if (Role is Helper.Roles.parent)
            {
                if (_isHovered)
                {
                    using (Pen pen = new Pen(indicatorColor, indicatorWidth))
                    {
                        pen.StartCap = LineCap.Round;
                        pen.EndCap = LineCap.Round;
                        e.Graphics.DrawLine(pen, 5, y1, 5, y2); // Vertical line
                    }
                }
            }
            else if (Role is Helper.Roles.child)
            {
                if (_isHovered || _isSelected)
                {
                    using (Pen pen = new Pen(indicatorColor, indicatorWidth))
                    {
                        pen.StartCap = LineCap.Round;
                        pen.EndCap = LineCap.Round;
                        e.Graphics.DrawLine(pen, 5, y1, 5, y2); // Vertical line
                    }
                }
            }
        }

        private void DrawChevron(PaintEventArgs e, float y)
        {
            if (role == Helper.Roles.parent)
            {
                // Calculate center of the control on the right side for chevron placement
                int chevronCenterY = collapsedHeight / 2;
                int chevronRightX = this.Width - 20;
                int chevronThickness = 2;
                int offset = 6;
                // Draw Up and Down chevron
                if (_isExpanded)
                {
                    // Draw Chevron Up
                    using (Pen pen = new Pen(chevronColor, chevronThickness))
                    {
                        pen.StartCap = LineCap.Round;
                        pen.EndCap = LineCap.Round;
                        Point[] chevronUpPoints =
                        {
                            new Point(chevronRightX - 5, chevronCenterY), // Bottom-left
                            new Point(chevronRightX, (int)y+offset),      // Top-center
                            new Point(chevronRightX + 5, chevronCenterY)  // Bottom-right
                        };
                        e.Graphics.DrawLines(pen, chevronUpPoints);
                    }
                }
                else
                {
                    using (Pen pen = new Pen(chevronColor, chevronThickness))
                    {
                        pen.StartCap = LineCap.Round;
                        pen.EndCap = LineCap.Round;

                        Point[] chevronDownPoints =
                        {
                            new Point(chevronRightX - 5, (int)y+offset), // Top-left
                            new Point(chevronRightX, chevronCenterY),      // Bottom-center
                            new Point(chevronRightX + 5, (int)y+offset)  // Top-right
                        };
                        e.Graphics.DrawLines(pen, chevronDownPoints);
                    }
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _isExpanded = !_isExpanded;
            _isSelected = true;

            if (_isExpanded && role is Helper.Roles.parent)
            {
                AccordionArea accordionArea = (AccordionArea)this.Parent;

                accordionArea.AutoScroll = false; // !!! disable auto scroll before resize
                int _childrenCount = this.Controls.Count + 1;
                collapsedHeight = this.Height;
                ShowChildren();
                this.Size = new Size(Width, Height * (_childrenCount == 0 ? 1 : _childrenCount));
            }
            else if (!_isExpanded)
            {
                
                if (role is Helper.Roles.child) this.Size = new Size(Width, collapsedHeight);
                else
                {
                    AccordionArea accordionArea = (AccordionArea)this.Parent;
                    accordionArea.AutoScroll = false;
                    this.Size = new Size(Width, collapsedHeight);
                    accordionArea.AutoScroll = true;
                }
            }
        }

        private void ShowChildren()
        {
            if (Role is Helper.Roles.parent)
            {
                for (int i = 1; i < this.Controls.Count; i++)
                {
                    Control child = this.Controls[i];
                    child.ForeColor = Helper.GetContrastingForeColor(child.BackColor);
                    child.Location = new Point(child.Location.X, collapsedHeight * (child.TabIndex + 1));
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnClick(e);
            OnClick(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode) collapsedHeight = this.Height;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            try
            {
                AccordionNode assumedChildNode = (AccordionNode)e.Control;

                if (assumedChildNode.Role is Helper.Roles.parent)
                {
                    this.Controls.Remove(assumedChildNode);
                    MessageBox.Show("Cannot add child to child");
                }
                else
                {
                    assumedChildNode.Name = assumedChildNode.Text.ToLower();
                    assumedChildNode.ForeColor = Helper.GetContrastingForeColor(assumedChildNode.BackColor);
                    assumedChildNode.Location = new Point(0, collapsedHeight * (assumedChildNode.TabIndex + 1));
                    UpdateForeColor();
                }
            }
            catch (Exception) { }
        }

        public void BeginInit()
        {

        }

        public void EndInit()
        {
            collapsedHeight = this.Height;
        }
    }
    // --------------------------------------------------------------------------------------------------------------
    public class AccordionArea : Panel
    {
        private int nodeCollapseHeight = 50;

        private string previousChildName = "";
        private Color scrollBarColor = ColorTranslator.FromHtml("#005FB8");
        private bool _showScrollBar = false;
        private int scrollJump = 50;
        private int thumbPositionY = 0;
        int _thumbHeight = 50;
        HandledMouseEventArgs mouseEventArgs;

        private int _contentHeight;

        public int NodeCollapseHeight { get => nodeCollapseHeight; set => nodeCollapseHeight = value; }
        public int ContentHeight { get => _contentHeight; set => _contentHeight = value; }

        public event EventHandler ChildClickedEvent;

        public AccordionArea()
        {
            this.DoubleBuffered = true;
            this.AutoScroll = true;
            this.MouseWheel += AccordionArea_Scroll;
            this.Font = new Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        protected virtual void OnChildClickedEvent(object sender, EventArgs e)
        {
            ChildClickedEvent?.Invoke(sender, e);
        }

        private void AccordionArea_Scroll(object sender, EventArgs e)
        {
            mouseEventArgs = (HandledMouseEventArgs)e;
            UpdateScrollBarPosition((HandledMouseEventArgs)e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //DrawScrollBar(e);
        }

        private void DrawScrollBar(PaintEventArgs e)
        {
            if (_showScrollBar)
            {
                using (Pen pen = new Pen(scrollBarColor, 5))
                {
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;
                    int x = this.Width - 2;
                    e.Graphics.DrawLine(pen, new Point(x, thumbPositionY), new Point(x, thumbPositionY + _thumbHeight));
                };
            }
        }

        private void UpdateScrollBarPosition(HandledMouseEventArgs e)
        {
            if (_showScrollBar)
            {
                int delta = e.Delta;
                // Negative delta means scroll down
                if (delta < 0)
                {
                    thumbPositionY = thumbPositionY + ((Math.Abs(delta) / 120) * scrollJump);
                }
                else
                {
                    thumbPositionY = thumbPositionY - ((delta / 120) * scrollJump);
                    if (thumbPositionY < 0) thumbPositionY = 0;
                }

                if ((thumbPositionY + _thumbHeight) > this.Height)
                {
                    thumbPositionY = thumbPositionY - scrollJump;
                }
            }
            else thumbPositionY = 0;
            Invalidate();
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            if (e.Control is AccordionNode node)
            {
                base.OnControlAdded(e);
                if (!this.DesignMode)
                {
                    PostionNewNode(node);
                }
                if (node.Role == Helper.Roles.parent)
                {
                    node.SizeChanged += ParentNodeSizeChanged;
                    node.Size = new Size(node.Parent.Width, nodeCollapseHeight);
                    node.Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point);
                    foreach (AccordionNode childNode in node.Controls)
                    {
                        // Subscribe to child node click
                        childNode.Click += ChildNodeClicked;
                        childNode.Size = new Size(node.Width, nodeCollapseHeight);
                        childNode.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    }
                }
            }
            else
            {
                this.Controls.Remove(e.Control);
                MessageBox.Show("Invalid child. Only AccordionNode Accepted");
            }
        }

        private void ParentNodeSizeChanged(object sender, EventArgs e)
        {
            RearrangeNodeLocation(sender);
        }

        private void ChildNodeClicked(object sender, EventArgs e)
        {
            ChildClickedEvent?.Invoke(sender, e);
            try
            {
                UnSelectPrevious(((AccordionNode)sender));
            }
            catch { }
        }

        private void UnSelectPrevious(AccordionNode clickedNode)
        {
            if (!string.IsNullOrEmpty(previousChildName))
            {
                foreach (Control control in this.Controls)
                {
                    if (control is AccordionNode parentNode)
                    {
                        foreach (AccordionNode childNode in parentNode.Controls)
                        {
                            if (childNode.Text == previousChildName)
                            {
                                childNode.IsSelected = !childNode.IsSelected;
                                childNode.Invalidate();
                            }
                        }
                    }
                }
            }
            previousChildName = clickedNode.Text;
        }

        private void RearrangeNodeLocation(object sender)
        {
            AccordionNode clickedParentNode = sender as AccordionNode;
            string clickedParentNodeText = clickedParentNode.Text;

            Point pos = clickedParentNode.Location;

            List<int> heights = new List<int>();
            this.Controls[0].Location = new Point(0, 0);
            for (int i = 0; i < this.Controls.Count; i++)
            {
                heights.Add(this.Controls[i].Height);
            }

            for (int i = 0; i < this.Controls.Count; i++)
            {
                int newHeight = heights.GetRange(0, i).Sum();
                this.Controls[i].Location = new Point(0, newHeight);
                // set scroll position to selected parent node
                if (this.Controls[i].Text == clickedParentNodeText)
                {
                    pos = this.Controls[i].Location;
                }
            }

            this.AutoScroll = true;
            this.AutoScrollPosition = pos;

            _contentHeight = heights.Sum();
            _thumbHeight = this.Height * this.Height / heights.Sum();
            ShowHideScrollBar(heights.Sum());
            this.AutoScroll = true;
        }

        private void ShowHideScrollBar(int contentHeight)
        {
            if (contentHeight > this.Height)
            {
                _showScrollBar = true;

            }
            else _showScrollBar = false;
            Invalidate();
        }

        private void PostionNewNode(AccordionNode node)
        {
            node.Location = new Point(0, node.TabIndex * nodeCollapseHeight);
        }
        /// <summary>
        /// Hide native scrollbar
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const int WM_NCPAINT = 0x85;   // Message for non-client area paint (scrollbars are part of this)
            const int WM_NCCALCSIZE = 0x83; // Message for non-client area size calculation

            // Suppress the drawing of scrollbars by intercepting WM_NCPAINT
            if (m.Msg == WM_NCPAINT || m.Msg == WM_NCCALCSIZE)
            {
                return; // Suppress native scrollbar drawing
            }

            base.WndProc(ref m);
        }
    }
}