
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms



'/ <summary>
'/ Summary description for InputValueForm.
'/ </summary>
Public Class InputValueForm
   Inherits System.Windows.Forms.Form
   Private tbValue As System.Windows.Forms.TextBox
   WithEvents btnOk As System.Windows.Forms.Button
   WithEvents btnCancel As System.Windows.Forms.Button
   WithEvents btnHole As System.Windows.Forms.Button
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      InitializeComponent()
   End Sub 'New
   
   
   Public Property ZValue() As Double
      Get
         ' return exactly the same hole value
         If tbValue.Text.Equals("(Hole)") Then
            Return m_hole
         End If
         Try
            Return Double.Parse(tbValue.Text)
         Catch
            Return m_hole
         End Try
      End Get
      Set
         tbValue.Text = value.ToString()
      End Set
   End Property
   
   Private m_hole As Double = Double.NaN
   
   Public Property Hole() As Double
      Get
         Return m_hole
      End Get
      Set
         m_hole = value
      End Set
   End Property
   
   
   '/ <summary>
   '/ Clean up any resources being used.
   '/ </summary>
   Protected Overloads Overrides Sub Dispose(disposing As Boolean) 
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub 'Dispose
   
   
#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      Me.tbValue = New System.Windows.Forms.TextBox()
      Me.btnOk = New System.Windows.Forms.Button()
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.btnHole = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      ' 
      ' tbValue
      ' 
      Me.tbValue.Location = New System.Drawing.Point(16, 16)
      Me.tbValue.Name = "tbValue"
      Me.tbValue.Size = New System.Drawing.Size(104, 20)
      Me.tbValue.TabIndex = 0
      Me.tbValue.Text = ""
      ' 
      ' btnOk
      ' 
      Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.btnOk.Location = New System.Drawing.Point(16, 56)
      Me.btnOk.Name = "btnOk"
      Me.btnOk.Size = New System.Drawing.Size(75, 20)
      Me.btnOk.TabIndex = 1
      Me.btnOk.Text = "OK"
      ' 
      ' btnCancel
      ' 
      Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancel.Location = New System.Drawing.Point(136, 56)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.Size = New System.Drawing.Size(75, 20)
      Me.btnCancel.TabIndex = 2
      Me.btnCancel.Text = "Cancel"
      ' 
      ' btnHole
      ' 
      Me.btnHole.Location = New System.Drawing.Point(136, 16)
      Me.btnHole.Name = "btnHole"
      Me.btnHole.Size = New System.Drawing.Size(75, 20)
      Me.btnHole.TabIndex = 3
      Me.btnHole.Text = "Set Hole"
      ' 
      ' InputValueForm
      ' 
      Me.AcceptButton = Me.btnOk
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.CancelButton = Me.btnCancel
      Me.ClientSize = New System.Drawing.Size(226, 87)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnHole, Me.btnCancel, Me.btnOk, Me.tbValue})
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.Name = "InputValueForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Enter Z-Value"
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent
    
#End Region
   Private Sub btnHole_Click(sender As Object, e As System.EventArgs) Handles btnHole.Click
      If Hole <> Double.NaN Then
         tbValue.Text = "(Hole)"
      End If
   End Sub 'btnHole_Click
End Class 'InputValueForm
