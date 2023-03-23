namespace TutorialsWinFormsC1FlexGrid
{
    partial class ServerSideFiltering
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
            C1.Win.Data.Entities.EntityViewSourceProperties entityViewSourceProperties1 = new C1.Win.Data.Entities.EntityViewSourceProperties();
            C1.Win.Data.Entities.EntityViewSourceProperties entityViewSourceProperties2 = new C1.Win.Data.Entities.EntityViewSourceProperties();
            C1.Win.Data.FilterDescriptorProperties filterDescriptorProperties1 = new C1.Win.Data.FilterDescriptorProperties();
            C1.Win.Data.SortDescriptorProperties sortDescriptorProperties1 = new C1.Win.Data.SortDescriptorProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSideFiltering));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.c1DataSource1 = new C1.Win.Data.Entities.C1DataSource();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.c1DataSource1;
            this.comboBox1.DisplayMember = "Categories.CategoryName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Categories.CategoryID";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // c1DataSource1
            // 
            this.c1DataSource1.ContextType = typeof(TutorialsWinFormsC1FlexGrid.NORTHWNDEntities);
            entityViewSourceProperties1.EntitySetName = "Categories";
            entityViewSourceProperties2.EntitySetName = "Products";
            filterDescriptorProperties1.PropertyPath = "CategoryID";
            filterDescriptorProperties1.Value = "1";
            entityViewSourceProperties2.FilterDescriptors.Add(filterDescriptorProperties1);
            sortDescriptorProperties1.PropertyPath = "ProductName";
            entityViewSourceProperties2.SortDescriptors.Add(sortDescriptorProperties1);
            this.c1DataSource1.ViewSourceCollection.Add(entityViewSourceProperties1);
            this.c1DataSource1.ViewSourceCollection.Add(entityViewSourceProperties2);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(702, 370);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(104, 23);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // ServerSideFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 433);
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowAddNew = true;
            this.c1FlexGrid1.AllowDelete = true;
            this.c1FlexGrid1.AllowFiltering = true;
            this.c1FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataMember = "Products";
            this.c1FlexGrid1.DataSource = this.c1DataSource1;
            this.c1FlexGrid1.Location = new System.Drawing.Point(32, 68);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.Size = new System.Drawing.Size(777, 278);
            this.c1FlexGrid1.TabIndex = 17;
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.comboBox1);
            this.Name = "ServerSideFiltering";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Data.Entities.C1DataSource c1DataSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSaveChanges;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}

