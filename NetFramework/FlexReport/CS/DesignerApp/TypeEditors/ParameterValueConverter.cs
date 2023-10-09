//----------------------------------------------------------------------------
// ParameterValueConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using C1.Win.C1Document;
using C1.Win.FlexReport;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class ParameterValueConverter :TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if(sourceType == typeof (string))
            {
                var parameter = GetParameter(context);
                return parameter != null && !parameter.MultiValue;
            }

            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
            Type destinationType)
        {
            if (destinationType == typeof (string))
            {
                var parameter = GetParameter(context);
                if (parameter == null) return base.ConvertTo(context, culture, value, destinationType);

                var dataType = parameter.DataType;
                var array = value as Array;
                if (array == null)
                {
                    if (value == null) return base.ConvertTo(context, culture, value, destinationType);
                    return GetValueString(value, dataType, culture);
                }
                else
                {
                    var sb = new StringBuilder();
                    sb.Append("[");
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        object v = array.GetValue(i);
                        sb.Append(GetValueString(v, dataType, culture));

                        sb.Append(", ");
                    }
                    if (sb.Length > 1) sb.Remove(sb.Length - 2, 2);
                    sb.Append("]");
                    return sb.ToString();
                }
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var s = value as string;
            if(s==null) return base.ConvertFrom(context, culture, value);

            var parameter = GetParameter(context);
            if (parameter == null) return base.ConvertFrom(context, culture, value);

            bool isArray = false;
            if (s.StartsWith("[") && s.EndsWith("]"))
            {
                isArray = true;
                s = s.Substring(1, s.Length - 2);
            }

            var dataType = parameter.DataType;
            var result = new List<object>();
            if (!isArray)
            {
                var value2 = ParameterValueEditor.EnsureValueDataType2(s, dataType, culture, true);
                if (value2 != null) result.Add(value2);
            }
            else
            {
                var ss = s.Split(',');
                foreach (var singleValue in ss)
                {
                    var value2 = ParameterValueEditor.EnsureValueDataType2(singleValue.Trim(), dataType, culture, true);
                    if (value2 != null) result.Add(value2);
                }
            }

            return ParameterValueEditor.ResolveValue(result.ToArray(), dataType, parameter.MultiValue);
        }

        private ReportParameter GetParameter(ITypeDescriptorContext context)
        {
            var model = context.Instance as EditableModel;
            var realInstance = (model != null) ? model.Instance : context.Instance;
            var parameter = realInstance as ReportParameter;
            return parameter;
        }

        private string GetValueString(object value, ParameterType dataType, CultureInfo culture)
        {
            if (value == null) return string.Empty;

            if (value is DateTime)
            {
                if (dataType == ParameterType.DateTime)
                    return ((DateTime)value).ToString(culture);
                else if (dataType == ParameterType.Time)
                    return ((DateTime)value).ToString("T", culture);
                else if (dataType == ParameterType.Date)
                    return ((DateTime)value).ToString("d", culture);
            }
            return value.ToString();
        }
    }
}
