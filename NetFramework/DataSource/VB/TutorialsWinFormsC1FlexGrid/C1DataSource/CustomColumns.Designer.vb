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
        Me.C1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me.c1DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1DataSource1
        '
        Me.c1DataSource1.ContextType = GetType(TutorialsWinFormsC1FlexGrid.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Products"
        EntityViewSourceProperties1.Include = ""
        Me.c1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:"
        ControlHandler1.AutoLookup = False
        ControlHandler1.VirtualMode = False
        Me.c1DataSource1.SetControlHandler(Me.C1FlexGrid1, ControlHandler1)
        Me.C1FlexGrid1.Location = New System.Drawing.Point(12, 12)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(897, 513)
        Me.C1FlexGrid1.TabIndex = 0
        '
        'CustomColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 537)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Name = "CustomColumns"
        Me.Text = "CustomColumns"
        CType(Me.c1DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)

End Sub
    Private WithEvents c1DataSource1 As C1.Win.Data.Entities.C1DataSource
    Friend WithEvents C1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
End Class
