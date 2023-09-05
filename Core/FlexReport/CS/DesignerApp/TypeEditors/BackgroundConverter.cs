//----------------------------------------------------------------------------
// BackgroundConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Win.Document;
using Utils = FlexReportDesignerApp.Controls.Background.Utils;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class BackgroundConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof (string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var s = value as string;
            if (s == null)
                return base.ConvertFrom(context, culture, value);

            if (string.IsNullOrEmpty(s))
                return new C1SolidBrush(Color.Transparent);

            try
            {
                var color = Utils.ColorFromString(s);
                return new C1SolidBrush(color);
            }
            catch (Exception)
            {
                throw new Exception(string.Format(Strings.BackgroundConverter.ErrorInvalidColor, s));
            }
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof (string))
            {
                var solidBrush = value as C1SolidBrush;
                if (solidBrush != null)
                {
                    return Utils.ColorToString(solidBrush.Color);
                }

                var linearBrush = value as C1LinearBrush;
                if (linearBrush != null)
                {
                    return "Linear Brush";
                }

                var radialBrush = value as C1RadialBrush;
                if (radialBrush != null)
                {
                    return "Radial Brush";
                }

                return "Transparent";
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
