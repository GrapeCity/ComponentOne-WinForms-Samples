Imports C1.Win.C1FlexGrid
Imports C1.Win.C1InputPanel

Public Class DerivedRowDetail

    ''' <summary>
    ''' Used to setup control before showing of it.
    ''' </summary>
    ''' <param name="parentGrid">FlexGrid which displays detail control.</param>
    ''' <param name="rowIndex">Index of parent detail row.</param>
    Public Overrides Sub Setup(ByVal parentGrid As C1FlexGrid, ByVal rowIndex As Integer)
        MyBase.Setup(parentGrid, rowIndex)

        Dim items = C1InputPanel.Items

        ' remove "EmployeeID" label and input component
        items.RemoveAt(0)
        items.RemoveAt(0)

        ' remove "TitleOfCourtesy" label and input component
        items.RemoveAt(6)
        items.RemoveAt(6)

        ' remove "Photo" label and input component
        items.RemoveAt(24)
        items.RemoveAt(24)

        ' remove "Notes" label and input component
        items.RemoveAt(24)
        items.RemoveAt(24)

        ' remove "ReportsTo" label and input component
        items.RemoveAt(24)
        items.RemoveAt(24)

        ' add new InputImage item and place it at the zero index
        Dim photoInputImage = New InputImage()
        photoInputImage.DataField = "Photo"
        photoInputImage.DataSource = C1InputPanel.DataSource
        photoInputImage.Width = 150
        photoInputImage.Height = 150
        photoInputImage.Break = BreakType.Column
        items.Insert(0, photoInputImage)
    End Sub

End Class
