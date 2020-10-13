namespace ControlExplorer.FlexGrid
{
    partial class DataAnnotations
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
            this.flexGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.flexGrid.Location = new System.Drawing.Point(12, 12);
            this.flexGrid.Name = "_flex";
            this.flexGrid.Size = new System.Drawing.Size(526, 326);
            this.flexGrid.ShowErrors = true;
            this.flexGrid.TabIndex = 0;
            // 
            // DataAnnotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.flexGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: DataAnnotations";
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private C1.Win.C1FlexGrid.C1FlexGrid flexGrid;

        #endregion
    }
}