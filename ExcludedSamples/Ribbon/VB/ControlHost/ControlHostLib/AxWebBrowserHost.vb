Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon

''' <summary>
''' The Ribbon element that contains an ActiveX element (WebBrowser).
''' </summary>
Public Class AxWebBrowserHost
    Inherits RibbonControlHost

    Private _nextUrl As String
    Public Const XmlNodeName As String = "axWebBrowserHost"

    ''' <summary>
    ''' Creates the ActiveX control and its host element.
    ''' </summary>
    Public Sub New()
        MyBase.New(New AxSHDocVw.AxWebBrowser())
    End Sub

    ''' <summary>
    ''' <inheritdoc />
    ''' </summary>
    Public Overrides ReadOnly Property ControlHostNodeName As String
        Get
            Return XmlNodeName
        End Get
    End Property

    ''' <summary>
    ''' Gets the hosted AxWebBrowser control.
    ''' </summary>
    <Browsable(False)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property AxWebBrowser() As AxSHDocVw.AxWebBrowser
        Get
            Return CType(Control, AxSHDocVw.AxWebBrowser)
        End Get
    End Property

    ''' <summary>
    ''' Navigates the browser to the specified URL.
    ''' </summary>
    Public Sub Navigate(ByVal url As String)
        If Not AxWebBrowser.IsHandleCreated Then
            _nextUrl = url
            AddHandler AxWebBrowser.HandleCreated, AddressOf AxWebBrowser_HandleCreated
        Else
            AxWebBrowser.Navigate(url)
        End If
    End Sub

    Private Sub AxWebBrowser_HandleCreated(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler AxWebBrowser.HandleCreated, AddressOf AxWebBrowser_HandleCreated
        If _nextUrl IsNot Nothing Then
            AxWebBrowser.Navigate(_nextUrl)
            _nextUrl = Nothing
        End If
    End Sub

End Class
