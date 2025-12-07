namespace JumpItemDemo
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

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.components = new System.ComponentModel.Container();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton1 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton2 = new C1.Win.C1Win7Pack.C1CustomButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKnownAfterCustom = new System.Windows.Forms.RadioButton();
            this.rbKnownBeforeCustom = new System.Windows.Forms.RadioButton();
            this.comboKnownCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddJumpPath = new System.Windows.Forms.Button();
            this.btnAddJumpLink = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUnregister = new System.Windows.Forms.Button();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.btnClearKnown = new System.Windows.Forms.Button();
            this.btnClearCustom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rejectedListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.removedListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.knownListBox = new System.Windows.Forms.ListBox();
            this.comboGetKnown = new System.Windows.Forms.ComboBox();
            this.btnGetKnown = new System.Windows.Forms.Button();
            this.taskbarButton = new C1.Win.C1Win7Pack.C1TaskbarButton(this.components);
            this.registrationDialog = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKnownAfterCustom);
            this.groupBox1.Controls.Add(this.rbKnownBeforeCustom);
            this.groupBox1.Controls.Add(this.comboKnownCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Known Categories";
            // 
            // rbKnownAfterCustom
            // 
            this.rbKnownAfterCustom.AutoSize = true;
            this.rbKnownAfterCustom.Checked = true;
            this.rbKnownAfterCustom.Location = new System.Drawing.Point(148, 45);
            this.rbKnownAfterCustom.Name = "rbKnownAfterCustom";
            this.rbKnownAfterCustom.Size = new System.Drawing.Size(150, 17);
            this.rbKnownAfterCustom.TabIndex = 3;
            this.rbKnownAfterCustom.TabStop = true;
            this.rbKnownAfterCustom.Text = "After Custom Categories";
            this.rbKnownAfterCustom.UseVisualStyleBackColor = true;
            this.rbKnownAfterCustom.Click += new System.EventHandler(this.rbKnownAfterCustom_Click);
            // 
            // rbKnownBeforeCustom
            // 
            this.rbKnownBeforeCustom.AutoSize = true;
            this.rbKnownBeforeCustom.Location = new System.Drawing.Point(148, 20);
            this.rbKnownBeforeCustom.Name = "rbKnownBeforeCustom";
            this.rbKnownBeforeCustom.Size = new System.Drawing.Size(159, 17);
            this.rbKnownBeforeCustom.TabIndex = 2;
            this.rbKnownBeforeCustom.Text = "Before Custom Categories";
            this.rbKnownBeforeCustom.UseVisualStyleBackColor = true;
            this.rbKnownBeforeCustom.Click += new System.EventHandler(this.rbKnownBeforeCustom_Click);
            // 
            // comboKnownCategory
            // 
            this.comboKnownCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKnownCategory.FormattingEnabled = true;
            this.comboKnownCategory.Items.AddRange(new object[] {
            "Neither",
            "Recent",
            "Frequent"});
            this.comboKnownCategory.Location = new System.Drawing.Point(16, 40);
            this.comboKnownCategory.Name = "comboKnownCategory";
            this.comboKnownCategory.Size = new System.Drawing.Size(108, 21);
            this.comboKnownCategory.TabIndex = 1;
            this.comboKnownCategory.SelectedIndexChanged += new System.EventHandler(this.comboKnownCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show";
            // 
            // btnAddJumpPath
            // 
            this.btnAddJumpPath.Location = new System.Drawing.Point(15, 115);
            this.btnAddJumpPath.Name = "btnAddJumpPath";
            this.btnAddJumpPath.Size = new System.Drawing.Size(185, 62);
            this.btnAddJumpPath.TabIndex = 3;
            this.btnAddJumpPath.Text = "Add \"JumpPath Category\" (consists of C1JumpPath objects that addresses .txt files" +
                ")";
            this.btnAddJumpPath.UseVisualStyleBackColor = true;
            this.btnAddJumpPath.Click += new System.EventHandler(this.btnAddJumpPath_Click);
            // 
            // btnAddJumpLink
            // 
            this.btnAddJumpLink.Location = new System.Drawing.Point(15, 191);
            this.btnAddJumpLink.Name = "btnAddJumpLink";
            this.btnAddJumpLink.Size = new System.Drawing.Size(185, 62);
            this.btnAddJumpLink.TabIndex = 4;
            this.btnAddJumpLink.Text = "Add \"JumpLink Category\" (consists of C1JumpLink objects that addresses .ico files" +
                ")";
            this.btnAddJumpLink.UseVisualStyleBackColor = true;
            this.btnAddJumpLink.Click += new System.EventHandler(this.btnAddJumpLink_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(343, 25);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(185, 23);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register \'.txt\' File Type";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUnregister
            // 
            this.btnUnregister.Location = new System.Drawing.Point(343, 58);
            this.btnUnregister.Name = "btnUnregister";
            this.btnUnregister.Size = new System.Drawing.Size(185, 23);
            this.btnUnregister.TabIndex = 2;
            this.btnUnregister.Text = "Unregister \'.txt\' File Type";
            this.btnUnregister.UseVisualStyleBackColor = true;
            this.btnUnregister.Click += new System.EventHandler(this.btnUnregister_Click);
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Location = new System.Drawing.Point(15, 275);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(185, 23);
            this.btnApplyChanges.TabIndex = 5;
            this.btnApplyChanges.Text = "Apply Changes to Jump List";
            this.btnApplyChanges.UseVisualStyleBackColor = true;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // btnClearKnown
            // 
            this.btnClearKnown.Location = new System.Drawing.Point(378, 275);
            this.btnClearKnown.Name = "btnClearKnown";
            this.btnClearKnown.Size = new System.Drawing.Size(150, 23);
            this.btnClearKnown.TabIndex = 11;
            this.btnClearKnown.Text = "Clear Known Categories";
            this.btnClearKnown.UseVisualStyleBackColor = true;
            this.btnClearKnown.Click += new System.EventHandler(this.btnClearKnown_Click);
            // 
            // btnClearCustom
            // 
            this.btnClearCustom.Location = new System.Drawing.Point(212, 275);
            this.btnClearCustom.Name = "btnClearCustom";
            this.btnClearCustom.Size = new System.Drawing.Size(150, 23);
            this.btnClearCustom.TabIndex = 10;
            this.btnClearCustom.Text = "Clear Custom Categories";
            this.btnClearCustom.UseVisualStyleBackColor = true;
            this.btnClearCustom.Click += new System.EventHandler(this.btnClearCustom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rejected Items:";
            // 
            // rejectedListBox
            // 
            this.rejectedListBox.FormattingEnabled = true;
            this.rejectedListBox.Location = new System.Drawing.Point(212, 115);
            this.rejectedListBox.Name = "rejectedListBox";
            this.rejectedListBox.Size = new System.Drawing.Size(316, 69);
            this.rejectedListBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Removed Items:";
            // 
            // removedListBox
            // 
            this.removedListBox.FormattingEnabled = true;
            this.removedListBox.Location = new System.Drawing.Point(212, 210);
            this.removedListBox.Name = "removedListBox";
            this.removedListBox.Size = new System.Drawing.Size(316, 43);
            this.removedListBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Known Destinations:";
            // 
            // knownListBox
            // 
            this.knownListBox.FormattingEnabled = true;
            this.knownListBox.Location = new System.Drawing.Point(122, 328);
            this.knownListBox.Name = "knownListBox";
            this.knownListBox.Size = new System.Drawing.Size(406, 56);
            this.knownListBox.TabIndex = 15;
            // 
            // comboGetKnown
            // 
            this.comboGetKnown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGetKnown.FormattingEnabled = true;
            this.comboGetKnown.Items.AddRange(new object[] {
            "Recent",
            "Frequent"});
            this.comboGetKnown.Location = new System.Drawing.Point(15, 328);
            this.comboGetKnown.Name = "comboGetKnown";
            this.comboGetKnown.Size = new System.Drawing.Size(93, 21);
            this.comboGetKnown.TabIndex = 12;
            // 
            // btnGetKnown
            // 
            this.btnGetKnown.Location = new System.Drawing.Point(15, 361);
            this.btnGetKnown.Name = "btnGetKnown";
            this.btnGetKnown.Size = new System.Drawing.Size(93, 23);
            this.btnGetKnown.TabIndex = 13;
            this.btnGetKnown.Text = "Get Items";
            this.btnGetKnown.UseVisualStyleBackColor = true;
            this.btnGetKnown.Click += new System.EventHandler(this.btnGetKnown_Click);
            // 
            // taskbarButton
            // 
            this.taskbarButton.ContainerForm = this;
            this.taskbarButton.RegistryProgID = "C1TaskbarDemo";
            this.taskbarButton.WindowAppID = "JumpItemDemo";
            this.taskbarButton.JumpItemsRemovedByUser += new C1.Win.C1Win7Pack.JumpItemsRemovedEventHandler(this.taskbarButton_JumpItemsRemovedByUser);
            this.taskbarButton.ApplyingJumpListChanges += new System.ComponentModel.CancelEventHandler(this.taskbarButton_ApplyingJumpListChanges);
            this.taskbarButton.JumpItemsRejected += new C1.Win.C1Win7Pack.JumpItemsRejectedEventHandler(this.taskbarButton_JumpItemsRejected);
            // 
            // registrationDialog
            // 
            this.registrationDialog.CheckBoxText = "Don\'t ask me again";
            this.registrationDialog.Content = "\'.txt\' file type is not registered.";
            c1CustomButton1.ID = 9;
            c1CustomButton1.Name = "registerButton";
            c1CustomButton1.Note = "Register .txt files with this application to run this demo application correctly." +
                "";
            c1CustomButton1.ShowElevationIcon = true;
            c1CustomButton1.Text = "Register file type for this application";
            c1CustomButton2.ID = 10;
            c1CustomButton2.Name = "ignoreButton";
            c1CustomButton2.Note = "You can try to apply changes without the registration.";
            c1CustomButton2.Text = "Do not register the file type";
            this.registrationDialog.CustomButtons.AddRange(new C1.Win.C1Win7Pack.C1CustomButton[] {
            c1CustomButton1,
            c1CustomButton2});
            this.registrationDialog.MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Information;
            this.registrationDialog.MainInstruction = "This demo application needs to register .txt files as associated files to apply c" +
                "hanges to the Jump List.";
            this.registrationDialog.NextID = 11;
            this.registrationDialog.WindowTitle = "C1JumpList Destinations";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnApplyChanges;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 402);
            this.Controls.Add(this.btnGetKnown);
            this.Controls.Add(this.comboGetKnown);
            this.Controls.Add(this.knownListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rejectedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearCustom);
            this.Controls.Add(this.btnClearKnown);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.btnUnregister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnAddJumpLink);
            this.Controls.Add(this.btnAddJumpPath);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1JumpList Destinations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1Win7Pack.C1TaskbarButton taskbarButton;
        private C1.Win.C1Win7Pack.C1TaskDialog registrationDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKnownCategory;
        private System.Windows.Forms.RadioButton rbKnownAfterCustom;
        private System.Windows.Forms.RadioButton rbKnownBeforeCustom;
        private System.Windows.Forms.Button btnAddJumpLink;
        private System.Windows.Forms.Button btnAddJumpPath;
        private System.Windows.Forms.Button btnUnregister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.ListBox rejectedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearCustom;
        private System.Windows.Forms.Button btnClearKnown;
        private System.Windows.Forms.ListBox removedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGetKnown;
        private System.Windows.Forms.ListBox knownListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetKnown;
    }
}

