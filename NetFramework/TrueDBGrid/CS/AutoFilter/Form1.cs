using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AutoFilter
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
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private AutoFilter.DataSet1 dataSet11;
		private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TrueDBDropdown1;
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
            C1.Win.C1TrueDBGrid.Style style1 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style2 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style3 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style4 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style5 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style6 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style7 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style8 = new C1.Win.C1TrueDBGrid.Style();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dataSet11 = new AutoFilter.DataSet1();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.c1TrueDBDropdown1 = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.DataMember = "Orders";
            this.c1TrueDBGrid1.DataSource = this.dataSet11;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.FilterBar = true;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(480, 278);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID")})});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO Customers(CustomerID) VALUES (?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID")});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT CustomerID FROM Customers";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // c1TrueDBDropdown1
            // 
            this.c1TrueDBDropdown1.AllowColMove = true;
            this.c1TrueDBDropdown1.AllowColSelect = true;
            this.c1TrueDBDropdown1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
            this.c1TrueDBDropdown1.AlternatingRows = false;
            this.c1TrueDBDropdown1.CaptionStyle = style1;
            this.c1TrueDBDropdown1.ColumnCaptionHeight = 17;
            this.c1TrueDBDropdown1.ColumnFooterHeight = 17;
            this.c1TrueDBDropdown1.DataMember = "Customers";
            this.c1TrueDBDropdown1.DataSource = this.dataSet11;
            this.c1TrueDBDropdown1.EvenRowStyle = style2;
            this.c1TrueDBDropdown1.ExtendRightColumn = true;
            this.c1TrueDBDropdown1.FetchRowStyles = false;
            this.c1TrueDBDropdown1.FooterStyle = style3;
            this.c1TrueDBDropdown1.HeadingStyle = style4;
            this.c1TrueDBDropdown1.HighLightRowStyle = style5;
            this.c1TrueDBDropdown1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBDropdown1.Images"))));
            this.c1TrueDBDropdown1.Location = new System.Drawing.Point(232, 168);
            this.c1TrueDBDropdown1.Name = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.OddRowStyle = style6;
            this.c1TrueDBDropdown1.RecordSelectorStyle = style7;
            this.c1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.ScrollTips = false;
            this.c1TrueDBDropdown1.Size = new System.Drawing.Size(100, 104);
            this.c1TrueDBDropdown1.Style = style8;
            this.c1TrueDBDropdown1.TabIndex = 1;
            this.c1TrueDBDropdown1.TabStop = false;
            this.c1TrueDBDropdown1.Text = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.Visible = false;
            this.c1TrueDBDropdown1.PropBag = resources.GetString("c1TrueDBDropdown1.PropBag");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(480, 278);
            this.Controls.Add(this.c1TrueDBDropdown1);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).EndInit();
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dataSet11);
			this.oleDbDataAdapter2.Fill(this.dataSet11);
			// the dropdown control is bound to the Customers table
			this.c1TrueDBGrid1.Columns["CustomerID"].DropDown = this.c1TrueDBDropdown1;
			// turn on the dropdown button in the filterbar
			this.c1TrueDBGrid1.Splits[0].DisplayColumns["CustomerID"].FilterButton = true;
			// turn it off for regulars cells in the grid
			this.c1TrueDBGrid1.Splits[0].DisplayColumns["CustomerID"].Button = false;
			this.c1TrueDBDropdown1.ColumnHeaders = false;
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
