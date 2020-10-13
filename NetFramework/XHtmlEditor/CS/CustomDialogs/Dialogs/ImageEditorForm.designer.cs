namespace CustomDialogs
{
    partial class ImageEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._cgbxImage = new System.Windows.Forms.Panel();
            this._tbAlternate = new System.Windows.Forms.TextBox();
            this._lblAlternate = new System.Windows.Forms.Label();
            this._lblPath = new System.Windows.Forms.Label();
            this._tbSource = new System.Windows.Forms.TextBox();
            this._btnSelectImageSource = new System.Windows.Forms.Button();
            this._cgbxSize = new System.Windows.Forms.GroupBox();
            this._tbHeightValue = new System.Windows.Forms.NumericUpDown();
            this._chkHeight = new System.Windows.Forms.CheckBox();
            this._tbWidthValue = new System.Windows.Forms.NumericUpDown();
            this._chkWidth = new System.Windows.Forms.CheckBox();
            this._cbxWidthType = new System.Windows.Forms.ComboBox();
            this._cbxHeightType = new System.Windows.Forms.ComboBox();
            this._cgbxPreview = new System.Windows.Forms.GroupBox();
            this._pbSourceImage = new System.Windows.Forms.PictureBox();
            this._containerMain.SuspendLayout();
            this._cgbxImage.SuspendLayout();
            this._cgbxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbHeightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tbWidthValue)).BeginInit();
            this._cgbxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbSourceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(240, 319);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(337, 319);
            // 
            // _btnAplly
            // 
            this._btnAplly.Location = new System.Drawing.Point(434, 319);
            // 
            // _containerMain
            // 
            this._containerMain.Controls.Add(this._cgbxPreview);
            this._containerMain.Controls.Add(this._cgbxSize);
            this._containerMain.Controls.Add(this._cgbxImage);
            this._containerMain.Size = new System.Drawing.Size(513, 301);
            // 
            // _cgbxImage
            // 
            this._cgbxImage.Controls.Add(this._tbAlternate);
            this._cgbxImage.Controls.Add(this._lblAlternate);
            this._cgbxImage.Controls.Add(this._lblPath);
            this._cgbxImage.Controls.Add(this._tbSource);
            this._cgbxImage.Controls.Add(this._btnSelectImageSource);
            this._cgbxImage.Dock = System.Windows.Forms.DockStyle.Top;
            this._cgbxImage.Location = new System.Drawing.Point(3, 17);
            this._cgbxImage.Name = "_cgbxImage";
            this._cgbxImage.Size = new System.Drawing.Size(507, 73);
            this._cgbxImage.TabIndex = 0;
            this._cgbxImage.Text = "&Path";
            // 
            // _tbAlternate
            // 
            this._tbAlternate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAlternate.Location = new System.Drawing.Point(96, 39);
            this._tbAlternate.Name = "_tbAlternate";
            this._tbAlternate.Size = new System.Drawing.Size(401, 21);
            this._tbAlternate.TabIndex = 5;
            // 
            // _lblAlternate
            // 
            this._lblAlternate.AutoSize = true;
            this._lblAlternate.Location = new System.Drawing.Point(3, 42);
            this._lblAlternate.Name = "_lblAlternate";
            this._lblAlternate.Size = new System.Drawing.Size(87, 13);
            this._lblAlternate.TabIndex = 4;
            this._lblAlternate.Text = "&Alternative text:";
            // 
            // _lblPath
            // 
            this._lblPath.AutoSize = true;
            this._lblPath.Location = new System.Drawing.Point(34, 15);
            this._lblPath.Name = "_lblPath";
            this._lblPath.Size = new System.Drawing.Size(56, 13);
            this._lblPath.TabIndex = 1;
            this._lblPath.Text = "&File name:";
            // 
            // _tbSource
            // 
            this._tbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSource.Location = new System.Drawing.Point(96, 12);
            this._tbSource.Name = "_tbSource";
            this._tbSource.Size = new System.Drawing.Size(368, 21);
            this._tbSource.TabIndex = 2;
            // 
            // _btnSelectImageSource
            // 
            this._btnSelectImageSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSelectImageSource.Image = global::CustomDialogs.Properties.Resources.openfolder;
            this._btnSelectImageSource.Location = new System.Drawing.Point(470, 12);
            this._btnSelectImageSource.Name = "_btnSelectImageSource";
            this._btnSelectImageSource.Size = new System.Drawing.Size(27, 21);
            this._btnSelectImageSource.TabIndex = 3;
            this._btnSelectImageSource.UseVisualStyleBackColor = true;
            // 
            // _cgbxSize
            // 
            this._cgbxSize.Controls.Add(this._tbHeightValue);
            this._cgbxSize.Controls.Add(this._chkHeight);
            this._cgbxSize.Controls.Add(this._tbWidthValue);
            this._cgbxSize.Controls.Add(this._chkWidth);
            this._cgbxSize.Controls.Add(this._cbxWidthType);
            this._cgbxSize.Controls.Add(this._cbxHeightType);
            this._cgbxSize.Dock = System.Windows.Forms.DockStyle.Top;
            this._cgbxSize.Location = new System.Drawing.Point(3, 90);
            this._cgbxSize.Name = "_cgbxSize";
            this._cgbxSize.Size = new System.Drawing.Size(507, 75);
            this._cgbxSize.TabIndex = 1;
            this._cgbxSize.TabStop = false;
            this._cgbxSize.Text = "Size";
            // 
            // _tbHeightValue
            // 
            this._tbHeightValue.Location = new System.Drawing.Point(121, 46);
            this._tbHeightValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this._tbHeightValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._tbHeightValue.Name = "_tbHeightValue";
            this._tbHeightValue.Size = new System.Drawing.Size(95, 21);
            this._tbHeightValue.TabIndex = 4;
            this._tbHeightValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // _tbWidthValue
            // 
            this._tbWidthValue.Location = new System.Drawing.Point(121, 19);
            this._tbWidthValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this._tbWidthValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._tbWidthValue.Name = "_tbWidthValue";
            this._tbWidthValue.Size = new System.Drawing.Size(95, 21);
            this._tbWidthValue.TabIndex = 1;
            this._tbWidthValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // _cbxWidthType
            // 
            this._cbxWidthType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._cbxWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxWidthType.FormattingEnabled = true;
            this._cbxWidthType.Location = new System.Drawing.Point(220, 19);
            this._cbxWidthType.Name = "_cbxWidthType";
            this._cbxWidthType.Size = new System.Drawing.Size(274, 21);
            this._cbxWidthType.TabIndex = 2;
            // 
            // _cbxHeightType
            // 
            this._cbxHeightType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._cbxHeightType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxHeightType.FormattingEnabled = true;
            this._cbxHeightType.Location = new System.Drawing.Point(220, 46);
            this._cbxHeightType.Name = "_cbxHeightType";
            this._cbxHeightType.Size = new System.Drawing.Size(274, 21);
            this._cbxHeightType.TabIndex = 5;
            // 
            // _cgbxPreview
            // 
            this._cgbxPreview.Controls.Add(this._pbSourceImage);
            this._cgbxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cgbxPreview.Location = new System.Drawing.Point(3, 165);
            this._cgbxPreview.Name = "_cgbxPreview";
            this._cgbxPreview.Size = new System.Drawing.Size(507, 133);
            this._cgbxPreview.TabIndex = 3;
            this._cgbxPreview.TabStop = false;
            this._cgbxPreview.Text = "Preview";
            // 
            // _pbSourceImage
            // 
            this._pbSourceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pbSourceImage.Location = new System.Drawing.Point(3, 17);
            this._pbSourceImage.Name = "_pbSourceImage";
            this._pbSourceImage.Size = new System.Drawing.Size(501, 113);
            this._pbSourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._pbSourceImage.TabIndex = 18;
            this._pbSourceImage.TabStop = false;
            // 
            // ImageEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(537, 356);
            this.MinimumSize = new System.Drawing.Size(545, 174);
            this.Name = "ImageEditorForm";
            this.Text = "Picture Properties";
            this._containerMain.ResumeLayout(false);
            this._cgbxImage.ResumeLayout(false);
            this._cgbxImage.PerformLayout();
            this._cgbxSize.ResumeLayout(false);
            this._cgbxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbHeightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tbWidthValue)).EndInit();
            this._cgbxPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pbSourceImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _cgbxImage;
        private System.Windows.Forms.TextBox _tbSource;
        private System.Windows.Forms.Button _btnSelectImageSource;
        private System.Windows.Forms.GroupBox _cgbxSize;
        private System.Windows.Forms.NumericUpDown _tbHeightValue;
        private System.Windows.Forms.CheckBox _chkHeight;
        private System.Windows.Forms.NumericUpDown _tbWidthValue;
        private System.Windows.Forms.CheckBox _chkWidth;
        private System.Windows.Forms.ComboBox _cbxWidthType;
        private System.Windows.Forms.ComboBox _cbxHeightType;
        private System.Windows.Forms.GroupBox _cgbxPreview;
        private System.Windows.Forms.Label _lblPath;
        private System.Windows.Forms.Label _lblAlternate;
        private System.Windows.Forms.PictureBox _pbSourceImage;
        private System.Windows.Forms.TextBox _tbAlternate;

    }
}
