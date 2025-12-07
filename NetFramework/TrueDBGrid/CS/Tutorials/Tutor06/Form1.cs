using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial_6
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Tutorial_6.DsContacts dsContacts1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
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

			this.dsContacts1 = new Tutorial_6.DsContacts();
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
			this.c1TrueDBGrid1.Caption = "C1True DBGrid .Net";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.DataMember = "Contacts";
			this.c1TrueDBGrid1.DataSource = this.dsContacts1;
			this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images"))));
			this.c1TrueDBGrid1.Location = new System.Drawing.Point(16, 16);
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
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(712, 144);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.UnboundColumnFetch += new C1.Win.TrueDBGrid.UnboundColumnFetchEventHandler(this.c1TrueDBGrid1_UnboundColumnFetch);
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"FirstName\" " +
				"DataField=\"FirstName\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Le" +
				"vel=\"0\" Caption=\"LastName\" DataField=\"LastName\"><ValueItems /><GroupInfo /></C1D" +
				"ataColumn><C1DataColumn Level=\"0\" Caption=\"CustType\" DataField=\"CustType\"><Value" +
				"Items /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"ContactType" +
				"\" DataField=\"ContactType\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColum" +
				"n Level=\"0\" Caption=\"Callback\" DataField=\"Callback\"><ValueItems Presentation=\"Ch" +
				"eckBox\" /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"ContactDa" +
				"te\" DataField=\"ContactDate\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataCol" +
				"umn Level=\"0\" Caption=\"UserCode\" DataField=\"UserCode\"><ValueItems /><GroupInfo /" +
				"></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"Expr1\" DataField=\"Expr1\"><Value" +
				"Items /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"Name\" DataF" +
				"ield=\"\"><ValueItems /><GroupInfo /></C1DataColumn></DataCols><Styles type=\"C1.Wi" +
				"n.C1TrueDBGrid.Design.ContextWrapper\"><Data>HighlightRow{ForeColor:HighlightText" +
				";BackColor:Highlight;}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveC" +
				"aption;}Style119{AlignHorz:Near;}Style118{AlignHorz:Near;}Style115{}Style114{}St" +
				"yle117{}Style116{}Style113{AlignHorz:Near;}Style112{AlignHorz:Near;}Editor{}Filt" +
				"erBar{}Style19{}Style18{}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1" +
				", 1, 1;ForeColor:ControlText;AlignVert:Center;}Style14{AlignHorz:Near;}Style15{A" +
				"lignHorz:Near;}Style16{}Style17{}Style139{}Style138{}Style137{AlignHorz:Center;}" +
				"Style136{AlignHorz:Center;}Style135{}Style134{}Style133{}Style132{}Style131{Alig" +
				"nHorz:Far;}Style130{AlignHorz:Far;}Style10{AlignHorz:Near;}Style11{}Style12{}Sty" +
				"le13{}Style128{}Style158{}Style124{AlignHorz:Far;}Style125{AlignHorz:Far;}Style1" +
				"22{}Style120{}Style121{}Style9{}Style129{}Style126{}Style127{}Style5{}Style4{}St" +
				"yle7{}Style123{}Style1{}Style159{}Style3{}Style2{}Style151{}Style150{}Style153{}" +
				"Style152{}Style155{AlignHorz:Near;}Style154{AlignHorz:Near;}Style157{}Style156{}" +
				"Style38{}Style39{}Style148{AlignHorz:Near;}Style149{AlignHorz:Near;}Normal{Font:" +
				"Tahoma, 11world;}Style140{}Style141{}Style142{AlignHorz:Far;}Style143{AlignHorz:" +
				"Far;}Style144{}Style145{}Style146{}Style147{}Selected{ForeColor:HighlightText;Ba" +
				"ckColor:Highlight;}EvenRow{BackColor:Aqua;}Style8{}Style6{}RecordSelector{AlignI" +
				"mage:Center;}Footer{}Caption{AlignHorz:Center;}OddRow{}Group{AlignVert:Center;Bo" +
				"rder:None,,0, 0, 0, 0;BackColor:ControlDark;}</Data></Styles><Splits><C1.Win.C1T" +
				"rueDBGrid.MergeView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFo" +
				"oterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecS" +
				"elWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 17" +
				", 708, 123</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style10\" /><EditorStyle parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=\"E" +
				"venRow\" me=\"Style8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><FooterS" +
				"tyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><He" +
				"adingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRo" +
				"w\" me=\"Style7\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle par" +
				"ent=\"OddRow\" me=\"Style9\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Styl" +
				"e11\" /><SelectedStyle parent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" me=" +
				"\"Style1\" /><internalCols><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Styl" +
				"e14\" /><Style parent=\"Style1\" me=\"Style15\" /><FooterStyle parent=\"Style3\" me=\"St" +
				"yle16\" /><EditorStyle parent=\"Style5\" me=\"Style17\" /><GroupHeaderStyle parent=\"S" +
				"tyle1\" me=\"Style19\" /><GroupFooterStyle parent=\"Style1\" me=\"Style18\" /><Visible>" +
				"True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><" +
				"DCIdx>8</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" " +
				"me=\"Style112\" /><Style parent=\"Style1\" me=\"Style113\" /><FooterStyle parent=\"Styl" +
				"e3\" me=\"Style114\" /><EditorStyle parent=\"Style5\" me=\"Style115\" /><GroupHeaderSty" +
				"le parent=\"Style1\" me=\"Style117\" /><GroupFooterStyle parent=\"Style1\" me=\"Style11" +
				"6\" /><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>0</" +
				"DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style" +
				"118\" /><Style parent=\"Style1\" me=\"Style119\" /><FooterStyle parent=\"Style3\" me=\"S" +
				"tyle120\" /><EditorStyle parent=\"Style5\" me=\"Style121\" /><GroupHeaderStyle parent" +
				"=\"Style1\" me=\"Style123\" /><GroupFooterStyle parent=\"Style1\" me=\"Style122\" /><Col" +
				"umnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>1</DCIdx></C" +
				"1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style124\" /><S" +
				"tyle parent=\"Style1\" me=\"Style125\" /><FooterStyle parent=\"Style3\" me=\"Style126\" " +
				"/><EditorStyle parent=\"Style5\" me=\"Style127\" /><GroupHeaderStyle parent=\"Style1\"" +
				" me=\"Style129\" /><GroupFooterStyle parent=\"Style1\" me=\"Style128\" /><Visible>True" +
				"</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCId" +
				"x>2</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"" +
				"Style130\" /><Style parent=\"Style1\" me=\"Style131\" /><FooterStyle parent=\"Style3\" " +
				"me=\"Style132\" /><EditorStyle parent=\"Style5\" me=\"Style133\" /><GroupHeaderStyle p" +
				"arent=\"Style1\" me=\"Style135\" /><GroupFooterStyle parent=\"Style1\" me=\"Style134\" /" +
				"><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15" +
				"</Height><DCIdx>3</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent" +
				"=\"Style2\" me=\"Style136\" /><Style parent=\"Style1\" me=\"Style137\" /><FooterStyle pa" +
				"rent=\"Style3\" me=\"Style138\" /><EditorStyle parent=\"Style5\" me=\"Style139\" /><Grou" +
				"pHeaderStyle parent=\"Style1\" me=\"Style141\" /><GroupFooterStyle parent=\"Style1\" m" +
				"e=\"Style140\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivi" +
				"der><Height>15</Height><DCIdx>4</DCIdx></C1DisplayColumn><C1DisplayColumn><Headi" +
				"ngStyle parent=\"Style2\" me=\"Style142\" /><Style parent=\"Style1\" me=\"Style143\" /><" +
				"FooterStyle parent=\"Style3\" me=\"Style144\" /><EditorStyle parent=\"Style5\" me=\"Sty" +
				"le145\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style147\" /><GroupFooterStyle par" +
				"ent=\"Style1\" me=\"Style146\" /><Visible>True</Visible><ColumnDivider>DarkGray,Sing" +
				"le</ColumnDivider><Height>15</Height><DCIdx>5</DCIdx></C1DisplayColumn><C1Displa" +
				"yColumn><HeadingStyle parent=\"Style2\" me=\"Style148\" /><Style parent=\"Style1\" me=" +
				"\"Style149\" /><FooterStyle parent=\"Style3\" me=\"Style150\" /><EditorStyle parent=\"S" +
				"tyle5\" me=\"Style151\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style153\" /><GroupF" +
				"ooterStyle parent=\"Style1\" me=\"Style152\" /><Visible>True</Visible><ColumnDivider" +
				">DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>6</DCIdx></C1DisplayCo" +
				"lumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style154\" /><Style paren" +
				"t=\"Style1\" me=\"Style155\" /><FooterStyle parent=\"Style3\" me=\"Style156\" /><EditorS" +
				"tyle parent=\"Style5\" me=\"Style157\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style" +
				"159\" /><GroupFooterStyle parent=\"Style1\" me=\"Style158\" /><Visible>True</Visible>" +
				"<ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>7</DCIdx" +
				"></C1DisplayColumn></internalCols></C1.Win.TrueDBGrid.MergeView></Splits><Name" +
				"dStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><St" +
				"yle parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=\"Caption\" /><Style" +
				" parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style " +
				"parent=\"Normal\" me=\"Editor\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style " +
				"parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style paren" +
				"t=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Normal\" me=\"FilterBar\" /><Style" +
				" parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1</vertSplits><horzSpli" +
				"ts>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelW" +
				"idth><ClientArea>0, 0, 708, 140</ClientArea><PrintPageHeaderStyle parent=\"\" me=\"" +
				"Style38\" /><PrintPageFooterStyle parent=\"\" me=\"Style39\" /></Blob>";
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
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(744, 174);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial06";
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
		System.Data.DataTable dtCopy = new System.Data.DataTable();

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);
			oleDbDataAdapter1.Fill(dsContacts1);
			dtCopy = this.dsContacts1.Tables[0].Copy();
		}

		private void c1TrueDBGrid1_UnboundColumnFetch(object sender, C1.Win.TrueDBGrid.UnboundColumnFetchEventArgs e)
		{
			if(e.Col == 8 && e.Row < dtCopy.Rows.Count)
			{
				e.Value = dtCopy.Rows[e.Row].ItemArray.GetValue(0).ToString() + " " + dtCopy.Rows[e.Row].ItemArray.GetValue(1).ToString();
			}
		}
		private string GetModifiedConnectionString(string connstring)
		{
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
		}
	}
}
