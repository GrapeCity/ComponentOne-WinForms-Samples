Public Class ContactCard

    ' Fields...
    Private _memo As String
    Private _websiteAddress As String
    Private _eMailAddress As String

    ' Properties...
    Public Property ContactCode() As String
    Public Property Telephone() As String
    Public Property LastName() As String
    Public Property FirstName() As String
    Public Property Year() As String
    Public Property Month() As String
    Public Property Day() As String
    Public Property PostCode() As String
    Public Property Country() As String
    Public Property City() As String
    Public Property Town() As String
    Public Property Street() As String
    Public Property MobileTelephone() As String
    Public Property FullName() As String
    Public Property MainTelephone() As String

    Public Property Memo As String
        Get
            Return _memo
        End Get
        Set(ByVal Value As String)
            _memo = String.Format("NOTE:{0};", Value)
        End Set
    End Property

    Public Property WebsiteAddress As String
        Get
            Return _websiteAddress
        End Get
        Set(ByVal Value As String)
            _websiteAddress = String.Format("URL:{0};", Value)
        End Set
    End Property

    Public Property Birthday() As String

    Public Property EMailAddress As String
        Get
            Return _eMailAddress
        End Get
        Set(ByVal Value As String)
            _eMailAddress = String.Format("EMAIL:{0};", Value)
        End Set
    End Property

    Public Property Address() As String

    Private Sub CreateTelephone()
        If MainTelephone <> String.Empty Then
            If MobileTelephone <> String.Empty Then
                Telephone = String.Format("TEL:{0};TEL:{1};", MainTelephone, MobileTelephone)
            End If
            Telephone = String.Format("TEL:{0};", MainTelephone)

        End If
    End Sub
    
    Private Sub CreateAddress()
        Address = String.Format("ADR:{0};", Street)
        If Town <> String.Empty Then
            Address = String.Format("ADR:{0},{1};", Street, Town)
            If Country <> String.Empty Then
                Address = String.Format("ADR:{0},{1},{2},{3};", Street, Town, PostCode, Country)
            Else
                Address = String.Format("ADR:{0},{1},{2};", Street, Town, PostCode)
            End If
        End If
    End Sub

    Private Sub CreateBirthday()
        If Day <> String.Empty Then
            Birthday = String.Format("BDAY:{0}{1}{2};", Year, Month, Day)
        End If
    End Sub

    Private Sub CreateFullName()
        FullName = String.Format("N:{0},{1};", LastName, FirstName)
    End Sub

    Public Sub CreateContactCode()
        CreateTelephone()
        CreateAddress()
        CreateBirthday()
        CreateFullName()
        If Memo <> String.Empty Then
            If Birthday <> String.Empty Then
                ContactCode = String.Format("MECARD:{0}{1}{2}{3}{4}{5}{6};", FullName, Telephone, EMailAddress, WebsiteAddress, Address, Memo, Birthday)
                Return
            End If
            ContactCode = String.Format("MECARD:{0}{1}{2}{3}{4}{5};", FullName, Telephone, EMailAddress, WebsiteAddress, Address, Memo)
        Else
            If Birthday <> String.Empty Then
                ContactCode = String.Format("MECARD:{0}{1}{2}{3}{4}{5};", FullName, Telephone, EMailAddress, WebsiteAddress, Address, Birthday)
                Return
            End If
            ContactCode = String.Format("MECARD:{0}{1}{2}{3}{4};", FullName, Telephone, EMailAddress, WebsiteAddress, Address)
        End If
    End Sub
End Class
