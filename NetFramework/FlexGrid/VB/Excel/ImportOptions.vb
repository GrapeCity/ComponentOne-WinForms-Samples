Imports C1.Win.FlexGrid
Imports C1.Win.Ribbon
Imports C1.Win.SuperTooltip
Imports System

Partial Public Class ImportOptions
    Inherits C1RibbonForm
    Private toolTip1 As C1SuperTooltip = New C1SuperTooltip()
    Private _flags As FileFlags = New FileFlags()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c1ThemeController1.SetTheme(toolTip1, "(default)")
        toolTip1.RoundedCorners = True
        toolTip1.SetToolTip(chkLoadAsTransposed, "Load transposed grid.")
        toolTip1.SetToolTip(chkVisibleOnly, "Load only visible rows and columns.")
        toolTip1.SetToolTip(chkLoadMergedRanges, "Load merged ranges when importing from Excel.")
        toolTip1.SetToolTip(chkNoFreezing, "Do not freeze rows and columns when importing from Excel.")
        toolTip1.SetToolTip(chkIncludeFixedCells, "Include fixed cells when loading the grid. ")
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
        If chkLoadAsTransposed.Checked Then
            _flags = _flags Or FileFlags.LoadAsTransposed
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
        If chkLoadMergedRanges.Checked Then
            _flags = _flags Or FileFlags.LoadMergedRanges
            none = False
        End If
        If none Then _flags = FileFlags.None
    End Sub
End Class
