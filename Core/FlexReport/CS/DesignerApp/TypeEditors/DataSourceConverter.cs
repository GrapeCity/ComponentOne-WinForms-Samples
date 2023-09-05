//----------------------------------------------------------------------------
// DataSourceConverter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
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
    /// <summary>
    /// Select data source from those defined in the report.
    /// </summary>
    internal class DataSourceConverter : ExpandableObjectConverter
    {
        // ExpandableObjectConverter 
        static internal readonly string c_strNone = Strings.Common.None;
        static private readonly string c_strUnavailFmt = Strings.Common.UnavailableFmt;

        private C1FlexReport GetReport(ITypeDescriptorContext context)
        {
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services))
                return null;
            IGetReportsService grs = services.GetGetReportService();
            if (grs == null)
                return null;
            return grs.Report;
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

            var report = GetReport(context);
            if (report == null)
                return base.ConvertFrom(context, culture, value);

            return report.DataSources.FindByName(s);
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
            var ds = value as DataSource;
            if (ds != null)
                return ds.Name;
            else
            {
                var report = GetReport(context);
                if (report != null && !string.IsNullOrEmpty(report.DataSourceName))
                    return string.Format(c_strUnavailFmt, report.DataSourceName);
            }
            return c_strNone;
        }
    }

    public class DataSourceEditor : UITypeEditor
    {
        private IWindowsFormsEditorService _edSvc;
        private ListBox _listBox;

        public DataSourceEditor()
        {
            _listBox = new ListBox();
            _listBox.BorderStyle = BorderStyle.None;
            _listBox.Click += new System.EventHandler(_listBox_Click);
            _listBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_listBox_KeyPress);
        }
        override public UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext ctx)
        {
            return UITypeEditorEditStyle.DropDown;
        }
        private void FillListBox(C1FlexReport report, object currentItem)
        {
            if (report == null)
                return;

            _listBox.BeginUpdate();
            _listBox.Items.Clear();
            _listBox.Items.Add(DataSourceConverter.c_strNone);
            _listBox.Items.AddRange(report.DataSources.Select(ds => ds.Name).ToArray());
            _listBox.EndUpdate();
        }
        override public object EditValue(ITypeDescriptorContext ctx, IServiceProvider provider, object value)
        {
            // sanity
            if (provider == null)
                return value;

            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(ctx, out instance, out services))
                return value;

            IGetReportsService grs = services.GetGetReportService();
            if (grs == null)
                return value;

            C1FlexReport report = grs.Report;
            if (report == null)
                return value;

            // show the list
            _edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (_edSvc == null)
                return value;
            FillListBox(report, instance);
            _edSvc.DropDownControl(_listBox);
            _edSvc = null;

            var name = _listBox.SelectedItem as string;
            if (string.IsNullOrEmpty(name))
                return null;
            else if (name == DataSourceConverter.c_strNone)
            {
                // This is a patch: if we had a non-empty but invalid DataSourceName, and have selected "(none)",
                // prop grid would see the same in and out value (null) and won't fire the change.
                // So we push the undo and reset DataSourceName right here.
                // This is all very fishy, and should be replaced by editing the DataSourceName itself. --dima.
                if (!string.IsNullOrEmpty(report.DataSourceName))
                {
                    MainForm.TheMainForm.PushPendingUndoState();
                    report.DataSourceName = null;
                }
                return null;
            }
            else
                return report.DataSources.FindByName(name);
        }
        private void _listBox_Click(object sender, System.EventArgs e)
        {
            if (_edSvc != null)
                _edSvc.CloseDropDown();
        }
        private void _listBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)27:
                    _listBox.SelectedIndex = -1;
                    if (_edSvc != null)
                        _edSvc.CloseDropDown();
                    break;
                case (char)13:
                    if (_edSvc != null)
                        _edSvc.CloseDropDown();
                    break;
            }
        }
    }

    internal class ChartDataSourceConverter : TypeConverter
    {
        private const string DefaultDataSource = "(Default)";

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

            return s == DefaultDataSource ? string.Empty : s;
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
