using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial14
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Tutorial14.DsComposer dsComposer1;
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
            this.dsComposer1 = new Tutorial14.DsComposer();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsComposer1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1TrueDBGrid1
			// 
			this.c1TrueDBGrid1.AllowDelete = true;
			this.c1TrueDBGrid1.Caption = "C1TrueDBGrid.Net";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.DataMember = "Composer";
			this.c1TrueDBGrid1.DataSource = this.dsComposer1;
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
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(464, 240);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Last\" DataF" +
				"ield=\"Last\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Ca" +
				"ption=\"First\" DataField=\"First\"><ValueItems /><GroupInfo /></C1DataColumn><C1Dat" +
				"aColumn Level=\"0\" Caption=\"Country\" DataField=\"Country\"><ValueItems /><GroupInfo" +
				" /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"Birth\" DataField=\"Birth\"><Val" +
				"ueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"Death\" Da" +
				"taField=\"Death\"><ValueItems /><GroupInfo /></C1DataColumn></DataCols><Styles typ" +
				"e=\"C1.Win.C1TrueDBGrid.Design.ContextWrapper\"><Data>RecordSelector{AlignImage:Ce" +
				"nter;}Caption{AlignHorz:Center;}Normal{}Style24{}Editor{}Style18{AlignHorz:Near;" +
				"}Style19{AlignHorz:Near;}Style14{AlignHorz:Far;}Style15{AlignHorz:Far;}Style16{}" +
				"Style17{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style42{}Style38{}St" +
				"yle37{}Style34{}Style35{}OddRow{}Style29{}Style28{}Style27{AlignHorz:Near;}Style" +
				"26{AlignHorz:Near;}Style25{}Footer{}Style23{AlignHorz:Far;}Style22{AlignHorz:Far" +
				";}Style21{}Style20{}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCap" +
				"tion;}EvenRow{BackColor:Aqua;}Heading{Wrap:True;BackColor:Control;Border:Raised," +
				",1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style2{}Style9{}Style6{}Styl" +
				"e1{}Style3{}Style41{}Style40{}Style43{}FilterBar{}Style45{}Selected{ForeColor:Hi" +
				"ghlightText;BackColor:Highlight;}Style4{}Style44{}Style8{}Style39{}Style36{}Styl" +
				"e5{}Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style7" +
				"{}Style32{}Style33{}Style30{AlignHorz:Near;}Style31{AlignHorz:Near;}HighlightRow" +
				"{ForeColor:HighlightText;BackColor:Highlight;}</Data></Styles><Splits><C1.Win.C1" +
				"TrueDBGrid.MergeView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnF" +
				"ooterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRec" +
				"SelWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 1" +
				"7, 460, 219</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=\"Style2\" " +
				"me=\"Style10\" /><EditorStyle parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=\"" +
				"EvenRow\" me=\"Style8\" /><FilterBarStyle parent=\"FilterBar\" me=\"Style13\" /><Footer" +
				"Style parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><H" +
				"eadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightR" +
				"ow\" me=\"Style7\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle pa" +
				"rent=\"OddRow\" me=\"Style9\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Sty" +
				"le11\" /><SelectedStyle parent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" me" +
				"=\"Style1\" /><internalCols><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Sty" +
				"le26\" /><Style parent=\"Style1\" me=\"Style27\" /><FooterStyle parent=\"Style3\" me=\"S" +
				"tyle28\" /><EditorStyle parent=\"Style5\" me=\"Style29\" /><GroupHeaderStyle parent=\"" +
				"Style1\" me=\"Style37\" /><GroupFooterStyle parent=\"Style1\" me=\"Style36\" /><Visible" +
				">True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height>" +
				"<DCIdx>1</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\"" +
				" me=\"Style30\" /><Style parent=\"Style1\" me=\"Style31\" /><FooterStyle parent=\"Style" +
				"3\" me=\"Style32\" /><EditorStyle parent=\"Style5\" me=\"Style33\" /><GroupHeaderStyle " +
				"parent=\"Style1\" me=\"Style39\" /><GroupFooterStyle parent=\"Style1\" me=\"Style38\" />" +
				"<Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15<" +
				"/Height><DCIdx>0</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=" +
				"\"Style2\" me=\"Style18\" /><Style parent=\"Style1\" me=\"Style19\" /><FooterStyle paren" +
				"t=\"Style3\" me=\"Style20\" /><EditorStyle parent=\"Style5\" me=\"Style21\" /><GroupHead" +
				"erStyle parent=\"Style1\" me=\"Style41\" /><GroupFooterStyle parent=\"Style1\" me=\"Sty" +
				"le40\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><He" +
				"ight>15</Height><DCIdx>2</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle" +
				" parent=\"Style2\" me=\"Style14\" /><Style parent=\"Style1\" me=\"Style15\" /><FooterSty" +
				"le parent=\"Style3\" me=\"Style16\" /><EditorStyle parent=\"Style5\" me=\"Style17\" /><G" +
				"roupHeaderStyle parent=\"Style1\" me=\"Style43\" /><GroupFooterStyle parent=\"Style1\"" +
				" me=\"Style42\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDiv" +
				"ider><Height>15</Height><DCIdx>3</DCIdx></C1DisplayColumn><C1DisplayColumn><Head" +
				"ingStyle parent=\"Style2\" me=\"Style22\" /><Style parent=\"Style1\" me=\"Style23\" /><F" +
				"ooterStyle parent=\"Style3\" me=\"Style24\" /><EditorStyle parent=\"Style5\" me=\"Style" +
				"25\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style45\" /><GroupFooterStyle parent=" +
				"\"Style1\" me=\"Style44\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</C" +
				"olumnDivider><Height>15</Height><DCIdx>4</DCIdx></C1DisplayColumn></internalCols" +
				"></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent=\"\" me=\"Norm" +
				"al\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" " +
				"/><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /" +
				"><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /><St" +
				"yle parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><S" +
				"tyle parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /" +
				"><Style parent=\"Normal\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" /></" +
				"NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified" +
				"</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 460, 236</" +
				"ClientArea><PrintPageHeaderStyle parent=\"\" me=\"Style34\" /><PrintPageFooterStyle " +
				"parent=\"\" me=\"Style35\" /></Blob>";
			// 
			// dsComposer1
			// 
			this.dsComposer1.DataSetName = "DsComposer";
			this.dsComposer1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsComposer1.Namespace = "http://www.tempuri.org/DsComposer.xsd";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Composer", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("First", "First"),
																																																					new System.Data.Common.DataColumnMapping("Last", "Last"),
																																																					new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																					new System.Data.Common.DataColumnMapping("Birth", "Birth"),
																																																					new System.Data.Common.DataColumnMapping("Death", "Death")})});
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
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=4;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Birth, Country, Death, First, Last FROM Composer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 254);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial 14";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsComposer1)).EndInit();
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
			this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);
			oleDbDataAdapter1.Fill(dsComposer1);

			//create an additional split
			c1TrueDBGrid1.InsertHorizontalSplit(0);

			//hide all columns in the leftmost split except 0 and 1
			int x;
			for (x = 2; x < c1TrueDBGrid1.Columns.Count; x++)
			{
				c1TrueDBGrid1.Splits[0].DisplayColumns[x].Visible = false;
			}

			//configure split 0 to display exactly 2 columns
			c1TrueDBGrid1.Splits[0].SplitSizeMode = C1.Win.C1TrueDBGrid.SizeModeEnum.NumberOfColumns;
			c1TrueDBGrid1.Splits[0].SplitSize = 2;
			c1TrueDBGrid1.Splits[0].AllowHorizontalSizing = false;

			//make columns 0 and 1 invisible in split 1
			c1TrueDBGrid1.Splits[1].DisplayColumns[0].Visible = false;
			c1TrueDBGrid1.Splits[1].DisplayColumns[1].Visible = false;

			//turn off recordselectors in split 1
			c1TrueDBGrid1.Splits[1].RecordSelectors = false;

		}
		private string GetModifiedConnectionString(string connstring)
		{
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
		}
	}
}
