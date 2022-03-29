namespace ControlExplorer.FlexGrid
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnPicker));
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1FlexGridBandedView1 = new C1.Win.C1FlexGrid.C1FlexGridBandedView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCreateBands = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveBands = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = false;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 25);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(1450, 784);
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.AllowEditing = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateBands,
            this.toolStripSeparator1,
            this.btnRemoveBands});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1450, 50);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCreateBands
            // 
            this.btnCreateBands.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCreateBands.Image = ((System.Drawing.Image)(resources.GetObject("tsbCreateBands.Image")));
            this.btnCreateBands.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateBands.Name = "tsbCreateBands";
            this.btnCreateBands.Size = new System.Drawing.Size(124, 22);
            this.btnCreateBands.Text = "Create column bands";
            this.btnCreateBands.Click += new System.EventHandler(this.btnCreateBands_Click);
            // 
            // btnRemoveBands
            // 
            this.btnRemoveBands.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemoveBands.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveBands.Image")));
            this.btnRemoveBands.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveBands.Name = "tsbRemoveBands";
            this.btnRemoveBands.Size = new System.Drawing.Size(133, 22);
            this.btnRemoveBands.Text = "Remove column bands";
            this.btnRemoveBands.Click += new System.EventHandler(this.btnRemoveBands_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ColumnPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 809);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ColumnPicker";
            this.Text = "ColumnPicker";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1FlexGrid.C1FlexGridBandedView c1FlexGridBandedView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCreateBands;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRemoveBands;
    }
}