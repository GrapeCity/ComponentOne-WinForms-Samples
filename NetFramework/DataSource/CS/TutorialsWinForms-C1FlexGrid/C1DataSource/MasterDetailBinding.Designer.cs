namespace TutorialsWinForms
{
    partial class MasterDetailBinding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDetailBinding));
            C1.Win.Data.ControlHandler controlHandler1 = new C1.Win.Data.ControlHandler();
            C1.Win.Data.ControlHandler controlHandler2 = new C1.Win.Data.ControlHandler();
            C1.Win.Data.Entities.EntityViewSourceProperties entityViewSourceProperties1 = new C1.Win.Data.Entities.EntityViewSourceProperties();
            C1.Win.Data.SortDescriptorProperties sortDescriptorProperties1 = new C1.Win.Data.SortDescriptorProperties();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1FlexGrid2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1DataSource1 = new C1.Win.Data.Entities.C1DataSource();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.AllowAddNew = true;
            this.c1FlexGrid1.AllowDelete = true;
            this.c1FlexGrid1.AllowFiltering = true;
            this.c1FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGrid1.AutoResize = true;
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            controlHandler1.AutoLookup = false;
            controlHandler1.VirtualMode = false;
            this.c1DataSource1.SetControlHandler(this.c1FlexGrid1, controlHandler1);
            this.c1FlexGrid1.DataMember = "Categories";
            this.c1FlexGrid1.DataSource = this.c1DataSource1;
            this.c1FlexGrid1.Location = new System.Drawing.Point(12, 12);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.Size = new System.Drawing.Size(705, 132);
            this.c1FlexGrid1.TabIndex = 4;
            // 
            // c1FlexGrid2
            // 
            this.c1FlexGrid2.AllowAddNew = true;
            this.c1FlexGrid2.AllowDelete = true;
            this.c1FlexGrid2.AllowFiltering = true;
            this.c1FlexGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGrid2.ColumnInfo = resources.GetString("c1FlexGrid2.ColumnInfo");
            controlHandler2.AutoLookup = true;
            controlHandler2.VirtualMode = false;
            this.c1DataSource1.SetControlHandler(this.c1FlexGrid2, controlHandler2);
            this.c1FlexGrid2.DataMember = "Categories.Products";
            this.c1FlexGrid2.DataSource = this.c1DataSource1;
            this.c1FlexGrid2.Location = new System.Drawing.Point(12, 160);
            this.c1FlexGrid2.Name = "c1FlexGrid2";
            this.c1FlexGrid2.Rows.Count = 1;
            this.c1FlexGrid2.Rows.DefaultSize = 19;
            this.c1FlexGrid2.Size = new System.Drawing.Size(705, 268);
            this.c1FlexGrid2.TabIndex = 5;
            // 
            // c1DataSource1
            // 
            this.c1DataSource1.ContextType = typeof(TutorialsWinForms.NORTHWNDEntities);
            entityViewSourceProperties1.EntitySetName = "Categories";
            entityViewSourceProperties1.Include = "";
            sortDescriptorProperties1.PropertyPath = "CategoryID";
            entityViewSourceProperties1.SortDescriptors.Add(sortDescriptorProperties1);
            this.c1DataSource1.ViewSourceCollection.Add(entityViewSourceProperties1);
            // 
            // MasterDetailBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 440);
            this.Controls.Add(this.c1FlexGrid2);
            this.Controls.Add(this.c1FlexGrid1);
            this.Name = "MasterDetailBinding";
            this.Text = "Master detail binding";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Data.Entities.C1DataSource c1DataSource1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid2;
    }
}

