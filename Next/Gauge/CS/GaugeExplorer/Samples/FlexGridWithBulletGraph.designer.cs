namespace SampleExplorer
{
    partial class FlexGridWithBulletGraph
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2611, 5);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,125,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(2611, 1762);
            this.c1FlexGrid1.TabIndex = 4;
            this.c1FlexGrid1.AfterEdit += new C1.Win.FlexGrid.RowColEventHandler(this.c1FlexGrid1_AfterEdit);
            this.c1FlexGrid1.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this.c1FlexGrid1_OwnerDrawCell);
            // 
            // FlexGridWithBulletGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2611, 1762);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1FlexGrid1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FlexGridWithBulletGraph";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}

