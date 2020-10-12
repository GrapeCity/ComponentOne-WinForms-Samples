namespace C1Report2Rpx
{
    partial class ArDesigner
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
            this.theDesigner = new GrapeCity.ActiveReports.Design.Designer();
            this.arToolbox = new GrapeCity.ActiveReports.Design.Toolbox.Toolbox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.reportExplorer1 = new GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer();
            this.arPropertyGrid = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.arToolbox)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // theDesigner
            // 
            this.theDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theDesigner.IsDirty = false;
            this.theDesigner.Location = new System.Drawing.Point(0, 0);
            this.theDesigner.LockControls = false;
            this.theDesigner.Name = "theDesigner";
            this.theDesigner.PreviewPages = 10;
            this.theDesigner.PromptUser = true;
            this.theDesigner.PropertyGrid = null;
            this.theDesigner.ReportTabsVisible = true;
            this.theDesigner.ShowDataSourceIcon = true;
            this.theDesigner.Size = new System.Drawing.Size(563, 584);
            this.theDesigner.TabIndex = 0;
            this.theDesigner.Toolbox = null;
            this.theDesigner.ToolBoxItem = null;
            // 
            // arToolbox
            // 
            this.arToolbox.DesignerHost = null;
            this.arToolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arToolbox.Location = new System.Drawing.Point(0, 0);
            this.arToolbox.Name = "arToolbox";
            this.arToolbox.Size = new System.Drawing.Size(174, 584);
            this.arToolbox.TabIndex = 1;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(983, 584);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Enabled = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.Enabled = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(983, 609);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.arToolbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(983, 584);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.theDesigner);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(805, 584);
            this.splitContainer2.SplitterDistance = 563;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.reportExplorer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.arPropertyGrid);
            this.splitContainer3.Size = new System.Drawing.Size(238, 584);
            this.splitContainer3.SplitterDistance = 197;
            this.splitContainer3.TabIndex = 3;
            // 
            // reportExplorer1
            // 
            this.reportExplorer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportExplorer1.Location = new System.Drawing.Point(0, 0);
            this.reportExplorer1.Name = "reportExplorer1";
            this.reportExplorer1.ReportDesigner = this.theDesigner;
            this.reportExplorer1.Size = new System.Drawing.Size(238, 197);
            this.reportExplorer1.TabIndex = 3;
            // 
            // arPropertyGrid
            // 
            this.arPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.arPropertyGrid.Name = "arPropertyGrid";
            this.arPropertyGrid.Size = new System.Drawing.Size(238, 383);
            this.arPropertyGrid.TabIndex = 4;
            // 
            // ArDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 609);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "ArDesigner";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ActiveReports Designer";
            ((System.ComponentModel.ISupportInitialize)(this.arToolbox)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GrapeCity.ActiveReports.Design.Designer theDesigner;
        private GrapeCity.ActiveReports.Design.Toolbox.Toolbox arToolbox;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private GrapeCity.ActiveReports.Design.ReportExplorer.ReportExplorer reportExplorer1;
        private System.Windows.Forms.PropertyGrid arPropertyGrid;
    }
}