namespace ControlExplorer.Word
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    partial class WordCreator : C1DemoForm
    {

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
            this.components = new System.ComponentModel.Container();
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
            this._groupFormat = new System.Windows.Forms.GroupBox();
            this._check2007 = new System.Windows.Forms.CheckBox();
            this._comboFormat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._statusBar = new System.Windows.Forms.StatusBar();
            this._groupWrite.SuspendLayout();
            this._groupRead.SuspendLayout();
            this._groupFormat.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSimple
            // 
            this.btSimple.BackColor = System.Drawing.SystemColors.Info;
            this.btSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSimple.Location = new System.Drawing.Point(16, 24);
            this.btSimple.Name = "btSimple";
            this.btSimple.Size = new System.Drawing.Size(91, 24);
            this.btSimple.TabIndex = 1;
            this.btSimple.Text = "Simple";
            this.btSimple.UseVisualStyleBackColor = false;
            this.btSimple.Click += new System.EventHandler(this.btSimple_Click);
            // 
            // _btRead
            // 
            this._btRead.BackColor = System.Drawing.SystemColors.Info;
            this._btRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btRead.Location = new System.Drawing.Point(9, 26);
            this._btRead.Name = "_btRead";
            this._btRead.Size = new System.Drawing.Size(91, 24);
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
            this._tbPicture.Size = new System.Drawing.Size(91, 24);
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
            this._btTable.Size = new System.Drawing.Size(91, 24);
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
            this._btGraphics.Size = new System.Drawing.Size(91, 24);
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
            this._btMetafile.Size = new System.Drawing.Size(91, 24);
            this._btMetafile.TabIndex = 8;
            this._btMetafile.Text = "Metafile";
            this._btMetafile.UseVisualStyleBackColor = false;
            this._btMetafile.Click += new System.EventHandler(this._btMetafile_Click);
            // 
            // _groupWrite
            // 
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
            this._groupWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupWrite.Location = new System.Drawing.Point(3, 3);
            this._groupWrite.Name = "_groupWrite";
            this.tableLayoutPanel1.SetRowSpan(this._groupWrite, 2);
            this._groupWrite.Size = new System.Drawing.Size(744, 311);
            this._groupWrite.TabIndex = 6;
            this._groupWrite.TabStop = false;
            this._groupWrite.Text = "Write documents";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Convert metafile to the document.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Various curves.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Graphics primitives in field.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Complex (pictures, lists, tables, graphics...).";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Show all fonts in our computer.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Show any picture.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Example with tables.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
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
            this._btComplex.Size = new System.Drawing.Size(91, 24);
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
            this._btFonts.Size = new System.Drawing.Size(91, 24);
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
            this._btCurve.Size = new System.Drawing.Size(91, 24);
            this._btCurve.TabIndex = 7;
            this._btCurve.Text = "Curves";
            this._btCurve.UseVisualStyleBackColor = false;
            this._btCurve.Click += new System.EventHandler(this._btCurve_Click);
            // 
            // _groupRead
            // 
            this._groupRead.Controls.Add(this.label1);
            this._groupRead.Controls.Add(this._btRead);
            this._groupRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupRead.Location = new System.Drawing.Point(753, 129);
            this._groupRead.Name = "_groupRead";
            this._groupRead.Size = new System.Drawing.Size(294, 185);
            this._groupRead.TabIndex = 7;
            this._groupRead.TabStop = false;
            this._groupRead.Text = "Read and write documents";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Read document to a object model and create (write) other document.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _groupFormat
            // 
            this._groupFormat.Controls.Add(this._check2007);
            this._groupFormat.Controls.Add(this._comboFormat);
            this._groupFormat.Controls.Add(this.label10);
            this._groupFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupFormat.Location = new System.Drawing.Point(753, 3);
            this._groupFormat.Name = "_groupFormat";
            this._groupFormat.Size = new System.Drawing.Size(294, 120);
            this._groupFormat.TabIndex = 9;
            this._groupFormat.TabStop = false;
            this._groupFormat.Text = "File format";
            // 
            // _check2007
            // 
            this._check2007.Location = new System.Drawing.Point(16, 71);
            this._check2007.Name = "_check2007";
            this._check2007.Size = new System.Drawing.Size(232, 36);
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
            this._comboFormat.Location = new System.Drawing.Point(16, 44);
            this._comboFormat.Name = "_comboFormat";
            this._comboFormat.Size = new System.Drawing.Size(224, 21);
            this._comboFormat.TabIndex = 0;
            this._comboFormat.Text = "DOCX";
            this._comboFormat.SelectedIndexChanged += new System.EventHandler(this._comboFormat_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Select document format for write (DOCX/RTF):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40));
            this.tableLayoutPanel1.Controls.Add(this._groupFormat, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._groupWrite, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._groupRead, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._statusBar, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 636);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // _statusBar
            // 
            this._statusBar.Dock = System.Windows.Forms.DockStyle.None;
            this._statusBar.Location = new System.Drawing.Point(3, 320);
            this._statusBar.Name = "_statusBar";
            this._statusBar.Size = new System.Drawing.Size(335, 30);
            this._statusBar.SizingGrip = false;
            this._statusBar.TabIndex = 8;
            this._statusBar.Text = "Ready.";
            // 
            // WordCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1050, 636);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WordCreator";
            this.Text = "C1Word Demo Creator";
            this._groupWrite.ResumeLayout(false);
            this._groupWrite.PerformLayout();
            this._groupRead.ResumeLayout(false);
            this._groupFormat.ResumeLayout(false);
            this._groupFormat.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btSimple;
        private System.Windows.Forms.Button _btRead;
        private System.Windows.Forms.Button _tbPicture;
        private System.Windows.Forms.Button _btTable;
        private System.Windows.Forms.Button _btGraphics;
        private System.Windows.Forms.Button _btMetafile;
        private System.Windows.Forms.GroupBox _groupWrite;
        private System.Windows.Forms.GroupBox _groupRead;
        private System.Windows.Forms.Button _btCurve;
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
        private System.Windows.Forms.GroupBox _groupFormat;
        private System.Windows.Forms.ComboBox _comboFormat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox _check2007;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusBar _statusBar;
    }
}
