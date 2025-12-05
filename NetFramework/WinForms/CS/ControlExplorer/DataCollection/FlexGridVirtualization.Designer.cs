namespace ControlExplorer.DataCollection
{
    partial class FlexGridVirtualization
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
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1DbNavigator1 = new C1.Win.C1Input.C1DbNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DbNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 22);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(928, 756);
            this.c1FlexGrid1.TabIndex = 0;
            // 
            // c1DbNavigator1
            // 
            this.c1DbNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1DbNavigator1.Location = new System.Drawing.Point(0, 0);
            this.c1DbNavigator1.Name = "c1DbNavigator1";
            this.c1DbNavigator1.Size = new System.Drawing.Size(928, 22);
            this.c1DbNavigator1.TabIndex = 1;
            // 
            // FlexGridVirtualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 778);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.c1DbNavigator1);
            this.Name = "FlexGridVirtualization";
            this.Text = "FlexGridVirtualization";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DbNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1Input.C1DbNavigator c1DbNavigator1;
    }
}