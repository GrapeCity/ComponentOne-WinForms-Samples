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
        Me.c1Label1 = New C1.Win.C1Input.C1Label()
        Me.ctdbgThemes = New C1.Win.TrueDBGrid.C1TrueDBGrid()
        Me.c1Label2 = New C1.Win.C1Input.C1Label()
        Me.lblApplicationTheme = New C1.Win.C1Input.C1Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.c1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctdbgThemes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblApplicationTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'c1Label1
        '
        Me.c1Label1.AutoSize = True
        Me.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Label1.ForeColor = System.Drawing.Color.Black
        Me.c1Label1.Location = New System.Drawing.Point(10, 50)
        Me.c1Label1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.c1Label1.Name = "c1Label1"
        Me.c1Label1.Size = New System.Drawing.Size(326, 13)
        Me.c1Label1.TabIndex = 0
        Me.c1Label1.Tag = Nothing
        Me.c1Label1.Text = "Available Themes:"
        Me.c1Label1.TextDetached = True
        Me.c1ThemeController1.SetTheme(Me.c1Label1, "(default)")
        Me.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom
        '
        'ctdbgThemes
        '
        Me.ctdbgThemes.AllowUpdate = False
        Me.ctdbgThemes.AlternatingRows = True
        Me.ctdbgThemes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctdbgThemes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ctdbgThemes.CaptionHeight = 17
        Me.ctdbgThemes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctdbgThemes.ForeColor = System.Drawing.Color.Black
        Me.ctdbgThemes.GroupByCaption = "Drag a column header here to group by that column"
        Me.ctdbgThemes.Images.Add(CType(resources.GetObject("ctdbgThemes.Images"), System.Drawing.Image))
        Me.ctdbgThemes.Location = New System.Drawing.Point(10, 66)
        Me.ctdbgThemes.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.ctdbgThemes.Name = "ctdbgThemes"
        Me.ctdbgThemes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.ctdbgThemes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.ctdbgThemes.PreviewInfo.ZoomFactor = 75.0R
        Me.ctdbgThemes.PrintInfo.MeasurementDevice = C1.Win.TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.ctdbgThemes.PrintInfo.MeasurementPrinterName = Nothing
        Me.ctdbgThemes.PrintInfo.PageSettings = CType(resources.GetObject("ctdbgThemes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.ctdbgThemes.PropBag = resources.GetString("ctdbgThemes.PropBag")
        Me.ctdbgThemes.RowDivider.Color = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ctdbgThemes.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.[Single]
        Me.ctdbgThemes.RowSubDividerColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ctdbgThemes.Size = New System.Drawing.Size(326, 352)
        Me.ctdbgThemes.TabIndex = 1
        Me.ctdbgThemes.Text = "c1TrueDBGrid1"
        Me.c1ThemeController1.SetTheme(Me.ctdbgThemes, "(default)")
        Me.ctdbgThemes.UseCompatibleTextRendering = False
        Me.ctdbgThemes.VisualStyle = C1.Win.TrueDBGrid.VisualStyle.Custom
        '
        'c1Label2
        '
        Me.c1Label2.AutoSize = True
        Me.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.c1Label2.ForeColor = System.Drawing.Color.Black
        Me.c1Label2.Location = New System.Drawing.Point(10, 421)
        Me.c1Label2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.c1Label2.Name = "c1Label2"
        Me.c1Label2.Size = New System.Drawing.Size(326, 13)
        Me.c1Label2.TabIndex = 2
        Me.c1Label2.Tag = Nothing
        Me.c1Label2.Text = "Application theme:"
        Me.c1Label2.TextDetached = True
        Me.c1ThemeController1.SetTheme(Me.c1Label2, "(default)")
        Me.c1Label2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom
        '
        'lblApplicationTheme
        '
        Me.lblApplicationTheme.AutoEllipsis = True
        Me.lblApplicationTheme.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblApplicationTheme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblApplicationTheme.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblApplicationTheme.ForeColor = System.Drawing.Color.Black
        Me.lblApplicationTheme.Location = New System.Drawing.Point(10, 434)
        Me.lblApplicationTheme.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblApplicationTheme.Name = "lblApplicationTheme"
        Me.lblApplicationTheme.Size = New System.Drawing.Size(326, 30)
        Me.lblApplicationTheme.TabIndex = 3
        Me.lblApplicationTheme.Tag = Nothing
        Me.lblApplicationTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.c1ThemeController1.SetTheme(Me.lblApplicationTheme, "(default)")
        Me.lblApplicationTheme.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom
        '
        'textBox1
        '
        Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.ForeColor = System.Drawing.Color.Black
        Me.textBox1.Location = New System.Drawing.Point(10, 10)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.Size = New System.Drawing.Size(326, 30)
        Me.textBox1.TabIndex = 4
        Me.textBox1.Text = "Using ObjectThemeApplied event  you can restore visual properties which where cha" &
    "nged during theme applying."
        Me.c1ThemeController1.SetTheme(Me.textBox1, "(default)")
        '
        'c1ThemeController1
        '
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.textBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblApplicationTheme, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.c1Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.c1Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ctdbgThemes, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(346, 464)
        Me.TableLayoutPanel1.TabIndex = 5
        Me.c1ThemeController1.SetTheme(Me.TableLayoutPanel1, "(default)")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 464)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "C1Themes events"
        Me.c1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctdbgThemes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblApplicationTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private c1Label1 As C1.Win.C1Input.C1Label
    Private WithEvents ctdbgThemes As C1.Win.TrueDBGrid.C1TrueDBGrid
	Private c1Label2 As C1.Win.C1Input.C1Label
	Private lblApplicationTheme As C1.Win.C1Input.C1Label
	Private textBox1 As System.Windows.Forms.TextBox
    Private WithEvents c1ThemeController1 As C1.Win.Themes.C1ThemeController
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class

