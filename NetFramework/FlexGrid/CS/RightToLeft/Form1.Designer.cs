namespace RightToLeft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._btnRightToLeft = new System.Windows.Forms.ToolStripButton();
            this._btnPrint = new System.Windows.Forms.ToolStripButton();
            this._btnScrollHome = new System.Windows.Forms.ToolStripButton();
            this._btnSelectHome = new System.Windows.Forms.ToolStripButton();
            this._btnSelectEnd = new System.Windows.Forms.ToolStripButton();
            this._btnRenderMode = new System.Windows.Forms.ToolStripButton();
            this._btnOutlineTree = new System.Windows.Forms.ToolStripButton();
            this._btnBelow = new System.Windows.Forms.ToolStripButton();
            this._btnCellLabels = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._flex);
            this.splitContainer1.Size = new System.Drawing.Size(890, 404);
            this.splitContainer1.SplitterDistance = 433;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // _flex
            // 
            this._flex.AllowAddNew = true;
            this._flex.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
            this._flex.AllowFiltering = true;
            this._flex.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both;
            this._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this._flex.ColumnInfo = "10,1,0,0,0,120,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.NewRowWatermark = "Type here to create a new row...";
            this._flex.Rows.DefaultSize = 24;
            this._flex.ShowCursor = true;
            this._flex.ShowErrors = true;
            this._flex.Size = new System.Drawing.Size(452, 404);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnRightToLeft,
            this._btnPrint,
            this._btnScrollHome,
            this._btnSelectHome,
            this._btnSelectEnd,
            this._btnRenderMode,
            this._btnOutlineTree,
            this._btnBelow,
            this._btnCellLabels});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _btnRightToLeft
            // 
            this._btnRightToLeft.CheckOnClick = true;
            this._btnRightToLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnRightToLeft.Image = ((System.Drawing.Image)(resources.GetObject("_btnRightToLeft.Image")));
            this._btnRightToLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnRightToLeft.Name = "_btnRightToLeft";
            this._btnRightToLeft.Size = new System.Drawing.Size(38, 22);
            this._btnRightToLeft.Text = "RTL";
            this._btnRightToLeft.Click += new System.EventHandler(this._btnRightToLeft_Click);
            // 
            // _btnPrint
            // 
            this._btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("_btnPrint.Image")));
            this._btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Size = new System.Drawing.Size(40, 22);
            this._btnPrint.Text = "Print";
            this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
            // 
            // _btnScrollHome
            // 
            this._btnScrollHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnScrollHome.Image = ((System.Drawing.Image)(resources.GetObject("_btnScrollHome.Image")));
            this._btnScrollHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnScrollHome.Name = "_btnScrollHome";
            this._btnScrollHome.Size = new System.Drawing.Size(88, 22);
            this._btnScrollHome.Text = "Scroll Home";
            this._btnScrollHome.Click += new System.EventHandler(this._btnScrollHome_Click);
            // 
            // _btnSelectHome
            // 
            this._btnSelectHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnSelectHome.Image = ((System.Drawing.Image)(resources.GetObject("_btnSelectHome.Image")));
            this._btnSelectHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnSelectHome.Name = "_btnSelectHome";
            this._btnSelectHome.Size = new System.Drawing.Size(94, 22);
            this._btnSelectHome.Text = "Select Home";
            this._btnSelectHome.Click += new System.EventHandler(this._btnSelectHome_Click);
            // 
            // _btnSelectEnd
            // 
            this._btnSelectEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnSelectEnd.Image = ((System.Drawing.Image)(resources.GetObject("_btnSelectEnd.Image")));
            this._btnSelectEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnSelectEnd.Name = "_btnSelectEnd";
            this._btnSelectEnd.Size = new System.Drawing.Size(79, 22);
            this._btnSelectEnd.Text = "Select End";
            this._btnSelectEnd.Click += new System.EventHandler(this._btnSelectEnd_Click);
            // 
            // _btnRenderMode
            // 
            this._btnRenderMode.CheckOnClick = true;
            this._btnRenderMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnRenderMode.Image = ((System.Drawing.Image)(resources.GetObject("_btnRenderMode.Image")));
            this._btnRenderMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnRenderMode.Name = "_btnRenderMode";
            this._btnRenderMode.Size = new System.Drawing.Size(102, 22);
            this._btnRenderMode.Text = "TextRenderer";
            this._btnRenderMode.Click += new System.EventHandler(this._btnRenderMode_Click);
            // 
            // _btnOutlineTree
            // 
            this._btnOutlineTree.CheckOnClick = true;
            this._btnOutlineTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnOutlineTree.Image = ((System.Drawing.Image)(resources.GetObject("_btnOutlineTree.Image")));
            this._btnOutlineTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnOutlineTree.Name = "_btnOutlineTree";
            this._btnOutlineTree.Size = new System.Drawing.Size(43, 22);
            this._btnOutlineTree.Text = "Tree";
            this._btnOutlineTree.Click += new System.EventHandler(this._btnOutlineTree_Click);
            // 
            // _btnBelow
            // 
            this._btnBelow.CheckOnClick = true;
            this._btnBelow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnBelow.Image = ((System.Drawing.Image)(resources.GetObject("_btnBelow.Image")));
            this._btnBelow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnBelow.Name = "_btnBelow";
            this._btnBelow.Size = new System.Drawing.Size(49, 22);
            this._btnBelow.Text = "Below";
            this._btnBelow.Click += new System.EventHandler(this._btnBelow_Click);
            // 
            // _btnCellLabels
            // 
            this._btnCellLabels.CheckOnClick = true;
            this._btnCellLabels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnCellLabels.Image = ((System.Drawing.Image)(resources.GetObject("_btnCellLabels.Image")));
            this._btnCellLabels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnCellLabels.Name = "_btnCellLabels";
            this._btnCellLabels.Size = new System.Drawing.Size(78, 22);
            this._btnCellLabels.Text = "Cell Labels";
            this._btnCellLabels.Click += new System.EventHandler(this._btnCellLabels_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 429);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _btnRightToLeft;
        private System.Windows.Forms.ToolStripButton _btnScrollHome;
        private System.Windows.Forms.ToolStripButton _btnSelectHome;
        private System.Windows.Forms.ToolStripButton _btnSelectEnd;
        private System.Windows.Forms.ToolStripButton _btnRenderMode;
        private System.Windows.Forms.ToolStripButton _btnOutlineTree;
        private System.Windows.Forms.ToolStripButton _btnPrint;
        private System.Windows.Forms.ToolStripButton _btnBelow;
        private System.Windows.Forms.ToolStripButton _btnCellLabels;
    }
}

