Imports System
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1SpellChecker

'Namespace QuickStart
''' <summary> 
''' Wrapper class that implements the ISpellCheckableEditor interface 
''' on behalf of a C1FlexGrid so the grid can be spell-checked with the 
''' C1SpellChecker component. 
''' </summary> 
Public Class FlexGridSpeller
    Implements ISpellCheckableEditor
    '----------------------------------------------------------------------------- 
#Region "** fields"

    Private _flex As C1FlexGrid
    ' grid being spell-checked 
    Private _cols As Integer()
    ' columns to be spell-checked 
    Private _row As Integer, _col As Integer
    ' cell being spell-checked (_row, _cols[_col]) 
    Private _selStart As Integer
    ' selection being checked within the cell 
    Private _selLength As Integer

#End Region

    '----------------------------------------------------------------------------- 
#Region "** ctors"

    ' check some columns 
    Public Sub New(ByVal flex As C1FlexGrid, ByVal ParamArray cols As String())
        ' save parameters 
        _flex = flex

        ' create column list if needed 
        If cols Is Nothing Then
            Dim list As New List(Of String)()
            For Each col As Column In flex.Cols
                If col.DataType.ToString() = "String" Then
                    list.Add(col.Name)
                End If
            Next
            cols = list.ToArray()
        End If

        ' convert column names to column indices 
        _cols = New Integer(cols.Length - 1) {}
        For i As Integer = 0 To _cols.Length - 1
            Dim name As String = cols(i)
            If Not _flex.Cols.Contains(name) Then
                Throw New Exception("column not found: " + name)
            End If
            _cols(i) = _flex.Cols(name).Index
        Next

        ' scan cells until an error is found 
        _row = -1
        _col = 0
        MoveNext()
    End Sub

    ' check all columns 
    Public Sub New(ByVal flex As C1FlexGrid)
        Me.New(flex, Nothing)
    End Sub

#End Region

    '----------------------------------------------------------------------------- 
#Region "** object model"

    ' move on to the next cell 
    Public Function MoveNext() As Boolean
        ' initialize or increment row/col position 
        If _row < 0 Then
            ' initialize 
            _row = _flex.Rows.Fixed
            _col = 0
        ElseIf _col < _cols.Length - 1 Then
            ' next column 
            _col += 1
        Else
            ' next row 
            _row += 1
            _col = 0
        End If

        ' return true if we still have valid cells 
        Return _row < _flex.Rows.Count AndAlso _col < _cols.Length
    End Function

#End Region

    '----------------------------------------------------------------------------- 
#Region "** ISpellCheckableEditor"

    Public ReadOnly Property Control() As Control Implements C1.Win.C1SpellChecker.ISpellCheckableEditor.Control
        Get
            Return _flex
        End Get
    End Property
    Public Property HideSelection() As Boolean Implements C1.Win.C1SpellChecker.ISpellCheckableEditor.HideSelection
        Get
            Return False
        End Get
        Set(ByVal value As Boolean)
        End Set
    End Property
    Public Property Text() As String Implements C1.Win.C1SpellChecker.ISpellCheckableEditor.Text
        Get
            Return _flex.GetDataDisplay(_row, _cols(_col))
        End Get
        Set(ByVal value As String)
            _flex(_row, _cols(_col)) = value
        End Set
    End Property
    Public Property SelectedText() As String Implements C1.Win.C1SpellChecker.ISpellCheckableEditor.SelectedText
        Get
            Return Text.Substring(_selStart, _selLength)
        End Get
        Set(ByVal value As String)
            Dim text As String = Me.Text
            text = String.Format("{0}{1}{2}", text.Substring(0, _selStart), value, text.Substring(_selStart + _selLength))
            Me.Text = text
        End Set
    End Property
    Public Property SelectionLength() As Integer Implements C1.Win.C1SpellChecker.ISpellCheckableEditor.SelectionLength
        Get
            Return _selLength
        End Get
        Set(ByVal value As Integer)
            _selLength = value
        End Set
    End Property
    Public Property SelectionStart() As Integer Implements C1.Win.C1SpellChecker.ISpellCheckableEditor.SelectionStart
        Get
            Return _selStart
        End Get
        Set(ByVal value As Integer)
            _selStart = value
        End Set
    End Property
    Public Sub [Select](ByVal start As Integer, ByVal length As Integer) Implements C1.Win.C1SpellChecker.ISpellCheckableEditor.Select
        ' keep track of selection within the cell 
        _selStart = start
        _selLength = length

        ' check that the cell being checked is selected 
        _flex.[Select](_row, _cols(_col))
    End Sub
    Public Sub SelectAll()
        _selStart = 0
        _selLength = Text.Length
    End Sub
    Public Function HasMoreText() As Boolean Implements C1.Win.C1SpellChecker.ISpellCheckableEditor.HasMoreText
        Return MoveNext()
    End Function
    Public Sub BeginSpell() Implements C1.Win.C1SpellChecker.ISpellCheckableEditor.BeginSpell
    End Sub
    Public Sub EndSpell() Implements C1.Win.C1SpellChecker.ISpellCheckableEditor.EndSpell
    End Sub
#End Region

End Class
'End Namespace
