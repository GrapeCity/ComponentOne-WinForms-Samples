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
        Dim C1TreeColumn1 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Me.C1TreeView1 = New C1.Win.TreeView.C1TreeView()
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TreeView1
        '
        C1TreeColumn1.DisplayFieldName = Nothing
        C1TreeColumn1.HeaderText = "Column1"
        C1TreeColumn1.Name = "Column1"
        Me.C1TreeView1.Columns.Add(C1TreeColumn1)
        Me.C1TreeView1.BindingInfo.DataMember = Nothing
        Me.C1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TreeView1.BindingInfo.KeyField = Nothing
        Me.C1TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.C1TreeView1.Name = "C1TreeView1"
        Me.C1TreeView1.BindingInfo.ParentKeyField = Nothing
        Me.C1TreeView1.Size = New System.Drawing.Size(414, 342)
        Me.C1TreeView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 342)
        Me.Controls.Add(Me.C1TreeView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1TreeView1 As C1.Win.TreeView.C1TreeView
End Class
