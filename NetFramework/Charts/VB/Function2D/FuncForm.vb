
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms



'/ <summary>
'/ Summary description for FuncForm.
'/ </summary>
Public Class FuncForm
   Inherits System.Windows.Forms.Form
   WithEvents tbCode As System.Windows.Forms.TextBox
   WithEvents btnOK As System.Windows.Forms.Button
   WithEvents btnCancel As System.Windows.Forms.Button
   WithEvents tbMinX As System.Windows.Forms.TextBox
   Private label3 As System.Windows.Forms.Label
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   Private udN As System.Windows.Forms.NumericUpDown
   WithEvents tbMaxX As System.Windows.Forms.TextBox
   Private errorProvider1 As System.Windows.Forms.ErrorProvider
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   Private m_engine As Engine = Nothing
   
   
   Public Sub New(engine As Engine)
      InitializeComponent()
      m_engine = engine
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
   
   
   Public Property Code() As String
      Get
         Return tbCode.Text
      End Get
      Set
         tbCode.Text = value
      End Set
   End Property
   
   
   Public Property MinX() As Single
      Get
         Return Single.Parse(tbMinX.Text)
      End Get
      Set
         tbMinX.Text = value.ToString()
      End Set
   End Property
   
   
   Public Property MaxX() As Single
      Get
         Return Single.Parse(tbMaxX.Text)
      End Get
      Set
         tbMaxX.Text = value.ToString()
      End Set
   End Property
   
   
   Public Property NPts() As Integer
      Get
         Return CInt(udN.Value)
      End Get
      Set
         udN.Value = value
      End Set
   End Property
   
   
   
#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      tbCode = New System.Windows.Forms.TextBox()
      Me.btnOK = New System.Windows.Forms.Button()
      Me.btnCancel = New System.Windows.Forms.Button()
      Me.udN = New System.Windows.Forms.NumericUpDown()
      tbMaxX = New System.Windows.Forms.TextBox()
      tbMinX = New System.Windows.Forms.TextBox()
      Me.label3 = New System.Windows.Forms.Label()
      Me.label1 = New System.Windows.Forms.Label()
      Me.label2 = New System.Windows.Forms.Label()
      Me.errorProvider1 = New System.Windows.Forms.ErrorProvider()
      CType(Me.udN, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' tbCode
      ' 
      tbCode.Location = New System.Drawing.Point(16, 16)
      tbCode.Name = "tbCode"
      tbCode.Size = New System.Drawing.Size(272, 20)
      tbCode.TabIndex = 0
      tbCode.Text = "x"
      ' 
      ' btnOK
      ' 
      Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.btnOK.Location = New System.Drawing.Point(120, 104)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.Size = New System.Drawing.Size(75, 20)
      Me.btnOK.TabIndex = 4
      Me.btnOK.Text = "OK"
      ' 
      ' btnCancel
      ' 
      Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnCancel.Location = New System.Drawing.Point(216, 104)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.Size = New System.Drawing.Size(75, 20)
      Me.btnCancel.TabIndex = 5
      Me.btnCancel.Text = "Cancel"
      ' 
      ' udN
      ' 
      Me.udN.Location = New System.Drawing.Point(192, 64)
      Me.udN.Minimum = New System.Decimal(New Integer() {2, 0, 0, 0})
      Me.udN.Name = "udN"
      Me.udN.Size = New System.Drawing.Size(56, 20)
      Me.udN.TabIndex = 3
      Me.udN.Value = New System.Decimal(New Integer() {20, 0, 0, 0})
      ' 
      ' tbMaxX
      ' 
      tbMaxX.Location = New System.Drawing.Point(104, 64)
      tbMaxX.Name = "tbMaxX"
      tbMaxX.Size = New System.Drawing.Size(56, 20)
      tbMaxX.TabIndex = 2
      tbMaxX.Text = "10"
      ' 
      ' tbMinX
      ' 
      tbMinX.Location = New System.Drawing.Point(16, 64)
      tbMinX.Name = "tbMinX"
      tbMinX.Size = New System.Drawing.Size(56, 20)
      tbMinX.TabIndex = 1
      tbMinX.Text = "0"
      ' 
      ' label3
      ' 
      Me.label3.Location = New System.Drawing.Point(192, 48)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(96, 23)
      Me.label3.TabIndex = 6
      Me.label3.Text = "Number of points"
      ' 
      ' label1
      ' 
      Me.label1.Location = New System.Drawing.Point(16, 48)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(48, 16)
      Me.label1.TabIndex = 7
      Me.label1.Text = "Min X"
      ' 
      ' label2
      ' 
      Me.label2.Location = New System.Drawing.Point(104, 48)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(48, 16)
      Me.label2.TabIndex = 8
      Me.label2.Text = "Max X"
      ' 
      ' FuncForm
      ' 
      Me.AcceptButton = Me.btnOK
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.CancelButton = Me.btnCancel
      Me.ClientSize = New System.Drawing.Size(306, 133)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label2, Me.label1, Me.btnCancel, Me.btnOK, tbCode, tbMinX, tbMaxX, Me.udN, Me.label3})
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FuncForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Edit Function"
      CType(Me.udN, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent
    
#End Region
   Private Sub tbFloat_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbMaxX.Validating, tbMinX.Validating
      Dim tb As TextBox = CType(sender, TextBox)
      Try
         Single.Parse(tb.Text)
         errorProvider1.SetError(tb, Nothing)
      Catch ex As Exception
         e.Cancel = True
         errorProvider1.SetError(tb, ex.Message)
      End Try
   End Sub 'tbFloat_Validating
   
   
   Private Sub tbCode_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbCode.Validating
      If Not m_engine.Compile(tbCode.Text) Then
         e.Cancel = True
         errorProvider1.SetError(tbCode, m_engine.Errors(0))
      Else
         errorProvider1.SetError(tbCode, Nothing)
      End If
   End Sub 'tbCode_Validating
End Class 'FuncForm
