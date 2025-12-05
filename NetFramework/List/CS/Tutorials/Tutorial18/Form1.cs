using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial18
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.List.C1List C1List1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		internal C1.Win.List.C1Combo c1Combo4;
		internal C1.Win.List.C1Combo c1Combo3;
		internal C1.Win.List.C1Combo c1Combo2;
		internal C1.Win.List.C1Combo c1Combo1;
		private DsCustomers dsCustomers1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
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
			C1.Win.List.Style style1 = new C1.Win.List.Style();
			C1.Win.List.Style style2 = new C1.Win.List.Style();
			C1.Win.List.Style style3 = new C1.Win.List.Style();
			C1.Win.List.Style style4 = new C1.Win.List.Style();
			C1.Win.List.Style style5 = new C1.Win.List.Style();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			C1.Win.List.Style style6 = new C1.Win.List.Style();
			C1.Win.List.Style style7 = new C1.Win.List.Style();
			C1.Win.List.Style style8 = new C1.Win.List.Style();
			C1.Win.List.Style style9 = new C1.Win.List.Style();
			C1.Win.List.Style style10 = new C1.Win.List.Style();
			C1.Win.List.Style style11 = new C1.Win.List.Style();
			C1.Win.List.Style style12 = new C1.Win.List.Style();
			C1.Win.List.Style style13 = new C1.Win.List.Style();
			C1.Win.List.Style style14 = new C1.Win.List.Style();
			C1.Win.List.Style style15 = new C1.Win.List.Style();
			C1.Win.List.Style style16 = new C1.Win.List.Style();
			C1.Win.List.Style style17 = new C1.Win.List.Style();
			C1.Win.List.Style style18 = new C1.Win.List.Style();
			C1.Win.List.Style style19 = new C1.Win.List.Style();
			C1.Win.List.Style style20 = new C1.Win.List.Style();
			C1.Win.List.Style style21 = new C1.Win.List.Style();
			C1.Win.List.Style style22 = new C1.Win.List.Style();
			C1.Win.List.Style style23 = new C1.Win.List.Style();
			C1.Win.List.Style style24 = new C1.Win.List.Style();
			C1.Win.List.Style style25 = new C1.Win.List.Style();
			C1.Win.List.Style style26 = new C1.Win.List.Style();
			C1.Win.List.Style style27 = new C1.Win.List.Style();
			C1.Win.List.Style style28 = new C1.Win.List.Style();
			C1.Win.List.Style style29 = new C1.Win.List.Style();
			C1.Win.List.Style style30 = new C1.Win.List.Style();
			C1.Win.List.Style style31 = new C1.Win.List.Style();
			C1.Win.List.Style style32 = new C1.Win.List.Style();
			C1.Win.List.Style style33 = new C1.Win.List.Style();
			C1.Win.List.Style style34 = new C1.Win.List.Style();
			C1.Win.List.Style style35 = new C1.Win.List.Style();
			C1.Win.List.Style style36 = new C1.Win.List.Style();
			C1.Win.List.Style style37 = new C1.Win.List.Style();
			C1.Win.List.Style style38 = new C1.Win.List.Style();
			C1.Win.List.Style style39 = new C1.Win.List.Style();
			C1.Win.List.Style style40 = new C1.Win.List.Style();
			this.C1List1 = new C1.Win.List.C1List();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.c1Combo4 = new C1.Win.List.C1Combo();
			this.c1Combo3 = new C1.Win.List.C1Combo();
			this.c1Combo2 = new C1.Win.List.C1Combo();
			this.c1Combo1 = new C1.Win.List.C1Combo();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dsCustomers1 = new Tutorial18.DsCustomers();
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustomers1)).BeginInit();
			this.SuspendLayout();
			// 
			// C1List1
			// 
			this.C1List1.AddItemSeparator = ';';
			this.C1List1.CaptionHeight = 17;
			this.C1List1.CaptionStyle = style1;
			this.C1List1.ColumnCaptionHeight = 17;
			this.C1List1.ColumnFooterHeight = 17;
			this.C1List1.ColumnWidth = 100;
			this.C1List1.DataMember = "Customer";
			this.C1List1.DataSource = this.dsCustomers1;
			this.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
			this.C1List1.DisplayMember = "Company";
			this.C1List1.EvenRowStyle = style2;
			this.C1List1.FooterStyle = style3;
			this.C1List1.HeadingStyle = style4;
			this.C1List1.HighLightRowStyle = style5;
			this.C1List1.Images.Add(((System.Drawing.Image)(resources.GetObject("C1List1.Images"))));
			this.C1List1.ItemHeight = 15;
			this.C1List1.Location = new System.Drawing.Point(32, 24);
			this.C1List1.MatchEntryTimeout = ((long)(2000));
			this.C1List1.Name = "C1List1";
			this.C1List1.OddRowStyle = style6;
			this.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1List1.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1List1.SelectedStyle = style7;
			this.C1List1.Size = new System.Drawing.Size(496, 288);
			this.C1List1.Style = style8;
			this.C1List1.TabIndex = 0;
			this.C1List1.Text = "C1List1";
			this.C1List1.PropBag = resources.GetString("C1List1.PropBag");
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 336);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "MatchCol";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 336);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Compare Mode:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(304, 336);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "MatchEntryTimeout:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(448, 336);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "MatchEntry:";
			// 
			// c1Combo4
			// 
			this.c1Combo4.AddItemSeparator = ';';
			this.c1Combo4.Caption = "";
			this.c1Combo4.CaptionHeight = 17;
			this.c1Combo4.CaptionStyle = style9;
			this.c1Combo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo4.ColumnCaptionHeight = 17;
			this.c1Combo4.ColumnFooterHeight = 17;
			this.c1Combo4.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList;
			this.c1Combo4.ContentHeight = 15;
			this.c1Combo4.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.c1Combo4.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo4.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo4.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.c1Combo4.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo4.EditorHeight = 15;
			this.c1Combo4.EvenRowStyle = style10;
			this.c1Combo4.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
			this.c1Combo4.FooterStyle = style11;
			this.c1Combo4.GapHeight = 2;
			this.c1Combo4.HeadingStyle = style12;
			this.c1Combo4.HighLightRowStyle = style13;
			this.c1Combo4.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo4.Images"))));
			this.c1Combo4.ItemHeight = 15;
			this.c1Combo4.Location = new System.Drawing.Point(304, 360);
			this.c1Combo4.MatchEntryTimeout = ((long)(100));
			this.c1Combo4.MaxDropDownItems = ((short)(5));
			this.c1Combo4.MaxLength = 32767;
			this.c1Combo4.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo4.Name = "c1Combo4";
			this.c1Combo4.OddRowStyle = style14;
			this.c1Combo4.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo4.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.c1Combo4.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo4.SelectedStyle = style15;
			this.c1Combo4.Size = new System.Drawing.Size(104, 21);
			this.c1Combo4.Style = style16;
			this.c1Combo4.TabIndex = 19;
			this.c1Combo4.TabStop = false;
			this.c1Combo4.Text = "C1Combo4";
			this.c1Combo4.Change += new C1.Win.List.ChangeEventHandler(this.C1Combo4_Change);
			this.c1Combo4.PropBag = resources.GetString("c1Combo4.PropBag");
			// 
			// c1Combo3
			// 
			this.c1Combo3.AddItemSeparator = ';';
			this.c1Combo3.Caption = "";
			this.c1Combo3.CaptionHeight = 17;
			this.c1Combo3.CaptionStyle = style17;
			this.c1Combo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo3.ColumnCaptionHeight = 17;
			this.c1Combo3.ColumnFooterHeight = 17;
			this.c1Combo3.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList;
			this.c1Combo3.ContentHeight = 15;
			this.c1Combo3.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.c1Combo3.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo3.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo3.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.c1Combo3.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo3.EditorHeight = 15;
			this.c1Combo3.EvenRowStyle = style18;
			this.c1Combo3.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
			this.c1Combo3.FooterStyle = style19;
			this.c1Combo3.GapHeight = 2;
			this.c1Combo3.HeadingStyle = style20;
			this.c1Combo3.HighLightRowStyle = style21;
			this.c1Combo3.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo3.Images"))));
			this.c1Combo3.ItemHeight = 15;
			this.c1Combo3.Location = new System.Drawing.Point(448, 360);
			this.c1Combo3.MatchEntryTimeout = ((long)(100));
			this.c1Combo3.MaxDropDownItems = ((short)(5));
			this.c1Combo3.MaxLength = 32767;
			this.c1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo3.Name = "c1Combo3";
			this.c1Combo3.OddRowStyle = style22;
			this.c1Combo3.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo3.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.c1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo3.SelectedStyle = style23;
			this.c1Combo3.Size = new System.Drawing.Size(80, 21);
			this.c1Combo3.Style = style24;
			this.c1Combo3.TabIndex = 18;
			this.c1Combo3.TabStop = false;
			this.c1Combo3.Text = "C1Combo3";
			this.c1Combo3.Change += new C1.Win.List.ChangeEventHandler(this.C1Combo3_Change);
			this.c1Combo3.PropBag = resources.GetString("c1Combo3.PropBag");
			// 
			// c1Combo2
			// 
			this.c1Combo2.AddItemSeparator = ';';
			this.c1Combo2.Caption = "";
			this.c1Combo2.CaptionHeight = 17;
			this.c1Combo2.CaptionStyle = style25;
			this.c1Combo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo2.ColumnCaptionHeight = 17;
			this.c1Combo2.ColumnFooterHeight = 17;
			this.c1Combo2.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList;
			this.c1Combo2.ContentHeight = 15;
			this.c1Combo2.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.c1Combo2.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo2.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo2.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.c1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo2.EditorHeight = 15;
			this.c1Combo2.EvenRowStyle = style26;
			this.c1Combo2.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
			this.c1Combo2.FooterStyle = style27;
			this.c1Combo2.GapHeight = 2;
			this.c1Combo2.HeadingStyle = style28;
			this.c1Combo2.HighLightRowStyle = style29;
			this.c1Combo2.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo2.Images"))));
			this.c1Combo2.ItemHeight = 15;
			this.c1Combo2.Location = new System.Drawing.Point(168, 360);
			this.c1Combo2.MatchEntryTimeout = ((long)(100));
			this.c1Combo2.MaxDropDownItems = ((short)(5));
			this.c1Combo2.MaxLength = 32767;
			this.c1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo2.Name = "c1Combo2";
			this.c1Combo2.OddRowStyle = style30;
			this.c1Combo2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo2.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.c1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo2.SelectedStyle = style31;
			this.c1Combo2.Size = new System.Drawing.Size(88, 21);
			this.c1Combo2.Style = style32;
			this.c1Combo2.TabIndex = 17;
			this.c1Combo2.TabStop = false;
			this.c1Combo2.Text = "C1Combo2";
			this.c1Combo2.Change += new C1.Win.List.ChangeEventHandler(this.C1Combo2_Change);
			this.c1Combo2.PropBag = resources.GetString("c1Combo2.PropBag");
			// 
			// c1Combo1
			// 
			this.c1Combo1.AddItemSeparator = ';';
			this.c1Combo1.Caption = "";
			this.c1Combo1.CaptionHeight = 17;
			this.c1Combo1.CaptionStyle = style33;
			this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo1.ColumnCaptionHeight = 17;
			this.c1Combo1.ColumnFooterHeight = 17;
			this.c1Combo1.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList;
			this.c1Combo1.ContentHeight = 15;
			this.c1Combo1.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo1.EditorHeight = 15;
			this.c1Combo1.EvenRowStyle = style34;
			this.c1Combo1.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
			this.c1Combo1.FooterStyle = style35;
			this.c1Combo1.GapHeight = 2;
			this.c1Combo1.HeadingStyle = style36;
			this.c1Combo1.HighLightRowStyle = style37;
			this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
			this.c1Combo1.ItemHeight = 15;
			this.c1Combo1.Location = new System.Drawing.Point(32, 360);
			this.c1Combo1.MatchEntryTimeout = ((long)(100));
			this.c1Combo1.MaxDropDownItems = ((short)(5));
			this.c1Combo1.MaxLength = 32767;
			this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo1.Name = "c1Combo1";
			this.c1Combo1.OddRowStyle = style38;
			this.c1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo1.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo1.SelectedStyle = style39;
			this.c1Combo1.Size = new System.Drawing.Size(112, 21);
			this.c1Combo1.Style = style40;
			this.c1Combo1.TabIndex = 16;
			this.c1Combo1.TabStop = false;
			this.c1Combo1.Text = "C1Combo1";
			this.c1Combo1.Change += new C1.Win.List.ChangeEventHandler(this.C1Combo1_Change);
			this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT     Customer.*\r\nFROM         Customer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("UserCode", "UserCode"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("Company", "Company"),
                        new System.Data.Common.DataColumnMapping("Contacted", "Contacted"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("CustType", "CustType")})});
			// 
			// oleDbConnection1
			// 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"..\\..\\..\\Data\\C1ListDemo.mdb\"";
			// 
			// dsCustomers1
			// 
			this.dsCustomers1.DataSetName = "DsCustomers";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 397);
			this.Controls.Add(this.c1Combo4);
			this.Controls.Add(this.c1Combo3);
			this.Controls.Add(this.c1Combo2);
			this.Controls.Add(this.c1Combo1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.C1List1);
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial18";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
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
			//Fill the dataset
			this.oleDbConnection1.ConnectionString = AdjustConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dsCustomers1);

			//Fill combo1
			this.c1Combo1.AddItem("Current Mouse Position");
			this.c1Combo1.AddItem("DisplayMember");
			this.c1Combo1.AddItem("Current Selected Col");
			this.c1Combo1.SelectedIndex = 0;

			//Fill combo2
			this.c1Combo2.AddItem("Partial Include");
			this.c1Combo2.AddItem("Equal");
			this.c1Combo2.AddItem("Less Than");
			this.c1Combo2.AddItem("Greater Than");
			this.c1Combo2.SelectedIndex = 0;

			//Fill Combo3
			this.c1Combo3.AddItem("Standard");
			this.c1Combo3.AddItem("Extended");
			this.c1Combo3.SelectedIndex = 0;

			//Fill Combo4
			this.c1Combo4.AddItem("2000");
			this.c1Combo4.AddItem("1000");
			this.c1Combo4.AddItem("3000");
			this.c1Combo4.SelectedIndex = 0;

			//Start
			this.C1List1.MatchCol = C1.Win.List.MatchColEnum.CurrentMousePos;
			this.C1List1.MatchCompare = C1.Win.List.MatchCompareEnum.PartiallyEqual;
			this.C1List1.MatchEntry = C1.Win.List.MatchEntryEnum.Standard;
			this.C1List1.MatchEntryTimeout = 2000;
		}


		private void C1Combo1_Change(object sender, System.EventArgs e)
		{
			switch ((string)this.c1Combo1.Text)
			{
				case "Current Mouse Position":
					this.C1List1.MatchCol = C1.Win.List.MatchColEnum.CurrentMousePos;
					break;
				case "DisplayMember":
					this.C1List1.MatchCol = C1.Win.List.MatchColEnum.DisplayMember;
					break;
				case "Current Selected Col":
					this.C1List1.MatchCol = C1.Win.List.MatchColEnum.CurrentSelectedCol;
					break;
			}
		}

		private void C1Combo2_Change(object sender, System.EventArgs e)
		{
			switch((string)this.c1Combo2.Text)
			{
				case "Partial Include":
					this.C1List1.MatchCompare = C1.Win.List.MatchCompareEnum.PartiallyEqual;
					break;
				case "Equal":
					this.C1List1.MatchCompare = C1.Win.List.MatchCompareEnum.Equal;
					break;
				case "Less Than":
					this.C1List1.MatchCompare = C1.Win.List.MatchCompareEnum.LessThan;
					break;
				case "Greater Than":
					this.C1List1.MatchCompare = C1.Win.List.MatchCompareEnum.GreaterThan;
					break;
			}
		}

		private void C1Combo3_Change(object sender, System.EventArgs e)
		{
			switch ((string)c1Combo3.Text)
			{
				case "Standard":
					C1List1.MatchEntry = C1.Win.List.MatchEntryEnum.Standard;
					break;
				case "Extended":
					C1List1.MatchEntry = C1.Win.List.MatchEntryEnum.Extended;
					break;
			}
		}

		private void C1Combo4_Change(object sender, System.EventArgs e)
		{
			switch((string)this.c1Combo4.Text)
			{
				case "2000":
					C1List1.MatchEntryTimeout = 2000;
					break;
				case "1000":
					C1List1.MatchEntryTimeout = 1000;
					break;
				case "3000":
					C1List1.MatchEntryTimeout = 3000;
					break;
			}
		}

		private string AdjustConnectionString(string connectionString)
		{
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ComponentOne Samples\\Common\\C1NWind.mdb" + "\"";
		}
	}
}
