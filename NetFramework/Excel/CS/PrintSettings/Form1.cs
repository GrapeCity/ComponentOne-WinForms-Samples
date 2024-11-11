using System;
using System.Globalization;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Excel;

namespace xltest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Excel.C1XLBook c1XLBook1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton _rdPortrait;
		private System.Windows.Forms.RadioButton _rdLandscape;
		private System.Windows.Forms.RadioButton _rdAdjust;
		private System.Windows.Forms.RadioButton _rdFit;
		private System.Windows.Forms.NumericUpDown _udPercentSize;
		private System.Windows.Forms.NumericUpDown _udAcross;
		private System.Windows.Forms.NumericUpDown _udDown;
		private System.Windows.Forms.ComboBox _cmbPaperSize;
		private System.Windows.Forms.TextBox _txtStartPage;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown _udLeft;
		private System.Windows.Forms.NumericUpDown _udRight;
		private System.Windows.Forms.NumericUpDown _udTop;
		private System.Windows.Forms.NumericUpDown _udBottom;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown _udFooter;
		private System.Windows.Forms.NumericUpDown _udHeader;
		private System.Windows.Forms.TextBox _txtHeader;
		private System.Windows.Forms.TextBox _txtFooter;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
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
            this.c1XLBook1 = new C1.Excel.C1XLBook();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._rdPortrait = new System.Windows.Forms.RadioButton();
            this._rdLandscape = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this._cmbPaperSize = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._udPercentSize = new System.Windows.Forms.NumericUpDown();
            this._rdAdjust = new System.Windows.Forms.RadioButton();
            this._rdFit = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this._udAcross = new System.Windows.Forms.NumericUpDown();
            this._udDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtStartPage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._udLeft = new System.Windows.Forms.NumericUpDown();
            this._udRight = new System.Windows.Forms.NumericUpDown();
            this._udTop = new System.Windows.Forms.NumericUpDown();
            this._udBottom = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._udFooter = new System.Windows.Forms.NumericUpDown();
            this._udHeader = new System.Windows.Forms.NumericUpDown();
            this._txtHeader = new System.Windows.Forms.TextBox();
            this._txtFooter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._udPercentSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._udAcross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._udDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._udLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._udRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._udTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._udBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._udFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._udHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._rdPortrait);
            this.groupBox1.Controls.Add(this._rdLandscape);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._cmbPaperSize);
            this.groupBox1.Location = new System.Drawing.Point(8, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paper Size/Orientation";
            // 
            // _rdPortrait
            // 
            this._rdPortrait.Location = new System.Drawing.Point(368, 24);
            this._rdPortrait.Name = "_rdPortrait";
            this._rdPortrait.Size = new System.Drawing.Size(64, 16);
            this._rdPortrait.TabIndex = 0;
            this._rdPortrait.Text = "Portrait";
            // 
            // _rdLandscape
            // 
            this._rdLandscape.Location = new System.Drawing.Point(440, 24);
            this._rdLandscape.Name = "_rdLandscape";
            this._rdLandscape.Size = new System.Drawing.Size(112, 16);
            this._rdLandscape.TabIndex = 0;
            this._rdLandscape.Text = "Landscape";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Paper Size";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _cmbPaperSize
            // 
            this._cmbPaperSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbPaperSize.Location = new System.Drawing.Point(88, 22);
            this._cmbPaperSize.Name = "_cmbPaperSize";
            this._cmbPaperSize.Size = new System.Drawing.Size(240, 21);
            this._cmbPaperSize.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this._udPercentSize);
            this.groupBox2.Controls.Add(this._rdAdjust);
            this.groupBox2.Controls.Add(this._rdFit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this._udAcross);
            this.groupBox2.Controls.Add(this._udDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scaling";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(136, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "% normal size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _udPercentSize
            // 
            this._udPercentSize.Location = new System.Drawing.Point(80, 22);
            this._udPercentSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._udPercentSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this._udPercentSize.Name = "_udPercentSize";
            this._udPercentSize.Size = new System.Drawing.Size(48, 20);
            this._udPercentSize.TabIndex = 1;
            this._udPercentSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._udPercentSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // _rdAdjust
            // 
            this._rdAdjust.Location = new System.Drawing.Point(8, 24);
            this._rdAdjust.Name = "_rdAdjust";
            this._rdAdjust.Size = new System.Drawing.Size(72, 16);
            this._rdAdjust.TabIndex = 0;
            this._rdAdjust.Text = "Adjust to";
            // 
            // _rdFit
            // 
            this._rdFit.Location = new System.Drawing.Point(8, 64);
            this._rdFit.Name = "_rdFit";
            this._rdFit.Size = new System.Drawing.Size(56, 16);
            this._rdFit.TabIndex = 0;
            this._rdFit.Text = "Fit to";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(136, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "pages wide by";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _udAcross
            // 
            this._udAcross.Location = new System.Drawing.Point(80, 62);
            this._udAcross.Name = "_udAcross";
            this._udAcross.Size = new System.Drawing.Size(48, 20);
            this._udAcross.TabIndex = 1;
            this._udAcross.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _udDown
            // 
            this._udDown.Location = new System.Drawing.Point(216, 62);
            this._udDown.Name = "_udDown";
            this._udDown.Size = new System.Drawing.Size(48, 20);
            this._udDown.TabIndex = 1;
            this._udDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(272, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "tall";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "First page number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _txtStartPage
            // 
            this._txtStartPage.Location = new System.Drawing.Point(120, 296);
            this._txtStartPage.Name = "_txtStartPage";
            this._txtStartPage.Size = new System.Drawing.Size(112, 20);
            this._txtStartPage.TabIndex = 4;
            this._txtStartPage.Text = "Auto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 24);
            this.button2.TabIndex = 0;
            this.button2.Text = "Save";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this._udLeft);
            this.groupBox3.Controls.Add(this._udRight);
            this.groupBox3.Controls.Add(this._udTop);
            this.groupBox3.Controls.Add(this._udBottom);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this._udFooter);
            this.groupBox3.Controls.Add(this._udHeader);
            this.groupBox3.Location = new System.Drawing.Point(320, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 104);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Margins";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Left";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(152, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Right";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Top";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(152, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bottom";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _udLeft
            // 
            this._udLeft.DecimalPlaces = 2;
            this._udLeft.Location = new System.Drawing.Point(64, 24);
            this._udLeft.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this._udLeft.Name = "_udLeft";
            this._udLeft.Size = new System.Drawing.Size(72, 20);
            this._udLeft.TabIndex = 1;
            this._udLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._udLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _udRight
            // 
            this._udRight.DecimalPlaces = 2;
            this._udRight.Location = new System.Drawing.Point(208, 24);
            this._udRight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this._udRight.Name = "_udRight";
            this._udRight.Size = new System.Drawing.Size(72, 20);
            this._udRight.TabIndex = 1;
            this._udRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._udRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _udTop
            // 
            this._udTop.DecimalPlaces = 2;
            this._udTop.Location = new System.Drawing.Point(64, 48);
            this._udTop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this._udTop.Name = "_udTop";
            this._udTop.Size = new System.Drawing.Size(72, 20);
            this._udTop.TabIndex = 1;
            this._udTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._udTop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _udBottom
            // 
            this._udBottom.DecimalPlaces = 2;
            this._udBottom.Location = new System.Drawing.Point(208, 48);
            this._udBottom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this._udBottom.Name = "_udBottom";
            this._udBottom.Size = new System.Drawing.Size(72, 20);
            this._udBottom.TabIndex = 1;
            this._udBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._udBottom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Header";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(152, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Footer";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _udFooter
            // 
            this._udFooter.DecimalPlaces = 2;
            this._udFooter.Location = new System.Drawing.Point(208, 72);
            this._udFooter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this._udFooter.Name = "_udFooter";
            this._udFooter.Size = new System.Drawing.Size(72, 20);
            this._udFooter.TabIndex = 1;
            this._udFooter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._udFooter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _udHeader
            // 
            this._udHeader.DecimalPlaces = 2;
            this._udHeader.Location = new System.Drawing.Point(64, 72);
            this._udHeader.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this._udHeader.Name = "_udHeader";
            this._udHeader.Size = new System.Drawing.Size(72, 20);
            this._udHeader.TabIndex = 1;
            this._udHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._udHeader.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _txtHeader
            // 
            this._txtHeader.Location = new System.Drawing.Point(120, 232);
            this._txtHeader.Name = "_txtHeader";
            this._txtHeader.Size = new System.Drawing.Size(488, 20);
            this._txtHeader.TabIndex = 4;
            // 
            // _txtFooter
            // 
            this._txtFooter.Location = new System.Drawing.Point(120, 264);
            this._txtFooter.Name = "_txtFooter";
            this._txtFooter.Size = new System.Drawing.Size(488, 20);
            this._txtFooter.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(16, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Page Footer";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(16, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Page Header";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(618, 335);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this._txtStartPage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._txtHeader);
            this.Controls.Add(this._txtFooter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Excel: Print settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._udPercentSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._udAcross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._udDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._udLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._udRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._udTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._udBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._udFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._udHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			foreach (PaperKind pk in Enum.GetValues(typeof(PaperKind)))
			{
				_cmbPaperSize.Items.Add(pk);
			}
		}
		private void button1_Click(object sender, System.EventArgs e)
		{
			// load book
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.FileName = "*.xls";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					c1XLBook1.Load(dlg.FileName);
					ShowPrintSettings();
				}
			}
		}
		private void button2_Click(object sender, System.EventArgs e)
		{
			// apply print settings
			ApplyPrintSettings();

			// save book
			string tempdir = Application.ExecutablePath.Substring(0,
				Application.ExecutablePath.LastIndexOf("\\")+1);
			string xlsFile = tempdir + @"psOut.xls";
			c1XLBook1.Save(xlsFile);
			System.Diagnostics.Process.Start(xlsFile);
		}

		// read print settings from sheet, show in form
		private void ShowPrintSettings()
		{
			XLSheet sheet = c1XLBook1.Sheets[0];
			XLPrintSettings ps = sheet.PrintSettings;

			// paper size, orientation
			_cmbPaperSize.SelectedItem = ps.PaperKind;
			if (ps.Landscape)
			{
				_rdLandscape.Checked = true;
			}
			else
			{
				_rdPortrait.Checked = true;
			}
			
			// scaling
			if (ps.AutoScale)
			{
				_rdFit.Checked = true;
			}
			else
			{
				_rdAdjust.Checked = true;
			}
			_udAcross.Value = ps.FitPagesAcross;
			_udDown.Value = ps.FitPagesDown;
			_udPercentSize.Value = ps.ScalingFactor;

			// start page
			_txtStartPage.Text = ps.StartPage.ToString();

			// margins
			_udLeft.Value   = new decimal(ps.MarginLeft);
			_udTop.Value    = new decimal(ps.MarginTop);
			_udRight.Value  = new decimal(ps.MarginRight);
			_udBottom.Value = new decimal(ps.MarginBottom); 
			_udHeader.Value = new decimal(ps.MarginHeader); 
			_udFooter.Value = new decimal(ps.MarginFooter); 

			// header/footer
			_txtHeader.Text = ps.Header;
			_txtFooter.Text = ps.Footer;
		}

		// read print settings from form, apply to sheet
		private void ApplyPrintSettings()
		{
			XLSheet sheet = c1XLBook1.Sheets[0];
			XLPrintSettings ps = sheet.PrintSettings;

			// paper size, orientation
			if (_cmbPaperSize.SelectedItem != null)
                ps.PaperKind = (short)(int)_cmbPaperSize.SelectedItem;
            ps.Landscape = _rdLandscape.Checked;

			// scaling
			// ** note: 
			//    setting the FitPagesAcross, FitPagesDown, and ScalingFactor properties
			//    changes the value of AutoScale, so set AutoScale last.
			ps.FitPagesAcross = decimal.ToInt32(_udAcross.Value);
			ps.FitPagesDown = decimal.ToInt32(_udDown.Value);
			ps.ScalingFactor = decimal.ToInt32(_udPercentSize.Value);
			ps.AutoScale = _rdFit.Checked;

			// start page
			try
			{
				ps.StartPage = int.Parse(_txtStartPage.Text);
			}
			catch 
			{
				ps.StartPage = 1;
			}

			// margins
			ps.MarginLeft   = decimal.ToDouble(_udLeft.Value);
			ps.MarginTop    = decimal.ToDouble(_udTop.Value);
			ps.MarginRight  = decimal.ToDouble(_udRight.Value);
			ps.MarginBottom = decimal.ToDouble(_udBottom.Value); 
			ps.MarginHeader = decimal.ToDouble(_udHeader.Value); 
			ps.MarginFooter = decimal.ToDouble(_udFooter.Value); 

			// header/footer
			ps.Header = _txtHeader.Text;
			ps.Footer = _txtFooter.Text;
		}
	}
}
