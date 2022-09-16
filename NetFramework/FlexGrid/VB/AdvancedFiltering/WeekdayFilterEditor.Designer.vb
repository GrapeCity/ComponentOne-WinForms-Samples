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
            components = New System.ComponentModel.Container()
            Me.chkSun = New System.Windows.Forms.CheckBox()
            Me.chkSat = New System.Windows.Forms.CheckBox()
            Me.chkFri = New System.Windows.Forms.CheckBox()
            Me.chkThu = New System.Windows.Forms.CheckBox()
            Me.chkWed = New System.Windows.Forms.CheckBox()
            Me.chkTue = New System.Windows.Forms.CheckBox()
            Me.chkMon = New System.Windows.Forms.CheckBox()
            Me.SuspendLayout()
            Me.chkSun.AutoSize = True
            Me.chkSun.Location = New System.Drawing.Point(15, 151)
            Me.chkSun.Name = "chkSun"
            Me.chkSun.Size = New System.Drawing.Size(62, 17)
            Me.chkSun.TabIndex = 13
            Me.chkSun.Text = "Sunday"
            Me.chkSun.UseVisualStyleBackColor = True
            Me.chkSat.AutoSize = True
            Me.chkSat.Location = New System.Drawing.Point(15, 128)
            Me.chkSat.Name = "chkSat"
            Me.chkSat.Size = New System.Drawing.Size(68, 17)
            Me.chkSat.TabIndex = 12
            Me.chkSat.Text = "Saturday"
            Me.chkSat.UseVisualStyleBackColor = True
            Me.chkFri.AutoSize = True
            Me.chkFri.Location = New System.Drawing.Point(15, 105)
            Me.chkFri.Name = "chkFri"
            Me.chkFri.Size = New System.Drawing.Size(54, 17)
            Me.chkFri.TabIndex = 11
            Me.chkFri.Text = "Friday"
            Me.chkFri.UseVisualStyleBackColor = True
            Me.chkThu.AutoSize = True
            Me.chkThu.Location = New System.Drawing.Point(15, 82)
            Me.chkThu.Name = "chkThu"
            Me.chkThu.Size = New System.Drawing.Size(70, 17)
            Me.chkThu.TabIndex = 10
            Me.chkThu.Text = "Thursday"
            Me.chkThu.UseVisualStyleBackColor = True
            Me.chkWed.AutoSize = True
            Me.chkWed.Location = New System.Drawing.Point(15, 59)
            Me.chkWed.Name = "chkWed"
            Me.chkWed.Size = New System.Drawing.Size(83, 17)
            Me.chkWed.TabIndex = 9
            Me.chkWed.Text = "Wednesday"
            Me.chkWed.UseVisualStyleBackColor = True
            Me.chkTue.AutoSize = True
            Me.chkTue.Location = New System.Drawing.Point(15, 36)
            Me.chkTue.Name = "chkTue"
            Me.chkTue.Size = New System.Drawing.Size(67, 17)
            Me.chkTue.TabIndex = 8
            Me.chkTue.Text = "Tuesday"
            Me.chkTue.UseVisualStyleBackColor = True
            Me.chkMon.AutoSize = True
            Me.chkMon.Location = New System.Drawing.Point(15, 13)
            Me.chkMon.Name = "chkMon"
            Me.chkMon.Size = New System.Drawing.Size(64, 17)
            Me.chkMon.TabIndex = 7
            Me.chkMon.Text = "Monday"
            Me.chkMon.UseVisualStyleBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chkSun)
            Me.Controls.Add(Me.chkSat)
            Me.Controls.Add(Me.chkFri)
            Me.Controls.Add(Me.chkThu)
            Me.Controls.Add(Me.chkWed)
            Me.Controls.Add(Me.chkTue)
            Me.Controls.Add(Me.chkMon)
            Me.Name = "WeekdayFilterEditor"
            Me.Size = New System.Drawing.Size(125, 189)
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
