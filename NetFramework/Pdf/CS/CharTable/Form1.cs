using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using _Font = C1.Util.Font;
using _StringFormat = C1.Util.StringFormat;
using _HorizontalAlignment = C1.Util.HorizontalAlignment;
using _VerticalAlignment = C1.Util.VerticalAlignment;

namespace CharTable
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private C1.Win.Pdf.C1PdfDocument _pdf;
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
            this.button1 = new System.Windows.Forms.Button();
            this._pdf = new C1.Win.Pdf.C1PdfDocument();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Build Table";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _pdf
            // 
            this._pdf.FontType = C1.Pdf.PdfFontType.Embedded;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(216, 61);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Pdf: Character Table";
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
			_pdf.Clear();

			Rectangle rcell = new Rectangle(72, 72, 36, 36);
            var sf = new _StringFormat();
			sf.Alignment = _HorizontalAlignment.Center;
			sf.LineAlignment = _VerticalAlignment.Center;
			var f1 = new _Font("Tahoma", rcell.Height / 2);
			var f2 = new _Font("Tahoma", rcell.Height / 6);
            GrapeCity.Documents.Drawing.Pen pen = new GrapeCity.Documents.Drawing.Pen(Color.Black, 0.1f);

			int col = 0;
			for (char c = (char)32; c <= (char)256; c++)
			{
				// show this character
				_pdf.DrawRectangle(pen, rcell);
				_pdf.DrawString(c.ToString(), f1, Color.Black, rcell, sf);

				rcell.Width  /= 2;
				rcell.Height /= 4;
				_pdf.DrawRectangle(pen, rcell);
				_pdf.DrawString(((int)c).ToString(), f2, Color.Black, rcell, sf);
				rcell.Width  *= 2;
				rcell.Height *= 4;

				// increment rectangle
				col++;
				if (col >= 12)
				{
					col = 0;
					rcell.X = 72;
					rcell.Y += rcell.Height;
				}
				else
				{
					rcell.X += rcell.Width;
				}
			}

			string tempdir = Application.ExecutablePath.Substring(0,
				Application.ExecutablePath.LastIndexOf("\\")+1);
			string fname = tempdir + "chartbl.pdf";
			_pdf.Save(fname);
			System.Diagnostics.Process.Start(fname);
		}
	}
}
