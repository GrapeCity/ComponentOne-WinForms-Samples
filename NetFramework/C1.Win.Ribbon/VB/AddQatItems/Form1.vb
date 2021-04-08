Imports C1.Framework
Imports C1.Win.Ribbon

Public Class Form1

    Public Sub New()

        InitializeComponent()

        ' Create a new instance of C1Ribbon and add it to the form.
        Dim c1Ribbon1 As New C1Ribbon()
        Me.Controls.Add(c1Ribbon1)

        Dim saveButton As New RibbonButton()
        saveButton.IconSet.Add(New C1BitmapIcon("Save", New Size(16, 16), Color.Transparent, "Preset_SmallImages", -1))
        c1Ribbon1.Qat.Items.Add(saveButton)
        Dim undoButton As New RibbonButton()
        undoButton.IconSet.Add(New C1BitmapIcon("Undo", New Size(16, 16), Color.Transparent, "Preset_SmallImages", -1))
        c1Ribbon1.Qat.Items.Add(undoButton)
        Dim redoButton As New RibbonButton()
        redoButton.IconSet.Add(New C1BitmapIcon("Redo", New Size(16, 16), Color.Transparent, "Preset_SmallImages", -1))
        c1Ribbon1.Qat.Items.Add(redoButton)

    End Sub

End Class
