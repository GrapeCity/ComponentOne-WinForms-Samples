namespace FlexPivotExplorer.Samples.FlexPivotRanges
{
    partial class PivotView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PivotView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c1FlexPivotSlicer1 = new C1.Win.FlexPivot.C1FlexPivotSlicer();
            this.c1FlexPivotSlicer2 = new C1.Win.FlexPivot.C1FlexPivotSlicer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.c1FlexPivotGrid1 = new C1.Win.FlexPivot.C1FlexPivotGrid();
            this.pivotPanel = new C1.Win.FlexPivot.C1FlexPivotPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotSlicer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotSlicer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.c1FlexPivotSlicer1);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1FlexPivotSlicer2);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(310, 748);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 0;
            // 
            // c1FlexPivotSlicer1
            // 
            this.c1FlexPivotSlicer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotSlicer1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotSlicer1.MultiSelect = false;
            this.c1FlexPivotSlicer1.Name = "c1FlexPivotSlicer1";
            this.c1FlexPivotSlicer1.ShowSelectAll = true;
            this.c1FlexPivotSlicer1.Size = new System.Drawing.Size(310, 336);
            this.c1FlexPivotSlicer1.TabIndex = 0;
            this.c1FlexPivotSlicer1.Text = "c1FlexPivotSlicer1";
            // 
            // c1FlexPivotSlicer2
            // 
            this.c1FlexPivotSlicer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotSlicer2.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotSlicer2.MultiSelect = false;
            this.c1FlexPivotSlicer2.Name = "c1FlexPivotSlicer2";
            this.c1FlexPivotSlicer2.ShowSelectAll = true;
            this.c1FlexPivotSlicer2.Size = new System.Drawing.Size(310, 408);
            this.c1FlexPivotSlicer2.TabIndex = 1;
            this.c1FlexPivotSlicer2.Text = "c1FlexPivotSlicer2";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(310, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.c1FlexPivotGrid1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pivotPanel);
            this.splitContainer2.Size = new System.Drawing.Size(1101, 748);
            this.splitContainer2.SplitterDistance = 719;
            this.splitContainer2.TabIndex = 1;
            // 
            // c1FlexPivotGrid1
            // 
            this.c1FlexPivotGrid1.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.FixedOnly;
            this.c1FlexPivotGrid1.AllowMergingFixed = C1.Win.FlexGrid.AllowMergingEnum.Default;
            this.c1FlexPivotGrid1.ColumnInfo = "1,1,0,0,0,125,Columns:0{Width:125;Caption:\" \";}\t";
            this.c1FlexPivotGrid1.DataSource = this.pivotPanel;
            this.c1FlexPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this.c1FlexPivotGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotGrid1.Name = "c1FlexPivotGrid1";
            this.c1FlexPivotGrid1.Rows.Count = 1;
            this.c1FlexPivotGrid1.Size = new System.Drawing.Size(719, 748);
            this.c1FlexPivotGrid1.StyleInfo = resources.GetString("c1FlexPivotGrid1.StyleInfo");
            this.c1FlexPivotGrid1.SubtotalBackground = System.Drawing.Color.Empty;
            this.c1FlexPivotGrid1.SubtotalForeground = System.Drawing.Color.Empty;
            this.c1FlexPivotGrid1.TabIndex = 0;
            // 
            // pivotPanel
            // 
            this.pivotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotPanel.Location = new System.Drawing.Point(0, 0);
            this.pivotPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pivotPanel.Name = "pivotPanel";
            this.pivotPanel.Size = new System.Drawing.Size(378, 748);
            this.pivotPanel.TabIndex = 0;
            this.pivotPanel.LoadedFields += new System.EventHandler(this.pivotPanel_LoadedFields);
            // 
            // PivotView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PivotView";
            this.Size = new System.Drawing.Size(1411, 748);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotSlicer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotSlicer2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.FlexPivot.C1FlexPivotSlicer c1FlexPivotSlicer1;
        private C1.Win.FlexPivot.C1FlexPivotSlicer c1FlexPivotSlicer2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private C1.Win.FlexPivot.C1FlexPivotGrid c1FlexPivotGrid1;
        private C1.Win.FlexPivot.C1FlexPivotPanel pivotPanel;
    }
}
