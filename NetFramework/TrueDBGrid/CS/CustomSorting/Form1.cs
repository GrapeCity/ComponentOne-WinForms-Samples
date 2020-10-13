using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;

namespace CustomSorting
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private CustomSorting.DataSet1 dataSet11;
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
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataSet11 = new CustomSorting.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(448, 266);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.HeadClick += new C1.Win.C1TrueDBGrid.ColEventHandler(this.c1TrueDBGrid1_HeadClick);
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                        new System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"),
                        new System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"),
                        new System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"),
                        new System.Data.Common.DataColumnMapping("Freight", "Freight"),
                        new System.Data.Common.DataColumnMapping("ShipName", "ShipName"),
                        new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
                        new System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"),
                        new System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"),
                        new System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"),
                        new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"),
            new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("Freight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(0)), "Freight", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"),
            new System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, "RequiredDate"),
            new System.Data.OleDb.OleDbParameter("ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, "ShipAddress"),
            new System.Data.OleDb.OleDbParameter("ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCity"),
            new System.Data.OleDb.OleDbParameter("ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCountry"),
            new System.Data.OleDb.OleDbParameter("ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, "ShipName"),
            new System.Data.OleDb.OleDbParameter("ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippedDate"),
            new System.Data.OleDb.OleDbParameter("ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "ShipPostalCode"),
            new System.Data.OleDb.OleDbParameter("ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipRegion"),
            new System.Data.OleDb.OleDbParameter("ShipVia", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ShipVia", System.Data.DataRowVersion.Current, null)});
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studi" +
                @"o.NET 2.0\Common\C1Nwind.mdb;";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT CustomerID, EmployeeID, Freight, OrderDate, OrderID, RequiredDate, ShipAdd" +
                "ress, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegion, " +
                "ShipVia FROM Orders";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(448, 266);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		enum SortDir
		{
			None,
			Asc,
			Desc
		}
		Bitmap _sortup, _sortdn;
		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dataSet11);
			this.c1TrueDBGrid1.DataSource = this.dataSet11.Tables[0].DefaultView;
			// we're going to handle the sorting ourselves in the grids headclick event
			this.c1TrueDBGrid1.AllowSort = false;

			foreach( C1.Win.C1TrueDBGrid.C1DisplayColumn dc in this.c1TrueDBGrid1.Splits[0].DisplayColumns )
			{
				// make the column headers act like buttons
				dc.ButtonHeader = true;
				// default sort order
				dc.DataColumn.Tag = SortDir.None;
			}
			// get the sorting indicators that we'll use in the column headers
			Assembly a = Assembly.GetExecutingAssembly();
			string an = a.GetName().Name;
			_sortdn = new Bitmap(a.GetManifestResourceStream(an+".SortDn.bmp"));
			_sortup = new Bitmap(a.GetManifestResourceStream(an+".SortUp.bmp"));
			_sortdn.MakeTransparent(Color.Red);
			_sortup.MakeTransparent(Color.Red);
		}

		// custom sorting when a column header is pressed
		private void c1TrueDBGrid1_HeadClick(object sender, C1.Win.C1TrueDBGrid.ColEventArgs e)
		{
			// get the display column that was clicked
			C1.Win.C1TrueDBGrid.C1DisplayColumn dc = this.c1TrueDBGrid1.Splits[0].DisplayColumns[e.ColIndex];

			// new sort order
			SortDir newsort = SortDir.None;
			switch ((SortDir)dc.DataColumn.Tag)
			{
				case SortDir.None:
				case SortDir.Desc:
					newsort = SortDir.Asc;
					break;
				default:
					newsort = SortDir.Desc;
					break;
			}

			// clear all sort states and our sort indicators
			foreach( C1.Win.C1TrueDBGrid.C1DisplayColumn col in this.c1TrueDBGrid1.Splits[0].DisplayColumns )
			{
				col.DataColumn.Tag = SortDir.None;
				col.HeadingStyle.ForegroundImage = null;
			}

			// build our new sort condition
			string sortCondition = dc.DataColumn.DataField + " ";
			sortCondition += newsort == SortDir.Desc ? "DESC" : "";

			// sort it
			this.dataSet11.Tables[0].DefaultView.Sort = sortCondition;

			// save the sort state
			dc.DataColumn.Tag = newsort;

			// update the sorting indicator
			if( newsort == SortDir.Asc )
				dc.HeadingStyle.ForegroundImage = this._sortup;
			else
				dc.HeadingStyle.ForegroundImage = this._sortdn;
			// indicators go to the right of text
			dc.HeadingStyle.ForeGroundPicturePosition = C1.Win.C1TrueDBGrid.ForeGroundPicturePositionEnum.RightOfText;
		}

        private string GetModifiedConnectionString(string connstring)
        {
            int dataSource = connstring.IndexOf("Data Source=", 0, StringComparison.OrdinalIgnoreCase);
            int dataSourceEnd = connstring.LastIndexOf('\\', connstring.IndexOf(';', dataSource));
            connstring = connstring.Substring(0, dataSource) + "Data Source=" +
             Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
             "\\ComponentOne Samples\\Common" + connstring.Substring(dataSourceEnd);
            return connstring;
        }
	}
}
