namespace FlexGridAi.Forms
{
    partial class FormApiKeyEntry
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
            linkLblDescription = new LinkLabel();
            lblTitle = new C1.Win.Input.C1Label();
            txtBoxApiKey = new C1.Win.Input.C1TextBox();
            btnToggle = new C1.Win.Input.C1Button();
            btnConfirm = new C1.Win.Input.C1Button();
            lblError = new C1.Win.Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)lblTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBoxApiKey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnToggle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnConfirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblError).BeginInit();
            SuspendLayout();
            // 
            // linkLblDescription
            // 
            linkLblDescription.AutoSize = true;
            linkLblDescription.Font = new Font("Segoe UI Variable Text", 10F);
            linkLblDescription.LinkColor = Color.FromArgb(0, 95, 184);
            linkLblDescription.Location = new Point(32, 98);
            linkLblDescription.Margin = new Padding(2, 0, 2, 0);
            linkLblDescription.Name = "linkLblDescription";
            linkLblDescription.Size = new Size(568, 54);
            linkLblDescription.TabIndex = 0;
            linkLblDescription.TabStop = true;
            linkLblDescription.Text = "To use the AI assistant, you'll need to provide your own API key. \r\nDon’t have a key yet? Here’s how to create API key";
            linkLblDescription.LinkClicked += LinkLbl_LinkClicked;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Variable Text Semibold", 12F);
            lblTitle.Location = new Point(24, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(231, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Enter your Api Key:";
            // 
            // txtBoxApiKey
            // 
            txtBoxApiKey.AutoSize = false;
            txtBoxApiKey.Font = new Font("Segoe UI Variable Text", 10F);
            txtBoxApiKey.Location = new Point(38, 199);
            txtBoxApiKey.Name = "txtBoxApiKey";
            txtBoxApiKey.Placeholder = "Enter your API key here...";
            txtBoxApiKey.Size = new Size(512, 50);
            txtBoxApiKey.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            txtBoxApiKey.Styles.Corners = new C1.Framework.Corners(3, 3, 3, 3);
            txtBoxApiKey.Styles.Disabled.BackColor = Color.White;
            txtBoxApiKey.Styles.Margins = new C1.Framework.Thickness(0, 0, 0, 0);
            txtBoxApiKey.Styles.Padding = new C1.Framework.Thickness(10, 2, 2, 2);
            txtBoxApiKey.Styles.Underline.Default.Color = Color.Transparent;
            txtBoxApiKey.Styles.Underline.Focused.Color = Color.Transparent;
            txtBoxApiKey.Styles.Underline.Hot.Color = Color.Transparent;
            txtBoxApiKey.TabIndex = 2;
            txtBoxApiKey.Value = "";
            txtBoxApiKey.VerticalAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            // 
            // btnToggle
            // 
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.Location = new Point(572, 199);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(50, 50);
            btnToggle.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            btnToggle.Styles.Corners = new C1.Framework.Corners(3, 3, 3, 3);
            btnToggle.Styles.Default.BackColor = Color.White;
            btnToggle.Styles.Hot.BackColor = SystemColors.ButtonFace;
            btnToggle.Styles.HotPressed.BackColor = Color.FromArgb(254, 254, 254);
            btnToggle.Styles.Padding = new C1.Framework.Thickness(0, 0, 0, 0);
            btnToggle.TabIndex = 3;
            btnToggle.Click += BtnToggle_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Location = new Point(38, 300);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(154, 50);
            btnConfirm.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            btnConfirm.Styles.Corners = new C1.Framework.Corners(4, 4, 4, 4);
            btnConfirm.Styles.Default.BackColor = Color.FromArgb(0, 95, 184);
            btnConfirm.Styles.Default.BorderColor = Color.FromArgb(20, 108, 190);
            btnConfirm.Styles.Default.ForeColor = Color.White;
            btnConfirm.Styles.Disabled.BackColor = SystemColors.ScrollBar;
            btnConfirm.Styles.Disabled.BorderColor = SystemColors.ScrollBar;
            btnConfirm.Styles.Disabled.ForeColor = Color.White;
            btnConfirm.Styles.Font = new Font("Segoe UI Variable Text", 10F);
            btnConfirm.Styles.Hot.BackColor = Color.FromArgb(26, 111, 192);
            btnConfirm.Styles.Hot.BorderColor = Color.FromArgb(30, 84, 136);
            btnConfirm.Styles.Hot.ForeColor = Color.White;
            btnConfirm.Styles.HotPressed.BackColor = Color.FromArgb(51, 127, 198);
            btnConfirm.Styles.HotPressed.BorderColor = Color.FromArgb(67, 137, 202);
            btnConfirm.Styles.HotPressed.ForeColor = Color.FromArgb(193, 216, 238);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm";
            btnConfirm.Click += BtnConfirm_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI Variable Text", 10F);
            lblError.Location = new Point(31, 252);
            lblError.Name = "lblError";
            lblError.Size = new Size(512, 41);
            lblError.Styles.Default.ForeColor = Color.FromArgb(210, 1, 4);
            lblError.Styles.Padding = new C1.Framework.Thickness(1, 1, 1, 1);
            lblError.TabIndex = 5;
            lblError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormApiKeyEntry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 231, 237);
            ClientSize = new Size(655, 420);
            Controls.Add(lblError);
            Controls.Add(btnConfirm);
            Controls.Add(btnToggle);
            Controls.Add(txtBoxApiKey);
            Controls.Add(lblTitle);
            Controls.Add(linkLblDescription);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "FormApiKeyEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "API Key";
            ((System.ComponentModel.ISupportInitialize)lblTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBoxApiKey).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnToggle).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnConfirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLblDescription;
        private C1.Win.Input.C1Label lblTitle;
        private C1.Win.Input.C1TextBox txtBoxApiKey;
        private C1.Win.Input.C1Button btnToggle;
        private C1.Win.Input.C1Button btnConfirm;
        private C1.Win.Input.C1Label lblError;
    }
}