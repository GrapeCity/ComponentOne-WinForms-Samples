using System;
using System.IO;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Data;
using C1.C1Word;
using C1.C1Word.Objects;

namespace WordCreator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btSimple;
		private System.Windows.Forms.Button _btRead;
		private System.Windows.Forms.Button _tbPicture;
		private System.Windows.Forms.Button _btTable;
		private System.Windows.Forms.Button _btGraphics;
		private System.Windows.Forms.Button _btMetafile;
		private System.Windows.Forms.GroupBox _groupWrite;
		private System.Windows.Forms.GroupBox _groupRead;
		private System.Windows.Forms.Button _btCurve;
		private System.Windows.Forms.StatusBar _statusBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _btFonts;
		private System.Windows.Forms.Button _btComplex;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
        private GroupBox _groupFormat;
        private ComboBox _comboFormat;
        private Label label10;
        private string _format;
        private CheckBox _check2007;

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
#if DEBUG
            _comboFormat.SelectedIndex = 1;
            _format = ".rtf";
#else
            _comboFormat.SelectedIndex = 0;
            _format = ".docx";
#endif
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
            this.btSimple = new System.Windows.Forms.Button();
            this._btRead = new System.Windows.Forms.Button();
            this._tbPicture = new System.Windows.Forms.Button();
            this._btTable = new System.Windows.Forms.Button();
            this._btGraphics = new System.Windows.Forms.Button();
            this._btMetafile = new System.Windows.Forms.Button();
            this._groupWrite = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btComplex = new System.Windows.Forms.Button();
            this._btFonts = new System.Windows.Forms.Button();
            this._btCurve = new System.Windows.Forms.Button();
            this._groupRead = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._statusBar = new System.Windows.Forms.StatusBar();
            this._groupFormat = new System.Windows.Forms.GroupBox();
            this._check2007 = new System.Windows.Forms.CheckBox();
            this._comboFormat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this._groupWrite.SuspendLayout();
            this._groupRead.SuspendLayout();
            this._groupFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSimple
            // 
            this.btSimple.BackColor = System.Drawing.SystemColors.Info;
            this.btSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSimple.Location = new System.Drawing.Point(16, 24);
            this.btSimple.Name = "btSimple";
            this.btSimple.Size = new System.Drawing.Size(112, 24);
            this.btSimple.TabIndex = 1;
            this.btSimple.Text = "Simple";
            this.btSimple.UseVisualStyleBackColor = false;
            this.btSimple.Click += new System.EventHandler(this.btSimple_Click);
            // 
            // _btRead
            // 
            this._btRead.BackColor = System.Drawing.SystemColors.Info;
            this._btRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btRead.Location = new System.Drawing.Point(16, 24);
            this._btRead.Name = "_btRead";
            this._btRead.Size = new System.Drawing.Size(112, 24);
            this._btRead.TabIndex = 9;
            this._btRead.Text = "Read && Write";
            this._btRead.UseVisualStyleBackColor = false;
            this._btRead.Click += new System.EventHandler(this._btRead_Click);
            // 
            // _tbPicture
            // 
            this._tbPicture.BackColor = System.Drawing.SystemColors.Info;
            this._tbPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._tbPicture.Location = new System.Drawing.Point(16, 120);
            this._tbPicture.Name = "_tbPicture";
            this._tbPicture.Size = new System.Drawing.Size(112, 24);
            this._tbPicture.TabIndex = 4;
            this._tbPicture.Text = "Picture";
            this._tbPicture.UseVisualStyleBackColor = false;
            this._tbPicture.Click += new System.EventHandler(this._tbPicture_Click);
            // 
            // _btTable
            // 
            this._btTable.BackColor = System.Drawing.SystemColors.Info;
            this._btTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btTable.Location = new System.Drawing.Point(16, 88);
            this._btTable.Name = "_btTable";
            this._btTable.Size = new System.Drawing.Size(112, 24);
            this._btTable.TabIndex = 3;
            this._btTable.Text = "Table";
            this._btTable.UseVisualStyleBackColor = false;
            this._btTable.Click += new System.EventHandler(this._btTable_Click);
            // 
            // _btGraphics
            // 
            this._btGraphics.BackColor = System.Drawing.SystemColors.Info;
            this._btGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btGraphics.Location = new System.Drawing.Point(16, 184);
            this._btGraphics.Name = "_btGraphics";
            this._btGraphics.Size = new System.Drawing.Size(112, 24);
            this._btGraphics.TabIndex = 6;
            this._btGraphics.Text = "Graphics";
            this._btGraphics.UseVisualStyleBackColor = false;
            this._btGraphics.Click += new System.EventHandler(this._btGraphics_Click);
            // 
            // _btMetafile
            // 
            this._btMetafile.BackColor = System.Drawing.SystemColors.Info;
            this._btMetafile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btMetafile.Location = new System.Drawing.Point(16, 248);
            this._btMetafile.Name = "_btMetafile";
            this._btMetafile.Size = new System.Drawing.Size(112, 24);
            this._btMetafile.TabIndex = 8;
            this._btMetafile.Text = "Metafile";
            this._btMetafile.UseVisualStyleBackColor = false;
            this._btMetafile.Click += new System.EventHandler(this._btMetafile_Click);
            // 
            // _groupWrite
            // 
            this._groupWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupWrite.Controls.Add(this.label9);
            this._groupWrite.Controls.Add(this.label8);
            this._groupWrite.Controls.Add(this.label7);
            this._groupWrite.Controls.Add(this.label6);
            this._groupWrite.Controls.Add(this.label5);
            this._groupWrite.Controls.Add(this.label4);
            this._groupWrite.Controls.Add(this.label3);
            this._groupWrite.Controls.Add(this.label2);
            this._groupWrite.Controls.Add(this._btComplex);
            this._groupWrite.Controls.Add(this._btFonts);
            this._groupWrite.Controls.Add(this._btCurve);
            this._groupWrite.Controls.Add(this._btGraphics);
            this._groupWrite.Controls.Add(this._btMetafile);
            this._groupWrite.Controls.Add(this.btSimple);
            this._groupWrite.Controls.Add(this._tbPicture);
            this._groupWrite.Controls.Add(this._btTable);
            this._groupWrite.Location = new System.Drawing.Point(14, 91);
            this._groupWrite.Name = "_groupWrite";
            this._groupWrite.Size = new System.Drawing.Size(388, 288);
            this._groupWrite.TabIndex = 6;
            this._groupWrite.TabStop = false;
            this._groupWrite.Text = "Write documents";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(136, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Convert metafile to the document.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(136, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Various curves.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(136, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Graphics primitives in field.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(136, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Complex (pictures, lists, tables, graphics...).";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(136, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Show all fonts in our computer.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(136, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Show any picture.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(136, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Example with tables.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(136, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "\"Hello World!\" document.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _btComplex
            // 
            this._btComplex.BackColor = System.Drawing.SystemColors.Info;
            this._btComplex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btComplex.Location = new System.Drawing.Point(16, 56);
            this._btComplex.Name = "_btComplex";
            this._btComplex.Size = new System.Drawing.Size(112, 24);
            this._btComplex.TabIndex = 2;
            this._btComplex.Text = "Complex";
            this._btComplex.UseVisualStyleBackColor = false;
            this._btComplex.Click += new System.EventHandler(this._btComplex_Click);
            // 
            // _btFonts
            // 
            this._btFonts.BackColor = System.Drawing.SystemColors.Info;
            this._btFonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btFonts.Location = new System.Drawing.Point(16, 152);
            this._btFonts.Name = "_btFonts";
            this._btFonts.Size = new System.Drawing.Size(112, 24);
            this._btFonts.TabIndex = 5;
            this._btFonts.Text = "Fonts";
            this._btFonts.UseVisualStyleBackColor = false;
            this._btFonts.Click += new System.EventHandler(this._btFonts_Click);
            // 
            // _btCurve
            // 
            this._btCurve.BackColor = System.Drawing.SystemColors.Info;
            this._btCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btCurve.Location = new System.Drawing.Point(16, 216);
            this._btCurve.Name = "_btCurve";
            this._btCurve.Size = new System.Drawing.Size(112, 24);
            this._btCurve.TabIndex = 7;
            this._btCurve.Text = "Curves";
            this._btCurve.UseVisualStyleBackColor = false;
            this._btCurve.Click += new System.EventHandler(this._btCurve_Click);
            // 
            // _groupRead
            // 
            this._groupRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupRead.Controls.Add(this.label1);
            this._groupRead.Controls.Add(this._btRead);
            this._groupRead.Location = new System.Drawing.Point(14, 385);
            this._groupRead.Name = "_groupRead";
            this._groupRead.Size = new System.Drawing.Size(388, 64);
            this._groupRead.TabIndex = 7;
            this._groupRead.TabStop = false;
            this._groupRead.Text = "Read and write documents";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(136, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Read document to a object model and create (write) other document.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _statusBar
            // 
            this._statusBar.Location = new System.Drawing.Point(0, 459);
            this._statusBar.Name = "_statusBar";
            this._statusBar.Size = new System.Drawing.Size(414, 22);
            this._statusBar.SizingGrip = false;
            this._statusBar.TabIndex = 8;
            this._statusBar.Text = "Ready.";
            // 
            // _groupFormat
            // 
            this._groupFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupFormat.Controls.Add(this._check2007);
            this._groupFormat.Controls.Add(this._comboFormat);
            this._groupFormat.Controls.Add(this.label10);
            this._groupFormat.Location = new System.Drawing.Point(14, 12);
            this._groupFormat.Name = "_groupFormat";
            this._groupFormat.Size = new System.Drawing.Size(388, 73);
            this._groupFormat.TabIndex = 9;
            this._groupFormat.TabStop = false;
            this._groupFormat.Text = "File format";
            // 
            // _check2007
            // 
            this._check2007.AutoSize = true;
            this._check2007.Location = new System.Drawing.Point(16, 46);
            this._check2007.Name = "_check2007";
            this._check2007.Size = new System.Drawing.Size(343, 17);
            this._check2007.TabIndex = 3;
            this._check2007.Text = "Maintain (canvas) compatibility with 2007 version of Microsoft Word";
            this._check2007.UseVisualStyleBackColor = true;
            // 
            // _comboFormat
            // 
            this._comboFormat.FormattingEnabled = true;
            this._comboFormat.Items.AddRange(new object[] {
            "DOCX",
            "RTF"});
            this._comboFormat.Location = new System.Drawing.Point(16, 19);
            this._comboFormat.Name = "_comboFormat";
            this._comboFormat.Size = new System.Drawing.Size(112, 21);
            this._comboFormat.TabIndex = 0;
            this._comboFormat.Text = "DOCX";
            this._comboFormat.SelectedIndexChanged += new System.EventHandler(this._comboFormat_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(134, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Select document format for write (DOCX/RTF) ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(414, 481);
            this.Controls.Add(this._groupFormat);
            this.Controls.Add(this._statusBar);
            this.Controls.Add(this._groupRead);
            this.Controls.Add(this._groupWrite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 520);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Word Demo Creator";
            this._groupWrite.ResumeLayout(false);
            this._groupRead.ResumeLayout(false);
            this._groupFormat.ResumeLayout(false);
            this._groupFormat.PerformLayout();
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

		private void btSimple_Click(object sender, System.EventArgs e)
		{
			// create document
			C1WordDocument c1Word = new C1WordDocument();
			c1Word.Info.Title = "Simple sample";
			_statusBar.Text = "Creating document...";

			Font font = new Font("Tahoma", 24, FontStyle.Italic);
            c1Word.AddParagraph("Hello World!", font, Color.Blue);

			_statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "simple.rtf");
			c1Word.Save(fileName);
			Process.Start(fileName);
			_statusBar.Text = "Ready.";
		}

		private void _tbPicture_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Gif (*.gif)|*.gif|Png (*.png)|*.png|Jpeg (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|Windows metafile (*.wmf)|*.wmf|All files (*.*)|*.*";
			dlg.FilterIndex = 6;
			dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

			// create document
			C1WordDocument c1Word = new C1WordDocument();
			c1Word.Info.Title = "Show any picture sample";
			_statusBar.Text = "Creating document...";

			Font font = new Font("Arial", 14, FontStyle.Bold);
            c1Word.AddParagraph("Picture:", font, Color.Chocolate);

			Image img;
			string ext = Path.GetExtension(dlg.FileName);
            if (ext == ".wmf" || ext == ".emf")
            {
                img = Metafile.FromFile(dlg.FileName);
            }
            else
            {
                img = new Bitmap(dlg.FileName);
            }
			c1Word.AddPicture(img, RtfHorizontalAlignment.Left);

			c1Word.LineBreak();

			font = new Font("Arial", 10, FontStyle.Regular);
            c1Word.AddParagraph(dlg.FileName, font, Color.Blue);

			_statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "picture.rtf");
			c1Word.Save(fileName);
			Process.Start(fileName);
			_statusBar.Text = "Ready.";
		}

		private void _btTable_Click(object sender, System.EventArgs e)
		{
			// create document
            C1WordDocument c1Word = new C1WordDocument();
			c1Word.Info.Title = "Sample with tables";
			_statusBar.Text = "Creating document...";

			int rows = 4;
			int cols = 2;
            RtfTable table = new RtfTable(rows, cols);
            table.BottomBorderStyle = table.LeftBorderStyle = table.RightBorderStyle = table.TopBorderStyle = RtfBorderStyle.Single;
            table.BottomBorderWidth = table.LeftBorderWidth = table.RightBorderWidth = table.TopBorderWidth = 1;
            c1Word.Add(table);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var cell = table.Rows[row].Cells[col];
                    cell.BottomBorderStyle = cell.LeftBorderStyle = cell.RightBorderStyle = cell.TopBorderStyle = RtfBorderStyle.Single;
                    cell.BottomBorderWidth = cell.LeftBorderWidth = cell.RightBorderWidth = cell.TopBorderWidth = 1;
                    RtfParagraph paragraph = new RtfParagraph();
                    paragraph.Content.Add(new RtfString(string.Format("table cell {0}:{1}.", row, col)));
                    cell.Content.Add(paragraph);
                }
            }

            Font font = new Font("Arial", 10, FontStyle.Regular);
            c1Word.AddParagraph("Simple table.", font, Color.Blue);

			_statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "table.rtf");
			c1Word.Save(fileName);
			Process.Start(fileName);
			_statusBar.Text = "Ready.";
		}

        private void _btComplex_Click(object sender, System.EventArgs e)
        {
            // create document
            C1WordDocument c1Word = new C1WordDocument();
            c1Word.Info.Title = "Complex sample";
            _statusBar.Text = "Creating document...";

            // add title
            c1Word.AddParagraph(c1Word.Info.Title, new Font("Tahoma", 24, FontStyle.Italic), Color.BlueViolet);

            // add image
            c1Word.AddParagraph("picture:", new Font("Courier New", 9, FontStyle.Regular), Color.Black);
            Bitmap img = new Bitmap(GetManifestResource("picture.jpg"));
            c1Word.AddPicture(img, RtfHorizontalAlignment.Center);

            // add table
            c1Word.LineBreak();
            int rows = 7;
            int cols = 2;
            RtfTable table = new RtfTable(rows, cols);
            table.BottomBorderStyle = table.LeftBorderStyle = table.RightBorderStyle = table.TopBorderStyle = RtfBorderStyle.Single;
            table.BottomBorderWidth = table.LeftBorderWidth = table.RightBorderWidth = table.TopBorderWidth = 1;
            c1Word.Add(table);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var cell = table.Rows[row].Cells[col];
                    cell.BottomBorderStyle = cell.LeftBorderStyle = cell.RightBorderStyle = cell.TopBorderStyle = RtfBorderStyle.Single;
                    cell.BottomBorderWidth = cell.LeftBorderWidth = cell.RightBorderWidth = cell.TopBorderWidth = 1;
                    RtfParagraph paragraph = new RtfParagraph();
                    paragraph.Content.Add(new RtfString(string.Format("table cell {0}:{1}.", row, col)));
                    cell.Content.Add(paragraph);
                }
            }

            // add graphics
            c1Word.LineBreak();
            c1Word.DrawLine(Pens.Green, 200, 90, 400, 90);

            var rc = new RectangleF(150, 170, 90, 40);
            using (Pen pen = new Pen(Brushes.Blue, 5.0f))
            {
                c1Word.DrawRectangle(pen, rc);
            }
            c1Word.FillRectangle(Color.Gold, rc);
            c1Word.ShapeFillOpacity(50);
            c1Word.ShapeRotation(25);

            rc = new RectangleF(300, 120, 80, 80);
            c1Word.DrawEllipse(Pens.Red, rc);
            c1Word.FillEllipse(Color.Pink, rc);
            c1Word.ShapeFillOpacity(70);

            _statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "complex.rtf");
            c1Word.Save(fileName);
            Process.Start(fileName);
            _statusBar.Text = "Ready.";
        }

		private void _btFonts_Click(object sender, System.EventArgs e)
		{
			// create document
			C1WordDocument c1Word = new C1WordDocument();
			c1Word.Info.Title = "All Fonts";
			_statusBar.Text = "Creating document...";

			// add title
            c1Word.AddParagraph(c1Word.Info.Title, new Font("Tahoma", 24, FontStyle.Bold), Color.Black);

			// draw text in many fonts
			Font font = new Font("Tahoma", 9);
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
                c1Word.AddParagraph(ff.Name, font, Color.Black);
                c1Word.AddParagraph("The quick brown fox jumped over the lazy dog. 1234567890!", sample, Color.Black);
				sample.Dispose();
				// TODO: add split bar or line

				// TODO: add new page if necessary
//				c1Word.PageBreak();
			}

			// save and show document
			_statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "fonts.rtf");
			c1Word.Save(fileName);
			Process.Start(fileName);
			_statusBar.Text = "Ready.";
		}

		private void _btGraphics_Click(object sender, System.EventArgs e)
		{
			// create document
			C1WordDocument c1Word = new C1WordDocument();
			c1Word.Info.Title = "Graphics primitives sample";
			_statusBar.Text = "Creating document...";

            RectangleF rc = new RectangleF(250, 100, 200, 200);
            Bitmap image = new Bitmap(GetManifestResource("picture.jpg"));
            c1Word.DrawImage(image, rc);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            rc = new RectangleF(250, 100, 150, 20);
            Font font = new Font("Arial", 14, FontStyle.Italic);
            c1Word.DrawString(c1Word.Info.Title, font, Color.DeepPink, rc, sf);

            c1Word.DrawLine(Pens.Green, 200, 190, 400, 190);

            rc = new RectangleF(150, 150, 190, 80);
            using (Pen pen = new Pen(Brushes.Blue, 5.0f))
            {
                c1Word.DrawRectangle(pen, rc);
            }
            c1Word.FillRectangle(Color.Gold, rc);
            c1Word.ShapeFillOpacity(50);
            c1Word.ShapeRotation(25);

            rc = new RectangleF(300, 150, 80, 80);
            c1Word.DrawEllipse(Pens.Red, rc);
            c1Word.FillEllipse(Color.Pink, rc);
            c1Word.ShapeFillOpacity(70);

            PointF[] pts = new PointF[4];
            pts[0] = new PointF(200, 200);
            pts[1] = new PointF(250, 300);
            pts[2] = new PointF(330, 250);
            pts[3] = new PointF(340, 140);
            c1Word.DrawPolyline(Pens.BlueViolet, pts);

            sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Far;
            sf.FormatFlags |= StringFormatFlags.DirectionVertical;
            rc = new RectangleF(450, 150, 25, 75);
            font = new Font("Verdana", 12, FontStyle.Bold);
            c1Word.DrawString("Vertical", font, Color.Black, rc, sf);

            pts = new PointF[4];
            pts[0] = new PointF(372, 174);
            pts[1] = new PointF(325, 174);
            pts[2] = new PointF(325, 281);
            pts[3] = new PointF(269, 281);
            c1Word.DrawBeziers(Pens.HotPink, pts);

			_statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "graphics.rtf");
			c1Word.Save(fileName);
			Process.Start(fileName);
			_statusBar.Text = "Ready.";
		}

		private void _btMetafile_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Extended metafile (*.emf)|*.emf|Windows metafile (*.wmf)|*.wmf|All files (*.*)|*.*";
			dlg.FilterIndex = 1;
			dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

			// create document
			C1WordDocument c1Word = new C1WordDocument();
			c1Word.Info.Title = "Convert metafile to RTF example";
			_statusBar.Text = "Creating document...";

			Image img;
			string ext = Path.GetExtension(dlg.FileName);
            if (ext == ".wmf" || ext == ".emf")
            {
                img = Metafile.FromFile(dlg.FileName);
            }
            else
            {
                throw new FormatException("Not metafile.");
            }
			c1Word.DrawMetafile((Metafile)img);

			c1Word.PageBreak();

            c1Word.AddPicture(img, RtfHorizontalAlignment.Left);

			c1Word.LineBreak();

			Font font = new Font("Arial", 10, FontStyle.Regular);
            c1Word.AddParagraph(dlg.FileName, font, Color.Black);

			_statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "metafile.rtf");
			c1Word.Save(fileName);
			Process.Start(fileName);
			_statusBar.Text = "Ready.";
		}

		private void _btCurve_Click(object sender, System.EventArgs e)
		{
			// create document
			C1WordDocument c1Word = new C1WordDocument();
			c1Word.Info.Title = "Various curves sample";
			_statusBar.Text = "Creating document...";

			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;
			RectangleF rc = new RectangleF(250, 100, 150, 20);
			Font font = new Font("Tachoma", 12, FontStyle.Italic | FontStyle.Underline);
			c1Word.DrawString("Curves sample", font, Color.Black, rc, sf);

            //// curve
            //PointF[] pts = new PointF[7];
            //pts[0] = new PointF(191.1f, 172.3f);
            //pts[1] = new PointF(229.1f, 205.3f);
            //pts[2] = new PointF(267.15f, 238.3f);
            //pts[3] = new PointF(296.4f, 235.3f);
            //pts[4] = new PointF(325.65f, 232.3f);
            //pts[5] = new PointF(346.1f, 193.3f);
            //pts[6] = new PointF(366.6f, 154.3f);
            //c1Word.DrawBeziers(Pens.HotPink, pts);

            //// pie
            //rc = new RectangleF(120, 100, 150, 80);
            //c1Word.FillPie(Brushes.Yellow, rc, 0, 90);
            //c1Word.DrawPie(Pens.Indigo, rc, 0, 90);

            // arc
            rc = new RectangleF(120, 100, 150, 80);
            c1Word.DrawArc(Pens.Red, rc, 0, 90);

            //// arc
            //rc = new RectangleF(320, 300, 90, 45);
            //c1Word.DrawArc(Pens.Blue, rc, 270, 90);

			_statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "curves.rtf");
			c1Word.Save(fileName);
			Process.Start(fileName);
			_statusBar.Text = "Ready.";
		}

		private void _btRead_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = GetFileFilter();
			dlg.FilterIndex = 0;
			dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

			// create document
			C1WordDocument c1Word = new C1WordDocument();
			_statusBar.Text = "Loading RTF document...";
			c1Word.Load(dlg.FileName);
#if DEBUGx
            foreach (RtfObject obj in c1Word.MainSection.Content)
            {
                if (obj is RtfParagraph)
                {
                    var paragraph = obj as RtfParagraph;
                    foreach (var o in paragraph.Content)
                    {
                        if (o is RtfString)
                        {
                            ((RtfString)o).Text = "<skip>";
                        }
                    }
                }
            }
#endif
			_statusBar.Text = "Saving document...";
            string fileName = GetFileName(c1Word, "reading.rtf");
			c1Word.Save(fileName);
			Process.Start(fileName);
			_statusBar.Text = "Ready.";
		}

		string GetFileFilter()
		{
            if (_format.Equals(".rtf"))
                return "RTF files (*.rtf)|*.rtf|MS Word (Open XML) files (*.docx)|*.docx";
            return "MS Word (Open XML) files (*.docx)|*.docx|RTF files (*.rtf)|*.rtf";
        }
		string GetFileName(C1WordDocument c1Word, string fileName)
		{
            c1Word.Info.Author = "C1WordCreator";
            c1Word.Info.Company = "GrapeCity";

            if (_format.Equals(".rtf"))
            {
                return Path.GetDirectoryName(Application.ExecutablePath) + '\\' + fileName;
            }

            if (_check2007.Checked)
            {
                c1Word.ShapesWord2007Compatible = true;
            }

            return Path.GetDirectoryName(Application.ExecutablePath) + '\\' + Path.GetFileNameWithoutExtension(fileName) + _format;
        }
		private static Stream GetManifestResource(string resource)
		{
			resource = resource.ToLower();
			Assembly a = Assembly.GetExecutingAssembly();
			foreach (string res in a.GetManifestResourceNames())
			{
				if (res.ToLower().EndsWith(resource))
					return a.GetManifestResourceStream(res);
			}
			return null;
		}

        private void _comboFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = _comboFormat.Text.ToUpper();
            if (text.Contains("DOCX"))
                _format = ".docx";
            else
                _format = ".rtf";
        }
	}
}
