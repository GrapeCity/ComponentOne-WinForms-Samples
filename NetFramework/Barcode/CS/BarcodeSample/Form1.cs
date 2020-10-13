using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1BarCode;

namespace WindowsApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Label label10;
		private C1.Win.C1BarCode.C1BarCode c1BarCode3;
		private C1.Win.C1BarCode.C1BarCode c1BarCode4;
		private System.Windows.Forms.TextBox textBox1;
		private C1.Win.C1BarCode.C1BarCode c1BarCode5;
		private C1.Win.C1BarCode.C1BarCode c1BarCode6;
		private C1.Win.C1BarCode.C1BarCode c1BarCode1;
		private C1.Win.C1BarCode.C1BarCode c1BarCode2;
		private C1.Win.C1BarCode.C1BarCode c1BarCode7;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1BarCode.C1BarCode c1BarCode8;
		private System.Windows.Forms.Label label2;
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.label10 = new System.Windows.Forms.Label();
			this.c1BarCode3 = new C1.Win.C1BarCode.C1BarCode();
			this.c1BarCode4 = new C1.Win.C1BarCode.C1BarCode();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.c1BarCode5 = new C1.Win.C1BarCode.C1BarCode();
			this.c1BarCode6 = new C1.Win.C1BarCode.C1BarCode();
			this.c1BarCode1 = new C1.Win.C1BarCode.C1BarCode();
			this.c1BarCode2 = new C1.Win.C1BarCode.C1BarCode();
			this.c1BarCode7 = new C1.Win.C1BarCode.C1BarCode();
			this.label1 = new System.Windows.Forms.Label();
			this.c1BarCode8 = new C1.Win.C1BarCode.C1BarCode();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(512, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "39";
			// 
			// label5
			// 
			this.label5.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(512, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "93";
			// 
			// label6
			// 
			this.label6.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(512, 216);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Codabar";
			// 
			// label7
			// 
			this.label7.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(512, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "128";
			// 
			// label8
			// 
			this.label8.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(512, 328);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "PostNet";
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.HelpVisible = false;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(8, 8);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.propertyGrid1.Size = new System.Drawing.Size(184, 480);
			this.propertyGrid1.TabIndex = 5;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ToolbarVisible = false;
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// label10
			// 
			this.label10.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(512, 160);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "i2of5";
			// 
			// c1BarCode3
			// 
			this.c1BarCode3.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1BarCode3.CodeType = C1.Win.C1BarCode.CodeTypeEnum.CodeI2of5;
			this.c1BarCode3.Location = new System.Drawing.Point(208, 160);
			this.c1BarCode3.Name = "c1BarCode3";
			this.c1BarCode3.Size = new System.Drawing.Size(296, 48);
			this.c1BarCode3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode3.TabIndex = 1;
			this.c1BarCode3.Text = "123";
			// 
			// c1BarCode4
			// 
			this.c1BarCode4.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1BarCode4.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Codabar;
			this.c1BarCode4.Location = new System.Drawing.Point(208, 216);
			this.c1BarCode4.Name = "c1BarCode4";
			this.c1BarCode4.Size = new System.Drawing.Size(296, 48);
			this.c1BarCode4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode4.TabIndex = 1;
			this.c1BarCode4.Text = "123";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textBox1.Location = new System.Drawing.Point(208, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(296, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "textBox1";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// c1BarCode5
			// 
			this.c1BarCode5.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1BarCode5.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128;
			this.c1BarCode5.Location = new System.Drawing.Point(208, 272);
			this.c1BarCode5.Name = "c1BarCode5";
			this.c1BarCode5.Size = new System.Drawing.Size(296, 48);
			this.c1BarCode5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode5.TabIndex = 1;
			this.c1BarCode5.Text = "123";
			// 
			// c1BarCode6
			// 
			this.c1BarCode6.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1BarCode6.BarHeight = 12;
			this.c1BarCode6.CodeType = C1.Win.C1BarCode.CodeTypeEnum.PostNet;
			this.c1BarCode6.Location = new System.Drawing.Point(208, 328);
			this.c1BarCode6.Name = "c1BarCode6";
			this.c1BarCode6.Size = new System.Drawing.Size(296, 48);
			this.c1BarCode6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode6.TabIndex = 1;
			this.c1BarCode6.Text = "123";
			// 
			// c1BarCode1
			// 
			this.c1BarCode1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1BarCode1.Location = new System.Drawing.Point(208, 48);
			this.c1BarCode1.Name = "c1BarCode1";
			this.c1BarCode1.Size = new System.Drawing.Size(296, 48);
			this.c1BarCode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode1.TabIndex = 1;
			this.c1BarCode1.Text = "123";
			// 
			// c1BarCode2
			// 
			this.c1BarCode2.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1BarCode2.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code93;
			this.c1BarCode2.Location = new System.Drawing.Point(208, 104);
			this.c1BarCode2.Name = "c1BarCode2";
			this.c1BarCode2.Size = new System.Drawing.Size(296, 48);
			this.c1BarCode2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode2.TabIndex = 1;
			this.c1BarCode2.Text = "123";
			// 
			// c1BarCode7
			// 
			this.c1BarCode7.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1BarCode7.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Ean13;
			this.c1BarCode7.Location = new System.Drawing.Point(208, 440);
			this.c1BarCode7.Name = "c1BarCode7";
			this.c1BarCode7.Size = new System.Drawing.Size(296, 48);
			this.c1BarCode7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode7.TabIndex = 1;
			this.c1BarCode7.Text = "123";
			// 
			// label1
			// 
			this.label1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(512, 384);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "EAN-8";
			// 
			// c1BarCode8
			// 
			this.c1BarCode8.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.c1BarCode8.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Ean8;
			this.c1BarCode8.Location = new System.Drawing.Point(208, 384);
			this.c1BarCode8.Name = "c1BarCode8";
			this.c1BarCode8.Size = new System.Drawing.Size(296, 48);
			this.c1BarCode8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode8.TabIndex = 1;
			this.c1BarCode8.Text = "123";
			// 
			// label2
			// 
			this.label2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(512, 440);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "EAN-13";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(560, 501);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.propertyGrid1,
																		  this.label8,
																		  this.label6,
																		  this.label4,
																		  this.label5,
																		  this.label7,
																		  this.label10,
																		  this.textBox1,
																		  this.c1BarCode1,
																		  this.c1BarCode2,
																		  this.c1BarCode3,
																		  this.c1BarCode4,
																		  this.c1BarCode5,
																		  this.c1BarCode6,
																		  this.c1BarCode7,
																		  this.label1,
																		  this.c1BarCode8,
																		  this.label2});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1BarCode sample";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			foreach (Control ctl in Controls)
			{
				if (ctl is C1BarCode)
				{
					ctl.Text = textBox1.Text;		
				}
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			ArrayList al = new ArrayList();
			foreach (Control ctl in Controls)
			{
				if (ctl is C1BarCode)
					al.Add(ctl);
			}
			propertyGrid1.SelectedObjects = (object[])al.ToArray(typeof(C1BarCode));
		}
	}
}
