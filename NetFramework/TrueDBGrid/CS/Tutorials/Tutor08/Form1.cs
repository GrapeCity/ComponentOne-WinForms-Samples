using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial08
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Tutorial08.DsContacts dsContacts1;
		private C1.Win.TrueDBGrid.C1TrueDBDropdown c1TrueDBDropdown1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private Tutorial08.DsCustType dsCustType1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
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
			this.c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();

			this.dsContacts1 = new Tutorial08.DsContacts();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
			this.c1TrueDBDropdown1 = new C1.Win.TrueDBGrid.C1TrueDBDropdown();
			this.dsCustType1 = new Tutorial08.DsCustType();
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
			this.c1TrueDBGrid1.Caption = "C1True DBGrid .Net";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.DataMember = "Contacts";
			this.c1TrueDBGrid1.DataSource = this.dsContacts1;
			this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images"))));
			this.c1TrueDBGrid1.Location = new System.Drawing.Point(16, 8);
			this.c1TrueDBGrid1.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.DottedCellBorder;
			this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
			this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
			this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
			this.c1TrueDBGrid1.RecordSelectorWidth = 17;
			this.c1TrueDBGrid1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1TrueDBGrid1.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.Single;
			this.c1TrueDBGrid1.RowHeight = 15;
			this.c1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(480, 208);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.UnboundColumnFetch += new C1.Win.TrueDBGrid.UnboundColumnFetchEventHandler(this.c1TrueDBGrid1_UnboundColumnFetch);
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Name\" DataF" +
				"ield=\"\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Captio" +
				"n=\"FirstName\" DataField=\"FirstName\"><ValueItems /><GroupInfo /></C1DataColumn><C" +
				"1DataColumn Level=\"0\" Caption=\"LastName\" DataField=\"LastName\"><ValueItems /><Gro" +
				"upInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"CustType\" DataField=\"Cu" +
				"stType\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Captio" +
				"n=\"ContactType\" DataField=\"ContactType\"><ValueItems /><GroupInfo /></C1DataColum" +
				"n><C1DataColumn Level=\"0\" Caption=\"Callback\" DataField=\"Callback\"><ValueItems />" +
				"<GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"ContactDate\" DataFi" +
				"eld=\"ContactDate\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=" +
				"\"0\" Caption=\"UserCode\" DataField=\"UserCode\"><ValueItems /><GroupInfo /></C1DataC" +
				"olumn><C1DataColumn Level=\"0\" Caption=\"Expr1\" DataField=\"Expr1\"><ValueItems /><G" +
				"roupInfo /></C1DataColumn></DataCols><Styles type=\"C1.Win.TrueDBGrid.Design.Co" +
				"ntextWrapper\"><Data>HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}In" +
				"active{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}Selected{ForeCol" +
				"or:HighlightText;BackColor:Highlight;}Editor{}FilterBar{}Heading{Wrap:True;BackC" +
				"olor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}S" +
				"tyle18{AlignHorz:Near;}Style19{AlignHorz:Near;}Style14{AlignHorz:Near;}Style15{A" +
				"lignHorz:Near;}Style16{}Style17{}Style10{AlignHorz:Near;}Style11{}Style12{}Style" +
				"13{}Style27{AlignHorz:Far;}Style29{}Style28{}Style26{AlignHorz:Far;}Style25{}Sty" +
				"le9{}Style8{}Style24{}Style23{AlignHorz:Far;}Style5{}Style4{}Style7{}Style6{}Sty" +
				"le1{}Style22{AlignHorz:Far;}Style3{}Style2{}Style21{}Style20{}OddRow{}Style38{Al" +
				"ignHorz:Near;}Style39{AlignHorz:Near;}Style36{}Style37{}Style34{AlignHorz:Far;}S" +
				"tyle35{AlignHorz:Far;}Style32{}Style33{}Style30{AlignHorz:Center;}Style49{}Style" +
				"48{}Style31{AlignHorz:Center;}Normal{}Style41{}Style40{}Style43{AlignHorz:Near;}" +
				"Style42{AlignHorz:Near;}Style45{}Style44{}Style47{AlignHorz:Near;}Style46{AlignH" +
				"orz:Near;}EvenRow{BackColor:Aqua;}Style59{}Style58{}RecordSelector{AlignImage:Ce" +
				"nter;}Style51{}Style50{}Footer{}Style52{}Style53{}Style54{}Style55{}Style56{}Sty" +
				"le57{}Caption{AlignHorz:Center;}Style69{}Style68{}Style63{}Style62{}Style61{}Sty" +
				"le60{}Style67{}Style66{}Style65{}Style64{}Group{AlignVert:Center;Border:None,,0," +
				" 0, 0, 0;BackColor:ControlDark;}</Data></Styles><Splits><C1.Win.TrueDBGrid.Mer" +
				"geView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"1" +
				"7\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecSelWidth=\"17\" " +
				"VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 17, 476, 187</C" +
				"lientRect><BorderSide>0</BorderSide><CaptionStyle parent=\"Style2\" me=\"Style10\" /" +
				"><EditorStyle parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=\"EvenRow\" me=\"S" +
				"tyle8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><FooterStyle parent=\"" +
				"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><HeadingStyle pa" +
				"rent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style7" +
				"\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" " +
				"me=\"Style9\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" /><Selec" +
				"tedStyle parent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" me=\"Style1\" /><i" +
				"nternalCols><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style46\" /><Style" +
				" parent=\"Style1\" me=\"Style47\" /><FooterStyle parent=\"Style3\" me=\"Style48\" /><Edi" +
				"torStyle parent=\"Style5\" me=\"Style49\" /><GroupHeaderStyle parent=\"Style1\" me=\"St" +
				"yle53\" /><GroupFooterStyle parent=\"Style1\" me=\"Style52\" /><ColumnDivider>DarkGra" +
				"y,Single</ColumnDivider><Height>15</Height><DCIdx>0</DCIdx></C1DisplayColumn><C1" +
				"DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style14\" /><Style parent=\"Style1" +
				"\" me=\"Style15\" /><FooterStyle parent=\"Style3\" me=\"Style16\" /><EditorStyle parent" +
				"=\"Style5\" me=\"Style17\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style55\" /><Group" +
				"FooterStyle parent=\"Style1\" me=\"Style54\" /><Visible>True</Visible><ColumnDivider" +
				">DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>1</DCIdx></C1DisplayCo" +
				"lumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style18\" /><Style parent" +
				"=\"Style1\" me=\"Style19\" /><FooterStyle parent=\"Style3\" me=\"Style20\" /><EditorStyl" +
				"e parent=\"Style5\" me=\"Style21\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style57\" " +
				"/><GroupFooterStyle parent=\"Style1\" me=\"Style56\" /><Visible>True</Visible><Colum" +
				"nDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>2</DCIdx></C1D" +
				"isplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style22\" /><Styl" +
				"e parent=\"Style1\" me=\"Style23\" /><FooterStyle parent=\"Style3\" me=\"Style24\" /><Ed" +
				"itorStyle parent=\"Style5\" me=\"Style25\" /><GroupHeaderStyle parent=\"Style1\" me=\"S" +
				"tyle59\" /><GroupFooterStyle parent=\"Style1\" me=\"Style58\" /><Visible>True</Visibl" +
				"e><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>3</DCI" +
				"dx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style30\"" +
				" /><Style parent=\"Style1\" me=\"Style31\" /><FooterStyle parent=\"Style3\" me=\"Style3" +
				"2\" /><EditorStyle parent=\"Style5\" me=\"Style33\" /><GroupHeaderStyle parent=\"Style" +
				"1\" me=\"Style63\" /><GroupFooterStyle parent=\"Style1\" me=\"Style62\" /><Visible>True" +
				"</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCId" +
				"x>5</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"" +
				"Style34\" /><Style parent=\"Style1\" me=\"Style35\" /><FooterStyle parent=\"Style3\" me" +
				"=\"Style36\" /><EditorStyle parent=\"Style5\" me=\"Style37\" /><GroupHeaderStyle paren" +
				"t=\"Style1\" me=\"Style65\" /><GroupFooterStyle parent=\"Style1\" me=\"Style64\" /><Visi" +
				"ble>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Heig" +
				"ht><DCIdx>6</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Styl" +
				"e2\" me=\"Style26\" /><Style parent=\"Style1\" me=\"Style27\" /><FooterStyle parent=\"St" +
				"yle3\" me=\"Style28\" /><EditorStyle parent=\"Style5\" me=\"Style29\" /><GroupHeaderSty" +
				"le parent=\"Style1\" me=\"Style61\" /><GroupFooterStyle parent=\"Style1\" me=\"Style60\"" +
				" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>" +
				"15</Height><DCIdx>4</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle pare" +
				"nt=\"Style2\" me=\"Style42\" /><Style parent=\"Style1\" me=\"Style43\" /><FooterStyle pa" +
				"rent=\"Style3\" me=\"Style44\" /><EditorStyle parent=\"Style5\" me=\"Style45\" /><GroupH" +
				"eaderStyle parent=\"Style1\" me=\"Style69\" /><GroupFooterStyle parent=\"Style1\" me=\"" +
				"Style68\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider>" +
				"<Height>15</Height><DCIdx>8</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingSt" +
				"yle parent=\"Style2\" me=\"Style38\" /><Style parent=\"Style1\" me=\"Style39\" /><Footer" +
				"Style parent=\"Style3\" me=\"Style40\" /><EditorStyle parent=\"Style5\" me=\"Style41\" /" +
				"><GroupHeaderStyle parent=\"Style1\" me=\"Style67\" /><GroupFooterStyle parent=\"Styl" +
				"e1\" me=\"Style66\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</Column" +
				"Divider><Height>15</Height><DCIdx>7</DCIdx></C1DisplayColumn></internalCols></C1" +
				".Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /" +
				"><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><St" +
				"yle parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Sty" +
				"le parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /><Style p" +
				"arent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style " +
				"parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Sty" +
				"le parent=\"Normal\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 476, 204</Clien" +
				"tArea><PrintPageHeaderStyle parent=\"\" me=\"Style50\" /><PrintPageFooterStyle paren" +
				"t=\"\" me=\"Style51\" /></Blob>";
			// 
			// dsContacts1
			// 
			this.dsContacts1.DataSetName = "DsContacts";
			this.dsContacts1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsContacts1.Namespace = "http://www.tempuri.org/DsContacts.xsd";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Contacts", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
																																																					new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																					new System.Data.Common.DataColumnMapping("CustType", "CustType"),
																																																					new System.Data.Common.DataColumnMapping("ContactType", "ContactType"),
																																																					new System.Data.Common.DataColumnMapping("Callback", "Callback"),
																																																					new System.Data.Common.DataColumnMapping("ContactDate", "ContactDate"),
																																																					new System.Data.Common.DataColumnMapping("UserCode", "UserCode"),
																																																					new System.Data.Common.DataColumnMapping("Expr1", "Expr1")})});
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Customer.FirstName, Customer.LastName, Customer.CustType, Contacts.Cont" +
				"actType, Contacts.Callback, Contacts.ContactDate, Contacts.UserCode, Customer.U" +
				"serCode AS Expr1 FROM Contacts INNER JOIN Customer ON Contacts.UserCode = Custo" +
				"mer.UserCode";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection2;
			// 
			// oleDbConnection2
			// 
			this.oleDbConnection2.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// c1TrueDBDropdown1
			// 
			this.c1TrueDBDropdown1.AllowColMove = true;
			this.c1TrueDBDropdown1.AllowColSelect = true;
			this.c1TrueDBDropdown1.AllowRowSizing = C1.Win.TrueDBGrid.RowSizingEnum.AllRows;
			this.c1TrueDBDropdown1.AlternatingRows = false;
			this.c1TrueDBDropdown1.CaptionHeight = 17;
			this.c1TrueDBDropdown1.ColumnCaptionHeight = 17;
			this.c1TrueDBDropdown1.ColumnFooterHeight = 17;
			this.c1TrueDBDropdown1.DataMember = "CustType";
			this.c1TrueDBDropdown1.DataSource = this.dsCustType1;
			this.c1TrueDBDropdown1.FetchRowStyles = false;
			this.c1TrueDBDropdown1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images1"))));
			this.c1TrueDBDropdown1.LayoutFileName = "";
			this.c1TrueDBDropdown1.LayoutName = "";
			this.c1TrueDBDropdown1.LayoutURL = "";
			this.c1TrueDBDropdown1.DisplayMember = "CustType.TypeId";
			this.c1TrueDBDropdown1.Location = new System.Drawing.Point(272, 56);
			this.c1TrueDBDropdown1.Name = "c1TrueDBDropdown1";
			this.c1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1TrueDBDropdown1.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.Single;
			this.c1TrueDBDropdown1.RowHeight = 15;
			this.c1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1TrueDBDropdown1.ScrollTips = false;
			this.c1TrueDBDropdown1.Size = new System.Drawing.Size(192, 136);
			this.c1TrueDBDropdown1.TabIndex = 1;
			this.c1TrueDBDropdown1.Text = "c1TrueDBDropdown1";
			this.c1TrueDBDropdown1.Visible = false;
			this.c1TrueDBDropdown1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"TypeDesc\" D" +
				"ataField=\"TypeDesc\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Leve" +
				"l=\"0\" Caption=\"TypeId\" DataField=\"TypeId\"><ValueItems /><GroupInfo /></C1DataCol" +
				"umn></DataCols><Styles type=\"C1.Win.TrueDBGrid.Design.ContextWrapper\"><Data>Ca" +
				"ption{AlignHorz:Center;}Normal{}Style25{}Selected{ForeColor:HighlightText;BackCo" +
				"lor:Highlight;}Editor{}Style18{AlignHorz:Near;}Style19{AlignHorz:Near;}Style14{A" +
				"lignHorz:Near;}Style15{AlignHorz:Near;}Style16{}Style17{}Style10{AlignHorz:Near;" +
				"}Style11{}OddRow{}Style13{}Style12{}Footer{}HighlightRow{ForeColor:HighlightText" +
				";BackColor:Highlight;}RecordSelector{AlignImage:Center;}Style24{}Style23{}Style2" +
				"2{}Style21{}Style20{}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCa" +
				"ption;}EvenRow{BackColor:Aqua;}Heading{Wrap:True;BackColor:Control;Border:Raised" +
				",,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}FilterBar{}Style4{}Style9{}" +
				"Style8{}Style5{}Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:Control" +
				"Dark;}Style7{}Style6{}Style1{}Style3{}Style2{}</Data></Styles><Splits><C1.Win.C1" +
				"TrueDBGrid.DropdownView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" Colu" +
				"mnFooterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"16\" Rec" +
				"ordSelectors=\"False\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRe" +
				"ct>0, 0, 188, 132</ClientRect><internalCols><C1DropDisplayColumn><DCIdx>0</DCIdx" +
				"><HeadingStyle parent=\"Style2\" me=\"Style14\" /><Style parent=\"Style1\" me=\"Style15" +
				"\" /><FooterStyle parent=\"Style3\" me=\"Style16\" /><EditorStyle parent=\"Style5\" me=" +
				"\"Style17\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style23\" /><GroupFooterStyle p" +
				"arent=\"Style1\" me=\"Style22\" /><Visible>True</Visible><ColumnDivider>DarkGray,Sin" +
				"gle</ColumnDivider><Height>15</Height></C1DropDisplayColumn><C1DropDisplayColumn" +
				"><DCIdx>1</DCIdx><HeadingStyle parent=\"Style2\" me=\"Style18\" /><Style parent=\"Sty" +
				"le1\" me=\"Style19\" /><FooterStyle parent=\"Style3\" me=\"Style20\" /><EditorStyle par" +
				"ent=\"Style5\" me=\"Style21\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style25\" /><Gr" +
				"oupFooterStyle parent=\"Style1\" me=\"Style24\" /><Visible>True</Visible><ColumnDivi" +
				"der>DarkGray,Single</ColumnDivider><Height>15</Height></C1DropDisplayColumn></in" +
				"ternalCols><CaptionStyle parent=\"Style2\" me=\"Style10\" /><EditorStyle parent=\"Edi" +
				"tor\" me=\"Style5\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style8\" /><FilterBarStyle " +
				"parent=\"FilterBar\" me=\"Style13\" /><FooterStyle parent=\"Footer\" me=\"Style3\" /><Gr" +
				"oupStyle parent=\"Group\" me=\"Style12\" /><HeadingStyle parent=\"Heading\" me=\"Style2" +
				"\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style7\" /><InactiveStyle parent" +
				"=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style9\" /><RecordSele" +
				"ctorStyle parent=\"RecordSelector\" me=\"Style11\" /><SelectedStyle parent=\"Selected" +
				"\" me=\"Style6\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.TrueDBGrid.Dropd" +
				"ownView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Norm" +
				"al\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\"" +
				" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" m" +
				"e=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /><Style parent=\"Normal\" me=\"H" +
				"ighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"" +
				"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Normal\" m" +
				"e=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1" +
				"</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWi" +
				"dth>17</DefaultRecSelWidth><ClientArea>0, 0, 188, 132</ClientArea></Blob>";
			// 
			// dsCustType1
			// 
			this.dsCustType1.DataSetName = "DsCustType";
			this.dsCustType1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsCustType1.Namespace = "http://www.tempuri.org/DsCustType.xsd";
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
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection2;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeId", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeId", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeDesc", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeDesc1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO CustType(TypeDesc, TypeId) VALUES (?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection2;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeDesc", System.Data.OleDb.OleDbType.VarWChar, 15, "TypeDesc"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeId", System.Data.OleDb.OleDbType.VarWChar, 1, "TypeId"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT TypeDesc, TypeId FROM CustType";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection2;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE CustType SET TypeDesc = ?, TypeId = ? WHERE (TypeId = ?) AND (TypeDesc = ?" +
				" OR ? IS NULL AND TypeDesc IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection2;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeDesc", System.Data.OleDb.OleDbType.VarWChar, 15, "TypeDesc"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeId", System.Data.OleDb.OleDbType.VarWChar, 1, "TypeId"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeId", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeId", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeDesc", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeDesc1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeDesc", System.Data.DataRowVersion.Original, null));
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(504, 222);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1TrueDBDropdown1,
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Form1";
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
				this.oleDbConnection2.ConnectionString = GetModifiedConnectionString(this.oleDbConnection2.ConnectionString);
				this.oleDbDataAdapter1.Fill(this.dsContacts1);
				dtCopy = this.dsContacts1.Tables[0].Copy();
			
				this.oleDbDataAdapter2.Fill(this.dsCustType1);
				this.c1TrueDBGrid1.Columns["CustType"].DropDown = this.c1TrueDBDropdown1;
			}
			catch (System.Exception eLoad) 
			{ 
				MessageBox.Show(eLoad.Message); 
			}
		}
		private void c1TrueDBGrid1_UnboundColumnFetch(object sender, C1.Win.TrueDBGrid.UnboundColumnFetchEventArgs e)
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
