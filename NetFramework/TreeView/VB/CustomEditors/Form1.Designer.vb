<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim C1TreeColumn1 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Dim C1TreeColumn2 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Dim C1TreeColumn3 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Dim C1TreeColumn4 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.C1TreeView1 = New C1.Win.TreeView.C1TreeView()
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(438, 192)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox1.Location = New System.Drawing.Point(438, 219)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Visible = False
        '
        'C1TreeView1
        '
        Me.C1TreeView1.AllowEditing = True
        Me.C1TreeView1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        C1TreeColumn1.DisplayFieldName = "TextValue\TextValue"
        C1TreeColumn1.Editor = Me.TextBox1
        C1TreeColumn1.HeaderText = "MS TextBox"
        C1TreeColumn1.Name = "Column1"
        C1TreeColumn2.DisplayFieldName = "ObjectValue\ObjectValue"
        C1TreeColumn2.Editor = Me.ComboBox1
        C1TreeColumn2.EditorType = C1.Win.TreeView.C1TreeViewEditorType.ComboBox
        C1TreeColumn2.HeaderText = "MS ComboBox"
        C1TreeColumn2.Name = "Column2"
        C1TreeColumn3.DisplayFieldName = "ColorValue\ColorValue"
        C1TreeColumn3.HeaderText = "Custom ColorPicker"
        C1TreeColumn3.Name = "Column3"
        C1TreeColumn4.DisplayFieldName = "DateValue\DateValue"
        C1TreeColumn4.HeaderText = "Custom DatePicker"
        C1TreeColumn4.Name = "Column4"
        Me.C1TreeView1.Columns.Add(C1TreeColumn1)
        Me.C1TreeView1.Columns.Add(C1TreeColumn2)
        Me.C1TreeView1.Columns.Add(C1TreeColumn3)
        Me.C1TreeView1.Columns.Add(C1TreeColumn4)
        Me.C1TreeView1.BindingInfo.DataMember = Nothing
        Me.C1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TreeView1.BindingInfo.KeyField = Nothing
        Me.C1TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.C1TreeView1.Name = "C1TreeView1"
        Me.C1TreeView1.BindingInfo.ParentKeyField = Nothing
        Me.C1TreeView1.Size = New System.Drawing.Size(612, 364)
        Me.C1TreeView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 364)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.C1TreeView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1TreeView1 As C1.Win.TreeView.C1TreeView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
