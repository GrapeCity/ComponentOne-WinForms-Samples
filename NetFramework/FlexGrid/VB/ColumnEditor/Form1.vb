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
    Friend WithEvents _mycontrol As ColumnEditor.UserControl1
    'Friend WithEvents _myControl As ColumnEditor.ColumnEditor.UserControl1
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._mycontrol = New ColumnEditor.UserControl1()
        CType(Me._mycontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_mycontrol
        '
        Me._mycontrol.BackColor = System.Drawing.SystemColors.Desktop
        Me._mycontrol.ColumnInfo = "5,1,0,0,0,85,Columns:0{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Width:" & _
    "20;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._mycontrol.Dock = System.Windows.Forms.DockStyle.Fill
        Me._mycontrol.Location = New System.Drawing.Point(0, 0)
        Me._mycontrol.Name = "_mycontrol"
        Me._mycontrol.Padding = New System.Windows.Forms.Padding(5)
        Me._mycontrol.Size = New System.Drawing.Size(502, 315)
        Me._mycontrol.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(502, 315)
        Me.Controls.Add(Me._mycontrol)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Design-Time Column Editor"
        CType(Me._mycontrol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
