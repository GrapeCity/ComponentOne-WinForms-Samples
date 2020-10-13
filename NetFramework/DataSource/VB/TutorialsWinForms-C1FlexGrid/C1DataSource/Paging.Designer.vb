<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Paging))
        Dim ControlHandler1 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Me.C1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.labelPage = New System.Windows.Forms.Label()
        Me.btnPrevPage = New System.Windows.Forms.Button()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataSource1
        '
        Me.C1DataSource1.ContextType = GetType(TutorialsWinForms.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Orders"
        EntityViewSourceProperties1.Include = ""
        EntityViewSourceProperties1.PageSize = 10
        Me.C1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        '
        'btnNextPage
        '
        Me.btnNextPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNextPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextPage.Location = New System.Drawing.Point(137, 284)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(28, 23)
        Me.btnNextPage.TabIndex = 19
        Me.btnNextPage.Text = ">"
        Me.btnNextPage.UseVisualStyleBackColor = True
        '
        'labelPage
        '
        Me.labelPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelPage.AutoSize = True
        Me.labelPage.Location = New System.Drawing.Point(62, 289)
        Me.labelPage.Name = "labelPage"
        Me.labelPage.Size = New System.Drawing.Size(55, 13)
        Me.labelPage.TabIndex = 18
        Me.labelPage.Text = "Page: 0/0"
        '
        'btnPrevPage
        '
        Me.btnPrevPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrevPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevPage.Location = New System.Drawing.Point(30, 284)
        Me.btnPrevPage.Name = "btnPrevPage"
        Me.btnPrevPage.Size = New System.Drawing.Size(28, 23)
        Me.btnPrevPage.TabIndex = 17
        Me.btnPrevPage.Text = "<"
        Me.btnPrevPage.UseVisualStyleBackColor = True
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        ControlHandler1.AutoLookup = True
        ControlHandler1.VirtualMode = False
        Me.C1DataSource1.SetControlHandler(Me.C1FlexGrid1, ControlHandler1)
        Me.C1FlexGrid1.DataMember = "Orders"
        Me.C1FlexGrid1.DataSource = Me.C1DataSource1
        Me.C1FlexGrid1.Location = New System.Drawing.Point(12, 12)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(889, 266)
        Me.C1FlexGrid1.TabIndex = 20
        '
        'Paging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 324)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.btnNextPage)
        Me.Controls.Add(Me.labelPage)
        Me.Controls.Add(Me.btnPrevPage)
        Me.Name = "Paging"
        Me.Text = "Paging"
        CType(Me.C1DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents btnNextPage As System.Windows.Forms.Button
    Private WithEvents labelPage As System.Windows.Forms.Label
    Private WithEvents btnPrevPage As System.Windows.Forms.Button
    Private WithEvents C1DataSource1 As C1.Win.Data.Entities.C1DataSource
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
End Class
