namespace ControlExplorer.FlexPivot
{
    partial class Ranges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranges));
            C1.DataEngine.Workspace workspace1 = C1.Win.FlexPivot.C1FlexPivotPanel.CreateWorkspace();
            this.scSlicers = new System.Windows.Forms.SplitContainer();
            this.pivotSlicerTop = new C1.Win.FlexPivot.C1FlexPivotSlicer();
            this.pivotSlicerBottom = new C1.Win.FlexPivot.C1FlexPivotSlicer();
            this.scPivotPanel = new System.Windows.Forms.SplitContainer();
            this.pivotGrid = new C1.Win.FlexPivot.C1FlexPivotGrid();
            this.pivotPanel = new C1.Win.FlexPivot.C1FlexPivotPanel();
            ((System.ComponentModel.ISupportInitialize)(this.scSlicers)).BeginInit();
            this.scSlicers.Panel1.SuspendLayout();
            this.scSlicers.Panel2.SuspendLayout();
            this.scSlicers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotSlicerTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotSlicerBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scPivotPanel)).BeginInit();
            this.scPivotPanel.Panel1.SuspendLayout();
            this.scPivotPanel.Panel2.SuspendLayout();
            this.scPivotPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // scSlicers
            // 
            this.scSlicers.Dock = System.Windows.Forms.DockStyle.Left;
            this.scSlicers.Location = new System.Drawing.Point(0, 0);
            this.scSlicers.Name = "scSlicers";
            this.scSlicers.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSlicers.Panel1
            // 
            this.scSlicers.Panel1.Controls.Add(this.pivotSlicerTop);
            this.scSlicers.Panel1MinSize = 100;
            // 
            // scSlicers.Panel2
            // 
            this.scSlicers.Panel2.Controls.Add(this.pivotSlicerBottom);
            this.scSlicers.Panel2MinSize = 100;
            this.scSlicers.Size = new System.Drawing.Size(150, 450);
            this.scSlicers.SplitterDistance = 218;
            this.scSlicers.TabIndex = 0;
            // 
            // pivotSlicerTop
            // 
            this.pivotSlicerTop.AccessibleName = "pivotSlicerTop";
            this.pivotSlicerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotSlicerTop.Location = new System.Drawing.Point(0, 0);
            this.pivotSlicerTop.MultiSelect = false;
            this.pivotSlicerTop.Name = "pivotSlicerTop";
            this.pivotSlicerTop.ShowSelectAll = true;
            this.pivotSlicerTop.Size = new System.Drawing.Size(150, 218);
            this.pivotSlicerTop.TabIndex = 0;
            this.pivotSlicerTop.Text = "pivotSlicerTop";
            // 
            // pivotSlicerBottom
            // 
            this.pivotSlicerBottom.AccessibleName = "pivotSlicerBottom";
            this.pivotSlicerBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotSlicerBottom.Location = new System.Drawing.Point(0, 0);
            this.pivotSlicerBottom.MultiSelect = false;
            this.pivotSlicerBottom.Name = "pivotSlicerBottom";
            this.pivotSlicerBottom.ShowSelectAll = true;
            this.pivotSlicerBottom.Size = new System.Drawing.Size(150, 228);
            this.pivotSlicerBottom.TabIndex = 1;
            this.pivotSlicerBottom.Text = "pivotSlicerBottom";
            // 
            // scPivotPanel
            // 
            this.scPivotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPivotPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scPivotPanel.Location = new System.Drawing.Point(150, 0);
            this.scPivotPanel.Name = "scPivotPanel";
            // 
            // scPivotPanel.Panel1
            // 
            this.scPivotPanel.Panel1.Controls.Add(this.pivotGrid);
            // 
            // scPivotPanel.Panel2
            // 
            this.scPivotPanel.Panel2.Controls.Add(this.pivotPanel);
            this.scPivotPanel.Size = new System.Drawing.Size(650, 450);
            this.scPivotPanel.SplitterDistance = 420;
            this.scPivotPanel.TabIndex = 1;
            // 
            // pivotGrid
            // 
            this.pivotGrid.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.FixedOnly;
            this.pivotGrid.AllowMergingFixed = C1.Win.FlexGrid.AllowMergingEnum.Default;
            this.pivotGrid.ColumnInfo = "1,1,0,0,0,125,Columns:0{Width:125;Caption:\" \";}\t";
            this.pivotGrid.DataSource = this.pivotPanel;
            this.pivotGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGrid.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this.pivotGrid.Location = new System.Drawing.Point(0, 0);
            this.pivotGrid.Name = "pivotGrid";
            this.pivotGrid.Rows.Count = 1;
            this.pivotGrid.Rows.DefaultSize = 25;
            this.pivotGrid.Size = new System.Drawing.Size(450, 450);
            this.pivotGrid.StyleInfo = resources.GetString("pivotGrid.StyleInfo");
            this.pivotGrid.SubtotalBackground = System.Drawing.Color.Empty;
            this.pivotGrid.SubtotalForeground = System.Drawing.Color.Empty;
            this.pivotGrid.TabIndex = 0;
            // 
            // pivotPanel
            // 
            this.pivotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotPanel.Location = new System.Drawing.Point(0, 0);
            this.pivotPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pivotPanel.Name = "pivotPanel";
            this.pivotPanel.Size = new System.Drawing.Size(196, 450);
            this.pivotPanel.TabIndex = 0;
            workspace1.AutoSave = true;
            workspace1.KeepFiles = C1.DataEngine.KeepFileType.Results;
            this.pivotPanel.Workspace = workspace1;
            // 
            // Ranges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scPivotPanel);
            this.Controls.Add(this.scSlicers);
            this.Name = "Ranges";
            this.Text = "Ranges";
            this.scSlicers.Panel1.ResumeLayout(false);
            this.scSlicers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSlicers)).EndInit();
            this.scSlicers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotSlicerTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotSlicerBottom)).EndInit();
            this.scPivotPanel.Panel1.ResumeLayout(false);
            this.scPivotPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPivotPanel)).EndInit();
            this.scPivotPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scSlicers;
        private C1.Win.FlexPivot.C1FlexPivotSlicer pivotSlicerTop;
        private C1.Win.FlexPivot.C1FlexPivotSlicer pivotSlicerBottom;
        private System.Windows.Forms.SplitContainer scPivotPanel;
        private C1.Win.FlexPivot.C1FlexPivotGrid pivotGrid;
        private C1.Win.FlexPivot.C1FlexPivotPanel pivotPanel;
    }
}