
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms



'/ <summary>
'/ Summary description for Form4.
'/ </summary>
Public Class frmLoadURL
   Inherits System.Windows.Forms.Form
   Private labEnterURL As System.Windows.Forms.Label
   Private txtURL As System.Windows.Forms.TextBox
   WithEvents btnOK As System.Windows.Forms.Button
   WithEvents btnCancel As System.Windows.Forms.Button
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
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
      Me.labEnterURL = New System.Windows.Forms.Label()
      Me.txtURL = New System.Windows.Forms.TextBox()
      Me.btnOK = New System.Windows.Forms.Button()
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      ' 
      ' labEnterURL
      ' 
      Me.labEnterURL.Location = New System.Drawing.Point(8, 24)
      Me.labEnterURL.Name = "labEnterURL"
      Me.labEnterURL.Size = New System.Drawing.Size(72, 16)
      Me.labEnterURL.TabIndex = 0
      Me.labEnterURL.Text = "Enter URL:"
      ' 
      ' txtURL
      ' 
      Me.txtURL.Location = New System.Drawing.Point(24, 48)
      Me.txtURL.Name = "txtURL"
      Me.txtURL.Size = New System.Drawing.Size(496, 20)
      Me.txtURL.TabIndex = 1
      Me.txtURL.Text = ""
      ' 
      ' btnOK
      ' 
      Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.btnOK.Location = New System.Drawing.Point(360, 96)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.TabIndex = 2
      Me.btnOK.Text = "&OK"
      ' 
      ' btnCancel
      ' 
      Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancel.Location = New System.Drawing.Point(448, 96)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.TabIndex = 3
      Me.btnCancel.Text = "&Cancel"
      ' 
      ' frmLoadURL
      ' 
      Me.AcceptButton = Me.btnOK
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.CancelButton = Me.btnCancel
      Me.ClientSize = New System.Drawing.Size(542, 133)
      Me.ControlBox = False
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnOK, Me.txtURL, Me.labEnterURL})
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmLoadURL"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Load Chart from URL..."
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent 
#End Region
   
   Public Property URL() As String
      Get
         Return txtURL.Text
      End Get
      Set
         txtURL.Text = value
      End Set
   End Property
End Class 'frmLoadURL
