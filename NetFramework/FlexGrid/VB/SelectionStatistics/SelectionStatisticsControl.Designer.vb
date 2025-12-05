<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectionStatisticsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectionStatisticsControl))
        Me.tsSelectionStatistics = New System.Windows.Forms.ToolStrip()
        Me.tslSelectionStatistics = New System.Windows.Forms.ToolStripLabel()
        Me.c1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.C1NWindDataSet1 = New SelectionStatistics.C1NWindDataSet()
        Me.OrdersTableAdapter1 = New SelectionStatistics.C1NWindDataSetTableAdapters.OrdersTableAdapter()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tsSelectionStatistics.SuspendLayout()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NWindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsSelectionStatistics
        '
        Me.tsSelectionStatistics.BackColor = System.Drawing.SystemColors.Control
        Me.tsSelectionStatistics.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsSelectionStatistics.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSelectionStatistics.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslSelectionStatistics})
        Me.tsSelectionStatistics.Location = New System.Drawing.Point(0, 582)
        Me.tsSelectionStatistics.Name = "tsSelectionStatistics"
        Me.tsSelectionStatistics.Size = New System.Drawing.Size(723, 25)
        Me.tsSelectionStatistics.TabIndex = 0
        Me.tsSelectionStatistics.Text = "tsSelectionStatistics"
        '
        'tslSelectionStatistics
        '
        Me.tslSelectionStatistics.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslSelectionStatistics.Name = "tslSelectionStatistics"
        Me.tslSelectionStatistics.Size = New System.Drawing.Size(113, 22)
        Me.tslSelectionStatistics.Text = "tslSelectionStatistics"
        '
        'c1FlexGrid1
        '
        Me.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo")
        Me.c1FlexGrid1.DataSource = Me.OrdersBindingSource
        Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.c1FlexGrid1.Name = "c1FlexGrid1"
        Me.c1FlexGrid1.Rows.Count = 1
        Me.c1FlexGrid1.Size = New System.Drawing.Size(723, 582)
        Me.c1FlexGrid1.TabIndex = 1
        '
        'C1NWindDataSet1
        '
        Me.C1NWindDataSet1.DataSetName = "C1NWindDataSet"
        Me.C1NWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersTableAdapter1
        '
        Me.OrdersTableAdapter1.ClearBeforeFill = True
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.C1NWindDataSet1
        '
        'SelectionStatisticsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.c1FlexGrid1)
        Me.Controls.Add(Me.tsSelectionStatistics)
        Me.Name = "SelectionStatisticsControl"
        Me.Size = New System.Drawing.Size(723, 607)
        Me.tsSelectionStatistics.ResumeLayout(False)
        Me.tsSelectionStatistics.PerformLayout()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NWindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
    Friend tslSelectionStatistics As System.Windows.Forms.ToolStripLabel
    Friend tsSelectionStatistics As System.Windows.Forms.ToolStrip
    Friend WithEvents C1NWindDataSet1 As C1NWindDataSet
    Friend WithEvents OrdersTableAdapter1 As C1NWindDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents OrdersBindingSource As BindingSource
End Class
