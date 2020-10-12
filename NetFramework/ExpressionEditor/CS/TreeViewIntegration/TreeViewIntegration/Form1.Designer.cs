namespace TreeViewIntegration
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
            this.components = new System.ComponentModel.Container();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn2 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn3 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn4 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn5 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn6 = new C1.Win.TreeView.C1TreeColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            this.c1NWindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1NWindDataSet = new TreeViewIntegration.C1NWindDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new TreeViewIntegration.C1NWindDataSetTableAdapters.CategoriesTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new TreeViewIntegration.C1NWindDataSetTableAdapters.ProductsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse left click on icon in Expression column header to open Expression Editor.";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 403);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(828, 3);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // c1TreeView1
            // 
            this.c1TreeView1.AllowEditing = true;
            this.c1TreeView1.AutoGenerateColumns = false;
            this.c1TreeView1.BindingInfo.DataMember = "Categories\\Products";
            this.c1TreeView1.BindingInfo.DataSource = this.c1NWindDataSetBindingSource;
            this.c1TreeView1.BindingInfo.KeyField = "CategoryID\\CategoryID";
            this.c1TreeView1.BindingInfo.ParentKeyField = null;
            this.c1TreeView1.BindingMode = C1.Win.TreeView.BindingMode.OneWay;
            // 
            // 
            // 
            this.c1TreeView1.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.ButtonImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.c1TreeView1.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.c1TreeView1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.CheckImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.c1TreeView1.CheckImageList.TransparentColor = System.Drawing.Color.Transparent;
            c1TreeColumn1.DisplayFieldName = "CategoryName\\ProductName";
            c1TreeColumn1.HeaderText = "Name";
            c1TreeColumn1.Name = "Name";
            c1TreeColumn1.Width = 200;
            c1TreeColumn2.DisplayFieldName = "UnitPrice\\UnitPrice";
            c1TreeColumn2.HeaderText = "UnitPrice";
            c1TreeColumn2.Name = "UnitPrice";
            c1TreeColumn2.Width = 70;
            c1TreeColumn3.DisplayFieldName = "UnitsInStock\\UnitsInStock";
            c1TreeColumn3.HeaderText = "UnitsInStock";
            c1TreeColumn3.Name = "UnitsInStock";
            c1TreeColumn3.Width = 80;
            c1TreeColumn4.DisplayFieldName = "UnitsOnOrder\\UnitsOnOrder";
            c1TreeColumn4.HeaderText = "UnitsOnOrder";
            c1TreeColumn4.Name = "UnitsOnOrder";
            c1TreeColumn4.Width = 90;
            c1TreeColumn5.DisplayFieldName = "ReorderLevel\\ReorderLevel";
            c1TreeColumn5.HeaderText = "ReorderLevel";
            c1TreeColumn5.Name = "ReorderLevel";
            c1TreeColumn5.Width = 90;
            c1TreeColumn6.DisplayFieldName = "TotalPrice\\TotalPrice";
            c1TreeColumn6.HeaderText = "TotalPrice";
            c1TreeColumn6.Name = "TotalPrice";
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.Columns.Add(c1TreeColumn2);
            this.c1TreeView1.Columns.Add(c1TreeColumn3);
            this.c1TreeView1.Columns.Add(c1TreeColumn4);
            this.c1TreeView1.Columns.Add(c1TreeColumn5);
            this.c1TreeView1.Columns.Add(c1TreeColumn6);
            this.c1TreeView1.DataMember = "Categories\\Products";
            this.c1TreeView1.DataSource = this.c1NWindDataSetBindingSource;
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.KeyField = "CategoryID\\CategoryID";
            this.c1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.ParentKeyField = null;
            this.c1TreeView1.Size = new System.Drawing.Size(828, 403);
            this.c1TreeView1.TabIndex = 5;
            // 
            // c1NWindDataSetBindingSource
            // 
            this.c1NWindDataSetBindingSource.DataSource = this.c1NWindDataSet;
            this.c1NWindDataSetBindingSource.Position = 0;
            // 
            // c1NWindDataSet
            // 
            this.c1NWindDataSet.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.c1NWindDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.c1NWindDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 460);
            this.Controls.Add(this.c1TreeView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private C1.Win.TreeView.C1TreeView c1TreeView1;
        private C1NWindDataSet c1NWindDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private C1NWindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private C1NWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource c1NWindDataSetBindingSource;
    }
}

