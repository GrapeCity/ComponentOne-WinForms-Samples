using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;

using C1.Win.C1Chart3D;

namespace test3d
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.MenuStrip mainMenu1;
		private System.Windows.Forms.ToolStripMenuItem menuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuItem2;
		private System.Windows.Forms.ToolStripMenuItem menuItem3;
		private System.Windows.Forms.ToolStripMenuItem menuItem4;
		private System.Windows.Forms.ToolStripMenuItem menuItem5;
		private System.Windows.Forms.ToolStripMenuItem menuItem6;
		private System.Windows.Forms.ToolStripMenuItem menuItem7;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.ToolStripSeparator menuSepItem8;
		private System.Windows.Forms.ToolStripMenuItem menuItem9;
		private System.Windows.Forms.ToolStripMenuItem menuItem10;
		private System.Windows.Forms.ToolStripMenuItem menuItem11;
		private System.Windows.Forms.ToolStripMenuItem menuItem12;
		private System.Windows.Forms.ToolStripMenuItem menuItem13;
		private System.Windows.Forms.ToolStripMenuItem menuItem14;
		private System.Windows.Forms.ToolStripMenuItem menuItem15;
		private System.Windows.Forms.ToolStripMenuItem menuItem16;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolStripSeparator menuSepItem17;
		private System.Windows.Forms.ToolStripMenuItem menuItem18;
		private System.Windows.Forms.ToolStripSeparator menuSepItem19;
		private System.Windows.Forms.ToolStripMenuItem menuItem20;
		private System.Windows.Forms.ToolStripMenuItem menuItem21;
		private System.Windows.Forms.ToolStripMenuItem menuItem22;
		private System.Windows.Forms.ToolStripSeparator menuSepItem23;
		private System.Windows.Forms.ToolStripMenuItem menuItem24;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		//
		int angleIncrement = 2;
		Chart3DDataSetPoint setPoint;
		Chart3DDataSetGrid setGrid;
		Chart3DDataSetIrGrid setIrGrid;
		Chart3DPoint[] pointData = new Chart3DPoint[27];
		Chart3DPoint[] pointData1 = new Chart3DPoint[27];
		double[,] contourData;
		private System.Windows.Forms.ToolStripSeparator menuSepItem25;
		private System.Windows.Forms.ToolStripMenuItem menuItem26;
		private System.Windows.Forms.ToolStripMenuItem menuItem27;
		private System.Windows.Forms.ToolStripMenuItem menuItem28;
		private System.Windows.Forms.ToolStripMenuItem menuItem29;
		private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
		bool bUpdate = true;

		public Form1()
		{
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			numericUpDown1.Minimum = -360;
			numericUpDown1.Maximum = 360;
			numericUpDown1.Increment = (decimal)angleIncrement;
			numericUpDown1.Value = (decimal)c1Chart3D1.ChartArea.View.RotationX;

			numericUpDown2.Maximum = 360;
			numericUpDown2.Minimum = -360;
			numericUpDown2.Increment = (decimal)angleIncrement;
			numericUpDown2.Value = (decimal)c1Chart3D1.ChartArea.View.RotationY;

			numericUpDown3.Maximum = 360;
			numericUpDown3.Minimum = -360;
			numericUpDown3.Increment = (decimal)angleIncrement;
			numericUpDown3.Value = (decimal)c1Chart3D1.ChartArea.View.RotationZ;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		public new void Dispose( bool disposing )
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.c1Chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.mainMenu1 = new System.Windows.Forms.MenuStrip();
            this.menuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSepItem23 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSepItem19 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSepItem25 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSepItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSepItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem29 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.mainMenu1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid1.Location = new System.Drawing.Point(8, 82);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1Chart3D1;
            this.propertyGrid1.Size = new System.Drawing.Size(224, 356);
            this.propertyGrid1.TabIndex = 0;
            // 
            // c1Chart3D1
            // 
            this.c1Chart3D1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c1Chart3D1.Location = new System.Drawing.Point(232, 26);
            this.c1Chart3D1.Name = "c1Chart3D1";
            this.c1Chart3D1.PropBag = resources.GetString("c1Chart3D1.PropBag");
            this.c1Chart3D1.Size = new System.Drawing.Size(360, 412);
            this.c1Chart3D1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(80, 24);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.OnValueChanged2);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(152, 24);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.OnValueChanged3);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.OnValueChanged1);
            // 
            // mainMenu1
            // 
            this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem14,
            this.menuItem4,
            this.menuItem1,
            this.menuItem29});
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(592, 24);
            this.mainMenu1.TabIndex = 12;
            // 
            // menuItem14
            // 
            this.menuItem14.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem21,
            this.menuItem22,
            this.menuSepItem23,
            this.menuItem15,
            this.menuItem16,
            this.menuSepItem19,
            this.menuItem28,
            this.menuItem24,
            this.menuItem20});
            this.menuItem14.Name = "menuItem14";
            this.menuItem14.Size = new System.Drawing.Size(35, 20);
            this.menuItem14.Text = "File";
            // 
            // menuItem21
            // 
            this.menuItem21.Name = "menuItem21";
            this.menuItem21.Size = new System.Drawing.Size(137, 22);
            this.menuItem21.Text = "Open Chart";
            this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Name = "menuItem22";
            this.menuItem22.Size = new System.Drawing.Size(137, 22);
            this.menuItem22.Text = "Save Chart";
            this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // menuItem23
            // 
            this.menuSepItem23.Name = "menuItem23";
            this.menuSepItem23.Size = new System.Drawing.Size(134, 6);
            // 
            // menuItem15
            // 
            this.menuItem15.Name = "menuItem15";
            this.menuItem15.Size = new System.Drawing.Size(137, 22);
            this.menuItem15.Text = "Load Data";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Name = "menuItem16";
            this.menuItem16.Size = new System.Drawing.Size(137, 22);
            this.menuItem16.Text = "Save Data";
            this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // menuItem19
            // 
            this.menuSepItem19.Name = "menuItem19";
            this.menuSepItem19.Size = new System.Drawing.Size(134, 6);
            // 
            // menuItem28
            // 
            this.menuItem28.Name = "menuItem28";
            this.menuItem28.Size = new System.Drawing.Size(137, 22);
            this.menuItem28.Text = "Save Image";
            this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Name = "menuItem24";
            this.menuItem24.Size = new System.Drawing.Size(137, 22);
            this.menuItem24.Text = "Print Preview";
            this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Name = "menuItem20";
            this.menuItem20.Size = new System.Drawing.Size(137, 22);
            this.menuItem20.Text = "Exit";
            this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem27,
            this.menuItem26,
            this.menuSepItem25,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuSepItem17,
            this.menuItem18});
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(46, 20);
            this.menuItem4.Text = "Chart";
            // 
            // menuItem27
            // 
            this.menuItem27.Name = "menuItem27";
            this.menuItem27.Size = new System.Drawing.Size(123, 22);
            this.menuItem27.Text = "Properties";
            this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click_1);
            // 
            // menuItem26
            // 
            this.menuItem26.Name = "menuItem26";
            this.menuItem26.Size = new System.Drawing.Size(123, 22);
            this.menuItem26.Text = "Wizard";
            this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
            // 
            // menuItem25
            // 
            this.menuSepItem25.Name = "menuItem25";
            this.menuSepItem25.Size = new System.Drawing.Size(120, 6);
            // 
            // menuItem5
            // 
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(123, 22);
            this.menuItem5.Text = "Bar";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Name = "menuItem6";
            this.menuItem6.Size = new System.Drawing.Size(123, 22);
            this.menuItem6.Text = "Scatter";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Name = "menuItem7";
            this.menuItem7.Size = new System.Drawing.Size(123, 22);
            this.menuItem7.Text = "Surface";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem17
            // 
            this.menuSepItem17.Name = "menuItem17";
            this.menuSepItem17.Size = new System.Drawing.Size(120, 6);
            // 
            // menuItem18
            // 
            this.menuItem18.Name = "menuItem18";
            this.menuItem18.Size = new System.Drawing.Size(123, 22);
            this.menuItem18.Text = "Interacive";
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem11,
            this.menuSepItem8,
            this.menuItem9,
            this.menuItem10});
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(42, 20);
            this.menuItem1.Text = "Data";
            // 
            // menuItem2
            // 
            this.menuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem12,
            this.menuItem13});
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(135, 22);
            this.menuItem2.Text = "Points";
            // 
            // menuItem12
            // 
            this.menuItem12.Name = "menuItem12";
            this.menuItem12.Size = new System.Drawing.Size(111, 22);
            this.menuItem12.Text = "1 series";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Name = "menuItem13";
            this.menuItem13.Size = new System.Drawing.Size(111, 22);
            this.menuItem13.Text = "2 series";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(135, 22);
            this.menuItem3.Text = "Grid";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Name = "menuItem11";
            this.menuItem11.Size = new System.Drawing.Size(135, 22);
            this.menuItem11.Text = "IrregularGrid";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem8
            // 
            this.menuSepItem8.Name = "menuItem8";
            this.menuSepItem8.Size = new System.Drawing.Size(132, 6);
            // 
            // menuItem9
            // 
            this.menuItem9.Name = "menuItem9";
            this.menuItem9.Size = new System.Drawing.Size(135, 22);
            this.menuItem9.Text = "Holes";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Name = "menuItem10";
            this.menuItem10.Size = new System.Drawing.Size(135, 22);
            this.menuItem10.Text = "4D";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem29
            // 
            this.menuItem29.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuItem29.Name = "menuItem29";
            this.menuItem29.Size = new System.Drawing.Size(40, 20);
            this.menuItem29.Text = "&Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(103, 22);
            this.menuHelpAbout.Text = "&About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(56, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(16, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(128, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(16, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(200, 24);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(16, 24);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rot X";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(80, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rot Y";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(152, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rot Z";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(8, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 56);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(592, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1Chart3D1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.mainMenu1);
            this.MainMenuStrip = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComponentOne Chart for .NET 3D - PropertyGrid Demo";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.mainMenu1.ResumeLayout(false);
            this.mainMenu1.PerformLayout();
            this.panel1.ResumeLayout(false);
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

		private void OnValueChanged1(object sender, System.EventArgs e)
		{
			if( bUpdate)
				c1Chart3D1.ChartArea.View.RotationX = (int)numericUpDown1.Value;
		}
		private void OnValueChanged2(object sender, System.EventArgs e)
		{
			if( bUpdate)
				c1Chart3D1.ChartArea.View.RotationY = (int)numericUpDown2.Value;
		}
		private void OnValueChanged3(object sender, System.EventArgs e)
		{
			if( bUpdate)
				c1Chart3D1.ChartArea.View.RotationZ = (int)numericUpDown3.Value;
		}

		void createTestData()
		{
			int i, j;
			float x, y;
			// init point dataset
			setPoint = new Chart3DDataSetPoint();
			
			for( int ix=0; ix<3; ix++)
				for( int iy=0; iy<3; iy++)
					for( int iz=0; iz<3; iz++)
					{
						pointData[ ix+3*iy+9*iz].X = ix;
						pointData[ ix+3*iy+9*iz].Y = iy;
						pointData[ ix+3*iy+9*iz].Z = iz;

						pointData1[ ix+3*iy+9*iz].X = 3+2*ix;
						pointData1[ ix+3*iy+9*iz].Y = 2*iy;
						pointData1[ ix+3*iy+9*iz].Z = 2*iz;
					}

			setPoint.AddSeries( pointData);
			setPoint.AddSeries( pointData1);

			//float[,] gridData = new float[ 11, 11];
			float[,] gridData = (float[,]) Array.CreateInstance( typeof(float), 11, 11);
			for( i=0; i<gridData.GetLength(0); i++)
				for( j=0; j<gridData.GetLength(1); j++)
				{
					x = -5 + i;
					y = -5 + j;
					gridData[ i, j] = 0.1f*x*x - 0.4f*y*y;
				}

			setGrid = new Chart3DDataSetGrid( -5, -5, 1, 1, gridData);

			// contour data for 4d chart
			contourData = (double[,]) Array.CreateInstance( typeof(double), setGrid.ColumnCount, setGrid.RowCount);
			for( i=0; i<setGrid.ColumnCount; i++)
				for( j=0; j<setGrid.RowCount; j++)
				{
					contourData[i,j] = i+j;
				}

			// init irregular grid dataset
			float[] xdata = { 1, 2, 6, 8, 9, 13, 15};
			float[] ydata = { 1, 2, 4, 8, 11, 12, 15};
			float[,] vals = (float[,]) Array.CreateInstance( typeof(float), xdata.Length, ydata.Length);

			setIrGrid = new Chart3DDataSetIrGrid(xdata, ydata, vals);

			{
				x = (float)setIrGrid.ColumnOrigin;
				for( i=0; i<setIrGrid.ColumnCount; i++)
				{
					x += (float)setIrGrid.ColumnDeltaArray[i];
					y = (float)setIrGrid.RowOrigin;
					for( j=0; j<setIrGrid.RowCount; j++)
					{
						y += (float)setIrGrid.RowDeltaArray[j];
						float val = 0.1f*x*x - 0.4f*y*y;
						setIrGrid.SetValue( i, j, val);
					}
				}
			}
			// starting dataset
			c1Chart3D1.ChartGroups[0].ChartData.Set = setGrid;

			// adding labels to chart
			Chart3DLabel labelC = c1Chart3D1.ChartLabels.LabelsCollection.AddNewLabel();
			labelC.Text = "Label(Coordinate)";
			labelC.LabelCompass = LabelCompassEnum.SouthEast;
			labelC.AttachMethodData.X = 20;
			labelC.AttachMethodData.Y = 20;
			labelC.Visible = true;

			Chart3DLabel labelD = c1Chart3D1.ChartLabels.LabelsCollection.AddNewLabel();
			labelD.Text = "Label(DataCoordinate)";
			labelD.LabelCompass = LabelCompassEnum.SouthEast;
			labelD.Offset = 50;
			labelD.Connected = true;
			labelD.AttachMethod = AttachMethodEnum.DataCoordinate;
			labelD.AttachMethodData.X = 0;
			labelD.AttachMethodData.Y = 0;
			labelD.AttachMethodData.Z = 0;
			labelD.Visible = true;

			Chart3DLabel labelI = c1Chart3D1.ChartLabels.LabelsCollection.AddNewLabel();
			labelI.Text = "Label(DataIndex)";
			labelI.LabelCompass = LabelCompassEnum.SouthWest;
			labelI.Offset = 25;
			labelI.Connected = true;
			labelI.AttachMethod = AttachMethodEnum.DataIndex;
			labelI.AttachMethodData.SeriesIndex = 2;
			labelI.AttachMethodData.PointIndex = 4;
			labelI.Visible = true;

			// adding data labels
			c1Chart3D1.DefaultLabelStyle.BackColor = Color.MistyRose;
			c1Chart3D1.DefaultLabelStyle.Border.BorderStyle = BorderStyleEnum.Solid;
			for( i=0; i< setGrid.RowCount; i++)
			{
				Chart3DDataLabel lab = c1Chart3D1.ChartGroups.RowLabels.AddNewLabel();
				lab.Index = i;
				lab.Text = "Row " + i.ToString();
			}
			for( j=0; j< setGrid.ColumnCount; j++)
			{
				Chart3DDataLabel lab = c1Chart3D1.ChartGroups.ColumnLabels.AddNewLabel();
				lab.Index = j;
				lab.Text = "Col " + j.ToString();
			}
			
			// adding labels to axis
			foreach( Chart3DAxis axis in c1Chart3D1.ChartArea.Axes)
			{
				Chart3DAxisLabel alab1 = axis.ValueLabels.AddNewLabel();
				alab1.Value = -1;
				alab1.Text  = "minus one";

				Chart3DAxisLabel alab2 = axis.ValueLabels.AddNewLabel();
				alab2.Value = +1;
				alab2.Text  = "plus one";
			}

			// set bar colors
			c1Chart3D1.ChartGroups[0].Bar.SetBarColor( 1, 1, Color.Red);
			c1Chart3D1.ChartGroups[0].Bar.SetBarColor( 1, 2, Color.Red);
			c1Chart3D1.ChartGroups[0].Bar.SetBarColor( -1, 3, Color.Blue);
			c1Chart3D1.ChartGroups[0].Bar.SetBarColor( 3, -1, Color.Green);
		}

		private void FormLoad(object sender, System.EventArgs e)
		{
			createTestData();
			c1Chart3D1.ChartArea.View.AfterRotate += new RotateEventHandler( RotateHandler);
			this.propertyGrid1.Anchor = AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left;//!!VBPassThru
			this.c1Chart3D1.Anchor = AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;//!!VBPassThru
			//c1Chart3D1.DumpModel();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			c1Chart3D1.ChartGroups[0].ChartData.Set = setGrid;
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			c1Chart3D1.ChartGroups[0].ChartType = Chart3DTypeEnum.Bar;
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			c1Chart3D1.ChartGroups[0].ChartType = Chart3DTypeEnum.Scatter;
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			c1Chart3D1.ChartGroups[0].ChartType = Chart3DTypeEnum.Surface;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked)
			{
				c1Chart3D1.ChartArea.View.RotationX += angleIncrement;
				if( c1Chart3D1.ChartArea.View.RotationX>=360)
					c1Chart3D1.ChartArea.View.RotationX = 0;
				numericUpDown1.Value = (decimal)c1Chart3D1.ChartArea.View.RotationX;
			}
			if(checkBox2.Checked)
			{
				c1Chart3D1.ChartArea.View.RotationY += angleIncrement;
				if( c1Chart3D1.ChartArea.View.RotationY>=360)
					c1Chart3D1.ChartArea.View.RotationY = 0;
				numericUpDown2.Value = (decimal)c1Chart3D1.ChartArea.View.RotationY;
			}
			if(checkBox3.Checked)
			{
				c1Chart3D1.ChartArea.View.RotationZ += angleIncrement;
				if( c1Chart3D1.ChartArea.View.RotationZ>=360)
					c1Chart3D1.ChartArea.View.RotationZ = 0;
				numericUpDown3.Value = (decimal)c1Chart3D1.ChartArea.View.RotationZ;
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			timer1.Enabled = (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked);
		}

		void setHoles( Chart3DDataSetGrid grset, bool enable)
		{
			int i, j;
			if( enable)
			{
				for( i=0; i<grset.ColumnCount; i++)
					for( j=0; j<grset.RowCount; j++)
					{
						float x;
						float y;

						if( grset is Chart3DDataSetIrGrid)
						{
							Chart3DDataSetIrGrid s = (Chart3DDataSetIrGrid) grset;
							x = (float)s.GetColumnValue( i);
							y = (float)s.GetRowValue(j);
						}
						else
						{
							x = (float)(grset.MinX + i*grset.RowDelta);
							y = (float)(grset.MinY + j*grset.ColumnDelta);
						}

						float val = 0.1f*x*x - 0.4f*y*y;
						if( i==j || i == grset.RowCount -j)
							grset.SetValue( i, j, val);
					}
			}
			else
			{
				for( i=0; i<grset.ColumnCount; i++)
					for( j=0; j<grset.RowCount; j++)
					{
						// holes
						if( i==j || i == grset.RowCount -j)
							grset.SetValue( i, j, grset.Hole);
					}
			}
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			setHoles( setGrid, menuItem9.Checked);
			setHoles( (Chart3DDataSetGrid) setIrGrid, menuItem9.Checked);
			menuItem9.Checked = !menuItem9.Checked;
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			if( c1Chart3D1.ChartGroups[0].ChartData.ContourData==null)
				c1Chart3D1.ChartGroups[0].ChartData.ContourData = contourData;
			else
				c1Chart3D1.ChartGroups[0].ChartData.ContourData = null;
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			c1Chart3D1.ChartGroups[0].ChartData.Set = this.setIrGrid;
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			if(setPoint.SeriesCollection.Count==1)
				setPoint.AddSeries( pointData1);

			c1Chart3D1.ChartGroups[0].ChartData.Set = setPoint;
			c1Chart3D1.ChartGroups[0].ChartType = Chart3DTypeEnum.Scatter;
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			if(setPoint.SeriesCollection.Count==2)
				setPoint.RemoveSeries(1);
			c1Chart3D1.ChartGroups[0].ChartData.Set = setPoint;
			c1Chart3D1.ChartGroups[0].ChartType = Chart3DTypeEnum.Scatter;
		}

		private void c1Chart3D1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//float x=0, y=0, z=0;
			//c1Chart3D1.ChartGroups[0].ChartData.CoordToDataCoord( e.X, e.Y, ref x, ref y, ref z);
			//c1Chart3D1.ChartLabels[0].Text = String.Format( " {0}, {1}, {2}", x, y, z );
		}

		private void RotateHandler(object sender, RotateEventArgs e)
		{
			bUpdate = false;
			numericUpDown1.Value = (decimal)(e.RotationX / Math.PI * 180);
			numericUpDown2.Value = (decimal)(e.RotationY / Math.PI * 180);
			numericUpDown3.Value = (decimal)(e.RotationZ / Math.PI * 180);
			bUpdate = true;
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.DefaultExt = "dat3xml";
			ofd.FileName = "doc1";
			ofd.Filter = "Chart3D.Net xml data files(*.dat3xml)|*.dat3xml|C1Chart7 data files(*.dat)|*.dat";

			if( ofd.ShowDialog()==DialogResult.OK)
				c1Chart3D1.ChartGroups[0].ChartData.LoadDataFromFile( ofd.FileName);
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.DefaultExt = "dat3xml";
			sfd.FileName = "doc1";
			sfd.Filter = "Chart3D.Net xml data files(*.dat3xml)|*.dat3xml|C1Chart7 data files(*.dat)|*.dat";
			
			if( sfd.ShowDialog()==DialogResult.OK)
				c1Chart3D1.ChartGroups[0].ChartData.SaveDataToFile( sfd.FileName);
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			c1Chart3D1.ChartArea.View.IsInteractive = !c1Chart3D1.ChartArea.View.IsInteractive;
			menuItem18.Checked = c1Chart3D1.ChartArea.View.IsInteractive;
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.DefaultExt = "chart3dxml";
			ofd.FileName = "doc1";
			ofd.Filter = "Chart3D xml files(*.chart3dxml)|*.chart3dxml|All files (*.*)|*.*";

			if( ofd.ShowDialog()==DialogResult.OK)
				c1Chart3D1.LoadChartFromFile( ofd.FileName);
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.DefaultExt = "chart3dxml";
			sfd.FileName = "doc1";
			sfd.Filter = "Chart3D xml files(*.chart3dxml)|*.chart3dxml|All files (*.*)|*.*";

			if( sfd.ShowDialog()==DialogResult.OK)
				c1Chart3D1.SaveChartToFile( sfd.FileName);
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			PrintDocument pd = new PrintDocument();
			pd.PrintPage += new PrintPageEventHandler	(this.pd_PrintPage);

			PrintPreviewDialog preview = new PrintPreviewDialog();
			preview.Document = pd;
			preview.ShowDialog();
		}

		private void pd_PrintPage(object sender, PrintPageEventArgs ev) 
		{
			this.c1Chart3D1.Draw( ev.Graphics, ev.MarginBounds);
		}

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			c1Chart3D1.ShowWizard();
		}

		private void menuItem27_Click_1(object sender, System.EventArgs e)
		{
			c1Chart3D1.ShowProperties();
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfg = new SaveFileDialog();

			sfg.Filter = "Metafiles (*.emf)|*.emf|" +
				"Bmp files (*.bmp)|*.bmp|" +
				"Gif files (*.gif)|*.gif|" +
				"Jpeg files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
				"Png files (*.png)|*.png";
			sfg.DefaultExt = "emf";
			sfg.FileName = "image1";
			sfg.OverwritePrompt = true;
			sfg.CheckPathExists = true;
			sfg.RestoreDirectory = false;
			sfg.ValidateNames = true;

			if(sfg.ShowDialog() == DialogResult.OK)
			{
				ImageFormat imgfmt = null;
				switch( Path.GetExtension( sfg.FileName))
				{
					case ".emf":
						imgfmt = ImageFormat.Emf;
						break;

					case ".bmp":
						imgfmt = ImageFormat.Bmp;
						break;

					case ".gif":
						imgfmt = ImageFormat.Gif;
						break;

					case ".jpeg":
					case ".jpg":
						imgfmt = ImageFormat.Jpeg;
						break;

					case ".png":
						imgfmt = ImageFormat.Png;
						break;

					default:
						return;
				}
				c1Chart3D1.SaveImage( sfg.FileName, imgfmt);
			}
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show( this, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);		
		}
	}
}
