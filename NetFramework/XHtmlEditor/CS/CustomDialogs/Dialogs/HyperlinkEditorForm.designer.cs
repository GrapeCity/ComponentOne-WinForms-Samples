namespace CustomDialogs
{
    partial class HyperlinkEditorForm
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
            this._tbLink = new System.Windows.Forms.TextBox();
            this._lblTitle = new System.Windows.Forms.Label();
            this._tbAccessKey = new System.Windows.Forms.TextBox();
            this._tbTitle = new System.Windows.Forms.TextBox();
            this._tbText = new System.Windows.Forms.TextBox();
            this._lblText = new System.Windows.Forms.Label();
            this._lblTabIndex = new System.Windows.Forms.Label();
            this._lblAccessKey = new System.Windows.Forms.Label();
            this._lblLink = new System.Windows.Forms.Label();
            this._lblTarget = new System.Windows.Forms.Label();
            this._cmbTarget = new System.Windows.Forms.ComboBox();
            this._cgbxBasic = new System.Windows.Forms.GroupBox();
            this._btnSelectImageSource = new System.Windows.Forms.Button();
            this._cgbxAdvanced = new System.Windows.Forms.GroupBox();
            this._tbTabIndex = new System.Windows.Forms.NumericUpDown();
            this._containerMain.SuspendLayout();
            this._cgbxBasic.SuspendLayout();
            this._cgbxAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbTabIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(216, 286);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(313, 286);
            // 
            // _btnAplly
            // 
            this._btnAplly.Location = new System.Drawing.Point(410, 286);
            // 
            // _containerMain
            // 
            this._containerMain.Controls.Add(this._cgbxAdvanced);
            this._containerMain.Controls.Add(this._cgbxBasic);
            this._containerMain.Size = new System.Drawing.Size(489, 268);
            // 
            // _tbLink
            // 
            this._tbLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbLink.Location = new System.Drawing.Point(105, 46);
            this._tbLink.Name = "_tbLink";
            this._tbLink.Size = new System.Drawing.Size(339, 21);
            this._tbLink.TabIndex = 3;
            // 
            // _lblTitle
            // 
            this._lblTitle.AutoSize = true;
            this._lblTitle.Location = new System.Drawing.Point(17, 22);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(59, 13);
            this._lblTitle.TabIndex = 0;
            this._lblTitle.Text = "&Screen tip:";
            // 
            // _tbAccessKey
            // 
            this._tbAccessKey.Location = new System.Drawing.Point(105, 73);
            this._tbAccessKey.Name = "_tbAccessKey";
            this._tbAccessKey.Size = new System.Drawing.Size(120, 21);
            this._tbAccessKey.TabIndex = 5;
            // 
            // _tbTitle
            // 
            this._tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbTitle.Location = new System.Drawing.Point(105, 19);
            this._tbTitle.Name = "_tbTitle";
            this._tbTitle.Size = new System.Drawing.Size(372, 21);
            this._tbTitle.TabIndex = 1;
            // 
            // _tbText
            // 
            this._tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbText.Location = new System.Drawing.Point(105, 19);
            this._tbText.Name = "_tbText";
            this._tbText.Size = new System.Drawing.Size(372, 21);
            this._tbText.TabIndex = 1;
            // 
            // _lblText
            // 
            this._lblText.AutoSize = true;
            this._lblText.Location = new System.Drawing.Point(17, 22);
            this._lblText.Name = "_lblText";
            this._lblText.Size = new System.Drawing.Size(82, 13);
            this._lblText.TabIndex = 0;
            this._lblText.Text = "&Text to display:";
            // 
            // _lblTabIndex
            // 
            this._lblTabIndex.AutoSize = true;
            this._lblTabIndex.Location = new System.Drawing.Point(17, 101);
            this._lblTabIndex.Name = "_lblTabIndex";
            this._lblTabIndex.Size = new System.Drawing.Size(58, 13);
            this._lblTabIndex.TabIndex = 6;
            this._lblTabIndex.Text = "Tab &index:";
            // 
            // _lblAccessKey
            // 
            this._lblAccessKey.AutoSize = true;
            this._lblAccessKey.Location = new System.Drawing.Point(17, 75);
            this._lblAccessKey.Name = "_lblAccessKey";
            this._lblAccessKey.Size = new System.Drawing.Size(64, 13);
            this._lblAccessKey.TabIndex = 4;
            this._lblAccessKey.Text = "Access &key:";
            // 
            // _lblLink
            // 
            this._lblLink.AutoSize = true;
            this._lblLink.Location = new System.Drawing.Point(17, 49);
            this._lblLink.Name = "_lblLink";
            this._lblLink.Size = new System.Drawing.Size(50, 13);
            this._lblLink.TabIndex = 2;
            this._lblLink.Text = "&Address:";
            // 
            // _lblTarget
            // 
            this._lblTarget.AutoSize = true;
            this._lblTarget.Location = new System.Drawing.Point(17, 49);
            this._lblTarget.Name = "_lblTarget";
            this._lblTarget.Size = new System.Drawing.Size(74, 13);
            this._lblTarget.TabIndex = 2;
            this._lblTarget.Text = "Ta&rget frame:";
            // 
            // _cmbTarget
            // 
            this._cmbTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._cmbTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cmbTarget.Location = new System.Drawing.Point(105, 46);
            this._cmbTarget.Name = "_cmbTarget";
            this._cmbTarget.Size = new System.Drawing.Size(120, 21);
            this._cmbTarget.TabIndex = 3;
            // 
            // _cgbxBasic
            // 
            this._cgbxBasic.Controls.Add(this._btnSelectImageSource);
            this._cgbxBasic.Controls.Add(this._tbLink);
            this._cgbxBasic.Controls.Add(this._tbText);
            this._cgbxBasic.Controls.Add(this._lblText);
            this._cgbxBasic.Controls.Add(this._lblLink);
            this._cgbxBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this._cgbxBasic.Location = new System.Drawing.Point(3, 17);
            this._cgbxBasic.Name = "_cgbxBasic";
            this._cgbxBasic.Size = new System.Drawing.Size(483, 75);
            this._cgbxBasic.TabIndex = 0;
            this._cgbxBasic.TabStop = false;
            this._cgbxBasic.Text = "Basic";
            // 
            // _btnSelectImageSource
            // 
            this._btnSelectImageSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSelectImageSource.Image = global::CustomDialogs.Properties.Resources.openfolder;
            this._btnSelectImageSource.Location = new System.Drawing.Point(450, 46);
            this._btnSelectImageSource.Name = "_btnSelectImageSource";
            this._btnSelectImageSource.Size = new System.Drawing.Size(27, 21);
            this._btnSelectImageSource.TabIndex = 4;
            this._btnSelectImageSource.UseVisualStyleBackColor = true;
            // 
            // _cgbxAdvanced
            // 
            this._cgbxAdvanced.Controls.Add(this._tbTabIndex);
            this._cgbxAdvanced.Controls.Add(this._tbTitle);
            this._cgbxAdvanced.Controls.Add(this._lblTitle);
            this._cgbxAdvanced.Controls.Add(this._lblTabIndex);
            this._cgbxAdvanced.Controls.Add(this._tbAccessKey);
            this._cgbxAdvanced.Controls.Add(this._lblAccessKey);
            this._cgbxAdvanced.Controls.Add(this._lblTarget);
            this._cgbxAdvanced.Controls.Add(this._cmbTarget);
            this._cgbxAdvanced.Dock = System.Windows.Forms.DockStyle.Top;
            this._cgbxAdvanced.Location = new System.Drawing.Point(3, 92);
            this._cgbxAdvanced.Name = "_cgbxAdvanced";
            this._cgbxAdvanced.Size = new System.Drawing.Size(483, 128);
            this._cgbxAdvanced.TabIndex = 1;
            this._cgbxAdvanced.TabStop = false;
            this._cgbxAdvanced.Text = "Advanced";
            // 
            // _tbTabIndex
            // 
            this._tbTabIndex.Location = new System.Drawing.Point(105, 99);
            this._tbTabIndex.Name = "_tbTabIndex";
            this._tbTabIndex.Size = new System.Drawing.Size(119, 21);
            this._tbTabIndex.TabIndex = 7;
            // 
            // HyperlinkEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(513, 323);
            this.MinimumSize = new System.Drawing.Size(521, 174);
            this.Name = "HyperlinkEditorForm";
            this.Text = "Hyperlink Properties";
            this._containerMain.ResumeLayout(false);
            this._cgbxBasic.ResumeLayout(false);
            this._cgbxBasic.PerformLayout();
            this._cgbxAdvanced.ResumeLayout(false);
            this._cgbxAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbTabIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _tbLink;
        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.TextBox _tbAccessKey;
        private System.Windows.Forms.TextBox _tbTitle;
        private System.Windows.Forms.TextBox _tbText;
        private System.Windows.Forms.Label _lblText;
        private System.Windows.Forms.Label _lblTabIndex;
        private System.Windows.Forms.Label _lblAccessKey;
        private System.Windows.Forms.Label _lblLink;
        private System.Windows.Forms.Label _lblTarget;
        private System.Windows.Forms.ComboBox _cmbTarget;
        private System.Windows.Forms.GroupBox _cgbxBasic;
        private System.Windows.Forms.Button _btnSelectImageSource;
        private System.Windows.Forms.GroupBox _cgbxAdvanced;
        private System.Windows.Forms.NumericUpDown _tbTabIndex;

    }
}
