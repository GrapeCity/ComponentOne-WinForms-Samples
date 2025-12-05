Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents C1TrueDBGrid1 As C1.Win.TrueDBGrid.C1TrueDBGrid
    Public dt As DataTable
    Friend WithEvents button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid
        Me.button1 = New System.Windows.Forms.Button
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(16, 24)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(261, 194)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "c1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(312, 24)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Add"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 266)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    ' fills the grid with random data
    Private Sub _fillGrid()
        Dim maxrows As Integer = 5

        dt = New DataTable("testdatatable")

        Dim dc As DataColumn
        Dim dr As DataRow

        ' set up an integer column
        dc = New DataColumn()
        dc.DataType = System.Type.GetType("System.Int32")
        dc.ColumnName = "Integer"
        dt.Columns.Add(dc)

        ' do string
        dc = New DataColumn()
        dc.DataType = System.Type.GetType("System.String")
        dc.ColumnName = "String"
        dt.Columns.Add(dc)

        Dim rnd As New Random()
        Dim i As Integer
        For i = 0 To maxrows - 1
            dr = dt.NewRow()
            dr("Integer") = CInt(rnd.NextDouble() * 1000.0)
            dr("String") = "Row: " + i.ToString()
            dt.Rows.Add(dr)
        Next i
        Me.c1TrueDBGrid1.DataSource = dt
        dt.DefaultView.Sort = "Integer"
    End Sub '_fillGrid

    ' find the newly added record in the grid and select it
    Private Sub _findrow(ByVal i As Integer)
        ' get the currency manager that the grid is bound to
        Dim cm As CurrencyManager = CType(Me.BindingContext(Me.C1TrueDBGrid1.DataSource, Me.C1TrueDBGrid1.DataMember), CurrencyManager)
        ' get the property descriptor for the "integer" column
        Dim prop As System.ComponentModel.PropertyDescriptor = cm.GetItemProperties()("Integer")

        ' get the binding list
        Dim blist As System.ComponentModel.IBindingList = CType(cm.List, System.ComponentModel.IBindingList)

        ' find the newly added record
        Dim row As Integer = blist.Find(prop, i)
        ' now show it as selected in the grid
        Me.C1TrueDBGrid1.SelectedRows.Clear()
        Me.C1TrueDBGrid1.SelectedRows.Add(row)
    End Sub '_findrow

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim f As New Form2()
        If f.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            ' add the new record to the datasource
            Dim dr As DataRow = dt.NewRow()
            Dim i As Integer = System.Convert.ToInt32(f.TextBox1.Text)
            dr("Integer") = i
            dr("String") = f.TextBox2.Text
            dt.Rows.Add(dr)
            ' sort the data
            dt.DefaultView.Sort = "Integer"
            ' now select it in the grid
            _findrow(i)
        End If
    End Sub 'button1_Click

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _fillGrid()
    End Sub
End Class
