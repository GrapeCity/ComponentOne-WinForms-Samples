namespace FlowHtml
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            _cmbFiles = new System.Windows.Forms.ComboBox();
            _cmbColumns = new System.Windows.Forms.ComboBox();
            _btnLandscape = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            _status = new System.Windows.Forms.ToolStripStatusLabel();
            _c1pdf = new C1.Win.Pdf.C1PdfDocument();
            groupBox1 = new System.Windows.Forms.GroupBox();
            webBrowser1 = new System.Windows.Forms.WebBrowser();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(548, 23);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(104, 26);
            button1.TabIndex = 1;
            button1.Text = "Show Pdf...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "&Document";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(180, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "Number of &Columns";
            // 
            // _cmbFiles
            // 
            _cmbFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cmbFiles.FormattingEnabled = true;
            _cmbFiles.Location = new System.Drawing.Point(14, 29);
            _cmbFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            _cmbFiles.Name = "_cmbFiles";
            _cmbFiles.Size = new System.Drawing.Size(161, 23);
            _cmbFiles.Sorted = true;
            _cmbFiles.TabIndex = 5;
            _cmbFiles.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // _cmbColumns
            // 
            _cmbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cmbColumns.FormattingEnabled = true;
            _cmbColumns.Location = new System.Drawing.Point(183, 29);
            _cmbColumns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            _cmbColumns.Name = "_cmbColumns";
            _cmbColumns.Size = new System.Drawing.Size(161, 23);
            _cmbColumns.TabIndex = 5;
            // 
            // _btnLandscape
            // 
            _btnLandscape.AutoSize = true;
            _btnLandscape.Location = new System.Drawing.Point(82, 20);
            _btnLandscape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            _btnLandscape.Name = "_btnLandscape";
            _btnLandscape.Size = new System.Drawing.Size(81, 19);
            _btnLandscape.TabIndex = 4;
            _btnLandscape.TabStop = true;
            _btnLandscape.Text = "&Landscape";
            _btnLandscape.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(7, 20);
            radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(64, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "&Portrait";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { _status });
            statusStrip1.Location = new System.Drawing.Point(0, 546);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(705, 22);
            statusStrip1.TabIndex = 7;
            // 
            // _status
            // 
            _status.Name = "_status";
            _status.Size = new System.Drawing.Size(688, 17);
            _status.Spring = true;
            _status.Text = "Ready";
            _status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _c1pdf
            // 
            _c1pdf.ClipRectPath = (System.Drawing.RectangleF)resources.GetObject("_c1pdf.ClipRectPath");
            _c1pdf.CurrentFontIndex = 0;
            _c1pdf.CustomCallback = null;
            _c1pdf.DocumentInfo.Author = "";
            _c1pdf.DocumentInfo.CreationDate = new System.DateTime(0L);
            _c1pdf.DocumentInfo.Creator = "";
            _c1pdf.DocumentInfo.Keywords = "";
            _c1pdf.DocumentInfo.Producer = "C1.Pdf";
            _c1pdf.DocumentInfo.Subject = "";
            _c1pdf.DocumentInfo.Title = "";
            _c1pdf.PathState = C1.Pdf.PdfPathState.None;
            _c1pdf.PdfVersion = "1.3";
            _c1pdf.RefDC = null;
            _c1pdf.RotateAngle = 0F;
            _c1pdf.StopPathClip = false;
            _c1pdf.UseFontShaping = true;
            _c1pdf.ViewerPreferences.DisplayDocTitle = false;
            _c1pdf.ViewerPreferences.Duplex = C1.Pdf.Duplex.Simplex;
            _c1pdf.ViewerPreferences.HideWindowUI = false;
            _c1pdf.ViewerPreferences.NonFullScreenPageMode = C1.Pdf.PageMode.UseNone;
            _c1pdf.ViewerPreferences.NumCopies = 0;
            _c1pdf.ViewerPreferences.PickTrayByPDFSize = null;
            _c1pdf.ViewerPreferences.PrintPageRange = "";
            _c1pdf.ViewerPreferences.PrintScaling = C1.Pdf.PrintScaling.AppDefault;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(_btnLandscape);
            groupBox1.Location = new System.Drawing.Point(357, 10);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(184, 44);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orientation";
            // 
            // webBrowser1
            // 
            webBrowser1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            webBrowser1.Location = new System.Drawing.Point(14, 61);
            webBrowser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            webBrowser1.MinimumSize = new System.Drawing.Size(23, 23);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new System.Drawing.Size(688, 478);
            webBrowser1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(705, 568);
            Controls.Add(webBrowser1);
            Controls.Add(_cmbColumns);
            Controls.Add(_cmbFiles);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Padding = new System.Windows.Forms.Padding(0, 69, 0, 0);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "C1Pdf: Flow HTML text into Pdf documents";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C1.Win.Pdf.C1PdfDocument _c1pdf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cmbFiles;
        private System.Windows.Forms.ComboBox _cmbColumns;
        private System.Windows.Forms.RadioButton _btnLandscape;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

