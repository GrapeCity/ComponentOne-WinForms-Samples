using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NestedCtls
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.ToolBar toolBar2;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolBar toolBar3;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.ToolBarButton toolBarButton15;
		private System.Windows.Forms.ToolBarButton toolBarButton16;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button10;
        private C1.Win.Sizer.C1SizerLight c1SizerLight1;
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
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.toolBar3 = new System.Windows.Forms.ToolBar();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton15 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.toolBar2 = new System.Windows.Forms.ToolBar();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.c1SizerLight1 = new C1.Win.Sizer.C1SizerLight(this.components);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1SizerLight1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5,
																						this.toolBarButton6,
																						this.toolBarButton7});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(488, 26);
			this.toolBar1.TabIndex = 0;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 279);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2,
																						  this.statusBarPanel3});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(488, 22);
			this.statusBar1.TabIndex = 1;
			this.statusBar1.Text = "statusBar1";
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.Text = "statusBarPanel1";
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.Text = "statusBarPanel2";
			// 
			// statusBarPanel3
			// 
			this.statusBarPanel3.Text = "statusBarPanel3";
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Left;
			this.button1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(0, 26);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 253);
			this.button1.TabIndex = 2;
			this.button1.Text = "Docked Left";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.panel1,
																					this.button2,
																					this.toolBar2,
																					this.button3,
																					this.button4,
																					this.button5,
																					this.button10});
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.groupBox1.Location = new System.Drawing.Point(54, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 236);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button7,
																				 this.button6,
																				 this.label2,
																				 this.toolBar3,
																				 this.button8,
																				 this.button9});
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2109F);
			this.panel1.Location = new System.Drawing.Point(18, 54);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(218, 158);
			this.panel1.TabIndex = 2;
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.625746F);
			this.button7.Location = new System.Drawing.Point(113, 62);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(88, 38);
			this.button7.TabIndex = 3;
			this.button7.Text = "100 times";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.625746F);
			this.button6.Location = new System.Drawing.Point(8, 62);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(97, 38);
			this.button6.TabIndex = 2;
			this.button6.Text = "50 times";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.03077F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic));
			this.label2.Location = new System.Drawing.Point(5, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Resize the form:";
			// 
			// toolBar3
			// 
			this.toolBar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolBar3.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton12,
																						this.toolBarButton13,
																						this.toolBarButton14,
																						this.toolBarButton15,
																						this.toolBarButton16});
			this.toolBar3.DropDownArrows = true;
			this.toolBar3.Name = "toolBar3";
			this.toolBar3.ShowToolTips = true;
			this.toolBar3.Size = new System.Drawing.Size(214, 26);
			this.toolBar3.TabIndex = 0;
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.625746F);
			this.button8.Location = new System.Drawing.Point(8, 110);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(97, 38);
			this.button8.TabIndex = 2;
			this.button8.Text = "150 times";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.625746F, System.Drawing.FontStyle.Bold);
			this.button9.Location = new System.Drawing.Point(113, 110);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(88, 38);
			this.button9.TabIndex = 3;
			this.button9.Text = "200 times!";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2109F);
			this.button2.Location = new System.Drawing.Point(247, 54);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(47, 27);
			this.button2.TabIndex = 1;
			this.button2.Text = "A";
			// 
			// toolBar2
			// 
			this.toolBar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolBar2.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton8,
																						this.toolBarButton9,
																						this.toolBarButton10,
																						this.toolBarButton11});
			this.toolBar2.DropDownArrows = true;
			this.toolBar2.Location = new System.Drawing.Point(3, 16);
			this.toolBar2.Name = "toolBar2";
			this.toolBar2.ShowToolTips = true;
			this.toolBar2.Size = new System.Drawing.Size(304, 26);
			this.toolBar2.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2109F);
			this.button3.Location = new System.Drawing.Point(247, 87);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(47, 27);
			this.button3.TabIndex = 1;
			this.button3.Text = "B";
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2109F);
			this.button4.Location = new System.Drawing.Point(247, 119);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(47, 27);
			this.button4.TabIndex = 1;
			this.button4.Text = "C";
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2109F);
			this.button5.Location = new System.Drawing.Point(247, 151);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(47, 27);
			this.button5.TabIndex = 1;
			this.button5.Text = "D";
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2109F);
			this.button10.Location = new System.Drawing.Point(247, 183);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(47, 27);
			this.button10.TabIndex = 1;
			this.button10.Text = "E";
			// 
			// radioButton1
			// 
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.radioButton1.Location = new System.Drawing.Point(378, 67);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(82, 15);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.Text = "Option 1";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(378, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "A Label:";
			// 
			// radioButton2
			// 
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.radioButton2.Location = new System.Drawing.Point(378, 98);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(82, 15);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.Text = "Option 2";
			// 
			// radioButton3
			// 
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.radioButton3.Location = new System.Drawing.Point(378, 125);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(82, 15);
			this.radioButton3.TabIndex = 4;
			this.radioButton3.Text = "Option 3";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(378, 154);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(101, 111);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.c1SizerLight1.SetAutoResize(this, true);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 301);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pictureBox1,
																		  this.label1,
																		  this.radioButton1,
																		  this.groupBox1,
																		  this.button1,
																		  this.statusBar1,
																		  this.toolBar1,
																		  this.radioButton2,
																		  this.radioButton3});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1SizerLight: Docked and Nested controls";
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1SizerLight1)).EndInit();
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
		private void button6_Click(object sender, System.EventArgs e)
		{
			RandomTest(50);
		}
		private void button7_Click(object sender, System.EventArgs e)
		{
			RandomTest(100);
		}
		private void button8_Click(object sender, System.EventArgs e)
		{
			RandomTest(150);
		}
		private void button9_Click(object sender, System.EventArgs e)
		{
			RandomTest(200);
		}

		private void RandomTest(int rep)
		{
			// save original dimensions
			int widOrg = Width;
			int heiOrg = Height;
			
			// resize form randomly
			Random r = new Random(1);
			for (int i = 0; i < rep; i++)
			{
				Width  = r.Next(100, 800);
				Height = r.Next(100, 600);
				//Application.DoEvents();
				Update();
			}

			// restore original dimensions
			Width  = widOrg;
			Height = heiOrg;
		}
	}
}
