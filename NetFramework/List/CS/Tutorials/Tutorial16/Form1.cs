using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial16
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.List.C1List C1List1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private DataTable tb;   //A copy of the data
		private Color borderColor;
		private int bLeft, bTop, bRight, bBottom;
		private C1.Win.List.BorderTypeEnum bType;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private C1.Win.List.C1Combo C1Combo4;
		private C1.Win.List.C1Combo C1Combo3;
		private C1.Win.List.C1Combo C1Combo2;
		private C1.Win.List.C1Combo C1Combo1;
		private C1.Win.List.C1Combo C1Combo5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private DsCustomer dsCustomer1;

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
			C1.Win.List.Style style41 = new C1.Win.List.Style();
			C1.Win.List.Style style42 = new C1.Win.List.Style();
			C1.Win.List.Style style43 = new C1.Win.List.Style();
			C1.Win.List.Style style44 = new C1.Win.List.Style();
			C1.Win.List.Style style45 = new C1.Win.List.Style();
			C1.Win.List.Style style46 = new C1.Win.List.Style();
			C1.Win.List.Style style47 = new C1.Win.List.Style();
			C1.Win.List.Style style48 = new C1.Win.List.Style();
			this.C1List1 = new C1.Win.List.C1List();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.C1Combo4 = new C1.Win.List.C1Combo();
			this.C1Combo3 = new C1.Win.List.C1Combo();
			this.C1Combo2 = new C1.Win.List.C1Combo();
			this.C1Combo1 = new C1.Win.List.C1Combo();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.C1Combo5 = new C1.Win.List.C1Combo();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dsCustomer1 = new Tutorial16.DsCustomer();
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.C1Combo4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.C1Combo3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.C1Combo2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.C1Combo1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.C1Combo5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustomer1)).BeginInit();
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
			this.C1List1.DataSource = this.dsCustomer1;
			this.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
			this.C1List1.EvenRowStyle = style2;
			this.C1List1.FooterStyle = style3;
			this.C1List1.HeadingStyle = style4;
			this.C1List1.HighLightRowStyle = style5;
			this.C1List1.Images.Add(((System.Drawing.Image)(resources.GetObject("C1List1.Images"))));
			this.C1List1.ItemHeight = 15;
			this.C1List1.Location = new System.Drawing.Point(32, 16);
			this.C1List1.MatchEntryTimeout = ((long)(2000));
			this.C1List1.Name = "C1List1";
			this.C1List1.OddRowStyle = style6;
			this.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1List1.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1List1.SelectedStyle = style7;
			this.C1List1.Size = new System.Drawing.Size(536, 328);
			this.C1List1.Style = style8;
			this.C1List1.TabIndex = 0;
			this.C1List1.Text = "C1List1";
			this.C1List1.FetchScrollTips += new C1.Win.List.FetchScrollTipsEventHandler(this.C1List1_FetchScrollTips);
			this.C1List1.PropBag = resources.GetString("C1List1.PropBag");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.C1Combo4);
			this.groupBox1.Controls.Add(this.C1Combo3);
			this.groupBox1.Controls.Add(this.C1Combo2);
			this.groupBox1.Controls.Add(this.C1Combo1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(32, 360);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 224);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Border Size";
			// 
			// C1Combo4
			// 
			this.C1Combo4.AddItemSeparator = ';';
			this.C1Combo4.Caption = "";
			this.C1Combo4.CaptionHeight = 17;
			this.C1Combo4.CaptionStyle = style9;
			this.C1Combo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.C1Combo4.ColumnCaptionHeight = 17;
			this.C1Combo4.ColumnFooterHeight = 17;
			this.C1Combo4.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList;
			this.C1Combo4.ContentHeight = 15;
			this.C1Combo4.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.C1Combo4.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.C1Combo4.EditorBackColor = System.Drawing.SystemColors.Window;
			this.C1Combo4.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1Combo4.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.C1Combo4.EditorHeight = 15;
			this.C1Combo4.EvenRowStyle = style10;
			this.C1Combo4.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
			this.C1Combo4.FooterStyle = style11;
			this.C1Combo4.GapHeight = 2;
			this.C1Combo4.HeadingStyle = style12;
			this.C1Combo4.HighLightRowStyle = style13;
			this.C1Combo4.Images.Add(((System.Drawing.Image)(resources.GetObject("C1Combo4.Images"))));
			this.C1Combo4.ItemHeight = 15;
			this.C1Combo4.Location = new System.Drawing.Point(112, 176);
			this.C1Combo4.MatchEntryTimeout = ((long)(2000));
			this.C1Combo4.MaxDropDownItems = ((short)(5));
			this.C1Combo4.MaxLength = 32767;
			this.C1Combo4.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.C1Combo4.Name = "C1Combo4";
			this.C1Combo4.OddRowStyle = style14;
			this.C1Combo4.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1Combo4.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.C1Combo4.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1Combo4.SelectedStyle = style15;
			this.C1Combo4.Size = new System.Drawing.Size(104, 21);
			this.C1Combo4.Style = style16;
			this.C1Combo4.TabIndex = 15;
			this.C1Combo4.TabStop = false;
			this.C1Combo4.RowChange += new System.EventHandler(this.C1Combo4_RowChange);
			this.C1Combo4.PropBag = resources.GetString("C1Combo4.PropBag");
			// 
			// C1Combo3
			// 
			this.C1Combo3.AddItemSeparator = ';';
			this.C1Combo3.Caption = "";
			this.C1Combo3.CaptionHeight = 17;
			this.C1Combo3.CaptionStyle = style17;
			this.C1Combo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.C1Combo3.ColumnCaptionHeight = 17;
			this.C1Combo3.ColumnFooterHeight = 17;
			this.C1Combo3.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList;
			this.C1Combo3.ContentHeight = 15;
			this.C1Combo3.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.C1Combo3.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.C1Combo3.EditorBackColor = System.Drawing.SystemColors.Window;
			this.C1Combo3.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1Combo3.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.C1Combo3.EditorHeight = 15;
			this.C1Combo3.EvenRowStyle = style18;
			this.C1Combo3.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
			this.C1Combo3.FooterStyle = style19;
			this.C1Combo3.GapHeight = 2;
			this.C1Combo3.HeadingStyle = style20;
			this.C1Combo3.HighLightRowStyle = style21;
			this.C1Combo3.Images.Add(((System.Drawing.Image)(resources.GetObject("C1Combo3.Images"))));
			this.C1Combo3.ItemHeight = 15;
			this.C1Combo3.Location = new System.Drawing.Point(112, 128);
			this.C1Combo3.MatchEntryTimeout = ((long)(2000));
			this.C1Combo3.MaxDropDownItems = ((short)(5));
			this.C1Combo3.MaxLength = 32767;
			this.C1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.C1Combo3.Name = "C1Combo3";
			this.C1Combo3.OddRowStyle = style22;
			this.C1Combo3.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1Combo3.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.C1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1Combo3.SelectedStyle = style23;
			this.C1Combo3.Size = new System.Drawing.Size(104, 21);
			this.C1Combo3.Style = style24;
			this.C1Combo3.TabIndex = 14;
			this.C1Combo3.TabStop = false;
			this.C1Combo3.RowChange += new System.EventHandler(this.C1Combo3_RowChange);
			this.C1Combo3.PropBag = resources.GetString("C1Combo3.PropBag");
			// 
			// C1Combo2
			// 
			this.C1Combo2.AddItemSeparator = ';';
			this.C1Combo2.Caption = "";
			this.C1Combo2.CaptionHeight = 17;
			this.C1Combo2.CaptionStyle = style25;
			this.C1Combo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.C1Combo2.ColumnCaptionHeight = 17;
			this.C1Combo2.ColumnFooterHeight = 17;
			this.C1Combo2.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList;
			this.C1Combo2.ContentHeight = 15;
			this.C1Combo2.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.C1Combo2.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.C1Combo2.EditorBackColor = System.Drawing.SystemColors.Window;
			this.C1Combo2.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.C1Combo2.EditorHeight = 15;
			this.C1Combo2.EvenRowStyle = style26;
			this.C1Combo2.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
			this.C1Combo2.FooterStyle = style27;
			this.C1Combo2.GapHeight = 2;
			this.C1Combo2.HeadingStyle = style28;
			this.C1Combo2.HighLightRowStyle = style29;
			this.C1Combo2.Images.Add(((System.Drawing.Image)(resources.GetObject("C1Combo2.Images"))));
			this.C1Combo2.ItemHeight = 15;
			this.C1Combo2.Location = new System.Drawing.Point(112, 80);
			this.C1Combo2.MatchEntryTimeout = ((long)(100));
			this.C1Combo2.MaxDropDownItems = ((short)(5));
			this.C1Combo2.MaxLength = 32767;
			this.C1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.C1Combo2.Name = "C1Combo2";
			this.C1Combo2.OddRowStyle = style30;
			this.C1Combo2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1Combo2.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.C1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1Combo2.SelectedStyle = style31;
			this.C1Combo2.Size = new System.Drawing.Size(104, 21);
			this.C1Combo2.Style = style32;
			this.C1Combo2.TabIndex = 13;
			this.C1Combo2.TabStop = false;
			this.C1Combo2.RowChange += new System.EventHandler(this.C1Combo2_RowChange);
			this.C1Combo2.PropBag = resources.GetString("C1Combo2.PropBag");
			// 
			// C1Combo1
			// 
			this.C1Combo1.AddItemSeparator = ';';
			this.C1Combo1.Caption = "";
			this.C1Combo1.CaptionHeight = 17;
			this.C1Combo1.CaptionStyle = style33;
			this.C1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.C1Combo1.ColumnCaptionHeight = 17;
			this.C1Combo1.ColumnFooterHeight = 17;
			this.C1Combo1.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList;
			this.C1Combo1.ContentHeight = 15;
			this.C1Combo1.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.C1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.C1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.C1Combo1.EditorHeight = 15;
			this.C1Combo1.EvenRowStyle = style34;
			this.C1Combo1.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
			this.C1Combo1.FooterStyle = style35;
			this.C1Combo1.GapHeight = 2;
			this.C1Combo1.HeadingStyle = style36;
			this.C1Combo1.HighLightRowStyle = style37;
			this.C1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("C1Combo1.Images"))));
			this.C1Combo1.ItemHeight = 15;
			this.C1Combo1.Location = new System.Drawing.Point(112, 32);
			this.C1Combo1.MatchEntryTimeout = ((long)(100));
			this.C1Combo1.MaxDropDownItems = ((short)(5));
			this.C1Combo1.MaxLength = 32767;
			this.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.C1Combo1.Name = "C1Combo1";
			this.C1Combo1.OddRowStyle = style38;
			this.C1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1Combo1.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1Combo1.SelectedStyle = style39;
			this.C1Combo1.Size = new System.Drawing.Size(104, 21);
			this.C1Combo1.Style = style40;
			this.C1Combo1.TabIndex = 12;
			this.C1Combo1.TabStop = false;
			this.C1Combo1.RowChange += new System.EventHandler(this.C1Combo1_RowChange);
			this.C1Combo1.PropBag = resources.GetString("C1Combo1.PropBag");
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Right Width:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Left Width:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Bottom Width:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Top Width:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(280, 400);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "Border Appearance:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(304, 480);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 48);
			this.button1.TabIndex = 4;
			this.button1.Text = "Border Color";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBox2);
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Location = new System.Drawing.Point(424, 392);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(152, 160);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Scrolling";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(24, 104);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 16);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "ScrollTracking";
			this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(24, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "ScrollTips";
			this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
			// 
			// C1Combo5
			// 
			this.C1Combo5.AddItemSeparator = ';';
			this.C1Combo5.Caption = "";
			this.C1Combo5.CaptionHeight = 17;
			this.C1Combo5.CaptionStyle = style41;
			this.C1Combo5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.C1Combo5.ColumnCaptionHeight = 17;
			this.C1Combo5.ColumnFooterHeight = 17;
			this.C1Combo5.ComboStyle = C1.Win.List.ComboStyleEnum.DropdownList;
			this.C1Combo5.ContentHeight = 15;
			this.C1Combo5.DataMode = C1.Win.List.DataModeEnum.AddItem;
			this.C1Combo5.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.C1Combo5.EditorBackColor = System.Drawing.SystemColors.Window;
			this.C1Combo5.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1Combo5.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.C1Combo5.EditorHeight = 15;
			this.C1Combo5.EvenRowStyle = style42;
			this.C1Combo5.FlatStyle = C1.Win.List.FlatModeEnum.Standard;
			this.C1Combo5.FooterStyle = style43;
			this.C1Combo5.GapHeight = 2;
			this.C1Combo5.HeadingStyle = style44;
			this.C1Combo5.HighLightRowStyle = style45;
			this.C1Combo5.Images.Add(((System.Drawing.Image)(resources.GetObject("C1Combo5.Images"))));
			this.C1Combo5.ItemHeight = 15;
			this.C1Combo5.Location = new System.Drawing.Point(280, 424);
			this.C1Combo5.MatchEntryTimeout = ((long)(2000));
			this.C1Combo5.MaxDropDownItems = ((short)(5));
			this.C1Combo5.MaxLength = 32767;
			this.C1Combo5.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.C1Combo5.Name = "C1Combo5";
			this.C1Combo5.OddRowStyle = style46;
			this.C1Combo5.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.C1Combo5.RowDivider.Style = C1.Win.List.LineStyleEnum.None;
			this.C1Combo5.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.C1Combo5.SelectedStyle = style47;
			this.C1Combo5.Size = new System.Drawing.Size(120, 21);
			this.C1Combo5.Style = style48;
			this.C1Combo5.TabIndex = 16;
			this.C1Combo5.TabStop = false;
			this.C1Combo5.RowChange += new System.EventHandler(this.C1Combo5_RowChange);
			this.C1Combo5.PropBag = resources.GetString("C1Combo5.PropBag");
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
                        new System.Data.Common.DataColumnMapping("Phone", "Phone")})});
			// 
			// oleDbConnection1
			// 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"..\\..\\..\\Data\\C1ListDemo.mdb\"";
			// 
			// dsCustomer1
			// 
			this.dsCustomer1.DataSetName = "DsCustomer";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(616, 605);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.C1List1);
			this.Controls.Add(this.C1Combo5);
			this.Name = "Form1";
			this.Text = "C1List .Net Tutorial16";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.C1List1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.C1Combo4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.C1Combo3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.C1Combo2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.C1Combo1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.C1Combo5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustomer1)).EndInit();
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
			this.oleDbConnection1.ConnectionString = AdjustConnectionString(this.oleDbConnection1.ConnectionString);
			this.oleDbDataAdapter1.Fill(this.dsCustomer1);

			tb = this.dsCustomer1.Tables[0].Copy();
			this.C1List1.ItemHeight = 40;

			//Fill each combo
			this.checkBox2.Checked = true;
			FillCombo(ref this.C1Combo1 );
			FillCombo(ref this.C1Combo2);
			FillCombo(ref this.C1Combo3 );
			FillCombo(ref this.C1Combo4);
			FillCombo5();

			//Init border size
			this.bBottom = 1;
			this.bTop = 1;
			this.bLeft = 1;
			this.bRight = 1;
			this.bType = C1.Win.List.BorderTypeEnum.None;
		}

		//Fill each comboBox with number 1 to 10
		private void FillCombo(ref C1.Win.List.C1Combo  comb)
		{
			for (int i = 1; i < 11; i++)
				comb.AddItem(i.ToString());
			comb.SelectedIndex = 0;
			comb.ColumnHeaders = false;
		}

		private void FillCombo5()
		{
			this.C1Combo5.AddItem("Fillet");
			this.C1Combo5.AddItem("Flat");
			this.C1Combo5.AddItem("Groove");
			this.C1Combo5.AddItem("Inset");
			this.C1Combo5.AddItem("InsetBevel");
			this.C1Combo5.AddItem("None");
			this.C1Combo5.AddItem("Raised");
			this.C1Combo5.AddItem("RaisedBevel");
			this.C1Combo5.SelectedIndex=5;
			this.C1Combo5.ColumnHeaders = false;
		}


		private void UpdateBorder()
		{
			C1.Win.List.CellBorders bds = this.C1List1.Splits[0].DisplayColumns[this.C1List1.Col].Style.Borders;
			bds.Color = this.borderColor;
			bds.BorderType = this.bType;
			bds.Bottom = this.bBottom;
			bds.Left = this.bLeft;
			bds.Right = this.bRight;
			bds.Top = this.bTop;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = this.colorDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				this.borderColor = this.colorDialog1.Color;
				this.button1.BackColor = this.borderColor;
			}

			UpdateBorder();
		}

		private void checkBox1_Click(object sender, System.EventArgs e)
		{
			this.C1List1.ScrollTips = this.checkBox1.Checked;
		}

		private void checkBox2_Click(object sender, System.EventArgs e)
		{
			this.C1List1.ScrollTrack = this.checkBox2.Checked;
		}

		private void C1List1_FetchScrollTips(object sender, C1.Win.List.FetchScrollTipsEventArgs e)
		{
			 //set the ScrollTip depending on which scroll bar was moved
			switch (e.ScrollBar)
			{
				case C1.Win.List.ScrollBarEnum.Horizontal:
					e.ScrollTip = this.C1List1.Columns[e.ColIndex].Caption;
					break;
				case C1.Win.List.ScrollBarEnum.Vertical:
					e.ScrollTip = "Record: " + (e.Row + 1) + " of " +
						this.C1List1.ListCount + "\n";
					e.ScrollTip +=  "Company: " + this.tb.Rows[e.Row]["Company"] + "\n";
					e.ScrollTip +=  "User Code: " +
						this.tb.Rows[e.Row]["UserCode"];
					break;
			}
			e.TipStyle.ForeColor = Color.Blue;
		}

		private void C1Combo5_RowChange(object sender, System.EventArgs e)
		{
			switch ((string)this.C1Combo5.Text)
			{
				case "Fillet":
					this.bType = C1.Win.List.BorderTypeEnum.Fillet;
					break;
				case "Flat":
					this.bType = C1.Win.List.BorderTypeEnum.Flat;
					break;
				case "Groove":
					this.bType = C1.Win.List.BorderTypeEnum.Groove;
					break;
				case "Inset":
					this.bType = C1.Win.List.BorderTypeEnum.Inset;
					break;
				case "InsetBevel":
					this.bType = C1.Win.List.BorderTypeEnum.InsetBevel;
					break;
				case "None":
					this.bType = C1.Win.List.BorderTypeEnum.None;
					break;
				case "Raised":
					this.bType = C1.Win.List.BorderTypeEnum.Raised;
					break;
				case "RaisedBevel":
					this.bType = C1.Win.List.BorderTypeEnum.RaisedBevel;
					break;
			}
			this.UpdateBorder();
		}

		private void C1Combo1_RowChange(object sender, System.EventArgs e)
		{
			this.bTop = this.C1Combo1.SelectedIndex + 1;
			this.UpdateBorder();
		}

		private void C1Combo2_RowChange(object sender, System.EventArgs e)
		{
			this.bBottom = this.C1Combo2.SelectedIndex + 1;
			this.UpdateBorder();
		}

		private void C1Combo3_RowChange(object sender, System.EventArgs e)
		{
			this.bLeft = this.C1Combo3.SelectedIndex + 1;
			this.UpdateBorder();
		}

		private void C1Combo4_RowChange(object sender, System.EventArgs e)
		{
			this.bRight = this.C1Combo4.SelectedIndex + 1;
			this.UpdateBorder();
		}

		private string AdjustConnectionString(string connectionString)
		{
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ComponentOne Samples\\Common\\C1NWind.mdb" + "\"";
		}
	}
}
