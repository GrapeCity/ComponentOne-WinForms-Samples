//----------------------------------------------------------------------------
// CMapDataSourceConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.ComponentModel;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.TypeEditors.CustomMapField
{
    internal class CMapDataSourceConverter : TypeConverter
    {
        private const string DefaultDataSource = "(Report Data)";

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            var report = GetReport(context);
            if (report == null)
                return base.GetStandardValues(context);

            var values = new List<string> { DefaultDataSource };
            values.AddRange(report.DataSources.Select(ds => ds.Name));
            return new StandardValuesCollection(values);
        }

        private C1FlexReport GetReport(ITypeDescriptorContext context)
        {
            object instance;
            FlexDesignerHostServices services;
            Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services);
            if (services != null)
            {
                var grs = services.GetGetReportService();
                if (grs != null)
                    return grs.Report;
            }
            var field = instance as FieldBase;
            if (field != null)
                return field.ParentReport;

            return null;
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var s = value as string;
            if (s == null)
                return base.ConvertFrom(context, culture, value);

            var report = GetReport(context);
            if (report != null && !report.DataSources.Contains(s))
                s = string.Empty;

            return s;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType != typeof(string))
                return base.ConvertTo(context, culture, value, destinationType);

            var s = value == null ? "" : value.ToString();
            return string.IsNullOrEmpty(s) ? DefaultDataSource : s;
        }
    }
}
