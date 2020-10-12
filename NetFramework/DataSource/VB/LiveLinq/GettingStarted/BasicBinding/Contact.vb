Public Class Contact
    Inherits C1.LiveLinq.Collections.IndexableObject

    Private _name As String

    Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal Value As String)
            _name = Value
            OnPropertyChanged("Name")
        End Set
    End Property

End Class
