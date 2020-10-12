Imports System
Imports C1.Win.Layout

Namespace DashboardDemo.Controls
    Public Class FilePathEventArgs
        Inherits EventArgs

        Public Sub New(ByVal path As String)
            MyBase.New()
            FilePath = path
        End Sub

        Public Property FilePath As String
    End Class

    Public Class LayoutTypeEventArgs
        Inherits EventArgs

        Public Sub New(ByVal lType As LayoutType)
            MyBase.New()
            Type = lType
        End Sub

        Public Property Type As LayoutType
    End Class

    Public Class ToolIconAppearanceEventArgs
        Inherits EventArgs

        Public Sub New(ByVal tia As ToolIconAppearance)
            MyBase.New()
            ToolIconAppearance = tia
        End Sub

        Public Property ToolIconAppearance As ToolIconAppearance
    End Class
End Namespace
