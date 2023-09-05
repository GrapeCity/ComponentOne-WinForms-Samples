//----------------------------------------------------------------------------
// PreviewControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using C1.Util.Win;
using Brush = System.Drawing.Brush;

namespace FlexReportDesignerApp.Controls.Background
{
    internal enum PreviewOrientation
    {
        Horizontal,
        Vertical,
    }

    internal class DrawPreviewEventArgs : EventArgs
    {
        private readonly Graphics _graphics;
        private readonly Rectangle _bounds;

        #region Constructors
        public DrawPreviewEventArgs(
            Graphics graphics,
            Rectangle bounds)
        {
            _graphics = graphics;
            _bounds = bounds;
        }
        #endregion

        #region Public properties
        public Graphics Graphics
        {
            get { return _graphics; }
        }

        public Rectangle Bounds
        {
            get { return _bounds; }
        }
        #endregion
    }

    internal class PreviewControl : Control
    {
        private const int c_BorderSize = 1;
        private const int c_CaptionOffset = 2;
        private const bool c_DefShowInitial = true;
        private const bool c_DefShowCaptions = true;
        private const PreviewOrientation c_DefOrientation = PreviewOrientation.Vertical;
        private static readonly Color c_DefBorderColor = Color.Black;

        private bool _showInitial = c_DefShowInitial;
        private bool _showCaptions = c_DefShowCaptions;
        private PreviewOrientation _orientation = c_DefOrientation;
        private Color _borderColor = c_DefBorderColor;
        private readonly string _initial = Strings.BackgroundEditorPreviewControl.Initial;
        private readonly string _current = Strings.BackgroundEditorPreviewControl.Current;

        #region Constructors
        public PreviewControl()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Opaque, true);
        }
        #endregion

        #region Private
        private void CalcRects(
            Rectangle bounds,
            out Rectangle initialCaption,
            out Rectangle initialPreview,
            out Rectangle currentCaption,
            out Rectangle currentPreview,
            out Rectangle border)
        {
            border = Rectangle.Empty;
            initialCaption = Rectangle.Empty;
            currentCaption = Rectangle.Empty;
            if (!_showInitial)
            {
                initialPreview = Rectangle.Empty;
                border = bounds;
                currentPreview = Rectangle.Inflate(border, -c_BorderSize, -c_BorderSize);
                return;
            }

            int captionSize = Font.Height + c_CaptionOffset * 2;
            switch (_orientation)
            {
                case PreviewOrientation.Horizontal:
                    initialPreview = new Rectangle(bounds.Left, bounds.Top, bounds.Width / 2, bounds.Height);
                    currentPreview = new Rectangle(initialPreview.Right, bounds.Top, bounds.Width - initialPreview.Width, bounds.Height);
                    if (_showCaptions)
                    {
                        initialCaption = new Rectangle(bounds.Left, bounds.Top, captionSize, bounds.Height);
                        initialPreview.X += initialCaption.Width;
                        initialPreview.Width -= initialCaption.Width;
                        currentCaption = new Rectangle(bounds.Right - captionSize, bounds.Top, captionSize, bounds.Height);
                        currentPreview.Width -= currentCaption.Width;
                    }
                    border = new Rectangle(initialPreview.Left, initialPreview.Top, currentPreview.Right - initialPreview.Left, currentPreview.Bottom - initialPreview.Top);
                    initialPreview.X += c_BorderSize;
                    initialPreview.Width -= c_BorderSize;
                    initialPreview.Y += c_BorderSize;
                    initialPreview.Height -= c_BorderSize * 2;
                    currentPreview.Width -= c_BorderSize;
                    currentPreview.Y += c_BorderSize;
                    currentPreview.Height -= c_BorderSize * 2;
                    break;
                case PreviewOrientation.Vertical:
                    initialPreview = new Rectangle(bounds.Left, bounds.Top, bounds.Width, bounds.Height / 2);
                    currentPreview = new Rectangle(bounds.Left, initialPreview.Bottom, bounds.Width, bounds.Height - initialPreview.Height);
                    if (_showCaptions)
                    {
                        initialCaption = new Rectangle(bounds.Left, bounds.Top, bounds.Width, captionSize);
                        initialPreview.Y += initialCaption.Height;
                        initialPreview.Height -= initialCaption.Height;
                        currentCaption = new Rectangle(bounds.Left, bounds.Bottom - captionSize, bounds.Width, captionSize);
                        currentPreview.Height -= currentCaption.Height;
                    }
                    border = new Rectangle(initialPreview.Left, initialPreview.Top, currentPreview.Right - initialPreview.Left, currentPreview.Bottom - initialPreview.Top);
                    initialPreview.X += c_BorderSize;
                    initialPreview.Width -= c_BorderSize * 2;
                    initialPreview.Y += c_BorderSize;
                    initialPreview.Height -= c_BorderSize;
                    currentPreview.Height -= c_BorderSize;
                    currentPreview.X += c_BorderSize;
                    currentPreview.Width -= c_BorderSize * 2;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void DrawText(
            IntPtr dc,
            string s,
            Rectangle bounds,
            bool vertical)
        {
            Win32.RECT r;
            if (vertical)
            {
                r = Win32.RECT.FromRectangle(bounds);
                Win32.DrawText(dc, s, s.Length, ref r, Win32.DT.DT_CENTER | Win32.DT.DT_VCENTER | Win32.DT.DT_END_ELLIPSIS | Win32.DT.DT_SINGLELINE);
                return;
            }

            // calc text
            string s2 = string.Copy(s);
            r.left = bounds.Left;
            r.top = bounds.Top;
            r.right = r.left + bounds.Height;
            r.bottom = r.top + bounds.Width;
            Win32.DrawText(dc, s2, s2.Length, ref r, Win32.DT.DT_CENTER | Win32.DT.DT_VCENTER | Win32.DT.DT_END_ELLIPSIS | Win32.DT.DT_SINGLELINE | Win32.DT.DT_MODIFYSTRING | Win32.DT.DT_CALCRECT);

            Win32.RECT r2 = Win32.RECT.FromRectangle(bounds);
            Win32.ExtTextOut(dc, bounds.Left + c_BorderSize, bounds.Bottom - (bounds.Height - r.Width) / 2, Win32.ETO.ETO_CLIPPED, ref r2, s2, s2.Length, IntPtr.Zero);
        }

        #endregion

        #region Protected
        protected virtual void OnDrawInitial(
            Graphics graphics,
            Rectangle bounds)
        {
            if (DrawInitial != null)
                DrawInitial(this, new DrawPreviewEventArgs(graphics, bounds));
            else
            {
                using (var b = new SolidBrush(BackColor))
                {
                    graphics.FillRectangle(b, bounds);
                }
            }
        }

        protected virtual void OnDrawCurrent(
            Graphics graphics,
            Rectangle bounds)
        {
            if (DrawCurrent != null)
                DrawCurrent(this, new DrawPreviewEventArgs(graphics, bounds));
            else
            {
                using (var b = new SolidBrush(BackColor))
                {
                    graphics.FillRectangle(b, bounds);
                }
            }
        }

        protected override void OnPaint(
            PaintEventArgs e)
        {
            // calculate rectangles
            Rectangle ic, ip, cc, cp, border;
            CalcRects(ClientRectangle, out ic, out ip, out cc, out cp, out border);

            // caption
            if (_showCaptions)
            {
                // background
                using (Brush b = new SolidBrush(BackColor))
                {
                    e.Graphics.FillRectangle(b, ic);
                    e.Graphics.FillRectangle(b, cc);
                }

                // text, create Win32 font
                var lf = new Win32.LOGFONT();
                Font.ToLogFont(lf);
                if (_orientation == PreviewOrientation.Horizontal)
                {
                    // text rotated at 90
                    lf.lfOrientation = 900;
                    lf.lfEscapement = 900;
                }
                IntPtr dc = e.Graphics.GetHdc();
                IntPtr nf = Win32.CreateFontIndirect(lf);
                IntPtr of = Win32.SelectObject(dc, nf);
                int oc = Win32.SetTextColor(dc, ColorTranslator.ToWin32(ForeColor));
                int om = Win32.SetBkMode(dc, Win32.SetBkModeConsts.TRANSPARENT);

                DrawText(dc, _initial, ic, _orientation == PreviewOrientation.Vertical);

                DrawText(dc, _current, cc, _orientation == PreviewOrientation.Vertical);

                Win32.SetBkMode(dc, om);
                Win32.SetTextColor(dc, oc);
                Win32.SelectObject(dc, of);
                Win32.DeleteObject(nf);
                e.Graphics.ReleaseHdc();
            }

            // border
            using (var p = new Pen(_borderColor, 1))
                e.Graphics.DrawRectangle(p, border.Left, border.Top, border.Width - 1, border.Height - 1);

            //
            if (_showInitial)
            {
                OnDrawInitial(e.Graphics, ip);
                OnDrawCurrent(e.Graphics, cp);
            }
            else
            {
                OnDrawCurrent(e.Graphics, cp);
            }

            base.OnPaint(e);
        }
        #endregion

        #region Public properties

        [DefaultValue(c_DefShowInitial)]
        public bool ShowInitial
        {
            get { return _showInitial; }
            set
            {
                if (_showInitial == value)
                    return;
                _showInitial = value;
                Invalidate();
            }
        }

        [DefaultValue(c_DefShowCaptions)]
        public bool ShowCaptions
        {
            get { return _showCaptions; }
            set
            {
                if (_showCaptions == value)
                    return;
                _showCaptions = value;
                Invalidate();
            }
        }

        [DefaultValue(c_DefOrientation)]
        public PreviewOrientation Orientation
        {
            get { return _orientation; }
            set
            {
                if (_orientation == value)
                    return;
                _orientation = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "Black")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                if (_borderColor == value)
                    return;
                _borderColor = value;
                Invalidate();
            }
        }
        #endregion

        #region Events

        public event EventHandler<DrawPreviewEventArgs> DrawInitial;

        public event EventHandler<DrawPreviewEventArgs> DrawCurrent;

        #endregion
    }
}
