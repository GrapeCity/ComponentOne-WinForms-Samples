//----------------------------------------------------------------------------
// PictureHolderEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using C1.Win.FlexReport;
using FlexReportDesignerApp.Controls;
using FlexReportDesignerApp.Forms;
using FlexReportDesignerApp.Util;
using FieldInfo = C1.Win.FlexReport.FieldInfo;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.TypeEditors
{
    internal class PictureHolderEditor : UITypeEditor
    {
        private IWindowsFormsEditorService _editorService;

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            _editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            if (_editorService == null)
                return base.EditValue(context, provider, value);
            if (context == null || context.PropertyDescriptor == null)
                return base.EditValue(context, provider, value);

            object instance;
            FlexDesignerHostServices services;
            Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services);
            using (var form = new PictureHolderEditorForm())
            {
                form.Init(services, instance, context.PropertyDescriptor.Name, value, SupportExpression());
                if (_editorService.ShowDialog(form) == DialogResult.OK)
                {
                    value = form.Value;
                }
            }

            return value;
        }

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(PaintValueEventArgs e)
        {
            var pictureHolder = e.Value as PictureHolder;
            if (pictureHolder == null) return;

            if (pictureHolder.Image != null)
            {
                e.Graphics.DrawImage(pictureHolder.Image, e.Bounds);
                return;
            }

            var resourceName = GetPictureSourceResourceName(pictureHolder);
            if (string.IsNullOrEmpty(resourceName)) return;

            var image = AppUtils.LoadResourceImage(resourceName);
            if (image == null) return;

            e.Graphics.DrawImage(image, e.Bounds);
            image.Dispose();
        }

        protected virtual bool SupportExpression()
        {
            return true;
        }

        protected IScriptEditorService GetScriptService(ITypeDescriptorContext context)
        {
            object instance;
            FlexDesignerHostServices services;
            if (!Util.EditableModelHelper.GetInstanceAndServices(context, out instance, out services))
                return null;

            return services.GetScriptEditorService();
        }

        protected C1FlexReport GetReport(ITypeDescriptorContext context)
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

        private string GetPictureSourceResourceName(PictureHolder picture)
        {
            if (picture == null) return null;

            switch (picture.Type)
            {
                case PictureHolderType.File:
                    return "PictureHolderSource_File.png";
                case PictureHolderType.Url:
                    return "PictureHolderSource_URL.png";
                case PictureHolderType.Expression:
                    return "PictureHolderSource_Expression.png";
                case PictureHolderType.Image:
                    return "PictureHolderSource_Image.png";
            }
            return null;
        }
    }

    internal class FieldPictureHolderEditor : PictureHolderEditor
    {
        private readonly string EditorText = Strings.PictureHolderEditor.EditorText;
        private const int MaxDisplayListBoxItems = 10;

        private IWindowsFormsEditorService _editorService;
        private List<FieldInfo> _dbFields;

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
           return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            _editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            if (_editorService == null)
                return base.EditValue(context, provider, value);

            var report = GetReport(context);
            if (report == null)
            {
                return base.EditValue(context, provider, value);
            }

            var listBox = new ListBoxEx
            {
                BorderStyle = BorderStyle.None,
                PaintIndicatorSupported = true,
                ItemHeight = 20
            };
            listBox.Click += listBox_Click;
            listBox.PaintIndicator += listBox_PaintIndicator;
            listBox.Items.Add(EditorText);

            _dbFields = new List<FieldInfo>();
            _dbFields.AddRange(report.DataSource.DataSourceInfo.ImageFields);
            foreach (var dbField in report.DataSource.DataSourceInfo.TextFields)
            {
                if(dbField.DataType == typeof(string))
                    _dbFields.Add(dbField);
            }
            listBox.Items.AddRange(_dbFields.Select(f=>(object)f.Name).ToArray());

            var itemsToDisplay = Math.Min(MaxDisplayListBoxItems, listBox.Items.Count);
            listBox.Height = itemsToDisplay*listBox.ItemHeight;
            if (value != null)
            {
                listBox.SelectedItem = value.ToString();
            }

            _editorService.DropDownControl(listBox);

            if (listBox.SelectedIndex == 0)
            {
                value = base.EditValue(context, provider, value);
            }
            else if (listBox.SelectedIndex > 0)
            {
                var fieldName = listBox.SelectedItem.ToString();
                value = PictureHolder.FromExpression(fieldName);
            }

            _dbFields = null;
            return value;
        }

        void listBox_PaintIndicator(object sender, ListBoxEx.PaintIndicatorEventArgs e)
        {
            if (e.Index <= 0 || e.Index > _dbFields.Count) return;

            var dbField = _dbFields[e.Index - 1];
            var isImage = dbField.DataType == typeof(byte[]) || dbField.DataType == typeof(Image);
            var resourceName = isImage ? "DBImageField.png" : "DBTextField.png";
            var image = AppUtils.LoadResourceImage(resourceName);
            if (image == null) return;

            e.Graphics.DrawImage(image,e.Bounds);
            image.Dispose();
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            if (((ListBoxEx)sender).SelectedIndex >= 0)
                _editorService.CloseDropDown();
        }
    }

    internal class ChartObjectPictureHolderEditor : PictureHolderEditor
    {
        protected override bool SupportExpression()
        {
            return false;
        }
    }
}
