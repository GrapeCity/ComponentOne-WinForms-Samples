using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;

namespace FlexFreezeBottomSample
{
	/// <summary>
	/// 
	/// FlexFreezeBottom
	/// 
	/// This is a control (derived from Panel) that contains a FlexGrid. The
	/// contained FlexGrid is positioned with a negative Y coordinate within 
	/// the panel so that the fixed rows are not visible.
	/// 
	/// The contained grid is also sized and scrolled via code so that the 
	/// bottom 'n' rows are visible.
	/// 
	/// The contained grid is bound to a main FlexGrid and therefore shares 
	/// the underlying grid model (data, layout, styles, selection, etc).
	/// 
	/// The whole control (panel and contained grid) is attached to the main 
	/// FlexGrid and positioned at its bottom. This way, the control always
	/// shows the bottom 'n' rows of the main grid.
	/// 
	/// </summary>
	internal class FlexFreezeBottom : Panel
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _frz;
		private C1.Win.C1FlexGrid.C1FlexGrid _main;
		private int  _rows;
		internal FlexFreezeBottom(C1.Win.C1FlexGrid.C1FlexGrid main, int rows)
		{
			// save info we'll need later
			_main = main;
			_rows = rows;

			// create child grid with frozen bottom rows
			_frz = new C1.Win.C1FlexGrid.C1FlexGrid();
			_frz.ScrollBars = ScrollBars.None;
			_frz.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			_frz.DrawMode = DrawModeEnum.OwnerDraw;
			_frz.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(_frz_OwnerDrawCell);
			_frz.SetupEditor   += new C1.Win.C1FlexGrid.RowColEventHandler(_frz_SetupEditor);
			_frz.AfterScroll   += new C1.Win.C1FlexGrid.RangeEventHandler(_frz_AfterScroll);
			_frz.GridChanged   += new C1.Win.C1FlexGrid.GridChangedEventHandler(_main_GridChanged);
			Controls.Add(_frz);

			// bind frozen grid to main grid (share data, layout, styles, selection)
			_frz.DataSource = main;

			// add this to the main grid
			main.Controls.Add(this);

			// hook up the events we need to synchronize with the main grid
			main.Resize      += new System.EventHandler(_main_Resize);
			main.VisibleChanged += new System.EventHandler(_main_Resize);
			main.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(_main_AfterScroll);
			main.SelChange   += new System.EventHandler(_main_SelChange);
			main.GridChanged += new C1.Win.C1FlexGrid.GridChangedEventHandler(_main_GridChanged);

			// initialize
			AdjustLayout();
		}

		internal void AdjustLayout()
		{
			// get index of the bottom (frozen) rows
			RowCollection rows = _main.Rows;
			int r2 = rows.Count-1;
			int r1 = r2 - _rows + 1;
			if (r1 <= rows.Fixed) r1 = rows.Fixed;

			// hide control if the main grid is big enough
			Visible = (r1 <= r2);
			if (!Visible) return;

			// set control size and location
			Rectangle rc = _main.ClientRectangle;
			if (rows[r2].Bottom <= rc.Bottom)
			{
				Visible = false;
				return;
			}
			int hei = rows[r2].Bottom - rows[r1].Top + 1;
			rc.Y = rc.Bottom - hei;
			rc.Height = hei;
			Bounds = rc;

			// adjust child grid to hide fixed rows
			rc = ClientRectangle;
			hei = rows[rows.Fixed + rows.Frozen].Top;
			rc.Y -= hei;
			rc.Height += hei;
			_frz.Bounds = rc;

			// syncronize scroll position
			SynchScrollPosition(false);
		}
		internal void SynchScrollPosition(bool synchMain)
		{
			Point pos;

			// optionally synchronize X scroll position on the main grid
			if (synchMain)
			{
				pos = _frz.ScrollPosition;
				pos.Y = _main.ScrollPosition.Y;
				_main.ScrollPosition = pos;
			}

			// syncronize X scroll position of the frozen grid with main
			pos = _main.ScrollPosition;
			pos.Y = -64000;
			_frz.ScrollPosition = pos;

			// update everything right away
			_main.Update();
			_frz.Update();
		}

		// make normal and scrollable areas look different
		// (when painting and when editing)
		private void _frz_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
		{
			if (e.Style.BackColor == _frz.Styles.Normal.BackColor)
			{
				e.Graphics.FillRectangle(Brushes.Beige, e.Bounds);
				e.DrawCell(DrawCellFlags.Border | DrawCellFlags.Content);
			}
		}
		private void _frz_SetupEditor(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			_frz.BackColor = Color.Beige;
		}

		// adjust layout after resizing the main grid (our container)
		private void _main_Resize(object sender, System.EventArgs e)
		{
			AdjustLayout();
		}

		// synchronize scrolling
		private void _main_AfterScroll(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			SynchScrollPosition(false);
		}
		private void _frz_AfterScroll(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			// if the frozen grid has the focus and the user selects non-frozen
			// cells, scroll main grid up.
			if (_frz.Focused)
			{
				int row = Math.Min(_frz.Row, _frz.RowSel);
				int bot = _main.Rows[row].Bottom + _main.ScrollPosition.Y;
				if (bot > Top)
				{
					// unless this is a mouse selection, give focus to main grid
					if (!_frz.Capture) _main.Focus();
					_main.TopRow = _main.Row;
				}
			}
			SynchScrollPosition(true);
		}

		// scroll while selecting
		// if the user extends the selection down on the main grid, scroll it down.
		private void _main_SelChange(object sender, System.EventArgs e)
		{
			// only when the main grid has the focus!
			if (!_main.Focused) return;

			// calculate selection bottom (accounting for scrolling)
			int row = Math.Max(_main.Row, _main.RowSel);
			int bot = _main.Rows[row].Bottom + _main.ScrollPosition.Y;

			// try scrolling if past the bottom of the frozen area
			if (bot > Top) _main.TopRow++;
		}

		// adjust layout after massive changes (resize rows/cols, sort, etc)
		private void _main_GridChanged(object sender, C1.Win.C1FlexGrid.GridChangedEventArgs e)
		{
			switch (e.GridChangedType)
			{
				case GridChangedTypeEnum.GridChanged:
				case GridChangedTypeEnum.LayoutChanged:
					AdjustLayout();
					break;
			}
		}
	}
}