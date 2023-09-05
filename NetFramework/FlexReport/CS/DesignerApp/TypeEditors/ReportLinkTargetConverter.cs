//----------------------------------------------------------------------------
// ReportLinkTargetConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
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
using C1.Win.FlexReport;
using NSD = C1.Win.Interop;
using Doc = C1.Win.C1Document;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class ReportLinkTargetConverter : ExpandableObjectModelConverter
    {
        private static Dictionary<string, Type> s_Aliases;
        private static readonly StandardValuesCollection s_Values;

        static ReportLinkTargetConverter()
        {
            s_Aliases = new Dictionary<string, Type>();
            s_Aliases.Add("Bookmark", typeof(ReportLinkTargetBookmark));
            s_Aliases.Add("Url", typeof(ReportLinkTargetUrl));
            s_Aliases.Add("Script", typeof(ReportLinkTargetScript));
            string[] keys = new string[s_Aliases.Count];
            int i = 0;
            foreach (KeyValuePair<string, Type> kvp in s_Aliases)
                keys[i++] = kvp.Key;
            s_Values = new StandardValuesCollection(keys);
        }

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

            Type type;
            if (!s_Aliases.TryGetValue(s, out type))
                return base.ConvertFrom(context, culture, value);

            return Activator.CreateInstance(type);
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
            ReportLinkTargetBase rlt = value as ReportLinkTargetBase;
            if (rlt != null)
            {
                Type type = rlt.GetType();
                foreach (KeyValuePair<string, Type> kvp in s_Aliases)
                    if (kvp.Value == type)
                        return kvp.Key;
            }
            return string.Empty;
        }
    }
}
