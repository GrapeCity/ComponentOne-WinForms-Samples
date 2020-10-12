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
        Me.components = New System.ComponentModel.Container()
        Me.C1DbNavigator1 = New C1.Win.C1Input.C1DbNavigator()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1NWindDataSet = New DataBinding.C1NWindDataSet()
        Me.C1ExpressionEditor1 = New C1.Win.ExpressionEditor.C1ExpressionEditor()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.C1ExpressionEditorPanel1 = New C1.Win.ExpressionEditor.C1ExpressionEditorPanel()
        Me.ProductsTableAdapter = New DataBinding.C1NWindDataSetTableAdapters.ProductsTableAdapter()
        CType(Me.C1DbNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NWindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ExpressionEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1DbNavigator1
        '
        Me.C1DbNavigator1.DataSource = Me.ProductsBindingSource
        Me.C1DbNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DbNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.C1DbNavigator1.Name = "C1DbNavigator1"
        Me.C1DbNavigator1.Size = New System.Drawing.Size(658, 22)
        Me.C1DbNavigator1.TabIndex = 0
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.C1NWindDataSet
        '
        'C1NWindDataSet
        '
        Me.C1NWindDataSet.DataSetName = "C1NWindDataSet"
        Me.C1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'C1ExpressionEditor1
        '
        Me.C1ExpressionEditor1.DataSource = Me.ProductsBindingSource
        Me.C1ExpressionEditor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1ExpressionEditor1.Expression = "[UnitPrice] * [UnitsInStock]"
        Me.C1ExpressionEditor1.ItemContext = Me.ProductsBindingSource
        Me.C1ExpressionEditor1.Location = New System.Drawing.Point(0, 22)
        Me.C1ExpressionEditor1.Name = "C1ExpressionEditor1"
        Me.C1ExpressionEditor1.Size = New System.Drawing.Size(658, 60)
        Me.C1ExpressionEditor1.TabIndex = 1
        Me.C1ExpressionEditor1.Text = "C1ExpressionEditor1"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 82)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(658, 3)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 41)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result of the Expression for the current row:"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(652, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(0, 336)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(658, 3)
        Me.Splitter2.TabIndex = 4
        Me.Splitter2.TabStop = False
        '
        'C1ExpressionEditorPanel1
        '
        Me.C1ExpressionEditorPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1ExpressionEditorPanel1.ExpressionEditor = Me.C1ExpressionEditor1
        Me.C1ExpressionEditorPanel1.Location = New System.Drawing.Point(0, 85)
        Me.C1ExpressionEditorPanel1.Name = "C1ExpressionEditorPanel1"
        Me.C1ExpressionEditorPanel1.Size = New System.Drawing.Size(658, 251)
        Me.C1ExpressionEditorPanel1.TabIndex = 5
        Me.C1ExpressionEditorPanel1.Text = "C1ExpressionEditorPanel1"
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 380)
        Me.Controls.Add(Me.C1ExpressionEditorPanel1)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.C1ExpressionEditor1)
        Me.Controls.Add(Me.C1DbNavigator1)
        Me.Name = "Form1"
        Me.Text = "ExpressionEditor data binding sample"
        CType(Me.C1DbNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NWindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ExpressionEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1DbNavigator1 As C1.Win.C1Input.C1DbNavigator
    Friend WithEvents C1ExpressionEditor1 As C1.Win.ExpressionEditor.C1ExpressionEditor
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents C1ExpressionEditorPanel1 As C1.Win.ExpressionEditor.C1ExpressionEditorPanel
    Friend WithEvents C1NWindDataSet As C1NWindDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As C1NWindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TextBox1 As TextBox
End Class
