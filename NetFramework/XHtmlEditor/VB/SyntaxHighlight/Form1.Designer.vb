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
        Me.c1Editor1 = New C1.Win.C1Editor.C1Editor()
        DirectCast((Me.c1Editor1), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' c1Editor1
        ' 
        Me.c1Editor1.BackColor = System.Drawing.SystemColors.Window
        Me.c1Editor1.XmlExtensions = Nothing
        Me.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Editor1.Location = New System.Drawing.Point(0, 0)
        Me.c1Editor1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.c1Editor1.Name = "c1Editor1"
        Me.c1Editor1.WordWrap = True
        Me.c1Editor1.Size = New System.Drawing.Size(617, 446)
        Me.c1Editor1.TabIndex = 0
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0F, 16.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 446)
        Me.Controls.Add(Me.c1Editor1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Editor: Syntax highlighting"
        DirectCast((Me.c1Editor1), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private c1Editor1 As C1.Win.C1Editor.C1Editor
End Class

