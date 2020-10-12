namespace ControlExplorer.FlexGrid
{
    partial class ErrorInfo
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
            // _flex
            // 
            this.flexGrid.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid.Name = "_flex";
            this.flexGrid.Size = new System.Drawing.Size(472, 285);
            this.flexGrid.TabIndex = 0;
            this.flexGrid.GetRowErrorInfo += new C1.Win.C1FlexGrid.GetErrorInfoEventHandler(this._flex_GetRowErrorInfo);
            this.flexGrid.GetCellErrorInfo += new C1.Win.C1FlexGrid.GetErrorInfoEventHandler(this._flex_GetCellErrorInfo);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(472, 285);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.flexGrid});
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Display Error Information";
            this.Load += new System.EventHandler(this.ErrorInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private C1.Win.C1FlexGrid.C1FlexGrid flexGrid;

        #endregion
    }
}