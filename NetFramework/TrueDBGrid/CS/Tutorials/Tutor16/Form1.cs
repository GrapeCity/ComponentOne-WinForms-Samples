using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.TrueDBGrid;

namespace Tutorial_16
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private Tutorial_16.DsMasterDetail dsMasterDetail1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbConnection oleDbConnection2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
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
            this.dsMasterDetail1 = new Tutorial_16.DsMasterDetail();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsMasterDetail1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1TrueDBGrid1
			// 
			this.c1TrueDBGrid1.Caption = "C1True DBGrid .Net";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.Cursor = System.Windows.Forms.Cursors.Default;
			this.c1TrueDBGrid1.DataMember = "Composer";
			this.c1TrueDBGrid1.DataSource = this.dsMasterDetail1;
			this.c1TrueDBGrid1.DataView = C1.Win.TrueDBGrid.DataViewEnum.Hierarchical;
			this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
			this.c1TrueDBGrid1.Images.Add(((System.Drawing.Bitmap)(resources.GetObject("resource.Images"))));
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
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(424, 184);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Relation=\"True\" Capt" +
				"ion=\"First\" DataField=\"First\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataC" +
				"olumn Level=\"0\" Caption=\"Last\" DataField=\"Last\"><ValueItems /><GroupInfo /></C1D" +
				"ataColumn><C1DataColumn Level=\"0\" Caption=\"Country\" DataField=\"Country\"><ValueIt" +
				"ems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"1\" Relation=\"True\" Captio" +
				"n=\"Last\" DataField=\"Last\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColum" +
				"n Level=\"1\" Caption=\"Opus\" DataField=\"Opus\"><ValueItems /><GroupInfo /></C1DataC" +
				"olumn></DataCols><Styles type=\"C1.Win.TrueDBGrid.Design.ContextWrapper\"><Data>" +
				"RecordSelector{AlignImage:Center;}Style50{}Caption{AlignHorz:Center;}Normal{}Sel" +
				"ected{ForeColor:HighlightText;BackColor:Highlight;}Editor{}Style18{AlignHorz:Nea" +
				"r;}Style19{AlignHorz:Near;}Style14{AlignHorz:Near;}Style15{AlignHorz:Near;}Style" +
				"16{}Style17{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style2{AlignHorz" +
				":Near;}Style34{}Style4{}OddRow{}Style29{}Style28{}Style27{}Style26{}Style25{}Foo" +
				"ter{}Style23{}Style22{}Style21{}Style20{}Inactive{ForeColor:InactiveCaptionText;" +
				"BackColor:InactiveCaption;}EvenRow{BackColor:Aqua;}Style6{AlignHorz:Near;}Headin" +
				"g{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Bac" +
				"kColor:Control;}Style3{}Style24{}Style7{}Style8{}Style1{AlignHorz:Near;}Style5{A" +
				"lignHorz:Near;}Style41{}Style40{}Style43{}FilterBar{}Style45{}Style42{}Style44{}" +
				"Style9{AlignHorz:Near;}Style38{}Style39{}Style36{}Style37{}Group{BackColor:Contr" +
				"olDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style35{AlignHorz:Near;}Style32" +
				"{}Style33{}Style30{}Style31{}HighlightRow{ForeColor:HighlightText;BackColor:High" +
				"light;}</Data></Styles><Splits><C1.Win.TrueDBGrid.HierarchicalView DefRecSelWi" +
				"dth=\"17\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=" +
				"\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" VerticalScrollGrou" +
				"p=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 17, 420, 163</ClientRect><interna" +
				"lCols><C1DisplayColumn><HeadingStyle parent=\"Style28\" me=\"Style1\" /><Style paren" +
				"t=\"Style26\" me=\"Style2\" /><FooterStyle parent=\"Style29\" me=\"Style3\" /><EditorSty" +
				"le parent=\"Style27\" me=\"Style4\" /><GroupHeaderStyle parent=\"Style26\" me=\"Style25" +
				"\" /><GroupFooterStyle parent=\"Style26\" me=\"Style24\" /><Visible>True</Visible><Co" +
				"lumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>0</DCIdx></" +
				"C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style28\" me=\"Style5\" /><S" +
				"tyle parent=\"Style26\" me=\"Style6\" /><FooterStyle parent=\"Style29\" me=\"Style7\" />" +
				"<EditorStyle parent=\"Style27\" me=\"Style8\" /><GroupHeaderStyle parent=\"Style26\" m" +
				"e=\"Style39\" /><GroupFooterStyle parent=\"Style26\" me=\"Style38\" /><Visible>True</V" +
				"isible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>1" +
				"</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style28\" me=\"St" +
				"yle9\" /><Style parent=\"Style26\" me=\"Style10\" /><FooterStyle parent=\"Style29\" me=" +
				"\"Style11\" /><EditorStyle parent=\"Style27\" me=\"Style12\" /><GroupHeaderStyle paren" +
				"t=\"Style26\" me=\"Style41\" /><GroupFooterStyle parent=\"Style26\" me=\"Style40\" /><Vi" +
				"sible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</He" +
				"ight><DCIdx>2</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"St" +
				"yle28\" me=\"Style14\" /><Style parent=\"Style26\" me=\"Style15\" /><FooterStyle parent" +
				"=\"Style29\" me=\"Style16\" /><EditorStyle parent=\"Style27\" me=\"Style17\" /><GroupHea" +
				"derStyle parent=\"Style26\" me=\"Style43\" /><GroupFooterStyle parent=\"Style26\" me=\"" +
				"Style42\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider>" +
				"<Height>15</Height><DCIdx>3</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingSt" +
				"yle parent=\"Style28\" me=\"Style18\" /><Style parent=\"Style26\" me=\"Style19\" /><Foot" +
				"erStyle parent=\"Style29\" me=\"Style20\" /><EditorStyle parent=\"Style27\" me=\"Style2" +
				"1\" /><GroupHeaderStyle parent=\"Style26\" me=\"Style45\" /><GroupFooterStyle parent=" +
				"\"Style26\" me=\"Style44\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</" +
				"ColumnDivider><Height>15</Height><DCIdx>4</DCIdx></C1DisplayColumn></internalCol" +
				"s><CaptionStyle parent=\"Heading\" me=\"Style35\" /><EditorStyle parent=\"Editor\" me=" +
				"\"Style27\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style33\" /><FilterBarStyle parent" +
				"=\"FilterBar\" me=\"Style50\" /><FooterStyle parent=\"Footer\" me=\"Style29\" /><GroupSt" +
				"yle parent=\"Group\" me=\"Style37\" /><HeadingStyle parent=\"Heading\" me=\"Style28\" />" +
				"<HighLightRowStyle parent=\"HighlightRow\" me=\"Style32\" /><InactiveStyle parent=\"I" +
				"nactive\" me=\"Style31\" /><OddRowStyle parent=\"OddRow\" me=\"Style34\" /><RecordSelec" +
				"torStyle parent=\"RecordSelector\" me=\"Style36\" /><SelectedStyle parent=\"Selected\"" +
				" me=\"Style30\" /><Style parent=\"Normal\" me=\"Style26\" /></C1.Win.TrueDBGrid.Hier" +
				"archicalView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=" +
				"\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Hea" +
				"ding\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Norm" +
				"al\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /><Style parent=\"Normal\" " +
				"me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\"" +
				" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Norm" +
				"al\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSpl" +
				"its>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRec" +
				"SelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 420, 180</ClientArea><PrintPag" +
				"eHeaderStyle parent=\"\" me=\"Style22\" /><PrintPageFooterStyle parent=\"\" me=\"Style2" +
				"3\" /></Blob>";
			// 
			// dsMasterDetail1
			// 
			this.dsMasterDetail1.DataSetName = "DsMasterDetail";
			this.dsMasterDetail1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsMasterDetail1.Namespace = "http://www.tempuri.org/DsMasterDetail.xsd";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Composer", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("Birth", "Birth"),
																																																					new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																					new System.Data.Common.DataColumnMapping("Death", "Death"),
																																																					new System.Data.Common.DataColumnMapping("First", "First"),
																																																					new System.Data.Common.DataColumnMapping("Last", "Last")})});
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Composer(Birth, Country, Death, First, Last) VALUES (?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection2;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Birth", System.Data.OleDb.OleDbType.DBDate, 0, "Birth"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 50, "Country"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Death", System.Data.OleDb.OleDbType.DBDate, 0, "Death"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("First", System.Data.OleDb.OleDbType.VarWChar, 50, "First"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"));
			// 
			// oleDbConnection2
			// 
			this.oleDbConnection2.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Birth, Country, Death, First, Last FROM Composer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection2;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Opus", new System.Data.Common.DataColumnMapping[] {
																																																				new System.Data.Common.DataColumnMapping("Last", "Last"),
																																																				new System.Data.Common.DataColumnMapping("Opus", "Opus")})});
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Opus(Last, Opus) VALUES (?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection2;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Last", System.Data.OleDb.OleDbType.VarWChar, 50, "Last"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Opus", System.Data.OleDb.OleDbType.VarWChar, 150, "Opus"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Last, Opus FROM Opus";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 206);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial 16";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsMasterDetail1)).EndInit();
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
				this.oleDbConnection2.ConnectionString = GetModifiedConnectionString(this.oleDbConnection2.ConnectionString);
				this.oleDbDataAdapter1.Fill(this.dsMasterDetail1);
				this.oleDbDataAdapter2.Fill(this.dsMasterDetail1);
			}
			catch(System.Exception eLoad)
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
