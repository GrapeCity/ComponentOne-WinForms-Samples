//----------------------------------------------------------------------------
// OutlineParentEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
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

using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using Flex = C1.Win.FlexReport;
using Doc = C1.Win.C1Document;

namespace FlexReportDesignerApp
{
    // TODO: this editor shows a plain list of item names. It would be much better to 
    // show different item types differently, in a tree etc.
    public class OutlineParentEditor : UITypeEditor
    {
        private IWindowsFormsEditorService _edSvc;
        private ListBox _listBox;

        public OutlineParentEditor()
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
            foreach (var g in report.Groups.Where(g_ => !string.IsNullOrEmpty(g_.Name) && g_ != currentItem))
                _listBox.Items.Add(g.Name);
            foreach (var s in C1FlexReportDesigner.GetSectionsInDesignerOrder(report))
            {
                if (s != currentItem)
                    _listBox.Items.Add(s.Name);
                foreach (var ss in s.SubSections)
                {
                    if (!string.IsNullOrEmpty(ss.Name) && ss != currentItem)
                        _listBox.Items.Add(ss.Name);
                    _listBox.Items.AddRange(ss.Fields.Where(ff_ => ff_ != currentItem).Select(f_ => f_.Name).Where(n_ => !string.IsNullOrEmpty(n_)).ToArray());
                }
            }
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

            return _listBox.SelectedItem;
        }
        private void _listBox_Click(object sender, System.EventArgs e)
        {
            if (_edSvc != null)
                _edSvc.CloseDropDown();
        }
        private void _listBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
}
