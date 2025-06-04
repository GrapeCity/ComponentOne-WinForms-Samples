using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if WINFORMS
using System.Drawing;
using C1.Win.Chart;
#endif
#if WPF
using C1.WPF.Chart;
#endif

namespace C1.Chart.Legacy.Serialization
{
    /// <summary>
    /// This utility class both stores and restores information about a FlexChart _Style object to and from a string, respectively.
    /// </summary>
    class StyleSerializer
    {
        /// <summary>
        /// StyleToString stores information contained in the FlexChart _Style object as a string.
        /// </summary>
        /// <param name="style">Specifies the FlexChart _Style object with information to be stored as a string.</param>
        /// <param name="conv">Specifies an instance of a FlexChart which can be used to convert FlexChart brush
        ///                    information into string.</param>
        /// <returns>This static method returns a string containing the _Style information available.</returns>
        public static string StyleToString(_Style style, IBrushConverter conv)
        {
            if (style == null)
                return null;

            var s = new StringBuilder();
            if (style.Fill != null)
                s.AppendFormat("Fill:{0};", conv.Convert(style.Fill));
            if (style.Stroke != null)
                s.AppendFormat("Stroke:{0};", conv.Convert(style.Stroke));
            if(style.StrokeThickness != 0)
                s.AppendFormat("StrokeThickness:{0};", style.StrokeThickness);
            if (style.HAlign != 0)
                s.AppendFormat("HAlign:{0};", style.HAlign);

            // font
            if (style.Font != null)
            {
                string fontStrings = getFontStrings(style);
                if (fontStrings != null)
                {
                    s.AppendFormat("Font:{0};", fontStrings);
                }
            }

            // stroke dashes
            if (style.StrokePattern != null && style.StrokePattern.Length > 0)
            {
                string strokePattern = string.Concat(style.StrokePattern.Select<double, string>(
                    sp => "," + sp.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                s.AppendFormat("StrokePattern:{0};", strokePattern.Substring(1));
            }
            return s.ToString();
        }

        /// <summary>
        /// StyleFromString creates a new FlexChart _Style object with the information stored in a specified
        /// string create with the StyleToString method.
        /// </summary>
        /// <param name="s">Specifies the string containing the FlexChart _Style information.</param>
        /// <returns></returns>
        public static _Style StyleFromString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;

            var style = new _Style();
            var pairs = s.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var pair in pairs)
            {
                var parts = pair.Split(':');
                if (parts.Length == 2)
                {
                    switch (parts[0])
                    {
                        case "Stroke":
                            style.Stroke = int.Parse(parts[1], System.Globalization.NumberStyles.AllowHexSpecifier);
                            break;
                        case "Fill":
                            style.Fill = int.Parse(parts[1], System.Globalization.NumberStyles.AllowHexSpecifier);
                            break;
                        case "StrokeThickness":
                            style.StrokeThickness = double.Parse(parts[1]);
                            break;
                        case "HAlign":
                            style.HAlign = int.Parse(parts[1]);
                            break;
                        case "Font":
                            setFontFromStrings(style, parts[1]);
                            break;
                        case "StrokePattern":
                            style.StrokePattern = parts[1].Split(',').Select<string, double>(
                                sd => double.Parse(sd, System.Globalization.CultureInfo.InvariantCulture)).ToArray();
                            break;
                    }
                }
            }

            return style;
        }

#if WINFORMS
        static string getFontStrings(_Style sty)
        {
            if (sty != null && sty.Font != null)
            {
                Font font = sty.Font as Font;
                if (font != null && font.FontFamily != null && !string.IsNullOrWhiteSpace(font.FontFamily.Name))
                {
                    string fontFamilyName = font.FontFamily.Name;
                    string fontStretchName = "Normal";
                    string fontWeightName = font.Bold ? "Bold" : "Normal";
                    string fontStyleName = font.Italic ? "Italic" : "Normal";
                    double fontSizePX = font.SizeInPoints * 96 / 72;   // per Microsoft, 96/inch is fixed for WPF.

                    return fontFamilyName + "," + fontSizePX.ToString() + "," + fontStretchName + "," +
                        fontWeightName + "," + fontStyleName;
                }
            }
            return null;
        }

        static void setFontFromStrings(_Style style, string fontStrings)
        {
            if (style != null && !string.IsNullOrWhiteSpace(fontStrings))
            {
                string[] fs = fontStrings.Split(',');

                string fontFamilyName = null;
                string fontStretchName = "Normal";
                string fontWeightName = "Normal";
                string fontStyleName = "Normal";
                double fontSizePX = -1;

                if (fs.Length == 0 || string.IsNullOrWhiteSpace(fs[0]))
                    return;

                fontFamilyName = fs[0];

                if(fs.Length > 1 && !string.IsNullOrWhiteSpace(fs[1]))
                {
                    double fsize = 0.0;
                    if (double.TryParse(fs[1], out fsize) && fsize > 1)
                        fontSizePX = fsize;
                }

                if (fs.Length > 2 && !string.IsNullOrWhiteSpace(fs[2]))
                    fontStretchName = fs[2];

                if (fs.Length > 3 && !string.IsNullOrWhiteSpace(fs[3]))
                    fontWeightName = fs[3].Trim();

                if (fs.Length > 4 && !string.IsNullOrWhiteSpace(fs[4]))
                    fontStyleName = fs[4].Trim();


                FontStyle fstyle = FontStyle.Regular;

                if (fontWeightName.IndexOf("bold", StringComparison.OrdinalIgnoreCase) > -1 ||
                    fontWeightName.IndexOf("blank", StringComparison.OrdinalIgnoreCase) > -1)
                    fstyle |= FontStyle.Bold;

                if (fontStyleName.IndexOf("italic", StringComparison.OrdinalIgnoreCase) > -1 ||
                    fontStyleName.IndexOf("oblique", StringComparison.OrdinalIgnoreCase) > -1)
                    fstyle |= FontStyle.Italic;

                float fontSize = (fontSizePX > 0) ? (float)(fontSizePX * 72 / 96) : 10f;
                Font font = new Font(fontFamilyName, fontSize, fstyle);

                style.Font = font;
            }
            return;
        }
#endif

#if WPF
        static string getFontStrings(_Style sty)
        {
            ChartStyle cstyle = new ChartStyle(sty);
            if(cstyle != null && cstyle.FontFamily != null)
            {
                return cstyle.FontFamily.Source + "," +
                    cstyle.FontSize.ToString() + "," +
                    cstyle.FontStretch.ToString() + "," +
                    cstyle.FontWeight.ToString() + "," +
                    cstyle.FontStyle.ToString();
            }
            return null;
        }

        static object getStaticPropertyValue(string namedStaticProperty, Type propertyParentType, object defaultValue)
        {
            object returnProp = defaultValue;
            try
            {
                var propertyInfo = propertyParentType.GetProperty(namedStaticProperty);
                returnProp = propertyInfo.GetAccessors()[0].Invoke(null, null);
            }
            catch { }
            return returnProp;
        }

        static void setFontFromStrings(_Style style, string fontStrings)
        {
            ChartStyle sty = new ChartStyle(style);

            // fontStrings appears like "FontFamily,FontSize,FontStretch,FontWeight,FontStyle";
            string[] fs = fontStrings.Split(',');

            System.Windows.Media.FontFamily fontFamily = null;
            double fontSize = -1.0;

            var fontStretch = System.Windows.FontStretches.Normal;
            var fontWeight = System.Windows.FontWeights.Normal;
            var fontStyle = System.Windows.FontStyles.Normal;

            // FontFamily
            if (fs.Length > 0 && !string.IsNullOrWhiteSpace(fs[0]))
            {
                try { fontFamily = new System.Windows.Media.FontFamily(fs[0].Trim()); }
                catch { }
            }

            // FontSize
            if (fs.Length > 1 && !string.IsNullOrWhiteSpace(fs[1]))
            {
                double fsize = 0.0;
                if (double.TryParse(fs[1].Trim(), out fsize))
                    fontSize = fsize;
            }

            // FontStretch
            if (fs.Length > 2 && !string.IsNullOrWhiteSpace(fs[2]))
            {
                fontStretch = (System.Windows.FontStretch)
                    getStaticPropertyValue(fs[2].Trim(), typeof(System.Windows.FontStretches), fontStretch);
            }

            // FontWeight
            if (fs.Length > 3 && !string.IsNullOrWhiteSpace(fs[3]))
            {
                fontWeight = (System.Windows.FontWeight)
                    getStaticPropertyValue(fs[3].Trim(), typeof(System.Windows.FontWeights), fontWeight);
            }

            // FontStyle
            if (fs.Length > 4 && !string.IsNullOrWhiteSpace(fs[4]))
            {
                fontStyle = (System.Windows.FontStyle)
                    getStaticPropertyValue(fs[4].Trim(), typeof(System.Windows.FontStyles), fontStyle);
            }

            if (fontFamily != null)
                sty.FontFamily = fontFamily;
            if (fontSize > 0.0)
                sty.FontSize = fontSize;

            sty.FontStretch = fontStretch;
            sty.FontWeight = fontWeight;
            sty.FontStyle = fontStyle;

            style.Font = sty.ToStyle().Font;
        }
#endif
    }
}
