' ------------------------------------------------------------------------
' FilterRow.cs
' 
' Implements a class that works as a filter row for the C1FlexGrid 
' control (it is also used by the C1FlexGroup control).
' 
' To use this class, bind a FlexGrid to a DataTable or DataView object, 
' then create a FilterRow object passing the grid as a parameter to the 
' constructor. For example:
' 
' OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
' DataTable dt = new DataTable();
' da.Fill(dt);
' _flex.DataSource = dt;
' FilterRow fr = new FilterRow(_flex);
' 
' Once created, the FilterRow class will:
' 
' 1 - Add a new Fixed row to the grid. This new row will be the 'filter row'.
' 
' 2 - Trap mouse and keyboard events to select cells in the filter row.
'     The user can select the filter row by clicking on its cells, by 
'     pressing F3, or by moving to the top row and pressing the up arrow.
'     The user can remove the filter by clicking the first fixed column
'     on the filter row, then pressing the Delete key.
' 
' 3 - Trap the RowColChange event to update the filter expression and apply
'     it to the grid's data source. The filter expression may contain:
'     a) Simple values (e.g. "Smith"). These are translated into filter
'        expressions such as "like 'Smith*'".
' 		  If you type "s" in the filter row, the grid will show only rows
'        where the corresponding entry starts with "s".
'     b) Logical expressions (e.g. "> a", "= US"). These are translated 
'        into filter expressions such as "> 'a'" and "= 'US'".
' 		  If you type ">=12" in the filter row, the grid will show rows
'        where the corresponding entry is 12 or a higher value.
' 
' ------------------------------------------------------------------------
' This is a part of the C1FlexGrid package.
' 
' This source code is intended as a supplement to the C1FlexGrid control
' and related documentation provided with the product. See these sources 
' for detailed information regarding the C1FlexGrid product.
' 
' You may use this code as-is or modify it for any purpose you see fit,
' including the development of commercial applications. If you make any
' improvements that you would like to share with other users, please 
' post them at the C1FlexGrid newsgroup. Thanks.
' ------------------------------------------------------------------------
' Version history:
' 
' 1.0: June 2002	Sample created
' 1.2: Oct 2003	    Minor changes, added to C1FlexGroup control, VB version
' ------------------------------------------------------------------------
Imports System
Imports System.Text
Imports System.Data
Imports C1.Win.C1FlexGrid

Public Class FilterRow

    Dim _flex As C1FlexGrid
    Dim _style As CellStyle
    Dim _row As Integer = -1            ' index of filter row (-1 if none)
    Dim _col As Integer = -1   ' index of filter row cell being edited (-1 if none)

    ' ** ctor
    Public Sub New(ByVal flex As C1FlexGrid)

        ' save reference to grid
        _flex = flex

        ' add filter row
        _row = _flex.Rows.Fixed
        _flex.Rows.Fixed = _flex.Rows.Fixed + 1

        ' customize filter row style
        _style = _flex.Styles.Add("Filter", _flex.Styles.Frozen)
        _style.BackColor = SystemColors.Info
        _style.ForeColor = SystemColors.InfoText
        _style.Border.Direction = BorderDirEnum.Horizontal
        _flex.Rows(_row).Style = _style

        ' add event handlers
        AddHandler _flex.KeyDown, New KeyEventHandler(AddressOf _flex_KeyDown)
        AddHandler _flex.BeforeMouseDown, New BeforeMouseDownEventHandler(AddressOf _flex_BeforeMouseDown)
        AddHandler _flex.RowColChange, New EventHandler(AddressOf _flex_RowColChange)
        AddHandler _flex.AfterEdit, New RowColEventHandler(AddressOf _flex_AfterEdit)
    End Sub

    ' ** event handlers

    ' custom logic for selection, clearing the filter
    Private Sub _flex_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

        ' user hit f3 or up arrow on the first scrollable row
        If (e.KeyCode = Keys.F3 OrElse (e.KeyCode = Keys.Up AndAlso _flex.Row = _row + 1)) Then

            ' select the filter cell and go start editing it
            _flex.Select(_row, _flex.Col)
            e.Handled = True
        End If

        ' user hit Del when the filter row is selected
        If (e.KeyCode = Keys.Delete AndAlso _flex.Row = _row) Then
            Dim col As Integer
            For col = _flex.Cols.Fixed To _flex.Cols.Count - 1
                _flex(_row, col) = Nothing
            Next
            UpdateFilter()
            e.Handled = True
        End If

    End Sub

    ' special mouse handling for filter row
    Private Sub _flex_BeforeMouseDown(ByVal sender As Object, ByVal e As BeforeMouseDownEventArgs)

        ' detect clicks on filter row
        If ((e.Button And MouseButtons.Left) <> 0 AndAlso _row > 0 AndAlso _flex.MouseRow = _row) Then

            ' get the column that was clicked
            Dim col As Integer = _flex.MouseCol

            ' fixed col? select the whole filter row
            If (col < _flex.Cols.Fixed) Then
                _flex.Select(_row, _flex.Cols.Fixed, _row, _flex.Cols.Count - 1)
                _flex.FinishEditing(True)
            Else ' clicked a cell on the filter row, select it
                _flex.Select(_row, col)
            End If

            ' eat the event (no sorting, sizing etc)
            e.Cancel = True
        End If
    End Sub

    ' keep filter row in edit mode
    Private Sub _flex_RowColChange(ByVal sender As Object, ByVal e As EventArgs)

        ' we're only interested in cursor changes
        If (_row > -1 AndAlso (_flex.Row <> _row OrElse _flex.Col <> _col)) Then

            ' if the new cell is in the filter row, start editing
            _col = -1
            If (_flex.Row = _row) Then
                _col = _flex.Col
                _flex.StartEditing()
            End If
        End If
    End Sub

    ' update the filter after any edits to the filter row
    Private Sub _flex_AfterEdit(ByVal sender As Object, ByVal e As RowColEventArgs)
        If (e.Row = _row) Then
            UpdateFilter()
        End If
    End Sub

    ' ** object model
    Public Property Visible() As Boolean
        Get
            Return _flex.Rows(_row).Visible
        End Get
        Set(ByVal Value As Boolean)
            _flex.Rows(_row).Visible = Value
        End Set
    End Property

    Public Sub Clear()
        Dim col As Integer
        For col = 0 To _flex.Cols.Count - 1
            _flex(_row, col) = Nothing
        Next
        UpdateFilter()
    End Sub

    ' ** event handlers

    ' ** utilities

    ' update filter (called after editing the filter row)
    Private Sub UpdateFilter()

        ' make sure we have a filter row
        If _row < 0 Then Return

        ' save filter row content <<**
        Dim rgFilter As C1.Win.C1FlexGrid.CellRange = _flex.GetCellRange(_row, 0, _row, _flex.Cols.Count - 1)
        Dim filterContent As String = rgFilter.Clip

        ' make sure we have a data view
        Dim dv As DataView = Nothing
        If TypeOf _flex.DataSource Is DataView Then
            dv = _flex.DataSource
        End If
        If TypeOf _flex.DataSource Is DataTable Then
            Dim dt As DataTable = _flex.DataSource
            dv = dt.DefaultView
        End If
        If dv Is Nothing Then
            Debug.WriteLine("DataSource should be a DataTable or DataView.")
            Return
        End If

        ' scan each cell in the filter row and build new filter
        Dim sb As New StringBuilder
        Dim col As Integer
        For col = _flex.Cols.Fixed To _flex.Cols.Count - 1

            ' get value for this column
            Dim expr As String = _flex.GetDataDisplay(_row, col).TrimEnd()
            If expr.Length > 0 Then

                ' get filter expression
                expr = BuildFilterExpression(col, expr)
                If expr.Length > 0 Then

                    ' concatenate new condition
                    If (sb.Length > 0) Then sb.Append(" And ")
                    sb.AppendFormat("[{0}]{1}", _flex.Cols(col).Name, expr)
                End If
            End If
        Next

        ' apply filter to current view
        Dim strFilter As String = sb.ToString()
        If strFilter = dv.RowFilter Then Return
        Try
            _flex(_row, 0) = Nothing
            dv.RowFilter = strFilter
        Catch
            _flex(_row, 0) = "Err"
            Debug.WriteLine("Bad filter expression.")
        End Try

        ' restore filter row content <<**
        rgFilter.Clip = filterContent

        ' stay in filter row
        _flex.Row = _row

    End Sub


    ' Build a filter expression to apply to data table
    '
    ' This takes a value in the filter row and converts it into 
    ' a filter expression. For example:
    '
    ' Text		Filter Expression
    ' -------  -----------------
    ' smith    like 'smith*'
    ' > s      > 's'
    '
    Private Function BuildFilterExpression(ByVal col As Integer, ByVal expr As String) As String

        ' operators we recognize
        Dim oper As String = "<>="

        ' no operators? use 'like' for strings, or '=' for other datatypes 
        If (oper.IndexOf(Left(expr, 1)) < 0) Then
            If _flex.Cols(col).DataType Is GetType(String) Then
                Return String.Format(" like '{0}*'", expr)
            Else
                Return String.Format(" = '{0}'", expr)
            End If
        End If

        ' look for end of operators
        Dim index As Integer
        For index = 0 To expr.Length - 1
            If (oper.IndexOf(Mid(expr, index + 1, 1)) < 0) Then
                Dim retval As String = expr.Substring(0, index) + " "
                retval = retval + String.Format("'{0}'", expr.Substring(index).Trim())
                Return retval
            End If
        Next

        ' if we got here, the condition must be bad (e.g. ><)
        Debug.WriteLine("Can't build filter expression.")
        Return ""
    End Function

End Class
