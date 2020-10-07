namespace SparklineExplorer.Samples
{
    partial class RegionSales
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
            this.fxgRegionSales = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.fxgRegionSales)).BeginInit();
            this.SuspendLayout();
            // 
            // fxgRegionSales
            // 
            this.fxgRegionSales.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.fxgRegionSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fxgRegionSales.Location = new System.Drawing.Point(0, 0);
            this.fxgRegionSales.Name = "fxgRegionSales";
            this.fxgRegionSales.Size = new System.Drawing.Size(385, 389);
            this.fxgRegionSales.TabIndex = 0;
            this.fxgRegionSales.Text = "c1FlexGrid1";
            // 
            // RegionSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fxgRegionSales);
            this.Name = "RegionSales";
            this.Size = new System.Drawing.Size(385, 389);
            ((System.ComponentModel.ISupportInitialize)(this.fxgRegionSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid fxgRegionSales;
    }
}
