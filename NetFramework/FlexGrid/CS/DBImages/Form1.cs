using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace DBImages
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.C1FlexGrid.C1FlexGrid flex;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private DBImages.DataSet1 dataSet11;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.dataSet11 = new DBImages.DataSet1();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			((System.ComponentModel.ISupportInitialize)(this.flex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// flex
			// 
			this.flex.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.flex.BackColor = System.Drawing.SystemColors.Window;
			this.flex.ColumnInfo = "18,1,0,0,0,75,Columns:0{Width:22;TextAlign:LeftTop;TextAlignFixed:LeftCenter;}\t1{" +
				"Width:91;Name:\"EmployeeID\";Caption:\"EmployeeID\";Visible:False;DataType:System.In" +
				"t32;TextAlign:RightTop;TextAlignFixed:LeftCenter;}\t2{Width:79;Name:\"Extension\";C" +
				"aption:\"Extension\";Visible:False;DataType:System.String;TextAlign:LeftTop;TextAl" +
				"ignFixed:LeftCenter;}\t3{Width:81;Name:\"FirstName\";Caption:\"FirstName\";Visible:Fa" +
				"lse;DataType:System.String;TextAlign:LeftTop;TextAlignFixed:LeftCenter;}\t4{Width" +
				":92;Name:\"HomePhone\";Caption:\"HomePhone\";Visible:False;DataType:System.String;Te" +
				"xtAlign:LeftTop;TextAlignFixed:LeftCenter;}\t5{Width:81;Name:\"LastName\";Caption:\"" +
				"LastName\";Visible:False;DataType:System.String;TextAlign:LeftTop;TextAlignFixed:" +
				"LeftCenter;}\t6{Width:59;Name:\"Notes\";Caption:\"Notes\";Visible:False;DataType:Syst" +
				"em.String;TextAlign:LeftTop;TextAlignFixed:LeftCenter;}\t7{Width:57;Name:\"Photo\";" +
				"Caption:\"Photo\";DataType:System.Byte[];TextAlign:LeftTop;TextAlignFixed:LeftCent" +
				"er;ImageAlign:Scale;}\t8{Width:67;Name:\"Country\";Caption:\"Country\";DataType:Syste" +
				"m.String;TextAlign:LeftTop;TextAlignFixed:LeftCenter;}\t9{Width:47;Name:\"City\";Ca" +
				"ption:\"City\";DataType:System.String;TextAlign:LeftTop;TextAlignFixed:LeftCenter;" +
				"}\t10{Width:69;Name:\"Address\";Caption:\"Address\";DataType:System.String;TextAlign:" +
				"LeftTop;TextAlignFixed:LeftCenter;}\t11{Width:74;Name:\"BirthDate\";Caption:\"BirthD" +
				"ate\";DataType:System.DateTime;Format:\"d\";TextAlign:LeftTop;TextAlignFixed:LeftCe" +
				"nter;}\t12{Width:72;Name:\"HireDate\";Caption:\"HireDate\";DataType:System.DateTime;F" +
				"ormat:\"d\";TextAlign:LeftTop;TextAlignFixed:LeftCenter;}\t13{Width:65;Name:\"Region" +
				"\";Caption:\"Region\";Visible:False;DataType:System.String;TextAlign:LeftTop;TextAl" +
				"ignFixed:LeftCenter;}\t14{Width:88;Name:\"PostalCode\";Caption:\"PostalCode\";Visible" +
				":False;DataType:System.String;TextAlign:LeftTop;TextAlignFixed:LeftCenter;}\t15{W" +
				"idth:82;Name:\"ReportsTo\";Caption:\"ReportsTo\";Visible:False;DataType:System.Int32" +
				";TextAlign:RightTop;TextAlignFixed:LeftCenter;}\t16{Width:51;Name:\"Title\";Caption" +
				":\"Title\";Visible:False;DataType:System.String;TextAlign:LeftTop;TextAlignFixed:L" +
				"eftCenter;}\t17{Width:108;Name:\"TitleOfCourtesy\";Caption:\"TitleOfCourtesy\";Visibl" +
				"e:False;DataType:System.String;TextAlign:LeftTop;TextAlignFixed:LeftCenter;}\t";
			this.flex.DataSource = this.dataSet11.Employees;
			this.flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flex.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
			this.flex.Name = "flex";
			this.flex.Rows.Count = 1;
			this.flex.ShowCursor = true;
			this.flex.Size = new System.Drawing.Size(496, 273);
			this.flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{TextAlign:LeftTop;}	Fixed{BackColor:Control;ForeColor:ControlText;TextAlign:LeftCenter;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.flex.TabIndex = 0;
			this.flex.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.flex.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("flex.Tree.NodeImageCollapsed")));
			this.flex.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("flex.Tree.NodeImageExpanded")));
			this.flex.BeforeAutosizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.flex_BeforeAutosizeColumn);
			this.flex.BeforeSort += new C1.Win.C1FlexGrid.SortColEventHandler(this.flex_BeforeSort);
			this.flex.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.flex_OwnerDrawCell);
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Address, BirthDate, City, Country, EmployeeID, Extension, FirstName, HireD" +
				"ate, HomePhone, LastName, Notes, Photo, PostalCode, Region, ReportsTo, Title, Ti" +
				"tleOfCourtesy FROM Employees";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Employees(Address, BirthDate, City, Country, Extension, FirstName, Hi" +
				"reDate, HomePhone, LastName, Notes, Photo, PostalCode, Region, ReportsTo, Title," +
				" TitleOfCourtesy) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("BirthDate", System.Data.OleDb.OleDbType.DBDate, 0, "BirthDate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Extension", System.Data.OleDb.OleDbType.VarWChar, 4, "Extension"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBDate, 0, "HireDate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "HomePhone"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 0, "Notes"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Photo", System.Data.OleDb.OleDbType.VarBinary, 0, "Photo"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ReportsTo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, "TitleOfCourtesy"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE Employees SET Address = ?, BirthDate = ?, City = ?, Country = ?, Extension = ?, FirstName = ?, HireDate = ?, HomePhone = ?, LastName = ?, Notes = ?, Photo = ?, PostalCode = ?, Region = ?, ReportsTo = ?, Title = ?, TitleOfCourtesy = ? WHERE (EmployeeID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (BirthDate = ? OR ? IS NULL AND BirthDate IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Extension = ? OR ? IS NULL AND Extension IS NULL) AND (FirstName = ?) AND (HireDate = ? OR ? IS NULL AND HireDate IS NULL) AND (HomePhone = ? OR ? IS NULL AND HomePhone IS NULL) AND (LastName = ?) AND (Notes = ? OR ? IS NULL AND Notes IS NULL) AND (Photo = ? OR ? IS NULL AND Photo IS NULL) AND (PostalCode = ? OR ? IS NULL AND PostalCode IS NULL) AND (Region = ? OR ? IS NULL AND Region IS NULL) AND (Title = ? OR ? IS NULL AND Title IS NULL) AND (TitleOfCourtesy = ? OR ? IS NULL AND TitleOfCourtesy IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("BirthDate", System.Data.OleDb.OleDbType.DBDate, 0, "BirthDate"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Extension", System.Data.OleDb.OleDbType.VarWChar, 4, "Extension"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBDate, 0, "HireDate"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "HomePhone"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 0, "Notes"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Photo", System.Data.OleDb.OleDbType.VarBinary, 0, "Photo"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ReportsTo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, "TitleOfCourtesy"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notes", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notes", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notes1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notes", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Photo", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Photo", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Photo1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Photo", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM Employees WHERE (EmployeeID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (BirthDate = ? OR ? IS NULL AND BirthDate IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Extension = ? OR ? IS NULL AND Extension IS NULL) AND (FirstName = ?) AND (HireDate = ? OR ? IS NULL AND HireDate IS NULL) AND (HomePhone = ? OR ? IS NULL AND HomePhone IS NULL) AND (LastName = ?) AND (Notes = ? OR ? IS NULL AND Notes IS NULL) AND (Photo = ? OR ? IS NULL AND Photo IS NULL) AND (PostalCode = ? OR ? IS NULL AND PostalCode IS NULL) AND (Region = ? OR ? IS NULL AND Region IS NULL) AND (Title = ? OR ? IS NULL AND Title IS NULL) AND (TitleOfCourtesy = ? OR ? IS NULL AND TitleOfCourtesy IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notes", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notes", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Notes1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Notes", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Photo", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Photo", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Photo1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Photo", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
																																																					 new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																					 new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
																																																					 new System.Data.Common.DataColumnMapping("Title", "Title"),
																																																					 new System.Data.Common.DataColumnMapping("TitleOfCourtesy", "TitleOfCourtesy"),
																																																					 new System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"),
																																																					 new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
																																																					 new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																					 new System.Data.Common.DataColumnMapping("City", "City"),
																																																					 new System.Data.Common.DataColumnMapping("Region", "Region"),
																																																					 new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
																																																					 new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																					 new System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"),
																																																					 new System.Data.Common.DataColumnMapping("Extension", "Extension"),
																																																					 new System.Data.Common.DataColumnMapping("Photo", "Photo"),
																																																					 new System.Data.Common.DataColumnMapping("Notes", "Notes"),
																																																					 new System.Data.Common.DataColumnMapping("ReportsTo", "ReportsTo")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Show Database Images";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.flex)).EndInit();
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
			Application.Run(new Form1());
		}

        void Form1_Load(object sender, System.EventArgs e)
        {
            this.oleDbConnection1.ConnectionString = GetConnectionString();
            oleDbDataAdapter1.Fill(dataSet11);

            // make sure photo column is visible and non-editable
            flex.Cols["Photo"].Visible = true;
            flex.Cols["Photo"].AllowEditing = false;

            // initialize styles
            flex.Styles.Normal.Margins.Left = flex.Styles.Normal.Margins.Right = 0;
            flex.Styles.Normal.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftTop;
            flex.Styles.Fixed.TextAlign  = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;

            // add an unbound (calculated) column
            C1.Win.C1FlexGrid.Column c = flex.Cols.Insert(1);
            c.Caption = c.Name = "FullName";
            c.Width = flex.Cols.DefaultSize * 2;

            // make rows taller to show images
            int hei = flex.Rows.DefaultSize;
            flex.Rows.DefaultSize = hei * 6;
            flex.Rows[0].Height = hei;
        }

        // trap OwnerDrawCell event to return calculated values and to return
        // images stored in the database
        void flex_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
        {
            // images are stored in mdb as byte[]
            if (e.Row >= flex.Rows.Fixed)
            {
                // "FullName" is a calculated (unbound) column
                if (flex.Cols[e.Col].Name == "FullName")
                {
                    e.Text = flex[e.Row, "FirstName"] + " " + flex[e.Row, "LastName"];
                    return;
                }

                // "Photo" is an image stored in a blob (byte[])
                if (flex.Cols[e.Col].Name == "Photo")
                {
                    // try loading from mdb
                    e.Image = LoadImage(flex[e.Row, e.Col] as byte[]);

                    // if we got an image, blank text
                    if (e.Image != null) e.Text = null;
                }
            }
        }

        // load bitmap image stored in blob DB field
        // this assumes the image was stored as an OLE "package"
        // (this is the format used by Access)
        static Image LoadImage(byte[] picData)
        {
            // make sure this is an embedded object
            const int bmData = 78;
            if (picData == null || picData.Length < bmData + 2) return null;
            if (picData[0] != 0x15 || picData[1] != 0x1c) return null;

            // we only handle bitmaps for now
            if (picData[bmData] != 'B' || picData[bmData + 1] != 'M') return null;

            // load the picture
            Image img = null;
            try
            {
                MemoryStream ms = new MemoryStream(picData, bmData, picData.Length - bmData);
                img = Image.FromStream(ms);
            } 
            catch {}

            // return what we got
            return img;
        }

        // auto-sizing works based on stored data
        // use default values for unbound columns
        void flex_BeforeAutosizeColumn(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            C1.Win.C1FlexGrid.Column c = flex.Cols[e.Col];

            // "FullName" is a calculated (unbound) column
            if (c.Name == "FullName")
            {
                c.Width = flex.Cols.DefaultSize;
                e.Cancel = true;
                return;
            }

            // "Photo" is an image stored in a blob (byte[])
            if (c.Name == "Photo")
            {
                c.Width = flex.Cols.DefaultSize * 2;
                e.Cancel = true;
                return;
            }
        }

        // sorting works based on the column that was clicked
        // defer clicks on unbound columns to columns that contain data
        bool _descending;
        void flex_BeforeSort(object sender, C1.Win.C1FlexGrid.SortColEventArgs e)
        {
            if (flex.Cols[e.Col].Name == "FullName")
            {
                string str = "FirstName";
                if (_descending) str += " DESC";
                dataSet11.Employees.DefaultView.Sort = str;
                _descending = !_descending;
                e.Cancel = true;                
            }
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
