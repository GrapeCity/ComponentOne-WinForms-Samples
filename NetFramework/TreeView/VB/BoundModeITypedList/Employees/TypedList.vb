Imports System.ComponentModel

<Serializable>
Public Class TypedList(Of T)
    Inherits BindingList(Of T)
    Implements ITypedList

    <NonSerialized>
    Private properties As PropertyDescriptorCollection

    Public Sub New()
        MyBase.New()
        Dim pdc As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T), New Attribute() {New BrowsableAttribute(True)})
        properties = pdc
    End Sub

#Region "ITypedList Implementation"

    Private Function ITypedList_GetItemProperties(listAccessors() As PropertyDescriptor) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
        Dim pdc As PropertyDescriptorCollection

        If listAccessors IsNot Nothing AndAlso listAccessors.Length > 0 Then
            pdc = ListBindingHelper.GetListItemProperties(listAccessors(0).PropertyType)
        Else
            pdc = properties
        End If

        Return pdc
    End Function

    Private Function ITypedList_GetListName(listAccessors() As PropertyDescriptor) As String Implements ITypedList.GetListName
        Return GetType(T).Name
    End Function

#End Region
End Class

