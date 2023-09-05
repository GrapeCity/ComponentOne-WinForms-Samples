//----------------------------------------------------------------------------
// Utils.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using System.Globalization;
using System.Drawing.Imaging;
using C1.Win.Document;
using C1.Win.Document.Util;
using C1.Util.Win;
using NSD = C1.Win.Interop;

namespace FlexReportDesignerApp.Controls.Background
{
    internal static class Utils
    {
        private static readonly string BackgroundNotCompletelyDefined;
        private static readonly TypeConverter ColorConverter;
        
        public static readonly string EmptyColorCaption;
        public static readonly string TransparentColorCaption;

        #region Constructors
        static Utils()
        {
            TransparentColorCaption = Strings.BackgroundEditor.TransparentColor;
            EmptyColorCaption = Strings.BackgroundEditor.EmptyColor;
            BackgroundNotCompletelyDefined = Strings.BackgroundEditor.BackgroundNotCompletelyDefined;
            ColorConverter = TypeDescriptor.GetConverter(typeof(Color));
        }
        #endregion

        #region Public static

        public static bool IsNull(
            object value)
        {
            return value == null || value is System.DBNull;
        }

        public static bool IsNumber(
            object obj)
        {
            return obj is byte ||
                obj is Int16 ||
                obj is Int32 ||
                obj is Int64 ||
                obj is UInt16 ||
                obj is UInt32 ||
                obj is UInt64 ||
                obj is decimal ||
                obj is float ||
                obj is double;
        }

        public static decimal AsDecimal(
            object obj)
        {
            if (obj is byte)
                return (byte)obj;
            if (obj is Int16)
                return (Int16)obj;
            if (obj is Int32)
                return (Int32)obj;
            if (obj is Int64)
                return (Int64)obj;
            if (obj is UInt16)
                return (UInt16)obj;
            if (obj is UInt32)
                return (UInt32)obj;
            if (obj is UInt64)
                return (UInt64)obj;
            if (obj is decimal)
                return (decimal)obj;
            if (obj is float)
                return (decimal)((float)obj);
            if (obj is double)
                return (decimal)((double)obj);
            throw new InvalidCastException();
        }

        public static double AsNumber(
            object obj)
        {
            if (obj is byte)
                return (byte)obj;
            if (obj is Int16)
                return (Int16)obj;
            if (obj is Int32)
                return (Int32)obj;
            if (obj is Int64)
                return (Int64)obj;
            if (obj is UInt16)
                return (UInt16)obj;
            if (obj is UInt32)
                return (UInt32)obj;
            if (obj is UInt64)
                return (UInt64)obj;
            if (obj is decimal)
                return (double)((decimal)obj);
            if (obj is float)
                return (float)obj;
            if (obj is double)
                return (double)obj;
            throw new InvalidCastException();
        }

        public static string ColorToString(
            Color value)
        {
            return (string)ColorConverter.ConvertTo(null, CultureInfo.InvariantCulture, value, typeof(string));
        }

        public static Color ColorFromString(
            string s)
        {
            return (Color)ColorConverter.ConvertFrom(null, CultureInfo.InvariantCulture, s);
        }

        public static string GetNumberFormat(
            int decimalPlaces,
            bool forEdit)
        {
            string result = decimalPlaces <= 0 ? "0" : string.Format("0.{0}", new string('0', decimalPlaces));
            if (!forEdit)
                result = "#" + result;
            return result;
        }

        public static string DoubleToString(
            double value,
            int decimalPlaces,
            bool suppressTrailingZeros,
            bool forEdit,
            CultureInfo ci)
        {
            if (decimalPlaces < 0)
                return value.ToString(ci);

            string s = value.ToString(GetNumberFormat(decimalPlaces, forEdit), ci);
            if (suppressTrailingZeros)
            {
                string sep = ci.NumberFormat.NumberDecimalSeparator;
                int i = s.LastIndexOf(sep, StringComparison.Ordinal);
                if (i >= 0)
                {
                    int j = s.Length - 1;
                    while (j >= i + sep.Length && s[j] == '0') j--;
                    s = j < i + sep.Length ? s.Substring(0, i) : s.Substring(0, j + 1);
                }
            }
            return s;
        }

        public static string DoubleToString(
            double value,
            int decimalPlaces,
            bool suppressTrailingZeros,
            bool forEdit)
        {
            return DoubleToString(value, decimalPlaces, suppressTrailingZeros, forEdit, CultureInfo.InvariantCulture);
        }

        public static string GetColorDisplayText(
            Color c,
            string emptyColorCaption)
        {
            if (string.IsNullOrEmpty(emptyColorCaption))
                emptyColorCaption = EmptyColorCaption;
            if (c.IsEmpty)
                return emptyColorCaption;
            if (c.IsNamedColor)
                return c.Name;
            if (c.A == 255)
                return string.Format("{0}; {1}; {2}", c.R, c.G, c.B);
            return string.Format("{0}; {1}; {2}; {3}", c.A, c.R, c.G, c.B);
        }

        public static bool TryParseColorFromDisplayText(
            string s,
            string emptyColorCaption,
            out Color value)
        {
            if (string.IsNullOrEmpty(emptyColorCaption))
                emptyColorCaption = EmptyColorCaption;
            value = Color.Empty;
            if (s == emptyColorCaption)
                return true;

            int a, r, g, b;
            s = s.Trim();
            if (s.StartsWith("#"))
            {
                // HTML color, specified in format: RRGGBB
                // color can contain alpha value: AARRGGBB
                if (s.Length != 7 && s.Length != 9)
                    return false;
                
                if (s.Length == 9)
                {
                    if (!int.TryParse(s.Substring(1, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out a))
                        return false;
                }
                else
                    a = 255;

                if (!int.TryParse(s.Substring(3, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out r))
                    return false;

                if (!int.TryParse(s.Substring(5, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out g))
                    return false;

                if (!int.TryParse(s.Substring(7, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out b))
                    return false;

                value = Color.FromArgb(a, r, g, b);
                return true;
            }

            if (s.StartsWith("0x"))
            {
                // HEX color, specified in format: GGBBRR
                // color can contain alpha value: AABBRRGG
                if (s.Length != 8 && s.Length != 10)
                    return false;
                
                if (s.Length == 10)
                {
                    if (!int.TryParse(s.Substring(2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out a))
                        return false;
                }
                else
                    a = 255;

                if (!int.TryParse(s.Substring(3, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out b))
                    return false;

                if (!int.TryParse(s.Substring(5, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out g))
                    return false;

                if (!int.TryParse(s.Substring(7, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out r))
                    return false;

                value = Color.FromArgb(a, r, g, b);
                return true;
            }

            int win32Color;
            if (int.TryParse(s, out win32Color))
            {
                value = ColorTranslator.FromWin32(win32Color);
                return true;
            }

            string[] ss = s.Split(';', ',');
            if (ss.Length == 1)
            {
                if (string.IsNullOrEmpty(ss[0]))
                    return false;
                // named color
                try
                {
                    var kc = (KnownColor)Enum.Parse(typeof(KnownColor), ss[0], true);
                    value = Color.FromKnownColor(kc);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            // color specified in format like: RRR; GGG; BBB
            // where numbers specified as decimal values
            if (ss.Length != 3 && ss.Length != 4)
                return false;
            int i = 0;
            if (ss.Length == 4)
            {
                if (!int.TryParse(ss[i++].Trim(), out a))
                    return false;
            }
            else
                a = 255;

            if (!int.TryParse(ss[i++].Trim(), out r) || r < 0 || r > 255)
                return false;
            if (!int.TryParse(ss[i++].Trim(), out g) || g < 0 || g > 255)
                return false;
            if (!int.TryParse(ss[i].Trim(), out b) || b < 0 || b > 255)
                return false;

            value = Color.FromArgb(a, r, g, b);
            return true;
        }

        public static void DrawPointMark(Graphics g, Point point, Size markSize, int markOffset)
        {
            var hdc = g.GetHdc();
            var hpen = Win32.CreatePen(Win32.PS.PS_SOLID, markSize.Width, ColorTranslator.ToWin32(Color.Black));
            var oldpen = Win32.SelectObject(hdc, hpen);
            int rop = Win32.SetROP2(hdc, Win32.RasterOp.R2_NOT);

            Win32.MoveTo(hdc, point.X, point.Y - markOffset - markSize.Height);
            Win32.LineTo(hdc, point.X, point.Y - markOffset);
            Win32.MoveTo(hdc, point.X, point.Y + markOffset + markSize.Height);
            Win32.LineTo(hdc, point.X, point.Y + markOffset);
            Win32.MoveTo(hdc, point.X - markOffset - markSize.Height, point.Y);
            Win32.LineTo(hdc, point.X - markOffset, point.Y);
            Win32.MoveTo(hdc, point.X + markOffset + markSize.Height, point.Y);
            Win32.LineTo(hdc, point.X + markOffset, point.Y);

            Win32.SetROP2(hdc, rop);
            Win32.SelectObject(hdc, oldpen);
            Win32.DeleteObject(hpen);
            g.ReleaseHdc(hdc);
        }

        public static void DrawColorMark(
            Graphics g,
            Color color,
            bool showBorder,
            Rectangle r)
        {
            Rectangle innerRect;
            if (showBorder)
            {
                g.DrawRectangle(Pens.DarkGray, r.X, r.Y, r.Width - 1, r.Height - 1);
                g.DrawRectangle(Pens.White, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3);
                innerRect = Rectangle.Inflate(r, -2, -2);
            }
            else
                innerRect = r;

            if (color.IsEmpty)
            {
                using (var b = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.Gray, Color.White))
                {
                    g.RenderingOrigin = new Point(r.X, r.Y);
                    g.FillRectangle(b, innerRect);
                }
            }
            else if (color == Color.Transparent)
            {
                using (var pLine = new Pen(Color.Red, 3))
                {
                    g.FillRectangle(Brushes.White, innerRect);
                    Region rgn = g.Clip;
                    g.IntersectClip(innerRect);
                    g.DrawLine(pLine, r.Left, r.Bottom, r.Right, r.Top);
                    g.Clip = rgn;
                    rgn.Dispose();
                }
            }
            else
            {
                if (color.A < 0xFF)
                    g.FillRectangle(Brushes.White, innerRect);
                using (var b = new SolidBrush(color))
                {
                    g.FillRectangle(b, innerRect);
                }
            }
        }
        
        public static void DrawBackground(
            Graphics g,
            Color backcolor,
            C1Brush background,
            Rectangle bounds)
        {
            if (background == null) return;

            var tsb = background as C1SolidBrush;
            if (tsb != null)
            {
                if (tsb.Color == Color.Transparent || tsb.Color.IsEmpty)
                {
                    DrawColorMark(g, tsb.Color, false, bounds);
                    return;
                }
            }

            using (
                var image = GetBrushImage(backcolor, background, new NSD.Size(bounds.Width, bounds.Height),
                    new NSD.Point(g.DpiX, g.DpiY)))
            {
                g.DrawImageUnscaled(image, bounds.Left, bounds.Top);
            }
        }

        public static Image GetBrushImage(Color backcolor, C1Brush brush, C1.Win.Interop.Size size, C1.Win.Interop.Point dpi)
        {
            using (var dxGraphics = new C1DXGraphics())
            {
                dxGraphics.BeginGetImage(size, dpi);
                var bounds = new C1.Win.Interop.Rect(0, 0, size.Width, size.Height);
                dxGraphics.FillRectangle(backcolor, bounds);
                dxGraphics.FillRectangle(brush, bounds);
                using (C1Image image = dxGraphics.EndGetImage(false))
                {
                    return Image.FromStream(image.GetData());
                }
            }
        }

        public static void DrawInvalidBackground(
            Graphics graphics,
            Rectangle bounds,
            Color backColor,
            Color foreColor,
            Font font)
        {
            using (Brush b = new SolidBrush(backColor))
                graphics.FillRectangle(b, bounds);
            Size sz = TextRenderer.MeasureText(
                BackgroundNotCompletelyDefined,
                font,
                new Size(bounds.Width, 0),
                TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.WordBreak);
            var r = new Rectangle(bounds.Left, bounds.Top + (bounds.Height - sz.Height) / 2, bounds.Width, sz.Height);
            TextRenderer.DrawText(
                graphics,
                BackgroundNotCompletelyDefined,
                font,
                r,
                foreColor,
                Color.Transparent,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.Top | TextFormatFlags.WordBreak);
        }

        #endregion
    }
}
