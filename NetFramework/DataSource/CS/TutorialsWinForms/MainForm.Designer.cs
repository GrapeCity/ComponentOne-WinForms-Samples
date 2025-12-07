namespace TutorialsWinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.showSimpleBinding = new System.Windows.Forms.Button();
            this.showMasterDetailBinding = new System.Windows.Forms.Button();
            this.showServerSideFiltering = new System.Windows.Forms.Button();
            this.showPaging = new System.Windows.Forms.Button();
            this.showLargeDataset = new System.Windows.Forms.Button();
            this.showCustomColumns = new System.Windows.Forms.Button();
            this.showDataSourcesInCode = new System.Windows.Forms.Button();
            this.showClientSideQuerying = new System.Windows.Forms.Button();
            this.showMVVM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showSimpleBinding
            // 
            this.showSimpleBinding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showSimpleBinding.Location = new System.Drawing.Point(15, 40);
            this.showSimpleBinding.Name = "showSimpleBinding";
            this.showSimpleBinding.Size = new System.Drawing.Size(269, 30);
            this.showSimpleBinding.TabIndex = 0;
            this.showSimpleBinding.Text = "Simple binding";
            this.showSimpleBinding.UseVisualStyleBackColor = true;
            this.showSimpleBinding.Click += new System.EventHandler(this.showSimpleBinding_Click);
            // 
            // showMasterDetailBinding
            // 
            this.showMasterDetailBinding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showMasterDetailBinding.Location = new System.Drawing.Point(15, 108);
            this.showMasterDetailBinding.Name = "showMasterDetailBinding";
            this.showMasterDetailBinding.Size = new System.Drawing.Size(269, 30);
            this.showMasterDetailBinding.TabIndex = 2;
            this.showMasterDetailBinding.Text = "Master-detail binding";
            this.showMasterDetailBinding.UseVisualStyleBackColor = true;
            this.showMasterDetailBinding.Click += new System.EventHandler(this.showMasterDetailBinding_Click);
            // 
            // showServerSideFiltering
            // 
            this.showServerSideFiltering.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showServerSideFiltering.Location = new System.Drawing.Point(15, 74);
            this.showServerSideFiltering.Name = "showServerSideFiltering";
            this.showServerSideFiltering.Size = new System.Drawing.Size(269, 30);
            this.showServerSideFiltering.TabIndex = 1;
            this.showServerSideFiltering.Text = "Server-side filtering";
            this.showServerSideFiltering.UseVisualStyleBackColor = true;
            this.showServerSideFiltering.Click += new System.EventHandler(this.showServerSideFiltering_Click);
            // 
            // showPaging
            // 
            this.showPaging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showPaging.Location = new System.Drawing.Point(15, 142);
            this.showPaging.Name = "showPaging";
            this.showPaging.Size = new System.Drawing.Size(269, 30);
            this.showPaging.TabIndex = 3;
            this.showPaging.Text = "Paging";
            this.showPaging.UseVisualStyleBackColor = true;
            this.showPaging.Click += new System.EventHandler(this.showPaging_Click);
            // 
            // showLargeDataset
            // 
            this.showLargeDataset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showLargeDataset.Location = new System.Drawing.Point(15, 176);
            this.showLargeDataset.Name = "showLargeDataset";
            this.showLargeDataset.Size = new System.Drawing.Size(269, 30);
            this.showLargeDataset.TabIndex = 4;
            this.showLargeDataset.Text = "Large datasets: Virtual Mode";
            this.showLargeDataset.UseVisualStyleBackColor = true;
            this.showLargeDataset.Click += new System.EventHandler(this.showLargeDataset_Click);
            // 
            // showCustomColumns
            // 
            this.showCustomColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showCustomColumns.Location = new System.Drawing.Point(15, 210);
            this.showCustomColumns.Name = "showCustomColumns";
            this.showCustomColumns.Size = new System.Drawing.Size(269, 30);
            this.showCustomColumns.TabIndex = 5;
            this.showCustomColumns.Text = "Custom Columns";
            this.showCustomColumns.UseVisualStyleBackColor = true;
            this.showCustomColumns.Click += new System.EventHandler(this.showCustomColumns_Click);
            // 
            // showDataSourcesInCode
            // 
            this.showDataSourcesInCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showDataSourcesInCode.Location = new System.Drawing.Point(15, 280);
            this.showDataSourcesInCode.Name = "showDataSourcesInCode";
            this.showDataSourcesInCode.Size = new System.Drawing.Size(269, 30);
            this.showDataSourcesInCode.TabIndex = 6;
            this.showDataSourcesInCode.Text = "Data sources in code";
            this.showDataSourcesInCode.UseVisualStyleBackColor = true;
            this.showDataSourcesInCode.Click += new System.EventHandler(this.showDataSourcesInCode_Click);
            // 
            // showClientSideQuerying
            // 
            this.showClientSideQuerying.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showClientSideQuerying.Location = new System.Drawing.Point(15, 314);
            this.showClientSideQuerying.Name = "showClientSideQuerying";
            this.showClientSideQuerying.Size = new System.Drawing.Size(269, 30);
            this.showClientSideQuerying.TabIndex = 7;
            this.showClientSideQuerying.Text = "Client-side querying: Live views";
            this.showClientSideQuerying.UseVisualStyleBackColor = true;
            this.showClientSideQuerying.Click += new System.EventHandler(this.showClientSideQuerying_Click);
            // 
            // showMVVM
            // 
            this.showMVVM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showMVVM.Location = new System.Drawing.Point(15, 384);
            this.showMVVM.Name = "showMVVM";
            this.showMVVM.Size = new System.Drawing.Size(269, 30);
            this.showMVVM.TabIndex = 8;
            this.showMVVM.Text = "MVVM";
            this.showMVVM.UseVisualStyleBackColor = true;
            this.showMVVM.Click += new System.EventHandler(this.showMVVM_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Using C1DataSource control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Programming in code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Using MVVM pattern";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showMVVM);
            this.Controls.Add(this.showClientSideQuerying);
            this.Controls.Add(this.showDataSourcesInCode);
            this.Controls.Add(this.showCustomColumns);
            this.Controls.Add(this.showLargeDataset);
            this.Controls.Add(this.showPaging);
            this.Controls.Add(this.showServerSideFiltering);
            this.Controls.Add(this.showMasterDetailBinding);
            this.Controls.Add(this.showSimpleBinding);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tutorials WinForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showSimpleBinding;
        private System.Windows.Forms.Button showMasterDetailBinding;
        private System.Windows.Forms.Button showServerSideFiltering;
        private System.Windows.Forms.Button showPaging;
        private System.Windows.Forms.Button showLargeDataset;
        private System.Windows.Forms.Button showCustomColumns;
        private System.Windows.Forms.Button showDataSourcesInCode;
        private System.Windows.Forms.Button showClientSideQuerying;
        private System.Windows.Forms.Button showMVVM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

