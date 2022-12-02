Imports C1.Framework
Imports C1.Win.TreeView

Public Class HyperLinkPresenter
    Inherits CustomContentPresenter

    Private _hyperLink As HyperLinkElement

    Public Sub New()
        _hyperLink = New HyperLinkElement()
        _hyperLink.Style = New Style()
        _hyperLink.Style.Margins = New Thickness(0, 4)
        AddHandler _hyperLink.Click, AddressOf hyperLink_Click
        ' CustomContentPresenter child has a parent size, so we add an intermediate panel.
        Dim panel = New RowPanel()
        panel.Children.Add(_hyperLink)

        Child = panel
    End Sub

    Private Sub hyperLink_Click(sender As Object, e As EventArgs)
        Dim url = DirectCast(Node.GetValue(), Hyperlink).Url
        System.Diagnostics.Process.Start(url)
    End Sub

#Region "ICellContentPresenter"
    Public Overrides Sub SetStyle(styles As TreeNodeCellStyles)
        _hyperLink.Style.Font = styles.Font
    End Sub

    Public Overrides Sub SetValue(value As Object)
        _hyperLink.Text = value?.ToString()
    End Sub

    Public Overrides ReadOnly Property ToolTipText() As String
        Get
            Return String.Empty
        End Get
    End Property

    Public Overrides Sub SetFormat(format As String)

    End Sub
#End Region

End Class

Public Class HyperLinkElement
    Inherits TextElement

    Private _isVisited As Boolean
    Private _oldCursor As Cursor
    Private _defaultColor As Color

    Public Sub New()
        HitTestable = True
    End Sub

    Public Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        ' saves cursor and changes to hand
        _oldCursor = HostControl.Cursor
        HostControl.Cursor = Cursors.Hand
        ' set underline
        Style.Font = New Font(Style.Font, FontStyle.Underline)
    End Sub

    Public Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        ' reset cursor
        HostControl.Cursor = _oldCursor
        ' reset font
        Style.Font = New Font(Style.Font, FontStyle.Regular)
    End Sub

    Public Property IsVisited() As Boolean
        Get
            Return _isVisited
        End Get
        Set
            _isVisited = Value
            If _isVisited Then
                _defaultColor = Style.ForeColor
                ' set visited color
                Style.ForeColor = System.Drawing.Color.FromArgb(128, 0, 128)
            Else
                Style.ForeColor = _defaultColor
            End If
        End Set
    End Property

    Public Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        IsVisited = True
        RaiseEvent Click(Me, e)
    End Sub

    Public Event Click As EventHandler
End Class
