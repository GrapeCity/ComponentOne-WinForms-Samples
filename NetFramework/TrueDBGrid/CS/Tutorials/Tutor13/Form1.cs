using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1TrueDBGrid;

namespace Tutor13
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private int dragColumn = -1;
		private bool isDrag = false;

		#region Windows Form Designer Generated Variables
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.Label label7;
		internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;
		internal System.Data.OleDb.OleDbConnection OleDbConnection1;
		internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;
		internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;
		internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;
		internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
		internal System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
		internal System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
		private Tutor13.DataSet1 DsTutor131;
		#endregion
		internal C1.Win.C1TrueDBGrid.C1TrueDBGrid C1TrueDBGrid1;
		internal C1.Win.C1TrueDBGrid.C1TrueDBGrid C1TrueDBGrid2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			Application.EnableVisualStyles();
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
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.DsTutor131 = new Tutor13.DataSet1();
			this.C1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
			this.C1TrueDBGrid2 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.DsTutor131)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.C1TrueDBGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.C1TrueDBGrid2)).BeginInit();
			this.SuspendLayout();
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(-82, -39);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(456, 25);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "Drag a row from the top grid and drop it on the bottom grid";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(-82, 169);
			this.Label2.Name = "Label2";
			this.Label2.TabIndex = 8;
			this.Label2.Text = "To here:";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(-82, -7);
			this.Label1.Name = "Label1";
			this.Label1.TabIndex = 7;
			this.Label1.Text = "Drag from here:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(456, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Drag a row from the top grid and drop it on the bottom grid";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 216);
			this.label6.Name = "label6";
			this.label6.TabIndex = 14;
			this.label6.Text = "To here:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 40);
			this.label7.Name = "label7";
			this.label7.TabIndex = 13;
			this.label7.Text = "Drag from here:";
			// 
			// OleDbUpdateCommand1
			// 
			this.OleDbUpdateCommand1.CommandText = @"UPDATE Customer SET Company = ?, Contacted = ?, CustType = ?, FirstName = ?, LastName = ?, Phone = ?, UserCode = ? WHERE (UserCode = ?) AND (Company = ? OR ? IS NULL AND Company IS NULL) AND (Contacted = ? OR ? IS NULL AND Contacted IS NULL) AND (CustType = ? OR ? IS NULL AND CustType IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL)";
			this.OleDbUpdateCommand1.Connection = this.OleDbConnection1;
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Current, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Current, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode"));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserCode", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Company", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Company", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Company1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Company", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contacted", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Contacted", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contacted1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Contacted", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustType1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.OleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			// 
			// OleDbConnection1
			// 
			this.OleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=4;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// OleDbInsertCommand1
			// 
			this.OleDbInsertCommand1.CommandText = "INSERT INTO Customer(Company, Contacted, CustType, FirstName, LastName, Phone, U" +
				"serCode) VALUES (?, ?, ?, ?, ?, ?, ?)";
			this.OleDbInsertCommand1.Connection = this.OleDbConnection1;
			this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"));
			this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"));
			this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Current, null));
			this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
			this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"));
			this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Current, null));
			this.OleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode"));
			// 
			// OleDbDataAdapter1
			// 
			this.OleDbDataAdapter1.DeleteCommand = this.OleDbDeleteCommand1;
			this.OleDbDataAdapter1.InsertCommand = this.OleDbInsertCommand1;
			this.OleDbDataAdapter1.SelectCommand = this.OleDbSelectCommand1;
			this.OleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Customer", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("UserCode", "UserCode"),
																																																					 new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																					 new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
																																																					 new System.Data.Common.DataColumnMapping("Company", "Company"),
																																																					 new System.Data.Common.DataColumnMapping("Contacted", "Contacted"),
																																																					 new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																					 new System.Data.Common.DataColumnMapping("CustType", "CustType")})});
			this.OleDbDataAdapter1.UpdateCommand = this.OleDbUpdateCommand1;
			// 
			// OleDbDeleteCommand1
			// 
			this.OleDbDeleteCommand1.CommandText = @"DELETE FROM Customer WHERE (UserCode = ?) AND (Company = ? OR ? IS NULL AND Company IS NULL) AND (Contacted = ? OR ? IS NULL AND Contacted IS NULL) AND (CustType = ? OR ? IS NULL AND CustType IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL)";
			this.OleDbDeleteCommand1.Connection = this.OleDbConnection1;
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserCode", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Company", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Company", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Company1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Company", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contacted", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Contacted", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contacted1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Contacted", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustType1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.OleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			// 
			// OleDbSelectCommand1
			// 
			this.OleDbSelectCommand1.CommandText = "SELECT Company, Contacted, CustType, FirstName, LastName, Phone, UserCode FROM Cu" +
				"stomer";
			this.OleDbSelectCommand1.Connection = this.OleDbConnection1;
			// 
			// OleDbDataAdapter2
			// 
			this.OleDbDataAdapter2.InsertCommand = this.OleDbInsertCommand2;
			this.OleDbDataAdapter2.SelectCommand = this.OleDbSelectCommand2;
			this.OleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "CallList", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("Customer", "Customer"),
																																																					new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																					new System.Data.Common.DataColumnMapping("CallDate", "CallDate")})});
			// 
			// OleDbInsertCommand2
			// 
			this.OleDbInsertCommand2.CommandText = "INSERT INTO CallList(CallDate, Customer, Phone) VALUES (?, ?, ?)";
			this.OleDbInsertCommand2.Connection = this.OleDbConnection1;
			this.OleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"));
			this.OleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Customer", System.Data.OleDb.OleDbType.VarWChar, 55, "Customer"));
			this.OleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Current, null));
			// 
			// OleDbSelectCommand2
			// 
			this.OleDbSelectCommand2.CommandText = "SELECT CallDate, Customer, Phone FROM CallList";
			this.OleDbSelectCommand2.Connection = this.OleDbConnection1;
			// 
			// DsTutor131
			// 
			this.DsTutor131.DataSetName = "DataSet1";
			this.DsTutor131.Locale = new System.Globalization.CultureInfo("en-US");
			this.DsTutor131.Namespace = "http://www.tempuri.org/DataSet1.xsd";
			// 
			// C1TrueDBGrid1
			// 
			this.C1TrueDBGrid1.AllowDrag = true;
			this.C1TrueDBGrid1.Caption = "C1TrueDBGrid.Net";
			this.C1TrueDBGrid1.CaptionHeight = 17;
			this.C1TrueDBGrid1.DataMember = "Customer";
			this.C1TrueDBGrid1.DataSource = this.DsTutor131;
			this.C1TrueDBGrid1.ExtendRightColumn = true;
			this.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
			this.C1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images"))));
			this.C1TrueDBGrid1.Location = new System.Drawing.Point(16, 64);
			this.C1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.SolidCellBorder;
			this.C1TrueDBGrid1.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.Simple;
			this.C1TrueDBGrid1.Name = "C1TrueDBGrid1";
			this.C1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
			this.C1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
			this.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
			this.C1TrueDBGrid1.RecordSelectorWidth = 17;
			this.C1TrueDBGrid1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1TrueDBGrid1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
			this.C1TrueDBGrid1.RowHeight = 15;
			this.C1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1TrueDBGrid1.Size = new System.Drawing.Size(456, 144);
			this.C1TrueDBGrid1.TabIndex = 17;
			this.C1TrueDBGrid1.Text = "C1TrueDBGrid1";
			this.C1TrueDBGrid1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C1TrueDBGrid1_MouseMove);
			this.C1TrueDBGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.C1TrueDBGrid1_MouseDown);
			this.C1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"FirstName\" " +
				"DataField=\"FirstName\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Le" +
				"vel=\"0\" Caption=\"LastName\" DataField=\"LastName\"><ValueItems /><GroupInfo /></C1D" +
				"ataColumn><C1DataColumn Level=\"0\" Caption=\"Company\" DataField=\"Company\"><ValueIt" +
				"ems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"Phone\" DataFi" +
				"eld=\"Phone\" NumberFormat=\"(###)###-####\"><ValueItems /><GroupInfo /></C1DataColu" +
				"mn></DataCols><Styles type=\"C1.Win.C1TrueDBGrid.Design.ContextWrapper\"><Data>Sty" +
				"le50{}Style51{}Caption{AlignHorz:Center;}Style27{AlignHorz:Near;}Normal{}Style25" +
				"{}Style24{}Editor{}Style48{}Style18{AlignHorz:Far;}Style19{AlignHorz:Far;}Style1" +
				"4{AlignHorz:Near;}Style15{AlignHorz:Near;}Style16{}Style17{}Style10{AlignHorz:Ne" +
				"ar;}Style11{}OddRow{}Style13{}Style43{}Style44{}Style45{}Style46{}Style47{}Style" +
				"12{}Style29{}Style28{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style26{AlignHorz:Near;}RecordSelector{AlignImage:Center;}Footer{}Style23{AlignH" +
				"orz:Far;}Style22{AlignHorz:Far;}Style21{}Style20{}Group{BackColor:ControlDark;Bo" +
				"rder:None,,0, 0, 0, 0;AlignVert:Center;}Inactive{ForeColor:InactiveCaptionText;B" +
				"ackColor:InactiveCaption;}EvenRow{BackColor:Aqua;}Heading{Wrap:True;AlignVert:Ce" +
				"nter;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style49{" +
				"}Style3{}Style7{}Style6{}Style1{}Style5{}Style41{}Style40{}Style8{}FilterBar{}St" +
				"yle42{}Selected{ForeColor:HighlightText;BackColor:Highlight;}Style4{}Style9{}Sty" +
				"le38{AlignHorz:Near;}Style39{AlignHorz:Near;}Style36{}Style37{}Style34{AlignHorz" +
				":Far;}Style35{AlignHorz:Far;}Style32{}Style33{}Style30{AlignHorz:Near;}Style31{A" +
				"lignHorz:Near;}Style2{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Na" +
				"me=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"17\" Extend" +
				"RightColumn=\"True\" MarqueeStyle=\"SolidCellBorder\" RecordSelectorWidth=\"17\" DefRe" +
				"cSelWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, " +
				"17, 452, 123</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=\"Style2\"" +
				" me=\"Style10\" /><EditorStyle parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=" +
				"\"EvenRow\" me=\"Style8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><Foote" +
				"rStyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><" +
				"HeadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"Highlight" +
				"Row\" me=\"Style7\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle p" +
				"arent=\"OddRow\" me=\"Style9\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"St" +
				"yle11\" /><SelectedStyle parent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" m" +
				"e=\"Style1\" /><internalCols><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"St" +
				"yle30\" /><Style parent=\"Style1\" me=\"Style31\" /><FooterStyle parent=\"Style3\" me=\"" +
				"Style32\" /><EditorStyle parent=\"Style5\" me=\"Style33\" /><GroupHeaderStyle parent=" +
				"\"Style1\" me=\"Style45\" /><GroupFooterStyle parent=\"Style1\" me=\"Style44\" /><Visibl" +
				"e>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height" +
				"><DCIdx>1</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2" +
				"\" me=\"Style26\" /><Style parent=\"Style1\" me=\"Style27\" /><FooterStyle parent=\"Styl" +
				"e3\" me=\"Style28\" /><EditorStyle parent=\"Style5\" me=\"Style29\" /><GroupHeaderStyle" +
				" parent=\"Style1\" me=\"Style47\" /><GroupFooterStyle parent=\"Style1\" me=\"Style46\" /" +
				"><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15" +
				"</Height><DCIdx>0</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent" +
				"=\"Style2\" me=\"Style14\" /><Style parent=\"Style1\" me=\"Style15\" /><FooterStyle pare" +
				"nt=\"Style3\" me=\"Style16\" /><EditorStyle parent=\"Style5\" me=\"Style17\" /><GroupHea" +
				"derStyle parent=\"Style1\" me=\"Style49\" /><GroupFooterStyle parent=\"Style1\" me=\"St" +
				"yle48\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><H" +
				"eight>15</Height><DCIdx>2</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyl" +
				"e parent=\"Style2\" me=\"Style34\" /><Style parent=\"Style1\" me=\"Style35\" /><FooterSt" +
				"yle parent=\"Style3\" me=\"Style36\" /><EditorStyle parent=\"Style5\" me=\"Style37\" /><" +
				"GroupHeaderStyle parent=\"Style1\" me=\"Style51\" /><GroupFooterStyle parent=\"Style1" +
				"\" me=\"Style50\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDi" +
				"vider><Height>15</Height><DCIdx>3</DCIdx></C1DisplayColumn></internalCols></C1.W" +
				"in.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><" +
				"Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Styl" +
				"e parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style" +
				" parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /><Style par" +
				"ent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style pa" +
				"rent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style" +
				" parent=\"Normal\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSt" +
				"yles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layou" +
				"t><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 452, 140</ClientA" +
				"rea><PrintPageHeaderStyle parent=\"\" me=\"Style42\" /><PrintPageFooterStyle parent=" +
				"\"\" me=\"Style43\" /></Blob>";
			// 
			// C1TrueDBGrid2
			// 
			this.C1TrueDBGrid2.AllowDrop = true;
			this.C1TrueDBGrid2.CaptionHeight = 17;
			this.C1TrueDBGrid2.DataMember = "CallList";
			this.C1TrueDBGrid2.DataSource = this.DsTutor131;
			this.C1TrueDBGrid2.ExtendRightColumn = true;
			this.C1TrueDBGrid2.GroupByCaption = "Drag a column header here to group by that column";
			this.C1TrueDBGrid2.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images1"))));
			this.C1TrueDBGrid2.Location = new System.Drawing.Point(16, 240);
			this.C1TrueDBGrid2.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder;
			this.C1TrueDBGrid2.Name = "C1TrueDBGrid2";
			this.C1TrueDBGrid2.PreviewInfo.Location = new System.Drawing.Point(0, 0);
			this.C1TrueDBGrid2.PreviewInfo.Size = new System.Drawing.Size(0, 0);
			this.C1TrueDBGrid2.PreviewInfo.ZoomFactor = 75;
			this.C1TrueDBGrid2.RecordSelectorWidth = 17;
			this.C1TrueDBGrid2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1TrueDBGrid2.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
			this.C1TrueDBGrid2.RowHeight = 15;
			this.C1TrueDBGrid2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1TrueDBGrid2.Size = new System.Drawing.Size(456, 104);
			this.C1TrueDBGrid2.TabIndex = 18;
			this.C1TrueDBGrid2.Text = "C1TrueDBGrid2";
			this.C1TrueDBGrid2.DragEnter += new System.Windows.Forms.DragEventHandler(this.C1TrueDBGrid2_DragEnter);
			this.C1TrueDBGrid2.DragDrop += new System.Windows.Forms.DragEventHandler(this.C1TrueDBGrid2_DragDrop);
			this.C1TrueDBGrid2.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Customer\" D" +
				"ataField=\"Customer\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Leve" +
				"l=\"0\" Caption=\"Phone\" DataField=\"Phone\" NumberFormat=\"(###)###-####\"><ValueItems" +
				" /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"CallDate\" DataFi" +
				"eld=\"CallDate\"><ValueItems /><GroupInfo /></C1DataColumn></DataCols><Styles type" +
				"=\"C1.Win.C1TrueDBGrid.Design.ContextWrapper\"><Data>Caption{AlignHorz:Center;}Sty" +
				"le27{}Normal{}Style25{}Selected{ForeColor:HighlightText;BackColor:Highlight;}Edi" +
				"tor{}Style18{AlignHorz:Far;}Style19{AlignHorz:Far;}Style14{AlignHorz:Near;}Style" +
				"15{AlignHorz:Near;}Style16{}Style17{}Style10{AlignHorz:Near;}Style11{}OddRow{}St" +
				"yle13{}Style12{}Style32{}Style33{}Style31{}Footer{}Style29{}Style28{}HighlightRo" +
				"w{ForeColor:HighlightText;BackColor:Highlight;}Style26{}RecordSelector{AlignImag" +
				"e:Center;}Style24{}Style23{AlignHorz:Far;}Style22{AlignHorz:Far;}Style21{}Style2" +
				"0{}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}EvenRow{Bac" +
				"kColor:Aqua;}Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeCo" +
				"lor:ControlText;BackColor:White;}FilterBar{}Style4{}Style9{}Style8{}Style5{}Grou" +
				"p{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style7{}Style6" +
				"{}Style1{}Style30{}Style3{}Style2{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid." +
				"MergeView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight" +
				"=\"17\" ExtendRightColumn=\"True\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWid" +
				"th=\"17\" DefRecSelWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><C" +
				"lientRect>0, 0, 452, 100</ClientRect><BorderSide>0</BorderSide><CaptionStyle par" +
				"ent=\"Style2\" me=\"Style10\" /><EditorStyle parent=\"Editor\" me=\"Style5\" /><EvenRowS" +
				"tyle parent=\"EvenRow\" me=\"Style8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Style" +
				"13\" /><FooterStyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"" +
				"Style12\" /><HeadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle paren" +
				"t=\"HighlightRow\" me=\"Style7\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><O" +
				"ddRowStyle parent=\"OddRow\" me=\"Style9\" /><RecordSelectorStyle parent=\"RecordSele" +
				"ctor\" me=\"Style11\" /><SelectedStyle parent=\"Selected\" me=\"Style6\" /><Style paren" +
				"t=\"Normal\" me=\"Style1\" /><internalCols><C1DisplayColumn><HeadingStyle parent=\"St" +
				"yle2\" me=\"Style14\" /><Style parent=\"Style1\" me=\"Style15\" /><FooterStyle parent=\"" +
				"Style3\" me=\"Style16\" /><EditorStyle parent=\"Style5\" me=\"Style17\" /><GroupHeaderS" +
				"tyle parent=\"Style1\" me=\"Style29\" /><GroupFooterStyle parent=\"Style1\" me=\"Style2" +
				"8\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Heigh" +
				"t>15</Height><DCIdx>0</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle pa" +
				"rent=\"Style2\" me=\"Style18\" /><Style parent=\"Style1\" me=\"Style19\" /><FooterStyle " +
				"parent=\"Style3\" me=\"Style20\" /><EditorStyle parent=\"Style5\" me=\"Style21\" /><Grou" +
				"pHeaderStyle parent=\"Style1\" me=\"Style31\" /><GroupFooterStyle parent=\"Style1\" me" +
				"=\"Style30\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivide" +
				"r><Height>15</Height><DCIdx>1</DCIdx></C1DisplayColumn><C1DisplayColumn><Heading" +
				"Style parent=\"Style2\" me=\"Style22\" /><Style parent=\"Style1\" me=\"Style23\" /><Foot" +
				"erStyle parent=\"Style3\" me=\"Style24\" /><EditorStyle parent=\"Style5\" me=\"Style25\"" +
				" /><GroupHeaderStyle parent=\"Style1\" me=\"Style33\" /><GroupFooterStyle parent=\"St" +
				"yle1\" me=\"Style32\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</Colu" +
				"mnDivider><Height>15</Height><DCIdx>2</DCIdx></C1DisplayColumn></internalCols></" +
				"C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\"" +
				" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><" +
				"Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><S" +
				"tyle parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /><Style" +
				" parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Styl" +
				"e parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><S" +
				"tyle parent=\"Normal\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" /></Nam" +
				"edStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</L" +
				"ayout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 452, 100</Cli" +
				"entArea><PrintPageHeaderStyle parent=\"\" me=\"Style26\" /><PrintPageFooterStyle par" +
				"ent=\"\" me=\"Style27\" /></Blob>";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 366);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.C1TrueDBGrid2,
																		  this.C1TrueDBGrid1,
																		  this.label5,
																		  this.label6,
																		  this.label7,
																		  this.Label3,
																		  this.Label2,
																		  this.Label1});
			this.Name = "Form1";
			this.Text = "Tutorial 13";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.DsTutor131)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.C1TrueDBGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.C1TrueDBGrid2)).EndInit();
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			try
			{
                this.OleDbConnection1.ConnectionString = GetModifiedConnectionString(this.OleDbConnection1.ConnectionString);
				this.OleDbDataAdapter1.Fill(this.DsTutor131);
				this.OleDbDataAdapter2.Fill(this.DsTutor131);
			}
			catch(System.Exception eLoad)
			{
				MessageBox.Show(eLoad.Message);
			}
			this.dragColumn = -1;
		}

		private void ResetDragDrop()
		{
			// Turn off drag-and-drop by resetting the highlight and label text.
			this.dragColumn = -1;
			if(this.C1TrueDBGrid1.MarqueeStyle == MarqueeEnum.SolidCellBorder) return;
			this.C1TrueDBGrid1.MarqueeStyle = MarqueeEnum.SolidCellBorder;
			this.C1TrueDBGrid2.MarqueeStyle = MarqueeEnum.SolidCellBorder;
			this.Label3.Text = "Drag a row from the top grid and drop it on the bottom grid.";
		}

		private void C1TrueDBGrid1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int row, col;
			this.dragColumn = -1;
			this.isDrag = false;
			if(this.C1TrueDBGrid1.CellContaining(e.X, e.Y, out row, out col))
			{
				this.C1TrueDBGrid1.MarqueeStyle = MarqueeEnum.HighlightRow;
				this.C1TrueDBGrid1.Col = col;
				this.C1TrueDBGrid1.Bookmark = row;
				this.dragColumn = col;
				this.isDrag = true;
			}
		}

		private void C1TrueDBGrid1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(this.dragColumn != -1 && this.isDrag)
				this.C1TrueDBGrid1.DoDragDrop(this.dragColumn, DragDropEffects.Copy);
		}

		private void C1TrueDBGrid2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			this.Label3.Text = "Create a new record when dropped...";
			e.Effect = DragDropEffects.Copy;
		}

		private void C1TrueDBGrid2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try
			{
				int col = (int)e.Data.GetData(typeof(int));
				string custname = this.C1TrueDBGrid1.Columns["FirstName"].Value.ToString() +
					" " + this.C1TrueDBGrid1.Columns["LastName"].Value.ToString();
				custname += this.C1TrueDBGrid1.Columns["Company"].Value.ToString();
				// add a new row to the data set for the bottom grid
				DataRowView drv = this.DsTutor131.CallList.DefaultView.AddNew();
				drv["CallDate"] = DateTime.Now;
				drv["Customer"] = custname;
				drv["Phone"] = this.C1TrueDBGrid1.Columns["Phone"].Value.ToString();
				drv.EndEdit();
				this.C1TrueDBGrid2.MoveLast();
				this.C1TrueDBGrid2.Select();
				// commit changes to the database
				DataSet inserted = this.DsTutor131.GetChanges(DataRowState.Added);
				if(inserted != null) this.OleDbDataAdapter2.Update(inserted);
				this.ResetDragDrop();
			}
			catch(System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private string GetModifiedConnectionString(string connstring)
		{
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
		}

	}
}
