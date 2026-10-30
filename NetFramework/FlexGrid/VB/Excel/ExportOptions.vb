Imports C1.Win.FlexGrid
Imports C1.Win.Ribbon
Imports C1.Win.SuperTooltip
Imports System

Partial Public Class ExportOptions
    Inherits C1RibbonForm
    Private toolTip1 As C1SuperTooltip = New C1SuperTooltip()
    Private _flags As FileFlags = New FileFlags()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c1ThemeController1.SetTheme(toolTip1, "(default)")
        toolTip1.RoundedCorners = True
        toolTip1.SetToolTip(chkExcludeFooters, "Do not save footer rows when exporting.")
        toolTip1.SetToolTip(chkVisibleOnly, "Save only visible rows and columns.")
        toolTip1.SetToolTip(chkSelectedRowsOnly, "Save only selected rows.")
        toolTip1.SetToolTip(chkSaveMergedRanges, "Save merged ranges when exporting to Excel.")
        toolTip1.SetToolTip(chkOpenXml, "Save file in OpenXml (Office 2007) format. ")
        toolTip1.SetToolTip(chkNoFreezing, "Do not freeze rows and columns when exporting to Excel.")
        toolTip1.SetToolTip(chkIncludeFixedCells, "Include fixed cells when saving the grid. ")
        toolTip1.SetToolTip(chkAsDisplayed, "Save values as displayed (including formatting and mapping where available). ")
    End Sub

    Public Property Flags As FileFlags
        Get
            Return _flags
        End Get
        Set(value As FileFlags)
            _flags = value
        End Set
    End Property

    Private Sub btnOK_Click(sender As Object, e As EventArgs)
        Dim none = True
        If chkAsDisplayed.Checked Then
            _flags = _flags Or FileFlags.AsDisplayed
            none = False
        End If
        If chkIncludeFixedCells.Checked Then
            _flags = _flags Or FileFlags.IncludeFixedCells
            none = False
        End If
        If chkNoFreezing.Checked Then
            _flags = _flags Or FileFlags.NoFreezing
            none = False
        End If
        If chkOpenXml.Checked Then
            _flags = _flags Or FileFlags.OpenXml
            none = False
        End If
        If chkSaveMergedRanges.Checked Then
            _flags = _flags Or FileFlags.SaveMergedRanges
            none = False
        End If
        If chkSelectedRowsOnly.Checked Then
            _flags = _flags Or FileFlags.SelectedRowsOnly
            none = False
        End If
        If chkVisibleOnly.Checked Then
            _flags = _flags Or FileFlags.VisibleOnly
            none = False
        End If
        If chkExcludeFooters.Checked Then
            _flags = _flags Or FileFlags.ExcludeFooters
            none = False
        End If
        If none Then _flags = FileFlags.None
    End Sub
End Class
