using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial12
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Tutorial12.DsContacts dsContacts1;
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
            this.dsContacts1 = new Tutorial12.DsContacts();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1TrueDBGrid1
			// 
			this.c1TrueDBGrid1.AllowAddNew = true;
			this.c1TrueDBGrid1.AlternatingRows = true;
			this.c1TrueDBGrid1.Caption = "C1True DBGrid .Net";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.DataMember = "Contacts";
			this.c1TrueDBGrid1.DataSource = this.dsContacts1;
			this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images"))));
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images1"))));
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images2"))));
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images3"))));
			this.c1TrueDBGrid1.Location = new System.Drawing.Point(8, 8);
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
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(624, 192);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.UnboundColumnFetch += new C1.Win.TrueDBGrid.UnboundColumnFetchEventHandler(this.c1TrueDBGrid1_UnboundColumnFetch);
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Name\" DataF" +
				"ield=\"\"><ValueItems CycleOnClick=\"True\" Translate=\"True\" /><GroupInfo /></C1Data" +
				"Column><C1DataColumn Level=\"0\" Caption=\"FirstName\" DataField=\"FirstName\"><ValueI" +
				"tems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"LastName\" Da" +
				"taField=\"LastName\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level" +
				"=\"0\" Caption=\"CustType\" DataField=\"CustType\"><ValueItems Presentation=\"ComboBox\"" +
				" Translate=\"True\"><internalValues><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem" +
				"\" Value=\"1\" dispVal=\"Prospective\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueIt" +
				"em\" Value=\"2\" dispVal=\"Normal\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\"" +
				" Value=\"3\" dispVal=\"Buyer\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Val" +
				"ue=\"4\" dispVal=\"Distributor\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" V" +
				"alue=\"5\" dispVal=\"Other\" /></internalValues></ValueItems><GroupInfo /></C1DataCo" +
				"lumn><C1DataColumn Level=\"0\" Caption=\"ContactType\" DataField=\"ContactType\"><Valu" +
				"eItems CycleOnClick=\"True\" Translate=\"True\"><internalValues><ValueItem type=\"C1." +
				"Win.C1TrueDBGrid.ValueItem\" Value=\"0\" ImgIdx=\"1\" /><ValueItem type=\"C1.Win.C1Tru" +
				"eDBGrid.ValueItem\" Value=\"1\" ImgIdx=\"2\" /><ValueItem type=\"C1.Win.TrueDBGrid.V" +
				"alueItem\" Value=\"2\" ImgIdx=\"3\" /></internalValues></ValueItems><GroupInfo /></C1" +
				"DataColumn><C1DataColumn Level=\"0\" Caption=\"Callback\" DataField=\"Callback\"><Valu" +
				"eItems CycleOnClick=\"True\" Presentation=\"CheckBox\" Translate=\"True\" /><GroupInfo" +
				" /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"ContactDate\" DataField=\"Conta" +
				"ctDate\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Captio" +
				"n=\"UserCode\" DataField=\"UserCode\"><ValueItems /><GroupInfo /></C1DataColumn><C1D" +
				"ataColumn Level=\"0\" Caption=\"Expr1\" DataField=\"Expr1\"><ValueItems Presentation=\"" +
				"ComboBox\" Translate=\"True\"><internalValues><ValueItem type=\"C1.Win.TrueDBGrid." +
				"ValueItem\" Value=\"1\" dispVal=\"Prospective\" /><ValueItem type=\"C1.Win.C1TrueDBGri" +
				"d.ValueItem\" Value=\"2\" dispVal=\"Normal\" /><ValueItem type=\"C1.Win.TrueDBGrid.V" +
				"alueItem\" Value=\"3\" dispVal=\"Buyer\" /><ValueItem type=\"C1.Win.TrueDBGrid.Value" +
				"Item\" Value=\"4\" dispVal=\"Distributor\" /><ValueItem type=\"C1.Win.TrueDBGrid.Val" +
				"ueItem\" Value=\"5\" dispVal=\"Other\" /></internalValues></ValueItems><GroupInfo /><" +
				"/C1DataColumn></DataCols><Styles type=\"C1.Win.TrueDBGrid.Design.ContextWrapper" +
				"\"><Data>HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Inactive{ForeC" +
				"olor:InactiveCaptionText;BackColor:InactiveCaption;}Selected{ForeColor:Highlight" +
				"Text;BackColor:Highlight;}Editor{}FilterBar{}Heading{Wrap:True;AlignVert:Center;" +
				"Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style18{Align" +
				"Horz:Near;}Style19{AlignHorz:Near;}Style14{AlignHorz:Near;}Style15{AlignHorz:Nea" +
				"r;}Style16{}Style17{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style27{" +
				"AlignHorz:Center;AlignVert:Center;}Style29{}Style28{}Style26{AlignHorz:Far;}Styl" +
				"e25{}Style9{}Style8{}Style24{}Style23{AlignHorz:Far;}Style5{}Style4{}Style7{}Sty" +
				"le6{}Style1{}Style22{AlignHorz:Far;}Style3{}Style2{}Style21{}Style20{}OddRow{}St" +
				"yle38{AlignHorz:Near;}Style39{AlignHorz:Near;}Style36{}Style37{}Style34{AlignHor" +
				"z:Far;}Style35{AlignHorz:Far;}Style32{}Style33{}Style30{AlignHorz:Center;}Style4" +
				"9{}Style48{}Style31{AlignHorz:Center;AlignVert:Center;}Normal{Font:Tahoma, 11wor" +
				"ld;}Style41{}Style40{}Style43{AlignHorz:Near;}Style42{AlignHorz:Near;}Style45{}S" +
				"tyle44{}Style47{AlignHorz:Near;}Style46{AlignHorz:Near;}EvenRow{BackColor:Aqua;}" +
				"Style59{}Style58{}RecordSelector{AlignImage:Center;}Style51{}Style50{}Footer{}St" +
				"yle52{}Style53{}Style54{}Style55{}Style56{}Style57{}Caption{AlignHorz:Center;}St" +
				"yle69{}Style68{}Style63{}Style62{}Style61{}Style60{}Style67{}Style66{}Style65{}S" +
				"tyle64{}Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}</" +
				"Data></Styles><Splits><C1.Win.TrueDBGrid.MergeView Name=\"\" AlternatingRowStyle" +
				"=\"True\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"17\" Marq" +
				"ueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecSelWidth=\"17\" Vertica" +
				"lScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 17, 620, 171</ClientRe" +
				"ct><BorderSide>0</BorderSide><CaptionStyle parent=\"Style2\" me=\"Style10\" /><Edito" +
				"rStyle parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style8\" " +
				"/><FilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><FooterStyle parent=\"Footer\"" +
				" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><HeadingStyle parent=\"H" +
				"eading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style7\" /><In" +
				"activeStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Sty" +
				"le9\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" /><SelectedStyl" +
				"e parent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" me=\"Style1\" /><internal" +
				"Cols><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style46\" /><Style parent" +
				"=\"Style1\" me=\"Style47\" /><FooterStyle parent=\"Style3\" me=\"Style48\" /><EditorStyl" +
				"e parent=\"Style5\" me=\"Style49\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style53\" " +
				"/><GroupFooterStyle parent=\"Style1\" me=\"Style52\" /><ColumnDivider>DarkGray,Singl" +
				"e</ColumnDivider><Height>15</Height><DCIdx>0</DCIdx></C1DisplayColumn><C1Display" +
				"Column><HeadingStyle parent=\"Style2\" me=\"Style14\" /><Style parent=\"Style1\" me=\"S" +
				"tyle15\" /><FooterStyle parent=\"Style3\" me=\"Style16\" /><EditorStyle parent=\"Style" +
				"5\" me=\"Style17\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style55\" /><GroupFooterS" +
				"tyle parent=\"Style1\" me=\"Style54\" /><Visible>True</Visible><ColumnDivider>DarkGr" +
				"ay,Single</ColumnDivider><Height>15</Height><DCIdx>1</DCIdx></C1DisplayColumn><C" +
				"1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style18\" /><Style parent=\"Style" +
				"1\" me=\"Style19\" /><FooterStyle parent=\"Style3\" me=\"Style20\" /><EditorStyle paren" +
				"t=\"Style5\" me=\"Style21\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style57\" /><Grou" +
				"pFooterStyle parent=\"Style1\" me=\"Style56\" /><Visible>True</Visible><ColumnDivide" +
				"r>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>2</DCIdx></C1DisplayC" +
				"olumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style22\" /><Style paren" +
				"t=\"Style1\" me=\"Style23\" /><FooterStyle parent=\"Style3\" me=\"Style24\" /><EditorSty" +
				"le parent=\"Style5\" me=\"Style25\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style59\"" +
				" /><GroupFooterStyle parent=\"Style1\" me=\"Style58\" /><Visible>True</Visible><Colu" +
				"mnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><Button>True</Button" +
				"><DCIdx>3</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2" +
				"\" me=\"Style30\" /><Style parent=\"Style1\" me=\"Style31\" /><FooterStyle parent=\"Styl" +
				"e3\" me=\"Style32\" /><EditorStyle parent=\"Style5\" me=\"Style33\" /><GroupHeaderStyle" +
				" parent=\"Style1\" me=\"Style63\" /><GroupFooterStyle parent=\"Style1\" me=\"Style62\" /" +
				"><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15" +
				"</Height><DCIdx>5</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent" +
				"=\"Style2\" me=\"Style26\" /><Style parent=\"Style1\" me=\"Style27\" /><FooterStyle pare" +
				"nt=\"Style3\" me=\"Style28\" /><EditorStyle parent=\"Style5\" me=\"Style29\" /><GroupHea" +
				"derStyle parent=\"Style1\" me=\"Style61\" /><GroupFooterStyle parent=\"Style1\" me=\"St" +
				"yle60\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><H" +
				"eight>15</Height><DCIdx>4</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyl" +
				"e parent=\"Style2\" me=\"Style34\" /><Style parent=\"Style1\" me=\"Style35\" /><FooterSt" +
				"yle parent=\"Style3\" me=\"Style36\" /><EditorStyle parent=\"Style5\" me=\"Style37\" /><" +
				"GroupHeaderStyle parent=\"Style1\" me=\"Style65\" /><GroupFooterStyle parent=\"Style1" +
				"\" me=\"Style64\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDi" +
				"vider><Height>15</Height><DCIdx>6</DCIdx></C1DisplayColumn><C1DisplayColumn><Hea" +
				"dingStyle parent=\"Style2\" me=\"Style42\" /><Style parent=\"Style1\" me=\"Style43\" /><" +
				"FooterStyle parent=\"Style3\" me=\"Style44\" /><EditorStyle parent=\"Style5\" me=\"Styl" +
				"e45\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style69\" /><GroupFooterStyle parent" +
				"=\"Style1\" me=\"Style68\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</" +
				"ColumnDivider><Height>15</Height><Button>True</Button><DCIdx>8</DCIdx></C1Displa" +
				"yColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style38\" /><Style par" +
				"ent=\"Style1\" me=\"Style39\" /><FooterStyle parent=\"Style3\" me=\"Style40\" /><EditorS" +
				"tyle parent=\"Style5\" me=\"Style41\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style6" +
				"7\" /><GroupFooterStyle parent=\"Style1\" me=\"Style66\" /><Visible>True</Visible><Co" +
				"lumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>7</DCIdx></" +
				"C1DisplayColumn></internalCols></C1.Win.TrueDBGrid.MergeView></Splits><NamedSt" +
				"yles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style" +
				" parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=\"Caption\" /><Style pa" +
				"rent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style par" +
				"ent=\"Normal\" me=\"Editor\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Normal\" me=\"FilterBar\" /><Style pa" +
				"rent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>" +
				"1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidt" +
				"h><ClientArea>0, 0, 620, 188</ClientArea><PrintPageHeaderStyle parent=\"\" me=\"Sty" +
				"le50\" /><PrintPageFooterStyle parent=\"\" me=\"Style51\" /></Blob>";
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
			this.ClientSize = new System.Drawing.Size(648, 213);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial 12";
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
