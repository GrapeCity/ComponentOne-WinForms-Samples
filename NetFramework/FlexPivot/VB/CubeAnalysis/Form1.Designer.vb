<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.c1FlexPivotPage1 = New C1.Win.FlexPivot.FlexPivotPage()
        CType(Me.c1FlexPivotPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'progressBar1
        '
        Me.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.progressBar1.Location = New System.Drawing.Point(355, 209)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(233, 15)
        Me.progressBar1.TabIndex = 3
        Me.progressBar1.Visible = False
        '
        'c1FlexPivotPage1
        '
        Me.c1FlexPivotPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexPivotPage1.Location = New System.Drawing.Point(0, 0)
        Me.c1FlexPivotPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.c1FlexPivotPage1.Name = "c1FlexPivotPage1"
        Me.c1FlexPivotPage1.Size = New System.Drawing.Size(962, 449)
        Me.c1FlexPivotPage1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 449)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.c1FlexPivotPage1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cube Analysis"
        CType(Me.c1FlexPivotPage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents c1FlexPivotPage1 As C1.Win.FlexPivot.FlexPivotPage

End Class
