using System;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Security
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _txtOwner;
		private System.Windows.Forms.TextBox _txtUser;
		private System.Windows.Forms.CheckBox _chkAllowPrint;
		private System.Windows.Forms.CheckBox _chkAllowCopy;
		private System.Windows.Forms.CheckBox _chkAllowEditContent;
		private System.Windows.Forms.CheckBox _chkAllowEditAnnot;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button _btnCreate;
		private C1.C1Pdf.C1PdfDocument c1PdfDocument1;
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
			this._txtOwner = new System.Windows.Forms.TextBox();
			this._txtUser = new System.Windows.Forms.TextBox();
			this._chkAllowPrint = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._chkAllowCopy = new System.Windows.Forms.CheckBox();
			this._chkAllowEditContent = new System.Windows.Forms.CheckBox();
			this._chkAllowEditAnnot = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._btnCreate = new System.Windows.Forms.Button();
			this.c1PdfDocument1 = new C1.C1Pdf.C1PdfDocument();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _txtOwner
			// 
			this._txtOwner.Location = new System.Drawing.Point(104, 16);
			this._txtOwner.Name = "_txtOwner";
			this._txtOwner.Size = new System.Drawing.Size(120, 20);
			this._txtOwner.TabIndex = 0;
			this._txtOwner.Text = "";
			// 
			// _txtUser
			// 
			this._txtUser.Location = new System.Drawing.Point(104, 48);
			this._txtUser.Name = "_txtUser";
			this._txtUser.Size = new System.Drawing.Size(120, 20);
			this._txtUser.TabIndex = 0;
			this._txtUser.Text = "";
			// 
			// _chkAllowPrint
			// 
			this._chkAllowPrint.Checked = true;
			this._chkAllowPrint.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkAllowPrint.Location = new System.Drawing.Point(16, 24);
			this._chkAllowPrint.Name = "_chkAllowPrint";
			this._chkAllowPrint.Size = new System.Drawing.Size(136, 16);
			this._chkAllowPrint.TabIndex = 1;
			this._chkAllowPrint.Text = "Print";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Owner Password";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "User Password";
			// 
			// _chkAllowCopy
			// 
			this._chkAllowCopy.Checked = true;
			this._chkAllowCopy.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkAllowCopy.Location = new System.Drawing.Point(16, 48);
			this._chkAllowCopy.Name = "_chkAllowCopy";
			this._chkAllowCopy.Size = new System.Drawing.Size(136, 16);
			this._chkAllowCopy.TabIndex = 1;
			this._chkAllowCopy.Text = "Copy Content";
			// 
			// _chkAllowEditContent
			// 
			this._chkAllowEditContent.Checked = true;
			this._chkAllowEditContent.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkAllowEditContent.Location = new System.Drawing.Point(16, 96);
			this._chkAllowEditContent.Name = "_chkAllowEditContent";
			this._chkAllowEditContent.Size = new System.Drawing.Size(136, 16);
			this._chkAllowEditContent.TabIndex = 1;
			this._chkAllowEditContent.Text = "Edit Content";
			// 
			// _chkAllowEditAnnot
			// 
			this._chkAllowEditAnnot.Checked = true;
			this._chkAllowEditAnnot.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkAllowEditAnnot.Location = new System.Drawing.Point(16, 72);
			this._chkAllowEditAnnot.Name = "_chkAllowEditAnnot";
			this._chkAllowEditAnnot.Size = new System.Drawing.Size(136, 16);
			this._chkAllowEditAnnot.TabIndex = 1;
			this._chkAllowEditAnnot.Text = "Edit Annotations";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this._chkAllowPrint,
																					this._chkAllowCopy,
																					this._chkAllowEditAnnot,
																					this._chkAllowEditContent});
			this.groupBox1.Location = new System.Drawing.Point(16, 88);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(208, 120);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Permissions";
			// 
			// _btnCreate
			// 
			this._btnCreate.Location = new System.Drawing.Point(16, 224);
			this._btnCreate.Name = "_btnCreate";
			this._btnCreate.Size = new System.Drawing.Size(208, 24);
			this._btnCreate.TabIndex = 4;
			this._btnCreate.Text = "Create Document";
			this._btnCreate.Click += new System.EventHandler(this._btnCreate_Click);
			// 
			// c1PdfDocument1
			// 
			this.c1PdfDocument1.DocumentInfo.Author = "Peter Downes Fisher";
			this.c1PdfDocument1.DocumentInfo.Creator = "Sample App";
			this.c1PdfDocument1.DocumentInfo.Keywords = "Security, protection, encryption";
			this.c1PdfDocument1.DocumentInfo.Producer = "ComponentOne C1Pdf";
			this.c1PdfDocument1.DocumentInfo.Subject = "Security";
			this.c1PdfDocument1.DocumentInfo.Title = "Pdf Security Sample";
			this.c1PdfDocument1.Security.AllowCopyContent = true;
			this.c1PdfDocument1.Security.AllowEditAnnotations = true;
			this.c1PdfDocument1.Security.AllowEditContent = true;
			this.c1PdfDocument1.Security.AllowPrint = true;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(240, 262);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._btnCreate,
																		  this.groupBox1,
																		  this.label1,
																		  this._txtOwner,
																		  this._txtUser,
																		  this.label2});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Pdf Security";
			this.groupBox1.ResumeLayout(false);
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

		private void _btnCreate_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument(System.Drawing.Printing.PaperKind.A4);
			pdf.Compression = C1.C1Pdf.CompressionEnum.None;
			pdf.Security.UserPassword         = _txtUser.Text;
			pdf.Security.OwnerPassword        = _txtOwner.Text;
			pdf.Security.AllowPrint           = _chkAllowPrint.Checked;
			pdf.Security.AllowCopyContent     = _chkAllowCopy.Checked;
			pdf.Security.AllowEditAnnotations = _chkAllowEditAnnot.Checked;
			pdf.Security.AllowEditContent     = _chkAllowEditContent.Checked;

			RectangleF rc = pdf.PageRectangle;
			rc.Inflate(-72, -72);
			pdf.DrawRectangle(Pens.Black, rc, new SizeF(72,72));
			rc.Inflate(-72, -72);

			Font font = new Font("Tahoma", 12);
			string text = string.Format("Owner password is '{0}'\r\nUser password is '{1}'", _txtOwner.Text, _txtUser.Text);
			pdf.DrawString(text, font, Brushes.Black, rc);

			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\security.pdf";
			pdf.Save(fileName);
			Process.Start(fileName);
		}
	}
}
