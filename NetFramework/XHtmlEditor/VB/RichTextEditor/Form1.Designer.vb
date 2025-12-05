Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overloads Overrides Sub Dispose(disposing As Boolean)
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
        Me.c1TextEditorRibbon1 = New RichTextEditor.C1TextEditorRibbon()
        Me.textEditor1 = New C1.Win.C1Editor.C1Editor()
        Me.RibbonApplicationMenu2 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.RibbonQat2 = New C1.Win.Ribbon.RibbonQat()
        Me.RibbonConfigToolBar2 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.c1StatusBar1 = New C1.Win.Ribbon.C1StatusBar()
        Me.C1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        CType(Me.c1TextEditorRibbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1TextEditorRibbon1
        '
        Me.c1TextEditorRibbon1.C1Editor = Me.textEditor1
        Me.c1TextEditorRibbon1.Location = New System.Drawing.Point(0, 0)
        Me.c1TextEditorRibbon1.Name = "c1TextEditorRibbon1"
        Me.c1TextEditorRibbon1.Size = New System.Drawing.Size(889, 161)
        Me.C1ThemeController1.SetTheme(Me.c1TextEditorRibbon1, "(default)")
        Me.c1TextEditorRibbon1.ToolTipSettings.MaximumWidth = 240
        '
        'textEditor1
        '
        Me.textEditor1.BackColor = System.Drawing.Color.White
        Me.textEditor1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textEditor1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textEditor1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.textEditor1.Location = New System.Drawing.Point(0, 161)
        Me.textEditor1.Margin = New System.Windows.Forms.Padding(2)
        Me.textEditor1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.textEditor1.Name = "textEditor1"
        Me.textEditor1.Size = New System.Drawing.Size(889, 391)
        Me.textEditor1.TabIndex = 1
        Me.C1ThemeController1.SetTheme(Me.textEditor1, "(default)")
        '
        'RibbonApplicationMenu2
        '
        Me.RibbonApplicationMenu2.Name = "RibbonApplicationMenu2"
        '
        'RibbonQat2
        '
        Me.RibbonQat2.Name = "RibbonQat2"
        '
        'RibbonConfigToolBar2
        '
        Me.RibbonConfigToolBar2.Name = "RibbonConfigToolBar2"
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'RibbonBottomToolBar1
        '
        Me.RibbonBottomToolBar1.Name = "RibbonBottomToolBar1"
        '
        'ribbonApplicationMenu1
        '
        Me.ribbonApplicationMenu1.DropDownWidth = 370
        Me.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
        '
        'ribbonQat1
        '
        Me.ribbonQat1.Name = "ribbonQat1"
        '
        'ribbonConfigToolBar1
        '
        Me.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
        '
        'c1StatusBar1
        '
        Me.c1StatusBar1.Location = New System.Drawing.Point(0, 552)
        Me.c1StatusBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.c1StatusBar1.Name = "c1StatusBar1"
        Me.c1StatusBar1.Size = New System.Drawing.Size(889, 22)
        Me.C1ThemeController1.SetTheme(Me.c1StatusBar1, "(default)")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 574)
        Me.Controls.Add(Me.textEditor1)
        Me.Controls.Add(Me.c1StatusBar1)
        Me.Controls.Add(Me.c1TextEditorRibbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rich Text Editor"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.c1TextEditorRibbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private c1TextEditorRibbon1 As RichTextEditor.C1TextEditorRibbon
    Private c1StatusBar1 As C1.Win.Ribbon.C1StatusBar
    Private textEditor1 As C1.Win.C1Editor.C1Editor
    Private ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Private ribbonQat1 As C1.Win.Ribbon.RibbonQat
    Private ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Private WithEvents C1ThemeController1 As C1.Win.Themes.C1ThemeController
    Friend WithEvents RibbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Friend WithEvents RibbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents RibbonApplicationMenu2 As C1.Win.Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonQat2 As C1.Win.Ribbon.RibbonQat
    Friend WithEvents RibbonConfigToolBar2 As C1.Win.Ribbon.RibbonConfigToolBar
End Class

