namespace CustomDialogs
{
    partial class ObjectEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
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
            this._cgbxImage = new System.Windows.Forms.Panel();
            this._lblTitle = new System.Windows.Forms.Label();
            this._tbTitle = new System.Windows.Forms.TextBox();
            this._lblSource = new System.Windows.Forms.Label();
            this._tbData = new System.Windows.Forms.TextBox();
            this._btnSelectFile = new System.Windows.Forms.Button();
            this._cgbxSize = new System.Windows.Forms.GroupBox();
            this._chkHeight = new System.Windows.Forms.CheckBox();
            this._chkWidth = new System.Windows.Forms.CheckBox();
            this._cbxHeightType = new System.Windows.Forms.ComboBox();
            this._nudHeightValue = new System.Windows.Forms.NumericUpDown();
            this._cbxWidthType = new System.Windows.Forms.ComboBox();
            this._nudWidthValue = new System.Windows.Forms.NumericUpDown();
            this._cgbxOptions = new System.Windows.Forms.GroupBox();
            this._chbLoop = new System.Windows.Forms.CheckBox();
            this._chbAutoplay = new System.Windows.Forms.CheckBox();
            this._containerMain.SuspendLayout();
            this._cgbxImage.SuspendLayout();
            this._cgbxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudHeightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudWidthValue)).BeginInit();
            this._cgbxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(256, 286);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(353, 286);
            // 
            // _btnAplly
            // 
            this._btnAplly.Location = new System.Drawing.Point(450, 286);
            // 
            // _containerMain
            // 
            this._containerMain.Controls.Add(this._cgbxOptions);
            this._containerMain.Controls.Add(this._cgbxSize);
            this._containerMain.Controls.Add(this._cgbxImage);
            this._containerMain.Size = new System.Drawing.Size(529, 268);
            // 
            // _cgbxImage
            // 
            this._cgbxImage.Controls.Add(this._lblTitle);
            this._cgbxImage.Controls.Add(this._tbTitle);
            this._cgbxImage.Controls.Add(this._lblSource);
            this._cgbxImage.Controls.Add(this._tbData);
            this._cgbxImage.Controls.Add(this._btnSelectFile);
            this._cgbxImage.Dock = System.Windows.Forms.DockStyle.Top;
            this._cgbxImage.Location = new System.Drawing.Point(3, 17);
            this._cgbxImage.Name = "_cgbxImage";
            this._cgbxImage.Size = new System.Drawing.Size(523, 74);
            this._cgbxImage.TabIndex = 6;
            this._cgbxImage.Text = "&Path";
            // 
            // _lblTitle
            // 
            this._lblTitle.AutoSize = true;
            this._lblTitle.Location = new System.Drawing.Point(3, 46);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(87, 13);
            this._lblTitle.TabIndex = 3;
            this._lblTitle.Text = "&Alternative text:";
            // 
            // _tbTitle
            // 
            this._tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbTitle.Location = new System.Drawing.Point(92, 41);
            this._tbTitle.Name = "_tbTitle";
            this._tbTitle.Size = new System.Drawing.Size(420, 21);
            this._tbTitle.TabIndex = 4;
            // 
            // _lblSource
            // 
            this._lblSource.AutoSize = true;
            this._lblSource.Location = new System.Drawing.Point(24, 19);
            this._lblSource.Name = "_lblSource";
            this._lblSource.Size = new System.Drawing.Size(66, 13);
            this._lblSource.TabIndex = 0;
            this._lblSource.Text = "Source &URL:";
            // 
            // _tbData
            // 
            this._tbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbData.Location = new System.Drawing.Point(92, 14);
            this._tbData.Name = "_tbData";
            this._tbData.Size = new System.Drawing.Size(389, 21);
            this._tbData.TabIndex = 1;
            // 
            // _btnSelectFile
            // 
            this._btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSelectFile.Image = global::CustomDialogs.Properties.Resources.openfolder;
            this._btnSelectFile.Location = new System.Drawing.Point(487, 14);
            this._btnSelectFile.Name = "_btnSelectFile";
            this._btnSelectFile.Size = new System.Drawing.Size(27, 21);
            this._btnSelectFile.TabIndex = 2;
            this._btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // _cgbxSize
            // 
            this._cgbxSize.Controls.Add(this._chkHeight);
            this._cgbxSize.Controls.Add(this._chkWidth);
            this._cgbxSize.Controls.Add(this._cbxHeightType);
            this._cgbxSize.Controls.Add(this._nudHeightValue);
            this._cgbxSize.Controls.Add(this._cbxWidthType);
            this._cgbxSize.Controls.Add(this._nudWidthValue);
            this._cgbxSize.Dock = System.Windows.Forms.DockStyle.Top;
            this._cgbxSize.Location = new System.Drawing.Point(3, 91);
            this._cgbxSize.Name = "_cgbxSize";
            this._cgbxSize.Size = new System.Drawing.Size(523, 75);
            this._cgbxSize.TabIndex = 7;
            this._cgbxSize.TabStop = false;
            this._cgbxSize.Text = "Size";
            // 
            // _chkHeight
            // 
            this._chkHeight.AutoSize = true;
            this._chkHeight.Checked = true;
            this._chkHeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkHeight.Location = new System.Drawing.Point(19, 47);
            this._chkHeight.Name = "_chkHeight";
            this._chkHeight.Size = new System.Drawing.Size(98, 17);
            this._chkHeight.TabIndex = 3;
            this._chkHeight.Text = "Specify &height:";
            this._chkHeight.UseVisualStyleBackColor = true;
            // 
            // _chkWidth
            // 
            this._chkWidth.AutoSize = true;
            this._chkWidth.Checked = true;
            this._chkWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkWidth.Location = new System.Drawing.Point(19, 21);
            this._chkWidth.Name = "_chkWidth";
            this._chkWidth.Size = new System.Drawing.Size(94, 17);
            this._chkWidth.TabIndex = 0;
            this._chkWidth.Text = "Specify &width:";
            this._chkWidth.UseVisualStyleBackColor = true;
            // 
            // _cbxHeightType
            // 
            this._cbxHeightType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._cbxHeightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxHeightType.FormattingEnabled = true;
            this._cbxHeightType.Location = new System.Drawing.Point(220, 46);
            this._cbxHeightType.Name = "_cbxHeightType";
            this._cbxHeightType.Size = new System.Drawing.Size(292, 21);
            this._cbxHeightType.TabIndex = 5;
            // 
            // _nudHeightValue
            // 
            this._nudHeightValue.Location = new System.Drawing.Point(121, 46);
            this._nudHeightValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this._nudHeightValue.Name = "_nudHeightValue";
            this._nudHeightValue.Size = new System.Drawing.Size(95, 21);
            this._nudHeightValue.TabIndex = 4;
            // 
            // _cbxWidthType
            // 
            this._cbxWidthType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._cbxWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxWidthType.FormattingEnabled = true;
            this._cbxWidthType.Location = new System.Drawing.Point(220, 19);
            this._cbxWidthType.Name = "_cbxWidthType";
            this._cbxWidthType.Size = new System.Drawing.Size(292, 21);
            this._cbxWidthType.TabIndex = 2;
            // 
            // _nudWidthValue
            // 
            this._nudWidthValue.Location = new System.Drawing.Point(121, 19);
            this._nudWidthValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this._nudWidthValue.Name = "_nudWidthValue";
            this._nudWidthValue.Size = new System.Drawing.Size(95, 21);
            this._nudWidthValue.TabIndex = 1;
            // 
            // _cgbxOptions
            // 
            this._cgbxOptions.Controls.Add(this._chbLoop);
            this._cgbxOptions.Controls.Add(this._chbAutoplay);
            this._cgbxOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this._cgbxOptions.Location = new System.Drawing.Point(3, 166);
            this._cgbxOptions.Name = "_cgbxOptions";
            this._cgbxOptions.Size = new System.Drawing.Size(523, 72);
            this._cgbxOptions.TabIndex = 8;
            this._cgbxOptions.TabStop = false;
            this._cgbxOptions.Text = "Options";
            // 
            // _chbLoop
            // 
            this._chbLoop.AutoSize = true;
            this._chbLoop.Location = new System.Drawing.Point(19, 47);
            this._chbLoop.Name = "_chbLoop";
            this._chbLoop.Size = new System.Drawing.Size(49, 17);
            this._chbLoop.TabIndex = 1;
            this._chbLoop.Text = "&Loop";
            this._chbLoop.UseVisualStyleBackColor = true;
            // 
            // _chbAutoplay
            // 
            this._chbAutoplay.AutoSize = true;
            this._chbAutoplay.Location = new System.Drawing.Point(19, 21);
            this._chbAutoplay.Name = "_chbAutoplay";
            this._chbAutoplay.Size = new System.Drawing.Size(69, 17);
            this._chbAutoplay.TabIndex = 0;
            this._chbAutoplay.Text = "Auto&play";
            this._chbAutoplay.UseVisualStyleBackColor = true;
            // 
            // ObjectEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(553, 323);
            this.MinimumSize = new System.Drawing.Size(561, 174);
            this.Name = "ObjectEditorForm";
            this.Text = "Movie in Flash Format Properties";
            this._containerMain.ResumeLayout(false);
            this._cgbxImage.ResumeLayout(false);
            this._cgbxImage.PerformLayout();
            this._cgbxSize.ResumeLayout(false);
            this._cgbxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudHeightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudWidthValue)).EndInit();
            this._cgbxOptions.ResumeLayout(false);
            this._cgbxOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _cgbxImage;
        private System.Windows.Forms.Label _lblSource;
        private System.Windows.Forms.TextBox _tbData;
        private System.Windows.Forms.Button _btnSelectFile;
        private System.Windows.Forms.GroupBox _cgbxSize;
        private System.Windows.Forms.ComboBox _cbxHeightType;
        private System.Windows.Forms.NumericUpDown _nudHeightValue;
        private System.Windows.Forms.ComboBox _cbxWidthType;
        private System.Windows.Forms.NumericUpDown _nudWidthValue;
        private System.Windows.Forms.CheckBox _chkHeight;
        private System.Windows.Forms.CheckBox _chkWidth;
        private System.Windows.Forms.GroupBox _cgbxOptions;
        private System.Windows.Forms.CheckBox _chbLoop;
        private System.Windows.Forms.CheckBox _chbAutoplay;
        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.TextBox _tbTitle;


    }
}
