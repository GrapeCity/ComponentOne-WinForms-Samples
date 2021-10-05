
namespace InputExplorer.Samples
{
    partial class NumericEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumericEdit));
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.c1NumericEdit1 = new C1.Win.Input.C1NumericEdit();
            this.c1NumericEdit2 = new C1.Win.Input.C1NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(201, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1NumericEdit1;
            this.propertyGrid1.Size = new System.Drawing.Size(366, 436);
            this.propertyGrid1.TabIndex = 5;
            // 
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.AcceptsEscape = false;
            this.c1NumericEdit1.AcceptsReturn = true;
            this.c1NumericEdit1.DisableOnNoData = false;
            this.c1NumericEdit1.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1NumericEdit1.Location = new System.Drawing.Point(14, 32);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.PasswordChar = '*';
            this.c1NumericEdit1.Placeholder = "Password";
            this.c1NumericEdit1.PreValidation.ErrorMessage = "";
            this.c1NumericEdit1.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1NumericEdit1.Size = new System.Drawing.Size(138, 28);
            this.c1NumericEdit1.TabIndex = 6;
            this.c1NumericEdit1.Value = ((object)(resources.GetObject("c1NumericEdit1.Value")));
            // 
            // c1NumericEdit2
            // 
            this.c1NumericEdit2.AcceptsEscape = false;
            this.c1NumericEdit2.AcceptsReturn = true;
            this.c1NumericEdit2.DisableOnNoData = false;
            this.c1NumericEdit2.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1NumericEdit2.Location = new System.Drawing.Point(14, 108);
            this.c1NumericEdit2.MarkEmpty = true;
            this.c1NumericEdit2.Name = "c1NumericEdit2";
            this.c1NumericEdit2.Placeholder = "Mark Empty";
            this.c1NumericEdit2.PreValidation.ErrorMessage = "";
            this.c1NumericEdit2.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1NumericEdit2.Size = new System.Drawing.Size(138, 28);
            this.c1NumericEdit2.TabIndex = 7;
            this.c1NumericEdit2.Value = ((object)(resources.GetObject("c1NumericEdit2.Value")));
            // 
            // NumericEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1NumericEdit2);
            this.Controls.Add(this.c1NumericEdit1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "NumericEdit";
            this.Size = new System.Drawing.Size(567, 436);
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private C1.Win.Input.C1NumericEdit c1NumericEdit1;
        private C1.Win.Input.C1NumericEdit c1NumericEdit2;
    }
}
