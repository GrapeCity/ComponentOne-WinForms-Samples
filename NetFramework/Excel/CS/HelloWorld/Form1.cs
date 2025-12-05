using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Excel;

namespace HelloWorld
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private C1.Excel.C1XLBook c1XLBook1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.c1XLBook1 = new C1.Excel.C1XLBook();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(192, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Create XLS file";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(192, 40);
			this.button2.TabIndex = 0;
			this.button2.Text = "Add Sheets";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// c1XLBook1
			// 
			this.c1XLBook1.DefaultFont = new C1.Excel.XLFont("Arial", 10F);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(208, 101);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.button2});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Excel";
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
			// step 1: create a new workbook
			C1XLBook book = new C1XLBook();

			// step 2: get the sheet that was created by default, give it a name
			XLSheet sheet = book.Sheets[0];
			sheet.Name = "Hello World";

			// step 3: create styles for odd and even values
			XLStyle styleOdd    = new XLStyle(book);
			styleOdd.Font       = new XLFont("Tahoma", 9, false, true);
			styleOdd.ForeColor  = Color.Blue;
			XLStyle styleEven   = new XLStyle(book);
			styleEven.Font		= new XLFont("Tahoma", 9, true, false);
			styleEven.ForeColor = Color.Red;

			// step 3: write content and format into some cells
			for (int i = 0; i < 100; i++)
			{
				XLCell cell = sheet[i, 0]; 
				cell.Value = i + 1;
				cell.Style = ((i+1) % 2 == 0)? styleEven: styleOdd;
			}

			// step 4: save the file
			string fileName = Application.StartupPath + @"\hello.xls";
			book.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// create book (will have a single sheet by default)
			C1XLBook book = new C1XLBook();

            MessageBox.Show(string.Format("The book has {0} sheet", book.Sheets.Count));

			// add three blank sheets
			for (int i = 0; i < 3; i++)
				book.Sheets.Add();

            MessageBox.Show(string.Format("The book now has {0} sheets", book.Sheets.Count));
		}
	}
}
