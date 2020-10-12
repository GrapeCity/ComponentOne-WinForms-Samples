
Imports System.ComponentModel

Public Class Employee
    Private _id As Integer
    Private _chiefID As Integer
    Private _firstName As String
    Private _lastName As String
    Private _post As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, chiefID As Integer, firstName As String, lastName As String, post As String)
        _id = id
        _chiefID = chiefID
        _firstName = firstName
        _lastName = lastName
        _post = post
    End Sub

    <Browsable(False)>
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set
            If _id <> Value Then
                _id = Value
                OnPropertyChanged(New PropertyChangedEventArgs("ID"))
            End If
        End Set
    End Property
    <Browsable(False)>
    Public Property ChiefID() As Integer
        Get
            Return _chiefID
        End Get
        Set
            If _chiefID <> Value Then
                _chiefID = Value
                OnPropertyChanged(New PropertyChangedEventArgs("ChiefID"))
            End If
        End Set
    End Property
    Public Property Post() As String
        Get
            Return _post
        End Get
        Set
            If _post <> Value Then
                _post = Value
                OnPropertyChanged(New PropertyChangedEventArgs("Post"))
            End If
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set
            If _lastName <> Value Then
                _lastName = Value
                OnPropertyChanged(New PropertyChangedEventArgs("LastName"))
            End If
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set
            If _firstName <> Value Then
                _firstName = Value
                OnPropertyChanged(New PropertyChangedEventArgs("FirstName"))
            End If
        End Set
    End Property

#Region "INotifyPropertyChanged Members"

    Public Event PropertyChanged As PropertyChangedEventHandler

    Protected Overridable Sub OnPropertyChanged(e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub

#End Region
End Class