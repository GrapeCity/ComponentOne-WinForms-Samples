//----------------------------------------------------------------------------
// ParameterValueEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Windows.Forms.Design;
using C1.Win.C1Document;
using C1.Win.C1FlexGrid;
using C1.Win.C1Themes;
using C1.Win.FlexReport;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class ParameterValueEditor : CollectionEditor
    {
        private ReportParameter _parameter;
        private bool _canceled;

        public ParameterValueEditor() : base(typeof (List<object>))
        {
            
        }

        protected override Type CreateCollectionItemType()
        {
            if (_parameter == null) return base.CreateCollectionItemType();

            switch (_parameter.DataType)
            {
                case ParameterType.Boolean:
                    return typeof(bool);
                case ParameterType.DateTime:
                case ParameterType.Time:
                case ParameterType.Date:
                    return typeof(DateTime);
                case ParameterType.Float:
                    return typeof(double);
                case ParameterType.Integer:
                    return typeof(int);
                case ParameterType.String:
                    return typeof(string);
            }

            return typeof(string);
        }

        protected override object CreateInstance(Type itemType)
        {
            return GetDefaultValue(itemType);
        }

        protected override void CancelChanges()
        {
            _canceled = true;
            base.CancelChanges();
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            var model = context.Instance as EditableModel;
            var realInstance = (model != null) ? model.Instance : context.Instance;
            var parameter = realInstance as ReportParameter;
            if (parameter == null) return UITypeEditorEditStyle.None;

            return parameter.MultiValue ? UITypeEditorEditStyle.Modal : UITypeEditorEditStyle.None;
        }
        
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc == null) return base.EditValue(context, provider, value);

            var model = context.Instance as EditableModel;
            var realInstance = (model != null) ? model.Instance : context.Instance;
            var parameter = realInstance as ReportParameter;
            if (parameter == null) return base.EditValue(context, provider, value);
            _parameter = parameter;

            var items = EnsureValueDataType(value, parameter.DataType, parameter.ParentReport.ActualCulture);
            var list = new List<object>(items);
            _canceled = false;
            var result = base.EditValue(context, provider, list);
            if (_canceled) return value;

            var newValue = ResolveValue(((List<object>) result).ToArray(), parameter.DataType, parameter.MultiValue);
            return newValue;
        }

        public static object ResolveValue(object[] array, ParameterType dataType, bool multivalue)
        {
            if (array == null || array.Length == 0) return null;
            return (multivalue || array.Length > 1) ? array : array[0];
       }

        public static object[] EnsureValueDataType(object value, ParameterType dataType, CultureInfo culture)
        {
            var list = new List<object>();
            if (value == null) return list.ToArray();

            if (!(value is Array))
            {
                var value2 = EnsureValueDataType2(value, dataType, culture, false);
                if (value2 != null)
                    list.Add(value2);
            }
            else
            {
                var array = (Array)value;
                var len = array.GetLength(0);
                for (int i = 0; i < len; i++)
                {
                    var value2 = EnsureValueDataType2(array.GetValue(i), dataType, culture, false);
                    if (value2 != null) list.Add(value2);
                }
            }

            return list.ToArray();
        }

        public static object EnsureValueDataType2(object value, ParameterType dataType, CultureInfo culture, bool throwException)
        {
            if (value == null) return null;

            try
            {
                switch (dataType)
                {
                    case ParameterType.Boolean:
                        return Convert.ToBoolean(value, culture);
                    case ParameterType.DateTime:
                    case ParameterType.Time:
                    case ParameterType.Date:
                        return Convert.ToDateTime(value, culture);
                    case ParameterType.Float:
                        // all other components Viewer, C1SSRSDocumentSource etc etc interpret 
                        // ParameterType.Float as double value
                        return Convert.ToDouble(value, culture);
                    case ParameterType.Integer:
                        return Convert.ToInt32(value, culture);
                    case ParameterType.String:
                        return Convert.ToString(value, culture);
                }
            }
            catch
            {
                if (value is string && ((string) value).Length == 0) return null;

                if (!throwException)
                    return null;

                throw;
            }

            return value;
        }

        private static object GetDefaultValue(Type type)
        {
            if (type == typeof (bool))
                return false;
            if (type == typeof (DateTime))
                return DateTime.Now;
            if (type == typeof (float))
                return 0f;
            if (type == typeof (int))
                return 0;

            return "";
        }
    }
}
