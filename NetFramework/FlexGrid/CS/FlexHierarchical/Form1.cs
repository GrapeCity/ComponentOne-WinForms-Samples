using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Hierarchical;

namespace HierFlex
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand8;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand8;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand8;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand8;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter5;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter6;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter7;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter8;
		private HierFlex.DataSet1 dataSet11;
		private System.Windows.Forms.Splitter splitter1;
		private C1.Win.C1FlexGrid.Hierarchical.C1FlexHierarchical _hierFlex;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Splitter splitter2;
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataSet11 = new HierFlex.DataSet1();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand7 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand8 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDataAdapter5 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDataAdapter6 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDataAdapter7 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDataAdapter8 = new System.Data.OleDb.OleDbDataAdapter();
			this._hierFlex = new C1.Win.C1FlexGrid.Hierarchical.C1FlexHierarchical();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.splitter2 = new System.Windows.Forms.Splitter();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._hierFlex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._hierFlex.FlexGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.DataSource = this.dataSet11;
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(172, 150);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(380, 159);
			this.dataGrid1.TabIndex = 1;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Categories(CategoryName, Description, Picture) VALUES (?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "CategoryName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE Categories SET CategoryName = ?, Description = ?, Picture = ? WHERE (Categ" +
				"oryID = ?) AND (CategoryName = ?)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "CategoryName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Categories WHERE (CategoryID = ?) AND (CategoryName = ?)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Address, City, CompanyName, ContactName, ContactTitle, Country, Fax, HomeP" +
				"age, Phone, PostalCode, Region, SupplierID FROM Suppliers";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Suppliers(Address, City, CompanyName, ContactName, ContactTitle, Coun" +
				"try, Fax, HomePage, Phone, PostalCode, Region) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?" +
				", ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("HomePage", System.Data.OleDb.OleDbType.VarWChar, 0, "HomePage"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE Suppliers SET Address = ?, City = ?, CompanyName = ?, ContactName = ?, ContactTitle = ?, Country = ?, Fax = ?, HomePage = ?, Phone = ?, PostalCode = ?, Region = ? WHERE (SupplierID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (CompanyName = ?) AND (ContactName = ? OR ? IS NULL AND ContactName IS NULL) AND (ContactTitle = ? OR ? IS NULL AND ContactTitle IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (PostalCode = ? OR ? IS NULL AND PostalCode IS NULL) AND (Region = ? OR ? IS NULL AND Region IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("HomePage", System.Data.OleDb.OleDbType.VarWChar, 0, "HomePage"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactTitle1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM Suppliers WHERE (SupplierID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (CompanyName = ?) AND (ContactName = ? OR ? IS NULL AND ContactName IS NULL) AND (ContactTitle = ? OR ? IS NULL AND ContactTitle IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (PostalCode = ? OR ? IS NULL AND PostalCode IS NULL) AND (Region = ? OR ? IS NULL AND Region IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactTitle1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = "SELECT Address, City, CompanyName, ContactName, ContactTitle, Country, CustomerID" +
				", Fax, Phone, PostalCode, Region FROM Customers";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand3
			// 
			this.oleDbInsertCommand3.CommandText = "INSERT INTO Customers(Address, City, CompanyName, ContactName, ContactTitle, Coun" +
				"try, CustomerID, Fax, Phone, PostalCode, Region) VALUES (?, ?, ?, ?, ?, ?, ?, ?," +
				" ?, ?, ?)";
			this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
			// 
			// oleDbUpdateCommand3
			// 
			this.oleDbUpdateCommand3.CommandText = @"UPDATE Customers SET Address = ?, City = ?, CompanyName = ?, ContactName = ?, ContactTitle = ?, Country = ?, CustomerID = ?, Fax = ?, Phone = ?, PostalCode = ?, Region = ? WHERE (CustomerID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (CompanyName = ?) AND (ContactName = ? OR ? IS NULL AND ContactName IS NULL) AND (ContactTitle = ? OR ? IS NULL AND ContactTitle IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (PostalCode = ? OR ? IS NULL AND PostalCode IS NULL) AND (Region = ? OR ? IS NULL AND Region IS NULL)";
			this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactTitle1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand3
			// 
			this.oleDbDeleteCommand3.CommandText = @"DELETE FROM Customers WHERE (CustomerID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (CompanyName = ?) AND (ContactName = ? OR ? IS NULL AND ContactName IS NULL) AND (ContactTitle = ? OR ? IS NULL AND ContactTitle IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (PostalCode = ? OR ? IS NULL AND PostalCode IS NULL) AND (Region = ? OR ? IS NULL AND Region IS NULL)";
			this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ContactTitle1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbSelectCommand4
			// 
			this.oleDbSelectCommand4.CommandText = "SELECT Address, BirthDate, City, Country, EmployeeID, Extension, FirstName, HireD" +
				"ate, HomePhone, LastName, Notes, Photo, PostalCode, Region, ReportsTo, Title, Ti" +
				"tleOfCourtesy FROM Employees";
			this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand4
			// 
			this.oleDbInsertCommand4.CommandText = "INSERT INTO Employees(Address, BirthDate, City, Country, Extension, FirstName, Hi" +
				"reDate, HomePhone, LastName, Notes, Photo, PostalCode, Region, ReportsTo, Title," +
				" TitleOfCourtesy) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand4.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("BirthDate", System.Data.OleDb.OleDbType.DBDate, 0, "BirthDate"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Extension", System.Data.OleDb.OleDbType.VarWChar, 4, "Extension"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBDate, 0, "HireDate"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "HomePhone"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 0, "Notes"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Photo", System.Data.OleDb.OleDbType.VarBinary, 0, "Photo"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("ReportsTo", System.Data.OleDb.OleDbType.Integer, 0, "ReportsTo"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, "TitleOfCourtesy"));
			// 
			// oleDbUpdateCommand4
			// 
			this.oleDbUpdateCommand4.CommandText = @"UPDATE Employees SET Address = ?, BirthDate = ?, City = ?, Country = ?, Extension = ?, FirstName = ?, HireDate = ?, HomePhone = ?, LastName = ?, Notes = ?, Photo = ?, PostalCode = ?, Region = ?, ReportsTo = ?, Title = ?, TitleOfCourtesy = ? WHERE (EmployeeID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (BirthDate = ? OR ? IS NULL AND BirthDate IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Extension = ? OR ? IS NULL AND Extension IS NULL) AND (FirstName = ?) AND (HireDate = ? OR ? IS NULL AND HireDate IS NULL) AND (HomePhone = ? OR ? IS NULL AND HomePhone IS NULL) AND (LastName = ?) AND (PostalCode = ? OR ? IS NULL AND PostalCode IS NULL) AND (Region = ? OR ? IS NULL AND Region IS NULL) AND (ReportsTo = ? OR ? IS NULL AND ReportsTo IS NULL) AND (Title = ? OR ? IS NULL AND Title IS NULL) AND (TitleOfCourtesy = ? OR ? IS NULL AND TitleOfCourtesy IS NULL)";
			this.oleDbUpdateCommand4.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("BirthDate", System.Data.OleDb.OleDbType.DBDate, 0, "BirthDate"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Extension", System.Data.OleDb.OleDbType.VarWChar, 4, "Extension"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBDate, 0, "HireDate"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "HomePhone"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 0, "Notes"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Photo", System.Data.OleDb.OleDbType.VarBinary, 0, "Photo"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("ReportsTo", System.Data.OleDb.OleDbType.Integer, 0, "ReportsTo"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, "TitleOfCourtesy"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReportsTo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReportsTo1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand4
			// 
			this.oleDbDeleteCommand4.CommandText = @"DELETE FROM Employees WHERE (EmployeeID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (BirthDate = ? OR ? IS NULL AND BirthDate IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Extension = ? OR ? IS NULL AND Extension IS NULL) AND (FirstName = ?) AND (HireDate = ? OR ? IS NULL AND HireDate IS NULL) AND (HomePhone = ? OR ? IS NULL AND HomePhone IS NULL) AND (LastName = ?) AND (PostalCode = ? OR ? IS NULL AND PostalCode IS NULL) AND (Region = ? OR ? IS NULL AND Region IS NULL) AND (ReportsTo = ? OR ? IS NULL AND ReportsTo IS NULL) AND (Title = ? OR ? IS NULL AND Title IS NULL) AND (TitleOfCourtesy = ? OR ? IS NULL AND TitleOfCourtesy IS NULL)";
			this.oleDbDeleteCommand4.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReportsTo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReportsTo1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbSelectCommand5
			// 
			this.oleDbSelectCommand5.CommandText = "SELECT Discount, OrderID, ProductID, Quantity, UnitPrice FROM [Order Details]";
			this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand5
			// 
			this.oleDbInsertCommand5.CommandText = "INSERT INTO [Order Details] (Discount, OrderID, ProductID, Quantity, UnitPrice) V" +
				"ALUES (?, ?, ?, ?, ?)";
			this.oleDbInsertCommand5.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Discount", System.Data.OleDb.OleDbType.Single, 0, "Discount"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.Integer, 0, "OrderID"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.SmallInt, 0, "Quantity"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, "UnitPrice"));
			// 
			// oleDbUpdateCommand5
			// 
			this.oleDbUpdateCommand5.CommandText = "UPDATE [Order Details] SET Discount = ?, OrderID = ?, ProductID = ?, Quantity = ?" +
				", UnitPrice = ? WHERE (OrderID = ?) AND (ProductID = ?) AND (Discount = ?) AND (" +
				"Quantity = ?) AND (UnitPrice = ?)";
			this.oleDbUpdateCommand5.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Discount", System.Data.OleDb.OleDbType.Single, 0, "Discount"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.Integer, 0, "OrderID"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.SmallInt, 0, "Quantity"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, "UnitPrice"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Discount", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discount", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand5
			// 
			this.oleDbDeleteCommand5.CommandText = "DELETE FROM [Order Details] WHERE (OrderID = ?) AND (ProductID = ?) AND (Discount" +
				" = ?) AND (Quantity = ?) AND (UnitPrice = ?)";
			this.oleDbDeleteCommand5.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Discount", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discount", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbSelectCommand6
			// 
			this.oleDbSelectCommand6.CommandText = "SELECT CustomerID, EmployeeID, Freight, OrderDate, OrderID, RequiredDate, ShipAdd" +
				"ress, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegion, " +
				"ShipVia FROM Orders";
			this.oleDbSelectCommand6.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand6
			// 
			this.oleDbInsertCommand6.CommandText = "INSERT INTO Orders(CustomerID, EmployeeID, Freight, OrderDate, RequiredDate, Ship" +
				"Address, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegio" +
				"n, ShipVia) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand6.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, "EmployeeID"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Freight", System.Data.OleDb.OleDbType.Currency, 0, "Freight"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, "RequiredDate"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, "ShipAddress"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCity"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCountry"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, "ShipName"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippedDate"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "ShipPostalCode"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipRegion"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipVia", System.Data.OleDb.OleDbType.Integer, 0, "ShipVia"));
			// 
			// oleDbUpdateCommand6
			// 
			this.oleDbUpdateCommand6.CommandText = @"UPDATE Orders SET CustomerID = ?, EmployeeID = ?, Freight = ?, OrderDate = ?, RequiredDate = ?, ShipAddress = ?, ShipCity = ?, ShipCountry = ?, ShipName = ?, ShippedDate = ?, ShipPostalCode = ?, ShipRegion = ?, ShipVia = ? WHERE (OrderID = ?) AND (CustomerID = ? OR ? IS NULL AND CustomerID IS NULL) AND (EmployeeID = ? OR ? IS NULL AND EmployeeID IS NULL) AND (Freight = ? OR ? IS NULL AND Freight IS NULL) AND (OrderDate = ? OR ? IS NULL AND OrderDate IS NULL) AND (RequiredDate = ? OR ? IS NULL AND RequiredDate IS NULL) AND (ShipAddress = ? OR ? IS NULL AND ShipAddress IS NULL) AND (ShipCity = ? OR ? IS NULL AND ShipCity IS NULL) AND (ShipCountry = ? OR ? IS NULL AND ShipCountry IS NULL) AND (ShipName = ? OR ? IS NULL AND ShipName IS NULL) AND (ShipPostalCode = ? OR ? IS NULL AND ShipPostalCode IS NULL) AND (ShipRegion = ? OR ? IS NULL AND ShipRegion IS NULL) AND (ShipVia = ? OR ? IS NULL AND ShipVia IS NULL) AND (ShippedDate = ? OR ? IS NULL AND ShippedDate IS NULL)";
			this.oleDbUpdateCommand6.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, "EmployeeID"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Freight", System.Data.OleDb.OleDbType.Currency, 0, "Freight"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, "RequiredDate"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, "ShipAddress"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCity"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCountry"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, "ShipName"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippedDate"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "ShipPostalCode"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipRegion"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipVia", System.Data.OleDb.OleDbType.Integer, 0, "ShipVia"));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_EmployeeID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Freight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Freight", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Freight1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Freight", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_OrderDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RequiredDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipAddress1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipCity1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipCountry1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipName1", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipPostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipRegion1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipVia", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipVia1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShippedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand6
			// 
			this.oleDbDeleteCommand6.CommandText = @"DELETE FROM Orders WHERE (OrderID = ?) AND (CustomerID = ? OR ? IS NULL AND CustomerID IS NULL) AND (EmployeeID = ? OR ? IS NULL AND EmployeeID IS NULL) AND (Freight = ? OR ? IS NULL AND Freight IS NULL) AND (OrderDate = ? OR ? IS NULL AND OrderDate IS NULL) AND (RequiredDate = ? OR ? IS NULL AND RequiredDate IS NULL) AND (ShipAddress = ? OR ? IS NULL AND ShipAddress IS NULL) AND (ShipCity = ? OR ? IS NULL AND ShipCity IS NULL) AND (ShipCountry = ? OR ? IS NULL AND ShipCountry IS NULL) AND (ShipName = ? OR ? IS NULL AND ShipName IS NULL) AND (ShipPostalCode = ? OR ? IS NULL AND ShipPostalCode IS NULL) AND (ShipRegion = ? OR ? IS NULL AND ShipRegion IS NULL) AND (ShipVia = ? OR ? IS NULL AND ShipVia IS NULL) AND (ShippedDate = ? OR ? IS NULL AND ShippedDate IS NULL)";
			this.oleDbDeleteCommand6.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_EmployeeID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Freight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Freight", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Freight1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Freight", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_OrderDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RequiredDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipAddress1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipCity1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipCountry1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipName1", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipPostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipRegion1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipVia", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipVia1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShippedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbSelectCommand7
			// 
			this.oleDbSelectCommand7.CommandText = "SELECT CategoryID, Discontinued, ProductID, ProductName, QuantityPerUnit, Reorder" +
				"Level, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products";
			this.oleDbSelectCommand7.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand7
			// 
			this.oleDbInsertCommand7.CommandText = "INSERT INTO Products(CategoryID, Discontinued, ProductName, QuantityPerUnit, Reor" +
				"derLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder) VALUES (?, ?, ?, ?," +
				" ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand7.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 0, "CategoryID"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, "Discontinued"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, "ProductName"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, "QuantityPerUnit"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, "ReorderLevel"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 0, "SupplierID"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, "UnitPrice"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, "UnitsInStock"));
			this.oleDbInsertCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, "UnitsOnOrder"));
			// 
			// oleDbUpdateCommand7
			// 
			this.oleDbUpdateCommand7.CommandText = @"UPDATE Products SET CategoryID = ?, Discontinued = ?, ProductName = ?, QuantityPerUnit = ?, ReorderLevel = ?, SupplierID = ?, UnitPrice = ?, UnitsInStock = ?, UnitsOnOrder = ? WHERE (ProductID = ?) AND (CategoryID = ? OR ? IS NULL AND CategoryID IS NULL) AND (Discontinued = ?) AND (ProductName = ?) AND (QuantityPerUnit = ? OR ? IS NULL AND QuantityPerUnit IS NULL) AND (ReorderLevel = ? OR ? IS NULL AND ReorderLevel IS NULL) AND (SupplierID = ? OR ? IS NULL AND SupplierID IS NULL) AND (UnitPrice = ? OR ? IS NULL AND UnitPrice IS NULL) AND (UnitsInStock = ? OR ? IS NULL AND UnitsInStock IS NULL) AND (UnitsOnOrder = ? OR ? IS NULL AND UnitsOnOrder IS NULL)";
			this.oleDbUpdateCommand7.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 0, "CategoryID"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, "Discontinued"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, "ProductName"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, "QuantityPerUnit"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, "ReorderLevel"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 0, "SupplierID"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, "UnitPrice"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, "UnitsInStock"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, "UnitsOnOrder"));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CategoryID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReorderLevel1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_SupplierID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitsInStock1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand7
			// 
			this.oleDbDeleteCommand7.CommandText = @"DELETE FROM Products WHERE (ProductID = ?) AND (CategoryID = ? OR ? IS NULL AND CategoryID IS NULL) AND (Discontinued = ?) AND (ProductName = ?) AND (QuantityPerUnit = ? OR ? IS NULL AND QuantityPerUnit IS NULL) AND (ReorderLevel = ? OR ? IS NULL AND ReorderLevel IS NULL) AND (SupplierID = ? OR ? IS NULL AND SupplierID IS NULL) AND (UnitPrice = ? OR ? IS NULL AND UnitPrice IS NULL) AND (UnitsInStock = ? OR ? IS NULL AND UnitsInStock IS NULL) AND (UnitsOnOrder = ? OR ? IS NULL AND UnitsOnOrder IS NULL)";
			this.oleDbDeleteCommand7.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CategoryID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Discontinued", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_QuantityPerUnit1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReorderLevel1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_SupplierID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_SupplierID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitPrice1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitsInStock1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand7.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UnitsOnOrder1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbSelectCommand8
			// 
			this.oleDbSelectCommand8.CommandText = "SELECT CompanyName, Phone, ShipperID FROM Shippers";
			this.oleDbSelectCommand8.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand8
			// 
			this.oleDbInsertCommand8.CommandText = "INSERT INTO Shippers(CompanyName, Phone) VALUES (?, ?)";
			this.oleDbInsertCommand8.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
			this.oleDbInsertCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"));
			// 
			// oleDbUpdateCommand8
			// 
			this.oleDbUpdateCommand8.CommandText = "UPDATE Shippers SET CompanyName = ?, Phone = ? WHERE (ShipperID = ?) AND (Company" +
				"Name = ?) AND (Phone = ? OR ? IS NULL AND Phone IS NULL)";
			this.oleDbUpdateCommand8.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipperID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipperID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand8
			// 
			this.oleDbDeleteCommand8.CommandText = "DELETE FROM Shippers WHERE (ShipperID = ?) AND (CompanyName = ?) AND (Phone = ? O" +
				"R ? IS NULL AND Phone IS NULL)";
			this.oleDbDeleteCommand8.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShipperID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipperID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand8.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Categories", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
																																																					  new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
																																																					  new System.Data.Common.DataColumnMapping("Description", "Description"),
																																																					  new System.Data.Common.DataColumnMapping("Picture", "Picture")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Suppliers", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																					 new System.Data.Common.DataColumnMapping("City", "City"),
																																																					 new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
																																																					 new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
																																																					 new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
																																																					 new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																					 new System.Data.Common.DataColumnMapping("Fax", "Fax"),
																																																					 new System.Data.Common.DataColumnMapping("HomePage", "HomePage"),
																																																					 new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																					 new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
																																																					 new System.Data.Common.DataColumnMapping("Region", "Region"),
																																																					 new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
			this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																					 new System.Data.Common.DataColumnMapping("City", "City"),
																																																					 new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
																																																					 new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
																																																					 new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
																																																					 new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																					 new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
																																																					 new System.Data.Common.DataColumnMapping("Fax", "Fax"),
																																																					 new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																					 new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
																																																					 new System.Data.Common.DataColumnMapping("Region", "Region")})});
			this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.DeleteCommand = this.oleDbDeleteCommand4;
			this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand4;
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																					 new System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"),
																																																					 new System.Data.Common.DataColumnMapping("City", "City"),
																																																					 new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																					 new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
																																																					 new System.Data.Common.DataColumnMapping("Extension", "Extension"),
																																																					 new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
																																																					 new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
																																																					 new System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"),
																																																					 new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																					 new System.Data.Common.DataColumnMapping("Notes", "Notes"),
																																																					 new System.Data.Common.DataColumnMapping("Photo", "Photo"),
																																																					 new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
																																																					 new System.Data.Common.DataColumnMapping("Region", "Region"),
																																																					 new System.Data.Common.DataColumnMapping("ReportsTo", "ReportsTo"),
																																																					 new System.Data.Common.DataColumnMapping("Title", "Title"),
																																																					 new System.Data.Common.DataColumnMapping("TitleOfCourtesy", "TitleOfCourtesy")})});
			this.oleDbDataAdapter4.UpdateCommand = this.oleDbUpdateCommand4;
			// 
			// oleDbDataAdapter5
			// 
			this.oleDbDataAdapter5.DeleteCommand = this.oleDbDeleteCommand5;
			this.oleDbDataAdapter5.InsertCommand = this.oleDbInsertCommand5;
			this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
			this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Order Details", new System.Data.Common.DataColumnMapping[] {
																																																						 new System.Data.Common.DataColumnMapping("Discount", "Discount"),
																																																						 new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
																																																						 new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																						 new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
																																																						 new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice")})});
			this.oleDbDataAdapter5.UpdateCommand = this.oleDbUpdateCommand5;
			// 
			// oleDbDataAdapter6
			// 
			this.oleDbDataAdapter6.DeleteCommand = this.oleDbDeleteCommand6;
			this.oleDbDataAdapter6.InsertCommand = this.oleDbInsertCommand6;
			this.oleDbDataAdapter6.SelectCommand = this.oleDbSelectCommand6;
			this.oleDbDataAdapter6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
																																																				  new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
																																																				  new System.Data.Common.DataColumnMapping("Freight", "Freight"),
																																																				  new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
																																																				  new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
																																																				  new System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"),
																																																				  new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
																																																				  new System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"),
																																																				  new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry"),
																																																				  new System.Data.Common.DataColumnMapping("ShipName", "ShipName"),
																																																				  new System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"),
																																																				  new System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"),
																																																				  new System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"),
																																																				  new System.Data.Common.DataColumnMapping("ShipVia", "ShipVia")})});
			this.oleDbDataAdapter6.UpdateCommand = this.oleDbUpdateCommand6;
			// 
			// oleDbDataAdapter7
			// 
			this.oleDbDataAdapter7.DeleteCommand = this.oleDbDeleteCommand7;
			this.oleDbDataAdapter7.InsertCommand = this.oleDbInsertCommand7;
			this.oleDbDataAdapter7.SelectCommand = this.oleDbSelectCommand7;
			this.oleDbDataAdapter7.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
																																																					new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"),
																																																					new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																					new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
																																																					new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
																																																					new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
																																																					new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
																																																					new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
																																																					new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
																																																					new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder")})});
			this.oleDbDataAdapter7.UpdateCommand = this.oleDbUpdateCommand7;
			// 
			// oleDbDataAdapter8
			// 
			this.oleDbDataAdapter8.DeleteCommand = this.oleDbDeleteCommand8;
			this.oleDbDataAdapter8.InsertCommand = this.oleDbInsertCommand8;
			this.oleDbDataAdapter8.SelectCommand = this.oleDbSelectCommand8;
			this.oleDbDataAdapter8.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Shippers", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
																																																					new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																					new System.Data.Common.DataColumnMapping("ShipperID", "ShipperID")})});
			this.oleDbDataAdapter8.UpdateCommand = this.oleDbUpdateCommand8;
			// 
			// _hierFlex
			// 
			this._hierFlex.BackColor = System.Drawing.SystemColors.Highlight;
			this._hierFlex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			// 
			// _hierFlex.ButtonTemplate
			// 
			this._hierFlex.ButtonTemplate.BackColor = System.Drawing.SystemColors.Control;
			this._hierFlex.ButtonTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._hierFlex.ButtonTemplate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._hierFlex.ButtonTemplate.ForeColor = System.Drawing.SystemColors.ControlText;
			this._hierFlex.ButtonTemplate.TabIndex = 0;
			this._hierFlex.ButtonTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._hierFlex.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this._hierFlex.FlexGrid});
			this._hierFlex.DataSource = this.dataSet11.Customers;
			this._hierFlex.Dock = System.Windows.Forms.DockStyle.Top;
			// 
			// _hierFlex.FlexGrid
			// 
			this._hierFlex.FlexGrid.BackColor = System.Drawing.SystemColors.Window;
			this._hierFlex.FlexGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			this._hierFlex.FlexGrid.ColumnInfo = @"13,1,0,0,0,85,Columns:0{Width:34;ImageAlign:RightCenter;}	1{Width:53;Name:""Address"";Caption:""Address"";DataType:System.String;TextAlign:LeftCenter;}	2{Width:31;Name:""City"";Caption:""City"";DataType:System.String;TextAlign:LeftCenter;}	3{Width:90;Name:""CompanyName"";Caption:""CompanyName"";DataType:System.String;TextAlign:LeftCenter;}	4{Width:80;Name:""ContactName"";Caption:""ContactName"";DataType:System.String;TextAlign:LeftCenter;}	5{Width:72;Name:""ContactTitle"";Caption:""ContactTitle"";DataType:System.String;TextAlign:LeftCenter;}	6{Width:51;Name:""Country"";Caption:""Country"";DataType:System.String;TextAlign:LeftCenter;}	7{Width:72;Name:""CustomerID"";Caption:""CustomerID"";DataType:System.String;TextAlign:LeftCenter;}	8{Width:30;Name:""Fax"";Caption:""Fax"";DataType:System.String;TextAlign:LeftCenter;}	9{Width:44;Name:""Phone"";Caption:""Phone"";DataType:System.String;TextAlign:LeftCenter;}	10{Width:70;Name:""PostalCode"";Caption:""PostalCode"";DataType:System.String;TextAlign:LeftCenter;}	11{Width:47;Name:""Region"";Caption:""Region"";DataType:System.String;TextAlign:LeftCenter;}	12{Name:""CustomersOrders"";Caption:""CustomersOrders"";Visible:False;AllowEditing:False;DataType:System.ComponentModel.IBindingList;}	";
			this._hierFlex.FlexGrid.DataSource = this.dataSet11.Customers;
			this._hierFlex.FlexGrid.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
			this._hierFlex.FlexGrid.ForeColor = System.Drawing.SystemColors.WindowText;
			this._hierFlex.FlexGrid.ShowCursor = true;
			this._hierFlex.FlexGrid.ShowErrors = true;
			this._hierFlex.FlexGrid.Size = new System.Drawing.Size(376, 142);
			this._hierFlex.FlexGrid.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._hierFlex.FlexGrid.TabIndex = 0;
			this._hierFlex.ForeColor = System.Drawing.SystemColors.HighlightText;
			this._hierFlex.Location = new System.Drawing.Point(172, 0);
			this._hierFlex.Name = "_hierFlex";
			this._hierFlex.Size = new System.Drawing.Size(380, 146);
			this._hierFlex.TabIndex = 3;
			this._hierFlex.TabStop = false;
			this._hierFlex.Text = "button1";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(172, 146);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(380, 4);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Left;
			this.propertyGrid1.HelpVisible = false;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.propertyGrid1.SelectedObject = this._hierFlex;
			this.propertyGrid1.Size = new System.Drawing.Size(168, 309);
			this.propertyGrid1.TabIndex = 5;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(168, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(4, 309);
			this.splitter2.TabIndex = 6;
			this.splitter2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 309);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.dataGrid1,
																		  this.splitter1,
																		  this._hierFlex,
																		  this.splitter2,
																		  this.propertyGrid1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Hierarchical data-binding";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._hierFlex.FlexGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._hierFlex)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		void Form1_Load(object sender, System.EventArgs e)
		{
            this.oleDbConnection1.ConnectionString = GetConnectionString();
            this.oleDbDataAdapter1.Fill(this.dataSet11);
			this.oleDbDataAdapter2.Fill(this.dataSet11);
			this.oleDbDataAdapter3.Fill(this.dataSet11);
			this.oleDbDataAdapter4.Fill(this.dataSet11);
			this.oleDbDataAdapter7.Fill(this.dataSet11);
			this.oleDbDataAdapter8.Fill(this.dataSet11);
			this.oleDbDataAdapter6.Fill(this.dataSet11);
			this.oleDbDataAdapter5.Fill(this.dataSet11);
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
