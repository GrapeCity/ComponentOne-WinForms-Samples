namespace ComboBoxTranslateValue
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
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this._orderDBGrid = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1NWindDataSet = new ComboBoxTranslateValue.C1NWindDataSet();
            this.orderTableAdapter = new ComboBoxTranslateValue.C1NWindDataSetTableAdapters.OrderTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1DateEdit1 = new C1.Win.C1Input.C1DateEdit();
            this._purchaseDateEdit = new C1.Win.C1Input.C1DateEdit();
            this._customerEdit = new C1.Win.C1Input.C1ComboBox();
            this.customerdemoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._descriptionEdit = new C1.Win.C1Input.C1TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._quantityEdit = new C1.Win.C1Input.C1NumericEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._addBtn = new C1.Win.C1Input.C1Button();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this._themes = new C1.Win.C1Input.C1ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customer_demoTableAdapter = new ComboBoxTranslateValue.C1NWindDataSetTableAdapters.Customer_demoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._orderDBGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._purchaseDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._customerEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerdemoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._descriptionEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._quantityEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._addBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._themes)).BeginInit();
            this.SuspendLayout();
            // 
            // _orderDBGrid
            // 
            this._orderDBGrid.AlternatingRows = true;
            this._orderDBGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._orderDBGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._orderDBGrid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this._orderDBGrid.DataSource = this.orderBindingSource;
            this._orderDBGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._orderDBGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._orderDBGrid.GroupByCaption = "Drag a column header here to group by that column";
            this._orderDBGrid.Location = new System.Drawing.Point(12, 12);
            this._orderDBGrid.Name = "_orderDBGrid";
            this._orderDBGrid.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this._orderDBGrid.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this._orderDBGrid.PreviewInfo.ZoomFactor = 75D;
            this._orderDBGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("_orderDBGrid.PrintInfo.PageSettings")));
            this._orderDBGrid.PropBag = resources.GetString("_orderDBGrid.PropBag");
            this._orderDBGrid.RowDivider.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._orderDBGrid.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.Single;
            this._orderDBGrid.RowSubDividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this._orderDBGrid.Size = new System.Drawing.Size(340, 339);
            this._orderDBGrid.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this._orderDBGrid, "(default)");
            this._orderDBGrid.UseCompatibleTextRendering = false;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.c1NWindDataSet;
            // 
            // c1NWindDataSet
            // 
            this.c1NWindDataSet.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.c1DateEdit1);
            this.panel1.Controls.Add(this._purchaseDateEdit);
            this.panel1.Controls.Add(this._customerEdit);
            this.panel1.Controls.Add(this._descriptionEdit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._quantityEdit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(368, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 339);
            this.panel1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.AllowSpinLoop = false;
            this.c1DateEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1DateEdit1.BackColor = System.Drawing.Color.White;
            this.c1DateEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1DateEdit1.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1DateEdit1.Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.c1DateEdit1.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1DateEdit1.Calendar.DayNamesFont = new System.Drawing.Font("Tahoma", 8F);
            this.c1DateEdit1.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1DateEdit1.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1DateEdit1.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.c1DateEdit1.Calendar.SelectionForeColor = System.Drawing.Color.White;
            this.c1DateEdit1.Calendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.c1DateEdit1.Calendar.TitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.c1DateEdit1.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1DateEdit1.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.c1DateEdit1.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.c1DateEdit1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.c1DateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "Time", true));
            this.c1DateEdit1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.c1DateEdit1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.LongTime;
            this.c1DateEdit1.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.c1DateEdit1.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.LongTime;
            this.c1DateEdit1.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.c1DateEdit1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DateEdit1.Location = new System.Drawing.Point(69, 60);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(145, 18);
            this.c1DateEdit1.TabIndex = 13;
            this.c1DateEdit1.Tag = null;
            this.c1ThemeController1.SetTheme(this.c1DateEdit1, "(default)");
            this.c1DateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.c1DateEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // _purchaseDateEdit
            // 
            this._purchaseDateEdit.AllowSpinLoop = false;
            this._purchaseDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._purchaseDateEdit.BackColor = System.Drawing.Color.White;
            this._purchaseDateEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this._purchaseDateEdit.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._purchaseDateEdit.Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this._purchaseDateEdit.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._purchaseDateEdit.Calendar.DayNamesFont = new System.Drawing.Font("Tahoma", 8F);
            this._purchaseDateEdit.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this._purchaseDateEdit.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._purchaseDateEdit.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this._purchaseDateEdit.Calendar.SelectionForeColor = System.Drawing.Color.White;
            this._purchaseDateEdit.Calendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this._purchaseDateEdit.Calendar.TitleFont = new System.Drawing.Font("Tahoma", 8F);
            this._purchaseDateEdit.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._purchaseDateEdit.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this._purchaseDateEdit.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this._purchaseDateEdit.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this._purchaseDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "PurchaseDate", true));
            this._purchaseDateEdit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this._purchaseDateEdit.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this._purchaseDateEdit.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this._purchaseDateEdit.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this._purchaseDateEdit.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this._purchaseDateEdit.ImagePadding = new System.Windows.Forms.Padding(0);
            this._purchaseDateEdit.Location = new System.Drawing.Point(69, 36);
            this._purchaseDateEdit.Name = "_purchaseDateEdit";
            this._purchaseDateEdit.Size = new System.Drawing.Size(145, 18);
            this._purchaseDateEdit.TabIndex = 12;
            this._purchaseDateEdit.Tag = null;
            this.c1ThemeController1.SetTheme(this._purchaseDateEdit, "(default)");
            this._purchaseDateEdit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // _customerEdit
            // 
            this._customerEdit.AllowSpinLoop = false;
            this._customerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._customerEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this._customerEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._customerEdit.BackColor = System.Drawing.Color.White;
            this._customerEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._customerEdit.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "CustomerID", true));
            this._customerEdit.DataType = typeof(int);
            this._customerEdit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this._customerEdit.GapHeight = 0;
            this._customerEdit.ImagePadding = new System.Windows.Forms.Padding(0);
            this._customerEdit.ItemsDataSource = this.customerdemoBindingSource;
            this._customerEdit.ItemsDisplayMember = "LastName";
            this._customerEdit.ItemsValueMember = "ID";
            this._customerEdit.Location = new System.Drawing.Point(69, 12);
            this._customerEdit.Name = "_customerEdit";
            this._customerEdit.Size = new System.Drawing.Size(145, 18);
            this._customerEdit.Style.DropDownBackColor = System.Drawing.Color.White;
            this._customerEdit.Style.DropDownBorderColor = System.Drawing.Color.Gainsboro;
            this._customerEdit.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._customerEdit.TabIndex = 12;
            this._customerEdit.Tag = null;
            this._customerEdit.TextDetached = true;
            this.c1ThemeController1.SetTheme(this._customerEdit, "(default)");
            this._customerEdit.TranslateValue = true;
            this._customerEdit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // customerdemoBindingSource
            // 
            this.customerdemoBindingSource.DataMember = "Customer_demo";
            this.customerdemoBindingSource.DataSource = this.c1NWindDataSet;
            // 
            // _descriptionEdit
            // 
            this._descriptionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._descriptionEdit.BackColor = System.Drawing.Color.White;
            this._descriptionEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._descriptionEdit.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "Description", true));
            this._descriptionEdit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this._descriptionEdit.Location = new System.Drawing.Point(69, 108);
            this._descriptionEdit.Multiline = true;
            this._descriptionEdit.Name = "_descriptionEdit";
            this._descriptionEdit.Size = new System.Drawing.Size(145, 85);
            this._descriptionEdit.TabIndex = 11;
            this._descriptionEdit.Tag = null;
            this.c1ThemeController1.SetTheme(this._descriptionEdit, "(default)");
            this._descriptionEdit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description";
            this.c1ThemeController1.SetTheme(this.label5, "(default)");
            // 
            // _quantityEdit
            // 
            this._quantityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._quantityEdit.BackColor = System.Drawing.Color.White;
            this._quantityEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this._quantityEdit.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this._quantityEdit.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this._quantityEdit.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "Quantity", true));
            this._quantityEdit.DataType = typeof(int);
            this._quantityEdit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this._quantityEdit.ImagePadding = new System.Windows.Forms.Padding(0);
            this._quantityEdit.Location = new System.Drawing.Point(69, 84);
            this._quantityEdit.Name = "_quantityEdit";
            this._quantityEdit.Size = new System.Drawing.Size(145, 18);
            this._quantityEdit.TabIndex = 9;
            this._quantityEdit.Tag = null;
            this.c1ThemeController1.SetTheme(this._quantityEdit, "(default)");
            this._quantityEdit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(17, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity";
            this.c1ThemeController1.SetTheme(this.label4, "(default)");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(33, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time";
            this.c1ThemeController1.SetTheme(this.label3, "(default)");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            this.c1ThemeController1.SetTheme(this.label2, "(default)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            // 
            // _addBtn
            // 
            this._addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addBtn.Location = new System.Drawing.Point(12, 357);
            this._addBtn.Name = "_addBtn";
            this._addBtn.Size = new System.Drawing.Size(75, 23);
            this._addBtn.TabIndex = 2;
            this._addBtn.Text = "Add";
            this.c1ThemeController1.SetTheme(this._addBtn, "(default)");
            this._addBtn.UseVisualStyleBackColor = true;
            this._addBtn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this._addBtn.Click += new System.EventHandler(this._addBtn_Click);
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "MacBlue";
            // 
            // _themes
            // 
            this._themes.AllowSpinLoop = false;
            this._themes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._themes.BackColor = System.Drawing.Color.White;
            this._themes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._themes.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this._themes.GapHeight = 0;
            this._themes.ImagePadding = new System.Windows.Forms.Padding(0);
            this._themes.ItemsDisplayMember = "name";
            this._themes.ItemsValueMember = "";
            this._themes.Location = new System.Drawing.Point(461, 357);
            this._themes.Name = "_themes";
            this._themes.Size = new System.Drawing.Size(136, 18);
            this._themes.Style.DropDownBackColor = System.Drawing.Color.White;
            this._themes.Style.DropDownBorderColor = System.Drawing.Color.Gainsboro;
            this._themes.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._themes.TabIndex = 3;
            this._themes.Tag = null;
            this.c1ThemeController1.SetTheme(this._themes, "(default)");
            this._themes.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this._themes.SelectedItemChanged += new System.EventHandler(this._themes_SelectedItemChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(410, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Themes";
            this.c1ThemeController1.SetTheme(this.label6, "(default)");
            // 
            // customer_demoTableAdapter
            // 
            this.customer_demoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 391);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._themes);
            this.Controls.Add(this._addBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._orderDBGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Name = "Form1";
            this.Text = "ComboBoxTranslateValue";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._orderDBGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._purchaseDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._customerEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerdemoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._descriptionEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._quantityEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._addBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._themes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.TrueDBGrid.C1TrueDBGrid _orderDBGrid;
        private C1NWindDataSet c1NWindDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private C1NWindDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1Button _addBtn;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private C1.Win.C1Input.C1ComboBox _themes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1TextBox _descriptionEdit;
        private System.Windows.Forms.Label label5;
        private C1.Win.C1Input.C1NumericEdit _quantityEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private C1.Win.C1Input.C1ComboBox _customerEdit;
        private System.Windows.Forms.BindingSource customerdemoBindingSource;
        private C1NWindDataSetTableAdapters.Customer_demoTableAdapter customer_demoTableAdapter;
        private C1.Win.C1Input.C1DateEdit _purchaseDateEdit;
        private C1.Win.C1Input.C1DateEdit c1DateEdit1;
    }
}

