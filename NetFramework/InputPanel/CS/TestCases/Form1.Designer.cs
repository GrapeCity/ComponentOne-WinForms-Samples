namespace TestCases
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
            this.label1 = new System.Windows.Forms.Label();
            this.testCaseCombo = new System.Windows.Forms.ComboBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.c1InputPanel1 = new C1.Win.InputPanel.C1InputPanel();
            this.xmlTextBox = new System.Windows.Forms.TextBox();
            this.themeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Case:";
            // 
            // testCaseCombo
            // 
            this.testCaseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testCaseCombo.FormattingEnabled = true;
            this.testCaseCombo.Location = new System.Drawing.Point(77, 6);
            this.testCaseCombo.Name = "testCaseCombo";
            this.testCaseCombo.Size = new System.Drawing.Size(153, 21);
            this.testCaseCombo.TabIndex = 1;
            this.testCaseCombo.SelectedIndexChanged += new System.EventHandler(this.testCaseCombo_SelectedIndexChanged);
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadButton.Location = new System.Drawing.Point(834, 4);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(74, 23);
            this.reloadButton.TabIndex = 4;
            this.reloadButton.Text = "Reload XML";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InputPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(452, 503);
            this.c1InputPanel1.TabIndex = 0;
            this.c1InputPanel1.VisualStyle = C1.Win.InputPanel.VisualStyle.Office2007Blue;
            // 
            // xmlTextBox
            // 
            this.xmlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlTextBox.Location = new System.Drawing.Point(0, 0);
            this.xmlTextBox.Multiline = true;
            this.xmlTextBox.Name = "xmlTextBox";
            this.xmlTextBox.ReadOnly = true;
            this.xmlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.xmlTextBox.Size = new System.Drawing.Size(437, 503);
            this.xmlTextBox.TabIndex = 0;
            // 
            // themeCombo
            // 
            this.themeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeCombo.FormattingEnabled = true;
            this.themeCombo.Items.AddRange(new object[] {
            "System",
            "Blue",
            "Black",
            "Silver"});
            this.themeCombo.Location = new System.Drawing.Point(291, 6);
            this.themeCombo.Name = "themeCombo";
            this.themeCombo.Size = new System.Drawing.Size(79, 21);
            this.themeCombo.TabIndex = 3;
            this.themeCombo.SelectedIndexChanged += new System.EventHandler(this.themeCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Theme:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(15, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.c1InputPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xmlTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(893, 503);
            this.splitContainer1.SplitterDistance = 452;
            this.splitContainer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 548);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.themeCombo);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.testCaseCombo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Test Cases Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox testCaseCombo;
        private System.Windows.Forms.Button reloadButton;
        private C1.Win.InputPanel.C1InputPanel c1InputPanel1;
        private System.Windows.Forms.TextBox xmlTextBox;
        private System.Windows.Forms.ComboBox themeCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

