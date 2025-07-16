using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UsingC1TDBDropdown
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private C1.Win.TrueDBGrid.C1TrueDBDropdown c1TrueDBDropdown1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private UsingC1TDBDropdown.DataSet1 dataSet11;
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
            C1.Win.TrueDBGrid.Style style1 = new C1.Win.TrueDBGrid.Style();
            C1.Win.TrueDBGrid.Style style2 = new C1.Win.TrueDBGrid.Style();
            C1.Win.TrueDBGrid.Style style3 = new C1.Win.TrueDBGrid.Style();
            C1.Win.TrueDBGrid.Style style4 = new C1.Win.TrueDBGrid.Style();
            C1.Win.TrueDBGrid.Style style5 = new C1.Win.TrueDBGrid.Style();
            C1.Win.TrueDBGrid.Style style6 = new C1.Win.TrueDBGrid.Style();
            C1.Win.TrueDBGrid.Style style7 = new C1.Win.TrueDBGrid.Style();
            C1.Win.TrueDBGrid.Style style8 = new C1.Win.TrueDBGrid.Style();
            C1.Win.TrueDBGrid.Style style9 = new C1.Win.TrueDBGrid.Style();
            C1.Win.TrueDBGrid.Style style10 = new C1.Win.TrueDBGrid.Style();
            C1.Win.TrueDBGrid.Style style11 = new C1.Win.TrueDBGrid.Style();
            this.c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            this.dataSet11 = new UsingC1TDBDropdown.DataSet1();
            this.c1TrueDBDropdown1 = new C1.Win.TrueDBGrid.C1TrueDBDropdown();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.Caption = "Products Table";
            this.c1TrueDBGrid1.DataSource = this.dataSet11.Products;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(19, 18);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(480, 250);
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
            // c1TrueDBDropdown1
            // 
            this.c1TrueDBDropdown1.AllowColMove = true;
            this.c1TrueDBDropdown1.AllowColSelect = true;
            this.c1TrueDBDropdown1.AllowRowSizing = C1.Win.TrueDBGrid.RowSizingEnum.AllRows;
            this.c1TrueDBDropdown1.AlternatingRows = false;
            this.c1TrueDBDropdown1.CaptionStyle = style1;
            this.c1TrueDBDropdown1.ColumnCaptionHeight = 17;
            this.c1TrueDBDropdown1.ColumnFooterHeight = 17;
            this.c1TrueDBDropdown1.ColumnSelectorStyle = style2;
            this.c1TrueDBDropdown1.DataSource = this.dataSet11.Categories;
            this.c1TrueDBDropdown1.EvenRowStyle = style3;
            this.c1TrueDBDropdown1.FetchRowStyles = false;
            this.c1TrueDBDropdown1.FooterStyle = style4;
            this.c1TrueDBDropdown1.HeadingHotStyle = style5;
            this.c1TrueDBDropdown1.HeadingStyle = style6;
            this.c1TrueDBDropdown1.HighLightRowStyle = style7;
            this.c1TrueDBDropdown1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBDropdown1.Images"))));
            this.c1TrueDBDropdown1.Location = new System.Drawing.Point(144, 120);
            this.c1TrueDBDropdown1.Name = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.OddRowStyle = style8;
            this.c1TrueDBDropdown1.RecordSelectorStyle = style9;
            this.c1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBDropdown1.RowSelectorStyle = style10;
            this.c1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBDropdown1.ScrollTips = false;
            this.c1TrueDBDropdown1.Size = new System.Drawing.Size(230, 120);
            this.c1TrueDBDropdown1.Style = style11;
            this.c1TrueDBDropdown1.TabIndex = 1;
            this.c1TrueDBDropdown1.Text = "c1TrueDBDropdown1";
            this.c1TrueDBDropdown1.Visible = false;
            this.c1TrueDBDropdown1.PropBag = resources.GetString("c1TrueDBDropdown1.PropBag");
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Categories", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Picture", "Picture")})});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO Categories(CategoryID, CategoryName, Description, Picture) VALUES (?," +
    " ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "CategoryName"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture")});
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Program Files\\ComponentOne Studio" +
    ".NET 2.0\\Common\\C1Nwind.mdb;";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
                        new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
                        new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
                        new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO Products(CategoryID, Discontinued, ProductID, ProductName, QuantityPe" +
    "rUnit, ReorderLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder) VALUES (" +
    "?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, "Discontinued"),
            new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, "ProductName"),
            new System.Data.OleDb.OleDbParameter("QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, "QuantityPerUnit"),
            new System.Data.OleDb.OleDbParameter("ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "SupplierID", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Current, null)});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT CategoryID, Discontinued, ProductID, ProductName, QuantityPerUnit, Reorder" +
    "Level, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(432, 270);
            this.Controls.Add(this.c1TrueDBDropdown1);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

			// attach the dropdown to the categories column
			this.c1TrueDBGrid1.Columns["CategoryID"].DropDown = this.c1TrueDBDropdown1;
			
			// underlying datasource value is CategoryID
			this.c1TrueDBDropdown1.DataField = "CategoryID";
			
			// display value will be CategoryName
			this.c1TrueDBDropdown1.ListField = "CategoryName";
			
			// tell the grid that we're translating values
			this.c1TrueDBGrid1.Columns["CategoryID"].ValueItems.Translate = true;
			
			// now use the dropdown to perform the translation for us
			// using a more readable format (i.e.,"CategoryName")
			this.c1TrueDBDropdown1.ValueTranslate = true;
			
			// show checkboxes for the Discontinued column
			this.c1TrueDBGrid1.Columns["Discontinued"].ValueItems.Presentation = C1.Win.TrueDBGrid.PresentationEnum.CheckBox;
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
