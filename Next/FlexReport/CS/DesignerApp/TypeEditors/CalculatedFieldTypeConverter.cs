//----------------------------------------------------------------------------
// CalculatedFieldTypeConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class CalculatedFieldTypeConverter : TypeConverter
    {
        private static List<Type> s_types = new List<Type>()
        {
            typeof(String),
            typeof(int),
            typeof(float),
            typeof(double),
            typeof(bool),
            typeof(DateTime),
            typeof(byte[]),
        };
        private static StandardValuesCollection s_values = new StandardValuesCollection(s_types);

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return s_values;
        }
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            return base.CanConvertFrom(context, sourceType);
        }
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
                return true;
            return base.CanConvertTo(context, destinationType);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var s = value as string;
            if (s == null)
                return base.ConvertFrom(context, culture, value);

            return s_types.Find(t_ => t_.Name == s);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType != typeof(string) || !(value is Type))
                return base.ConvertTo(context, culture, value, destinationType);

            return ((Type)value).Name;
        }
    }
}
