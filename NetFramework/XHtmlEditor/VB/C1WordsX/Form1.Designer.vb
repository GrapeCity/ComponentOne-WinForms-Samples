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
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.c1TextEditorRibbon1 = New C1WordsX.C1TextEditorRibbon()
        Me.textEditor1 = New C1.Win.C1Editor.C1Editor()
        Me.ribbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.ribbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.ribbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.c1StatusBar1 = New C1.Win.C1Ribbon.C1StatusBar()
        DirectCast((Me.c1TextEditorRibbon1), System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast((Me.c1StatusBar1), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' c1TextEditorRibbon1
        ' 
        Me.c1TextEditorRibbon1.C1Editor = Me.textEditor1
        Me.c1TextEditorRibbon1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.c1TextEditorRibbon1.Name = "c1TextEditorRibbon1"
        Me.c1TextEditorRibbon1.ToolTipSettings.MaximumWidth = 240
        ' 
        ' textEditor1
        ' 
        Me.textEditor1.BackColor = System.Drawing.Color.White
        Me.textEditor1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textEditor1.Font = New System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
        Me.textEditor1.Location = New System.Drawing.Point(0, 150)
        Me.textEditor1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.textEditor1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.textEditor1.Name = "textEditor1"
        Me.textEditor1.Size = New System.Drawing.Size(671, 224)
        Me.textEditor1.TabIndex = 1
        ' 
        ' ribbonApplicationMenu1
        ' 
        Me.ribbonApplicationMenu1.DropDownWidth = 370
        Me.ribbonApplicationMenu1.LargeImage = DirectCast((resources.GetObject("ribbonApplicationMenu1.LargeImage")), System.Drawing.Image)
        Me.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
        ' 
        ' ribbonQat1
        ' 
        Me.ribbonQat1.Name = "ribbonQat1"
        ' 
        ' ribbonConfigToolBar1
        ' 
        Me.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
        ' 
        ' c1StatusBar1
        ' 
        Me.c1StatusBar1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.c1StatusBar1.Name = "c1StatusBar1"
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 396)
        Me.Controls.Add(Me.textEditor1)
        Me.Controls.Add(Me.c1StatusBar1)
        Me.Controls.Add(Me.c1TextEditorRibbon1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Words"
        DirectCast((Me.c1TextEditorRibbon1), System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast((Me.c1StatusBar1), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private c1TextEditorRibbon1 As C1WordsX.C1TextEditorRibbon
    Private c1StatusBar1 As C1.Win.C1Ribbon.C1StatusBar
    Private textEditor1 As C1.Win.C1Editor.C1Editor
	Private ribbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
	Private ribbonQat1 As C1.Win.C1Ribbon.RibbonQat
	Private ribbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
End Class

