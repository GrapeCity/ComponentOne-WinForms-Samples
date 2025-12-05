//----------------------------------------------------------------------------
// ListBoxEx.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexReportDesignerApp.Controls
{
    internal class ListBoxEx : ListBox
    {
        private const int ContentPadding = 4;
        private const int VSpacePixels = 2;
        private const int IndicatorWidth = 19;

        public ListBoxEx()
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            DrawMode = DrawMode.OwnerDrawFixed;
        }

        public event EventHandler<PaintIndicatorEventArgs> PaintIndicator;

        [DefaultValue(false)]
        public bool PaintIndicatorSupported { get; set; }

        public override DrawMode DrawMode
        {
            get
            {
                return base.DrawMode;
            }
            set
            {
                if (value != base.DrawMode)
                {
                    base.DrawMode = value;
                    SetItemSize();
                }
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (!PaintIndicatorSupported)
            {
                base.OnDrawItem(e);
            }
            else
            {
                e.DrawBackground();

                var indicatorBounds = e.Bounds;
                indicatorBounds.X += 1;
                indicatorBounds.Width = IndicatorWidth;
                indicatorBounds.Inflate(0, -1*VSpacePixels);
                //e.Graphics.DrawRectangle(new Pen(Color.Black),indicatorBounds);
                OnPaintIndicator(new PaintIndicatorEventArgs(e.Index, e.Graphics, indicatorBounds));

                var content = Items[e.Index].ToString();
                using (var format = new StringFormat())
                {
                    using (var brush = new SolidBrush(e.ForeColor))
                    {
                        format.LineAlignment= StringAlignment.Center;
                        format.FormatFlags = StringFormatFlags.NoWrap;
                        var contentBounds = e.Bounds;
                        var offset = IndicatorWidth + 1 + ContentPadding;
                        contentBounds.X += offset;
                        contentBounds.Width -= offset;
                        e.Graphics.DrawString(content, Font, brush, contentBounds, format);
                    }
                }
                e.DrawFocusRectangle();
            }
        }

        private void SetItemSize()
        {
            using (var gMeasure = Graphics.FromHwnd(IntPtr.Zero))
            {
                gMeasure.PageUnit = GraphicsUnit.Pixel;
                ItemHeight = (int)((VSpacePixels * 2) + Font.GetHeight(gMeasure));
            }
        }

        private void OnPaintIndicator(PaintIndicatorEventArgs e)
        {
            if (PaintIndicator != null)
                PaintIndicator(this, e);
        }

        internal class PaintIndicatorEventArgs : EventArgs
        {
            public PaintIndicatorEventArgs(int index, Graphics g, Rectangle rect)
            {
                Index = index;
                Graphics = g;
                Bounds = rect;
            }

            public int Index { get; private set; }
            public Graphics Graphics { get; private set; }
            public Rectangle Bounds { get; private set; }
        }
    }
}
