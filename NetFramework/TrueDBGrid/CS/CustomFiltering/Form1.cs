using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace CustomFiltering
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
		private CustomFiltering.DataSet1 dataSet11;
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
            this.dataSet11 = new CustomFiltering.DataSet1();
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
            this.c1TrueDBGrid1.DataSource = this.dataSet11.Customers;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(488, 266);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.FilterChange += new System.EventHandler(this.c1TrueDBGrid1_FilterChange);
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
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax")})});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO Customers(Address, City, CompanyName, ContactName, ContactTitle, Coun" +
                "try, CustomerID, Fax, Phone, PostalCode, Region) VALUES (?, ?, ?, ?, ?, ?, ?, ?," +
                " ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"),
            new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"),
            new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"),
            new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"),
            new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"),
            new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"),
            new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"),
            new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"),
            new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"),
            new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region")});
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studi" +
                @"o.NET 2.0\Common\C1Nwind.mdb;";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT Address, City, CompanyName, ContactName, ContactTitle, Country, CustomerID" +
                ", Fax, Phone, PostalCode, Region FROM Customers";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(488, 266);
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
			// turn the filterbar on
			this.c1TrueDBGrid1.FilterBar = true;
			// we'll do the filtering ourselves
			this.c1TrueDBGrid1.AllowFilter = false;
		}

		// raised when the contents of the filterbar change
		private void c1TrueDBGrid1_FilterChange(object sender, System.EventArgs e)
		{
			// build our filter expression
			StringBuilder sb = new StringBuilder();		

			foreach(C1.Win.TrueDBGrid.C1DataColumn dc in this.c1TrueDBGrid1.Columns)
			{
				if( dc.FilterText.Length > 0 )
				{
					if( sb.Length > 0 ) sb.Append(" AND ");
					sb.Append(dc.DataField + " like " + "'" + dc.FilterText + "*'");
				}
			}
			// filter the data
			this.dataSet11.Tables[0].DefaultView.RowFilter = sb.ToString();
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
