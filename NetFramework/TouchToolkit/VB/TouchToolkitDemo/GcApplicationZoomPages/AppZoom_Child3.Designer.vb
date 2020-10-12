Namespace C1ApplicationZoomPages
    Partial Class AppZoom_Child3
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
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(30, 23)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(34, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "名前:"
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(30, 55)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(70, 13)
            Me.label2.TabIndex = 1
            Me.label2.Text = "パスワード:"
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(103, 20)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(146, 20)
            Me.textBox1.TabIndex = 2
            ' 
            ' textBox2
            ' 
            Me.textBox2.Location = New System.Drawing.Point(103, 52)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(146, 20)
            Me.textBox2.TabIndex = 3
            ' 
            ' button1
            ' 
            Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.button1.Location = New System.Drawing.Point(92, 97)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 4
            Me.button1.Text = "登録"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' button2
            ' 
            Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.button2.Location = New System.Drawing.Point(180, 97)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 5
            Me.button2.Text = "取消"
            Me.button2.UseVisualStyleBackColor = True
            ' 
            ' AppZoom_Child3
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(267, 132)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.textBox2)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "AppZoom_Child3"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.Text = "AppZoom_Child3"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private textBox1 As System.Windows.Forms.TextBox
        Private textBox2 As System.Windows.Forms.TextBox
        Private button1 As System.Windows.Forms.Button
        Private button2 As System.Windows.Forms.Button
    End Class
End Namespace
