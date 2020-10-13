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
        Dim C1TreeColumn3 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Dim C1TreeColumn4 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.C1TreeView1 = New C1.Win.TreeView.C1TreeView()
        Me.C1TreeView2 = New C1.Win.TreeView.C1TreeView()
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TreeView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.EnableAutoDragDrop = True
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 221)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(508, 104)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'C1TreeView1
        '
        C1TreeColumn3.DisplayFieldName = Nothing
        C1TreeColumn3.HeaderText = "Column1"
        C1TreeColumn3.Name = "Column1"
        Me.C1TreeView1.Columns.Add(C1TreeColumn3)
        Me.C1TreeView1.BindingInfo.DataMember = Nothing
        Me.C1TreeView1.BindingInfo.KeyField = Nothing
        Me.C1TreeView1.Location = New System.Drawing.Point(13, 13)
        Me.C1TreeView1.Name = "C1TreeView1"
        Me.C1TreeView1.BindingInfo.ParentKeyField = Nothing
        Me.C1TreeView1.Size = New System.Drawing.Size(220, 200)
        Me.C1TreeView1.TabIndex = 1
        '
        'C1TreeView2
        '
        C1TreeColumn4.DisplayFieldName = Nothing
        C1TreeColumn4.HeaderText = "Column1"
        C1TreeColumn4.Name = "Column1"
        Me.C1TreeView2.Columns.Add(C1TreeColumn4)
        Me.C1TreeView2.BindingInfo.DataMember = Nothing
        Me.C1TreeView2.BindingInfo.KeyField = Nothing
        Me.C1TreeView2.Location = New System.Drawing.Point(290, 12)
        Me.C1TreeView2.Name = "C1TreeView2"
        Me.C1TreeView2.BindingInfo.ParentKeyField = Nothing
        Me.C1TreeView2.Size = New System.Drawing.Size(230, 200)
        Me.C1TreeView2.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 337)
        Me.Controls.Add(Me.C1TreeView2)
        Me.Controls.Add(Me.C1TreeView1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TreeView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents C1TreeView1 As C1.Win.TreeView.C1TreeView
    Friend WithEvents C1TreeView2 As C1.Win.TreeView.C1TreeView
End Class
