Namespace C1ZoomPages
    Partial Class BoundaryFeedbackUI
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

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.radioButton2 = New System.Windows.Forms.RadioButton()
            Me.radioButton1 = New System.Windows.Forms.RadioButton()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.radioButton2)
            Me.groupBox1.Controls.Add(Me.radioButton1)
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBox1.Location = New System.Drawing.Point(0, 0)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(226, 46)
            Me.groupBox1.TabIndex = 35
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "BoundaryFeedbackMode "
            ' 
            ' radioButton2
            ' 
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Location = New System.Drawing.Point(127, 19)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(68, 17)
            Me.radioButton2.TabIndex = 0
            Me.radioButton2.Text = "Standard"
            Me.radioButton2.UseVisualStyleBackColor = True
            AddHandler Me.radioButton2.CheckedChanged, New EventHandler(AddressOf Me.radioButton_CheckedChanged)
            ' 
            ' radioButton1
            ' 
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Checked = True
            Me.radioButton1.Location = New System.Drawing.Point(29, 19)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(45, 17)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Split"
            Me.radioButton1.UseVisualStyleBackColor = True
            AddHandler Me.radioButton1.CheckedChanged, New EventHandler(AddressOf Me.radioButton_CheckedChanged)
            ' 
            ' BoundaryFeedbackUI
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "BoundaryFeedbackUI"
            Me.Size = New System.Drawing.Size(226, 46)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private groupBox1 As System.Windows.Forms.GroupBox
        Private radioButton2 As System.Windows.Forms.RadioButton
        Private radioButton1 As System.Windows.Forms.RadioButton
    End Class
End Namespace
