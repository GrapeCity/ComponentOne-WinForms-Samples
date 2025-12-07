//----------------------------------------------------------------------------
// ScriptValueList.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
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

using C1.Report;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using Flex = C1.Win.FlexReport;
using Doc = C1.Win.Document;

namespace FlexReportDesignerApp
{
    /// <summary>
    /// Helper static class to build lists of values available to be used as fields' expressions and so on.
    /// The list always includes an item representing a call to script editor, plus
    /// the list of available data fields, report fields, literals and so on - depending on the context.
    /// Call one of the two FillList* methods to fill an IList with desirable values.
    /// The list can be used in a UI element as is, or used to build UI elements such as combobox items.
    /// Selectable item types are <see cref="ScriptValueList.ScriptEditorItem"/> and <see cref="ScriptValueList.ValueItem"/>.
    /// </summary>
    internal static class ScriptValueList
    {
        public static void FillListWithFields(IList list, C1FlexReport report, DataSource ds, ScriptEditorContextKind contextKind, bool imageFieldsToo)
        {
            list.Add(ScriptValueList.ScriptEditorItem.One);
            if (ds != null)
            {
                // In 'meta view', db fields are added as strings rather than as expressions:
                bool metaView = contextKind == ScriptEditorContextKind.MetaView;
                // todo: maybe draw an icon for image fields?
                if (ds.IsDataSourceInfoFetched)
                {
                    var info = ds.DataSourceInfo;
                    if (info.TextFields.Count > 0 || (imageFieldsToo && info.ImageFields.Count > 0))
                        list.Add(new ScriptValueList.LabelItem(Strings.Common.DbFields));
                    info.TextFields.Select(tf_ => new ScriptValueList.ValueItem(tf_.Name, !metaView)).ToList().ForEach(v_ => list.Add(v_));
                    if (imageFieldsToo)
                        info.ImageFields.Select(tf_ => new ScriptValueList.ValueItem(tf_.Name, !metaView)).ToList().ForEach(v_ => list.Add(v_));
                }
                var cfs = ds.CalculatedFields.Select(f_ => f_.Name).Where(s_ => !string.IsNullOrEmpty(s_));
                if (cfs.Count() > 0)
                {
                    list.Add(new ScriptValueList.LabelItem(Strings.Common.CalcFields));
                    cfs.Select(cf_ => new ScriptValueList.ValueItem(cf_, !metaView)).ToList().ForEach(v_ => list.Add(v_));
                }
            }
            if (report.Parameters.Count > 0)
            {
                list.Add(new ScriptValueList.LabelItem(Strings.Common.ReportParams));
                report.Parameters.Select(p_ => new ScriptValueList.ValueItem(p_.Name, true)).ToList().ForEach(v_ => list.Add(v_));
            }
            if (contextKind == ScriptEditorContextKind.ReportScript && report.Fields.Count > 0)
            {
                list.Add(new ScriptValueList.LabelItem(Strings.Common.ReportFields));
                report.Fields.Select(f_ => new ScriptValueList.ValueItem(f_.Name, true)).ToList().ForEach(v_ => list.Add(v_));
            }
        }

        public static void FillListWithSortDirections(IList list)
        {
            list.Add(ScriptValueList.ScriptEditorItem.One);
            Enum.GetNames(typeof(SortDirection)).Select(s_ => new ScriptValueList.ValueItem(s_, false, false)).ToList().ForEach(v_ => list.Add(v_));
        }
        public class ScriptEditorItem : IScriptValueListItem
        {
            public static readonly ScriptEditorItem One = new ScriptEditorItem();
            public override string ToString()
            {
                return string.Empty;
            }
            public bool IsScriptEditor { get { return true; } }
            public bool IsLabel { get { return false; } }
            public bool IsValue { get { return false; } }
            public string Text { get { return null; } }
            public bool IsExpression { get { return false; } }
            public string DisplayText { get { return Strings.Common.ExprEditor; } }
        }
        public class LabelItem : IScriptValueListItem
        {
            private string _text;
            public LabelItem(string text)
            {
                _text = text;
            }
            public override string ToString()
            {
                return string.Empty;
            }
            public bool IsScriptEditor { get { return false; } }
            public bool IsLabel { get { return true; } }
            public bool IsValue { get { return false; } }
            public string Text { get { return null; } }
            public bool IsExpression { get { return false; } }
            public string DisplayText { get { return _text; } }
        }
        public class ValueItem : IScriptValueListItem
        {
            private string _text;
            private string _displayText;
            private bool _exression;
            public ValueItem(string text, bool expression, bool offset = true)
            {
                _text = text;
                _exression = expression;
                _displayText = offset ? ("   " + text) : text;
            }
            public override string ToString()
            {
                return _text;
            }
            public bool IsScriptEditor { get { return false; } }
            public bool IsLabel { get { return false; } }
            public bool IsValue { get { return true; } }
            public string Text { get { return _text; } }
            public bool IsExpression { get { return _exression; } }
            public string DisplayText { get { return _displayText; } }
        }
    }

    /// <summary>
    /// Represents a list box wtih an item for showing the script editor (Script Editor...),
    /// plus the list of available db fields, report parameters and report fields.
    /// </summary>
    internal class ScriptValueListBox : ListBox
    {
        private Font _valueFont = SystemFonts.DialogFont;
        private Font _labelFont;
        // this prevents 'accepting' values when the list box is closed due to e.g. user alt-tabbing elsewhere:
        private IScriptValueListItem _selectedItem = null;

        #region Publics
        /// <summary>
        /// Fired when a selectable item (expression editor or one of the fields/values) is explicitly selected
        /// by clicking or by pressing Enter. Caller should close the container form and retrieve the
        /// accepted value via a call to <see cref="GetSelectedItem()"/>.
        /// </summary>
        public EventHandler ItemSelected;
        /// <summary>
        /// Initalizes a new instance of ScriptValuesListBox.
        /// </summary>
        public ScriptValueListBox()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            _labelFont = new Font(_valueFont.FontFamily, _valueFont.Size - 0.5f, FontStyle.Bold);
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.IntegralHeight = true;
            this.SelectionMode = System.Windows.Forms.SelectionMode.One;
        }
        /// <summary>
        /// Fills the listbox with script editor caller + sort direction values.
        /// </summary>
        public void FillWithSortDirections()
        {
            this.BeginUpdate();
            this.Items.Clear();
            ScriptValueList.FillListWithSortDirections(this.Items);
            this.EndUpdate();
        }
        /// <summary>
        /// Fills the listbox with script editor caller + data fields, calc fields, params and report fields..
        /// </summary>
        /// <param name="report">The report.</param>
        /// <param name="ds">The data source to get dbfields from.</param>
        /// <param name="contextKind">The context kind.</param>
        public void FillWithFields(C1FlexReport report, DataSource ds, ScriptEditorContextKind contextKind)
        {
            this.BeginUpdate();
            this.Items.Clear();
            ScriptValueList.FillListWithFields(this.Items, report, ds, contextKind, false);
            this.EndUpdate();
        }
        /// <summary>
        /// Returns the value selected/accepted by the user.
        /// This can be either a script editor caller <see cref="ScriptValueList.ScriptEditorItem"/>,
        /// a <see cref="ScriptValueList.ValueItem"/>, or null.
        /// </summary>
        /// <returns></returns>
        public IScriptValueListItem GetSelectedItem()
        {
            return _selectedItem;
        }
        #endregion

        #region Overrides
        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            IScriptValueListItem item = this.Items[e.Index] as IScriptValueListItem;
            if (item == null)
                return;
            string text = item.DisplayText;
            var m = e.Graphics.MeasureString(text, item.IsLabel ? _labelFont : this.Font);
            e.ItemHeight = (int)m.Height;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            var item = this.Items[e.Index] as IScriptValueListItem;
            if (item == null)
                return;
            string text = item.DisplayText;
            bool label = item.IsLabel;
            if (label)
                e.Graphics.FillRectangle(SystemBrushes.Control, e.Bounds);
            else
                e.DrawBackground();
            e.Graphics.DrawString(text, label ? _labelFont : this.Font, Brushes.Black, e.Bounds);
            if (e.State == DrawItemState.Focus && (item.IsScriptEditor || item.IsValue))
                e.DrawFocusRectangle();
        }
        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Escape || keyData == Keys.Enter)
                return true;
            return base.IsInputKey(keyData);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.KeyData.ToString());
            switch (e.KeyData)
            {
                case Keys.Escape:
                    _selectedItem = null;
                    if (ItemSelected != null)
                        ItemSelected(this, EventArgs.Empty);
                    break;
                case Keys.Enter:
                    UpdateSelectedItem();
                    if (_selectedItem != null && ItemSelected != null)
                        ItemSelected(this, EventArgs.Empty);
                    break;
                case Keys.Up:
                    if (SelectedIndex > 0)
                        SelectedIndex -= 1;
                    e.Handled = IsSelectedItemSelectable();
                    break;
                case Keys.Down:
                    if (SelectedIndex < Items.Count - 1)
                        SelectedIndex += 1;
                    e.Handled = IsSelectedItemSelectable();
                    break;
            }
            base.OnKeyDown(e);
        }
        #endregion

        #region Privates
        private bool IsSelectedItemSelectable()
        {
            var item = this.SelectedItem as IScriptValueListItem;
            return item != null && (item.IsScriptEditor || item.IsValue);
        }
        private void UpdateSelectedItem()
        {
            if (IsSelectedItemSelectable())
                _selectedItem = (IScriptValueListItem)this.SelectedItem;
            else
                _selectedItem = null;
        }
        protected override void OnClick(EventArgs e)
        {
            UpdateSelectedItem();
            if (_selectedItem == null)
                this.SelectedIndex = -1;
            else if (ItemSelected != null)
                ItemSelected(this, EventArgs.Empty);
        }
        #endregion
    }
}
