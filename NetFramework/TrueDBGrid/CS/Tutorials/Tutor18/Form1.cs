using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial18
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private C1.Win.C1TrueDBGrid.C1TrueDBDropdown c1TrueDBDropdown1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private Tutorial18.dsContacts dsContacts1;
		private Tutorial18.dsCustType dsCustType1;
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
			this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dsContacts1 = new Tutorial18.dsContacts();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.c1TrueDBDropdown1 = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
			this.dsCustType1 = new Tutorial18.dsCustType();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustType1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1TrueDBGrid1
			// 
			this.c1TrueDBGrid1.AllowAddNew = true;
			this.c1TrueDBGrid1.Caption = "C1TrueDBGrid.Net";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.DataMember = "Customer";
			this.c1TrueDBGrid1.DataSource = this.dsContacts1;
			this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images"))));
			this.c1TrueDBGrid1.Location = new System.Drawing.Point(8, 8);
			this.c1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder;
			this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
			this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
			this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
			this.c1TrueDBGrid1.RecordSelectorWidth = 17;
			this.c1TrueDBGrid1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1TrueDBGrid1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
			this.c1TrueDBGrid1.RowHeight = 15;
			this.c1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(504, 272);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.UnboundColumnFetch += new C1.Win.C1TrueDBGrid.UnboundColumnFetchEventHandler(this.c1TrueDBGrid1_UnboundColumnFetch);
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Company\" Da" +
				"taField=\"Company\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=" +
				"\"0\" Caption=\"Contacted\" DataField=\"Contacted\"><ValueItems /><GroupInfo /></C1Dat" +
				"aColumn><C1DataColumn Level=\"0\" Caption=\"CustType\" DataField=\"CustType\"><ValueIt" +
				"ems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"FirstName\" Da" +
				"taField=\"FirstName\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Leve" +
				"l=\"0\" Caption=\"LastName\" DataField=\"LastName\"><ValueItems /><GroupInfo /></C1Dat" +
				"aColumn><C1DataColumn Level=\"0\" Caption=\"Phone\" DataField=\"Phone\"><ValueItems />" +
				"<GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"UserCode\" DataField" +
				"=\"UserCode\"><ValueItems /><GroupInfo /></C1DataColumn></DataCols><Styles type=\"C" +
				"1.Win.C1TrueDBGrid.Design.ContextWrapper\"><Data>Style195{}Style161{AlignHorz:Far" +
				";}Style166{AlignHorz:Far;}Style185{AlignHorz:Far;}Style186{}Style50{}Style51{}St" +
				"yle157{}Caption{AlignHorz:Center;}Style179{AlignHorz:Near;}Normal{Font:Tahoma, 1" +
				"1world;}Style194{}Selected{ForeColor:HighlightText;BackColor:Highlight;}Style173" +
				"{AlignHorz:Near;}Editor{}Style171{}Style170{}Style177{}Style176{}Style175{}Style" +
				"174{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}EvenRow{BackColor:Aqua;}" +
				"Style191{AlignHorz:Near;}Style190{AlignHorz:Near;}Style193{}Style192{}Group{Alig" +
				"nVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style168{}Style169{}" +
				"Style162{}Style163{}Style160{AlignHorz:Far;}Style159{}Style158{}Style167{AlignHo" +
				"rz:Far;}Style164{}Style165{}HighlightRow{ForeColor:HighlightText;BackColor:Highl" +
				"ight;}RecordSelector{AlignImage:Center;}Footer{}Style178{AlignHorz:Near;}Style18" +
				"4{AlignHorz:Far;}Style155{AlignHorz:Near;}Style154{AlignHorz:Near;}Style187{}Sty" +
				"le156{}Style172{AlignHorz:Near;}Style182{}Style183{}Heading{Wrap:True;BackColor:" +
				"Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style1" +
				"88{}Style189{}Style180{}Inactive{ForeColor:InactiveCaptionText;BackColor:Inactiv" +
				"eCaption;}FilterBar{}Style9{}Style8{}OddRow{}Style5{}Style4{}Style7{}Style6{}Sty" +
				"le1{}Style181{}Style3{}Style2{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.Merg" +
				"eView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"17" +
				"\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecSelWidth=\"17\" V" +
				"erticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 17, 500, 251</Cl" +
				"ientRect><BorderSide>0</BorderSide><CaptionStyle parent=\"Style2\" me=\"Style10\" />" +
				"<EditorStyle parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=\"EvenRow\" me=\"St" +
				"yle8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style7\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style9\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" me=\"Style1\" /><in" +
				"ternalCols><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style154\" /><Style" +
				" parent=\"Style1\" me=\"Style155\" /><FooterStyle parent=\"Style3\" me=\"Style156\" /><E" +
				"ditorStyle parent=\"Style5\" me=\"Style157\" /><GroupHeaderStyle parent=\"Style1\" me=" +
				"\"Style159\" /><GroupFooterStyle parent=\"Style1\" me=\"Style158\" /><Visible>True</Vi" +
				"sible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>0<" +
				"/DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Styl" +
				"e160\" /><Style parent=\"Style1\" me=\"Style161\" /><FooterStyle parent=\"Style3\" me=\"" +
				"Style162\" /><EditorStyle parent=\"Style5\" me=\"Style163\" /><GroupHeaderStyle paren" +
				"t=\"Style1\" me=\"Style165\" /><GroupFooterStyle parent=\"Style1\" me=\"Style164\" /><Vi" +
				"sible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</He" +
				"ight><DCIdx>1</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"St" +
				"yle2\" me=\"Style166\" /><Style parent=\"Style1\" me=\"Style167\" /><FooterStyle parent" +
				"=\"Style3\" me=\"Style168\" /><EditorStyle parent=\"Style5\" me=\"Style169\" /><GroupHea" +
				"derStyle parent=\"Style1\" me=\"Style171\" /><GroupFooterStyle parent=\"Style1\" me=\"S" +
				"tyle170\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider>" +
				"<Width>66</Width><Height>15</Height><DCIdx>2</DCIdx></C1DisplayColumn><C1Display" +
				"Column><HeadingStyle parent=\"Style2\" me=\"Style172\" /><Style parent=\"Style1\" me=\"" +
				"Style173\" /><FooterStyle parent=\"Style3\" me=\"Style174\" /><EditorStyle parent=\"St" +
				"yle5\" me=\"Style175\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style177\" /><GroupFo" +
				"oterStyle parent=\"Style1\" me=\"Style176\" /><Visible>True</Visible><ColumnDivider>" +
				"DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>3</DCIdx></C1DisplayCol" +
				"umn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style178\" /><Style parent" +
				"=\"Style1\" me=\"Style179\" /><FooterStyle parent=\"Style3\" me=\"Style180\" /><EditorSt" +
				"yle parent=\"Style5\" me=\"Style181\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style1" +
				"83\" /><GroupFooterStyle parent=\"Style1\" me=\"Style182\" /><Visible>True</Visible><" +
				"ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>4</DCIdx>" +
				"</C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style184\" /" +
				"><Style parent=\"Style1\" me=\"Style185\" /><FooterStyle parent=\"Style3\" me=\"Style18" +
				"6\" /><EditorStyle parent=\"Style5\" me=\"Style187\" /><GroupHeaderStyle parent=\"Styl" +
				"e1\" me=\"Style189\" /><GroupFooterStyle parent=\"Style1\" me=\"Style188\" /><Visible>T" +
				"rue</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><D" +
				"CIdx>5</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" m" +
				"e=\"Style190\" /><Style parent=\"Style1\" me=\"Style191\" /><FooterStyle parent=\"Style" +
				"3\" me=\"Style192\" /><EditorStyle parent=\"Style5\" me=\"Style193\" /><GroupHeaderStyl" +
				"e parent=\"Style1\" me=\"Style195\" /><GroupFooterStyle parent=\"Style1\" me=\"Style194" +
				"\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height" +
				">15</Height><DCIdx>6</DCIdx></C1DisplayColumn></internalCols></C1.Win.C1TrueDBGr" +
				"id.MergeView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=" +
				"\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Hea" +
				"ding\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Norm" +
				"al\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /><Style parent=\"Normal\" " +
				"me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\"" +
				" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Norm" +
				"al\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSpl" +
				"its>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRec" +
				"SelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 500, 268</ClientArea><PrintPag" +
				"eHeaderStyle parent=\"\" me=\"Style50\" /><PrintPageFooterStyle parent=\"\" me=\"Style5" +
				"1\" /></Blob>";
			// 
			// dsContacts1
			// 
			this.dsContacts1.DataSetName = "dsContacts";
			this.dsContacts1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsContacts1.Namespace = "http://www.tempuri.org/dsContacts.xsd";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Customer", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Company", "Company"),
																																																					 new System.Data.Common.DataColumnMapping("Contacted", "Contacted"),
																																																					 new System.Data.Common.DataColumnMapping("CustType", "CustType"),
																																																					 new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
																																																					 new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																					 new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																					 new System.Data.Common.DataColumnMapping("UserCode", "UserCode")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM Customer WHERE (UserCode = ?) AND (Company = ? OR ? IS NULL AND Company IS NULL) AND (Contacted = ? OR ? IS NULL AND Contacted IS NULL) AND (CustType = ? OR ? IS NULL AND CustType IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserCode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Company", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Company", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Company1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Company", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contacted", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Contacted", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contacted1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Contacted", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustType1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Customer(Company, Contacted, CustType, FirstName, LastName, Phone, U" +
				"serCode) VALUES (?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Company, Contacted, CustType, FirstName, LastName, Phone, UserCode FROM Cu" +
				"stomer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE Customer SET Company = ?, Contacted = ?, CustType = ?, FirstName = ?, LastName = ?, Phone = ?, UserCode = ? WHERE (UserCode = ?) AND (Company = ? OR ? IS NULL AND Company IS NULL) AND (Contacted = ? OR ? IS NULL AND Contacted IS NULL) AND (CustType = ? OR ? IS NULL AND CustType IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserCode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Company", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Company", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Company1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Company", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contacted", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Contacted", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Contacted1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Contacted", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustType1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "CustType", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			// 
			// c1TrueDBDropdown1
			// 
			this.c1TrueDBDropdown1.AllowColMove = true;
			this.c1TrueDBDropdown1.AllowColSelect = true;
			this.c1TrueDBDropdown1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;
			this.c1TrueDBDropdown1.AlternatingRows = false;
			this.c1TrueDBDropdown1.CaptionHeight = 17;
			this.c1TrueDBDropdown1.ColumnCaptionHeight = 17;
			this.c1TrueDBDropdown1.ColumnFooterHeight = 17;
			this.c1TrueDBDropdown1.ValueMember = "CustType.TypeId";
			this.c1TrueDBDropdown1.DataMember = "CustType";
			this.c1TrueDBDropdown1.DataSource = this.dsCustType1;
			this.c1TrueDBDropdown1.FetchRowStyles = false;
			this.c1TrueDBDropdown1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images1"))));
			this.c1TrueDBDropdown1.LayoutFileName = "";
			this.c1TrueDBDropdown1.LayoutName = "";
			this.c1TrueDBDropdown1.LayoutURL = "";
			this.c1TrueDBDropdown1.DisplayMember = "CustType.TypeDesc";
			this.c1TrueDBDropdown1.Location = new System.Drawing.Point(264, 136);
			this.c1TrueDBDropdown1.Name = "c1TrueDBDropdown1";
			this.c1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1TrueDBDropdown1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
			this.c1TrueDBDropdown1.RowHeight = 15;
			this.c1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1TrueDBDropdown1.ScrollTips = false;
			this.c1TrueDBDropdown1.Size = new System.Drawing.Size(192, 120);
			this.c1TrueDBDropdown1.TabIndex = 1;
			this.c1TrueDBDropdown1.Text = "c1TrueDBDropdown1";
			this.c1TrueDBDropdown1.ValueTranslate = true;
			this.c1TrueDBDropdown1.Visible = false;
			this.c1TrueDBDropdown1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"TypeDesc\" D" +
				"ataField=\"TypeDesc\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Leve" +
				"l=\"0\" Caption=\"TypeId\" DataField=\"TypeId\"><ValueItems /><GroupInfo /></C1DataCol" +
				"umn></DataCols><Styles type=\"C1.Win.C1TrueDBGrid.Design.ContextWrapper\"><Data>Ca" +
				"ption{AlignHorz:Center;}Normal{}Selected{ForeColor:HighlightText;BackColor:Highl" +
				"ight;}Editor{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style140{AlignH" +
				"orz:Near;}Style139{}Style138{}Style137{}Style136{}Style135{AlignHorz:Near;}Style" +
				"134{AlignHorz:Near;}OddRow{}HighlightRow{ForeColor:HighlightText;BackColor:Highl" +
				"ight;}RecordSelector{AlignImage:Center;}Footer{}Inactive{ForeColor:InactiveCapti" +
				"onText;BackColor:InactiveCaption;}EvenRow{BackColor:Aqua;}Heading{Wrap:True;Back" +
				"Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" +
				"Style7{}Style6{}FilterBar{}Style3{}Style4{}Style9{}Style8{}Style1{}Style5{}Group" +
				"{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style141{AlignH" +
				"orz:Near;}Style142{}Style143{}Style144{}Style145{}Style2{}</Data></Styles><Split" +
				"s><C1.Win.C1TrueDBGrid.DropdownView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeig" +
				"ht=\"17\" ColumnFooterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWi" +
				"dth=\"16\" RecordSelectors=\"False\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"" +
				"1\"><ClientRect>0, 0, 188, 116</ClientRect><internalCols><C1DropDisplayColumn><DC" +
				"Idx>0</DCIdx><HeadingStyle parent=\"Style2\" me=\"Style134\" /><Style parent=\"Style1" +
				"\" me=\"Style135\" /><FooterStyle parent=\"Style3\" me=\"Style136\" /><EditorStyle pare" +
				"nt=\"Style5\" me=\"Style137\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style139\" /><G" +
				"roupFooterStyle parent=\"Style1\" me=\"Style138\" /><Visible>True</Visible><ColumnDi" +
				"vider>DarkGray,Single</ColumnDivider><Height>15</Height></C1DropDisplayColumn><C" +
				"1DropDisplayColumn><DCIdx>1</DCIdx><HeadingStyle parent=\"Style2\" me=\"Style140\" /" +
				"><Style parent=\"Style1\" me=\"Style141\" /><FooterStyle parent=\"Style3\" me=\"Style14" +
				"2\" /><EditorStyle parent=\"Style5\" me=\"Style143\" /><GroupHeaderStyle parent=\"Styl" +
				"e1\" me=\"Style145\" /><GroupFooterStyle parent=\"Style1\" me=\"Style144\" /><Visible>T" +
				"rue</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height></" +
				"C1DropDisplayColumn></internalCols><CaptionStyle parent=\"Style2\" me=\"Style10\" />" +
				"<EditorStyle parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=\"EvenRow\" me=\"St" +
				"yle8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style7\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style9\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1TrueDBGrid.DropdownView></Splits><NamedStyles><Style parent=\"\" me=\"Norma" +
				"l\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /" +
				"><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" />" +
				"<Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /><Sty" +
				"le parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><St" +
				"yle parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" />" +
				"<Style parent=\"Normal\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" /></N" +
				"amedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified<" +
				"/Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 188, 116</C" +
				"lientArea></Blob>";
			// 
			// dsCustType1
			// 
			this.dsCustType1.DataSetName = "dsCustType";
			this.dsCustType1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsCustType1.Namespace = "http://www.tempuri.org/dsCustType.xsd";
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "CustType", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("TypeDesc", "TypeDesc"),
																																																					new System.Data.Common.DataColumnMapping("TypeId", "TypeId")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM CustType WHERE (TypeId = ?) AND (TypeDesc = ? OR ? IS NULL AND TypeDe" +
				"sc IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeId", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeId", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeDesc", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeDesc1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO CustType(TypeDesc, TypeId) VALUES (?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeDesc", System.Data.OleDb.OleDbType.VarWChar, 15, "TypeDesc"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeId", System.Data.OleDb.OleDbType.VarWChar, 1, "TypeId"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT TypeDesc, TypeId FROM CustType";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE CustType SET TypeDesc = ?, TypeId = ? WHERE (TypeId = ?) AND (TypeDesc = ?" +
				" OR ? IS NULL AND TypeDesc IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeDesc", System.Data.OleDb.OleDbType.VarWChar, 15, "TypeDesc"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeId", System.Data.OleDb.OleDbType.VarWChar, 1, "TypeId"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeId", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeId", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeDesc", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeDesc1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, null));
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(536, 294);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1TrueDBDropdown1,
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial 18";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBDropdown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustType1)).EndInit();
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

		DataTable dtCopy;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			try
			{
				this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);

				this.oleDbDataAdapter1.Fill(this.dsContacts1);
				dtCopy = this.dsContacts1.Tables[0].Copy();
		
				this.oleDbDataAdapter2.Fill(this.dsCustType1);
				this.c1TrueDBGrid1.Columns["CustType"].DropDown = this.c1TrueDBDropdown1;
				this.c1TrueDBDropdown1.ValueTranslate = true;
				this.c1TrueDBDropdown1.DisplayMember = "TypeDesc";
				this.c1TrueDBDropdown1.ValueMember = "TypeID";


			}
			catch (System.Exception eLoad) 
			{ 
				MessageBox.Show(eLoad.Message); 
			}
		}
		private void c1TrueDBGrid1_UnboundColumnFetch(object sender, C1.Win.C1TrueDBGrid.UnboundColumnFetchEventArgs e)
		{
			if(e.Col == 0 && e.Row < dtCopy.Rows.Count)
				e.Value = dtCopy.Rows[e.Row].ItemArray.GetValue(0).ToString() + " " + dtCopy.Rows[e.Row].ItemArray.GetValue(1).ToString();
		}
		private string GetModifiedConnectionString(string connstring)
		{
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
		}
	}
}
