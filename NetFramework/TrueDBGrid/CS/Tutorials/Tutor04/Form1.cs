using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace tutorial_4
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private tutorial_4.DSCustomers dsCustomers1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
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

			this.dsCustomers1 = new tutorial_4.DSCustomers();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.AllowAddNew = true;
			this.c1TrueDBGrid1.AllowDelete = true;
			this.c1TrueDBGrid1.Caption = "C1True DBGrid .Net";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.DataMember = "Customer";
			this.c1TrueDBGrid1.DataSource = this.dsCustomers1;
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
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(384, 224);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Company\" Da" +
				"taField=\"Company\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=" +
				"\"0\" Caption=\"Contacted\" DataField=\"Contacted\"><ValueItems /><GroupInfo /></C1Dat" +
				"aColumn><C1DataColumn Level=\"0\" Caption=\"FirstName\" DataField=\"FirstName\"><Value" +
				"Items /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"LastName\" D" +
				"ataField=\"LastName\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Leve" +
				"l=\"0\" Caption=\"Phone\" DataField=\"Phone\"><ValueItems /><GroupInfo /></C1DataColum" +
				"n><C1DataColumn Level=\"0\" Caption=\"UserCode\" DataField=\"UserCode\"><ValueItems />" +
				"<GroupInfo /></C1DataColumn></DataCols><Styles type=\"C1.Win.C1TrueDBGrid.Design." +
				"ContextWrapper\"><Data>Style39{}Style50{}Style51{}Caption{AlignHorz:Center;}Style" +
				"27{AlignHorz:Near;}Normal{}Style25{}Style24{}Editor{}Style48{}Style18{AlignHorz:" +
				"Far;}Style19{AlignHorz:Far;}Style14{AlignHorz:Near;}Style15{AlignHorz:Near;}Styl" +
				"e16{}Style17{}Style10{AlignHorz:Near;}Style11{}OddRow{}Style13{}Style42{}Style43" +
				"{}Style44{}Style45{}Style46{}Style47{}Style38{}Style12{}Style29{}Style28{}Highli" +
				"ghtRow{ForeColor:HighlightText;BackColor:Highlight;}Style26{AlignHorz:Near;}Reco" +
				"rdSelector{AlignImage:Center;}Footer{}Style23{AlignHorz:Near;}Style22{AlignHorz:" +
				"Near;}Style21{}Style20{}Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor" +
				":ControlDark;}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}" +
				"EvenRow{BackColor:Aqua;}Heading{Wrap:True;BackColor:Control;Border:Raised,,1, 1," +
				" 1, 1;ForeColor:ControlText;AlignVert:Center;}Style49{}Style3{}Style5{}Style41{}" +
				"Style7{}Style6{}FilterBar{}Style40{}Selected{ForeColor:HighlightText;BackColor:H" +
				"ighlight;}Style4{}Style9{}Style8{}Style1{}Style36{}Style37{}Style34{AlignHorz:Ne" +
				"ar;}Style35{AlignHorz:Near;}Style32{}Style33{}Style30{AlignHorz:Far;}Style31{Ali" +
				"gnHorz:Far;}Style2{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name=" +
				"\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"17\" MarqueeSt" +
				"yle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecSelWidth=\"17\" VerticalScro" +
				"llGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 17, 380, 203</ClientRect><B" +
				"orderSide>0</BorderSide><CaptionStyle parent=\"Style2\" me=\"Style10\" /><EditorStyl" +
				"e parent=\"Editor\" me=\"Style5\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style8\" /><Fi" +
				"lterBarStyle parent=\"FilterBar\" me=\"Style13\" /><FooterStyle parent=\"Footer\" me=\"" +
				"Style3\" /><GroupStyle parent=\"Group\" me=\"Style12\" /><HeadingStyle parent=\"Headin" +
				"g\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style7\" /><Inactiv" +
				"eStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style9\" " +
				"/><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" /><SelectedStyle par" +
				"ent=\"Selected\" me=\"Style6\" /><Style parent=\"Normal\" me=\"Style1\" /><internalCols>" +
				"<C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style14\" /><Style parent=\"Sty" +
				"le1\" me=\"Style15\" /><FooterStyle parent=\"Style3\" me=\"Style16\" /><EditorStyle par" +
				"ent=\"Style5\" me=\"Style17\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style41\" /><Gr" +
				"oupFooterStyle parent=\"Style1\" me=\"Style40\" /><Visible>True</Visible><ColumnDivi" +
				"der>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>0</DCIdx></C1Displa" +
				"yColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style18\" /><Style par" +
				"ent=\"Style1\" me=\"Style19\" /><FooterStyle parent=\"Style3\" me=\"Style20\" /><EditorS" +
				"tyle parent=\"Style5\" me=\"Style21\" /><GroupHeaderStyle parent=\"Style1\" me=\"Style4" +
				"3\" /><GroupFooterStyle parent=\"Style1\" me=\"Style42\" /><Visible>True</Visible><Co" +
				"lumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>1</DCIdx></" +
				"C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style22\" /><S" +
				"tyle parent=\"Style1\" me=\"Style23\" /><FooterStyle parent=\"Style3\" me=\"Style24\" />" +
				"<EditorStyle parent=\"Style5\" me=\"Style25\" /><GroupHeaderStyle parent=\"Style1\" me" +
				"=\"Style45\" /><GroupFooterStyle parent=\"Style1\" me=\"Style44\" /><Visible>True</Vis" +
				"ible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><DCIdx>2</" +
				"DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" me=\"Style" +
				"26\" /><Style parent=\"Style1\" me=\"Style27\" /><FooterStyle parent=\"Style3\" me=\"Sty" +
				"le28\" /><EditorStyle parent=\"Style5\" me=\"Style29\" /><GroupHeaderStyle parent=\"St" +
				"yle1\" me=\"Style47\" /><GroupFooterStyle parent=\"Style1\" me=\"Style46\" /><Visible>T" +
				"rue</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</Height><D" +
				"CIdx>3</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"Style2\" m" +
				"e=\"Style30\" /><Style parent=\"Style1\" me=\"Style31\" /><FooterStyle parent=\"Style3\"" +
				" me=\"Style32\" /><EditorStyle parent=\"Style5\" me=\"Style33\" /><GroupHeaderStyle pa" +
				"rent=\"Style1\" me=\"Style49\" /><GroupFooterStyle parent=\"Style1\" me=\"Style48\" /><V" +
				"isible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Height>15</H" +
				"eight><DCIdx>4</DCIdx></C1DisplayColumn><C1DisplayColumn><HeadingStyle parent=\"S" +
				"tyle2\" me=\"Style34\" /><Style parent=\"Style1\" me=\"Style35\" /><FooterStyle parent=" +
				"\"Style3\" me=\"Style36\" /><EditorStyle parent=\"Style5\" me=\"Style37\" /><GroupHeader" +
				"Style parent=\"Style1\" me=\"Style51\" /><GroupFooterStyle parent=\"Style1\" me=\"Style" +
				"50\" /><Visible>True</Visible><ColumnDivider>DarkGray,Single</ColumnDivider><Heig" +
				"ht>15</Height><DCIdx>5</DCIdx></C1DisplayColumn></internalCols></C1.Win.C1TrueDB" +
				"Grid.MergeView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style paren" +
				"t=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"H" +
				"eading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"No" +
				"rmal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Editor\" /><Style parent=\"Normal" +
				"\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Norma" +
				"l\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"No" +
				"rmal\" me=\"FilterBar\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertS" +
				"plits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultR" +
				"ecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 380, 220</ClientArea><PrintP" +
				"ageHeaderStyle parent=\"\" me=\"Style38\" /><PrintPageFooterStyle parent=\"\" me=\"Styl" +
				"e39\" /></Blob>";
			// 
			// dsCustomers1
			// 
			this.dsCustomers1.DataSetName = "DSCustomers";
			this.dsCustomers1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsCustomers1.Namespace = "http://www.tempuri.org/DSCustomers.xsd";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(408, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "&Update";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(408, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 32);
			this.button2.TabIndex = 2;
			this.button2.Text = "&Delete";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(408, 104);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 32);
			this.button3.TabIndex = 3;
			this.button3.Text = "&Add New";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(408, 168);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(88, 32);
			this.button4.TabIndex = 4;
			this.button4.Text = "&First";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(408, 208);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(88, 32);
			this.button5.TabIndex = 5;
			this.button5.Text = "&Next";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(408, 248);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(88, 32);
			this.button6.TabIndex = 6;
			this.button6.Text = "&Previous";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(408, 288);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(88, 32);
			this.button7.TabIndex = 7;
			this.button7.Text = "&Last";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCustomers1, "Customer.FirstName"));
			this.textBox1.Location = new System.Drawing.Point(168, 264);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 20);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = "textBox1";
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCustomers1, "Customer.LastName"));
			this.textBox2.Location = new System.Drawing.Point(168, 312);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(184, 20);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "textBox2";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCustomers1, "Customer.Company"));
			this.textBox3.Location = new System.Drawing.Point(168, 360);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(184, 20);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "textBox3";
			// 
			// listBox1
			// 
			this.listBox1.DataSource = this.dsCustomers1;
			this.listBox1.DisplayMember = "Customer.LastName";
			this.listBox1.Location = new System.Drawing.Point(8, 264);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 121);
			this.listBox1.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(168, 248);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "First Name:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 296);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Last Name:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(168, 344);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "Company:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 248);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Last Name List:";
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("UserCode", "UserCode"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("Company", "Company"),
                        new System.Data.Common.DataColumnMapping("Contacted", "Contacted"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM Customer\r\nWHERE        (UserCode = ?)";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.WChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UserCode", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO Customer(Company, Contacted, FirstName, LastName, Phone, UserCode) VA" +
    "LUES (?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"),
            new System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"),
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"),
            new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(15)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT Company, Contacted, FirstName, LastName, Phone, UserCode FROM Customer";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE       Customer\r\nSET                LastName = ?, FirstName = ?, Company = " +
    "?, Contacted = ?, Phone = ?\r\nWHERE        (UserCode = ?)";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.WChar, 15, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.WChar, 10, "FirstName"),
            new System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.WChar, 30, "Company"),
            new System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.Date, 0, "Contacted"),
            new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(15)), ((byte)(0)), "Phone", System.Data.DataRowVersion.Current, null),
            new System.Data.OleDb.OleDbParameter("Original_UserCode", System.Data.OleDb.OleDbType.WChar, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UserCode", System.Data.DataRowVersion.Original, null)});
            //
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(504, 397);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.label1,
																		  this.listBox1,
																		  this.textBox3,
																		  this.textBox2,
																		  this.textBox1,
																		  this.button7,
																		  this.button6,
																		  this.button5,
																		  this.button4,
																		  this.button3,
																		  this.button2,
																		  this.button1,
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial 04";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustomers1)).EndInit();
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
			this.oleDbDataAdapter1.Fill(this.dsCustomers1);
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			//Move to the first record in the grid
			this.c1TrueDBGrid1.MoveFirst();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			//Move to the next record in the grid
			this.c1TrueDBGrid1.MoveNext();
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			//Move to the previous record in the grid
			this.c1TrueDBGrid1.MovePrevious();
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			//Move to the last record in the grid
			this.c1TrueDBGrid1.MoveLast();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//Update the grid, call the UpdateCustomers procedure to save
			this.c1TrueDBGrid1.Update();
			UpdateCustomers();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//Delete the record and save the changes to the database
			this.c1TrueDBGrid1.Delete();
			UpdateCustomers();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//This "Add New" button moves the cursor to the "new (blank) row"
			//at the end so that the user can start adding data to the new
			//record.

			//Move to last record, "new row" will be visible
			this.c1TrueDBGrid1.MoveLast();
			//Move to the "addnew row", and set focus to the grid
			this.c1TrueDBGrid1.Row = this.c1TrueDBGrid1.Row + 1;
			this.c1TrueDBGrid1.Select();
		}

		private void UpdateCustomers()
		{
			this.oleDbConnection1.Open();
			DataSet UpdatedRows, InsertedRows, DeletedRows;
			//These three are data tables that hold any changes that have
			//been made to the dataset since the last update

			UpdatedRows = this.dsCustomers1.GetChanges(DataRowState.Modified);
			InsertedRows = this.dsCustomers1.GetChanges(DataRowState.Added);
			DeletedRows = this.dsCustomers1.GetChanges(DataRowState.Deleted);

			try
			{
				//For each of these, we have to make sure that the data tables
				//contain at least one record, otherwise we will get an error
				if(UpdatedRows != null) this.oleDbDataAdapter1.Update(UpdatedRows);
				if(InsertedRows != null) this.oleDbDataAdapter1.Update(InsertedRows);
				if(DeletedRows != null) this.oleDbDataAdapter1.Update(DeletedRows);
                dsCustomers1.AcceptChanges();
            }
            catch (System.Exception eUpdate)
			{
				MessageBox.Show("Caught exection: " + eUpdate.Message);
			}
            
			this.oleDbConnection1.Close();
		}
		private string GetModifiedConnectionString(string connstring)
		{
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
        }
	}
}
