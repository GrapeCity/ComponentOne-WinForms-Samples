namespace Layout
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTheme = new C1.Win.C1Input.C1ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.clpTodayForeColor = new C1.Win.C1Input.C1ColorPicker();
            this.clpTodayBorderColor = new C1.Win.C1Input.C1ColorPicker();
            this.clpWeekendForeColor = new C1.Win.C1Input.C1ColorPicker();
            this.clpDayForeColor = new C1.Win.C1Input.C1ColorPicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAlignment = new C1.Win.C1Input.C1ComboBox();
            this.cmbMonthTitlePosition = new C1.Win.C1Input.C1ComboBox();
            this.cmbDayTitlePosition = new C1.Win.C1Input.C1ComboBox();
            this.numMaxSelectionCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numCalendarDimensions = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbShowWeekNumbers = new System.Windows.Forms.CheckBox();
            this.cbVerticalOrientationLayout = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c1CalendarView1 = new C1.Win.Calendar.C1CalendarView();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clpTodayForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clpTodayBorderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clpWeekendForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clpDayForeColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonthTitlePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDayTitlePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSelectionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCalendarDimensions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1CalendarView1);
            this.splitContainer1.Size = new System.Drawing.Size(1126, 672);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.splitContainer1, "(default)");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.groupBox2.Controls.Add(this.cmbTheme);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.clpTodayForeColor);
            this.groupBox2.Controls.Add(this.clpTodayBorderColor);
            this.groupBox2.Controls.Add(this.clpWeekendForeColor);
            this.groupBox2.Controls.Add(this.clpDayForeColor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 178);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styles";
            this.c1ThemeController1.SetTheme(this.groupBox2, "(default)");
            // 
            // cmbTheme
            // 
            this.cmbTheme.AllowSpinLoop = false;
            this.cmbTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbTheme.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cmbTheme.GapHeight = 0;
            this.cmbTheme.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbTheme.ImageTransparentColor = System.Drawing.Color.Empty;
            this.cmbTheme.ItemsDisplayMember = "";
            this.cmbTheme.ItemsValueMember = "";
            this.cmbTheme.Location = new System.Drawing.Point(151, 23);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(132, 18);
            this.cmbTheme.Style.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbTheme.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.cmbTheme.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTheme.TabIndex = 9;
            this.cmbTheme.Tag = null;
            this.c1ThemeController1.SetTheme(this.cmbTheme, "(default)");
            this.cmbTheme.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label10.Location = new System.Drawing.Point(102, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Theme:";
            this.c1ThemeController1.SetTheme(this.label10, "(default)");
            // 
            // clpTodayForeColor
            // 
            this.clpTodayForeColor.AllowEmpty = false;
            this.clpTodayForeColor.Color = System.Drawing.Color.Transparent;
            this.clpTodayForeColor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.clpTodayForeColor.ImagePadding = new System.Windows.Forms.Padding(0);
            this.clpTodayForeColor.ImageTransparentColor = System.Drawing.Color.Empty;
            this.clpTodayForeColor.Location = new System.Drawing.Point(151, 103);
            this.clpTodayForeColor.Name = "clpTodayForeColor";
            this.clpTodayForeColor.Size = new System.Drawing.Size(132, 18);
            this.clpTodayForeColor.TabIndex = 7;
            this.clpTodayForeColor.Tag = null;
            this.c1ThemeController1.SetTheme(this.clpTodayForeColor, "(default)");
            this.clpTodayForeColor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.clpTodayForeColor.ColorChanged += new System.EventHandler(this.clpTodayForeColor_ColorChanged);
            // 
            // clpTodayBorderColor
            // 
            this.clpTodayBorderColor.AllowEmpty = false;
            this.clpTodayBorderColor.Color = System.Drawing.Color.Transparent;
            this.clpTodayBorderColor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.clpTodayBorderColor.ImagePadding = new System.Windows.Forms.Padding(0);
            this.clpTodayBorderColor.ImageTransparentColor = System.Drawing.Color.Empty;
            this.clpTodayBorderColor.Location = new System.Drawing.Point(151, 130);
            this.clpTodayBorderColor.Name = "clpTodayBorderColor";
            this.clpTodayBorderColor.Size = new System.Drawing.Size(132, 18);
            this.clpTodayBorderColor.TabIndex = 6;
            this.clpTodayBorderColor.Tag = null;
            this.c1ThemeController1.SetTheme(this.clpTodayBorderColor, "(default)");
            this.clpTodayBorderColor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.clpTodayBorderColor.ColorChanged += new System.EventHandler(this.clpTodayBorderColor_ColorChanged);
            // 
            // clpWeekendForeColor
            // 
            this.clpWeekendForeColor.AllowEmpty = false;
            this.clpWeekendForeColor.Color = System.Drawing.Color.Transparent;
            this.clpWeekendForeColor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.clpWeekendForeColor.ImagePadding = new System.Windows.Forms.Padding(0);
            this.clpWeekendForeColor.ImageTransparentColor = System.Drawing.Color.Empty;
            this.clpWeekendForeColor.Location = new System.Drawing.Point(151, 76);
            this.clpWeekendForeColor.Name = "clpWeekendForeColor";
            this.clpWeekendForeColor.Size = new System.Drawing.Size(132, 18);
            this.clpWeekendForeColor.TabIndex = 5;
            this.clpWeekendForeColor.Tag = null;
            this.c1ThemeController1.SetTheme(this.clpWeekendForeColor, "(default)");
            this.clpWeekendForeColor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.clpWeekendForeColor.ColorChanged += new System.EventHandler(this.clpWeekendForeColor_ColorChanged);
            // 
            // clpDayForeColor
            // 
            this.clpDayForeColor.AllowEmpty = false;
            this.clpDayForeColor.Color = System.Drawing.Color.Transparent;
            this.clpDayForeColor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.clpDayForeColor.ImagePadding = new System.Windows.Forms.Padding(0);
            this.clpDayForeColor.ImageTransparentColor = System.Drawing.Color.Empty;
            this.clpDayForeColor.Location = new System.Drawing.Point(151, 49);
            this.clpDayForeColor.Name = "clpDayForeColor";
            this.clpDayForeColor.Size = new System.Drawing.Size(132, 18);
            this.clpDayForeColor.TabIndex = 4;
            this.clpDayForeColor.Tag = null;
            this.c1ThemeController1.SetTheme(this.clpDayForeColor, "(default)");
            this.clpDayForeColor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.clpDayForeColor.ColorChanged += new System.EventHandler(this.clpDayForeColor_ColorChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label9.Location = new System.Drawing.Point(25, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Today foreground color:";
            this.c1ThemeController1.SetTheme(this.label9, "(default)");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label8.Location = new System.Drawing.Point(46, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Today border color:";
            this.c1ThemeController1.SetTheme(this.label8, "(default)");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label7.Location = new System.Drawing.Point(11, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Weekend foreground color:";
            this.c1ThemeController1.SetTheme(this.label7, "(default)");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label6.Location = new System.Drawing.Point(36, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Day foreground color:";
            this.c1ThemeController1.SetTheme(this.label6, "(default)");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.groupBox1.Controls.Add(this.cmbAlignment);
            this.groupBox1.Controls.Add(this.cmbMonthTitlePosition);
            this.groupBox1.Controls.Add(this.cmbDayTitlePosition);
            this.groupBox1.Controls.Add(this.numMaxSelectionCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numCalendarDimensions);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbShowWeekNumbers);
            this.groupBox1.Controls.Add(this.cbVerticalOrientationLayout);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 206);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layout";
            this.c1ThemeController1.SetTheme(this.groupBox1, "(default)");
            // 
            // cmbAlignment
            // 
            this.cmbAlignment.AllowSpinLoop = false;
            this.cmbAlignment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbAlignment.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cmbAlignment.GapHeight = 0;
            this.cmbAlignment.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbAlignment.ImageTransparentColor = System.Drawing.Color.Empty;
            this.cmbAlignment.Items.Add("NotSet");
            this.cmbAlignment.Items.Add("Near");
            this.cmbAlignment.Items.Add("Far");
            this.cmbAlignment.Items.Add("Center");
            this.cmbAlignment.Items.Add("Spread");
            this.cmbAlignment.ItemsDisplayMember = "";
            this.cmbAlignment.ItemsValueMember = "";
            this.cmbAlignment.Location = new System.Drawing.Point(115, 100);
            this.cmbAlignment.Name = "cmbAlignment";
            this.cmbAlignment.Size = new System.Drawing.Size(166, 18);
            this.cmbAlignment.Style.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbAlignment.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.cmbAlignment.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAlignment.TabIndex = 14;
            this.cmbAlignment.Tag = null;
            this.c1ThemeController1.SetTheme(this.cmbAlignment, "(default)");
            this.cmbAlignment.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cmbAlignment.SelectedIndexChanged += new System.EventHandler(this.cmbAlignment_SelectedIndexChanged);
            // 
            // cmbMonthTitlePosition
            // 
            this.cmbMonthTitlePosition.AllowSpinLoop = false;
            this.cmbMonthTitlePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbMonthTitlePosition.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cmbMonthTitlePosition.GapHeight = 0;
            this.cmbMonthTitlePosition.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbMonthTitlePosition.ImageTransparentColor = System.Drawing.Color.Empty;
            this.cmbMonthTitlePosition.Items.Add("Top");
            this.cmbMonthTitlePosition.Items.Add("Bottom");
            this.cmbMonthTitlePosition.Items.Add("Left");
            this.cmbMonthTitlePosition.Items.Add("Right");
            this.cmbMonthTitlePosition.ItemsDisplayMember = "";
            this.cmbMonthTitlePosition.ItemsValueMember = "";
            this.cmbMonthTitlePosition.Location = new System.Drawing.Point(115, 50);
            this.cmbMonthTitlePosition.Name = "cmbMonthTitlePosition";
            this.cmbMonthTitlePosition.Size = new System.Drawing.Size(166, 18);
            this.cmbMonthTitlePosition.Style.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbMonthTitlePosition.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.cmbMonthTitlePosition.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMonthTitlePosition.TabIndex = 13;
            this.cmbMonthTitlePosition.Tag = null;
            this.c1ThemeController1.SetTheme(this.cmbMonthTitlePosition, "(default)");
            this.cmbMonthTitlePosition.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cmbMonthTitlePosition.SelectedIndexChanged += new System.EventHandler(this.cmbMonthTitlePosition_SelectedIndexChanged);
            // 
            // cmbDayTitlePosition
            // 
            this.cmbDayTitlePosition.AllowSpinLoop = false;
            this.cmbDayTitlePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbDayTitlePosition.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cmbDayTitlePosition.GapHeight = 0;
            this.cmbDayTitlePosition.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbDayTitlePosition.ImageTransparentColor = System.Drawing.Color.Empty;
            this.cmbDayTitlePosition.Items.Add("Top");
            this.cmbDayTitlePosition.Items.Add("Bottom");
            this.cmbDayTitlePosition.Items.Add("Left");
            this.cmbDayTitlePosition.Items.Add("Right");
            this.cmbDayTitlePosition.ItemsDisplayMember = "";
            this.cmbDayTitlePosition.ItemsValueMember = "";
            this.cmbDayTitlePosition.Location = new System.Drawing.Point(115, 23);
            this.cmbDayTitlePosition.Name = "cmbDayTitlePosition";
            this.cmbDayTitlePosition.Size = new System.Drawing.Size(167, 18);
            this.cmbDayTitlePosition.Style.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbDayTitlePosition.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.cmbDayTitlePosition.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDayTitlePosition.TabIndex = 12;
            this.cmbDayTitlePosition.Tag = null;
            this.c1ThemeController1.SetTheme(this.cmbDayTitlePosition, "(default)");
            this.cmbDayTitlePosition.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cmbDayTitlePosition.SelectedIndexChanged += new System.EventHandler(this.cmbDayTitlePosition_SelectedIndexChanged);
            // 
            // numMaxSelectionCount
            // 
            this.numMaxSelectionCount.BackColor = System.Drawing.Color.White;
            this.numMaxSelectionCount.ForeColor = System.Drawing.Color.Black;
            this.numMaxSelectionCount.Location = new System.Drawing.Point(115, 175);
            this.numMaxSelectionCount.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numMaxSelectionCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxSelectionCount.Name = "numMaxSelectionCount";
            this.numMaxSelectionCount.Size = new System.Drawing.Size(44, 20);
            this.numMaxSelectionCount.TabIndex = 11;
            this.c1ThemeController1.SetTheme(this.numMaxSelectionCount, "(default)");
            this.numMaxSelectionCount.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numMaxSelectionCount.ValueChanged += new System.EventHandler(this.numMaxSelectionCount_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(4, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max selection count:";
            this.c1ThemeController1.SetTheme(this.label5, "(default)");
            // 
            // numCalendarDimensions
            // 
            this.numCalendarDimensions.BackColor = System.Drawing.Color.White;
            this.numCalendarDimensions.ForeColor = System.Drawing.Color.Black;
            this.numCalendarDimensions.Location = new System.Drawing.Point(115, 149);
            this.numCalendarDimensions.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numCalendarDimensions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCalendarDimensions.Name = "numCalendarDimensions";
            this.numCalendarDimensions.Size = new System.Drawing.Size(44, 20);
            this.numCalendarDimensions.TabIndex = 9;
            this.c1ThemeController1.SetTheme(this.numCalendarDimensions, "(default)");
            this.numCalendarDimensions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCalendarDimensions.ValueChanged += new System.EventHandler(this.numCalendarDimensions_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(45, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dimensions:";
            this.c1ThemeController1.SetTheme(this.label4, "(default)");
            // 
            // cbShowWeekNumbers
            // 
            this.cbShowWeekNumbers.BackColor = System.Drawing.Color.Transparent;
            this.cbShowWeekNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbShowWeekNumbers.Location = new System.Drawing.Point(98, 126);
            this.cbShowWeekNumbers.Name = "cbShowWeekNumbers";
            this.cbShowWeekNumbers.Size = new System.Drawing.Size(183, 17);
            this.cbShowWeekNumbers.TabIndex = 8;
            this.cbShowWeekNumbers.Text = "Show week numbers";
            this.c1ThemeController1.SetTheme(this.cbShowWeekNumbers, "(default)");
            this.cbShowWeekNumbers.UseVisualStyleBackColor = false;
            this.cbShowWeekNumbers.CheckedChanged += new System.EventHandler(this.cbShowWeekNumbers_CheckedChanged);
            // 
            // cbVerticalOrientationLayout
            // 
            this.cbVerticalOrientationLayout.BackColor = System.Drawing.Color.Transparent;
            this.cbVerticalOrientationLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbVerticalOrientationLayout.Location = new System.Drawing.Point(98, 76);
            this.cbVerticalOrientationLayout.Name = "cbVerticalOrientationLayout";
            this.cbVerticalOrientationLayout.Size = new System.Drawing.Size(183, 18);
            this.cbVerticalOrientationLayout.TabIndex = 7;
            this.cbVerticalOrientationLayout.Text = "Vertical orientation layout";
            this.c1ThemeController1.SetTheme(this.cbVerticalOrientationLayout, "(default)");
            this.cbVerticalOrientationLayout.UseVisualStyleBackColor = false;
            this.cbVerticalOrientationLayout.CheckedChanged += new System.EventHandler(this.cbVerticalOrientationLayout_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day title position:";
            this.c1ThemeController1.SetTheme(this.label2, "(default)");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(53, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alignment:";
            this.c1ThemeController1.SetTheme(this.label3, "(default)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month title position:";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            // 
            // c1CalendarView1
            // 
            this.c1CalendarView1.CaptionFormat = null;
            this.c1CalendarView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1CalendarView1.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.c1CalendarView1.Location = new System.Drawing.Point(0, 0);
            this.c1CalendarView1.MaxDate = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.c1CalendarView1.Name = "c1CalendarView1";
            this.c1CalendarView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.c1CalendarView1.Size = new System.Drawing.Size(818, 672);
            this.c1CalendarView1.TabIndex = 0;
            this.c1CalendarView1.Text = "c1CalendarView1";
            this.c1ThemeController1.SetTheme(this.c1CalendarView1, "(default)");
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "VS2013Light";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 672);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clpTodayForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clpTodayBorderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clpWeekendForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clpDayForeColor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonthTitlePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDayTitlePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSelectionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCalendarDimensions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.Calendar.C1CalendarView c1CalendarView1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbVerticalOrientationLayout;
        private System.Windows.Forms.CheckBox cbShowWeekNumbers;
        private System.Windows.Forms.NumericUpDown numCalendarDimensions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMaxSelectionCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private C1.Win.C1Input.C1ColorPicker clpTodayForeColor;
        private C1.Win.C1Input.C1ColorPicker clpTodayBorderColor;
        private C1.Win.C1Input.C1ColorPicker clpWeekendForeColor;
        private C1.Win.C1Input.C1ColorPicker clpDayForeColor;
        private System.Windows.Forms.Label label10;
        private C1.Win.C1Input.C1ComboBox cmbTheme;
        private C1.Win.C1Input.C1ComboBox cmbMonthTitlePosition;
        private C1.Win.C1Input.C1ComboBox cmbDayTitlePosition;
        private C1.Win.C1Input.C1ComboBox cmbAlignment;
    }
}

