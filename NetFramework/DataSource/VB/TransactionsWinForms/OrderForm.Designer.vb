<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Me.textBoxShipCity = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.textBoxShipName = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.textBoxOrderDate = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonOK = New System.Windows.Forms.Button()
        Me.orderDetailsGrid = New System.Windows.Forms.DataGridView()
        Me.textBoxFreight = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBoxID = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.orderDetailsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBoxShipCity
        '
        Me.textBoxShipCity.Location = New System.Drawing.Point(91, 132)
        Me.textBoxShipCity.Name = "textBoxShipCity"
        Me.textBoxShipCity.Size = New System.Drawing.Size(170, 20)
        Me.textBoxShipCity.TabIndex = 25
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(11, 135)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(50, 13)
        Me.label5.TabIndex = 24
        Me.label5.Text = "Ship city:"
        '
        'textBoxShipName
        '
        Me.textBoxShipName.Location = New System.Drawing.Point(91, 102)
        Me.textBoxShipName.Name = "textBoxShipName"
        Me.textBoxShipName.Size = New System.Drawing.Size(170, 20)
        Me.textBoxShipName.TabIndex = 23
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(11, 105)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(60, 13)
        Me.label4.TabIndex = 22
        Me.label4.Text = "Ship name:"
        '
        'textBoxOrderDate
        '
        Me.textBoxOrderDate.Location = New System.Drawing.Point(91, 72)
        Me.textBoxOrderDate.Name = "textBoxOrderDate"
        Me.textBoxOrderDate.Size = New System.Drawing.Size(170, 20)
        Me.textBoxOrderDate.TabIndex = 21
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(11, 75)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(60, 13)
        Me.label3.TabIndex = 20
        Me.label3.Text = "Order date:"
        '
        'buttonCancel
        '
        Me.buttonCancel.Location = New System.Drawing.Point(508, 364)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 19
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonOK
        '
        Me.buttonOK.Location = New System.Drawing.Point(418, 364)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(75, 23)
        Me.buttonOK.TabIndex = 18
        Me.buttonOK.Text = "OK"
        Me.buttonOK.UseVisualStyleBackColor = True
        '
        'orderDetailsGrid
        '
        Me.orderDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.orderDetailsGrid.Location = New System.Drawing.Point(12, 165)
        Me.orderDetailsGrid.Name = "orderDetailsGrid"
        Me.orderDetailsGrid.Size = New System.Drawing.Size(571, 177)
        Me.orderDetailsGrid.TabIndex = 17
        '
        'textBoxFreight
        '
        Me.textBoxFreight.Location = New System.Drawing.Point(91, 42)
        Me.textBoxFreight.Name = "textBoxFreight"
        Me.textBoxFreight.Size = New System.Drawing.Size(170, 20)
        Me.textBoxFreight.TabIndex = 16
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(11, 45)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Freight:"
        '
        'textBoxID
        '
        Me.textBoxID.Location = New System.Drawing.Point(91, 12)
        Me.textBoxID.Name = "textBoxID"
        Me.textBoxID.ReadOnly = True
        Me.textBoxID.Size = New System.Drawing.Size(170, 20)
        Me.textBoxID.TabIndex = 14
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(21, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "ID:"
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 399)
        Me.Controls.Add(Me.textBoxShipCity)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.textBoxShipName)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textBoxOrderDate)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonOK)
        Me.Controls.Add(Me.orderDetailsGrid)
        Me.Controls.Add(Me.textBoxFreight)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBoxID)
        Me.Controls.Add(Me.label1)
        Me.Name = "OrderForm"
        Me.Text = "Edit Order"
        CType(Me.orderDetailsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents textBoxShipCity As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents textBoxShipName As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents textBoxOrderDate As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents buttonCancel As System.Windows.Forms.Button
    Private WithEvents buttonOK As System.Windows.Forms.Button
    Private WithEvents orderDetailsGrid As System.Windows.Forms.DataGridView
    Private WithEvents textBoxFreight As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents textBoxID As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
