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
        Dim C1TreeColumn2 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Dim C1TreeColumn3 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Me.c1TreeView1 = New C1.Win.TreeView.C1TreeView()
        CType(Me.c1TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1TreeView1
        '
        Me.c1TreeView1.AllowEditing = True
        Me.c1TreeView1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        C1TreeColumn1.DataMap = Nothing
        C1TreeColumn1.DisplayFieldName = "Post"
        C1TreeColumn1.HeaderText = "Post"
        C1TreeColumn1.Name = "cPost"
        C1TreeColumn2.DataMap = Nothing
        C1TreeColumn2.DisplayFieldName = Nothing
        C1TreeColumn2.HeaderText = "Name"
        C1TreeColumn2.Name = "cName"
        C1TreeColumn3.DataMap = Nothing
        C1TreeColumn3.DisplayFieldName = "CountryId"
        C1TreeColumn3.EditorType = C1.Win.TreeView.C1TreeViewEditorType.ComboBox
        C1TreeColumn3.HeaderText = "Country"
        C1TreeColumn3.Name = "cCountry"
        Me.c1TreeView1.Columns.Add(C1TreeColumn1)
        Me.c1TreeView1.Columns.Add(C1TreeColumn2)
        Me.c1TreeView1.Columns.Add(C1TreeColumn3)
        Me.c1TreeView1.BindingInfo.DataMember = Nothing
        Me.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1TreeView1.BindingInfo.KeyField = Nothing
        Me.c1TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.c1TreeView1.Name = "c1TreeView1"
        Me.c1TreeView1.BindingInfo.ParentKeyField = Nothing
        Me.c1TreeView1.Size = New System.Drawing.Size(852, 486)
        Me.c1TreeView1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 486)
        Me.Controls.Add(Me.c1TreeView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.c1TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents c1TreeView1 As C1.Win.TreeView.C1TreeView
End Class
