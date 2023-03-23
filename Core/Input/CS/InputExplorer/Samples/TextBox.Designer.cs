
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextBox));
            this.c1TextBox4 = new C1.Win.Input.C1TextBox();
            this.c1TextBox2 = new C1.Win.Input.C1TextBox();
            this.c1TextBox1 = new C1.Win.Input.C1TextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1Label3 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TextBox4
            // 
            this.c1TextBox4.AcceptsEscape = false;
            this.c1TextBox4.AcceptsReturn = true;
            this.c1TextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.c1TextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.c1TextBox4.DisableOnNoData = false;
            this.c1TextBox4.Location = new System.Drawing.Point(9, 504);
            this.c1TextBox4.Name = "c1TextBox4";
            this.c1TextBox4.Placeholder = "Auto Complete";
            this.c1TextBox4.Size = new System.Drawing.Size(172, 28);
            this.c1TextBox4.TabIndex = 3;
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.AcceptsEscape = false;
            this.c1TextBox2.AcceptsReturn = true;
            this.c1TextBox2.AutoSize = false;
            this.c1TextBox2.DisableOnNoData = false;
            this.c1TextBox2.Location = new System.Drawing.Point(9, 257);
            this.c1TextBox2.Multiline = true;
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.Placeholder = "Multiline";
            this.c1TextBox2.Size = new System.Drawing.Size(172, 130);
            this.c1TextBox2.TabIndex = 2;
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.AcceptsReturn = true;
            this.c1TextBox1.DisableOnNoData = false;
            this.c1TextBox1.Location = new System.Drawing.Point(9, 172);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Placeholder = "Validation";
            this.c1TextBox1.PostValidation.Values = ((System.Collections.IList)(resources.GetObject("c1TextBox1.PostValidation.Values")));
            this.c1TextBox1.PreValidation.PatternString = "^[a-zA-Z]+$";
            this.c1TextBox1.PreValidation.Validation = C1.Win.Input.PreValidationType.RegexPattern;
            this.c1TextBox1.Size = new System.Drawing.Size(172, 28);
            this.c1TextBox1.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(316, 0);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1TextBox1;
            this.propertyGrid1.Size = new System.Drawing.Size(389, 568);
            this.propertyGrid1.TabIndex = 4;
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.FormatInfo.Inherit = ((C1.Win.Input.FormatInfoInheritProperties)((((((C1.Win.Input.FormatInfoInheritProperties.FormatType | C1.Win.Input.FormatInfoInheritProperties.CustomFormat) 
            | C1.Win.Input.FormatInfoInheritProperties.NullText) 
            | C1.Win.Input.FormatInfoInheritProperties.EmptyAsNull) 
            | C1.Win.Input.FormatInfoInheritProperties.TrimStart) 
            | C1.Win.Input.FormatInfoInheritProperties.CalendarType)));
            this.c1Label1.Location = new System.Drawing.Point(9, 3);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(270, 160);
            this.c1Label1.TabIndex = 11;
            this.c1Label1.Text = resources.GetString("c1Label1.Text");
            // 
            // c1Label3
            // 
            this.c1Label3.AutoSize = true;
            this.c1Label3.Location = new System.Drawing.Point(9, 411);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(300, 80);
            this.c1Label3.TabIndex = 13;
            this.c1Label3.Text = "This case demonstrates autocomplete.\r\nStart typing one of \"orange\", \"apple\", \"pea" +
    "r\", \r\n\"pineapple\", \"coconut\", \"banana\", \"plum\" \r\nto see a list of recommended va" +
    "lues.";
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.Location = new System.Drawing.Point(9, 227);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(303, 20);
            this.c1Label2.TabIndex = 12;
            this.c1Label2.Text = "This case demonstrates a multiline C1TextBox.";
            // 
            // TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.c1Label3);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1TextBox4);
            this.Controls.Add(this.c1TextBox2);
            this.Controls.Add(this.c1TextBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TextBox";
            this.Size = new System.Drawing.Size(705, 568);
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Input.C1TextBox c1TextBox4;
        private C1.Win.Input.C1TextBox c1TextBox2;
        private C1.Win.Input.C1TextBox c1TextBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1Label c1Label3;
        private C1.Win.Input.C1Label c1Label2;
    }
}
