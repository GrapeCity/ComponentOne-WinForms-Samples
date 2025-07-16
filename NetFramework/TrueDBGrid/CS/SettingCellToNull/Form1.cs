using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SettingCellToNull
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private SettingCellToNull.DataSet1 dataSet11;
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
            this.c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            this.dataSet11 = new SettingCellToNull.DataSet1();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.DataSource = this.dataSet11.Orders;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(16, 24);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(528, 216);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.BeforeColUpdate += new C1.Win.TrueDBGrid.BeforeColUpdateEventHandler(this.c1TrueDBGrid1_BeforeColUpdate);
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
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 266);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dataSet11);
            // To delete the value of date on double-clicking inside the cell and pressing 'Del' or Backspace key.
            c1TrueDBGrid1.Columns[3].EnableDateTimeEditor = false;
		}

		// this event is raised prior to the data being written to the underlying datasource
		private void c1TrueDBGrid1_BeforeColUpdate(object sender, C1.Win.TrueDBGrid.BeforeColUpdateEventArgs e)
		{
			// e.ColIndex is the index in the grid's Column collection
			C1.Win.TrueDBGrid.C1DataColumn dc = this.c1TrueDBGrid1.Columns[e.ColIndex];
			// if we're on the "OrderDate" column with an empty string then set it to null
			if( dc.DataField == "OrderDate" && dc.Text.Length == 0 )
			{
				e.OldValue = System.DBNull.Value;
			}
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
