using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Main
{
    public class FeatureStack : Panel
    {
        #region fields
        private bool onItem = false;
        private Padding itemPadding;
        private Font selectedFont;
        private Font hoverFont;
        private Color selectedBackColor;
        private Color selectedForeColor;
        private Color hoverBackColor;
        private Color hoverForeColor;
        private SolidBrush selectedBackColorBrush;
        private SolidBrush selectedForeColorBrush;
        private SolidBrush hoverBackColorBrush;
        private SolidBrush hoverForeColorBrush;
        private SolidBrush foreColorBrush;

        private ControlData _control;
        private FeatureStackItem _selectedItem;

        #endregion

        #region properties

        public List<FeatureStackItem> Items
        {
            get; private set;
        }

        public FeatureStackItem SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            private set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    for ( int i = 0; i < Items.Count; i++)
                    {
                        var item = Items[i];
                        item.Selected = (item == _selectedItem);
                    }
                    RenderFeatureStack();
                }
            }
        }

        public Color HoverBackColor
        {
            get
            {
                return hoverBackColor;
            }
            set
            {
                if (hoverBackColor != value)
                {
                    hoverBackColor = value;
                    hoverBackColorBrush = new SolidBrush(hoverBackColor);
                    RenderFeatureStack();
                }
            }
        }
        public Color HoverForeColor
        {
            get
            {
                return hoverForeColor;
            }
            set
            {
                if (hoverForeColor != value)
                {
                    hoverForeColor = value;
                    hoverForeColorBrush = new SolidBrush(hoverForeColor);
                    RenderFeatureStack();
                }
            }
        }
        public Font HoverFont
        {
            get
            {
                return hoverFont;
            }
            set
            {
                if (value != hoverFont)
                {
                    hoverFont = value;
                    RenderFeatureStack();
                }
            }
        }

        public Color SelectedBackColor
        {
            get
            {
                return selectedBackColor;
            }
            set
            {
                if (selectedBackColor != value)
                {
                    selectedBackColor = value;
                    selectedBackColorBrush = new SolidBrush(selectedBackColor);
                    RenderFeatureStack();
                }
            }
        }
        public Color SelectedForeColor
        {
            get
            {
                return selectedForeColor;
            }
            set
            {
                if (selectedForeColor != value)
                {
                    selectedForeColor = value;
                    selectedForeColorBrush = new SolidBrush(selectedForeColor);
                    RenderFeatureStack();
                }
            }
        }
        public Font SelectedFont
        {
            get
            {
                return selectedFont;
            }
            set
            {
                if (value != selectedFont)
                {
                    selectedFont = value;
                    RenderFeatureStack();
                }
            }
        }
        public Padding ItemPadding
        {
            get
            {
                return itemPadding;
            }
            set
            {
                if (itemPadding != value)
                {
                    itemPadding = value;
                    RenderFeatureStack();
                }
            }
        }

        #endregion

        #region events

        public delegate void FeatureStackEventDelegate(object sender, FeatureStackEventArgs e);
        public event FeatureStackEventDelegate ItemAdded;
        public event FeatureStackEventDelegate ItemRemoved;
        public event FeatureStackEventDelegate ItemClicked;
        public event FeatureStackEventDelegate MouseOverItem;

        #endregion

        public FeatureStack()
        {
            Items = new List<FeatureStackItem>();
            selectedFont = hoverFont = Font;
            selectedBackColor = hoverBackColor = BackColor;
            selectedForeColor = hoverForeColor = ForeColor;
            selectedBackColorBrush = hoverBackColorBrush = new SolidBrush(BackColor);
            foreColorBrush = selectedForeColorBrush = hoverForeColorBrush = new SolidBrush(ForeColor);
            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = true;
        }

        #region methods

        public void loadSamples(ControlData control)
        {
            if (control != null && control != _control)
            {
                _control = control;
                if (_control.Features.Count > 0)
                {
                    Items.Clear();
                    foreach (SampleData sample in control.Features)
                    {
                        FeatureStackItem item = AddItem(sample.Name);
                        item.Tag = sample;
                        item.Selected = false;
                    }
                    var first = Items.First();
                    first.Selected = true;
                    _selectedItem = first;
                }
            }
            if (ItemClicked != null)
            {
                ItemClicked(this, new FeatureStackEventArgs(_selectedItem));
            }

        }

        public FeatureStackItem AddItem(string value)
        {
            FeatureStackItem item = new FeatureStackItem()
            {
                Value = value
            };
            Items.Add(item);
            OnItemAdded(Items.Last());
            return Items.Last();
        }

        public void RemoveItem(string id)
        {
            if (Items.Count(it => it.ID == id) > 0)
            {
                RemoveItems(Items.First(i => i.ID == id));
            }
            else
            {
                throw new Exception("Cannot find item");
            }
        }

        public void RemoveItems(FeatureStackItem featureStackItem)
        {
            if (Items.Count(it => it.ID == featureStackItem.ID) > 0)
            {
                Items.Remove(featureStackItem);
                OnItemRemoved(featureStackItem);
            }
            else
            {
                throw new Exception("Cannot find item");
            }
        }

        #endregion

        #region overrides/events

        private void OnItemAdded(FeatureStackItem item)
        {
            if (ItemAdded != null)
            {
                ItemAdded(this, new FeatureStackEventArgs(item));
            }
            RenderFeatureStack();
        }

        private void OnItemRemoved(FeatureStackItem item)
        {
            if (ItemRemoved != null)
            {
                ItemRemoved(this, new FeatureStackEventArgs(item));
            }
            RenderFeatureStack();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
            #region paint
            foreach (var item in Items)
            {
                if (item.Hover)
                {
                    g.FillRectangle(hoverBackColorBrush, item.HoverRegion);
                    g.DrawString(item.Value, this.HoverFont, hoverForeColorBrush, item.TextRegion);
                }
                if (item.Selected)
                {
                    g.FillPolygon(selectedBackColorBrush, item.SelectedRegion);
                    g.DrawString(item.Value, this.SelectedFont, selectedForeColorBrush, item.TextRegion);
                }
                if (! item.Hover && !item.Selected)
                {
                    g.DrawString(item.Value, this.Font, foreColorBrush, item.TextRegion);
                }
            }
            #endregion
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            FeatureStackItem fs = GetItemUnder(e.Location);
            if (fs != null)
            {
                SelectedItem = fs;
                if (ItemClicked != null)
                {
                    ItemClicked(this, new FeatureStackEventArgs(fs));
                }
                RenderFeatureStack();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            FeatureStackItem fs = GetItemUnder(e.Location);
            if (fs != null)
            {
                if (!fs.Hover)
                {
                    Items.ForEach((item) =>
                    {
                        item.Hover = false;
                    });
                    fs.Hover = true;
                    RenderFeatureStack();
                }
                if (MouseOverItem != null)
                {
                    MouseOverItem(this, new FeatureStackEventArgs(fs));
                }
                onItem = false;
            }
            else
            {
                if (!onItem)
                {
                    Items.ForEach((item) =>
                    {
                        item.Hover = false;
                    });
                    if (!onItem)
                        RenderFeatureStack();
                    onItem = true;
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RenderFeatureStack();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            RenderFeatureStack();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Items.ForEach((item) =>
            {
                item.Hover = false;
            });
            RenderFeatureStack();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            foreColorBrush = new SolidBrush(this.ForeColor);
        }

        // double buffering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        #endregion

        #region internals

        public static readonly object locker = new object();

        void RenderFeatureStack()
        {
            lock (locker)
            {
                float maxheight = 0f;
                float maxwidth = 0f;
                float currtop = this.Padding.Top;

                using (Graphics g = this.CreateGraphics())
                {
                    foreach (FeatureStackItem item in Items.ToList())
                    {
                        float height = g.MeasureString(item.Value, this.Font).Height;
                        if (height > maxheight)
                        {
                            maxheight = height;
                        }
                        float width = g.MeasureString(item.Value, this.Font).Width;
                        if (width > maxwidth)
                        {
                            maxwidth = width;
                        }
                    }
                }

                foreach (FeatureStackItem item in Items.ToList())
                {
                    RectangleF rect;
                    RectangleF recttxt;
                    PointF[] points;
                    float left, top, width, height;
                    float lefttxt, toptxt, widthtxt, heighttxt;

                    height = this.ItemPadding.Top + this.ItemPadding.Bottom + maxheight;
                    top = currtop;
                    left = this.Padding.Left;
                    float adjustedWidth = maxwidth + this.itemPadding.Left + this.itemPadding.Right + height / 2 + 100;
                    if (adjustedWidth < this.Width)
                    {
                        width = adjustedWidth;
                    }
                    else
                    {
                        width = this.Width - this.Padding.Left - this.Padding.Right - height / 2;
                    }

                    toptxt = top + this.itemPadding.Top;
                    lefttxt = left + this.itemPadding.Left;
                    widthtxt = width - this.itemPadding.Left - this.Padding.Right;
                    heighttxt = height - this.itemPadding.Top - this.Padding.Bottom;

                    rect = new RectangleF(left, top, width, height);
                    recttxt = new RectangleF(lefttxt, toptxt, widthtxt, heighttxt);
                    points = new PointF[]
                    {
                        new PointF(rect.Left, rect.Top),
                        new PointF(rect.Right, rect.Top),
                        new PointF(rect.Right + height/2, rect.Top + height/2),
                        new PointF(rect.Right, rect.Bottom),
                        new PointF(rect.Left, rect.Bottom)
                    };

                    item.HoverRegion = rect;
                    item.TextRegion = recttxt;
                    item.SelectedRegion = points;
                    currtop = item.HoverRegion.Bottom;
                }

                // Calculate bottom to decide AutoScrollMinSize
                var totalHeight = currtop + this.Padding.Bottom + this.Margin.Bottom;
                this.AutoScrollMinSize = new Size(this.Width, Convert.ToInt16(totalHeight));
            }
            Invalidate();

        }

        private FeatureStackItem GetItemUnder(PointF location)
        {
            location = AdjustScrollOffset(location);
            foreach (var item in Items)
            {
                if (IsPointInRectangle(location, item.SelectedRegion))
                {
                    return item;
                }
            }
            return null;
        }

        private PointF AdjustScrollOffset(PointF location)
        {
            return new PointF(
                    location.X - this.AutoScrollPosition.X,
                    location.Y - this.AutoScrollPosition.Y
                );
        }

        private bool IsPointInRectangle(PointF point, PointF[] polygon)
        {
            int polygonLength = polygon.Length, i = 0;
            bool inside = false;
            // x, y for tested point.
            float pointX = point.X, pointY = point.Y;
            // start / end point for the current polygon segment.
            float startX, startY, endX, endY;
            PointF endPoint = polygon[polygonLength - 1];
            endX = endPoint.X;
            endY = endPoint.Y;
            while (i < polygonLength)
            {
                startX = endX; startY = endY;
                endPoint = polygon[i++];
                endX = endPoint.X; endY = endPoint.Y;
                //
                inside ^= (endY > pointY ^ startY > pointY) /* ? pointY inside [startY;endY] segment ? */
                          && /* if so, test if it is under the segment */
                          ((pointX - endX) < (pointY - endY) * (startX - endX) / (startY - endY));
            }
            return inside;
        }

        #endregion
    }

    public class FeatureStackItem
    {
        private string val;
        private bool selected;
        private bool hover;
        private RectangleF region;

        public string ID { get; private set; }

        public string Value
        {
            get
            {
                return val;
            }
            set
            {
                if(value != val)
                {
                    val = value;
                }
            }
        }

        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                if (value != selected)
                {
                    selected = value;
                }
            }
        }
        public bool Hover
        {
            get
            {
                return hover;
            }
            set
            {
                if (value != hover)
                {
                    hover = value;
                }
            }
        }

        public RectangleF HoverRegion
        {
            get
            {
                return region;
            }
            set
            {
                if (value != region)
                {
                    region = value;
                }
            }
        }

        public PointF[] SelectedRegion
        {
            get; set;
        }

        public RectangleF TextRegion { get; set; }

        public object Tag
        {
            get; set;
        }

        public FeatureStackItem()
        {
            ID = Guid.NewGuid().ToString();
        }

    }

    public class FeatureStackEventArgs : EventArgs
    {
        public FeatureStackItem FeatureStackItem { get; private set; }

        public FeatureStackEventArgs(FeatureStackItem item)
        {
            FeatureStackItem = item;
        }
    }
}
