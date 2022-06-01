namespace TreeViewExplorer.Samples
{
    partial class CustomNodes
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn2 = new C1.Win.TreeView.C1TreeColumn();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TreeView1
            // 
            // 
            // 
            // 
            this.c1TreeView1.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.ButtonImageList.ImageSize = new System.Drawing.Size(16, 16);
            // 
            // 
            // 
            this.c1TreeView1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.CheckImageList.ImageSize = new System.Drawing.Size(16, 16);
            c1TreeColumn1.DisplayFieldName = "ProductName";
            c1TreeColumn1.HeaderText = "Category";
            c1TreeColumn1.Name = "Column1";
            c1TreeColumn1.Width = 210;
            c1TreeColumn2.HeaderText = "Products";
            c1TreeColumn2.Name = null;
            c1TreeColumn2.Width = 200;
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.Columns.Add(c1TreeColumn2);
            this.c1TreeView1.Styles.BorderStyle = C1.Win.TreeView.C1TreeViewBorderStyle.Full;
            this.c1TreeView1.Styles.ColumnHeader.BackColor = System.Drawing.Color.YellowGreen;
            this.c1TreeView1.Styles.ColumnHeader.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.c1TreeView1.Styles.ColumnHeader.ForeColor = System.Drawing.Color.Black;
            this.c1TreeView1.Styles.ColumnHeader.HorizontalAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1TreeView1.Styles.ExpandButtonStyle = C1.Win.TreeView.ExpandButtonStyle.Windows10;
            this.c1TreeView1.Styles.ShowLines = false;
            this.c1TreeView1.BackColor = System.Drawing.Color.White;
            this.c1TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.Size = new System.Drawing.Size(498, 315);
            this.c1TreeView1.TabIndex = 0;
            // 
            // CustomNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1TreeView1);
            this.Name = "CustomNodes";
            this.Size = new System.Drawing.Size(498, 315);
            this.Load += new System.EventHandler(this.CustomNodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.TreeView.C1TreeView c1TreeView1;
    }
}
