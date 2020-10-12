/* ------------------------------------------------------------------------
 * TemplateRow.cs
 * 
 * Implements a class that works as a new row template for the C1FlexGrid 
 * control.
 * 
 * To use this class, create a TemplateRow object, then passing the grid as a parameter to the 
 * constructor. For example:
 * 
 * OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
 * DataTable dt = new DataTable();
 * da.Fill(dt);
 * _flex.DataSource = dt;
 * TemplateRow fr = new TemplateRow(_flex);
 * 
 * Once created, the TemplateRow class will:
 * 
 * 1 - Add a new Fixed row to the grid. This new row will be the 'template row'.
 * 
 * 2 - Apply the default editor and customized editor to each cell of the template row.
 * 
 * 3 - Trap mouse and keyboard events to select cells in the template row.
 *     The user can select the template row by clicking on its cells, by 
 *     pressing F3, or by moving to the top row and pressing the up arrow.
 * 
 * 4 - Copy the values in the template row to a new row after user presses the
 *	   <Enter> key or moves the selection to a new row.
 * 
 * ------------------------------------------------------------------------
 * This is a part of the C1FlexGrid package.
 * 
 * This source code is intended as a supplement to the C1FlexGrid control
 * and related documentation provided with the product. See these sources 
 * for detailed information regarding the C1FlexGrid product.
 * 
 * You may use this code as-is or modify it for any purpose you see fit,
 * including the development of commercial applications. If you make any
 * improvements that you would like to share with other users, please 
 * post them at the C1FlexGrid newsgroup. Thanks.
 * ------------------------------------------------------------------------
 * Version history:
 * 
 * 1.0: Aug 2005	Sample created
  * ------------------------------------------------------------------------
 */
using System;
using System.Reflection;
using System.ComponentModel;
using System.Text;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;

using C1.Win.C1FlexGrid;

namespace TemplateRow
{
	/// <summary>
	/// Summary description for TemplateRow.
	/// </summary>
	public class TemplateRow
	{
		private C1FlexGrid	_flex;
		private CellStyle	_style;
		private int			_row = -1;			// index of template row (-1 if none)
		private int			_col = -1;			// index of template row cell being edited (-1 if none)
		private bool		_clearing = false;
		private bool		_adding = false;
		private bool		_dirty = false;
		private Bitmap		_bmpBlank;
		private Bitmap		_bmpAdd;

		// ** ctor

		public TemplateRow(C1.Win.C1FlexGrid.C1FlexGrid flex)
		{
			// save reference to grid
			_flex = flex;

			// load icons
			_bmpBlank = new Bitmap(GetResourceStream("blank.ico"));
			_bmpAdd = new Bitmap(GetResourceStream("add.ico"));

			// add template row
			_row = _flex.Rows.Fixed;
			_flex.Rows.Fixed++;
			_flex.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;

			// customize template row style
			// note: customize margins to align checkboxes correctly in template cells,
			// which have no vertical border
			_style					= _flex.Styles.Add("TemplateRow", _flex.Styles.Frozen);
			_style.BackColor		= SystemColors.Info;
			_style.ForeColor		= SystemColors.InfoText;
			_style.Border.Direction = BorderDirEnum.Horizontal;
			_style.Margins			= new System.Drawing.Printing.Margins(1, 2, 1, 1);
			_flex.Rows[_row].Style	= _style;

			// add event handlers
			_flex.KeyDown			+= new KeyEventHandler(_flex_KeyDown);
			_flex.BeforeMouseDown	+= new BeforeMouseDownEventHandler(_flex_BeforeMouseDown);
			_flex.RowColChange		+= new EventHandler(_flex_RowColChange);
			_flex.KeyDownEdit		+= new KeyEditEventHandler(_flex_KeyDownEdit);
			_flex.OwnerDrawCell		+= new OwnerDrawCellEventHandler(_flex_OwnerDrawCell);
			_flex.CellChanged		+= new RowColEventHandler(_flex_CellChanged);

			ClearTemp();
			ApplyStyles();

			// move cursor to template row
			_flex.Select(_row, _flex.Cols.Fixed);
		}

		// ** object model
		public bool Visible
		{
			get { return _flex.Rows[_row].Visible; }
			set { _flex.Rows[_row].Visible = value; }
		}

		// Apply styles that specified the editors of each column to template cells.
		private void ApplyStyles()
		{
			CellStyle cs = _flex.Styles.Add("BooleanTempCell");
			cs.ImageAlign = ImageAlignEnum.CenterCenter;

			for (int col = 0; col < _flex.Cols.Count; col++)
			{
				_flex[_row, col] = null;
				if (ShowValueAsCheck(col))
				{
					_flex.SetCellStyle(_row, col, cs);
				}
				else
				{
					// Apply the data type and custom editor through the style,
					// so the editors can be invoked in template row.
					CellStyle style = _flex.Styles.Add("tempcol" + col.ToString());
					style.DataType  = _flex.Cols[col].DataType;
					style.Editor    = _flex.Cols[col].Editor;
					style.ComboList = _flex.Cols[col].ComboList;
					style.DataMap   = _flex.Cols[col].DataMap;
					_flex.SetCellStyle(_row, col, style);
				}
			}
		}

		/// <summary>
		/// Clears the values in the template row.
		/// </summary>
		public void ClearTemp()
		{
			_clearing = true;
			for (int col = 0; col < _flex.Cols.Count; col++)
			{
				_flex[_row, col] = null;
				if (ShowValueAsCheck(col))
					_flex.SetCellCheck(_row, col, CheckEnum.TSGrayed);
			}
			_clearing = false;
			_dirty = false;
			_flex.Invalidate(_row, _flex.Cols.Fixed - 1);
		}

		// ** event handlers
		private void _flex_CellChanged(object sender, RowColEventArgs e)
		{
			if (_clearing) return;
			if (e.Row == _row)
			{
				if (IsValidTemp())
				{
					_dirty = true;
					_flex.Invalidate(_row, _flex.Cols.Fixed - 1);
				}
			}
		}
		private void _flex_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
		{
			if (e.Row == _row && e.Col == _flex.Cols.Fixed - 1)
			{
				e.Style.ImageAlign = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter;
				e.Style.Render(e.Graphics, e.Bounds, _dirty ? _bmpAdd : _bmpBlank);
				e.Handled = true;
			}
		}
		private void _flex_KeyDownEdit(object sender, KeyEditEventArgs e)
		{
			if (e.Row != _row)
				return;

			// Add new row while user press the <Enter> key.
			if (e.KeyCode == Keys.Enter)
			{
				_flex.FinishEditing();

				if (IsValidTemp())
					AddNewRow();

				_flex.StartEditing(); 
				e.Handled = true;
			}
		}
		// custom logic for selection, clearing the template
		private void _flex_KeyDown(object sender, KeyEventArgs e)
		{
			// user hit f3 or up arrow on the first scrollable row
			if (e.KeyCode == Keys.F3 || (e.KeyCode == Keys.Up && _flex.Row == _row+1))
			{
				// select the template cell and go start editing it
				_flex.Select(_row, _flex.Cols.Fixed);
				e.Handled = true;
			}

			// user hit Del when the template row is selected
			if (e.KeyCode == Keys.Delete && _flex.Row == _row)
			{
				ClearTemp();
				e.Handled = true;
			}

			// Add new row while user press the <Enter> key.
			if (e.KeyCode == Keys.Enter && _flex.Row == _row)
			{
				if (IsValidTemp())
					AddNewRow();

				e.Handled = true;
			}
		}
		// special mouse handling for template row
		private void _flex_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
		{
			// we're interested in the left button
			if ((e.Button & MouseButtons.Left) == 0 || _row < 0 || !Visible)
				return;

			// get the cell that was clicked
			HitTestInfo ht = _flex.HitTest(e.X, e.Y);
			int row = ht.Row;
			int col = ht.Column;

			// handle clicks on template row
			if (row == _row)
			{
				// fixed column? select the whole template row
				if (col < _flex.Cols.Fixed)
				{
					_flex.FinishEditing();
					if (_dirty)
						AddNewRow();
				}
				else
				{
					_flex.Select(row, col);
				}

				// eat the event (no sorting, sizing etc) unless this is a checkbox <<1.4>>
				if (ht.Type != HitTestTypeEnum.Checkbox)
					e.Cancel = true;
			}
			else if (_flex.Row == _row) // handle regular clicks on rows away from template
			{
				// finish pending edits
				_flex.FinishEditing();
				if (_dirty)
				{
					// add new row
					AddNewRow();

					// select cell that was clicked
					_flex.Select(row, col);

					// done with selection for now
					e.Cancel = true;
				}
			}
		}
		// keep template row in edit mode
		private void _flex_RowColChange(object sender, EventArgs e)
		{
			if (_adding) return;

			int row = _flex.Row;
			int col = _flex.Col;

			// we're only interested in cursor changes
			if (_row > -1 && (row != _row || col != _col))
			{
				// if the new cell is in the template row, start editing
				_col = -1;
				if (_flex.Row == _row)
				{
					_col = col;

					// start editing if this is not a checkbox <<1.4>>
					if (_flex.Cols[_col].DataType != typeof(bool))
						_flex.StartEditing();
				}
				else
				{
					if (_dirty)
					{
						AddNewRow(false);
					}
				}
			}
		}
		// Show check box
		private bool ShowValueAsCheck(int col)
		{
			if (_flex.Cols[col].DataType != typeof(bool)) return false;
			if (_flex.Cols[col].DataMap != null) return false;

			// don't show as check if formatted with bool formatting string
			string fmt = _flex.Cols[col].Format;
			if (fmt.Length > 0 && fmt.IndexOf(';') > -1) return false;

			return true;
		}
		// Get the data in template cell
		private object GetTempData(int col)
		{
			// special handling on check column
			if (ShowValueAsCheck(col))
			{
				CheckEnum check = _flex.GetCellCheck(_row, col);
				switch(check)
				{
					case CheckEnum.Checked:
					case CheckEnum.TSChecked:
						return true;
					case CheckEnum.Unchecked:
					case CheckEnum.TSUnchecked:
						return false;
					case CheckEnum.TSGrayed:
						return DBNull.Value;
				}
			}
			return _flex.GetData(_row, col);
		}
		// Check whether the template row has data in it
		private bool IsValidTemp()
		{
			for (int col = 0; col < _flex.Cols.Count; col++)
			{
				object data = GetTempData(col);
				if (data != null && !data.Equals(string.Empty) && data != DBNull.Value)
					return true;
			}
			return false;
		}

		// Add new row and copy the values
		private void AddNewRow()
		{
			AddNewRow(true);
		}
		private void AddNewRow(bool more)
		{
			_adding = true;
			AddNewRowInternal();
			if (more)
			{
				// stay in template row
				_flex.Row = _row;
				_flex.Col = _flex.Cols.Fixed;
			}
			_adding = false;
		}	
		// Add a new row when the user moves the selection away from the template
		private void AddNewRowInternal()
		{
			// make sure we have a template row
			if (_row < 0) return;

			int oldCount = _flex.Rows.Count;
			_flex.Rows.Add();
			int newCount = _flex.Rows.Count;

			// make sure the row could be added
			if (oldCount == newCount)	return;

			// copy the data
			for(int col = 0; col < _flex.Cols.Count; col++)
			{
				object data = GetTempData(col);
				_flex.SetData(newCount - 1, col, data);
			}

			// clear the template row
			ClearTemp();
		}
		// get stream for loading resources
		private System.IO.Stream GetResourceStream(string name)
		{
			Assembly a = Assembly.GetExecutingAssembly();
			foreach (string res in a.GetManifestResourceNames())
			{
				if (res.EndsWith(name))
				{
					return a.GetManifestResourceStream(res);
				}
			}
			return null;
		}

	}
}
