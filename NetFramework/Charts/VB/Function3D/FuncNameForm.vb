
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms



'/ <summary>
'/ Summary description for FuncNameForm.
'/ </summary>
Public Class FuncNameForm
   Inherits System.Windows.Forms.Form
   WithEvents btnOk As System.Windows.Forms.Button
   WithEvents btnCancel As System.Windows.Forms.Button
   Public tbFName As System.Windows.Forms.TextBox
   
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      InitializeComponent()
   End Sub 'New
   
   
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
      tbFName = New System.Windows.Forms.TextBox()
      Me.btnOk = New System.Windows.Forms.Button()
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      ' 
      ' tbFName
      ' 
      tbFName.Location = New System.Drawing.Point(16, 16)
      tbFName.Name = "tbFName"
      tbFName.Size = New System.Drawing.Size(280, 20)
      tbFName.TabIndex = 0
      tbFName.Text = "Function1"
      ' 
      ' btnOk
      ' 
      Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.btnOk.Location = New System.Drawing.Point(128, 48)
      Me.btnOk.Name = "btnOk"
      Me.btnOk.TabIndex = 1
      Me.btnOk.Text = "Ok"
      ' 
      ' btnCancel
      ' 
      Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancel.Location = New System.Drawing.Point(220, 48)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.TabIndex = 2
      Me.btnCancel.Text = "Cancel"
      ' 
      ' FuncNameForm
      ' 
      Me.AcceptButton = Me.btnOk
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.CancelButton = Me.btnCancel
      Me.ClientSize = New System.Drawing.Size(314, 79)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnOk, tbFName})
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FuncNameForm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Enter function name"
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent 
#End Region
   
   Public Property FName() As String
      Get
         Return tbFName.Text
      End Get
      Set
         tbFName.Text = value
      End Set
   End Property
End Class 'FuncNameForm 
