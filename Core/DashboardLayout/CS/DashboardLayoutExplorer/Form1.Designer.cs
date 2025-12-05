namespace SampleExplorer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbSamples = new System.Windows.Forms.ListBox();
            this.pnlSample = new System.Windows.Forms.Panel();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkInfo = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbSamples);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlSample);
            this.splitContainer1.Panel2.Controls.Add(this.pnlDescription);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTitle);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // lbSamples
            // 
            this.lbSamples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSamples.DisplayMember = "Title";
            this.lbSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSamples.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSamples.ForeColor = System.Drawing.Color.DimGray;
            this.lbSamples.FormattingEnabled = true;
            this.lbSamples.ItemHeight = 25;
            this.lbSamples.Location = new System.Drawing.Point(0, 0);
            this.lbSamples.Name = "lbSamples";
            this.lbSamples.Size = new System.Drawing.Size(200, 450);
            this.lbSamples.TabIndex = 0;
            this.lbSamples.SelectedValueChanged += new System.EventHandler(this.lbSamples_SelectedValueChanged);
            // 
            // pnlSample
            // 
            this.pnlSample.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSample.Location = new System.Drawing.Point(0, 120);
            this.pnlSample.Name = "pnlSample";
            this.pnlSample.Size = new System.Drawing.Size(596, 330);
            this.pnlSample.TabIndex = 2;
            // 
            // pnlDescription
            // 
            this.pnlDescription.AutoSize = true;
            this.pnlDescription.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDescription.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDescription.Location = new System.Drawing.Point(0, 48);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(596, 72);
            this.pnlDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(0, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(596, 72);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "label1";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.Window;
            this.pnlTitle.Controls.Add(this.panel1);
            this.pnlTitle.Controls.Add(this.chkInfo);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(596, 48);
            this.pnlTitle.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 1);
            this.panel1.TabIndex = 1;
            // 
            // chkInfo
            // 
            this.chkInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInfo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkInfo.AutoSize = true;
            this.chkInfo.BackColor = System.Drawing.SystemColors.Window;
            this.chkInfo.Checked = true;
            this.chkInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInfo.FlatAppearance.BorderSize = 0;
            this.chkInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.chkInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.chkInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.chkInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkInfo.Location = new System.Drawing.Point(542, 1);
            this.chkInfo.Name = "chkInfo";
            this.chkInfo.Size = new System.Drawing.Size(54, 47);
            this.chkInfo.TabIndex = 1;
            this.chkInfo.Text = "❔";
            this.chkInfo.UseVisualStyleBackColor = false;
            this.chkInfo.CheckedChanged += new System.EventHandler(this.chkInfo_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(26, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1124, 800);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DashboardLayout Explorer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlDescription.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbSamples;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox chkInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSample;
    }
}

