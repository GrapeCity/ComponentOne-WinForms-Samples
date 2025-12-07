namespace FlexChartPrint
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnMultiPage = new FlexChartPrint.SampleButton();
            this.btnSinglePage = new FlexChartPrint.SampleButton();
            this.baseSample1 = new FlexChartPrint.Samples.BaseSample();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnMultiPage);
            this.splitContainer1.Panel1.Controls.Add(this.btnSinglePage);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.baseSample1);
            this.splitContainer1.Size = new System.Drawing.Size(885, 708);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnMultiPage
            // 
            this.btnMultiPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnMultiPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnMultiPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMultiPage.Location = new System.Drawing.Point(3, 57);
            this.btnMultiPage.Name = "btnMultiPage";
            this.btnMultiPage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMultiPage.Selected = false;
            this.btnMultiPage.Size = new System.Drawing.Size(194, 34);
            this.btnMultiPage.TabIndex = 1;
            this.btnMultiPage.Text = "MULTI PAGE PRINTING";
            this.btnMultiPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultiPage.UseVisualStyleBackColor = false;
            this.btnMultiPage.Click += new System.EventHandler(this.btnMultiPage_Click);
            // 
            // btnSinglePage
            // 
            this.btnSinglePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSinglePage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSinglePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinglePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSinglePage.Location = new System.Drawing.Point(3, 24);
            this.btnSinglePage.Name = "btnSinglePage";
            this.btnSinglePage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSinglePage.Selected = true;
            this.btnSinglePage.Size = new System.Drawing.Size(194, 36);
            this.btnSinglePage.TabIndex = 0;
            this.btnSinglePage.Text = "SINGLE PAGE PRINTING";
            this.btnSinglePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinglePage.UseVisualStyleBackColor = false;
            this.btnSinglePage.Click += new System.EventHandler(this.btnSinglePage_Click);
            // 
            // baseSample1
            // 
            this.baseSample1.BackColor = System.Drawing.Color.White;
            this.baseSample1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseSample1.Location = new System.Drawing.Point(0, 0);
            this.baseSample1.Name = "baseSample1";
            this.baseSample1.Size = new System.Drawing.Size(684, 708);
            this.baseSample1.TabIndex = 0;
            this.baseSample1.Title = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 708);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FlexChart Printing";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private SampleButton btnMultiPage;
        private SampleButton btnSinglePage;
        private Samples.BaseSample baseSample1;
    }
}

