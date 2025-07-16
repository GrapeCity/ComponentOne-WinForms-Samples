using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutor3
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private Tutor3.DsMasterDetail dsMasterDetail1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
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

			this.dsMasterDetail1 = new Tutor3.DsMasterDetail();
			this.c1TrueDBGrid2 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsMasterDetail1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).BeginInit();
			this.SuspendLayout();
			// 
			// c1TrueDBGrid1
			// 
			this.c1TrueDBGrid1.Caption = "C1TrueDBGrid.Net";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.DataMember = "Composer";
			this.c1TrueDBGrid1.DataSource = this.dsMasterDetail1;
			this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images"))));
			this.c1TrueDBGrid1.Location = new System.Drawing.Point(8, 40);
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
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(488, 152);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Birth\" Data" +
				"Field=\"Birth\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" " +
				"Caption=\"Country\" DataField=\"Country\"><ValueItems /><GroupInfo /></C1DataColumn>" +
				"<C1DataColumn Level=\"0\" Caption=\"Death\" DataField=\"Death\"><ValueItems /><GroupIn" +
				"fo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"First\" DataField=\"First\"><V" +
				"alueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"Last\" D" +
				"ataField=\"Last\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"1" +
				"\" Caption=\"Last\" DataField=\"Last\"><ValueItems /><GroupInfo /></C1DataColumn><C1D" +
				"ataColumn Level=\"1\" Caption=\"Opus\" DataField=\"Opus\"><ValueItems /><GroupInfo /><" +
				"/C1DataColumn></DataCols><Styles type=\"C1.Win.TrueDBGrid.Design.ContextWrapper" +
				"\"><Data>Style108{}Style109{}HighlightRow{ForeColor:HighlightText;BackColor:Highl" +
				"ight;}Style104{}Style105{}Style106{AlignHorz:Near;}Style107{AlignHorz:Near;}Styl" +
				"e100{AlignHorz:Near;}Style101{AlignHorz:Near;}Normal{Font:Tahoma, 11world;}Style" +
				"103{}Selected{ForeColor:HighlightText;BackColor:Highlight;}Editor{}Style94{Align" +
				"Horz:Far;}Style110{}Style96{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}" +
				"Caption{AlignHorz:Center;}Style98{}Style34{}Style35{}Style85{}Style84{}Style87{}" +
				"Style86{}Style83{AlignHorz:Far;}Style82{AlignHorz:Far;}RecordSelector{AlignImage" +
				":Center;}Footer{}Style89{AlignHorz:Near;}Style88{AlignHorz:Near;}Style102{}Inact" +
				"ive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}EvenRow{BackColor:A" +
				"qua;}OddRow{}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeC" +
				"olor:ControlText;AlignVert:Center;}Style91{}Style97{}Style90{}FilterBar{}Style95" +
				"{AlignHorz:Far;}Style111{}Style4{}Style9{}Style8{}Style92{}Style93{}Style5{}Grou" +
				"p{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style7{}Style6" +
				"{}Style1{}Style99{}Style3{}Style2{}</Data></Styles><Splits><C1.Win.TrueDBGrid." +
				"MergeView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight" +
				"=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecSelWidth=\"1" +
				"7\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 17, 484, 131" +
				"</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=\"Style2\" me=\"Style10" +
				"\" /><EditorStyle parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=\"EvenRow\" me" +
				"=\"Style8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><FooterStyle paren" +
				"t=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><HeadingStyle" +
				" parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Sty" +
				"le7\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRo" +
				"w\" me=\"Style9\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" /><Se" +
				"lectedStyle parent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" me=\"Style1\" /" +
				"><internalCols><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style100\" /><S" +
				"tyle parent=\"Style1\" me=\"Style101\" /><FooterStyle parent=\"Style3\" me=\"Style102\" " +
				"/><EditorStyle parent=\"Style5\" me=\"Style103\" /><GroupHeaderStyle parent=\"Style1\"" +
				" me=\"Style105\" /><GroupFooterStyle parent=\"Style1\" me=\"Style104\" /><Visible>True" +
				"</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Width>102</Width><Heigh" +
				"t>15</Height><DCIdx>3</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle pa" +
				"rent=\"Style2\" me=\"Style106\" /><Style parent=\"Style1\" me=\"Style107\" /><FooterStyl" +
				"e parent=\"Style3\" me=\"Style108\" /><EditorStyle parent=\"Style5\" me=\"Style109\" /><" +
				"GroupHeaderStyle parent=\"Style1\" me=\"Style111\" /><GroupFooterStyle parent=\"Style" +
				"1\" me=\"Style110\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</Column" +
				"Divider><Width>102</Width><Height>15</Height><DCIdx>4</DCIdx></C1DisplayColumn><" +
				"C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style88\" /><Style parent=\"Styl" +
				"e1\" me=\"Style89\" /><FooterStyle parent=\"Style3\" me=\"Style90\" /><EditorStyle pare" +
				"nt=\"Style5\" me=\"Style91\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style93\" /><Gro" +
				"upFooterStyle parent=\"Style1\" me=\"Style92\" /><Visible>True</Visible><ColumnDivid" +
				"er>DarkGray,Single</ColumnDivider><Width>102</Width><Height>15</Height><DCIdx>1<" +
				"/DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Styl" +
				"e82\" /><Style parent=\"Style1\" me=\"Style83\" /><FooterStyle parent=\"Style3\" me=\"St" +
				"yle84\" /><EditorStyle parent=\"Style5\" me=\"Style85\" /><GroupHeaderStyle parent=\"S" +
				"tyle1\" me=\"Style87\" /><GroupFooterStyle parent=\"Style1\" me=\"Style86\" /><Visible>" +
				"True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Width>102</Width><H" +
				"eight>15</Height><DCIdx>0</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyl" +
				"e parent=\"Style2\" me=\"Style94\" /><Style parent=\"Style1\" me=\"Style95\" /><FooterSt" +
				"yle parent=\"Style3\" me=\"Style96\" /><EditorStyle parent=\"Style5\" me=\"Style97\" /><" +
				"GroupHeaderStyle parent=\"Style1\" me=\"Style99\" /><GroupFooterStyle parent=\"Style1" +
				"\" me=\"Style98\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDi" +
				"vider><Width>102</Width><Height>15</Height><DCIdx>2</DCIdx></C1DisplayColumn></i" +
				"nternalCols></C1.Win.TrueDBGrid.MergeView></Splits><NamedStyles><Style parent=" +
				"\"\" me=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" m" +
				"e=\"Footer\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"" +
				"Inactive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Ed" +
				"itor\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"Ev" +
				"enRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Record" +
				"Selector\" /><Style parent=\"Normal\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"" +
				"Group\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layo" +
				"ut>Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0," +
				" 484, 148</ClientArea><PrintPageHeaderStyle parent=\"\" me=\"Style34\" /><PrintPageF" +
				"ooterStyle parent=\"\" me=\"Style35\" /></Blob>";
			// 
			// dsMasterDetail1
			// 
			this.dsMasterDetail1.DataSetName = "DsMasterDetail";
			this.dsMasterDetail1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsMasterDetail1.Namespace = "http://www.tempuri.org/DsMasterDetail.xsd";
			// 
			// c1TrueDBGrid2
			// 
			this.c1TrueDBGrid2.CaptionHeight = 17;
			this.c1TrueDBGrid2.DataMember = "Composer.ComposerOpus";
			this.c1TrueDBGrid2.DataSource = this.dsMasterDetail1;
			this.c1TrueDBGrid2.GroupByCaption = "Drag a column header here to group by that column";
			this.c1TrueDBGrid2.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images1"))));
			this.c1TrueDBGrid2.Location = new System.Drawing.Point(8, 240);
			this.c1TrueDBGrid2.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.DottedCellBorder;
			this.c1TrueDBGrid2.Name = "c1TrueDBGrid2";
			this.c1TrueDBGrid2.PreviewInfo.Location = new System.Drawing.Point(0, 0);
			this.c1TrueDBGrid2.PreviewInfo.Size = new System.Drawing.Size(0, 0);
			this.c1TrueDBGrid2.PreviewInfo.ZoomFactor = 75;
			this.c1TrueDBGrid2.RecordSelectorWidth = 17;
			this.c1TrueDBGrid2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1TrueDBGrid2.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.Single;
			this.c1TrueDBGrid2.RowHeight = 15;
			this.c1TrueDBGrid2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1TrueDBGrid2.Size = new System.Drawing.Size(480, 96);
			this.c1TrueDBGrid2.TabIndex = 1;
			this.c1TrueDBGrid2.Text = "c1TrueDBGrid2";
			this.c1TrueDBGrid2.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Last\" DataF" +
				"ield=\"Last\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Ca" +
				"ption=\"Opus\" DataField=\"Opus\"><ValueItems /><GroupInfo /></C1DataColumn></DataCo" +
				"ls><Styles type=\"C1.Win.TrueDBGrid.Design.ContextWrapper\"><Data>HighlightRow{F" +
				"oreColor:HighlightText;BackColor:Highlight;}Caption{AlignHorz:Center;}Normal{Fon" +
				"t:Tahoma, 11world;}Style25{}Selected{ForeColor:HighlightText;BackColor:Highlight" +
				";}Editor{}Style18{AlignHorz:Near;}Style19{AlignHorz:Near;}Style14{AlignHorz:Near" +
				";}Style15{AlignHorz:Near;}Style16{}Style17{}Style10{AlignHorz:Near;}Style11{}Odd" +
				"Row{}Style13{}Footer{}Style27{}Style26{}RecordSelector{AlignImage:Center;}Style2" +
				"4{}Style23{}Style22{}Style21{}Style20{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}EvenRow{BackColor:Aqua;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}FilterBar" +
				"{}Style5{}Style4{}Style9{}Style8{}Style12{}Group{AlignVert:Center;Border:None,,0" +
				", 0, 0, 0;BackColor:ControlDark;}Style7{}Style6{}Style1{}Style3{}Style2{}</Data>" +
				"</Styles><Splits><C1.Win.TrueDBGrid.MergeView Name=\"\" CaptionHeight=\"17\" Colum" +
				"nCaptionHeight=\"17\" ColumnFooterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" Reco" +
				"rdSelectorWidth=\"17\" DefRecSelWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrol" +
				"lGroup=\"1\"><ClientRect>0, 0, 476, 92</ClientRect><BorderSide>0</BorderSide><Capt" +
				"ionStyle parent=\"Style2\" me=\"Style10\" /><EditorStyle parent=\"Editor\" me=\"Style5\"" +
				" /><EvenRowStyle parent=\"EvenRow\" me=\"Style8\" /><FilterBarStyle parent=\"FilterBa" +
				"r\" me=\"Style13\" /><FooterStyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=" +
				"\"Group\" me=\"Style12\" /><HeadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRo" +
				"wStyle parent=\"HighlightRow\" me=\"Style7\" /><InactiveStyle parent=\"Inactive\" me=\"" +
				"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style9\" /><RecordSelectorStyle parent" +
				"=\"RecordSelector\" me=\"Style11\" /><SelectedStyle parent=\"Selected\" me=\"Style6\" />" +
				"<Style parent=\"Normal\" me=\"Style1\" /><internalCols><C1DisplayColumn><HeadingStyl" +
				"e parent=\"Style2\" me=\"Style14\" /><Style parent=\"Style1\" me=\"Style15\" /><FooterSt" +
				"yle parent=\"Style3\" me=\"Style16\" /><EditorStyle parent=\"Style5\" me=\"Style17\" /><" +
				"GroupHeaderStyle parent=\"Style1\" me=\"Style25\" /><GroupFooterStyle parent=\"Style1" +
				"\" me=\"Style24\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDi" +
				"vider><Width>83</Width><Height>15</Height><DCIdx>0</DCIdx></C1DisplayColumn><C1D" +
				"isplayColumn><HeadingStyle parent=\"Style2\" me=\"Style18\" /><Style parent=\"Style1\"" +
				" me=\"Style19\" /><FooterStyle parent=\"Style3\" me=\"Style20\" /><EditorStyle parent=" +
				"\"Style5\" me=\"Style21\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style27\" /><GroupF" +
				"ooterStyle parent=\"Style1\" me=\"Style26\" /><Visible>True</Visible><ColumnDivider>" +
				"DarkGray,Single</ColumnDivider><Width>373</Width><Height>15</Height><DCIdx>1</DC" +
				"Idx></C1DisplayColumn></internalCols></C1.Win.TrueDBGrid.MergeView></Splits><N" +
				"amedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" />" +
				"<Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=\"Caption\" /><St" +
				"yle parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"Selected\" /><Sty" +
				"le parent=\"Normal\" me=\"Editor\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Sty" +
				"le parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pa" +
				"rent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Normal\" me=\"FilterBar\" /><St" +
				"yle parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1</vertSplits><horzS" +
				"plits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</DefaultRecS" +
				"elWidth><ClientArea>0, 0, 476, 92</ClientArea><PrintPageHeaderStyle parent=\"\" me" +
				"=\"Style22\" /><PrintPageFooterStyle parent=\"\" me=\"Style23\" /></Blob>";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Composer", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("Birth", "Birth"),
																																																					new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																					new System.Data.Common.DataColumnMapping("Death", "Death"),
																																																					new System.Data.Common.DataColumnMapping("First", "First"),
																																																					new System.Data.Common.DataColumnMapping("Last", "Last")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Composer WHERE (Last = ?) AND (Birth = ? OR ? IS NULL AND Birth IS NU" +
				"LL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Death = ? OR ? IS NU" +
				"LL AND Death IS NULL) AND (First = ? OR ? IS NULL AND First IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Last", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Last", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Birth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Birth", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Birth1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Birth", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Death", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Death", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Death1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Death", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_First", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "First", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_First1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "First", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Composer(Birth, Country, Death, First, Last) VALUES (?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Birth", System.Data.OleDb.OleDbType.DBDate, 0, "Birth"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Death", System.Data.OleDb.OleDbType.DBDate, 0, "Death"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("First", System.Data.OleDb.OleDbType.VarWChar, 50, "First"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Birth, Country, Death, First, Last FROM Composer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE Composer SET Birth = ?, Country = ?, Death = ?, First = ?, Last = ? WHERE (Last = ?) AND (Birth = ? OR ? IS NULL AND Birth IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Death = ? OR ? IS NULL AND Death IS NULL) AND (First = ? OR ? IS NULL AND First IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Birth", System.Data.OleDb.OleDbType.DBDate, 0, "Birth"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Death", System.Data.OleDb.OleDbType.DBDate, 0, "Death"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("First", System.Data.OleDb.OleDbType.VarWChar, 50, "First"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Last", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Last", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Birth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Birth", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Birth1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Birth", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Death", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Death", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Death1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Death", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_First", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "First", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_First1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "First", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Opus", new System.Data.Common.DataColumnMapping[] {
																																																				new System.Data.Common.DataColumnMapping("Last", "Last"),
																																																				new System.Data.Common.DataColumnMapping("Opus", "Opus")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = "DELETE FROM Opus WHERE (Last = ?) AND (Opus = ?)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Last", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Last", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Opus", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Opus", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Opus(Last, Opus) VALUES (?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Opus", System.Data.OleDb.OleDbType.VarWChar, 150, "Opus"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Last, Opus FROM Opus";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = "UPDATE Opus SET Last = ?, Opus = ? WHERE (Last = ?) AND (Opus = ?)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Opus", System.Data.OleDb.OleDbType.VarWChar, 150, "Opus"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Last", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Last", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Opus", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Opus", System.Data.DataRowVersion.Original, null));
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 2;
			this.label1.Text = "Composers:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 208);
			this.label2.Name = "label2";
			this.label2.TabIndex = 3;
			this.label2.Text = "Their Works:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 358);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.label1,
																		  this.c1TrueDBGrid2,
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial 03";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsMasterDetail1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).EndInit();
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
                this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);
				this.oleDbDataAdapter1.Fill(this.dsMasterDetail1); 
				this.oleDbDataAdapter2.Fill(this.dsMasterDetail1); 
			} 
			catch (System.Exception eLoad) 
			{
				MessageBox.Show(eLoad.Message);
			}
		}
		private string GetModifiedConnectionString(string connstring)
		{
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
		}
	}
}
