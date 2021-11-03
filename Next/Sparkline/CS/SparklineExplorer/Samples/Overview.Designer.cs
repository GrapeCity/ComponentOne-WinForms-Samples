namespace SparklineExplorer.Samples
{
    partial class Overview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblSparklineType = new System.Windows.Forms.ToolStripLabel();
            this.cmbSparklineType = new System.Windows.Forms.ToolStripComboBox();
            this.chkDisplayXAxis = new System.Windows.Forms.ToolStripButton();
            this.btnNewData = new System.Windows.Forms.ToolStripButton();
            this.c1Sparkline1 = new C1.Win.Sparkline.C1Sparkline();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSparklineType,
            this.cmbSparklineType,
            this.chkDisplayXAxis,
            this.btnNewData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(407, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblSparklineType
            // 
            this.lblSparklineType.Name = "lblSparklineType";
            this.lblSparklineType.Size = new System.Drawing.Size(99, 22);
            this.lblSparklineType.Text = "Sparkline Type: ";
            // 
            // cmbSparklineType
            // 
            this.cmbSparklineType.Items.AddRange(new object[] {
            "Line",
            "Column",
            "WinLoss"});
            this.cmbSparklineType.Name = "cmbSparklineType";
            this.cmbSparklineType.Size = new System.Drawing.Size(121, 25);
            this.cmbSparklineType.SelectedIndexChanged += new System.EventHandler(this.cmbSparklineType_SelectedIndexChanged);
            // 
            // chkDisplayXAxis
            // 
            this.chkDisplayXAxis.CheckOnClick = true;
            this.chkDisplayXAxis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.chkDisplayXAxis.Image = ((System.Drawing.Image)(resources.GetObject("chkDisplayXAxis.Image")));
            this.chkDisplayXAxis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkDisplayXAxis.Name = "chkDisplayXAxis";
            this.chkDisplayXAxis.Size = new System.Drawing.Size(93, 22);
            this.chkDisplayXAxis.Text = "Display X Axis";
            this.chkDisplayXAxis.CheckedChanged += new System.EventHandler(this.chkDisplayXAxis_CheckedChanged);
            // 
            // btnNewData
            // 
            this.btnNewData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewData.Image = ((System.Drawing.Image)(resources.GetObject("btnNewData.Image")));
            this.btnNewData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size(69, 22);
            this.btnNewData.Text = "New Data";
            this.btnNewData.Click += new System.EventHandler(this.btnNewData_Click);
            // 
            // c1Sparkline1
            // 
            this.c1Sparkline1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sparkline1.Location = new System.Drawing.Point(0, 25);
            this.c1Sparkline1.Name = "c1Sparkline1";
            this.c1Sparkline1.Size = new System.Drawing.Size(407, 279);
            this.c1Sparkline1.TabIndex = 1;
            this.c1Sparkline1.Text = "c1Sparkline1";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Sparkline1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(407, 304);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblSparklineType;
        private System.Windows.Forms.ToolStripComboBox cmbSparklineType;
        private System.Windows.Forms.ToolStripButton chkDisplayXAxis;
        private System.Windows.Forms.ToolStripButton btnNewData;
        private C1.Win.Sparkline.C1Sparkline c1Sparkline1;
    }
}
