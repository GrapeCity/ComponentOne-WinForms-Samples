<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewColumnForm
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
        Me.c1Label6 = New C1.Win.C1Input.C1Label()
        Me.btnCancel = New C1.Win.C1Input.C1Button()
        Me.btnAdd = New C1.Win.C1Input.C1Button()
        Me.c1Label5 = New C1.Win.C1Input.C1Label()
        Me.c1Label4 = New C1.Win.C1Input.C1Label()
        Me.tbDisplayFieldName = New C1.Win.C1Input.C1TextBox()
        Me.c1Label3 = New C1.Win.C1Input.C1Label()
        Me.tbHeaderText = New C1.Win.C1Input.C1TextBox()
        Me.c1Label2 = New C1.Win.C1Input.C1Label()
        Me.tbName = New C1.Win.C1Input.C1TextBox()
        Me.c1Label1 = New C1.Win.C1Input.C1Label()
        CType(Me.c1Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDisplayFieldName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbHeaderText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1Label6
        '
        Me.c1Label6.AutoSize = True
        Me.c1Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label6.Location = New System.Drawing.Point(69, 178)
        Me.c1Label6.Name = "c1Label6"
        Me.c1Label6.Size = New System.Drawing.Size(135, 13)
        Me.c1Label6.TabIndex = 21
        Me.c1Label6.Tag = Nothing
        Me.c1Label6.Text = "Empty placeholder: [Empty]"
        Me.c1Label6.TextDetached = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(237, 223)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 34)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAdd.Location = New System.Drawing.Point(144, 223)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 34)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'c1Label5
        '
        Me.c1Label5.AutoSize = True
        Me.c1Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label5.Location = New System.Drawing.Point(69, 160)
        Me.c1Label5.Name = "c1Label5"
        Me.c1Label5.Size = New System.Drawing.Size(230, 13)
        Me.c1Label5.TabIndex = 18
        Me.c1Label5.Tag = Nothing
        Me.c1Label5.Text = "Fields in sample: FirstName, LastName, Post, Id"
        Me.c1Label5.TextDetached = True
        '
        'c1Label4
        '
        Me.c1Label4.AutoSize = True
        Me.c1Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label4.Location = New System.Drawing.Point(69, 142)
        Me.c1Label4.Name = "c1Label4"
        Me.c1Label4.Size = New System.Drawing.Size(178, 13)
        Me.c1Label4.TabIndex = 17
        Me.c1Label4.Tag = Nothing
        Me.c1Label4.Text = "Example:   FieldName\FieldName\..."
        Me.c1Label4.TextDetached = True
        '
        'tbDisplayFieldName
        '
        Me.tbDisplayFieldName.Location = New System.Drawing.Point(125, 119)
        Me.tbDisplayFieldName.Name = "tbDisplayFieldName"
        Me.tbDisplayFieldName.Size = New System.Drawing.Size(195, 18)
        Me.tbDisplayFieldName.TabIndex = 16
        Me.tbDisplayFieldName.Tag = Nothing
        Me.tbDisplayFieldName.TextDetached = True
        '
        'c1Label3
        '
        Me.c1Label3.AutoSize = True
        Me.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label3.Location = New System.Drawing.Point(53, 72)
        Me.c1Label3.Name = "c1Label3"
        Me.c1Label3.Size = New System.Drawing.Size(66, 13)
        Me.c1Label3.TabIndex = 15
        Me.c1Label3.Tag = Nothing
        Me.c1Label3.Text = "HeaderText:"
        Me.c1Label3.TextDetached = True
        '
        'tbHeaderText
        '
        Me.tbHeaderText.Location = New System.Drawing.Point(125, 69)
        Me.tbHeaderText.Name = "tbHeaderText"
        Me.tbHeaderText.Size = New System.Drawing.Size(195, 18)
        Me.tbHeaderText.TabIndex = 14
        Me.tbHeaderText.Tag = Nothing
        Me.tbHeaderText.TextDetached = True
        '
        'c1Label2
        '
        Me.c1Label2.AutoSize = True
        Me.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label2.Location = New System.Drawing.Point(25, 122)
        Me.c1Label2.Name = "c1Label2"
        Me.c1Label2.Size = New System.Drawing.Size(94, 13)
        Me.c1Label2.TabIndex = 13
        Me.c1Label2.Tag = Nothing
        Me.c1Label2.Text = "DisplayFieldName:"
        Me.c1Label2.TextDetached = True
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(125, 45)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(195, 18)
        Me.tbName.TabIndex = 12
        Me.tbName.Tag = Nothing
        Me.tbName.TextDetached = True
        '
        'c1Label1
        '
        Me.c1Label1.AutoSize = True
        Me.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label1.Location = New System.Drawing.Point(81, 48)
        Me.c1Label1.Name = "c1Label1"
        Me.c1Label1.Size = New System.Drawing.Size(38, 13)
        Me.c1Label1.TabIndex = 11
        Me.c1Label1.Tag = Nothing
        Me.c1Label1.Text = "Name:"
        Me.c1Label1.TextDetached = True
        '
        'AddNewColumnForm
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(331, 266)
        Me.Controls.Add(Me.c1Label6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.c1Label5)
        Me.Controls.Add(Me.c1Label4)
        Me.Controls.Add(Me.tbDisplayFieldName)
        Me.Controls.Add(Me.c1Label3)
        Me.Controls.Add(Me.tbHeaderText)
        Me.Controls.Add(Me.c1Label2)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.c1Label1)
        Me.Name = "AddNewColumnForm"
        Me.Text = "AddNewColumnForm"
        CType(Me.c1Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDisplayFieldName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbHeaderText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents c1Label6 As C1.Win.C1Input.C1Label
    Private WithEvents btnCancel As C1.Win.C1Input.C1Button
    Private WithEvents btnAdd As C1.Win.C1Input.C1Button
    Private WithEvents c1Label5 As C1.Win.C1Input.C1Label
    Private WithEvents c1Label4 As C1.Win.C1Input.C1Label
    Private WithEvents tbDisplayFieldName As C1.Win.C1Input.C1TextBox
    Private WithEvents c1Label3 As C1.Win.C1Input.C1Label
    Private WithEvents tbHeaderText As C1.Win.C1Input.C1TextBox
    Private WithEvents c1Label2 As C1.Win.C1Input.C1Label
    Private WithEvents tbName As C1.Win.C1Input.C1TextBox
    Private WithEvents c1Label1 As C1.Win.C1Input.C1Label
End Class
