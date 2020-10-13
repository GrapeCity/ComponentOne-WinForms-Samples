Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports C1.Win.C1FlexGrid


Public Class FlexFreezeBottom

    ' FlexFreezeBottom
    ' 
    ' This is a control (derived from Panel) that contains a FlexGrid. The
    ' contained FlexGrid is positioned with a negative Y coordinate within 
    ' the panel so that the fixed rows are not visible.
    ' 
    ' The contained grid is also sized and scrolled via code so that the 
    ' bottom 'n' rows are visible.
    ' 
    ' The contained grid is bound to a main FlexGrid and therefore shares 
    ' the underlying grid model (data, layout, styles, selection, etc).
    ' 
    ' The whole control (panel and contained grid) is attached to the main 
    ' FlexGrid and positioned at its bottom. This way, the control always
    ' shows the bottom 'n' rows of the main grid.

    Friend Class FlexFreezeBottom
        Inherits Panel
        Dim WithEvents _frz As C1.Win.C1FlexGrid.C1FlexGrid
        Dim WithEvents _main As C1.Win.C1FlexGrid.C1FlexGrid
        Dim _rows As Integer

        Friend Sub New(ByVal main As C1.Win.C1FlexGrid.C1FlexGrid, ByVal rows As Integer)
            MyBase.New()

            ' save info we'll need later
            _main = main
            _rows = rows

            ' create child grid with frozen bottom rows
            _frz = New C1FlexGrid()
            _frz.ScrollBars = ScrollBars.None
            _frz.BorderStyle = Util.BaseControls.BorderStyleEnum.None
            _frz.DrawMode = DrawModeEnum.OwnerDraw
            '_frz.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(_frz_OwnerDrawCell);
            '_frz.SetupEditor   += new C1.Win.C1FlexGrid.RowColEventHandler(_frz_SetupEditor);
            '_frz.AfterScroll   += new C1.Win.C1FlexGrid.RangeEventHandler(_frz_AfterScroll);
            '_frz.GridChanged   += new C1.Win.C1FlexGrid.GridChangedEventHandler(_main_GridChanged);
            Controls.Add(_frz)

            ' bind frozen grid to main grid(share data, layout, styles,selection)
            _frz.DataSource = main

            ' add this to the main grid
            main.Controls.Add(Me)

            ' hook up the events we need to synchronize with the main grid
            'main.Resize      += new System.EventHandler(_main_Resize);
            'main.VisibleChanged += new System.EventHandler(_main_Resize);
            'main.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(_main_AfterScroll);
            'main.SelChange   += new System.EventHandler(_main_SelChange);
            'main.GridChanged += new C1.Win.C1FlexGrid.GridChangedEventHandler(_main_GridChanged);

            'initialize 
            AdjustLayout()

        End Sub

        Friend Sub AdjustLayout()

            ' get index of the bottom (frozen) rows
            Dim rows As RowCollection = _main.Rows
            Dim r2 As Integer = rows.Count - 1
            Dim r1 As Integer = r2 - _rows + 1
            If r1 <= rows.Fixed Then r1 = rows.Fixed

            ' hide control if the main grid is big enough
            Visible = (r1 <= r2)
            If Not Visible Then Return

            ' set control size and location
            Dim rc As Rectangle = _main.ClientRectangle
            If rows(r2).Bottom <= rc.Bottom Then
                Visible = False
                Return
            End If

            Dim hei As Integer = rows(r2).Bottom - rows(r1).Top + 1
            rc.Y = rc.Bottom - hei
            rc.Height = hei
            Bounds = rc

            ' adjust child grid to hide fixed rows
            rc = ClientRectangle
            hei = rows(rows.Fixed + rows.Frozen).Top
            rc.Y -= hei
            rc.Height += hei
            _frz.Bounds = rc

            ' synchronize scroll position
            SynchScrollPosition(False)

        End Sub

        Friend Sub SynchScrollPosition(ByVal synchMain As Boolean)
            Dim pos As Point

            ' optionally synchronize X scroll position on the main grid
            If synchMain Then
                pos = _frz.ScrollPosition
                pos.Y = _main.ScrollPosition.Y
                _main.ScrollPosition = pos
            End If

            ' synchronize X scroll position of the frozen grid with main
            pos = _main.ScrollPosition
            pos.Y = -64000
            _frz.ScrollPosition = pos

            ' update everything right away
            _main.Update()
            _frz.Update()

        End Sub

        ' make normal and scrollable areas look different
        ' (when painting and when editing)
        Private Sub _frz_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles _frz.OwnerDrawCell
            If e.Style.BackColor.Equals(_frz.Styles.Normal.BackColor) Then
                e.Graphics.FillRectangle(Brushes.Beige, e.Bounds)
                e.DrawCell(DrawCellFlags.Border Or DrawCellFlags.Content)
            End If
        End Sub

        Private Sub _frz_SetupEditor(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles _frz.SetupEditor
            _frz.BackColor = Color.Beige
        End Sub

        ' adjust layout after resizing the main grid (our container)
        Private Sub _main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles _main.Resize, _main.VisibleChanged
            AdjustLayout()
        End Sub

        ' synchronize scrolling
        Private Sub _main_AfterScroll(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles _main.AfterScroll
            SynchScrollPosition(False)
        End Sub

        Private Sub _frz_AfterScroll(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles _frz.AfterScroll

            ' if the frozen grid has the focus and the user selects non-frozen
            ' cells, scroll main grid up.
            If _frz.Focused Then
                Dim row As Integer = Math.Min(_frz.Row, _frz.RowSel)
                Dim bot As Integer = _main.Rows(row).Bottom + _main.ScrollPosition.Y
                If bot > Top Then
                    ' unless this is a mouse selection, give focus to main grid
                    If Not _frz.Capture Then _main.Focus()
                    _main.TopRow = _main.Row
                End If
            End If
            SynchScrollPosition(True)

        End Sub

        ' scroll while selecting 
        ' if the user extends the selection down on the main grid, scroll it down
        Private Sub _main_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles _main.SelChange

            ' only when the main grid has the focus!
            If Not _main.Focused Then Return

            ' calculate selection bottom (accounting for scrolling)
            Dim row As Integer = Math.Max(_main.Row, _main.RowSel)
            Dim bot As Integer = _main.Rows(row).Bottom + _main.ScrollPosition.Y

            'try scrolling if past the bottom of the frozen area
            If bot > Top Then _main.TopRow += 1

        End Sub

        ' adjust layout after massive changes (resize rows/cols, sort,etc)
        Private Sub _main_GridChanged(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.GridChangedEventArgs) Handles _main.GridChanged, _frz.GridChanged

            Select Case e.GridChangedType
                Case GridChangedTypeEnum.GridChanged, GridChangedTypeEnum.LayoutChanged
                    AdjustLayout()
            End Select
        End Sub
    End Class
End Class
