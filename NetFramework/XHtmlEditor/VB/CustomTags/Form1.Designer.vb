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
		Me.btnSource = New System.Windows.Forms.Button()
		Me.btnPreview = New System.Windows.Forms.Button()
		Me.btnDesign = New System.Windows.Forms.Button()
		Me.lblMode = New System.Windows.Forms.Label()
        Me.editor = New C1.Win.C1Editor.C1Editor()
        Me.btnStatistics = New System.Windows.Forms.Button()
        DirectCast((Me.editor), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' btnSource
        ' 
        Me.btnSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
        Me.btnSource.Location = New System.Drawing.Point(93, 406)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(75, 23)
        Me.btnSource.TabIndex = 1
        Me.btnSource.Text = "Source"
        Me.btnSource.UseVisualStyleBackColor = True
        AddHandler Me.btnSource.Click, New System.EventHandler(AddressOf Me.btnMode_Click)
        ' 
        ' btnPreview
        ' 
        Me.btnPreview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.Location = New System.Drawing.Point(174, 406)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 2
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        AddHandler Me.btnPreview.Click, New System.EventHandler(AddressOf Me.btnMode_Click)
        ' 
        ' btnDesign
        ' 
        Me.btnDesign.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles)
        Me.btnDesign.Location = New System.Drawing.Point(12, 406)
        Me.btnDesign.Name = "btnDesign"
        Me.btnDesign.Size = New System.Drawing.Size(75, 23)
        Me.btnDesign.TabIndex = 3
        Me.btnDesign.Text = "Design"
        Me.btnDesign.UseVisualStyleBackColor = True
        AddHandler Me.btnDesign.Click, New System.EventHandler(AddressOf Me.btnMode_Click)
        ' 
        ' lblMode
        ' 
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(9, 9)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(40, 13)
        Me.lblMode.TabIndex = 4
        Me.lblMode.Text = "Design"
        ' 
        ' editor
        ' 
        Me.editor.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.editor.BackColor = System.Drawing.SystemColors.Window
        Me.editor.Location = New System.Drawing.Point(2, 29)
        Me.editor.Name = "editor"
        Me.editor.Size = New System.Drawing.Size(611, 371)
        Me.editor.TabIndex = 5
        Me.editor.WordWrap = False
        Me.editor.XmlExtensions = Nothing
        ' 
        ' btnStatistics
        ' 
        Me.btnStatistics.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.btnStatistics.Location = New System.Drawing.Point(527, 406)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(75, 23)
        Me.btnStatistics.TabIndex = 6
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        AddHandler Me.btnStatistics.Click, New System.EventHandler(AddressOf Me.btnStatistics_Click)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 440)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.editor)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.btnDesign)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnSource)
        Me.Name = "Form1"
        Me.Text = "Form1"
        AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
        DirectCast((Me.editor), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private btnSource As System.Windows.Forms.Button
    Private btnPreview As System.Windows.Forms.Button
    Private btnDesign As System.Windows.Forms.Button
    Private lblMode As System.Windows.Forms.Label
    Private editor As C1.Win.C1Editor.C1Editor
	Private btnStatistics As System.Windows.Forms.Button
End Class

