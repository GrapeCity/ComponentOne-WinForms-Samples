/* ------------------------------------------------------------------------
 * C1FlexGroup.cs
 * 
 * Implements Outlook-style grouping using the C1FlexGrid control
 * ------------------------------------------------------------------------
 * This is a part of the C1FlexGrid package.
 * 
 * This source code is intended as a supplement to the C1FlexGrid control
 * and related documentation provided with the product. See these sources 
 * for detailed information regarding the C1FlexGrid product.
 * 
 * The C1FlexGroup control demonstrates how you can inherit from the 
 * C1FlexGrid control to provide additional functionality.
 * 
 * You may use this code as-is or modify it for any purpose you see fit,
 * including the development of commercial applications. If you make any
 * improvements that you would like to share with other users, please 
 * post them at the C1FlexGrid newsgroup. Thanks.
 * 
 * ------------------------------------------------------------------------
 * Version history:
 * 
 * 1.0: June 2002	Sample created
 * 
 * 1.1: June 2003   Updated (minor fixes and improvements)
 * 					some fixes provided by d.smith@ceoimage.com:
 * 
 * 1.2: Oct 2003  - Added Groups property, a comma-delimited list of column
 *					names used to apply a custom view to the control
 *					(e.g. _fg.Groups = "Country,City")
 *                - Added FilterRow property, a boolean that shows or hides
 *					a filter row at the top of the grid.
 * 
 * 1.3: Jan 2004 - Updated (minor fixes and improvements)
 * 
 * 1.4: Mar 2004 - Fixed Localization issues
 * 
 * 1.5: Dec 2004 - Allow sorting ungrouped columns
 * ------------------------------------------------------------------------
 */
using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using System.Reflection;
using System.Diagnostics;
using C1.Win.FlexGrid;

namespace C1FlexGroup
{
	/// <summary>
	/// C1FlexGroup
	/// </summary>
	[
    LicenseProvider(),
	ToolboxBitmap(typeof(C1FlexGroup))
	]
	public class C1FlexGroup : PictureBox, ISupportInitialize
	{
		//--------------------------------------------------------------------------------
		#region ** fields **

		private C1FlexGrid		_flex;				// grid control
		private ArrayList		_groups;			// list of fields (columns) in the group area
		private FieldDragger	_dragger;			// aux control to drag fields
		private CellStyle		_styleGroup;		// used to paint groups
		private CellStyle		_styleEmpty;		// used to paint empty area
		private bool			_showGroups;		// show/hide grouping area
		private bool			_insGroup;			// whether column being inserted is a group/column 
		private bool			_dirty;				// need to refresh groups
		private int				_insIndex;			// index where group/column should be inserted
		private string			_groupMessage;		// message displayed in the empty group area
		private Rectangle		_insRect;			// rectangle where insert indicator is drawn
		private Rectangle		_insRectLast;		// rectangle where last insert indicator was drawn
		private SolidBrush		_brBack, _brFore;	// gdi objects used for painting group area
		private SolidBrush		_brGrp, _brBdr;		// gdi objects used for painting grid
		private FilterRow		_filterRow;			// filter row (control visibility with FilterRow property)

		private static StringFormat	_sf;
		private static Bitmap	_bmpInsert;			// insert icon
		private static Bitmap	_bmpSortUp;			// sort icon
		private static Bitmap	_bmpSortDn;			// sort icon

		private const int		MARGIN        = 8;  // spacing between groups, edges
		private const int		SCROLLSTEP    = 15;	// scroll step (while dragging mouse)
		private const int		DRAGTHRESHOLD = 8;	// pixels before starting column drag
		private const string	GROUP_MSG     = "Drag column headers here to create groups";

		#endregion

		//--------------------------------------------------------------------------------
		#region ** expose grid events **

		public event GridChangedEventHandler		GridChanged;
		public event RangeEventHandler              BeforeRowColChange;
		public event RangeEventHandler              AfterRowColChange;
		public event RangeEventHandler              BeforeSelChange;
		public event RangeEventHandler              AfterSelChange;

		#endregion

		//--------------------------------------------------------------------------------
		#region ** ctor **

		static C1FlexGroup()
		{
			// initialize static members
			_sf = new StringFormat(StringFormat.GenericDefault);
			_sf.Alignment = _sf.LineAlignment = StringAlignment.Center;
			_bmpInsert = LoadBitmap("InsertPoint", Color.White);
			_bmpSortUp = LoadBitmap("SortUp", Color.Red);
			_bmpSortDn = LoadBitmap("SortDn", Color.Red);
		}
		public C1FlexGroup()
		{
			// initialize contained Flex control
			_flex = new C1FlexGrid();
			_flex.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			_flex.Dock = DockStyle.Bottom;
			_flex.Size = new Size(10,10);
			_flex.AllowMerging = AllowMergingEnum.Nodes;
			_flex.Cols[0].Width = _flex.Rows.DefaultSize;
			_flex.ShowCursor = true;
			_flex.Tree.Style = TreeStyleFlags.Symbols;
			_flex.DrawMode = DrawModeEnum.OwnerDraw;
			_flex.BeforeMouseDown += new BeforeMouseDownEventHandler(_flex_BeforeMouseDown);
			_flex.KeyPress += new KeyPressEventHandler(_flex_KeyPress);
			_flex.BeforeEdit += new RowColEventHandler(_flex_BeforeEdit);
			_flex.AfterResizeColumn += new RowColEventHandler(_flex_AfterResizeColumn);
			_flex.OwnerDrawCell += new OwnerDrawCellEventHandler(_flex_OwnerDrawCell);
			_flex.AfterDataRefresh += new ListChangedEventHandler(_flex_DataChanged);
			_flex.GridChanged += new GridChangedEventHandler(_flex_GridChanged);

			// hook up additional event handlers
			_flex.BeforeRowColChange += new RangeEventHandler(_flex_BeforeRowColChange);
			_flex.AfterRowColChange  += new RangeEventHandler(_flex_AfterRowColChange );
			_flex.BeforeSelChange += new RangeEventHandler(_flex_BeforeSelChange);
			_flex.AfterSelChange += new RangeEventHandler(_flex_AfterSelChange);

			// initialize styles
			_flex.Styles.Normal.Border.Direction = BorderDirEnum.Horizontal;
			_styleGroup = _flex.Styles.Add("Group", _flex.Styles.Fixed);
			_styleEmpty = _flex.Styles.Add("Empty", _flex.Styles.EmptyArea);
			_styleEmpty.BackColor = SystemColors.ControlDarkDark;
			_styleEmpty.ForeColor = SystemColors.ControlLightLight;

			// initialize internal members
			_groupMessage = GROUP_MSG;
			_groups = new ArrayList();
			_showGroups = true;
			_insIndex = -1;

			// initialize field dragger control
			_dragger = new FieldDragger(this);

			// add filter row (control visibility with 'FilterRow' property)
			_filterRow = new FilterRow(_flex);
			_filterRow.Visible = false;
		
			// initialize parent control
			SuspendLayout();
			BorderStyle = BorderStyle.Fixed3D;
			BackColor = SystemColors.ControlDark;
			ForeColor = SystemColors.ControlLightLight;
			Controls.AddRange(new Control[] { _dragger, _flex });
			ResumeLayout(false);
		}

		#endregion

		//--------------------------------------------------------------------------------
		#region ** ISupportInitialize **

		void ISupportInitialize.BeginInit()
		{
			_flex.BeginInit();
		}
		void ISupportInitialize.EndInit()
		{
			// don't call EndInit without BeginInit first <<B4>>
			_flex.BeginInit();
			_flex.EndInit();

			// flex has re-created the styles, 
			// so get a fresh reference to the custom ones we'll use
			_styleGroup = _flex.Styles["Group"];
			_styleEmpty = _flex.Styles["Empty"];

			// make sure grid is visible <<B4>>
			_flex.Visible = true;
			UpdateLayout();
		}

		#endregion

		//--------------------------------------------------------------------------------
		#region ** object model **

		[
		Description("Gets the contained C1FlexGrid control."),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Content) 
		]
		public C1FlexGrid Grid
		{
			get { return _flex; }
		}
		[
		Description("Gets or sets whether to show the groups."),
		DefaultValue(true)
		]
		public bool ShowGroups
		{
			get { return _showGroups; }
			set
			{
				_showGroups = value;
				UpdateLayout();
			}
		}
		[ 
		Description("Gets the CellStyle object used to paint the group rows."),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) 
		]
		public CellStyle StyleGroupRows
		{
			get { return _styleGroup; }
		}
		[ 
		Description("Gets the CellStyle object used to paint the group area."),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) 
		]
		public CellStyle StyleGroupArea
		{
			get { return _styleEmpty; }
		}
		[ Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		new public Image Image
		{
			get { return base.Image; }
			set { base.Image = value; }
		}
		[ 
		Description("Gets or sets the message shown in the empty group area."),
		Localizable(true), // <<B4>> localize this message
		DefaultValue(GROUP_MSG)
		]
		public string GroupMessage
		{
			get { return _groupMessage; }
			set
			{
				_groupMessage = value; 
				Invalidate();
			}
		}
		[
		Description("Gets or sets a comma-delimited list of the groups (by column name)."),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden) 
		]
		public string Groups
		{
			get
			{
				// build string with column names
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < _groups.Count; i++)
				{
					if (i > 0) sb.Append(", ");
					sb.Append(((Column)_groups[i]).Name);
				}
				return sb.ToString();
			}
			set 
			{
				// make current group columns visible
				_flex.Redraw = false;
				foreach (Column col in _groups)
				{
					col.Visible = true;
				}

				// rebuild _groups collection
				_groups.Clear();
				string[] colNames = value.Split(',');
				foreach (string colName in colNames)
				{
                    string name = colName.Trim();
					if (name.Length > 0)
					{
						Column col = _flex.Cols[name];
						if (col != null) _groups.Add(col);
					}
				}

				// apply new collection
				_dirty = true;
				UpdateGroups();
				UpdateLayout();

				// done
				_flex.Redraw = true;
			}
		}
		[
		Description("Gets or sets whether the control should display a filter row above the data."),
		DefaultValue(false)
		]
		public bool FilterRow
		{
			get { return _filterRow.Visible; }
			set 
			{
				if (_filterRow.Visible != value)
				{
					_filterRow.Clear();
					_filterRow.Visible = value;
				}
			}
		}

		#endregion

		//--------------------------------------------------------------------------------
		#region ** overrides **

		// adjust layout when the control is resized
		override protected void OnSizeChanged(EventArgs e)
		{
			UpdateLayout();
			base.OnSizeChanged(e);
		}

		// start dragging groups
		override protected void OnMouseDown(MouseEventArgs e)
		{
			// we're interested in the left button
			if ((e.Button & MouseButtons.Left) != 0)
			{
				for (int i = 0; i < _groups.Count; i++)
				{
					Rectangle rc = GetGroupRectangle(i);
					if (rc.Contains(e.X, e.Y))
					{
						_dragger.StartDragging((Column)_groups[i], rc);
						return;
					}
				}
			}

			// allow base class processing
			base.OnMouseDown(e);
		}

		// paint group area
		override protected void OnPaint(PaintEventArgs e)
		{
			UpdateObjects();
			Graphics g = e.Graphics;

			// get group area
			Rectangle rc = ClientRectangle;
			rc.Height = _flex.Top;

			// draw background
			g.FillRectangle(_brBack, rc);
			if (_groups.Count == 0)
			{
				g.DrawString(_groupMessage, _styleEmpty.Font, _brFore, rc, _sf);
			}
			else // draw groups
			{
				for (int i = 0; i < _groups.Count; i++)
				{
					rc = GetGroupRectangle(i);
					PaintGroup(g, rc, (Column)_groups[i]);
				}
			}

			// show insert position while dragging
			if (_dragger.Visible)
			{
				DrawImageCentered(g, _bmpInsert, _insRect);
			}
		}

		// update GDI objects based on grid style
		internal void UpdateObjects()
		{
			Color clr;

			// update objects used to draw group area
			clr = _styleEmpty.BackColor;
			if (_brBack == null || _brBack.Color != clr)
			{
				_brBack = new SolidBrush(clr);
			}

			clr = _styleEmpty.ForeColor;
			if (_brFore == null || _brFore.Color != clr)
			{
				_brFore = new SolidBrush(clr);
			}

			// update objects used to draw grid
			clr = _styleGroup.BackColor;
			if (_brGrp == null || _brGrp.Color != clr)
			{
				_brGrp = new SolidBrush(clr);
			}
			clr = _styleGroup.Border.Color;
			if (_brBdr == null || _brBdr.Color != clr)
			{
				_brBdr = new SolidBrush(clr);
			}
		}

		#endregion

		//--------------------------------------------------------------------------------
		#region ** event handlers **

		// cancel dragging when a key is pressed
		private void _flex_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (_dragger.Visible)
			{
				_dragger.Visible = false;
				Invalidate();
			}
		}

		// start dragging columns
		private void _flex_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
		{
			// we're interested in the left button
			if ((e.Button & MouseButtons.Left) == 0)
				return;
			
			// check that the click was on a column header
			HitTestInfo hti = _flex.HitTest(e.X, e.Y);
			if (hti.Type != HitTestTypeEnum.ColumnHeader)
				return;

			// check that the click was on the first row
			// (in case there's additional fixed rows)
			if (hti.Row > 0)
				return;

			// check that the click was on a scrollable column
			ColumnCollection cols = _flex.Cols;
			if (hti.Column < cols.Fixed)
				return;

			// eat the event 
			e.Cancel = true;

            // check that we have at least one non-grouped column
            var visCount = 0;
            for (var i = cols.Fixed; i < cols.Count; i++)
            {
                if (cols[i].Visible)
                    visCount++;
            }
            if (visCount < 2)
                return;

			// start dragging column
			_dragger.StartDragging(cols[hti.Column]);
		}

		// prevent editing group headers // <<B5>>
		private void _flex_BeforeEdit(object sender, RowColEventArgs e)
		{
			if (_flex.Rows[e.Row].IsNode)
			{
				e.Cancel = true;
			}
		}

		// update layout after resizing columns
		private void _flex_AfterResizeColumn(object sender, RowColEventArgs e)
		{
			UpdateLayout();
		}

		// draw cells to make them look like Outlook
		private void _flex_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
		{
            // do not paint while measuring
            if (e.Graphics == null) return;

			// custom draw only scrollable rows on tree column
			if (_groups.Count == 0) return;
			if (e.Col != _flex.Tree.Column) return;
			if (e.Row < _flex.Rows.Fixed) return;

			// get parameters we'll need
			Row row = _flex.Rows[e.Row];
			if (row.Node == null) return;
			int idt = _flex.Tree.Indent;
			int x   = _flex.ScrollPosition.X;
			int lvl = row.Node.Level;
			Rectangle rc;

			// custom draw nodes
			UpdateObjects();
			if (row.IsNode)
			{
				// draw background and content
				e.Style = _styleGroup;
				e.DrawCell(DrawCellFlags.Background | DrawCellFlags.Content);

				// draw line above
				if (lvl == 0 || !_flex.Rows[e.Row-1].IsNode)
				{
					rc = e.Bounds;
					OffsetLeft(ref rc, lvl * idt + x);
					rc.Height = 1;
					e.Graphics.FillRectangle(_brBdr, rc);
				}

				// if the node is expanded, draw line below
				if (row.Node.Expanded)
				{
					rc = e.Bounds;
					OffsetLeft(ref rc, (lvl+1) * idt + x);
					rc.Y = rc.Bottom-1;
					rc.Height = 1;
					e.Graphics.FillRectangle(_brBdr, rc);
				}

				// draw vertical lines to the left of the symbol
				rc = e.Bounds;
				rc.X += x;
				rc.Width = 1;
				for (int i = 0; i <= lvl; i++)
				{
					e.Graphics.FillRectangle(_brBdr, rc);
					rc.Offset(idt, 0);
				}

				// done
				return;
			}

			// custom draw data
			{
				// base painting
				e.DrawCell();

				// fill area on the left
				rc = e.Bounds;
				rc.Width = (lvl+1) * idt;
				e.Graphics.FillRectangle(_brGrp, rc);

				// draw vertical lines over filled area
				rc = e.Bounds;
				rc.Width = 1;
				for (int i = 0; i <= lvl+1; i++)
				{
					e.Graphics.FillRectangle(_brBdr, rc);
					rc.Offset(idt, 0);
				}
			}
		}
		internal void OffsetLeft(ref Rectangle rc, int x)
		{
			rc.X += x;
			rc.Width -= x;
		}

		// repaint control when styles change
		private void _flex_GridChanged(object sender, GridChangedEventArgs e)
		{
			// invalidate whole control
			if (e.GridChangedType == GridChangedTypeEnum.StyleChanged ||
				e.GridChangedType == GridChangedTypeEnum.RepaintGrid)
				Invalidate();

			// fire GridChanged event
			if (GridChanged != null)
				GridChanged(this, e);
		}		

		#endregion

		//--------------------------------------------------------------------------------
		#region ** fire grid events **

		private void _flex_BeforeRowColChange(object sender, RangeEventArgs e)
		{
			if (BeforeRowColChange != null) BeforeRowColChange(this, e);
		}
		private void _flex_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if (AfterRowColChange != null) AfterRowColChange(this, e);
		}
		private void _flex_BeforeSelChange(object sender, RangeEventArgs e)
		{
			if (BeforeSelChange != null) BeforeSelChange(this, e);
		}
		private void _flex_AfterSelChange(object sender, RangeEventArgs e)
		{
			if (AfterSelChange != null) AfterSelChange(this, e);
		}

		// reset groups when data source changes <<1.1>>
		private void _flex_DataChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.Reset)
			{
				_dirty = true;
				UpdateGroups();
			}
        }

		#endregion

		//--------------------------------------------------------------------------------
		#region ** utilities **

		// update the size of the group area
		protected void UpdateLayout()
		{
			// calculate size of grouping area
			int hei = 0;
			if (_showGroups)
			{
				hei = (_groups.Count > 0)
					? GetGroupRectangle(_groups.Count-1).Bottom + MARGIN
					: _flex.Rows.DefaultSize + 2 * MARGIN; // <<B5>>
			}

			// move grid to remaining area
			_flex.Height = ClientRectangle.Height - hei;

			// repaint the control
			Invalidate();

			// and update groups
			UpdateGroups();
		}

		// update grouping/sorting
		internal bool UpdateGroupNeeded()
		{
	        // reset groups if the data source has changed <<1.1>>
			for (int i = 0; i < _groups.Count; i++)
			{
				Column col = (Column)_groups[i];

				// if index is bad, try fixing it
				if (col.Index < 0)
				{
					if (_flex.Cols.Contains(col.Name))
					{
						_groups[i] = _flex.Cols[col.Name];
					}
					else
					{
						_groups.Clear();
						return true;
					}
				}
			}

			// groups must be the first columns and must be hidden
			ColumnCollection cols = _flex.Cols;
			int iFixed = cols.Fixed;
			for (int i = 0; i < _groups.Count; i++)
			{
				Column col = cols[i + iFixed];
				if (col.Visible || !_groups[i].Equals(col))
					return true;
			}

			// remaining columns must be visible
			for (int i = iFixed + _groups.Count; i < cols.Count; i++)
			{
				if (!cols[i].Visible)
					return true;
			}

			// no update is needed
			return false;
		}

		// update grouping/sorting
		internal void UpdateGroups()
		{
			// check whether we need to update the groups
			if (!_dirty && !UpdateGroupNeeded())
				return;

			// stop painting for a while
			_flex.Redraw = false;

			// remove subtotals
			_flex.Subtotal(AggregateEnum.Clear);

			// adjust group columns
			ColumnCollection cols = _flex.Cols;
			int index = cols.Fixed;

			// UPDATED BY d.smith@ceoimage.com:
			// remember whether each column was visible
			bool[] wasVisible = new bool[cols.Count];

			// update column visibility
			foreach (Column col in _groups)
			{
				// adjust column position/visibility
				wasVisible[col.Index] = col.Visible;
				col.Visible = false;
				cols.Move(col.Index, index++);

				// initialize sorting direction if necessary
				if ((col.Sort & (SortFlags.Ascending | SortFlags.Descending)) == 0)
					col.Sort = SortFlags.Ascending;
			}

			// restore visibility
			for (; index < cols.Count; index++)
				if (wasVisible[index])
					cols[index].Visible = true;

			// sort columns
			//_flex.Sort(SortFlags.UseColSort, cols.Fixed, _groups.Count);
			_flex.Sort(SortFlags.UseColSort, cols.Fixed, cols.Count - 1); // <<B5>>

			// make sure tree is in the right position
			_flex.Tree.Column = cols.Fixed + _groups.Count;

			// and make sure tree contents are left-aligned (or there's no spill merge) <<1.1>>
			_flex.Cols[_flex.Tree.Column].TextAlign = TextAlignEnum.LeftCenter;

			// and insert subtotals
			for (index = 0; index < _groups.Count; index++)
			{
				int col = index + cols.Fixed;
				string fmt = cols[col].Caption + ": {0}";
				_flex.Subtotal(AggregateEnum.None, index, col, 0, fmt);
			}

			// done
			_dirty = false;
			_flex.Redraw = true;
		}

		// update the position of the insertion indicator
		internal void UpdateInsertLocation()
		{
			Point loc = PointToClient(Control.MousePosition);
			Rectangle rc;

			// initialize members
			_insRect = Rectangle.Empty;
			_insIndex = -1;
			
			// insert into group list
			if (loc.Y < _flex.Top)
			{
				// find position where new group should be inserted
				int index = _groups.Count;
				for (int i = 0; i < _groups.Count; i++)
				{
					rc = GetGroupRectangle(i);
					if (rc.X + rc.Width/2 > loc.X)
					{
						index = i;
						break;
					}
				}

				// update insert info
				_insGroup = true;
				_insIndex = index;

				// update insert position
				if (index < _groups.Count)
				{
					_insRect = GetGroupRectangle(index);
					_insRect.X -= MARGIN;
				}
				else
				{
					_insRect = GetGroupRectangle(_groups.Count-1);
					_insRect.X = _insRect.Right;
				}
				if (index > 0 && index < _groups.Count)
				{
					_insRect.Y -= _insRect.Height/2;
					_insRect.Height += _insRect.Height/2;
				}
				_insRect.Width = MARGIN;
			}
			else // remove from group list (insert into grid)
			{
				// find position where grid column should be inserted
				int index = _flex.Cols.Count;
				for (int i = _flex.Cols.Fixed; i < _flex.Cols.Count; i++)
				{
					rc = _flex.GetCellRect(0, i, false);
					if (rc.X + rc.Width/2 > loc.X)
					{
						index = i;
						break;
					}
				}

				// and update insert info
				_insGroup = false;
				_insIndex = index;

				// update insert position
				if (index < _flex.Cols.Count)
				{
					_insRect = _flex.GetCellRect(0, index, false);
					_insRect.Width = 0;
				}
				else
				{
					_insRect = _flex.GetCellRect(0, index-1, false);
					_insRect.X = _insRect.Right;
					_insRect.Width = 0;
				}
				_insRect.Inflate(MARGIN/2, 5);
				_insRect.Offset(0, _flex.Top);
			}

			// invalidate to show new insertion point
			if (_insRect != _insRectLast)
			{
				Invalidate();
				_insRectLast = _insRect;
			}
		}

		// finish dragging a column (or group)
		internal void FinishDragging(Column col, bool dragged)
		{
			// didn't drag? then it was a click: apply/reverse sort
			if (!dragged)
			{
                // check that sorting is allowed here
                if (_flex.AllowSorting == AllowSortingEnum.None || !col.AllowSorting)
                    return;

                // reverse column sort
				col.Sort = ((col.Sort & SortFlags.Ascending) != 0)
					? SortFlags.Descending
					: SortFlags.Ascending;

				// if this is a non-grouped column, reset Sort property on all other
				// non-grouped columns and re-apply sort
				if (!_groups.Contains(col))
				{
					// reset sort order on other columns
					int colIndex = col.Index;
					ColumnCollection cols = _flex.Cols;
					for (int c = _groups.Count; c < cols.Count; c++)
					{
						if (c != colIndex)
							_flex.Cols[c].Sort = SortFlags.None;
					}

					// apply sort
					_flex.Col = colIndex;
					_flex.Sort(SortFlags.UseColSort, cols.Fixed, cols.Count-1);
					_flex.ShowSortAt(col.Sort, colIndex);
					return;
				}
			}

			// insert column into group collection
			else if (_insGroup)
			{
				// add group to list at the proper position (col->grp, grp->grp)
				_groups.Insert(_insIndex, col);
				for (int i = 0; i < _groups.Count; i++)
				{
					if (i != _insIndex && _groups[i] == col)
					{
						_groups.RemoveAt(i);
						break;
					}
				}
				col.Visible = false;
			}

			// insert column into grid
			else 
			{
				// move column to a new position (col->col, grp->col)
				int oldIndex = col.Index;
				int newIndex = _insIndex;
				if (newIndex > oldIndex) newIndex--;
				_flex.Cols.Move(oldIndex, newIndex);
				col.Visible = true;

				// remove from group list, if it's there (grp->col)
				if (_groups.Contains(col))
					_groups.Remove(col);
			}

			// update layout and repaint
			_dirty = true;
			UpdateLayout();
		}

		// get the position of a group in the group area
		internal Rectangle GetGroupRectangle(int index)
		{
			// build skinny rectangle at the top
			Rectangle rc = new Rectangle(MARGIN, MARGIN, 0, _flex.Rows.DefaultSize);

			// set width if we can
			// (Don't use WidthDisplay because grouped columns are invisible)
			if (index > -1 && index < _groups.Count)
				rc.Width = GetGroupWidth(index);

			// loop/adjust position
			for (int i = 0; i < index; i++)
			{
				rc.X += GetGroupWidth(i) + MARGIN;
				rc.Y += rc.Height/2;
			}

			// return the rectangle
			return rc;
		}

		// get column width in pixels <<B1.3>>
		// note:
		// col.Width returns -1 if the column has default width
		// col.WidthDsplay returns 0 if the column is invisible (groups are)
		private int GetGroupWidth(int index)
		{
			int wid = ((Column)_groups[index]).Width;
			if (wid < 0)
				wid = _flex.Cols.DefaultSize;
			return wid;
		}

		// draw image centering it on rectangle
		internal void DrawImageCentered(Graphics g, Image img, Rectangle rc)
		{
			Size sz = img.Size;
			rc.Offset((rc.Width-sz.Width)/2, (rc.Height-sz.Height)/2);
			rc.Size = sz;
			g.DrawImageUnscaled(img, rc);
		}

		// load a bitmap from the assembly resources
		internal static Bitmap LoadBitmap(string name, Color transparent)
		{
			Assembly a = Assembly.GetExecutingAssembly();

			// find resource by name
			name += ".bmp";
			string resName = null;
			foreach (string res in a.GetManifestResourceNames())
			{
				if (res.EndsWith(name))
				{
					resName = res;
					break;
				}
			}
			if (resName == null)
			{
				Debug.Assert(false, "Could not find resource: " + name);
				return null;
			}

			// load bitmap
			Bitmap bmp = new Bitmap(a.GetManifestResourceStream(resName));
			bmp.MakeTransparent(transparent);
			return bmp;
		}

		// paint group using dragger control
		internal void PaintGroup(Graphics g, Rectangle rc, Column col)
		{
			// draw control
			_dragger.PaintControl(g, rc, col.Caption, false);

			// draw sorting glyph
			if (_flex.ShowSort)
			{
				Image img = ((col.Sort & SortFlags.Ascending)  != 0)? _bmpSortUp
					: ((col.Sort & SortFlags.Descending) != 0)? _bmpSortDn: null;
				if (img != null)
				{
					rc.X = rc.Right - rc.Height;
					rc.Width = rc.Height;
					DrawImageCentered(g, img, rc);
				}
			}
		}

		#endregion

		//--------------------------------------------------------------------------------
		#region ** internal classes **
		/// <summary>
		/// FieldDragger
		/// internal class used to implement field dragging
		/// </summary>
		private class FieldDragger : Label
		{
			private C1FlexGroup	_owner;
			private Column				_column;
			private Point				_offset, _ptDown;
			private bool				_dragging;
			private Rectangle			_rcClip;
			private SolidBrush			_brBack, _brFore, _brDrag;

			static private StringFormat _sf;
			static private Pen			_pDark;
			static private Pen			_pLite;

			// ** ctor

			internal FieldDragger(C1FlexGroup owner)
			{
				// initialize static members
				if (_sf == null)
				{
					_pDark = SystemPens.ControlDark;
					_pLite = SystemPens.ControlLightLight;
					_sf = new StringFormat(StringFormat.GenericDefault);
					_sf.Alignment = StringAlignment.Near;
					_sf.LineAlignment = StringAlignment.Center;
					_sf.FormatFlags |= StringFormatFlags.NoWrap;
				}

				// initialize control
				_owner  = owner;
				Visible = false;
				BackColor = Color.Transparent;
			}

			// ** overrides

			// use custom painting routine
			override protected void OnPaint(PaintEventArgs e)
			{
				Rectangle rc = ClientRectangle;
				PaintControl(e.Graphics, rc, _column.Caption, true);
			}

			// move with the mouse
			override protected void OnMouseMove(MouseEventArgs e)
			{
				// drag while the left button is down
				if ((e.Button & MouseButtons.Left) == 0)
					return;

                // make sure column allows dragging
                if (!_column.AllowDragging)
                    return;

                // make sure the mouse moved at least a little
				if (!_dragging)
				{
					Point ptNow = Control.MousePosition;
					if (Math.Abs(ptNow.X - _ptDown.X) < DRAGTHRESHOLD &&
						Math.Abs(ptNow.Y - _ptDown.Y) < DRAGTHRESHOLD)
						return;
					_dragging = true;
				}

				// calculate new position for the control
				Point pos = _owner.PointToClient(Control.MousePosition);
				Point loc = pos;
				loc.Offset(-_offset.X, -_offset.Y);

				// clip to grouping area, scroll
				Rectangle rc = _rcClip;
				C1FlexGrid g = _owner.Grid;
				Point pt = g.ScrollPosition;
				if (loc.X + Width > rc.Right)
				{
					loc.X = rc.Right - Width;
					pt.X -= SCROLLSTEP;
				}
				if (loc.X < 0)
				{
					loc.X = 0;
					pt.X += SCROLLSTEP;
				}
				if (loc.Y + Height > rc.Bottom) loc.Y = rc.Bottom - Height;
				if (loc.Y < 0) loc.Y = 0;

				// move dragger control
				if (Location != loc) Location = loc;

				// scroll grid
				bool scroll = false;
				if (pos.Y >= _owner.Grid.Top && g.ScrollPosition != pt)
				{
					Point oldPos = g.ScrollPosition;
					g.ScrollPosition = pt;
					scroll = (g.ScrollPosition != oldPos);
				}

				// update insert location (after scrolling grid)
				_owner.UpdateInsertLocation();

				// keep scrolling
				if (scroll) 
				{
					_owner.Update();
					OnMouseMove(e);
				}
			}

			// finish dragging when the left mouse button is released
			override protected void OnMouseUp(MouseEventArgs e)
			{
				// make sure left button is up
				if ((Control.MouseButtons & MouseButtons.Left) != 0)
					return;

				// make sure we're visible
				if (!Visible) return;

				// hide and finish dragging
				Visible = false;
				_owner.FinishDragging(_column, _dragging);
			}

			// lost focus? cancel
			override protected void OnLeave(EventArgs e)
			{
				Visible = false;
			}

			// ** utilities

			// update GDI objects based on grid style
			internal void UpdateObjects()
			{
				Color clr;
				CellStyle cs = _owner.Grid.Styles["Group"];

				clr = cs.BackColor;
				if (_brBack == null || _brBack.Color != clr)
				{
					_brBack = new SolidBrush(clr);
					_brDrag = new SolidBrush(Color.FromArgb(100, clr));
				}

				clr = cs.ForeColor;
				if (_brFore == null || _brFore.Color != clr)
					_brFore = new SolidBrush(clr);

				Font = cs.Font;
			}

			// start dragging a grid column
			internal void StartDragging(Column col)
			{
				C1FlexGrid g = _owner.Grid;
				Rectangle rc = g.GetCellRect(0, col.Index, false);
				rc.Width = col.WidthDisplay; // <<B1.3>>
				rc = g.RectangleToScreen(rc);
				rc = _owner.RectangleToClient(rc);
				StartDragging(col, rc);
			}

			// start dragging a group
			internal void StartDragging(Column col, Rectangle rc)
			{
				C1FlexGrid g = _owner.Grid;
				_column = col;

				// initialize position/visibility
				Size = new Size(rc.Width, rc.Height);
				Location = new Point(rc.X, rc.Y);
				Visible = true;

				// calculate clip rectangle
				_rcClip = _owner.ClientRectangle;
				_rcClip.Height = g.Top + g.Rows[0].HeightDisplay;

				// keep track of the mouse position
				_ptDown = Control.MousePosition;
				_offset = PointToClient(_ptDown);
				_dragging = false;

				// capture mouse to track MouseMove event
				Capture = true;
			}

			// custom paint routine, usable by anyone
			internal void PaintControl(Graphics g, Rectangle rc, string text, bool dragging)
			{
				// paint control
				UpdateObjects();
				g.FillRectangle(dragging? _brDrag: _brBack, rc);
				g.DrawString(text, Font, _brFore, rc, _sf);

				// paint border 
				// note: ControlPaint.DrawBorder3D is not good with transparent stuff
				rc.Width--; rc.Height--;
				g.DrawLine(_pDark, rc.Left+1, rc.Bottom,   rc.Right,   rc.Bottom);
				g.DrawLine(_pDark, rc.Right,  rc.Bottom,   rc.Right,   rc.Top+1);
				g.DrawLine(_pLite, rc.Left,   rc.Bottom-1, rc.Left,    rc.Top);
				g.DrawLine(_pLite, rc.Left,   rc.Top,      rc.Right-1, rc.Top);
			}
		}
		#endregion
	}
}
