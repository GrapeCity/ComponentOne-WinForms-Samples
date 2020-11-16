Imports C1.Win.Ribbon

Public Class Form1

    Public Sub New()

        InitializeComponent()

        ' Create a new instance of C1Ribbon and add it to the form.
        Dim c1Ribbon1 As New C1Ribbon()
        Me.Controls.Add(c1Ribbon1)

        c1Ribbon1.Qat.Items.Add(New RibbonButton(My.Resources.Save))
        c1Ribbon1.Qat.Items.Add(New RibbonButton(My.Resources.Undo))
        c1Ribbon1.Qat.Items.Add(New RibbonButton(My.Resources.Redo))

    End Sub

End Class
