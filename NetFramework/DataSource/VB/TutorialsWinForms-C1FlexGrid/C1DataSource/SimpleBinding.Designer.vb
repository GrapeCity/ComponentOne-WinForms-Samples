<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleBinding
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimpleBinding))
        Dim ControlHandler1 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Dim EntityViewSourceProperties1 As C1.Win.Data.Entities.EntityViewSourceProperties = New C1.Win.Data.Entities.EntityViewSourceProperties()
        Dim FilterDescriptorProperties1 As C1.Win.Data.FilterDescriptorProperties = New C1.Win.Data.FilterDescriptorProperties()
        Dim SortDescriptorProperties1 As C1.Win.Data.SortDescriptorProperties = New C1.Win.Data.SortDescriptorProperties()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        ControlHandler1.AutoLookup = True
        ControlHandler1.VirtualMode = False
        Me.C1DataSource1.SetControlHandler(Me.C1FlexGrid1, ControlHandler1)
        Me.C1FlexGrid1.DataMember = "Products"
        Me.C1FlexGrid1.DataSource = Me.C1DataSource1
        Me.C1FlexGrid1.Location = New System.Drawing.Point(12, 12)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(822, 341)
        Me.C1FlexGrid1.TabIndex = 0
        '
        'C1DataSource1
        '
        Me.C1DataSource1.ContextType = GetType(TutorialsWinForms.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Products"
        FilterDescriptorProperties1.PropertyPath = "Discontinued"
        FilterDescriptorProperties1.Value = "true"
        EntityViewSourceProperties1.FilterDescriptors.Add(FilterDescriptorProperties1)
        EntityViewSourceProperties1.Include = ""
        SortDescriptorProperties1.PropertyPath = "ProductID"
        EntityViewSourceProperties1.SortDescriptors.Add(SortDescriptorProperties1)
        Me.C1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        '
        'SimpleBinding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 355)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Name = "SimpleBinding"
        Me.Text = "SimpleBinding"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)

End Sub
    Private WithEvents C1DataSource1 As C1.Win.Data.Entities.C1DataSource
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
End Class
