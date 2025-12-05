using System;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.FlexGrid;

namespace DataTree
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
		private DataTree.C1FlexDataTree _flex;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._flex = new DataTree.C1FlexDataTree();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Customers";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Orders";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nothing";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // _flex
            // 
            this._flex.AllowAddNew = true;
            this._flex.AllowDelete = true;
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:34;Style:\"ImageAlign:RightCenter;\";}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this._flex.Location = new System.Drawing.Point(0, 40);
            this._flex.Name = "_flex";
            this._flex.Rows.Count = 51;
            this._flex.Rows.DefaultSize = 17;
            this._flex.ShowCursor = true;
            this._flex.Size = new System.Drawing.Size(627, 334);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 1;
            this._flex.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Black;
            this._flex.SetupColumns += new System.EventHandler(this._flex_SetupColumns);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(627, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._flex);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Data Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		DataSet _ds = new DataSet();

		void Form1_Load(object sender, System.EventArgs e)
		{
			// initialize db connection variables
			string conn = GetConnectionString();

			// load some tables
			string[] tables = "Customers, Orders, Order Details, Products, Employees, Shippers".Split(',');
			foreach (string tableName in tables)
			{
				FillTable(_ds, tableName, conn);
			}

			// set up some relations
			_ds.Relations.Add("Customers_Orders",
				_ds.Tables["Customers"].Columns["CustomerID"],
				_ds.Tables["Orders"].Columns["CustomerID"]);

			_ds.Relations.Add("Orders_OrderDetails",
				_ds.Tables["Orders"].Columns["OrderID"],
				_ds.Tables["Order Details"].Columns["OrderID"]);

			// build display parameters for "Orders" table
			//
			// the parameters consist of a string array containing column names,
			// captions, and formats (applied to the table), as well as data maps 
			// bound to columns to show data other than raw IDs (e.g. product name 
			// instead of productID).
			//
			// we attach this info to the tables and columns as ExtendedProperties 
			// so the child grids can pick it up in the SetupColumns event.
			//
			// note that most of this work can be done at design time using the 
			// grid's Column Editor, but in this case we use code because all the
			// binding is done at run time.
			//
			DataTable dt = _ds.Tables["Orders"];
			dt.ExtendedProperties.Add("ShowColumns", new string[] {
																	  "OrderID",
																	  "EmployeeID, Employee",
																	  "OrderDate, Order Date",
																	  "RequiredDate, Required Date",
																	  "ShippedDate, Shipped Date",
																	  "ShipVia, Ship Via",
																	  "Freight, Freight, c"
																  });
			dt.Columns["EmployeeID"].ExtendedProperties.Add("DataMap",
				BuildDataMap("Employees", "EmployeeID", "LastName"));
			dt.Columns["ShipVia"].ExtendedProperties.Add("DataMap",
				BuildDataMap("Shippers", "ShipperID", "CompanyName"));

			// build display parameters for "Order Details" table
			//
			dt = _ds.Tables["Order Details"];
			dt.ExtendedProperties.Add("ShowColumns", new string[] {
																	  "ProductID, Product",
																	  "UnitPrice, Unit Price, c",
																	  "Quantity, Qty, 0.00",
																	  "Discount, Discount, c"
																  });
			dt.Columns["ProductID"].ExtendedProperties.Add("DataMap",
				BuildDataMap("Products", "ProductID", "ProductName"));

			// add a calculated column to Customers table so we can see the number of orders for each customer
			//
			dt = _ds.Tables["Customers"];
			DataColumn col = dt.Columns.Add("OrderCount", typeof(int), "Count(Child.OrderID)");

			// re-arrange the columns on the customer table
			//
			dt.ExtendedProperties.Add("ShowColumns", new string[] {
																	  "CustomerID, Customer",
																	  "OrderCount, Orders",
																	  "CompanyName, Company",
																	  "ContactName, Contact",
																	  "Phone",
																	  "City",
																	  "Region",
																	  "Country",
			});

			// show customers to begin with
			_flex.SetDataBinding(_ds, "Customers");
		}


		// bind data tree grid to [Customers]->[Orders]->[Order Details]
		void button1_Click(object sender, System.EventArgs e)
		{
			_flex.AutoResize = true; // small table, fast autoresize
			_flex.SetDataBinding(_ds, "Customers");
		}

		// bind data tree grid to [Orders]->[Order Details]
		void button2_Click(object sender, System.EventArgs e)
		{
			_flex.AutoResize = false; // (for speed)
			_flex.SetDataBinding(_ds, "Orders");
		}

		// bind data tree grid to nothing
		void button3_Click(object sender, System.EventArgs e)
		{
			_flex.SetDataBinding(null, string.Empty);
		}

		// load table into DataSet
		void FillTable(DataSet ds, string tableName, string conn)
		{
			tableName = tableName.Trim();
			string sql = string.Format("select * from [{0}]", tableName);
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			da.Fill(ds, tableName);
		}

		// build a data map
		IDictionary BuildDataMap(string table, string key, string value)
		{
			ListDictionary ld = new ListDictionary();
			foreach (DataRow dr in _ds.Tables[table].Rows)
				ld.Add(dr[key], dr[value]);
			return ld;
		}

		// customize grid display to show selected columns, captions, formats, and data maps
		void _flex_SetupColumns(object sender, System.EventArgs e)
		{
			// get grid that was just bound
			C1FlexDataTree grid = sender as C1FlexDataTree;
			if (grid == null || grid.DataSource == null)
				return;

			// get source DataTable
			CurrencyManager cm = (CurrencyManager)BindingContext[grid.DataSource, grid.DataMember];
			DataTable dt = ((DataView)cm.List).Table;

			// apply custom column order, captions, format
			string[] columns = dt.ExtendedProperties["ShowColumns"] as string[];
			if (columns != null)
			{
				SetupColumns(grid, columns);
			}

			// apply custom data maps
			foreach (Column gridColumn in grid.Cols)
			{
				DataColumn dataColumn = dt.Columns[gridColumn.Name];
				if (dataColumn == null) continue;
				gridColumn.DataMap = dataColumn.ExtendedProperties["DataMap"] as IDictionary;
				if (gridColumn.DataMap != null)
				{
					gridColumn.TextAlign = TextAlignEnum.LeftCenter;
				}
			}

			// all done, autosize to show mapped data
			if (grid.AutoResize)
			{
				grid.AutoSizeCols(12);
			}
		}

		// apply column information to a grid
		// this will set the column positions, caption, format, and visibility
		// (any columns not included in the 'columns' array will not be displayed
		void SetupColumns(C1FlexDataTree grid, string[] columns)
		{
			// initialize column position
			int position = grid.Cols.Fixed;

			// apply column information
			foreach (string s in columns)
			{
				// split column info (name, caption, format)
				string[] columnInfo = s.Split(',');

				// move column to proper position based on its name
				Column column = grid.Cols[columnInfo[0].Trim()];
				if (column != null)
				{
					column.Move(position);
					position++;

					// apply caption
					if (columnInfo.Length > 1)
						column.Caption = columnInfo[1].Trim();

					// apply format
					if (columnInfo.Length > 2)
						column.Format = columnInfo[2].Trim();
				}
			}

			// hide all other columns
			for (int i = position; i < grid.Cols.Count; i++)
				grid.Cols[i].Visible = false;
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
