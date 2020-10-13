Public Class EmailForm

    ' Fields...
    Private _formEmailAddress As String
    Private _body As String
    Private _subject As String

    ' Properties...







    Public Property EmailCode() As String
    
    Public Property FormEmailAddress As String
        Get
            Return _formEmailAddress
        End Get
        Set(ByVal Value As String)
            _formEmailAddress = String.Format("TO:{0};", Value)
        End Set
    End Property
    
    Public Property Body As String
        Get
            Return _body
        End Get

        Set(ByVal Value As String)
            _body = String.Format("BODY:{0};", Value)
        End Set
    End Property

    Public Property Subject As String
        Get
            Return _subject
        End Get
        Set(ByVal Value As String)
            _subject = String.Format("SUB:{0};", Value)
        End Set
    End Property




    Public Sub CreateEmailCode()
        EmailCode = String.Format("MATMSG:{0}{1}{2};", _formEmailAddress, _subject, _body)
    End Sub


    

End Class
