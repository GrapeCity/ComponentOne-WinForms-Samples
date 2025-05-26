namespace FlexGridExplorer.Samples
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)flexGrid).BeginInit();
            SuspendLayout();
            // 
            // flexGrid
            // 
            flexGrid.ColumnInfo = "10,1,0,0,0,85,Columns:";
            flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            flexGrid.Location = new System.Drawing.Point(0, 0);
            flexGrid.Name = "flexGrid";
            flexGrid.Size = new System.Drawing.Size(1272, 855);
            flexGrid.TabIndex = 0;
            flexGrid.GetCellErrorInfo += _flex_GetCellErrorInfo;
            flexGrid.GetRowErrorInfo += _flex_GetRowErrorInfo;
            // 
            // ErrorInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(flexGrid);
            Name = "ErrorInfo";
            Size = new System.Drawing.Size(1272, 855);
            Load += ErrorInfo_Load;
            ((System.ComponentModel.ISupportInitialize)flexGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
    }
}
