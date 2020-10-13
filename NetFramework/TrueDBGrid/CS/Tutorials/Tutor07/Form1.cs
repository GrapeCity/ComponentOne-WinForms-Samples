using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial07
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Tutorial07.DsContacts dsContacts1;
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

			this.dsContacts1 = new Tutorial07.DsContacts();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1TrueDBGrid1
			// 
			this.c1TrueDBGrid1.Caption = "C1TrueDBGrid.Net";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.DataMember = "Contacts";
			this.c1TrueDBGrid1.DataSource = this.dsContacts1;
			this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images"))));
			this.c1TrueDBGrid1.Location = new System.Drawing.Point(24, 24);
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
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(528, 128);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.UnboundColumnFetch += new C1.Win.C1TrueDBGrid.UnboundColumnFetchEventHandler(this.c1TrueDBGrid1_UnboundColumnFetch);
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Name\" DataF" +
				"ield=\"\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Captio" +
				"n=\"FirstName\" DataField=\"FirstName\"><ValueItems /><GroupInfo /></C1DataColumn><C" +
				"1DataColumn Level=\"0\" Caption=\"LastName\" DataField=\"LastName\"><ValueItems /><Gro" +
				"upInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"CustType\" DataField=\"Cu" +
				"stType\"><ValueItems Presentation=\"ComboBox\" Translate=\"True\"><internalValues><Va" +
				"lueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"1\" dispVal=\"Prospective\" /><" +
				"ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"2\" dispVal=\"Normal\" /><Val" +
				"ueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"3\" dispVal=\"Buyer\" /><ValueIt" +
				"em type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"4\" dispVal=\"Distributor\" /><Value" +
				"Item type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"5\" dispVal=\"Other\" /></internal" +
				"Values></ValueItems><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=" +
				"\"ContactType\" DataField=\"ContactType\"><ValueItems /><GroupInfo /></C1DataColumn>" +
				"<C1DataColumn Level=\"0\" Caption=\"Callback\" DataField=\"Callback\"><ValueItems /><G" +
				"roupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"ContactDate\" DataFiel" +
				"d=\"ContactDate\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0" +
				"\" Caption=\"UserCode\" DataField=\"UserCode\"><ValueItems /><GroupInfo /></C1DataCol" +
				"umn><C1DataColumn Level=\"0\" Caption=\"Expr1\" DataField=\"Expr1\"><ValueItems Presen" +
				"tation=\"ComboBox\" Translate=\"True\"><internalValues><ValueItem type=\"C1.Win.C1Tru" +
				"eDBGrid.ValueItem\" Value=\"1\" dispVal=\"Prospective\" /><ValueItem type=\"C1.Win.C1T" +
				"rueDBGrid.ValueItem\" Value=\"2\" dispVal=\"Normal\" /><ValueItem type=\"C1.Win.C1True" +
				"DBGrid.ValueItem\" Value=\"3\" dispVal=\"Buyer\" /><ValueItem type=\"C1.Win.C1TrueDBGr" +
				"id.ValueItem\" Value=\"4\" dispVal=\"Distributor\" /><ValueItem type=\"C1.Win.C1TrueDB" +
				"Grid.ValueItem\" Value=\"5\" dispVal=\"Other\" /></internalValues></ValueItems><Group" +
				"Info /></C1DataColumn></DataCols><Styles type=\"C1.Win.C1TrueDBGrid.Design.Contex" +
				"tWrapper\"><Data>HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Inacti" +
				"ve{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}Selected{ForeColor:H" +
				"ighlightText;BackColor:Highlight;}Editor{}FilterBar{}Heading{Wrap:True;AlignVert" +
				":Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style" +
				"18{AlignHorz:Near;}Style19{AlignHorz:Near;}Style14{AlignHorz:Near;}Style15{Align" +
				"Horz:Near;}Style16{}Style17{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}" +
				"Style27{AlignHorz:Far;}Style29{}Style28{}Style26{AlignHorz:Far;}Style25{}Style9{" +
				"}Style8{}Style24{}Style23{AlignHorz:Far;}Style5{}Style4{}Style7{}Style6{}Style1{" +
				"}Style22{AlignHorz:Far;}Style3{}Style2{}Style21{}Style20{}OddRow{}Style38{AlignH" +
				"orz:Near;}Style39{AlignHorz:Near;}Style36{}Style37{}Style34{AlignHorz:Far;}Style" +
				"35{AlignHorz:Far;}Style32{}Style33{}Style30{AlignHorz:Center;}Style49{}Style48{}" +
				"Style31{AlignHorz:Center;}Normal{}Style41{}Style40{}Style43{AlignHorz:Near;}Styl" +
				"e42{AlignHorz:Near;}Style45{}Style44{}Style47{AlignHorz:Near;}Style46{AlignHorz:" +
				"Near;}EvenRow{BackColor:Aqua;}Style59{}Style58{}RecordSelector{AlignImage:Center" +
				";}Style51{}Style50{}Footer{}Style52{}Style53{}Style54{}Style55{}Style56{}Style57" +
				"{}Caption{AlignHorz:Center;}Style69{}Style68{}Style63{}Style62{}Style61{}Style60" +
				"{}Style67{}Style66{}Style65{}Style64{}Group{BackColor:ControlDark;Border:None,,0" +
				", 0, 0, 0;AlignVert:Center;}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeVi" +
				"ew Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"17\" M" +
				"arqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecSelWidth=\"17\" Vert" +
				"icalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 17, 524, 107</Clien" +
				"tRect><BorderSide>0</BorderSide><CaptionStyle parent=\"Style2\" me=\"Style10\" /><Ed" +
				"itorStyle parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style" +
				"8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style7\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style9\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" me=\"Style1\" /><inter" +
				"nalCols><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style46\" /><Style par" +
				"ent=\"Style1\" me=\"Style47\" /><FooterStyle parent=\"Style3\" me=\"Style48\" /><EditorS" +
				"tyle parent=\"Style5\" me=\"Style49\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style5" +
				"3\" /><GroupFooterStyle parent=\"Style1\" me=\"Style52\" /><Visible>True</Visible><Co" +
				"lumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>0</DCIdx></" +
				"C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style14\" /><S" +
				"tyle parent=\"Style1\" me=\"Style15\" /><FooterStyle parent=\"Style3\" me=\"Style16\" />" +
				"<EditorStyle parent=\"Style5\" me=\"Style17\" /><GroupHeaderStyle parent=\"Style1\" me" +
				"=\"Style55\" /><GroupFooterStyle parent=\"Style1\" me=\"Style54\" /><ColumnDivider>Dar" +
				"kGray,Single</ColumnDivider><Height>15</Height><DCIdx>1</DCIdx></C1DisplayColumn" +
				"><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style18\" /><Style parent=\"St" +
				"yle1\" me=\"Style19\" /><FooterStyle parent=\"Style3\" me=\"Style20\" /><EditorStyle pa" +
				"rent=\"Style5\" me=\"Style21\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style57\" /><G" +
				"roupFooterStyle parent=\"Style1\" me=\"Style56\" /><ColumnDivider>DarkGray,Single</C" +
				"olumnDivider><Height>15</Height><DCIdx>2</DCIdx></C1DisplayColumn><C1DisplayColu" +
				"mn><HeadingStyle parent=\"Style2\" me=\"Style22\" /><Style parent=\"Style1\" me=\"Style" +
				"23\" /><FooterStyle parent=\"Style3\" me=\"Style24\" /><EditorStyle parent=\"Style5\" m" +
				"e=\"Style25\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style59\" /><GroupFooterStyle" +
				" parent=\"Style1\" me=\"Style58\" /><Visible>True</Visible><ColumnDivider>DarkGray,S" +
				"ingle</ColumnDivider><Height>15</Height><Button>True</Button><DCIdx>3</DCIdx></C" +
				"1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style26\" /><St" +
				"yle parent=\"Style1\" me=\"Style27\" /><FooterStyle parent=\"Style3\" me=\"Style28\" /><" +
				"EditorStyle parent=\"Style5\" me=\"Style29\" /><GroupHeaderStyle parent=\"Style1\" me=" +
				"\"Style61\" /><GroupFooterStyle parent=\"Style1\" me=\"Style60\" /><Visible>True</Visi" +
				"ble><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>4</D" +
				"CIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style3" +
				"0\" /><Style parent=\"Style1\" me=\"Style31\" /><FooterStyle parent=\"Style3\" me=\"Styl" +
				"e32\" /><EditorStyle parent=\"Style5\" me=\"Style33\" /><GroupHeaderStyle parent=\"Sty" +
				"le1\" me=\"Style63\" /><GroupFooterStyle parent=\"Style1\" me=\"Style62\" /><Visible>Tr" +
				"ue</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DC" +
				"Idx>5</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me" +
				"=\"Style34\" /><Style parent=\"Style1\" me=\"Style35\" /><FooterStyle parent=\"Style3\" " +
				"me=\"Style36\" /><EditorStyle parent=\"Style5\" me=\"Style37\" /><GroupHeaderStyle par" +
				"ent=\"Style1\" me=\"Style65\" /><GroupFooterStyle parent=\"Style1\" me=\"Style64\" /><Vi" +
				"sible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</He" +
				"ight><DCIdx>6</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"St" +
				"yle2\" me=\"Style38\" /><Style parent=\"Style1\" me=\"Style39\" /><FooterStyle parent=\"" +
				"Style3\" me=\"Style40\" /><EditorStyle parent=\"Style5\" me=\"Style41\" /><GroupHeaderS" +
				"tyle parent=\"Style1\" me=\"Style67\" /><GroupFooterStyle parent=\"Style1\" me=\"Style6" +
				"6\" /><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>7</" +
				"DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style" +
				"42\" /><Style parent=\"Style1\" me=\"Style43\" /><FooterStyle parent=\"Style3\" me=\"Sty" +
				"le44\" /><EditorStyle parent=\"Style5\" me=\"Style45\" /><GroupHeaderStyle parent=\"St" +
				"yle1\" me=\"Style69\" /><GroupFooterStyle parent=\"Style1\" me=\"Style68\" /><ColumnDiv" +
				"ider>DarkGray,Single</ColumnDivider><Height>15</Height><Button>True</Button><DCI" +
				"dx>8</DCIdx></C1DisplayColumn></internalCols></C1.Win.C1TrueDBGrid.MergeView></S" +
				"plits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" me=\"Hea" +
				"ding\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=\"Captio" +
				"n\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"Selected" +
				"\" /><Style parent=\"Normal\" me=\"Editor\" /><Style parent=\"Normal\" me=\"HighlightRow" +
				"\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><" +
				"Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Normal\" me=\"FilterBa" +
				"r\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1</vertSplit" +
				"s><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</Def" +
				"aultRecSelWidth><ClientArea>0, 0, 524, 124</ClientArea><PrintPageHeaderStyle par" +
				"ent=\"\" me=\"Style50\" /><PrintPageFooterStyle parent=\"\" me=\"Style51\" /></Blob>";
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
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=4;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 174);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial 07";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).EndInit();
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
			this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dsContacts1);
			dtCopy = this.dsContacts1.Tables[0].Copy();

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
