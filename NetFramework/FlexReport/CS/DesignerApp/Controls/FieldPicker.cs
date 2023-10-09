//----------------------------------------------------------------------------
// FieldPicker.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

using C1.Win.FlexReport;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
    /// FieldPicker inherits from the ComboBox control and connects with a 
    /// ReportDesigner control to provide a list of report sections and fields
    /// that is synchronized with the selection (changes in the designer affect
    /// the Picker and vice-versa).
	/// </summary>
	public class FieldPicker : ComboBox
	{
		private C1FlexReportDesigner _designer;
        // Allows to display names of items not in the list.
        private object _oneOffItem = null;

        #region Constructors
        public FieldPicker()
		{
			DrawMode      = DrawMode.OwnerDrawFixed;
			DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Public properties
        public C1FlexReportDesigner Designer
        {
            get { return _designer; }
            set
            {
                // unhook previous event handlers
                if (_designer != null)
                {
                    _designer.VisibleChanged -= new EventHandler(_designer_VisibleChanged);
                    _designer.SelectionChanged -= new EventHandler(_designer_SelectionChanged);
                    _designer.ReportChanged -= new EventHandler(_designer_ReportChanged);
                }

                // set value
                _designer = value;

                // hook event handers
                if (_designer != null)
                {
                    _designer.VisibleChanged += new EventHandler(_designer_VisibleChanged);
                    _designer.SelectionChanged += new EventHandler(_designer_SelectionChanged);
                    _designer.ReportChanged += new EventHandler(_designer_ReportChanged);
                }
            }
        }

        public new object SelectedItem
		{
			get { return base.SelectedItem; }
			set
			{
				// refill list if the item is not in it
                if (value != null)
                {
                    if (value != _oneOffItem)
                        RemoveOneOffItem();
                    if (!Items.Contains(value))
                        FillList();
                }
				// base processing
				base.SelectedItem = value;
			}
        }

        public void SelectOneOffItem(object item)
        {
            RemoveOneOffItem();
            if (item == null)
            {
                base.SelectedItem = null;
            }
            else if (item != _oneOffItem)
            {
                if (Items.Count < 1)
                    FillList();
                Items.Insert(1, _oneOffItem = item);
                base.SelectedIndex = 1;
            }
            else
                base.SelectedItem = item;
        }
        #endregion

        #region Privates
        private void RemoveOneOffItem()
        {
            if (_oneOffItem != null)
            {
                System.Diagnostics.Debug.Assert(Items.Count > 0 && Items[1] == _oneOffItem);
                if (Items.Count > 0 && Items[1] == _oneOffItem)
                    Items.RemoveAt(1);
                _oneOffItem = null;
            }
        }

        private void FillList()
        {
            // save selection
            object selected = SelectedItem;
            //
            BeginUpdate();
            try
            {
                // clear list
                Items.Clear();
                if (_designer == null || _designer.Report == null)
                    return;

                // populate list
                Items.Add(_designer.Report);
                foreach (var s in C1FlexReportDesigner.GetSectionsInDesignerOrder(_designer.Report))
                {
                    Items.Add(s);
                    foreach (var ssec in s.SubSections)
                    {
                        Items.Add(ssec);
                        foreach (var f in ssec.Fields)
                            Items.Add(f);
                    }
                }
                //
                if (_oneOffItem != null)
                    Items.Insert(1, _oneOffItem);
            }
            finally
            {
                EndUpdate();
            }
            // restore selection
            if (selected != null && Items.Contains(selected))
                SelectedItem = selected;
        }

        private void _designer_VisibleChanged(object sender, EventArgs e)
		{
			// enable and update selection when designer is visible
			if (_designer.Visible)
			{
				Enabled = true;
				_designer_SelectionChanged(null, EventArgs.Empty);
			}
			else // disable and select report when designer is invisible
			{
				Enabled = false;
				SelectedItem = _designer.Report;
			}
		}

		private void _designer_SelectionChanged(object sender, EventArgs e)
		{
            if (_designer.SelectedObjects.Count > 1)
                SelectedItem = null;
            else if (_designer.SelectedObjects.Count == 1)
                SelectedItem = _designer.SelectedObjects[0];
            else
                SelectedItem = null;
		}

		private void _designer_ReportChanged(object sender, EventArgs e)
		{
			FillList();
            _designer_SelectionChanged(sender, EventArgs.Empty);
        }
        #endregion

        #region Protected
        protected override void OnDropDown(EventArgs e)
        {
            FillList();
            base.OnDropDown(e);
        }

        protected override void OnSelectionChangeCommitted(EventArgs e)
		{
            var selectedItem = SelectedItem;
            if (selectedItem != _oneOffItem)
            {
                RemoveOneOffItem();
                // Note: FillList here is safer (?) but results in visual flicker:
                // FillList();
            }
			// synchronize designer selection with list selection
			if (_designer != null)
			{
                if (selectedItem is C1FlexReport)
                    _designer.SelectNone();
                else if (selectedItem is Section)
                    _designer.SelectSection((Section)selectedItem, true, true);
                else if (selectedItem is SubSection)
                    _designer.SelectSubSection((SubSection)selectedItem, true, true);
                else if (selectedItem is FieldBase)
                    _designer.SelectField((FieldBase)selectedItem, true, true);

                // done, send focus back to designer
                _designer.ScrollToSelection();
				_designer.Focus();
			}
			// allow base class processing
			base.OnSelectionChangeCommitted(e);
		}

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // initialize objects
            string text = string.Empty;
            Font font = e.Font;
            Brush brush = SystemBrushes.WindowText;
            Brush backBrush = SystemBrushes.Window;
            const string offSec = "  ";
            const string offSubSec = "    ";
            const string offField = "      ";

            if (e.Index < 0 || e.Index >= Items.Count)
                return;

            object item = Items[e.Index];

            if (item is C1FlexReport)
            {
                text = ((C1FlexReport)item).ReportName;
                if (string.IsNullOrEmpty(text))
                    text = Strings.FieldPicker.UnnamedReport;
            }
            else if (item is Section)
            {
                text = ((Section)item).Name;
                if (string.IsNullOrEmpty(text))
                    text = Strings.FieldPicker.UnnamedSection;
                text = offSec + text;
                backBrush = SystemBrushes.ControlLight;
            }
            else if (item is SubSection)
            {
                text = C1FlexReportDesigner.GetSubSectionDisplayName((SubSection)item);
                text = offSubSec + text;
                backBrush = SystemBrushes.ControlLight;
            }
            else if (item is FieldBase)
            {
                var f = (FieldBase)item;
                text = f.Name;
                if (string.IsNullOrEmpty(text))
                    text = Strings.FieldPicker.UnnamedField;

                // for custom fields, show full type names (we assume all field types derived from Field are custom):
                var type = f.GetType();
                if (type.IsSubclassOf(typeof(Field)))
                    text = string.Format("{0} ({1})", text, type.FullName);
                else
                    text = string.Format("{0} ({1})", text, type.Name);

                if (Designer.IsFieldDataBound(f))
                    font = new System.Drawing.Font(font, FontStyle.Bold);
                // brush = SystemBrushes.Highlight;

                text = offField + text;
            }
            // data tree items:
            else if (item is ReportParameter)
            {
                text = string.Format("Report Parameter: {0}", ((ReportParameter)item).Name);
                font = new Font(font, FontStyle.Bold);
            }
            else if (item is DataSource)
            {
                text = string.Format("Data Source: {0}", ((DataSource)item).Name);
                font = new Font(font, FontStyle.Bold);
            }
            else if (item is FieldInfo)
            {
                text = string.Format("Data Field: {0}", ((FieldInfo)item).Name);
                font = new Font(font, FontStyle.Bold);
            }
            else if (item is CalculatedField)
            {
                text = string.Format("Calculated Field: {0}", ((CalculatedField)item).Name);
                font = new Font(font, FontStyle.Bold);
            }
            else if (item is SortDefinition)
            {
                var se = (SortDefinition)item;
                var coll = se.Owner;
                text = string.Format("Sort Definition {0} on {1}", coll.IndexOf(se), coll.Owner.Name);
                font = new Font(font, FontStyle.Bold);
            }
            else if (item != null)
            {
                text = item.ToString();
                font = new Font(font, FontStyle.Italic);
            }

            // select brush for highlighted item
            if ((e.State & (DrawItemState.Selected | DrawItemState.HotLight)) != 0)
            {
                brush = SystemBrushes.HighlightText;
                backBrush = SystemBrushes.Highlight;
            }

            // draw item
            e.Graphics.FillRectangle(backBrush, e.Bounds);
            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }
        #endregion
    }
}
