
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports C1.Win.C1FlexGrid

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
    Friend WithEvents _btnTotals As System.Windows.Forms.Button
    Friend WithEvents _btnDataTable As System.Windows.Forms.Button
    Friend WithEvents sqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents _btnDataReader As System.Windows.Forms.Button
    Friend WithEvents sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._btnTotals = New System.Windows.Forms.Button()
        Me._btnDataTable = New System.Windows.Forms.Button()
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me._btnDataReader = New System.Windows.Forms.Button()
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_btnTotals
        '
        Me._btnTotals.Location = New System.Drawing.Point(402, 9)
        Me._btnTotals.Name = "_btnTotals"
        Me._btnTotals.Size = New System.Drawing.Size(159, 37)
        Me._btnTotals.TabIndex = 5
        Me._btnTotals.Text = "Add Totals"
        '
        '_btnDataTable
        '
        Me._btnDataTable.Location = New System.Drawing.Point(205, 9)
        Me._btnDataTable.Name = "_btnDataTable"
        Me._btnDataTable.Size = New System.Drawing.Size(179, 37)
        Me._btnDataTable.TabIndex = 4
        Me._btnDataTable.Text = "Bind to DataTable"
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "data source=tstsrv1;initial catalog=Northwind;password=onyx;persist security info" & _
        "=True;user id=dloyola;workstation id=PERMANI;packet size=4096"
        '
        'sqlSelectCommand1
        '
        Me.sqlSelectCommand1.CommandText = "SELECT Products.ProductName, [Order Details].OrderID, [Order Details].UnitPrice, " & _
        "[Order Details].Quantity, [Order Details].UnitPrice * [Order Details].Quantity A" & _
        "S Total FROM [Order Details] INNER JOIN Products ON [Order Details].ProductID = " & _
        "Products.ProductID ORDER BY Products.ProductName, [Order Details].OrderID, [Orde" & _
        "r Details].UnitPrice * [Order Details].Quantity DESC"
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        '
        '_btnDataReader
        '
        Me._btnDataReader.Location = New System.Drawing.Point(9, 9)
        Me._btnDataReader.Name = "_btnDataReader"
        Me._btnDataReader.Size = New System.Drawing.Size(178, 37)
        Me._btnDataReader.TabIndex = 3
        Me._btnDataReader.Text = "Load from DataReader"
        '
        'sqlDataAdapter1
        '
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax")})})
        '
        '_flex
        '
        Me._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Location = New System.Drawing.Point(9, 56)
        Me._flex.Name = "_flex"
        Me._flex.Rows.Count = 1
        Me._flex.Size = New System.Drawing.Size(683, 345)
        Me._flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(701, 407)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me._btnDataReader, Me._btnTotals, Me._btnDataTable})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Loading Data"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'load data using datareader
    Private Sub _btnDataReader_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnDataReader.Click
        'prepare datareader
        Dim myConn As SqlConnection = New SqlConnection(sqlConnection1.ConnectionString)
        Dim myCMD As SqlCommand = New SqlCommand(sqlSelectCommand1.CommandText, myConn)
        myConn.Open()
        Dim myReader As SqlDataReader = myCMD.ExecuteReader()

        'build grid structure from DB schema
        Dim dt As DataTable = myReader.GetSchemaTable()
        _flex.Cols.Count = 1
        Dim dr As DataRow
        For Each dr In dt.Rows
            Dim c As Column = _flex.Cols.Add()
            c.Caption = CType(dr("ColumnName"), String)
            c.Name = CType(dr("ColumnName"), String)
            c.DataType = CType(dr("DataType"), Type)

        Next

        'populate grid
        _flex.DataSource = Nothing
        _flex.Rows.Count = 1
        Dim row As Integer = 1
        Dim t As MyTimer = New MyTimer()
        _flex.Redraw = False

        'method 1
        While myReader.Read()
            _flex.Rows.Add()
            Dim i As Integer
            For i = 0 To myReader.FieldCount - 1
                _flex(row, i + 1) = myReader.GetValue(i)
            Next
            row = row + 1
        End While

        _flex.Redraw = True
        t.done(String.Format("read {0} rows", _flex.Rows.Count))

        'cleanup
        _flex.AutoSizeCols()
        myReader.Close()
        myConn.Close()

    End Sub


    Private Sub _btnDataTable_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnDataTable.Click
        Dim t As New mytimer()

        Dim datatable As New DataTable()
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlSelectCommand1.CommandText, sqlConnection1.ConnectionString)
        da.Fill(datatable)
        _flex.AutoResize = False
        _flex.DataSource = datatable

        t.done(String.Format("read {0} rows", _flex.Rows.Count))

        'make it a fair comparison (autosize is not timed)
        _flex.AutoSizeCols()
    End Sub

    'add totals

    Private Sub _btnTotals_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnTotals.Click
        _flex.Tree.Column = 1

        Dim t As New mytimer()

        _flex.Redraw = False
        _flex.Subtotal(AggregateEnum.Sum, 0, 1, 1, 5, "Product")
        _flex.Subtotal(AggregateEnum.Sum, 1, 3, 3, 5, "Unit Price")
        _flex.Redraw = True

        t.done(String.Format("Added subtotals to {0} rows", _flex.Rows.Count))
    End Sub

    Private Sub _flex_BeforeSort(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles _flex.BeforeSort
        'get rid of totals before sorting
        'when bound, this is automatic.
        'when loaded with DataReader, it isn't
        _flex.Subtotal(AggregateEnum.Clear)
    End Sub
End Class

'MyTimer
'helper class

Friend Class MyTimer
    Dim _start As DateTime
    Friend Sub New()
        _start = DateTime.Now
        Cursor.Current = Cursors.WaitCursor
    End Sub

    Friend Sub Done(ByVal text As String)
        Cursor.Current = Cursors.Default
        Dim ts As TimeSpan = DateTime.Now.Subtract(_start)
        text += String.Format(" in {0:0.00} seconds", ts.TotalSeconds)
        MessageBox.Show(text, "Timer")
    End Sub
End Class