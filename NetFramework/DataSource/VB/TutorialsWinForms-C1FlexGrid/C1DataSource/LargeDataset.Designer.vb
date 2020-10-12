<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LargeDataset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LargeDataset))
        Dim ControlHandler1 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Dim EntityViewSourceProperties1 As C1.Win.Data.Entities.EntityViewSourceProperties = New C1.Win.Data.Entities.EntityViewSourceProperties()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.c1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        ControlHandler1.AutoLookup = False
        ControlHandler1.VirtualMode = True
        Me.c1DataSource1.SetControlHandler(Me.C1FlexGrid1, ControlHandler1)
        Me.C1FlexGrid1.DataMember = "Order_Details"
        Me.C1FlexGrid1.DataSource = Me.c1DataSource1
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(526, 618)
        Me.C1FlexGrid1.TabIndex = 0
        '
        'c1DataSource1
        '
        Me.c1DataSource1.ContextType = GetType(TutorialsWinForms.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Order_Details"
        EntityViewSourceProperties1.Include = ""
        EntityViewSourceProperties1.PageSize = 50
        EntityViewSourceProperties1.VirtualMode = C1.Data.DataSource.VirtualModeKind.Managed
        Me.c1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        '
        'LargeDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 630)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Name = "LargeDataset"
        Me.Text = "LargeDataset"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)

End Sub
    Private WithEvents c1DataSource1 As C1.Win.Data.Entities.C1DataSource
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
End Class
