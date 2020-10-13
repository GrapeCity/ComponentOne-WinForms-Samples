/* ------------------------------------------------------------------------
 * C1FlexDataTree.cs
 * 
 * Implements hierarchical data-binding (MS Access style) using the 
 * C1FlexGrid control.
 * 
 * Bind the grid to a table in a hierarchical data set and any rows with
 * child tables will be displayed as tree nodes. Clicking on the expand
 * button (+) on a fixed row will open a child grid showing the child 
 * table. Child tables may in turn contain more child tables (nesting is
 * allowed with no pre-set limit).
 * 
 * This type of data binding is similar to what is provided in Microsoft 
 * Access 2000 and later in its default table views.
 * 
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
 * 1.0: December 2003	- Sample created
 * 1.1: August 2004		- Added extra 'header' grid to prevent child grids 
 *						  from painting over parent's fixed rows.
 * ------------------------------------------------------------------------
 */
using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
	/// <summary>
	/// C1FlexDataTree
	/// </summary>
	[
	//LicenseProvider(typeof(System.ComponentModel.LicenseProvider)),
	ToolboxBitmap(typeof(C1FlexDataTree))
	]
	public class C1FlexDataTree : C1.Win.C1FlexGrid.C1FlexGrid, ISupportInitialize
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
		private C1.Win.C1FlexGrid.C1FlexGrid _hdr = null; // <<1.1>>
		
		#endregion

		//--------------------------------------------------------------------------------
		#region ** ctor
		public C1FlexDataTree()
		{
			Initialize();

			// create 'header' grid <<1.1>>
			_hdr = new C1.Win.C1FlexGrid.C1FlexGrid();
			_hdr.Dock = DockStyle.Top;
            _hdr.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			_hdr.Height = Rows[Rows.Fixed].Top;
			_hdr.ScrollBars = ScrollBars.None;
			_hdr.AfterScroll += new RangeEventHandler(hdr_AfterScroll);
			Controls.Add(_hdr);

			// header grid uses this as a DataSource, causing both grids to share
			// the same underlying grid model (rows/cols).
			_hdr.DataSource = this;
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
            try
            {
                // update position of all children
                for (int row = 0; row < Rows.Count; row++)
                {
                    C1FlexDataTree child = Rows[row].UserData as C1FlexDataTree;
                    if (child != null)
                        child.UpdatePosition();
                }
            }
            catch
            {
            }

			// and update position of this grid within its parent
			UpdatePosition();
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
			rc.X      = rc.Right;
			rc.Y      = rc.Bottom;
			rc.Width  = Cols[Cols.Count-1].Right;
			rc.Height = Rows[Rows.Count-1].Bottom;

			// make sure child grid width doesn't extend past parent client width
			int maxRight = parent.ClientSize.Width - 2;
			if (rc.Right > maxRight)
				rc.Width = maxRight - rc.X;

			// update size/position
			if (Location != rc.Location)
				Location = rc.Location;
			if (ClientSize != rc.Size)
				ClientSize = rc.Size;

			// update height of container row
			parent.Rows[row + 1].Height = Height;
		}
		#endregion

		//--------------------------------------------------------------------------------
		#region ** overrides

		// initialize child grids by copying properties from parent
		// border style, colors, etc.
		override protected void OnParentChanged(EventArgs e)
		{
			// always call base implementation
			base.OnParentChanged(e);

			// copy properties from parent
			C1FlexDataTree parent = Parent as C1FlexDataTree;
			if (parent != null)
			{
				ShowCursor  = parent.ShowCursor;
				AllowAddNew = parent.AllowAddNew;
				AllowDelete = parent.AllowDelete;
				BorderStyle = parent.BorderStyle;
				Styles.ParseString(parent.Styles.BuildString(true));
				foreach (GlyphEnum g in Enum.GetValues(typeof(GlyphEnum)))
					Glyphs[g] = parent.Glyphs[g];
				Cols[0].Width = parent.Cols[0].WidthDisplay;
			}
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
				e.Image = (Rows[e.Row].UserData != null)
					? Glyphs[GlyphEnum.Expanded]
					: Glyphs[GlyphEnum.Collapsed];
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
				return;

			// check that it's a row header cell
			HitTestInfo hit = HitTest(e.X, e.Y);
			if (hit.Type != HitTestTypeEnum.RowHeader || hit.Row < Rows.Fixed)
				return;

			// check that the click was over the collapse/expand icon
			if (e.X < Cols[0].Right - (Glyphs[GlyphEnum.Collapsed].Width + 4))
				return;

			// all checks OK, cancel click before proceeding
			e.Cancel = true;
			Select(hit.Row, Cols.Fixed, hit.Row, Cols.Count-1, false);

			// create and show child grid
			if (Rows[hit.Row].UserData == null)
			{
				// create child grid
				C1FlexDataTree childGrid = new C1FlexDataTree();
				childGrid.Visible = false;
				childGrid.ScrollBars = ScrollBars.Horizontal;

				// attach child grid to parent, set data source
				Controls.Add(childGrid);
				childGrid.DataSource = _colChild[hit.Row];

				// save references: 
				// child grid Tag property contains a reference to the parent row
				// parent row UserData contains a reference to the child grid
				childGrid.Tag = Rows[hit.Row];
				Rows[hit.Row].UserData = childGrid;

				// add node row (unbound) to display child
				Rows.InsertNode(hit.Row + 1, -1);

                // move child grid into position, make it visible
                childGrid.UpdatePosition();
                childGrid.Visible = true;
                childGrid.Focus();
            }
			else // hide and delete child grid
			{
				// get child grid
				C1FlexDataTree childGrid = (C1FlexDataTree)Rows[hit.Row].UserData;

				// break references
				Rows[hit.Row].UserData = null;
				childGrid.Tag = null;

				// clear child and remove it from parent
				childGrid.Controls.Clear();
				Controls.Remove(childGrid);

				// delete container row
				Rows.Remove(hit.Row + 1);
			}
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
			if (sb != ScrollBars.Horizontal)
			{
				UpdateChildren();
			}
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
			if (parent == null)
				UpdateChildren();
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

			// update positions after adding/removing/resizing rows/columns
			if (e.GridChangedType == GridChangedTypeEnum.GridChanged ||
				e.GridChangedType == GridChangedTypeEnum.RowAdded    ||
				e.GridChangedType == GridChangedTypeEnum.RowRemoved)
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

			// keep track of hierarchical column
			_colChild = null;
			foreach (Column	col in Cols)
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
		#region ** event handlers

		// synchronize main grid with header grid after header scrolled <<1.1>>
		private void hdr_AfterScroll(object sender, RangeEventArgs e)
		{
			ScrollPosition = new Point(_hdr.ScrollPosition.X, ScrollPosition.Y);
		}
		#endregion
	}
}
