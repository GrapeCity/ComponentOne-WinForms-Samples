<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomColumns
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
        Dim EntityViewSourceProperties1 As C1.Win.Data.Entities.EntityViewSourceProperties = New C1.Win.Data.Entities.EntityViewSourceProperties()
        Dim ControlHandler1 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Me.c1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.c1DataSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'c1DataSource1
        '
        Me.c1DataSource1.ContextType = GetType(TutorialsWinForms.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Products"
        Me.c1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ControlHandler1.AutoLookup = false
        ControlHandler1.VirtualMode = false
        Me.c1DataSource1.SetControlHandler(Me.dataGridView1, ControlHandler1)
        Me.dataGridView1.Location = New System.Drawing.Point(12, 30)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(897, 477)
        Me.dataGridView1.TabIndex = 1
        '
        'CustomColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 537)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "CustomColumns"
        Me.Text = "CustomColumns"
        CType(Me.c1DataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Private WithEvents c1DataSource1 As C1.Win.Data.Entities.C1DataSource
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
End Class
