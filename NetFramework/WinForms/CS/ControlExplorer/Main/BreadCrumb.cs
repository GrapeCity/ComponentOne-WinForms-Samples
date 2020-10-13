using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.Util;

namespace ControlExplorer.Main
{
    public class BreadCrumb : Control
    {
        #region fields

        private Color _bgColor;
        private Color _bgColor2;
        private Point _mouseLocation;
        private Image _homeImage = null;
        private Color _foreColor;
        private Color _foreColor2;
        private FlatIcon _homeIcon;
        private ImageRecolorer _recolorer = new ImageRecolorer();
        #endregion

        #region events
        public delegate void BreadCrumbEventDelegate(object sender, BreadCrumbEventArgs e);
        public event BreadCrumbEventDelegate ItemAdded;
        public event BreadCrumbEventDelegate ItemRemoved;
        public event BreadCrumbEventDelegate ItemClicked;
        #endregion

        #region properties

        public List<BreadCrumbItem> Items
        {
            get; private set;
        }
        public new Color BackColor
        {
            get
            {
                return _bgColor;
            }
            set
            {
                if (_bgColor != value)
                {
                    _bgColor = value;
                    RenderBreadCrumb();
                }
            }
        }
        public Color BackColor2
        {
            get
            {
                return _bgColor2;
            }
            set
            {
                if (_bgColor2 != value)
                {
                    _bgColor2 = value;
                    RenderBreadCrumb();
                }
            }
        }
        public new Color ForeColor
        {
            get
            {
                return _foreColor;
            }
            set
            {
                if (_foreColor != value)
                {
                    _foreColor = value;
                    _recolorer.ChannelWhite = _foreColor;
                    if(_homeIcon != null)
                        _homeIcon.Foreground = _foreColor;
                    RenderBreadCrumb();
                }
            }
        }

        public Color ForeColor2
        {
            get
            {
                return _foreColor2;
            }
            set
            {
                if (_foreColor2 != value)
                {
                    _foreColor2 = value;
                    RenderBreadCrumb();
                }
            }
        }

        public Image HomeImage
        {
            get
            {
                if (_homeIcon != null)
                    return _homeIcon.Image;
                else
                    return _homeImage;
            }
            set
            {
                if(_homeImage != value)
                {
                    if (value.Width < this.Height && value.Height < this.Height)
                    {
                        _homeImage = value;
                        _homeIcon = new FlatIcon(value) { Recolorer = _recolorer, Foreground = ForeColor };
                        Invalidate(
                            new Rectangle(
                                (int)Home.Point0.X,
                                (int)Home.Point0.Y,
                                (int)Home.Point2.X,
                                (int)Home.Point3.Y)
                                );
                    }
                    else
                    {
                        throw new Exception("Image Size should accomodate inside the first bread crumb item ");
                    }
                }
            }
        }
        public BreadCrumbItem Home
        {
            get
            {
                return Items.First(item=> item.Value == "Home");
            }
        }
        public bool ModifyColorForVisibility { get; set; }
        #endregion

        public BreadCrumb()
        {
            Items = new List<BreadCrumbItem>();
            Dock = DockStyle.Fill;
            AddItem("Home");
            ForeColor = Color.White;
            ModifyColorForVisibility = true;
        }

        #region methods

        public BreadCrumbItem AddItem(string value)
        {
            BreadCrumbItem item = new BreadCrumbItem()
            {
                ID = Guid.NewGuid().ToString(),
                Value = value,
                Level = Items.Count()
            };
            Items.Add(item);
            OnItemAdded(Items.Last());
            return item;
        }
        public void RemoveItemsAfter(BreadCrumbItem item)
        {
            Items.Sort();
            if (Items.Contains(item))
            {
                while(Items.Last().ID!= item.ID)
                {
                    Items.Remove(Items.Last());
                }
                RenderBreadCrumb();
                return;
            }
            throw new Exception("Cannot find item");
        }
        public BreadCrumbItem RemoveItems(BreadCrumbItem item)
        {
            Items.Sort();
            if (Items.Contains(item))
            {
                if (Items.Count(it => it.ID == item.ID) > 0)
                {
                    BreadCrumbItem i = Items.Last();
                    Items.Remove(i);
                    while (Items.Count > 0 && i.ID != item.ID)
                    {
                        i = Items.Last();
                        Items.Remove(i);
                        OnItemRemoved(i);
                    }
                    return i;
                }
            }
            throw new Exception("Cannot find item");
        }
        public BreadCrumbItem RemoveItems(string id)
        {
            if(Items.Count(it=> it.ID == id) > 0)
            {
                return RemoveItems(Items.First(i=>i.ID == id));
            }
            throw new Exception("Cannot find item");
        }

        public BreadCrumbItem RemoveTop()
        {
            if(Items.Count > 0)
            {
                return RemoveItems(Items.Last());
            }
            throw new Exception("Cannot find item");
        }
        #endregion

        #region overrides/events
        private void OnItemAdded(BreadCrumbItem item)
        {
            if (ItemAdded != null)
            {
                ItemAdded(this, new BreadCrumbEventArgs(item));
            }
            RenderBreadCrumb();
        }
        private void OnItemRemoved(BreadCrumbItem item)
        {
            if (ItemRemoved != null)
            {
                ItemRemoved(this, new BreadCrumbEventArgs(item));
            }
            RenderBreadCrumb();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            #region paint
            g.FillPolygon(new SolidBrush(BackColor), Items.First().Region);
            if (HomeImage != null)
            {
                int h, w;
                h = w = this.Height;
                Point imgPoint = new Point((w - HomeImage.Size.Width) / 2, (h - HomeImage.Size.Height) / 2);
                Rectangle imgrect = new Rectangle(imgPoint, HomeImage.Size);
                g.DrawImage(HomeImage, imgrect);
            }
            foreach (var item in Items.Where(it=> it.Value != "Home"))
            {
                //if (item.PaintRequired)
                //{
                if (item.Level % 2 == 0)
                {
                    g.FillPolygon(new SolidBrush(BackColor), item.Region);
                    g.DrawString(item.Value, this.Font, new SolidBrush(this.ForeColor), item.TextLocation);
                }
                else
                {
                    g.FillPolygon(new SolidBrush(BackColor2), item.Region);
                    g.DrawString(item.Value, this.Font, new SolidBrush(this.ForeColor2), item.TextLocation);
                }
                //}
                //item.PaintRequired = false;
            }
            #endregion

        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RenderBreadCrumb();
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            RenderBreadCrumb();
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            BreadCrumbItem bc = GetItemUnder(e.Location);
            if (bc != null)
            {
                if (ItemClicked != null)
                {
                    ItemClicked(this, new BreadCrumbEventArgs(bc));
                }
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            try {
                if (e.X > Items.Last().Point1.X && !IsPointInPolygon(e.Location, Items.Last().Region))
                {
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    this.Cursor = Cursors.Hand;
                }
            }
            catch { }
        }
        #endregion

        #region internals
        private void RenderBreadCrumb(int x = -1, int y = -1)
        {
            _mouseLocation = new Point(x, y);

            int h = this.Height;
            int xof = this.Height;

            Items.First().Point0 = new PointF(0, 0);
            Items.First().Point1 = new PointF(0 + xof, 0);
            Items.First().Point2 = new PointF(0 + xof + h / 2, h / 2);
            Items.First().Point3 = new PointF(0 + xof, h);
            Items.First().Point4 = new PointF(0, h);
            Items.First().Point5 = new PointF(0, h / 2);
            if (Items.Count > 1)
            {
                Items.Sort();
                BreadCrumbItem lastItem = Items[0];
                foreach (BreadCrumbItem item in Items.ToList())
                {
                    if (item.Value != "Home")
                    {
                        float p1 = lastItem.Region[1].X;
                        float p2 = lastItem.Region[2].X;
                        float p3 = lastItem.Region[3].X;

                        SizeF size;
                        using (Graphics g = this.CreateGraphics())
                        {
                            size = g.MeasureString(item.Value, this.Font);
                        }
                        float padding = (h - size.Height) / 2;
                        float xoffset = size.Width + padding * 2;
                        item.Point0 = new PointF(p1, 0);
                        item.Point1 = new PointF(p1 + xoffset, 0);
                        item.Point2 = new PointF(p2 + xoffset, h / 2);
                        item.Point3 = new PointF(p3 + xoffset, h);
                        item.Point4 = new PointF(p3, h);
                        item.Point5 = new PointF(p2, h / 2);
                        //item.Region = points;
                        item.TextLocation = new PointF(p2 + padding, padding);
                    }
                    lastItem = item;
                }
            }
            Invalidate();
        }
        private BreadCrumbItem GetItemUnder(PointF location)
        {
            foreach(var item in Items)
            {
                if(IsPointInPolygon(location, item.Region))
                {
                    return item;
                }
            }
            return null;
        }
        private bool IsPointInPolygon(PointF point, PointF[] polygon)
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

    public class BreadCrumbItem : IComparable
    {
        public bool PaintRequired = true;
        private string val;
        private PointF textLocation;
        private PointF point0 = new PointF(-1, -1);
        private PointF point1 = new PointF(-1, -1);
        private PointF point2 = new PointF(-1, -1);
        private PointF point3 = new PointF(-1, -1);
        private PointF point4 = new PointF(-1, -1);
        private PointF point5 = new PointF(-1, -1);

        public string ID { get; internal set; }
        public int Level { get; set; }
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
                    PaintRequired = true;
                }
            }
        }
        public PointF Point0
        {
            get
            {
                return point0;
            }
            set
            {
                if (value != point0)
                {
                    point0 = value;
                    PaintRequired = true;
                }
            }
        }
        public PointF Point1
        {
            get
            {
                return point1;
            }
            set
            {
                if (value != point1)
                {
                    point1 = value;
                    PaintRequired = true;
                }
            }
        }
        public PointF Point2
        {
            get
            {
                return point2;
            }
            set
            {
                if (value != point2)
                {
                    point2 = value;
                    PaintRequired = true;
                }
            }
        }
        public PointF Point3
        {
            get
            {
                return point3;
            }
            set
            {
                if (value != point3)
                {
                    point3 = value;
                    PaintRequired = true;
                }
            }
        }
        public PointF Point4
        {
            get
            {
                return point4;
            }
            set
            {
                if (value != point4)
                {
                    point4 = value;
                    PaintRequired = true;
                }
            }
        }
        public PointF Point5
        {
            get
            {
                return point5;
            }
            set
            {
                if (value != point5)
                {
                    point5 = value;
                    PaintRequired = true;
                }
            }
        }
        public object Tag
        {
            get; set;
        }
        public PointF[] Region
        {
            get
            {
                return new PointF[]
                {
                    Point0,
                    Point1,
                    Point2,
                    Point3,
                    Point4,
                    Point5
                };
            }
        }
        public PointF TextLocation
        {
            get
            {
                return textLocation;
            }
            set
            {
                if (value != textLocation)
                {
                    textLocation = value;
                    PaintRequired = true;
                }
            }
        }

        public int CompareTo(object obj)
        {
            return Level.CompareTo(((BreadCrumbItem)obj).Level);
        }
    }

    public class BreadCrumbEventArgs : EventArgs
    {
        public BreadCrumbItem BreadCrumbItem { get; private set; }
        public BreadCrumbEventArgs(BreadCrumbItem item)
        {
            BreadCrumbItem = item;
        }
    }
}
