//----------------------------------------------------------------------------
// StatementEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Globalization;
using System.Drawing;

using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using Flex = C1.Win.FlexReport;
using Doc = C1.Win.C1Document;

namespace FlexReportDesignerApp
{
    public class StatementEditor : UITypeEditor
    {
        protected virtual bool IsExpression { get { return false; } }

        /// <summary>
        /// Gets the editor style used by the <see cref="EditValue"/> method.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <returns>Always returns <b>UITypeEditorEditStyle.Modal</b>.</returns>
        override public UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext ctx)
        {
            return (ctx != null && ctx.Instance != null && ctx.PropertyDescriptor != null)
                ? UITypeEditorEditStyle.Modal
                : base.GetEditStyle(ctx);
        }
        /// <summary>
        /// Edits the value of the specified object.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <param name="provider">An <see cref="IServiceProvider"/> through which editing services may be obtained.</param>
        /// <param name="value">An instance of the value being edited.</param>
        /// <returns>A string containing the new value of the object.</returns>
        override public object EditValue(ITypeDescriptorContext ctx, IServiceProvider provider, object value)
        {
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(ctx, out instance, out services))
                return value;

            IGetReportsService grs = services.GetGetReportService();
            IScriptEditorService ses = services.GetScriptEditorService();
            if (grs == null || ses == null)
                return value;

            var report = grs.Report;
            if (report == null)
                return value;

            // guess script context
            string dataSourceName;
            ScriptEditorContextKind contextKind;
            EditorScriptContextBase.GuessContextName(report, instance, ctx.PropertyDescriptor.Name, out dataSourceName, out contextKind);

            // Run the editor:
            object result;
            if (ses.EditScript(report, dataSourceName, contextKind, instance, ctx.PropertyDescriptor.Name, null, IsExpression, out result))
                return result;
                
            // editor was cancelled - return original value
            return value;
        }
    }

    public class ExpressionEditor : StatementEditor
    {
        protected override bool IsExpression { get { return true; } }
    }

    public class ScriptStringValueConverter : StringConverter
    {
        override public bool CanConvertFrom(ITypeDescriptorContext ctx, Type type)
        {
            if (type == typeof(string))
                return true;
            return base.CanConvertFrom(ctx, type);
        }
        override public object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object value)
        {
            var str = value as string;
            if (str == null)
                return base.ConvertFrom(ctx, ci, value);

            Type targetType;
            if (ctx != null && ctx.PropertyDescriptor != null)
                targetType = ctx.PropertyDescriptor.PropertyType;
            else
                targetType = typeof(string);

            return Util.ScriptValueHelper.FromString(str, targetType);
        }
        override public bool CanConvertTo(ITypeDescriptorContext ctx, Type type)
        {
            if (type == typeof(string))
                return true;
            return base.CanConvertTo(ctx, type);
        }
        override public object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
        {
            if (type == typeof(string))
                return Util.ScriptValueHelper.ToString(value);
            return base.ConvertTo(ctx, ci, value, type);
        }
    }

    /// <summary>
    /// <see cref="UITypeEditor"/> that provides a list of available text field names plus the option to type in an 
    /// expression using a script editor.
    /// </summary>
    /// <summary>
    /// <see cref="UITypeEditor"/> used to edit properties that represent report field names.
    /// </summary>
    /// <remarks>
    /// <para><see cref="ScriptStringValueEditor"/> shows a drop-down list that allows users to select report field names.</para>
    /// <para>The list includes a (Script Editor...) option that shows a dialog where the user can type complex expressions.</para>
    /// <para>You can use this <see cref="UITypeEditor"/> in classes that derive from <see cref="Field"/> to provide properties 
    /// that should be set to report field names.</para>
    /// </remarks>
    public class ScriptStringValueEditor : UITypeEditor
    {
        private IWindowsFormsEditorService _edSvc;
        private ScriptValueListBox _listBox;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptStringValueEditor"/> class.
        /// </summary>
        public ScriptStringValueEditor()
        {
            _listBox = new ScriptValueListBox();
            _listBox.BorderStyle = BorderStyle.None;
            _listBox.ItemSelected += (s_, e_) => { if (_edSvc != null) _edSvc.CloseDropDown(); };
        }

#if MAP
        internal ScriptValueListBox ListBox
        {
            get { return _listBox; }
        }
#endif

        public override bool IsDropDownResizable
        {
            get { return true; }
        }

        /// <summary>
        /// Gets the editor style used by the <see cref="EditValue"/> method.
        /// If there are available bindable fields, returns DropDown, otherwise Modal.
        /// </summary>
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext ctx)
        {
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(ctx, out instance, out services))
                return UITypeEditorEditStyle.None;

            if (ctx.PropertyDescriptor.PropertyType == typeof(ScriptEnumValue<SortDirection>))
            {
                _listBox.FillWithSortDirections();
            }
            else
            {
                var grs = services.GetGetReportService();
                if (grs == null)
                    return UITypeEditorEditStyle.None;

                C1FlexReport report = grs.Report;
                if (report == null)
                    return UITypeEditorEditStyle.None;

                string dataSourceName;
                ScriptEditorContextKind contextKind;
                EditorScriptContextBase.GuessContextName(report, instance, ctx.PropertyDescriptor.Name, out dataSourceName, out contextKind);

                if (contextKind == ScriptEditorContextKind.DataView)
                    return UITypeEditorEditStyle.Modal;

                if (contextKind == ScriptEditorContextKind.MetaView)
                    dataSourceName = report.DataSourceName;

                var ds = report.DataSources.FindByName(dataSourceName);
                _listBox.FillWithFields(report, ds, contextKind);
            }

            if (_listBox.Items.Count == 1) // just the expression editor
                return UITypeEditorEditStyle.Modal;

            // done
            return UITypeEditorEditStyle.DropDown;
        }

        /// <summary>
        /// Edits the value of the specified object.
        /// </summary>
        /// <param name="ctx">An <see cref="ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
        /// <param name="provider">An <see cref="IServiceProvider"/> through which editing services may be obtained.</param>
        /// <param name="value">An instance of the value being edited.</param>
        /// <returns>A string containing the new value of the object.</returns>
        public override object EditValue(ITypeDescriptorContext ctx, IServiceProvider provider, object value)
        {
            // sanity
            if (provider == null)
                return value;

            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(ctx, out instance, out services))
                return value;

            IGetReportsService grs = services.GetGetReportService();
            IScriptEditorService ses = services.GetScriptEditorService();
            if (grs == null || ses == null)
                return value;

            C1FlexReport report = grs.Report;
            if (report == null)
                return value;

            // Handle both string and ScriptStringValue properties:
            Type targetType = ctx != null && ctx.PropertyDescriptor != null ? ctx.PropertyDescriptor.PropertyType : typeof(string);

            // script editor call:
            Func<object, object> doEdit = (v_) =>
                {
                    string dataSourceName;
                    ScriptEditorContextKind contextKind;
                    EditorScriptContextBase.GuessContextName(report, instance, ctx.PropertyDescriptor.Name, out dataSourceName, out contextKind);
                    object result;
                    if (ses.EditScript(report, dataSourceName, contextKind, instance, ctx.PropertyDescriptor.Name, null, true, out result))
                        return result;
                    else
                        return v_;
                };

            // select editor style
            UITypeEditorEditStyle style = GetEditStyle(ctx);
            object retValue;
            switch (style)
            {
                case UITypeEditorEditStyle.None:
                    retValue = value;
                    break;
                case UITypeEditorEditStyle.Modal:
                    retValue = doEdit(value);
                    break;
                case UITypeEditorEditStyle.DropDown:
                    _edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
                    if (_edSvc != null)
                    {
                        // show the list
                        _edSvc.DropDownControl(_listBox);
                        _edSvc = null;
                        IScriptValueListItem selectedItem = _listBox.GetSelectedItem();
                        if (selectedItem == null)
                            retValue = value;
                        else if (selectedItem.IsScriptEditor)
                            retValue = doEdit(value);
                        else if (selectedItem.IsValue)
                            retValue = Util.ScriptValueHelper.TextToObject(selectedItem.Text, targetType, selectedItem.IsExpression);
                        else
                            retValue = value;
                    }
                    else
                        retValue = value;
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false);
                    retValue = null;
                    break;
            }
            // return whatever we got
            return retValue;
        }
    }
}
