//----------------------------------------------------------------------------
// AllowedValuesDefinitionConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
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

namespace FlexReportDesignerApp.TypeEditors
{
    internal class AllowedValuesDefinitionConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof (string))
            {
                var model = context.Instance as EditableModel;
                var realInstance = (model != null) ? model.Instance : context.Instance;
                var parameter = realInstance as ReportParameter;
                if(parameter==null)
                    return base.ConvertTo(context, culture, value, destinationType);

                if (IsEmpty(parameter))
                {
                    return "(None)";
                }
                if (parameter.AllowedValuesDefinition.Values.Count == 0)
                {
                    return string.Format("(<{0}> Data Source)", parameter.AllowedValuesDefinition.Binding.DataSourceName);
                }
                else
                {
                    return "(Values Collection)";
                }
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        private bool IsEmpty(ReportParameter parameter)
        {
            return parameter.AllowedValuesDefinition.Values.Count == 0
                   && string.IsNullOrEmpty(parameter.AllowedValuesDefinition.Binding.DataSourceName)
                   && string.IsNullOrEmpty(parameter.AllowedValuesDefinition.Binding.LabelExpression)
                   && string.IsNullOrEmpty(parameter.AllowedValuesDefinition.Binding.ValueExpression);
        }
    }
}
