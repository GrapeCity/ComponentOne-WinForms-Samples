using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace StockAnalysis
{
    class DropPanel : Panel
    {
        int usedHeight = 0;
        int usedWidth = 0;

        List<Control[]> controlRows = new List<Control[]>();
        public Size DefaultControlSize { get; set; }

        // add a set of controls to a line the panel
        public void Add(params Control[] ctrls)
        {
            int requiredWidth = Padding.Left + Padding.Right;
            int requiredHeight = 0;
            bool zeroWidth = false;
            controlRows.Add(ctrls);

            foreach (Control c in ctrls)
            {
                requiredWidth += c.Width;
                if (c.Height > requiredHeight)
                    requiredHeight = c.Height;
                if (c.Width == 0) zeroWidth = true;

                PropertyInfo pi = c.GetType().GetProperty("AutoSize");
                if (pi != null) pi.SetValue(c, false, null);
            }

            if (zeroWidth || requiredWidth == 0)
                requiredWidth = DefaultControlSize.Width;

            if (requiredWidth > usedWidth)
                usedWidth = requiredWidth;

            usedHeight += requiredHeight > 0 ? requiredHeight : DefaultControlSize.Height;
        }

        public void AddSeparator()
        {
            // add a gray bar
            usedHeight += 3;
            controlRows.Add( new Control[]
            { 
                new Panel() { Size = Size.Empty, ForeColor = Color.LightGray, BackColor = Color.LightGray, }
            });
            
            // add space.
            usedHeight += 10;
            controlRows.Add(new Control[]
            {
                new Panel() { Size = new Size(0,10), ForeColor = Color.Transparent, BackColor = Color.Transparent, }
            });
        }

        /// <summary>
        /// Fills the panel with added controls, sized and place as requested.
        /// </summary>
        public void Setup()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;

            int currentRowPosition = Padding.Top;
            foreach (Control[] ctrls in controlRows)
            {
                if (ctrls.Length == 1)
                {
                    if (ctrls[0] is Panel && ctrls[0].Size.IsEmpty)
                    {
                        ctrls[0].Location = new Point(0, currentRowPosition+1);
                        ctrls[0].Size = new Size(usedWidth, 1);
                        currentRowPosition += 3;
                        Controls.Add(ctrls[0]);
                    }
                    else if (ctrls[0] != null)
                    {
                        int w = usedWidth - Padding.Left - Padding.Right;
                        int h = ctrls[0].Height > 0 ? ctrls[0].Height : DefaultControlSize.Height;
                        ctrls[0].Location = new Point(Padding.Left, currentRowPosition);
                        ctrls[0].Size = new Size(w, h);
                        currentRowPosition += h + 1;
                        Controls.Add(ctrls[0]);
                    }
                }
                else
                {
                    int currentColPosition = Padding.Left;
                    int requiredWidth = 0, requiredHeight = 0;

                    foreach (Control c in ctrls)
                    {
                        requiredWidth += c.Width;
                        if (c.Height > requiredHeight)
                            requiredHeight = c.Height;
                    }

                    foreach (Control c in ctrls)
                    {
                        if (c.Width == 0)
                            c.Width = usedWidth - requiredWidth - Padding.Left - Padding.Right;

                        if (c.Height == 0)
                            c.Height = (usedHeight > 0) ? usedHeight : DefaultControlSize.Height;
                        else
                            c.Location = new Point(currentColPosition,
                                currentRowPosition + (requiredHeight - c.Height -1) / 2);
                        currentColPosition += c.Width;

                        Controls.Add(c);
                    }

                    currentRowPosition += requiredHeight;
                }
            }

            Size = new Size(usedWidth, usedHeight + Padding.Top + Padding.Bottom);

            if (Parent != null)
            {
                parentMinSize = this.Parent.MinimumSize;
                parentMaxSize = this.Parent.MaximumSize;
            }
        }

        Size parentMinSize = Size.Empty;
        Size parentMaxSize = Size.Empty;
        static DropPanel visibleDropPanel = null;

        protected override void OnVisibleChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                if (Visible)
                {
                    visibleDropPanel = this;
                    parentMinSize = this.Parent.MinimumSize;
                    parentMaxSize = this.Parent.MaximumSize;
                    this.Parent.MinimumSize = this.Parent.MaximumSize = this.Parent.Size;
                }

                base.OnVisibleChanged(e);

                if (!Visible)
                {
                    this.Parent.MinimumSize = parentMinSize;
                    this.Parent.MaximumSize = parentMaxSize;
                    visibleDropPanel = null;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.LightGray,
                new Rectangle(Point.Empty, new Size(ClientSize.Width-1, ClientSize.Height - 1)));
        }

        public void PositionDropPanel(Control cc)    //, Size offset)
        {
            Control c = cc;
            Point point = c.Location;
            while (c.Parent != null && c.Parent != this.Parent)
            {
                point = new Point(point.X + c.Parent.Left, point.Y + c.Parent.Top);
                c = c.Parent;
            }

            Point p = Point.Empty;
            if (point.X + this.Width < this.Parent.ClientSize.Width)
                p.X = point.X - cc.Margin.Left;
            else
                p.X = point.X + cc.Width - this.Width + cc.Margin.Right;

            if (point.Y + cc.Height + this.Height < this.Parent.ClientSize.Height)
                p.Y = point.Y + cc.Height + cc.Margin.Bottom;
            else
                p.Y = point.Y - cc.Height - cc.Margin.Top;

            Location = p;
        }

        public void PanelButtonClick(Button b)
        {
            if (Visible)
                Visible = false;
            else
            {
                if (visibleDropPanel != null)
                    visibleDropPanel.Visible = false;

                PositionDropPanel(b);
                Visible = true;
            }
        }

        static public void CloseActivePanelClickHandler(object sender, EventArgs e)
        {
            if (visibleDropPanel != null)
                visibleDropPanel.Visible = false;
        }

        public T GetControl<T>(string name) where T:class
        {
            return Controls[name] as T;
        }
    }
}
