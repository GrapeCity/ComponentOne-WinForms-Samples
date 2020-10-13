<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlexPivotForm
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
        Me._c1FlexPivotPage = New C1.Win.FlexPivot.C1FlexPivotPage()
        CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_c1FlexPivotPage
        '
        Me._c1FlexPivotPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me._c1FlexPivotPage.Location = New System.Drawing.Point(0, 0)
        Me._c1FlexPivotPage.Margin = New System.Windows.Forms.Padding(2)
        Me._c1FlexPivotPage.Name = "_c1FlexPivotPage"
        Me._c1FlexPivotPage.Size = New System.Drawing.Size(808, 560)
        Me._c1FlexPivotPage.TabIndex = 2
        '
        'FlexPivotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 560)
        Me.Controls.Add(Me._c1FlexPivotPage)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.MinimizeBox = False
        Me.Name = "FlexPivotForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Join Query Data Analysis"
        CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents _c1FlexPivotPage As C1.Win.FlexPivot.C1FlexPivotPage
End Class
