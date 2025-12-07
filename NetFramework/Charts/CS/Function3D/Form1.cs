using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;

namespace Function3D
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox tbFuncText;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel pnlFuncEditor;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown udNx;
		private System.Windows.Forms.TextBox tbMinX;
		private System.Windows.Forms.TextBox tbMaxX;
		private System.Windows.Forms.TextBox tbMaxY;
		private System.Windows.Forms.TextBox tbMinY;
		private System.Windows.Forms.NumericUpDown udNy;
		private System.Windows.Forms.Button btnSave;

//
		Engine eng = new Engine();
		Range _range = new Range();
		private System.Windows.Forms.ComboBox cbFList;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.TextBox tbErrors;
		private System.Windows.Forms.StatusBar sbChart;
		private System.Windows.Forms.StatusBarPanel sbpChart;
		private System.Windows.Forms.StatusBarPanel sbpC1;
		private System.Windows.Forms.ContextMenu cmChartType;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.ImageList imageList1;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBar tlbChart;
		FunctionInfoCollection fcoll = new FunctionInfoCollection();

		int rot_inc = 5;
		int rotx, rotz;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.ContextMenu cmView;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ContextMenu cmContour;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.ContextMenu cmNCont;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem31;
		private System.Windows.Forms.MenuItem menuItem32;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.MenuItem menuItem33;
		private System.Windows.Forms.MenuItem menuItem34;
		private System.Windows.Forms.MenuItem menuItem35;
		private System.Windows.Forms.MenuItem menuItem36;
		private System.Windows.Forms.MenuItem menuItem37;
		private System.Windows.Forms.MenuItem menuItem38;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		
		Range Range
		{
			get
			{
				updateRange( true);
				return _range;
			}
			set
			{
				_range = value;
				updateRange( false);
			}
		}

		void updateRange( bool dir)
		{
			if(dir)
			{
				_range.MinX = float.Parse( tbMinX.Text);
				_range.MinY = float.Parse( tbMinY.Text);
				_range.MaxX = float.Parse( tbMaxX.Text);
				_range.MaxY = float.Parse( tbMaxY.Text);
				_range.NumX = (int)udNx.Value;
				_range.NumY = (int)udNy.Value;
			}
			else
			{
				tbMinX.Text = _range.MinX.ToString();
				tbMinY.Text = _range.MinY.ToString();
				tbMaxX.Text = _range.MaxX.ToString();
				tbMaxY.Text = _range.MaxY.ToString();				
				udNx.Value = _range.NumX;
				udNy.Value = _range.NumY;
			}
		}

		void updateFList( int sel)
		{
			cbFList.Items.Clear();
			for( int i=0; i<fcoll.Count; i++)
				cbFList.Items.Add( fcoll[i].Name);
			cbFList.SelectedIndex = sel;
		}

		void setZoneChart( C1.Win.C1Chart3D.ColorSetEnum clrset)
		{
			if( !c1Chart3D1.ChartGroups[0].Contour.IsZoned)
				c1Chart3D1.ChartGroups[0].Contour.IsZoned = true;
			c1Chart3D1.ChartGroups.ContourStyles.ColorSet = clrset;
		}

		void setZoneNumber( int n)
		{
			if( !c1Chart3D1.ChartGroups[0].Contour.IsZoned)
			{
				c1Chart3D1.ChartGroups[0].Contour.IsZoned = true;
				selectNext( cmContour);
			}
			c1Chart3D1.ChartGroups[0].Contour.NumLevels = n;
		}

		void loadFList()
		{
			FunctionInfoCollection fic = null;
			TextReader reader = null;
			XmlSerializer x = new XmlSerializer(typeof(FunctionInfoCollection));
			
			try
			{
				reader = new StreamReader( getConfigFileName());
				fic = (FunctionInfoCollection)x.Deserialize(reader);
				reader.Close();
			}
			catch
			{
			}
			finally
			{
				if( reader!=null)
					reader.Close();
			}

			string res = string.Empty;
			if( fic==null || fic.Count==0)
			{
				System.Resources.ResourceManager resources = new System.Resources.ResourceManager("Function3D.Config",Assembly.GetAssembly(typeof(Form1)));
				res = resources.GetString( "Config");
				if( res.Length>0)
				{
					reader = new StringReader( res);
					fic = (FunctionInfoCollection)x.Deserialize(reader);
				}
			}

			if( fic!=null)
			{
				fcoll = fic;
				updateFList(0);
			}
		}

		string getConfigFileName()
		{
			//return config_dir + "\\" + 
			return Assembly.GetExecutingAssembly().GetName().Name +".config";
		}

		void selectNext( System.Windows.Forms.ContextMenu cm)
		{
			int sel = 0;
			for( int i=0; i<cm.MenuItems.Count; i++)
			{
				if( cm.MenuItems[i].Checked)
				{
					sel =i;
					break;
				}
			}

			if( sel >= cm.MenuItems.Count-1)
				sel = 0;
			else
				sel++;

			if( cm.MenuItems[sel].Text.Equals( "-"))
			{
				if( sel >= cm.MenuItems.Count-1)
					sel = 0;
				else
					sel++;
			}

			cm.MenuItems[sel].PerformClick();
		}

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )//!!VBReplace-Overrides-Overloads Overrides-
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.pnlFuncEditor = new System.Windows.Forms.Panel();
			this.cbFList = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tbErrors = new System.Windows.Forms.TextBox();
			this.tbFuncText = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbMaxX = new System.Windows.Forms.TextBox();
			this.tbMinX = new System.Windows.Forms.TextBox();
			this.udNx = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbMaxY = new System.Windows.Forms.TextBox();
			this.tbMinY = new System.Windows.Forms.TextBox();
			this.udNy = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.sbChart = new System.Windows.Forms.StatusBar();
			this.sbpChart = new System.Windows.Forms.StatusBarPanel();
			this.sbpC1 = new System.Windows.Forms.StatusBarPanel();
			this.tlbChart = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.cmChartType = new System.Windows.Forms.ContextMenu();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.cmView = new System.Windows.Forms.ContextMenu();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.cmContour = new System.Windows.Forms.ContextMenu();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem33 = new System.Windows.Forms.MenuItem();
			this.menuItem34 = new System.Windows.Forms.MenuItem();
			this.menuItem35 = new System.Windows.Forms.MenuItem();
			this.menuItem36 = new System.Windows.Forms.MenuItem();
			this.menuItem37 = new System.Windows.Forms.MenuItem();
			this.menuItem38 = new System.Windows.Forms.MenuItem();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.cmNCont = new System.Windows.Forms.ContextMenu();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.menuItem28 = new System.Windows.Forms.MenuItem();
			this.menuItem29 = new System.Windows.Forms.MenuItem();
			this.menuItem30 = new System.Windows.Forms.MenuItem();
			this.menuItem31 = new System.Windows.Forms.MenuItem();
			this.menuItem32 = new System.Windows.Forms.MenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.c1Chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
			this.pnlFuncEditor.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udNx)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udNy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpC1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem1,
																																							this.menuItem2,
																																							this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuFileExit});
			this.menuItem1.Text = "&File";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 0;
			this.menuFileExit.Text = "E&xit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem5});
			this.menuItem2.Text = "&View";
			// 
			// menuItem5
			// 
			this.menuItem5.Checked = true;
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "Function Editor";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuHelpAbout});
			this.menuItem3.Text = "&Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 0;
			this.menuHelpAbout.Text = "&About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// pnlFuncEditor
			// 
			this.pnlFuncEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlFuncEditor.Controls.AddRange(new System.Windows.Forms.Control[] {
																																								this.cbFList,
																																								this.btnSave,
																																								this.label1,
																																								this.tabControl1,
																																								this.btnGenerate});
			this.pnlFuncEditor.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlFuncEditor.Name = "pnlFuncEditor";
			this.pnlFuncEditor.Size = new System.Drawing.Size(240, 403);
			this.pnlFuncEditor.TabIndex = 0;
			// 
			// cbFList
			// 
			this.cbFList.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbFList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFList.Location = new System.Drawing.Point(8, 24);
			this.cbFList.MaxDropDownItems = 10;
			this.cbFList.Name = "cbFList";
			this.cbFList.Size = new System.Drawing.Size(224, 21);
			this.cbFList.TabIndex = 3;
			this.cbFList.SelectedIndexChanged += new System.EventHandler(this.cbFList_SelectedIndexChanged);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSave.Location = new System.Drawing.Point(136, 56);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(96, 20);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save function...";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Function Editor";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																							this.tabPage1,
																																							this.tabPage2});
			this.tabControl1.Location = new System.Drawing.Point(8, 88);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(222, 306);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					 this.tbErrors,
																																					 this.tbFuncText});
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(214, 280);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Code";
			// 
			// tbErrors
			// 
			this.tbErrors.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbErrors.Location = new System.Drawing.Point(0, 224);
			this.tbErrors.Multiline = true;
			this.tbErrors.Name = "tbErrors";
			this.tbErrors.ReadOnly = true;
			this.tbErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbErrors.Size = new System.Drawing.Size(214, 56);
			this.tbErrors.TabIndex = 1;
			this.tbErrors.Text = "";
			this.tbErrors.Visible = false;
			this.tbErrors.VisibleChanged += new System.EventHandler(this.tbErrors_VisibleChanged);
			// 
			// tbFuncText
			// 
			this.tbFuncText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbFuncText.Multiline = true;
			this.tbFuncText.Name = "tbFuncText";
			this.tbFuncText.Size = new System.Drawing.Size(214, 280);
			this.tbFuncText.TabIndex = 0;
			this.tbFuncText.Text = "";
			this.tbFuncText.WordWrap = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					 this.groupBox1,
																																					 this.groupBox2});
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(214, 280);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Range";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.tbMaxX,
																																						this.tbMinX,
																																						this.udNx,
																																						this.label4,
																																						this.label3,
																																						this.label2});
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 96);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "X";
			// 
			// tbMaxX
			// 
			this.tbMaxX.Location = new System.Drawing.Point(56, 40);
			this.tbMaxX.Name = "tbMaxX";
			this.tbMaxX.Size = new System.Drawing.Size(80, 20);
			this.tbMaxX.TabIndex = 7;
			this.tbMaxX.Text = "textBox2";
			this.tbMaxX.TextChanged += new System.EventHandler(this.tbFloat_TextChanged);
			// 
			// tbMinX
			// 
			this.tbMinX.Location = new System.Drawing.Point(56, 16);
			this.tbMinX.Name = "tbMinX";
			this.tbMinX.Size = new System.Drawing.Size(80, 20);
			this.tbMinX.TabIndex = 6;
			this.tbMinX.Text = "textBox1";
			this.tbMinX.TextChanged += new System.EventHandler(this.tbFloat_TextChanged);
			// 
			// udNx
			// 
			this.udNx.Location = new System.Drawing.Point(96, 64);
			this.udNx.Minimum = new System.Decimal(new int[] {
																												 5,
																												 0,
																												 0,
																												 0});
			this.udNx.Name = "udNx";
			this.udNx.Size = new System.Drawing.Size(40, 20);
			this.udNx.TabIndex = 5;
			this.udNx.Value = new System.Decimal(new int[] {
																											 5,
																											 0,
																											 0,
																											 0});
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Number of points";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Max";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Min";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.tbMaxY,
																																						this.tbMinY,
																																						this.udNy,
																																						this.label5,
																																						this.label6,
																																						this.label7});
			this.groupBox2.Location = new System.Drawing.Point(8, 112);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 96);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Y";
			// 
			// tbMaxY
			// 
			this.tbMaxY.Location = new System.Drawing.Point(56, 40);
			this.tbMaxY.Name = "tbMaxY";
			this.tbMaxY.Size = new System.Drawing.Size(80, 20);
			this.tbMaxY.TabIndex = 7;
			this.tbMaxY.Text = "textBox2";
			this.tbMaxY.TextChanged += new System.EventHandler(this.tbFloat_TextChanged);
			// 
			// tbMinY
			// 
			this.tbMinY.Location = new System.Drawing.Point(56, 16);
			this.tbMinY.Name = "tbMinY";
			this.tbMinY.Size = new System.Drawing.Size(80, 20);
			this.tbMinY.TabIndex = 6;
			this.tbMinY.Text = "textBox1";
			this.tbMinY.TextChanged += new System.EventHandler(this.tbFloat_TextChanged);
			// 
			// udNy
			// 
			this.udNy.Location = new System.Drawing.Point(96, 64);
			this.udNy.Minimum = new System.Decimal(new int[] {
																												 5,
																												 0,
																												 0,
																												 0});
			this.udNy.Name = "udNy";
			this.udNy.Size = new System.Drawing.Size(40, 20);
			this.udNy.TabIndex = 5;
			this.udNy.Value = new System.Decimal(new int[] {
																											 5,
																											 0,
																											 0,
																											 0});
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Number of points";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = "Max";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 23);
			this.label7.TabIndex = 1;
			this.label7.Text = "Min";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(8, 56);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(96, 20);
			this.btnGenerate.TabIndex = 1;
			this.btnGenerate.Text = "Generate Chart";
			this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(240, 0);
			this.splitter1.MinSize = 220;
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(4, 403);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// sbChart
			// 
			this.sbChart.Location = new System.Drawing.Point(244, 381);
			this.sbChart.Name = "sbChart";
			this.sbChart.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																																							 this.sbpChart,
																																							 this.sbpC1});
			this.sbChart.ShowPanels = true;
			this.sbChart.Size = new System.Drawing.Size(348, 22);
			this.sbChart.TabIndex = 3;
			this.sbChart.Text = "Ready";
			// 
			// sbpChart
			// 
			this.sbpChart.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.sbpChart.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
			this.sbpChart.Text = "Ready";
			this.sbpChart.Width = 302;
			// 
			// sbpC1
			// 
			this.sbpC1.Icon = ((System.Drawing.Icon)(resources.GetObject("sbpC1.Icon")));
			this.sbpC1.MinWidth = 30;
			this.sbpC1.Width = 30;
			// 
			// tlbChart
			// 
			this.tlbChart.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.tlbChart.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																																								this.toolBarButton1,
																																								this.toolBarButton11,
																																								this.toolBarButton2,
																																								this.toolBarButton4,
																																								this.toolBarButton3,
																																								this.toolBarButton5,
																																								this.toolBarButton7,
																																								this.toolBarButton6,
																																								this.toolBarButton8,
																																								this.toolBarButton9,
																																								this.toolBarButton10,
																																								this.toolBarButton14,
																																								this.toolBarButton12,
																																								this.toolBarButton13});
			this.tlbChart.DropDownArrows = true;
			this.tlbChart.ImageList = this.imageList1;
			this.tlbChart.Location = new System.Drawing.Point(244, 0);
			this.tlbChart.Name = "tlbChart";
			this.tlbChart.ShowToolTips = true;
			this.tlbChart.Size = new System.Drawing.Size(348, 25);
			this.tlbChart.TabIndex = 5;
			this.tlbChart.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.tlbChart.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tlbChart_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.DropDownMenu = this.cmChartType;
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.toolBarButton1.ToolTipText = "Chart type";
			// 
			// cmChartType
			// 
			this.cmChartType.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																								this.menuItem14,
																																								this.menuItem12,
																																								this.menuItem13});
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 0;
			this.menuItem14.RadioCheck = true;
			this.menuItem14.Text = "Bar";
			this.menuItem14.Click += new System.EventHandler(this.miChartType_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.RadioCheck = true;
			this.menuItem12.Text = "Scatter";
			this.menuItem12.Click += new System.EventHandler(this.miChartType_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Checked = true;
			this.menuItem13.Index = 2;
			this.menuItem13.RadioCheck = true;
			this.menuItem13.Text = "Surface";
			this.menuItem13.Click += new System.EventHandler(this.miChartType_Click);
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.DropDownMenu = this.cmView;
			this.toolBarButton11.ImageIndex = 9;
			this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.toolBarButton11.ToolTipText = "View";
			// 
			// cmView
			// 
			this.cmView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																					 this.menuItem11,
																																					 this.menuItem18,
																																					 this.menuItem15,
																																					 this.menuItem16,
																																					 this.menuItem17});
			// 
			// menuItem11
			// 
			this.menuItem11.Checked = true;
			this.menuItem11.Index = 0;
			this.menuItem11.RadioCheck = true;
			this.menuItem11.Text = "3D - Default";
			this.menuItem11.Click += new System.EventHandler(this.miView_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 1;
			this.menuItem18.Text = "-";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 2;
			this.menuItem15.RadioCheck = true;
			this.menuItem15.Text = "2D - XY plane";
			this.menuItem15.Click += new System.EventHandler(this.miView_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 3;
			this.menuItem16.RadioCheck = true;
			this.menuItem16.Text = "2D - XZ plane";
			this.menuItem16.Click += new System.EventHandler(this.miView_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 4;
			this.menuItem17.RadioCheck = true;
			this.menuItem17.Text = "2D - YZ plane";
			this.menuItem17.Click += new System.EventHandler(this.miView_Click);
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 5;
			this.toolBarButton4.ToolTipText = "Rotation Z";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 1;
			this.toolBarButton3.ToolTipText = "Rotation Z";
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.ImageIndex = 6;
			this.toolBarButton7.ToolTipText = "Rotation X";
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 2;
			this.toolBarButton6.ToolTipText = "Rotation X";
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 7;
			this.toolBarButton9.Pushed = true;
			this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.toolBarButton9.ToolTipText = "Grid";
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.ImageIndex = 8;
			this.toolBarButton10.Pushed = true;
			this.toolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.toolBarButton10.ToolTipText = "Axes";
			// 
			// toolBarButton14
			// 
			this.toolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.DropDownMenu = this.cmContour;
			this.toolBarButton12.ImageIndex = 10;
			this.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.toolBarButton12.ToolTipText = "Zone colors";
			// 
			// cmContour
			// 
			this.cmContour.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem19,
																																							this.menuItem20,
																																							this.menuItem21,
																																							this.menuItem22,
																																							this.menuItem23,
																																							this.menuItem33,
																																							this.menuItem34,
																																							this.menuItem35,
																																							this.menuItem36,
																																							this.menuItem37,
																																							this.menuItem38});
			// 
			// menuItem19
			// 
			this.menuItem19.Checked = true;
			this.menuItem19.Index = 0;
			this.menuItem19.RadioCheck = true;
			this.menuItem19.Text = "None";
			this.menuItem19.Click += new System.EventHandler(this.miContour_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 1;
			this.menuItem20.RadioCheck = true;
			this.menuItem20.Text = "Rainbow";
			this.menuItem20.Click += new System.EventHandler(this.miContour_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 2;
			this.menuItem21.RadioCheck = true;
			this.menuItem21.Text = "RevRainbow";
			this.menuItem21.Click += new System.EventHandler(this.miContour_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 3;
			this.menuItem22.RadioCheck = true;
			this.menuItem22.Text = "Black -> White";
			this.menuItem22.Click += new System.EventHandler(this.miContour_Click);
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 4;
			this.menuItem23.RadioCheck = true;
			this.menuItem23.Text = "White -> Black";
			this.menuItem23.Click += new System.EventHandler(this.miContour_Click);
			// 
			// menuItem33
			// 
			this.menuItem33.Index = 5;
			this.menuItem33.RadioCheck = true;
			this.menuItem33.Text = "Green -> Blue";
			this.menuItem33.Click += new System.EventHandler(this.miContour_Click);
			// 
			// menuItem34
			// 
			this.menuItem34.Index = 6;
			this.menuItem34.RadioCheck = true;
			this.menuItem34.Text = "Red -> White";
			this.menuItem34.Click += new System.EventHandler(this.miContour_Click);
			// 
			// menuItem35
			// 
			this.menuItem35.Index = 7;
			this.menuItem35.RadioCheck = true;
			this.menuItem35.Text = "Blue -> Pink";
			this.menuItem35.Click += new System.EventHandler(this.miContour_Click);
			// 
			// menuItem36
			// 
			this.menuItem36.Index = 8;
			this.menuItem36.RadioCheck = true;
			this.menuItem36.Text = "Blue -> White -> Red";
			this.menuItem36.Click += new System.EventHandler(this.miContour_Click);
			// 
			// menuItem37
			// 
			this.menuItem37.Index = 9;
			this.menuItem37.RadioCheck = true;
			this.menuItem37.Text = "Black -> Red ->Yellow";
			this.menuItem37.Click += new System.EventHandler(this.miContour_Click);
			// 
			// menuItem38
			// 
			this.menuItem38.Index = 10;
			this.menuItem38.RadioCheck = true;
			this.menuItem38.Text = "Green -> Purple -> Yellow";
			this.menuItem38.Click += new System.EventHandler(this.miContour_Click);
			// 
			// toolBarButton13
			// 
			this.toolBarButton13.DropDownMenu = this.cmNCont;
			this.toolBarButton13.ImageIndex = 11;
			this.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.toolBarButton13.ToolTipText = "Number of levels";
			// 
			// cmNCont
			// 
			this.cmNCont.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																						this.menuItem24,
																																						this.menuItem25,
																																						this.menuItem26,
																																						this.menuItem27,
																																						this.menuItem28,
																																						this.menuItem29,
																																						this.menuItem30,
																																						this.menuItem31,
																																						this.menuItem32});
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 0;
			this.menuItem24.RadioCheck = true;
			this.menuItem24.Text = "10";
			this.menuItem24.Click += new System.EventHandler(this.miNCont_Click);
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 1;
			this.menuItem25.RadioCheck = true;
			this.menuItem25.Text = "15";
			this.menuItem25.Click += new System.EventHandler(this.miNCont_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.Checked = true;
			this.menuItem26.Index = 2;
			this.menuItem26.RadioCheck = true;
			this.menuItem26.Text = "20";
			this.menuItem26.Click += new System.EventHandler(this.miNCont_Click);
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 3;
			this.menuItem27.RadioCheck = true;
			this.menuItem27.Text = "25";
			this.menuItem27.Click += new System.EventHandler(this.miNCont_Click);
			// 
			// menuItem28
			// 
			this.menuItem28.Index = 4;
			this.menuItem28.RadioCheck = true;
			this.menuItem28.Text = "30";
			this.menuItem28.Click += new System.EventHandler(this.miNCont_Click);
			// 
			// menuItem29
			// 
			this.menuItem29.Index = 5;
			this.menuItem29.RadioCheck = true;
			this.menuItem29.Text = "35";
			this.menuItem29.Click += new System.EventHandler(this.miNCont_Click);
			// 
			// menuItem30
			// 
			this.menuItem30.Index = 6;
			this.menuItem30.RadioCheck = true;
			this.menuItem30.Text = "40";
			this.menuItem30.Click += new System.EventHandler(this.miNCont_Click);
			// 
			// menuItem31
			// 
			this.menuItem31.Index = 7;
			this.menuItem31.RadioCheck = true;
			this.menuItem31.Text = "45";
			this.menuItem31.Click += new System.EventHandler(this.miNCont_Click);
			// 
			// menuItem32
			// 
			this.menuItem32.Index = 8;
			this.menuItem32.RadioCheck = true;
			this.menuItem32.Text = "50";
			this.menuItem32.Click += new System.EventHandler(this.miNCont_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			// 
			// c1Chart3D1
			// 
			this.c1Chart3D1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart3D1.Location = new System.Drawing.Point(244, 25);
			this.c1Chart3D1.Name = "c1Chart3D1";
			this.c1Chart3D1.PropBag = "<?xml version=\"1.0\"?><Chart3DPropBag Version=\"\"><LegendData Compass=\"East\" /><Sty" +
				"leCollection><NamedStyle Name=\"Legend\" ParentName=\"Legend.default\" /><NamedStyle" +
				" Name=\"Footer\" ParentName=\"Control\" /><NamedStyle Name=\"Area\" ParentName=\"Area.d" +
				"efault\" StyleData=\"Border=Empty,ControlText,1;\" /><NamedStyle Name=\"Control\" Par" +
				"entName=\"Control.default\" StyleData=\"Border=RaisedBevel,ControlText,1;\" /><Named" +
				"Style Name=\"LabelStyleDefault\" ParentName=\"Control\" StyleData=\"BackColor=Transpa" +
				"rent;\" /><NamedStyle Name=\"Legend.default\" ParentName=\"Control\" StyleData=\"Wrap=" +
				"False;AlignVert=Top;\" /><NamedStyle Name=\"Header\" ParentName=\"Control\" /><NamedS" +
				"tyle Name=\"Control.default\" ParentName=\"\" StyleData=\"ForeColor=ControlText;BackC" +
				"olor=Control;\" /><NamedStyle Name=\"Area.default\" ParentName=\"Control\" StyleData=" +
				"\"AlignVert=Top;\" /></StyleCollection><FooterData Compass=\"South\" /><HeaderData C" +
				"ompass=\"North\" /><ChartStyles><Chart3DStyle><SymbolStyle Shape=\"Dot\" Color=\"Red\"" +
				" Size=\"4\" /><LineStyle Pattern=\"Solid\" Color=\"Black\" Thickness=\"0\" /></Chart3DSt" +
				"yle></ChartStyles><ChartGroupsCollection><Chart3DGroup><Contour NumLevels=\"20\" /" +
				"><ChartData><Set type=\"Chart3DDataSetGrid\" ColumnOrigin=\"0\" RowOrigin=\"0\" RowDel" +
				"ta=\"1\" RowCount=\"11\" ColumnCount=\"11\" ColumnDelta=\"1\" Hole=\"3.40282347E+38\"><Dat" +
				"a>4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4.5" +
				" 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 10 " +
				"10.9 12.9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12.9 14.1 13.2 12.5 12 11.7 1" +
				"1.6 11.7 12 12.5 13.2 14.1 14.5 13.6 12.9 12.4 12.1 12 12.1 12.4 12.9 13.6 14.5 " +
				"14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 12.9 12 11.3 10.8 10.5 10.4 1" +
				"0.5 10.8 11.3 12 12.9 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 8.1 7.2 6.5 6 " +
				"5.7 5.6 5.7 6 6.5 7.2 8.1 4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.399" +
				"99986 2.89999986 3.6 4.5 </Data></Set></ChartData></Chart3DGroup></ChartGroupsCo" +
				"llection><View BackColor=\"Control\" ViewportHorizontalShift=\"0\" ViewportVerticalS" +
				"hift=\"0\" /></Chart3DPropBag>";
			this.c1Chart3D1.Size = new System.Drawing.Size(348, 356);
			this.c1Chart3D1.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 403);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.c1Chart3D1,
																																	this.tlbChart,
																																	this.sbChart,
																																	this.splitter1,
																																	this.pnlFuncEditor});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 3D - Function Plotting Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlFuncEditor.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udNx)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udNy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpC1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).EndInit();
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			sbpChart.Text = "Generating chart ...";
			C1.Win.C1Chart3D.Chart3DDataSetGrid grset = eng.Run( tbFuncText.Text, Range); 
			if( grset!=null)
			{
				tbErrors.Visible = false;
				c1Chart3D1.ChartGroups[0].ChartData.SetGrid = grset;
				this.sbpChart.Text = "Ready";
			}
			else
			{
				tbErrors.Visible = true;
				tbErrors.Lines = eng.Errors;
				this.sbpChart.Text = "Error in function code";
			}
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			pnlFuncEditor.Visible = !pnlFuncEditor.Visible;
			MenuItem mi = (MenuItem)sender;
			mi.Checked = pnlFuncEditor.Visible;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			cbFList.Anchor = ((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right); //!!VBPassThru
			btnSave.Anchor = (AnchorStyles.Top | AnchorStyles.Right); //!!VBPassThru
			label1.Anchor = ((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right); //!!VBPassThru
			tabControl1.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right); //!!VBPassThru
			groupBox1.Anchor = ((AnchorStyles.Top | AnchorStyles.Left) 	| AnchorStyles.Right); //!!VBPassThru
			groupBox2.Anchor = ((AnchorStyles.Top | AnchorStyles.Left) 	| AnchorStyles.Right); //!!VBPassThru

			updateRange( false);
			loadFList();
			rotz = c1Chart3D1.ChartArea.View.RotationZ;
			rotx = c1Chart3D1.ChartArea.View.RotationX;
		}

		private void tbFloat_TextChanged(object sender, System.EventArgs e)
		{
			TextBox tb = (TextBox) sender;
			try
			{
				float.Parse( tb.Text);
			}
			catch
			{
				tb.Undo();
				tb.ClearUndo();
			}
			tb.Text = tb.Text.Trim();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			FuncNameForm fnf = new FuncNameForm();
			fnf.FName = cbFList.SelectedItem.ToString();
			if( fnf.ShowDialog() == DialogResult.OK)
			{
				int i = fcoll.FindName( fnf.FName);
				if( i==-1)
					i = fcoll.Add( new FunctionInfo( fnf.tbFName.Text, tbFuncText.Lines, Range));
				else
				{
					if( MessageBox.Show( "Overwrite existing function?", "Confirmation",
						MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						fcoll[i].Code = tbFuncText.Lines;
						fcoll[i].Range = Range;
					}
				}

				updateFList( i);
				XmlSerializer x = new XmlSerializer(typeof(FunctionInfoCollection));
				TextWriter writer = new StreamWriter( getConfigFileName());
				x.Serialize(writer, fcoll);
				writer.Close();
			}
 		}

		private void cbFList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int i = cbFList.SelectedIndex;
			if( i>=0 && i<=fcoll.Count)
			{
				this.tbFuncText.Lines = fcoll[i].Code;
				Range = fcoll[i].Range;
			}
		}

		private void tbErrors_VisibleChanged(object sender, System.EventArgs e)
		{
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void tlbChart_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch( tlbChart.Buttons.IndexOf( e.Button))
			{
				case 0:
					selectNext( cmChartType);
					break;
				case 1:
					selectNext( cmView);
					break;
				case 4:
					rotz += rot_inc;
					if( rotz>360)
						rotz -= 360;
					c1Chart3D1.ChartArea.View.RotationZ = rotz;
					break;
				case 3:
					rotz -= rot_inc;
					if( rotz<0)
						rotz += 360;
					c1Chart3D1.ChartArea.View.RotationZ = rotz;
					break;
				case 6:
					rotx += rot_inc;
					if( rotx>360)
						rotx -= 360;
					c1Chart3D1.ChartArea.View.RotationX = rotx;
					break;
				case 7:
					rotx -= rot_inc;
					if( rotx<0)
						rotx += 360;
					c1Chart3D1.ChartArea.View.RotationX = rotx;
					break;
				case 9:
					c1Chart3D1.ChartGroups[0].Elevation.IsMeshed = !c1Chart3D1.ChartGroups[0].Elevation.IsMeshed;
					break;
				case 10:
					c1Chart3D1.ChartArea.AxisX.Visible = !c1Chart3D1.ChartArea.AxisX.Visible;
					c1Chart3D1.ChartArea.AxisY.Visible = !c1Chart3D1.ChartArea.AxisY.Visible;
					c1Chart3D1.ChartArea.AxisZ.Visible = !c1Chart3D1.ChartArea.AxisZ.Visible;
					break;
				case 12:
					selectNext( cmContour);
					break;
				case 13:
					selectNext( cmNCont);
					break;
				default:
					break;
			}
		}

		private void miChartType_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = (MenuItem) sender;
			foreach( MenuItem _mi in cmChartType.MenuItems)
				_mi.Checked = false;
			mi.Checked = true;

			switch( this.cmChartType.MenuItems.IndexOf(mi))
			{
				case 0:
					c1Chart3D1.ChartGroups[0].ChartType = C1.Win.C1Chart3D.Chart3DTypeEnum.Bar;
					break;
				case 1:
					c1Chart3D1.ChartGroups[0].ChartType = C1.Win.C1Chart3D.Chart3DTypeEnum.Scatter;
					break;
				case 2:
					c1Chart3D1.ChartGroups[0].ChartType = C1.Win.C1Chart3D.Chart3DTypeEnum.Surface;
					break;
				default:
					break;
			}
		}

		private void miView_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = (MenuItem) sender;
			foreach( MenuItem _mi in cmView.MenuItems)
				_mi.Checked = false;
			mi.Checked = true;

			switch( this.cmView.MenuItems.IndexOf(mi))
			{
				case 0:
					c1Chart3D1.ChartArea.View.View3D = C1.Win.C1Chart3D.View3DEnum.Default;
					break;
				case 2:
					c1Chart3D1.ChartArea.View.View3D = C1.Win.C1Chart3D.View3DEnum.XY_2D_Pos;
					break;
				case 3:
					c1Chart3D1.ChartArea.View.View3D = C1.Win.C1Chart3D.View3DEnum.XZ_2D_Pos;
					break;
				case 4:
					c1Chart3D1.ChartArea.View.View3D = C1.Win.C1Chart3D.View3DEnum.YZ_2D_Pos;
					break;
				default:
					break;
			}
		}

		private void miContour_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = (MenuItem) sender;
			foreach( MenuItem _mi in cmContour.MenuItems)
				_mi.Checked = false;
			mi.Checked = true;

			int i = this.cmContour.MenuItems.IndexOf(mi);

			switch( i)
			{
				case 0:
					if( c1Chart3D1.ChartGroups[0].Contour.IsZoned)
						c1Chart3D1.ChartGroups[0].Contour.IsZoned = false;
					break;
				default:
					setZoneChart( (C1.Win.C1Chart3D.ColorSetEnum)i );
					break;
			}
		}

		private void miNCont_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = (MenuItem) sender;
			foreach( MenuItem _mi in cmNCont.MenuItems)
				_mi.Checked = false;
			mi.Checked = true;
			setZoneNumber( mi.Index*5 +10);
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);		
		}
	}
}
