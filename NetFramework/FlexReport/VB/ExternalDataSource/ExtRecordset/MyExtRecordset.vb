Imports C1.Win.FlexReport

Public Class MyRecordset
    Implements IC1FlexReportRecordset

    Private _recNo As Integer
    Private _recCount As Integer

    Sub New()
        _recCount = 60
    End Sub

    Public Property RecCount As Integer
        Get
            Return _recCount
        End Get
        Set(value As Integer)
            _recCount = value
        End Set
    End Property

    Public Function GetFieldNames() As String() Implements IC1FlexReportRecordset.GetFieldNames
        Return New String() {"ID", "Caption"}
    End Function

    Public Function GetFieldTypes() As Type() Implements IC1FlexReportRecordset.GetFieldTypes
        Return New Type() {GetType(Integer), GetType(String)}
    End Function

    Public Function GetFieldValue(fieldIndex As Integer) As Object Implements IC1FlexReportRecordset.GetFieldValue
        Select Case fieldIndex
            Case 0
                Return _recNo + 1
            Case 1
                Return String.Format("Caption {0}", _recNo + 1)
            Case Else
                Return Nothing
        End Select
    End Function

    Public Function BOF() As Boolean Implements IC1FlexReportRecordset.BOF
        Return _recNo < 0
    End Function

    Public Function EOF() As Boolean Implements IC1FlexReportRecordset.EOF
        Return _recNo >= _recCount
    End Function

    Public Sub MoveFirst() Implements IC1FlexReportRecordset.MoveFirst
        _recNo = 0
    End Sub

    Public Sub MoveLast() Implements IC1FlexReportRecordset.MoveLast
        _recNo = _recCount - 1
    End Sub

    Public Sub MovePrevious() Implements IC1FlexReportRecordset.MovePrevious
        _recNo = _recNo - 1
    End Sub

    Public Sub MoveNext() Implements IC1FlexReportRecordset.MoveNext
        _recNo = _recNo + 1
    End Sub

    Public Function GetBookmark() As Integer Implements IC1FlexReportRecordset.GetBookmark
        Return _recNo
    End Function

    Public Sub SetBookmark(bkmk As Integer) Implements IC1FlexReportRecordset.SetBookmark
        _recNo = bkmk
    End Sub

    Public ReadOnly Property Count As Integer Implements IC1FlexReportRecordset.Count
        Get
            Return _recCount
        End Get
    End Property

End Class


Public Class MyExtRecordset
    Implements IC1FlexReportExternalRecordset

    Private _recordset As MyRecordset

    Sub New()
        _recordset = New MyRecordset()
    End Sub

    Public Property RecCount As Integer
        Get
            Return _recordset.RecCount
        End Get
        Set(value As Integer)
            _recordset.RecCount = value
        End Set
    End Property

    Public Sub EditParams() Implements IC1FlexReportExternalRecordset.EditParams
        Dim f = New MyExtRecordsetForm()
        f.Edit(Me)
    End Sub

    Public Function GetRecordset() As IC1FlexReportRecordset Implements IC1FlexReportExternalRecordset.GetRecordset
        Return _recordset
    End Function

    Public ReadOnly Property Caption As String Implements IC1FlexReportExternalRecordset.Caption
        Get
            Return "External Recordset Sample"
        End Get
    End Property

    Public Property Params As String Implements IC1FlexReportExternalRecordset.Params
        Get
            Return _recordset.RecCount.ToString()
        End Get
        Set(value As String)
            Dim count As Integer = 0
            If (Integer.TryParse(value, count)) Then
                _recordset.RecCount = count
            End If
        End Set
    End Property
End Class
