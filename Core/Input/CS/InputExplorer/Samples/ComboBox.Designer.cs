namespace InputExplorer.Samples
{
    partial class ComboBox
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
            C1.Win.Input.ComboBoxItem comboBoxItem4 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem5 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem6 = new C1.Win.Input.ComboBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBox));
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.c1ComboBox1 = new C1.Win.Input.C1ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.c1ComboBox2 = new C1.Win.Input.C1ComboBox();
            this.c1ComboBox3 = new C1.Win.Input.C1ComboBox();
            this.c1ComboBox4 = new C1.Win.Input.C1ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(201, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1ComboBox1;
            this.propertyGrid1.Size = new System.Drawing.Size(366, 436);
            this.propertyGrid1.TabIndex = 1;
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AcceptsEscape = false;
            this.c1ComboBox1.DisableOnNoData = false;
            this.c1ComboBox1.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            comboBoxItem4.DisplayText = "circle";
            comboBoxItem4.ImageKey = "circle";
            comboBoxItem4.Value = "circle";
            comboBoxItem5.DisplayText = "square";
            comboBoxItem5.ImageKey = "square";
            comboBoxItem5.Value = "square";
            comboBoxItem6.DisplayText = "triangle";
            comboBoxItem6.ImageKey = "triangle";
            comboBoxItem6.Value = "triangle";
            this.c1ComboBox1.Items.Add(comboBoxItem4);
            this.c1ComboBox1.Items.Add(comboBoxItem5);
            this.c1ComboBox1.Items.Add(comboBoxItem6);
            this.c1ComboBox1.ItemsImageList = this.imageList1;
            this.c1ComboBox1.Location = new System.Drawing.Point(14, 32);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Placeholder = "Items With Image";
            this.c1ComboBox1.PreValidation.ErrorMessage = "";
            this.c1ComboBox1.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1ComboBox1.Size = new System.Drawing.Size(138, 28);
            this.c1ComboBox1.TabIndex = 2;
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
            // c1ComboBox2
            // 
            this.c1ComboBox2.AcceptsEscape = false;
            this.c1ComboBox2.DisableOnNoData = false;
            this.c1ComboBox2.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            this.c1ComboBox2.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1ComboBox2.Location = new System.Drawing.Point(14, 108);
            this.c1ComboBox2.Name = "c1ComboBox2";
            this.c1ComboBox2.Placeholder = "Items Data Source";
            this.c1ComboBox2.PreValidation.ErrorMessage = "";
            this.c1ComboBox2.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1ComboBox2.Size = new System.Drawing.Size(138, 28);
            this.c1ComboBox2.TabIndex = 3;
            // 
            // c1ComboBox3
            // 
            this.c1ComboBox3.AcceptsEscape = false;
            this.c1ComboBox3.DisableOnNoData = false;
            this.c1ComboBox3.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1ComboBox3.Location = new System.Drawing.Point(14, 184);
            this.c1ComboBox3.MaxDropDownItems = 10;
            this.c1ComboBox3.Name = "c1ComboBox3";
            this.c1ComboBox3.Placeholder = "Max Items";
            this.c1ComboBox3.PreValidation.ErrorMessage = "";
            this.c1ComboBox3.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1ComboBox3.Size = new System.Drawing.Size(138, 28);
            this.c1ComboBox3.TabIndex = 4;
            // 
            // c1ComboBox4
            // 
            this.c1ComboBox4.AcceptsEscape = false;
            this.c1ComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.c1ComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.c1ComboBox4.DisableOnNoData = false;
            this.c1ComboBox4.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1ComboBox4.Location = new System.Drawing.Point(14, 259);
            this.c1ComboBox4.Name = "c1ComboBox4";
            this.c1ComboBox4.Placeholder = "Auto Complete";
            this.c1ComboBox4.PreValidation.ErrorMessage = "";
            this.c1ComboBox4.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1ComboBox4.Size = new System.Drawing.Size(138, 28);
            this.c1ComboBox4.TabIndex = 5;
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1ComboBox4);
            this.Controls.Add(this.c1ComboBox3);
            this.Controls.Add(this.c1ComboBox2);
            this.Controls.Add(this.c1ComboBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "ComboBox";
            this.Size = new System.Drawing.Size(567, 436);
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private C1.Win.Input.C1ComboBox c1ComboBox1;
        private C1.Win.Input.C1ComboBox c1ComboBox2;
        private C1.Win.Input.C1ComboBox c1ComboBox3;
        private C1.Win.Input.C1ComboBox c1ComboBox4;
        private System.Windows.Forms.ImageList imageList1;
    }
}
