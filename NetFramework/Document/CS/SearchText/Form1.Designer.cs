namespace SearchText
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
            this.components = new System.ComponentModel.Container();
            this.btnFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.tbFindText = new System.Windows.Forms.TextBox();
            this.cbxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.cbxWholeWord = new System.Windows.Forms.CheckBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvFoundPositions = new System.Windows.Forms.ListView();
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBounds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPosInNearText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNearText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbFind = new System.Windows.Forms.ProgressBar();
            this.c1PdfDocumentSource1 = new C1.Win.Document.C1PdfDocumentSource(this.components);
            this.rbWholeDocument = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSinglePage = new System.Windows.Forms.RadioButton();
            this.nudPageIndex = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Location = new System.Drawing.Point(647, 12);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(26, 20);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF file:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFile
            // 
            this.tbFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFile.Location = new System.Drawing.Point(118, 12);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(523, 20);
            this.tbFile.TabIndex = 1;
            // 
            // tbFindText
            // 
            this.tbFindText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFindText.Location = new System.Drawing.Point(118, 38);
            this.tbFindText.Name = "tbFindText";
            this.tbFindText.Size = new System.Drawing.Size(361, 20);
            this.tbFindText.TabIndex = 4;
            this.tbFindText.TextChanged += new System.EventHandler(this.tbFindText_TextChanged);
            // 
            // cbxCaseSensitive
            // 
            this.cbxCaseSensitive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCaseSensitive.AutoSize = true;
            this.cbxCaseSensitive.Location = new System.Drawing.Point(485, 40);
            this.cbxCaseSensitive.Name = "cbxCaseSensitive";
            this.cbxCaseSensitive.Size = new System.Drawing.Size(96, 17);
            this.cbxCaseSensitive.TabIndex = 5;
            this.cbxCaseSensitive.Text = "Case Sensitive";
            this.cbxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // cbxWholeWord
            // 
            this.cbxWholeWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxWholeWord.AutoSize = true;
            this.cbxWholeWord.Location = new System.Drawing.Point(587, 40);
            this.cbxWholeWord.Name = "cbxWholeWord";
            this.cbxWholeWord.Size = new System.Drawing.Size(86, 17);
            this.cbxWholeWord.TabIndex = 6;
            this.cbxWholeWord.Text = "Whole Word";
            this.cbxWholeWord.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(118, 90);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Params:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvFoundPositions
            // 
            this.lvFoundPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFoundPositions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNum,
            this.chPage,
            this.chBounds,
            this.chPosInNearText,
            this.chNearText});
            this.lvFoundPositions.FullRowSelect = true;
            this.lvFoundPositions.Location = new System.Drawing.Point(12, 147);
            this.lvFoundPositions.Name = "lvFoundPositions";
            this.lvFoundPositions.Size = new System.Drawing.Size(661, 281);
            this.lvFoundPositions.TabIndex = 13;
            this.lvFoundPositions.UseCompatibleStateImageBehavior = false;
            this.lvFoundPositions.View = System.Windows.Forms.View.Details;
            // 
            // chNum
            // 
            this.chNum.Text = "#";
            this.chNum.Width = 50;
            // 
            // chPage
            // 
            this.chPage.Text = "Page";
            // 
            // chBounds
            // 
            this.chBounds.Text = "Bounds";
            this.chBounds.Width = 100;
            // 
            // chPosInNearText
            // 
            this.chPosInNearText.Text = "Pos In Near Text";
            // 
            // chNearText
            // 
            this.chNearText.Text = "Near Text";
            this.chNearText.Width = 350;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Find Results:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "pdf";
            this.openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // pbFind
            // 
            this.pbFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFind.Location = new System.Drawing.Point(12, 434);
            this.pbFind.Name = "pbFind";
            this.pbFind.Size = new System.Drawing.Size(661, 5);
            this.pbFind.TabIndex = 14;
            // 
            // rbWholeDocument
            // 
            this.rbWholeDocument.AutoSize = true;
            this.rbWholeDocument.Checked = true;
            this.rbWholeDocument.Location = new System.Drawing.Point(118, 67);
            this.rbWholeDocument.Name = "rbWholeDocument";
            this.rbWholeDocument.Size = new System.Drawing.Size(108, 17);
            this.rbWholeDocument.TabIndex = 8;
            this.rbWholeDocument.TabStop = true;
            this.rbWholeDocument.Text = "Whole Document";
            this.rbWholeDocument.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search Scope:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbSinglePage
            // 
            this.rbSinglePage.AutoSize = true;
            this.rbSinglePage.Location = new System.Drawing.Point(232, 67);
            this.rbSinglePage.Name = "rbSinglePage";
            this.rbSinglePage.Size = new System.Drawing.Size(85, 17);
            this.rbSinglePage.TabIndex = 9;
            this.rbSinglePage.Text = "Single Page:";
            this.rbSinglePage.UseVisualStyleBackColor = true;
            // 
            // nudPageIndex
            // 
            this.nudPageIndex.Location = new System.Drawing.Point(323, 65);
            this.nudPageIndex.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPageIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPageIndex.Name = "nudPageIndex";
            this.nudPageIndex.Size = new System.Drawing.Size(75, 20);
            this.nudPageIndex.TabIndex = 10;
            this.nudPageIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 451);
            this.Controls.Add(this.nudPageIndex);
            this.Controls.Add(this.rbSinglePage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbWholeDocument);
            this.Controls.Add(this.pbFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvFoundPositions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cbxWholeWord);
            this.Controls.Add(this.cbxCaseSensitive);
            this.Controls.Add(this.tbFindText);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFile);
            this.Name = "Form1";
            this.Text = "Search text in PDF file";
            ((System.ComponentModel.ISupportInitialize)(this.nudPageIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.TextBox tbFindText;
        private System.Windows.Forms.CheckBox cbxCaseSensitive;
        private System.Windows.Forms.CheckBox cbxWholeWord;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvFoundPositions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar pbFind;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chPage;
        private System.Windows.Forms.ColumnHeader chBounds;
        private System.Windows.Forms.ColumnHeader chNearText;
        private C1.Win.Document.C1PdfDocumentSource c1PdfDocumentSource1;
        private System.Windows.Forms.ColumnHeader chPosInNearText;
        private System.Windows.Forms.RadioButton rbWholeDocument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSinglePage;
        private System.Windows.Forms.NumericUpDown nudPageIndex;
    }
}

