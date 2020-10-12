using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

using C1.Win.C1Chart;

namespace propGrid
{

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private C1.Win.C1Chart.C1Chart C1Chart1;
		private System.Windows.Forms.MenuStrip mainMenu1;
		private System.Windows.Forms.ToolStripMenuItem menuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuItem2;
		private System.Windows.Forms.ToolStripSeparator menuSepItem4;
		private System.Windows.Forms.ToolStripMenuItem menuItem5;
		private System.Windows.Forms.ToolStripMenuItem menuItem6;
		private System.Windows.Forms.ToolStripSeparator menuSepItem7;
		private System.Windows.Forms.ToolStripMenuItem menuItem8;
		private System.Windows.Forms.ToolStripMenuItem menuItem9;
		private System.Windows.Forms.ToolStripMenuItem menuItem10;
		private System.Windows.Forms.ToolStripMenuItem menuItem11;
		private System.Windows.Forms.ToolStripMenuItem menuItem12;
		private System.Windows.Forms.ToolStripMenuItem menuItem13;
		private System.Windows.Forms.ToolStripMenuItem menuItem14;
		private System.Windows.Forms.ToolStripMenuItem menuItem15;
		private System.Windows.Forms.ToolStripMenuItem menuItem16;
		private System.Windows.Forms.ToolStripMenuItem menuItem17;
		private System.Windows.Forms.ToolStripSeparator menuSepItem18;
		private System.Windows.Forms.ToolStripMenuItem menuItem19;
		private System.Windows.Forms.ToolStripMenuItem menuItem3;
		private System.Windows.Forms.ToolStripMenuItem menuItem20;

		private const string cInfoLabel = "FloatingInfo";
		private const float hole_value = float.MaxValue;
		private System.Windows.Forms.ToolStripMenuItem menuItem21;
		private int m_unique = 0;
		private System.Windows.Forms.ToolStripMenuItem menuItem22;
		private System.Windows.Forms.ToolStripMenuItem menuItem23;
		private System.Windows.Forms.ToolStripMenuItem menuItem24;
		private System.Windows.Forms.ToolStripMenuItem menuItem25;
		private System.Windows.Forms.ToolStripMenuItem menuItem26;
		private System.Windows.Forms.ToolStripMenuItem menuItem27;
		private System.Windows.Forms.ToolStripMenuItem menuItem28;
		private System.Windows.Forms.ToolStripMenuItem menuItem29;
		private System.Windows.Forms.ToolStripMenuItem menuItem30;
		private System.Windows.Forms.ToolStripMenuItem menuItem31;
		private System.Windows.Forms.ToolStripMenuItem menuItem32;
		private System.Windows.Forms.ToolStripMenuItem menuItem33;
		private System.Windows.Forms.ToolStripMenuItem menuItem34;
		private System.Windows.Forms.ToolStripMenuItem menuItem35;
		private System.Windows.Forms.ToolStripMenuItem menuItem36;
		private System.Windows.Forms.ToolStripMenuItem menuItem37;
		private System.Windows.Forms.ToolStripMenuItem menuItem38;
		private System.Windows.Forms.ToolStripMenuItem menuItem39;
		private System.Windows.Forms.ToolStripMenuItem menuItem40;
		private System.Windows.Forms.ToolStripMenuItem menuItem41;
		private System.Windows.Forms.ToolStripMenuItem menuItem42;
		private System.Windows.Forms.ToolStripMenuItem menuItem43;
		private System.Windows.Forms.ToolStripMenuItem menuItem44;
		private System.Windows.Forms.ToolStripMenuItem menuItem45;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		public new void Dispose()
		{
			base.Dispose();
			if(components != null)
				components.Dispose();
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuItem19 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSepItem18 = new System.Windows.Forms.ToolStripSeparator();
			this.menuItem15 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem14 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem16 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem17 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem12 = new System.Windows.Forms.ToolStripMenuItem();
			this.C1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.mainMenu1 = new System.Windows.Forms.MenuStrip();
			this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem28 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem20 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem33 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem21 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem29 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem22 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem23 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem24 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem25 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem26 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem30 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem27 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem32 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem31 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSepItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.menuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem34 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem42 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem43 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem44 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem45 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem35 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem36 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem37 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem38 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem39 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem40 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSepItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.menuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItem41 = new System.Windows.Forms.ToolStripMenuItem();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			((System.ComponentModel.ISupportInitialize)(this.C1Chart1)).BeginInit();
			this.mainMenu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuItem19
			// 
			this.menuItem19.Name = "menuItem19";
			this.menuItem19.Size = new System.Drawing.Size(142, 22);
			this.menuItem19.Text = "Default Print";
			this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
			// 
			// menuSepItem18
			// 
			this.menuSepItem18.Name = "menuSepItem18";
			this.menuSepItem18.Size = new System.Drawing.Size(149, 6);
			// 
			// menuItem15
			// 
			this.menuItem15.Name = "menuItem15";
			this.menuItem15.Size = new System.Drawing.Size(152, 22);
			this.menuItem15.Text = "Page Setup ...";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuItem15,
			this.menuItem16,
			this.menuSepItem18,
			this.menuItem17});
			this.menuItem14.Name = "menuItem14";
			this.menuItem14.Size = new System.Drawing.Size(51, 20);
			this.menuItem14.Text = "Printer";
			// 
			// menuItem16
			// 
			this.menuItem16.Name = "menuItem16";
			this.menuItem16.Size = new System.Drawing.Size(152, 22);
			this.menuItem16.Text = "Printer Setup ...";
			this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Name = "menuItem17";
			this.menuItem17.Size = new System.Drawing.Size(152, 22);
			this.menuItem17.Text = "Dialog on Print";
			this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Name = "menuItem11";
			this.menuItem11.Size = new System.Drawing.Size(142, 22);
			this.menuItem11.Text = "ScaleToMax";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Name = "menuItem10";
			this.menuItem10.Size = new System.Drawing.Size(142, 22);
			this.menuItem10.Text = "ScaleToHeight";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Name = "menuItem13";
			this.menuItem13.Size = new System.Drawing.Size(142, 22);
			this.menuItem13.Text = "ScaleNone";
			this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Name = "menuItem12";
			this.menuItem12.Size = new System.Drawing.Size(142, 22);
			this.menuItem12.Text = "ScaleToWidth";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// C1Chart1
			// 
			this.C1Chart1.BackColor = System.Drawing.Color.SlateGray;
			this.C1Chart1.Location = new System.Drawing.Point(330, 38);
			this.C1Chart1.Name = "C1Chart1";
			this.C1Chart1.PropBag = resources.GetString("C1Chart1.PropBag");
			this.C1Chart1.Size = new System.Drawing.Size(336, 360);
			this.C1Chart1.TabIndex = 1;
			this.C1Chart1.BackColorChanged += new System.EventHandler(this.Chart1_BackColorChanged);
			this.C1Chart1.FontChanged += new System.EventHandler(this.Chart1_FontChanged);
			this.C1Chart1.ForeColorChanged += new System.EventHandler(this.Chart1_ForeColorChanged);
			this.C1Chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseMove);
			this.C1Chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseUp);
			// 
			// mainMenu1
			// 
			this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuItem1,
			this.menuItem14,
			this.menuItem41});
			this.mainMenu1.Location = new System.Drawing.Point(0, 0);
			this.mainMenu1.Name = "mainMenu1";
			this.mainMenu1.Size = new System.Drawing.Size(704, 24);
			this.mainMenu1.TabIndex = 0;
			this.mainMenu1.Text = "mainMenu1";
			// 
			// menuItem1
			// 
			this.menuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuItem2,
			this.menuItem28,
			this.menuItem3,
			this.menuItem20,
			this.menuItem33,
			this.menuItem21,
			this.menuItem29,
			this.menuItem22,
			this.menuItem23,
			this.menuItem24,
			this.menuItem25,
			this.menuItem26,
			this.menuItem30,
			this.menuItem27,
			this.menuItem32,
			this.menuItem31,
			this.menuSepItem4,
			this.menuItem6,
			this.menuItem34,
			this.menuItem35,
			this.menuItem38,
			this.menuItem8,
			this.menuSepItem7,
			this.menuItem5});
			this.menuItem1.Name = "menuItem1";
			this.menuItem1.Size = new System.Drawing.Size(83, 20);
			this.menuItem1.Text = "DemoOptions";
			// 
			// menuItem2
			// 
			this.menuItem2.Name = "menuItem2";
			this.menuItem2.Size = new System.Drawing.Size(207, 22);
			this.menuItem2.Text = "XY Plot - Trig Functions";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem28
			// 
			this.menuItem28.Name = "menuItem28";
			this.menuItem28.Size = new System.Drawing.Size(207, 22);
			this.menuItem28.Text = "Stacked XY Plot";
			this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Name = "menuItem3";
			this.menuItem3.Size = new System.Drawing.Size(207, 22);
			this.menuItem3.Text = "Pie Charts";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Name = "menuItem20";
			this.menuItem20.Size = new System.Drawing.Size(207, 22);
			this.menuItem20.Text = "Bar Chart";
			this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
			// 
			// menuItem33
			// 
			this.menuItem33.Name = "menuItem33";
			this.menuItem33.Size = new System.Drawing.Size(207, 22);
			this.menuItem33.Text = "Stacked Bar Chart";
			this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Name = "menuItem21";
			this.menuItem21.Size = new System.Drawing.Size(207, 22);
			this.menuItem21.Text = "Area Chart - Trig Functions";
			this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
			// 
			// menuItem29
			// 
			this.menuItem29.Name = "menuItem29";
			this.menuItem29.Size = new System.Drawing.Size(207, 22);
			this.menuItem29.Text = "Stacked Area Chart";
			this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Name = "menuItem22";
			this.menuItem22.Size = new System.Drawing.Size(207, 22);
			this.menuItem22.Text = "Hi-Lo Chart";
			this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
			// 
			// menuItem23
			// 
			this.menuItem23.Name = "menuItem23";
			this.menuItem23.Size = new System.Drawing.Size(207, 22);
			this.menuItem23.Text = "Hi-Lo-Open-Close";
			this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
			// 
			// menuItem24
			// 
			this.menuItem24.Name = "menuItem24";
			this.menuItem24.Size = new System.Drawing.Size(207, 22);
			this.menuItem24.Text = "Bubble Chart";
			this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
			// 
			// menuItem25
			// 
			this.menuItem25.Name = "menuItem25";
			this.menuItem25.Size = new System.Drawing.Size(207, 22);
			this.menuItem25.Text = "Candle Chart";
			this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.Name = "menuItem26";
			this.menuItem26.Size = new System.Drawing.Size(207, 22);
			this.menuItem26.Text = "Polar Chart";
			this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
			// 
			// menuItem30
			// 
			this.menuItem30.Name = "menuItem30";
			this.menuItem30.Size = new System.Drawing.Size(207, 22);
			this.menuItem30.Text = "Stacked Polar Chart";
			this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
			// 
			// menuItem27
			// 
			this.menuItem27.Name = "menuItem27";
			this.menuItem27.Size = new System.Drawing.Size(207, 22);
			this.menuItem27.Text = "Radar Chart";
			this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
			// 
			// menuItem32
			// 
			this.menuItem32.Name = "menuItem32";
			this.menuItem32.Size = new System.Drawing.Size(207, 22);
			this.menuItem32.Text = "Simple Stacked Radar Chart";
			this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
			// 
			// menuItem31
			// 
			this.menuItem31.Name = "menuItem31";
			this.menuItem31.Size = new System.Drawing.Size(207, 22);
			this.menuItem31.Text = "Stacked Radar Chart";
			this.menuItem31.Click += new System.EventHandler(this.menuItem31_Click);
			// 
			// menuSepItem4
			// 
			this.menuSepItem4.Name = "menuSepItem4";
			this.menuSepItem4.Size = new System.Drawing.Size(204, 6);
			// 
			// menuItem6
			// 
			this.menuItem6.Name = "menuItem6";
			this.menuItem6.Size = new System.Drawing.Size(207, 22);
			this.menuItem6.Text = "Reset C1Chart";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem34
			// 
			this.menuItem34.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuItem42,
			this.menuItem43});
			this.menuItem34.Name = "menuItem34";
			this.menuItem34.Size = new System.Drawing.Size(207, 22);
			this.menuItem34.Text = "Save Chart Image";
			this.menuItem34.Click += new System.EventHandler(this.menuItem34_Click);
			// 
			// menuItem42
			// 
			this.menuItem42.Name = "menuItem42";
			this.menuItem42.Size = new System.Drawing.Size(157, 22);
			this.menuItem42.Text = "Save to file";
			this.menuItem42.Click += new System.EventHandler(this.menuItem42_Click);
			// 
			// menuItem43
			// 
			this.menuItem43.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuItem44,
			this.menuItem45});
			this.menuItem43.Name = "menuItem43";
			this.menuItem43.Size = new System.Drawing.Size(157, 22);
			this.menuItem43.Text = "Save to clipboard";
			// 
			// menuItem44
			// 
			this.menuItem44.Name = "menuItem44";
			this.menuItem44.Size = new System.Drawing.Size(108, 22);
			this.menuItem44.Text = "as BMP";
			this.menuItem44.Click += new System.EventHandler(this.menuItem44_Click);
			// 
			// menuItem45
			// 
			this.menuItem45.Name = "menuItem45";
			this.menuItem45.Size = new System.Drawing.Size(108, 22);
			this.menuItem45.Text = "as EMF";
			this.menuItem45.Click += new System.EventHandler(this.menuItem45_Click);
			// 
			// menuItem35
			// 
			this.menuItem35.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuItem36,
			this.menuItem37});
			this.menuItem35.Name = "menuItem35";
			this.menuItem35.Size = new System.Drawing.Size(207, 22);
			this.menuItem35.Text = "Save/Load Chart";
			// 
			// menuItem36
			// 
			this.menuItem36.Name = "menuItem36";
			this.menuItem36.Size = new System.Drawing.Size(141, 22);
			this.menuItem36.Text = "Save to File";
			this.menuItem36.Click += new System.EventHandler(this.menuItem36_Click);
			// 
			// menuItem37
			// 
			this.menuItem37.Name = "menuItem37";
			this.menuItem37.Size = new System.Drawing.Size(141, 22);
			this.menuItem37.Text = "Load from File";
			this.menuItem37.Click += new System.EventHandler(this.menuItem37_Click);
			// 
			// menuItem38
			// 
			this.menuItem38.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuItem39,
			this.menuItem40});
			this.menuItem38.Name = "menuItem38";
			this.menuItem38.Size = new System.Drawing.Size(207, 22);
			this.menuItem38.Text = "Save/Load Data";
			// 
			// menuItem39
			// 
			this.menuItem39.Name = "menuItem39";
			this.menuItem39.Size = new System.Drawing.Size(167, 22);
			this.menuItem39.Text = "Save Data to File";
			this.menuItem39.Click += new System.EventHandler(this.menuItem39_Click);
			// 
			// menuItem40
			// 
			this.menuItem40.Name = "menuItem40";
			this.menuItem40.Size = new System.Drawing.Size(167, 22);
			this.menuItem40.Text = "Load Data from File";
			this.menuItem40.Click += new System.EventHandler(this.menuItem40_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuItem13,
			this.menuItem9,
			this.menuItem10,
			this.menuItem11,
			this.menuItem12,
			this.menuItem19});
			this.menuItem8.Name = "menuItem8";
			this.menuItem8.Size = new System.Drawing.Size(207, 22);
			this.menuItem8.Text = "Print C1Chart";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Name = "menuItem9";
			this.menuItem9.Size = new System.Drawing.Size(142, 22);
			this.menuItem9.Text = "ScaleToFit";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuSepItem7
			// 
			this.menuSepItem7.Name = "menuSepItem7";
			this.menuSepItem7.Size = new System.Drawing.Size(204, 6);
			// 
			// menuItem5
			// 
			this.menuItem5.Name = "menuItem5";
			this.menuItem5.Size = new System.Drawing.Size(207, 22);
			this.menuItem5.Text = "Exit";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem41
			// 
			this.menuItem41.Name = "menuItem41";
			this.menuItem41.Size = new System.Drawing.Size(68, 20);
			this.menuItem41.Text = "Properties";
			this.menuItem41.Click += new System.EventHandler(this.menuItem41_Click);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(12, 38);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(304, 272);
			this.propertyGrid1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 420);
			this.Controls.Add(this.C1Chart1);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.mainMenu1);
			this.MainMenuStrip = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			((System.ComponentModel.ISupportInitialize)(this.C1Chart1)).EndInit();
			this.mainMenu1.ResumeLayout(false);
			this.mainMenu1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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

		private void _sizeControls()
		{
			this.propertyGrid1.Top = this.mainMenu1.Bottom + 1;
			this.propertyGrid1.Height = this.ClientSize.Height - this.mainMenu1.Height - 1;
			this.C1Chart1.Left = this.propertyGrid1.Width;
			this.C1Chart1.Top = this.mainMenu1.Bottom + 1;
			this.C1Chart1.Height = this.ClientSize.Height - this.mainMenu1.Height - 1;
			this.C1Chart1.Width = this.ClientSize.Width - this.C1Chart1.Left;
		}

		private int _unique
		{
			get { m_unique++; return m_unique; }
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.propertyGrid1.SelectedObject = this.C1Chart1;
			this.propertyGrid1.Text = this.C1Chart1.Name;
			this.propertyGrid1.Top = 0;
			this.propertyGrid1.Left = 0;
			this.C1Chart1.Top = 0;
			_sizeControls();
			this.menuItem17.Checked = C1Chart1.PrintDialogUsage;
			this.runTestProcedures();
			Debug.WriteLine("Chart AssemblyFileVersion: " + C1Chart1.AssemblyFileVersionString);
			Debug.WriteLine("Chart AssemblyVersion: " + C1Chart1.AssemblyVersionString);
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			_sizeControls();
		}

		private void Chart1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				Debug.WriteLine("Right Click X,Y Position = " + e.X.ToString() + "," + e.Y.ToString());
				ChartGroup grp = C1Chart1.ChartGroups.Group0;

				float xd=0f, yd=0f;
				if(grp.CoordToDataCoord(e.X, e.Y, ref xd, ref yd))
				{
					Debug.WriteLine("	DataCoord = " + xd.ToString() + "," + yd.ToString());
				}
			}
			else if(e.Button == MouseButtons.Middle)
			{
				if ((Control.ModifierKeys & (Keys.Shift | Keys.Alt | Keys.Control)) != 0) return;

				Debug.WriteLine("Middle Click");

				// the floating labels, since constantly repainting
				// these labels will undo the drawing below.
				LabelsCollection lc = C1Chart1.ChartLabels.LabelsCollection;
				lc.Remove(lc[cInfoLabel + "0"]);
				lc.Remove(lc[cInfoLabel + "1"]);
				C1Chart1.Refresh();

				ChartGroup grp = C1Chart1.ChartGroups.Group0;
				int si=0, pi=0, ds=0;
				// find the nearest point.
				if(grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, ref si, ref pi, ref ds))
				{
					Rectangle r = grp.DataIndexToRect(si, pi);
					if(!r.IsEmpty)
					{
						Pen lpen = Pens.Black;
						Brush lbrush = Brushes.Black;

						if(grp.ChartType == Chart2DTypeEnum.Pie)
						{
							// pie charts a special case, where the
							// returned rectangle provides information
							// describing the pie slice, and not really
							// a rectangle.
							if(ds == 0)
							{
								int xp=0, yp=0;
								if(grp.DataIndexToCoord(si, pi, ref xp, ref yp))
								{
									xp -= r.Left;
									yp -= r.Top;

									int radius = (int)Math.Sqrt(xp*xp + yp*yp);
									int startAngle = r.Width;
									int sweepAngle = r.Height - r.Width;

									r.Width = 2 * radius;
									r.Height = 2 * radius;
									r.X -= radius;
									r.Y -= radius;

									Graphics g = C1Chart1.CreateGraphics();									
									g.DrawPie(lpen, r, startAngle, sweepAngle);
									g.FillPie(lbrush, r, startAngle, sweepAngle);
									g.Dispose();
								}
							}
						}
						else if(r.Contains(e.X, e.Y))
						{
							// if the nearest point rect contains the click point
							// draw and fill the rectangle the rectangle.
							Graphics g = C1Chart1.CreateGraphics();
							g.DrawRectangle(lpen,r);
							g.FillRectangle(lbrush,r);
							g.Dispose();
						}
					}
				}
			}
		}

		private void Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ChartRegionEnum region = C1Chart1.ChartRegionFromCoord(e.X, e.Y);
			Debug.WriteLine(_unique.ToString() + ") RegionCode: " + region.ToString());
			if(region == ChartRegionEnum.Legend)
			{
				int gi=0, si=0;
				if(C1Chart1.Legend.SeriesFromCoord(e.X, e.Y, ref gi, ref si))
				{
					string seriesName = C1Chart1.ChartGroups[gi].ChartData[si].Label;
					Debug.WriteLine("  gi=" + gi.ToString() + ", si=" + si.ToString() + 
						", SeriesName=" + seriesName);
				}
			}
			else if(region == ChartRegionEnum.ChartLabel)
			{
				int li=0;
				if(C1Chart1.ChartLabels.LabelFromCoord(e.X, e.Y, ref li))
				{
					C1.Win.C1Chart.Label lab = C1Chart1.ChartLabels[li];
					Debug.WriteLine(" LabelIndex=" + li.ToString() + ", LabelName=" + lab.Name);
				}
			}

			if(C1Chart1.Capture)
			{
				if(e.Button == MouseButtons.Left)
				{
					if(this.Cursor.Equals(Cursors.VSplit))
					{
						int newleft = C1Chart1.Left + e.X;
						propertyGrid1.Width = newleft-1;
						_sizeControls();
					}
				}
				else
				{
					if(e.X < -10 || e.X > 10)
					{
						// restore mouse cursor
						if(Cursor.Equals(Cursors.VSplit))
							this.Cursor = Cursors.Default;
					}
				}
			}
			else
			{
				if(e.X >= -10 && e.X <= 10)
				{
					// set mouse cursor
					if(!Cursor.Equals(Cursors.VSplit))
						this.Cursor = Cursors.VSplit;
				}
				else
				{
					// restore mouse cursor
					if(Cursor.Equals(Cursors.VSplit))
						this.Cursor = Cursors.Default;
				}

				for(int i=0; i < C1Chart1.ChartGroups.Count; i++)
				{
					ChartGroup grp = C1Chart1.ChartGroups[i];
					if(grp.ChartData.SeriesList.Count > 0)
					{
						float xd=0f, yd=0f;
						if(grp.CoordToDataCoord(e.X, e.Y, ref xd, ref yd))
						{
							C1.Win.C1Chart.Label l = C1Chart1.ChartLabels[cInfoLabel + i.ToString()];
							if(l != null)
							{
								int borderWidth = C1Chart1.Style.Border.Thickness;
								if(i==0)
									l.AttachMethodData.X = borderWidth;
								else
									l.AttachMethodData.X = C1Chart1.Width - borderWidth;

								l.AttachMethodData.Y = borderWidth;
								l.Text = "<<< " + l.Name + " >>>\n";
								l.Text += "Coord=(" + e.X.ToString() + "," + e.Y.ToString() + ")\n" +
									"  DataCoord=" + xd.ToString() + "," + yd.ToString() + ")\n";

								int xc=0, yc=0;
								grp.DataCoordToCoord(xd, yd, ref xc, ref yc);
								l.Text += "	   Coord=(" + xc.ToString() + "," + yc.ToString() + ")\n";

								int s=0;
								int p=0;
								int dist=-1;
								grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, ref s, ref p, ref dist);
								//grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XCoord, ref s, ref p, ref dist);
								//grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.YCoord, ref s, ref p, ref dist);
								l.Text += "	 Series=" + s.ToString() + "(";
								if(s >= 0)
									l.Text += grp.ChartData.SeriesList[s].Label;
								else
									l.Text += "n/a";
								l.Text += ")  Point=" + p.ToString() + "   Distance=" + dist.ToString() + "\n";
				
								if(s >= 0 && p >= 0)
								{
									grp.DataIndexToCoord(s, p, ref xc, ref yc);
									l.Text += "	   Coord=(" + xc.ToString() + "," + yc.ToString() + ")";

									PointF pf = (PointF)grp.ChartData.SeriesList[s].PointData[p];
									l.Text += "	   DataValue(s,p)=" + pf.ToString() + "\n";

									if(	grp.ChartType == Chart2DTypeEnum.HiLo ||
										grp.ChartType == Chart2DTypeEnum.HiLoOpenClose ||
										grp.ChartType == Chart2DTypeEnum.Candle)
									{
										ChartDataSeries ser = grp.ChartData.SeriesList[s];
										float hi = (float)ser.Y[p];
										float lo = (float)ser.Y1[p];
										string adder = "	Hi=" + hi.ToString() + ", Lo=" + lo.ToString();
										if( grp.ChartType == Chart2DTypeEnum.HiLoOpenClose ||
											grp.ChartType == Chart2DTypeEnum.Candle)
										{
											hi = (float)ser.Y2[p];		// open
											lo = (float)ser.Y3[p];		// close
											adder += ", Open=" + hi.ToString() + ", Close=" + lo.ToString();
										}
										if(ser.X.DataType.Equals(typeof(DateTime)))
										{
											adder += ", Date=" + ((DateTime)ser.X[p]).ToShortDateString();
										}
										l.Text += adder + "\n";
									}
								}
								if(!l.Visible) l.Visible = true;
							}
						}
					}
				}
			}
		}

		private PointF [] makeSineCurveData(float phasor)
		{
			const int nPts = 42;
			double pi = System.Math.PI;

			PointF [] pts = (PointF[])Array.CreateInstance(typeof(PointF),nPts);

			double xi = (4.0 * pi) / (nPts-1);
			for(int i=0; i < nPts; i++)
			{
				double x = (double)i * xi;
				pts[i].X = (float)x;
				pts[i].Y = (float)Math.Sin(x + phasor);
			}

			return pts;
		}

		private void addInfoLabels()
		{
			// add a floating informational label that
			// will response to chart positioning
			C1.Win.C1Chart.Label l = C1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
			l.Visible = false;
			l.Name = cInfoLabel + "0";
			l.Style.Font = new Font("Arial", 8);
			l.Style.HorizontalAlignment = AlignHorzEnum.Near;
			l.Style.BackColor = Color.FromKnownColor(KnownColor.Info);
			l.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			l.Style.Border.Color = Color.Red;
			l.Style.Border.Thickness = 1;
			l.AttachMethod = AttachMethodEnum.Coordinate;
			l.Compass = LabelCompassEnum.SouthEast;

			l = C1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
			l.Visible = false;
			l.Name = cInfoLabel + "1";
			l.Style.Font = new Font("Arial", 8);
			l.Style.BackColor = Color.FromKnownColor(KnownColor.Info);
			l.Style.HorizontalAlignment = AlignHorzEnum.Far;
			l.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			l.Style.Border.Color = Color.Red;
			l.Style.Border.Thickness = 1;
			l.AttachMethod = AttachMethodEnum.Coordinate;
			l.Compass = LabelCompassEnum.SouthWest;
		}

		public void doRefresh()
		{
			propertyGrid1.Refresh();
		}

		public void runTestProceduresForXYPlot()
		{
			C1Chart1.Reset();

			// this is a dummy function that is used to modify
			// object properties during startup.  It is to be removed
			// later, if this application is ever used as a designer.
			C1Chart1.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			C1Chart1.Style.Border.Thickness = 5;

			C1.Win.C1Chart.Title lab = this.C1Chart1.Header;
			lab.Text = "This is the header";
			lab.Style.Font = new Font("Arial", 18, FontStyle.Bold);
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			lab.Style.Border.Thickness = 5;
			lab.Visible = true;

			lab = this.C1Chart1.Footer;
			lab.Text = "This is the footer";
			lab.Style.Font = new Font("Arial", 18, FontStyle.Bold);
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			lab.Style.Border.Thickness = 5;
			lab.Visible = true;

			C1.Win.C1Chart.Legend leg = this.C1Chart1.Legend;
			leg.Text = "Legend";
			leg.Style.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);	//!!VBPassThru
			leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			leg.Style.Border.Thickness = 8;
			leg.Visible = true;

			Area area = this.C1Chart1.ChartArea;
			area.Style.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);	//!!VBPassThru
			area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			area.Style.Border.Thickness = 8;
			area.Visible = true;

			area.AxisX.Text = "The X-Axis";
			area.AxisY.Text = "The Y-Axis";
			area.AxisY2.Text = "The Y2-Axis";

			PointF [] ps;
			float pif = (float)System.Math.PI;

			ChartGroup group = C1Chart1.ChartGroups[0];
			ChartGroup group1 = C1Chart1.ChartGroups[1];
			group.ChartType = Chart2DTypeEnum.XYPlot;
			ChartData data = group.ChartData;

			ChartDataSeries s = new ChartDataSeries();
			data.SeriesList.Add(s);
			ps = this.makeSineCurveData(0.0F);
			ps[1].Y = hole_value;
			s.PointData.CopyDataIn(ps);
			s.LineStyle.Thickness = 1;
			s.FitType = FitTypeEnum.Line;

			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			ps = this.makeSineCurveData(pif/2);
			ps[10].X = hole_value;
			ps[11].Y = hole_value;
			s.PointData.CopyDataIn(ps);
			s.LineStyle.Thickness = 2;
			s.FitType = FitTypeEnum.Spline;

			s = new ChartDataSeries();
			ps = this.makeSineCurveData(pif);
			ps[22].Y = hole_value;
			s.PointData.CopyDataIn(ps);
			s.LineStyle.Thickness = 3;
			s.FitType = FitTypeEnum.Beziers;
			data.SeriesList.Add(s);

			s = new ChartDataSeries();
			ps = new PointF[] { PointF.Empty, new PointF((float)data.MaxX, 0f) };
			s.PointData.CopyDataIn(ps);
			s.LineStyle.Thickness = 2;
			data.SeriesList.Insert(0,s);

			s = data.SeriesList.AddNewSeries();
			ps = this.makeSineCurveData(pif/4);
			s.PointData.CopyDataIn(ps);
			s.LineStyle.Thickness = 7;

			s = data.SeriesList.AddNewSeries();
			ps = this.makeSineCurveData(2.445F);
			s.PointData.CopyDataIn(ps);
			s.LineStyle.Thickness = 7;
			s.FitType = FitTypeEnum.Spline;

			ChartLabels cLabs = C1Chart1.ChartLabels;
			cLabs.DefaultLabelStyle.BackColor = Color.Turquoise;
			cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			cLabs.DefaultLabelStyle.Border.Thickness = 2;

			C1.Win.C1Chart.Label cLab = cLabs.LabelsCollection.AddNewLabel();
			cLab.Text = "This is a C1Chart Label\nSecond line of label";
			cLab.AttachMethod = AttachMethodEnum.DataIndex;
			cLab.AttachMethodData.GroupIndex = 0;
			cLab.AttachMethodData.SeriesIndex = 2;
			cLab.AttachMethodData.PointIndex = 3;
			cLab.Connected = true;
			cLab.Offset = 15;
			cLab.Visible = true;

			addInfoLabels();
			doRefresh();
		}

		public void runTestProceduresForStackedXYChart()
		{
			C1Chart1.Reset();

			// this is a dummy function that is used to modify
			// object properties during startup.  It is to be removed
			// later, if this application is ever used as a designer.
			C1Chart1.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			C1Chart1.Style.Border.Thickness = 5;

			C1.Win.C1Chart.Title lab = this.C1Chart1.Header;
			lab.Text = "Stacked XY Header";
			lab.Style.Font = new Font("Arial", 18, FontStyle.Bold);
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			lab.Style.Border.Thickness = 5;
			lab.Visible = true;

			lab = this.C1Chart1.Footer;
			lab.Text = "Stacked XY Footer";
			lab.Style.Font = new Font("Arial", 18, FontStyle.Bold);
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			lab.Style.Border.Thickness = 5;
			lab.Visible = true;

			C1.Win.C1Chart.Legend leg = this.C1Chart1.Legend;
			leg.Text = "Legend";
			leg.Style.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);	//!!VBPassThru
			leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			leg.Style.Border.Thickness = 8;
			leg.Visible = true;

			Area area = this.C1Chart1.ChartArea;
			area.Style.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);	//!!VBPassThru
			area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel;
			area.Style.Border.Thickness = 8;
			area.Visible = true;

			area.AxisX.Text = "The X-Axis";
			area.AxisX.GridMajor.Visible = true;
			area.AxisX.GridMajor.Color = Color.Black;
			area.AxisX.GridMinor.Visible = true;
			area.AxisX.GridMinor.Color = Color.DarkBlue;

			area.AxisY.Text = "The Y-Axis";
			area.AxisY.GridMajor.Visible = true;
			area.AxisY.GridMajor.Color = Color.Black;
			area.AxisY.GridMinor.Visible = true;
			area.AxisY.GridMinor.Color = Color.DarkBlue;

			ChartGroup group = C1Chart1.ChartGroups[0];
			group.ChartType = Chart2DTypeEnum.XYPlot;
			group.Stacked = true;

			ChartData data = group.ChartData;

			ChartDataSeries s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.FitType = FitTypeEnum.Line;
			PointF[] pfa = new PointF[]
				{
					new PointF(0.5f, 0.5f),
					new PointF(1f, 1.5f), 
					new PointF(1.5f, 3f),
					new PointF(1.6f, 3.5f),
					new PointF(1.8f, 1.5f),
				};
			s.PointData.CopyDataIn(pfa); 

			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.FitType = FitTypeEnum.Spline;
			pfa = new PointF[]
				{
					PointF.Empty,
					new PointF(0.5f, 1.2f),
					new PointF(1f, 1.2f), 
					new PointF(1.5f, 1.3f), 
					new PointF(2f, 4f)
				};
			s.PointData.CopyDataIn(pfa); 

			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.FitType = FitTypeEnum.Line;
			pfa = new PointF[]
				{
					new PointF(0f, 1.2f),
					new PointF(0.81f, 2f), 
					new PointF(1.5f, 3f), 
					new PointF(2f, 1f)
				};
			s.PointData.CopyDataIn(pfa); 

			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.FitType = FitTypeEnum.Spline;
			pfa = new PointF[]
				{
					new PointF(0f, 1.2f),
					new PointF(1f, 1f), 
					new PointF(1.5f, 0.3f), 
					new PointF(2f, 0.5f)
				};
			s.PointData.CopyDataIn(pfa); 

			ChartLabels cLabs = C1Chart1.ChartLabels;
			cLabs.DefaultLabelStyle.BackColor = Color.Turquoise;
			cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			cLabs.DefaultLabelStyle.Border.Thickness = 2;

			C1.Win.C1Chart.Label cLab = cLabs.LabelsCollection.AddNewLabel();
			cLab.Text = "G=0,S=2,P=3";
			cLab.AttachMethod = AttachMethodEnum.DataIndex;
			cLab.AttachMethodData.GroupIndex = 0;
			cLab.AttachMethodData.SeriesIndex = 2;
			cLab.AttachMethodData.PointIndex = 3;
			cLab.Connected = true;
			cLab.Offset = 15;
			cLab.Visible = true;

			addInfoLabels();
			doRefresh();
		}

		public void runTestProceduresForStackedAreaChart()
		{
			runTestProceduresForStackedXYChart();
			ChartGroup grp = C1Chart1.ChartGroups[0];
			grp.ChartType = Chart2DTypeEnum.Area;
			grp.Stacked = true;

			C1Chart1.Header.Text = "Stacked Area Header";
			C1Chart1.Footer.Text = "Stacked Area Footer";
			doRefresh();
		}

		public void runTestProceduresForPieChart()
		{
			C1Chart1.Reset();
			C1Chart1.Style.Font = new Font("Arial", 18, FontStyle.Bold);

			C1.Win.C1Chart.Title lab = this.C1Chart1.Header;
			lab.Text = "Pie C1Chart";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			lab = C1Chart1.Footer;
			lab.Text = "Pie Footer";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			C1.Win.C1Chart.Legend leg = this.C1Chart1.Legend;
			leg.Text = "Legend";
			leg.Style.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);	//!!VBPassThru
			leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			leg.Style.Border.Thickness = 2;
			leg.Visible = true;

			Area area = this.C1Chart1.ChartArea;
			area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None;
			area.Style.BackColor = Color.Azure;
			area.Visible = true;

			ChartGroup group = C1Chart1.ChartGroups[0];
			group.ChartType = Chart2DTypeEnum.Pie;

			ChartData data = group.ChartData;

			ChartDataSeries s = new ChartDataSeries();
			data.SeriesList.Add(s);
			PointF [] ps;
			ps = new PointF[] { new PointF(1f,20f),
								new PointF(2f,24f),
								new PointF(3f, 42f),
								new PointF(4f, 13f),
								new PointF(5f, 10f)
							  };
			s.PointData.CopyDataIn(ps); 
			s.Offset = 30;

			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			ps = new PointF[] { new PointF(1f,20f),
								  new PointF(2f,24f),
								  new PointF(3f, 42f),
								  new PointF(4f, 13f),
								  new PointF(5f, 10f)
							  };
			s.PointData.CopyDataIn(ps); 

			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			ps = new PointF[] { new PointF(1f,10f),
								  new PointF(2f,4f),
								  new PointF(3f, 17f),
								  new PointF(4f, 81f),
								  new PointF(5f, 10f)
							  };
			s.PointData.CopyDataIn(ps); 
			s.Offset = 40;

			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			ps = new PointF[] { new PointF(1f, 20f),
								  new PointF(2f, 4f),
								  new PointF(3f, 52f),
								  new PointF(4f, 13f),
								  new PointF(5f, 10f)
							  };
			s.PointData.CopyDataIn(ps); 

			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			ps = new PointF[] { new PointF(1f,6f),
								  new PointF(2f,24f),
								  new PointF(3f, 142f),
								  new PointF(4f, 113),
								  new PointF(5f, 10f)
							  };
			s.PointData.CopyDataIn(ps); 

			ChartLabels cLabs = C1Chart1.ChartLabels;
			cLabs.DefaultLabelStyle.BackColor = Color.Turquoise;
			cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			cLabs.DefaultLabelStyle.Border.Thickness = 3;

			C1.Win.C1Chart.Label cLab = cLabs.LabelsCollection.AddNewLabel();
			cLab.Text = "(0,0)";
			cLab.AttachMethod = AttachMethodEnum.DataIndex;
			cLab.AttachMethodData.GroupIndex = 0;
			cLab.AttachMethodData.SeriesIndex = 0;
			cLab.AttachMethodData.PointIndex = 0;
			cLab.Connected = true;
			cLab.Offset = 10;
			cLab.Visible = true;

			addInfoLabels();
			doRefresh();
		}

		public void runTestProceduresForBarChart()
		{
			C1Chart1.Reset();
			C1Chart1.Style.Font = new Font("Lucida Console", 18, FontStyle.Bold);

			C1.Win.C1Chart.Title lab = this.C1Chart1.Header;
			lab.Text = "Bar Chart";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			lab = C1Chart1.Footer;
			lab.Text = "Bar Footer";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			C1.Win.C1Chart.Legend leg = this.C1Chart1.Legend;
			leg.Text = "Legend";
			leg.Style.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);	//!!VBPassThru
			leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			leg.Style.Border.Thickness = 2;
			leg.Visible = true;

			Area area = this.C1Chart1.ChartArea;
			area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None;
			area.Style.BackColor = Color.Bisque;
			area.Visible = true;

			ChartGroup group = C1Chart1.ChartGroups[0];
			ChartGroup group2 = C1Chart1.ChartGroups[1];
			group.ChartType = Chart2DTypeEnum.Bar;

			ChartData data = group.ChartData;
			ChartData data2 = group2.ChartData;

			PointF [] ps;
			ps = new PointF[] { new PointF(5f,20f),
								  new PointF(4f,24f),
								  new PointF(3f, 42f),
								  new PointF(1f, 13f),
								  new PointF(2f, 10f)
							  };
			ChartDataSeries s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			s = new ChartDataSeries();
			data2.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(1f,20f),
								  new PointF(2f,24f),
								  new PointF(3f, 42f),
								  new PointF(4f, 13f),
								  new PointF(5f, 10f)
							  };
			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			s = new ChartDataSeries();
			data2.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(1f,10f),
								  new PointF(2f,4f),
								  new PointF(3f, 17f),
								  new PointF(4f, 81f),
								  new PointF(5f, 10f)
							  };
			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			s = new ChartDataSeries();
			data2.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(1f, 20f),
								  new PointF(2f, 4f),
								  new PointF(3f, 52f),
								  new PointF(4f, 13f),
								  new PointF(5f, 10f)
							  };
			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			s = new ChartDataSeries();
			data2.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(1f,6f),
								  new PointF(2f,24f),
								  new PointF(3f, 142f),
								  new PointF(4f, 113),
								  new PointF(5f, 10f)
							  };
			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			s = new ChartDataSeries();
			data2.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ChartLabels cLabs = C1Chart1.ChartLabels;
			cLabs.DefaultLabelStyle.BackColor = Color.Turquoise;
			cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			cLabs.DefaultLabelStyle.Border.Thickness = 3;

			C1.Win.C1Chart.Label cLab = cLabs.LabelsCollection.AddNewLabel();
			cLab.Text = "Bar Label";
			cLab.AttachMethod = AttachMethodEnum.DataIndex;
			cLab.AttachMethodData.GroupIndex = 0;
			cLab.AttachMethodData.SeriesIndex = 0;
			cLab.AttachMethodData.PointIndex = 0;
			cLab.Compass = LabelCompassEnum.North;
			cLab.Connected = true;
			cLab.Offset = 10;
			cLab.Visible = true;

			addInfoLabels();
			doRefresh();
		}

		public void runTestProceduresForStackedBarChart()
		{
			C1Chart1.Reset();
			C1Chart1.Style.Font = new Font("Lucida Console", 18, FontStyle.Bold);

			C1.Win.C1Chart.Title lab = this.C1Chart1.Header;
			lab.Text = "Stacked Bar Chart\nWith A Centered AlarmZone";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			lab = C1Chart1.Footer;
			lab.Text = "Stacked Bar Footer";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			C1.Win.C1Chart.Legend leg = this.C1Chart1.Legend;
			leg.Text = "SB Legend";
			leg.Style.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);	//!!VBPassThru
			leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			leg.Style.Border.Thickness = 2;
			leg.Visible = true;

			Area area = this.C1Chart1.ChartArea;
			area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None;
			area.Style.BackColor = Color.Bisque;
			area.Visible = true;

			area.AxisY.Min = 0;
			area.AxisY.GridMajor.Color = Color.Black;
			area.AxisY.GridMajor.Visible = true;
			area.AxisY.GridMinor.Visible = true;

			AlarmZone az = area.PlotArea.AlarmZones.AddNewZone();
			az.Name = "AlarmZoneForBar";
			az.BackColor = Color.CadetBlue;
			az.NearExtent = 1.5f;
			az.FarExtent = 4.5f;
			az.LowerExtent = 100f;
			az.UpperExtent = 200f;
			az.Visible = true;

			ChartGroup group = C1Chart1.ChartGroups[0];
			group.ChartType = Chart2DTypeEnum.Bar;
			group.Stacked = true;

			ChartData data = group.ChartData;
			PointF [] ps;
			ps = new PointF[] { new PointF(1f, 13f),
								  new PointF(2f, 10f),
								  new PointF(3f, 42f),
								  new PointF(4f,24f),
								  new PointF(5f,20f),
							  };
			ChartDataSeries s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(1f,20f),
								  new PointF(2f,24f),
								  new PointF(3f, 42f),
								  new PointF(4f, 13f),
								  new PointF(5f, 10f)
							  };
			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(1f,10f),
								  new PointF(2f,4f),
								  new PointF(3f, 17f),
								  new PointF(4f, 81f),
								  new PointF(5f, 10f)
							  };
			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(1f, 20f),
								  new PointF(2f, 4f),
								  new PointF(3f, 52f),
								  new PointF(4f, 13f),
								  new PointF(5f, 10f)
							  };
			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(1f,6f),
								  new PointF(2f,24f),
								  new PointF(3f, 142f),
								  new PointF(4f, 113),
								  new PointF(5f, 10f)
							  };

			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ChartLabels cLabs = C1Chart1.ChartLabels;
			cLabs.DefaultLabelStyle.BackColor = Color.Turquoise;
			cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			cLabs.DefaultLabelStyle.Border.Thickness = 3;

			C1.Win.C1Chart.Label cLab = cLabs.LabelsCollection.AddNewLabel();
			cLab.Text = "Stacked Bar Label";
			cLab.AttachMethod = AttachMethodEnum.DataIndex;
			cLab.AttachMethodData.GroupIndex = 0;
			cLab.AttachMethodData.SeriesIndex = 0;
			cLab.AttachMethodData.PointIndex = 0;
			cLab.Compass = LabelCompassEnum.North;
			cLab.Connected = true;
			cLab.Offset = 10;
			cLab.Visible = false;	//true;

			addInfoLabels();

			int sl = data.SeriesList.Count;
			int pl = ps.Length;

			float [,] xys = (float[,])Array.CreateInstance(typeof(float),sl+1,pl);
			xys.Initialize();

			// set the X values.
			for(int p=0; p < pl; p++)
				xys[0,p] = ps[p].X;

			Random rand = new Random(11);
			for(int si=0; si < sl; si++)
			{
				ps = (PointF[])data[si].PointData.CopyDataOut();
				for(int p0=0; p0 < pl; p0++)
					xys[si+1,p0] = ps[p0].Y;
			}

			dumpStackedArray(xys);
			doRefresh();
		}
		
		public void runTestProceduresForHiLoChart()
		{
			C1Chart1.Reset();
			C1Chart1.Style.Font = new Font("Lucida Console", 18, FontStyle.Bold);

			C1.Win.C1Chart.Title lab = this.C1Chart1.Header;
			lab.Text = "Hi-Lo Chart Header";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			lab = C1Chart1.Footer;
			lab.Text = "Hi-Lo Chart Footer";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			C1.Win.C1Chart.Legend leg = this.C1Chart1.Legend;
			leg.Text = "Legend";
			leg.Style.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);	//!!VBPassThru
			leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			leg.Style.Border.Thickness = 2;
			leg.Visible = true;

			Area area = this.C1Chart1.ChartArea;
			area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None;
			area.Style.BackColor = Color.AliceBlue;
			area.Visible = true;

			area.AxisX.GridMajor.Visible = true;
			area.AxisX.AnnoFormat = FormatEnum.DateManual;
			area.AxisX.AnnoFormatString = "MM/dd";
			area.AxisX.AnnotationRotation = 30;
			area.AxisX.Text = "Date of Interest";

			area.AxisY.GridMajor.Visible = true;
			area.AxisY.Text = "Price ($)";

			ChartGroup group = C1Chart1.ChartGroups[0];
			group.ChartType = Chart2DTypeEnum.HiLo;
			ChartData data = group.ChartData;

			DateTime [] Xds = new DateTime[] { new DateTime(2002,1,1), new DateTime(2002,1,2),
					new DateTime(2002,1,3), new DateTime(2002,1,4), new DateTime(2002,1,5) };
			float[] Hi = new float[] { 10f, 12f, 17f, 19f, 14f };
			float[] Lo = new float[] {	7f,	 6f, 12f, 10f, 13f };

			ChartDataSeries s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.X.CopyDataIn(Xds);
			s.Y.CopyDataIn(Hi);
			s.Y1.CopyDataIn(Lo);
			s.LineStyle.Color = Color.Red;
			s.LineStyle.Thickness = 5;
			s.SymbolStyle.Size = 5;

			Hi = new float[] { 20f, 22f, 27f, 29f, 24f };
			Lo = new float[] { 17f, 16f, 22f, 20f, 23f };

			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.X.CopyDataIn(Xds);
			s.Y.CopyDataIn(Hi);
			s.Y1.CopyDataIn(Lo);

			s.LineStyle.Color = Color.Green;
			s.LineStyle.Thickness = 5;
			s.SymbolStyle.Size = 8;

			ChartLabels cLabs = C1Chart1.ChartLabels;
			cLabs.DefaultLabelStyle.BackColor = Color.Turquoise;
			cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			cLabs.DefaultLabelStyle.Border.Thickness = 3;

			C1.Win.C1Chart.Label cLab = cLabs.LabelsCollection.AddNewLabel();
			cLab.Text = "Hi-Lo Label";
			cLab.AttachMethod = AttachMethodEnum.DataIndex;
			cLab.AttachMethodData.GroupIndex = 0;
			cLab.AttachMethodData.SeriesIndex = 0;
			cLab.AttachMethodData.PointIndex = 0;
			cLab.Compass = LabelCompassEnum.North;
			cLab.Connected = true;
			cLab.Offset = 10;
			cLab.Visible = true;

			addInfoLabels();
			doRefresh();
		}

		public void runTestProceduresForHiLoOpenCloseChart()
		{
			runTestProceduresForHiLoChart();

			ChartGroup cg = C1Chart1.ChartGroups[0];
			cg.ChartType = Chart2DTypeEnum.HiLoOpenClose;

			int ns = cg.ChartData.SeriesList.Count;
			for(int s=0; s < ns; s++)
			{
				ChartDataSeries ser = cg.ChartData.SeriesList[s];
				int np = ser.Length;

				float [] his = (float[])ser.Y.CopyDataOut();
				float [] los = (float[])ser.Y1.CopyDataOut();
				float [] opens = (float[])Array.CreateInstance(typeof(float),np);
				float [] closes = (float[])Array.CreateInstance(typeof(float),np);

				Random rnd = new Random(666);

				for(int p=0; p < np; p++)
				{
					// add in open and close points
					float hi = his[p];
					float lo = los[p];
					opens[p] = (float)(lo + (hi - lo) * rnd.NextDouble());
					closes[p] = (float)(lo + (hi - lo) * rnd.NextDouble());
				}
				ser.Y2.CopyDataIn(opens);
				ser.Y3.CopyDataIn(closes);
			}
			doRefresh();
		}

		public void runTestProceduresForBubbleChart()
		{
			this.runTestProceduresForHiLoChart();
			C1Chart1.ChartGroups[0].ChartType = Chart2DTypeEnum.Bubble;
			C1.Win.C1Chart.Label lab = C1Chart1.ChartLabels[0];
			lab.Text = "Bubble Label";
			lab.AttachMethodData.PointIndex = 3;
			lab.Compass = LabelCompassEnum.North;
			lab.Offset = 30;

			C1Chart1.Header.Text = "Bubble Header";
			C1Chart1.Footer.Text = "Bubble Footer";
			doRefresh();
		}

		public void runTestProceduresForAreaChart()
		{
			this.runTestProceduresForXYPlot();
			C1Chart1.ChartGroups[0].ChartType = Chart2DTypeEnum.Area;
			doRefresh();
		}

		public void runTestProceduresForCandleChart()
		{
			runTestProceduresForHiLoOpenCloseChart();

			ChartGroup cg = C1Chart1.ChartGroups[0];
			cg.ChartType = Chart2DTypeEnum.Candle;
			cg.HiLoData.FillTransparent = false;
			foreach(ChartDataSeries ser in cg.ChartData.SeriesList)
			{
				ser.LineStyle.Thickness = 1;
				ser.SymbolStyle.Size = 12;
				ser.SymbolStyle.Color = Color.Yellow;
			}

			C1.Win.C1Chart.Label lab = C1Chart1.ChartLabels[0];
			lab.Text = "Candle Label";
			lab.AttachMethodData.PointIndex = 3;
			lab.Compass = LabelCompassEnum.NorthEast;
			lab.Offset = 30;

			C1Chart1.Header.Text = "Candle Header";
			C1Chart1.Footer.Text = "Candle Footer";
			doRefresh();
		}

		public void runTestProceduresForPolarChart()
		{
			C1Chart1.Reset();
			C1Chart1.Style.Font = new Font("Lucida Console", 18, FontStyle.Bold);

			C1.Win.C1Chart.Title lab = this.C1Chart1.Header;
			lab.Text = "Polar Chart\nwith 2 AlarmZones";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			lab = C1Chart1.Footer;
			lab.Text = "Polar Chart Footer";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			C1.Win.C1Chart.Legend leg = this.C1Chart1.Legend;
			leg.Text = "Polar Legend";
			leg.Style.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);	//!!VBPassThru
			leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			leg.Style.Border.Thickness = 2;
			leg.Visible = true;

			Area area = this.C1Chart1.ChartArea;
			area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None;
			area.Style.BackColor = Color.Bisque;
			area.AxisX.Font = new Font("Lucida Console", 9);
			area.AxisX.Text = "Polar X Axis";
			area.AxisX.TickMajor = TickMarksEnum.Cross;
			area.AxisX.GridMajor.Visible = true;
			area.AxisY.GridMajor.Visible = true;
			area.AxisX.GridMinor.Visible = true;
			area.AxisY.GridMinor.Visible = true;
			area.AxisY.Font = new Font("Arial",9);
			area.Visible = true;
			area.PlotArea.BackColor = Color.Azure;

			AlarmZone az = area.PlotArea.AlarmZones.AddNewZone();
			az.LowerExtent = 0f;
			az.UpperExtent = 24f;
			az.NearExtent = 240f;
			az.FarExtent = 265f;
			az.BackColor = Color.Green;
			az.Visible = true;

			az = area.PlotArea.AlarmZones.AddNewZone();
			az.LowerExtent = 24f;
			az.UpperExtent = 34f;
			az.NearExtent = 120f;
			az.FarExtent = 150f;
			az.BackColor = Color.CadetBlue;
			az.Visible = true;

			ChartGroup group = C1Chart1.ChartGroups[0];
			group.ChartType = Chart2DTypeEnum.Polar;
			group.Polar.Degrees = true;

			ChartData data = group.ChartData;
			PointF [] ps;

			ps = new PointF[] { new PointF(30f,20f),
								  new PointF(60f,24f),
								  new PointF(90f, 42f),
								  new PointF(120f, 13f),
								  new PointF(150f, 10f)
							  };
			ChartDataSeries s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(10f,20f),
								  new PointF(20f,24f),
								  new PointF(30f, 42f),
								  new PointF(40f, 13f),
								  new PointF(50f, 10f)
							  };
			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(60f,10f),
								  new PointF(120f,4f),
								  new PointF(180f, 17f),
								  new PointF(240f, 18f),
								  new PointF(300f, 10f)
							  };
			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ps = new PointF[] { new PointF(45f, 20f),
								  new PointF(90f, 4f),
								  new PointF(135f, 25f),
								  new PointF(180f, 13f),
								  new PointF(225f, 10f)
							  };
			s = new ChartDataSeries();
			data.SeriesList.Add(s);
			s.PointData.CopyDataIn(ps); 

			ChartLabels cLabs = C1Chart1.ChartLabels;
			cLabs.DefaultLabelStyle.BackColor = Color.Turquoise;
			cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			cLabs.DefaultLabelStyle.Border.Thickness = 3;

			C1.Win.C1Chart.Label cLab = cLabs.LabelsCollection.AddNewLabel();
			cLab.Text = "Polar Label";
			cLab.AttachMethod = AttachMethodEnum.DataIndex;
			cLab.AttachMethodData.GroupIndex = 0;
			cLab.AttachMethodData.SeriesIndex = 0;
			cLab.AttachMethodData.PointIndex = 0;
			cLab.Compass = LabelCompassEnum.North;
			cLab.Connected = true;
			cLab.Offset = 10;
			cLab.Visible = true;

			addInfoLabels();
			doRefresh();
		}

		public void runTestProceduresForRadarChart()
		{
			this.runTestProceduresForPolarChart();

			C1Chart1.ChartGroups[0].ChartType = Chart2DTypeEnum.Radar;
			C1.Win.C1Chart.Label lab = C1Chart1.ChartLabels[0];
			lab.Text = "Radar Label";
			lab.AttachMethodData.PointIndex = 3;
			lab.Compass = LabelCompassEnum.North;
			lab.Offset = 30;

			C1Chart1.Header.Text = "Radar Header";
			C1Chart1.Footer.Text = "Radar Footer";
			C1Chart1.Legend.Text = "Radar Legend";
			C1Chart1.ChartArea.AxisX.Text = "Radar X Axis";
			doRefresh();
		}

		public void runTestProceduresForStackedPolarChart()
		{
			runTestProceduresForPolarChart();
			C1Chart1.ChartGroups[0].Stacked = true;
			C1Chart1.ChartLabels[0].Text = "Stacked Polar Label";

			C1Chart1.Header.Text = "Stacked Polar Header";
			C1Chart1.Footer.Text = "Stacked Polar Footer";
			C1Chart1.Legend.Text = "Stacked Polar Legend";
			doRefresh();
		}

		public void runTestProceduresForStackedRadarChart()
		{
			runTestProceduresForRadarChart();
			C1Chart1.ChartGroups[0].Stacked = true;
			C1Chart1.ChartLabels[0].Text = "Stacked Radar Label";
			C1Chart1.ChartLabels[0].Visible = false;

			C1Chart1.Header.Text = "Stacked Radar Header";
			C1Chart1.Footer.Text = "Stacked Radar Footer";
			C1Chart1.Legend.Text = "Stacked Radar Legend";
			doRefresh();
		}

		public void dumpStackedArray(float[,] xys)
		{
			int sl = xys.GetLength(0);
			int pl = xys.GetLength(1);
			int s;

			string ss1 = "	   X ";
			string ss2 = "";
			for(s=0; s < sl-1; s++)
			{
				string ss = "Y" + s.ToString();
				while(ss.Length < 6)
					ss = " " + ss;
				ss1 += ss + "  ";

				ss = "SY" + s.ToString();
				while(ss.Length < 6)
					ss = " " + ss;
				ss2 += ss + "  ";
			}
			Debug.WriteLine(ss1 + ss2);

			ss2 = "";
			for(s=0; s < (2 * sl - 1); s++)
				ss2 += "------	";
			Debug.WriteLine(ss2);

			for(int p=0; p < pl; p++)
			{
				for(s=0; s < sl; s++)
				{
					ss1 = xys[s,p].ToString("f2");
					while(ss1.Length < 6) ss1 = " " + ss1;
					Debug.Write(ss1 + "	 ");
				}

				float sum=0f;
				for(s=1; s < sl; s++)
				{
					sum += xys[s,p];
					ss1 = sum.ToString("f2");
					while(ss1.Length < 6) ss1 = " " + ss1;
					Debug.Write(ss1 + "	 ");
				}
				Debug.WriteLine("");
			}
		}

		public void runTestProceduresForSimpleStackedRadarChart()
		{
			C1Chart1.Reset();
			C1Chart1.Style.Font = new Font("Lucida Console", 18, FontStyle.Bold);

			C1.Win.C1Chart.Title lab = this.C1Chart1.Header;
			lab.Text = "Simple Stacked Radar Chart Header";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			lab = C1Chart1.Footer;
			lab.Text = "Simple Stacked Radar Chart Footer";
			lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			lab.Style.Border.Thickness = 2;
			lab.Visible = true;

			C1.Win.C1Chart.Legend leg = this.C1Chart1.Legend;
			leg.Text = "Radar Legend";
			leg.Style.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);	//!!VBPassThru
			leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			leg.Style.Border.Thickness = 2;
			leg.Visible = true;

			Area area = this.C1Chart1.ChartArea;
			area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None;
			area.Style.BackColor = Color.Bisque;
			area.AxisX.TickMajor = TickMarksEnum.Cross;
			area.AxisX.GridMajor.Visible = true;
			area.AxisY.GridMajor.Visible = true;
			area.AxisX.GridMinor.Visible = true;
			area.AxisY.GridMinor.Visible = true;
			area.AxisY.Font = new Font("Arial",9);
			area.AxisY.Min = 0f;
			area.Visible = true;

			area.PlotArea.BackColor = Color.Azure;

			ChartGroup group = C1Chart1.ChartGroups[0];
			group.ChartType = Chart2DTypeEnum.Radar;
			group.Stacked = true;
			group.Radar.Filled = true;

			ChartData data = group.ChartData;
			PointF [] ps;

			int sl = 4;
			int pl = 5;
			int p;

			ps = (PointF[])Array.CreateInstance(typeof(PointF),pl);

			float [,] xys = (float[,])Array.CreateInstance(typeof(float),sl+1,pl);
			xys.Initialize();

			// set the X values.
			for(p=0; p < pl; p++)
			{
				xys[0,p] = p;
				ps[p].X = p;
			}

			Random rand = new Random(11);
			for(int s=0; s < sl; s++)
			{
				for(p=0; p < pl; p++)
				{
					ps[p].Y = (float)(50 * rand.NextDouble() + 10);
					xys[s+1,p] = ps[p].Y;
				}

				ChartDataSeries ser = new ChartDataSeries();
				data.SeriesList.Add(ser);
				ser.PointData.CopyDataIn(ps); 
			}

			dumpStackedArray(xys);

			ChartLabels cLabs = C1Chart1.ChartLabels;
			cLabs.DefaultLabelStyle.BackColor = Color.Turquoise;
			cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
			cLabs.DefaultLabelStyle.Border.Thickness = 3;

			C1.Win.C1Chart.Label cLab = cLabs.LabelsCollection.AddNewLabel();
			cLab.Text = "Simple Stacked Radar Label";
			cLab.AttachMethod = AttachMethodEnum.DataIndex;
			cLab.AttachMethodData.GroupIndex = 0;
			cLab.AttachMethodData.SeriesIndex = 0;
			cLab.AttachMethodData.PointIndex = 0;
			cLab.Compass = LabelCompassEnum.North;
			cLab.Connected = true;
			cLab.Offset = 10;
			cLab.Visible = true;	//false;

			addInfoLabels();
			doRefresh();
		}

		public void runTestProcedures()
		{
			//this.runTestProceduresForXYPlot();
			//this.runTestProceduresForPieChart();
			//this.runTestProceduresForBarChart();
			//this.runTestProceduresForAreaChart();
			//this.runTestProceduresForHiLoChart();
			//this.runTestProceduresForBubbleChart();
			//this.runTestProceduresForCandleChart();
			//this.runTestProceduresForPolarChart();
			//this.runTestProceduresForRadarChart();
			//this.runTestProceduresForStackedXYChart();
			//this.runTestProceduresForStackedAreaChart();
			//this.runTestProceduresForStackedPolarChart();
			//this.runTestProceduresForStackedRadarChart();
			//this.runTestProceduresForSimpleStackedRadarChart();
			//this.runTestProceduresForStackedBarChart();
		}

		private void Chart1_BackColorChanged(object sender, System.EventArgs e)
		{
			Debug.WriteLine("BackColor has changed");
		}
		private void Chart1_ForeColorChanged(object sender, System.EventArgs e)
		{
			Debug.WriteLine("ForeColor has changed");
		}
		private void Chart1_FontChanged(object sender, System.EventArgs e)
		{
			Debug.WriteLine("Font has changed");
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForXYPlot();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForPieChart();
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForBarChart();
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForAreaChart();
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForHiLoChart();
		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForHiLoOpenCloseChart();
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForBubbleChart();
		}

		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForCandleChart();
		}

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForPolarChart();
		}

		private void menuItem27_Click(object sender, System.EventArgs e)
		{		
			this.runTestProceduresForRadarChart();
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForStackedXYChart();
		}

		private void menuItem29_Click(object sender, System.EventArgs e)
		{		
			this.runTestProceduresForStackedAreaChart();
		}

		private void menuItem30_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForStackedPolarChart();
		}

		private void menuItem31_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForStackedRadarChart();
		}

		private void menuItem32_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForSimpleStackedRadarChart();
		}

		private void menuItem33_Click(object sender, System.EventArgs e)
		{
			this.runTestProceduresForStackedBarChart();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			C1Chart1.Reset();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			C1Chart1.PrintChart();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			C1Chart1.PrintChart(PrintScaleEnum.ScaleToFit);
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			C1Chart1.PrintChart(PrintScaleEnum.ScaleToHeight);
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			C1Chart1.PrintChart(PrintScaleEnum.ScaleToMax);
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			C1Chart1.PrintChart(PrintScaleEnum.ScaleToWidth);
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			C1Chart1.PrintChart(PrintScaleEnum.ScaleNone);
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			C1Chart1.PageSetup();
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			C1Chart1.PrintSetup();
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
			bool usePrintDialog = C1Chart1.PrintDialogUsage;
			C1Chart1.PrintDialogUsage = !usePrintDialog;
			this.menuItem17.Checked = !usePrintDialog;
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			C1Chart1.PrintChart();
		}

		
		private int lastFilterIndex = 1;
		private void menuItem34_Click(object sender, System.EventArgs e)
		{
		}

		private void menuItem36_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.DefaultExt = "chart2dxml";
			sfd.FileName = "doc1";
			sfd.Filter = "Chart files(*.chart2dxml)|*.chart2dxml|All files (*.*)|*.*";
			
			DialogResult dr = sfd.ShowDialog();
			if(dr == DialogResult.OK)
				C1Chart1.SaveChartToFile(sfd.FileName);
		}

		private void menuItem37_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.DefaultExt = "chart2dxml";
			ofd.FileName = "doc1";
			ofd.Filter = "Chart files(*.chart2dxml)|*.chart2dxml|All files (*.*)|*.*";

			DialogResult dr = ofd.ShowDialog();
			if(dr == DialogResult.OK)
				C1Chart1.LoadChartFromFile(ofd.FileName);

			doRefresh();
		}

		private void menuItem39_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.DefaultExt = "datxml";
			sfd.FileName = "doc1";
			sfd.Filter = "Chart files(*.datxml)|*.datxml|All files (*.*)|*.*";
			
			DialogResult dr = sfd.ShowDialog();
			if(dr == DialogResult.OK)
				C1Chart1.ChartGroups[0].ChartData.SaveDataToFile(sfd.FileName);
		}

		private void menuItem40_Click(object sender, System.EventArgs e)
		{		
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.DefaultExt = "datxml";
			ofd.FileName = "doc1";
			ofd.Filter = "Chart files(*.datxml)|*.datxml|All files (*.*)|*.*";

			DialogResult dr = ofd.ShowDialog();
			if(dr == DialogResult.OK)
				C1Chart1.ChartGroups[0].ChartData.LoadDataFromFile(ofd.FileName);

			doRefresh();
		}

		private void menuItem41_Click(object sender, System.EventArgs e)
		{
			C1Chart1.ShowProperties();
		
		}

		private void menuItem42_Click(object sender, System.EventArgs e)
		{
			// save to file
			SaveFileDialog sfg = new SaveFileDialog();

			sfg.Filter = "Metafiles (*.emf)|*.emf|" +
				"Bmp files (*.bmp)|*.bmp|" +
				"Gif files (*.gif)|*.gif|" +
				"Jpeg files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
				"Png files (*.png)|*.png|" +
				"All graphic files (*.emf;*.bmp;*.gif;*.jpg;*.jpeg;*.png)|*.emf;*.bmp;*.gif;*.jpg;*.jpeg;*.png";
			sfg.FilterIndex = lastFilterIndex;
			sfg.OverwritePrompt = true;
			sfg.CheckPathExists = true;
			sfg.RestoreDirectory = false;
			sfg.ValidateNames = true;

			if(sfg.ShowDialog() == DialogResult.OK)
			{
				string fn = sfg.FileName;
				int indext = fn.LastIndexOf('.');
				if(indext < 0)
				{
					indext = fn.Length + 1;
					fn += ".emf";
				}
				else
					indext++;

				string ext = fn.Substring(indext);
				ImageFormat imgfmt = null;

				switch(ext)
				{
					case "emf":
						imgfmt = ImageFormat.Emf;
						C1Chart1.SaveImage(fn, imgfmt);
						break;

					case "bmp":
						imgfmt = ImageFormat.Bmp;
						break;

					case "gif":
						imgfmt = ImageFormat.Gif;
						break;

					case "jpeg":
					case "jpg":
						imgfmt = ImageFormat.Jpeg;
						break;

					case "png":
						imgfmt = ImageFormat.Png;
						break;

					default:
						return;
				}

				lastFilterIndex = sfg.FilterIndex;

				if(!imgfmt.Equals(ImageFormat.Emf))
				{
					Image img = C1Chart1.GetImage();
					img.Save(fn, imgfmt);
					img.Dispose();
				}
			}
			sfg.Dispose();
		}

		private void menuItem44_Click(object sender, System.EventArgs e)
		{
			// Save to Clipboard as bmp
			C1Chart1.SaveImage(ImageFormat.Bmp);
		}

		private void menuItem45_Click(object sender, System.EventArgs e)
		{
			// Save to Clipboard as emf
			C1Chart1.SaveImage(ImageFormat.Emf);
		}
	}
}
