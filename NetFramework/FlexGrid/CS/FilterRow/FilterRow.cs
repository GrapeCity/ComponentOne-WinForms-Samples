/* ------------------------------------------------------------------------
 * FilterRow.cs
 * 
 * Implements a class that works as a filter row for the C1FlexGrid 
 * control (it is also used by the C1FlexGroup control).
 * 
 * To use this class, bind a FlexGrid to a DataTable or DataView object, 
 * then create a FilterRow object passing the grid as a parameter to the 
 * constructor. For example:
 * 
 * OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
 * DataTable dt = new DataTable();
 * da.Fill(dt);
 * _flex.DataSource = dt;
 * FilterRow fr = new FilterRow(_flex);
 * 
 * Once created, the FilterRow class will:
 * 
 * 1 - Add a new Fixed row to the grid. This new row will be the 'filter row'.
 * 
 * 2 - Trap mouse and keyboard events to select cells in the filter row.
 *     The user can select the filter row by clicking on its cells, by 
 *     pressing F3, or by moving to the top row and pressing the up arrow.
 *     The user can remove the filter by clicking the first fixed column
 *     on the filter row, then pressing the Delete key.
 * 
 * 3 - Trap the RowColChange event to update the filter expression and apply
 *     it to the grid's data source. The filter expression may contain:
 *     a) Simple values (e.g. "Smith"). These are translated into filter
 *        expressions such as "like 'Smith*'".
 * 		  If you type "s" in the filter row, the grid will show only rows
 *        where the corresponding entry starts with "s".
 *     b) Logical expressions (e.g. "> a", "= US"). These are translated 
 *        into filter expressions such as "> 'a'" and "= 'US'".
 * 		  If you type ">=12" in the filter row, the grid will show rows
 *        where the corresponding entry is 12 or a higher value.
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
 * 1.0: Jun 2002	Sample created
 * 1.2: Oct 2003	Minor changes, added to C1FlexGroup control
 * 1.3: Nov 2003	Added support for DataMaps in UpdateFilter
 * 1.4: Mar 2004	Improved support for boolean columns
 * 1.5: May 2006	Commit changes to data source before searching
 * ------------------------------------------------------------------------
 */
using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using C1.Win.FlexGrid;

namespace FilterRow
{
	/// <summary>
	/// Summary description for FilterRow.
	/// </summary>
	public class FilterRow
	{
		private C1FlexGrid _flex;
		private CellStyle  _style;
		private int _row = -1;			// index of filter row (-1 if none)
		private int _col = -1;			// index of filter row cell being edited (-1 if none)

		// ** ctor

		public FilterRow(C1.Win.FlexGrid.C1FlexGrid flex)
		{
			// save reference to grid
			_flex = flex;

			// add filter row
			_row = _flex.Rows.Fixed;
			_flex.Rows.Fixed++;

			// customize filter row style
			// note: customize margins to align checkboxes correctly in filter cells,
			// which have no vertical border <<1.4>>
			_style					= _flex.Styles.Add("Filter", _flex.Styles.Frozen);
			_style.BackColor		= SystemColors.Info;
			_style.ForeColor		= SystemColors.InfoText;
			_style.Border.Direction = BorderDirEnum.Horizontal;
			_style.Margins			= new System.Drawing.Printing.Margins(1, 2, 1, 1);
			_flex.Rows[_row].Style	= _style;

			// add event handlers
			_flex.KeyDown			+= new KeyEventHandler(_flex_KeyDown);
			_flex.BeforeMouseDown	+= new BeforeMouseDownEventHandler(_flex_BeforeMouseDown);
			_flex.RowColChange		+= new EventHandler(_flex_RowColChange);
			_flex.AfterEdit			+= new RowColEventHandler(_flex_AfterEdit);

			// initialize boolean cells <<1.4>>
			CellStyle cs = _flex.Styles.Add("BooleanFilterCell");
			cs.ImageAlign = ImageAlignEnum.CenterCenter;
			foreach (Column col in _flex.Cols)
			{
				if (col.DataType == typeof(bool))
				{
					_flex.SetCellCheck(_row, col.Index, CheckEnum.TSGrayed);
					_flex.SetCellStyle(_row, col.Index, cs);
				}
			}

			// move cursor to filter row
			_flex.Select(_row, _flex.Cols.Fixed);
		}

		// ** object model

		public bool Visible
		{
			get { return _flex.Rows[_row].Visible; }
			set { _flex.Rows[_row].Visible = value; }
		}
		public void Clear()
		{
			for (int col = 0; col < _flex.Cols.Count; col++)
				_flex[_row, col] = null;
			UpdateFilter();
		}

		// ** event handlers

		// custom logic for selection, clearing the filter
		private void _flex_KeyDown(object sender, KeyEventArgs e)
		{
			// user hit f3 or up arrow on the first scrollable row
			if (e.KeyCode == Keys.F3 || (e.KeyCode == Keys.Up && _flex.Row == _row+1))
			{
				// select the filter cell and go start editing it
				_flex.Select(_row, _flex.Col);
				e.Handled = true;
			}

			// user hit Del when the filter row is selected
			if (e.KeyCode == Keys.Delete && _flex.Row == _row)
			{
				for (int col = _flex.Cols.Fixed; col < _flex.Cols.Count; col++)
					_flex[_row, col] = null;
				UpdateFilter();
				e.Handled = true;
			}
		}

		// special mouse handling for filter row
		private void _flex_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
		{
			// detect clicks on filter row
			if ((e.Button & MouseButtons.Left) != 0 && _row > 0 && _flex.MouseRow == _row)
			{
				// get the column that was clicked
				HitTestInfo ht = _flex.HitTest(e.X, e.Y);
				int col = ht.Column;

				// fixed column? select the whole filter row
				if (col < _flex.Cols.Fixed)
				{
					_flex.Select(_row, _flex.Cols.Fixed, _row, _flex.Cols.Count-1);
					_flex.FinishEditing(true);
				}

				// clicked a cell on the filter row, select it
				else
				{
					_flex.Select(_row, col);
				}

				// eat the event (no sorting, sizing etc)
				// unless this is a checkbox <<1.4>>
				if (ht.Type != HitTestTypeEnum.Checkbox)
					e.Cancel = true;
			}
		}

		// keep filter row in edit mode
		private void _flex_RowColChange(object sender, EventArgs e)
		{
			// we're only interested in cursor changes
			if (_row > -1 && (_flex.Row != _row || _flex.Col != _col))
			{
				// if the new cell is in the filter row, start editing
				_col = -1;
				if (_flex.Row == _row)
				{
					_col = _flex.Col;

					// start editing if this is not a checkbox <<1.4>>
					if (_flex.Cols[_col].DataType != typeof(bool))
						_flex.StartEditing();
				}
			}
		}

		// update the filter after any edits to the filter row
		private void _flex_AfterEdit(object sender, RowColEventArgs e)
		{
			if (e.Row == _row)
				UpdateFilter();
		}

		// ** utilities

		// update filter (called after editing the filter row)
		private void UpdateFilter()
		{
			// make sure we have a filter row
			if (_row < 0) return;

			// make sure we have a data view
			DataView dv = _flex.DataSource as DataView;
			if (dv == null)
			{
				DataTable dt = _flex.DataSource as DataTable;
				if (dt != null) dv = dt.DefaultView;
			}
			if (dv == null) 
			{
				Debug.WriteLine("DataSource should be a DataTable or DataView.");
				return;
			}

			// make sure changes are committed to the data source <<1.5>>
			CurrencyManager cm = (CurrencyManager)_flex.BindingContext[_flex.DataSource, _flex.DataMember];
			cm.EndCurrentEdit();

			// scan each cell in the filter row and build new filter
			StringBuilder sb = new StringBuilder();
			for (int col = _flex.Cols.Fixed; col < _flex.Cols.Count; col++)
			{
				// get column value
				string expr = _flex.GetDataDisplay(_row, col).TrimEnd();

				// special handling for boolean columns <<1.4>>
				if (_flex.Cols[col].DataType == typeof(bool))
				{
					switch (_flex.GetCellCheck(_row, col))
					{
						case CheckEnum.TSChecked:
							expr = "true";
							break;
						case CheckEnum.TSUnchecked:
							expr = "false";
							break;
					}
				}

				// ignore empty cells
				if (expr.Length == 0) continue;

				// handle data maps <<1.3>>
				IDictionary dataMap = _flex.Cols[col].DataMap;
				if (dataMap != null)
				{
					foreach (object key in dataMap.Keys)
					{
						if (string.Compare(dataMap[key].ToString(), expr, true) == 0)
						{
							expr = key.ToString();
							break;
						}
					}
				}

				// get filter expression
				expr = BuildFilterExpression(col, expr);
				if (expr.Length == 0) continue;

				// concatenate new condition
				if (sb.Length > 0) sb.Append(" And ");
				sb.AppendFormat("[{0}]{1}", _flex.Cols[col].Name, expr);
			}

			// apply filter to current view
			string strFilter = sb.ToString();
			if (strFilter == dv.RowFilter) return;
			try
			{
				_flex[_row, 0] = null;
				dv.RowFilter = strFilter;
			}
			catch
			{
				_flex[_row, 0] = "Err";
				Debug.WriteLine("Bad filter expression.");
			}

			// stay in filter row
			_flex.Row = _row;
		}

		// Build a filter expression to apply to data table
		//
		// This takes a value in the filter row and converts it into 
		// a filter expression. For example:
		//
		// Text		Filter Expression
		// -------  -----------------
		// smith    like 'smith*'
		// > s      > 's'
        // 1        = '1'
        // > 1      > '1'
		//
		private string BuildFilterExpression(int col, string expr)
		{
			// operators we recognize
			string oper = "<>=";

			// no operators? use 'like' for strings, = for other types
			if (oper.IndexOf(expr[0]) < 0)
			{
                return (_flex.Cols[col].DataType == typeof(string))
                    ? string.Format(" like '{0}*'", expr)
                    : string.Format(" = '{0}'", expr);
            }
			
			// look for end of operators
			for (int index = 0; index < expr.Length; index++)
			{
				if (oper.IndexOf(expr[index]) < 0)
				{
					string retval = expr.Substring(0, index) + " ";
					retval += string.Format("'{0}'", expr.Substring(index).Trim());
					return retval;
				}
			}

			// if we got here, the condition must be bad (e.g. ><)
			Debug.WriteLine("Can't build filter expression.");
			return "";
		}
	}
}
