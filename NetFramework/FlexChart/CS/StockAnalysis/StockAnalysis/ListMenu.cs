using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace StockAnalysis
{
    public class ListMenu : ListBox
    {
        int _mouseIndex = -1;
        int _selectedIndex = -1;

        #region ctors
        public ListMenu() : base()
        {
            BackColorSelected = Color.FromArgb(230, 230, 230);
            BackColorOnOver = Color.FromArgb(240, 240, 240);
            ForeColorAlt = ForeColor;
        }
        #endregion

        #region Properties
        public Color BackColorSelected { get; set; }
        public Color BackColorOnOver { get; set; }
        public Color ForeColorAlt { get; set; }
        #endregion

        #region Overrides
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Type itemType = null;

            // ensure the listbox is well behaved at designtime and other objects.
            if (e.Index > -1 && Items != null && Items.Count > 0 && Items[e.Index] != null)
            {
                Type it = Items[e.Index].GetType();
                if (it == typeof(Object.Quote))
                    itemType = it;
            }

            if (itemType != null)
            {
                DrawBackGround(e);
                DrawQuoteItem(e);
            }
            else
            {
                base.OnDrawItem(e);
            }

            return;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            int index = IndexFromPoint(e.Location);

            if (index != _mouseIndex)
            {
                if (_mouseIndex > -1) Invalidate(RectangleFromIndex(_mouseIndex));
                _mouseIndex = (index > -1 && index <= Items.Count) ? index : -1;
                if (_mouseIndex > -1) Invalidate(RectangleFromIndex(_mouseIndex));
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (_mouseIndex > -1) Invalidate(RectangleFromIndex(_mouseIndex));
            _mouseIndex = -1;
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            if (_selectedIndex != SelectedIndex)
            {
                if (_selectedIndex > -1) Invalidate(RectangleFromIndex(_selectedIndex));
                _selectedIndex = SelectedIndex;
                if (_selectedIndex > -1) Invalidate(RectangleFromIndex(_selectedIndex));
            }
        }
        #endregion


        #region Implementation
        private Rectangle RectangleFromIndex(int index)
        {
            return new Rectangle(0, index * ItemHeight, Width, (index + 1) * ItemHeight);
        }

        private void DrawQuoteItem(DrawItemEventArgs e)
        {
            // move data information to local variables.
            Object.Quote quote = Items[e.Index] as Object.Quote;
            string[] priceData = new string[]
            {
                quote.Name, quote.Rate.ToString("P2"), quote.Price.ToString("F2")
            };
            bool risingPrice = !(quote.Rate < 0);
            bool gap = quote.Updown;

            Graphics g = e.Graphics;
            Rectangle r = e.Bounds;

            float textHeight = g.MeasureString("A", Font).Height;

            PointF p = new PointF(r.Left + Margin.Left, r.Top + (r.Height - textHeight) / 2);

            using (Brush br = new SolidBrush(risingPrice ? ForeColor : ForeColorAlt))
            {
                // draw name
                g.DrawString(priceData[0], Font, br, p);

                // draw change - right justified
                float width = g.MeasureString(priceData[1], Font).Width;
                p.X += 145 - width;
                g.DrawString(priceData[1], Font, br, p);

                // draw indicator
                p.X += width;
                DrawIndicator(g, p, risingPrice, br);

                // draw price - right justified
                width = g.MeasureString(priceData[2], Font).Width;
                p.X += 80 - width;
                g.DrawString(priceData[2], Font, br, p);

                // draw line separating items.
                e.Graphics.DrawLine(Pens.LightGray,
                    new PointF(r.Left, r.Bottom - 1), new PointF(r.Right, r.Bottom - 1));
            }
        }

        private void DrawBackGround(DrawItemEventArgs e)
        {
            Color backColor = BackColor;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                backColor = BackColorSelected;
            else if (e.Index == _mouseIndex)
                backColor = BackColorOnOver;

            using (Brush br = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(br, e.Bounds);
            }
        }

        private void DrawIndicator(Graphics g, PointF p, bool risingPrice, Brush br)
        {
            PointF[] indicator = null;

            if (risingPrice)
            {
                indicator = new PointF[]
                {
                    new PointF(p.X + 11, p.Y + 4),
                    new PointF(p.X + 5, p.Y + 10),
                    new PointF(p.X + 17, p.Y + 10)
                };
            }
            else
            {
                indicator = new PointF[]
                {
                    new PointF(p.X + 11, p.Y + 10),
                    new PointF(p.X + 6, p.Y + 5),
                    new PointF(p.X + 16, p.Y + 5)
                };
            }

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillPolygon(br, indicator);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
        }
        #endregion
    }
}
