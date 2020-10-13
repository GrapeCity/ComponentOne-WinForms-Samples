

Public Class NumPadDropDown
    Inherits C1.Win.C1Input.DropDownForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
  Friend WithEvents button12 As System.Windows.Forms.Button
  Friend WithEvents button11 As System.Windows.Forms.Button
  Friend WithEvents button10 As System.Windows.Forms.Button
  Friend WithEvents button9 As System.Windows.Forms.Button
  Friend WithEvents button8 As System.Windows.Forms.Button
  Friend WithEvents button7 As System.Windows.Forms.Button
  Friend WithEvents button6 As System.Windows.Forms.Button
  Friend WithEvents button5 As System.Windows.Forms.Button
  Friend WithEvents button4 As System.Windows.Forms.Button
  Friend WithEvents button3 As System.Windows.Forms.Button
  Friend WithEvents button2 As System.Windows.Forms.Button
  Friend WithEvents button1 As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button11 = New System.Windows.Forms.Button()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button12
        '
        Me.button12.BackColor = System.Drawing.SystemColors.Control
        Me.button12.ForeColor = System.Drawing.Color.Brown
        Me.button12.Location = New System.Drawing.Point(40, 136)
        Me.button12.Name = "button12"
        Me.button12.Size = New System.Drawing.Size(64, 32)
        Me.button12.TabIndex = 23
        Me.button12.Text = "Enter"
        '
        'button11
        '
        Me.button11.BackColor = System.Drawing.SystemColors.Control
        Me.button11.ForeColor = System.Drawing.Color.Brown
        Me.button11.Location = New System.Drawing.Point(40, 104)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(64, 32)
        Me.button11.TabIndex = 22
        Me.button11.Text = "Clear"
        '
        'button10
        '
        Me.button10.BackColor = System.Drawing.SystemColors.Control
        Me.button10.ForeColor = System.Drawing.Color.Blue
        Me.button10.Location = New System.Drawing.Point(8, 104)
        Me.button10.Name = "button10"
        Me.button10.Size = New System.Drawing.Size(32, 32)
        Me.button10.TabIndex = 21
        Me.button10.Text = "0"
        '
        'button9
        '
        Me.button9.BackColor = System.Drawing.SystemColors.Control
        Me.button9.ForeColor = System.Drawing.Color.Blue
        Me.button9.Location = New System.Drawing.Point(72, 8)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(32, 32)
        Me.button9.TabIndex = 20
        Me.button9.Text = "9"
        '
        'button8
        '
        Me.button8.BackColor = System.Drawing.SystemColors.Control
        Me.button8.ForeColor = System.Drawing.Color.Blue
        Me.button8.Location = New System.Drawing.Point(40, 8)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(32, 32)
        Me.button8.TabIndex = 19
        Me.button8.Text = "8"
        '
        'button7
        '
        Me.button7.BackColor = System.Drawing.SystemColors.Control
        Me.button7.ForeColor = System.Drawing.Color.Blue
        Me.button7.Location = New System.Drawing.Point(8, 8)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(32, 32)
        Me.button7.TabIndex = 18
        Me.button7.Text = "7"
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.SystemColors.Control
        Me.button6.ForeColor = System.Drawing.Color.Blue
        Me.button6.Location = New System.Drawing.Point(72, 40)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(32, 32)
        Me.button6.TabIndex = 17
        Me.button6.Text = "6"
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.SystemColors.Control
        Me.button5.ForeColor = System.Drawing.Color.Blue
        Me.button5.Location = New System.Drawing.Point(40, 40)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(32, 32)
        Me.button5.TabIndex = 16
        Me.button5.Text = "5"
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.SystemColors.Control
        Me.button4.ForeColor = System.Drawing.Color.Blue
        Me.button4.Location = New System.Drawing.Point(8, 40)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(32, 32)
        Me.button4.TabIndex = 15
        Me.button4.Text = "4"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.SystemColors.Control
        Me.button3.ForeColor = System.Drawing.Color.Blue
        Me.button3.Location = New System.Drawing.Point(72, 72)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(32, 32)
        Me.button3.TabIndex = 14
        Me.button3.Text = "3"
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.SystemColors.Control
        Me.button2.ForeColor = System.Drawing.Color.Blue
        Me.button2.Location = New System.Drawing.Point(40, 72)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(32, 32)
        Me.button2.TabIndex = 13
        Me.button2.Text = "2"
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.SystemColors.Control
        Me.button1.ForeColor = System.Drawing.Color.Blue
        Me.button1.Location = New System.Drawing.Point(8, 72)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(32, 32)
        Me.button1.TabIndex = 12
        Me.button1.Text = "1"
        '
        'NumPadDropDown
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(112, 176)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.button12, Me.button11, Me.button10, Me.button9, Me.button8, Me.button7, Me.button6, Me.button5, Me.button4, Me.button3, Me.button2, Me.button1})
        Me.Name = "NumPadDropDown"
        Me.Options = C1.Win.C1Input.DropDownFormOptionsFlags.FixedSize
        Me.ResumeLayout(False)

    End Sub

#End Region

  Private Sub button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button12.Click
    CloseDropDown(True)
  End Sub

  Private Sub button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button11.Click
        OwnerControl.BaseText = ""
  End Sub

  Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click, button2.Click, button3.Click, button4.Click, button5.Click, button6.Click, button7.Click, button8.Click, button9.Click, button10.Click
    If OwnerControl.Text.Length > 0 Or CType(sender, Button).Text <> "0" Then
      OwnerControl.Text = OwnerControl.Text + CType(sender, Control).Text
      OwnerControl.SelectionStart = OwnerControl.Text.Length
    End If
  End Sub
End Class
