using System;
using System.Threading;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.C1Pdf;

namespace PdfThreaded
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Pdf.C1PdfDocument c1PdfDocument1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
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
			this.c1PdfDocument1 = new C1.C1Pdf.C1PdfDocument();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(168, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Go";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "5",
														   "10",
														   "50",
														   "100",
														   "200"});
			this.comboBox1.Location = new System.Drawing.Point(8, 80);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(152, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 48);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select the number of threads you want to create, then click \"Go\". Each thread wil" +
				"l generate a Pdf file in the execution directory\".";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 117);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.comboBox1,
																		  this.button1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Pdf: Threaded test";
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

		private void makeDocument()
		{
			// start a new document
			C1PdfDocument pdf = new C1PdfDocument();
			string name = Thread.CurrentThread.Name;

			// with two fonts
			Font font1 = new Font("Tahoma", 10);
			Font font2 = new Font("Tahoma", 10, FontStyle.Italic);

			// create document
			pdf.Clear();
			RectangleF rc = pdf.PageRectangle;
			rc.Inflate(-72,-72);
			while (rc.Y < pdf.PageRectangle.Bottom - 72)
			{
				pdf.DrawString("Hello buddy. This is thread " + name, font1, Brushes.Red, rc);
				rc.Y += 12;
				pdf.DrawString("Hello again. Same thread " + name, font2, Brushes.Blue, rc);
				rc.Y += 12;
				pdf.DrawLine(Pens.ForestGreen, rc.X, rc.Y, rc.Right, rc.Y);

				// let other threads work
				Thread.Sleep(0);
			}

			// save document
			string tempdir = Application.ExecutablePath.Substring(0,
				Application.ExecutablePath.LastIndexOf("\\")+1);
			pdf.Save(string.Format(tempdir + "test{0}.pdf", name));
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
		}

		int _ctr = 0;
		private void button1_Click(object sender, System.EventArgs e)
		{
			int n = int.Parse(comboBox1.Text);
			for (int i = 0; i < n; i++)
			{
				Thread t = new Thread(new ThreadStart(makeDocument));
				t.Name = string.Format("{0}", i + _ctr);
				t.Start();
			}
			_ctr += n;
		}
	}
}
