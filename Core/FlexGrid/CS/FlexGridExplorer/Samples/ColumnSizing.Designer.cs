namespace FlexGridExplorer.Samples
{
    partial class ColumnSizing
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
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            label = new System.Windows.Forms.ToolStripLabel();
            cmbMethod = new System.Windows.Forms.ToolStripComboBox();
            flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flexGrid).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { label, cmbMethod });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(701, 28);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // label
            // 
            label.Name = "label";
            label.Size = new System.Drawing.Size(105, 25);
            label.Text = "Sizing Method";
            // 
            // cmbMethod
            // 
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new System.Drawing.Size(180, 28);
            cmbMethod.SelectedIndexChanged += CmbMethod_SelectedIndexChanged;
            // 
            // flexGrid
            // 
            flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            flexGrid.Location = new System.Drawing.Point(0, 28);
            flexGrid.Name = "flexGrid";
            flexGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            flexGrid.Size = new System.Drawing.Size(701, 710);
            flexGrid.TabIndex = 1;
            // 
            // ColumnSizing
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flexGrid);
            Controls.Add(toolStrip1);
            Name = "ColumnSizing";
            Size = new System.Drawing.Size(701, 738);
            Load += ColumnSizingOptions_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)flexGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel label;
        private System.Windows.Forms.ToolStripComboBox cmbMethod;
        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
    }
}
