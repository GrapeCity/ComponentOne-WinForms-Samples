Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports C1.Win.C1Editor
Imports C1.Win.C1Editor.Internal.HTML

Partial Public Class Form1
    Inherits Form

    Private _currentControl As Control = Nothing
    Private _currentHTMLElement As IHTMLElement = Nothing

    Public Sub New()
        Application.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture
        InitializeComponent()

        AddHandler c1Editor1.HtmlEvent, AddressOf c1Editor1_HtmlEvent
        AddHandler TextBox1.TextChanged, AddressOf control_TextChanged
        AddHandler DateTimePicker1.TextChanged, AddressOf control_TextChanged
        AddHandler ComboBox1.TextChanged, AddressOf control_TextChanged

    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        c1Editor1.LoadXml(Resources.Document, Nothing)
    End Sub

    Private Sub c1Editor1_HtmlEvent(ByVal sender As Object, ByVal e As HtmlEventEventArgs)
        If e.Type <> C1.Win.C1Editor.HtmlEventTypes.MouseOver Then 'only MouseOver event is handled
            Exit Sub
        End If
        Dim isLinked As Boolean = False
        Dim element As IHTMLElement = e.HTMLEventObj.SrcElement
        If Not element Is Nothing Then
            Dim oClassName As Object = element.getAttribute("className", 0) 'get class name of the current element
            If TypeOf oClassName Is String Then
                Dim className As String = CType(oClassName, String)
                Select Case className
                    Case "pubtitle", "subtitle", "other", "pubname", "isbn" 'text input fields
                        LinkControlToElement(TextBox1, element)
                        isLinked = True
                    Case "date" 'date input fields
                        LinkControlToElement(DateTimePicker1, element)
                        isLinked = True
                    Case "pubcity" 'combobox input fields
                        LinkControlToElement(ComboBox1, element)
                        isLinked = True
                End Select
            End If
        End If
        If Not isLinked Then
            HideCurrentVisibleControl() 'hide current control if visible
        End If
    End Sub

    Private Sub control_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        If _currentHTMLElement Is Nothing Then
            Exit Sub
        End If
        _currentHTMLElement.innerText = _currentControl.Text
    End Sub

    Private Sub LinkControlToElement(ByVal control As Control, ByVal element As IHTMLElement)
        If _currentControl Is control Then 'this control is already visible
            Exit Sub
        ElseIf Not _currentControl Is Nothing Then
            HideCurrentVisibleControl() 'visible control found? Then hide it.
        End If

        _currentControl = control
        _currentHTMLElement = element

        Dim x As Integer = element.offsetLeft
        Dim y As Integer = element.offsetTop
        Dim width As Integer = element.offsetWidth

        'set location, width and text of the control, and make them visible
        control.Location = New System.Drawing.Point(x, y)
        control.Width = width + 20
        control.Text = element.innerText
        control.Visible = True
    End Sub

    Private Sub HideCurrentVisibleControl()
        If _currentControl Is Nothing Then
            Exit Sub
        End If
        'hide the current visible control
        _currentControl.Visible = False
        _currentControl = Nothing
        _currentHTMLElement = Nothing
    End Sub

End Class

