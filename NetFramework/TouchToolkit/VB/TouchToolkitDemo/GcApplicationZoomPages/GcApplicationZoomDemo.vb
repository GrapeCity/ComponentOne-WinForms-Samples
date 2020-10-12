Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit

Namespace C1ApplicationZoomPages
    Partial Public Class C1ApplicationZoomDemo
        Inherits DemoBase
        Public Sub New()
            InitializeComponent()

            Me.Description = "User can add a component to MainForm (startup form),  then it add touch-zoom capability to all Forms. " & "It will be a simplest way for most Windows Forms Application."

            InitializeDemo()
            Me._gcZoom.ZoomPolicies.Add(New MyImageButtonZoomPolicy())
            AddHandler Me._gcZoom.C1ZoomAttaching, AddressOf gcApplicationZoom1_C1ZoomAttaching
        End Sub

        Private Sub gcApplicationZoom1_C1ZoomAttaching(sender As Object, e As C1ZoomAttachingEventArgs)
            If (TypeOf e.Form Is AppZoom_Main) OrElse (TypeOf e.Form Is AppZoom_Child1) OrElse (TypeOf e.Form Is AppZoom_Child2) OrElse (TypeOf e.Form Is AppZoom_Child3) Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End Sub

        Private _gcZoom As New C1ApplicationZoom()

        Private Sub InitializeDemo()
            Me.Title = "C1Zoom Basic (Zoom and Scroll)"
            Me.Description = "This page is used to try basic features of C1Zoom. " & vbCr & vbLf & "  - Click the Show Form Button to show a test application. And test the Gestrue zoom/scroll." & vbCr & vbLf & "  - Try to change the settings to knows how to config the C1ApplicationZoom."

            AddEnumItemsToComboBox(ZoomPreviewModeComboBox, GetType(ZoomPreviewMode))
            AddEnumItemsToComboBox(scrollIndicatorCombo, GetType(ScrollIndicatorMode))
            formatComboBox.Items.Add("Zooming {Percentage}%")
            formatComboBox.Items.Add("Zooming x{ZoomFactor}")

            scrollIndicatorCombo.SelectedItem = _gcZoom.ScrollIndicatorMode
            ZoomPreviewModeComboBox.SelectedItem = _gcZoom.ZoomPreviewMode
            formatComboBox.SelectedIndex = 0
            displayLabel.Font = _gcZoom.AlternativeContentSettings.Font
            displayLabel.ForeColor = _gcZoom.AlternativeContentSettings.ForeColor
            HorizontalRailEnableCheckBox.DataBindings.Add("Checked", _gcZoom, "IsHorizontalRailEnabled")
            VerticalRailEnableCheckBox.DataBindings.Add("Checked", _gcZoom, "IsVerticalRailEnabled")
            AllowDoubleTapZoomCheckBox.DataBindings.Add("Checked", _gcZoom, "AllowDoubleTapZoom")
            KeepAspectRatioCheckBox.DataBindings.Add("Checked", _gcZoom, "KeepAspectRatio")
            scrollIndicatorCombo.DataBindings.Add("SelectedItem", _gcZoom, "ScrollIndicatorMode")
            boundaryFeedbackUI1.DataBindings.Add("BoundaryFeedbackMode", _gcZoom, "BoundaryFeedbackMode")

            AddHandler ZoomPreviewModeComboBox.SelectedIndexChanged, AddressOf ZoomPreviewModeComboBox_SelectedIndexChanged
            AddHandler formatComboBox.TextChanged, AddressOf formatComboBox_TextChanged
            AddHandler FontButton.Click, AddressOf FontButton_Click
            AddHandler ForeColorButton.Click, AddressOf ForeColorButton_Click
            AddHandler formButton.Click, AddressOf formButton_Click
            AddHandler _gcZoom.C1ZoomAttached, AddressOf _gcZoom_C1ZoomAttached
            AddHandler boundaryFeedbackUI1.BoundaryFeedbackModeChanged, AddressOf boundaryFeedbackUI1_BoundaryFeedbackModeChanged
        End Sub

        Private Sub _gcZoom_C1ZoomAttached(sender As Object, e As C1ZoomAttachedEventArgs)
            If TypeOf e.Form Is AppZoom_Child3 Then
                e.GcZoom.InnerPanelLayoutMode = InnerPanelLayoutMode.MiddleCenter
                e.GcZoom.AllowResizeByZoom = True
            End If
        End Sub

        Private Sub formButton_Click(sender As Object, e As EventArgs)
            Using form As New AppZoom_Main()
                form.ShowDialog(Me)
            End Using
        End Sub

        Private Sub ZoomPreviewModeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
            _gcZoom.ZoomPreviewMode = DirectCast(ZoomPreviewModeComboBox.SelectedItem, ZoomPreviewMode)

            Me.alternativeContentGroup.Visible = False
            Me.NoPreivewInfoPanel.Visible = False
            Me.boundaryFeedbackUI1.Visible = False
            Select Case _gcZoom.ZoomPreviewMode
                Case ZoomPreviewMode.Bitmap
                    Me.boundaryFeedbackUI1.Visible = True
                    Exit Select
                Case ZoomPreviewMode.NoPreview
                    Me.NoPreivewInfoPanel.Visible = True
                    Exit Select
                Case ZoomPreviewMode.AlternativeContent
                    Me.alternativeContentGroup.Visible = True
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End Sub

        Private Sub formatComboBox_TextChanged(sender As Object, e As EventArgs)
            If formatComboBox.Text IsNot Nothing Then
                _gcZoom.AlternativeContentSettings.Format = formatComboBox.Text
                displayLabel.Text = formatComboBox.Text.Replace("{Percentage}", "100").Replace("{ZoomFactor}", "1.00")


            End If
        End Sub

        Private Sub ForeColorButton_Click(sender As Object, e As EventArgs)
            Dim dialog As New ColorDialog()
            If DialogResult.OK = dialog.ShowDialog() Then
                _gcZoom.AlternativeContentSettings.ForeColor = dialog.Color
                displayLabel.ForeColor = dialog.Color
            End If
        End Sub

        Private Sub FontButton_Click(sender As Object, e As EventArgs)
            Dim dialog As New FontDialog()
            If DialogResult.OK = dialog.ShowDialog() Then
                _gcZoom.AlternativeContentSettings.Font = dialog.Font
                displayLabel.Font = dialog.Font
            End If
        End Sub

        Private Sub boundaryFeedbackUI1_BoundaryFeedbackModeChanged(sender As Object, e As EventArgs)
            _gcZoom.BoundaryFeedbackMode = boundaryFeedbackUI1.BoundaryFeedbackMode
        End Sub

        Private Sub AddEnumItemsToComboBox(comboBox As ComboBox, enumType As Type)
            Dim enumArray As Array = [Enum].GetValues(enumType)
            For i As Integer = 0 To enumArray.Length - 1
                comboBox.Items.Add(enumArray.GetValue(i))
            Next
        End Sub
    End Class
End Namespace