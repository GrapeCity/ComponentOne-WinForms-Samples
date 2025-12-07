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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnFile = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tbFile = new System.Windows.Forms.TextBox();
            tbFindText = new System.Windows.Forms.TextBox();
            cbxCaseSensitive = new System.Windows.Forms.CheckBox();
            cbxWholeWord = new System.Windows.Forms.CheckBox();
            btnFind = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            lvFoundPositions = new System.Windows.Forms.ListView();
            chNum = new System.Windows.Forms.ColumnHeader();
            chPage = new System.Windows.Forms.ColumnHeader();
            chBounds = new System.Windows.Forms.ColumnHeader();
            chPosInNearText = new System.Windows.Forms.ColumnHeader();
            chNearText = new System.Windows.Forms.ColumnHeader();
            label3 = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            pbFind = new System.Windows.Forms.ProgressBar();
            rbWholeDocument = new System.Windows.Forms.RadioButton();
            label4 = new System.Windows.Forms.Label();
            rbSinglePage = new System.Windows.Forms.RadioButton();
            nudPageIndex = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPageIndex).BeginInit();
            SuspendLayout();
            // 
            // btnFile
            // 
            btnFile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFile.Location = new System.Drawing.Point(755, 14);
            btnFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFile.Name = "btnFile";
            btnFile.Size = new System.Drawing.Size(30, 23);
            btnFile.TabIndex = 2;
            btnFile.Text = "...";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += btnFile_Click;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(14, 14);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 23);
            label1.TabIndex = 0;
            label1.Text = "PDF file:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFile
            // 
            tbFile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbFile.Location = new System.Drawing.Point(138, 14);
            tbFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbFile.Name = "tbFile";
            tbFile.Size = new System.Drawing.Size(610, 23);
            tbFile.TabIndex = 1;
            // 
            // tbFindText
            // 
            tbFindText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbFindText.Location = new System.Drawing.Point(138, 44);
            tbFindText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbFindText.Name = "tbFindText";
            tbFindText.Size = new System.Drawing.Size(420, 23);
            tbFindText.TabIndex = 4;
            tbFindText.TextChanged += tbFindText_TextChanged;
            // 
            // cbxCaseSensitive
            // 
            cbxCaseSensitive.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbxCaseSensitive.AutoSize = true;
            cbxCaseSensitive.Location = new System.Drawing.Point(578, 46);
            cbxCaseSensitive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbxCaseSensitive.Name = "cbxCaseSensitive";
            cbxCaseSensitive.Size = new System.Drawing.Size(100, 19);
            cbxCaseSensitive.TabIndex = 5;
            cbxCaseSensitive.Text = "Case Sensitive";
            cbxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // cbxWholeWord
            // 
            cbxWholeWord.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbxWholeWord.AutoSize = true;
            cbxWholeWord.Location = new System.Drawing.Point(693, 46);
            cbxWholeWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbxWholeWord.Name = "cbxWholeWord";
            cbxWholeWord.Size = new System.Drawing.Size(92, 19);
            cbxWholeWord.TabIndex = 6;
            cbxWholeWord.Text = "Whole Word";
            cbxWholeWord.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new System.Drawing.Point(138, 104);
            btnFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(88, 27);
            btnFind.TabIndex = 11;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(14, 44);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 23);
            label2.TabIndex = 3;
            label2.Text = "Search Params:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvFoundPositions
            // 
            lvFoundPositions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lvFoundPositions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chNum, chPage, chBounds, chPosInNearText, chNearText });
            lvFoundPositions.FullRowSelect = true;
            lvFoundPositions.Location = new System.Drawing.Point(14, 170);
            lvFoundPositions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lvFoundPositions.Name = "lvFoundPositions";
            lvFoundPositions.Size = new System.Drawing.Size(770, 324);
            lvFoundPositions.TabIndex = 13;
            lvFoundPositions.UseCompatibleStateImageBehavior = false;
            lvFoundPositions.View = System.Windows.Forms.View.Details;
            // 
            // chNum
            // 
            chNum.Text = "#";
            chNum.Width = 50;
            // 
            // chPage
            // 
            chPage.Text = "Page";
            // 
            // chBounds
            // 
            chBounds.Text = "Bounds";
            chBounds.Width = 100;
            // 
            // chPosInNearText
            // 
            chPosInNearText.Text = "Pos In Near Text";
            // 
            // chNearText
            // 
            chNearText.Text = "Near Text";
            chNearText.Width = 350;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 151);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "Find Results:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "pdf";
            openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // pbFind
            // 
            pbFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pbFind.Location = new System.Drawing.Point(14, 501);
            pbFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pbFind.Name = "pbFind";
            pbFind.Size = new System.Drawing.Size(771, 6);
            pbFind.TabIndex = 14;
            // 
            // rbWholeDocument
            // 
            rbWholeDocument.AutoSize = true;
            rbWholeDocument.Checked = true;
            rbWholeDocument.Location = new System.Drawing.Point(138, 77);
            rbWholeDocument.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbWholeDocument.Name = "rbWholeDocument";
            rbWholeDocument.Size = new System.Drawing.Size(118, 19);
            rbWholeDocument.TabIndex = 8;
            rbWholeDocument.TabStop = true;
            rbWholeDocument.Text = "Whole Document";
            rbWholeDocument.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(14, 75);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 23);
            label4.TabIndex = 7;
            label4.Text = "Search Scope:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbSinglePage
            // 
            rbSinglePage.AutoSize = true;
            rbSinglePage.Location = new System.Drawing.Point(271, 77);
            rbSinglePage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbSinglePage.Name = "rbSinglePage";
            rbSinglePage.Size = new System.Drawing.Size(89, 19);
            rbSinglePage.TabIndex = 9;
            rbSinglePage.Text = "Single Page:";
            rbSinglePage.UseVisualStyleBackColor = true;
            // 
            // nudPageIndex
            // 
            nudPageIndex.Location = new System.Drawing.Point(377, 75);
            nudPageIndex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nudPageIndex.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            nudPageIndex.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPageIndex.Name = "nudPageIndex";
            nudPageIndex.Size = new System.Drawing.Size(88, 23);
            nudPageIndex.TabIndex = 10;
            nudPageIndex.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(799, 520);
            Controls.Add(nudPageIndex);
            Controls.Add(rbSinglePage);
            Controls.Add(label4);
            Controls.Add(rbWholeDocument);
            Controls.Add(pbFind);
            Controls.Add(label3);
            Controls.Add(lvFoundPositions);
            Controls.Add(label2);
            Controls.Add(btnFind);
            Controls.Add(cbxWholeWord);
            Controls.Add(cbxCaseSensitive);
            Controls.Add(tbFindText);
            Controls.Add(btnFile);
            Controls.Add(label1);
            Controls.Add(tbFile);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Search text in PDF file";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)nudPageIndex).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private C1.Document.C1PdfDocumentSource c1PdfDocumentSource1;
        private System.Windows.Forms.ColumnHeader chPosInNearText;
        private System.Windows.Forms.RadioButton rbWholeDocument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSinglePage;
        private System.Windows.Forms.NumericUpDown nudPageIndex;
    }
}

