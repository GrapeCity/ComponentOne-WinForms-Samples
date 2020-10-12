Namespace CustomFilters
	Partial Public Class StringFilterEditor
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me._chkAE = New CheckBox()
			Me._chkFJ = New CheckBox()
			Me._chkKO = New CheckBox()
			Me._chkPT = New CheckBox()
			Me._chkUZ = New CheckBox()
			Me.SuspendLayout()
			' 
			' _chkAE
			' 
			Me._chkAE.AutoSize = True
			Me._chkAE.Location = New Point(2, 4)
			Me._chkAE.Margin = New Padding(3, 0, 3, 0)
			Me._chkAE.Name = "_chkAE"
			Me._chkAE.Size = New Size(61, 21)
			Me._chkAE.TabIndex = 0
			Me._chkAE.Text = "A - E"
			Me._chkAE.UseVisualStyleBackColor = True
'			Me._chkAE.CheckedChanged += New System.EventHandler(Me._chkAE_CheckedChanged)
			' 
			' _chkFJ
			' 
			Me._chkFJ.AutoSize = True
			Me._chkFJ.Location = New Point(2, 25)
			Me._chkFJ.Margin = New Padding(3, 0, 3, 0)
			Me._chkFJ.Name = "_chkFJ"
			Me._chkFJ.Size = New Size(58, 21)
			Me._chkFJ.TabIndex = 0
			Me._chkFJ.Text = "F - J"
			Me._chkFJ.UseVisualStyleBackColor = True
'			Me._chkFJ.CheckedChanged += New System.EventHandler(Me._chkAE_CheckedChanged)
			' 
			' _chkKO
			' 
			Me._chkKO.AutoSize = True
			Me._chkKO.Location = New Point(2, 46)
			Me._chkKO.Margin = New Padding(3, 0, 3, 0)
			Me._chkKO.Name = "_chkKO"
			Me._chkKO.Size = New Size(63, 21)
			Me._chkKO.TabIndex = 0
			Me._chkKO.Text = "K - O"
			Me._chkKO.UseVisualStyleBackColor = True
'			Me._chkKO.CheckedChanged += New System.EventHandler(Me._chkAE_CheckedChanged)
			' 
			' _chkPT
			' 
			Me._chkPT.AutoSize = True
			Me._chkPT.Location = New Point(2, 67)
			Me._chkPT.Margin = New Padding(3, 0, 3, 0)
			Me._chkPT.Name = "_chkPT"
			Me._chkPT.Size = New Size(61, 21)
			Me._chkPT.TabIndex = 0
			Me._chkPT.Text = "P - T"
			Me._chkPT.UseVisualStyleBackColor = True
'			Me._chkPT.CheckedChanged += New System.EventHandler(Me._chkAE_CheckedChanged)
			' 
			' _chkUZ
			' 
			Me._chkUZ.AutoSize = True
			Me._chkUZ.Location = New Point(2, 88)
			Me._chkUZ.Margin = New Padding(3, 0, 3, 0)
			Me._chkUZ.Name = "_chkUZ"
			Me._chkUZ.Size = New Size(62, 21)
			Me._chkUZ.TabIndex = 0
			Me._chkUZ.Text = "U - Z"
			Me._chkUZ.UseVisualStyleBackColor = True
'			Me._chkUZ.CheckedChanged += New System.EventHandler(Me._chkAE_CheckedChanged)
			' 
			' StringFilterEditor
			' 
			Me.AutoScaleDimensions = New SizeF(8F, 16F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoSize = True
			Me.BackColor = Color.Transparent
			Me.Controls.Add(Me._chkUZ)
			Me.Controls.Add(Me._chkPT)
			Me.Controls.Add(Me._chkKO)
			Me.Controls.Add(Me._chkFJ)
			Me.Controls.Add(Me._chkAE)
			Me.Margin = New Padding(4, 4, 4, 4)
			Me.Name = "StringFilterEditor"
			Me.Size = New Size(234, 114)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents _chkAE As CheckBox
		Private WithEvents _chkFJ As CheckBox
		Private WithEvents _chkKO As CheckBox
		Private WithEvents _chkPT As CheckBox
		Private WithEvents _chkUZ As CheckBox
	End Class
End Namespace
