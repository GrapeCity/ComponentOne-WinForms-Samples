Public Class AddNewColumnForm

    Public ReadOnly Property ColumnName As String
        Get
            Return tbName.Text
        End Get
    End Property

    Public ReadOnly Property ColumnHeaderText As String
        Get
            Return tbHeaderText.Text
        End Get
    End Property

    Public ReadOnly Property ColumnDisplayFieldName As String
        Get
            Return tbDisplayFieldName.Text
        End Get
    End Property

End Class