namespace TreeViewExplorer.Samples
{
    partial class DefaultEditors
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
            C1.Win.TreeView.C1TreeColumn c1TreeColumn3 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn4 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn5 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn6 = new C1.Win.TreeView.C1TreeColumn();
            this.c1TreeView1 = new C1.Win.TreeView.C1TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TreeView1
            // 
            this.c1TreeView1.AllowEditing = true;
            this.c1TreeView1.BindingInfo.DataMember = null;
            this.c1TreeView1.BindingInfo.KeyField = null;
            this.c1TreeView1.BindingInfo.ParentKeyField = null;
            // 
            // 
            // 
            this.c1TreeView1.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.ButtonImageList.ImageSize = new System.Drawing.Size(16, 16);
            // 
            // 
            // 
            this.c1TreeView1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.c1TreeView1.CheckImageList.ImageSize = new System.Drawing.Size(16, 16);
            c1TreeColumn1.DisplayFieldName = "Post";
            c1TreeColumn1.HeaderText = "Post";
            c1TreeColumn1.Name = "cPost";
            c1TreeColumn2.DisplayFieldName = null;
            c1TreeColumn2.HeaderText = "Name";
            c1TreeColumn2.IsTypedEditor = false;
            c1TreeColumn2.Name = "cName";
            c1TreeColumn3.DisplayFieldName = "CountryId";
            c1TreeColumn3.EditorType = C1.Win.TreeView.C1TreeViewEditorType.ComboBox;
            c1TreeColumn3.HeaderText = "Country";
            c1TreeColumn3.Name = "cCountry";
            c1TreeColumn4.DisplayFieldName = "YearBonus";
            c1TreeColumn4.EditorType = C1.Win.TreeView.C1TreeViewEditorType.NumericEdit;
            c1TreeColumn4.HeaderText = "Year Bonus";
            c1TreeColumn4.Name = "cBonus";
            c1TreeColumn5.DisplayFieldName = "HasSpecialNeeds";
            c1TreeColumn5.EditorType = C1.Win.TreeView.C1TreeViewEditorType.CheckBox;
            c1TreeColumn5.HeaderText = "Has Special Needs";
            c1TreeColumn5.Name = "cNeeds";
            c1TreeColumn6.DisplayFieldName = "HireDate";
            c1TreeColumn6.EditorType = C1.Win.TreeView.C1TreeViewEditorType.DatePicker;
            c1TreeColumn6.HeaderText = "Hire Date";
            c1TreeColumn6.Name = "cHireDate";
            this.c1TreeView1.Columns.Add(c1TreeColumn1);
            this.c1TreeView1.Columns.Add(c1TreeColumn2);
            this.c1TreeView1.Columns.Add(c1TreeColumn3);
            this.c1TreeView1.Columns.Add(c1TreeColumn4);
            this.c1TreeView1.Columns.Add(c1TreeColumn5);
            this.c1TreeView1.Columns.Add(c1TreeColumn6);
            this.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView1.Name = "c1TreeView1";
            this.c1TreeView1.Size = new System.Drawing.Size(763, 425);
            this.c1TreeView1.TabIndex = 0;
            // 
            // DefaultEditors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1TreeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DefaultEditors";
            this.Size = new System.Drawing.Size(763, 425);
            ((System.ComponentModel.ISupportInitialize)(this.c1TreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.TreeView.C1TreeView c1TreeView1;
    }
}

