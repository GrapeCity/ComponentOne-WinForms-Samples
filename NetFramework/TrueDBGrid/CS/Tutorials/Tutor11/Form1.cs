using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial11
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
		private Tutorial11.DsContacts dsContacts1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
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
			this.dsContacts1 = new Tutorial11.DsContacts();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
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
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images1"))));
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images2"))));
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images3"))));
			this.c1TrueDBGrid1.Location = new System.Drawing.Point(8, 24);
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
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(560, 192);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.FetchRowStyle += new C1.Win.TrueDBGrid.FetchRowStyleEventHandler(this.C1TrueDBGrid1_FetchRowStyle);
			this.c1TrueDBGrid1.UnboundColumnFetch += new C1.Win.TrueDBGrid.UnboundColumnFetchEventHandler(this.c1TrueDBGrid1_UnboundColumnFetch);
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Customer Na" +
				"me\" DataField=\"\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"" +
				"0\" Caption=\"FirstName\" DataField=\"FirstName\"><ValueItems /><GroupInfo /></C1Data" +
				"Column><C1DataColumn Level=\"0\" Caption=\"LastName\" DataField=\"LastName\"><ValueIte" +
				"ms /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"CustType\" Data" +
				"Field=\"CustType\"><ValueItems Presentation=\"ComboBox\" Translate=\"True\"><internalV" +
				"alues><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"1\" dispVal=\"Prospec" +
				"tive\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"2\" dispVal=\"Norma" +
				"l\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"3\" dispVal=\"Buyer\" /" +
				"><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"4\" dispVal=\"Distributor\"" +
				" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"5\" dispVal=\"Other\" /><" +
				"/internalValues></ValueItems><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\"" +
				" Caption=\"ContactType\" DataField=\"ContactType\"><ValueItems CycleOnClick=\"True\" T" +
				"ranslate=\"True\"><internalValues><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" " +
				"Value=\"0\" ImgIdx=\"1\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"1\"" +
				" ImgIdx=\"2\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"2\" ImgIdx=\"" +
				"3\" /></internalValues></ValueItems><GroupInfo /></C1DataColumn><C1DataColumn Lev" +
				"el=\"0\" Caption=\"Callback\" DataField=\"Callback\"><ValueItems CycleOnClick=\"True\" P" +
				"resentation=\"CheckBox\" Translate=\"True\" /><GroupInfo /></C1DataColumn><C1DataCol" +
				"umn Level=\"0\" Caption=\"ContactDate\" DataField=\"ContactDate\"><ValueItems /><Group" +
				"Info /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"UserCode\" DataField=\"User" +
				"Code\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=" +
				"\"Expr1\" DataField=\"Expr1\"><ValueItems Presentation=\"ComboBox\" Translate=\"True\"><" +
				"internalValues><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"1\" dispVal" +
				"=\"Prospective\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"2\" dispV" +
				"al=\"Normal\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"3\" dispVal=" +
				"\"Buyer\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"4\" dispVal=\"Dis" +
				"tributor\" /><ValueItem type=\"C1.Win.TrueDBGrid.ValueItem\" Value=\"5\" dispVal=\"O" +
				"ther\" /></internalValues></ValueItems><GroupInfo /></C1DataColumn></DataCols><St" +
				"yles type=\"C1.Win.TrueDBGrid.Design.ContextWrapper\"><Data>HighlightRow{ForeCol" +
				"or:HighlightText;BackColor:Highlight;}Inactive{ForeColor:InactiveCaptionText;Bac" +
				"kColor:InactiveCaption;}Selected{ForeColor:HighlightText;BackColor:Highlight;}Ed" +
				"itor{}FilterBar{}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1, 1, 1;F" +
				"oreColor:ControlText;AlignVert:Center;}Style18{AlignHorz:Near;}Style19{AlignHorz" +
				":Near;}Style14{AlignHorz:Near;}Style15{AlignHorz:Near;}Style16{}Style17{}Style10" +
				"{AlignHorz:Near;}Style11{}Style12{}Style13{}Style27{AlignHorz:Center;AlignVert:C" +
				"enter;}Style29{}Style28{}Style26{AlignHorz:Far;}Style25{}Style9{}Style8{}Style24" +
				"{}Style23{AlignHorz:Far;}Style5{}Style4{}Style7{}Style6{}Style1{}Style22{AlignHo" +
				"rz:Far;}Style3{}Style2{}Style21{}Style20{}OddRow{}Style38{AlignHorz:Near;}Style3" +
				"9{AlignHorz:Near;}Style36{}Style37{}Style34{AlignHorz:Far;}Style35{AlignHorz:Far" +
				";}Style32{}Style33{}Style30{AlignHorz:Center;}Style49{}Style48{}Style31{AlignHor" +
				"z:Center;AlignVert:Center;}Normal{Font:Tahoma, 11world;}Style41{}Style40{}Style4" +
				"3{AlignHorz:Near;}Style42{AlignHorz:Near;}Style45{}Style44{}Style47{AlignHorz:Ne" +
				"ar;}Style46{AlignHorz:Near;}EvenRow{BackColor:Aqua;}Style59{}Style58{}RecordSele" +
				"ctor{AlignImage:Center;}Style51{}Style50{}Footer{}Style52{}Style53{}Style54{}Sty" +
				"le55{}Style56{}Style57{}Caption{AlignHorz:Center;}Style69{}Style68{}Style63{}Sty" +
				"le62{}Style61{}Style60{}Style67{}Style66{}Style65{}Style64{}Group{AlignVert:Cent" +
				"er;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}</Data></Styles><Splits><C1.Wi" +
				"n.C1TrueDBGrid.MergeView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" Col" +
				"umnFooterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" De" +
				"fRecSelWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>" +
				"0, 17, 556, 171</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=\"Styl" +
				"e2\" me=\"Style10\" /><EditorStyle parent=\"Editor\" me=\"Style5\" /><EvenRowStyle pare" +
				"nt=\"EvenRow\" me=\"Style8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><Fo" +
				"oterStyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" " +
				"/><HeadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"Highli" +
				"ghtRow\" me=\"Style7\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyl" +
				"e parent=\"OddRow\" me=\"Style9\" /><RecordSelectorStyle parent=\"RecordSelector\" me=" +
				"\"Style11\" /><SelectedStyle parent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal" +
				"\" me=\"Style1\" /><internalCols><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=" +
				"\"Style46\" /><Style parent=\"Style1\" me=\"Style47\" /><FooterStyle parent=\"Style3\" m" +
				"e=\"Style48\" /><EditorStyle parent=\"Style5\" me=\"Style49\" /><GroupHeaderStyle pare" +
				"nt=\"Style1\" me=\"Style53\" /><GroupFooterStyle parent=\"Style1\" me=\"Style52\" /><Vis" +
				"ible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Hei" +
				"ght><DCIdx>0</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Sty" +
				"le2\" me=\"Style14\" /><Style parent=\"Style1\" me=\"Style15\" /><FooterStyle parent=\"S" +
				"tyle3\" me=\"Style16\" /><EditorStyle parent=\"Style5\" me=\"Style17\" /><GroupHeaderSt" +
				"yle parent=\"Style1\" me=\"Style55\" /><GroupFooterStyle parent=\"Style1\" me=\"Style54" +
				"\" /><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>1</D" +
				"CIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style1" +
				"8\" /><Style parent=\"Style1\" me=\"Style19\" /><FooterStyle parent=\"Style3\" me=\"Styl" +
				"e20\" /><EditorStyle parent=\"Style5\" me=\"Style21\" /><GroupHeaderStyle parent=\"Sty" +
				"le1\" me=\"Style57\" /><GroupFooterStyle parent=\"Style1\" me=\"Style56\" /><ColumnDivi" +
				"der>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>2</DCIdx></C1Displa" +
				"yColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style22\" /><Style par" +
				"ent=\"Style1\" me=\"Style23\" /><FooterStyle parent=\"Style3\" me=\"Style24\" /><EditorS" +
				"tyle parent=\"Style5\" me=\"Style25\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style5" +
				"9\" /><GroupFooterStyle parent=\"Style1\" me=\"Style58\" /><Visible>True</Visible><Co" +
				"lumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><Button>True</Butt" +
				"on><DCIdx>3</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Styl" +
				"e2\" me=\"Style26\" /><Style parent=\"Style1\" me=\"Style27\" /><FooterStyle parent=\"St" +
				"yle3\" me=\"Style28\" /><EditorStyle parent=\"Style5\" me=\"Style29\" /><GroupHeaderSty" +
				"le parent=\"Style1\" me=\"Style61\" /><GroupFooterStyle parent=\"Style1\" me=\"Style60\"" +
				" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>" +
				"15</Height><DCIdx>4</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle pare" +
				"nt=\"Style2\" me=\"Style30\" /><Style parent=\"Style1\" me=\"Style31\" /><FooterStyle pa" +
				"rent=\"Style3\" me=\"Style32\" /><EditorStyle parent=\"Style5\" me=\"Style33\" /><GroupH" +
				"eaderStyle parent=\"Style1\" me=\"Style63\" /><GroupFooterStyle parent=\"Style1\" me=\"" +
				"Style62\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider>" +
				"<Height>15</Height><DCIdx>5</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingSt" +
				"yle parent=\"Style2\" me=\"Style34\" /><Style parent=\"Style1\" me=\"Style35\" /><Footer" +
				"Style parent=\"Style3\" me=\"Style36\" /><EditorStyle parent=\"Style5\" me=\"Style37\" /" +
				"><GroupHeaderStyle parent=\"Style1\" me=\"Style65\" /><GroupFooterStyle parent=\"Styl" +
				"e1\" me=\"Style64\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</Column" +
				"Divider><Width>129</Width><Height>15</Height><DCIdx>6</DCIdx></C1DisplayColumn><" +
				"C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style38\" /><Style parent=\"Styl" +
				"e1\" me=\"Style39\" /><FooterStyle parent=\"Style3\" me=\"Style40\" /><EditorStyle pare" +
				"nt=\"Style5\" me=\"Style41\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style67\" /><Gro" +
				"upFooterStyle parent=\"Style1\" me=\"Style66\" /><ColumnDivider>DarkGray,Single</Col" +
				"umnDivider><Height>15</Height><DCIdx>7</DCIdx></C1DisplayColumn><C1DisplayColumn" +
				"><HeadingStyle parent=\"Style2\" me=\"Style42\" /><Style parent=\"Style1\" me=\"Style43" +
				"\" /><FooterStyle parent=\"Style3\" me=\"Style44\" /><EditorStyle parent=\"Style5\" me=" +
				"\"Style45\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style69\" /><GroupFooterStyle p" +
				"arent=\"Style1\" me=\"Style68\" /><ColumnDivider>DarkGray,Single</ColumnDivider><Hei" +
				"ght>15</Height><Button>True</Button><DCIdx>8</DCIdx></C1DisplayColumn></internal" +
				"Cols></C1.Win.TrueDBGrid.MergeView></Splits><NamedStyles><Style parent=\"\" me=\"" +
				"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Foot" +
				"er\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactiv" +
				"e\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /" +
				"><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" " +
				"/><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelecto" +
				"r\" /><Style parent=\"Normal\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" " +
				"/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modi" +
				"fied</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 556, 1" +
				"88</ClientArea><PrintPageHeaderStyle parent=\"\" me=\"Style50\" /><PrintPageFooterSt" +
				"yle parent=\"\" me=\"Style51\" /></Blob>";
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(56, 232);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Prospective Customers";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(232, 232);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 24);
			this.button2.TabIndex = 2;
			this.button2.Text = "Distributors";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(384, 232);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 24);
			this.button3.TabIndex = 3;
			this.button3.Text = "Reset the Grid";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 270);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button3,
																		  this.button2,
																		  this.button1,
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial 11";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 

		int bflag;
		DataTable dtCopy;

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

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
		private void C1TrueDBGrid1_FetchRowStyle(object sender,C1.Win.TrueDBGrid.FetchRowStyleEventArgs e)
		{
			if(bflag == 1 && this.c1TrueDBGrid1.Columns["CustType"].CellValue(e.Row).ToString() == "1")
			{
				Font fntFont = new Font(e.CellStyle.Font.Name, e.CellStyle.Font.Size, FontStyle.Bold);
				e.CellStyle.Font = fntFont;
				e.CellStyle.ForeColor = System.Drawing.Color.Blue;
			}
			else if(bflag == 2 && this.c1TrueDBGrid1.Columns["CustType"].CellValue(e.Row).ToString() == "4" )
			{
				e.CellStyle.ForeColor = System.Drawing.Color.White;
				e.CellStyle.BackColor = System.Drawing.Color.Red;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//prospective
			this.c1TrueDBGrid1.FetchRowStyles = true;
			bflag = 1;
			this.c1TrueDBGrid1.Refresh();		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//distributors
			this.c1TrueDBGrid1.FetchRowStyles = true;
			bflag = 2;
			this.c1TrueDBGrid1.Refresh();	
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//reset styles
			this.c1TrueDBGrid1.FetchRowStyles = false;
			this.c1TrueDBGrid1.Refresh();	
		}
		private string GetModifiedConnectionString(string connstring)
		{
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
		}
	}
}
