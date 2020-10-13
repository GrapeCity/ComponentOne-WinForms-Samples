using System;
using System.Security.Permissions;
using System.ComponentModel;
using System.Collections;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;

namespace C1.Win.C1FlexGrid.Hierarchical
{
	public enum ButtonLayoutEnum
	{
		Horizontal,
		Stepped
	}

	/// <summary>
	/// Summary description for FlexHier.
	/// </summary>
	[
	LicenseProvider(typeof(LicenseProvider)),
	ToolboxBitmap(typeof(C1FlexHierarchical))
	]
	public class C1FlexHierarchical : PictureBox, ISupportInitialize
	{
		// ** fields

		protected C1FlexGrid				_flex;
		protected HitTestInfo				_hti;
		protected ArrayList					_stack;
		protected ContextMenu				_menu;
		protected Image						_img;
		protected Label						_lbl;
		protected ButtonLayoutEnum			_buttonLayout;

		// ** ctor

		public C1FlexHierarchical()
		{
			// initialize label template
			_lbl = new Label();
			_lbl.BorderStyle = BorderStyle.FixedSingle;
			_lbl.BackColor = SystemColors.Control;
			_lbl.ForeColor = SystemColors.ControlText;
			_lbl.TextAlign = ContentAlignment.MiddleCenter;
			_lbl.FontChanged      += new EventHandler(_label_Changed);
			_lbl.BackColorChanged += new EventHandler(_label_Changed);
			_lbl.ForeColorChanged += new EventHandler(_label_Changed);
			_lbl.TextAlignChanged += new EventHandler(_label_Changed);

			// initialize contained FlexGrid
			_flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			_flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			_flex.Cols[0].Width = _flex.Rows[0].HeightDisplay * 2;
			_flex.ShowCursor = true;
			_flex.ShowErrors = true;
			_flex.ForeColor = SystemColors.WindowText;
			_flex.DrawMode = DrawModeEnum.OwnerDraw;
			_flex.Cols[0].ImageAlign = ImageAlignEnum.RightCenter;
			_flex.BeforeMouseDown += new C1.Win.C1FlexGrid.BeforeMouseDownEventHandler(_flex_BeforeMouseDown);
			_flex.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(_flex_OwnerDrawCell);
			Controls.Add(_flex);

			// initialize container
			BackColor = SystemColors.Highlight;
			ForeColor = SystemColors.HighlightText;
			BorderStyle = BorderStyle.Fixed3D;

			// initialize fields
			_buttonLayout = ButtonLayoutEnum.Horizontal;
			_stack = new ArrayList();
			_menu = new ContextMenu();
			_img = _flex.Glyphs[GlyphEnum.Collapsed];
		}

		// ** ISupportInitialize

		void ISupportInitialize.BeginInit()
		{
			_flex.BeginInit();
		}
		void ISupportInitialize.EndInit()
		{
			_flex.EndInit();

			// re-assign data source after grid is initialized
			object ds = DataSource;
			if (ds != null)
			{
				DataSource = null;
				DataSource = ds;
			}
		}

		// ** object model

		[
		DefaultValue(ButtonLayoutEnum.Horizontal)
		]
		public ButtonLayoutEnum ButtonLayout
		{
			get { return _buttonLayout; }
			set 
			{
				_buttonLayout = value;
				UpdateLayout(true);
			}
		}
		[
		TypeConverter(typeof(ExpandableObjectConverter)),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Content)
		]
		public Label ButtonTemplate
		{
			get { return _lbl; }
		}
		[
		TypeConverter(typeof(ExpandableObjectConverter)),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Content)
		]
		public C1.Win.C1FlexGrid.C1FlexGrid FlexGrid
		{
			get { return _flex; }
		}
		[
		DefaultValue(null),
		RefreshProperties(RefreshProperties.Repaint),
		TypeConverter("System.Windows.Forms.Design.DataSourceConverter, System.Design")
		]
		public object DataSource
		{
			get { return _flex.DataSource; }
			set 
			{
				_menu.MenuItems.Clear();
				ClearButtons(null);
				DrillDown(value);
			}
		}

		// ** internal stuff

		// drill down into a selected data source
		private void DrillDown(object ds)
		{
			// handle DataSets
			if (ds is DataSet)
			{
				AddButton(ds, ((DataSet)ds).DataSetName);
			}

			// handle DataTables
			if (ds is DataTable)
				ds = ((DataTable)ds).DefaultView;

			// handle DataViews
			if (ds is DataView)
			{
				// get data source name
				DataView dvp = _flex.DataSource as DataView;
				DataView dvc = ds as DataView;
				string dsName = dvc.Table.TableName;

				// append relation key, if available
				if (dvp != null && dvc != null && dvc.Table.DataSet != null)
				{
					foreach (DataRelation dr in dvc.Table.DataSet.Relations)
					{
						if (dr.ParentTable == dvp.Table && dr.ChildTable  == dvc.Table)
						{
							string colName  = dr.ChildColumns[0].ColumnName;
							object colValue = dvc[0][colName];
							dsName += string.Format(" ({0}: {1})", colName, colValue);
						}
					}
				}

				// add the navigation button
				AddButton(ds, dsName);
			}

			// go get the data
			BindGrid(ds);
		}

		// bind grid to current data source
		private void BindGrid(object ds)
		{
			// initialize child table menu
			_menu.MenuItems.Clear();

			// bind grid
			_flex.DataSource = ds;

			// scan grid columns for child tables
			foreach (Column col in _flex.Cols)
			{
				if (typeof(IBindingList).IsAssignableFrom(col.DataType))
					_menu.MenuItems.Add(col.Name);
			}

			// hook up menu
			if (_menu.MenuItems.Count > 0)
			{
				foreach (MenuItem item in _menu.MenuItems)
					item.Click += new EventHandler(_menuClick);
			}
		}

		// show child table menu
		private void _flex_BeforeMouseDown(object sender, C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
		{
			// check that it's the Left button and that we have a menu
			if (e.Button == MouseButtons.Left && _menu.MenuItems.Count > 0)
			{
				// check that it's a row header cell
				_hti = _flex.HitTest(e.X, e.Y);
				if (_hti.Type == HitTestTypeEnum.RowHeader && _hti.Row > 0)
				{
					// check that the click was over the collapsed icon
					if (e.X > _flex.Cols[0].Right - (_img.Width + 4))
					{
						// all checks OK, cancel click and show menu instead
						e.Cancel = true;
						_menu.Show(_flex, new Point(e.X, e.Y));
					}
				}
			}
		}

		// navigate to child table
		private void _menuClick(object sender, System.EventArgs e)
		{
			MenuItem item = sender as MenuItem;
			DrillDown(_flex[_hti.Row, item.Text]);
		}

		// navigate to parent table
		private void _btn_Click(object sender, System.EventArgs e)
		{
			Label lbl = sender as Label;
			ClearButtons(lbl);
			BindGrid(lbl.Tag);
		}

		// paint collapsed icon on row header cell
		private void _flex_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
		{
			if (_menu.MenuItems.Count > 0 && e.Col == 0 && e.Row >= _flex.Rows.Fixed)
				e.Image = _img;
		}

		// clear navigation buttons
		private void ClearButtons(Label clearBelow)
		{
			// remove all buttons below the selected one
			for (int i = _stack.Count-1; i >= 0; i--)
			{
				Label lbl = (Label)_stack[i];
				if (lbl.Equals(clearBelow))
					break;
				_stack.Remove(lbl);
				Controls.Remove(lbl);
			}

			// update the layout
			UpdateLayout(false);
		}

		// add navigation button
		private void AddButton(object ds, string dsName)
		{
			// create label control to use as navigation button
			Label lbl = new Label();

			// initialize label properties
			lbl.Tag = ds;
			lbl.Text = dsName;
			lbl.AutoSize = true;

			// hook label up
			lbl.Click += new EventHandler(_btn_Click);

			// add label to collections
			Controls.Add(lbl);
			_stack.Add(lbl);

			// fix layout
			UpdateLayout(true);
		}

		// update control layout when template label properties change
		private void _label_Changed(object sender, EventArgs e)
		{
			UpdateLayout(true);
		}

		// adjust size/positions
		private void UpdateLayout(bool moveButtons)
		{
			// move/position labels
			if (moveButtons)
			{
				Point pt = new Point(2,2);
				foreach (Label lbl in _stack)
				{
					// copy properties from template label
					lbl.Font = _lbl.Font;
					lbl.BorderStyle = _lbl.BorderStyle;
					lbl.BackColor = _lbl.BackColor;
					lbl.ForeColor = _lbl.ForeColor;
					lbl.TextAlign = _lbl.TextAlign;

					// set position for this one
					lbl.Location = pt;

					// and update for next
					switch (_buttonLayout)
					{
						case ButtonLayoutEnum.Horizontal:
							pt.X += lbl.Width + 1;
							break;
						case ButtonLayoutEnum.Stepped:
							pt.X += lbl.Height;
							pt.Y += lbl.Height + 1;
							break;
					}
				}
			}

			// move/position grid
			int barHeight = 0;
			if (_stack.Count > 0)
			{
				Label lbl = (Label)_stack[_stack.Count-1];
				barHeight = lbl.Bounds.Bottom + 2;
			}
			Rectangle rc = ClientRectangle;
			rc.Height -= barHeight;
			rc.Y += barHeight;
			_flex.Bounds = rc;
		}

		// ** overrides

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			UpdateLayout(false);
		}
	}
}
