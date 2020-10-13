
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms



'/ <summary>
'/ Summary description for frmCanvas.
'/ </summary>
Public Class frmCanvas
   Inherits System.Windows.Forms.Form
   Public pictureBox1 As System.Windows.Forms.PictureBox
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem2 As System.Windows.Forms.MenuItem
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
      Me.pictureBox1 = New System.Windows.Forms.PictureBox()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuItem2 = New System.Windows.Forms.MenuItem()
      Me.SuspendLayout()
      ' 
      ' pictureBox1
      ' 
      Me.pictureBox1.Location = New System.Drawing.Point(8, 8)
      Me.pictureBox1.Name = "pictureBox1"
      Me.pictureBox1.Size = New System.Drawing.Size(292, 273)
      Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
      Me.pictureBox1.TabIndex = 0
      Me.pictureBox1.TabStop = False
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
      ' 
      ' menuItem1
      ' 
      Me.menuItem1.Index = 0
      Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2})
      Me.menuItem1.Text = "Image Size"
      ' 
      ' menuItem2
      ' 
      Me.menuItem2.Index = 0
      Me.menuItem2.Text = "Stretch"
      ' 
      ' frmCanvas
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.AutoScroll = True
      Me.ClientSize = New System.Drawing.Size(360, 313)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pictureBox1})
      Me.Menu = Me.mainMenu1
      Me.Name = "frmCanvas"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Image Output"
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent
    
#End Region
   Private Sub menuItem2_Click(sender As Object, e As System.EventArgs) Handles menuItem2.Click
      Dim mi As MenuItem = CType(sender, MenuItem)
      mi.Checked = Not mi.Checked
      If mi.Checked Then
         Me.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
         pictureBox1.Dock = DockStyle.Fill
      Else
         pictureBox1.Dock = DockStyle.None
         Me.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
      End If
   End Sub 'menuItem2_Click
End Class 'frmCanvas
