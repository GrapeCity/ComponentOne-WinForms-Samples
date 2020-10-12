using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace PrintBarCodes
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1BarCode.C1BarCode _c1BarCode;
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
			this._c1BarCode = new C1.Win.C1BarCode.C1BarCode();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _c1BarCode
			// 
			this._c1BarCode.Location = new System.Drawing.Point(136, 16);
			this._c1BarCode.Name = "_c1BarCode";
			this._c1BarCode.Size = new System.Drawing.Size(75, 23);
			this._c1BarCode.TabIndex = 0;
			this._c1BarCode.Text = "c1BarCode1";
			this._c1BarCode.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Show Document";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 61);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this._c1BarCode});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1BarCode";
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

		DataTable _dt = new DataTable();
		void Form1_Load(object sender, System.EventArgs e)
		{
			// get some data for the report
			string sql = "select * from products";
            string conn = GetConnectionString();
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			da.Fill(_dt);
		}
		void button1_Click(object sender, System.EventArgs e)
		{
			// create PrintDocument
			PrintDocument doc = new PrintDocument();
			doc.BeginPrint += new PrintEventHandler(_beginPrint);
			doc.PrintPage += new PrintPageEventHandler(_printPage);

			// show preview
			PrintPreviewDialog dlg = new PrintPreviewDialog();
			dlg.Document = doc;
			dlg.ShowDialog();
		}
		int _item;
		void _beginPrint(object sender, PrintEventArgs e)
		{
			_item = 0;
		}
		void _printPage(object sender, PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;

			Font font = new Font("Tahoma", 12);
			Rectangle rcPage = e.MarginBounds;
			Rectangle rc1 = rcPage;
			rc1.Height = 30;
			rc1.Width = 100;
			
			Rectangle rc2 = rc1;
			rc2.Offset(rc1.Width, 0);
			rc2.Width = 300;

			Rectangle rc3 = rc2;
			rc3.Offset(rc2.Width, 0);
			rc3.Width = 100;

			// show header at the top of the page
			g.DrawString("Product ID", font, Brushes.Black, rc1);
			g.DrawString("Name", font, Brushes.Black, rc2);
			g.DrawString("Code", font, Brushes.Black, rc3);
			rc1.Y += rc1.Height + 10;
			rc2.Y += rc2.Height + 10;
			rc3.Y += rc3.Height + 10;

			// loop through rows until done (or until out of room)
			while (rc1.Bottom <= rcPage.Bottom && _item < _dt.Rows.Count)
			{
				DataRow dr = _dt.Rows[_item];
				string id = string.Format("{0:0000}", dr["ProductID"]);
				string name = (string)dr["ProductName"];
				g.DrawString(id, font, Brushes.Black, rc1);
				g.DrawString(name, font, Brushes.Black, rc2);

				_c1BarCode.Text = id;
				g.DrawImage(_c1BarCode.Image, rc3);

				rc1.Y += rc1.Height + 10;
				rc2.Y += rc2.Height + 10;
				rc3.Y += rc3.Height + 10;
				_item++;
			}

			// continue if necessary
			e.HasMorePages = (_item < _dt.Rows.Count - 1);
		}
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
