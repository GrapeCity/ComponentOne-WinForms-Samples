//----------------------------------------------------------------------------
// ColorButton.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace FlexReportDesignerApp.Controls.Background
{
    [Flags]
    internal enum ColorButtonState
    {
        None = 0x00,
        Hot = 0x01,
        Selected = 0x02,
    }

    internal class ColorButton : Button
    {
        private const int c_MarkSize = 14;
        private const int c_MarkPadding = 4;
        private static readonly Color c_BorderColor = Color.FromArgb(0xC5, 0xC5, 0xC5);
        private static readonly Color c_SelectedColor1 = Color.FromArgb(0xEF, 0x48, 0x10);
        private static readonly Color c_SelectedColor2 = Color.FromArgb(0xFF, 0xE2, 0x94);
        private static readonly Color c_HotColor1 = Color.FromArgb(0xF2, 0x94, 0x36);
        private static readonly Color c_HotColor2 = Color.FromArgb(0xFF, 0xE2, 0x94);
        private static readonly Color c_DisabledColor1 = SystemColors.ControlDark;
        private static readonly Color c_DisabledColor2 = SystemColors.ControlLight;

        private ColorButtonState _state;
        private Color _color;

        #region Protected
        protected override void OnPaint(
            PaintEventArgs pevent)
        {
            Color c1 = Color == Color.Empty || Color == Color.Transparent ? Color.Black : c_BorderColor;
            Color c2 = Color.Empty;
            Color foreColor = ForeColor;
            if (!Enabled)
            {
                c1 = c_DisabledColor1;
                c2 = c_DisabledColor2;
                foreColor = SystemColors.GrayText;
            }
            else if ((State & ColorButtonState.Hot) != 0)
            {
                c1 = c_HotColor1;
                c2 = c_HotColor2;
            }
            else if ((State & ColorButtonState.Selected) != 0)
            {
                c1 = c_SelectedColor1;
                c2 = c_SelectedColor2;
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

            if (Color == Color.Transparent || Color == Color.Empty)
            {
                var markRect = new Rectangle
                {
                    Y = cr.Top + (cr.Height - c_MarkSize)/2,
                    Height = c_MarkSize,
                    X = cr.Left + c_MarkPadding,
                    Width = c_MarkSize
                };

                var textRect = new Rectangle
                {
                    X = markRect.Right + c_MarkPadding,
                    Y = r.Y,
                    Width = r.Right - markRect.Right - c_MarkPadding,
                    Height = r.Height
                };

                if (BackColor == Color.Transparent || BackColor.IsEmpty)
                    using (var b = new SolidBrush(Parent.BackColor))
                        pevent.Graphics.FillRectangle(b, r);
                else
                    using (var b = new SolidBrush(BackColor))
                        pevent.Graphics.FillRectangle(b, r);
                Utils.DrawColorMark(pevent.Graphics, Color, true, markRect);
                string s = Text;
                if (string.IsNullOrEmpty(s))
                {
                    if (Color == Color.Transparent)
                        s = Utils.TransparentColorCaption;
                    else if (Color.IsEmpty)
                        s = Utils.EmptyColorCaption;
                }
                TextRenderer.DrawText(pevent.Graphics, s, Font, textRect, foreColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
            }
            else
                using (var b = new SolidBrush(_color))
                    pevent.Graphics.FillRectangle(b, r);

            if(Focused)
                ControlPaint.DrawFocusRectangle(pevent.Graphics, r);
        }

        protected override void OnMouseEnter(
            EventArgs e)
        {
            State |= ColorButtonState.Hot;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(
            EventArgs e)
        {
            State &= ~ColorButtonState.Hot;
            base.OnMouseLeave(e);
        }
        #endregion

        #region Public properties
        [Browsable(true)]
        public Color Color
        {
            get { return _color; }
            set
            {
                if (_color == value)
                    return;
                _color = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ColorButtonState State
        {
            get { return _state; }
            set
            {
                if (_state == value)
                    return;
                _state = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Selected
        {
            get { return (_state & ColorButtonState.Selected) != 0; }
            set
            {
                if (value)
                    State |= ColorButtonState.Selected;
                else
                    State &= ~ColorButtonState.Selected;
            }
        }
        #endregion
    }
}
