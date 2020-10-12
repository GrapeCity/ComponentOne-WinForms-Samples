namespace ControlExplorer.FlexGrid
{
    partial class SearchPanel
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
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1FlexGridSearchPanel1 = new C1.Win.C1FlexGrid.C1FlexGridSearchPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGridSearchPanel1.SetC1FlexGridSearchPanel(this.c1FlexGrid1, this.c1FlexGridSearchPanel1);
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 48);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.Size = new System.Drawing.Size(284, 213);
            this.c1FlexGrid1.TabIndex = 0;
            // 
            // c1FlexGridSearchPanel1
            // 
            this.c1FlexGridSearchPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1FlexGridSearchPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGridSearchPanel1.Name = "C1FlexGridSearchPanel";
            this.c1FlexGridSearchPanel1.SearchMode = C1.Win.C1FlexGrid.SearchMode.Always;
            this.c1FlexGridSearchPanel1.Size = new System.Drawing.Size(284, 49);
            this.c1FlexGridSearchPanel1.TabIndex = 0;
            // 
            // SearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.c1FlexGridSearchPanel1);
            this.Name = "SearchPanel";
            this.Text = "SearchPanel";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1FlexGrid.C1FlexGridSearchPanel c1FlexGridSearchPanel1;
    }
}