Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        Application.EnableVisualStyles()

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
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowRowSelect = False
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(16, 24)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(460, 178)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "c1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'checkBox1
        '
        Me.checkBox1.Location = New System.Drawing.Point(496, 24)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(120, 24)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "Show CheckBoxes"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 214)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim maxrows As Integer = 100
        Dim dt As New System.Data.DataTable("testdatatable")

        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow

        ' row number
        dc = New DataColumn()
        dc.DataType = System.Type.GetType("System.Int32")
        dc.ColumnName = "RowNum"
        dt.Columns.Add(dc)

        ' set up an integer column - this will be our checkbox column
        dc = New DataColumn()
        dc.DataType = System.Type.GetType("System.Int32")
        dc.ColumnName = "Integer"
        dt.Columns.Add(dc)

        ' string column
        dc = New DataColumn()
        dc.DataType = System.Type.GetType("System.String")
        dc.ColumnName = "String"
        dt.Columns.Add(dc)

        ' date
        dc = New DataColumn()
        dc.DataType = System.Type.GetType("System.DateTime")
        dc.ColumnName = "Date"
        dt.Columns.Add(dc)

        Dim random As New System.Random()
        Dim i As Integer
        For i = 0 To maxrows - 1
            dr = dt.NewRow()
            dr(0) = i
            ' the "Integer" column has 3 values corresponding to the 3 states the checkbox can have
            dr(1) = CInt(random.NextDouble() * 3.0)
            dr(2) = "Row: " + i.ToString()
            dr(3) = System.DateTime.Now
            dt.Rows.Add(dr)
        Next i
        Me.C1TrueDBGrid1.SetDataBinding(dt, "", True)
        Me.C1TrueDBGrid1.Splits(0).ExtendRightColumn = True

    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Dim items As C1.Win.C1TrueDBGrid.ValueItems = Me.C1TrueDBGrid1.Columns("Integer").ValueItems

        If Me.checkBox1.Checked Then
            ' we're going to translate values - the datasource needs to hold at least 3 states
            items.Translate = True
            ' each click will cycle thru the various checkbox states
            items.CycleOnClick = True
            ' display the cell as a checkbox
            items.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            ' now associate underlying db values with the checked state
            items.Values.Clear()
            items.Values.Add(New C1.Win.C1TrueDBGrid.ValueItem("0", False)) ' unchecked
            items.Values.Add(New C1.Win.C1TrueDBGrid.ValueItem("1", True)) ' checked
            items.Values.Add(New C1.Win.C1TrueDBGrid.ValueItem("2", "INDETERMINATE")) ' indeterminate state
        Else
            items.Translate = False
            items.CycleOnClick = False
            items.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.Normal
        End If
        Me.C1TrueDBGrid1.Refresh()
    End Sub
End Class
