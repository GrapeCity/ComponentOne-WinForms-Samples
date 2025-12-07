using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1Chart;

namespace PieStuff
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelp;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.GroupBox grpChartLabels;
		private System.Windows.Forms.GroupBox grpDataLabels;
		private System.Windows.Forms.GroupBox grpOutlines;
		private System.Windows.Forms.GroupBox grpStartAngle;
		private System.Windows.Forms.Label lblStartAngle;
		private System.Windows.Forms.TextBox txtStartAngle;
		private System.Windows.Forms.RadioButton radioLabelsOn;
		private System.Windows.Forms.RadioButton radioLabelsOff;
		private System.Windows.Forms.RadioButton radioDataLabOn;
		private System.Windows.Forms.RadioButton radioDataLabOff;
		private System.Windows.Forms.CheckBox checkOutlines;
		private System.Windows.Forms.GroupBox grpPieSliceOffsets;
		private System.Windows.Forms.Label lblSlice0Offset;
		private System.Windows.Forms.TextBox txtSlice0Offset;
		private System.Windows.Forms.Label lblSlice1Offset;
		private System.Windows.Forms.TextBox txtSlice1Offset;
		private System.Windows.Forms.Label lblSlice2Offset;
		private System.Windows.Forms.TextBox txtSlice2Offset;
		private System.Windows.Forms.Label lblSlice3Offset;
		private System.Windows.Forms.TextBox txtSlice3Offset;
		private System.Windows.Forms.Label lblSlice4Offset;
		private System.Windows.Forms.TextBox txtSlice4Offset;
		private System.Windows.Forms.Label lblSlice5Offset;
		private System.Windows.Forms.TextBox txtSlice5Offset;
		private System.Windows.Forms.Label lblSlice6Offset;
		private System.Windows.Forms.TextBox txtSlice6Offset;
		private System.Windows.Forms.Label lblSlice7Offset;
		private System.Windows.Forms.TextBox txtSlice7Offset;
		private System.Windows.Forms.GroupBox grpOtherSlice;
		private System.Windows.Forms.Label lblOtherOffset;
		private System.Windows.Forms.TextBox txtOtherOffset;
		private System.Windows.Forms.MenuItem menuHelpMoreInfo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblElev;
		private System.Windows.Forms.Label lblDepth;
		private System.Windows.Forms.NumericUpDown udElev;
		private System.Windows.Forms.NumericUpDown udDepth;
		private System.Windows.Forms.CheckBox check3D;
		private IContainer components;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.grpChartLabels = new System.Windows.Forms.GroupBox();
			this.radioLabelsOff = new System.Windows.Forms.RadioButton();
			this.radioLabelsOn = new System.Windows.Forms.RadioButton();
			this.grpDataLabels = new System.Windows.Forms.GroupBox();
			this.radioDataLabOn = new System.Windows.Forms.RadioButton();
			this.radioDataLabOff = new System.Windows.Forms.RadioButton();
			this.grpOutlines = new System.Windows.Forms.GroupBox();
			this.checkOutlines = new System.Windows.Forms.CheckBox();
			this.grpStartAngle = new System.Windows.Forms.GroupBox();
			this.txtStartAngle = new System.Windows.Forms.TextBox();
			this.lblStartAngle = new System.Windows.Forms.Label();
			this.grpOtherSlice = new System.Windows.Forms.GroupBox();
			this.txtOtherOffset = new System.Windows.Forms.TextBox();
			this.lblOtherOffset = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuHelp = new System.Windows.Forms.MenuItem();
			this.menuHelpMoreInfo = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.grpPieSliceOffsets = new System.Windows.Forms.GroupBox();
			this.lblSlice0Offset = new System.Windows.Forms.Label();
			this.txtSlice0Offset = new System.Windows.Forms.TextBox();
			this.lblSlice1Offset = new System.Windows.Forms.Label();
			this.txtSlice1Offset = new System.Windows.Forms.TextBox();
			this.lblSlice2Offset = new System.Windows.Forms.Label();
			this.txtSlice2Offset = new System.Windows.Forms.TextBox();
			this.lblSlice3Offset = new System.Windows.Forms.Label();
			this.txtSlice3Offset = new System.Windows.Forms.TextBox();
			this.lblSlice4Offset = new System.Windows.Forms.Label();
			this.txtSlice4Offset = new System.Windows.Forms.TextBox();
			this.lblSlice5Offset = new System.Windows.Forms.Label();
			this.txtSlice5Offset = new System.Windows.Forms.TextBox();
			this.lblSlice6Offset = new System.Windows.Forms.Label();
			this.txtSlice6Offset = new System.Windows.Forms.TextBox();
			this.lblSlice7Offset = new System.Windows.Forms.Label();
			this.txtSlice7Offset = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.udElev = new System.Windows.Forms.NumericUpDown();
			this.lblElev = new System.Windows.Forms.Label();
			this.check3D = new System.Windows.Forms.CheckBox();
			this.udDepth = new System.Windows.Forms.NumericUpDown();
			this.lblDepth = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.grpChartLabels.SuspendLayout();
			this.grpDataLabels.SuspendLayout();
			this.grpOutlines.SuspendLayout();
			this.grpStartAngle.SuspendLayout();
			this.grpOtherSlice.SuspendLayout();
			this.grpPieSliceOffsets.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udElev)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udDepth)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.Location = new System.Drawing.Point(138, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
			this.c1Chart1.Size = new System.Drawing.Size(336, 296);
			this.c1Chart1.TabIndex = 0;
			this.c1Chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseUp);
			this.c1Chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseMove);
			// 
			// grpChartLabels
			// 
			this.grpChartLabels.Controls.Add(this.radioLabelsOff);
			this.grpChartLabels.Controls.Add(this.radioLabelsOn);
			this.grpChartLabels.Location = new System.Drawing.Point(0, 0);
			this.grpChartLabels.Name = "grpChartLabels";
			this.grpChartLabels.Size = new System.Drawing.Size(136, 39);
			this.grpChartLabels.TabIndex = 1;
			this.grpChartLabels.TabStop = false;
			this.grpChartLabels.Text = "Chart Labels";
			// 
			// radioLabelsOff
			// 
			this.radioLabelsOff.AutoSize = true;
			this.radioLabelsOff.Location = new System.Drawing.Point(12, 12);
			this.radioLabelsOff.Name = "radioLabelsOff";
			this.radioLabelsOff.Size = new System.Drawing.Size(39, 17);
			this.radioLabelsOff.TabIndex = 1;
			this.radioLabelsOff.Text = "Off";
			this.radioLabelsOff.CheckedChanged += new System.EventHandler(this.radioLabelsOff_CheckedChanged);
			// 
			// radioLabelsOn
			// 
			this.radioLabelsOn.AutoSize = true;
			this.radioLabelsOn.Checked = true;
			this.radioLabelsOn.Location = new System.Drawing.Point(80, 12);
			this.radioLabelsOn.Name = "radioLabelsOn";
			this.radioLabelsOn.Size = new System.Drawing.Size(39, 17);
			this.radioLabelsOn.TabIndex = 0;
			this.radioLabelsOn.TabStop = true;
			this.radioLabelsOn.Text = "On";
			this.radioLabelsOn.CheckedChanged += new System.EventHandler(this.radioLabelsOn_CheckedChanged);
			// 
			// grpDataLabels
			// 
			this.grpDataLabels.Controls.Add(this.radioDataLabOn);
			this.grpDataLabels.Controls.Add(this.radioDataLabOff);
			this.grpDataLabels.Location = new System.Drawing.Point(0, 38);
			this.grpDataLabels.Name = "grpDataLabels";
			this.grpDataLabels.Size = new System.Drawing.Size(136, 39);
			this.grpDataLabels.TabIndex = 2;
			this.grpDataLabels.TabStop = false;
			this.grpDataLabels.Text = "Data Labels";
			// 
			// radioDataLabOn
			// 
			this.radioDataLabOn.AutoSize = true;
			this.radioDataLabOn.Checked = true;
			this.radioDataLabOn.Location = new System.Drawing.Point(80, 16);
			this.radioDataLabOn.Name = "radioDataLabOn";
			this.radioDataLabOn.Size = new System.Drawing.Size(39, 17);
			this.radioDataLabOn.TabIndex = 1;
			this.radioDataLabOn.TabStop = true;
			this.radioDataLabOn.Text = "On";
			this.radioDataLabOn.UseVisualStyleBackColor = true;
			this.radioDataLabOn.CheckedChanged += new System.EventHandler(this.radioDataLabelsOn_CheckChanged);
			// 
			// radioDataLabOff
			// 
			this.radioDataLabOff.AutoSize = true;
			this.radioDataLabOff.Location = new System.Drawing.Point(12, 16);
			this.radioDataLabOff.Name = "radioDataLabOff";
			this.radioDataLabOff.Size = new System.Drawing.Size(39, 17);
			this.radioDataLabOff.TabIndex = 0;
			this.radioDataLabOff.TabStop = true;
			this.radioDataLabOff.Text = "Off";
			this.radioDataLabOff.UseVisualStyleBackColor = true;
			this.radioDataLabOff.CheckedChanged += new System.EventHandler(this.radioDataLabelsOff_CheckChanged);
			// 
			// grpOutlines
			// 
			this.grpOutlines.Controls.Add(this.checkOutlines);
			this.grpOutlines.Location = new System.Drawing.Point(0, 77);
			this.grpOutlines.Name = "grpOutlines";
			this.grpOutlines.Size = new System.Drawing.Size(136, 40);
			this.grpOutlines.TabIndex = 3;
			this.grpOutlines.TabStop = false;
			this.grpOutlines.Text = "Outlines";
			// 
			// checkOutlines
			// 
			this.checkOutlines.Checked = true;
			this.checkOutlines.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkOutlines.Location = new System.Drawing.Point(8, 16);
			this.checkOutlines.Name = "checkOutlines";
			this.checkOutlines.Size = new System.Drawing.Size(96, 16);
			this.checkOutlines.TabIndex = 0;
			this.checkOutlines.Text = "Outlines";
			this.checkOutlines.CheckedChanged += new System.EventHandler(this.checkOutlines_CheckedChanged);
			// 
			// grpStartAngle
			// 
			this.grpStartAngle.Controls.Add(this.txtStartAngle);
			this.grpStartAngle.Controls.Add(this.lblStartAngle);
			this.grpStartAngle.Location = new System.Drawing.Point(0, 117);
			this.grpStartAngle.Name = "grpStartAngle";
			this.grpStartAngle.Size = new System.Drawing.Size(136, 48);
			this.grpStartAngle.TabIndex = 4;
			this.grpStartAngle.TabStop = false;
			// 
			// txtStartAngle
			// 
			this.txtStartAngle.Location = new System.Drawing.Point(88, 16);
			this.txtStartAngle.Name = "txtStartAngle";
			this.txtStartAngle.Size = new System.Drawing.Size(40, 20);
			this.txtStartAngle.TabIndex = 1;
			this.txtStartAngle.Text = "55";
			this.txtStartAngle.TextChanged += new System.EventHandler(this.txtStartAngle_TextChanged);
			this.txtStartAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyCheck);
			// 
			// lblStartAngle
			// 
			this.lblStartAngle.Location = new System.Drawing.Point(8, 18);
			this.lblStartAngle.Name = "lblStartAngle";
			this.lblStartAngle.Size = new System.Drawing.Size(80, 16);
			this.lblStartAngle.TabIndex = 0;
			this.lblStartAngle.Text = "Starting Angle:";
			// 
			// grpOtherSlice
			// 
			this.grpOtherSlice.Controls.Add(this.txtOtherOffset);
			this.grpOtherSlice.Controls.Add(this.lblOtherOffset);
			this.grpOtherSlice.Location = new System.Drawing.Point(0, 277);
			this.grpOtherSlice.Name = "grpOtherSlice";
			this.grpOtherSlice.Size = new System.Drawing.Size(136, 48);
			this.grpOtherSlice.TabIndex = 6;
			this.grpOtherSlice.TabStop = false;
			this.grpOtherSlice.Text = "Other Slice";
			// 
			// txtOtherOffset
			// 
			this.txtOtherOffset.Location = new System.Drawing.Point(72, 16);
			this.txtOtherOffset.Name = "txtOtherOffset";
			this.txtOtherOffset.Size = new System.Drawing.Size(32, 20);
			this.txtOtherOffset.TabIndex = 1;
			this.txtOtherOffset.Text = "0";
			this.txtOtherOffset.TextChanged += new System.EventHandler(this.txtOtherOffset_TextChanged);
			this.txtOtherOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyCheck);
			// 
			// lblOtherOffset
			// 
			this.lblOtherOffset.Location = new System.Drawing.Point(24, 18);
			this.lblOtherOffset.Name = "lblOtherOffset";
			this.lblOtherOffset.Size = new System.Drawing.Size(40, 16);
			this.lblOtherOffset.TabIndex = 0;
			this.lblOtherOffset.Text = "Offset:";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuHelp});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFileExit});
			this.menuFile.Text = "File";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 0;
			this.menuFileExit.Text = "Exit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.Index = 1;
			this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuHelpMoreInfo,
            this.menuHelpAbout});
			this.menuHelp.Text = "Help";
			// 
			// menuHelpMoreInfo
			// 
			this.menuHelpMoreInfo.Index = 0;
			this.menuHelpMoreInfo.Text = "More Info ...";
			this.menuHelpMoreInfo.Click += new System.EventHandler(this.menuHelpMoreInfo_Click);
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 1;
			this.menuHelpAbout.Text = "About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// grpPieSliceOffsets
			// 
			this.grpPieSliceOffsets.Controls.Add(this.lblSlice0Offset);
			this.grpPieSliceOffsets.Controls.Add(this.txtSlice0Offset);
			this.grpPieSliceOffsets.Controls.Add(this.lblSlice1Offset);
			this.grpPieSliceOffsets.Controls.Add(this.txtSlice1Offset);
			this.grpPieSliceOffsets.Controls.Add(this.lblSlice2Offset);
			this.grpPieSliceOffsets.Controls.Add(this.txtSlice2Offset);
			this.grpPieSliceOffsets.Controls.Add(this.lblSlice3Offset);
			this.grpPieSliceOffsets.Controls.Add(this.txtSlice3Offset);
			this.grpPieSliceOffsets.Controls.Add(this.lblSlice4Offset);
			this.grpPieSliceOffsets.Controls.Add(this.txtSlice4Offset);
			this.grpPieSliceOffsets.Controls.Add(this.lblSlice5Offset);
			this.grpPieSliceOffsets.Controls.Add(this.txtSlice5Offset);
			this.grpPieSliceOffsets.Controls.Add(this.lblSlice6Offset);
			this.grpPieSliceOffsets.Controls.Add(this.txtSlice6Offset);
			this.grpPieSliceOffsets.Controls.Add(this.lblSlice7Offset);
			this.grpPieSliceOffsets.Controls.Add(this.txtSlice7Offset);
			this.grpPieSliceOffsets.Location = new System.Drawing.Point(0, 165);
			this.grpPieSliceOffsets.Name = "grpPieSliceOffsets";
			this.grpPieSliceOffsets.Size = new System.Drawing.Size(136, 112);
			this.grpPieSliceOffsets.TabIndex = 5;
			this.grpPieSliceOffsets.TabStop = false;
			this.grpPieSliceOffsets.Text = "Pie Slice Offset Values";
			// 
			// lblSlice0Offset
			// 
			this.lblSlice0Offset.Location = new System.Drawing.Point(8, 18);
			this.lblSlice0Offset.Name = "lblSlice0Offset";
			this.lblSlice0Offset.Size = new System.Drawing.Size(16, 16);
			this.lblSlice0Offset.TabIndex = 0;
			this.lblSlice0Offset.Text = "0:";
			// 
			// txtSlice0Offset
			// 
			this.txtSlice0Offset.Location = new System.Drawing.Point(24, 16);
			this.txtSlice0Offset.Name = "txtSlice0Offset";
			this.txtSlice0Offset.Size = new System.Drawing.Size(40, 20);
			this.txtSlice0Offset.TabIndex = 1;
			this.txtSlice0Offset.Tag = 0;
			this.txtSlice0Offset.Text = "0";
			this.txtSlice0Offset.TextChanged += new System.EventHandler(this.SliceOffsetTextChanged);
			this.txtSlice0Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyCheck);
			// 
			// lblSlice1Offset
			// 
			this.lblSlice1Offset.Location = new System.Drawing.Point(8, 40);
			this.lblSlice1Offset.Name = "lblSlice1Offset";
			this.lblSlice1Offset.Size = new System.Drawing.Size(16, 16);
			this.lblSlice1Offset.TabIndex = 2;
			this.lblSlice1Offset.Text = "1:";
			// 
			// txtSlice1Offset
			// 
			this.txtSlice1Offset.Location = new System.Drawing.Point(24, 38);
			this.txtSlice1Offset.Name = "txtSlice1Offset";
			this.txtSlice1Offset.Size = new System.Drawing.Size(40, 20);
			this.txtSlice1Offset.TabIndex = 3;
			this.txtSlice1Offset.Tag = 1;
			this.txtSlice1Offset.Text = "0";
			this.txtSlice1Offset.TextChanged += new System.EventHandler(this.SliceOffsetTextChanged);
			this.txtSlice1Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyCheck);
			// 
			// lblSlice2Offset
			// 
			this.lblSlice2Offset.Location = new System.Drawing.Point(8, 62);
			this.lblSlice2Offset.Name = "lblSlice2Offset";
			this.lblSlice2Offset.Size = new System.Drawing.Size(16, 16);
			this.lblSlice2Offset.TabIndex = 4;
			this.lblSlice2Offset.Text = "2:";
			// 
			// txtSlice2Offset
			// 
			this.txtSlice2Offset.Location = new System.Drawing.Point(24, 60);
			this.txtSlice2Offset.Name = "txtSlice2Offset";
			this.txtSlice2Offset.Size = new System.Drawing.Size(40, 20);
			this.txtSlice2Offset.TabIndex = 5;
			this.txtSlice2Offset.Tag = 2;
			this.txtSlice2Offset.Text = "0";
			this.txtSlice2Offset.TextChanged += new System.EventHandler(this.SliceOffsetTextChanged);
			this.txtSlice2Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyCheck);
			// 
			// lblSlice3Offset
			// 
			this.lblSlice3Offset.Location = new System.Drawing.Point(8, 84);
			this.lblSlice3Offset.Name = "lblSlice3Offset";
			this.lblSlice3Offset.Size = new System.Drawing.Size(16, 16);
			this.lblSlice3Offset.TabIndex = 6;
			this.lblSlice3Offset.Text = "3:";
			// 
			// txtSlice3Offset
			// 
			this.txtSlice3Offset.Location = new System.Drawing.Point(24, 82);
			this.txtSlice3Offset.Name = "txtSlice3Offset";
			this.txtSlice3Offset.Size = new System.Drawing.Size(40, 20);
			this.txtSlice3Offset.TabIndex = 7;
			this.txtSlice3Offset.Tag = 3;
			this.txtSlice3Offset.Text = "0";
			this.txtSlice3Offset.TextChanged += new System.EventHandler(this.SliceOffsetTextChanged);
			this.txtSlice3Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyCheck);
			// 
			// lblSlice4Offset
			// 
			this.lblSlice4Offset.Location = new System.Drawing.Point(70, 18);
			this.lblSlice4Offset.Name = "lblSlice4Offset";
			this.lblSlice4Offset.Size = new System.Drawing.Size(16, 16);
			this.lblSlice4Offset.TabIndex = 8;
			this.lblSlice4Offset.Text = "4:";
			// 
			// txtSlice4Offset
			// 
			this.txtSlice4Offset.Location = new System.Drawing.Point(86, 16);
			this.txtSlice4Offset.Name = "txtSlice4Offset";
			this.txtSlice4Offset.Size = new System.Drawing.Size(40, 20);
			this.txtSlice4Offset.TabIndex = 9;
			this.txtSlice4Offset.Tag = 4;
			this.txtSlice4Offset.Text = "0";
			this.txtSlice4Offset.TextChanged += new System.EventHandler(this.SliceOffsetTextChanged);
			this.txtSlice4Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyCheck);
			// 
			// lblSlice5Offset
			// 
			this.lblSlice5Offset.Location = new System.Drawing.Point(70, 40);
			this.lblSlice5Offset.Name = "lblSlice5Offset";
			this.lblSlice5Offset.Size = new System.Drawing.Size(16, 16);
			this.lblSlice5Offset.TabIndex = 10;
			this.lblSlice5Offset.Text = "5:";
			// 
			// txtSlice5Offset
			// 
			this.txtSlice5Offset.Location = new System.Drawing.Point(86, 38);
			this.txtSlice5Offset.Name = "txtSlice5Offset";
			this.txtSlice5Offset.Size = new System.Drawing.Size(40, 20);
			this.txtSlice5Offset.TabIndex = 11;
			this.txtSlice5Offset.Tag = 5;
			this.txtSlice5Offset.Text = "0";
			this.txtSlice5Offset.TextChanged += new System.EventHandler(this.SliceOffsetTextChanged);
			this.txtSlice5Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyCheck);
			// 
			// lblSlice6Offset
			// 
			this.lblSlice6Offset.Location = new System.Drawing.Point(70, 62);
			this.lblSlice6Offset.Name = "lblSlice6Offset";
			this.lblSlice6Offset.Size = new System.Drawing.Size(16, 16);
			this.lblSlice6Offset.TabIndex = 12;
			this.lblSlice6Offset.Text = "6:";
			// 
			// txtSlice6Offset
			// 
			this.txtSlice6Offset.Location = new System.Drawing.Point(86, 60);
			this.txtSlice6Offset.Name = "txtSlice6Offset";
			this.txtSlice6Offset.Size = new System.Drawing.Size(40, 20);
			this.txtSlice6Offset.TabIndex = 13;
			this.txtSlice6Offset.Tag = 6;
			this.txtSlice6Offset.Text = "0";
			this.txtSlice6Offset.TextChanged += new System.EventHandler(this.SliceOffsetTextChanged);
			this.txtSlice6Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyCheck);
			// 
			// lblSlice7Offset
			// 
			this.lblSlice7Offset.Location = new System.Drawing.Point(70, 84);
			this.lblSlice7Offset.Name = "lblSlice7Offset";
			this.lblSlice7Offset.Size = new System.Drawing.Size(16, 16);
			this.lblSlice7Offset.TabIndex = 14;
			this.lblSlice7Offset.Text = "7:";
			// 
			// txtSlice7Offset
			// 
			this.txtSlice7Offset.Location = new System.Drawing.Point(86, 82);
			this.txtSlice7Offset.Name = "txtSlice7Offset";
			this.txtSlice7Offset.Size = new System.Drawing.Size(40, 20);
			this.txtSlice7Offset.TabIndex = 15;
			this.txtSlice7Offset.Tag = 7;
			this.txtSlice7Offset.Text = "0";
			this.txtSlice7Offset.TextChanged += new System.EventHandler(this.SliceOffsetTextChanged);
			this.txtSlice7Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyCheck);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.udElev);
			this.groupBox1.Controls.Add(this.lblElev);
			this.groupBox1.Controls.Add(this.check3D);
			this.groupBox1.Controls.Add(this.udDepth);
			this.groupBox1.Controls.Add(this.lblDepth);
			this.groupBox1.Location = new System.Drawing.Point(0, 325);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 64);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "3D";
			// 
			// udElev
			// 
			this.udElev.Enabled = false;
			this.udElev.Location = new System.Drawing.Point(88, 40);
			this.udElev.Name = "udElev";
			this.udElev.Size = new System.Drawing.Size(40, 20);
			this.udElev.TabIndex = 9;
			this.udElev.ValueChanged += new System.EventHandler(this.udElev_ValueChanged);
			// 
			// lblElev
			// 
			this.lblElev.Location = new System.Drawing.Point(48, 40);
			this.lblElev.Name = "lblElev";
			this.lblElev.Size = new System.Drawing.Size(32, 16);
			this.lblElev.TabIndex = 8;
			this.lblElev.Text = "Elev.";
			// 
			// check3D
			// 
			this.check3D.Location = new System.Drawing.Point(8, 16);
			this.check3D.Name = "check3D";
			this.check3D.Size = new System.Drawing.Size(40, 40);
			this.check3D.TabIndex = 7;
			this.check3D.Text = "On";
			this.check3D.CheckedChanged += new System.EventHandler(this.check3D_CheckedChanged);
			// 
			// udDepth
			// 
			this.udDepth.Enabled = false;
			this.udDepth.Location = new System.Drawing.Point(88, 16);
			this.udDepth.Name = "udDepth";
			this.udDepth.Size = new System.Drawing.Size(40, 20);
			this.udDepth.TabIndex = 7;
			this.udDepth.ValueChanged += new System.EventHandler(this.udDepth_ValueChanged);
			// 
			// lblDepth
			// 
			this.lblDepth.Location = new System.Drawing.Point(48, 16);
			this.lblDepth.Name = "lblDepth";
			this.lblDepth.Size = new System.Drawing.Size(40, 16);
			this.lblDepth.TabIndex = 7;
			this.lblDepth.Text = "Depth";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 391);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grpOtherSlice);
			this.Controls.Add(this.grpPieSliceOffsets);
			this.Controls.Add(this.grpStartAngle);
			this.Controls.Add(this.grpOutlines);
			this.Controls.Add(this.grpDataLabels);
			this.Controls.Add(this.grpChartLabels);
			this.Controls.Add(this.c1Chart1);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Pie Stuff";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			this.grpChartLabels.ResumeLayout(false);
			this.grpChartLabels.PerformLayout();
			this.grpDataLabels.ResumeLayout(false);
			this.grpDataLabels.PerformLayout();
			this.grpOutlines.ResumeLayout(false);
			this.grpStartAngle.ResumeLayout(false);
			this.grpStartAngle.PerformLayout();
			this.grpOtherSlice.ResumeLayout(false);
			this.grpOtherSlice.PerformLayout();
			this.grpPieSliceOffsets.ResumeLayout(false);
			this.grpPieSliceOffsets.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udElev)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udDepth)).EndInit();
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
			// Center the form
			this.CenterToParent();

			// All properties can be set at Design time, however
			// for instructional purposes, it is easier to see if
			// the properties are set at runtime.

			// Set up the Chart Appearance
			c1Chart1.Width = this.ClientSize.Width - c1Chart1.Left;
			c1Chart1.Height = this.ClientSize.Height;
			c1Chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;//!!VBPassThru
			c1Chart1.Style.BackColor = Color.CadetBlue;
			c1Chart1.Style.Border.BorderStyle = BorderStyleEnum.InsetBevel;

			// Add in the header
			Title hdr = c1Chart1.Header;
			hdr.Text = "Pie Chart Stuff";
			hdr.Style.Font = new Font("Arial Black", 16);
			hdr.Style.BackColor = Color.Tan;
			hdr.Style.Border.BorderStyle = BorderStyleEnum.RaisedBevel;
			hdr.Style.Border.Thickness = 4;

			// Add in the footer
			Title ftr = c1Chart1.Footer;
			ftr.Text = "Nowhere";
			ftr.Style.Font = new Font("Arial Narrow", 12, FontStyle.Bold);
			ftr.LocationDefault = new Point(10, -1);

			// Setup the legend.
			Legend lgd = c1Chart1.Legend;
			lgd.Compass = CompassEnum.East;
			lgd.Style.Border.BorderStyle = BorderStyleEnum.RaisedBevel;
			lgd.Style.Border.Color = Color.CadetBlue;
			lgd.Style.Border.Thickness = 4;
			lgd.Style.Font = new Font("Arial Narrow", 10);
			lgd.Style.HorizontalAlignment = AlignHorzEnum.Center;
			lgd.Text = "Series";
			lgd.Visible = true;

			// Set the Chart area style.
			Area area = c1Chart1.ChartArea;
			area.Style.Border.BorderStyle = BorderStyleEnum.RaisedBevel;
			area.Style.Border.Thickness = 4;

			// Set the default label style.  By using the default style,
			// all the labels styles can be handled uniformly
			c1Chart1.ChartLabels.DefaultLabelStyle.BackColor = SystemColors.Info;
			c1Chart1.ChartLabels.DefaultLabelStyle.Border.BorderStyle = BorderStyleEnum.Solid;

			// Set up a Pie chart with 8 slices
			ChartGroup grp = c1Chart1.ChartGroups[0];
			grp.ChartType = Chart2DTypeEnum.Pie;
			grp.Pie.OtherOffset = 0;
			grp.Pie.Start = int.Parse(txtStartAngle.Text);

			// Clear existing, and add new data.
			ChartData dat = grp.ChartData;
			dat.SeriesList.Clear();

			// SliceValue is the relative value of the slice in the whole.
			// These are the Y values.
			int [] SliceValue = new int [] { 30, 18, 26, 10, 40, 26, 12, 35 };

			// Pick a nice color for each Series.
			Color [] ColorValue = new Color []
				{
					Color.Red, Color.Tan, Color.LightGreen, Color.MediumTurquoise,
					Color.Blue, Color.Magenta, Color.GreenYellow, Color.MediumBlue
				};

			for(int slice=0; slice < SliceValue.Length; slice++)
			{
				ChartDataSeries series = dat.SeriesList.AddNewSeries();
				series.PointData.Length = 1;
				series.PointData[0] = new PointF(1f, SliceValue[slice]);
				series.LineStyle.Color = ColorValue[slice];
				series.Label = slice.ToString();

				// set the DataLabel to show each value and percent of the whole
				DataLabel dlab = series.DataLabel;
				dlab.Compass = LabelCompassEnum.RadialText;
				dlab.Offset = -2;
				dlab.Text = "{#YVAL} ({%YVAL:0.00%})";
				dlab.Style.BackColor = Color.Transparent;
				dlab.Style.Border.BorderStyle = BorderStyleEnum.None;
				dlab.Visible = radioDataLabOn.Checked;

				// Add a chart label for each slice
				C1.Win.C1Chart.Label lab = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
				lab.AttachMethod = AttachMethodEnum.DataIndex;

				AttachMethodData amd = lab.AttachMethodData;
				amd.GroupIndex = 0;
				amd.PointIndex = 0;
				amd.SeriesIndex = slice;

				lab.Text = "Chart Label " + slice.ToString();
				lab.Compass = LabelCompassEnum.Radial;
				lab.Connected = true;
				lab.Offset = 10;
				lab.Visible = radioLabelsOn.Checked;
			}

			udDepth.Minimum = 5;
			udDepth.Maximum = 100;
			udDepth.Value = 30;
			udDepth.Increment = 5;

			udElev.Minimum = 5;
			udElev.Maximum = 85;
			udElev.Value = 45;
			udElev.Increment = 5;
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuHelpMoreInfo_Click(object sender, System.EventArgs e)
		{
			string msg = "Click on a slice to toggle it's offset.\n" +
				"Click on a legend entry to toggle the series display.";

			MessageBox.Show( this, msg, "More Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void setLabelsStatus(bool labelsOn)
		{
			LabelsCollection labels = c1Chart1.ChartLabels.LabelsCollection;
			foreach(C1.Win.C1Chart.Label lab in labels)
				lab.Visible = labelsOn;
		}

		private void radioLabelsOn_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton rb = (RadioButton)sender;
			if(rb.Checked)
				setLabelsStatus(true);
		}

		private void radioLabelsOff_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton rb = (RadioButton)sender;
			if(rb.Checked)
				setLabelsStatus(false);
		}

		private void setDataLabelsStatus(bool labelsOn)
		{
			ChartDataSeriesCollection seriesList = c1Chart1.ChartGroups.Group0.ChartData.SeriesList;
			foreach (ChartDataSeries cds in seriesList)
				cds.DataLabel.Visible = labelsOn;
		}

		private void radioDataLabelsOn_CheckChanged(object sender, System.EventArgs e)
		{
			setDataLabelsStatus(true);
		}

		private void radioDataLabelsOff_CheckChanged(object sender, System.EventArgs e)
		{
			setDataLabelsStatus(false);
		}

		private void checkOutlines_CheckedChanged(object sender, System.EventArgs e)
		{
			CheckBox cb = (CheckBox)sender;
			c1Chart1.ChartGroups[0].ShowOutline = cb.Checked;
		}

		private void txtStartAngle_TextChanged(object sender, System.EventArgs e)
		{
			int angle = c1Chart1.ChartGroups[0].Pie.Start;
			try
			{
				angle = int.Parse(txtStartAngle.Text);
				c1Chart1.ChartGroups[0].Pie.Start = angle;
			}
			catch {}
		}

		private void SliceOffsetTextChanged(object sender, System.EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			int index = (int)tb.Tag;
			ChartDataSeriesCollection serList = c1Chart1.ChartGroups[0].ChartData.SeriesList;
			if(index >= 0 && index < serList.Count)
			{
				ChartDataSeries series = serList[index];
				int offset = series.Offset;
				try
				{
					offset = int.Parse(tb.Text);
					series.Offset = offset;
				}
				catch {}
			}
		}

		private void txtOtherOffset_TextChanged(object sender, System.EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			int offset = c1Chart1.ChartGroups[0].Pie.OtherOffset;
			try
			{
				offset = int.Parse(tb.Text);
				c1Chart1.ChartGroups[0].Pie.OtherOffset = offset;
			}
			catch {}		
		}

		private void txtKeyCheck(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
				return;

			e.Handled = true;
		}

		private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button.Equals(MouseButtons.None))
			{
				C1Chart chart = (C1Chart)sender;
				ChartRegionEnum region = chart.ChartRegionFromCoord(e.X, e.Y);

				int g = -1, s = -1, p = -1, d = -1;
				if(region.Equals(ChartRegionEnum.Legend))
				{
					if(chart.Legend.SeriesFromCoord(e.X, e.Y, ref g, ref s))
					{
						if(g >= 0 && s >= 0)
							chart.Footer.Text = "Series #" + s.ToString();
					}
				}
				else
				{
					ChartGroup grp = chart.ChartGroups[0];
					if(grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, ref s, ref p, ref d))
					{
						if(d == 0 && s >= 0 && p >= 0)
							chart.Footer.Text = "Slice #" + s.ToString();
						else if(!chart.Footer.Text.Equals("Nowhere"))
							chart.Footer.Text = "Nowhere";
					}
				}
			}
		}

		private void SetTextBoxSliceOffsetValue(int series, int offset)
		{
			foreach(Control c in grpPieSliceOffsets.Controls)
			{
				if(c is TextBox && c.Tag is int && c.Tag.Equals(series))
				{
					c.Text = offset.ToString();
					return;
				}
			}
		}

		private void c1Chart1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			C1Chart chart = (C1Chart)sender;

			if(e.Button.Equals(MouseButtons.Left))
			{
				int g = -1, s = -1, p = -1, d = -1;
				ChartGroup grp = chart.ChartGroups[0];
				ChartDataSeries ser = null;

				ChartRegionEnum region = chart.ChartRegionFromCoord(e.X, e.Y);
				if(region.Equals(ChartRegionEnum.Legend))
				{
					if(chart.Legend.SeriesFromCoord(e.X, e.Y, ref g, ref s))
					{
						ser = grp.ChartData.SeriesList[s];
						if(ser.Display.Equals(SeriesDisplayEnum.Show))
							ser.Display = SeriesDisplayEnum.Hide;
						else
							ser.Display = SeriesDisplayEnum.Show;
					}
					return;
				}

				if(grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord,
					ref s, ref p, ref d))
				{
					if(d == 0 && s >= 0 && p >= 0)
					{
						ser = grp.ChartData.SeriesList[s];
						int offset = ser.Offset;
						if(offset == 0)
							offset = 40;
						else
							offset = 0;
						ser.Offset = offset;

						SetTextBoxSliceOffsetValue(s, offset);
					}
				}
			}
		}

		private void udDepth_ValueChanged(object sender, System.EventArgs e)
		{
			if( check3D.Checked)
				c1Chart1.ChartArea.PlotArea.View3D.Depth = (int)udDepth.Value;
		}

		private void udElev_ValueChanged(object sender, System.EventArgs e)
		{
			if( check3D.Checked)
				c1Chart1.ChartArea.PlotArea.View3D.Elevation = (int)udElev.Value;
		}

		private void check3D_CheckedChanged(object sender, System.EventArgs e)
		{
			if( check3D.Checked)
			{
				c1Chart1.ChartArea.PlotArea.View3D.Depth = (int)udDepth.Value;
				c1Chart1.ChartArea.PlotArea.View3D.Elevation = (int)udElev.Value;

				udDepth.Enabled = true;
				udElev.Enabled = true;
			}
			else
			{
				c1Chart1.ChartArea.PlotArea.View3D.Depth = 0;

				udDepth.Enabled = false;
				udElev.Enabled = false;
			}
		}
	}
}
