using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FakeStudio
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ToolBarButton toolBarButton4;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
		private C1.Win.Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.ToolBarButton toolBarButton15;
		private System.Windows.Forms.ToolBarButton toolBarButton16;
		private System.Windows.Forms.ToolBarButton toolBarButton17;
		private System.Windows.Forms.ToolBarButton toolBarButton18;
		private System.ComponentModel.IContainer components;

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "C1FlexGrid", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Control, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))))}, 0);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "C1AddToCart", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Control, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))))}, 1);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "C1CheckoutCart", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Control, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))))}, 2);
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "C1PurchaseItem", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Control, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))))}, 3);
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "C1Report", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Control, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))))}, 4);
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "C1ReportDesigner", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Control, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))))}, 5);
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "C1Sizer", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Control, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))))}, 6);
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "C1SizerLight", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Control, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0))))}, 7);
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton15 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton17 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton18 = new System.Windows.Forms.ToolBarButton();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.c1Sizer1 = new C1.Win.Sizer.C1Sizer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem10});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "&Edit";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "&View";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "&Project";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 4;
			this.menuItem5.Text = "&Build";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 5;
			this.menuItem6.Text = "&Debug";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 6;
			this.menuItem7.Text = "D&ata";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 7;
			this.menuItem8.Text = "&Tools";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 8;
			this.menuItem9.Text = "&Window";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 9;
			this.menuItem10.Text = "&Help";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 3;
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5,
																						this.toolBarButton6,
																						this.toolBarButton7,
																						this.toolBarButton8,
																						this.toolBarButton9,
																						this.toolBarButton10,
																						this.toolBarButton11,
																						this.toolBarButton12,
																						this.toolBarButton13,
																						this.toolBarButton14,
																						this.toolBarButton15,
																						this.toolBarButton16,
																						this.toolBarButton17,
																						this.toolBarButton18});
			this.toolBar1.ButtonSize = new System.Drawing.Size(23, 22);
			this.toolBar1.Divider = false;
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList2;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(704, 22);
			this.toolBar1.TabIndex = 0;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.ImageIndex = 4;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 5;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.ImageIndex = 6;
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 7;
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 8;
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.ImageIndex = 9;
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.ImageIndex = 10;
			// 
			// toolBarButton13
			// 
			this.toolBarButton13.ImageIndex = 11;
			// 
			// toolBarButton14
			// 
			this.toolBarButton14.ImageIndex = 12;
			// 
			// toolBarButton15
			// 
			this.toolBarButton15.ImageIndex = 13;
			// 
			// toolBarButton16
			// 
			this.toolBarButton16.ImageIndex = 14;
			// 
			// toolBarButton17
			// 
			this.toolBarButton17.ImageIndex = 15;
			// 
			// toolBarButton18
			// 
			this.toolBarButton18.ImageIndex = 16;
			// 
			// imageList2
			// 
			this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList2.ImageSize = new System.Drawing.Size(16, 15);
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Red;
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.BackColor = System.Drawing.SystemColors.Control;
			this.c1Sizer1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.tabControl1,
																				   this.panel1,
																				   this.panel2,
																				   this.panel3});
			this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Sizer1.GridDefinition = "69.620253164557:True:False;26.0759493670886:True:False;0.253164556962025:True:Tru" +
				"e;\t20.4545454545455:True:True;50.9943181818182:True:False;26.2784090909091:True:" +
				"True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 22);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(704, 395);
			this.c1Sizer1.TabIndex = 1;
			this.c1Sizer1.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2});
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(152, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(0, 0);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(359, 275);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.textBox1});
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(351, 244);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Form1.cs";
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(351, 244);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "using System;\r\nusing System.Drawing;\r\nusing System.Collections;\r\nusing System.Com" +
				"ponentModel;\r\nusing System.Windows.Forms;\r\nusing System.Data;\r\n\r\nnamespace FakeS" +
				"tudio\r\n{\r\n    /// <summary>\r\n    /// Summary description for Form1.\r\n    /// </s" +
				"ummary>\r\n    public class Form1 : System.Windows.Forms.Form\r\n    {\r\n        priv" +
				"ate System.Windows.Forms.MainMenu mainMenu1;\r\n        private System.Windows.For" +
				"ms.MenuItem menuItem1;\r\n        private System.Windows.Forms.ToolBarButton toolB" +
				"arButton1;\r\n        private System.Windows.Forms.ToolBarButton toolBarButton2;\r\n" +
				"        private System.Windows.Forms.ToolBarButton toolBarButton3;\r\n        priv" +
				"ate System.Windows.Forms.ToolBarButton toolBarButton4;\r\n        private System.W" +
				"indows.Forms.ToolBar toolBar1;\r\n        private System.Windows.Forms.MenuItem me" +
				"nuItem2;\r\n        private System.Windows.Forms.MenuItem menuItem3;\r\n        priv" +
				"ate System.Windows.Forms.MenuItem menuItem4;\r\n        private System.Windows.For" +
				"ms.MenuItem menuItem5;\r\n        private System.Windows.Forms.MenuItem menuItem6;" +
				"\r\n        private System.Windows.Forms.MenuItem menuItem7;\r\n        private Syst" +
				"em.Windows.Forms.MenuItem menuItem8;\r\n        private System.Windows.Forms.MenuI" +
				"tem menuItem9;\r\n        private System.Windows.Forms.MenuItem menuItem10;\r\n     " +
				"   private C1.Win.Sizer.C1Sizer c1Sizer1;\r\n        private System.Windows.Form" +
				"s.Panel panel1;\r\n        private System.Windows.Forms.Panel panel2;\r\n        pri" +
				"vate System.Windows.Forms.Panel panel3;\r\n        private System.Windows.Forms.To" +
				"olBar toolBar2;\r\n        private System.Windows.Forms.TabControl tabControl1;\r\n " +
				"       private System.Windows.Forms.TabPage tabPage1;\r\n        private System.Wi" +
				"ndows.Forms.TabPage tabPage2;\r\n\r\n        // etc\r\n    }\r\n}";
			this.textBox1.WordWrap = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.textBox2});
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(351, 244);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Readme.txt";
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.ForeColor = System.Drawing.Color.DarkGreen;
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox2.Size = new System.Drawing.Size(351, 244);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = @"FakeStudio
------------------------------------------------------------------------
Create a user interface that looks like Visual Studio.

This sample has no code. It contains a single C1Sizer control with
three rows and three columns, and several child controls arranged within
the C1SizerGrid.

The layout grid was set up at design time with the C1Sizer's grid editor.

Most of the rows and columns were set up as splitters, to the user
can resize them at runtime using the mouse.

Some rows were set up as fixed-size, so when the form is resized they
are not resized proportionally, but retain their dimension (this is
especially useful to set up headers).

Some of the grid panes contains Panel controls, which in turn contain
other controls that are docked within the panel. The C1Sizer itself is 
docked to fill the form. This shows how the C1Sizer control works with 
the layout support provided by the .NET framework.";
			this.textBox2.WordWrap = false;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.listView1,
																				 this.label1});
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(144, 275);
			this.panel1.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.SystemColors.Control;
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.HoverSelection = true;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
																					  listViewItem1,
																					  listViewItem2,
																					  listViewItem3,
																					  listViewItem4,
																					  listViewItem5,
																					  listViewItem6,
																					  listViewItem7,
																					  listViewItem8});
			this.listView1.Location = new System.Drawing.Point(0, 16);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(144, 259);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 1;
			this.listView1.View = System.Windows.Forms.View.List;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Silver;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Highlight;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = " Toolbox";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.textBox3,
																				 this.label3});
			this.panel2.Location = new System.Drawing.Point(4, 283);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(507, 103);
			this.panel2.TabIndex = 0;
			// 
			// textBox3
			// 
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox3.Location = new System.Drawing.Point(0, 16);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(507, 87);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = @"'DefaultDomain': Loaded 'c:\winnt\microsoft.net\framework\v1.0.3705\mscorlib.dll', No symbols loaded.
'FakeStudio': Loaded 'E:\C1\CVSHome\.NET\C1\personal\Sizer\Samples\cs\FakeStudio\bin\Release\FakeStudio.exe', No symbols loaded.
'FakeStudio.exe': Loaded 'c:\winnt\assembly\gac\system.windows.forms\1.0.3300.0__b77a5c561934e089\system.windows.forms.dll', No symbols loaded.
'FakeStudio.exe': Loaded 'c:\winnt\assembly\gac\system\1.0.3300.0__b77a5c561934e089\system.dll', No symbols loaded.
'FakeStudio.exe': Loaded 'c:\winnt\assembly\gac\system.drawing\1.0.3300.0__b03f5f7f11d50a3a\system.drawing.dll', No symbols loaded.";
			this.textBox3.WordWrap = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Highlight;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(507, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = " Output";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.propertyGrid1,
																				 this.label2});
			this.panel3.Location = new System.Drawing.Point(515, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(185, 382);
			this.panel3.TabIndex = 0;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(0, 16);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.propertyGrid1.SelectedObject = this.c1Sizer1;
			this.propertyGrid1.Size = new System.Drawing.Size(185, 366);
			this.propertyGrid1.TabIndex = 2;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Highlight;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = " Properties";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 417);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Sizer1,
																		  this.toolBar1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "FakeStudio";
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
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
	}
}
