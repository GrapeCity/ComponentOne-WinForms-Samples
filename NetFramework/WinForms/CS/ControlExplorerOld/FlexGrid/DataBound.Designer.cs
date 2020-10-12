namespace ControlExplorer.FlexGrid
{
    partial class DataBound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBound));
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:27;}\t";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.NewRowWatermark = "Click to add new row";
            this.c1FlexGrid1.Rows.DefaultSize = 17;
            this.c1FlexGrid1.Rows.Fixed = 2;
            this.c1FlexGrid1.ScrollOptions = ((C1.Win.C1FlexGrid.ScrollFlags)((C1.Win.C1FlexGrid.ScrollFlags.DelayedScroll | C1.Win.C1FlexGrid.ScrollFlags.ShowScrollTips)));
            this.c1FlexGrid1.ShowCellLabels = true;
            this.c1FlexGrid1.ShowCursor = true;
            this.c1FlexGrid1.Size = new System.Drawing.Size(592, 446);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.ShowScrollTip += new C1.Win.C1FlexGrid.RowColToolTipEventHandler(this.c1FlexGrid1_ShowScrollTip);
            // 
            // DataBound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1FlexGrid1);
            this.Name = "DataBound";
            this.Text = "CellMerging";
            this.Load += new System.EventHandler(this.DataBound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;

    }
}