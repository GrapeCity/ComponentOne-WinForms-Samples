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
            C1.Win.Input.SplitButtonItem splitButtonItem1 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.SplitButtonItem splitButtonItem2 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.SplitButtonItem splitButtonItem3 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.SplitButtonItem splitButtonItem4 = new C1.Win.Input.SplitButtonItem();
            C1.Win.Input.ComboBoxItem comboBoxItem1 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem2 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem3 = new C1.Win.Input.ComboBoxItem();
            C1.Win.Input.ComboBoxItem comboBoxItem4 = new C1.Win.Input.ComboBoxItem();
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
            this.c1DropDownControl1 = new C1.Win.Input.C1DropDownControl();
            this.c1MaskedTextBox1 = new C1.Win.Input.C1MaskedTextBox();
            this.c1ColorPicker1 = new C1.Win.Input.Pickers.C1ColorPicker();
            this.c1DateEdit1 = new C1.Win.Calendar.C1DateEdit();
            this.c1FontPicker1 = new C1.Win.Input.Pickers.C1FontPicker();
            this.c1CalendarView1 = new C1.Win.Calendar.C1CalendarView();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbThemes)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1RadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1RangeSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ColorPicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FontPicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CalendarView1)).BeginInit();
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
            this.cmbThemes.DisableOnNoData = false;
            this.cmbThemes.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            this.cmbThemes.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            this.cmbThemes.Location = new System.Drawing.Point(97, 6);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Placeholder = "Chose a theme";
            this.cmbThemes.Size = new System.Drawing.Size(126, 23);
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
            this.flowLayoutPanel1.Controls.Add(this.c1DropDownControl1);
            this.flowLayoutPanel1.Controls.Add(this.c1MaskedTextBox1);
            this.flowLayoutPanel1.Controls.Add(this.c1ColorPicker1);
            this.flowLayoutPanel1.Controls.Add(this.c1DateEdit1);
            this.flowLayoutPanel1.Controls.Add(this.c1FontPicker1);
            this.flowLayoutPanel1.Controls.Add(this.c1CalendarView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(518, 318);
            this.flowLayoutPanel1.TabIndex = 11;
            this.c1ThemeController1.SetTheme(this.flowLayoutPanel1, "(default)");
            // 
            // c1Button1
            // 
            this.c1Button1.AutoSize = true;
            this.c1Button1.Location = new System.Drawing.Point(7, 7);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(62, 23);
            this.c1Button1.TabIndex = 0;
            this.c1Button1.Text = "c1Button1";
            this.c1ThemeController1.SetTheme(this.c1Button1, "(default)");
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.AcceptsEscape = false;
            this.c1TextBox1.AcceptsReturn = true;
            this.c1TextBox1.DisableOnNoData = false;
            this.c1TextBox1.Location = new System.Drawing.Point(75, 7);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Placeholder = null;
            this.c1TextBox1.Size = new System.Drawing.Size(56, 23);
            this.c1TextBox1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.c1TextBox1, "(default)");
            // 
            // c1CheckBox1
            // 
            this.c1CheckBox1.AutoSize = true;
            this.c1CheckBox1.Location = new System.Drawing.Point(137, 7);
            this.c1CheckBox1.Name = "c1CheckBox1";
            this.c1CheckBox1.Size = new System.Drawing.Size(92, 19);
            this.c1CheckBox1.TabIndex = 1;
            this.c1CheckBox1.Text = "c1CheckBox1";
            this.c1ThemeController1.SetTheme(this.c1CheckBox1, "(default)");
            // 
            // c1RadioButton1
            // 
            this.c1RadioButton1.AutoSize = true;
            this.c1RadioButton1.Location = new System.Drawing.Point(235, 7);
            this.c1RadioButton1.Name = "c1RadioButton1";
            this.c1RadioButton1.Size = new System.Drawing.Size(105, 19);
            this.c1RadioButton1.TabIndex = 4;
            this.c1RadioButton1.Text = "c1RadioButton1";
            this.c1ThemeController1.SetTheme(this.c1RadioButton1, "(default)");
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.Location = new System.Drawing.Point(346, 7);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(52, 21);
            this.c1Label1.TabIndex = 5;
            this.c1Label1.Text = "c1Label1";
            this.c1ThemeController1.SetTheme(this.c1Label1, "(default)");
            // 
            // c1SplitButton1
            // 
            this.c1SplitButton1.AutoSize = true;
            splitButtonItem1.Text = "Item 1";
            splitButtonItem2.Text = "Item 2";
            splitButtonItem3.Text = "Item 3";
            splitButtonItem4.Text = "Item 4";
            this.c1SplitButton1.Items.Add(splitButtonItem1);
            this.c1SplitButton1.Items.Add(splitButtonItem2);
            this.c1SplitButton1.Items.Add(splitButtonItem3);
            this.c1SplitButton1.Items.Add(splitButtonItem4);
            this.c1SplitButton1.Location = new System.Drawing.Point(404, 7);
            this.c1SplitButton1.Name = "c1SplitButton1";
            this.c1SplitButton1.Size = new System.Drawing.Size(85, 23);
            this.c1SplitButton1.TabIndex = 3;
            this.c1SplitButton1.Text = "c1SplitButton1";
            this.c1ThemeController1.SetTheme(this.c1SplitButton1, "(default)");
            // 
            // c1PictureBox1
            // 
            this.c1PictureBox1.Image = global::InputExplorer.Properties.Resources.mescius_logo;
            this.c1PictureBox1.Location = new System.Drawing.Point(7, 36);
            this.c1PictureBox1.Name = "c1PictureBox1";
            this.c1PictureBox1.Size = new System.Drawing.Size(121, 24);
            this.c1PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c1PictureBox1.TabIndex = 6;
            this.c1PictureBox1.TabStop = false;
            // 
            // c1RangeSlider1
            // 
            this.c1RangeSlider1.LargeChange = 5D;
            this.c1RangeSlider1.Location = new System.Drawing.Point(134, 36);
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
            this.c1ComboBox1.DisableOnNoData = false;
            this.c1ComboBox1.ItemHeight = 25;
            comboBoxItem1.DisplayText = "Item 1";
            comboBoxItem1.Value = "Item 1";
            comboBoxItem2.DisplayText = "Item 2";
            comboBoxItem2.Value = "Item 2";
            comboBoxItem3.DisplayText = "Item 3";
            comboBoxItem3.Value = "Item 3";
            comboBoxItem4.DisplayText = "Item 4";
            comboBoxItem4.Value = "Item 4";
            this.c1ComboBox1.Items.Add(comboBoxItem1);
            this.c1ComboBox1.Items.Add(comboBoxItem2);
            this.c1ComboBox1.Items.Add(comboBoxItem3);
            this.c1ComboBox1.Items.Add(comboBoxItem4);
            this.c1ComboBox1.Location = new System.Drawing.Point(261, 36);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Placeholder = null;
            this.c1ComboBox1.Size = new System.Drawing.Size(72, 23);
            this.c1ComboBox1.TabIndex = 8;
            this.c1ThemeController1.SetTheme(this.c1ComboBox1, "(default)");
            // 
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.AcceptsEscape = false;
            this.c1NumericEdit1.AcceptsReturn = true;
            this.c1NumericEdit1.DisableOnNoData = false;
            this.c1NumericEdit1.Location = new System.Drawing.Point(339, 36);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Placeholder = null;
            this.c1NumericEdit1.Size = new System.Drawing.Size(72, 23);
            this.c1NumericEdit1.TabIndex = 9;
            this.c1ThemeController1.SetTheme(this.c1NumericEdit1, "(default)");
            this.c1NumericEdit1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // c1DropDownControl1
            // 
            this.c1DropDownControl1.Location = new System.Drawing.Point(417, 36);
            this.c1DropDownControl1.Name = "c1DropDownControl1";
            this.c1DropDownControl1.Size = new System.Drawing.Size(72, 23);
            this.c1DropDownControl1.TabIndex = 10;
            this.c1ThemeController1.SetTheme(this.c1DropDownControl1, "(default)");
            // 
            // c1MaskedTextBox1
            // 
            this.c1MaskedTextBox1.CustomFormat = "+0-(000)-000-0000";
            this.c1MaskedTextBox1.DisplayFormat.FormatType = C1.Win.Input.FormatType.CustomFormat;
            this.c1MaskedTextBox1.DisplayFormat.Inherit = ((C1.Win.Input.FormatInfoInheritProperties)((((((C1.Win.Input.FormatInfoInheritProperties.CustomFormat | C1.Win.Input.FormatInfoInheritProperties.NullText) 
            | C1.Win.Input.FormatInfoInheritProperties.EmptyAsNull) 
            | C1.Win.Input.FormatInfoInheritProperties.TrimStart) 
            | C1.Win.Input.FormatInfoInheritProperties.TrimEnd) 
            | C1.Win.Input.FormatInfoInheritProperties.CalendarType)));
            this.c1MaskedTextBox1.EditFormat.FormatType = C1.Win.Input.FormatType.CustomFormat;
            this.c1MaskedTextBox1.EditFormat.Inherit = ((C1.Win.Input.FormatInfoInheritProperties)((((((C1.Win.Input.FormatInfoInheritProperties.CustomFormat | C1.Win.Input.FormatInfoInheritProperties.NullText) 
            | C1.Win.Input.FormatInfoInheritProperties.EmptyAsNull) 
            | C1.Win.Input.FormatInfoInheritProperties.TrimStart) 
            | C1.Win.Input.FormatInfoInheritProperties.TrimEnd) 
            | C1.Win.Input.FormatInfoInheritProperties.CalendarType)));
            this.c1MaskedTextBox1.EditMask = "+0-(000)-000-0000";
            this.c1MaskedTextBox1.Location = new System.Drawing.Point(7, 66);
            this.c1MaskedTextBox1.Name = "c1MaskedTextBox1";
            this.c1MaskedTextBox1.Size = new System.Drawing.Size(99, 23);
            this.c1MaskedTextBox1.TabIndex = 11;
            this.c1ThemeController1.SetTheme(this.c1MaskedTextBox1, "(default)");
            // 
            // c1ColorPicker1
            // 
            this.c1ColorPicker1.Location = new System.Drawing.Point(112, 66);
            this.c1ColorPicker1.Name = "c1ColorPicker1";
            this.c1ColorPicker1.Size = new System.Drawing.Size(154, 23);
            this.c1ColorPicker1.TabIndex = 12;
            this.c1ThemeController1.SetTheme(this.c1ColorPicker1, "(default)");
            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.Calendar.ClearText = "&Clear";
            this.c1DateEdit1.Calendar.MaxDate = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.c1DateEdit1.Calendar.MinDate = new System.DateTime(((long)(0)));
            this.c1DateEdit1.Calendar.TodayFormat = "&Today: {}";
            this.c1DateEdit1.CultureInfo = new System.Globalization.CultureInfo("en-US");
            this.c1DateEdit1.Location = new System.Drawing.Point(272, 66);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(169, 23);
            this.c1DateEdit1.TabIndex = 13;
            this.c1ThemeController1.SetTheme(this.c1DateEdit1, "(default)");
            this.c1DateEdit1.Value = new System.DateTime(2022, 3, 24, 9, 1, 11, 959);
            // 
            // c1FontPicker1
            // 
            this.c1FontPicker1.Location = new System.Drawing.Point(7, 95);
            this.c1FontPicker1.Name = "c1FontPicker1";
            this.c1FontPicker1.Size = new System.Drawing.Size(152, 23);
            this.c1FontPicker1.TabIndex = 14;
            this.c1ThemeController1.SetTheme(this.c1FontPicker1, "(default)");
            // 
            // c1CalendarView1
            // 
            this.c1CalendarView1.AnnuallyBoldedDates = new System.DateTime[0];
            this.c1CalendarView1.CaptionFormat = null;
            this.c1CalendarView1.CurrentCulture = new System.Globalization.CultureInfo("");
            this.c1CalendarView1.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.c1CalendarView1.Location = new System.Drawing.Point(165, 95);
            this.c1CalendarView1.MaxDate = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.c1CalendarView1.Name = "c1CalendarView1";
            this.c1CalendarView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.c1CalendarView1.Size = new System.Drawing.Size(216, 187);
            this.c1CalendarView1.TabIndex = 15;
            this.c1ThemeController1.SetTheme(this.c1CalendarView1, "(default)");
            this.c1CalendarView1.TodayFormat = "&Today: {}";
            // 
            // Themes
            //             
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Themes";
            this.Size = new System.Drawing.Size(518, 361);
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Themes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbThemes)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1RadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1RangeSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MaskedTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ColorPicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FontPicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CalendarView1)).EndInit();
            this.ResumeLayout(false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
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
        private C1.Win.Input.C1DropDownControl c1DropDownControl1;
        private C1.Win.Input.C1MaskedTextBox c1MaskedTextBox1;
        private C1.Win.Input.Pickers.C1ColorPicker c1ColorPicker1;
        private C1.Win.Calendar.C1CalendarView c1CalendarView1;
        private C1.Win.Calendar.C1DateEdit c1DateEdit1;
        private C1.Win.Input.Pickers.C1FontPicker c1FontPicker1;

    }
}
