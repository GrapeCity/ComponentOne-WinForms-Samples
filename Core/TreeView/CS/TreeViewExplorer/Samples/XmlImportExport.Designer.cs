namespace TreeViewExplorer.Samples
{
    partial class XmlImportExport
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn3 = new C1.Win.TreeView.C1TreeColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExport = new C1.Win.Input.C1Button();
            this.btnImport = new C1.Win.Input.C1Button();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnImport, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.c1TreeView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 492);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Location = new System.Drawing.Point(420, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 25);
            this.btnExport.Styles.Padding = new C1.Framework.Thickness(4, 4, 4, 4);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export to XML";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImport.Location = new System.Drawing.Point(312, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(102, 25);
            this.btnImport.Styles.Padding = new C1.Framework.Thickness(4, 4, 4, 4);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import from XML";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // c1TreeView1
            // 
            c1TreeColumn3.HeaderText = "Column1";
            c1TreeColumn3.Name = "Column1";
            this.c1TreeView1.Columns.Add(c1TreeColumn3);
            this.tableLayoutPanel1.SetColumnSpan(this.c1TreeView1, 2);
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.Location = new System.Drawing.Point(3, 34);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.Size = new System.Drawing.Size(828, 455);
            this.c1TreeView1.TabIndex = 1;
            // 
            // XmlImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "XmlImport";
            this.Size = new System.Drawing.Size(834, 492);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Input.C1Button btnImport;
        private C1.Win.Input.C1Button btnExport;
        private C1.Win.TreeView.C1TreeView c1TreeView1;
    }
}
