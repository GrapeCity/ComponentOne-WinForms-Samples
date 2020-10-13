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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnFindIndexing = New System.Windows.Forms.Button()
        Me.lbxResult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(50, 43)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(344, 28)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Find all orders for the first customer"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnFindIndexing
        '
        Me.btnFindIndexing.Location = New System.Drawing.Point(50, 113)
        Me.btnFindIndexing.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFindIndexing.Name = "btnFindIndexing"
        Me.btnFindIndexing.Size = New System.Drawing.Size(344, 28)
        Me.btnFindIndexing.TabIndex = 1
        Me.btnFindIndexing.Text = "Find all orders for the first customer (using indexing)"
        Me.btnFindIndexing.UseVisualStyleBackColor = True
        '
        'lbxResult
        '
        Me.lbxResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxResult.HorizontalScrollbar = True
        Me.lbxResult.ItemHeight = 16
        Me.lbxResult.Location = New System.Drawing.Point(5, 184)
        Me.lbxResult.Name = "lbxResult"
        Me.lbxResult.Size = New System.Drawing.Size(439, 80)
        Me.lbxResult.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 269)
        Me.Controls.Add(Me.lbxResult)
        Me.Controls.Add(Me.btnFindIndexing)
        Me.Controls.Add(Me.btnFind)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Improve LINQ performance using indexing"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnFindIndexing As System.Windows.Forms.Button
    Friend WithEvents lbxResult As ListBox
End Class
