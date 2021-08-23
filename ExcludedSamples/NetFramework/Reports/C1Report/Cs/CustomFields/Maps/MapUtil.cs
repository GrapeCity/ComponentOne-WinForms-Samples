using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using System.Reflection;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// Miscellaneous map utility functions.
    /// </summary>
    public static class Util
    {
        #region conversion functions
        /// <summary>
        /// Tests whether the type is a numeric one.
        /// </summary>
        /// <param name="t">The type to test.</param>
        /// <returns>True if the type is numeric, false otherwise.</returns>
        public static bool IsNumericType(Type t)
        {
            switch (Type.GetTypeCode(t))
            {
                case TypeCode.Byte:
                case TypeCode.DateTime:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.Single:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Converts an object to a System.Drawing.Color value.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <returns>The converted color, or null if the object could not be converted.</returns>
        public static System.Drawing.Color? GetColor(object value)
        {
            if (value is System.Drawing.Color)
                return (System.Drawing.Color)value;

            if (value == null || value == DBNull.Value)
                return null;

            if (value is System.Windows.Media.Color)
                return System.Drawing.Color.FromArgb(((System.Windows.Media.Color)value).A, ((System.Windows.Media.Color)value).R,
                    ((System.Windows.Media.Color)value).G, ((System.Windows.Media.Color)value).B);

            if (value is string)
                return System.Drawing.Color.FromName((string)value);

            if (value is int?)
            {
                int v = (int)value;
                return System.Drawing.Color.FromArgb(v & 0xFF, (v >> 8) & 0xFF, (v >> 16) & 0xFF);
            }

            if (value is double?)
            {
                int v = (int)(double)value;
                return System.Drawing.Color.FromArgb(v & 0xFF, (v >> 8) & 0xFF, (v >> 16) & 0xFF);
            }

            return (System.Drawing.Color)Convert.ChangeType(value, typeof(System.Drawing.Color));
        }

        /// <summary>
        /// Converts an object to a double value.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <returns>The converted value, or double.NaN if the object could not be converted.</returns>
        public static double GetDouble(object value)
        {
            return GetDouble(value, double.NaN);
        }

        /// <summary>
        /// Converts an object to a double value.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The converted value, or <paramref name="defaultValue"/> if the object could not be converted.</returns>
        public static double GetDouble(object value, double defaultValue)
        {
            if (value is double)
                return (double)value;

            if (value is string)
            {
                double ret;
                if (double.TryParse((string)value, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out ret))
                    return ret;
            }

            if (value == null || value == DBNull.Value || !IsNumericType(value.GetType()))
                return defaultValue;

            return (double)Convert.ChangeType(value, typeof(double));
        }

        /// <summary>
        /// Converts an object to a boolean value.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The converted value, or <paramref name="defaultValue"/> if the object could not be converted.</returns>
        public static bool GetBool(object value, bool defaultValue)
        {
            int v = GetInt(value, defaultValue ? -1 : 0);
            return v != 0;
        }

        /// <summary>
        /// Converts an object to an integer value.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <returns>The converted value, or 0 if the object could not be converted.</returns>
        public static int GetInt(object value)
        {
            return GetInt(value, 0);
        }

        /// <summary>
        /// Converts an object to an integer value.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The converted value, or <paramref name="defaultValue"/> if the object could not be converted.</returns>
        public static int GetInt(object value, int defaultValue)
        {
            if (value is int)
                return (int)value;

            if (value is string)
            {
                int ret;
                if (int.TryParse((string)value, NumberStyles.Integer, CultureInfo.InvariantCulture, out ret))
                    return ret;
            }

            if (value == null || value == DBNull.Value || !IsNumericType(value.GetType()))
                return defaultValue;

            return (int)Convert.ChangeType(value, typeof(double));
        }

        /// <summary>
        /// Converts an object to a string value.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <returns>The converted value, or empty string if the object could not be converted.</returns>
        public static string GetString(object value)
        {
            if (value == null || value == DBNull.Value)
                return string.Empty;
            return value.ToString();
        }

        /// <summary>
        /// Converts an object to an integer or a string that can be used as an index in a collection.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <param name="integer">OUT: the integer index if <paramref name="value"/> could be converted to an integer, -1 otherwise.</param>
        /// <returns>The string index (use only if <paramref name="integer"/> is -1).</returns>
        public static string GetIndex(object value, out int integer)
        {
            integer = -1;
            if (value == null || value == DBNull.Value)
                return null;
            if (value is int)
            {
                integer = (int)value;
                return null;
            }
            if (IsNumericType(value.GetType()))
            {
                integer = (int)Convert.ChangeType(value, typeof(int));
                return null;
            }
            return value.ToString();
        }
        #endregion

        #region marker geometries
        // 5 point star (pentagram) geometry:
        private static readonly double s_sin72 = Math.Sin((72 * Math.PI) / 180);
        private static readonly double s_cos72 = Math.Cos((72 * Math.PI) / 180);
        private static readonly double s_sin36 = Math.Sin((36 * Math.PI) / 180);
        private static readonly double s_cos36 = Math.Cos((36 * Math.PI) / 180);
        private static readonly double s_starR1 = 1.2; // distance from star center to the 5 points, times "heuristic" scale rel to a circle's radius
        private static readonly double s_starR2 = s_starR1 * s_cos72 / s_cos36; // from center to the 5 vertices of the inner pentagon
        private static readonly Point[] s_starPoints = new Point[]
            {
                new Point(0, -s_starR1), // starting from the top point clockwise
                new Point(s_starR2 * s_sin36, -s_starR2 * s_cos36),
                new Point(s_starR1 * s_sin72, -s_starR1 * s_cos72),
                new Point(s_starR2 * s_sin72, s_starR2 * s_cos72),
                new Point(s_starR1 * s_sin36, s_starR1 * s_cos36),
                new Point(0, s_starR2),
                new Point(-s_starR1 * s_sin36, s_starR1 * s_cos36),
                new Point(-s_starR2 * s_sin72, s_starR2 * s_cos72),
                new Point(-s_starR1 * s_sin72, -s_starR1 * s_cos72),
                new Point(-s_starR2 * s_sin36, -s_starR2 * s_cos36),
            };
        private static readonly PolyLineSegment s_starSegment = new PolyLineSegment(s_starPoints, true);
        private static readonly PathFigure s_starFigure = new PathFigure(s_starSegment.Points[0], new PolyLineSegment[] { s_starSegment }, true);
        // Triangle geometry:
        private static readonly double s_triR = 1.2; // dist from center to top
        private static readonly double s_triA = s_triR / 2; // dist from center to bottom edge
        private static readonly double s_triB = Math.Sqrt(s_triR * s_triR - s_triA * s_triA);
        private static readonly Point[] s_triPoints = new Point[]
            {
                new Point(0, -s_triB), // starting from the top clockwise
                new Point(s_triB, s_triA),
                new Point(-s_triB, s_triA),
            };
        private static readonly PolyLineSegment s_triSegment = new PolyLineSegment(s_triPoints, true);
        private static readonly PathFigure s_triFigure = new PathFigure(s_triSegment.Points[0], new PolyLineSegment[] { s_triSegment }, true);
        // Diamond geometry:
        private static readonly double s_diaR1 = 1.2; // dist from center to top/bottom
        private static readonly double s_diaR2 = 0.9; // dist from center to left/right
        private static readonly Point[] s_diaPoints = new Point[]
            {
                new Point(0, -s_diaR1), // starting from the top clockwise
                new Point(s_diaR2, 0),
                new Point(0, s_diaR1),
                new Point(-s_diaR2, 0),
            };
        private static readonly PolyLineSegment s_diaSegment = new PolyLineSegment(s_diaPoints, true);
        private static readonly PathFigure s_diaFigure = new PathFigure(s_diaSegment.Points[0], new PolyLineSegment[] { s_diaSegment }, true);

        public static Geometry MarkerShapeToGeometry(MarkerShape markerShape, double size)
        {
            switch (markerShape)
            {
                case MarkerShape.None:
                    return null;

                case MarkerShape.Circle:
                    return new EllipseGeometry(new Point(0, 0), size, size);

                case MarkerShape.Triangle:
                    return new PathGeometry(new PathFigure[] { s_triFigure }, FillRule.Nonzero, new ScaleTransform(size, size));

                case MarkerShape.Square:
                    double h = size / 1.2;
                    return new RectangleGeometry(new Rect(-h, -h, h * 2, h * 2));

                case MarkerShape.Diamond:
                    return new PathGeometry(new PathFigure[] { s_diaFigure }, FillRule.Nonzero, new ScaleTransform(size, size));

                case MarkerShape.Star:
                    return new PathGeometry(new PathFigure[] { s_starFigure }, FillRule.Nonzero, new ScaleTransform(size, size));

                default:
                    System.Diagnostics.Debug.Assert(false, "unknown mark shape");
                    goto case MarkerShape.Circle;
            }
        }
        #endregion

        #region misc conversions
        public static void ApplyFontToControl(System.Drawing.Font font, Control ctl)
        {
            if (font != null)
            {
                ctl.FontFamily = new FontFamily(font.FontFamily.Name);
                ctl.FontSize = font.SizeInPoints * (96d / 72d);
                if (font.Italic)
                    ctl.FontStyle = FontStyles.Italic;
                if (font.Bold)
                    ctl.FontWeight = FontWeights.Bold;
                /*
                if (font.Underline)
                    tb.TextDecorations.Add(TextDecorations.Underline);
                if (font.Strikeout)
                    tb.TextDecorations.Add(TextDecorations.Strikethrough);
                 */
            }
        }

        public static void ApplyFontToTextBlock(System.Drawing.Font font, TextBlock tb)
        {
            if (font != null)
            {
                tb.FontFamily = new FontFamily(font.FontFamily.Name);
                tb.FontSize = font.SizeInPoints * (96d / 72d);
                if (font.Italic)
                    tb.FontStyle = FontStyles.Italic;
                if (font.Bold)
                    tb.FontWeight = FontWeights.Bold;
                if (font.Underline)
                    tb.TextDecorations.Add(TextDecorations.Underline);
                if (font.Strikeout)
                    tb.TextDecorations.Add(TextDecorations.Strikethrough);
            }
        }

        public static Brush BrushFromGdiColor(System.Drawing.Color color)
        {
            return new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
        }

        public static DoubleCollection DashStyleToCollection(DashStyle dashStyle)
        {
            const int lDash = 8;
            const int lDot = 1;
            const int lSpace = 4;
            DoubleCollection dc = null;
            switch (dashStyle)
            {
                case DashStyle.Solid:
                    break;
                case DashStyle.Dash:
                    dc = new DoubleCollection() { lDash, lSpace };
                    break;
                case DashStyle.Dot:
                    dc = new DoubleCollection() { lDot, lSpace };
                    break;
                case DashStyle.DashDot:
                    dc = new DoubleCollection() { lDash, lSpace, lDot, lSpace };
                    break;
                case DashStyle.DashDotDot:
                    dc = new DoubleCollection() { lDash, lSpace, lDot, lSpace, lDot, lSpace };
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false, "Unknown dash style");
                    break;
            }
            return dc;
        }

        public static void ContentToHorzVertAlign(System.Drawing.ContentAlignment ca,
            out HorizontalAlignment horz, out VerticalAlignment vert)
        {
            switch (ca)
            {
                case System.Drawing.ContentAlignment.TopLeft:
                    horz = HorizontalAlignment.Left;
                    vert = VerticalAlignment.Top;
                    break;
                case System.Drawing.ContentAlignment.TopCenter:
                    horz = HorizontalAlignment.Center;
                    vert = VerticalAlignment.Top;
                    break;
                case System.Drawing.ContentAlignment.TopRight:
                    horz = HorizontalAlignment.Right;
                    vert = VerticalAlignment.Top;
                    break;
                case System.Drawing.ContentAlignment.MiddleLeft:
                    horz = HorizontalAlignment.Left;
                    vert = VerticalAlignment.Center;
                    break;
                case System.Drawing.ContentAlignment.MiddleCenter:
                    horz = HorizontalAlignment.Center;
                    vert = VerticalAlignment.Center;
                    break;
                case System.Drawing.ContentAlignment.MiddleRight:
                    horz = HorizontalAlignment.Right;
                    vert = VerticalAlignment.Center;
                    break;
                case System.Drawing.ContentAlignment.BottomLeft:
                    horz = HorizontalAlignment.Left;
                    vert = VerticalAlignment.Bottom;
                    break;
                case System.Drawing.ContentAlignment.BottomCenter:
                    horz = HorizontalAlignment.Center;
                    vert = VerticalAlignment.Bottom;
                    break;
                case System.Drawing.ContentAlignment.BottomRight:
                    horz = HorizontalAlignment.Right;
                    vert = VerticalAlignment.Bottom;
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false, "Unknown content alignment");
                    goto case System.Drawing.ContentAlignment.TopLeft;
            }
        }
        #endregion

        #region readonly attribute handling
        public static void SetReadOnlyAttribute(object component, string propName, bool isReadOnly)
        {
            SetReadOnlyAttribute(TypeDescriptor.GetProperties(component), propName, isReadOnly);
        }

        public static void SetReadOnlyAttribute(PropertyDescriptorCollection props, string propName, bool isReadOnly)
        {
            SetReadOnlyAttribute(props[propName], isReadOnly);
        }

        /// <summary>
        /// NOTE: Property MUST HAVE [ReadOnly(...)] specified already (in source)!!! otherwise this blows things up majorly.
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="isReadOnly"></param>
        public static void SetReadOnlyAttribute(PropertyDescriptor prop, bool isReadOnly)
        {
            // code from:
            // http://dotnetfacts.blogspot.com/2008/06/how-to-set-propertygrid-as-read-only.html
            var attr = prop.Attributes[typeof(ReadOnlyAttribute)];
            var field = attr.GetType().GetField("isReadOnly", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(attr, isReadOnly, BindingFlags.NonPublic | BindingFlags.Instance, null, null);
        }

        public static bool GetReadOnlyAttribute(object component, string propName)
        {
            return GetReadOnlyAttribute(TypeDescriptor.GetProperties(component), propName);
        }

        public static bool GetReadOnlyAttribute(PropertyDescriptorCollection props, string propName)
        {
            return GetReadOnlyAttribute(props[propName], propName);
        }

        public static bool GetReadOnlyAttribute(PropertyDescriptor prop)
        {
            var attr = prop.Attributes[typeof(ReadOnlyAttribute)];
            var field = attr.GetType().GetField("isReadOnly", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return (bool)field.GetValue(attr);
        }
        #endregion

        #region colors
        public static bool IsColorEmpty(System.Drawing.Color color)
        {
            return color.IsEmpty || color.ToArgb() == 0;
        }

        public static bool IsSameColors(System.Drawing.Color color1, System.Drawing.Color color2)
        {
            return color1.ToArgb() == color2.ToArgb();
        }

        // this and next method taken from
        // http://stackoverflow.com/questions/1940127/how-to-xmlserialize-system-drawing-font-class
        public static string FontToString(System.Drawing.Font font)
        {
            if (font == null)
                return null;
            try
            {
                System.ComponentModel.TypeConverter converter =
                    System.ComponentModel.TypeDescriptor.GetConverter(typeof(System.Drawing.Font));
                return converter.ConvertToString(font);
            }
            catch
            {
                return null;
            }
        }

        public static System.Drawing.Font StringToFont(string fontString)
        {
            try
            {
                System.ComponentModel.TypeConverter converter =
                    System.ComponentModel.TypeDescriptor.GetConverter(typeof(System.Drawing.Font));
                return (System.Drawing.Font)converter.ConvertFromString(fontString);
            }
            catch
            {
            return null;
            }
        }

        public static string ColorToString(System.Drawing.Color color)
        {
            return string.Format(CultureInfo.InvariantCulture, "#{0:X2}{1:X2}{2:X2}{3:X2}", color.A, color.R, color.G, color.B);
        }

        public static System.Drawing.Color StringToColor(string str)
        {
            if (string.IsNullOrEmpty(str))
                return System.Drawing.Color.Empty;

            try
            {
                var color = System.Drawing.Color.FromName(str);
                if (color.IsKnownColor)
                    return color;

                if (str.StartsWith("#"))
                    str = str.Substring(1);
                var n = Convert.ToInt32(str, 16);
                color = System.Drawing.Color.FromArgb(
                    (n >> 24) & 0xff,
                    (n >> 16) & 0xff,
                    (n >> 8) & 0xff,
                    n & 0xff);
                return color;
            }
            catch
            {
                return System.Drawing.Color.Empty;
            }
        }
        #endregion

        #region misc
        /// <summary>
        /// Generates a unique sequence of 16 hex digits.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Source: http://madskristensen.net/post/Generate-unique-strings-and-numbers-in-C.aspx
        /// </remarks>
        public static string GenerateId()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format(CultureInfo.InvariantCulture, "{0:x}", i - DateTime.Now.Ticks);
        }
        #endregion
    }
}
