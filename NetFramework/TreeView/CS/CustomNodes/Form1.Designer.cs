namespace CustomNodes
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn2 = new C1.Win.TreeView.C1TreeColumn();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            this.dataSet11 = new CustomNodes.DataSet1();
            this.productsTableAdapter1 = new CustomNodes.DataSet1TableAdapters.ProductsTableAdapter();
            this.categoriesTableAdapter1 = new CustomNodes.DataSet1TableAdapters.CategoriesTableAdapter();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TreeView1
            // 
            this.c1TreeView1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1TreeView1.BackColor = System.Drawing.Color.White;
            this.c1TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            c1TreeColumn1.DisplayFieldName = "ProductName";
            c1TreeColumn1.HeaderText = "Category";
            c1TreeColumn1.Name = "Column1";
            c1TreeColumn1.Width = 210;
            c1TreeColumn2.DisplayFieldName = null;
            c1TreeColumn2.HeaderText = "Products";
            c1TreeColumn2.Name = "Column2";
            c1TreeColumn2.Width = 200;
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.Columns.Add(c1TreeColumn2);
            this.c1TreeView1.BindingInfo.DataMember = null;
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.BindingInfo.KeyField = null;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.BindingInfo.ParentKeyField = null;
            this.c1TreeView1.Size = new System.Drawing.Size(715, 381);
            this.c1TreeView1.Styles.BorderStyle = C1.Win.TreeView.C1TreeViewBorderStyle.Full;
            this.c1TreeView1.Styles.ColumnHeader.BackColor = System.Drawing.Color.YellowGreen;
            this.c1TreeView1.Styles.ColumnHeader.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.c1TreeView1.Styles.ColumnHeader.ForeColor = System.Drawing.Color.Black;
            this.c1TreeView1.Styles.ColumnHeader.HorizontalAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1TreeView1.Styles.ExpandButtonStyle = C1.Win.TreeView.ExpandButtonStyle.Windows10;
            this.c1TreeView1.Styles.ShowLines = false;
            this.c1TreeView1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1TreeView1, "Office365White");
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office365White";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 381);
            this.Controls.Add(this.c1TreeView1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(169)))), ((int)(((byte)(23)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.c1ThemeController1.SetTheme(this, "Office365White");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.TreeView.C1TreeView c1TreeView1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private DataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
    }
}

