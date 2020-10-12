namespace ControlExplorer.SuperTooltip
{
    partial class SuperErrorProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperErrorProvider));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c1SuperLabel3 = new C1.Win.C1SuperTooltip.C1SuperLabel();
            this.c1SuperLabel2 = new C1.Win.C1SuperTooltip.C1SuperLabel();
            this.c1SuperLabel1 = new C1.Win.C1SuperTooltip.C1SuperLabel();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.nbAge = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.MaskedTextBox();
            this.tbPassword = new System.Windows.Forms.MaskedTextBox();
            this.c1SuperTooltip1 = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.epWarning = new C1.Win.C1SuperTooltip.C1SuperErrorProvider(this.components);
            this.epInfo = new C1.Win.C1SuperTooltip.C1SuperErrorProvider(this.components);
            this.epComplete = new C1.Win.C1SuperTooltip.C1SuperErrorProvider(this.components);
            this.epError = new C1.Win.C1SuperTooltip.C1SuperErrorProvider(this.components);
            this.c1SuperLabel4 = new C1.Win.C1SuperTooltip.C1SuperLabel();
            this.c1SuperLabel5 = new C1.Win.C1SuperTooltip.C1SuperLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAge)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Start Date:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(99, 81);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(167, 20);
            this.tbEmail.TabIndex = 23;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(99, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(167, 20);
            this.tbName.TabIndex = 17;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.c1SuperLabel3);
            this.groupBox1.Controls.Add(this.c1SuperLabel2);
            this.groupBox1.Controls.Add(this.c1SuperLabel1);
            this.groupBox1.Controls.Add(this.dateEnd);
            this.groupBox1.Controls.Add(this.dateStart);
            this.groupBox1.Controls.Add(this.nbAge);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 202);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error Providing";
            // 
            // c1SuperLabel3
            // 
            this.c1SuperLabel3.Location = new System.Drawing.Point(20, 82);
            this.c1SuperLabel3.Name = "c1SuperLabel3";
            this.c1SuperLabel3.Size = new System.Drawing.Size(75, 23);
            this.c1SuperLabel3.TabIndex = 35;
            this.c1SuperLabel3.Text = "<font color=\"red\">*</font> Email:";
            this.c1SuperLabel3.UseMnemonic = true;
            // 
            // c1SuperLabel2
            // 
            this.c1SuperLabel2.Location = new System.Drawing.Point(20, 53);
            this.c1SuperLabel2.Name = "c1SuperLabel2";
            this.c1SuperLabel2.Size = new System.Drawing.Size(75, 23);
            this.c1SuperLabel2.TabIndex = 34;
            this.c1SuperLabel2.Text = "<font color=\"red\">*</font> Age:";
            this.c1SuperLabel2.UseMnemonic = true;
            // 
            // c1SuperLabel1
            // 
            this.c1SuperLabel1.Location = new System.Drawing.Point(20, 24);
            this.c1SuperLabel1.Name = "c1SuperLabel1";
            this.c1SuperLabel1.Size = new System.Drawing.Size(75, 23);
            this.c1SuperLabel1.TabIndex = 33;
            this.c1SuperLabel1.Text = "<font color=\"red\">*</font> Name:";
            this.c1SuperLabel1.UseMnemonic = true;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(99, 136);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 32;
            this.dateEnd.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(99, 109);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 31;
            this.dateStart.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // nbAge
            // 
            this.nbAge.Location = new System.Drawing.Point(99, 53);
            this.nbAge.Name = "nbAge";
            this.nbAge.Size = new System.Drawing.Size(62, 20);
            this.nbAge.TabIndex = 30;
            this.nbAge.ValueChanged += new System.EventHandler(this.nbAge_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.c1SuperLabel5);
            this.groupBox2.Controls.Add(this.c1SuperLabel4);
            this.groupBox2.Controls.Add(this.tbUsername);
            this.groupBox2.Controls.Add(this.tbPassword);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 131);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmation";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(99, 26);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(167, 20);
            this.tbUsername.TabIndex = 24;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(99, 53);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(167, 20);
            this.tbPassword.TabIndex = 23;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // c1SuperTooltip1
            // 
            this.c1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1SuperTooltip1.Images.Add(new C1.Win.C1SuperTooltip.ImageEntry("Info1.png", ((System.Drawing.Image)(resources.GetObject("c1SuperTooltip1.Images")))));
            this.c1SuperTooltip1.Images.Add(new C1.Win.C1SuperTooltip.ImageEntry("Warning.png", ((System.Drawing.Image)(resources.GetObject("c1SuperTooltip1.Images1")))));
            this.c1SuperTooltip1.Images.Add(new C1.Win.C1SuperTooltip.ImageEntry("Error.png", ((System.Drawing.Image)(resources.GetObject("c1SuperTooltip1.Images2")))));
            // 
            // epWarning
            // 
            this.epWarning.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epWarning.ContainerControl = this;
            this.epWarning.Image = ((System.Drawing.Image)(resources.GetObject("epWarning.Image")));
            this.epWarning.ToolTip = this.c1SuperTooltip1;
            // 
            // epInfo
            // 
            this.epInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epInfo.ContainerControl = this;
            this.epInfo.Image = ((System.Drawing.Image)(resources.GetObject("epInfo.Image")));
            this.epInfo.ToolTip = this.c1SuperTooltip1;
            // 
            // epComplete
            // 
            this.epComplete.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epComplete.ContainerControl = this;
            this.epComplete.Image = ((System.Drawing.Image)(resources.GetObject("epComplete.Image")));
            this.epComplete.ImageHot = ((System.Drawing.Image)(resources.GetObject("epComplete.ImageHot")));
            this.epComplete.ToolTip = this.c1SuperTooltip1;
            this.epComplete.IconClick += new C1.Win.C1SuperTooltip.IconClickEventHandler(this.epComplete_IconClick);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            this.epError.ToolTip = this.c1SuperTooltip1;
            // 
            // c1SuperLabel4
            // 
            this.c1SuperLabel4.Location = new System.Drawing.Point(20, 27);
            this.c1SuperLabel4.Name = "c1SuperLabel4";
            this.c1SuperLabel4.Size = new System.Drawing.Size(75, 23);
            this.c1SuperLabel4.TabIndex = 36;
            this.c1SuperLabel4.Text = "<font color=\"red\">*</font> Username:";
            this.c1SuperLabel4.UseMnemonic = true;
            // 
            // c1SuperLabel5
            // 
            this.c1SuperLabel5.Location = new System.Drawing.Point(20, 54);
            this.c1SuperLabel5.Name = "c1SuperLabel5";
            this.c1SuperLabel5.Size = new System.Drawing.Size(75, 23);
            this.c1SuperLabel5.TabIndex = 37;
            this.c1SuperLabel5.Text = "<font color=\"red\">*</font> Password:";
            this.c1SuperLabel5.UseMnemonic = true;
            // 
            // SuperErrorProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SuperErrorProvider";
            this.Text = "SuperErrorProvider";
            this.Load += new System.EventHandler(this.SuperErrorProvider_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox tbPassword;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1SuperTooltip1;
        private C1.Win.C1SuperTooltip.C1SuperErrorProvider epWarning;
        private C1.Win.C1SuperTooltip.C1SuperErrorProvider epInfo;
        private C1.Win.C1SuperTooltip.C1SuperErrorProvider epComplete;
        private System.Windows.Forms.NumericUpDown nbAge;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private C1.Win.C1SuperTooltip.C1SuperErrorProvider epError;
        private C1.Win.C1SuperTooltip.C1SuperLabel c1SuperLabel3;
        private C1.Win.C1SuperTooltip.C1SuperLabel c1SuperLabel2;
        private C1.Win.C1SuperTooltip.C1SuperLabel c1SuperLabel1;
        private System.Windows.Forms.MaskedTextBox tbUsername;
        private C1.Win.C1SuperTooltip.C1SuperLabel c1SuperLabel5;
        private C1.Win.C1SuperTooltip.C1SuperLabel c1SuperLabel4;
    }
}