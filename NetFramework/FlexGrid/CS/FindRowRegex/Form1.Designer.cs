namespace FindRowRegEx
{
    partial class Form1
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
            this._flex = new C1.Win.FlexGrid.Classic.C1FlexGridClassic();
            this._txtSearch = new System.Windows.Forms.TextBox();
            this._btnFind = new System.Windows.Forms.Button();
            this._btnFindRx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGridClassic1
            // 
            this._flex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._flex.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this._flex.GridColorFixed = System.Drawing.SystemColors.ControlDark;
            this._flex.Location = new System.Drawing.Point(12, 39);
            this._flex.Name = "c1FlexGridClassic1";
            this._flex.NodeClosedPicture = null;
            this._flex.NodeOpenPicture = null;
            this._flex.OutlineCol = -1;
            this._flex.Size = new System.Drawing.Size(672, 385);
            this._flex.TabIndex = 0;
            this._flex.TreeColor = System.Drawing.Color.DarkGray;
            this._flex.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Black;
            // 
            // _txtSearch
            // 
            this._txtSearch.Location = new System.Drawing.Point(12, 11);
            this._txtSearch.Name = "_txtSearch";
            this._txtSearch.Size = new System.Drawing.Size(179, 20);
            this._txtSearch.TabIndex = 1;
            // 
            // _btnFind
            // 
            this._btnFind.Location = new System.Drawing.Point(197, 8);
            this._btnFind.Name = "_btnFind";
            this._btnFind.Size = new System.Drawing.Size(97, 25);
            this._btnFind.TabIndex = 2;
            this._btnFind.Text = "&Find";
            this._btnFind.UseVisualStyleBackColor = true;
            this._btnFind.Click += new System.EventHandler(this._btnFind_Click);
            // 
            // _btnFindRx
            // 
            this._btnFindRx.Location = new System.Drawing.Point(300, 8);
            this._btnFindRx.Name = "_btnFindRx";
            this._btnFindRx.Size = new System.Drawing.Size(97, 25);
            this._btnFindRx.TabIndex = 2;
            this._btnFindRx.Text = "Find RegE&x";
            this._btnFindRx.UseVisualStyleBackColor = true;
            this._btnFindRx.Click += new System.EventHandler(this._btnFindRx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 436);
            this.Controls.Add(this._btnFindRx);
            this.Controls.Add(this._btnFind);
            this.Controls.Add(this._txtSearch);
            this.Controls.Add(this._flex);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGridClassic: FindRowRegex";
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexGrid.Classic.C1FlexGridClassic _flex;
        private System.Windows.Forms.TextBox _txtSearch;
        private System.Windows.Forms.Button _btnFind;
        private System.Windows.Forms.Button _btnFindRx;
    }
}

