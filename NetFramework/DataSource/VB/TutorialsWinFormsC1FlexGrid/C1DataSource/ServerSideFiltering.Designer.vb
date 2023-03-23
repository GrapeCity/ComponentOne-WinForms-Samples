<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerSideFiltering
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
        Dim EntityViewSourceProperties2 As C1.Win.Data.Entities.EntityViewSourceProperties = New C1.Win.Data.Entities.EntityViewSourceProperties()
        Dim FilterDescriptorProperties1 As C1.Win.Data.FilterDescriptorProperties = New C1.Win.Data.FilterDescriptorProperties()
        Dim SortDescriptorProperties1 As C1.Win.Data.SortDescriptorProperties = New C1.Win.Data.SortDescriptorProperties()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServerSideFiltering))
        Dim ControlHandler1 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Me.C1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataSource1
        '
        Me.C1DataSource1.ContextType = GetType(TutorialsWinFormsC1FlexGrid.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Categories"
        EntityViewSourceProperties1.Include = ""
        EntityViewSourceProperties2.EntitySetName = "Products"
        FilterDescriptorProperties1.PropertyPath = "CategoryID"
        FilterDescriptorProperties1.Value = "1"
        EntityViewSourceProperties2.FilterDescriptors.Add(FilterDescriptorProperties1)
        EntityViewSourceProperties2.Include = ""
        SortDescriptorProperties1.PropertyPath = "ProductName"
        EntityViewSourceProperties2.SortDescriptors.Add(SortDescriptorProperties1)
        Me.C1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        Me.C1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties2)
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(704, 376)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(104, 23)
        Me.btnSaveChanges.TabIndex = 19
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'comboBox1
        '
        Me.comboBox1.DataSource = Me.C1DataSource1
        Me.comboBox1.DisplayMember = "Categories.CategoryName"
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(34, 33)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(175, 21)
        Me.comboBox1.TabIndex = 18
        Me.comboBox1.ValueMember = "Categories.CategoryID"
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        ControlHandler1.AutoLookup = False
        ControlHandler1.VirtualMode = False
        Me.C1DataSource1.SetControlHandler(Me.C1FlexGrid1, ControlHandler1)
        Me.C1FlexGrid1.DataMember = "Products"
        Me.C1FlexGrid1.DataSource = Me.C1DataSource1
        Me.C1FlexGrid1.Location = New System.Drawing.Point(12, 60)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1018, 299)
        Me.C1FlexGrid1.TabIndex = 20
        '
        'ServerSideFiltering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 433)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.comboBox1)
        Me.Name = "ServerSideFiltering"
        Me.Text = "ServerSideFiltering"
        CType(Me.C1DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)

End Sub
    Private WithEvents btnSaveChanges As System.Windows.Forms.Button
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents C1DataSource1 As C1.Win.Data.Entities.C1DataSource
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
End Class
