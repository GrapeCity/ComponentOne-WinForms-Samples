namespace TutorialsWinForms
{
    partial class Paging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paging));
            C1.Win.Data.ControlHandler controlHandler1 = new C1.Win.Data.ControlHandler();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.labelPage = new System.Windows.Forms.Label();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.c1DataSource1 = new C1.Win.Data.Entities.C1DataSource();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(131, 281);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(28, 23);
            this.btnNextPage.TabIndex = 15;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // labelPage
            // 
            this.labelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(56, 286);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(55, 13);
            this.labelPage.TabIndex = 14;
            this.labelPage.Text = "Page: 0/0";
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPage.Location = new System.Drawing.Point(24, 281);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(28, 23);
            this.btnPrevPage.TabIndex = 13;
            this.btnPrevPage.Text = "<";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // c1DataSource1
            // 
            this.c1DataSource1.ContextType = typeof(TutorialsWinForms.NORTHWNDEntities);
            entityViewSourceProperties1.EntitySetName = "Orders";
            entityViewSourceProperties1.PageSize = 10;
            this.c1DataSource1.ViewSourceCollection.Add(entityViewSourceProperties1);
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
            controlHandler1.AutoLookup = true;
            this.c1DataSource1.SetControlHandler(this.c1FlexGrid1, controlHandler1);
            this.c1FlexGrid1.DataMember = "Orders";
            this.c1FlexGrid1.DataSource = this.c1DataSource1;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 14);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.Size = new System.Drawing.Size(899, 248);
            this.c1FlexGrid1.TabIndex = 16;
            // 
            // Paging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(911, 324);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.btnPrevPage);
            this.Name = "Paging";
            this.Text = "Paging";
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Data.Entities.C1DataSource c1DataSource1;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button btnPrevPage;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}

