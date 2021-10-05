
namespace FlexGridExplorer.Samples
{
    partial class SelectionStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionStatistics));
            this.tsSelectionStatistics = new System.Windows.Forms.ToolStrip();
            this.flexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.tslSelectionStatistics = new System.Windows.Forms.ToolStripLabel();
            this.tsSelectionStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsSelectionStatistics
            // 
            this.tsSelectionStatistics.BackColor = System.Drawing.SystemColors.Control;
            this.tsSelectionStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSelectionStatistics.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSelectionStatistics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSelectionStatistics});
            this.tsSelectionStatistics.Location = new System.Drawing.Point(0, 582);
            this.tsSelectionStatistics.Name = "tsSelectionStatistics";
            this.tsSelectionStatistics.Size = new System.Drawing.Size(723, 25);
            this.tsSelectionStatistics.TabIndex = 0;
            this.tsSelectionStatistics.Text = "tsSelectionStatistics";
            // 
            // c1FlexGrid1
            // 
            this.flexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.flexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid1.Location = new System.Drawing.Point(0, 0);
            this.flexGrid1.Name = "c1FlexGrid1";
            this.flexGrid1.Size = new System.Drawing.Size(723, 582);
            this.flexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.flexGrid1.TabIndex = 1;
            this.flexGrid1.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
            // 
            // tslSelectionStatistics
            // 
            this.tslSelectionStatistics.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslSelectionStatistics.Name = "tslSelectionStatistics";
            this.tslSelectionStatistics.Size = new System.Drawing.Size(113, 22);
            this.tslSelectionStatistics.Text = "tslSelectionStatistics";
            // 
            // SelectionStatisticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flexGrid1);
            this.Controls.Add(this.tsSelectionStatistics);
            this.Name = "SelectionStatisticsControl";
            this.Size = new System.Drawing.Size(723, 607);
            this.tsSelectionStatistics.ResumeLayout(false);
            this.tsSelectionStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal C1.Win.FlexGrid.C1FlexGrid flexGrid1;
        internal System.Windows.Forms.ToolStripLabel tslSelectionStatistics;
        internal System.Windows.Forms.ToolStrip tsSelectionStatistics;
    }
}
