namespace ControlExplorer.FlexGrid
{
    partial class DataMap
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
            this.flexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flexGrid
            // 
            this.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid.ColumnInfo = "10,1,0,0,0,105,Columns:";
            this.flexGrid.Location = new System.Drawing.Point(9, 10);
            this.flexGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flexGrid.Name = "_flex";
            this.flexGrid.Rows.DefaultSize = 21;
            this.flexGrid.Size = new System.Drawing.Size(396, 266);
            this.flexGrid.TabIndex = 0;
            // 
            // DataMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 284);
            this.Controls.Add(this.flexGrid);
            this.Name = "DataMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: DataMap";
            this.Load += new System.EventHandler(this.DataMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            this.ResumeLayout(false);

        }

        private C1.Win.C1FlexGrid.C1FlexGrid flexGrid;

        #endregion
    }
}