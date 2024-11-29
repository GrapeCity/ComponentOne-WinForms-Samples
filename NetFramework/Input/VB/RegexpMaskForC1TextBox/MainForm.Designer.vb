Imports C1.Win.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits C1RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.C1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.RibbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.cmbThemes = New C1.Win.Ribbon.RibbonComboBox()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.c1Label11 = New C1.Win.C1Input.C1Label()
        Me.c1ComboBox2 = New C1.Win.C1Input.C1ComboBox()
        Me.c1Label10 = New C1.Win.C1Input.C1Label()
        Me.c1ComboBox1 = New C1.Win.C1Input.C1ComboBox()
        Me.c1Button4 = New C1.Win.C1Input.C1Button()
        Me.c1Button3 = New C1.Win.C1Input.C1Button()
        Me.c1Button2 = New C1.Win.C1Input.C1Button()
        Me.c1Label8 = New C1.Win.C1Input.C1Label()
        Me.c1Label6 = New C1.Win.C1Input.C1Label()
        Me.c1Label5 = New C1.Win.C1Input.C1Label()
        Me.c1Button1 = New C1.Win.C1Input.C1Button()
        Me.c1Label4 = New C1.Win.C1Input.C1Label()
        Me.c1Label3 = New C1.Win.C1Input.C1Label()
        Me.c1Label2 = New C1.Win.C1Input.C1Label()
        Me.c1Label1 = New C1.Win.C1Input.C1Label()
        Me.c1TextBox4 = New C1.Win.C1Input.C1TextBox()
        Me.c1TextBox3 = New C1.Win.C1Input.C1TextBox()
        Me.c1TextBox2 = New C1.Win.C1Input.C1TextBox()
        Me.c1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.c1Label7 = New C1.Win.C1Input.C1Label()
        Me.C1Label9 = New C1.Win.C1Input.C1Label()
        Me.C1Label12 = New C1.Win.C1Input.C1Label()
        Me.C1Label13 = New C1.Win.C1Input.C1Label()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1ComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Button4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.HideTabHeaderRow = True
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(1165, 42)
        Me.C1ThemeController1.SetTheme(Me.C1Ribbon1, "(default)")
        Me.C1Ribbon1.TopToolBarHolder = Me.RibbonTopToolBar1
        Me.C1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
        Me.RibbonApplicationMenu1.Visible = False
        '
        'RibbonBottomToolBar1
        '
        Me.RibbonBottomToolBar1.Name = "RibbonBottomToolBar1"
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.Name = "RibbonConfigToolBar1"
        '
        'RibbonQat1
        '
        Me.RibbonQat1.Name = "RibbonQat1"
        Me.RibbonQat1.Visible = False
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Items.Add(Me.cmbThemes)
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'cmbThemes
        '
        Me.cmbThemes.Label = "Theme"
        Me.cmbThemes.Name = "cmbThemes"
        Me.cmbThemes.TextAreaWidth = 100
        '
        'c1Label11
        '
        Me.c1Label11.AutoSize = True
        Me.c1Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label11.Location = New System.Drawing.Point(616, 547)
        Me.c1Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c1Label11.Name = "c1Label11"
        Me.c1Label11.Size = New System.Drawing.Size(124, 20)
        Me.c1Label11.TabIndex = 21
        Me.c1Label11.Tag = Nothing
        Me.c1Label11.Text = "Sample masks:"
        Me.c1Label11.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label11, "(default)")
        Me.c1Label11.Value = "Sample masks:"
        '
        'c1ComboBox2
        '
        Me.c1ComboBox2.AllowSpinLoop = False
        Me.c1ComboBox2.AutoSize = False
        Me.c1ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.c1ComboBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1ComboBox2.DropDownWidth = -1
        Me.c1ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1ComboBox2.GapHeight = 0
        Me.c1ComboBox2.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1ComboBox2.Items.Add("[a-z]*-[0-9]?")
        Me.c1ComboBox2.Items.Add("\K{3,5}")
        Me.c1ComboBox2.Items.Add("\+\Ｄ-\(\Ｄ{3}\)-\Ｄ{3}-\Ｄ{2}-\Ｄ{2}")
        Me.c1ComboBox2.Items.Add("([\D]-[A-Z]{3})?")
        Me.c1ComboBox2.Items.Add("[^a-z\W]{3,}")
        Me.c1ComboBox2.Items.Add("\D\A+")
        Me.c1ComboBox2.Items.Add("\Ｊ|\Ｔ")
        Me.c1ComboBox2.Items.Add("[a-z]{5}-[0-9]{3}")
        Me.c1ComboBox2.Location = New System.Drawing.Point(806, 541)
        Me.c1ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.c1ComboBox2.Name = "c1ComboBox2"
        Me.c1ComboBox2.Size = New System.Drawing.Size(333, 30)
        Me.c1ComboBox2.TabIndex = 6
        Me.c1ComboBox2.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.c1ComboBox2, "(default)")
        Me.c1ComboBox2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Label10
        '
        Me.c1Label10.AutoSize = True
        Me.c1Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label10.Location = New System.Drawing.Point(28, 547)
        Me.c1Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c1Label10.Name = "c1Label10"
        Me.c1Label10.Size = New System.Drawing.Size(124, 20)
        Me.c1Label10.TabIndex = 19
        Me.c1Label10.Tag = Nothing
        Me.c1Label10.Text = "Sample masks:"
        Me.c1Label10.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label10, "(default)")
        Me.c1Label10.Value = "Sample masks:"
        '
        'c1ComboBox1
        '
        Me.c1ComboBox1.AllowSpinLoop = False
        Me.c1ComboBox1.AutoSize = False
        Me.c1ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.c1ComboBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1ComboBox1.DropDownWidth = -1
        Me.c1ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1ComboBox1.GapHeight = 0
        Me.c1ComboBox1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1ComboBox1.Items.Add("[a-z]*-[0-9]?")
        Me.c1ComboBox1.Items.Add("\K{3,5}")
        Me.c1ComboBox1.Items.Add("\+\Ｄ-\(\Ｄ{3}\)-\Ｄ{3}-\Ｄ{2}-\Ｄ{2}")
        Me.c1ComboBox1.Items.Add("([\D]-[A-Z]{3})?")
        Me.c1ComboBox1.Items.Add("[^a-z\W]{3,}")
        Me.c1ComboBox1.Items.Add("\D\A+")
        Me.c1ComboBox1.Items.Add("\Ｊ|\Ｔ")
        Me.c1ComboBox1.Items.Add("^[a-zA-Z0-9]{8,10}$")
        Me.c1ComboBox1.Items.Add("\p{Lu}+")
        Me.c1ComboBox1.Items.Add("\p{IsKatakana}{3,5}")
        Me.c1ComboBox1.Items.Add("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Me.c1ComboBox1.Location = New System.Drawing.Point(214, 542)
        Me.c1ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.c1ComboBox1.Name = "c1ComboBox1"
        Me.c1ComboBox1.Size = New System.Drawing.Size(333, 30)
        Me.c1ComboBox1.TabIndex = 1
        Me.c1ComboBox1.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.c1ComboBox1, "(default)")
        Me.c1ComboBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Button4
        '
        Me.c1Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Button4.Location = New System.Drawing.Point(806, 681)
        Me.c1Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.c1Button4.Name = "c1Button4"
        Me.c1Button4.Size = New System.Drawing.Size(333, 30)
        Me.c1Button4.TabIndex = 9
        Me.c1Button4.Text = "Copy from RegexpMask"
        Me.C1ThemeController1.SetTheme(Me.c1Button4, "(default)")
        Me.c1Button4.UseVisualStyleBackColor = True
        Me.c1Button4.UseVisualStyleForeColor = True
        Me.c1Button4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Button3
        '
        Me.c1Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Button3.Location = New System.Drawing.Point(214, 681)
        Me.c1Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.c1Button3.Name = "c1Button3"
        Me.c1Button3.Size = New System.Drawing.Size(333, 30)
        Me.c1Button3.TabIndex = 4
        Me.c1Button3.Text = "Copy from C1RegexpEditMask"
        Me.C1ThemeController1.SetTheme(Me.c1Button3, "(default)")
        Me.c1Button3.UseVisualStyleBackColor = True
        Me.c1Button3.UseVisualStyleForeColor = True
        Me.c1Button3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Button2
        '
        Me.c1Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Button2.Location = New System.Drawing.Point(806, 636)
        Me.c1Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.c1Button2.Name = "c1Button2"
        Me.c1Button2.Size = New System.Drawing.Size(333, 30)
        Me.c1Button2.TabIndex = 8
        Me.c1Button2.Text = "Apply new mask"
        Me.C1ThemeController1.SetTheme(Me.c1Button2, "(default)")
        Me.c1Button2.UseVisualStyleBackColor = True
        Me.c1Button2.UseVisualStyleForeColor = True
        Me.c1Button2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Label8
        '
        Me.c1Label8.AutoSize = True
        Me.c1Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label8.Location = New System.Drawing.Point(616, 620)
        Me.c1Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c1Label8.Name = "c1Label8"
        Me.c1Label8.Size = New System.Drawing.Size(92, 20)
        Me.c1Label8.TabIndex = 12
        Me.c1Label8.Tag = Nothing
        Me.c1Label8.Text = "New mask:"
        Me.c1Label8.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label8, "(default)")
        Me.c1Label8.Value = "New mask:"
        '
        'c1Label6
        '
        Me.c1Label6.AutoSize = True
        Me.c1Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label6.Location = New System.Drawing.Point(616, 507)
        Me.c1Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c1Label6.Name = "c1Label6"
        Me.c1Label6.Size = New System.Drawing.Size(115, 20)
        Me.c1Label6.TabIndex = 10
        Me.c1Label6.Tag = Nothing
        Me.c1Label6.Text = "Current mask:"
        Me.c1Label6.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label6, "(default)")
        Me.c1Label6.Value = "Current mask:"
        '
        'c1Label5
        '
        Me.c1Label5.AutoSize = True
        Me.c1Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label5.Location = New System.Drawing.Point(616, 427)
        Me.c1Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c1Label5.Name = "c1Label5"
        Me.c1Label5.Size = New System.Drawing.Size(308, 20)
        Me.c1Label5.TabIndex = 9
        Me.c1Label5.Tag = Nothing
        Me.c1Label5.Text = "C1TextBox with C1RegexpEditMask"
        Me.c1Label5.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label5, "(default)")
        Me.c1Label5.Value = "C1TextBox with C1RegexpEditMask"
        '
        'c1Button1
        '
        Me.c1Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Button1.Location = New System.Drawing.Point(214, 636)
        Me.c1Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.c1Button1.Name = "c1Button1"
        Me.c1Button1.Size = New System.Drawing.Size(333, 30)
        Me.c1Button1.TabIndex = 3
        Me.c1Button1.Text = "Apply new mask"
        Me.C1ThemeController1.SetTheme(Me.c1Button1, "(default)")
        Me.c1Button1.UseVisualStyleBackColor = True
        Me.c1Button1.UseVisualStyleForeColor = True
        Me.c1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Label4
        '
        Me.c1Label4.AutoSize = True
        Me.c1Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label4.Location = New System.Drawing.Point(28, 593)
        Me.c1Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c1Label4.Name = "c1Label4"
        Me.c1Label4.Size = New System.Drawing.Size(92, 20)
        Me.c1Label4.TabIndex = 7
        Me.c1Label4.Tag = Nothing
        Me.c1Label4.Text = "New mask:"
        Me.c1Label4.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label4, "(default)")
        Me.c1Label4.Value = "New mask:"
        '
        'c1Label3
        '
        Me.c1Label3.AutoSize = True
        Me.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label3.Location = New System.Drawing.Point(28, 507)
        Me.c1Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c1Label3.Name = "c1Label3"
        Me.c1Label3.Size = New System.Drawing.Size(115, 20)
        Me.c1Label3.TabIndex = 6
        Me.c1Label3.Tag = Nothing
        Me.c1Label3.Text = "Current mask:"
        Me.c1Label3.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label3, "(default)")
        Me.c1Label3.Value = "Current mask:"
        '
        'c1Label2
        '
        Me.c1Label2.AutoSize = True
        Me.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label2.Location = New System.Drawing.Point(214, 507)
        Me.c1Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c1Label2.Name = "c1Label2"
        Me.c1Label2.Size = New System.Drawing.Size(77, 20)
        Me.c1Label2.TabIndex = 5
        Me.c1Label2.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.c1Label2, "(default)")
        Me.c1Label2.Value = "[0-9]{3}-[0-9]{3}"
        '
        'c1Label1
        '
        Me.c1Label1.AutoSize = True
        Me.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label1.Location = New System.Drawing.Point(28, 427)
        Me.c1Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c1Label1.Name = "c1Label1"
        Me.c1Label1.Size = New System.Drawing.Size(252, 20)
        Me.c1Label1.TabIndex = 4
        Me.c1Label1.Tag = Nothing
        Me.c1Label1.Text = "C1TextBox with RegexpMask"
        Me.c1Label1.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label1, "(default)")
        Me.c1Label1.Value = "C1TextBox with RegexpMask"
        '
        'c1TextBox4
        '
        Me.c1TextBox4.AutoSize = False
        Me.c1TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.c1TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1TextBox4.Location = New System.Drawing.Point(806, 590)
        Me.c1TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.c1TextBox4.Name = "c1TextBox4"
        Me.c1TextBox4.Size = New System.Drawing.Size(333, 30)
        Me.c1TextBox4.TabIndex = 7
        Me.c1TextBox4.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.c1TextBox4, "(default)")
        Me.c1TextBox4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1TextBox3
        '
        Me.c1TextBox3.AutoSize = False
        Me.c1TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.c1TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1TextBox3.Location = New System.Drawing.Point(214, 590)
        Me.c1TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.c1TextBox3.Name = "c1TextBox3"
        Me.c1TextBox3.Size = New System.Drawing.Size(333, 30)
        Me.c1TextBox3.TabIndex = 2
        Me.c1TextBox3.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.c1TextBox3, "(default)")
        Me.c1TextBox3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1TextBox2
        '
        Me.c1TextBox2.AutoSize = False
        Me.c1TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.c1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1TextBox2.Location = New System.Drawing.Point(616, 457)
        Me.c1TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.c1TextBox2.MaskInfo.RegexpEditMask = "[0-9]{3}-[0-9]{3}"
        Me.c1TextBox2.MaskInfo.RegexpMaskType = C1.Win.C1Input.RegexpMaskType.C1RegexpEditMask
        Me.c1TextBox2.MaskInfo.ShowLiterals = C1.Win.C1Input.ShowLiteralsEnum.FreeFormatEntry
        Me.c1TextBox2.Name = "c1TextBox2"
        Me.c1TextBox2.Size = New System.Drawing.Size(520, 30)
        Me.c1TextBox2.TabIndex = 5
        Me.c1TextBox2.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.c1TextBox2, "(default)")
        Me.c1TextBox2.Value = ""
        Me.c1TextBox2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1TextBox1
        '
        Me.c1TextBox1.AutoSize = False
        Me.c1TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1TextBox1.Location = New System.Drawing.Point(28, 457)
        Me.c1TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.c1TextBox1.MaskInfo.RegexpEditMask = "[0-9]{3}-[0-9]{3}"
        Me.c1TextBox1.MaskInfo.ShowLiterals = C1.Win.C1Input.ShowLiteralsEnum.FreeFormatEntry
        Me.c1TextBox1.Name = "c1TextBox1"
        Me.c1TextBox1.Size = New System.Drawing.Size(520, 30)
        Me.c1TextBox1.TabIndex = 0
        Me.c1TextBox1.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.c1TextBox1, "(default)")
        Me.c1TextBox1.Value = ""
        Me.c1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkLabel1.Location = New System.Drawing.Point(24, 368)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(473, 20)
        Me.linkLabel1.TabIndex = 25
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "Custom keywords in regular expressions and their description."
        Me.C1ThemeController1.SetTheme(Me.linkLabel1, "(default)")
        '
        'c1Label7
        '
        Me.c1Label7.AutoSize = True
        Me.c1Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label7.Location = New System.Drawing.Point(806, 505)
        Me.c1Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.c1Label7.Name = "c1Label7"
        Me.c1Label7.Size = New System.Drawing.Size(77, 20)
        Me.c1Label7.TabIndex = 11
        Me.c1Label7.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.c1Label7, "(default)")
        Me.c1Label7.Value = "[0-9]{3}-[0-9]{3}"
        '
        'C1Label9
        '
        Me.C1Label9.AutoSize = True
        Me.C1Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.C1Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C1Label9.Location = New System.Drawing.Point(28, 46)
        Me.C1Label9.Name = "C1Label9"
        Me.C1Label9.Size = New System.Drawing.Size(886, 40)
        Me.C1Label9.TabIndex = 27
        Me.C1Label9.Tag = Nothing
        Me.C1Label9.Text = resources.GetString("C1Label9.Text")
        Me.C1Label9.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.C1Label9, "(default)")
        Me.C1Label9.Value = resources.GetString("C1Label9.Value")
        '
        'C1Label12
        '
        Me.C1Label12.AutoSize = True
        Me.C1Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.C1Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C1Label12.Location = New System.Drawing.Point(28, 116)
        Me.C1Label12.Name = "C1Label12"
        Me.C1Label12.Size = New System.Drawing.Size(502, 240)
        Me.C1Label12.TabIndex = 28
        Me.C1Label12.Tag = Nothing
        Me.C1Label12.Text = resources.GetString("C1Label12.Text")
        Me.C1Label12.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.C1Label12, "(default)")
        '
        'C1Label13
        '
        Me.C1Label13.AutoSize = True
        Me.C1Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.C1Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C1Label13.Location = New System.Drawing.Point(616, 116)
        Me.C1Label13.Name = "C1Label13"
        Me.C1Label13.Size = New System.Drawing.Size(454, 200)
        Me.C1Label13.TabIndex = 29
        Me.C1Label13.Tag = Nothing
        Me.C1Label13.Text = resources.GetString("C1Label13.Text")
        Me.C1Label13.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.C1Label13, "(default)")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 740)
        Me.Controls.Add(Me.C1Label13)
        Me.Controls.Add(Me.C1Label12)
        Me.Controls.Add(Me.C1Label9)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Controls.Add(Me.c1Label11)
        Me.Controls.Add(Me.c1ComboBox2)
        Me.Controls.Add(Me.c1Label10)
        Me.Controls.Add(Me.c1ComboBox1)
        Me.Controls.Add(Me.c1Button4)
        Me.Controls.Add(Me.c1Button3)
        Me.Controls.Add(Me.c1Button2)
        Me.Controls.Add(Me.c1Label8)
        Me.Controls.Add(Me.c1Label7)
        Me.Controls.Add(Me.c1Label6)
        Me.Controls.Add(Me.c1Label5)
        Me.Controls.Add(Me.c1Button1)
        Me.Controls.Add(Me.c1Label4)
        Me.Controls.Add(Me.c1Label3)
        Me.Controls.Add(Me.c1Label2)
        Me.Controls.Add(Me.c1Label1)
        Me.Controls.Add(Me.c1TextBox4)
        Me.Controls.Add(Me.c1TextBox3)
        Me.Controls.Add(Me.c1TextBox2)
        Me.Controls.Add(Me.c1TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "RegexpMaskForC1TextBox"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1ComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Button4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.Ribbon.RibbonQat
    Friend WithEvents RibbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents cmbThemes As RibbonComboBox

    Friend WithEvents c1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1TextBox2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1TextBox3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1TextBox4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1Label1 As C1.Win.C1Input.C1Label
    Friend WithEvents c1Label2 As C1.Win.C1Input.C1Label
    Friend WithEvents c1Label3 As C1.Win.C1Input.C1Label
    Friend WithEvents c1Label4 As C1.Win.C1Input.C1Label
    Friend WithEvents c1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents c1Label5 As C1.Win.C1Input.C1Label
    Friend WithEvents c1Label6 As C1.Win.C1Input.C1Label
    Friend WithEvents c1Label7 As C1.Win.C1Input.C1Label
    Friend WithEvents c1Label8 As C1.Win.C1Input.C1Label
    Friend WithEvents c1Button2 As C1.Win.C1Input.C1Button
    Friend WithEvents c1Button3 As C1.Win.C1Input.C1Button
    Friend WithEvents c1Button4 As C1.Win.C1Input.C1Button
    Friend WithEvents c1ComboBox1 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents c1Label10 As C1.Win.C1Input.C1Label
    Friend WithEvents c1Label11 As C1.Win.C1Input.C1Label
    Friend WithEvents c1ComboBox2 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents C1Label9 As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label12 As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label13 As C1.Win.C1Input.C1Label
End Class
