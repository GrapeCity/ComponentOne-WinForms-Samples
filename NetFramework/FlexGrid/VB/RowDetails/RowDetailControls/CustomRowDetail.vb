Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.FlexGrid
Imports C1.Win.C1Input

''' <summary>
''' Custom row detail class which shows label with notes about employee.
''' </summary>
Public Class CustomRowDetail
    Inherits C1Label
    Implements IC1FlexGridRowDetail

    ''' <summary>
    ''' Used to setup control before showing of it.
    ''' </summary>
    ''' <param name="parentGrid">FlexGrid which displays detail control.</param>
    ''' <param name="rowIndex">Index of parent detail row.</param>
    Private Sub Setup(ByVal parentGrid As C1FlexGrid, ByVal rowIndex As Integer) Implements IC1FlexGridRowDetail.Setup
        Dim bs = New BindingSource(TryCast(parentGrid.DataSource, DataSet), "Employees")
        bs.Position = parentGrid.Rows(rowIndex).DataIndex
        DataField = "Notes"
        DataSource = bs
    End Sub

    ''' <summary>
    ''' Used to update size of the control.
    ''' </summary>
    ''' <param name="parentGrid">FlexGrid which displays detail control.</param>
    ''' <param name="rowIndex">Index of parent detail row.</param>
    ''' <param name="proposedSize">The proposed size for the detail control.</param>
    Private Sub UpdateSize(ByVal parentGrid As C1FlexGrid, ByVal rowIndex As Integer, ByVal proposedSize As Size) Implements IC1FlexGridRowDetail.UpdateSize
        Dim srSz = parentGrid.ScrollableRectangle.Size
        Dim sz = TextRenderer.MeasureText(Text, Font, srSz, TextFormatFlags.WordBreak)
        sz.Width = Math.Max(sz.Width, srSz.Width)

        Size = sz
    End Sub

    ''' <summary>
    ''' Used to release resources of the control before the removing of it.
    ''' </summary>
    ''' <param name="parentGrid">FlexGrid which displays detail control.</param>
    ''' <param name="rowIndex">Index of parent detail row.</param>
    Private Sub Removing(ByVal parentGrid As C1FlexGrid, ByVal rowIndex As Integer) Implements IC1FlexGridRowDetail.Removing
        ' No resources to release
    End Sub
End Class