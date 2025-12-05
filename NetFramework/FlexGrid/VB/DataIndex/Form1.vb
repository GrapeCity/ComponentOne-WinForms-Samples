
Imports System
Imports System.Drawing
Imports System.Data
Imports System.ComponentModel
Imports System.Collections
Imports System.Windows.Forms
Imports C1.Win.FlexGrid

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
    Friend WithEvents _stBar As System.Windows.Forms.StatusBar
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._stBar = New System.Windows.Forms.StatusBar()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_stBar
        '
        Me._stBar.Location = New System.Drawing.Point(0, 221)
        Me._stBar.Name = "_stBar"
        Me._stBar.Size = New System.Drawing.Size(440, 16)
        Me._stBar.TabIndex = 2
        '
        '_flex
        '
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(440, 221)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 237)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me._stBar})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: DataIndex"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'create data table 
        _flex.Rows.Count = 210
        _flex.Cols.Count = 4
        Dim dt As New DataTable()
        dt.Columns.Add("Customer", GetType(String))
        dt.Columns.Add("Product", GetType(String))
        dt.Columns.Add("Date", GetType(DateTime))
        dt.Columns.Add("Amount", GetType(Decimal))

        'populate data table
        Dim rnd As New Random()
        Dim customers As String() = "GM|Ford|Chrysler|Toyota|Honda|Mazda|Mitsubishi|Mercedes".Split("|")
        Dim products As String() = "Palm PC|Monitor|Keyboard|Printer|Fax|Copier|Mouse|Headphone".Split("|")
        Dim data As Object() = New Object(3) {}

        Dim i As Integer
        For i = 0 To 200 - 1
            data(0) = customers(rnd.Next(customers.Length - 1))
            data(1) = products(rnd.Next(products.Length - 1))
            data(2) = DateTime.Now.AddDays(-356 * rnd.Next(-365, 0))
            data(3) = rnd.NextDouble() * 10000
            dt.Rows.Add(data)
        Next

        dt.AcceptChanges()

        'sort data table
        dt.DefaultView.Sort = "Customer, Product"

        'bind to grid
        _flex.DataSource = dt

        'configure grid
        _flex.Cols("Amount").Format = "c"
        _flex.Cols("Amount").AllowDragging = False
        _flex.Cols("Date").AllowDragging = False
        _flex.AutoSizeCols()
        _flex.Cols(1).Width += 40
        _flex.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.MultiColumn
    End Sub


    Private Sub _flex_AfterDataRefresh(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles _flex.AfterDataRefresh
        UpdateTotals()
    End Sub


    Private Sub _flex_AfterDragColumn(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.DragRowColEventArgs) Handles _flex.AfterDragColumn
        UpdateTotals()
    End Sub

    Private Sub _flex_RowColChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles _flex.RowColChange
        UpdateStatus()
    End Sub

    Private Sub UpdateTotals()
        'set up tree
        _flex.Tree.Column = 1

        'clear existing totals
        _flex.Subtotal(AggregateEnum.Clear)

        'total amounts per product and customer
        Dim totalOn As Integer = _flex.Cols("Amount").Index
        _flex.Subtotal(AggregateEnum.Sum, 0, 1, totalOn)
        _flex.Subtotal(AggregateEnum.Sum, 1, 2, totalOn)

        'update status
        UpdateStatus()
    End Sub

    Private Sub UpdateStatus()
        'get current row's dataIndex (skip nodes and fixed rows)
        Dim current As Integer
        If _flex.Row > 0 Then
            current = _flex.Rows(_flex.Row).DataIndex
        Else
            current = -1
        End If

        'not a data row
        If current < 0 Then
            _stBar.Text = "Not a data row"
            Return
        End If

        'count data rows
        Dim last As Integer = -1
        Dim index As Integer
        For index = _flex.Rows.Count - 1 To index > 0 AndAlso last < 0 Step -1
            last = _flex.Rows(index).DataIndex
        Next

        'get underlying DataRow
        Dim cm As CurrencyManager = CType(BindingContext(_flex.DataSource, _flex.DataMember), CurrencyManager)
        Dim drv As DataRowView = CType(cm.List(current), DataRowView)

        'show current, total
        _stBar.Text = String.Format("Row {0} of {1}: {2}", current + 1, last + 1, drv.Row.RowState)

    End Sub
End Class
