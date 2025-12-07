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
        Me.C1TreeView1 = New C1.Win.TreeView.C1TreeView()
        Me.DataSet11 = New CustomNodes.DataSet1()
        Me.CategoriesTableAdapter1 = New CustomNodes.DataSet1TableAdapters.CategoriesTableAdapter()
        Me.ProductsTableAdapter1 = New CustomNodes.DataSet1TableAdapters.ProductsTableAdapter()
        Me.C1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TreeView1
        '
        Me.C1TreeView1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.C1TreeView1.BackColor = System.Drawing.Color.White
        C1TreeColumn1.DisplayFieldName = "CategoryID\ProductName"
        C1TreeColumn1.HeaderText = "Category"
        C1TreeColumn1.Name = "Column1"
        C1TreeColumn1.Width = 210
        C1TreeColumn2.DisplayFieldName = Nothing
        C1TreeColumn2.HeaderText = "Product"
        C1TreeColumn2.Name = "Column2"
        Me.C1TreeView1.Columns.Add(C1TreeColumn1)
        Me.C1TreeView1.Columns.Add(C1TreeColumn2)
        Me.C1TreeView1.BindingInfo.DataMember = Nothing
        Me.C1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TreeView1.BindingInfo.KeyField = Nothing
        Me.C1TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.C1TreeView1.Name = "C1TreeView1"
        Me.C1TreeView1.BindingInfo.ParentKeyField = Nothing
        Me.C1TreeView1.Size = New System.Drawing.Size(1020, 528)
        Me.C1TreeView1.Styles.BorderStyle = C1.Win.TreeView.C1TreeViewBorderStyle.Full
        Me.C1TreeView1.Styles.ColumnHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.C1TreeView1.Styles.ColumnHeader.HorizontalAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.C1TreeView1.Styles.ColumnHeader.BackColor = System.Drawing.Color.YellowGreen
        Me.C1TreeView1.Styles.ColumnHeader.ForeColor = System.Drawing.Color.Black
        Me.C1TreeView1.Styles.ExpandButtonStyle = C1.Win.TreeView.ExpandButtonStyle.Windows10
        Me.C1TreeView1.Styles.ShowLines = False
        Me.C1TreeView1.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.C1TreeView1, "Office365White")
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriesTableAdapter1
        '
        Me.CategoriesTableAdapter1.ClearBeforeFill = True
        '
        'ProductsTableAdapter1
        '
        Me.ProductsTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 528)
        Me.Controls.Add(Me.C1TreeView1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.C1ThemeController1.SetTheme(Me, "Office365White")
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1TreeView1 As C1.Win.TreeView.C1TreeView
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents CategoriesTableAdapter1 As DataSet1TableAdapters.CategoriesTableAdapter
    Friend WithEvents ProductsTableAdapter1 As DataSet1TableAdapters.ProductsTableAdapter
    Friend WithEvents C1ThemeController1 As C1.Win.Themes.C1ThemeController
End Class
