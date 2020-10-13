
namespace InputExplorer.Samples
{
    partial class TextBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextBox));
            this.c1TextBox4 = new C1.Win.Input.C1TextBox();
            this.c1TextBox2 = new C1.Win.Input.C1TextBox();
            this.c1TextBox1 = new C1.Win.Input.C1TextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TextBox4
            // 
            this.c1TextBox4.AcceptsEscape = false;
            this.c1TextBox4.AcceptsReturn = true;
            this.c1TextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.c1TextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.c1TextBox4.DisableOnNoData = false;
            this.c1TextBox4.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1TextBox4.Location = new System.Drawing.Point(7, 259);
            this.c1TextBox4.Multiline = true;
            this.c1TextBox4.Name = "c1TextBox4";
            this.c1TextBox4.Placeholder = "Auto Complete";
            this.c1TextBox4.PreValidation.ErrorMessage = "";
            this.c1TextBox4.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1TextBox4.Size = new System.Drawing.Size(138, 28);
            this.c1TextBox4.TabIndex = 10;
            this.c1TextBox4.Text = "apple, orange";
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.AcceptsEscape = false;
            this.c1TextBox2.AcceptsReturn = true;
            this.c1TextBox2.DisableOnNoData = false;
            this.c1TextBox2.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1TextBox2.Location = new System.Drawing.Point(7, 108);
            this.c1TextBox2.Multiline = true;
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.Placeholder = "Multiline";
            this.c1TextBox2.PreValidation.ErrorMessage = "";
            this.c1TextBox2.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1TextBox2.Size = new System.Drawing.Size(138, 104);
            this.c1TextBox2.TabIndex = 8;
            this.c1TextBox2.Text = "1 line\r\n2 line\r\n3 line\r\n4 line\r\n5 line\r\n6 line";
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.AcceptsEscape = false;
            this.c1TextBox1.AcceptsReturn = true;
            this.c1TextBox1.DisableOnNoData = false;
            this.c1TextBox1.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1TextBox1.Location = new System.Drawing.Point(7, 32);
            this.c1TextBox1.Multiline = true;
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Placeholder = "Validation";
            this.c1TextBox1.PostValidation.Inherit = C1.Win.Input.PostValidationInheritProperties.All;
            this.c1TextBox1.PostValidation.Validation = C1.Win.Input.PostValidationType.ValuesAndIntervals;
            this.c1TextBox1.PostValidation.Values = ((System.Collections.IList)(resources.GetObject("c1TextBox1.PostValidation.Values")));
            this.c1TextBox1.PreValidation.ErrorMessage = "";
            this.c1TextBox1.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1TextBox1.PreValidation.PatternString = "^[a-zA-Z]+$";
            this.c1TextBox1.PreValidation.Validation = C1.Win.Input.PreValidationType.RegexPattern;
            this.c1TextBox1.Size = new System.Drawing.Size(138, 28);
            this.c1TextBox1.TabIndex = 7;
            this.c1TextBox1.Text = "circle";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(198, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1TextBox1;
            this.propertyGrid1.Size = new System.Drawing.Size(366, 454);
            this.propertyGrid1.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "circle");
            this.imageList1.Images.SetKeyName(1, "square");
            this.imageList1.Images.SetKeyName(2, "triangle");
            // 
            // TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1TextBox4);
            this.Controls.Add(this.c1TextBox2);
            this.Controls.Add(this.c1TextBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "TextBox";
            this.Size = new System.Drawing.Size(564, 454);
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Input.C1TextBox c1TextBox4;
        private C1.Win.Input.C1TextBox c1TextBox2;
        private C1.Win.Input.C1TextBox c1TextBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
