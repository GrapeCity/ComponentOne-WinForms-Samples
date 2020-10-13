
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms



'/ <summary>
'/ Summary description for Form3.
'/ </summary>
Public Class frmClientSize
   Inherits System.Windows.Forms.Form
   WithEvents btnOK As System.Windows.Forms.Button
   WithEvents btnCancel As System.Windows.Forms.Button
   WithEvents btnApply As System.Windows.Forms.Button
   Private labWidth As System.Windows.Forms.Label
   Private labHeight As System.Windows.Forms.Label
   Private txtWidth As System.Windows.Forms.TextBox
   Private txtHeight As System.Windows.Forms.TextBox
   Private allowExit As Boolean = False
   Private clientForm As Form = Nothing
   
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
      Me.btnOK = New System.Windows.Forms.Button()
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.btnApply = New System.Windows.Forms.Button()
      Me.labWidth = New System.Windows.Forms.Label()
      Me.labHeight = New System.Windows.Forms.Label()
      Me.txtWidth = New System.Windows.Forms.TextBox()
      Me.txtHeight = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      ' 
      ' btnOK
      ' 
      Me.btnOK.Location = New System.Drawing.Point(8, 72)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.Size = New System.Drawing.Size(64, 24)
      Me.btnOK.TabIndex = 0
      Me.btnOK.Text = "&OK"
      ' 
      ' btnCancel
      ' 
      Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancel.Location = New System.Drawing.Point(80, 72)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.Size = New System.Drawing.Size(64, 24)
      Me.btnCancel.TabIndex = 1
      Me.btnCancel.Text = "&Cancel"
      ' 
      ' btnApply
      ' 
      Me.btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnApply.Location = New System.Drawing.Point(184, 72)
      Me.btnApply.Name = "btnApply"
      Me.btnApply.Size = New System.Drawing.Size(64, 24)
      Me.btnApply.TabIndex = 2
      Me.btnApply.Text = "&Apply"
      ' 
      ' labWidth
      ' 
      Me.labWidth.Location = New System.Drawing.Point(8, 24)
      Me.labWidth.Name = "labWidth"
      Me.labWidth.Size = New System.Drawing.Size(40, 24)
      Me.labWidth.TabIndex = 3
      Me.labWidth.Text = "&Width:"
      ' 
      ' labHeight
      ' 
      Me.labHeight.Location = New System.Drawing.Point(152, 24)
      Me.labHeight.Name = "labHeight"
      Me.labHeight.Size = New System.Drawing.Size(40, 23)
      Me.labHeight.TabIndex = 4
      Me.labHeight.Text = "&Height:"
      ' 
      ' txtWidth
      ' 
      Me.txtWidth.Location = New System.Drawing.Point(48, 24)
      Me.txtWidth.Name = "txtWidth"
      Me.txtWidth.Size = New System.Drawing.Size(50, 20)
      Me.txtWidth.TabIndex = 5
      Me.txtWidth.Text = "0"
      ' 
      ' txtHeight
      ' 
      Me.txtHeight.Location = New System.Drawing.Point(200, 24)
      Me.txtHeight.Name = "txtHeight"
      Me.txtHeight.Size = New System.Drawing.Size(50, 20)
      Me.txtHeight.TabIndex = 6
      Me.txtHeight.Text = "0"
      ' 
      ' frmClientSize
      ' 
      Me.AcceptButton = Me.btnOK
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.CancelButton = Me.btnCancel
      Me.ClientSize = New System.Drawing.Size(264, 109)
      Me.ControlBox = False
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtHeight, Me.txtWidth, Me.labHeight, Me.labWidth, Me.btnApply, Me.btnCancel, Me.btnOK})
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmClientSize"
      Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Set Chart Form ClientSize ..."
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent
    
#End Region
   Public Sub SetClientForm(frm As Form)
      clientForm = frm
      txtWidth.Text = frm.ClientSize.Width.ToString()
      txtHeight.Text = frm.ClientSize.Height.ToString()
   End Sub 'SetClientForm
   
   
   Private Sub btnApply_Click(sender As Object, e As System.EventArgs) Handles btnApply.Click
      Dim minbound As Integer = 10
      Dim w As Integer = minbound
      Dim h As Integer = minbound
      
      allowExit = False
      
      Try
         w = Int32.Parse(txtWidth.Text)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
         txtWidth.Focus()
         Return
      End Try
      
      Try
         h = Int32.Parse(txtHeight.Text)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
         txtHeight.Focus()
         Return
      End Try
      
      If w < minbound Then
         MessageBox.Show(("Minimum client width is " + minbound.ToString()))
         w = 10
      End If
      
      If h < minbound Then
         MessageBox.Show(("Minimum client width is " + minbound.ToString()))
         h = 10
      End If
      
      clientForm.ClientSize = New Size(w, h)
      allowExit = True
   End Sub 'btnApply_Click
   
   
   Private Sub btnOK_Click(sender As Object, e As System.EventArgs) Handles btnOK.Click
      btnApply_Click(sender, e)
      If allowExit Then
         Close()
      End If
   End Sub 'btnOK_Click
    
   Private Sub btnCancel_Click(sender As Object, e As System.EventArgs) Handles btnCancel.Click
      Close()
   End Sub 'btnCancel_Click
End Class 'frmClientSize
