//----------------------------------------------------------------------------
// ShapeConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
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
using System.Windows.Forms.Design;
using System.Globalization;

using C1.Win.C1Document;
using NSD = C1.Win.Interop;
using Doc = C1.Win.C1Document;

namespace FlexReportDesignerApp.TypeEditors
{
    public class ShapeConverter : ExpandableObjectConverter
    {
        private static readonly StandardValuesCollection s_Values = new StandardValuesCollection(Enum.GetNames(typeof(ShapeType)));

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }

        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return s_Values;
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var s = value as string;
            if (s == null)
                return base.ConvertFrom(context, culture, value);

            ShapeType shapeType;
            if (!Enum.TryParse(s, out shapeType))
                return base.ConvertFrom(context, culture, value);

            return ShapeBase.CreateShape(shapeType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
                return true;
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType != typeof(string))
                return base.ConvertTo(context, culture, value, destinationType);
            if (value is string)
                return value;
            if (value == null)
                return ShapeType.None.ToString();
            ShapeBase shapeBase = value as ShapeBase;
            if (shapeBase != null)
                return shapeBase.ShapeType.ToString();
            else
                return ShapeType.None.ToString();
        }
    }
}
