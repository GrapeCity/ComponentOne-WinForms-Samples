namespace ControlExplorer.DataCollection
{
    partial class DataGridViewVirtualization
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c1DbNavigator1 = new C1.Win.C1Input.C1DbNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DbNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(928, 778);
            this.dataGridView1.TabIndex = 0;
            // 
            // c1DbNavigator1
            // 
            this.c1DbNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1DbNavigator1.Location = new System.Drawing.Point(0, 0);
            this.c1DbNavigator1.Name = "c1DbNavigator1";
            this.c1DbNavigator1.Size = new System.Drawing.Size(928, 22);
            this.c1DbNavigator1.TabIndex = 1;
            // 
            // DataGridViewVirtualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 778);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.c1DbNavigator1);
            this.Name = "DataGridViewVirtualization";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DbNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private C1.Win.C1Input.C1DbNavigator c1DbNavigator1;
    }
}
