Namespace TouchEvent
    Partial Class AutoRepeatDemo
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
            Me.gcTouchEventProvider1 = New C1.Win.TouchToolKit.C1TouchEventProvider()
            Me.upButton1 = New System.Windows.Forms.Button()
            Me.downButton1 = New System.Windows.Forms.Button()
            Me.upButton2 = New System.Windows.Forms.Button()
            Me.downButton2 = New System.Windows.Forms.Button()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.textBox2)
            Me.panel1.Controls.Add(Me.downButton2)
            Me.panel1.Controls.Add(Me.upButton2)
            Me.panel1.Controls.Add(Me.downButton1)
            Me.panel1.Controls.Add(Me.upButton1)
            Me.panel1.Controls.Add(Me.textBox1)
            '
            'gcTouchEventProvider1
            '
            Me.gcTouchEventProvider1.EnablePressAndHold = False
            '
            'upButton1
            '
            Me.gcTouchEventProvider1.SetEnableTouchEvents(Me.upButton1, True)
            Me.upButton1.Location = New System.Drawing.Point(170, 242)
            Me.upButton1.Name = "upButton1"
            Me.upButton1.Size = New System.Drawing.Size(65, 31)
            Me.upButton1.TabIndex = 1
            Me.upButton1.Text = "+"
            Me.upButton1.UseVisualStyleBackColor = True
            '
            'downButton1
            '
            Me.gcTouchEventProvider1.SetEnableTouchEvents(Me.downButton1, True)
            Me.downButton1.Location = New System.Drawing.Point(241, 242)
            Me.downButton1.Name = "downButton1"
            Me.downButton1.Size = New System.Drawing.Size(65, 31)
            Me.downButton1.TabIndex = 2
            Me.downButton1.Text = "-"
            Me.downButton1.UseVisualStyleBackColor = True
            '
            'upButton2
            '
            Me.upButton2.Location = New System.Drawing.Point(170, 122)
            Me.upButton2.Name = "upButton2"
            Me.upButton2.Size = New System.Drawing.Size(65, 30)
            Me.upButton2.TabIndex = 3
            Me.upButton2.Text = "+"
            Me.upButton2.UseVisualStyleBackColor = True
            '
            'downButton2
            '
            Me.downButton2.Location = New System.Drawing.Point(241, 122)
            Me.downButton2.Name = "downButton2"
            Me.downButton2.Size = New System.Drawing.Size(65, 30)
            Me.downButton2.TabIndex = 4
            Me.downButton2.Text = "-"
            Me.downButton2.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(44, 243)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(120, 43)
            Me.textBox1.TabIndex = 0
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(44, 122)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(120, 43)
            Me.textBox2.TabIndex = 5
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(40, 161)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(411, 36)
            Me.label2.TabIndex = 6
            Me.label2.Text = "TextBox with Repeatable Buttons:"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(40, 29)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(272, 36)
            Me.label3.TabIndex = 7
            Me.label3.Text = "TextBox with Buttons:"
            '
            'label4
            '
            Me.label4.Location = New System.Drawing.Point(77, 47)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(501, 72)
            Me.label4.TabIndex = 11
            Me.label4.Text = "When press and hold a control, the default logic of Win8 is show a black rectangl" &
    "e. After release finger, it generate a right click message for this control. "
            '
            'label5
            '
            Me.label5.Location = New System.Drawing.Point(77, 184)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(501, 56)
            Me.label5.TabIndex = 12
            Me.label5.Text = "To disable this default behavior user can set ""EnablePressAndHold"" property to fa" &
    "lse."
            '
            'AutoRepeatDemo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 36.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "AutoRepeatDemo"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents gcTouchEventProvider1 As C1.Win.TouchToolKit.C1TouchEventProvider
        Private textBox2 As System.Windows.Forms.TextBox
        Private downButton2 As System.Windows.Forms.Button
        Private upButton2 As System.Windows.Forms.Button
        Private downButton1 As System.Windows.Forms.Button
        Private upButton1 As System.Windows.Forms.Button
        Private textBox1 As System.Windows.Forms.TextBox
        Private label3 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
    End Class
End Namespace
