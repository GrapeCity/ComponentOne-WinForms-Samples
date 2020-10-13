Public Class SeriesDialog

    Public Sub New(ByVal appSubject As String)
        Font = SystemInformation.MenuFont
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        If (appSubject.Length > 20) Then
            _lblMessage.Text = String.Format(_lblMessage.Text, appSubject.Substring(0, 17) + "...")
        Else
            _lblMessage.Text = String.Format(_lblMessage.Text, appSubject)
        End If
        _pBox.Image = SystemIcons.Exclamation.ToBitmap()
    End Sub

    ' <summary>
    ' Gets the <see cref="Boolean"/> value determining whether end-user selected 
    ' the series or individual occurrence.
    ' </summary>
    Public ReadOnly Property Series() As Boolean
        Get
            Return _rbSeries.Checked
        End Get
    End Property

End Class