namespace FilterMenu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._mnuEditFilters = new System.Windows.Forms.ToolStripDropDownButton();
            this._mnuClearFilters = new System.Windows.Forms.ToolStripDropDownButton();
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuEditFilters,
            this._mnuClearFilters});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _mnuEditFilters
            // 
            this._mnuEditFilters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._mnuEditFilters.Image = ((System.Drawing.Image)(resources.GetObject("_mnuEditFilters.Image")));
            this._mnuEditFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._mnuEditFilters.Name = "_mnuEditFilters";
            this._mnuEditFilters.Size = new System.Drawing.Size(146, 36);
            this._mnuEditFilters.Text = "&Edit Filters";
            // 
            // _mnuClearFilters
            // 
            this._mnuClearFilters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._mnuClearFilters.Image = ((System.Drawing.Image)(resources.GetObject("_mnuClearFilters.Image")));
            this._mnuClearFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._mnuClearFilters.Name = "_mnuClearFilters";
            this._mnuClearFilters.Size = new System.Drawing.Size(160, 36);
            this._mnuClearFilters.Text = "&Clear Filters";
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,110,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._flex.Location = new System.Drawing.Point(0, 42);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 22;
            this._flex.Size = new System.Drawing.Size(580, 281);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 1;
            this._flex.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2010Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 323);
            this.Controls.Add(this._flex);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Edit filters from a Menu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private C1.Win.FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.ToolStripDropDownButton _mnuEditFilters;
        private System.Windows.Forms.ToolStripDropDownButton _mnuClearFilters;
    }
}

