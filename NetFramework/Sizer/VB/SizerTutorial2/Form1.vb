Public Class Form1
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
    Friend WithEvents C1Sizer1 As C1.Win.Sizer.C1Sizer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1Sizer1 = New C1.Win.Sizer.C1Sizer
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1Sizer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1Sizer1
        '
        Me.C1Sizer1.Controls.Add(Me.TextBox1)
        Me.C1Sizer1.Controls.Add(Me.ListView1)
        Me.C1Sizer1.Controls.Add(Me.Button1)
        Me.C1Sizer1.Controls.Add(Me.ComboBox1)
        Me.C1Sizer1.Controls.Add(Me.Label1)
        Me.C1Sizer1.Controls.Add(Me.Button2)
        Me.C1Sizer1.Controls.Add(Me.Button3)
        Me.C1Sizer1.Controls.Add(Me.Button4)
        Me.C1Sizer1.Controls.Add(Me.ComboBox2)
        Me.C1Sizer1.Controls.Add(Me.Label2)
        Me.C1Sizer1.Controls.Add(Me.Label3)
        Me.C1Sizer1.Controls.Add(Me.Button5)
        Me.C1Sizer1.Controls.Add(Me.Button6)
        Me.C1Sizer1.Controls.Add(Me.Button7)
        Me.C1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer1.GridDefinition = resources.GetString("C1Sizer1.GridDefinition")
        Me.C1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1Sizer1.Location = New System.Drawing.Point(0, 0)
        Me.C1Sizer1.Name = "C1Sizer1"
        Me.C1Sizer1.Size = New System.Drawing.Size(392, 245)
        Me.C1Sizer1.SplitterWidth = 1
        Me.C1Sizer1.TabIndex = 0
        Me.C1Sizer1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 160)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "TextBox1"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(8, 40)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(376, 112)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 21)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "x"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(88, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "ComboBox1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Look &in:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(300, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 21)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "x"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(329, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 21)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "x"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(358, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 21)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "x"
        '
        'ComboBox2
        '
        Me.ComboBox2.Location = New System.Drawing.Point(88, 184)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.Text = "ComboBox1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "File &Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "File T&ype:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(288, 160)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 20)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Open"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(288, 184)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 21)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Cancel"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(288, 208)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 21)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Help"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 245)
        Me.Controls.Add(Me.C1Sizer1)
        Me.Name = "Form1"
        Me.Text = "C1Sizer: Tutorial 2"
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1Sizer1.ResumeLayout(False)
        Me.C1Sizer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    
End Class
