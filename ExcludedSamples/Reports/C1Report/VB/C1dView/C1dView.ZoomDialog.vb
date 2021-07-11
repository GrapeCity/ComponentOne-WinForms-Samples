Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Preview

Public Class ZoomDialog

    Public Property PreviewPane As C1.Win.C1Preview.C1PreviewPane

    Private Property Updating As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ''
        AddHandler Me.numZoom.ValueChanged, _
            Sub(s, e)
                If (Not Updating) Then
                    PreviewPane.ZoomFactor = CType(numZoom.Value / 100D, Double)
                    UpdateFromPreview()
                End If
            End Sub

        AddHandler Me.numCols.ValueChanged, _
            Sub(s, e)
                If (Not Updating) Then
                    PreviewPane.ZoomMode = ZoomModeEnum.WholePage
                    PreviewPane.Cols = CType(numCols.Value, Integer)
                    UpdateFromPreview()
                End If
            End Sub

        AddHandler Me.numRows.ValueChanged, _
            Sub(s, e)
                If (Not Updating) Then
                    PreviewPane.ZoomMode = ZoomModeEnum.WholePage
                    PreviewPane.Continuous = False
                    PreviewPane.Rows = CType(numRows.Value, Integer)
                    UpdateFromPreview()
                End If
            End Sub

        AddHandler Me.chkFacing.CheckedChanged, _
            Sub(s, e)
                If (Not Updating) Then
                    PreviewPane.ZoomMode = ZoomModeEnum.WholePage
                    PreviewPane.PageLayout = If(Me.chkFacing.Checked, PageLayoutEnum.Facing, PageLayoutEnum.Normal)
                    UpdateFromPreview()
                End If
            End Sub

        AddHandler Me.chkContinuous.CheckedChanged, _
            Sub(s, e)
                If (Not Updating) Then
                    PreviewPane.Continuous = Me.chkContinuous.Checked
                    UpdateFromPreview()
                End If
            End Sub

        AddHandler Me.rbt100.CheckedChanged, _
            Sub(s, e)
                If (Not Updating AndAlso rbt100.Checked) Then
                    PreviewPane.ZoomMode = ZoomModeEnum.ActualSize
                    UpdateFromPreview()
                End If
            End Sub

        AddHandler Me.rbtFitWindow.CheckedChanged, _
            Sub(s, e)
                If (Not Updating AndAlso rbtFitWindow.Checked) Then
                    PreviewPane.ZoomMode = ZoomModeEnum.WholePage
                    UpdateFromPreview()
                End If
            End Sub

        AddHandler Me.rbtFitWidth.CheckedChanged, _
            Sub(s, e)
                If (Not Updating AndAlso rbtFitWidth.Checked) Then
                    PreviewPane.ZoomMode = ZoomModeEnum.PageWidth
                    UpdateFromPreview()
                End If
            End Sub

        AddHandler Me.rbtFitTextWidth.CheckedChanged, _
            Sub(s, e)
                If (Not Updating AndAlso rbtFitTextWidth.Checked) Then
                    PreviewPane.ZoomMode = ZoomModeEnum.TextWidth
                    UpdateFromPreview()
                End If
            End Sub

        AddHandler Me.btnOk.Click, _
            Sub(s, e)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End Sub

    End Sub

    Protected Overrides Sub OnShown(e As System.EventArgs)
        UpdateLimits()
        UpdateFromPreview()
        MyBase.OnShown(e)
    End Sub

    Private Sub UpdateLimits()
        If (PreviewPane Is Nothing OrElse Updating) Then
            Return
        End If
        Try
            Updating = True
            numZoom.Minimum = CType(Math.Round(PreviewPane.MinZoomFactor * 100), Integer)
            numZoom.Maximum = CType(Math.Round(PreviewPane.MaxZoomFactor * 100), Integer)
        Finally
            Updating = False
        End Try
    End Sub

    Private Sub UpdateFromPreview()
        If (PreviewPane Is Nothing OrElse Updating) Then
            Return
        End If
        Try
            Updating = True
            numZoom.Value = CType(Math.Round(PreviewPane.ZoomFactor * 100), Integer)
            numCols.Value = PreviewPane.Cols
            numRows.Value = PreviewPane.Rows
            chkFacing.Checked = PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Facing
            chkContinuous.Checked = PreviewPane.Continuous
            rbt100.Checked = PreviewPane.ZoomFactor = 1
            rbtFitWindow.Checked = PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
            rbtFitWidth.Checked = PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.PageWidth
            rbtFitTextWidth.Checked = PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.TextWidth
        Finally
            Updating = False
        End Try
    End Sub
End Class