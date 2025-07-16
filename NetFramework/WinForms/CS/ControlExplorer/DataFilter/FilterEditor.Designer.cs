namespace ControlExplorer.DataFilter
{
    partial class FilterEditor
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
            this.c1FilterEditor1 = new C1.Win.DataFilter.C1FilterEditor();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1FilterEditor1
            // 
            this.c1FilterEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FilterEditor1.Location = new System.Drawing.Point(0, 3);
            this.c1FilterEditor1.Name = "c1FilterEditor1";
            this.c1FilterEditor1.Size = new System.Drawing.Size(568, 692);
            this.c1FilterEditor1.TabIndex = 0;
            this.c1FilterEditor1.Text = "c1FilterEditor1";
            this.c1FilterEditor1.FilterChanged += new System.EventHandler(this.c1FilterEditor1_FilterChanged);
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(483, 749);
            this.c1FlexGrid1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.btnApply);
            this.splitContainer1.Panel1.Controls.Add(this.c1FilterEditor1);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1FlexGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(1057, 749);
            this.splitContainer1.SplitterDistance = 570;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(481, 714);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Filter";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(391, 714);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply Filter";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // FilterEditor
            // 
            this.ClientSize = new System.Drawing.Size(1057, 749);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FilterEditor";
            this.Load += new System.EventHandler(this.FilterEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.DataFilter.C1FilterEditor c1FilterEditor1;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnReset;
    }
}
