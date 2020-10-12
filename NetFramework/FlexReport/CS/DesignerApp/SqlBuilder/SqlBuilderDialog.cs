//----------------------------------------------------------------------------
// SqlBuilderDialog.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

using C1.Win.C1FlexGrid;

namespace SqlBuilder
{
	/// <summary>
	/// Summary description for SqlBuilderDialog.
	/// </summary>
	public class SqlBuilderDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar _toolbar;
		private System.Windows.Forms.ToolBarButton _tbProperties;
		private System.Windows.Forms.ToolBarButton _tbSep1;
		private System.Windows.Forms.ToolBarButton _tbViewResults;
		private System.Windows.Forms.ToolBarButton _tbConnString;
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.TreeView _tree;
		private System.Windows.Forms.TextBox _txtSql;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.ToolBarButton _tbGroupBy;
		private System.Windows.Forms.ToolBarButton _tbCheckSql;
		private System.Windows.Forms.ToolBarButton _tbSep2;
		private System.Windows.Forms.ToolBarButton _tbClearQuery;
		private System.Windows.Forms.ImageList _imgList;
		private System.Windows.Forms.ContextMenu _treeMenu;
		private System.Windows.Forms.MenuItem _tmShowTables;
		private System.Windows.Forms.MenuItem _tmHideTable;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button _btnOK;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.Label _lblStatus;
		private System.ComponentModel.IContainer components;

		public SqlBuilderDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlBuilderDialog));
            this._toolbar = new System.Windows.Forms.ToolBar();
            this._tbConnString = new System.Windows.Forms.ToolBarButton();
            this._tbProperties = new System.Windows.Forms.ToolBarButton();
            this._tbGroupBy = new System.Windows.Forms.ToolBarButton();
            this._tbSep1 = new System.Windows.Forms.ToolBarButton();
            this._tbCheckSql = new System.Windows.Forms.ToolBarButton();
            this._tbViewResults = new System.Windows.Forms.ToolBarButton();
            this._tbSep2 = new System.Windows.Forms.ToolBarButton();
            this._tbClearQuery = new System.Windows.Forms.ToolBarButton();
            this._imgList = new System.Windows.Forms.ImageList(this.components);
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._txtSql = new System.Windows.Forms.TextBox();
            this._tree = new System.Windows.Forms.TreeView();
            this._treeMenu = new System.Windows.Forms.ContextMenu();
            this._tmHideTable = new System.Windows.Forms.MenuItem();
            this._tmShowTables = new System.Windows.Forms.MenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this._lblStatus = new System.Windows.Forms.Label();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolbar
            // 
            this._toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this._toolbar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this._tbConnString,
            this._tbProperties,
            this._tbGroupBy,
            this._tbSep1,
            this._tbCheckSql,
            this._tbViewResults,
            this._tbSep2,
            this._tbClearQuery});
            this._toolbar.DropDownArrows = true;
            this._toolbar.ImageList = this._imgList;
            this._toolbar.Location = new System.Drawing.Point(0, 0);
            this._toolbar.Name = "_toolbar";
            this._toolbar.ShowToolTips = true;
            this._toolbar.Size = new System.Drawing.Size(640, 28);
            this._toolbar.TabIndex = 0;
            this._toolbar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this._toolbar_ButtonClick);
            // 
            // _tbConnString
            // 
            this._tbConnString.ImageIndex = 0;
            this._tbConnString.Name = "_tbConnString";
            this._tbConnString.ToolTipText = "Connection String";
            // 
            // _tbProperties
            // 
            this._tbProperties.ImageIndex = 3;
            this._tbProperties.Name = "_tbProperties";
            this._tbProperties.ToolTipText = "Properties";
            // 
            // _tbGroupBy
            // 
            this._tbGroupBy.ImageIndex = 4;
            this._tbGroupBy.Name = "_tbGroupBy";
            this._tbGroupBy.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this._tbGroupBy.ToolTipText = "Group By";
            // 
            // _tbSep1
            // 
            this._tbSep1.Name = "_tbSep1";
            this._tbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _tbCheckSql
            // 
            this._tbCheckSql.Enabled = false;
            this._tbCheckSql.ImageIndex = 6;
            this._tbCheckSql.Name = "_tbCheckSql";
            this._tbCheckSql.ToolTipText = "Check SQL Statement";
            // 
            // _tbViewResults
            // 
            this._tbViewResults.Enabled = false;
            this._tbViewResults.ImageIndex = 5;
            this._tbViewResults.Name = "_tbViewResults";
            this._tbViewResults.ToolTipText = "View Results";
            // 
            // _tbSep2
            // 
            this._tbSep2.Name = "_tbSep2";
            this._tbSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _tbClearQuery
            // 
            this._tbClearQuery.Enabled = false;
            this._tbClearQuery.ImageIndex = 8;
            this._tbClearQuery.Name = "_tbClearQuery";
            this._tbClearQuery.ToolTipText = "Clear Query";
            // 
            // _imgList
            // 
            this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
            this._imgList.TransparentColor = System.Drawing.Color.Red;
            this._imgList.Images.SetKeyName(0, "");
            this._imgList.Images.SetKeyName(1, "");
            this._imgList.Images.SetKeyName(2, "");
            this._imgList.Images.SetKeyName(3, "");
            this._imgList.Images.SetKeyName(4, "");
            this._imgList.Images.SetKeyName(5, "");
            this._imgList.Images.SetKeyName(6, "");
            this._imgList.Images.SetKeyName(7, "");
            this._imgList.Images.SetKeyName(8, "");
            this._imgList.Images.SetKeyName(9, "");
            this._imgList.Images.SetKeyName(10, "");
            // 
            // _flex
            // 
            this._flex.AllowDelete = true;
            this._flex.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
            this._flex.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns;
            this._flex.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this._flex.ColumnInfo = "10,1,1,0,0,85,Columns:0{Width:27;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Top;
            this._flex.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual;
            this._flex.EditOptions = ((C1.Win.C1FlexGrid.EditFlags)((C1.Win.C1FlexGrid.EditFlags.AutoSearch | C1.Win.C1FlexGrid.EditFlags.MultiCheck)));
            this._flex.ExtendLastCol = true;
            this._flex.Location = new System.Drawing.Point(180, 28);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this._flex.ShowCursor = true;
            this._flex.ShowErrors = true;
            this._flex.Size = new System.Drawing.Size(460, 199);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 10;
            this._flex.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this._flex_BeforeEdit);
            this._flex.CellButtonClick += new C1.Win.C1FlexGrid.RowColEventHandler(this._flex_CellButtonClick);
            this._flex.AfterDataRefresh += new System.ComponentModel.ListChangedEventHandler(this._flex_AfterDataRefresh);
            this._flex.DragDrop += new System.Windows.Forms.DragEventHandler(this._flex_DragDrop);
            this._flex.DragEnter += new System.Windows.Forms.DragEventHandler(this._flex_DragEnter);
            // 
            // _txtSql
            // 
            this._txtSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtSql.Location = new System.Drawing.Point(180, 231);
            this._txtSql.Multiline = true;
            this._txtSql.Name = "_txtSql";
            this._txtSql.ReadOnly = true;
            this._txtSql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtSql.Size = new System.Drawing.Size(460, 134);
            this._txtSql.TabIndex = 11;
            this._txtSql.WordWrap = false;
            this._txtSql.TextChanged += new System.EventHandler(this._txtSql_TextChanged);
            // 
            // _tree
            // 
            this._tree.AllowDrop = true;
            this._tree.ContextMenu = this._treeMenu;
            this._tree.Dock = System.Windows.Forms.DockStyle.Left;
            this._tree.ImageIndex = 0;
            this._tree.ImageList = this._imgList;
            this._tree.Location = new System.Drawing.Point(0, 28);
            this._tree.Name = "_tree";
            this._tree.SelectedImageIndex = 0;
            this._tree.Size = new System.Drawing.Size(176, 337);
            this._tree.TabIndex = 1;
            this._tree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this._tree_ItemDrag);
            this._tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._tree_AfterSelect);
            this._tree.DoubleClick += new System.EventHandler(this._tree_DoubleClick);
            // 
            // _treeMenu
            // 
            this._treeMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._tmHideTable,
            this._tmShowTables});
            this._treeMenu.Popup += new System.EventHandler(this._treeMenu_Popup);
            // 
            // _tmHideTable
            // 
            this._tmHideTable.Index = 0;
            this._tmHideTable.Text = "Hide this table";
            this._tmHideTable.Click += new System.EventHandler(this._tmHideTable_Click);
            // 
            // _tmShowTables
            // 
            this._tmShowTables.Index = 1;
            this._tmShowTables.Text = "Show all tables";
            this._tmShowTables.Click += new System.EventHandler(this._tmShowTables_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(176, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 337);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(180, 227);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(460, 4);
            this.splitter2.TabIndex = 14;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._lblStatus);
            this.panel1.Controls.Add(this._btnOK);
            this.panel1.Controls.Add(this._btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 40);
            this.panel1.TabIndex = 15;
            // 
            // _lblStatus
            // 
            this._lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblStatus.Location = new System.Drawing.Point(8, 8);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(400, 24);
            this._lblStatus.TabIndex = 1;
            this._lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnOK.Location = new System.Drawing.Point(472, 9);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 0;
            this._btnOK.Text = "&OK";
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnCancel.Location = new System.Drawing.Point(553, 9);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 0;
            this._btnCancel.Text = "&Cancel";
            // 
            // SqlBuilderDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(640, 405);
            this.Controls.Add(this._txtSql);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this._flex);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this._tree);
            this.Controls.Add(this._toolbar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SqlBuilderDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Builder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		//----------------------------------------------------------------
		#region ** fields

		QueryBuilder	_qb = new QueryBuilder();
		IDictionary		_tables  = new ListDictionary();
		IDictionary		_columns = new Hashtable();

		#endregion

		//----------------------------------------------------------------
		#region ** public stuff

		public string ConnectionString
		{
			get { return _qb.ConnectionString; }
			set
			{
				_qb.ConnectionString = value; 
				ResetUI();
			}
		}
		public string Sql
		{
			get { return _qb.Sql; }
			set
			{
				// do to...
			}
		}

		#endregion

		//----------------------------------------------------------------
		#region ** private stuff

		private void ResetUI()
		{
			// reset table tree
			_tree.BeginUpdate();
			_tree.Nodes.Clear();

			// create tree structure
            TreeNode nConn = _tree.Nodes.Add(FlexReportDesignerApp.Strings.SqlBuilderDialog.Connection);
			nConn.ImageIndex = nConn.SelectedImageIndex = 0;

			TreeNode nTables = nConn.Nodes.Add(FlexReportDesignerApp.Strings.SqlBuilderDialog.Tables);
			nTables.ImageIndex = nTables.SelectedImageIndex = 1;

			TreeNode nViews = nConn.Nodes.Add(FlexReportDesignerApp.Strings.SqlBuilderDialog.Views);
			nViews.ImageIndex = nViews.SelectedImageIndex = 10;

			foreach (DataTable dt in _qb.Schema.Tables)
			{
				// check whether this is a regular table or a view
				bool isView = object.Equals("VIEW", dt.ExtendedProperties["TABLE_TYPE"]);

				// create table node under the appropriate parent
				TreeNode nParent = (isView)? nViews: nTables;
				TreeNode nTable = nParent.Nodes.Add(dt.TableName);
				nTable.Tag = dt;
				nTable.ImageIndex = nTable.SelectedImageIndex = nTable.Parent.ImageIndex;

				// add column nodes
				foreach (DataColumn dc in dt.Columns)
				{
					TreeNode nColumn = nTable.Nodes.Add(dc.ColumnName);
					nColumn.Tag = dc;
					nColumn.ImageIndex = nColumn.SelectedImageIndex = 2;
				}
			}
			nConn.Expand();
			_tree.EndUpdate();

			// update data maps
			_tables.Clear();
			_columns.Clear();
			foreach (DataTable dt in _qb.Schema.Tables)
			{
				// add table to table dictionary
				_tables.Add(dt, dt.TableName);

				// add ComboList strings for each table to column dictionary
				StringBuilder sb = new StringBuilder();
				foreach (DataColumn dc in dt.Columns)
					sb.AppendFormat("|{0}", dc.ColumnName);
				_columns.Add(dt, sb.ToString());
			}
		}

		private void ResetGrid()
		{
			// arrange grid columns
			int pos = 1;
			Column c;

			c = _flex.Cols["Column"];
			c.Width = 95;
			c.Move(pos++);

			c = _flex.Cols["Alias"];
			c.Width = 65;
			c.Move(pos++);

			c = _flex.Cols["Table"];
			c.Width = 75;
			c.DataMap = _tables;
			c.AllowEditing = false;
			c.Move(pos++);

			c = _flex.Cols["Output"];
			c.Width = 55;
			c.Move(pos++);

			c = _flex.Cols["Sort"];
			c.Width = 60;
			c.Move(pos++);

			c = _flex.Cols["GroupBy"];
			c.Width = 60;
			c.Visible = _qb.GroupBy;
			c.Move(pos++);

			c = _flex.Cols["Criteria"];
			c.Width = 120;
			c.ComboList = "|...";
			c.Move(pos++);

			// keep column sizes
			_flex.AutoResize = false;
		}

		private static string PromptConnectionString(string initial, IntPtr handle)
		{
			bool ok = false;
			ADODB.Connection conn = null;
			MSDASC.DataLinksClass dlinks = null;
			try
			{
				// create objects we'll need
				dlinks = new MSDASC.DataLinksClass();
				conn = new ADODB.ConnectionClass();

				// initialize object
				if (initial != null && initial.Length > 0)
					conn.ConnectionString = initial;

				// show connection picker dialog
				object obj = conn;
				dlinks.hWnd = (int)handle; // << make it modal
				ok = dlinks.PromptEdit(ref obj);
			}
			catch (Exception x)
			{
                FlexReportDesignerApp.MessageForm.Error(string.Format(FlexReportDesignerApp.Strings.SqlBuilderDialog.ErrCannotBuildConnFmt, x.Message));
			}

			// return what we got
			return ok ? conn.ConnectionString : initial;
		}

		private string Plural(int cnt, string lbl)
		{
			return string.Format("{0} {1}{2}", cnt, lbl, (cnt != 1)? "s": string.Empty);
		}
		#endregion

		//----------------------------------------------------------------
		#region ** event handlers
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			// initialize UI
			ResetUI();

			// initialize grid
			_flex.DataSource = _qb.QueryFields;
			ResetGrid();
		}

		private void _toolbar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			// change connection string
			if (e.Button == this._tbConnString)
			{
				string conn = _qb.ConnectionString;
				_qb.ConnectionString = PromptConnectionString(conn, Handle);
				ResetUI();
				return;
			}

			// show properties
			if (e.Button == this._tbProperties)
			{
				using (QueryPropertiesForm f = new QueryPropertiesForm())
				{
					f.QueryBuilder = _qb;
					f.ShowDialog();
					_txtSql.Text = _qb.Sql;
				}
				return;
			}

			// toggle GroupBy switch
			if (e.Button == this._tbGroupBy)
			{
				_qb.GroupBy = this._tbGroupBy.Pushed;
				_txtSql.Text = _qb.Sql;

				// show/hide GroupBy column
				_flex.Cols["GroupBy"].Visible = this._tbGroupBy.Pushed;
				return;
			}

			// clear query
			if (e.Button == this._tbClearQuery)
			{
				// confirm with user
                DialogResult dr = FlexReportDesignerApp.MessageForm.Ask(FlexReportDesignerApp.Strings.SqlBuilderDialog.ClearQueryQ, MessageBoxButtons.YesNo);
                if (dr != System.Windows.Forms.DialogResult.Yes)
					return;

				// clear it
				_qb.QueryFields.Clear();
				return;
			}

			// preview results/check syntax
			if (e.Button == this._tbViewResults || e.Button == this._tbCheckSql)
			{
				// sanity...
				if (_qb.QueryFields.Count == 0)
					return;

				// prepare to get data/check sql
				string conn = _qb.ConnectionString;
				string sql  = _qb.Sql;
				DataTable dt = new DataTable();

				try
				{
					// build data adapter
					OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);

					// check sql by retrieving schema
					if (e.Button == this._tbCheckSql)
					{
						da.FillSchema(dt, SchemaType.Mapped);
                        // ShowMessage(ReportDesignerApp.Strings.SqlBuilderDialog.SqlVerified, MessageBoxIcon.Information);
                        FlexReportDesignerApp.MessageForm.Info(FlexReportDesignerApp.Strings.SqlBuilderDialog.SqlVerified);
						return;
					}

					// get data into table
					da.Fill(dt);
				}
				catch (Exception x)
				{
					// ShowMessage(string.Format(ReportDesignerApp.Strings.SqlBuilderDialog.ErrCannotGetDataFmt, x.Message), MessageBoxIcon.Warning);
                    FlexReportDesignerApp.MessageForm.Warn(string.Format(FlexReportDesignerApp.Strings.SqlBuilderDialog.ErrCannotGetDataFmt, x.Message));
					return;
				}

				// show data preview form
				PreviewForm f = new PreviewForm();
				f._flex.DataSource = dt;
				f.ShowDialog();
			}
		}

		// drag nodes from tree to grid
		private void _tree_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
		{
			TreeNode node = e.Item as TreeNode;
			if (node != null && node.Tag is DataColumn)
			{
				DoDragDrop(e.Item, DragDropEffects.Copy);
			}
		}

		private void _flex_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			TreeNode node = e.Data.GetData(typeof(TreeNode)) as TreeNode;
			if (node != null && node.Tag is DataColumn)
			{
				QueryField qf = new QueryField(node.Tag as DataColumn);
				_qb.QueryFields.Add(qf);
			}
		}

		private void _flex_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			TreeNode node = e.Data.GetData(typeof(TreeNode)) as TreeNode;
			if (node != null && node.Tag is DataColumn)
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// add an item by double-clicking it
		private void _tree_DoubleClick(object sender, System.EventArgs e)
		{
			TreeNode node = _tree.SelectedNode;
			if (node != null && node.Tag is DataColumn)
			{
				QueryField qf = new QueryField(node.Tag as DataColumn);
				_qb.QueryFields.Add(qf);
			}
		}

		// update sql query when any of the QueryFields change
		private void _flex_AfterDataRefresh(object sender, System.ComponentModel.ListChangedEventArgs e)
		{
			_txtSql.Text = _qb.Sql;
		}

		// update status when Sql changes
		ArrayList _usedTables = new ArrayList();
		private void _txtSql_TextChanged(object sender, System.EventArgs e)
		{
			// get current info
			int tables = _qb.TableCount;
			int fields = _qb.QueryFields.Count;

			// update status panel
			_lblStatus.Text = string.Format("{0}, {1}.",
				Plural(fields, "field"), 
				Plural(tables, "table"));

			// warn of missing joins (probably an error)
			if (_qb.MissingJoins)
			{
				_lblStatus.Text += FlexReportDesignerApp.Strings.SqlBuilderDialog.NotAllTablesJoined;
			}

			// update toolbar buttons
			bool hasQuery = fields > 0;
			_tbViewResults.Enabled = hasQuery;
			_tbCheckSql.Enabled    = hasQuery;
			_tbClearQuery.Enabled  = hasQuery;

			// highlight tables that are in use
			_usedTables.Clear();
			foreach (QueryField qf in _qb.QueryFields)
			{
				if (!_usedTables.Contains(qf.Table))
					_usedTables.Add(qf.Table);
			}
			foreach (TreeNode nd in _tree.Nodes[0].Nodes)
			{
				DataTable dt = nd.Tag as DataTable;
				int imgIndex = (_usedTables.Contains(dt))? 9: 1;
				nd.ImageIndex = nd.SelectedImageIndex = imgIndex;
			}
		}

		// show list of columns available on the selected table
		private void _flex_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			_flex.ComboList = string.Empty;
			if (_flex.Cols[e.Col].Name == "Column")
			{
				DataTable dt = _flex[e.Row, "Table"] as DataTable;
				if (dt != null)
					_flex.ComboList = _columns[dt] as string;
			}
		}

		// show criteria editor
		private void _flex_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			using (CriteriaForm f = new CriteriaForm())
			{
				f.QueryField = _flex.Rows[e.Row].DataSource as QueryField;
				DialogResult dr = f.ShowDialog();
				if (dr == DialogResult.OK)
				{
					_flex[e.Row, e.Col] = f.Value;
				}
			}
		}

		private void _tree_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			// get selected table
			TreeNode selNode = _tree.SelectedNode;
			if (selNode.Tag is DataColumn)
				selNode = selNode.Parent;
			DataTable dt = selNode.Tag as DataTable;

			// scan all table nodes
			Font relatedFont = new Font(_tree.Font, FontStyle.Underline);
			Color defaultColor = _tree.Nodes[0].BackColor;
			foreach (TreeNode nd in _tree.Nodes[0].Nodes[0].Nodes)
			{
				// assume no relation
				nd.BackColor = defaultColor;
				nd.NodeFont = null;

				// find relation
				DataTable dtr = nd.Tag as DataTable;
				foreach (DataRelation dr in _qb.Schema.Relations)
				{
					if ((dt == dtr) ||
						(dr.ParentTable == dt  && dr.ChildTable == dtr) ||
						(dr.ParentTable == dtr && dr.ChildTable == dt))
					{
						nd.NodeFont = relatedFont;
						nd.BackColor = SystemColors.Info;
						break;
					}
				}
			}
		}
		private void _tmHideTable_Click(object sender, System.EventArgs e)
		{
			_tree.Nodes.Remove(_tree.SelectedNode);
		}
		
        private void _tmShowTables_Click(object sender, System.EventArgs e)
		{
			ResetUI();
		}

		private void _treeMenu_Popup(object sender, System.EventArgs e)
		{
			Point pt = _tree.PointToClient(Control.MousePosition);
			TreeNode nd = _tree.GetNodeAt(pt);		
			if (nd != null && nd.Tag is DataTable)
			{
				_tree.SelectedNode = nd;
				_tmHideTable.Enabled = true;
			}
			else
			{
				_tmHideTable.Enabled = false;
			}
		}
		#endregion
	}
}
