Partial Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnAdd = New C1.Win.C1Input.C1Button()
        Me.btnRemove = New C1.Win.C1Input.C1Button()
        Me.btnSetAsApplicationTheme = New C1.Win.C1Input.C1Button()
        Me.c1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        Me.c1Label1 = New C1.Win.C1Input.C1Label()
        Me.tbApplicationTheme = New C1.Win.C1Input.C1TextBox()
        Me.ctdbgThemes = New C1.Win.TrueDBGrid.C1TrueDBGrid()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.C1Label2 = New C1.Win.C1Input.C1Label()
        Me.C1Label3 = New C1.Win.C1Input.C1Label()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbApplicationTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctdbgThemes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnAdd.Location = New System.Drawing.Point(101, 352)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add..."
        Me.c1ThemeController1.SetTheme(Me.btnAdd, "(default)")
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnRemove.Location = New System.Drawing.Point(101, 381)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.c1ThemeController1.SetTheme(Me.btnRemove, "(default)")
        Me.btnRemove.UseVisualStyleBackColor = True
        Me.btnRemove.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnSetAsApplicationTheme
        '
        Me.btnSetAsApplicationTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSetAsApplicationTheme.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSetAsApplicationTheme.Location = New System.Drawing.Point(101, 323)
        Me.btnSetAsApplicationTheme.Name = "btnSetAsApplicationTheme"
        Me.btnSetAsApplicationTheme.Size = New System.Drawing.Size(75, 23)
        Me.btnSetAsApplicationTheme.TabIndex = 5
        Me.btnSetAsApplicationTheme.Text = "Apply"
        Me.c1ThemeController1.SetTheme(Me.btnSetAsApplicationTheme, "(default)")
        Me.btnSetAsApplicationTheme.UseVisualStyleBackColor = True
        Me.btnSetAsApplicationTheme.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Label1
        '
        Me.c1Label1.AutoSize = True
        Me.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.c1Label1.ForeColor = System.Drawing.Color.Black
        Me.c1Label1.Location = New System.Drawing.Point(12, 9)
        Me.c1Label1.Name = "c1Label1"
        Me.c1Label1.Size = New System.Drawing.Size(83, 16)
        Me.c1Label1.TabIndex = 0
        Me.c1Label1.Tag = Nothing
        Me.c1Label1.Text = "Current theme:"
        Me.c1Label1.TextDetached = True
        Me.c1ThemeController1.SetTheme(Me.c1Label1, "(default)")
        Me.c1Label1.UseCompatibleTextRendering = True
        '
        'tbApplicationTheme
        '
        Me.tbApplicationTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbApplicationTheme.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.tbApplicationTheme.Location = New System.Drawing.Point(101, 7)
        Me.tbApplicationTheme.Name = "tbApplicationTheme"
        Me.tbApplicationTheme.ReadOnly = True
        Me.tbApplicationTheme.Size = New System.Drawing.Size(224, 20)
        Me.tbApplicationTheme.TabIndex = 1
        Me.tbApplicationTheme.Tag = Nothing
        Me.c1ThemeController1.SetTheme(Me.tbApplicationTheme, "(default)")
        Me.tbApplicationTheme.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ctdbgThemes
        '
        Me.ctdbgThemes.AllowColMove = False
        Me.ctdbgThemes.AllowUpdate = False
        Me.ctdbgThemes.AlternatingRows = True
        Me.ctdbgThemes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctdbgThemes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctdbgThemes.CaptionHeight = 17
        Me.ctdbgThemes.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ctdbgThemes.ForeColor = System.Drawing.Color.Black
        Me.ctdbgThemes.GroupByCaption = "Drag a column header here to group by that column"
        Me.ctdbgThemes.Images.Add(CType(resources.GetObject("ctdbgThemes.Images"), System.Drawing.Image))
        Me.ctdbgThemes.Location = New System.Drawing.Point(12, 49)
        Me.ctdbgThemes.Name = "ctdbgThemes"
        Me.ctdbgThemes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.ctdbgThemes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.ctdbgThemes.PreviewInfo.ZoomFactor = 75.0R
        Me.ctdbgThemes.PrintInfo.PageSettings = CType(resources.GetObject("ctdbgThemes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.ctdbgThemes.RowDivider.Color = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ctdbgThemes.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.[Single]
        Me.ctdbgThemes.RowHeight = 15
        Me.ctdbgThemes.RowSubDividerColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ctdbgThemes.Size = New System.Drawing.Size(311, 265)
        Me.ctdbgThemes.TabIndex = 3
        Me.ctdbgThemes.Text = "c1TrueDBGrid1"
        Me.c1ThemeController1.SetTheme(Me.ctdbgThemes, "(default)")
        Me.ctdbgThemes.PropBag = resources.GetString("ctdbgThemes.PropBag")
        '
        'openFileDialog1
        '
        Me.openFileDialog1.DefaultExt = "c1theme"
        Me.openFileDialog1.FileName = "openFileDialog1"
        Me.openFileDialog1.Filter = "C1Theme files (*.c1theme)|*.c1theme|All files (*.*)|*.*"
        Me.openFileDialog1.Title = "Select Theme"
        '
        'C1Label2
        '
        Me.C1Label2.AutoSize = True
        Me.C1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.C1Label2.ForeColor = System.Drawing.Color.Black
        Me.C1Label2.Location = New System.Drawing.Point(12, 30)
        Me.C1Label2.Name = "C1Label2"
        Me.C1Label2.Size = New System.Drawing.Size(95, 16)
        Me.C1Label2.TabIndex = 2
        Me.C1Label2.Tag = Nothing
        Me.C1Label2.Text = "Available themes:"
        Me.C1Label2.TextDetached = True
        Me.c1ThemeController1.SetTheme(Me.C1Label2, "(default)")
        Me.C1Label2.UseCompatibleTextRendering = True
        '
        'C1Label3
        '
        Me.C1Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.C1Label3.AutoSize = True
        Me.C1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.C1Label3.ForeColor = System.Drawing.Color.Black
        Me.C1Label3.Location = New System.Drawing.Point(12, 328)
        Me.C1Label3.Name = "C1Label3"
        Me.C1Label3.Size = New System.Drawing.Size(83, 16)
        Me.C1Label3.TabIndex = 4
        Me.C1Label3.Tag = Nothing
        Me.C1Label3.Text = "Theme actions:"
        Me.C1Label3.TextDetached = True
        Me.c1ThemeController1.SetTheme(Me.C1Label3, "(default)")
        Me.C1Label3.UseCompatibleTextRendering = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 422)
        Me.Controls.Add(Me.ctdbgThemes)
        Me.Controls.Add(Me.tbApplicationTheme)
        Me.Controls.Add(Me.C1Label3)
        Me.Controls.Add(Me.C1Label2)
        Me.Controls.Add(Me.c1Label1)
        Me.Controls.Add(Me.btnSetAsApplicationTheme)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Theme Manager"
        Me.c1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbApplicationTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctdbgThemes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents btnAdd As C1.Win.C1Input.C1Button
    Friend WithEvents btnRemove As C1.Win.C1Input.C1Button
    Friend WithEvents btnSetAsApplicationTheme As C1.Win.C1Input.C1Button
    Friend WithEvents c1ThemeController1 As C1.Win.Themes.C1ThemeController
    Friend WithEvents c1Label1 As C1.Win.C1Input.C1Label
    Friend WithEvents tbApplicationTheme As C1.Win.C1Input.C1TextBox
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents ctdbgThemes As C1.Win.TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1Label2 As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label3 As C1.Win.C1Input.C1Label
End Class
