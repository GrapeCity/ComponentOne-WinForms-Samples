/* --------------------------------------------------------------------------------------
 * C1FlexDataTree.cs
 * 
 * Implements hierarchical data-binding (MS Access style) using the C1FlexGrid control.
 * 
 * Bind the grid to a table in a hierarchical data set and any rows with child tables 
 * will be displayed as tree nodes. Clicking on the expand button (+) on a fixed row 
 * will open a child grid showing the child table. Child tables may in turn contain 
 * more child tables (nesting is allowed with no pre-set limit).
 * 
 * This type of data binding is similar to what is provided in Microsoft Access 2000 
 * and later in its default table views.
 * 
 * --------------------------------------------------------------------------------------
 * This is a part of the C1FlexGrid package.
 * 
 * This source code is intended as a supplement to the C1FlexGrid control and related 
 * documentation provided with the product. See these sources for detailed information 
 * regarding the C1FlexGrid product.
 * 
 * The C1FlexGroup control demonstrates how you can inherit from the C1FlexGrid 
 * control to provide additional functionality.
 * 
 * You may use this code as-is or modify it for any purpose you see fit, including the 
 * development of commercial applications. If you make any improvements that you would 
 * like to share with other users, please post them at the C1FlexGrid newsgroup. 
 * Thanks.
 * 
 * --------------------------------------------------------------------------------------
 * Version history:
 * 
 * 1.0: December 2003
 *		Sample created
 * 
 * 1.1: August 2004
 *		Added extra 'header' grid to prevent child grids from painting over parent's
 *      fixed rows when the grid scrolls vertically.
 * 
 * 1.2: March 2005
 *		Added check to see if master rows have children.
 *		If they don't, show an "add" glyph instead of the regular collapsed glyph 
 *      (user can still open the empty detail grid to add rows if AllowAddNew is true).
 * --------------------------------------------------------------------------------------
 */
using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using C1.Win.C1FlexGrid;

namespace DataTree
{
	/// <summary>
	/// C1FlexDataTree
	/// </summary>
	[ToolboxBitmap(typeof(C1FlexDataTree))]
	public class C1FlexDataTree : C1FlexGrid, ISupportInitialize
	{
		//--------------------------------------------------------------------------------
		#region ** fields
		
		// reference to hidden column that contains details rows for each master record
		//
		// this is created automatically by a DataSet based on its Relations.
		//
		// e.g. if the parent table is 'Orders', this could be an 'OrderDetails' table 
		// with the order details for each order on the master data table.
		//
		private Column _colChild = null;

		// child grid that displays the headers rows over the native header rows.
		//
		// this grid appears on top of all child controls and prevents children from
		// hiding the parent grid's header rows when they scroll.
		//
		private GridHeader _hdr = null; // <<1.1>>

        private bool _suspendUpdates = false;
        /// <summary>
        /// Allows to suspend redrawing during heavy operations
        /// </summary>
        private bool SuspendUpdates
        {
            get
            {
                return _suspendUpdates;
            }
            set
            {
                if (value != _suspendUpdates)
                {
                    _suspendUpdates = value;
                    if (_suspendUpdates)
                    {
                        BeginUpdate();
                    }
                    else
                    {
                        EndUpdate();
                    }
                }
            }
        }

        #endregion

        //--------------------------------------------------------------------------------
        #region ** ctor

        public C1FlexDataTree()
		{
			Initialize();

			// create 'header' grid <<1.1>>
			_hdr = new GridHeader(this);

            // when user filters the data using the header grid, collapse all children
            _hdr.BeforeFilter += (s, e) =>
                {
                    CollapseAll();
                };
		}
		#endregion

		//--------------------------------------------------------------------------------
		#region ** interfaces

		// ISupportInitialize
		void ISupportInitialize.BeginInit()
		{
			base.BeginInit();
		}
		void ISupportInitialize.EndInit()
		{
			base.EndInit();
			Initialize();
		}
		#endregion

		//--------------------------------------------------------------------------------
		#region ** object model

        /// <summary>
        /// Apply AllowFiltering property to header grid.
        /// </summary>
        new public bool AllowFiltering
        {
            get { return base.AllowFiltering; }
            set
            {
                base.AllowFiltering = value;
                _hdr.AllowFiltering = value;
            }
        }

		// fire event to allow setting up child grids
		// the event sender is the child grid that was just bound
		public event EventHandler SetupColumns;
		protected virtual void OnSetupColumns(object sender)
		{
			if (SetupColumns != null)
				SetupColumns(sender, EventArgs.Empty);
		}

		// get top-level grid (overall parent)
		public C1FlexDataTree ParentGrid
		{
			get
			{
				C1FlexDataTree parent = this;
				while (parent.Parent is C1FlexDataTree)
					parent = parent.Parent as C1FlexDataTree;
				return parent;
			}
		}

		// toggle row state (collapsed/expanded)
		public bool ToggleRowState(int row)
		{
			// sanity
			if (row < Rows.Fixed || row >= Rows.Count)
			{
				return false;
			}

			// toggle collapse/expand state
			return (Rows[row].UserData == null)
				? ExpandRow(row)
				: CollapseRow(row);
		}

		// expand all rows
		public void ExpandAll(int level)
		{
            bool needSuspendUpdates = !SuspendUpdates;
            if (needSuspendUpdates)
            {
                // stop redrawing
                SuspendUpdates = true;
            }

            // expand all child rows
            for (int r = Rows.Fixed; r < Rows.Count; r++)
			{
				bool expanded = ExpandRow(r);
				if (expanded)
				{
					r++;
				}
			}

			// recurse to expand children
			if (level > 0)
			{
				foreach (Control ctl in this.Controls)
				{
					C1FlexDataTree child = ctl as C1FlexDataTree;
					if (child != null)
					{
						child.ExpandAll(level - 1);
					}
				}
			}

            // done
            if (needSuspendUpdates)
            {
                SuspendUpdates = false;
            }
        }

		// collapse all rows
		public void CollapseAll()
		{
            BeginUpdate();
			for (int r = Rows.Fixed; r < Rows.Count; r++)
			{
				CollapseRow(r);
			}
            EndUpdate();
		}

		// expand row
		public bool ExpandRow(int row)
		{
			// sanity
			if (row < Rows.Fixed || row >= Rows.Count)
			{
				return false;
			}

			// check that the row is not already expanded
			C1FlexDataTree childGrid = Rows[row].UserData as C1FlexDataTree;
			if (childGrid != null)
			{
				return false;
			}

			// check that we have a data source for this row
			object dataSource = _colChild != null ? _colChild[row] : null;
			if (!(dataSource is IBindingList))
			{
				return false;
			}

            // ** fire before collapse event
            var e = new RowColEventArgs(row, -1);
            OnBeforeCollapse(e);
            if (e.Cancel)
            {
                return false;
            }

			// add node row (unbound) to display child
			Rows.InsertNode(row + 1, -1);

			// make new row non-editable (it's just a placeholder)
			Rows[row + 1].AllowEditing = false;

			// create child grid
			childGrid = new C1FlexDataTree();
            if (SuspendUpdates)
            {
                childGrid.SuspendUpdates = true;
            }
            childGrid.Visible = false;
			childGrid.ScrollBars = ScrollBars.Horizontal;

			// attach child grid to parent, set data source
			Controls.Add(childGrid);

            childGrid.ApplyParentStyles(this);
            childGrid.DataSource = dataSource;

			// save references: 
			// child grid Tag property contains a reference to the parent row
			// parent row UserData contains a reference to the child grid
			childGrid.Tag = Rows[row];
			Rows[row].UserData = childGrid;

            // move child grid into position, make it visible
            childGrid.UpdatePosition();
            childGrid.Visible = true;
            if (!SuspendUpdates)
            {
                childGrid.Focus();
            }

            // ** fire after collapse event
            OnAfterCollapse(e);
            
			// done
			return true;
		}

		// collapse row
		public bool CollapseRow(int row)
		{
			// sanity
			if (row < Rows.Fixed || row >= Rows.Count)
			{
				return false;
			}

			// check that the row is expanded
			C1FlexDataTree childGrid = Rows[row].UserData as C1FlexDataTree;
			if (childGrid == null)
			{
				return false;
			}

            // ** fire before collapse event
            var e = new RowColEventArgs(row, -1);
            OnBeforeCollapse(e);
            if (e.Cancel)
            {
                return false;
            }

			// break references
			Rows[row].UserData = null;
			childGrid.Tag = null;

			// clear child and remove it from parent
			childGrid.Controls.Clear();
			Controls.Remove(childGrid);

			// delete container row
			Rows.Remove(row + 1);

            // ** fire after collapse event
            OnAfterCollapse(e);

			// done
			return true;
		}


		#endregion

		//--------------------------------------------------------------------------------
		#region ** private methods
		
		// called by ctor and ISupportInitialize to set default properties
		private void Initialize()
		{
			DrawMode = DrawModeEnum.OwnerDraw;
			Cols[0].ImageAlign = ImageAlignEnum.RightCenter;
			Cols[0].Width = Rows[0].HeightDisplay * 2;
		}

		// update size/position of all child grids and of this grid within this parent.
		// this is called when the grid scrolls, when it's size changes, and when 
		// rows or columns are added, removed, or resized.
		private void UpdateChildren()
		{
			// update position of all children
			for (int row = 0; row < Rows.Count; row++)
			{
				C1FlexDataTree child = Rows[row].UserData as C1FlexDataTree;
				if (child != null)
				{
                    child.SuspendUpdates = false;
                    child.UpdatePosition();
				}
			}
		}

        private void ApplyParentStyles(C1FlexDataTree parent)
        {
            if (parent != null)
            {
                Cols[0].Width = parent.Cols[0].Width;
                ShowCursor = parent.ShowCursor;
                AllowAddNew = parent.AllowAddNew;
                AllowDelete = parent.AllowDelete;
                BorderStyle = parent.BorderStyle;
                Styles.ParseString(parent.Styles.BuildString(true));
            }
        }

        // update position of this child grid within its parent.
        // this is called by the UpdateChildren method above and also 
        // when child grids are created.
        private void UpdatePosition()
		{
			// sanity
			C1FlexDataTree parent = Parent as C1FlexDataTree;
			Row parentRow = Tag as Row;
			if (parent == null || parentRow == null) return;

			// get cell rectangle
			int row = parentRow.Index;
			Rectangle rc = parent.GetCellRectDisplay(row, 0);

            // calculate child location and client size
            rc.X = rc.Right;
            rc.Y = rc.Bottom;
            rc.Width = Cols[Cols.Count - 1].Right;
            rc.Width = Math.Max(Cols[Cols.Count - 1].Right, parent.ScrollableRectangle.Width);
            rc.Height = Rows[Rows.Count - 1].Bottom;

			// make sure child grid width doesn't extend past parent client width
			int maxRight = parent.ClientSize.Width - 2;
			if (rc.Right > maxRight)
				rc.Width = maxRight - rc.X;

			// update size/position
			if (Location != rc.Location)
			{
				Location = rc.Location;
			}
			if (ClientSize != rc.Size)
			{
				ClientSize = rc.Size;
			}

			// update height of container row
			parent.Rows[row + 1].Height = Height;
		}
		#endregion

		//--------------------------------------------------------------------------------
		#region ** overrides

        // collapse rows before deleting them (TFS 24135)
        protected override void OnBeforeDeleteRow(RowColEventArgs e)
        {
            CollapseRow(e.Row);
            base.OnBeforeDeleteRow(e);
        }

		// draw collapse/expand icon on first fixed column (right-aligned)
		//
		// the icon is drawn if the grid contains subordinate data tables
		// (_colChild != null)
		//
		// the row is expanded if there is a child grid under it, otherwise
		// it's collapsed.
		//
		override protected void OnOwnerDrawCell(OwnerDrawCellEventArgs e)
		{
			// always call base implementation
			base.OnOwnerDrawCell(e);

			// draw collapse/expand icon
			if (_colChild != null && e.Col == 0 && Cols.Fixed > 0 && 
				e.Row >= Rows.Fixed && !Rows[e.Row].IsNode && !Rows[e.Row].IsNew)
			{
				if (Rows[e.Row].UserData != null)
				{
					// this row has children and they're visible
					e.Image = Glyphs[GlyphEnum.Expanded];
				}
				else
				{
					// check if this row has children <<B2>>
					IList list = _colChild[e.Row] as IList;
					if (list != null)
					{
                        if (list.Count > 0 || this.AllowAddNew)
						{
							e.Image = Glyphs[GlyphEnum.Collapsed];
						}
					}
				}
			}
		}

		// expand/collapse child grid
		//
		// if the user clicks the icons (drawn in the method above), either
		// create a child grid (and bind it to the detail records), or remove
		// the existing one.
		//
		override protected void OnBeforeMouseDown(BeforeMouseDownEventArgs e)
		{
			// always call base implementation
			base.OnBeforeMouseDown(e);

			// check that it's the Left button and that we have a hierarchy
			if (e.Button != MouseButtons.Left || _colChild == null)
			{
				return;
			}

			// check that it's a row header cell
			HitTestInfo hit = HitTest(e.X, e.Y);
			if (hit.Type != HitTestTypeEnum.RowHeader || hit.Row < Rows.Fixed)
			{
				return;
			}

			// check that the click was over the collapse/expand icon
			if (e.X < Cols[0].Right - (Glyphs[GlyphEnum.Collapsed].Width + 4))
			{
				return;
			}

			// if the row has no children and the user can't add new, cancel <<B2>>
			IList list = _colChild[hit.Row] as IList;
			if (list == null || list.Count == 0)
			{
				if (!AllowAddNew)
				{
					return;
				}
			}

			// all checks OK, cancel click before proceeding
			e.Cancel = true;
		    Select(hit.Row, Cols.Fixed, hit.Row, Cols.Count - 1, false);

			// toggle row state
			ToggleRowState(hit.Row);
		}

		// update position of child grids after scrolling
		//
		// when the grid scrolls vertically, move child grids so they
		// stay in their proper position.
		//
		override protected void OnScroll(ScrollBars sb)
		{
			// always call base implementation
			base.OnScroll(sb);

			// adjust horizontal position of the 'header' flex <<1.1>>
			if (sb != ScrollBars.Vertical)
			{
				_hdr.ScrollPosition = new Point(ScrollPosition.X, 0);
			}

            // adjust vertical position of the child grids
            if (!SuspendUpdates && sb != ScrollBars.Horizontal)
            {
                UpdateChildren();
            }

			Invalidate();
		}

		// update position of child grids when size changes
		//
		// when the grid is resized, move child grids so they
		// stay in their proper position.
		//
		override protected void OnSizeChanged(EventArgs e)
		{
			// always call base implementation
			base.OnSizeChanged(e);

			// if this is the top-level grid, update position of child grids
			C1FlexDataTree parent = Parent as C1FlexDataTree;
            if (!SuspendUpdates && parent == null)
            {
                UpdateChildren();
            }
        }

		// update position of child grids when column widths/etc change
		//
		// when rows are added, removed, or resized, move child grids so they
		// stay in their proper position.
		//
		override protected void OnGridChanged(object sender, GridChangedEventArgs e)
		{
			// always call base implementation
			base.OnGridChanged(sender, e);

			// reset data if child column became invalid
			if (_colChild != null && !Cols.Contains(_colChild))
			{
				ResetChildren();
			}

            // update positions after adding/removing/resizing rows/columns
            if (!SuspendUpdates &&
                (e.GridChangedType == GridChangedTypeEnum.GridChanged ||
                e.GridChangedType == GridChangedTypeEnum.RowAdded ||
                e.GridChangedType == GridChangedTypeEnum.RowRemoved))
            {
                UpdateChildren();
            }
        }

		// keep track of column with child information (if any)
		//
		// when the grid receives a Refresh notification from the DataSource,
		// scan the columns looking for subordinate tables, and keep track of
		// the column so we can draw the collapse/expand icons and bind the
		// child grids to the subordinate tables.
		//
		// note: this implementation keeps only one detail column per table.
		// if the master table contains several detail columns, the grid will 
		// only show the first subordinate column. e.g. a Client table with 
		// ClientOrders and ClientDetails would expand to show ClientOrders
		// only.
		//
		override protected void OnDataRefresh(ListChangedEventArgs e)
		{
			// always call base implementation
			base.OnDataRefresh(e);

			// only want the Reset event
			if (e.ListChangedType != ListChangedType.Reset)
				return;

			ResetChildren();
		}
		private void ResetChildren()
		{
			// clear any existing children
			for (int i = 0; i < Controls.Count; i++)
			{
				C1FlexDataTree childGrid = Controls[i] as C1FlexDataTree;
				if (childGrid != null)
				{
					Controls.Remove(childGrid);
					i--;
				}
			}

			// reset all row heights
			for (int i = 0; i < this.Rows.Count; i++)
			{
				Rows[i].Height = -1;
				Rows[i].UserData = null;
			}

			// keep track of hierarchical column
			_colChild = null;
            foreach (Column col in Cols)
            {
				Type type = col.DataType;
				if (type != null && typeof(IList).IsAssignableFrom(type) && type != typeof(byte[]))
				{
					_colChild = col;
					break;
				}
			}

			// fire event to allow customization of master/child grids
			ParentGrid.OnSetupColumns(this);
		}
		#endregion

		//--------------------------------------------------------------------------------
		#region ** helper class

		private class GridHeader : C1FlexGrid
		{
			public GridHeader(C1FlexDataTree parent)
			{
				// initialize
				Dock = DockStyle.Top;
				BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
                Height = parent.Rows[Rows.Fixed - 1].Bottom;
				ScrollBars = ScrollBars.None;

				// add to parent Controls collection
				parent.Controls.Add(this);

				// header grid uses parent as a DataSource, causing both grids to share
				// the same underlying grid model (rows/cols).
				DataSource = parent;
			}

			// keep grids synchronized
			override protected void OnAfterScroll(RangeEventArgs e)
			{
				C1FlexDataTree parent = Parent as C1FlexDataTree;
				parent.ScrollPosition = new Point(ScrollPosition.X, parent.ScrollPosition.Y);
			}

			// call On... method on parent grid
			override protected void OnBeforeSort(SortColEventArgs e)
			{
				C1FlexDataTree parent = Parent as C1FlexDataTree;
				parent.OnBeforeSort(e);
			}
			override protected void OnAfterSort(SortColEventArgs e)
			{
				C1FlexDataTree parent = Parent as C1FlexDataTree;
				parent.OnAfterSort(e);
			}
		}

		#endregion
	}

}
