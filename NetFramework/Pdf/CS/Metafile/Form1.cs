using System;
using System.Reflection;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Meta
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Pdf.C1PdfDocument _c1pdf;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.StatusBar statusBar1;
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
			this._c1pdf = new C1.C1Pdf.C1PdfDocument();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button4 = new System.Windows.Forms.Button();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Show all Metafiles";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(168, 24);
			this.button2.TabIndex = 0;
			this.button2.Text = "RTF text";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(8, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(168, 24);
			this.button3.TabIndex = 0;
			this.button3.Text = "Arcs and Pies";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(184, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(336, 424);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.IntegralHeight = false;
			this.listBox1.Location = new System.Drawing.Point(8, 128);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(168, 304);
			this.listBox1.TabIndex = 2;
			this.listBox1.DoubleClick += new System.EventHandler(this.button4_Click);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(8, 104);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(168, 24);
			this.button4.TabIndex = 0;
			this.button4.Text = "Show selected Metafile";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 431);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(528, 22);
			this.statusBar1.TabIndex = 3;
			this.statusBar1.Text = "Ready";
			// 
			// Form1
			// 
			this.AcceptButton = this.button4;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button4,
																		  this.listBox1,
																		  this.pictureBox1,
																		  this.button1,
																		  this.button2,
																		  this.button3,
																		  this.statusBar1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Pdf Advanced features";
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

		//=============================================================================
		// populate list with emf files in the executable directory
		private void Form1_Load(object sender, System.EventArgs e)
		{
			string path = Path.GetDirectoryName(Application.ExecutablePath);
			foreach (string fileName in Directory.GetFiles(path, "*.emf"))
				listBox1.Items.Add(Path.GetFileName(fileName));
		}

		//=============================================================================
		// create a document with lots of metafiles in it
		private void button1_Click(object sender, System.EventArgs e)
		{
			DumpMetas("*.emf");
		}
		private void button4_Click(object sender, System.EventArgs e)
		{
			if (listBox1.SelectedItem != null)
				DumpMetas(listBox1.SelectedItem.ToString());
		}
		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string path = Path.GetDirectoryName(Application.ExecutablePath);
			pictureBox1.Image = Metafile.FromFile(path + "\\" + listBox1.SelectedItem.ToString());
		}

		string tempdir = Application.ExecutablePath.Substring(0,
			Application.ExecutablePath.LastIndexOf("\\")+1);

		private void DumpMetas(string mask)
		{
			Cursor = Cursors.WaitCursor;

			_c1pdf.Clear();
			_c1pdf.Compression = C1.C1Pdf.CompressionEnum.None;
			//_c1pdf.Compression = C1.C1Pdf.CompressionEnum.BestCompression;
			Random rnd = new Random();
			Font font = new Font("Courier New", 9, FontStyle.Bold);

			// look for emf files in the executable directory
			string path = Path.GetDirectoryName(Application.ExecutablePath);
			bool first = true;
			string[] files = Directory.GetFiles(path, mask);
			foreach (string fileName in files)
			{
				statusBar1.Text = string.Format("Exporting {0}...", Path.GetFileName(fileName));
				Application.DoEvents();

				// new page
				if (!first) _c1pdf.NewPage();
				first = false;

				// load metafile
				Metafile meta = (Metafile)Metafile.FromFile(fileName);

				// get metafile size in points
				SizeF szPage = GetImageSizeInPoints(meta);
				Console.WriteLine("Adding page {0:f2}\" x {1:f2}\"", szPage.Width/72f, szPage.Height/72f);

				// size page to metafile
				_c1pdf.PageSize = szPage;

				// draw metafile on the page
				RectangleF rc = _c1pdf.PageRectangle;
				_c1pdf.FillRectangle(Brushes.AntiqueWhite, rc);
				_c1pdf.DrawImage(meta, rc);
				_c1pdf.DrawString(fileName, font, Brushes.Black, rc);

				// draw thumbnail at random place
				rc.Width  /= 5;
				rc.Height /= 5;
				rc.X = rnd.Next((int)(szPage.Width  - rc.Width));
				rc.Y = rnd.Next((int)(szPage.Height - rc.Height));
				_c1pdf.FillRectangle(Brushes.White, rc);
				_c1pdf.DrawImage(meta, rc);
				_c1pdf.DrawRectangle(Pens.Black, rc);

				// add outline entry if there's more than one page
				if (files.Length > 1)
					_c1pdf.AddBookmark(Path.GetFileName(fileName), 0, 0);
			}

			// show the result
			statusBar1.Text = "Saving...";
			SaveAndShow(tempdir + "metas.pdf");
			Cursor = Cursors.Default;
			statusBar1.Text = "Ready";
		}

		//=============================================================================
		// create a document with some rtf in it
		private void button2_Click(object sender, System.EventArgs e)
		{
			_c1pdf.Clear();
			_c1pdf.PaperKind = PaperKind.Letter;
			_c1pdf.Compression = C1.C1Pdf.CompressionEnum.None;

			// load rtf
			StreamReader sr = new StreamReader(Application.StartupPath + @"\zip.rtf");
			string rtfText = sr.ReadToEnd();
			sr.Close();

			// render rtf onto the page as usual text
			RectangleF rc = _c1pdf.PageRectangle;
			rc.Inflate(-72, -72);
			_c1pdf.DrawStringRtf(rtfText, null, null, rc);
			_c1pdf.DrawRectangle(Pens.BlueViolet, rc);

			// render again on a new page
			_c1pdf.NewPage();
			rc = _c1pdf.PageRectangle;
			rc.X += 50; rc.Width  -= 180;
			rc.Y += 50; rc.Height -= 180;

			// this time measure the text first and adjust the height of the
			// rectangle to fit exactly.
			rc.Size = _c1pdf.MeasureStringRtf(rtfText, null, rc.Width);
			_c1pdf.DrawStringRtf(rtfText, null, null, rc);
			_c1pdf.DrawRectangle(Pens.BlueViolet, rc);

			// done
			SaveAndShow(tempdir + "rtf.pdf");
		}

		//=============================================================================
		// test arcs and pies
		private void button3_Click(object sender, System.EventArgs e)
		{
			_c1pdf.Clear();
			_c1pdf.Compression = C1.C1Pdf.CompressionEnum.None;

			int penWidth = 0;
			int penRGB = 0;
			Rectangle rc = new Rectangle(0,0,300,200);

			string text = "Hello world of .NET Graphics and PDF.\r\nNice to meet you.";
			Font font = new Font("Times New Roman", 12, FontStyle.Italic | FontStyle.Underline);

			// start, c1, c2, end1, c3, c4, end
			PointF[] bezierPoints = new PointF[]
			{
				new PointF(10f, 100f), new PointF(20f, 10f),  new PointF(35f, 50f),
				new PointF(50f, 100f), new PointF(60f, 150f), new PointF(65f, 100f),
				new PointF(50f, 50f)
			};

			// draw to .NET Graphics object
			Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
				g.FillPie(Brushes.Red,   rc,   0, 20f);
				g.FillPie(Brushes.Green, rc, 20f, 30f);
				g.FillPie(Brushes.Blue,  rc, 60f, 12f);
				g.FillPie(Brushes.Gold, rc, -80f, -20f);
				for (float sa = 0; sa < 360; sa += 40)
				{
					Color penColor = Color.FromArgb(penRGB, penRGB, penRGB);
					Pen pen = new Pen(penColor, penWidth++);
					penRGB = penRGB + 20;
					g.DrawArc(pen, rc, sa, 40f);
				}
				g.DrawRectangle(Pens.Red, rc);
				g.DrawBeziers(Pens.Blue, bezierPoints);
				g.DrawString(text, font, Brushes.Black, rc);
				g.Dispose();
			}
			this.pictureBox1.Image = bmp;
			this.pictureBox1.Refresh();

			// draw to pdf document
			penWidth = 0;
			penRGB = 0;
			if (true) 
			{
				C1.C1Pdf.C1PdfDocument g = _c1pdf;
				g.FillPie(Brushes.Red,   rc,   0, 20f);
				g.FillPie(Brushes.Green, rc, 20f, 30f);
				g.FillPie(Brushes.Blue,  rc, 60f, 12f);
				g.FillPie(Brushes.Gold, rc, -80f, -20f);
				for (float sa = 0; sa < 360; sa += 40)
				{
					Color penColor = Color.FromArgb(penRGB, penRGB, penRGB);
					Pen pen = new Pen(penColor, penWidth++);
					penRGB = penRGB + 20;
					g.DrawArc(pen, rc, sa, 40f);
				}
				g.DrawRectangle(Pens.Red, rc);
				g.DrawBeziers(Pens.Blue, bezierPoints);
				g.DrawString(text, font, Brushes.Black, rc);
			}

			// show pdf document
			SaveAndShow(tempdir + "arcpie.pdf");
		}

		// save current document and show it in Adobe Acrobat
		private void SaveAndShow(string fileName)
		{
			try
			{
				_c1pdf.Save(fileName);
				Process.Start(fileName);
			}
			catch
			{
				MessageBox.Show("Can't save, make sure the document is not open.");
			}
		}

		internal static SizeF GetImageSizeInPoints(Image img)
		{
			SizeF sz = SizeF.Empty;

			// PhysicalDimension returns himetric for Metafiles,
			// pixels for all other image types
			Metafile mf = img as Metafile;
			if (mf != null)
			{
				// always use 'logical' resolution of 96 dpi for display metafiles
				if (mf.GetMetafileHeader().IsDisplay())
				{
					sz.Width  = (float)Math.Round(img.Width  * 72f / 96f, 2);
					sz.Height = (float)Math.Round(img.Height * 72f / 96f, 2);
					return sz;
				}

				// other metafiles have PhysicalDimension stored in HiMetric
				sz = mf.PhysicalDimension;
				sz.Width  = (float)Math.Round(sz.Width  * 72f / 2540f, 2);
				sz.Height = (float)Math.Round(sz.Height * 72f / 2540f, 2);
				return sz;
			}

			// other images have the resolution stored in them
			sz.Height = (float)Math.Round(sz.Height * 72f / img.VerticalResolution, 2);
			sz.Width  = (float)Math.Round(sz.Width  * 72f / img.HorizontalResolution, 2);
			return sz;
		}
	}
}
