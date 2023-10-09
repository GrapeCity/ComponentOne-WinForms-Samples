//----------------------------------------------------------------------------
// LinearGradientModeListBox.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using C1.Win.Document;
using NSD = C1.Win.Interop;

namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal class LinearGradientModeListBox : DropDownListBox
    {
        private static readonly Size BrushSize = new Size(18, 18);
        private static readonly Color Color1 = Color.Red;
        private static readonly Color Color2 = Color.White;
        private const int Offset = 2;

        #region Constructors

        public LinearGradientModeListBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = BrushSize.Height + Offset * 2;
        }
        #endregion

        #region Protected
        protected override void OnDrawItem(
            DrawItemEventArgs e)
        {
            e.DrawBackground();

            var gm = (LinearGradientMode)((Item)Items[e.Index]).Value;
            var markRect = new Rectangle {X = e.Bounds.Left + Offset, Y = e.Bounds.Top + Offset, Size = BrushSize};
            var textRect = new Rectangle {X = markRect.Right + Offset, Y = e.Bounds.Top};
            textRect.Width = e.Bounds.Right - textRect.X;
            textRect.Height = e.Bounds.Height;

            e.Graphics.DrawRectangle(Pens.Black, markRect.X, markRect.Y, markRect.Width - 1, markRect.Height - 1);
            markRect.Inflate(-1, -1);

            var brush = new LinearGradientBrush(markRect, Color1, Color2, gm);
            e.Graphics.FillRectangle(brush, markRect);

            TextRenderer.DrawText(
                e.Graphics,
                gm.ToString(),
                Font,
                textRect,
                ((e.State & DrawItemState.Selected) != 0) ? SystemColors.HighlightText : ForeColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

            if ((e.State & DrawItemState.Focus) != 0)
                e.DrawFocusRectangle();

            base.OnDrawItem(e);
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int ItemHeight
        {
            get { return base.ItemHeight; }
            set { base.ItemHeight = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DrawMode DrawMode
        {
            get { return base.DrawMode; }
            set { base.DrawMode = value; }
        }
        #endregion
    }
}
