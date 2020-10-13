Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit

Namespace C1MagnifyPages
    Partial Public Class C1MagnifyCommon
        Inherits DemoBase
        Public Sub New()
            InitializeComponent()
            InitializeDemo()
        End Sub

        Private Sub InitializeDemo()
            Me.Title = "C1Magnify"
            Me.Description = "This page shows C1Magnify." & vbLf & "  -After long tap, a magnifier will popup above the finger, and shows the info around the finger."

            AddHandler moveLeftDownRadioButton.CheckedChanged, AddressOf MoveMessageRadioButton_CheckedChanged
            AddHandler moveNoneRadioButton.CheckedChanged, AddressOf MoveMessageRadioButton_CheckedChanged
            AddHandler moveRadioButton.CheckedChanged, AddressOf MoveMessageRadioButton_CheckedChanged

            AddHandler closeLeftRadioButton.CheckedChanged, AddressOf CloseMessageRadioButton_CheckedChanged
            AddHandler closeNoneRadioButton.CheckedChanged, AddressOf CloseMessageRadioButton_CheckedChanged
            AddHandler closeRightRadioButton.CheckedChanged, AddressOf CloseMessageRadioButton_CheckedChanged

            AddHandler circleRadioButton.CheckedChanged, AddressOf ShapeRadioButton_CheckedChanged
            AddHandler rectangleRadioButton.CheckedChanged, AddressOf ShapeRadioButton_CheckedChanged
            AddHandler roundedRectangleRadioButton.CheckedChanged, AddressOf ShapeRadioButton_CheckedChanged

            AddHandler lightRadioButton.CheckedChanged, AddressOf borderBackgroundModeRadioButton1_CheckedChanged
            AddHandler darkRadioButton.CheckedChanged, AddressOf borderBackgroundModeRadioButton1_CheckedChanged
            AddHandler customRadioButton.CheckedChanged, AddressOf borderBackgroundModeRadioButton1_CheckedChanged

            ShowCursorCheckbox.DataBindings.Add("Checked", gcMagnifier1, "ShowCursor")
            IsHorizontalRailEnabledCheckBox.DataBindings.Add("Checked", gcMagnifier1, "IsHorizontalRailEnabled")
            IsVerticalRailEnalbedCheckBox.DataBindings.Add("Checked", gcMagnifier1, "IsVerticalRailEnabled")

            If gcMagnifier1.BorderBackground IsNot Nothing Then
                pictureBox1.Image = gcMagnifier1.BorderBackground
            Else
                gcMagnifier1.BorderBackground = pictureBox1.Image
            End If

            AddHandler borderWidthTrackBar.ValueChanged, AddressOf borderWidthTrackBar_ValueChanged
            AddHandler PopupDelayTrackBar.ValueChanged, AddressOf PopupDelayTrackBar_ValueChanged
            AddHandler sizeTrackBar.ValueChanged, AddressOf sizeTrackBar_ValueChanged
            AddHandler zoomfactorTrackBar.ValueChanged, AddressOf zoomfactorTrackBar_ValueChanged
        End Sub

        Private Sub CloseMessageRadioButton_CheckedChanged(sender As Object, e As EventArgs)
            If closeLeftRadioButton.Checked Then
                gcMagnifier1.MessageWhenClose = MessageWhenClose.LeftClick
            ElseIf closeNoneRadioButton.Checked Then
                gcMagnifier1.MessageWhenClose = MessageWhenClose.None
            ElseIf closeRightRadioButton.Checked Then
                gcMagnifier1.MessageWhenClose = MessageWhenClose.RightClick
            End If
        End Sub

        Private Sub MoveMessageRadioButton_CheckedChanged(sender As Object, e As EventArgs)
            If moveLeftDownRadioButton.Checked Then
                gcMagnifier1.MessageWhenMove = MessageWhenMove.LeftDown
            ElseIf moveNoneRadioButton.Checked Then
                gcMagnifier1.MessageWhenMove = MessageWhenMove.None
            ElseIf moveRadioButton.Checked Then
                gcMagnifier1.MessageWhenMove = MessageWhenMove.Move
            End If
        End Sub

        Private Sub PopupDelayTrackBar_ValueChanged(sender As Object, e As EventArgs)
            popupDelayLabel.Text = PopupDelayTrackBar.Value.ToString() & "ms"
            gcMagnifier1.PopupDelay = PopupDelayTrackBar.Value
        End Sub

        Private Sub ShapeRadioButton_CheckedChanged(sender As Object, e As EventArgs)
            If circleRadioButton.Checked Then
                gcMagnifier1.Shape = MagnifierShape.Circle
            ElseIf rectangleRadioButton.Checked Then
                gcMagnifier1.Shape = MagnifierShape.Rectangle
            ElseIf roundedRectangleRadioButton.Checked Then
                gcMagnifier1.Shape = MagnifierShape.RoundedRectangle
            End If
        End Sub

        Private Sub sizeTrackBar_ValueChanged(sender As Object, e As EventArgs)
            gcMagnifier1.Size = New Size(sizeTrackBar.Value * 100, sizeTrackBar.Value * 100)
            sizeLabel.Text = "(" & (sizeTrackBar.Value * 100).ToString() & "," & (sizeTrackBar.Value * 100).ToString() & ")"
        End Sub

        Private Sub zoomfactorTrackBar_ValueChanged(sender As Object, e As EventArgs)
            gcMagnifier1.ZoomFactor = zoomfactorTrackBar.Value
            zoomFactorLabel.Text = (zoomfactorTrackBar.Value * 100).ToString() & "%"
        End Sub

        Private Sub borderBackgroundModeRadioButton1_CheckedChanged(sender As Object, e As EventArgs)
            If lightRadioButton.Checked Then
                gcMagnifier1.BorderBackgroundMode = BorderBackground.Light
                customBackgroundSetting.Visible = False
            ElseIf darkRadioButton.Checked Then
                gcMagnifier1.BorderBackgroundMode = BorderBackground.Dark
                customBackgroundSetting.Visible = False
            ElseIf customRadioButton.Checked Then
                gcMagnifier1.BorderBackgroundMode = BorderBackground.[Custom]
                customBackgroundSetting.Visible = True
            End If
        End Sub

        Private Sub SelectImageButton_Click(sender As Object, e As EventArgs) Handles SelectImageButton.Click
            Dim dialog As New OpenFileDialog()
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            If DialogResult.OK = dialog.ShowDialog() Then
                Dim bitmap As Bitmap = Nothing
                Try
                    bitmap = New Bitmap(dialog.FileName)
                Catch generatedExceptionName As ArgumentException
                    MessageBox.Show("This is not a suitable file.")
                    Return
                End Try
                If gcMagnifier1.BorderBackground IsNot Nothing Then
                    gcMagnifier1.BorderBackground.Dispose()
                    gcMagnifier1.BorderBackground = Nothing
                End If
                gcMagnifier1.BorderBackground = bitmap
                pictureBox1.Image = bitmap
            End If
        End Sub

        Private Sub borderWidthTrackBar_ValueChanged(sender As Object, e As EventArgs)
            gcMagnifier1.BorderWidth = borderWidthTrackBar.Value
            borderWidthlabel.Text = gcMagnifier1.BorderWidth.ToString()
        End Sub
    End Class
End Namespace