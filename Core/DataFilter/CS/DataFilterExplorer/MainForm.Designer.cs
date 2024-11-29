namespace DataFilterExplorer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            lblSamples = new System.Windows.Forms.ListBox();
            pnlSample = new System.Windows.Forms.Panel();
            pnlDescription = new System.Windows.Forms.Panel();
            lblDescription = new System.Windows.Forms.Label();
            pnlTitle = new System.Windows.Forms.Panel();
            cmbThemes = new C1.Win.Input.C1ComboBox();
            panel1 = new System.Windows.Forms.Panel();
            chkInfo = new System.Windows.Forms.CheckBox();
            lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlDescription.SuspendLayout();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbThemes).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            splitContainer1.Panel1.Controls.Add(lblSamples);
            splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(15, 7, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlSample);
            splitContainer1.Panel2.Controls.Add(pnlDescription);
            splitContainer1.Panel2.Controls.Add(pnlTitle);
            splitContainer1.Size = new System.Drawing.Size(1250, 850);
            splitContainer1.SplitterDistance = 341;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            splitContainer1.Text = "splitContainer1";
            // 
            // lblSamples
            // 
            lblSamples.BackColor = System.Drawing.SystemColors.Window;
            lblSamples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblSamples.DisplayMember = "Title";
            lblSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSamples.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            lblSamples.ForeColor = System.Drawing.Color.DimGray;
            lblSamples.FormattingEnabled = true;
            lblSamples.HorizontalScrollbar = true;
            lblSamples.ItemHeight = 32;
            lblSamples.Location = new System.Drawing.Point(15, 7);
            lblSamples.Margin = new System.Windows.Forms.Padding(6);
            lblSamples.Name = "lblSamples";
            lblSamples.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblSamples.Size = new System.Drawing.Size(326, 843);
            lblSamples.TabIndex = 0;
            lblSamples.SelectedValueChanged += lbSamples_SelectedValueChanged;
            // 
            // pnlSample
            // 
            pnlSample.BackColor = System.Drawing.SystemColors.Window;
            pnlSample.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSample.Location = new System.Drawing.Point(0, 120);
            pnlSample.Margin = new System.Windows.Forms.Padding(4);
            pnlSample.Name = "pnlSample";
            pnlSample.Size = new System.Drawing.Size(904, 730);
            pnlSample.TabIndex = 2;
            // 
            // pnlDescription
            // 
            pnlDescription.AutoSize = true;
            pnlDescription.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnlDescription.BackColor = System.Drawing.SystemColors.Window;
            pnlDescription.Controls.Add(lblDescription);
            pnlDescription.Dock = System.Windows.Forms.DockStyle.Top;
            pnlDescription.Location = new System.Drawing.Point(0, 60);
            pnlDescription.Margin = new System.Windows.Forms.Padding(4);
            pnlDescription.Name = "pnlDescription";
            pnlDescription.Size = new System.Drawing.Size(904, 60);
            pnlDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDescription.Font = new System.Drawing.Font("Calibri", 14.25F);
            lblDescription.Location = new System.Drawing.Point(0, 0);
            lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(904, 60);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "label1";
            lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = System.Drawing.SystemColors.Window;
            pnlTitle.Controls.Add(cmbThemes);
            pnlTitle.Controls.Add(panel1);
            pnlTitle.Controls.Add(chkInfo);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTitle.Location = new System.Drawing.Point(0, 0);
            pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new System.Drawing.Size(904, 60);
            pnlTitle.TabIndex = 0;
            // 
            // cmbThemes
            // 
            cmbThemes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cmbThemes.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            cmbThemes.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            cmbThemes.ItemsDisplayMember = "DisplayText";
            cmbThemes.Location = new System.Drawing.Point(579, 15);
            cmbThemes.Name = "cmbThemes";
            cmbThemes.ReadOnly = true;
            cmbThemes.Size = new System.Drawing.Size(250, 28);
            cmbThemes.TabIndex = 2;
            cmbThemes.SelectedIndexChanged += cmbThemes_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SkyBlue;
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 59);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(904, 1);
            panel1.TabIndex = 1;
            // 
            // chkInfo
            // 
            chkInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkInfo.Appearance = System.Windows.Forms.Appearance.Button;
            chkInfo.AutoSize = true;
            chkInfo.BackColor = System.Drawing.SystemColors.Window;
            chkInfo.Checked = true;
            chkInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            chkInfo.FlatAppearance.BorderSize = 0;
            chkInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            chkInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            chkInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            chkInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F);
            chkInfo.Location = new System.Drawing.Point(840, 1);
            chkInfo.Margin = new System.Windows.Forms.Padding(4);
            chkInfo.Name = "chkInfo";
            chkInfo.Size = new System.Drawing.Size(64, 56);
            chkInfo.TabIndex = 1;
            chkInfo.Text = "❔";
            chkInfo.UseVisualStyleBackColor = false;
            chkInfo.CheckedChanged += chkInfo_CheckedChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F);
            lblTitle.ForeColor = System.Drawing.Color.SkyBlue;
            lblTitle.Location = new System.Drawing.Point(32, 0);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(142, 58);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1250, 850);
            Controls.Add(splitContainer1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "MainForm";
            Text = "C1DataFilter Sample Explorer";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlDescription.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbThemes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lblSamples;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox chkInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSample;
        private C1.Win.Input.C1ComboBox cmbThemes;
    }
}

