<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientSideQuerying
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
        Me.labelCount = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cutButton = New System.Windows.Forms.Button()
        Me.raiseButton = New System.Windows.Forms.Button()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelCount
        '
        Me.labelCount.AutoSize = True
        Me.labelCount.Location = New System.Drawing.Point(665, 22)
        Me.labelCount.Name = "labelCount"
        Me.labelCount.Size = New System.Drawing.Size(57, 13)
        Me.labelCount.TabIndex = 15
        Me.labelCount.Text = "labelCount"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(621, 22)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 13)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Count:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(29, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(397, 16)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Non-discontinued Products with Unit Price Higher than $30"
        '
        'cutButton
        '
        Me.cutButton.Location = New System.Drawing.Point(870, 520)
        Me.cutButton.Name = "cutButton"
        Me.cutButton.Size = New System.Drawing.Size(167, 23)
        Me.cutButton.TabIndex = 11
        Me.cutButton.Text = "Lower Seafood Prices by 20%"
        Me.cutButton.UseVisualStyleBackColor = True
        '
        'raiseButton
        '
        Me.raiseButton.Location = New System.Drawing.Point(697, 520)
        Me.raiseButton.Name = "raiseButton"
        Me.raiseButton.Size = New System.Drawing.Size(167, 23)
        Me.raiseButton.TabIndex = 10
        Me.raiseButton.Text = "Raise Seafood Prices by 20%"
        Me.raiseButton.UseVisualStyleBackColor = True
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:"
        Me.C1FlexGrid1.Location = New System.Drawing.Point(32, 48)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1005, 443)
        Me.C1FlexGrid1.TabIndex = 16
        '
        'ClientSideQuerying
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 563)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.labelCount)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cutButton)
        Me.Controls.Add(Me.raiseButton)
        Me.Name = "ClientSideQuerying"
        Me.Text = "ClientSideQuerying"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents labelCount As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cutButton As System.Windows.Forms.Button
    Private WithEvents raiseButton As System.Windows.Forms.Button
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
End Class
