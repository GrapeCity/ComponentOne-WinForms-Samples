﻿namespace FlexPivotExplorer.Samples
{
    partial class Overview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c1FlexPivotPage1 = new C1.Win.FlexPivot.FlexPivotPage();
            this.lbWaiting = new C1.Win.Input.C1Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(lbWaiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPage1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 36);
            this.panel1.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(403, 7);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(176, 17);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Generating 1,000,000 rows... ";
            // 
            // lbWaiting
            // 
            this.lbWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWaiting.Font = new System.Drawing.Font("Calibri", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWaiting.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbWaiting.Location = new System.Drawing.Point(0, 0);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(786, 449);
            this.lbWaiting.TabIndex = 2;
            this.lbWaiting.Text = "Loading Data...";
            this.lbWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predefined views: ";
            // 
            // c1FlexPivotPage1
            // 
            this.c1FlexPivotPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotPage1.Location = new System.Drawing.Point(0, 36);
            this.c1FlexPivotPage1.Margin = new System.Windows.Forms.Padding(2);
            this.c1FlexPivotPage1.Name = "c1FlexPivotPage1";
            this.c1FlexPivotPage1.Size = new System.Drawing.Size(592, 410);
            this.c1FlexPivotPage1.TabIndex = 2;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.lbWaiting);
            this.Controls.Add(this.c1FlexPivotPage1);
            this.Controls.Add(this.panel1);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(592, 446);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(lbWaiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private C1.Win.FlexPivot.FlexPivotPage c1FlexPivotPage1;
        private C1.Win.Input.C1Label lbWaiting;
    }
}
