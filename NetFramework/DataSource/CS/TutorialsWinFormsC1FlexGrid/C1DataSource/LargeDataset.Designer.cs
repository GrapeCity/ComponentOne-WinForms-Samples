namespace TutorialsWinFormsC1FlexGrid
{
    partial class LargeDataset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LargeDataset));
            C1.Win.Data.ControlHandler controlHandler1 = new C1.Win.Data.ControlHandler();
            this.c1DataSource1 = new C1.Win.Data.Entities.C1DataSource();
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1DataSource1
            // 
            this.c1DataSource1.ContextType = typeof(TutorialsWinFormsC1FlexGrid.NORTHWNDEntities);
            entityViewSourceProperties1.EntitySetName = "Order_Details";
            entityViewSourceProperties1.VirtualMode = C1.Data.DataSource.VirtualModeKind.Managed;
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
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            controlHandler1.VirtualMode = true;
            this.c1DataSource1.SetControlHandler(this.c1FlexGrid1, controlHandler1);
            this.c1FlexGrid1.DataMember = "Order_Details";
            this.c1FlexGrid1.DataSource = this.c1DataSource1;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.Size = new System.Drawing.Size(532, 627);
            this.c1FlexGrid1.TabIndex = 1;
            // 
            // LargeDataset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 630);
            this.Controls.Add(this.c1FlexGrid1);
            this.Name = "LargeDataset";
            this.Text = "Large dataset";
            ((System.ComponentModel.ISupportInitialize)(this.c1DataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Data.Entities.C1DataSource c1DataSource1;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}

