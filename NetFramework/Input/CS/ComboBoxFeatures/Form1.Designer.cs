namespace ComboBoxFeatures
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectedIndex = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.c1ComboBoxMain = new C1.Win.C1Input.C1ComboBox();
            this.cbxDropDownStyle = new C1.Win.C1Input.C1ComboBox();
            this.cbxAutoOpen = new C1.Win.C1Input.C1ComboBox();
            this.cbxBoundTo = new C1.Win.C1Input.C1ComboBox();
            this.cbxDropDownSize = new C1.Win.C1Input.C1ComboBox();
            this.c1ComboBoxVisualStyle = new C1.Win.C1Input.C1ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDropDownStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAutoOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBoundTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDropDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBoxVisualStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Controls.Add(this.cbxDropDownStyle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxAutoOpen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxBoundTo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxDropDownSize, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 239);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DropDownStyle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AutoOpen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bound to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Drop down form size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ComboBox:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.81781F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.18219F));
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedIndex, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedItem, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblValue, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(294, 72);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 146);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblSelectedIndex
            // 
            this.lblSelectedIndex.AutoSize = true;
            this.lblSelectedIndex.Location = new System.Drawing.Point(88, 13);
            this.lblSelectedIndex.Name = "lblSelectedIndex";
            this.lblSelectedIndex.Size = new System.Drawing.Size(41, 13);
            this.lblSelectedIndex.TabIndex = 3;
            this.lblSelectedIndex.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "SelectedIndex";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "SelectedItem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Value";
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Location = new System.Drawing.Point(88, 0);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(41, 13);
            this.lblSelectedItem.TabIndex = 6;
            this.lblSelectedItem.Text = "label13";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(88, 26);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(44, 13);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "lblValue";
            // 
            // c1ComboBoxMain
            // 
            this.c1ComboBoxMain.AutoOpen = false;
            this.c1ComboBoxMain.GapHeight = 0;
            this.c1ComboBoxMain.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBoxMain.InitialSelectedIndex = 0;
            this.c1ComboBoxMain.Items.Add("Chateau Mansion Wood Iron Crystals hand made CHANDELIER stunning vintage style");
            this.c1ComboBoxMain.Items.Add("Vintage Cast Iron Chandelier Gothic Spanish Hanging Light Fixture Amber Shades");
            this.c1ComboBoxMain.Items.Add("Vintage Art Deco Cast Ceiling Flush Double Socket Light Fixture Chandelier");
            this.c1ComboBoxMain.Items.Add("ELEGANT c.30\'s VICTORIAN ART DECO GLASS CEILING LIGHT FIXTURE CHANDELIER");
            this.c1ComboBoxMain.Items.Add("VTG ANTIQUE ART DECO ORNATE GLASS CEILING LIGHT FIXTURE CHANDELIER SHADES");
            this.c1ComboBoxMain.Items.Add("Antique original glass art deco light fixture ceiling chandelier frosted");
            this.c1ComboBoxMain.ItemsDataSource = this.countryBindingSource;
            this.c1ComboBoxMain.ItemsDisplayMember = "";
            this.c1ComboBoxMain.ItemsValueMember = "";
            this.c1ComboBoxMain.Location = new System.Drawing.Point(407, 32);
            this.c1ComboBoxMain.MouseClickPassThrough = true;
            this.c1ComboBoxMain.Name = "c1ComboBoxMain";
            this.c1ComboBoxMain.Size = new System.Drawing.Size(108, 18);
            this.c1ComboBoxMain.Style.DefaultItemForeColor = System.Drawing.Color.Black;
            this.c1ComboBoxMain.Style.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.c1ComboBoxMain.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(112)))), ((int)(((byte)(116)))));
            this.c1ComboBoxMain.Style.HotItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c1ComboBoxMain.Style.HotItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.c1ComboBoxMain.Style.HotItemForeColor = System.Drawing.Color.Black;
            this.c1ComboBoxMain.Style.Padding = 2;
            this.c1ComboBoxMain.Style.TextSpacing = 8;
            this.c1ComboBoxMain.TabIndex = 2;
            this.c1ComboBoxMain.Tag = null;
            this.c1ComboBoxMain.Value = "lkejr ljklfjsldfj sdkf;  ;lsdkf; skd;f ks;dfk ;sdkf ;sdkf; s;dfk ;sdkfs";
            this.c1ComboBoxMain.SelectedItemChanged += new System.EventHandler(this.c1ComboBoxMain_SelectedItemChanged);
            this.c1ComboBoxMain.SelectedIndexChanged += new System.EventHandler(this.c1ComboBoxMain_SelectedIndexChanged);
            this.c1ComboBoxMain.ValueChanged += new System.EventHandler(this.c1ComboBoxMain_ValueChanged);
            // 
            // cbxDropDownStyle
            // 
            this.cbxDropDownStyle.AutoOpen = false;
            this.cbxDropDownStyle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxDropDownStyle.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbxDropDownStyle.GapHeight = 0;
            this.cbxDropDownStyle.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxDropDownStyle.InitialSelectedIndex = 0;
            this.cbxDropDownStyle.ItemsDisplayMember = "";
            this.cbxDropDownStyle.ItemsValueMember = "";
            this.cbxDropDownStyle.Location = new System.Drawing.Point(129, 3);
            this.cbxDropDownStyle.Name = "cbxDropDownStyle";
            this.cbxDropDownStyle.Size = new System.Drawing.Size(108, 18);
            this.cbxDropDownStyle.Style.DefaultItemForeColor = System.Drawing.Color.Black;
            this.cbxDropDownStyle.Style.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.cbxDropDownStyle.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(112)))), ((int)(((byte)(116)))));
            this.cbxDropDownStyle.Style.HotItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(217)))));
            this.cbxDropDownStyle.Style.HotItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.cbxDropDownStyle.Style.HotItemForeColor = System.Drawing.Color.Black;
            this.cbxDropDownStyle.Style.Padding = 2;
            this.cbxDropDownStyle.Style.TextSpacing = 8;
            this.cbxDropDownStyle.TabIndex = 2;
            this.cbxDropDownStyle.Tag = null;
            this.cbxDropDownStyle.TextDetached = true;
            this.cbxDropDownStyle.SelectedItemChanged += new System.EventHandler(this.cbxDropDownStyle_SelectedItemChanged);
            // 
            // cbxAutoOpen
            // 
            this.cbxAutoOpen.AutoOpen = false;
            this.cbxAutoOpen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxAutoOpen.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbxAutoOpen.GapHeight = 0;
            this.cbxAutoOpen.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxAutoOpen.InitialSelectedIndex = 1;
            this.cbxAutoOpen.InitialSelection = C1.Win.C1Input.InitialSelectionEnum.SelectAll;
            this.cbxAutoOpen.ItemsDisplayMember = "";
            this.cbxAutoOpen.ItemsValueMember = "";
            this.cbxAutoOpen.Location = new System.Drawing.Point(129, 23);
            this.cbxAutoOpen.Name = "cbxAutoOpen";
            this.cbxAutoOpen.Size = new System.Drawing.Size(108, 18);
            this.cbxAutoOpen.Style.DefaultItemForeColor = System.Drawing.Color.Black;
            this.cbxAutoOpen.Style.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.cbxAutoOpen.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(112)))), ((int)(((byte)(116)))));
            this.cbxAutoOpen.Style.HotItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(217)))));
            this.cbxAutoOpen.Style.HotItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.cbxAutoOpen.Style.HotItemForeColor = System.Drawing.Color.Black;
            this.cbxAutoOpen.Style.Padding = 2;
            this.cbxAutoOpen.Style.TextSpacing = 8;
            this.cbxAutoOpen.TabIndex = 5;
            this.cbxAutoOpen.Tag = null;
            this.cbxAutoOpen.TextDetached = true;
            this.cbxAutoOpen.SelectedItemChanged += new System.EventHandler(this.cbxAutoOpen_SelectedItemChanged);
            // 
            // cbxBoundTo
            // 
            this.cbxBoundTo.AutoOpen = false;
            this.cbxBoundTo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxBoundTo.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbxBoundTo.GapHeight = 0;
            this.cbxBoundTo.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxBoundTo.InitialSelectedIndex = 0;
            this.cbxBoundTo.InitialSelection = C1.Win.C1Input.InitialSelectionEnum.SelectAll;
            this.cbxBoundTo.Items.Add("Array of strings (Design time)");
            this.cbxBoundTo.Items.Add("Enum (Run time)");
            this.cbxBoundTo.Items.Add("Array (Run Time)");
            this.cbxBoundTo.Items.Add("BindingSource");
            this.cbxBoundTo.ItemsDisplayMember = "";
            this.cbxBoundTo.ItemsValueMember = "";
            this.cbxBoundTo.Location = new System.Drawing.Point(129, 43);
            this.cbxBoundTo.Name = "cbxBoundTo";
            this.cbxBoundTo.Size = new System.Drawing.Size(108, 18);
            this.cbxBoundTo.Style.DefaultItemForeColor = System.Drawing.Color.Black;
            this.cbxBoundTo.Style.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.cbxBoundTo.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(112)))), ((int)(((byte)(116)))));
            this.cbxBoundTo.Style.HotItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(217)))));
            this.cbxBoundTo.Style.HotItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.cbxBoundTo.Style.HotItemForeColor = System.Drawing.Color.Black;
            this.cbxBoundTo.Style.Padding = 2;
            this.cbxBoundTo.Style.TextSpacing = 8;
            this.cbxBoundTo.TabIndex = 6;
            this.cbxBoundTo.Tag = null;
            this.cbxBoundTo.TextDetached = true;
            this.cbxBoundTo.Value = "Array of strings (Design time)";
            this.cbxBoundTo.SelectedIndexChanged += new System.EventHandler(this.cbxBoundTo_SelectedIndexChanged);
            // 
            // cbxDropDownSize
            // 
            this.cbxDropDownSize.AutoOpen = false;
            this.cbxDropDownSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxDropDownSize.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbxDropDownSize.GapHeight = 0;
            this.cbxDropDownSize.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxDropDownSize.InitialSelectedIndex = 0;
            this.cbxDropDownSize.InitialSelection = C1.Win.C1Input.InitialSelectionEnum.SelectAll;
            this.cbxDropDownSize.Items.Add("Auto");
            this.cbxDropDownSize.Items.Add("Small");
            this.cbxDropDownSize.Items.Add("Large");
            this.cbxDropDownSize.ItemsDisplayMember = "";
            this.cbxDropDownSize.ItemsValueMember = "";
            this.cbxDropDownSize.Location = new System.Drawing.Point(129, 63);
            this.cbxDropDownSize.Name = "cbxDropDownSize";
            this.cbxDropDownSize.Size = new System.Drawing.Size(108, 18);
            this.cbxDropDownSize.Style.DefaultItemForeColor = System.Drawing.Color.Black;
            this.cbxDropDownSize.Style.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.cbxDropDownSize.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(112)))), ((int)(((byte)(116)))));
            this.cbxDropDownSize.Style.HotItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(217)))));
            this.cbxDropDownSize.Style.HotItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.cbxDropDownSize.Style.HotItemForeColor = System.Drawing.Color.Black;
            this.cbxDropDownSize.Style.Padding = 2;
            this.cbxDropDownSize.Style.TextSpacing = 8;
            this.cbxDropDownSize.TabIndex = 13;
            this.cbxDropDownSize.Tag = null;
            this.cbxDropDownSize.Value = "Auto";
            this.cbxDropDownSize.SelectedIndexChanged += new System.EventHandler(this.cbxDropDownSize_SelectedIndexChanged);
            // 
            // c1ComboBoxVisualStyle
            // 
            this.c1ComboBoxVisualStyle.AutoOpen = false;
            this.c1ComboBoxVisualStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c1ComboBoxVisualStyle.GapHeight = 0;
            this.c1ComboBoxVisualStyle.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBoxVisualStyle.InitialSelectedIndex = 0;
            this.c1ComboBoxVisualStyle.ItemsDisplayMember = "";
            this.c1ComboBoxVisualStyle.ItemsValueMember = "";
            this.c1ComboBoxVisualStyle.Location = new System.Drawing.Point(12, 277);
            this.c1ComboBoxVisualStyle.Name = "c1ComboBoxVisualStyle";
            this.c1ComboBoxVisualStyle.Size = new System.Drawing.Size(243, 18);
            this.c1ComboBoxVisualStyle.Style.DefaultItemForeColor = System.Drawing.Color.Black;
            this.c1ComboBoxVisualStyle.Style.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.c1ComboBoxVisualStyle.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(112)))), ((int)(((byte)(116)))));
            this.c1ComboBoxVisualStyle.Style.HotItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(217)))));
            this.c1ComboBoxVisualStyle.Style.HotItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.c1ComboBoxVisualStyle.Style.HotItemForeColor = System.Drawing.Color.Black;
            this.c1ComboBoxVisualStyle.Style.Padding = 2;
            this.c1ComboBoxVisualStyle.Style.TextSpacing = 8;
            this.c1ComboBoxVisualStyle.TabIndex = 0;
            this.c1ComboBoxVisualStyle.Tag = null;
            this.c1ComboBoxVisualStyle.SelectedItemChanged += new System.EventHandler(this.c1ComboBoxVisualStyle_SelectedItemChanged);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(ComboBoxFeatures.Country);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 307);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.c1ComboBoxMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.c1ComboBoxVisualStyle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDropDownStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAutoOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBoundTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDropDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBoxVisualStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1ComboBox c1ComboBoxVisualStyle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.C1Input.C1ComboBox cbxDropDownStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1Input.C1ComboBox cbxAutoOpen;
        private C1.Win.C1Input.C1ComboBox cbxBoundTo;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1Input.C1ComboBox c1ComboBoxMain;
        private System.Windows.Forms.Label label6;
        private C1.Win.C1Input.C1ComboBox cbxDropDownSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSelectedIndex;
        private System.Windows.Forms.Label lblSelectedItem;

    }
}

