Imports C1.Win.C1Ribbon

Public Class About
    ''' <summary>
    ''' Initializes a new instance of the About class.
    ''' </summary>
    Public Sub New(ByVal vs As VisualStyle)
        InitializeComponent()
        VisualStyle = vs
    End Sub
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ensure copyright period extends to current year  
        Dim dt As Date = Now
        If dt.Year <> 2011 Then
            Dim yr As Integer = dt.Year
            C1SuperLabel2.Text = String.Format("<b>© Dom Sinclair / View to Learn 2011-{0}</b>", yr)
        Else
            C1SuperLabel2.Text = "<b>© Dom Sinclair / View to Learn 2011</b>"
        End If
    End Sub

 
End Class
