//----------------------------------------------------------------------------
// ColorPickerButton.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlexReportDesignerApp.Controls.Background
{
    internal class ColorPickerButton : Button
    {
        private static readonly Color SelectedColor1 = Color.FromArgb(0xEF, 0x48, 0x10);
        private static readonly Color SelectedColor2 = Color.FromArgb(0xFF, 0xE2, 0x94);
        private static readonly Color HotColor1 = Color.FromArgb(0xF2, 0x94, 0x36);
        private static readonly Color HotColor2 = Color.FromArgb(0xFF, 0xE2, 0x94);
        private static readonly Color DisabledColor1 = SystemColors.ControlDark;
        private static readonly Color DisabledColor2 = SystemColors.ControlLight;

        private ColorButtonState _state;

        #region Protected
        protected override void OnPaint(
            PaintEventArgs pevent)
        {
            Color c1 = Color.Black;
            Color c2 = Color.Empty;
            if (!Enabled)
            {
                c1 = DisabledColor1;
                c2 = DisabledColor2;
            }
            else if ((_state & ColorButtonState.Hot) != 0)
            {
                c1 = HotColor1;
                c2 = HotColor2;
            }
            else if ((_state & ColorButtonState.Selected) != 0)
            {
                c1 = SelectedColor1;
                c2 = SelectedColor2;
            }

            Rectangle cr = ClientRectangle;
            Rectangle r = cr;
            using (var p = new Pen(c1))
                pevent.Graphics.DrawRectangle(p, r.X, r.Y, r.Width - 1, r.Height - 1);
            r.Inflate(-1, -1);
            if (c2 != Color.Empty)
            {
                using (var p = new Pen(c2))
                    pevent.Graphics.DrawRectangle(p, r.X, r.Y, r.Width - 1, r.Height - 1);
                r.Inflate(-1, -1);
            }

            if (BackColor == Color.Transparent || BackColor.IsEmpty)
                using (var b = new SolidBrush(Parent.BackColor))
                    pevent.Graphics.FillRectangle(b, r);
            else
                using (var b = new SolidBrush(BackColor))
                    pevent.Graphics.FillRectangle(b, r);

            if (Image != null)
            {
                var x = (cr.Width - Image.Width)/2 + 1;
                var y = cr.Height - Image.Height - 2;
                pevent.Graphics.DrawImageUnscaled(Image, new Point(x, y));
            }

            if (Focused)
            {
                ControlPaint.DrawFocusRectangle(pevent.Graphics, r);
            }
        }

        protected override void OnMouseEnter(
            EventArgs e)
        {
            _state |= ColorButtonState.Hot;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(
            EventArgs e)
        {
            _state &= ~ColorButtonState.Hot;
            base.OnMouseLeave(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            _state |= ColorButtonState.Selected;
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            _state &= ~ColorButtonState.Selected;
            base.OnLostFocus(e);
        }

        #endregion
    }
}
