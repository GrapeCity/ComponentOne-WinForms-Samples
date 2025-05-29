Imports System.Windows.Forms

Namespace AdvancedFiltering
    Partial Class WeekdayFilterEditor
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.chkSun = New System.Windows.Forms.CheckBox()
            Me.chkSat = New System.Windows.Forms.CheckBox()
            Me.chkFri = New System.Windows.Forms.CheckBox()
            Me.chkThu = New System.Windows.Forms.CheckBox()
            Me.chkWed = New System.Windows.Forms.CheckBox()
            Me.chkTue = New System.Windows.Forms.CheckBox()
            Me.chkMon = New System.Windows.Forms.CheckBox()
            Me.SuspendLayout()
            '
            'chkSun
            '
            Me.chkSun.AutoSize = True
            Me.chkSun.Location = New System.Drawing.Point(15, 199)
            Me.chkSun.Name = "chkSun"
            Me.chkSun.Size = New System.Drawing.Size(70, 19)
            Me.chkSun.TabIndex = 13
            Me.chkSun.Text = "Sunday"
            Me.chkSun.UseVisualStyleBackColor = True
            '
            'chkSat
            '
            Me.chkSat.AutoSize = True
            Me.chkSat.Location = New System.Drawing.Point(15, 168)
            Me.chkSat.Name = "chkSat"
            Me.chkSat.Size = New System.Drawing.Size(77, 19)
            Me.chkSat.TabIndex = 12
            Me.chkSat.Text = "Saturday"
            Me.chkSat.UseVisualStyleBackColor = True
            '
            'chkFri
            '
            Me.chkFri.AutoSize = True
            Me.chkFri.Location = New System.Drawing.Point(15, 137)
            Me.chkFri.Name = "chkFri"
            Me.chkFri.Size = New System.Drawing.Size(62, 19)
            Me.chkFri.TabIndex = 11
            Me.chkFri.Text = "Friday"
            Me.chkFri.UseVisualStyleBackColor = True
            '
            'chkThu
            '
            Me.chkThu.AutoSize = True
            Me.chkThu.Location = New System.Drawing.Point(15, 106)
            Me.chkThu.Name = "chkThu"
            Me.chkThu.Size = New System.Drawing.Size(79, 19)
            Me.chkThu.TabIndex = 10
            Me.chkThu.Text = "Thursday"
            Me.chkThu.UseVisualStyleBackColor = True
            '
            'chkWed
            '
            Me.chkWed.AutoSize = True
            Me.chkWed.Location = New System.Drawing.Point(15, 75)
            Me.chkWed.Name = "chkWed"
            Me.chkWed.Size = New System.Drawing.Size(93, 19)
            Me.chkWed.TabIndex = 9
            Me.chkWed.Text = "Wednesday"
            Me.chkWed.UseVisualStyleBackColor = True
            '
            'chkTue
            '
            Me.chkTue.AutoSize = True
            Me.chkTue.Location = New System.Drawing.Point(15, 44)
            Me.chkTue.Name = "chkTue"
            Me.chkTue.Size = New System.Drawing.Size(75, 19)
            Me.chkTue.TabIndex = 8
            Me.chkTue.Text = "Tuesday"
            Me.chkTue.UseVisualStyleBackColor = True
            '
            'chkMon
            '
            Me.chkMon.AutoSize = True
            Me.chkMon.Location = New System.Drawing.Point(15, 13)
            Me.chkMon.Name = "chkMon"
            Me.chkMon.Size = New System.Drawing.Size(73, 19)
            Me.chkMon.TabIndex = 7
            Me.chkMon.Text = "Monday"
            Me.chkMon.UseVisualStyleBackColor = True
            '
            'WeekdayFilterEditor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.chkSun)
            Me.Controls.Add(Me.chkSat)
            Me.Controls.Add(Me.chkFri)
            Me.Controls.Add(Me.chkThu)
            Me.Controls.Add(Me.chkWed)
            Me.Controls.Add(Me.chkTue)
            Me.Controls.Add(Me.chkMon)
            Me.Name = "WeekdayFilterEditor"
            Me.Size = New System.Drawing.Size(125, 231)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private chkSun As CheckBox
        Private chkSat As CheckBox
        Private chkFri As CheckBox
        Private chkThu As CheckBox
        Private chkWed As CheckBox
        Private chkTue As CheckBox
        Private chkMon As CheckBox
    End Class
End Namespace
