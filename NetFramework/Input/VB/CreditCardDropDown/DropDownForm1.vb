

Public Class DropDownForm1
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
  Friend WithEvents button2 As System.Windows.Forms.Button
  Friend WithEvents button1 As System.Windows.Forms.Button
  Friend WithEvents radioButton3 As System.Windows.Forms.RadioButton
  Friend WithEvents radioButton2 As System.Windows.Forms.RadioButton
  Friend WithEvents radioButton1 As System.Windows.Forms.RadioButton
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.button2 = New System.Windows.Forms.Button()
    Me.button1 = New System.Windows.Forms.Button()
    Me.radioButton3 = New System.Windows.Forms.RadioButton()
    Me.radioButton2 = New System.Windows.Forms.RadioButton()
    Me.radioButton1 = New System.Windows.Forms.RadioButton()
    Me.SuspendLayout()
    '
    'button2
    '
    Me.button2.BackColor = System.Drawing.SystemColors.Control
    Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.button2.Location = New System.Drawing.Point(151, 40)
    Me.button2.Name = "button2"
    Me.button2.TabIndex = 9
    Me.button2.Text = "Cancel"
    '
    'button1
    '
    Me.button1.BackColor = System.Drawing.SystemColors.Control
    Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.button1.Location = New System.Drawing.Point(151, 8)
    Me.button1.Name = "button1"
    Me.button1.TabIndex = 8
    Me.button1.Text = "OK"
    '
    'radioButton3
    '
    Me.radioButton3.Location = New System.Drawing.Point(7, 56)
    Me.radioButton3.Name = "radioButton3"
    Me.radioButton3.Size = New System.Drawing.Size(120, 24)
    Me.radioButton3.TabIndex = 7
    Me.radioButton3.Text = "American Express"
    '
    'radioButton2
    '
    Me.radioButton2.Location = New System.Drawing.Point(7, 32)
    Me.radioButton2.Name = "radioButton2"
    Me.radioButton2.Size = New System.Drawing.Size(120, 24)
    Me.radioButton2.TabIndex = 6
    Me.radioButton2.Text = "Master Card"
    '
    'radioButton1
    '
    Me.radioButton1.Checked = True
    Me.radioButton1.Location = New System.Drawing.Point(7, 8)
    Me.radioButton1.Name = "radioButton1"
    Me.radioButton1.Size = New System.Drawing.Size(120, 24)
    Me.radioButton1.TabIndex = 5
    Me.radioButton1.TabStop = True
    Me.radioButton1.Text = "Visa"
    '
    'DropDownForm1
    '
    Me.AcceptButton = Me.button1
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.BackColor = System.Drawing.Color.LightGray
    Me.CancelButton = Me.button2
    Me.ClientSize = New System.Drawing.Size(232, 96)
    Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.button2, Me.button1, Me.radioButton3, Me.radioButton2, Me.radioButton1})
    Me.FocusControl = Me.button1
    Me.MinimumSize = New System.Drawing.Size(232, 96)
    Me.Name = "DropDownForm1"
    Me.Options = (C1.Win.C1Input.DropDownFormOptionsFlags.Focusable Or C1.Win.C1Input.DropDownFormOptionsFlags.NoPostOnEnter)
    Me.ResumeLayout(False)

  End Sub

#End Region


  Private Sub DropDownForm1_PostChanges(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PostChanges
    Dim ctl As Control
    If Me.DialogResult = DialogResult.OK Then
      For Each ctl In Me.Controls
        If TypeOf (ctl) Is RadioButton Then
          If CType(ctl, RadioButton).Checked Then
            OwnerControl.Value = ctl.Text
          End If
        End If
      Next
    End If
  End Sub

End Class
