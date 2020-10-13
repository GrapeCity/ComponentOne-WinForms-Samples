using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Code128Test
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1BarCode.C1BarCode c1BarCode1;
		private C1.Win.C1BarCode.C1BarCode c1BarCode2;
		private C1.Win.C1BarCode.C1BarCode c1BarCode3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private C1.Win.C1BarCode.C1BarCode c1BarCode4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private C1.Win.C1BarCode.C1BarCode c1BarCode5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private C1.Win.C1BarCode.C1BarCode c1BarCode6;
		private C1.Win.C1BarCode.C1BarCode c1BarCode7;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private C1.Win.C1BarCode.C1BarCode c1BarCode8;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.c1BarCode1 = new C1.Win.C1BarCode.C1BarCode();
			this.c1BarCode2 = new C1.Win.C1BarCode.C1BarCode();
			this.c1BarCode3 = new C1.Win.C1BarCode.C1BarCode();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.c1BarCode4 = new C1.Win.C1BarCode.C1BarCode();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.c1BarCode5 = new C1.Win.C1BarCode.C1BarCode();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.c1BarCode6 = new C1.Win.C1BarCode.C1BarCode();
			this.c1BarCode7 = new C1.Win.C1BarCode.C1BarCode();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.c1BarCode8 = new C1.Win.C1BarCode.C1BarCode();
			this.SuspendLayout();
			// 
			// c1BarCode1
			// 
			this.c1BarCode1.BackColor = System.Drawing.Color.Transparent;
			this.c1BarCode1.BarHeight = 60;
			this.c1BarCode1.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128;
			this.c1BarCode1.Location = new System.Drawing.Point(8, 320);
			this.c1BarCode1.Name = "c1BarCode1";
			this.c1BarCode1.ShowText = true;
			this.c1BarCode1.Size = new System.Drawing.Size(280, 56);
			this.c1BarCode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode1.TabIndex = 0;
			this.c1BarCode1.Text = "c1BarCode1";
			// 
			// c1BarCode2
			// 
			this.c1BarCode2.BackColor = System.Drawing.Color.Transparent;
			this.c1BarCode2.BarHeight = 60;
			this.c1BarCode2.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128;
			this.c1BarCode2.Location = new System.Drawing.Point(8, 64);
			this.c1BarCode2.Name = "c1BarCode2";
			this.c1BarCode2.ShowText = true;
			this.c1BarCode2.Size = new System.Drawing.Size(280, 56);
			this.c1BarCode2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode2.TabIndex = 0;
			this.c1BarCode2.Text = "Ê9012KSCAC12345678901234567890";
			// 
			// c1BarCode3
			// 
			this.c1BarCode3.BackColor = System.Drawing.Color.Transparent;
			this.c1BarCode3.BarHeight = 60;
			this.c1BarCode3.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128;
			this.c1BarCode3.Location = new System.Drawing.Point(8, 190);
			this.c1BarCode3.Name = "c1BarCode3";
			this.c1BarCode3.ShowText = true;
			this.c1BarCode3.Size = new System.Drawing.Size(280, 56);
			this.c1BarCode3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode3.TabIndex = 0;
			this.c1BarCode3.Text = "Please work";
			this.c1BarCode3.Click += new System.EventHandler(this.c1BarCode3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 264);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(280, 87);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(8, 8);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(280, 87);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(8, 136);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(280, 87);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// c1BarCode4
			// 
			this.c1BarCode4.BackColor = System.Drawing.Color.Transparent;
			this.c1BarCode4.BarHeight = 60;
			this.c1BarCode4.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128;
			this.c1BarCode4.Location = new System.Drawing.Point(296, 64);
			this.c1BarCode4.Name = "c1BarCode4";
			this.c1BarCode4.ShowText = true;
			this.c1BarCode4.Size = new System.Drawing.Size(280, 56);
			this.c1BarCode4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode4.TabIndex = 0;
			this.c1BarCode4.Text = "Ê40206141411234567891";
			// 
			// pictureBox4
			// 
			this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox4.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(296, 8);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(280, 87);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox4.TabIndex = 1;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox5.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(296, 136);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(280, 87);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox5.TabIndex = 1;
			this.pictureBox5.TabStop = false;
			// 
			// c1BarCode5
			// 
			this.c1BarCode5.BackColor = System.Drawing.Color.Transparent;
			this.c1BarCode5.BarHeight = 60;
			this.c1BarCode5.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128;
			this.c1BarCode5.Location = new System.Drawing.Point(296, 190);
			this.c1BarCode5.Name = "c1BarCode5";
			this.c1BarCode5.ShowText = true;
			this.c1BarCode5.Size = new System.Drawing.Size(280, 56);
			this.c1BarCode5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode5.TabIndex = 0;
			this.c1BarCode5.Text = "E = m * c^2";
			// 
			// pictureBox6
			// 
			this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox6.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(296, 264);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(280, 87);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox6.TabIndex = 1;
			this.pictureBox6.TabStop = false;
			// 
			// c1BarCode6
			// 
			this.c1BarCode6.BackColor = System.Drawing.Color.Transparent;
			this.c1BarCode6.BarHeight = 60;
			this.c1BarCode6.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128;
			this.c1BarCode6.Location = new System.Drawing.Point(296, 320);
			this.c1BarCode6.Name = "c1BarCode6";
			this.c1BarCode6.ShowText = true;
			this.c1BarCode6.Size = new System.Drawing.Size(280, 56);
			this.c1BarCode6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode6.TabIndex = 0;
			this.c1BarCode6.Text = "CamelCase0123456";
			// 
			// c1BarCode7
			// 
			this.c1BarCode7.BackColor = System.Drawing.Color.Transparent;
			this.c1BarCode7.BarHeight = 60;
			this.c1BarCode7.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128;
			this.c1BarCode7.Location = new System.Drawing.Point(8, 448);
			this.c1BarCode7.Name = "c1BarCode7";
			this.c1BarCode7.ShowText = true;
			this.c1BarCode7.Size = new System.Drawing.Size(280, 56);
			this.c1BarCode7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode7.TabIndex = 0;
			this.c1BarCode7.Text = "Ê1234567";
			// 
			// pictureBox7
			// 
			this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox7.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(8, 392);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(280, 87);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox7.TabIndex = 1;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox8.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(296, 392);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(280, 87);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox8.TabIndex = 1;
			this.pictureBox8.TabStop = false;
			// 
			// c1BarCode8
			// 
			this.c1BarCode8.BackColor = System.Drawing.Color.Transparent;
			this.c1BarCode8.BarHeight = 60;
			this.c1BarCode8.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128;
			this.c1BarCode8.Location = new System.Drawing.Point(296, 448);
			this.c1BarCode8.Name = "c1BarCode8";
			this.c1BarCode8.ShowText = true;
			this.c1BarCode8.Size = new System.Drawing.Size(280, 56);
			this.c1BarCode8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.c1BarCode8.TabIndex = 0;
			this.c1BarCode8.Text = "3.14159265358979323846";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(584, 518);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1BarCode8,
																		  this.c1BarCode6,
																		  this.c1BarCode5,
																		  this.c1BarCode1,
																		  this.pictureBox1,
																		  this.c1BarCode2,
																		  this.c1BarCode3,
																		  this.pictureBox2,
																		  this.pictureBox3,
																		  this.c1BarCode4,
																		  this.pictureBox4,
																		  this.pictureBox5,
																		  this.pictureBox6,
																		  this.c1BarCode7,
																		  this.pictureBox7,
																		  this.pictureBox8});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Code 128";
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

		private void c1BarCode3_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
