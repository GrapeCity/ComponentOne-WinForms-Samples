<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.buttonUndo = New System.Windows.Forms.Button()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.buttonEdit = New System.Windows.Forms.Button()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.ordersGrid = New System.Windows.Forms.DataGridView()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.ordersGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonClose
        '
        Me.buttonClose.Location = New System.Drawing.Point(496, 283)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 13
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'buttonUndo
        '
        Me.buttonUndo.Location = New System.Drawing.Point(391, 283)
        Me.buttonUndo.Name = "buttonUndo"
        Me.buttonUndo.Size = New System.Drawing.Size(95, 23)
        Me.buttonUndo.TabIndex = 12
        Me.buttonUndo.Text = "Undo Changes"
        Me.buttonUndo.UseVisualStyleBackColor = True
        '
        'buttonDelete
        '
        Me.buttonDelete.Location = New System.Drawing.Point(141, 248)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(53, 23)
        Me.buttonDelete.TabIndex = 11
        Me.buttonDelete.Text = "Delete"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'buttonEdit
        '
        Me.buttonEdit.Location = New System.Drawing.Point(81, 248)
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Size = New System.Drawing.Size(53, 23)
        Me.buttonEdit.TabIndex = 10
        Me.buttonEdit.Text = "Edit"
        Me.buttonEdit.UseVisualStyleBackColor = True
        '
        'buttonAdd
        '
        Me.buttonAdd.Location = New System.Drawing.Point(21, 248)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(53, 23)
        Me.buttonAdd.TabIndex = 9
        Me.buttonAdd.Text = "Add"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'ordersGrid
        '
        Me.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ordersGrid.Location = New System.Drawing.Point(21, 39)
        Me.ordersGrid.Name = "ordersGrid"
        Me.ordersGrid.Size = New System.Drawing.Size(550, 203)
        Me.ordersGrid.TabIndex = 8
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(18, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Orders:"
        '
        'CustomerControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.buttonUndo)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.buttonEdit)
        Me.Controls.Add(Me.buttonAdd)
        Me.Controls.Add(Me.ordersGrid)
        Me.Controls.Add(Me.label1)
        Me.Name = "CustomerControl"
        Me.Size = New System.Drawing.Size(589, 329)
        CType(Me.ordersGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents buttonClose As System.Windows.Forms.Button
    Private WithEvents buttonUndo As System.Windows.Forms.Button
    Private WithEvents buttonDelete As System.Windows.Forms.Button
    Private WithEvents buttonEdit As System.Windows.Forms.Button
    Private WithEvents buttonAdd As System.Windows.Forms.Button
    Private WithEvents ordersGrid As System.Windows.Forms.DataGridView
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
