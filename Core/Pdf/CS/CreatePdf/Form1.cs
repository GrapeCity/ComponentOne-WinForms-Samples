using System;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Reflection;

using C1.Pdf;

using PaperKind = GrapeCity.Documents.Common.PaperKind;
using ImageSizeMode = C1.Util.ImageSizeMode;

namespace CreatePdf
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.StatusStrip status1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button10;
		private C1.Win.Pdf.C1PdfDocument _c1pdf;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button7;
		private ToolStripStatusLabel statusLabel1;

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
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            status1 = new StatusStrip();
            statusLabel1 = new ToolStripStatusLabel();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            button5 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            label6 = new Label();
            button8 = new Button();
            label8 = new Label();
            _c1pdf = new C1.Win.Pdf.C1PdfDocument();
            button9 = new Button();
            label9 = new Label();
            label10 = new Label();
            button10 = new Button();
            label7 = new Label();
            button7 = new Button();
            status1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(19, 20);
            button1.Name = "button1";
            button1.Size = new Size(326, 79);
            button1.TabIndex = 0;
            button1.Text = "Quotes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(365, 20);
            label1.Name = "label1";
            label1.Size = new Size(368, 79);
            label1.TabIndex = 1;
            label1.Text = "Create a document with quotations from www.quoteland.com. Shows DrawString, MeasureString, NewPage. (** requires web connection **)";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Location = new Point(19, 99);
            button2.Name = "button2";
            button2.Size = new Size(326, 78);
            button2.TabIndex = 0;
            button2.Text = "NorthWind Tables";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(365, 99);
            label2.Name = "label2";
            label2.Size = new Size(368, 78);
            label2.TabIndex = 1;
            label2.Text = "Create a document with NorthWind information. Shows how to do tables with indentation and alignment.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // status1
            // 
            status1.ImageScalingSize = new Size(24, 24);
            status1.Items.AddRange(new ToolStripItem[] { statusLabel1 });
            status1.Location = new Point(0, 606);
            status1.Name = "status1";
            status1.Size = new Size(757, 42);
            status1.SizingGrip = false;
            status1.TabIndex = 2;
            // 
            // statusLabel1
            // 
            statusLabel1.Name = "statusLabel1";
            statusLabel1.Size = new Size(83, 32);
            statusLabel1.Text = "Ready.";
            // 
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.Location = new Point(19, 177);
            button3.Name = "button3";
            button3.Size = new Size(326, 79);
            button3.TabIndex = 0;
            button3.Text = "Images";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(365, 177);
            label3.Name = "label3";
            label3.Size = new Size(368, 79);
            label3.TabIndex = 1;
            label3.Text = "Create a document with several images, saves into high and low-quality Pdfs. Shows the effect of the ImageQuality property.";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSteelBlue;
            button4.Location = new Point(19, 256);
            button4.Name = "button4";
            button4.Size = new Size(326, 79);
            button4.TabIndex = 0;
            button4.Text = "Image Alignment";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(365, 256);
            label4.Name = "label4";
            label4.Size = new Size(368, 79);
            label4.TabIndex = 1;
            label4.Text = "Create a document that shows more image alignment settings.";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSteelBlue;
            button5.Location = new Point(19, 335);
            button5.Name = "button5";
            button5.Size = new Size(326, 78);
            button5.TabIndex = 4;
            button5.Text = "Fonts, fonts";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = SystemColors.Control;
            label5.Location = new Point(365, 335);
            label5.Name = "label5";
            label5.Size = new Size(368, 78);
            label5.TabIndex = 1;
            label5.Text = "Create a document containing all fonts installed in the computer.";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSteelBlue;
            button6.Location = new Point(19, 413);
            button6.Name = "button6";
            button6.Size = new Size(326, 79);
            button6.TabIndex = 4;
            button6.Text = "Page Sizes";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = SystemColors.Control;
            label6.Location = new Point(365, 413);
            label6.Name = "label6";
            label6.Size = new Size(368, 79);
            label6.TabIndex = 1;
            label6.Text = "Create a document containing multiple page sizes and orientations.";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSteelBlue;
            button8.Location = new Point(19, 492);
            button8.Name = "button8";
            button8.Size = new Size(326, 79);
            button8.TabIndex = 4;
            button8.Text = "Table of Contents";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.BackColor = SystemColors.Control;
            label8.Location = new Point(365, 492);
            label8.Name = "label8";
            label8.Size = new Size(368, 79);
            label8.TabIndex = 1;
            label8.Text = "Create a document with a Table of Contents. Shows how to move pages within the document.";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _c1pdf
            // 
            _c1pdf.ClipRectPath = (RectangleF)resources.GetObject("_c1pdf.ClipRectPath");
            _c1pdf.CurrentFontIndex = 0;
            _c1pdf.CustomCallback = null;
            _c1pdf.DocumentInfo.Author = "";
            _c1pdf.DocumentInfo.CreationDate = new DateTime(0L);
            _c1pdf.DocumentInfo.Creator = "";
            _c1pdf.DocumentInfo.Keywords = "";
            _c1pdf.DocumentInfo.Producer = "ComponentOne C1Pdf";
            _c1pdf.DocumentInfo.Subject = "";
            _c1pdf.DocumentInfo.Title = "";
            _c1pdf.PathState = PdfPathState.None;
            _c1pdf.PdfVersion = "1.3";
            _c1pdf.RefDC = null;
            _c1pdf.RotateAngle = 0F;
            _c1pdf.StopPathClip = false;
            _c1pdf.UseFontShaping = true;
            _c1pdf.ViewerPreferences.DisplayDocTitle = false;
            _c1pdf.ViewerPreferences.Duplex = C1.Pdf.Duplex.Simplex;
            _c1pdf.ViewerPreferences.HideWindowUI = false;
            _c1pdf.ViewerPreferences.NonFullScreenPageMode = PageMode.UseNone;
            _c1pdf.ViewerPreferences.NumCopies = 0;
            _c1pdf.ViewerPreferences.PickTrayByPDFSize = null;
            _c1pdf.ViewerPreferences.PrintPageRange = "";
            _c1pdf.ViewerPreferences.PrintScaling = PrintScaling.AppDefault;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSteelBlue;
            button9.Location = new Point(19, 571);
            button9.Name = "button9";
            button9.Size = new Size(326, 78);
            button9.TabIndex = 4;
            button9.Text = "File Attachments";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.BackColor = SystemColors.Control;
            label9.Location = new Point(365, 571);
            label9.Name = "label9";
            label9.Size = new Size(368, 78);
            label9.TabIndex = 1;
            label9.Text = "Create a document with file attachments.";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = SystemColors.Control;
            label10.Location = new Point(365, 649);
            label10.Name = "label10";
            label10.Size = new Size(368, 79);
            label10.TabIndex = 1;
            label10.Text = "Shows how to flows text into columns and pages.";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button10
            // 
            button10.BackColor = Color.LightSteelBlue;
            button10.Location = new Point(19, 649);
            button10.Name = "button10";
            button10.Size = new Size(326, 79);
            button10.TabIndex = 4;
            button10.Text = "Text Flow";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = SystemColors.Control;
            label7.Location = new Point(365, 728);
            label7.Name = "label7";
            label7.Size = new Size(368, 80);
            label7.TabIndex = 1;
            label7.Text = "Shows how to position and align text (regular text and Rtf).";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSteelBlue;
            button7.Location = new Point(19, 728);
            button7.Name = "button7";
            button7.Size = new Size(326, 80);
            button7.TabIndex = 4;
            button7.Text = "Text Position";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleBaseSize = new Size(12, 32);
            ClientSize = new Size(757, 648);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(status1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(button8);
            Controls.Add(label8);
            Controls.Add(button9);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(button10);
            Controls.Add(label7);
            Controls.Add(button7);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C1Pdf Demo";
            Load += Form1_Load;
            status1.ResumeLayout(false);
            status1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

		private Random _rnd;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			_rnd = new Random();
		}

		[DefaultValue("")]
		internal string StatusText
		{
			get { return statusLabel1.Text; }
			set { statusLabel1.Text = value; }
		}

		//================================================================================
		// create document with quotations from www.quoteland.com
		//
		// shows how to render text with some formatting and how to handle page breaks.
		// this sample grabs content from the web, so it requires an active Internet
		// connection.
		//
		private void button1_Click(object sender, System.EventArgs e)
		{
			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = "Quotes from www.quoteland.com";
			StatusText = "Creating pdf document...";

			// get some content from the web
			ArrayList authorsQuotes = new ArrayList();
			try
			{
				// literary quotations
				GetContent(authorsQuotes, "http://www.quoteland.com/topic.asp?CATEGORY_ID=208");

				// 'no-topic' quotations
				GetContent(authorsQuotes, "http://www.quoteland.com/topic.asp?CATEGORY_ID=195");
			}
			catch
			{
				StatusText = "Failed to retrieve content from the web.";
				MessageBox.Show(StatusText);
				return;
			}

			// calculate page rect (discounting margins)
			RectangleF rcPage = GetPageRect();
			RectangleF rc = rcPage;

			// initialize output parameters
			Font hdrFont = new Font("Book Antiqua", 14, FontStyle.Bold);
			Font txtFont = new Font("Book Antiqua", 10, FontStyle.Italic);

			// add title
			Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
			rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rc);

			// build document
			string author = string.Empty;
			foreach (string s in authorsQuotes)
			{
				string[] authorQuote = s.Split('\t');
				
				// render header (author)
				if (author != authorQuote[0])
				{
					author = authorQuote[0];
					rc.Y += 20;
					rc = RenderParagraph(author, hdrFont, rcPage, rc, true);
				}
				
				// render body text (quote)
				string text = authorQuote[1];
				rc.X = rcPage.X + 36; // << indent body text by 1/2 inch
				rc.Width = rcPage.Width - 40;
				rc = RenderParagraph(text, txtFont, rcPage, rc);
				rc.X = rcPage.X; // << restore indent
				rc.Width = rcPage.Width;
				rc.Y += 12; // << add 12pt spacing after each quote
			}

			// second pass to number pages
			AddFooters();

			// save to file and show it
			StatusText = "Saving pdf document...";
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\quotes.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });
			StatusText = "Ready.";
		}

		// get the current page rectangle (depends on paper size)
		// and apply a 1" margin all around it.
		internal RectangleF GetPageRect()
		{
			RectangleF rcPage = _c1pdf.PageRectangle;
			rcPage.Inflate(-72, -72);
			return rcPage;
		}

		// measure a paragraph, skip a page if it won't fit, render it into a rectangle,
		// and update the rectangle for the next paragraph.
		// 
		// optionally mark the paragraph as an outline entry and as a link target.
		//
		// this routine will not break a paragraph across pages. for that, see the Text Flow sample.
		//
		internal RectangleF RenderParagraph(string text, Font font, RectangleF rcPage, RectangleF rc, bool outline, bool linkTarget)
		{
			// if it won't fit this page, do a page break
			rc.Height = _c1pdf.MeasureString(text, font, rc.Width).Height;
			if (rc.Bottom > rcPage.Bottom)
			{
				_c1pdf.NewPage();
				rc.Y = rcPage.Top;
			}

			// draw the string
			_c1pdf.DrawString(text, font, Brushes.Black, rc);

			// show bounds (mainly to check word wrapping)
			//_c1pdf.DrawRectangle(Pens.Sienna, rc);

			// add headings to outline
			if (outline)
			{
				_c1pdf.DrawLine(Pens.Black, rc.X, rc.Y, rc.Right, rc.Y);
				_c1pdf.AddBookmark(text, 0, rc.Y);
			}

			// add link target
			if (linkTarget)
			{
				_c1pdf.AddTarget(text, rc);
			}

			// update rectangle for next time
			rc.Offset(0, rc.Height);
			return rc;
		}
		internal RectangleF RenderParagraph(string text, Font font, RectangleF rcPage, RectangleF rc, bool outline)
		{
			return RenderParagraph(text, font, rcPage, rc, outline, false);
		}
		internal RectangleF RenderParagraph(string text, Font font, RectangleF rcPage, RectangleF rc)
		{
			return RenderParagraph(text, font, rcPage, rc, false, false);
		}

		//================================================================================
		// add page footers to a document
		//
		// this method is called by all samples in this project. it scans the document
		// and adds a 'page n of m' footer to each page. the footers are rendered as 
		// vertical text along the right edge of the document.
		//
		// adding content to an existing page is easy: just set the CurrentPage property
		// to point to an existing page and write into it as usual.
		//
		private void AddFooters()
		{
			Font fontHorz = new Font("Tahoma", 7, FontStyle.Bold);
			Font fontVert = new Font("Viner Hand ITC", 14, FontStyle.Bold);
			
			StringFormat sfRight = new StringFormat();
			sfRight.Alignment = StringAlignment.Far;

			StringFormat sfVert  = new StringFormat();
			sfVert.FormatFlags |= StringFormatFlags.DirectionVertical;
			sfVert.Alignment = StringAlignment.Center;

			for (int page = 0; page < _c1pdf.Pages.Count; page++)
			{
				// select page we want (could change PageSize)
				_c1pdf.CurrentPage = page;

				// build rectangles for rendering text
				RectangleF rcPage = GetPageRect();
				RectangleF rcFooter = rcPage;
				rcFooter.Y = rcFooter.Bottom + 6;
				rcFooter.Height = 12;
				RectangleF rcVert = rcPage;
				rcVert.X = rcPage.Right + 6;

				// add left-aligned footer
				string text = _c1pdf.DocumentInfo.Title;
				_c1pdf.DrawString(text, fontHorz, Brushes.Gray, rcFooter);

				// add right-aligned footer
				text = string.Format("Page {0} of {1}", page+1, _c1pdf.Pages.Count);
				_c1pdf.DrawString(text, fontHorz, Brushes.Gray, rcFooter, sfRight);

				// add vertical text
				text = _c1pdf.DocumentInfo.Title + " (document created using the C1Pdf .NET component)";
				_c1pdf.DrawString(text, fontVert, Brushes.LightGray, rcVert, sfVert);

				// draw lines on bottom and right of the page
				_c1pdf.DrawLine(Pens.Gray, rcPage.Left, rcPage.Bottom, rcPage.Right, rcPage.Bottom);
				_c1pdf.DrawLine(Pens.Gray, rcPage.Right, rcPage.Top, rcPage.Right, rcPage.Bottom);
			}
		}
		private void GetContent(ArrayList authorsQuotes, string url)
		{
			// get some content from the web
			StatusText = string.Format("Loading data from '{0}'...", url);
			HttpWebRequest req = (HttpWebRequest)System.Net.HttpWebRequest.Create(url);
			HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
			StreamReader sr = new StreamReader(resp.GetResponseStream());
			string content = sr.ReadToEnd();
			resp.Close();

			// break up into authors and quotes
			StatusText = "Parsing quotes...";
			string pattern = @">""([^""]+)""*<.*?AUTHOR_ID[^>]+>([^<]+)<";
			Regex rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase);
			MatchCollection mc = rx.Matches(content);
			foreach (Match m in mc)
			{
				string quote  = m.Groups[1].Value;
				string author = m.Groups[2].Value;
				quote = Regex.Replace(quote, "<BR>", "\r\n", RegexOptions.IgnoreCase);
				authorsQuotes.Add(author + '\t' + quote);
			}

			// sort by author
			StatusText = "Sorting quotes...";
			authorsQuotes.Sort();
		}

		//================================================================================
		// create document with tables from northwind
		//
		// the sample renders a few tables from the nwind database. although C1Pdf doesn't
		// have any table-specific commands, it is easy to render tables using the 
		// MeasureString and DrawString methods. the RenderTable method in the sample 
		// measures each row, creates a new page when necessary, then renders the rows
		// one by one, with row headers, cell alignment, indentation, and gridlines.
		//
		private void button2_Click(object sender, System.EventArgs e)
		{
			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = "NorthWind Tables";
			StatusText = "Creating pdf document...";

			// calculate page rect (discounting margins)
			RectangleF rcPage = GetPageRect();
			RectangleF rc = rcPage;

			// add title
			Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
			rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rc, false);

			// render some tables
			RenderTable(rc, rcPage, "Customers", new string[] { "CompanyName", "ContactName", "Country", "Address", "Phone" });
			_c1pdf.NewPage();
			rc = rcPage;
			RenderTable(rc, rcPage, "Products",  new string[] { "ProductName", "QuantityPerUnit", "UnitPrice", "UnitsInStock", "UnitsOnOrder" });
			_c1pdf.NewPage();
			rc = rcPage;
			RenderTable(rc, rcPage, "Employees", new string[] { "FirstName", "LastName", "Country", "Notes" });

			// second pass to number pages
			AddFooters();

			// save to file and show it
			StatusText = "Saving pdf document...";
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\nwind.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });
			StatusText = "Ready.";
		}
		private RectangleF RenderTable(RectangleF rc, RectangleF rcPage, string source, string[] fields)
		{
			// get data
			DataTable dt;
			StatusText = string.Format("Retrieving data for {0}...", source);
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			try
			{
				var conn = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}\ComponentOne Samples\Common\C1NWind.mdb;", path);
				var da = new OleDbDataAdapter("select * from " + source, conn);
				dt = new DataTable();
				da.Fill(dt);
			}
			catch (InvalidOperationException)
            {
				var conn = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}\ComponentOne Samples\Common\C1NWind.mdb;", path);
				var da = new OleDbDataAdapter("select * from " + source, conn);
				dt = new DataTable();
				da.Fill(dt);
			}

			// select fonts
			Font hdrFont = new Font("Tahoma", 10, FontStyle.Bold);
			Font txtFont = new Font("Tahoma", 8);

			// build table
			StatusText = string.Format("Creating {0} table...", source);
			_c1pdf.AddBookmark(source, 0, rc.Y);
			rc = RenderParagraph("NorthWind " + source, hdrFont, rcPage, rc, false);

			// build table
			rc = RenderTableHeader(hdrFont, rc, fields);
			foreach (DataRow dr in dt.Rows)
				rc = RenderTableRow(txtFont, hdrFont, rcPage, rc, fields, dr);

			// done
			return rc;
		}
		private RectangleF RenderTableHeader(Font font, RectangleF rc, string[] fields)
		{
			// calculate cell width (same for all columns)
			RectangleF rcCell = rc;
			rcCell.Width = rc.Width / fields.Length;
			rcCell.Height = 0;

			// calculate cell height (max of all columns)
			foreach (string field in fields)
			{
				float height = _c1pdf.MeasureString(field, font, rcCell.Width).Height;
				rcCell.Height = Math.Max(rcCell.Height, height);
			}

			// render header cells
			foreach (string field in fields)
			{
				_c1pdf.FillRectangle(Brushes.Black, rcCell);
				_c1pdf.DrawString(field, font, Brushes.White, rcCell);
				rcCell.Offset(rcCell.Width, 0);
			}

			// update rectangle and return it
			rc.Offset(0, rcCell.Height);
			return rc;
		}
		private RectangleF RenderTableRow(Font font, Font hdrFont, RectangleF rcPage, RectangleF rc, string[] fields, DataRow dr)
		{
			// calculate cell width (same for all columns)
			RectangleF rcCell = rc;
			rcCell.Width = rc.Width / fields.Length;
			rcCell.Height = 0;

			// calculate cell height (max of all columns)
			rcCell.Inflate(-4, 0);
			foreach (string field in fields)
			{
				string text = dr[field].ToString();
				float height = _c1pdf.MeasureString(text, font, rcCell.Width).Height;
				rcCell.Height = Math.Max(rcCell.Height, height);
			}
			rcCell.Inflate(4, 0);

			// break page if we have to
			if (rcCell.Bottom > rcPage.Bottom)
			{
				_c1pdf.NewPage();
				rc = RenderTableHeader(hdrFont, rcPage, fields);
				rcCell.Y = rc.Y;
			}

			// center vertically just to show how
			StringFormat sf = new StringFormat();
			sf.LineAlignment = StringAlignment.Center;

			// render data cells
			Pen pen = new Pen(Brushes.Gray, 0.1f);
			foreach (string field in fields)
			{
				// get content
				string text = dr[field].ToString();

				// set horizontal alignment
				double d;
				sf.Alignment = (double.TryParse(text, NumberStyles.Any, CultureInfo.CurrentCulture, out d))
					? StringAlignment.Far
					: StringAlignment.Near;

				// render cell
				_c1pdf.DrawRectangle(pen, rcCell);
				rcCell.Inflate(-4, 0);
				_c1pdf.DrawString(text, font, Brushes.Black, rcCell, sf);
				rcCell.Inflate(4, 0);
				rcCell.Offset(rcCell.Width, 0);
			}
			pen.Dispose();

			// update rectangle and return it
			rc.Offset(0, rcCell.Height);
			return rc;
		}

		//================================================================================
		// create document with lots of images
		//
		// this sample creates a document with several pictures of different types and 
		// saves three versions of the document with different qualities (high, low, and
		// default).
		//
		private void button3_Click(object sender, System.EventArgs e)
		{
			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = "Images";
			StatusText = "Creating pdf document...";

			// calculate page rect (discounting margins)
			RectangleF rcPage = GetPageRect();
			RectangleF rc = rcPage;
			rc.Inflate(-10, 0);

			// add title
			Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
			rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rc, false);

			Font hdrFont = new Font("Tahoma", 16, FontStyle.Bold);
			Font ftrFont = new Font("Tahoma", 8);

			// render louvre images
			rc = RenderParagraph("Louvre Images", hdrFont, rcPage, rc, true);
			foreach (string res in Assembly.GetExecutingAssembly().GetManifestResourceNames())
				if (res.ToLower().IndexOf("louvre") > -1)
					rc = RenderImage(rcPage, rc, res);
			_c1pdf.NewPage();
			rc.Y = rcPage.Y;

			// render Escher images
			rc = RenderParagraph("Escher Images", hdrFont, rcPage, rc, true);
			foreach (string res in Assembly.GetExecutingAssembly().GetManifestResourceNames())
				if (res.ToLower().IndexOf("escher") > -1)
					rc = RenderImage(rcPage, rc, res);
			_c1pdf.NewPage();
			rc.Y = rcPage.Y;

			// render icons
			rc = RenderParagraph("Icons (transparent)", hdrFont, rcPage, rc, true);
			foreach (string res in Assembly.GetExecutingAssembly().GetManifestResourceNames())
				if (res.ToLower().IndexOf("icons") > -1)
					rc = RenderImage(rcPage, rc, res);

			// render everything else
			rc = RenderParagraph("Other", hdrFont, rcPage, rc, true);
			foreach (string res in Assembly.GetExecutingAssembly().GetManifestResourceNames())
				if (res.ToLower().IndexOf("other") > -1)
					rc = RenderImage(rcPage, rc, res);

			// second pass to number pages
			AddFooters();

			// save to low-quality file and show it
			_c1pdf.ImageQuality = ImageQuality.Low;
			StatusText = "Saving low-quality pdf...";
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\imagesLow.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });

			// save to high-quality file and show it
			_c1pdf.ImageQuality = ImageQuality.High;
			StatusText = "Saving high-quality pdf...";
			fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\imagesHigh.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });

			// save to default-quality file and show it
			_c1pdf.ImageQuality = ImageQuality.Default;
			StatusText = "Saving default-quality pdf...";
			fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\images.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });

			// done
			StatusText = "Ready.";
		}
		private RectangleF RenderImage(RectangleF rcPage, RectangleF rc, string resName)
		{
			// get image
			Assembly a = Assembly.GetExecutingAssembly();
			Image img = Image.FromStream(a.GetManifestResourceStream(resName));

			// calculate image height
			// based on image size and page size
			rc.Height = Math.Min(img.Height / 96f * 72, rcPage.Height * .3f);

			// skip page if necessary
			if (rc.Bottom > rcPage.Bottom)
			{
				_c1pdf.NewPage();
				rc.Y = rcPage.Y;
			}

			// add bookmark
			string[] arr = resName.Split('.');
			string picName = string.Format("{0}.{1}", arr[arr.Length-2], arr[arr.Length-1]);
			_c1pdf.AddBookmark(picName, 1, rc.Y);

			// draw solid background (mainly to see transparency)
			rc.Inflate(+2, +2);
			_c1pdf.FillRectangle(Brushes.Gray, rc);
			rc.Inflate(-2, -2);

			// draw image (keep aspect ratio)
			_c1pdf.DrawImage(img, rc, ContentAlignment.MiddleCenter, ImageSizeMode.Scale);

			// draw caption
			Font font = new Font("Tahoma", 9);
			rc.Y = rc.Bottom + 3;
			rc.Height = 2 * font.Size;
			rc.Offset(+.3f, +.3f);
			_c1pdf.DrawString(picName, font, Brushes.Yellow, rc);
			rc.Offset(-.3f, -.3f);
			_c1pdf.DrawString(picName, font, Brushes.Black, rc);

			// update rectangle
			rc.Y = rc.Bottom + 20;
			return rc;
		}

		//================================================================================
		// create document showing image some alignment options
		//
		// the DrawImage method allows you to specify the content alignment and scaling
		// mode for images. the content alignment parameter sets the position of the 
		// image within the given rectangle (left top, right bottom, etc). the scaling 
		// mode sets the sizing of the image within the rectangle (clip, stretch, scale).
		//
		private void button4_Click(object sender, System.EventArgs e)
		{
			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = "Image Alignment";
			StatusText = "Creating pdf document...";

			// do it
			ShowImageAlignment(pictureBox1.Image);

			// save to file
			StatusText = "Saving pdf document...";
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\imgAlign.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });
			StatusText = "Ready.";
		}
		private void ShowImageAlignment(Image img)
		{
			// calculate page rect (discounting margins)
			RectangleF rcPage = GetPageRect();
			RectangleF rc = rcPage;
			rc.Inflate(-10, 0);

			// add title
			Font font = new Font("Tahoma", 9);
			Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
			rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rc, false);

			// draw images clipping
			rc.Y += 30;
			rc = RenderParagraph("Change ContentAlignment, clip images.", font, rcPage, rc);
			rc.Height = 100;
			foreach (ContentAlignment ca in Enum.GetValues(typeof(ContentAlignment)))
			{
				_c1pdf.DrawImage(img, rc, ca, ImageSizeMode.Clip);
			}
			rc.Inflate(+2,+2);
			_c1pdf.DrawRectangle(Pens.LightGray, rc);
			rc.Inflate(-2,-2);
			_c1pdf.DrawRectangle(Pens.Black, rc);

			// draw images scaling
			rc.Y += rc.Height + 20;
			rc.Inflate(-40, -40);
			rc = RenderParagraph("Change ContentAlignment, scale images.", font, rcPage, rc);
			rc.Height = 100;
			_c1pdf.DrawImage(img, rc, ContentAlignment.TopLeft,   ImageSizeMode.Scale);
			_c1pdf.DrawImage(img, rc, ContentAlignment.TopRight,  ImageSizeMode.Scale);
			_c1pdf.DrawImage(img, rc, ContentAlignment.TopCenter, ImageSizeMode.Scale);
			rc.Inflate(+2,+2);
			_c1pdf.DrawRectangle(Pens.LightGray, rc);
			rc.Inflate(-2,-2);
			_c1pdf.DrawRectangle(Pens.Black, rc);
		}

		//================================================================================
		// create document with all installed fonts
		//
		// the sample enumerates all fonts available in the system and writes one line
		// using each font.
		//
		private void button5_Click(object sender, System.EventArgs e)
		{
			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = "All Fonts";
			StatusText = "Creating pdf document...";
			RectangleF rcPage = GetPageRect();

			// add title
			RectangleF rc = rcPage;
			Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
			rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rc, false);

			// draw text in many fonts
			Font font = new Font("Tahoma", 9);
			rc.Height = 11;
			InstalledFontCollection ifc = new InstalledFontCollection();
			foreach (FontFamily ff in ifc.Families)
			{
				// create font
				Font sample = null;
				foreach (FontStyle fs in Enum.GetValues(typeof(FontStyle)))
				{
					if (ff.IsStyleAvailable(fs))
					{
						sample = new Font(ff.Name, 9, fs);
						break;
					}
				}
				if (sample == null) continue;

				// show font
				_c1pdf.DrawString(ff.Name, font, Brushes.Black, rc);
				rc.X += 120; rc.Width -= 120;
				_c1pdf.DrawString("The quick brown fox jumped over the lazy dog. 1234567890!", sample, Brushes.Black, rc);
				rc.X -= 120; rc.Width += 120;
				sample.Dispose();
				_c1pdf.DrawLine(Pens.LightGray, rc.X, rc.Bottom, rc.X + 130, rc.Bottom);

				// move cursor and skip page if necessary
				rc.Y += rc.Height;
				if (rc.Bottom > _c1pdf.PageSize.Height - 72)
				{
					rc.Y = rcPage.Y;
					_c1pdf.NewPage();
				}
			}

			// show footers as usual
			AddFooters();

			// save and show pdf document
			StatusText = "Saving pdf document...";
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\allFonts.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });
			StatusText = "Ready.";
		}

		//================================================================================
		// create a document with all paper sizes
		//
		// pdf allows you to create documents with different page sizes and orientation.
		// this sample enumerates the members of the PaperKind enum type and creates
		// a document with all paper sizes and random orientation.
		//
		private void button6_Click(object sender, System.EventArgs e)
		{
			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = "Paper Sizes";
			StatusText = "Creating pdf document...";

			// add title
			Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
			RectangleF rc = GetPageRect();
			RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rc, rc, false);

			// create constant font and StringFormat objects
			Font font = new Font("Tahoma", 18);
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;

			// create one page with each paper size
			bool firstPage = true;
			foreach (PaperKind pk in Enum.GetValues(typeof(PaperKind)))
			{
				// skip custom size
				if (pk == PaperKind.Custom) continue;

				// add new page for every page after the first one
				if (!firstPage) _c1pdf.NewPage();
				firstPage = false;

				// set paper kind and orientation
				_c1pdf.PaperKind = pk;
				_c1pdf.Landscape = !_c1pdf.Landscape;
				
				// draw some content on the page
				rc = GetPageRect();
				rc.Inflate(-6, -6);
				string text = string.Format("PaperKind: [{0}];\r\nLandscape: [{1}];\r\nFont: [Tahoma 18pt]",
					_c1pdf.PaperKind, _c1pdf.Landscape);
				_c1pdf.DrawString(text, font, Brushes.Black, rc, sf);
				_c1pdf.DrawRectangle(Pens.Blue, rc);
			}

			// show footers as usual
			AddFooters();

			// save and show pdf document
			StatusText = "Saving pdf document...";
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\allFonts.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });
			StatusText = "Ready.";

			// restore page size
			_c1pdf.PaperKind = PaperKind.Letter;
			_c1pdf.Landscape = false;
		}

		//================================================================================
		// create a document with a table of contents
		//
		// the sample keeps a list of bookmarks added to the document as it is rendered.
		// when the document is done, the sample uses the list to create a table of 
		// contents with links to each topic. finally, the sample moves the table of
		// contents to the start of the document using the Pages collection.
		//
		private void button8_Click(object sender, System.EventArgs e)
		{
			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = "Document with Table of Contents";
			StatusText = "Creating pdf document...";

			// add title
			Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
			RectangleF rcPage = GetPageRect();
			RectangleF rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rcPage, false);
			rc.Y += 12;
			
			// create nonsense document
			ArrayList bkmk = new ArrayList();
			Font headerFont = new Font("Arial", 14, FontStyle.Bold);
			Font bodyFont   = new Font("Times New Roman", 11);
			for (int i = 0; i < 30; i++)
			{
				// create ith header (as a link target and outline entry)
				string header = string.Format("{0}. {1}", i + 1, BuildRandomTitle());
				rc = RenderParagraph(header, headerFont, rcPage, rc, true, true);

				// save bookmark to build TOC later
				int pageNumber = _c1pdf.CurrentPage + 1;
				bkmk.Add(new string[] { pageNumber.ToString(), header });

				// create some text
				rc.X += 36;
				rc.Width -= 36;
				for (int j = 0; j < 3 + _rnd.Next(20); j++)
				{
					string text = BuildRandomParagraph();
					rc = RenderParagraph(text, bodyFont, rcPage, rc);
					rc.Y += 6;
				}
				rc.X -= 36;
				rc.Width += 36;
				rc.Y += 20;
			}

			// number pages (before adding TOC)
			AddFooters();

			// start Table of Contents
			_c1pdf.NewPage();					// start TOC on a new page
			int tocPage = _c1pdf.CurrentPage;	// save page index (to move TOC later)
			rc = RenderParagraph("Table of Contents", titleFont, rcPage, rcPage, true);
			rc.Y += 12;
			rc.X += 30;
			rc.Width -= 40;

			// render Table of Contents
			Pen dottedPen = new Pen(Brushes.Gray, 1.5f);
			dottedPen.DashStyle = DashStyle.Dot;
			StringFormat sfRight = new StringFormat();
			sfRight.Alignment = StringAlignment.Far;
			rc.Height = bodyFont.Height;
			foreach (string[] entry in bkmk)
			{
				// get bookmark info
				string page   = entry[0];
				string header = entry[1];

				// render header name and page number
				_c1pdf.DrawString(header, bodyFont, Brushes.Black, rc);
				_c1pdf.DrawString(page, bodyFont, Brushes.Black, rc, sfRight);
#if true
				// connect the two with some dots (looks better than a dotted line)
				string dots = ". ";
				float wid = _c1pdf.MeasureString(dots, bodyFont).Width;
				float x1  = rc.X + _c1pdf.MeasureString(header, bodyFont).Width + 8;
				float x2  = rc.Right - _c1pdf.MeasureString(page, bodyFont).Width - 8;
				float x = rc.X;
				for (rc.X = x1; rc.X  < x2; rc.X += wid)
					_c1pdf.DrawString(dots, bodyFont, Brushes.Gray, rc);
				rc.X = x;
#else 
				// connect with a dotted line (another option)
				float x1 = rc.X + _c1pdf.MeasureString(header, bodyFont).Width + 5;
				float x2 = rc.Right - _c1pdf.MeasureString(page, bodyFont).Width  - 5;
				float y  = rc.Top + bodyFont.Size;
				_c1pdf.DrawLine(dottedPen, x1, y, x2, y);
#endif
				// add local hyperlink to entry
				_c1pdf.AddLink("#" + header, rc);

				// move on to next entry
				rc.Offset(0, rc.Height);
				if (rc.Bottom > rcPage.Bottom)
				{
					_c1pdf.NewPage();
					rc.Y = rcPage.Y;
				}
			}

			// move table of contents to start of document
			PdfPage[] arr = new PdfPage[_c1pdf.Pages.Count - tocPage];
			_c1pdf.Pages.CopyTo(tocPage, arr, 0, arr.Length);
			_c1pdf.Pages.RemoveRange(tocPage, arr.Length);
			_c1pdf.Pages.InsertRange(0, arr);

			// save and show pdf document
			StatusText = "Saving pdf document...";
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\toc.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });
			StatusText = "Ready.";
		}
		private string BuildRandomTitle()
		{
			string[] a1 = "Learning|Explaining|Mastering|Forgetting|Examining|Understanding|Applying|Using|Destroying".Split('|');
			string[] a2 = "Music|Tennis|Golf|Zen|Diving|Modern Art|Gardening|Architecture|Mathematics|Investments|.NET|Java".Split('|');
			string[] a3 = "Quickly|Painlessly|The Hard Way|Slowly|Painfully|With Panache".Split('|');
			return string.Format("{0} {1} {2}", a1[_rnd.Next(a1.Length-1)], a2[_rnd.Next(a2.Length-1)], a3[_rnd.Next(a3.Length-1)]);
		}
		private string BuildRandomParagraph()
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < 5 + _rnd.Next(10); i++)
				sb.AppendFormat(BuildRandomSentence());
			return sb.ToString();
		}
		private string BuildRandomSentence()
		{
			string[] a1 = "Artists|Movie stars|Musicians|Politicians|Computer programmers|Modern thinkers|Gardeners|Experts|Some people|Hockey players".Split('|');
			string[] a2 = "know|seem to think about|care about|often discuss|dream about|hate|love|despise|respect|long for|pay attention to|embrace".Split('|');
			string[] a3 = "the movies|chicken soup|tea|many things|sushi|my car|deep thoughs|tasteless jokes|vaporware|cell phones|hot dogs|ballgames".Split('|');
			string[] a4 = "incessantly|too much|easily|without reason|rapidly|sadly|randomly|vigorously|more than usual|with enthusiasm|shamelessly|on Tuesdays".Split('|');
			return string.Format("{0} {1} {2} {3}. ", a1[_rnd.Next(a1.Length-1)], a2[_rnd.Next(a2.Length-1)], a3[_rnd.Next(a3.Length-1)], a4[_rnd.Next(a4.Length-1)]);
		}

		//================================================================================
		// create a document with file attachments
		// 
		private void button9_Click(object sender, System.EventArgs e)
		{
			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = "File Attachments";
			StatusText = "Creating pdf document...";

			// add title
			Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
			Font bodyFont  = new Font("Tahoma", 10);
			RectangleF rcPage = GetPageRect();
			RectangleF rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rcPage, false);
			rc.Y += rc.Height;

			// attach some files
			string path = Path.GetDirectoryName(Application.ExecutablePath);
			int pos = path.IndexOf(@"\bin");
			if (pos > -1) path = path.Substring(0, pos);
			string[] files = Directory.GetFiles(path);
			foreach (string file in files)
			{
				RectangleF rcAttach = new RectangleF(rc.X, rc.Y, rc.Height, rc.Height);
				_c1pdf.FillRectangle(Brushes.Gray, rcAttach);
				_c1pdf.AddAttachment(file, rcAttach);

				rc.X += rc.Height;
				RenderParagraph(Path.GetFileName(file), bodyFont, rcPage, rc, false);
				rc.X -= rc.Height;
				rc.Y += 2 * rc.Height;
			}

			// save and show pdf document
			StatusText = "Saving pdf document...";
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\attachments.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });
			StatusText = "Ready.";
		}

		//================================================================================
		// create a document with flowing text
		// 
		// the sample renders a long string into a multi-page 2-column document.
		//
		// this sample uses the return value of the DrawString method, which returns the
		// index of the first character that did not fit into the box. with this value,
		// it is easy to continue rendering after each break.
		//
		private void button10_Click(object sender, System.EventArgs e)
		{
			// load long string from resource file
			string text = "Resource not found...";
			Assembly a = Assembly.GetExecutingAssembly();
			foreach (string res in a.GetManifestResourceNames())
			{
				if (res.ToLower().IndexOf("flow.txt") > -1)
				{
					StreamReader sr = new StreamReader(a.GetManifestResourceStream(res));
					text = sr.ReadToEnd();
				}
			}
			text = text.Replace("\t", "   ");
			text = string.Format("{0}\r\n\r\n---oOoOoOo---\r\n\r\n{0}", text);

			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = "Text Flow";
			StatusText = "Creating pdf document...";

			// add title
			Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);
			Font bodyFont  = new Font("Tahoma", 9);
			RectangleF rcPage = GetPageRect();
			RectangleF rc = RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rcPage, false);
			rc.Y += titleFont.Size + 6;
			rc.Height = rcPage.Height - rc.Y;

			// create two columns for the text
			RectangleF rcLeft = rc;
			rcLeft.Width = rcPage.Width/2 - 12;
			rcLeft.Height = 300;
			rcLeft.Y = (rcPage.Y + rcPage.Height - rcLeft.Height)/2;
			RectangleF rcRight = rcLeft;
			rcRight.X = rcPage.Right - rcRight.Width;

			// start with left column
			rc = rcLeft;

			// render string spanning columns and pages
			for (;;)
			{
				// render as much as will fit into the rectangle
				rc.Inflate(-3, -3);
				int nextChar = _c1pdf.DrawString(text, bodyFont, Brushes.Black, rc);
				rc.Inflate(+3, +3);
				_c1pdf.DrawRectangle(Pens.Silver, rc);

				// break when done
				if (nextChar >= text.Length)
					break;

				// get rid of the part that was rendered
				text = text.Substring(nextChar);

				// switch to right-side rectangle
				if (rc.Left == rcLeft.Left)
				{
					rc = rcRight;
				}
				else // switch to left-side rectangle on the next page
				{
					_c1pdf.NewPage();
					rc = rcLeft;
				}
			}

			// save and show pdf document
			StatusText = "Saving pdf document...";
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\flow.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });
			StatusText = "Ready.";
		}

		//================================================================================
		// create a document with different kinds of text alignment
		//	
		private void button7_Click(object sender, System.EventArgs e)
		{
			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = "Text Alignment";
			StatusText = "Creating pdf document...";

			// create objects
			StringFormat sf   = new StringFormat();
			Font titleFont    = new Font("Tahoma", 24, FontStyle.Bold);
			Font font         = new Font("Tahoma", 10);
			RectangleF rcPage = GetPageRect();

			// render title
			RenderParagraph(_c1pdf.DocumentInfo.Title, titleFont, rcPage, rcPage, false);

			// draw cross-hair
			Pen pen = new Pen(Color.Black, 0.1f);
			PointF center = new PointF(rcPage.X+rcPage.Width/2, rcPage.Y+rcPage.Height/2);
			_c1pdf.DrawLine(pen, center.X, rcPage.Y, center.X, rcPage.Bottom);
			_c1pdf.DrawLine(pen, rcPage.X, center.Y, rcPage.Right, center.Y);

			// draw some text
			string text = "This is some sample text that will be rendered in rectangles on the page.";

			sf.Alignment = StringAlignment.Far;
			sf.LineAlignment = StringAlignment.Far;
			RectangleF rc = new RectangleF(center.X-100, center.Y-100, 100, 100);
			_c1pdf.FillRectangle(Brushes.LightGoldenrodYellow, rc);
			_c1pdf.DrawString("TOP LEFT: " + text, font, Brushes.Black, rc, sf);
			_c1pdf.DrawRectangle(Pens.Black, rc);

			sf.LineAlignment = StringAlignment.Near;
			rc.Offset(0, rc.Height);
			_c1pdf.FillRectangle(Brushes.LightSalmon, rc);
			_c1pdf.DrawString("BOTTOM LEFT: " + text, font, Brushes.Black, rc, sf);
			_c1pdf.DrawRectangle(Pens.Black, rc);

			sf.Alignment = StringAlignment.Near;
			rc.Offset(rc.Width, 0);
			_c1pdf.FillRectangle(Brushes.LightSeaGreen, rc);
			_c1pdf.DrawString("BOTTOM RIGHT: " + text, font, Brushes.Black, rc, sf);
			_c1pdf.DrawRectangle(Pens.Black, rc);

			sf.LineAlignment = StringAlignment.Far;
			rc.Offset(0, -rc.Height);
			_c1pdf.FillRectangle(Brushes.LightSteelBlue, rc);
			_c1pdf.DrawString("TOP RIGHT: " + text, font, Brushes.Black, rc, sf);
			_c1pdf.DrawRectangle(Pens.Black, rc);

			// render some rtf as well
			string qbf = "The quick brown fox jumped over the lazy dog. ";
			qbf = qbf + qbf + qbf + qbf;
			text =  @"This is some {\b RTF} text. It will render into the rectangle as usual.\par\par" +
					@"\qr And {\i this paragraph} will be {\b\i right-aligned}. {\fs12 " + qbf + @"\par\par}" +
					@"\qc And {\i this paragraph} will be {\b\i center-aligned}. {\fs12 " + qbf + @"\par\par}" +
					@"\qj And {\i this paragraph} will be {\b\i justified}. {\fs12 " + qbf + @"\par\par Done.}";
			rc.Location = new PointF(rcPage.X + 12, rcPage.Y + 50);
			rc.Size = _c1pdf.MeasureStringRtf(text, font, rc.Width * 2);
			_c1pdf.FillRectangle(Brushes.DarkBlue, rc);
			_c1pdf.DrawStringRtf(text, font, Brushes.White, rc);
			_c1pdf.DrawRectangle(Pens.Black, rc);

			// and some rtf with bullets
			text = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fcharset0 Arial;}{\f1\fnil\fcharset2 Symbol;}}" +
				   @"\viewkind4\uc1\pard\f0\fs20 Here's a bullet list:\par" +
				   @"\par" +
				   @"\pard{\pntext\f1\'B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\'B7}}\fi-360\li360 Item 1\par" +
				   @"{\pntext\f1\'B7\tab}Item 2\par" +
				   @"{\pntext\f1\'B7\tab}Item 3\par" +
				   @"{\pntext\f1\'B7\tab}Item 4\par" +
				   @"\pard\par" +
				   @"}";
			rc.Location = new PointF(rcPage.X + 250, rcPage.Y + 50);
			rc.Size = _c1pdf.MeasureStringRtf(text, font, rc.Width);
			_c1pdf.DrawStringRtf(text, font, Brushes.White, rc);
			_c1pdf.DrawRectangle(Pens.Black, rc);

			// box the whole thing
			pen = new Pen(Brushes.Black, 1);
			pen.DashStyle = DashStyle.Dot;
			_c1pdf.DrawRectangle(pen, rcPage);

			// save and show pdf document
			StatusText = "Saving pdf document...";
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\align.pdf";
			_c1pdf.Save(fileName);
			Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });
			StatusText = "Ready.";
		}
	}
}
