namespace FlexGridExplorer.Samples
{
    partial class Sparkline
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
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.AllowEditing = false;
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Location = new System.Drawing.Point(0,0);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new System.Drawing.Size(360, 225);
            c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexGrid1.TabIndex = 0;
            // 
            // Sparkline
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(c1FlexGrid1);
            Name = "Sparkline";
            Size = new System.Drawing.Size(1317, 796);
            this.Load += new System.EventHandler(this.Sparkline_Load);
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}
