using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace MultiSelection
{
	/// <summary>
	/// Summary description for MultiSelectFlexGrid.
	/// </summary>
	public class MultiSelectFlexGrid : C1FlexGrid
	{
		// ** fields
		private ArrayList _selections = new ArrayList();

		// ** ctor
		public MultiSelectFlexGrid()
		{
			base.SelectionMode = SelectionModeEnum.Default;
		}

		// ** object model

		/// <summary>
		/// Disable setting the SelectionMode to value other than Default.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		new public SelectionModeEnum SelectionMode
		{
			get { return base.SelectionMode; }
			set {}
		}

		/// <summary>
		/// Gets an array of selected ranges.
		/// </summary>
		/// <returns>An array of selected ranges.</returns>
		public CellRange[] GetSelections()
		{
			return (CellRange[])_selections.ToArray(typeof(CellRange));
		}

		// ** overrides

		override public bool IsCellHighlighted(int row, int col)
		{
			// no highlight at design time.
			if (DesignMode) return false;

			// return true if the cell is in the single selection range managed by the base class.
			bool isHighlighted = base.IsCellHighlighted(row, col);
			if (isHighlighted)	return true;

			// cursor is special
			if (base.IsCellCursor(row, col))
			{
				// don't highlight cursor with focus rect
				if (base.FocusRect != FocusRectEnum.None && Focused)
					return false;

				// don't highlight cursor while editor is active
				if (base.Editor != null)
					return false;
			}

			// tests whether the cell is in any of the selection range.
			foreach(CellRange range in _selections)
			{
				if (range.Contains(row, col))
					return true;
			}

			return false;
		}
		override protected void OnAfterSelChange(RangeEventArgs e)
		{
			base.OnAfterSelChange(e);

			// extends the last selection when Shift key is pressed.
			if ((Control.ModifierKeys & Keys.Shift) != 0)
			{
				if (_selections.Count > 0)
					_selections.RemoveAt(_selections.Count - 1);
			}
			else
			{
				// clears the selection when no Shift and Control key is pressed.
				if ((Control.ModifierKeys & Keys.Control) == 0)
				{
					if (Visible && Redraw)
					{
						foreach(CellRange range in _selections)
							this.Invalidate(range);
					}
					_selections.Clear();
				}
			}

			// records the selection
			_selections.Add(e.NewRange);
		}
	}
}