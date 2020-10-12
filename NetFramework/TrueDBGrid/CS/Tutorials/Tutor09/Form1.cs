using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Tutorial09
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
		private Tutorial09.DsContacts dsContacts1;
		private System.Windows.Forms.ListBox listBox1;
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

			this.dsContacts1 = new Tutorial09.DsContacts();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.listBox1 = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1TrueDBGrid1
			// 
			this.c1TrueDBGrid1.Caption = "C1TrueDBGrid1";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.DataMember = "Contacts";
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
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(536, 160);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.ButtonClick += new C1.Win.C1TrueDBGrid.ColEventHandler(this.c1TrueDBGrid1_ButtonClick);
			this.c1TrueDBGrid1.UnboundColumnFetch += new C1.Win.C1TrueDBGrid.UnboundColumnFetchEventHandler(this.c1TrueDBGrid1_UnboundColumnFetch);
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Customer Na" +
				"me\" DataField=\"\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"" +
				"0\" Caption=\"FirstName\" DataField=\"FirstName\"><ValueItems /><GroupInfo /></C1Data" +
				"Column><C1DataColumn Level=\"0\" Caption=\"LastName\" DataField=\"LastName\"><ValueIte" +
				"ms /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"CustType\" Data" +
				"Field=\"CustType\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"" +
				"0\" Caption=\"ContactType\" DataField=\"ContactType\"><ValueItems /><GroupInfo /></C1" +
				"DataColumn><C1DataColumn Level=\"0\" Caption=\"Callback\" DataField=\"Callback\"><Valu" +
				"eItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"ContactDat" +
				"e\" DataField=\"ContactDate\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColu" +
				"mn Level=\"0\" Caption=\"UserCode\" DataField=\"UserCode\"><ValueItems /><GroupInfo />" +
				"</C1DataColumn><C1DataColumn Level=\"0\" Caption=\"Expr1\" DataField=\"Expr1\"><ValueI" +
				"tems Presentation=\"ComboBox\" Translate=\"True\"><internalValues><ValueItem type=\"C" +
				"1.Win.C1TrueDBGrid.ValueItem\" Value=\"1\" dispVal=\"Prospective\" /><ValueItem type=" +
				"\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"2\" dispVal=\"Normal\" /><ValueItem type=\"C1" +
				".Win.C1TrueDBGrid.ValueItem\" Value=\"3\" dispVal=\"Buyer\" /><ValueItem type=\"C1.Win" +
				".C1TrueDBGrid.ValueItem\" Value=\"4\" dispVal=\"Distributor\" /><ValueItem type=\"C1.W" +
				"in.C1TrueDBGrid.ValueItem\" Value=\"5\" dispVal=\"Other\" /></internalValues></ValueI" +
				"tems><GroupInfo /></C1DataColumn></DataCols><Styles type=\"C1.Win.C1TrueDBGrid.De" +
				"sign.ContextWrapper\"><Data>HighlightRow{ForeColor:HighlightText;BackColor:Highli" +
				"ght;}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}Selected{" +
				"ForeColor:HighlightText;BackColor:Highlight;}Editor{}FilterBar{}Heading{Wrap:Tru" +
				"e;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Ce" +
				"nter;}Style18{AlignHorz:Near;}Style19{AlignHorz:Near;}Style14{AlignHorz:Near;}St" +
				"yle15{AlignHorz:Near;}Style16{}Style17{}Style10{AlignHorz:Near;}Style11{}Style12" +
				"{}Style13{}Style27{AlignHorz:Far;}Style29{}Style28{}Style26{AlignHorz:Far;}Style" +
				"25{}Style9{}Style8{}Style24{}Style23{AlignHorz:Far;}Style5{}Style4{}Style7{}Styl" +
				"e6{}Style1{}Style22{AlignHorz:Far;}Style3{}Style2{}Style21{}Style20{}OddRow{}Sty" +
				"le38{AlignHorz:Near;}Style39{AlignHorz:Near;}Style36{}Style37{}Style34{AlignHorz" +
				":Far;}Style35{AlignHorz:Far;}Style32{}Style33{}Style30{AlignHorz:Center;}Style49" +
				"{}Style48{}Style31{AlignHorz:Center;}Normal{Font:Tahoma, 11world;}Style41{}Style" +
				"40{}Style43{AlignHorz:Near;}Style42{AlignHorz:Near;}Style45{}Style44{}Style47{Al" +
				"ignHorz:Near;}Style46{AlignHorz:Near;}EvenRow{BackColor:Aqua;}Style59{}Style58{}" +
				"RecordSelector{AlignImage:Center;}Style51{}Style50{}Footer{}Style52{}Style53{}St" +
				"yle54{}Style55{}Style56{}Style57{}Caption{AlignHorz:Center;}Style69{}Style68{}St" +
				"yle63{}Style62{}Style61{}Style60{}Style67{}Style66{}Style65{}Style64{}Group{Alig" +
				"nVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}</Data></Styles><Spl" +
				"its><C1.Win.C1TrueDBGrid.MergeView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeigh" +
				"t=\"17\" ColumnFooterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWid" +
				"th=\"17\" DefRecSelWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><C" +
				"lientRect>0, 17, 532, 139</ClientRect><BorderSide>0</BorderSide><CaptionStyle pa" +
				"rent=\"Style2\" me=\"Style10\" /><EditorStyle parent=\"Editor\" me=\"Style5\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Styl" +
				"e13\" /><FooterStyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=" +
				"\"Style12\" /><HeadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle pare" +
				"nt=\"HighlightRow\" me=\"Style7\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><" +
				"OddRowStyle parent=\"OddRow\" me=\"Style9\" /><RecordSelectorStyle parent=\"RecordSel" +
				"ector\" me=\"Style11\" /><SelectedStyle parent=\"Selected\" me=\"Style6\" /><Style pare" +
				"nt=\"Normal\" me=\"Style1\" /><internalCols><C1DisplayColumn><HeadingStyle parent=\"S" +
				"tyle2\" me=\"Style46\" /><Style parent=\"Style1\" me=\"Style47\" /><FooterStyle parent=" +
				"\"Style3\" me=\"Style48\" /><EditorStyle parent=\"Style5\" me=\"Style49\" /><GroupHeader" +
				"Style parent=\"Style1\" me=\"Style53\" /><GroupFooterStyle parent=\"Style1\" me=\"Style" +
				"52\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Heig" +
				"ht>15</Height><DCIdx>0</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle p" +
				"arent=\"Style2\" me=\"Style14\" /><Style parent=\"Style1\" me=\"Style15\" /><FooterStyle" +
				" parent=\"Style3\" me=\"Style16\" /><EditorStyle parent=\"Style5\" me=\"Style17\" /><Gro" +
				"upHeaderStyle parent=\"Style1\" me=\"Style55\" /><GroupFooterStyle parent=\"Style1\" m" +
				"e=\"Style54\" /><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><" +
				"DCIdx>1</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" " +
				"me=\"Style18\" /><Style parent=\"Style1\" me=\"Style19\" /><FooterStyle parent=\"Style3" +
				"\" me=\"Style20\" /><EditorStyle parent=\"Style5\" me=\"Style21\" /><GroupHeaderStyle p" +
				"arent=\"Style1\" me=\"Style57\" /><GroupFooterStyle parent=\"Style1\" me=\"Style56\" /><" +
				"ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>2</DCIdx>" +
				"</C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style22\" />" +
				"<Style parent=\"Style1\" me=\"Style23\" /><FooterStyle parent=\"Style3\" me=\"Style24\" " +
				"/><EditorStyle parent=\"Style5\" me=\"Style25\" /><GroupHeaderStyle parent=\"Style1\" " +
				"me=\"Style59\" /><GroupFooterStyle parent=\"Style1\" me=\"Style58\" /><Visible>True</V" +
				"isible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><Button>" +
				"True</Button><DCIdx>3</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle pa" +
				"rent=\"Style2\" me=\"Style26\" /><Style parent=\"Style1\" me=\"Style27\" /><FooterStyle " +
				"parent=\"Style3\" me=\"Style28\" /><EditorStyle parent=\"Style5\" me=\"Style29\" /><Grou" +
				"pHeaderStyle parent=\"Style1\" me=\"Style61\" /><GroupFooterStyle parent=\"Style1\" me" +
				"=\"Style60\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivide" +
				"r><Height>15</Height><DCIdx>4</DCIdx></C1DisplayColumn><C1DisplayColumn><Heading" +
				"Style parent=\"Style2\" me=\"Style30\" /><Style parent=\"Style1\" me=\"Style31\" /><Foot" +
				"erStyle parent=\"Style3\" me=\"Style32\" /><EditorStyle parent=\"Style5\" me=\"Style33\"" +
				" /><GroupHeaderStyle parent=\"Style1\" me=\"Style63\" /><GroupFooterStyle parent=\"St" +
				"yle1\" me=\"Style62\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</Colu" +
				"mnDivider><Height>15</Height><DCIdx>5</DCIdx></C1DisplayColumn><C1DisplayColumn>" +
				"<HeadingStyle parent=\"Style2\" me=\"Style34\" /><Style parent=\"Style1\" me=\"Style35\"" +
				" /><FooterStyle parent=\"Style3\" me=\"Style36\" /><EditorStyle parent=\"Style5\" me=\"" +
				"Style37\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style65\" /><GroupFooterStyle pa" +
				"rent=\"Style1\" me=\"Style64\" /><Visible>True</Visible><ColumnDivider>DarkGray,Sing" +
				"le</ColumnDivider><Height>15</Height><DCIdx>6</DCIdx></C1DisplayColumn><C1Displa" +
				"yColumn><HeadingStyle parent=\"Style2\" me=\"Style38\" /><Style parent=\"Style1\" me=\"" +
				"Style39\" /><FooterStyle parent=\"Style3\" me=\"Style40\" /><EditorStyle parent=\"Styl" +
				"e5\" me=\"Style41\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style67\" /><GroupFooter" +
				"Style parent=\"Style1\" me=\"Style66\" /><ColumnDivider>DarkGray,Single</ColumnDivid" +
				"er><Height>15</Height><DCIdx>7</DCIdx></C1DisplayColumn><C1DisplayColumn><Headin" +
				"gStyle parent=\"Style2\" me=\"Style42\" /><Style parent=\"Style1\" me=\"Style43\" /><Foo" +
				"terStyle parent=\"Style3\" me=\"Style44\" /><EditorStyle parent=\"Style5\" me=\"Style45" +
				"\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style69\" /><GroupFooterStyle parent=\"S" +
				"tyle1\" me=\"Style68\" /><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</" +
				"Height><Button>True</Button><DCIdx>8</DCIdx></C1DisplayColumn></internalCols></C" +
				"1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" " +
				"/><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><S" +
				"tyle parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><St" +
				"yle parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /><Style " +
				"parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style" +
				" parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><St" +
				"yle parent=\"Normal\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" /></Name" +
				"dStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</La" +
				"yout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 532, 156</Clie" +
				"ntArea><PrintPageHeaderStyle parent=\"\" me=\"Style50\" /><PrintPageFooterStyle pare" +
				"nt=\"\" me=\"Style51\" /></Blob>";
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
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(304, 80);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(80, 82);
			this.listBox1.TabIndex = 1;
			this.listBox1.Visible = false;
			this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
			this.listBox1.Leave += new System.EventHandler(this.listBox1_Leave);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 174);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.listBox1,
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial 09";
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

			//add customer types to listbox1
			listBox1.Items.Add("Prospective");
			listBox1.Items.Add("Normal");
			listBox1.Items.Add("Buyer");
			listBox1.Items.Add("Distributor");
			listBox1.Items.Add("Other");
			//listBox1.Visible = False;
        
			//place a button in the CustType column
			this.c1TrueDBGrid1.Splits[0].DisplayColumns["CustType"].Button = true;
		}

		private void c1TrueDBGrid1_UnboundColumnFetch(object sender, C1.Win.C1TrueDBGrid.UnboundColumnFetchEventArgs e)
		{
			if(e.Col == 0 && e.Row < dtCopy.Rows.Count)
				e.Value = dtCopy.Rows[e.Row].ItemArray.GetValue(0).ToString() + " " + dtCopy.Rows[e.Row].ItemArray.GetValue(1).ToString();
		}

		
		private void c1TrueDBGrid1_ButtonClick(object sender, C1.Win.C1TrueDBGrid.ColEventArgs e)
		{
			listBox1.Left = this.c1TrueDBGrid1.Left + this.c1TrueDBGrid1.RecordSelectorWidth + this.c1TrueDBGrid1.Splits[0].DisplayColumns[0].Width + this.c1TrueDBGrid1.Splits[0].DisplayColumns[1].Width;
			listBox1.Top = this.c1TrueDBGrid1.Top + this.c1TrueDBGrid1.RowTop(this.c1TrueDBGrid1.Row);
			listBox1.Visible = true;
			listBox1.Select();
		}

		private void c1TrueDBGrid1_OnScroll(object sender, C1.Win.C1TrueDBGrid.CancelEventArgs e)
		{
			this.listBox1.Visible = false;
		}

		private void listBox1_DoubleClick(object sender, System.EventArgs e)
		{
	
			this.c1TrueDBGrid1.Columns[3].Text = this.listBox1.SelectedIndex.ToString();
			//this.c1TrueDBGrid1.Columns[3].Text = this.listBox1.SelectedIndex.ToString();
			//this.c1TrueDBGrid1.Columns[3].Text = this.listBox1.SelectedIndex.ToString(SelectedIndex + 1);
			//int i = this.listBox1.SelectedIndex + 1;
			//this.c1TrueDBGrid1.Columns[3].Text = i.ToString();
			this.listBox1.Visible = false;
		}
		
		private void listBox1_Leave(object sender, System.EventArgs e)
		{
			this.listBox1.Visible = false;
		}
		

		private string GetModifiedConnectionString(string connstring)
		{
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
		}

	}
}
