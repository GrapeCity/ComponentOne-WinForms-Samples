Imports System.IO
Imports C1.C1Report

Public Class DataSource
    Implements IC1ReportRecordset

    Public Enum FieldNames
        Name
        Path
        Title
        Extension
        Size
        ModDate
        Attributes
    End Enum

    ' shared mamebers: field names and types
    Private Shared _names() As String = {"Name", "Path", "Title", "Extension", "Size", "ModDate", "Attributes"}
    Private Shared _types() As Type = {GetType(String), GetType(String), GetType(String), GetType(String), GetType(Integer), GetType(DateTime), GetType(FileAttributes)}

    ' instance members
    Private _position As Integer        ' cursor position
    Private _list As ArrayList          ' data

    Private Const MAXFILES As Integer = 3000

    ' ** Constructor

    Public Sub New(ByVal dir As String)

        ' create file list
        _list = New ArrayList()

        ' populate list
        ReadDir(dir)

    End Sub

    Private Sub ReadDir(ByVal dir As String)

        ' add files in this dir
        Dim s As String
        Dim files As String() = Directory.GetFiles(dir)
        For Each s In files
            _list.Add(s)
            If _list.Count >= MAXFILES Then Exit Sub
        Next

        ' and add all subdirs
        Dim dirs As String() = Directory.GetDirectories(dir)
        For Each s In dirs
            ReadDir(s)
            If _list.Count >= MAXFILES Then Exit Sub
        Next

    End Sub

    ' ** IC1ReportRecordset members

    ' get recordset information

    Public Function GetFieldNames() As String() Implements IC1ReportRecordset.GetFieldNames
        GetFieldNames = _names
    End Function

    Public Function GetFieldTypes() As Type() Implements IC1ReportRecordset.GetFieldTypes
        GetFieldTypes = _types
    End Function

    Public Function GetFieldValue(ByVal fieldIndex As Integer) As Object Implements IC1ReportRecordset.GetFieldValue

        GetFieldValue = String.Empty

        ' get entry from list
        Dim name As String = _list(_position)

        ' return the part we're interested in
        Select Case CType(fieldIndex, FieldNames)

            Case FieldNames.Name
                GetFieldValue = name

            Case FieldNames.Path
                GetFieldValue = Path.GetDirectoryName(name)

            Case FieldNames.Title
                GetFieldValue = Path.GetFileNameWithoutExtension(name)

            Case FieldNames.Extension
                name = Path.GetExtension(name)
                If name.Length > 0 Then name = name.Substring(1)
                GetFieldValue = name.ToLower()

            Case FieldNames.Size
                GetFieldValue = FileLen(name)

            Case FieldNames.ModDate
                GetFieldValue = File.GetLastWriteTime(name)

            Case FieldNames.Attributes
                GetFieldValue = File.GetAttributes(name).ToString()

        End Select

    End Function

    ' sort/filter
    Public Sub ApplyFilter(ByVal filter As String) Implements IC1ReportRecordset.ApplyFilter
        ' not implemented
    End Sub
    Public Sub ApplySort(ByVal sort As String) Implements IC1ReportRecordset.ApplySort
        ' not implemented
    End Sub

    ' cursor positioning
    Public Function BOF() As Boolean Implements IC1ReportRecordset.BOF
        BOF = (_position = 0)
    End Function
    Public Function EOF() As Boolean Implements IC1ReportRecordset.EOF
        EOF = (_position >= _list.Count)
    End Function
    Public Function GetBookmark() As Integer Implements IC1ReportRecordset.GetBookmark
        GetBookmark = _position
    End Function
    Public Sub SetBookmark(ByVal bkmk As Integer) Implements IC1ReportRecordset.SetBookmark
        _position = bkmk
    End Sub
    Public Sub MoveFirst() Implements IC1ReportRecordset.MoveFirst
        _position = 0
    End Sub
    Public Sub MoveLast() Implements IC1ReportRecordset.MoveLast
        _position = _list.Count - 1
    End Sub
    Public Sub MovePrevious() Implements IC1ReportRecordset.MovePrevious
        If _position > 0 Then
            _position = _position - 1
        End If
    End Sub
    Public Sub MoveNext() Implements IC1ReportRecordset.MoveNext
        If _position < _list.Count Then
            _position = _position + 1
        End If
    End Sub

End Class
