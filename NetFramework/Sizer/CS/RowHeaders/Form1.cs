using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RowHeaders
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.Sizer.C1Sizer c1Sizer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Label label8;
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
			this.c1Sizer1 = new C1.Win.Sizer.C1Sizer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.panel12 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel12.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.panel1,
																				   this.panel2,
																				   this.panel7,
																				   this.panel10});
			this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Sizer1.GridDefinition = "48.3483483483483:True:False;48.048048048048:False:False;\t31.0606060606061:True:Fa" +
				"lse;66.6666666666667:False:False;";
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(528, 333);
			this.c1Sizer1.TabIndex = 0;
			this.c1Sizer1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel4,
																				 this.panel3});
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(164, 161);
			this.panel1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label2});
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 24);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(164, 137);
			this.panel4.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Top Row Content";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
			this.panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label1});
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(164, 24);
			this.panel3.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Top Row Header";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel5,
																				 this.panel6});
			this.panel2.Location = new System.Drawing.Point(4, 169);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(164, 160);
			this.panel2.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel5.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label3});
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 24);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(164, 136);
			this.panel5.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(182, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Bottom Row Content";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.Desktop;
			this.panel6.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label4});
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(164, 24);
			this.panel6.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(182, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "Bottom Row Header";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel7
			// 
			this.panel7.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel8,
																				 this.panel9});
			this.panel7.Location = new System.Drawing.Point(172, 4);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(352, 161);
			this.panel7.TabIndex = 0;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel8.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label5});
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 24);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(352, 137);
			this.panel8.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(182, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Right Row Content";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.SystemColors.Desktop;
			this.panel9.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label6});
			this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(352, 24);
			this.panel9.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(182, 22);
			this.label6.TabIndex = 0;
			this.label6.Text = "Right Row Header";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel10
			// 
			this.panel10.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.panel11,
																				  this.panel12});
			this.panel10.Location = new System.Drawing.Point(172, 169);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(352, 160);
			this.panel10.TabIndex = 0;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel11.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.label7});
			this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel11.Location = new System.Drawing.Point(0, 24);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(352, 136);
			this.panel11.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(182, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "Bottom Row Content";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel12
			// 
			this.panel12.BackColor = System.Drawing.SystemColors.Desktop;
			this.panel12.Controls.AddRange(new System.Windows.Forms.Control[] {
																				  this.label8});
			this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(352, 24);
			this.panel12.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(182, 22);
			this.label8.TabIndex = 0;
			this.label8.Text = "Bottom Row Header";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 333);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Sizer1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Sizer: Row Headers";
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
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
