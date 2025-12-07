Public Class Form2
    'save default font size for scaling
    Dim _defaultFontSize = 8.25F

    Private Sub btnSetAsApplicationTheme_Click(sender As System.Object, e As System.EventArgs) Handles btnSetAsApplicationTheme.Click
        Dim f2 = New Form2()
        f2.SetDesktopLocation(Me.DesktopBounds.Left + 20, Me.DesktopBounds.Top + 20)
        f2.Show()
    End Sub

    ''' <summary>
    ''' Event fired when a theme on an object managed by a theme controller has changed.
    ''' We use this event to ensure that even if the theme specifies a font for C1Label,
    ''' the size of the font on our label stays 12.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub c1ThemeController1_ObjectThemeApplied(sender As C1.Win.Themes.C1ThemeController, e As C1.Win.Themes.ObjectThemeEventArgs) Handles c1ThemeController1.ObjectThemeApplied
        ScaleForm()
        If e.Object Is Me.c1Label1 Then
            Me.c1Label1.Font = New Font(Me.c1Label1.Font.FontFamily, 12)
        End If
    End Sub

    ''' <summary>
    ''' Scales the form And all child controls.        
    ''' </summary>
    ''' <remarks>
    ''' We couldn't use Form.AutoScaleMode = Font, since we may create this form in run-time and
    ''' the theme Is set in the InitializeComponent method And may contain a different font size.
    ''' In this case auto scaling may Not work correctly in run-time. So we should scale manually.
    ''' </remarks>
    Private Sub ScaleForm()
        Dim fontSize = Font.Size
        If fontSize! = _defaultFontSize Then
            Dim factor = fontSize / _defaultFontSize
            Scale(New SizeF(factor, factor))
            _defaultFontSize = fontSize
        End If
    End Sub

End Class