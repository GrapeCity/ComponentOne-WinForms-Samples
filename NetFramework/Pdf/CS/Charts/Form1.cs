using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Charts
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private C1.Win.C1Chart.C1Chart c1Chart2;
		private C1.Win.C1Chart.C1Chart c1Chart3;
		private C1.Win.C1Chart.C1Chart c1Chart4;
		private C1.Win.C1Chart.C1Chart c1Chart5;
		private C1.Win.C1Chart.C1Chart c1Chart6;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D1;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D2;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D3;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D4;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D5;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D6;
		private System.Windows.Forms.Button button1;
		private C1.C1Pdf.C1PdfDocument _c1pdf;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D7;
		private C1.Win.C1Chart3D.C1Chart3D c1Chart3D8;
		private C1.Win.C1Chart.C1Chart c1Chart7;
		private C1.Win.C1Chart.C1Chart c1Chart8;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            this.c1Chart2 = new C1.Win.C1Chart.C1Chart();
            this.c1Chart3 = new C1.Win.C1Chart.C1Chart();
            this.c1Chart5 = new C1.Win.C1Chart.C1Chart();
            this.c1Chart6 = new C1.Win.C1Chart.C1Chart();
            this.c1Chart4 = new C1.Win.C1Chart.C1Chart();
            this.c1Chart7 = new C1.Win.C1Chart.C1Chart();
            this.c1Chart8 = new C1.Win.C1Chart.C1Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.c1Chart3D1 = new C1.Win.C1Chart3D.C1Chart3D();
            this.c1Chart3D2 = new C1.Win.C1Chart3D.C1Chart3D();
            this.c1Chart3D3 = new C1.Win.C1Chart3D.C1Chart3D();
            this.c1Chart3D4 = new C1.Win.C1Chart3D.C1Chart3D();
            this.c1Chart3D6 = new C1.Win.C1Chart3D.C1Chart3D();
            this.c1Chart3D5 = new C1.Win.C1Chart3D.C1Chart3D();
            this.c1Chart3D7 = new C1.Win.C1Chart3D.C1Chart3D();
            this.c1Chart3D8 = new C1.Win.C1Chart3D.C1Chart3D();
            this.button1 = new System.Windows.Forms.Button();
            this._c1pdf = new C1.C1Pdf.C1PdfDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart8)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D8)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.c1Chart1);
            this.tabPage1.Controls.Add(this.c1Chart2);
            this.tabPage1.Controls.Add(this.c1Chart3);
            this.tabPage1.Controls.Add(this.c1Chart5);
            this.tabPage1.Controls.Add(this.c1Chart6);
            this.tabPage1.Controls.Add(this.c1Chart4);
            this.tabPage1.Controls.Add(this.c1Chart7);
            this.tabPage1.Controls.Add(this.c1Chart8);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(662, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "2D Charts";
            // 
            // c1Chart1
            // 
            this.c1Chart1.Location = new System.Drawing.Point(10, 9);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(182, 176);
            this.c1Chart1.TabIndex = 0;
            // 
            // c1Chart2
            // 
            this.c1Chart2.Location = new System.Drawing.Point(192, 9);
            this.c1Chart2.Name = "c1Chart2";
            this.c1Chart2.PropBag = resources.GetString("c1Chart2.PropBag");
            this.c1Chart2.Size = new System.Drawing.Size(182, 176);
            this.c1Chart2.TabIndex = 0;
            // 
            // c1Chart3
            // 
            this.c1Chart3.Location = new System.Drawing.Point(374, 9);
            this.c1Chart3.Name = "c1Chart3";
            this.c1Chart3.PropBag = resources.GetString("c1Chart3.PropBag");
            this.c1Chart3.Size = new System.Drawing.Size(183, 176);
            this.c1Chart3.TabIndex = 0;
            // 
            // c1Chart5
            // 
            this.c1Chart5.Location = new System.Drawing.Point(10, 194);
            this.c1Chart5.Name = "c1Chart5";
            this.c1Chart5.PropBag = resources.GetString("c1Chart5.PropBag");
            this.c1Chart5.Size = new System.Drawing.Size(182, 175);
            this.c1Chart5.TabIndex = 0;
            // 
            // c1Chart6
            // 
            this.c1Chart6.Location = new System.Drawing.Point(192, 194);
            this.c1Chart6.Name = "c1Chart6";
            this.c1Chart6.PropBag = resources.GetString("c1Chart6.PropBag");
            this.c1Chart6.Size = new System.Drawing.Size(182, 175);
            this.c1Chart6.TabIndex = 0;
            // 
            // c1Chart4
            // 
            this.c1Chart4.Location = new System.Drawing.Point(374, 194);
            this.c1Chart4.Name = "c1Chart4";
            this.c1Chart4.PropBag = resources.GetString("c1Chart4.PropBag");
            this.c1Chart4.Size = new System.Drawing.Size(183, 175);
            this.c1Chart4.TabIndex = 0;
            // 
            // c1Chart7
            // 
            this.c1Chart7.Location = new System.Drawing.Point(557, 194);
            this.c1Chart7.Name = "c1Chart7";
            this.c1Chart7.PropBag = resources.GetString("c1Chart7.PropBag");
            this.c1Chart7.Size = new System.Drawing.Size(182, 175);
            this.c1Chart7.TabIndex = 0;
            // 
            // c1Chart8
            // 
            this.c1Chart8.Location = new System.Drawing.Point(557, 9);
            this.c1Chart8.Name = "c1Chart8";
            this.c1Chart8.PropBag = resources.GetString("c1Chart8.PropBag");
            this.c1Chart8.Size = new System.Drawing.Size(182, 176);
            this.c1Chart8.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.c1Chart3D1);
            this.tabPage2.Controls.Add(this.c1Chart3D2);
            this.tabPage2.Controls.Add(this.c1Chart3D3);
            this.tabPage2.Controls.Add(this.c1Chart3D4);
            this.tabPage2.Controls.Add(this.c1Chart3D6);
            this.tabPage2.Controls.Add(this.c1Chart3D5);
            this.tabPage2.Controls.Add(this.c1Chart3D7);
            this.tabPage2.Controls.Add(this.c1Chart3D8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(761, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "3D Charts";
            // 
            // c1Chart3D1
            // 
            this.c1Chart3D1.Location = new System.Drawing.Point(10, 9);
            this.c1Chart3D1.Name = "c1Chart3D1";
            this.c1Chart3D1.PropBag = resources.GetString("c1Chart3D1.PropBag");
            this.c1Chart3D1.Size = new System.Drawing.Size(182, 176);
            this.c1Chart3D1.TabIndex = 0;
            // 
            // c1Chart3D2
            // 
            this.c1Chart3D2.Location = new System.Drawing.Point(192, 9);
            this.c1Chart3D2.Name = "c1Chart3D2";
            this.c1Chart3D2.PropBag = resources.GetString("c1Chart3D2.PropBag");
            this.c1Chart3D2.Size = new System.Drawing.Size(182, 176);
            this.c1Chart3D2.TabIndex = 0;
            // 
            // c1Chart3D3
            // 
            this.c1Chart3D3.Location = new System.Drawing.Point(374, 9);
            this.c1Chart3D3.Name = "c1Chart3D3";
            this.c1Chart3D3.PropBag = resources.GetString("c1Chart3D3.PropBag");
            this.c1Chart3D3.Size = new System.Drawing.Size(183, 176);
            this.c1Chart3D3.TabIndex = 0;
            // 
            // c1Chart3D4
            // 
            this.c1Chart3D4.Location = new System.Drawing.Point(10, 194);
            this.c1Chart3D4.Name = "c1Chart3D4";
            this.c1Chart3D4.PropBag = resources.GetString("c1Chart3D4.PropBag");
            this.c1Chart3D4.Size = new System.Drawing.Size(182, 175);
            this.c1Chart3D4.TabIndex = 0;
            // 
            // c1Chart3D6
            // 
            this.c1Chart3D6.Location = new System.Drawing.Point(192, 194);
            this.c1Chart3D6.Name = "c1Chart3D6";
            this.c1Chart3D6.PropBag = resources.GetString("c1Chart3D6.PropBag");
            this.c1Chart3D6.Size = new System.Drawing.Size(182, 175);
            this.c1Chart3D6.TabIndex = 0;
            // 
            // c1Chart3D5
            // 
            this.c1Chart3D5.Location = new System.Drawing.Point(374, 194);
            this.c1Chart3D5.Name = "c1Chart3D5";
            this.c1Chart3D5.PropBag = resources.GetString("c1Chart3D5.PropBag");
            this.c1Chart3D5.Size = new System.Drawing.Size(183, 175);
            this.c1Chart3D5.TabIndex = 0;
            // 
            // c1Chart3D7
            // 
            this.c1Chart3D7.Location = new System.Drawing.Point(557, 9);
            this.c1Chart3D7.Name = "c1Chart3D7";
            this.c1Chart3D7.PropBag = resources.GetString("c1Chart3D7.PropBag");
            this.c1Chart3D7.Size = new System.Drawing.Size(182, 176);
            this.c1Chart3D7.TabIndex = 0;
            // 
            // c1Chart3D8
            // 
            this.c1Chart3D8.Location = new System.Drawing.Point(557, 194);
            this.c1Chart3D8.Name = "c1Chart3D8";
            this.c1Chart3D8.PropBag = resources.GetString("c1Chart3D8.PropBag");
            this.c1Chart3D8.Size = new System.Drawing.Size(182, 175);
            this.c1Chart3D8.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create PDF";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _c1pdf
            // 
            this._c1pdf.Security.OwnerPassword = "foobar";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(182, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 18);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(689, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Charts in PDF";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart8)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart3D8)).EndInit();
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
			// start document
			_c1pdf.Clear();
            _c1pdf.Security.AllowPrint = false;
            //_c1pdf.Security.UserPassword = "foobar";
            //_c1pdf.Landscape = true;

			// build page and chart rectangles
			RectangleF rcPage = _c1pdf.PageRectangle;
			rcPage.Inflate(-60, -72);
			rcPage.X = 72;
			RectangleF rcChart = new RectangleF(rcPage.X, rcPage.Y, 160, 160);

			// show title
			Font font = new Font("Tahoma", 16, FontStyle.Bold);
			string text = "Pdf charts created with the C1Chart control.";
			RectangleF rc = rcPage;
			rc.Y = rcPage.Y - 24;
			_c1pdf.DrawString(text, font, Brushes.DarkGray, rc);

			// scan controls on the selected tab page and render charts
			foreach (Control c in tabControl1.SelectedTab.Controls)
			{
				// skip invisible controls
				if (!c.Visible) continue;

				// get chart control
				C1.Win.C1Chart.C1Chart     c2d = c as C1.Win.C1Chart.C1Chart;
				C1.Win.C1Chart3D.C1Chart3D c3d = c as C1.Win.C1Chart3D.C1Chart3D;

				// get metafile from chart control
				label1.Text = string.Format("Getting image from {0}...", c.Name);
				label1.Update();
				Metafile meta = null;
				if (c2d != null) meta = (Metafile)c2d.GetImage();
				if (c3d != null) meta = (Metafile)c3d.GetImage();

				// make sure we got the metafile
				if (meta == null) continue;

				// draw it, frame it, and move on
				label1.Text = string.Format("Exporting {0}...", c.Name);
				label1.Update();
				_c1pdf.DrawImage(meta, rcChart);
				_c1pdf.DrawRectangle(Pens.SteelBlue, rcChart);
				rcChart = NextChartRect(rcChart, rcPage);
			}
			label1.Text = string.Empty;

			// save document and show it
			string tempdir = Application.ExecutablePath.Substring(0,
				Application.ExecutablePath.LastIndexOf("\\")+1);
			string fileName = string.Format(tempdir + @"{0}.pdf", tabControl1.SelectedTab.Text);
			_c1pdf.Save(fileName);
			Process.Start(fileName);
		}

		// update chart rectangle
		RectangleF NextChartRect(RectangleF rc, RectangleF rcPage)
		{
			// move to the right
			rc.Offset(rc.Width+6, 0);

			// wrap to next line
			if (rc.Right > rcPage.Right)
			{
				rc.X = rcPage.X;
				rc.Offset(0, rc.Height+6);
			}

			// wrap to next page
			if (rc.Bottom > rcPage.Bottom)
			{
				_c1pdf.NewPage();
				rc.Location = rcPage.Location;
			}

			// done
			return rc;
		}
	}
}
