
namespace SelectionStatistics
{
    partial class SelectionStatisticsControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionStatisticsControl));
            this.tsSelectionStatistics = new System.Windows.Forms.ToolStrip();
            this.tslSelectionStatistics = new System.Windows.Forms.ToolStripLabel();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1NWindDataSet1 = new SelectionStatistics.C1NWindDataSet();
            this.ordersTableAdapter1 = new SelectionStatistics.C1NWindDataSetTableAdapters.OrdersTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsSelectionStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
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
            // tslSelectionStatistics
            // 
            this.tslSelectionStatistics.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslSelectionStatistics.Name = "tslSelectionStatistics";
            this.tslSelectionStatistics.Size = new System.Drawing.Size(113, 22);
            this.tslSelectionStatistics.Text = "tslSelectionStatistics";
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataSource = this.ordersBindingSource;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Size = new System.Drawing.Size(723, 582);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 1;
            this.c1FlexGrid1.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
            // 
            // c1NWindDataSet1
            // 
            this.c1NWindDataSet1.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.c1NWindDataSet1;
            // 
            // SelectionStatisticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.tsSelectionStatistics);
            this.Name = "SelectionStatisticsControl";
            this.Size = new System.Drawing.Size(723, 607);
            this.tsSelectionStatistics.ResumeLayout(false);
            this.tsSelectionStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        internal System.Windows.Forms.ToolStripLabel tslSelectionStatistics;
        internal System.Windows.Forms.ToolStrip tsSelectionStatistics;
        private C1NWindDataSet c1NWindDataSet1;
        private C1NWindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
    }
}
