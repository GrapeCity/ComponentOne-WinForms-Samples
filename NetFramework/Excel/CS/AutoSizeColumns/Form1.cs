using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using C1.C1Excel;

namespace WindowsApplication2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Excel.C1XLBook c1XLBook1;
		private System.Windows.Forms.Button button1;
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
			this.c1XLBook1 = new C1.C1Excel.C1XLBook();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(264, 56);
			this.button1.TabIndex = 0;
			this.button1.Text = "Create grid, auto-size columns";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(280, 77);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Excel: AutoSize columns";
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
			// clear book
			c1XLBook1.Clear();

			// add some styles
			XLStyle s1 = new XLStyle(c1XLBook1);
			XLStyle s2 = new XLStyle(c1XLBook1);
			XLStyle s3 = new XLStyle(c1XLBook1);
			s1.Format = "#,##0.00000";
			s2.Format = "#,##0.00000";
			s2.Font = new Font("Courier New", 14);
			s3.Format = "dd-MMM-yy";

			// populate sheet with some random values
			C1.C1Excel.XLSheet sheet = c1XLBook1.Sheets[0];
			Random r = new Random();
			for (int i = 0; i < 100; i++)
			{
				sheet[i, 0].Value = r.NextDouble() * 100000;
				sheet[i, 0].Style = (i % 13 == 0)? s2 : s1;
			}
			for (int i = 0; i < 100; i++)
			{
				sheet[i, 1].Value = new DateTime(2005, r.Next(1,12), r.Next(1,28));
				sheet[i, 1].Style = s3;
			}

			string tempdir = Application.ExecutablePath.Substring(0,
				Application.ExecutablePath.LastIndexOf("\\")+1);

			// save with default column widths
			c1XLBook1.Save(tempdir + @"defaultWidth.xls");

			// autosize columns
			AutoSizeColumns(sheet);

			// save again after autosizing
			c1XLBook1.Save(tempdir + @"autoSized.xls");

			// show the autosized version
			System.Diagnostics.Process.Start(tempdir + @"autoSized.xls");
		}
		private void AutoSizeColumns(XLSheet sheet)
		{
			using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
			{
				for (int c = 0; c < sheet.Columns.Count; c++)
				{
					int colWidth = -1;
					for (int r = 0; r < sheet.Rows.Count; r++)
					{
						object value = sheet[r, c].Value;
						if (value != null)
						{
							// get value (unformatted at this point)
							string text = value.ToString();

							// format value if cell has a style with format set
							C1.C1Excel.XLStyle s = sheet[r, c].Style;
							if (s != null && s.Format.Length > 0 && value is IFormattable)
							{
								string fmt = XLStyle.FormatXLToDotNet(s.Format);
								text = ((IFormattable)value).ToString(fmt, CultureInfo.CurrentCulture);
							}

							// get font (default or style)
							Font font = this.c1XLBook1.DefaultFont;
							if (s != null && s.Font != null)
							{
								font = s.Font;
							}

							// measure string (add a little tolerance)
							Size sz = Size.Ceiling(g.MeasureString(text + "XX", font));

							// keep widest so far
							if (sz.Width > colWidth)
								colWidth = sz.Width;
						}
					}

					// done measuring, set column width
					if (colWidth > -1)
						sheet.Columns[c].Width = C1XLBook.PixelsToTwips(colWidth);
				}
			}
		}
	}
}
