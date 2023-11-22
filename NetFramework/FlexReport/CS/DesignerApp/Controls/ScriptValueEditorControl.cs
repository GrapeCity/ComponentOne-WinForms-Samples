//----------------------------------------------------------------------------
// ScriptValueEditorControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Input;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp.Controls
{
    internal class ScriptValueListForm : DropDownForm
    {
        private readonly ScriptValueListBox _listBox;
        private int _maxDropDownItem = 8;

        public ScriptValueListForm()
        {
            Options = DropDownFormOptionsFlags.Focusable | DropDownFormOptionsFlags.FixedSize;

            _listBox=new ScriptValueListBox();
            _listBox.ItemSelected += ListBoxItemSelected;
            _listBox.Dock = DockStyle.Fill;
            _listBox.BorderStyle = BorderStyle.None;
            _listBox.Parent = this;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ScriptValueListBox ListBox
        {
            get { return _listBox; }
        }

        [DefaultValue(8)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MaxDropDownHeight
        {
            get { return _maxDropDownItem; }
            set { _maxDropDownItem = value; }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                if (_listBox != null)
                    FocusControl = _listBox;
            }
        }

        private void ListBoxItemSelected(object sender, EventArgs e)
        {
            CloseDropDown();
        }

        public void UpdatePerferedSize(Size ownerSize)
        {
            var size = _listBox.GetPreferredSize(Size);
            var maxHeight = _listBox.ItemHeight * _maxDropDownItem;
            var width = Math.Max(size.Width, ownerSize.Width);
            var height = Math.Min(size.Height, maxHeight);
            Size = new Size(width, height);
        }
    }

    internal class ScriptValueEditorControl : C1DropDownControl
    {
        private IServiceProvider _provider;
        private string _scriptSource = "";
        private string _scriptName = "";
        private ScriptEditorContextKind _kind = ScriptEditorContextKind.ReportScript;
        private bool _showImageFields;
        private C1FlexReport _report;
        private readonly ScriptValueListBox _listBox;

        public ScriptValueEditorControl()
        {
            _listBox = DropDownForm.ListBox;
            VisibleButtons = DropDownControlButtonFlags.DropDown;
        }

        [DefaultValue("")]
        public string ScriptSource
        {
            get { return _scriptSource; }
            set
            {
                if (_scriptSource == value) return;
                _scriptSource = value;
                PopulateFields();
            }
        }

        [DefaultValue("")]
        public string ScriptName
        {
            get { return _scriptName; }
            set { _scriptName = value; }
        }

        [DefaultValue(ScriptEditorContextKind.ReportScript)]
        public ScriptEditorContextKind ScriptKind
        {
            get { return _kind; }
            set { _kind = value; }
        }

        [DefaultValue(false)]
        public bool ShowImageFields
        {
            get { return _showImageFields; }
            set
            {
                if (_showImageFields == value) return;
                _showImageFields = value;
                PopulateFields();
            }
        }

        [DefaultValue("")]
        public string Expression
        {
            get { return ScriptValueHelper.ToString(Value); }
            set
            {
                Value = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DropDownControlButtonFlags VisibleButtons
        {
            get { return base.VisibleButtons; }
            set { base.VisibleButtons = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ScriptValueListForm DropDownForm
        {
            get { return (ScriptValueListForm)base.DropDownForm; }
        }

        public void Init(IServiceProvider provider, string scriptSource, string scriptName)
        {
            _provider = provider;
            _scriptSource = scriptSource;
            _scriptName = scriptName;

            var grs = _provider.GetService(typeof(IGetReportsService)) as IGetReportsService;
            Debug.Assert(grs != null);
            _report = grs.Report;

            PopulateFields();
        }

        protected override string DefaultDropDownFormClassName
        {
            get { return "FlexReportDesignerApp.Controls.ScriptValueListForm"; }
        }

        protected override void OnDropDownOpened(EventArgs e)
        {
            base.OnDropDownOpened(e);

            DropDownForm.UpdatePerferedSize(Size);

            var expression = Expression;
            object selectedItem = null;
            foreach (var item in _listBox.Items)
            {
                var valueItem = item as ScriptValueList.ValueItem;
                if (valueItem == null) continue;
                var itemExpression =
                    ScriptValueHelper.TextToObject(valueItem.Text, typeof(ScriptStringValue), valueItem.IsExpression).ToString();
                if (expression == itemExpression)
                {
                    selectedItem = item;
                    break;
                }
            }
            _listBox.SelectedItem = selectedItem;
        }

        protected override void OnDropDownClosed(DropDownClosedEventArgs e)
        {
            base.OnDropDownClosed(e);

            if (_listBox.SelectedItem is ScriptValueList.ScriptEditorItem)
            {
                var scriptEditor = _provider.GetService(typeof(IScriptEditorService)) as IScriptEditorService;
                if (scriptEditor == null) return;

                var scriptSource = _scriptSource;
                if (string.IsNullOrEmpty(scriptSource))
                {
                    scriptSource = _report.DataSourceName;
                }
                
                object result;
                scriptEditor.EditScript(_report, scriptSource, _kind, this, "Expression", _scriptName, true,
                    out result);
            }
            else if (_listBox.SelectedItem is ScriptValueList.ValueItem)
            {
                var item = _listBox.SelectedItem as ScriptValueList.ValueItem;
                Expression =
                    ScriptValueHelper.TextToObject(item.Text, typeof (ScriptStringValue), item.IsExpression).ToString();
            }
        }

        private void PopulateFields()
        {
            if (_report == null)
                return;

            _listBox.Items.Clear();

            var scriptSource = _scriptSource;
            if (string.IsNullOrEmpty(scriptSource))
                scriptSource = _report.DataSourceName;
            DataSource ds = null;
            if (_report.DataSources.Contains(scriptSource))
                ds = _report.DataSources[scriptSource];

            ScriptValueList.FillListWithFields(_listBox.Items, _report, ds, _kind, _showImageFields);
        }
    }
}
