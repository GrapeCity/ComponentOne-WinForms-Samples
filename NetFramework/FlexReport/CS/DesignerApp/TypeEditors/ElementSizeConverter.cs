//----------------------------------------------------------------------------
// ElementSizeConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;

using C1.Chart;
using C1.Win.FlexReport;

namespace FlexReportDesignerApp
{
    /// <summary>
    /// <see cref="TypeConverter"/> used to edit properties of <see cref="C1.Chart.ElementSize"/> type.
    /// </summary>
    internal class ElementSizeConverter : TypeConverter
    {
        private static string[] s_Units = { "in", "\"", "pt", "pix", "cm", "mm", "tw", "%" };

        #region Public
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            ElementSize es = value as ElementSize;
            if (object.ReferenceEquals(es, null))
                return string.Empty;
            switch (es.SizeType)
            {
                case ElementSizeType.Absolute:
                    return es.Value.ToString(culture) + "tw";
                case ElementSizeType.Percentage:
                    return es.Value.ToString(culture) + "%";
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        /// <summary>
        /// Converts the given value to the type of this converter.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <param name="ci">The <see cref="CultureInfo"/> to use as the current culture.</param>
        /// <param name="value">The <see cref="Object"/> to convert.</param>
        /// <returns>An <see cref="C1.Chart.ElementSize"/> value that represents the converted value.</returns>
        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object value)
        {
            if (value is string)
            {
                // get string typed by the user
                double v;
                string s = (string)value;
                if (string.IsNullOrEmpty(s))
                    return null;

                // look for units in the string
                foreach (string unit in s_Units)
                {
                    int pos = s.IndexOf(unit);
                    if (pos < 0)
                        continue;

                    // found unit, try parsing the numeric part
                    s = s.Substring(0, pos);
                    if (!double.TryParse(s, NumberStyles.Any, ci, out v))
                        throw new ArgumentException();

                    // convert number into proper unit
                    switch (unit)
                    {
                        case "in":
                        case "\"":
                            return new ElementSize() { SizeType = ElementSizeType.Absolute, Value = Math.Round(v * 1440.0, 0) };
                        case "pt":
                            return new ElementSize() { SizeType = ElementSizeType.Absolute, Value = Math.Round(v * 1440.0 / 72.0, 0) };
                        case "cm":
                            return new ElementSize() { SizeType = ElementSizeType.Absolute, Value = Math.Round(v * 1440.0 / 2.54, 0) };
                        case "mm":
                            return new ElementSize() { SizeType = ElementSizeType.Absolute, Value = Math.Round(v * 1440.0 / 25.4, 0) };
                        case "pix": // assume 300 dpi
                            return new ElementSize() { SizeType = ElementSizeType.Absolute, Value = Math.Round(v * 1440.0 / 300.0, 0) };
                        case "tw":
                            return new ElementSize() { SizeType = ElementSizeType.Absolute, Value = v };
                        case "%":
                            return new ElementSize() { SizeType = ElementSizeType.Percentage, Value = v };
                    }
                }

                //
                if (double.TryParse(s, NumberStyles.Any, ci, out v))
                    return new ElementSize() { SizeType = ElementSizeType.Absolute, Value = v };
            }

            // not done, pass it on to base
            return base.ConvertFrom(ctx, ci, value);
        }
        #endregion
    }
}
