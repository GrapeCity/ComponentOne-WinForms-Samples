
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms



'/ <summary>
'/ Summary description for Form2.
'/ </summary>
Public Class frmPropGrid
   Inherits System.Windows.Forms.Form
   Private propertyGrid1 As System.Windows.Forms.PropertyGrid
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
      Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
      Me.SuspendLayout()
      ' 
      ' propertyGrid1
      ' 
      Me.propertyGrid1.CommandsVisibleIfAvailable = True
      Me.propertyGrid1.LargeButtons = False
      Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
      Me.propertyGrid1.Name = "propertyGrid1"
      Me.propertyGrid1.Size = New System.Drawing.Size(320, 424)
      Me.propertyGrid1.TabIndex = 0
      Me.propertyGrid1.Text = "propertyGrid1"
      Me.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window
      Me.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText
      ' 
      ' frmPropGrid
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(400, 533)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.propertyGrid1})
      Me.Name = "frmPropGrid"
      Me.Text = "Chart Properties"
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent
    
#End Region
   Private Sub frmPropGrid_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      propertyGrid1.Location = New Point(0)
      propertyGrid1.Size = Me.ClientSize
      propertyGrid1.ToolbarVisible = True
      propertyGrid1.Refresh()
   End Sub 'frmPropGrid_Load
   
   
   Private Sub frmPropGrid_Resize(sender As Object, e As System.EventArgs) Handles MyBase.Resize
      propertyGrid1.Size = Me.ClientSize
   End Sub 'frmPropGrid_Resize
   
   
   Public Property ChartObject() As Object
      Get
         Return propertyGrid1.SelectedObject
      End Get
      Set
         propertyGrid1.SelectedObject = value
      End Set
   End Property
End Class 'frmPropGrid
