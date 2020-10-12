<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.cmbTheme = New C1.Win.C1Input.C1ComboBox()
        Me.clpTodayForeColor = New C1.Win.C1Input.C1ColorPicker()
        Me.clpTodayBorderColor = New C1.Win.C1Input.C1ColorPicker()
        Me.clpWeekendForeColor = New C1.Win.C1Input.C1ColorPicker()
        Me.clpDayForeColor = New C1.Win.C1Input.C1ColorPicker()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMonthTitlePosition = New C1.Win.C1Input.C1ComboBox()
        Me.cmbAlignment = New C1.Win.C1Input.C1ComboBox()
        Me.cmbDayTitlePosition = New C1.Win.C1Input.C1ComboBox()
        Me.numMaxSelectionCount = New System.Windows.Forms.NumericUpDown()
        Me.label5 = New System.Windows.Forms.Label()
        Me.numCalendarDimensions = New System.Windows.Forms.NumericUpDown()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cbShowWeekNumbers = New System.Windows.Forms.CheckBox()
        Me.cbVerticalOrientationLayout = New System.Windows.Forms.CheckBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.c1CalendarView1 = New C1.Win.Calendar.C1CalendarView()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.cmbTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpTodayForeColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpTodayBorderColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpWeekendForeColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpDayForeColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.cmbMonthTitlePosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDayTitlePosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaxSelectionCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCalendarDimensions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.groupBox2)
        Me.splitContainer1.Panel1.Controls.Add(Me.groupBox1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.c1CalendarView1)
        Me.splitContainer1.Size = New System.Drawing.Size(918, 539)
        Me.splitContainer1.SplitterDistance = 308
        Me.splitContainer1.TabIndex = 1
        Me.C1ThemeController1.SetTheme(Me.splitContainer1, "(default)")
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.cmbTheme)
        Me.groupBox2.Controls.Add(Me.clpTodayForeColor)
        Me.groupBox2.Controls.Add(Me.clpTodayBorderColor)
        Me.groupBox2.Controls.Add(Me.clpWeekendForeColor)
        Me.groupBox2.Controls.Add(Me.clpDayForeColor)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.groupBox2.Location = New System.Drawing.Point(12, 224)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(289, 153)
        Me.groupBox2.TabIndex = 10
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Styles"
        Me.C1ThemeController1.SetTheme(Me.groupBox2, "(default)")
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label10.Location = New System.Drawing.Point(102, 25)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(43, 13)
        Me.label10.TabIndex = 8
        Me.label10.Text = "Theme:"
        Me.C1ThemeController1.SetTheme(Me.label10, "(default)")
        '
        'cmbTheme
        '
        Me.cmbTheme.AllowSpinLoop = False
        Me.cmbTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbTheme.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.cmbTheme.GapHeight = 0
        Me.cmbTheme.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cmbTheme.ItemsDisplayMember = ""
        Me.cmbTheme.ItemsValueMember = ""
        Me.cmbTheme.Location = New System.Drawing.Point(151, 23)
        Me.cmbTheme.Name = "cmbTheme"
        Me.cmbTheme.Size = New System.Drawing.Size(132, 18)
        Me.cmbTheme.Style.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.cmbTheme.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.cmbTheme.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTheme.TabIndex = 11
        Me.cmbTheme.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.cmbTheme, "(default)")
        Me.cmbTheme.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'clpTodayForeColor
        '
        Me.clpTodayForeColor.AllowEmpty = False
        Me.clpTodayForeColor.Color = System.Drawing.Color.Transparent
        Me.clpTodayForeColor.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.clpTodayForeColor.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.clpTodayForeColor.Location = New System.Drawing.Point(151, 97)
        Me.clpTodayForeColor.Name = "clpTodayForeColor"
        Me.clpTodayForeColor.Size = New System.Drawing.Size(132, 18)
        Me.clpTodayForeColor.TabIndex = 7
        Me.clpTodayForeColor.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.clpTodayForeColor, "(default)")
        Me.clpTodayForeColor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'clpTodayBorderColor
        '
        Me.clpTodayBorderColor.AllowEmpty = False
        Me.clpTodayBorderColor.Color = System.Drawing.Color.Transparent
        Me.clpTodayBorderColor.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.clpTodayBorderColor.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.clpTodayBorderColor.Location = New System.Drawing.Point(151, 121)
        Me.clpTodayBorderColor.Name = "clpTodayBorderColor"
        Me.clpTodayBorderColor.Size = New System.Drawing.Size(132, 18)
        Me.clpTodayBorderColor.TabIndex = 6
        Me.clpTodayBorderColor.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.clpTodayBorderColor, "(default)")
        Me.clpTodayBorderColor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'clpWeekendForeColor
        '
        Me.clpWeekendForeColor.AllowEmpty = False
        Me.clpWeekendForeColor.Color = System.Drawing.Color.Transparent
        Me.clpWeekendForeColor.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.clpWeekendForeColor.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.clpWeekendForeColor.Location = New System.Drawing.Point(151, 73)
        Me.clpWeekendForeColor.Name = "clpWeekendForeColor"
        Me.clpWeekendForeColor.Size = New System.Drawing.Size(132, 18)
        Me.clpWeekendForeColor.TabIndex = 5
        Me.clpWeekendForeColor.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.clpWeekendForeColor, "(default)")
        Me.clpWeekendForeColor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'clpDayForeColor
        '
        Me.clpDayForeColor.AllowEmpty = False
        Me.clpDayForeColor.Color = System.Drawing.Color.Transparent
        Me.clpDayForeColor.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.clpDayForeColor.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.clpDayForeColor.Location = New System.Drawing.Point(151, 49)
        Me.clpDayForeColor.Name = "clpDayForeColor"
        Me.clpDayForeColor.Size = New System.Drawing.Size(132, 18)
        Me.clpDayForeColor.TabIndex = 4
        Me.clpDayForeColor.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.clpDayForeColor, "(default)")
        Me.clpDayForeColor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label9.Location = New System.Drawing.Point(25, 99)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(120, 13)
        Me.label9.TabIndex = 3
        Me.label9.Text = "Today foreground color:"
        Me.C1ThemeController1.SetTheme(Me.label9, "(default)")
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(46, 123)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(99, 13)
        Me.label8.TabIndex = 2
        Me.label8.Text = "Today border color:"
        Me.C1ThemeController1.SetTheme(Me.label8, "(default)")
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(11, 75)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(137, 13)
        Me.label7.TabIndex = 1
        Me.label7.Text = "Weekend foreground color:"
        Me.C1ThemeController1.SetTheme(Me.label7, "(default)")
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(36, 51)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(109, 13)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Day foreground color:"
        Me.C1ThemeController1.SetTheme(Me.label6, "(default)")
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.groupBox1.Controls.Add(Me.cmbMonthTitlePosition)
        Me.groupBox1.Controls.Add(Me.cmbAlignment)
        Me.groupBox1.Controls.Add(Me.cmbDayTitlePosition)
        Me.groupBox1.Controls.Add(Me.numMaxSelectionCount)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.numCalendarDimensions)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.cbShowWeekNumbers)
        Me.groupBox1.Controls.Add(Me.cbVerticalOrientationLayout)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(289, 206)
        Me.groupBox1.TabIndex = 7
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Layout"
        Me.C1ThemeController1.SetTheme(Me.groupBox1, "(default)")
        '
        'cmbMonthTitlePosition
        '
        Me.cmbMonthTitlePosition.AllowSpinLoop = False
        Me.cmbMonthTitlePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbMonthTitlePosition.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.cmbMonthTitlePosition.GapHeight = 0
        Me.cmbMonthTitlePosition.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cmbMonthTitlePosition.Items.Add("Top")
        Me.cmbMonthTitlePosition.Items.Add("Bottom")
        Me.cmbMonthTitlePosition.Items.Add("Left")
        Me.cmbMonthTitlePosition.Items.Add("Right")
        Me.cmbMonthTitlePosition.ItemsDisplayMember = ""
        Me.cmbMonthTitlePosition.ItemsValueMember = ""
        Me.cmbMonthTitlePosition.Location = New System.Drawing.Point(115, 50)
        Me.cmbMonthTitlePosition.Name = "cmbMonthTitlePosition"
        Me.cmbMonthTitlePosition.Size = New System.Drawing.Size(166, 18)
        Me.cmbMonthTitlePosition.Style.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.cmbMonthTitlePosition.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.cmbMonthTitlePosition.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonthTitlePosition.TabIndex = 15
        Me.cmbMonthTitlePosition.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.cmbMonthTitlePosition, "(default)")
        Me.cmbMonthTitlePosition.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'cmbAlignment
        '
        Me.cmbAlignment.AllowSpinLoop = False
        Me.cmbAlignment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbAlignment.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.cmbAlignment.GapHeight = 0
        Me.cmbAlignment.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cmbAlignment.Items.Add("NotSet")
        Me.cmbAlignment.Items.Add("Near")
        Me.cmbAlignment.Items.Add("Far")
        Me.cmbAlignment.Items.Add("Center")
        Me.cmbAlignment.Items.Add("Spread")
        Me.cmbAlignment.ItemsDisplayMember = ""
        Me.cmbAlignment.ItemsValueMember = ""
        Me.cmbAlignment.Location = New System.Drawing.Point(115, 100)
        Me.cmbAlignment.Name = "cmbAlignment"
        Me.cmbAlignment.Size = New System.Drawing.Size(166, 18)
        Me.cmbAlignment.Style.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.cmbAlignment.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.cmbAlignment.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAlignment.TabIndex = 15
        Me.cmbAlignment.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.cmbAlignment, "(default)")
        Me.cmbAlignment.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'cmbDayTitlePosition
        '
        Me.cmbDayTitlePosition.AllowSpinLoop = False
        Me.cmbDayTitlePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbDayTitlePosition.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.cmbDayTitlePosition.GapHeight = 0
        Me.cmbDayTitlePosition.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cmbDayTitlePosition.Items.Add("Top")
        Me.cmbDayTitlePosition.Items.Add("Bottom")
        Me.cmbDayTitlePosition.Items.Add("Left")
        Me.cmbDayTitlePosition.Items.Add("Right")
        Me.cmbDayTitlePosition.ItemsDisplayMember = ""
        Me.cmbDayTitlePosition.ItemsValueMember = ""
        Me.cmbDayTitlePosition.Location = New System.Drawing.Point(115, 23)
        Me.cmbDayTitlePosition.Name = "cmbDayTitlePosition"
        Me.cmbDayTitlePosition.Size = New System.Drawing.Size(167, 18)
        Me.cmbDayTitlePosition.Style.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.cmbDayTitlePosition.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.cmbDayTitlePosition.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDayTitlePosition.TabIndex = 14
        Me.cmbDayTitlePosition.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.cmbDayTitlePosition, "(default)")
        Me.cmbDayTitlePosition.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'numMaxSelectionCount
        '
        Me.numMaxSelectionCount.BackColor = System.Drawing.Color.White
        Me.numMaxSelectionCount.ForeColor = System.Drawing.Color.Black
        Me.numMaxSelectionCount.Location = New System.Drawing.Point(115, 175)
        Me.numMaxSelectionCount.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numMaxSelectionCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMaxSelectionCount.Name = "numMaxSelectionCount"
        Me.numMaxSelectionCount.Size = New System.Drawing.Size(44, 20)
        Me.numMaxSelectionCount.TabIndex = 13
        Me.C1ThemeController1.SetTheme(Me.numMaxSelectionCount, "(default)")
        Me.numMaxSelectionCount.Value = New Decimal(New Integer() {14, 0, 0, 0})
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(4, 177)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(105, 13)
        Me.label5.TabIndex = 12
        Me.label5.Text = "Max selection count:"
        Me.C1ThemeController1.SetTheme(Me.label5, "(default)")
        '
        'numCalendarDimensions
        '
        Me.numCalendarDimensions.BackColor = System.Drawing.Color.White
        Me.numCalendarDimensions.ForeColor = System.Drawing.Color.Black
        Me.numCalendarDimensions.Location = New System.Drawing.Point(115, 149)
        Me.numCalendarDimensions.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numCalendarDimensions.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCalendarDimensions.Name = "numCalendarDimensions"
        Me.numCalendarDimensions.Size = New System.Drawing.Size(44, 20)
        Me.numCalendarDimensions.TabIndex = 9
        Me.C1ThemeController1.SetTheme(Me.numCalendarDimensions, "(default)")
        Me.numCalendarDimensions.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(45, 151)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(64, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Dimensions:"
        Me.C1ThemeController1.SetTheme(Me.label4, "(default)")
        '
        'cbShowWeekNumbers
        '
        Me.cbShowWeekNumbers.AutoSize = True
        Me.cbShowWeekNumbers.BackColor = System.Drawing.Color.Transparent
        Me.cbShowWeekNumbers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cbShowWeekNumbers.Location = New System.Drawing.Point(98, 126)
        Me.cbShowWeekNumbers.Name = "cbShowWeekNumbers"
        Me.cbShowWeekNumbers.Size = New System.Drawing.Size(125, 17)
        Me.cbShowWeekNumbers.TabIndex = 8
        Me.cbShowWeekNumbers.Text = "Show week numbers"
        Me.C1ThemeController1.SetTheme(Me.cbShowWeekNumbers, "(default)")
        Me.cbShowWeekNumbers.UseVisualStyleBackColor = False
        '
        'cbVerticalOrientationLayout
        '
        Me.cbVerticalOrientationLayout.AutoSize = True
        Me.cbVerticalOrientationLayout.BackColor = System.Drawing.Color.Transparent
        Me.cbVerticalOrientationLayout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cbVerticalOrientationLayout.Location = New System.Drawing.Point(98, 76)
        Me.cbVerticalOrientationLayout.Name = "cbVerticalOrientationLayout"
        Me.cbVerticalOrientationLayout.Size = New System.Drawing.Size(144, 17)
        Me.cbVerticalOrientationLayout.TabIndex = 7
        Me.cbVerticalOrientationLayout.Text = "Vertical orientation layout"
        Me.C1ThemeController1.SetTheme(Me.cbVerticalOrientationLayout, "(default)")
        Me.cbVerticalOrientationLayout.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(22, 25)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(87, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Day title position:"
        Me.C1ThemeController1.SetTheme(Me.label2, "(default)")
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(53, 102)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Alignment:"
        Me.C1ThemeController1.SetTheme(Me.label3, "(default)")
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(11, 52)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(98, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Month title position:"
        Me.C1ThemeController1.SetTheme(Me.label1, "(default)")
        '
        'c1CalendarView1
        '
        Me.c1CalendarView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1CalendarView1.FirstDayOfWeek = System.DayOfWeek.Sunday
        Me.c1CalendarView1.Location = New System.Drawing.Point(0, 0)
        Me.c1CalendarView1.MaxDate = New Date(9999, 12, 31, 0, 0, 0, 0)
        Me.c1CalendarView1.MinDate = New Date(CType(0, Long))
        Me.c1CalendarView1.Name = "c1CalendarView1"
        Me.c1CalendarView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.c1CalendarView1.Size = New System.Drawing.Size(606, 539)
        Me.c1CalendarView1.TabIndex = 0
        Me.c1CalendarView1.Text = "c1CalendarView1"
        Me.c1CalendarView1.Theme.Common.BackColor = System.Drawing.Color.White
        Me.c1CalendarView1.Theme.Common.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.c1CalendarView1.Theme.Day.Bolded.ForeColor = System.Drawing.Color.Black
        Me.c1CalendarView1.Theme.Day.Bolded.VerticalAlignment = C1.Framework.Alignment.Far
        Me.c1CalendarView1.Theme.Day.Disabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.c1CalendarView1.Theme.Day.Disabled.VerticalAlignment = C1.Framework.Alignment.Far
        Me.c1CalendarView1.Theme.Day.Weekend.ForeColor = System.Drawing.Color.Black
        Me.c1CalendarView1.Theme.Day.Weekend.VerticalAlignment = C1.Framework.Alignment.Far
        Me.c1CalendarView1.Theme.Day.Ordinary.ForeColor = System.Drawing.Color.Black
        Me.c1CalendarView1.Theme.Day.Ordinary.VerticalAlignment = C1.Framework.Alignment.Far
        Me.c1CalendarView1.Theme.Day.Selected.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.c1CalendarView1.Theme.Day.Selected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.c1CalendarView1.Theme.Day.Selected.VerticalAlignment = C1.Framework.Alignment.Far
        Me.c1CalendarView1.Theme.Day.Today.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.c1CalendarView1.Theme.Day.Today.ForeColor = System.Drawing.Color.Black
        Me.c1CalendarView1.Theme.Day.Today.VerticalAlignment = C1.Framework.Alignment.Far
        Me.c1CalendarView1.Theme.NavigationButtons.ArrowNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.c1CalendarView1.Theme.NavigationButtons.ArrowPrevious.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.c1CalendarView1.Theme.Titles.Day.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.c1CalendarView1.Theme.Titles.Day.ForeColor = System.Drawing.Color.Black
        Me.c1CalendarView1.Theme.Titles.Month.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.c1CalendarView1.Theme.Titles.Month.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.c1CalendarView1.Theme.Titles.Month.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.c1CalendarView1.Theme.Titles.Month.Margins = New C1.Framework.Thickness(0, 4, 0, 0)
        Me.c1CalendarView1.Theme.Titles.Month.Padding = New C1.Framework.Thickness(0, 0, 1, 0)
        Me.c1CalendarView1.Theme.Titles.Week.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.c1CalendarView1.Theme.Titles.Week.ForeColor = System.Drawing.Color.Black
        Me.c1CalendarView1.Theme.Titles.Week.HorizontalAlignment = C1.Framework.Alignment.Far
        Me.C1ThemeController1.SetTheme(Me.c1CalendarView1, "(default)")
        '
        'C1ThemeController1
        '
        Me.C1ThemeController1.Theme = "VS2013Light"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 539)
        Me.Controls.Add(Me.splitContainer1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.cmbTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpTodayForeColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpTodayBorderColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpWeekendForeColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpDayForeColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.cmbMonthTitlePosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAlignment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDayTitlePosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaxSelectionCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCalendarDimensions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents numCalendarDimensions As NumericUpDown
    Private WithEvents label4 As Label
    Private WithEvents cbShowWeekNumbers As CheckBox
    Private WithEvents cbVerticalOrientationLayout As CheckBox
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents c1CalendarView1 As C1.Win.Calendar.C1CalendarView
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label10 As Label
    Friend WithEvents cmbTheme As C1.Win.C1Input.C1ComboBox
    Private WithEvents clpTodayForeColor As C1.Win.C1Input.C1ColorPicker
    Private WithEvents clpTodayBorderColor As C1.Win.C1Input.C1ColorPicker
    Private WithEvents clpWeekendForeColor As C1.Win.C1Input.C1ColorPicker
    Private WithEvents clpDayForeColor As C1.Win.C1Input.C1ColorPicker
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents numMaxSelectionCount As NumericUpDown
    Private WithEvents label5 As Label
    Private WithEvents cmbMonthTitlePosition As C1.Win.C1Input.C1ComboBox
    Private WithEvents cmbAlignment As C1.Win.C1Input.C1ComboBox
    Private WithEvents cmbDayTitlePosition As C1.Win.C1Input.C1ComboBox
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
End Class
