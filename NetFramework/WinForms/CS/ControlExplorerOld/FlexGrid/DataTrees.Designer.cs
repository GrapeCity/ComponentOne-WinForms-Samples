namespace ControlExplorer.FlexGrid
{
    partial class DataTrees
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
            this._flex = new ControlExplorer.FlexGrid.C1FlexDataTree();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.AllowAddNew = true;
            this._flex.AllowDelete = true;
            this._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:34;Style:\"ImageAlign:RightCenter;\";}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Rows.Count = 51;
            this._flex.Rows.DefaultSize = 17;
            this._flex.Size = new System.Drawing.Size(592, 446);
            this._flex.TabIndex = 0;
            this._flex.SetupColumns += new System.EventHandler(this._flex_SetupColumns);
            // 
            // DataTrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this._flex);
            this.Name = "DataTrees";
            this.Text = "DataTrees";
            this.Load += new System.EventHandler(this.DataTrees_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1FlexDataTree _flex;
    }
}