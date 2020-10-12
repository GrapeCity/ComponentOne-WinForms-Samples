using System;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.C1Pdf;

namespace ManualSamples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Hello World";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 32);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 24);
			this.button2.TabIndex = 0;
			this.button2.Text = "StringFormat";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(8, 56);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(152, 24);
			this.button3.TabIndex = 0;
			this.button3.Text = "DrawStringRTF";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(8, 80);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(152, 24);
			this.button4.TabIndex = 0;
			this.button4.Text = "DrawImage";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(168, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(8, 104);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(152, 24);
			this.button5.TabIndex = 0;
			this.button5.Text = "Graphics";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(8, 128);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(152, 24);
			this.button6.TabIndex = 0;
			this.button6.Text = "RTF Directory";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(8, 152);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(152, 24);
			this.button7.TabIndex = 0;
			this.button7.Text = "Landscape";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(8, 176);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(152, 24);
			this.button8.TabIndex = 0;
			this.button8.Text = "Links";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(8, 200);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(152, 24);
			this.button9.TabIndex = 0;
			this.button9.Text = "DrawArc";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(168, 144);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(344, 216);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(8, 224);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(152, 24);
			this.button10.TabIndex = 0;
			this.button10.Text = "DrawBezier";
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(8, 248);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(152, 24);
			this.button11.TabIndex = 0;
			this.button11.Text = "DrawBeziers";
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(8, 272);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(152, 24);
			this.button12.TabIndex = 0;
			this.button12.Text = "DrawImage again";
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(312, 8);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(16, 16);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(8, 296);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(152, 24);
			this.button13.TabIndex = 0;
			this.button13.Text = "DrawLine";
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(8, 320);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(152, 24);
			this.button14.TabIndex = 0;
			this.button14.Text = "DrawLines";
			this.button14.Click += new System.EventHandler(this.button14_Click);
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(8, 344);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(152, 24);
			this.button15.TabIndex = 0;
			this.button15.Text = "DrawPie";
			this.button15.Click += new System.EventHandler(this.button15_Click);
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(8, 368);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(152, 24);
			this.button16.TabIndex = 0;
			this.button16.Text = "DrawPolygon";
			this.button16.Click += new System.EventHandler(this.button16_Click);
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(8, 392);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(152, 24);
			this.button17.TabIndex = 0;
			this.button17.Text = "DrawRectangle";
			this.button17.Click += new System.EventHandler(this.button17_Click);
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(8, 416);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(152, 24);
			this.button18.TabIndex = 0;
			this.button18.Text = "DrawString";
			this.button18.Click += new System.EventHandler(this.button18_Click);
			// 
			// button19
			// 
			this.button19.Location = new System.Drawing.Point(168, 368);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(152, 24);
			this.button19.TabIndex = 0;
			this.button19.Text = "DrawStringRTF";
			this.button19.Click += new System.EventHandler(this.button19_Click);
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(168, 392);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(152, 24);
			this.button20.TabIndex = 0;
			this.button20.Text = "MeasureString";
			this.button20.Click += new System.EventHandler(this.button20_Click);
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(168, 416);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(152, 24);
			this.button21.TabIndex = 0;
			this.button21.Text = "Insert";
			this.button21.Click += new System.EventHandler(this.button21_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pictureBox1,
																		  this.button1,
																		  this.button2,
																		  this.button3,
																		  this.button4,
																		  this.button5,
																		  this.button6,
																		  this.button7,
																		  this.button8,
																		  this.button9,
																		  this.pictureBox2,
																		  this.button10,
																		  this.button11,
																		  this.button12,
																		  this.pictureBox3,
																		  this.button13,
																		  this.button14,
																		  this.button15,
																		  this.button16,
																		  this.button17,
																		  this.button18,
																		  this.button19,
																		  this.button20,
																		  this.button21});
			this.Name = "Form1";
			this.Text = "Form1";
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

		string tempdir = Application.ExecutablePath.Substring(0,
			Application.ExecutablePath.LastIndexOf("\\")+1);

		private void button1_Click(object sender, System.EventArgs e)
		{
			// step 1: create the C1PdfDocument object
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// step 2: add content to the page
			Font font = new Font("Arial", 12);
			RectangleF rc = pdf.PageRectangle;
			rc.Inflate(-72, -72);
			pdf.DrawString("Hello World!", font, Brushes.Black, rc);

			// step 3: save the document to a file
			string fileName = tempdir + "hello world.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// step 1: create the C1PdfDocument object
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// step 2: add content to the page
			Font font = new Font("Arial", 12);
			RectangleF rc = new RectangleF(72, 72, 100, 50);
			string text = "Some long string to be rendered into a small rectangle. ";
			text = text + text + text + text + text + text;

			// center align and clip string
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;
			//sf.FormatFlags |= StringFormatFlags.NoClip;

			pdf.DrawString(text, font, Brushes.Black, rc, sf);
			pdf.DrawRectangle(Pens.Gray, rc);

			using (Graphics g = this.CreateGraphics())
			{
				g.PageUnit = GraphicsUnit.Point;
				g.DrawString(text, font, Brushes.Black, rc, sf);
				g.DrawRectangle(Pens.Gray, Rectangle.Truncate(rc));
			}

			// step 3: save the document to a file
			string fileName = tempdir + "hello world.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			// step 1: create the C1PdfDocument object
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// step 2: add content to the page
			Font font = new Font("Arial", 12);
			RectangleF rc = pdf.PageRectangle;
			rc.Inflate(-72, -72);
			pdf.DrawStringRtf(@"To {\b boldly} go where {\i no one} has gone before!", font, Brushes.Black, rc);

			// step 3: save the document to a file
			string fileName = tempdir + "hello world.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			// step 1: create the C1PdfDocument object
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// step 2: add content to the page
			Font font = new Font("Arial", 12);
			RectangleF rc = pdf.PageRectangle;
			rc.Inflate(-72, -72);

			// stretch image to fill the rectangle
			pdf.DrawImage(pictureBox1.Image, rc);

			// center image within the rectangle, scale keeping aspect ratio
			pdf.DrawImage(pictureBox1.Image, rc, ContentAlignment.MiddleCenter, C1.C1Pdf.ImageSizeModeEnum.Scale);

			// center image within the rectangle, keep original size
			pdf.DrawImage(pictureBox1.Image, rc, ContentAlignment.TopLeft, C1.C1Pdf.ImageSizeModeEnum.Clip);

			// step 3: save the document to a file
			string fileName = tempdir + "hello world.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			// create pdf document
			C1.C1Pdf.C1PdfDocument g = new C1.C1Pdf.C1PdfDocument();

			// set up to draw
			Rectangle rc = new Rectangle(0,0,300,200);
			string text = "Hello world of .NET Graphics and PDF.\r\nNice to meet you.";
			Font font = new Font("Times New Roman", 12, FontStyle.Italic | FontStyle.Underline);
			PointF[] bezierpts = new PointF[]
			{
				new PointF(10f, 100f), new PointF(20f, 10f),  new PointF(35f, 50f),
				new PointF(50f, 100f), new PointF(60f, 150f), new PointF(65f, 100f),
				new PointF(50f, 50f)
			};

			// draw to pdf document
			int penWidth = 0;
			int penRGB = 0;
			g.FillPie(Brushes.Red,   rc,   0, 20f);
			g.FillPie(Brushes.Green, rc, 20f, 30f);
			g.FillPie(Brushes.Blue,  rc, 60f, 12f);
			g.FillPie(Brushes.Gold, rc, -80f, -20f);
			for (float startAngle = 0; startAngle < 360; startAngle += 40)
			{
				Color penColor = Color.FromArgb(penRGB, penRGB, penRGB);
				Pen pen = new Pen(penColor, penWidth++);
				penRGB = penRGB + 20;
				g.DrawArc(pen, rc, startAngle, 40f);
			}
			g.DrawRectangle(Pens.Red, rc);
			g.DrawBeziers(Pens.Blue, bezierpts);
			g.DrawString(text, font, Brushes.Black, rc);

			// show it
			string fileName = tempdir + "graphics.pdf";
			g.Save(fileName);
			System.Diagnostics.Process.Start(fileName);

		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			// get rtf template
			string rtfHdr = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033" +
				@"{\fonttbl{\f0\fswiss\fcharset0 Arial;}{\f1\froman\fprq2\fcharset0 Book Antiqua;}}" +
				@"{\colortbl ;\red0\green0\blue0;}\viewkind4\uc1\pard\f0\fs20\par" +
				@"\pard\tx1440\tx2880\tx4320\tx5760\cf1\b\f1\fs24 Directory Report created on <<TODAY>>\par" +
				@"\ul\par Name\tab Extension\tab Size\tab Date\tab Attributes\par";
			string rtfEntry = @"\cf0\ulnone\b0\f0\fs16 <<NAME>>\tab <<EXT>>\tab <<SIZE>>\tab <<DATE>>\tab <<ATTS>>\par";

			// build rtf string
			StringBuilder sb = new StringBuilder();
			sb.Append(rtfHdr.Replace("<<TODAY>>", DateTime.Today.ToShortDateString()));
            foreach (string file in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "*.bmp"))
			{
				string s = rtfEntry;
				FileInfo fi = new FileInfo(file);
				s = s.Replace("<<NAME>>", Path.GetFileNameWithoutExtension(file));
				s = s.Replace("<<EXT>>",  fi.Extension);
				s = s.Replace("<<SIZE>>", string.Format("{0:#,##0}", fi.Length));
				s = s.Replace("<<DATE>>", fi.LastWriteTime.ToShortDateString());
				s = s.Replace("<<ATTS>>", fi.Attributes.ToString());
				sb.Append(s);
			}
			sb.Append("}");

			// render it
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();
			RectangleF rc = pdf.PageRectangle;
			rc.Inflate(-72, -72);
			pdf.DrawStringRtf(sb.ToString(), Font, Brushes.Black, rc);

			// save and show
			string fileName = tempdir + "dir.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			// initialize
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();
			Font font = new Font("Arial", 12);

			// create a 10 page document, make page 5 landscape
			for (int i = 0; i < 10; i++)
			{
				if (i > 0) pdf.NewPage();
				pdf.Landscape = (i == 4);

				RectangleF rc = pdf.PageRectangle;
				rc.Inflate(-72, -72);
				pdf.DrawString("Hello", font, Brushes.Black, rc);
				pdf.DrawRectangle(Pens.Black, rc);
			}

			// save and show
			string fileName = tempdir + "landscape.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			// initialize
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// create a regular (external) hyperlink 
			RectangleF rc = new RectangleF(50, 50, 200, 15);
			Font font = new Font("Arial", 10, FontStyle.Underline);
			pdf.AddLink("http://www.componentone.com", rc);
			pdf.DrawString("Visit ComponentOne", font, Brushes.Blue, rc);

			// create a link target
			pdf.AddTarget("#myLink", rc);

			// add a few pages
			for (int i = 0; i < 5; i++)
				pdf.NewPage();

			// add a link to the target
			pdf.AddLink("#myLink", rc);
			pdf.FillRectangle(Brushes.BlanchedAlmond, rc);
			pdf.DrawString("Local link: back to page 1...", font, Brushes.Blue, rc);

			// save and show
			string fileName = tempdir + "links.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			// initialize
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			RectangleF rc = new RectangleF(0, 0, 200, 180);

			pdf.DrawEllipse(Pens.Gray, rc);
			pdf.DrawArc(new Pen(Color.Black, 4), rc, 0,  45);
			pdf.DrawArc(new Pen(Color.Red,   4), rc, 0, -45);

			string fileName = tempdir + "arc.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);

			Bitmap bmp = new Bitmap(pictureBox2.Size.Width, pictureBox2.Size.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.PageUnit = GraphicsUnit.Point;
				g.DrawEllipse(Pens.Gray, rc);
				g.DrawArc(new Pen(Color.Black, 4), rc, 0,  45);
				g.DrawArc(new Pen(Color.Red,   4), rc, 0, -45);
			}
			this.pictureBox2.Image = bmp;

		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			// initialize
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// create points
			PointF[] pts = new PointF[]
			{
				new PointF(100, 100), new PointF(120,  30),
				new PointF(200, 140), new PointF(230,  20),
			};

			// draw Bezier spline
			pdf.DrawBezier(new Pen(Color.Blue, 4), pts[0], pts[1], pts[2], pts[3]);

			// show points
			pdf.DrawLines(Pens.Gray, pts);
			foreach (PointF pt in pts)
				pdf.DrawRectangle(Pens.Red, pt.X-2, pt.Y-2, 4, 4);

			string fileName = tempdir + "bezier.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button11_Click(object sender, System.EventArgs e)
		{
			// initialize
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// create points
			PointF[] pts = new PointF[]
			{
				new PointF( 50f, 100f), new PointF(100f, 10f),  new PointF(250f, 50f),
				new PointF(400f, 100f), new PointF(500f, 150f), new PointF(550f, 250f),
				new PointF(400f, 300f)
			};

			// draw Bezier spline
			pdf.DrawBeziers(new Pen(Color.Blue, 4), pts);

			// show points
			pdf.DrawLines(Pens.Gray, pts);
			for (int i = 0; i < pts.Length; i++)
			{
				Brush brush = (i % 3 == 0)? Brushes.Red: Brushes.Green;
				pdf.FillRectangle(brush, pts[i].X-2, pts[i].Y-2, 4, 4);
			}

			// save document
			string fileName = tempdir + "beziers.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button12_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();
			Image img = pictureBox3.Image;

			
			// stretch image to fill the rectangle
			Rectangle rc = new Rectangle(100,100,50,30);
			pdf.DrawImage(img, rc);
			pdf.DrawRectangle(Pens.Black, rc);

			// render in actual size, clipping if necessary
			rc.Offset(rc.Width+20, 0);
			pdf.DrawImage(img, rc, ContentAlignment.MiddleLeft, ImageSizeModeEnum.Clip);
			pdf.DrawRectangle(Pens.Black, rc);

			// scale the image to fit the rectangle while preserving the aspect ratio
			rc.Offset(rc.Width+20, 0);
			pdf.DrawImage(img, rc, ContentAlignment.MiddleLeft, ImageSizeModeEnum.Scale);
			pdf.DrawRectangle(Pens.Black, rc);

			// step 3: save the document to a file
			string fileName = tempdir + "images.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button13_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();
			
			// create a thin (hairline) black pen
			Pen thinPen = new Pen(Color.Black, 0);

			// create a thick (3pt) blue pen
			Pen thickPen = new Pen(Color.Blue, 3);

			// create a thick (2pt) dotted red pen
			Pen dotPen = new Pen(Color.Red, 2);
			dotPen.DashStyle = DashStyle.Dot;

			// draw some lines
			pdf.DrawLine(thinPen,  100, 100, 300, 100);
			pdf.DrawLine(thickPen, 100, 120, 300, 120);
			pdf.DrawLine(dotPen,   100, 140, 300, 140);

			// save the document to a file
			string fileName = tempdir + "drawline.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button14_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// create some points
			PointF[] points = new PointF[20];
			Random rnd = new Random();
			for (int i = 0; i < points.Length; i++)
				points[i] = new PointF(rnd.Next(100, 500), rnd.Next(100, 200));

			// draw lines
			pdf.DrawLines(Pens.Black, points);

			// show points
			foreach (PointF pt in points)
				pdf.DrawRectangle(Pens.Red, pt.X-3, pt.Y-3, 6, 6);

			// save the document to a file
			string fileName = tempdir + "drawlines.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button15_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// create an array with some brushes
			Brush[] brushes = new Brush[]
			{ 
				Brushes.Red, Brushes.Green, Brushes.Blue, 
				Brushes.Yellow, Brushes.Crimson, Brushes.Aquamarine
			};

			// setup rectangle and initialize angles
			RectangleF rc = new RectangleF(100,100,180,150);
			float startAngle = 0;
			float sweepAngle = -90; // << counter-clockwise

			// draw pie
			foreach (Brush brush in brushes)
			{
				pdf.FillPie(brush, rc, startAngle, sweepAngle);
				pdf.DrawPie(Pens.Black, rc, startAngle, sweepAngle);
				startAngle += sweepAngle;
				sweepAngle /= 2;
			}

			// save the document to a file
			string fileName = tempdir + "drawpie.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button16_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// create an array with some points
			PointF[] points = new PointF[]
			{ 
				new PointF(100, 100), new PointF(300, 100), new PointF(200, 200)
			};

			// fill and draw a polygon
			pdf.FillPolygon(Brushes.Beige, points);
			pdf.DrawPolygon(Pens.Black, points);

			// save the document to a file
			string fileName = tempdir + "poly.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button17_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// create a rectangle
			RectangleF rc = new RectangleF(100,100,200,150);

			// draw and fill rectangles with round corners
			for (int corner = 10; corner < 100; corner += 20)
			{
				SizeF sz = new SizeF(corner, corner/2);
				pdf.FillRectangle(Brushes.Beige, rc, sz);
				pdf.DrawRectangle(Pens.Blue, rc, sz);
			}

			// draw a regular rectangle
			pdf.DrawRectangle(Pens.Black, rc);

			// save the document to a file
			string fileName = tempdir + "rect.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button18_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// set up to draw
			Font font = new Font("Tahoma", 14);
			RectangleF rc = new RectangleF(100,100,150,28);

			// draw string using default options (left-top alignment, no clipping)
			string text = "This string is being rendered using the default options.";
			pdf.DrawString(text, font, Brushes.Black, rc);
			pdf.DrawRectangle(Pens.Black, rc);

			// create StringFormat to center align and clip
			StringFormat sf  = new StringFormat();
			sf.Alignment     =  StringAlignment.Center;
			sf.LineAlignment =  StringAlignment.Center;
			sf.FormatFlags	&= ~StringFormatFlags.NoClip;

			// render again using custom options
			rc.Offset(0, rc.Height + 30);
			text = "This string is being rendered using custom options.";
			pdf.DrawString(text, font, Brushes.Black, rc, sf);
			pdf.DrawRectangle(Pens.Black, rc);

			// save the document to a file
			string fileName = tempdir + "string.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button19_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// set up to draw
			Font font = new Font("Tahoma", 14);
			RectangleF rc = new RectangleF(100,100,300,28);

			// measure RTF text and adjust the rectangle to fit
			string text = @"Short {\b RTF} snippet with some {\b bold} and some {\i italics} in it.";
			rc.Y = rc.Bottom + 12;
			rc.Height = pdf.MeasureStringRtf(text, font, rc.Width).Height;

			// render RTF snippet
			pdf.DrawStringRtf(text, font, Brushes.Blue, rc);
			pdf.DrawRectangle(Pens.Black, rc);

			// save the document to a file
			string fileName = tempdir + "rtf.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button20_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// set up to draw
			string text = "We all came down to Montreux, by the Lake Geneva shoreline.";
			Font font = new Font("Tahoma", 12);
			RectangleF rc = new RectangleF(100,100,0,0);

			// measure text on a single line
			rc.Size = pdf.MeasureString(text, font);
			pdf.DrawString(text, font, Brushes.Black, rc);
			pdf.DrawRectangle(Pens.LightGray, rc);

			// update rectangle for next sample
			rc.Y = rc.Bottom + 12;
			rc.Width = 120;

			// measure text that wraps
			rc.Size = pdf.MeasureString(text, font, rc.Width);
			pdf.DrawString(text, font, Brushes.Black, rc);
			pdf.DrawRectangle(Pens.LightGray, rc);

			// save the document to a file
			string fileName = tempdir + "measure.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}

		private void button21_Click(object sender, System.EventArgs e)
		{
			C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

			// set up to draw
			Font font = new Font("Tahoma", 12);
			RectangleF rc = pdf.PageRectangle;
			rc.Inflate(-72, -72);

			// create document with 5 numbered pages
			for (int i = 0; i < 5; i++)
			{
				if (i > 0) pdf.NewPage();
				pdf.DrawString("Page " + i.ToString(), font, Brushes.Black, rc);
				pdf.DrawRectangle(Pens.LightGray, rc);
			}

			// move the last page to the front of the document
			PdfPage last = pdf.Pages[pdf.Pages.Count-1];
			pdf.Pages.Remove(last);
			pdf.Pages.Insert(0, last);

			// save the document to a file
			string fileName = tempdir + "pages.pdf";
			pdf.Save(fileName);
			System.Diagnostics.Process.Start(fileName);
		}
	}
}
