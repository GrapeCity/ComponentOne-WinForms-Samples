
Imports System
Imports System.Diagnostics



'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Hyperlink
    Private _text As String
    Private _link As String
    Private _visited As Boolean


    Public Sub New(ByVal [text] As String, ByVal link As String)
        _text = [text]
        _link = link
        _visited = False
    End Sub 'New

    Public ReadOnly Property Visited() As Boolean
        Get
            Return _visited
        End Get
    End Property

    Public Function Activate() As Process
        _visited = True
        Return Process.Start(_link)
    End Function 'Activate

    Public Overrides Function ToString() As String
        Return _text
    End Function 'ToString
End Class 'Hyperlink
