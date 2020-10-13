namespace InputExplorer.Samples
{
    partial class Themes
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
            C1.Win.Input.SplitButtonItem splitButtonItem17 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.SplitButtonItem splitButtonItem18 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.SplitButtonItem splitButtonItem19 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.SplitButtonItem splitButtonItem20 = new C1.Win.Input.SplitButtonItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themes));
            C1.Win.Input.ComboBoxItem comboBoxItem17 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem18 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem19 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem20 = new C1.Win.Input.ComboBoxItem();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbThemes = new C1.Win.Input.C1ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.c1Button1 = new C1.Win.Input.C1Button();
            this.c1TextBox1 = new C1.Win.Input.C1TextBox();
            this.c1CheckBox1 = new C1.Win.Input.C1CheckBox();
            this.c1RadioButton1 = new C1.Win.Input.C1RadioButton();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.c1SplitButton1 = new C1.Win.Input.C1SplitButton();
            this.c1PictureBox1 = new C1.Win.Input.C1PictureBox();
            this.c1RangeSlider1 = new C1.Win.Input.C1RangeSlider();
            this.c1ComboBox1 = new C1.Win.Input.C1ComboBox();
            this.c1NumericEdit1 = new C1.Win.Input.C1NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbThemes)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbThemes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 43);
            this.panel1.TabIndex = 10;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            // 
            // cmbThemes
            // 
            this.cmbThemes.AcceptsEscape = false;
            this.cmbThemes.AcceptsReturn = true;
            this.cmbThemes.DisableOnNoData = false;
            this.cmbThemes.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            this.cmbThemes.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.cmbThemes.Location = new System.Drawing.Point(109, 2);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Placeholder = "Chose a theme";
            this.cmbThemes.PreValidation.ErrorMessage = "";
            this.cmbThemes.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.cmbThemes.ReadOnly = true;
            this.cmbThemes.Size = new System.Drawing.Size(217, 23);
            this.cmbThemes.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.cmbThemes, "(default)");
            this.cmbThemes.SelectedItemChanged += new System.EventHandler(this.cmbThemes_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theme picker: ";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.c1Button1);
            this.flowLayoutPanel1.Controls.Add(this.c1TextBox1);
            this.flowLayoutPanel1.Controls.Add(this.c1CheckBox1);
            this.flowLayoutPanel1.Controls.Add(this.c1RadioButton1);
            this.flowLayoutPanel1.Controls.Add(this.c1Label1);
            this.flowLayoutPanel1.Controls.Add(this.c1SplitButton1);
            this.flowLayoutPanel1.Controls.Add(this.c1PictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.c1RangeSlider1);
            this.flowLayoutPanel1.Controls.Add(this.c1ComboBox1);
            this.flowLayoutPanel1.Controls.Add(this.c1NumericEdit1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(518, 198);
            this.flowLayoutPanel1.TabIndex = 11;
            this.c1ThemeController1.SetTheme(this.flowLayoutPanel1, "(default)");
            // 
            // c1Button1
            // 
            this.c1Button1.Location = new System.Drawing.Point(7, 7);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(121, 24);
            this.c1Button1.TabIndex = 0;
            this.c1Button1.Text = "c1Button1";
            this.c1ThemeController1.SetTheme(this.c1Button1, "(default)");
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.AcceptsEscape = false;
            this.c1TextBox1.AcceptsReturn = true;
            this.c1TextBox1.DisableOnNoData = false;
            this.c1TextBox1.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1TextBox1.Location = new System.Drawing.Point(134, 7);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Placeholder = null;
            this.c1TextBox1.PreValidation.ErrorMessage = "";
            this.c1TextBox1.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1TextBox1.Size = new System.Drawing.Size(121, 24);
            this.c1TextBox1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.c1TextBox1, "(default)");
            // 
            // c1CheckBox1
            // 
            this.c1CheckBox1.Location = new System.Drawing.Point(261, 7);
            this.c1CheckBox1.Name = "c1CheckBox1";
            this.c1CheckBox1.Size = new System.Drawing.Size(121, 24);
            this.c1CheckBox1.TabIndex = 1;
            this.c1CheckBox1.Text = "c1CheckBox1";
            this.c1ThemeController1.SetTheme(this.c1CheckBox1, "(default)");
            // 
            // c1RadioButton1
            // 
            this.c1RadioButton1.Location = new System.Drawing.Point(388, 7);
            this.c1RadioButton1.Name = "c1RadioButton1";
            this.c1RadioButton1.Size = new System.Drawing.Size(121, 24);
            this.c1RadioButton1.TabIndex = 4;
            this.c1RadioButton1.Text = "c1RadioButton1";
            this.c1ThemeController1.SetTheme(this.c1RadioButton1, "(default)");
            // 
            // c1Label1
            // 
            this.c1Label1.Location = new System.Drawing.Point(7, 37);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(121, 24);
            this.c1Label1.TabIndex = 5;
            this.c1Label1.Text = "c1Label1";
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            // 
            // c1SplitButton1
            // 
            splitButtonItem17.Text = "Item 1";
            splitButtonItem18.Text = "Item 2";
            splitButtonItem19.Text = "Item 3";
            splitButtonItem20.Text = "Item 4";
            this.c1SplitButton1.Items.Add(splitButtonItem17);
            this.c1SplitButton1.Items.Add(splitButtonItem18);
            this.c1SplitButton1.Items.Add(splitButtonItem19);
            this.c1SplitButton1.Items.Add(splitButtonItem20);
            this.c1SplitButton1.Location = new System.Drawing.Point(134, 37);
            this.c1SplitButton1.Name = "c1SplitButton1";
            this.c1SplitButton1.Size = new System.Drawing.Size(121, 24);
            this.c1SplitButton1.TabIndex = 3;
            this.c1SplitButton1.Text = "c1SplitButton1";
            this.c1ThemeController1.SetTheme(this.c1SplitButton1, "(default)");
            // 
            // c1PictureBox1
            // 
            this.c1PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("c1PictureBox1.Image")));
            this.c1PictureBox1.Location = new System.Drawing.Point(261, 37);
            this.c1PictureBox1.Name = "c1PictureBox1";
            this.c1PictureBox1.Size = new System.Drawing.Size(121, 24);
            this.c1PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c1PictureBox1.TabIndex = 6;
            this.c1PictureBox1.TabStop = false;
            // 
            // c1RangeSlider1
            // 
            this.c1RangeSlider1.LargeChange = 5D;
            this.c1RangeSlider1.Location = new System.Drawing.Point(388, 37);
            this.c1RangeSlider1.LowerValue = 0D;
            this.c1RangeSlider1.Maximum = 100D;
            this.c1RangeSlider1.Minimum = 0D;
            this.c1RangeSlider1.Name = "c1RangeSlider1";
            this.c1RangeSlider1.Size = new System.Drawing.Size(121, 24);
            this.c1RangeSlider1.TabIndex = 7;
            this.c1RangeSlider1.Text = "c1RangeSlider1";
            this.c1ThemeController1.SetTheme(this.c1RangeSlider1, "(default)");
            this.c1RangeSlider1.UpperValue = 100D;
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AcceptsEscape = false;
            this.c1ComboBox1.AcceptsReturn = true;
            this.c1ComboBox1.DisableOnNoData = false;
            this.c1ComboBox1.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1ComboBox1.ItemHeight = 25;
            comboBoxItem17.DisplayText = "Item 1";
            comboBoxItem17.Value = "Item 1";
            comboBoxItem18.DisplayText = "Item 2";
            comboBoxItem18.Value = "Item 2";
            comboBoxItem19.DisplayText = "Item 3";
            comboBoxItem19.Value = "Item 3";
            comboBoxItem20.DisplayText = "Item 4";
            comboBoxItem20.Value = "Item 4";
            this.c1ComboBox1.Items.Add(comboBoxItem17);
            this.c1ComboBox1.Items.Add(comboBoxItem18);
            this.c1ComboBox1.Items.Add(comboBoxItem19);
            this.c1ComboBox1.Items.Add(comboBoxItem20);
            this.c1ComboBox1.Location = new System.Drawing.Point(7, 67);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Placeholder = null;
            this.c1ComboBox1.PreValidation.ErrorMessage = "";
            this.c1ComboBox1.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1ComboBox1.Size = new System.Drawing.Size(121, 29);
            this.c1ComboBox1.TabIndex = 8;
            this.c1ThemeController1.SetTheme(this.c1ComboBox1, "(default)");
            // 
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.AcceptsEscape = false;
            this.c1NumericEdit1.AcceptsReturn = true;
            this.c1NumericEdit1.DisableOnNoData = false;
            this.c1NumericEdit1.InitialSelection = C1.Win.Input.InitialSelection.SelectAll;
            this.c1NumericEdit1.Location = new System.Drawing.Point(134, 67);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Placeholder = null;
            this.c1NumericEdit1.PreValidation.ErrorMessage = "";
            this.c1NumericEdit1.PreValidation.Inherit = ((C1.Win.Input.PreValidationInheritProperties)((((C1.Win.Input.PreValidationInheritProperties.CaseSensitive | C1.Win.Input.PreValidationInheritProperties.ErrorMessage) 
            | C1.Win.Input.PreValidationInheritProperties.TrimStart) 
            | C1.Win.Input.PreValidationInheritProperties.TrimEnd)));
            this.c1NumericEdit1.Size = new System.Drawing.Size(121, 29);
            this.c1NumericEdit1.TabIndex = 9;
            this.c1ThemeController1.SetTheme(this.c1NumericEdit1, "(default)");
            this.c1NumericEdit1.Value = ((object)(resources.GetObject("c1NumericEdit1.Value")));
            // 
            // Themes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Themes";
            this.Size = new System.Drawing.Size(518, 241);
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Themes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbThemes)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Input.C1ComboBox cmbThemes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private C1.Win.Input.C1Button c1Button1;
        private C1.Win.Input.C1TextBox c1TextBox1;
        private C1.Win.Input.C1CheckBox c1CheckBox1;
        private C1.Win.Input.C1RadioButton c1RadioButton1;
        private C1.Win.Input.C1Label c1Label1;
        private C1.Win.Input.C1SplitButton c1SplitButton1;
        private C1.Win.Input.C1PictureBox c1PictureBox1;
        private C1.Win.Input.C1RangeSlider c1RangeSlider1;
        private C1.Win.Input.C1ComboBox c1ComboBox1;
        private C1.Win.Input.C1NumericEdit c1NumericEdit1;
    }
}
