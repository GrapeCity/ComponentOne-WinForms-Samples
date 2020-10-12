Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit
Imports ClickOnceDemo.C1ZoomPages.Help_Forms

Namespace C1ZoomPanelPages
    Partial Public Class C1ZoomPanelDemo
        Inherits DemoBase
        Public Sub New()
            InitializeComponent()
            InitializeDemo()
        End Sub

        Private Sub InitializeDemo()
            Me.Title = "C1ZoomPanel Basic (Zoom and Scroll)"
            Me.Description = "This page is used to try basic features of C1ZoomPanel. " & vbCr & vbLf & "  - Click the Show Form Button to show a test form. And test the Gestrue zoom/scroll." & vbCr & vbLf & "  - Try to change the settings to knows how to config the C1ZoomPanel."

            AddEnumItemsToComboBox(ZoomPreviewModeComboBox, GetType(ZoomPreviewMode))
            ZoomPreviewModeComboBox.SelectedItem = ZoomPreviewMode.Bitmap
            AddHandler ZoomPreviewModeComboBox.SelectedIndexChanged, AddressOf ZoomPreviewModeComboBox_SelectedIndexChanged

            formatComboBox.Items.Add("Zooming {Percentage}%")
            formatComboBox.Items.Add("Zooming x{ZoomFactor}")
            formatComboBox.SelectedIndex = 0
            AddHandler formatComboBox.TextChanged, AddressOf formatComboBox_TextChanged

            AddHandler FontButton.Click, AddressOf FontButton_Click
            AddHandler ForeColorButton.Click, AddressOf ForeColorButton_Click

            displayLabel.Font = Me.Font
            displayLabel.ForeColor = Me.ForeColor

            boundaryFeedbackUI1.BoundaryFeedbackMode = BoundaryFeedbackMode.Split

            AddEnumItemsToComboBox(scrollIndicatorCombo, GetType(ScrollIndicatorMode))
            scrollIndicatorCombo.SelectedItem = ScrollIndicatorMode.ScrollIndicator

            VerticalRailEnableCheckBox.Checked = True
            HorizontalRailEnableCheckBox.Checked = True
            AllowDoubleTapZoomCheckBox.Checked = False

            AddHandler formButton.Click, AddressOf formButton_Click
        End Sub

        Private Sub formatComboBox_TextChanged(sender As Object, e As EventArgs)
            If formatComboBox.Text IsNot Nothing Then
                displayLabel.Text = formatComboBox.Text.Replace("{Percentage}", "100").Replace("{ZoomFactor}", "1.00")


            End If
        End Sub

        Private Sub formButton_Click(sender As Object, e As EventArgs)
            Using form As New Help()
                FillValues(form.C1ZoomPanel)
                ' The _gcZoom will auto detach when the Form dispose.
                '_gcZoom.SetEnabled(form, false);
                form.ShowDialog(Me)
            End Using
        End Sub

        Private Sub FillValues(gcZoomPanel As C1ZoomPanel)
            gcZoomPanel.ZoomPreviewMode = DirectCast(ZoomPreviewModeComboBox.SelectedItem, ZoomPreviewMode)
            gcZoomPanel.AlternativeContentSettings.Format = formatComboBox.Text
            gcZoomPanel.AlternativeContentSettings.ForeColor = displayLabel.ForeColor
            gcZoomPanel.AlternativeContentSettings.Font = displayLabel.Font

            gcZoomPanel.BoundaryFeedbackMode = boundaryFeedbackUI1.BoundaryFeedbackMode
            gcZoomPanel.ScrollIndicatorMode = DirectCast(scrollIndicatorCombo.SelectedItem, ScrollIndicatorMode)

            gcZoomPanel.IsVerticalRailEnabled = VerticalRailEnableCheckBox.Checked
            gcZoomPanel.IsHorizontalRailEnabled = HorizontalRailEnableCheckBox.Checked
            gcZoomPanel.AllowDoubleTapZoom = AllowDoubleTapZoomCheckBox.Checked
        End Sub

        Private Sub ForeColorButton_Click(sender As Object, e As EventArgs)
            Dim dialog As New ColorDialog()
            If DialogResult.OK = dialog.ShowDialog() Then
                displayLabel.ForeColor = dialog.Color
            End If
        End Sub

        Private Sub FontButton_Click(sender As Object, e As EventArgs)
            Dim dialog As New FontDialog()
            If DialogResult.OK = dialog.ShowDialog() Then

                displayLabel.Font = dialog.Font
            End If
        End Sub

        Private Sub ZoomPreviewModeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
            Me.alternativeContentGroup.Visible = False
            Me.NoPreivewInfoPanel.Visible = False
            Me.boundaryFeedbackUI1.Visible = False
            Select Case DirectCast(ZoomPreviewModeComboBox.SelectedItem, ZoomPreviewMode)
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

        Private Sub AddEnumItemsToComboBox(comboBox As ComboBox, enumType As Type)
            Dim enumArray As Array = [Enum].GetValues(enumType)
            For i As Integer = 0 To enumArray.Length - 1
                comboBox.Items.Add(enumArray.GetValue(i))
            Next
        End Sub
    End Class
End Namespace
