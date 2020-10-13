namespace _V1_2010_NewFeatures
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._searchBox = new _V1_2010_NewFeatures.SearchBox();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _timer
            // 
            this._timer.Interval = 1000;
            // 
            // _flex
            // 
            this._flex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:29;}\t";
            this._flex.Location = new System.Drawing.Point(12, 38);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.Size = new System.Drawing.Size(546, 374);
            this._flex.TabIndex = 0;
            this._flex.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            // 
            // _searchBox
            // 
            this._searchBox.AutoSize = true;
            this._searchBox.Delay = 1000;
            this._searchBox.Location = new System.Drawing.Point(12, 10);
            this._searchBox.Name = "_searchBox";
            this._searchBox.Size = new System.Drawing.Size(133, 22);
            this._searchBox.TabIndex = 5;
            this._searchBox.Search += new System.EventHandler(this._searchBox_Search);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 424);
            this.Controls.Add(this._searchBox);
            this.Controls.Add(this._flex);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "C1FlexGrid: iTunes-style search";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.Timer _timer;
        private SearchBox _searchBox;
    }
}