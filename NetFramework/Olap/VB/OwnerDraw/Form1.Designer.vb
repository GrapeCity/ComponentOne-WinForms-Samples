Namespace ConditionalFormatting
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
			Me.c1OlapPage1 = New C1.Win.Olap.C1OlapPage()
			CType(Me.c1OlapPage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' c1OlapPage1
			' 
			Me.c1OlapPage1.Dock = DockStyle.Fill
			Me.c1OlapPage1.Location = New Point(0, 0)
			Me.c1OlapPage1.Margin = New Padding(2)
			Me.c1OlapPage1.Name = "c1OlapPage1"
			Me.c1OlapPage1.Size = New Size(850, 470)
			Me.c1OlapPage1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(8F, 16F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(850, 470)
			Me.Controls.Add(Me.c1OlapPage1)
			Me.Name = "Form1"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "C1Olap: Conditional Formatting"
			CType(Me.c1OlapPage1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private c1OlapPage1 As C1.Win.Olap.C1OlapPage
	End Class
End Namespace

