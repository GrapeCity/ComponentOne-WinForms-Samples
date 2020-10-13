using System;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.C1FlexGrid;

namespace CellNotes
{
	/// <summary>
	/// CellNoteManager manages CellNote objects stored in C1FlexGrid 
	/// cells. It does three things:
	/// 
	/// 1) Hooks up some event handlers to detect when the mouse moves 
	/// over cells that contain CellNote objects and displays the notes.
	/// 
	/// 2) Provides an OwnerDraw handler that displays the cell note 
	/// indicator on the upper right corner of cells that contain notes.
	/// 
	/// 3) Provides a ContextMenu that allows users to create, edit, 
	/// and delete CellNotes.
	/// 
	/// To use the CellNoteManager, instantiate it and pass a C1FlexGrid
	/// control as a parameter:
	/// 
	///    CellNoteManager mgr = new CellNoteManager(_flex);
	///  
	/// </summary>
	public class CellNoteManager
	{
		//------------------------------------------------------------------------------------------------------
		#region ** fields

		private C1FlexGrid	_flex;				// grid that owns the notes
		private CellNote	_note;				// note currently displayed
		private bool		_menuActive;		// context menu is active (don't display notes)
		
		private ContextMenu _menu;
		private MenuItem	_mInsertNote;
		private MenuItem	_mEditNote;
		private MenuItem	_mDeleteNote;

		#endregion

		//------------------------------------------------------------------------------------------------------
		#region ** ctor

		public CellNoteManager(C1FlexGrid flex)
		{
			// store reference to grid that contains the notes
			_flex = flex;

			// attach event handlers
			_flex.DrawMode = DrawModeEnum.OwnerDraw;
			_flex.MouseHoverCell += new EventHandler(_flex_MouseHoverCell);
			_flex.OwnerDrawCell += new OwnerDrawCellEventHandler(_flex_OwnerDrawCell);
			_flex.MouseDown += new MouseEventHandler(_flex_MouseDown);

			// create context menu
			_menu        = new ContextMenu();
			_mInsertNote = new MenuItem("Insert Note", new EventHandler(_mInsertNote_Click));
			_mEditNote   = new MenuItem("Edit Note",   new EventHandler(_mEditNote_Click));
			_mDeleteNote = new MenuItem("Delete Note", new EventHandler(_mDeleteNote_Click));
			_menu.MenuItems.Add(_mInsertNote);
			_menu.MenuItems.Add(_mDeleteNote);
			_menu.MenuItems.Add(_mEditNote);
		}

		#endregion

		//------------------------------------------------------------------------------------------------------
		#region ** utility

		private CellNote GetNoteAtMouse()
		{
			int row = _flex.MouseRow;
			int col = _flex.MouseCol;
			if (row >= _flex.Rows.Fixed && col >= _flex.Cols.Fixed)
			{
				CellRange rg = _flex.GetCellRange(row, col);
				return rg.UserData as CellNote;
			}
			return null;
		}

		#endregion

		//------------------------------------------------------------------------------------------------------
		#region ** grid event handlers

		// show/hide cell notes
		private void _flex_MouseHoverCell(object sender, System.EventArgs e)
		{
			// hide current note, if any
			if (_note != null)
			{
				_note.HideNote();
				_note = null;
			}

			// don't show note if the grid is not focused or if the context menu is active
			if (!_flex.Focused || _menuActive)
			{
				return;
			}

			// show new note, if any
			_note = GetNoteAtMouse();
			if (_note != null)
			{
				Rectangle r = _flex.GetCellRect(_flex.MouseRow, _flex.MouseCol);
				r = _flex.RectangleToScreen(r);
				_note.ShowNote(r);
			}
		}

		// draw cell note indicator on the cell 
		// (a little red triangle on the upper-right corner)
		private void _flex_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
		{
			// check if the cell has a note
			CellRange rg = _flex.GetCellRange(e.Row, e.Col);
			if (rg.UserData is CellNote)
			{
				// default drawing
				e.DrawCell();

				// add the little red rectangle that indicaates there's a note on this cell
				Point pt = new Point(e.Bounds.Right, e.Bounds.Y);
				Point[] points = { new Point(pt.X - 4, pt.Y), pt, new Point(pt.X, pt.Y + 4) };
				e.Graphics.FillPolygon(Brushes.Red, points);
			}
		}

		// show context menu when user presses the right button
		private void _flex_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				// hide current note, if any
				if (_note != null)
				{
					_note.HideNote();
					_note = null;
				}

				// make sure user clicked a valid cell
				int row = _flex.MouseRow;
				int col = _flex.MouseCol;
				if (row >= _flex.Rows.Fixed && col >= _flex.Cols.Fixed)
				{
					// select cell that was clicked
					_flex.Select(row, col);

					// update context menu
					bool hasNote = GetNoteAtMouse() != null;
					_mInsertNote.Visible = !hasNote;
					_mEditNote.Visible   = hasNote;
					_mDeleteNote.Visible = hasNote;

					// show the menu
					_menuActive = true;
					_menu.Show(_flex, new Point(e.X, e.Y));
					//Application.DoEvents();
					_menuActive = false;
				}
			}
		}

		#endregion

		//------------------------------------------------------------------------------------------------------
		#region ** menu event handlers

		private void _mDeleteNote_Click(object sender, System.EventArgs e)
		{
			// get note
			CellRange rg = _flex.Selection;
			CellNote note = rg.UserData as CellNote;

			// clear note
			if (note != null)
			{
				rg.UserData = null;
				_flex.Invalidate();
			}

			// resume showing notes
			_menuActive = false;
		}
		private void _mInsertNote_Click(object sender, System.EventArgs e)
		{
			// create note
			CellNote note = new CellNote("Note: ");

			// attach note to cell
			CellRange rg = _flex.Selection;
			rg.UserData = note;
			_flex.Invalidate();

			// go edit the new note
			_mEditNote_Click(sender, e);
		}
		private void _mEditNote_Click(object sender, System.EventArgs e)
		{
			// get note
			CellRange rg = _flex.Selection;
			CellNote note = rg.UserData as CellNote;
		
			// edit note
			if (note != null)
			{
				Rectangle r = _flex.GetCellRect(rg.r1, rg.c1);
				r = _flex.RectangleToScreen(r);
				note.EditNote(r);
			}

			// resume showing notes
			_menuActive = false;
		}
		#endregion
	}
}
