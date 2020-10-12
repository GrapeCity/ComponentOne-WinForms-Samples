Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Collections.Specialized
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
    'It can be modified imports  the Windows Form Designer.  
    'Do not modify it imports  the code editor.
    Friend WithEvents _btnCustomSort As System.Windows.Forms.Button
    Friend WithEvents _chkSortLists As System.Windows.Forms.CheckBox
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._btnCustomSort = New System.Windows.Forms.Button()
        Me._chkSortLists = New System.Windows.Forms.CheckBox()
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_btnCustomSort
        '
        Me._btnCustomSort.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me._btnCustomSort.Location = New System.Drawing.Point(152, 256)
        Me._btnCustomSort.Name = "_btnCustomSort"
        Me._btnCustomSort.Size = New System.Drawing.Size(136, 24)
        Me._btnCustomSort.TabIndex = 4
        Me._btnCustomSort.Text = "Apply Custom Sort"
        '
        '_chkSortLists
        '
        Me._chkSortLists.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me._chkSortLists.Location = New System.Drawing.Point(8, 256)
        Me._chkSortLists.Name = "_chkSortLists"
        Me._chkSortLists.Size = New System.Drawing.Size(128, 24)
        Me._chkSortLists.TabIndex = 3
        Me._chkSortLists.Text = "Sort Combo Items"
        '
        '_flex
        '
        Me._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Location = New System.Drawing.Point(8, 8)
        Me._flex.Name = "_flex"
        Me._flex.Rows.Count = 5
        Me._flex.Size = New System.Drawing.Size(368, 240)
        Me._flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 285)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me._btnCustomSort, Me._chkSortLists})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Sorting"
        Me.TopMost = True
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'SortedList sorts values in the list by key
        Dim sl As SortedList = New SortedList()
        sl.Add("0", "Zero")
        sl.Add("1", "One")
        sl.Add("2", "Two")
        sl.Add("3", "Three")

        'ListDictionary keeps Add order
        Dim ld As New ListDictionary()
        ld.Add(0, "Zero")
        ld.Add(1, "One")
        ld.Add(2, "Two")
        ld.Add(3, "Three")

        'Hashtable stores items in arbitrary order
        Dim ht As New Hashtable()
        ht.Add(0, "Zero")
        ht.Add(1, "One")
        ht.Add(2, "Two")
        ht.Add(3, "Three")

        'apply data maps
        _flex.Cols(1).DataMap = sl
        _flex.Cols(1).Caption = "SortedList"
        _flex.Cols(2).DataMap = ld
        _flex.Cols(2).Caption = "ListDictionary"
        _flex.Cols(3).DataMap = ht
        _flex.Cols(3).Caption = "HashTable"
    End Sub

    'sort list items if that was requested
    Private Sub _flex_SetupEditor(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles _flex.SetupEditor
        Try
            Dim cb As ComboBox = CType(_flex.Editor, ComboBox)
            cb.Sorted = _chkSortLists.Checked
        Catch
        End Try
    End Sub

    'with mouse sort, use display values (these are data maps)

    Private Sub _flex_BeforeSort(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles _flex.BeforeSort
        'note OR operator (|) used to combine the AsDisplayed flag with
        'the sort direction set by the grid (Ascending or Descending)
        e.Order = e.Order Or SortFlags.AsDisplayed
    End Sub

    'apply custom sort
    Private Sub _btnCustomSort_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnCustomSort.Click
        _flex.Sort(New MyComparer(_flex))

    End Sub

    'MyComparer 
    'compares two grid rows using all columns
    Public Class MyComparer
        Implements IComparer

        Dim _flex As C1FlexGrid

        Public Sub New(ByVal flex As C1FlexGrid)
            _flex = flex
        End Sub

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            'get row indices 
            Dim r1 As Integer = CType(x, Row).Index
            Dim r2 As Integer = CType(y, Row).Index

            'scan all columns looking for differences
            Dim c As Integer
            For c = 0 To _flex.Cols.Count - 1
                'get display values
                Dim s1 As String = _flex.GetDataDisplay(r1, c)
                Dim s2 As String = _flex.GetDataDisplay(r2, c)

                'compare, done when a difference is found
                Dim cmp As Integer = String.Compare(s1, s2)
                If cmp <> 0 Then Return cmp

            Next

            'all values are the same, use row indices
            'to keep sort stable
            Return r1 - r2
        End Function
    End Class
End Class
