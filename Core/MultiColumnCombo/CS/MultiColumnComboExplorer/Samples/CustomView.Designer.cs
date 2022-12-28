namespace MultiColumnComboExplorer.Samples
{
    partial class CustomView
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
            this.multiComboGridView = new C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo();
            this.multiComboTree = new C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo();
            ((System.ComponentModel.ISupportInitialize)(this.multiComboGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiComboTree)).BeginInit();
            this.SuspendLayout();
            // 
            // multiComboGridView
            // 
            this.multiComboGridView.DropDownWidth = -1;
            this.multiComboGridView.Location = new System.Drawing.Point(36, 36);
            this.multiComboGridView.Name = "multiComboGridView";
            this.multiComboGridView.Placeholder = "Dropdown: DataGridView";
            this.multiComboGridView.Size = new System.Drawing.Size(178, 23);
            this.multiComboGridView.TabIndex = 0;
            // 
            // multiComboTree
            // 
            this.multiComboTree.DropDownWidth = -1;
            this.multiComboTree.Location = new System.Drawing.Point(242, 36);
            this.multiComboTree.Name = "multiComboTree";
            this.multiComboTree.Placeholder = "Dropdown: C1TreeView";
            this.multiComboTree.Size = new System.Drawing.Size(178, 23);
            this.multiComboTree.TabIndex = 1;
            // 
            // CustomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.multiComboTree);
            this.Controls.Add(this.multiComboGridView);
            this.Name = "CustomView";
            this.Size = new System.Drawing.Size(493, 316);
            this.Load += new System.EventHandler(this.CustomView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.multiComboGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiComboTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo multiComboGridView;
        private C1.Win.Input.MultiColumnCombo.C1MultiColumnCombo multiComboTree;
    }
}
