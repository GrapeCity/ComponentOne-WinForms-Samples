using System;
using System.Text;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Reflection;
using C1.Win.C1FlexGrid;

namespace CustomEditors
{
	//===============================================================================
	#region ** FlagsEditor
	//
	// FlagsEditor
	// UITypeEditor that can be used to edit enumerations with a Flags attribute.
	// Shows a checked listbox with one entry per flag, users can check any 
	// combination.
	// 
	public class FlagsEditor : UITypeEditor
	{
		// ** fields
		private IWindowsFormsEditorService _edSvc;
		private CheckedListBox	_list;
		private Type			_flagsType;
		private bool			_cancel;

		// ** ctor
		public FlagsEditor(Type flagsType)
		{
			// store reference to flags type being edited
			_flagsType = flagsType;

			// build selector list
			_list = new CheckedListBox();
			_list.BorderStyle		= BorderStyle.FixedSingle;
			_list.CheckOnClick		= true;
			_list.ThreeDCheckBoxes	= false;
			_list.KeyPress += new KeyPressEventHandler(_list_KeyPress);
		}

		// ** overrides
		override public UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext ctx) 
		{
			return UITypeEditorEditStyle.DropDown;
		}
		override public object EditValue(ITypeDescriptorContext ctx, IServiceProvider provider, object value)
		{ 
			// initialize editor service
			_edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
			if (_edSvc == null)
				return value;

			// null means no flags are checked
			if (value == null)
				value = 0;

			// populate the list
			_list.Items.Clear();
			foreach (object item in Enum.GetValues(_flagsType))
			{
				// skip 'none', people have to uncheck all options to get it
				// (if we added this to the list, it would always be checked...)
				if ((int)item == 0) continue;

				// add this item with the proper check state
				CheckState check = (((int)value & (int)item) == (int)item)
					? CheckState.Checked
					: CheckState.Unchecked;
				_list.Items.Add(item, check);
			}
			_list.Height = Math.Min(300, (_list.Items.Count+1) * _list.Font.Height);

			// show the list
			_cancel = false;
			_edSvc.DropDownControl(_list);

			// build return value from checked items on the list
			if (!_cancel)
			{
				// build a comma-delimited string with the checked items
				StringBuilder sb = new StringBuilder();
				foreach (object item in _list.CheckedItems)
				{
					if (sb.Length > 0) sb.Append(", ");
					sb.Append(item.ToString());
				}

				// convert empty string into '0' (no flags)
				return (sb.Length > 0)? sb.ToString(): "0";
			}

			// done
			return value;
		}

		// ** event handlers

		// close editor if the user presses enter or escape
		private void _list_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case (char)27:
					_cancel = true;
					_edSvc.CloseDropDown();
					break;
				case (char)13:
					_edSvc.CloseDropDown();
					break;
			}
		}
	}
	#endregion

	//===============================================================================
	#region ** Multi-Column editor
	//
	// MultiColumnEditor
	// UITypeEditor implemented using a FlexGrid. This is easier than creating a
	// drop down control from scratch. The UITypeEditorControl class takes care
	// of turning this into a control that can be used as a grid editor.
	// 
	public class MultiColumnEditor : UITypeEditor
	{
		// ** fields
		private IWindowsFormsEditorService _edSvc;
		private C1FlexGrid	_flex;
		private string      _keyColumn;
		private bool		_cancel;

		// ** ctor
		public MultiColumnEditor(C1FlexGrid flex, string keyColumn)
		{
			// some sanity
			if (!flex.Cols.Contains(keyColumn))
				throw new ApplicationException(string.Format("Column '{0}' not found on the grid.", keyColumn));

			// column that contains the value being edited
			_keyColumn = keyColumn;

			// initialize drop-down flex control
			_flex = flex;
			_flex.Cols.Fixed    = 1;
			_flex.Cols[0].Width = _flex.Font.Height;
			_flex.ShowCursor	= true;
			_flex.AllowEditing  = false;
			_flex.BorderStyle	= C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			_flex.SelectionMode = SelectionModeEnum.Row;
			//_flex.FocusRect		= FocusRectEnum.None;
			_flex.AutoSearch	= AutoSearchEnum.FromCursor;
			_flex.Click    += new EventHandler(_flex_Click);
			_flex.KeyPress += new KeyPressEventHandler(_flex_KeyPress);
		}

		// ** overrides
		override public UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext ctx) 
		{
			return UITypeEditorEditStyle.DropDown;
		}
		override public object EditValue(ITypeDescriptorContext ctx, IServiceProvider provider, object value)
		{ 
			// initialize editor service
			_edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
			if (_edSvc == null)
				return value;

			// size the grid
			_flex.ClientSize = new Size(
				Math.Min(800, _flex.Cols[_flex.Cols.Count-1].Right),
				Math.Min(250,  _flex.Rows[_flex.Rows.Count-1].Bottom));

			// initialize selection
			int col = _flex.Cols[_keyColumn].Index;
			_flex.Col = col;
			_flex.Row = (value is string)
				? _flex.FindRow((string)value, _flex.Cols.Fixed, col, false, true, true)
				: -1;

			// show the grid
            _flex.Visible = true;
			_cancel = false;
			_edSvc.DropDownControl(_flex);

			// get return value from selected item on the grid
			if (!_cancel && _flex.Row > -1)
				value = _flex[_flex.Row, _keyColumn];

			// done
			return value;
		}

		// ** event handlers

		// close editor when the user picks a row with the mouse
		private void _flex_Click(object sender, EventArgs e)
		{
			if (_edSvc != null)
				_edSvc.CloseDropDown();
		}

		// close editor if the user presses enter or escape
		private void _flex_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case (char)27:
					e.Handled = true;
					_cancel = true;
					_edSvc.CloseDropDown();
					break;
				case (char)13:
					e.Handled = true;
					_edSvc.CloseDropDown();
					break;
			}
		}
	}
	#endregion
}
