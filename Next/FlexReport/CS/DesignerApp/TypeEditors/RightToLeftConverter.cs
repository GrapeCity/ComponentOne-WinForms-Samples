//----------------------------------------------------------------------------
// RightToLeftConverter.cs
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
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class RightToLeftConverter : TypeConverter
    {
        private static string s_Default = Strings.RightToLeftConverter.Default;
        private static string s_True = true.ToString();
        private static string s_False = false.ToString();

        #region Private
        private string GetDefaultValue(ITypeDescriptorContext context)
        {
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services))
                return s_Default;
            FieldBase field = instance as FieldBase;
            if (field != null)
                return s_Default + " (" + field.ParentReport.ActualRightToLeft.ToString() + ")";
            C1FlexReport report = instance as C1FlexReport;
            if (report != null)
                return s_Default + " (" + C1FlexReport.DefaultRightToLeft.ToString() + ")";
            return s_Default;
        }
        #endregion

        #region Public
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(new string[] { s_True, s_False, GetDefaultValue(context) });
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

            if (s == s_False)
                return (bool?)false;
            else if (s == s_True)
                return (bool?)true;
            else
                return (bool?)null;
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

            if (value is bool)
                return (bool)value ? s_True : s_False;
            else
                return GetDefaultValue(context);
        }
        #endregion
    }
}
