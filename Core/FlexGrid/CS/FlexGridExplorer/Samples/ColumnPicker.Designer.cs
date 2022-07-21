namespace FlexGridExplorer.Samples
{
    partial class ColumnPicker
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCreateBands = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRemoveBands = new System.Windows.Forms.ToolStripButton();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1FlexGridBandedView1 = new C1.Win.FlexGrid.C1FlexGridBandedView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowEditing = false;
            this.c1FlexGrid1.AllowMergingFixed = C1.Win.FlexGrid.AllowMergingEnum.Custom;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(650, 585);
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            // 
            // c1FlexGridBandedView1
            // 
            this.c1FlexGridBandedView1.ColumnContextMenuEnabled = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateBands,
            this.toolStripSeparator1,
            this.btnRemoveBands});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(716, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCreateBands
            // 
            this.btnCreateBands.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCreateBands.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateBands.Name = "btnCreateBands";
            this.btnCreateBands.Size = new System.Drawing.Size(124, 47);
            this.btnCreateBands.Text = "Create column bands";
            this.btnCreateBands.Click += new System.EventHandler(this.btnCreateBands_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // btnRemoveBands
            // 
            this.btnRemoveBands.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemoveBands.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveBands.Name = "btnRemoveBands";
            this.btnRemoveBands.Size = new System.Drawing.Size(133, 47);
            this.btnRemoveBands.Text = "Remove column bands";
            this.btnRemoveBands.Click += new System.EventHandler(this.btnRemoveBands_Click);
            // 
            // ColumnPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ColumnPicker";
            this.Size = new System.Drawing.Size(716, 565);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCreateBands;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRemoveBands;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.FlexGrid.C1FlexGridBandedView c1FlexGridBandedView1;
    }
}
