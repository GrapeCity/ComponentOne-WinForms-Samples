namespace PdfSignature
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
            this._btCreate = new System.Windows.Forms.Button();
            this._status = new System.Windows.Forms.StatusStrip();
            this._statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this._lbCreate = new System.Windows.Forms.Label();
            this._lbOpen = new System.Windows.Forms.Label();
            this._btOpen = new System.Windows.Forms.Button();
            this._tbPassword = new System.Windows.Forms.TextBox();
            this._lbPassword = new System.Windows.Forms.Label();
            this._rtbCertificate = new System.Windows.Forms.RichTextBox();
            this._c1pdf = new C1.Win.Pdf.C1PdfDocument();
            this._lbInfo = new System.Windows.Forms.Label();
            this._rbText = new System.Windows.Forms.RadioButton();
            this._rbImage = new System.Windows.Forms.RadioButton();
            this._status.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btCreate
            // 
            this._btCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btCreate.Location = new System.Drawing.Point(351, 255);
            this._btCreate.Name = "_btCreate";
            this._btCreate.Size = new System.Drawing.Size(75, 23);
            this._btCreate.TabIndex = 0;
            this._btCreate.Text = "&Create";
            this._btCreate.UseVisualStyleBackColor = true;
            this._btCreate.Click += new System.EventHandler(this._btCreate_Click);
            // 
            // _status
            // 
            this._status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusBar});
            this._status.Location = new System.Drawing.Point(0, 290);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(438, 22);
            this._status.TabIndex = 1;
            // 
            // _statusBar
            // 
            this._statusBar.Name = "_statusBar";
            this._statusBar.Size = new System.Drawing.Size(39, 17);
            this._statusBar.Text = "Ready";
            // 
            // _lbCreate
            // 
            this._lbCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lbCreate.AutoSize = true;
            this._lbCreate.Location = new System.Drawing.Point(12, 244);
            this._lbCreate.Name = "_lbCreate";
            this._lbCreate.Size = new System.Drawing.Size(320, 13);
            this._lbCreate.TabIndex = 2;
            this._lbCreate.Text = "Press <Create> button for preview PDF result with digital signature.";
            // 
            // _lbOpen
            // 
            this._lbOpen.AutoSize = true;
            this._lbOpen.Location = new System.Drawing.Point(12, 9);
            this._lbOpen.Name = "_lbOpen";
            this._lbOpen.Size = new System.Drawing.Size(243, 13);
            this._lbOpen.TabIndex = 3;
            this._lbOpen.Text = "Press <Open> button for select file with certificate.";
            // 
            // _btOpen
            // 
            this._btOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btOpen.Location = new System.Drawing.Point(351, 25);
            this._btOpen.Name = "_btOpen";
            this._btOpen.Size = new System.Drawing.Size(75, 23);
            this._btOpen.TabIndex = 4;
            this._btOpen.Text = "&Open...";
            this._btOpen.UseVisualStyleBackColor = true;
            this._btOpen.Click += new System.EventHandler(this._btOpen_Click);
            // 
            // _tbPassword
            // 
            this._tbPassword.Location = new System.Drawing.Point(192, 176);
            this._tbPassword.Name = "_tbPassword";
            this._tbPassword.Size = new System.Drawing.Size(234, 20);
            this._tbPassword.TabIndex = 8;
            this._tbPassword.UseSystemPasswordChar = true;
            this._tbPassword.TextChanged += new System.EventHandler(this._tbPassword_TextChanged);
            // 
            // _lbPassword
            // 
            this._lbPassword.AutoSize = true;
            this._lbPassword.Location = new System.Drawing.Point(12, 183);
            this._lbPassword.Name = "_lbPassword";
            this._lbPassword.Size = new System.Drawing.Size(53, 13);
            this._lbPassword.TabIndex = 9;
            this._lbPassword.Text = "Password";
            // 
            // _rtbCertificate
            // 
            this._rtbCertificate.Location = new System.Drawing.Point(15, 63);
            this._rtbCertificate.Name = "_rtbCertificate";
            this._rtbCertificate.ReadOnly = true;
            this._rtbCertificate.Size = new System.Drawing.Size(411, 107);
            this._rtbCertificate.TabIndex = 10;
            this._rtbCertificate.Text = "";
            // 
            // _lbInfo
            // 
            this._lbInfo.AutoSize = true;
            this._lbInfo.Location = new System.Drawing.Point(12, 47);
            this._lbInfo.Name = "_lbInfo";
            this._lbInfo.Size = new System.Drawing.Size(97, 13);
            this._lbInfo.TabIndex = 11;
            this._lbInfo.Text = "No digital signatute";
            // 
            // _rbText
            // 
            this._rbText.AutoSize = true;
            this._rbText.Checked = true;
            this._rbText.Location = new System.Drawing.Point(15, 214);
            this._rbText.Name = "_rbText";
            this._rbText.Size = new System.Drawing.Size(92, 17);
            this._rbText.TabIndex = 12;
            this._rbText.TabStop = true;
            this._rbText.Text = "Text signature";
            this._rbText.UseVisualStyleBackColor = true;
            // 
            // _rbImage
            // 
            this._rbImage.AutoSize = true;
            this._rbImage.Location = new System.Drawing.Point(217, 214);
            this._rbImage.Name = "_rbImage";
            this._rbImage.Size = new System.Drawing.Size(100, 17);
            this._rbImage.TabIndex = 13;
            this._rbImage.Text = "Image signature";
            this._rbImage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 312);
            this.Controls.Add(this._rbImage);
            this.Controls.Add(this._rbText);
            this.Controls.Add(this._lbInfo);
            this.Controls.Add(this._rtbCertificate);
            this.Controls.Add(this._lbPassword);
            this.Controls.Add(this._tbPassword);
            this.Controls.Add(this._btOpen);
            this.Controls.Add(this._lbOpen);
            this.Controls.Add(this._lbCreate);
            this.Controls.Add(this._status);
            this.Controls.Add(this._btCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF digital signature sample";
            this._status.ResumeLayout(false);
            this._status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Pdf.C1PdfDocument _c1pdf;
        private System.Windows.Forms.Button _btCreate;
        private System.Windows.Forms.StatusStrip _status;
        private System.Windows.Forms.ToolStripStatusLabel _statusBar;
        private System.Windows.Forms.Label _lbCreate;
        private System.Windows.Forms.Label _lbOpen;
        private System.Windows.Forms.Button _btOpen;
        private System.Windows.Forms.TextBox _tbPassword;
        private System.Windows.Forms.Label _lbPassword;
        private System.Windows.Forms.RichTextBox _rtbCertificate;
        private System.Windows.Forms.Label _lbInfo;
        private System.Windows.Forms.RadioButton _rbText;
        private System.Windows.Forms.RadioButton _rbImage;
    }
}

