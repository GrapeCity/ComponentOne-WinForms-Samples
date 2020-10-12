Imports C1.Win.C1Win7Pack

Public Class Form1

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub linkCommonButtons_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCommonButtons.LinkClicked
        Dim result As TaskDialogResult = dialogCommonButtons.Show()
        Dim buttonText As String
        If result = TaskDialogResult.Ok Then
            buttonText = "OK"
        Else
            buttonText = result.ToString()
        End If
        MessageBox.Show(String.Format("The ""{0}"" button was clicked.", buttonText), "Common Buttons Sample")
    End Sub

    Private Sub linkCustomButtons_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCustomButtons.LinkClicked
        dialogCustomButtons.Show()
    End Sub

    Private Sub dialogCustomButtons_ButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1Win7Pack.TaskDialogButtonClickEventArgs) Handles dialogCustomButtons.ButtonClick

        If e.DialogResult = TaskDialogResult.Custom Then
            Select Case e.CustomButton.Name
                Case "Button1"
                    MessageBox.Show("Custom button 1 was clicked.", "Custom Buttons Sample")
                    e.Cancel = True
                Case "Button2"
                    MessageBox.Show("Custom button 2 was clicked.", "Custom Buttons Sample")
                    e.Cancel = True
                Case "Button3"
                    MessageBox.Show("Custom close button was clicked. Closing the dialog...", "Custom Buttons Sample")
            End Select
        End If

    End Sub

    Private Sub linkEnableDisable_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkEnableDisable.LinkClicked
        dialogEnableDisable.Show()
    End Sub

    Private Sub dialogEnableDisable_ButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1Win7Pack.TaskDialogButtonClickEventArgs) Handles dialogEnableDisable.ButtonClick

        If e.DialogResult = TaskDialogResult.Custom Then
            Dim cbc As CustomButtonCollection = dialogEnableDisable.CustomButtons
            If e.CustomButton.Name = "enableButton" Then
                dialogEnableDisable.RadioButtons(0).Enabled = True
                cbc("enableButton").Enabled = False
                cbc("disableButton").Enabled = True
            ElseIf e.CustomButton.Name = "disableButton" Then
                dialogEnableDisable.RadioButtons(0).Enabled = False
                cbc("enableButton").Enabled = True
                cbc("disableButton").Enabled = False
            End If
            e.Cancel = True
        End If

    End Sub

    Private Sub linkElevation_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkElevation.LinkClicked
        dialogElevation.Show()
    End Sub

    Private Sub linkError_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkError.LinkClicked
        dialogError.Show()
    End Sub

    Private Sub dialogError_ButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1Win7Pack.TaskDialogButtonClickEventArgs) Handles dialogError.ButtonClick
        If e.DialogResult = TaskDialogResult.Custom AndAlso e.CustomButton.Name = "sendButton" Then
            Dim sendDialog As C1TaskDialog = New C1TaskDialog()
            sendDialog.WindowTitle = "Send Feedback Dialog"
            sendDialog.Content = "Sending your feedback ....."
            sendDialog.ProgressBar.Maximum = 5000
            sendDialog.ProgressBar.Visible = True
            sendDialog.EnableTimer = True
            AddHandler sendDialog.TimerTick, AddressOf sendDialog_TimerTick

            sendDialog.Show()
            sendDialog.Dispose()
        End If
    End Sub

    Private Sub sendDialog_TimerTick(ByVal sender As Object, ByVal e As TaskDialogTimerTickEventArgs)
        Dim dialog As C1TaskDialog = CType(sender, C1TaskDialog)
        If e.Ticks <= 5000 Then
            dialog.MainInstruction = String.Format("Sending ....{0}", e.Ticks)
            dialog.ProgressBar.Value = e.Ticks
        Else
            dialog.MainInstruction = "Thanks for the feedback!"
            dialog.Content = "Our developers will get right on that..."
            dialog.ProgressBar.Value = 5000
        End If
    End Sub


    Private Sub linkIcons_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkIcons.LinkClicked
        dialogIcons.Show(False)
    End Sub

    Private Sub dialogIcons_RadioButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dialogIcons.RadioButtonClick
        Dim dialog As C1TaskDialog = CType(sender, C1TaskDialog)
        Select dialog.SelectedRadioButton.Name
            Case "radioNone"
                dialog.MainCommonIcon = TaskDialogCommonIcon.None
                dialog.FooterCommonIcon = TaskDialogCommonIcon.None
            Case "radioError"
                dialog.MainCommonIcon = TaskDialogCommonIcon.Error
                dialog.FooterCommonIcon = TaskDialogCommonIcon.Error
            Case "radioWarning"
                dialog.MainCommonIcon = TaskDialogCommonIcon.Warning
                dialog.FooterCommonIcon = TaskDialogCommonIcon.Warning
            Case "radioInformation"
                dialog.MainCommonIcon = TaskDialogCommonIcon.Information
                dialog.FooterCommonIcon = TaskDialogCommonIcon.Information
            Case "radioShield"
                dialog.MainCommonIcon = TaskDialogCommonIcon.Shield
                dialog.FooterCommonIcon = TaskDialogCommonIcon.Shield
        End Select
    End Sub

    Private Sub linkProgress1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkProgress1.LinkClicked
        dialogProgress1.ProgressBar.Value = 0
        dialogProgress1.Show()
    End Sub

    Private Sub dialogProgress1_TimerTick(ByVal sender As System.Object, ByVal e As C1.Win.C1Win7Pack.TaskDialogTimerTickEventArgs) Handles dialogProgress1.TimerTick
        Dim dialog As C1TaskDialog = CType(sender, C1TaskDialog)
        If (e.Ticks <= 5000) Then
            dialog.MainInstruction = String.Format("Progress = {0}", e.Ticks)
            dialog.ProgressBar.Value = e.Ticks
        Else
            dialog.MainInstruction = "Progress = Done"
            dialog.ProgressBar.Value = 5000
        End If
    End Sub

    Private Sub linkProgress2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkProgress2.LinkClicked
        dialogProgress2.Show()
    End Sub

    Private Sub linkTimer_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkTimer.LinkClicked
        dialogTimer.MainInstruction = "Time elapsed: 0 seconds"
        dialogTimer.Show()
    End Sub

    Private Sub dialogTimer_TimerTick(ByVal sender As System.Object, ByVal e As C1.Win.C1Win7Pack.TaskDialogTimerTickEventArgs) Handles dialogTimer.TimerTick
        CType(sender, C1TaskDialog).MainInstruction = String.Format("Time elapsed: {0} seconds", e.Ticks \ 1000)
    End Sub
End Class
