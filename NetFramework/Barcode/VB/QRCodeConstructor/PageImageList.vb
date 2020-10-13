Imports System.IO
Imports System.ComponentModel
Imports System.Drawing.Imaging

#If False Then

' This version of the PageImageList stores images as byte arrays. It is a little
' more complex and slower than a simple list, but doesn't consume GDI resources.
' This is important when the list contains lots of images (Windows only supports
' 10,000 simultaneous GDI objects!)
Friend Class PageImageList

    ' ** fields
    Private _list As List(Of Byte()) = New List(Of Byte())

    ' ** Properties
    Public ReadOnly Property Count() As Integer
        Get
            Return Me._list.Count
        End Get
    End Property

    Default Public Property Item(ByVal index As Integer) As Image
        Get
            Return Me.GetImage(Me._list.Item(index))
        End Get
        Set(ByVal value As Image)
            Me._list.Item(index) = Me.GetBytes(value)
        End Set
    End Property

    ' ** methods
    Public Sub Add(ByVal img As Image)
        Me._list.Add(Me.GetBytes(img))
        img.Dispose()
    End Sub

    Public Sub Clear()
        Me._list.Clear()
    End Sub

    ' ** implementation
    Function GetBytes(ByVal img As Image) As Byte()
        Dim mf As Metafile = TryCast(img, Metafile)
        Dim enhMetafileHandle As Integer = mf.GetHenhmetafile.ToInt32
        Dim bufferSize As Integer = PageImageList.GetEnhMetaFileBits(enhMetafileHandle, 0, Nothing)
        Dim buffer As Byte() = New Byte(bufferSize - 1) {}
        PageImageList.GetEnhMetaFileBits(enhMetafileHandle, bufferSize, buffer)
        Return buffer
    End Function

    <System.Runtime.InteropServices.DllImport("gdi32")> _
    Shared Function GetEnhMetaFileBits(ByVal hemf As Integer, ByVal cbBuffer As Integer, ByVal lpbBuffer As Byte()) As Integer
    End Function

    Function GetImage(ByVal data As Byte()) As Image
        Dim ms As New MemoryStream(data)
        Return Image.FromStream(ms)
    End Function

End Class

#Else

' use regular generic list
Public Class PageImageList
    Inherits List(Of Image)
End Class

#End If
