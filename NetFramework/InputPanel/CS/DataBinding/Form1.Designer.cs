namespace DataBinding
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nWINDDataSet = new DataBinding.NWINDDataSet();
            this.employeesTableAdapter = new DataBinding.NWINDDataSetTableAdapters.EmployeesTableAdapter();
            this.c1InputPanel1 = new C1.Win.InputPanel.C1InputPanel();
            this.inputGroupHeader4 = new C1.Win.InputPanel.InputGroupHeader();
            this.inputDataNavigator1 = new C1.Win.InputPanel.InputDataNavigator();
            this.inputGroupHeader1 = new C1.Win.InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.InputPanel.InputLabel();
            this.inputTextBox1 = new C1.Win.InputPanel.InputTextBox();
            this.inputTextBox2 = new C1.Win.InputPanel.InputTextBox();
            this.inputComboBox2 = new C1.Win.InputPanel.InputComboBox();
            this.inputOption1 = new C1.Win.InputPanel.InputOption();
            this.inputOption2 = new C1.Win.InputPanel.InputOption();
            this.inputLabel2 = new C1.Win.InputPanel.InputLabel();
            this.inputDatePicker1 = new C1.Win.InputPanel.InputDatePicker();
            this.inputLabel9 = new C1.Win.InputPanel.InputLabel();
            this.inputTimePicker1 = new C1.Win.InputPanel.InputTimePicker();
            this.inputImage1 = new C1.Win.InputPanel.InputImage();
            this.inputGroupHeader2 = new C1.Win.InputPanel.InputGroupHeader();
            this.inputLabel3 = new C1.Win.InputPanel.InputLabel();
            this.inputTextBox3 = new C1.Win.InputPanel.InputTextBox();
            this.inputLabel4 = new C1.Win.InputPanel.InputLabel();
            this.inputDatePicker2 = new C1.Win.InputPanel.InputDatePicker();
            this.inputLabel5 = new C1.Win.InputPanel.InputLabel();
            this.inputComboBox1 = new C1.Win.InputPanel.InputComboBox();
            this.inputGroupHeader3 = new C1.Win.InputPanel.InputGroupHeader();
            this.inputLabel6 = new C1.Win.InputPanel.InputLabel();
            this.inputTextBox5 = new C1.Win.InputPanel.InputTextBox();
            this.inputLabel7 = new C1.Win.InputPanel.InputLabel();
            this.inputTextBox6 = new C1.Win.InputPanel.InputTextBox();
            this.inputTextBox7 = new C1.Win.InputPanel.InputTextBox();
            this.inputLabel8 = new C1.Win.InputPanel.InputLabel();
            this.inputTextBox8 = new C1.Win.InputPanel.InputTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWINDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Employees";
            this.bindingSource1.DataSource = this.nWINDDataSet;
            // 
            // nWINDDataSet
            // 
            this.nWINDDataSet.DataSetName = "NWINDDataSet";
            this.nWINDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader4);
            this.c1InputPanel1.Items.Add(this.inputDataNavigator1);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel1.Items.Add(this.inputLabel1);
            this.c1InputPanel1.Items.Add(this.inputTextBox1);
            this.c1InputPanel1.Items.Add(this.inputTextBox2);
            this.c1InputPanel1.Items.Add(this.inputComboBox2);
            this.c1InputPanel1.Items.Add(this.inputLabel2);
            this.c1InputPanel1.Items.Add(this.inputDatePicker1);
            this.c1InputPanel1.Items.Add(this.inputLabel9);
            this.c1InputPanel1.Items.Add(this.inputTimePicker1);
            this.c1InputPanel1.Items.Add(this.inputImage1);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader2);
            this.c1InputPanel1.Items.Add(this.inputLabel3);
            this.c1InputPanel1.Items.Add(this.inputTextBox3);
            this.c1InputPanel1.Items.Add(this.inputLabel4);
            this.c1InputPanel1.Items.Add(this.inputDatePicker2);
            this.c1InputPanel1.Items.Add(this.inputLabel5);
            this.c1InputPanel1.Items.Add(this.inputComboBox1);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader3);
            this.c1InputPanel1.Items.Add(this.inputLabel6);
            this.c1InputPanel1.Items.Add(this.inputTextBox5);
            this.c1InputPanel1.Items.Add(this.inputLabel7);
            this.c1InputPanel1.Items.Add(this.inputTextBox6);
            this.c1InputPanel1.Items.Add(this.inputTextBox7);
            this.c1InputPanel1.Items.Add(this.inputLabel8);
            this.c1InputPanel1.Items.Add(this.inputTextBox8);
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 2);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(534, 486);
            this.c1InputPanel1.SmoothScrolling = true;
            this.c1InputPanel1.TabIndex = 0;
            // 
            // inputGroupHeader4
            // 
            this.inputGroupHeader4.Name = "inputGroupHeader4";
            this.inputGroupHeader4.Text = "Employees";
            // 
            // inputDataNavigator1
            // 
            this.inputDataNavigator1.AddNewImage = ((System.Drawing.Image)(resources.GetObject("inputDataNavigator1.AddNewImage")));
            this.inputDataNavigator1.AddNewToolTip = "Add New";
            this.inputDataNavigator1.ApplyImage = ((System.Drawing.Image)(resources.GetObject("inputDataNavigator1.ApplyImage")));
            this.inputDataNavigator1.ApplyToolTip = "Apply Changes";
            this.inputDataNavigator1.CancelImage = ((System.Drawing.Image)(resources.GetObject("inputDataNavigator1.CancelImage")));
            this.inputDataNavigator1.CancelToolTip = "Cancel Changes";
            this.inputDataNavigator1.DataSource = this.bindingSource1;
            this.inputDataNavigator1.DeleteImage = ((System.Drawing.Image)(resources.GetObject("inputDataNavigator1.DeleteImage")));
            this.inputDataNavigator1.DeleteToolTip = "Delete";
            this.inputDataNavigator1.MoveFirstImage = ((System.Drawing.Image)(resources.GetObject("inputDataNavigator1.MoveFirstImage")));
            this.inputDataNavigator1.MoveFirstToolTip = "Move First";
            this.inputDataNavigator1.MoveLastImage = ((System.Drawing.Image)(resources.GetObject("inputDataNavigator1.MoveLastImage")));
            this.inputDataNavigator1.MoveLastToolTip = "Move Last";
            this.inputDataNavigator1.MoveNextImage = ((System.Drawing.Image)(resources.GetObject("inputDataNavigator1.MoveNextImage")));
            this.inputDataNavigator1.MoveNextToolTip = "Move Next";
            this.inputDataNavigator1.MovePreviousImage = ((System.Drawing.Image)(resources.GetObject("inputDataNavigator1.MovePreviousImage")));
            this.inputDataNavigator1.MovePreviousToolTip = "Move Previous";
            this.inputDataNavigator1.Name = "inputDataNavigator1";
            this.inputDataNavigator1.ReloadImage = ((System.Drawing.Image)(resources.GetObject("inputDataNavigator1.ReloadImage")));
            this.inputDataNavigator1.ReloadToolTip = "Reload Data";
            this.inputDataNavigator1.SaveImage = ((System.Drawing.Image)(resources.GetObject("inputDataNavigator1.SaveImage")));
            this.inputDataNavigator1.SaveToolTip = "Save Data";
            this.inputDataNavigator1.ShowReloadButton = true;
            this.inputDataNavigator1.ShowSaveButton = true;
            this.inputDataNavigator1.SaveData += new System.EventHandler(this.inputDataNavigator1_SaveData);
            this.inputDataNavigator1.ReloadData += new System.EventHandler(this.inputDataNavigator1_ReloadData);
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "Personal Info";
            // 
            // inputLabel1
            // 
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "Name: ";
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Break = C1.Win.InputPanel.BreakType.None;
            this.inputTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "FirstName", true));
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Width = 120;
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Break = C1.Win.InputPanel.BreakType.None;
            this.inputTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "LastName", true));
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Width = 120;
            // 
            // inputComboBox2
            // 
            this.inputComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "TitleOfCourtesy", true));
            this.inputComboBox2.Items.Add(this.inputOption1);
            this.inputComboBox2.Items.Add(this.inputOption2);
            this.inputComboBox2.Name = "inputComboBox2";
            this.inputComboBox2.Width = 60;
            // 
            // inputOption1
            // 
            this.inputOption1.Name = "inputOption1";
            this.inputOption1.Text = "Mr.";
            // 
            // inputOption2
            // 
            this.inputOption2.Name = "inputOption2";
            this.inputOption2.Text = "Ms.";
            // 
            // inputLabel2
            // 
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Text = "Birth Date:";
            // 
            // inputDatePicker1
            // 
            this.inputDatePicker1.Break = C1.Win.InputPanel.BreakType.None;
            this.inputDatePicker1.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "BirthDate", true));
            this.inputDatePicker1.Name = "inputDatePicker1";
            // 
            // inputLabel9
            // 
            this.inputLabel9.HorizontalAlign = C1.Win.InputPanel.InputContentAlignment.Far;
            this.inputLabel9.Name = "inputLabel9";
            this.inputLabel9.Text = "Birth Time:";
            this.inputLabel9.Width = 68;
            // 
            // inputTimePicker1
            // 
            this.inputTimePicker1.Break = C1.Win.InputPanel.BreakType.Column;
            this.inputTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "BirthDate", true));
            this.inputTimePicker1.Name = "inputTimePicker1";
            // 
            // inputImage1
            // 
            this.inputImage1.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "Photo", true));
            this.inputImage1.Height = 155;
            this.inputImage1.Image = ((System.Drawing.Image)(resources.GetObject("inputImage1.Image")));
            this.inputImage1.Name = "inputImage1";
            this.inputImage1.Width = 155;
            // 
            // inputGroupHeader2
            // 
            this.inputGroupHeader2.Name = "inputGroupHeader2";
            this.inputGroupHeader2.Text = "Job Information";
            // 
            // inputLabel3
            // 
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Text = "Title:";
            this.inputLabel3.Width = 80;
            // 
            // inputTextBox3
            // 
            this.inputTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "Title", true));
            this.inputTextBox3.Name = "inputTextBox3";
            this.inputTextBox3.Width = 210;
            // 
            // inputLabel4
            // 
            this.inputLabel4.Name = "inputLabel4";
            this.inputLabel4.Text = "Hire Date:";
            this.inputLabel4.Width = 80;
            // 
            // inputDatePicker2
            // 
            this.inputDatePicker2.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "HireDate", true));
            this.inputDatePicker2.Name = "inputDatePicker2";
            // 
            // inputLabel5
            // 
            this.inputLabel5.Name = "inputLabel5";
            this.inputLabel5.Text = "Reports To:";
            this.inputLabel5.Width = 80;
            // 
            // inputComboBox1
            // 
            this.inputComboBox1.AutoCompleteMode = C1.Win.InputPanel.InputAutoCompleteMode.Suggest;
            this.inputComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "ReportsTo", true));
            this.inputComboBox1.DataSource = this.bindingSource1;
            this.inputComboBox1.DisplayMember = "LastName";
            this.inputComboBox1.FormattingEnabled = true;
            this.inputComboBox1.Name = "inputComboBox1";
            this.inputComboBox1.UpdateListPosition = false;
            this.inputComboBox1.ValueMember = "EmployeeID";
            this.inputComboBox1.Width = 186;
            this.inputComboBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.inputComboBox1_Format);
            // 
            // inputGroupHeader3
            // 
            this.inputGroupHeader3.Name = "inputGroupHeader3";
            this.inputGroupHeader3.Text = "Address";
            // 
            // inputLabel6
            // 
            this.inputLabel6.Height = 40;
            this.inputLabel6.Name = "inputLabel6";
            this.inputLabel6.Text = "Street:";
            this.inputLabel6.Width = 80;
            // 
            // inputTextBox5
            // 
            this.inputTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "Address", true));
            this.inputTextBox5.Height = 40;
            this.inputTextBox5.Multiline = true;
            this.inputTextBox5.Name = "inputTextBox5";
            this.inputTextBox5.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Spread;
            this.inputTextBox5.Width = 272;
            // 
            // inputLabel7
            // 
            this.inputLabel7.Name = "inputLabel7";
            this.inputLabel7.Text = "City, Region:";
            this.inputLabel7.Width = 80;
            // 
            // inputTextBox6
            // 
            this.inputTextBox6.Break = C1.Win.InputPanel.BreakType.None;
            this.inputTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "City", true));
            this.inputTextBox6.Name = "inputTextBox6";
            this.inputTextBox6.Width = 182;
            // 
            // inputTextBox7
            // 
            this.inputTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "Region", true));
            this.inputTextBox7.Name = "inputTextBox7";
            this.inputTextBox7.Width = 85;
            // 
            // inputLabel8
            // 
            this.inputLabel8.Name = "inputLabel8";
            this.inputLabel8.Text = "Country:";
            this.inputLabel8.Width = 80;
            // 
            // inputTextBox8
            // 
            this.inputTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.bindingSource1, "Country", true));
            this.inputTextBox8.Name = "inputTextBox8";
            this.inputTextBox8.Width = 182;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 491);
            this.Controls.Add(this.c1InputPanel1);
            this.Name = "Form1";
            this.Text = "DataBinding Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWINDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.InputPanel.C1InputPanel c1InputPanel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private NWINDDataSet nWINDDataSet;
        private DataBinding.NWINDDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.InputPanel.InputLabel inputLabel1;
        private C1.Win.InputPanel.InputTextBox inputTextBox1;
        private C1.Win.InputPanel.InputTextBox inputTextBox2;
        private C1.Win.InputPanel.InputComboBox inputComboBox2;
        private C1.Win.InputPanel.InputLabel inputLabel2;
        private C1.Win.InputPanel.InputDatePicker inputDatePicker1;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.InputPanel.InputLabel inputLabel3;
        private C1.Win.InputPanel.InputTextBox inputTextBox3;
        private C1.Win.InputPanel.InputLabel inputLabel4;
        private C1.Win.InputPanel.InputDatePicker inputDatePicker2;
        private C1.Win.InputPanel.InputLabel inputLabel5;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader3;
        private C1.Win.InputPanel.InputLabel inputLabel6;
        private C1.Win.InputPanel.InputTextBox inputTextBox5;
        private C1.Win.InputPanel.InputLabel inputLabel7;
        private C1.Win.InputPanel.InputTextBox inputTextBox6;
        private C1.Win.InputPanel.InputTextBox inputTextBox7;
        private C1.Win.InputPanel.InputLabel inputLabel8;
        private C1.Win.InputPanel.InputTextBox inputTextBox8;
        private C1.Win.InputPanel.InputImage inputImage1;
        private C1.Win.InputPanel.InputComboBox inputComboBox1;
        private C1.Win.InputPanel.InputOption inputOption1;
        private C1.Win.InputPanel.InputOption inputOption2;
        private C1.Win.InputPanel.InputLabel inputLabel9;
        private C1.Win.InputPanel.InputTimePicker inputTimePicker1;
        private C1.Win.InputPanel.InputDataNavigator inputDataNavigator1;
        private C1.Win.InputPanel.InputGroupHeader inputGroupHeader4;
    }
}

