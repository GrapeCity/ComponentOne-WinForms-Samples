<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.c1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        Me.c1Label1 = New C1.Win.C1Input.C1Label()
        Me.btnSetAsApplicationTheme = New C1.Win.C1Input.C1Button()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1ThemeController1
        '
        '
        'c1Label1
        '
        Me.c1Label1.AutoSize = True
        Me.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.c1Label1.ForeColor = System.Drawing.Color.Black
        Me.c1Label1.Location = New System.Drawing.Point(12, 9)
        Me.c1Label1.Name = "c1Label1"
        Me.c1Label1.Size = New System.Drawing.Size(168, 87)
        Me.c1Label1.TabIndex = 1
        Me.c1Label1.Tag = Nothing
        Me.c1Label1.Text = "This form demonstrates" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that changing ApplicationTheme" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on a single C1ThemeContro" & _
    "ller" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in an application automatically" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "propagates to all forms with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "theme contr" & _
    "ollers on them." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.c1Label1.TextDetached = True
        Me.c1ThemeController1.SetTheme(Me.c1Label1, "(default)")
        Me.c1Label1.UseCompatibleTextRendering = True
        '
        'btnSetAsApplicationTheme
        '
        Me.btnSetAsApplicationTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSetAsApplicationTheme.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnSetAsApplicationTheme.Location = New System.Drawing.Point(12, 227)
        Me.btnSetAsApplicationTheme.Name = "btnSetAsApplicationTheme"
        Me.btnSetAsApplicationTheme.Size = New System.Drawing.Size(139, 23)
        Me.btnSetAsApplicationTheme.TabIndex = 6
        Me.btnSetAsApplicationTheme.Text = "Clone this form"
        Me.c1ThemeController1.SetTheme(Me.btnSetAsApplicationTheme, "(default)")
        Me.btnSetAsApplicationTheme.UseVisualStyleBackColor = True
        Me.btnSetAsApplicationTheme.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Form2
        '
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnSetAsApplicationTheme)
        Me.Controls.Add(Me.c1Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Test Form"
        Me.c1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c1ThemeController1 As C1.Win.Themes.C1ThemeController
    Friend WithEvents c1Label1 As C1.Win.C1Input.C1Label
    Friend WithEvents btnSetAsApplicationTheme As C1.Win.C1Input.C1Button
End Class
