Public Class Form2
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        ' 
        ' label1
        ' 
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Integer"
        ' 
        ' textBox1
        ' 
        Me.TextBox1.Location = New System.Drawing.Point(136, 24)
        Me.TextBox1.Name = "textBox1"
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "textBox1"
        ' 
        ' label2
        ' 
        Me.Label2.Location = New System.Drawing.Point(8, 80)
        Me.Label2.Name = "label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "string"
        ' 
        ' textBox2
        ' 
        Me.TextBox2.Location = New System.Drawing.Point(136, 88)
        Me.TextBox2.Name = "textBox2"
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "textBox2"
        ' 
        ' button1
        ' 
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(104, 144)
        Me.Button1.Name = "button1"
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cancel"
        ' 
        ' button2
        ' 
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.Location = New System.Drawing.Point(224, 144)
        Me.Button2.Name = "button2"
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "OK"
        ' 
        ' Form2
        ' 
        Me.AcceptButton = Me.Button2
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(320, 174)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.Button1, Me.TextBox2, Me.Label2, Me.TextBox1, Me.Label1})
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
