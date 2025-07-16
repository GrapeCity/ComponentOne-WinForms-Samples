<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterDetailBinding
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterDetailBinding))
        Dim ControlHandler1 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Dim ControlHandler2 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Dim EntityViewSourceProperties1 As C1.Win.Data.Entities.EntityViewSourceProperties = New C1.Win.Data.Entities.EntityViewSourceProperties()
        Dim SortDescriptorProperties1 As C1.Win.Data.SortDescriptorProperties = New C1.Win.Data.SortDescriptorProperties()
        Me.C1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.C1FlexGrid2 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.c1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        ControlHandler1.AutoLookup = False
        ControlHandler1.VirtualMode = False
        Me.c1DataSource1.SetControlHandler(Me.C1FlexGrid1, ControlHandler1)
        Me.C1FlexGrid1.DataMember = "Categories"
        Me.C1FlexGrid1.DataSource = Me.c1DataSource1
        Me.C1FlexGrid1.Location = New System.Drawing.Point(12, 12)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(807, 164)
        Me.C1FlexGrid1.TabIndex = 0
        '
        'C1FlexGrid2
        '
        Me.C1FlexGrid2.ColumnInfo = resources.GetString("C1FlexGrid2.ColumnInfo")
        ControlHandler2.AutoLookup = True
        ControlHandler2.VirtualMode = False
        Me.c1DataSource1.SetControlHandler(Me.C1FlexGrid2, ControlHandler2)
        Me.C1FlexGrid2.DataMember = "Categories.Products"
        Me.C1FlexGrid2.DataSource = Me.c1DataSource1
        Me.C1FlexGrid2.Location = New System.Drawing.Point(12, 182)
        Me.C1FlexGrid2.Name = "C1FlexGrid2"
        Me.C1FlexGrid2.Rows.Count = 1
        Me.C1FlexGrid2.Rows.DefaultSize = 19
        Me.C1FlexGrid2.Size = New System.Drawing.Size(807, 263)
        Me.C1FlexGrid2.TabIndex = 1
        '
        'c1DataSource1
        '
        Me.c1DataSource1.ContextType = GetType(TutorialsWinFormsC1FlexGrid.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Categories"
        EntityViewSourceProperties1.Include = ""
        SortDescriptorProperties1.PropertyPath = "CategoryID"
        EntityViewSourceProperties1.SortDescriptors.Add(SortDescriptorProperties1)
        Me.c1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        '
        'MasterDetailBinding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 445)
        Me.Controls.Add(Me.C1FlexGrid2)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.MaximizeBox = False
        Me.Name = "MasterDetailBinding"
        Me.Text = "MasterDetailBinding"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)

End Sub
    Private WithEvents c1DataSource1 As C1.Win.Data.Entities.C1DataSource
    Friend WithEvents C1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGrid2 As C1.Win.FlexGrid.C1FlexGrid
End Class
