Namespace TouchEvent
    Partial Class ContextualUIDemo
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
            Me.colorButtonForTouch = New System.Windows.Forms.Button()
            Me.gcTouchEventProvider1 = New C1.Win.TouchToolKit.C1TouchEventProvider()
            Me.fontFamilyButtonForTouch = New System.Windows.Forms.Button()
            Me.fontSizeButtonForTouch = New System.Windows.Forms.Button()
            Me.fontFamilyTextBoxForTouch = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.preViewLabel = New System.Windows.Forms.Label()
            Me.colorButtonNormal = New System.Windows.Forms.Button()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.fontSizeButtonNormal = New System.Windows.Forms.Button()
            Me.fontFamilyTextBoxNormal = New System.Windows.Forms.TextBox()
            Me.fontFamilyButtonNormal = New System.Windows.Forms.Button()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.fontSizeButtonNormal)
            Me.panel1.Controls.Add(Me.fontSizeButtonForTouch)
            Me.panel1.Controls.Add(Me.fontFamilyButtonNormal)
            Me.panel1.Controls.Add(Me.fontFamilyButtonForTouch)
            Me.panel1.Controls.Add(Me.fontFamilyTextBoxNormal)
            Me.panel1.Controls.Add(Me.fontFamilyTextBoxForTouch)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.panel2)
            Me.panel1.Controls.Add(Me.colorButtonNormal)
            Me.panel1.Controls.Add(Me.colorButtonForTouch)
            '
            'colorButtonForTouch
            '
            Me.colorButtonForTouch.BackColor = System.Drawing.Color.Black
            Me.gcTouchEventProvider1.SetEnableTouchEvents(Me.colorButtonForTouch, True)
            Me.colorButtonForTouch.ForeColor = System.Drawing.Color.White
            Me.colorButtonForTouch.Location = New System.Drawing.Point(387, 142)
            Me.colorButtonForTouch.Name = "colorButtonForTouch"
            Me.colorButtonForTouch.Size = New System.Drawing.Size(146, 30)
            Me.colorButtonForTouch.TabIndex = 0
            Me.colorButtonForTouch.Text = "..."
            Me.colorButtonForTouch.UseVisualStyleBackColor = False
            '
            'gcTouchEventProvider1
            '
            '
            'fontFamilyButtonForTouch
            '
            Me.gcTouchEventProvider1.SetEnableTouchEvents(Me.fontFamilyButtonForTouch, True)
            Me.fontFamilyButtonForTouch.Location = New System.Drawing.Point(508, 314)
            Me.fontFamilyButtonForTouch.Name = "fontFamilyButtonForTouch"
            Me.fontFamilyButtonForTouch.Size = New System.Drawing.Size(25, 25)
            Me.fontFamilyButtonForTouch.TabIndex = 4
            Me.fontFamilyButtonForTouch.UseVisualStyleBackColor = True
            '
            'fontSizeButtonForTouch
            '
            Me.gcTouchEventProvider1.SetEnableTouchEvents(Me.fontSizeButtonForTouch, True)
            Me.fontSizeButtonForTouch.Location = New System.Drawing.Point(387, 228)
            Me.fontSizeButtonForTouch.Name = "fontSizeButtonForTouch"
            Me.fontSizeButtonForTouch.Size = New System.Drawing.Size(146, 25)
            Me.fontSizeButtonForTouch.TabIndex = 11
            Me.fontSizeButtonForTouch.Text = "9"
            Me.fontSizeButtonForTouch.UseVisualStyleBackColor = True
            '
            'fontFamilyTextBoxForTouch
            '
            Me.fontFamilyTextBoxForTouch.Location = New System.Drawing.Point(387, 314)
            Me.fontFamilyTextBoxForTouch.Name = "fontFamilyTextBoxForTouch"
            Me.fontFamilyTextBoxForTouch.Size = New System.Drawing.Size(121, 43)
            Me.fontFamilyTextBoxForTouch.TabIndex = 6
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(384, 111)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(137, 36)
            Me.label2.TabIndex = 8
            Me.label2.Text = "ForeColor:"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(384, 193)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(124, 36)
            Me.label3.TabIndex = 9
            Me.label3.Text = "FontSize:"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(384, 273)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(153, 36)
            Me.label4.TabIndex = 10
            Me.label4.Text = "FontFamily:"
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.preViewLabel)
            Me.panel2.Location = New System.Drawing.Point(45, 12)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(556, 72)
            Me.panel2.TabIndex = 7
            '
            'preViewLabel
            '
            Me.preViewLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.preViewLabel.ForeColor = System.Drawing.Color.Black
            Me.preViewLabel.Location = New System.Drawing.Point(0, 0)
            Me.preViewLabel.Name = "preViewLabel"
            Me.preViewLabel.Size = New System.Drawing.Size(554, 70)
            Me.preViewLabel.TabIndex = 3
            Me.preViewLabel.Text = "Provide touch-optimized contextual UI if it is opened by touch."
            Me.preViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'colorButtonNormal
            '
            Me.colorButtonNormal.BackColor = System.Drawing.Color.Black
            Me.colorButtonNormal.ForeColor = System.Drawing.Color.White
            Me.colorButtonNormal.Location = New System.Drawing.Point(63, 142)
            Me.colorButtonNormal.Name = "colorButtonNormal"
            Me.colorButtonNormal.Size = New System.Drawing.Size(146, 30)
            Me.colorButtonNormal.TabIndex = 0
            Me.colorButtonNormal.Text = "..."
            Me.colorButtonNormal.UseVisualStyleBackColor = False
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(60, 111)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(137, 36)
            Me.label5.TabIndex = 8
            Me.label5.Text = "ForeColor:"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(60, 193)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(124, 36)
            Me.label6.TabIndex = 9
            Me.label6.Text = "FontSize:"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(60, 273)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(153, 36)
            Me.label7.TabIndex = 10
            Me.label7.Text = "FontFamily:"
            '
            'fontSizeButtonNormal
            '
            Me.fontSizeButtonNormal.Location = New System.Drawing.Point(63, 228)
            Me.fontSizeButtonNormal.Name = "fontSizeButtonNormal"
            Me.fontSizeButtonNormal.Size = New System.Drawing.Size(146, 25)
            Me.fontSizeButtonNormal.TabIndex = 11
            Me.fontSizeButtonNormal.Text = "9"
            Me.fontSizeButtonNormal.UseVisualStyleBackColor = True
            '
            'fontFamilyTextBoxNormal
            '
            Me.fontFamilyTextBoxNormal.Location = New System.Drawing.Point(63, 314)
            Me.fontFamilyTextBoxNormal.Name = "fontFamilyTextBoxNormal"
            Me.fontFamilyTextBoxNormal.Size = New System.Drawing.Size(121, 43)
            Me.fontFamilyTextBoxNormal.TabIndex = 6
            '
            'fontFamilyButtonNormal
            '
            Me.fontFamilyButtonNormal.Location = New System.Drawing.Point(184, 314)
            Me.fontFamilyButtonNormal.Name = "fontFamilyButtonNormal"
            Me.fontFamilyButtonNormal.Size = New System.Drawing.Size(25, 25)
            Me.fontFamilyButtonNormal.TabIndex = 4
            Me.fontFamilyButtonNormal.UseVisualStyleBackColor = True
            '
            'ContextualUIDemo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 36.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "ContextualUIDemo"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private colorButtonForTouch As System.Windows.Forms.Button
        Private WithEvents gcTouchEventProvider1 As C1.Win.TouchToolKit.C1TouchEventProvider
        Private fontSizeButtonForTouch As System.Windows.Forms.Button
        Private label4 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private fontSizeButtonNormal As System.Windows.Forms.Button
        Private label7 As System.Windows.Forms.Label
        Private label6 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private panel2 As System.Windows.Forms.Panel
        Private preViewLabel As System.Windows.Forms.Label
        Private colorButtonNormal As System.Windows.Forms.Button
        Private fontFamilyButtonForTouch As System.Windows.Forms.Button
        Private fontFamilyTextBoxForTouch As System.Windows.Forms.TextBox
        Private fontFamilyButtonNormal As System.Windows.Forms.Button
        Private fontFamilyTextBoxNormal As System.Windows.Forms.TextBox
    End Class
End Namespace
