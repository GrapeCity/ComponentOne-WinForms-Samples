
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms



'/ <summary>
'/ Summary description for RtfForm.
'/ </summary>
Public Class RtfForm
   Inherits System.Windows.Forms.Form
   WithEvents btnFont As System.Windows.Forms.Button
   WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   Private fontDialog1 As System.Windows.Forms.FontDialog
   Private btnOk As System.Windows.Forms.Button
   Private btnCancel As System.Windows.Forms.Button
   Private label1 As System.Windows.Forms.Label
   WithEvents comboBox1 As System.Windows.Forms.ComboBox
   Private label2 As System.Windows.Forms.Label
   
   
   Public Property Rtf() As String
      Get
         Return richTextBox1.Rtf
      End Get
      Set
         richTextBox1.Rtf = value
      End Set
   End Property
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
      InitializeComponent()
   End Sub 'New
    
   '
   ' TODO: Add any constructor code after InitializeComponent call
   '
   
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
      Me.btnFont = New System.Windows.Forms.Button()
      Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
      Me.fontDialog1 = New System.Windows.Forms.FontDialog()
      Me.btnOk = New System.Windows.Forms.Button()
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.label1 = New System.Windows.Forms.Label()
      Me.comboBox1 = New System.Windows.Forms.ComboBox()
      Me.label2 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      ' 
      ' btnFont
      ' 
      Me.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnFont.Location = New System.Drawing.Point(64, 8)
      Me.btnFont.Name = "btnFont"
      Me.btnFont.Size = New System.Drawing.Size(160, 21)
      Me.btnFont.TabIndex = 0
      Me.btnFont.Text = "button1"
      ' 
      ' richTextBox1
      ' 
      Me.richTextBox1.AcceptsTab = True
      Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.richTextBox1.HideSelection = False
      Me.richTextBox1.Location = New System.Drawing.Point(0, 40)
      Me.richTextBox1.Name = "richTextBox1"
      Me.richTextBox1.Size = New System.Drawing.Size(392, 201)
      Me.richTextBox1.TabIndex = 1
      Me.richTextBox1.Text = "richTextBox1"
      ' 
      ' fontDialog1
      ' 
      Me.fontDialog1.ShowColor = True
      ' 
      ' btnOk
      ' 
      Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
      Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnOk.Location = New System.Drawing.Point(200, 248)
      Me.btnOk.Name = "btnOk"
      Me.btnOk.TabIndex = 2
      Me.btnOk.Text = "OK"
      ' 
      ' btnCancel
      ' 
      Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
      Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnCancel.Location = New System.Drawing.Point(296, 248)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.TabIndex = 3
      Me.btnCancel.Text = "Cancel"
      ' 
      ' label1
      ' 
      Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.label1.Location = New System.Drawing.Point(0, 8)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(56, 21)
      Me.label1.TabIndex = 4
      Me.label1.Text = "Font:"
      Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' comboBox1
      ' 
      Me.comboBox1.BackColor = System.Drawing.SystemColors.Control
      Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.comboBox1.Items.AddRange(New Object() {"Left", "Center", "Right"})
      Me.comboBox1.Location = New System.Drawing.Point(328, 8)
      Me.comboBox1.Name = "comboBox1"
      Me.comboBox1.Size = New System.Drawing.Size(64, 21)
      Me.comboBox1.TabIndex = 5
      ' 
      ' label2
      ' 
      Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.label2.Location = New System.Drawing.Point(256, 8)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(64, 21)
      Me.label2.TabIndex = 6
      Me.label2.Text = "Alignment:"
      Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' RtfForm
      ' 
      Me.AcceptButton = Me.btnOk
      Me.CancelButton = Me.btnCancel
      Me.ClientSize = New System.Drawing.Size(392, 273)
      Me.ControlBox = False
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label2, Me.comboBox1, Me.label1, Me.btnCancel, Me.btnOk, Me.richTextBox1, Me.btnFont})
      Me.DockPadding.Bottom = 32
      Me.DockPadding.Top = 40
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "RtfForm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Edit rtf"
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent
    
#End Region
   Private Sub RtfForm_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      updateFont()
      updateAlignment()
   End Sub 'RtfForm_Load
   
   
   Private Sub btnFont_Click(sender As Object, e As System.EventArgs) Handles btnFont.Click
      If fontDialog1.ShowDialog() <> DialogResult.Cancel Then
         richTextBox1.SelectionColor = fontDialog1.Color
         richTextBox1.SelectionFont = fontDialog1.Font
         
         updateFont()
      End If
   End Sub 'btnFont_Click
   
   
   Private Sub updateFont()
      btnFont.ForeColor = richTextBox1.SelectionColor
      btnFont.Text = String.Format("{0}, {1}pt", richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.SizeInPoints)
   End Sub 'updateFont
   
   
   Private Sub updateAlignment()
      comboBox1.SelectedItem = richTextBox1.SelectionAlignment.ToString()
   End Sub 'updateAlignment
   
   
   Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
      richTextBox1.SelectionAlignment = CType([Enum].Parse(GetType(HorizontalAlignment), comboBox1.SelectedItem.ToString()), HorizontalAlignment)
   End Sub 'comboBox1_SelectedIndexChanged
   
   
   Private Sub richTextBox1_SelectionChanged(sender As Object, e As System.EventArgs) Handles richTextBox1.SelectionChanged
      updateAlignment()
   End Sub 'richTextBox1_SelectionChanged
End Class 'RtfForm
