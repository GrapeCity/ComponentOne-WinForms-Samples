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
        Me._c1FlexPivotPage = New C1.Win.FlexPivot.C1FlexPivotPage()
        Me._chkCustomColumns = New System.Windows.Forms.CheckBox()
        CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_c1FlexPivotPage
        '
        Me._c1FlexPivotPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me._c1FlexPivotPage.Location = New System.Drawing.Point(0, 25)
        Me._c1FlexPivotPage.Margin = New System.Windows.Forms.Padding(2)
        Me._c1FlexPivotPage.Name = "_c1FlexPivotPage"
        Me._c1FlexPivotPage.Size = New System.Drawing.Size(774, 514)
        Me._c1FlexPivotPage.TabIndex = 2
        '
        '_chkCustomColumns
        '
        Me._chkCustomColumns.AutoSize = True
        Me._chkCustomColumns.Checked = True
        Me._chkCustomColumns.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkCustomColumns.Dock = System.Windows.Forms.DockStyle.Top
        Me._chkCustomColumns.Location = New System.Drawing.Point(0, 0)
        Me._chkCustomColumns.Margin = New System.Windows.Forms.Padding(2)
        Me._chkCustomColumns.Name = "_chkCustomColumns"
        Me._chkCustomColumns.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me._chkCustomColumns.Size = New System.Drawing.Size(774, 25)
        Me._chkCustomColumns.TabIndex = 3
        Me._chkCustomColumns.Text = "Add Custom Calculated Columns to the FlexPivot Output Table"
        Me._chkCustomColumns.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 539)
        Me.Controls.Add(Me._c1FlexPivotPage)
        Me.Controls.Add(Me._chkCustomColumns)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Columns"
        CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents _c1FlexPivotPage As C1.Win.FlexPivot.C1FlexPivotPage
    Private WithEvents _chkCustomColumns As System.Windows.Forms.CheckBox

End Class
