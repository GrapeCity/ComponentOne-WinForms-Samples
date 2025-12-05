using System;
using System.Globalization;
using System.Drawing;
using System.Drawing.Printing;
using System.Diagnostics;
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            groupBox1 = new GroupBox();
            _rdPortrait = new RadioButton();
            _rdLandscape = new RadioButton();
            label4 = new Label();
            _cmbPaperSize = new ComboBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            _udPercentSize = new NumericUpDown();
            _rdAdjust = new RadioButton();
            _rdFit = new RadioButton();
            label2 = new Label();
            _udAcross = new NumericUpDown();
            _udDown = new NumericUpDown();
            label3 = new Label();
            label5 = new Label();
            _txtStartPage = new TextBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            _udLeft = new NumericUpDown();
            _udRight = new NumericUpDown();
            _udTop = new NumericUpDown();
            _udBottom = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            _udFooter = new NumericUpDown();
            _udHeader = new NumericUpDown();
            _txtHeader = new TextBox();
            _txtFooter = new TextBox();
            label12 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)_udPercentSize).BeginInit();
            ((ISupportInitialize)_udAcross).BeginInit();
            ((ISupportInitialize)_udDown).BeginInit();
            groupBox3.SuspendLayout();
            ((ISupportInitialize)_udLeft).BeginInit();
            ((ISupportInitialize)_udRight).BeginInit();
            ((ISupportInitialize)_udTop).BeginInit();
            ((ISupportInitialize)_udBottom).BeginInit();
            ((ISupportInitialize)_udFooter).BeginInit();
            ((ISupportInitialize)_udHeader).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(19, 20);
            button1.Name = "button1";
            button1.Size = new Size(288, 59);
            button1.TabIndex = 0;
            button1.Text = "Load";
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(_rdPortrait);
            groupBox1.Controls.Add(_rdLandscape);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(_cmbPaperSize);
            groupBox1.Location = new Point(19, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1440, 138);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paper Size/Orientation";
            // 
            // _rdPortrait
            // 
            _rdPortrait.Location = new Point(883, 59);
            _rdPortrait.Name = "_rdPortrait";
            _rdPortrait.Size = new Size(154, 39);
            _rdPortrait.TabIndex = 0;
            _rdPortrait.Text = "Portrait";
            // 
            // _rdLandscape
            // 
            _rdLandscape.Location = new Point(1056, 59);
            _rdLandscape.Name = "_rdLandscape";
            _rdLandscape.Size = new Size(269, 39);
            _rdLandscape.TabIndex = 0;
            _rdLandscape.Text = "Landscape";
            // 
            // label4
            // 
            label4.Location = new Point(19, 59);
            label4.Name = "label4";
            label4.Size = new Size(173, 39);
            label4.TabIndex = 2;
            label4.Text = "Paper Size";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // _cmbPaperSize
            // 
            _cmbPaperSize.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbPaperSize.Location = new Point(211, 54);
            _cmbPaperSize.Name = "_cmbPaperSize";
            _cmbPaperSize.Size = new Size(576, 40);
            _cmbPaperSize.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(_udPercentSize);
            groupBox2.Controls.Add(_rdAdjust);
            groupBox2.Controls.Add(_rdFit);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(_udAcross);
            groupBox2.Controls.Add(_udDown);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(19, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(730, 256);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Scaling";
            // 
            // label1
            // 
            label1.Location = new Point(326, 59);
            label1.Name = "label1";
            label1.Size = new Size(231, 39);
            label1.TabIndex = 2;
            label1.Text = "% normal size";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // _udPercentSize
            // 
            _udPercentSize.Location = new Point(192, 54);
            _udPercentSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            _udPercentSize.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            _udPercentSize.Name = "_udPercentSize";
            _udPercentSize.Size = new Size(115, 39);
            _udPercentSize.TabIndex = 1;
            _udPercentSize.TextAlign = HorizontalAlignment.Center;
            _udPercentSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // _rdAdjust
            // 
            _rdAdjust.Location = new Point(19, 59);
            _rdAdjust.Name = "_rdAdjust";
            _rdAdjust.Size = new Size(173, 39);
            _rdAdjust.TabIndex = 0;
            _rdAdjust.Text = "Adjust to";
            // 
            // _rdFit
            // 
            _rdFit.Location = new Point(19, 158);
            _rdFit.Name = "_rdFit";
            _rdFit.Size = new Size(135, 39);
            _rdFit.TabIndex = 0;
            _rdFit.Text = "Fit to";
            // 
            // label2
            // 
            label2.Location = new Point(326, 158);
            label2.Name = "label2";
            label2.Size = new Size(192, 39);
            label2.TabIndex = 2;
            label2.Text = "pages wide by";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // _udAcross
            // 
            _udAcross.Location = new Point(192, 153);
            _udAcross.Name = "_udAcross";
            _udAcross.Size = new Size(115, 39);
            _udAcross.TabIndex = 1;
            _udAcross.TextAlign = HorizontalAlignment.Center;
            // 
            // _udDown
            // 
            _udDown.Location = new Point(518, 153);
            _udDown.Name = "_udDown";
            _udDown.Size = new Size(116, 39);
            _udDown.TabIndex = 1;
            _udDown.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Location = new Point(653, 158);
            label3.Name = "label3";
            label3.Size = new Size(57, 39);
            label3.TabIndex = 2;
            label3.Text = "tall";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.Location = new Point(38, 729);
            label5.Name = "label5";
            label5.Size = new Size(250, 39);
            label5.TabIndex = 2;
            label5.Text = "First page number";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // _txtStartPage
            // 
            _txtStartPage.Location = new Point(288, 729);
            _txtStartPage.Name = "_txtStartPage";
            _txtStartPage.Size = new Size(269, 39);
            _txtStartPage.TabIndex = 4;
            _txtStartPage.Text = "Auto";
            // 
            // button2
            // 
            button2.Location = new Point(346, 20);
            button2.Name = "button2";
            button2.Size = new Size(288, 59);
            button2.TabIndex = 0;
            button2.Text = "Save";
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(_udLeft);
            groupBox3.Controls.Add(_udRight);
            groupBox3.Controls.Add(_udTop);
            groupBox3.Controls.Add(_udBottom);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(_udFooter);
            groupBox3.Controls.Add(_udHeader);
            groupBox3.Location = new Point(768, 276);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(691, 256);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Margins";
            // 
            // label6
            // 
            label6.Location = new Point(19, 59);
            label6.Name = "label6";
            label6.Size = new Size(135, 39);
            label6.TabIndex = 0;
            label6.Text = "Left";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            label7.Location = new Point(365, 59);
            label7.Name = "label7";
            label7.Size = new Size(134, 39);
            label7.TabIndex = 0;
            label7.Text = "Right";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            label8.Location = new Point(19, 118);
            label8.Name = "label8";
            label8.Size = new Size(135, 40);
            label8.TabIndex = 0;
            label8.Text = "Top";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            label9.Location = new Point(365, 118);
            label9.Name = "label9";
            label9.Size = new Size(134, 40);
            label9.TabIndex = 0;
            label9.Text = "Bottom";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // _udLeft
            // 
            _udLeft.DecimalPlaces = 2;
            _udLeft.Location = new Point(154, 59);
            _udLeft.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            _udLeft.Name = "_udLeft";
            _udLeft.Size = new Size(172, 39);
            _udLeft.TabIndex = 1;
            _udLeft.TextAlign = HorizontalAlignment.Center;
            _udLeft.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // _udRight
            // 
            _udRight.DecimalPlaces = 2;
            _udRight.Location = new Point(499, 59);
            _udRight.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            _udRight.Name = "_udRight";
            _udRight.Size = new Size(173, 39);
            _udRight.TabIndex = 1;
            _udRight.TextAlign = HorizontalAlignment.Center;
            _udRight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // _udTop
            // 
            _udTop.DecimalPlaces = 2;
            _udTop.Location = new Point(154, 118);
            _udTop.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            _udTop.Name = "_udTop";
            _udTop.Size = new Size(172, 39);
            _udTop.TabIndex = 1;
            _udTop.TextAlign = HorizontalAlignment.Center;
            _udTop.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // _udBottom
            // 
            _udBottom.DecimalPlaces = 2;
            _udBottom.Location = new Point(499, 118);
            _udBottom.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            _udBottom.Name = "_udBottom";
            _udBottom.Size = new Size(173, 39);
            _udBottom.TabIndex = 1;
            _udBottom.TextAlign = HorizontalAlignment.Center;
            _udBottom.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.Location = new Point(19, 177);
            label10.Name = "label10";
            label10.Size = new Size(135, 40);
            label10.TabIndex = 0;
            label10.Text = "Header";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            label11.Location = new Point(365, 177);
            label11.Name = "label11";
            label11.Size = new Size(134, 40);
            label11.TabIndex = 0;
            label11.Text = "Footer";
            label11.TextAlign = ContentAlignment.BottomLeft;
            // 
            // _udFooter
            // 
            _udFooter.DecimalPlaces = 2;
            _udFooter.Location = new Point(499, 177);
            _udFooter.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            _udFooter.Name = "_udFooter";
            _udFooter.Size = new Size(173, 39);
            _udFooter.TabIndex = 1;
            _udFooter.TextAlign = HorizontalAlignment.Center;
            _udFooter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // _udHeader
            // 
            _udHeader.DecimalPlaces = 2;
            _udHeader.Location = new Point(154, 177);
            _udHeader.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            _udHeader.Name = "_udHeader";
            _udHeader.Size = new Size(172, 39);
            _udHeader.TabIndex = 1;
            _udHeader.TextAlign = HorizontalAlignment.Center;
            _udHeader.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // _txtHeader
            // 
            _txtHeader.Location = new Point(288, 571);
            _txtHeader.Name = "_txtHeader";
            _txtHeader.Size = new Size(1171, 39);
            _txtHeader.TabIndex = 4;
            // 
            // _txtFooter
            // 
            _txtFooter.Location = new Point(288, 650);
            _txtFooter.Name = "_txtFooter";
            _txtFooter.Size = new Size(1171, 39);
            _txtFooter.TabIndex = 4;
            // 
            // label12
            // 
            label12.Location = new Point(38, 650);
            label12.Name = "label12";
            label12.Size = new Size(250, 39);
            label12.TabIndex = 2;
            label12.Text = "Page Footer";
            label12.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label13
            // 
            label13.Location = new Point(38, 571);
            label13.Name = "label13";
            label13.Size = new Size(250, 39);
            label13.TabIndex = 2;
            label13.Text = "Page Header";
            label13.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            AutoScaleBaseSize = new Size(12, 32);
            ClientSize = new Size(618, 335);
            Controls.Add(groupBox3);
            Controls.Add(_txtStartPage);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(_txtHeader);
            Controls.Add(_txtFooter);
            Controls.Add(label12);
            Controls.Add(label13);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C1Excel: Print settings";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((ISupportInitialize)_udPercentSize).EndInit();
            ((ISupportInitialize)_udAcross).EndInit();
            ((ISupportInitialize)_udDown).EndInit();
            groupBox3.ResumeLayout(false);
            ((ISupportInitialize)_udLeft).EndInit();
            ((ISupportInitialize)_udRight).EndInit();
            ((ISupportInitialize)_udTop).EndInit();
            ((ISupportInitialize)_udBottom).EndInit();
            ((ISupportInitialize)_udFooter).EndInit();
            ((ISupportInitialize)_udHeader).EndInit();
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
            Process.Start(new ProcessStartInfo { FileName = xlsFile, UseShellExecute = true });
		}

		// read print settings from sheet, show in form
		private void ShowPrintSettings()
		{
			XLSheet sheet = c1XLBook1.Sheets[0];
			XLPrintSettings ps = sheet.PrintSettings;

			// paper size, orientation
			_cmbPaperSize.SelectedItem = (PaperKind)(int)ps.PaperKind;
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
