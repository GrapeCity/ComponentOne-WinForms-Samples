namespace AdHocSorting
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
            this._flexRep = new C1.Win.FlexReport.C1FlexReport();
            this.c1FlexViewerPane1 = new C1.Win.FlexViewer.C1FlexViewerPane();
            this._lbFields = new System.Windows.Forms.ListBox();
            this._rbtnAscending = new System.Windows.Forms.RadioButton();
            this._rbtnDescending = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this._btnRender = new System.Windows.Forms.Button();
            this._btnLoadReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewerPane1)).BeginInit();
            this.SuspendLayout();
            // 
            // _flexRep
            // 
            this._flexRep.ReportDefinition = resources.GetString("_flexRep.ReportDefinition");
            this._flexRep.ReportName = "List of Products";
            this._flexRep.ReportDefinitionChanged += new System.EventHandler(this._flexRep_ReportDefinitionChanged);
            // 
            // c1FlexViewerPane1
            // 
            this.c1FlexViewerPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexViewerPane1.Location = new System.Drawing.Point(283, 12);
            this.c1FlexViewerPane1.Name = "c1FlexViewerPane1";
            this.c1FlexViewerPane1.Size = new System.Drawing.Size(993, 608);
            this.c1FlexViewerPane1.TabIndex = 0;
            this.c1FlexViewerPane1.ZoomMode = C1.Win.FlexViewer.FlexViewerZoomMode.PageWidth;
            // 
            // _lbFields
            // 
            this._lbFields.FormattingEnabled = true;
            this._lbFields.Location = new System.Drawing.Point(12, 97);
            this._lbFields.Name = "_lbFields";
            this._lbFields.Size = new System.Drawing.Size(249, 290);
            this._lbFields.TabIndex = 1;
            // 
            // _rbtnAscending
            // 
            this._rbtnAscending.AutoSize = true;
            this._rbtnAscending.Location = new System.Drawing.Point(12, 393);
            this._rbtnAscending.Name = "_rbtnAscending";
            this._rbtnAscending.Size = new System.Drawing.Size(75, 17);
            this._rbtnAscending.TabIndex = 2;
            this._rbtnAscending.TabStop = true;
            this._rbtnAscending.Text = "Ascending";
            this._rbtnAscending.UseVisualStyleBackColor = true;
            this._rbtnAscending.CheckedChanged += new System.EventHandler(this._rbtnAscending_CheckedChanged);
            // 
            // _rbtnDescending
            // 
            this._rbtnDescending.AutoSize = true;
            this._rbtnDescending.Location = new System.Drawing.Point(140, 393);
            this._rbtnDescending.Name = "_rbtnDescending";
            this._rbtnDescending.Size = new System.Drawing.Size(82, 17);
            this._rbtnDescending.TabIndex = 2;
            this._rbtnDescending.TabStop = true;
            this._rbtnDescending.Text = "Descending";
            this._rbtnDescending.UseVisualStyleBackColor = true;
            this._rbtnDescending.CheckedChanged += new System.EventHandler(this._rbtnDescending_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sort by:";
            // 
            // _btnRender
            // 
            this._btnRender.Location = new System.Drawing.Point(12, 416);
            this._btnRender.Name = "_btnRender";
            this._btnRender.Size = new System.Drawing.Size(249, 40);
            this._btnRender.TabIndex = 4;
            this._btnRender.Text = "Render Report";
            this._btnRender.UseVisualStyleBackColor = true;
            this._btnRender.Click += new System.EventHandler(this._btnRender_Click);
            // 
            // _btnLoadReport
            // 
            this._btnLoadReport.Location = new System.Drawing.Point(12, 12);
            this._btnLoadReport.Name = "_btnLoadReport";
            this._btnLoadReport.Size = new System.Drawing.Size(249, 40);
            this._btnLoadReport.TabIndex = 5;
            this._btnLoadReport.Text = "Load Report";
            this._btnLoadReport.UseVisualStyleBackColor = true;
            this._btnLoadReport.Click += new System.EventHandler(this._btnLoadReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 632);
            this.Controls.Add(this._btnLoadReport);
            this.Controls.Add(this._btnRender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._rbtnDescending);
            this.Controls.Add(this._rbtnAscending);
            this.Controls.Add(this._lbFields);
            this.Controls.Add(this.c1FlexViewerPane1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AdHocSorting";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewerPane1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexReport.C1FlexReport _flexRep;
        private C1.Win.FlexViewer.C1FlexViewerPane c1FlexViewerPane1;
        private System.Windows.Forms.ListBox _lbFields;
        private System.Windows.Forms.RadioButton _rbtnAscending;
        private System.Windows.Forms.RadioButton _rbtnDescending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnRender;
        private System.Windows.Forms.Button _btnLoadReport;
    }
}

