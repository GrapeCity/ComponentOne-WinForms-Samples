using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial_22
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Tutorial_22.DsCustomer dsCustomer1;
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
            this.dsCustomer1 = new Tutorial_22.DsCustomer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustomer1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1TrueDBGrid1
			// 
			this.c1TrueDBGrid1.AllowAddNew = true;
			this.c1TrueDBGrid1.Caption = "C1True DBGrid .Net";
			this.c1TrueDBGrid1.CaptionHeight = 17;
			this.c1TrueDBGrid1.DataMember = "Customer";
			this.c1TrueDBGrid1.DataSource = this.dsCustomer1;
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
			this.c1TrueDBGrid1.RowHeight = 40;
			this.c1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(408, 216);
			this.c1TrueDBGrid1.TabIndex = 0;
			this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.FetchScrollTips += new C1.Win.TrueDBGrid.FetchScrollTipsEventHandler(this.c1TrueDBGrid1_FetchScrollTips);
			this.c1TrueDBGrid1.PropBag = "<?xml version=\"1.0\"?><Blob><DataCols><C1DataColumn Level=\"0\" Caption=\"Company\" Da" +
				"taField=\"Company\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Level=" +
				"\"0\" Caption=\"Contacted\" DataField=\"Contacted\"><ValueItems /><GroupInfo /></C1Dat" +
				"aColumn><C1DataColumn Level=\"0\" Caption=\"FirstName\" DataField=\"FirstName\"><Value" +
				"Items /><GroupInfo /></C1DataColumn><C1DataColumn Level=\"0\" Caption=\"LastName\" D" +
				"ataField=\"LastName\"><ValueItems /><GroupInfo /></C1DataColumn><C1DataColumn Leve" +
				"l=\"0\" Caption=\"Phone\" DataField=\"Phone\"><ValueItems /><GroupInfo /></C1DataColum" +
				"n><C1DataColumn Level=\"0\" Caption=\"UserCode\" DataField=\"UserCode\"><ValueItems />" +
				"<GroupInfo /></C1DataColumn></DataCols><Styles type=\"C1.Win.TrueDBGrid.Design." +
				"ContextWrapper\"><Data>RecordSelector{AlignImage:Center;}Style31{AlignHorz:Far;}S" +
				"tyle51{}Style50{}Caption{AlignHorz:Center;}Normal{}Selected{ForeColor:HighlightT" +
				"ext;BackColor:Highlight;}Editor{}Style18{AlignHorz:Far;}Style19{AlignHorz:Far;}S" +
				"tyle14{AlignHorz:Near;}Style15{AlignHorz:Near;}Style16{}Style17{}Style10{AlignHo" +
				"rz:Near;}Style11{}Style12{}Style13{}Style44{}Style45{}Style46{}Style47{}Style38{" +
				"}Style37{}Style34{AlignHorz:Near;}Style35{AlignHorz:Near;}Style32{}Style33{}OddR" +
				"ow{}Footer{}Style29{}Style28{}Style27{AlignHorz:Near;}Style26{AlignHorz:Near;}St" +
				"yle25{}Style24{}Style23{AlignHorz:Near;}Style22{AlignHorz:Near;}Style21{}Style20" +
				"{}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}EvenRow{Back" +
				"Color:Aqua;}Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeCol" +
				"or:ControlText;BackColor:Control;}Style49{}Style48{}Style2{}Style40{}Style41{}Fi" +
				"lterBar{}Style42{}Style43{}Style4{}Style9{}Style8{}Style39{}Style36{}Style5{}Gro" +
				"up{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style7{}Style" +
				"6{}Style1{}Style30{AlignHorz:Far;}Style3{}HighlightRow{ForeColor:HighlightText;B" +
				"ackColor:Highlight;}</Data></Styles><Splits><C1.Win.TrueDBGrid.MergeView Name=" +
				"\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"17\" MarqueeSt" +
				"yle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecSelWidth=\"17\" VerticalScro" +
				"llGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 17, 404, 195</ClientRect><B" +
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
				"ecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 404, 212</ClientArea><PrintP" +
				"ageHeaderStyle parent=\"\" me=\"Style38\" /><PrintPageFooterStyle parent=\"\" me=\"Styl" +
				"e39\" /></Blob>";
			// 
			// dsCustomer1
			// 
			this.dsCustomer1.DataSetName = "DsCustomer";
			this.dsCustomer1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsCustomer1.Namespace = "http://www.tempuri.org/DsCustomer.xsd";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.comboBox4,
																					this.comboBox3,
																					this.comboBox2,
																					this.comboBox1,
																					this.label4,
																					this.label3,
																					this.label2,
																					this.label1});
			this.groupBox1.Location = new System.Drawing.Point(16, 232);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 224);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Border Size";
			// 
			// comboBox4
			// 
			this.comboBox4.Location = new System.Drawing.Point(112, 120);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(96, 21);
			this.comboBox4.TabIndex = 7;
			this.comboBox4.Text = "comboBox4";
			this.comboBox4.SelectionChangeCommitted += new System.EventHandler(this.comboBox4_SelectionChangeCommitted);
			// 
			// comboBox3
			// 
			this.comboBox3.Location = new System.Drawing.Point(112, 88);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(96, 21);
			this.comboBox3.TabIndex = 6;
			this.comboBox3.Text = "comboBox3";
			this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
			// 
			// comboBox2
			// 
			this.comboBox2.Location = new System.Drawing.Point(112, 56);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(96, 21);
			this.comboBox2.TabIndex = 5;
			this.comboBox2.Text = "comboBox2";
			this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(112, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(96, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "comboBox1";
			this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.label4.Location = new System.Drawing.Point(8, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Right Width";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.label3.Location = new System.Drawing.Point(8, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Left Width";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Bottom Width";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Top Width";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.label5.Location = new System.Drawing.Point(264, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "Border Appearance";
			// 
			// comboBox5
			// 
			this.comboBox5.Location = new System.Drawing.Point(264, 272);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(144, 21);
			this.comboBox5.TabIndex = 3;
			this.comboBox5.Text = "comboBox5";
			this.comboBox5.SelectionChangeCommitted += new System.EventHandler(this.comboBox5_SelectionChangeCommitted);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(264, 304);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 48);
			this.button1.TabIndex = 4;
			this.button1.Text = "Border Color";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.checkBox2,
																					this.checkBox1});
			this.groupBox2.Location = new System.Drawing.Point(264, 368);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(144, 88);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Scrolling";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(16, 56);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 16);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Scroll Tracking";
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(16, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 16);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Scroll Tips";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// oleDbDataAdapter1
			// 
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
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Customer(Company, Contacted, FirstName, LastName, Phone, UserCode) VA" +
				"LUES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode"));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\TDBGDemo.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Company, Contacted, FirstName, LastName, Phone, UserCode FROM Customer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 477);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox2,
																		  this.button1,
																		  this.comboBox5,
																		  this.label5,
																		  this.groupBox1,
																		  this.c1TrueDBGrid1});
			this.Name = "Form1";
			this.Text = "Tutorial 22 ";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustomer1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		
		DataTable dbTable; //a copy of the data
		Color borderColor;
		int borderLeft, borderTop, borderRight, borderBottom;
		C1.Win.TrueDBGrid.BorderTypeEnum borderType;

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.oleDbConnection1.ConnectionString = GetModifiedConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dsCustomer1);
			dbTable = this.dsCustomer1.Tables[0].Copy();
			FillComboBorderAppearance();
			FillComboBorderSize(comboBox1);
			FillComboBorderSize(comboBox2);
			FillComboBorderSize(comboBox3);
			FillComboBorderSize(comboBox4);
			this.checkBox2.Checked = true;

			//init border sizes
			this.borderBottom = 1;
			this.borderLeft = 1;
			this.borderRight = 1;
			this.borderTop = 1;
		}

		private void FillComboBorderAppearance()
		{
			//fill the border appearance combo box
			this.comboBox5.Items.Add("Fillet");
			this.comboBox5.Items.Add("Flat");
			this.comboBox5.Items.Add("Groove");
			this.comboBox5.Items.Add("Inset");
			this.comboBox5.Items.Add("InsetBevel");
			this.comboBox5.Items.Add("None");
			this.comboBox5.Items.Add("Raised");
			this.comboBox5.Items.Add("RaisedBevel");
			this.comboBox5.SelectedItem = "None";
		}

		private void FillComboBorderSize(ComboBox combo)
		{
			//fill each combo with number 1 to 10
			combo.Text = "1";
			for(int i = 1; i != 11; i++) 
				combo.Items.Add(i.ToString());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = this.colorDialog1.ShowDialog();
			if(result == DialogResult.OK)
			{
				borderColor = this.colorDialog1.Color;
				button1.BackColor = borderColor;
			}
			UpdateBorder();
		}

		private void UpdateBorder()
		{
			C1.Win.TrueDBGrid.C1DisplayColumn column;
			column = this.c1TrueDBGrid1.Splits[0].DisplayColumns[this.c1TrueDBGrid1.Col];
			column.Style.Borders.Color = this.colorDialog1.Color;
			column.Style.Borders.BorderType = borderType;
			column.Style.Borders.Bottom = borderBottom;
			column.Style.Borders.Left = borderLeft;
			column.Style.Borders.Top = borderTop;
			column.Style.Borders.Right = borderRight;
		}

		private void comboBox5_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			switch(comboBox5.SelectedIndex)
			{
				case 0:
				{
					borderType = C1.Win.TrueDBGrid.BorderTypeEnum.Fillet;
					break;
				}
				case 1:
				{
					borderType = C1.Win.TrueDBGrid.BorderTypeEnum.Flat;
					break;
				}
				case 2:
				{
					borderType = C1.Win.TrueDBGrid.BorderTypeEnum.Groove;
					break;
				}
				case 3:
				{
					borderType = C1.Win.TrueDBGrid.BorderTypeEnum.Inset;
					break;
				}
				case 4:
				{
					borderType = C1.Win.TrueDBGrid.BorderTypeEnum.InsetBevel;
					break;
				}
				case 5:
				{
					borderType = C1.Win.TrueDBGrid.BorderTypeEnum.None;
					break;
				}
				case 6:
				{
					borderType = C1.Win.TrueDBGrid.BorderTypeEnum.Raised;
					break;
				}
				case 7:
				{
					borderType = C1.Win.TrueDBGrid.BorderTypeEnum.RaisedBevel;
					break;
				}
			}
			this.UpdateBorder();
		}

		private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			borderTop = int.Parse(comboBox1.SelectedItem.ToString());
			UpdateBorder();
		}

		private void comboBox2_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			borderBottom = int.Parse(comboBox2.SelectedItem.ToString());
			UpdateBorder();
		}

		private void comboBox3_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			borderLeft = int.Parse(comboBox3.SelectedItem.ToString());
			UpdateBorder();
		}

		private void comboBox4_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			borderRight = int.Parse(comboBox4.SelectedItem.ToString());
			UpdateBorder();
		}

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			c1TrueDBGrid1.ScrollTips = checkBox1.Checked;
		}

		private void checkBox2_Click(object sender, System.EventArgs e)
		{
			c1TrueDBGrid1.ScrollTrack = checkBox2.Checked;
		}

		private void c1TrueDBGrid1_FetchScrollTips(object sender, C1.Win.TrueDBGrid.FetchScrollTipsEventArgs e)
		{
			//set the scrolltip depending on which scroll bar has moved
			switch(e.ScrollBar)
			{
				case C1.Win.TrueDBGrid.ScrollBarEnum.Horizontal:
				{
					e.ScrollTip = c1TrueDBGrid1.Columns[e.ColIndex].Caption;
					break;
				}
				case C1.Win.TrueDBGrid.ScrollBarEnum.Vertical:
				{
					long row = e.Row + 1;
					e.ScrollTip = "Record: " + row.ToString() + " of " +
						dbTable.Rows.Count.ToString() + "\n" +
						"Company: " + dbTable.Rows[e.Row]["Company"].ToString() + "\n" + 
						"User code: " + dbTable.Rows[e.Row]["UserCode"].ToString();
					break;
				}
			}
			e.TipStyle.ForeColor = Color.Blue;
		}
		private string GetModifiedConnectionString(string connstring)
		{
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
		}
	}
}
