namespace CustomOperations
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
            this.dgvResult = new C1.Win.FlexGrid.C1FlexGrid();
            this.cbQuery = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.lblTimeGen = new System.Windows.Forms.Label();
            this.cbItemsCount = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResultTotalRows = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOD = new System.Windows.Forms.TabPage();
            this.lblODRowsTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new C1.Win.FlexGrid.C1FlexGrid();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.gbQuery.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageOD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.tabPageResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.dgvResult.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dgvResult.Location = new System.Drawing.Point(8, 50);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Rows.DefaultSize = 20;
            this.dgvResult.Size = new System.Drawing.Size(630, 289);
            this.dgvResult.StyleInfo = resources.GetString("dgvResult.StyleInfo");
            this.dgvResult.TabIndex = 2;
            // 
            // cbQuery
            // 
            this.cbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuery.FormattingEnabled = true;
            this.cbQuery.Items.AddRange(new object[] {
            "Standard discount",
            "Progressive discount",
            "Big orders",
            "Orders"});
            this.cbQuery.Location = new System.Drawing.Point(103, 52);
            this.cbQuery.Name = "cbQuery";
            this.cbQuery.Size = new System.Drawing.Size(170, 21);
            this.cbQuery.TabIndex = 3;
            this.cbQuery.SelectedIndexChanged += new System.EventHandler(this.cbQuery_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Query type:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(297, 55);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(136, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time executing query:";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(10, 94);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(87, 23);
            this.btnExec.TabIndex = 2;
            this.btnExec.Text = "Execute";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // gbQuery
            // 
            this.gbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQuery.Controls.Add(this.lblTimeGen);
            this.gbQuery.Controls.Add(this.lblTime);
            this.gbQuery.Controls.Add(this.cbItemsCount);
            this.gbQuery.Controls.Add(this.btnExec);
            this.gbQuery.Controls.Add(this.label7);
            this.gbQuery.Controls.Add(this.label2);
            this.gbQuery.Controls.Add(this.cbQuery);
            this.gbQuery.Location = new System.Drawing.Point(14, 12);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Size = new System.Drawing.Size(648, 123);
            this.gbQuery.TabIndex = 9;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "Query";
            // 
            // lblTimeGen
            // 
            this.lblTimeGen.AutoSize = true;
            this.lblTimeGen.Location = new System.Drawing.Point(297, 21);
            this.lblTimeGen.Name = "lblTimeGen";
            this.lblTimeGen.Size = new System.Drawing.Size(134, 13);
            this.lblTimeGen.TabIndex = 9;
            this.lblTimeGen.Text = "Time generating data:";
            // 
            // cbItemsCount
            // 
            this.cbItemsCount.FormattingEnabled = true;
            this.cbItemsCount.Items.AddRange(new object[] {
            "100,000",
            "1,000,000",
            "10,000,000"});
            this.cbItemsCount.Location = new System.Drawing.Point(103, 18);
            this.cbItemsCount.Name = "cbItemsCount";
            this.cbItemsCount.Size = new System.Drawing.Size(170, 21);
            this.cbItemsCount.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Row count:";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDesc.Location = new System.Drawing.Point(3, 2);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(636, 46);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total rows:";
            // 
            // lblResultTotalRows
            // 
            this.lblResultTotalRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultTotalRows.AutoSize = true;
            this.lblResultTotalRows.Location = new System.Drawing.Point(76, 343);
            this.lblResultTotalRows.Name = "lblResultTotalRows";
            this.lblResultTotalRows.Size = new System.Drawing.Size(14, 13);
            this.lblResultTotalRows.TabIndex = 10;
            this.lblResultTotalRows.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageOD);
            this.tabControl1.Controls.Add(this.tabPageResults);
            this.tabControl1.Location = new System.Drawing.Point(14, 141);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 387);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageOD
            // 
            this.tabPageOD.Controls.Add(this.lblODRowsTotal);
            this.tabPageOD.Controls.Add(this.label10);
            this.tabPageOD.Controls.Add(this.dgvOrderDetails);
            this.tabPageOD.Location = new System.Drawing.Point(4, 22);
            this.tabPageOD.Name = "tabPageOD";
            this.tabPageOD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOD.Size = new System.Drawing.Size(644, 361);
            this.tabPageOD.TabIndex = 0;
            this.tabPageOD.Text = "Order Details";
            this.tabPageOD.UseVisualStyleBackColor = true;
            // 
            // lblODRowsTotal
            // 
            this.lblODRowsTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblODRowsTotal.AutoSize = true;
            this.lblODRowsTotal.Location = new System.Drawing.Point(75, 343);
            this.lblODRowsTotal.Name = "lblODRowsTotal";
            this.lblODRowsTotal.Size = new System.Drawing.Size(14, 13);
            this.lblODRowsTotal.TabIndex = 12;
            this.lblODRowsTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total rows:";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderDetails.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.dgvOrderDetails.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dgvOrderDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Rows.DefaultSize = 20;
            this.dgvOrderDetails.Size = new System.Drawing.Size(635, 332);
            this.dgvOrderDetails.StyleInfo = resources.GetString("dgvOrderDetails.StyleInfo");
            this.dgvOrderDetails.TabIndex = 3;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.lblDesc);
            this.tabPageResults.Controls.Add(this.lblResultTotalRows);
            this.tabPageResults.Controls.Add(this.dgvResult);
            this.tabPageResults.Controls.Add(this.label8);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Size = new System.Drawing.Size(644, 361);
            this.tabPageResults.TabIndex = 2;
            this.tabPageResults.Text = "Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 529);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbQuery);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.MinimumSize = new System.Drawing.Size(696, 400);
            this.Name = "Form1";
            this.Text = "Custom Operations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.gbQuery.ResumeLayout(false);
            this.gbQuery.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageOD.ResumeLayout(false);
            this.tabPageOD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.tabPageResults.ResumeLayout(false);
            this.tabPageResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid dgvResult;
        private System.Windows.Forms.ComboBox cbQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.ComboBox cbItemsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResultTotalRows;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOD;
        private System.Windows.Forms.TabPage tabPageResults;
        private C1.Win.FlexGrid.C1FlexGrid dgvOrderDetails;
        private System.Windows.Forms.Label lblODRowsTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTimeGen;
    }
}

