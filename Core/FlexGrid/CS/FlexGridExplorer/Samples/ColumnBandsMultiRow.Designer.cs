
namespace FlexGridExplorer.Samples
{
    partial class ColumnBandsMultiRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnBandsMultiRow));
            this.flexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1FlexGridBandedView1 = new C1.Win.FlexGrid.C1FlexGridBandedView();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.flexGrid1.AllowEditing = false;
            this.flexGrid1.AllowMergingFixed = C1.Win.FlexGrid.AllowMergingEnum.Custom;
            this.flexGrid1.ColumnContextMenuEnabled = true;
            this.flexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.flexGrid1.DataSource = this.carsBindingSource;
            this.flexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this.flexGrid1.Location = new System.Drawing.Point(0, 0);
            this.flexGrid1.Name = "c1FlexGrid1";
            this.flexGrid1.Rows.Count = 3;
            this.flexGrid1.Rows.Fixed = 3;
            this.flexGrid1.Size = new System.Drawing.Size(650, 585);
            this.flexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.flexGrid1.TabIndex = 0;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            // 
            // c1FlexGridBandedView1
            // 
            this.c1FlexGridBandedView1.ColumnContextMenuEnabled = true;
            // 
            // ColumnBandsMultiRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flexGrid1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "ColumnBandsMultiRow";
            this.Size = new System.Drawing.Size(650, 585);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGridBandedView c1FlexGridBandedView1;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private C1.Win.FlexGrid.C1FlexGrid flexGrid1;
    }
}
