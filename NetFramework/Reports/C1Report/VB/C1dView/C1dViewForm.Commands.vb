Imports System
Imports System.ComponentModel
Imports C1.C1Preview
Imports C1.C1Report
Imports C1.Win.C1Preview
Imports C1.Win.C1Ribbon
Imports C1.Win.C1Command

Partial Public Class C1dViewForm

#Region "Helper objects"
    ''' <summary>
    ''' Provides zoom scale with 100% in the middle:
    ''' </summary>
    Protected Property ZoomSliderScale As ZoomSliderScale
#End Region


    Protected Sub InitPreviewCommands()

        '' Hide the search tab in the left tab control (it is not used, and is here only for
        '' backwards compatibility - FindHelper and status bar search controls are used instead):
        Me.dtpSearch.TabVisible = False
        Me.ptspMain.Visible = False

        '' Ensure command holder uses ribbon's visual style:
        Dim vs As C1.Win.C1Command.VisualStyle
        If (System.Enum.TryParse(Of C1.Win.C1Command.VisualStyle)(Me.rbMain.VisualStyle.ToString(), True, vs)) Then
            Me._cmdHolder.VisualStyle = vs
        End If

        Me.ZoomSliderScale = New ZoomSliderScale( _
            PreviewPane.MinZoomFactor, PreviewPane.MaxZoomFactor, _
            CType(PreviewPane.MinZoomFactor * 100, Integer), CType(PreviewPane.MaxZoomFactor * 100, Integer))
        Me.rtbZoom.TickFrequency = ZoomSliderScale.SliderValue(1)

        Me.KeyPreview = True
        AddHandler Me.KeyDown, New KeyEventHandler(AddressOf C1RibbonPrintPreviewForm_KeyDown)

        Me.rbnProgress.Visible = False
        AddHandler Me.PreviewPane.LongOperation, New C1.C1Preview.LongOperationEventHandler(AddressOf PreviewPane_LongOperation)
        AddHandler Me.PreviewPane.PropertyChanged, New PropertyChangedEventHandler(AddressOf PreviewPane_PropertyChanged)

        '' connect toolbar buttons to commands:
        AddHandler Me.rbtnAbout.Click, Sub(s, e) Me.cmdAbout.PerformClick()
        AddHandler Me.rbtnOpen.Click, Sub(s, e) Me.cmdFileOpen.PerformClick()
        AddHandler Me.rbtnOpen2.Click, Sub(s, e) Me.cmdFileOpen.PerformClick()
        AddHandler Me.rbtnSave.Click, Sub(s, e) Me.cmdFileSave.PerformClick()
        AddHandler Me.rbtnSave2.Click, Sub(s, e) Me.cmdFileSave.PerformClick()
        AddHandler Me.rbtnClose2.Click, Sub(s, e) Me.cmdFileClose.PerformClick()
        AddHandler Me.rbtnNew2.Click, Sub(s, e) Me.cmdFileNew.PerformClick()
        AddHandler Me.rbtnExit.Click, Sub(s, e) Me.cmdExit.PerformClick()
        AddHandler Me.rbtnPrint.Click, Sub(s, e) Me.cmdPrint.PerformClick()
        AddHandler Me.rbtnPrint2.Click, Sub(s, e) Me.cmdPrint.PerformClick()
        AddHandler Me.rbtnRefresh.Click, Sub(s, e) Me.cmdRefresh.PerformClick()
        AddHandler Me.rbtnPageSetup.Click, Sub(s, e) Me.cmdPageSetup.PerformClick()
        AddHandler Me.rbtnPageSetup2.Click, Sub(s, e) Me.cmdPageSetup.PerformClick()
        AddHandler Me.rbtnPageLandscape.Click, Sub(s, e) Me.cmdPageLandscape.PerformClick()
        AddHandler Me.rbtnPagePortrait.Click, Sub(s, e) Me.cmdPagePortrait.PerformClick()
        AddHandler Me.rbtnZoom100.Click, Sub(s, e) Me.cmdZoom100.PerformClick()
        AddHandler Me.rbtnZoomFitPage.Click, Sub(s, e) cmdZoomFitPage.PerformClick()
        AddHandler Me.rbtnZoomFitWidth.Click, Sub(s, e) cmdZoomFitWidth.PerformClick()

        AddHandler Me.rbtnFirstPage.Click, Sub(s, e) Me.cmdGoFirst.PerformClick()
        AddHandler Me.rbtnLastPage.Click, Sub(s, e) Me.cmdGoLast.PerformClick()
        AddHandler Me.rbtnPreviousPage.Click, Sub(s, e) Me.cmdGoPrev.PerformClick()
        AddHandler Me.rbtnNextPage.Click, Sub(s, e) Me.cmdGoNext.PerformClick()

        AddHandler Me.rbtnHistoryBack.Click, Sub(s, e) Me.cmdHistoryPrev.PerformClick()
        AddHandler Me.rbtnHistoryNext.Click, Sub(s, e) Me.cmdHistoryNext.PerformClick()

        AddHandler Me.rbtnHandTool.Click, Sub(s, e) Me.cmdMouseModeHand.PerformClick()
        AddHandler Me.rbtnTextSelectTool.Click, Sub(s, e) Me.cmdMouseModeSelect.PerformClick()
        AddHandler Me.rbtnZoomInTool.Click, Sub(s, e) Me.cmdMouseModeZoomIn.PerformClick()
        AddHandler Me.rbtnZoomOutTool.Click, Sub(s, e) Me.cmdMouseModeZoomOut.PerformClick()

        AddHandler Me.rbtnViewSinglePage.Click, Sub(s, e) Me.cmdPageViewSingle.PerformClick()
        AddHandler Me.rbtnViewContinuous.Click, Sub(s, e) Me.cmdPageViewContinuous.PerformClick()
        AddHandler Me.rbtnViewPagesFacing.Click, Sub(s, e) Me.cmdPageViewTwoUp.PerformClick()
        AddHandler Me.rbtnViewPagesFacingContinuous.Click, Sub(s, e) Me.cmdPageViewTwoUpContinuous.PerformClick()

        AddHandler Me.rbtnFind.Click, Sub(s, e) Me.cmdFind.PerformClick()
        AddHandler Me.rbtnFindAgain.Click, Sub(s, e) Me.cmdFindNext.PerformClick()

        AddHandler Me.rgZoom.DialogLauncherClick, Sub(s, e) Me.cmdZoomDialog.PerformClick()
        AddHandler Me.rbtnZoom.Click, Sub(s, e) Me.cmdZoomDialog.PerformClick()

        '' commands:
#If C1DVIEW_APP Then
        AddHandler Me.cmdAbout.Click, Sub(s, e)
                                          Dim about = New AboutForm()
                                          about.ShowDialog(Me)
                                      End Sub
        '' AddHandler me.cmdHelp.Click , Sub(s, e) (new AboutForm()).ShowDialog(me)
#End If

        AddHandler Me.cmdFileOpen.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy
        AddHandler Me.cmdFileOpen.EnabledChanged, Sub(s, e) Me.rbtnOpen.Enabled = Me.rbtnOpen2.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdFileOpen.Click, _
            Sub(s, e)
                FileOpen(CType(s, C1Command))
                PreviewPane.Focus()
            End Sub

        AddHandler Me.cmdFileSave.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso PreviewPane.Document IsNot Nothing
        AddHandler Me.cmdFileSave.EnabledChanged, Sub(s, e) Me.rbtnSave.Enabled = Me.rbtnSave2.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdFileSave.Click, Sub(s, e) PreviewPane.FileSave()

        AddHandler Me.cmdFileClose.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso (s_openWindows.Count > 1 OrElse PreviewPane.Document IsNot Nothing)
        AddHandler Me.cmdFileClose.EnabledChanged, Sub(s, e) rbtnClose2.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdFileClose.Click, Sub(s, e) FileClose()

        AddHandler Me.cmdFileNew.CommandStateQuery, Sub(s, e) e.Enabled = True
        AddHandler Me.cmdFileNew.EnabledChanged, Sub(s, e) rbtnNew2.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdFileNew.Click, Sub(s, e) FileNew(Nothing)

        AddHandler Me.cmdExit.Click, Sub(s, e) FileExit()

        AddHandler Me.cmdPrint.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso (s_openWindows.Count > 1 OrElse PreviewPane.Document IsNot Nothing)
        AddHandler Me.cmdPrint.EnabledChanged, Sub(s, e) Me.rbtnPrint.Enabled = Me.rbtnPrint2.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdPrint.Click, Sub(s, e) PreviewPane.Print()

        AddHandler Me.cmdRefresh.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso PreviewPane.Document IsNot Nothing AndAlso PreviewPane.Reflowable
        AddHandler Me.cmdRefresh.EnabledChanged, Sub(s, e) Me.rbtnRefresh.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdRefresh.Click, Sub(s, e) PreviewPane.Reflow()

        AddHandler Me.cmdPageSetup.CommandStateQuery, _
            Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso PreviewPane.Document IsNot Nothing AndAlso PreviewPane.Reflowable AndAlso PreviewPane.CanSetPageSettings
        AddHandler Me.cmdPageSetup.EnabledChanged, Sub(s, e) Me.rbtnPageSetup.Enabled = Me.rbtnPageSetup2.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdPageSetup.Click, Sub(s, e) PreviewPane.PageSetup()

        AddHandler Me.cmdPageLandscape.CommandStateQuery, _
            Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso PreviewPane.Document IsNot Nothing AndAlso PreviewPane.Reflowable AndAlso PreviewPane.CanSetPageSettings
        AddHandler Me.cmdPageLandscape.EnabledChanged, Sub(s, e) Me.rbtnPageLandscape.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdPageLandscape.PressedChanged, Sub(s, e) Me.rbtnPageLandscape.Pressed = CType(s, C1Command).Pressed
        AddHandler Me.cmdPageLandscape.Click, Sub(s, e) SetPageOrientation(True)

        AddHandler Me.cmdPagePortrait.CommandStateQuery, _
            Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso PreviewPane.Document IsNot Nothing AndAlso PreviewPane.Reflowable AndAlso PreviewPane.CanSetPageSettings
        AddHandler Me.cmdPagePortrait.EnabledChanged, Sub(s, e) Me.rbtnPagePortrait.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdPagePortrait.PressedChanged, Sub(s, e) Me.rbtnPagePortrait.Pressed = CType(s, C1Command).Pressed
        AddHandler Me.cmdPagePortrait.Click, Sub(s, e) SetPageOrientation(False)

        AddHandler Me.cmdZoom100.CommandStateQuery, Sub(s, e) e.Enabled = Document IsNot Nothing AndAlso Not PreviewPane.Busy
        AddHandler Me.cmdZoom100.EnabledChanged, Sub(s, e) Me.rbtnZoom100.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdZoom100.Click, Sub(s, e)
                                            PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Normal
                                            PreviewPane.ZoomMode = ZoomModeEnum.ActualSize
                                        End Sub

        AddHandler Me.cmdZoomFitPage.CommandStateQuery, Sub(s, e) e.Enabled = Document IsNot Nothing AndAlso Not PreviewPane.Busy
        AddHandler Me.cmdZoomFitPage.EnabledChanged, Sub(s, e) Me.rbtnZoomFitPage.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdZoomFitPage.Click, Sub(s, e) PreviewPane.ZoomMode = ZoomModeEnum.WholePage

        AddHandler Me.cmdZoomFitWidth.CommandStateQuery, Sub(s, e) e.Enabled = Document IsNot Nothing AndAlso Not PreviewPane.Busy
        AddHandler Me.cmdZoomFitWidth.EnabledChanged, Sub(s, e) Me.rbtnZoomFitWidth.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdZoomFitWidth.Click, Sub(s, e) PreviewPane.ZoomMode = ZoomModeEnum.PageWidth

        AddHandler Me.cmdZoomIn.Click, Sub(s, e) PreviewPane.DoZoomIn()
        AddHandler Me.cmdZoomIn.CommandStateQuery, Sub(s, e) e.Enabled = Math.Round(PreviewPane.ZoomFactor, 2) < PreviewPane.MaxZoomFactor
        '' me.cmdZoomIn.EnabledChanged , Sub(s, e) rbtnZoomIn.Enabled = cmdZoomIn.Enabled

        AddHandler Me.cmdZoomOut.Click, Sub(s, e) PreviewPane.DoZoomOut()
        AddHandler Me.cmdZoomOut.CommandStateQuery, Sub(s, e) e.Enabled = Math.Round(PreviewPane.ZoomFactor, 2) > PreviewPane.MinZoomFactor
        '' me.cmdZoomOut.EnabledChanged , Sub(s, e) rbtnZoomOut.Enabled = cmdZoomOut.Enabled

        AddHandler Me.cmdGoFirst.CommandStateQuery, Sub(s, e) e.Enabled = PreviewPane.StartPageIdx > 0
        AddHandler Me.cmdGoFirst.EnabledChanged, Sub(s, e) Me.rbtnFirstPage.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdGoFirst.Click, Sub(s, e) PreviewPane.StartPageIdx = 0

        AddHandler Me.cmdGoLast.CommandStateQuery, Sub(s, e) e.Enabled = PreviewPane.StartPageIdx < PreviewPane.Pages.Count - 1
        AddHandler Me.cmdGoLast.EnabledChanged, Sub(s, e) Me.rbtnLastPage.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdGoLast.Click, Sub(s, e) PreviewPane.StartPageIdx = Integer.MaxValue

        AddHandler Me.cmdGoPrev.CommandStateQuery, Sub(s, e) e.Enabled = PreviewPane.StartPageIdx > 0
        AddHandler Me.cmdGoPrev.EnabledChanged, Sub(s, e) Me.rbtnPreviousPage.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdGoPrev.Click, Sub(s, e) PreviewPane.StartPageIdx -= 1

        AddHandler Me.cmdGoNext.CommandStateQuery, Sub(s, e) e.Enabled = PreviewPane.StartPageIdx < PreviewPane.Pages.Count - 1
        AddHandler Me.cmdGoNext.EnabledChanged, Sub(s, e) Me.rbtnNextPage.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdGoNext.Click, Sub(s, e) PreviewPane.StartPageIdx += 1

        AddHandler Me.cmdGoPageNo.CommandStateQuery, Sub(s, e) e.Enabled = PreviewPane.Pages.Count > 0
        AddHandler Me.cmdGoPageNo.EnabledChanged, Sub(s, e) rebPageNo.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdGoPageNo.Click, Sub(s, e) GoToPage()

        AddHandler Me.cmdHistoryPrev.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso PreviewPane.CurrentHistoryEntryIndex > 0
        AddHandler Me.cmdHistoryPrev.EnabledChanged, Sub(s, e) Me.rbtnHistoryBack.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdHistoryPrev.Click, Sub(s, e) PreviewPane.HistoryBack()

        AddHandler Me.cmdHistoryNext.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy AndAlso PreviewPane.CurrentHistoryEntryIndex < PreviewPane.ViewHistory.Count - 1
        AddHandler Me.cmdHistoryNext.EnabledChanged, Sub(s, e) Me.rbtnHistoryNext.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdHistoryNext.Click, Sub(s, e) PreviewPane.HistoryForward()

        AddHandler Me.cmdMouseModeHand.Click, Sub(s, e) PreviewPane.MouseMode = MouseModeEnum.Hand
        AddHandler Me.cmdMouseModeSelect.Click, Sub(s, e) PreviewPane.MouseMode = MouseModeEnum.Select
        AddHandler Me.cmdMouseModeZoomIn.Click, Sub(s, e) PreviewPane.MouseMode = MouseModeEnum.Zoom
        AddHandler Me.cmdMouseModeZoomOut.Click, Sub(s, e) PreviewPane.MouseMode = MouseModeEnum.ZoomOut

        AddHandler Me.cmdPageViewSingle.EnabledChanged, Sub(s, e) Me.rbtnViewSinglePage.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdPageViewSingle.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy
        AddHandler Me.cmdPageViewSingle.Click, Sub(s, e) pageView_Click(s, e)

        AddHandler Me.cmdPageViewContinuous.EnabledChanged, Sub(s, e) Me.rbtnViewContinuous.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdPageViewContinuous.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy
        AddHandler Me.cmdPageViewContinuous.Click, Sub(s, e) pageView_Click(s, e)

        AddHandler Me.cmdPageViewTwoUp.EnabledChanged, Sub(s, e) Me.rbtnViewPagesFacing.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdPageViewTwoUp.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy
        AddHandler Me.cmdPageViewTwoUp.Click, Sub(s, e) pageView_Click(s, e)

        AddHandler Me.cmdPageViewTwoUpContinuous.EnabledChanged, Sub(s, e) Me.rbtnViewPagesFacingContinuous.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdPageViewTwoUpContinuous.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy
        AddHandler Me.cmdPageViewTwoUpContinuous.Click, Sub(s, e) pageView_Click(s, e)

        AddHandler Me.cmdZoomDialog.EnabledChanged, Sub(s, e) Me.rbtnZoom.Enabled = CType(s, C1Command).Enabled
        AddHandler Me.cmdZoomDialog.CommandStateQuery, Sub(s, e) e.Enabled = Not PreviewPane.Busy
        AddHandler Me.cmdZoomDialog.Click, Sub(s, e) ShowZoomDialog()
    End Sub

    Protected Sub RefreshUI()
        PreviewPane_PropertyChanged(PreviewPane, New PropertyChangedEventArgs("_all_"))
    End Sub

    Protected Sub C1RibbonPrintPreviewForm_KeyDown(sender As Object, e As KeyEventArgs)
        If (Not PreviewPane.Focused) Then
            If (e.KeyCode = Keys.Escape AndAlso e.Modifiers = Keys.None) Then
                PreviewPane.Focus()
            ElseIf (e.KeyCode = Keys.Add AndAlso e.Modifiers = Keys.Control) Then
                cmdZoomIn.PerformClick()
            ElseIf (e.KeyCode = Keys.Subtract AndAlso e.Modifiers = Keys.Control) Then
                cmdZoomOut.PerformClick()
            End If
        End If
    End Sub

    Protected Sub PreviewPane_PropertyChanged(sender As Object, e As PropertyChangedEventArgs)
        Dim updPageSettings As Action = _
            Sub()
                Dim ps = PreviewPane.PageSettings
                cmdPageLandscape.Pressed = ps IsNot Nothing AndAlso PreviewPane.PageSettings.Landscape
                cmdPagePortrait.Pressed = ps IsNot Nothing AndAlso Not PreviewPane.PageSettings.Landscape
            End Sub
        Dim updZoomFactor As Action = _
            Sub()
                Dim zf = CType(PreviewPane.ZoomFactor * 100, Integer)
                rbtnZoom100.Pressed = zf = 100
                rbtnZoomFitWidth.Pressed = PreviewPane.ZoomMode = ZoomModeEnum.PageWidth
                rbtnZoomFitPage.Pressed = PreviewPane.ZoomMode = ZoomModeEnum.WholePage
                ''
                rtbZoom.Minimum = CType(PreviewPane.MinZoomFactor * 100, Integer)
                rtbZoom.Maximum = CType(PreviewPane.MaxZoomFactor * 100, Integer)
                rtbZoom.Value = ZoomSliderScale.SliderValue(PreviewPane.ZoomFactor)
                rbtnZoom.Text = String.Format("{0}%", zf)
            End Sub
        Dim updView As Action = _
            Sub()
                '' bottom rigth buttons:
                rbtnViewSinglePage.Pressed = Not PreviewPane.Continuous AndAlso PreviewPane.Cols = 1 AndAlso PreviewPane.Rows = 1
                rbtnViewContinuous.Pressed = PreviewPane.Continuous AndAlso PreviewPane.Cols = 1 AndAlso PreviewPane.Rows = 1
                rbtnViewPagesFacing.Pressed = Not PreviewPane.Continuous AndAlso PreviewPane.Cols = 2 AndAlso PreviewPane.Rows = 1
                rbtnViewPagesFacingContinuous.Pressed = PreviewPane.Continuous AndAlso PreviewPane.Cols = 2 AndAlso PreviewPane.Rows = 1
            End Sub
        Dim updPageNo As Action = _
            Sub()
                rebPageNo.Text = (PreviewPane.StartPageIdx + 1).ToString()
                rlblPageCount.Text = String.Format("of {0}", PreviewPane.Pages.Count)
            End Sub
        Dim updMouseTools As Action = _
            Sub()
                rbtnHandTool.Pressed = PreviewPane.MouseMode = MouseModeEnum.Hand
                rbtnTextSelectTool.Pressed = PreviewPane.MouseMode = MouseModeEnum.Select
                rbtnZoomInTool.Pressed = PreviewPane.MouseMode = MouseModeEnum.Zoom
                rbtnZoomOutTool.Pressed = PreviewPane.MouseMode = MouseModeEnum.ZoomOut
            End Sub

        Select Case e.PropertyName
            Case "_all_"
                updPageSettings()
                updZoomFactor()
                updPageNo()
                updMouseTools()
                updView()
            Case "Busy"
                Me.rbnProgress.Visible = PreviewPane.Busy
            Case "StatusText"
                Me.rlblStatusText.Text = PreviewPane.StatusText
            Case "Document"
                updPageSettings()
                updZoomFactor()
                updPageNo()
            Case "PageSettings"
                '' Getting PreviewPane.PageSettings is a very heavy operation, so we only do it if necessary:
                updPageSettings()
            Case "ZoomFactor", "MinZoomFactor", "MaxZoomFactor"
                updZoomFactor()
            Case "Rows", "Cols", "PageLayout", "Continuous"
                updView()
            Case "StartPageIdx"
                updPageNo()
            Case "MouseMode"
                updMouseTools()
        End Select
    End Sub

    Protected Sub PreviewPane_LongOperation(sender As Object, e As C1.C1Preview.LongOperationEventArgs)
        Me.rbnProgress.Value = CType(e.Complete * 100D, Integer)
        For Each cmd As C1Command In _cmdHolder.Commands
            cmd.StateQuery()
        Next
        Application.DoEvents()
    End Sub

    Protected Sub SetPageOrientation(landscape As Boolean)
        Dim ps = PreviewPane.PageSettings
        If ps IsNot Nothing Then
            ps.Landscape = landscape
            PreviewPane.PageSettings = ps
        End If
    End Sub

    Protected Sub ShowZoomDialog()
        Using zd = New ZoomDialog()
            zd.PreviewPane = Me.PreviewPane
            zd.ShowDialog()
        End Using
    End Sub

    Protected Sub GoToPage()
        Dim v As Integer
        If (Integer.TryParse(rebPageNo.Text, v)) Then
            PreviewPane.StartPageIdx = v - 1
        Else
            rebPageNo.Text = (PreviewPane.StartPageIdx + 1).ToString()
        End If
    End Sub

    '' page view buttons on bottom left:
    Protected Sub pageView_Click(sender As Object, e As EventArgs)
        Using (New C1PreviewPane.LayoutSection(_pview, HistorySavedActionsEnum.PageLayout))
            If (sender Is cmdPageViewSingle) Then
                PreviewPane.Continuous = False
                PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Normal
            ElseIf (sender Is cmdPageViewContinuous) Then
                PreviewPane.Continuous = True
                PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Normal
            ElseIf (sender Is cmdPageViewTwoUp) Then
                PreviewPane.Continuous = False
                PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Custom
                PreviewPane.Rows = 1
                PreviewPane.Cols = 2
            ElseIf (sender Is cmdPageViewTwoUpContinuous) Then
                PreviewPane.Continuous = True
                PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Custom
                PreviewPane.Rows = 1
                PreviewPane.Cols = 2
            End If
        End Using
    End Sub

    Protected Sub RibbonClick(item As RibbonItem)
        If (TryCast(item.Parent, RibbonItem) Is rbtnHistoryBack OrElse TryCast(item.Parent, RibbonItem) Is rbtnHistoryNext) Then
            Dim vhi = CType(item.Tag, ViewHistoryItem)
            If (vhi IsNot Nothing) Then
                _pview.CurrentHistoryEntry = vhi
            End If
        End If
    End Sub

    Protected Sub RibbonChangeCommitted(item As RibbonItem)
        If (item Is rebPageNo) Then
            cmdGoPageNo.PerformClick()
        End If
    End Sub

    Protected Sub rbnMain_RibbonEvent(sender As Object, e As RibbonEventArgs) Handles rbMain.RibbonEvent
        Select Case e.EventType
            Case RibbonEventType.Click
                RibbonClick(CType(e.Item, RibbonItem))
            Case RibbonEventType.ChangeCommitted
                RibbonChangeCommitted(CType(e.Item, RibbonItem))
        End Select
    End Sub

    Protected Sub rtbZoom_Scroll(sender As Object, e As EventArgs) Handles rtbZoom.Scroll
        Dim zf = ZoomSliderScale.ZoomFactor(rtbZoom.Value)
        '' we want to be able to easily "zero in" on 100% zoom, hence this:
        If (zf > 0.97 AndAlso zf < 1.04) Then
            zf = 1
        ElseIf ((zf < 1 AndAlso PreviewPane.ZoomFactor > 1) OrElse (zf > 1 AndAlso PreviewPane.ZoomFactor < 1)) Then
            zf = 1
        End If
        PreviewPane.ZoomFactor = zf
    End Sub

    Protected Sub rbtnHistoryBack_DropDown(sender As Object, e As EventArgs) Handles rbtnHistoryBack.DropDown
        rbtnHistoryBack.Items.Clear()
        Dim j As Integer = 0
        For i As Integer = _pview.CurrentHistoryEntryIndex - 1 To 0 Step -1
            Dim vhi = _pview.ViewHistory(i)
            Dim btn = New RibbonButton(vhi.Caption)
            btn.Tag = vhi
            rbtnHistoryBack.Items.Add(btn)
            j += 1
            If j >= 10 Then
                Exit For
            End If
        Next
    End Sub

    Protected Sub rbtnHistoryNext_DropDown(sender As Object, e As EventArgs) Handles rbtnHistoryNext.DropDown
        rbtnHistoryNext.Items.Clear()
        Dim j As Integer = 0
        For i As Integer = _pview.CurrentHistoryEntryIndex + 1 To _pview.ViewHistory.Count - 1
            Dim vhi = _pview.ViewHistory(i)
            Dim btn = New RibbonButton(vhi.Caption)
            btn.Tag = vhi
            rbtnHistoryNext.Items.Add(btn)
            j += 1
            If j >= 10 Then
                Exit For
            End If
        Next
    End Sub

End Class

