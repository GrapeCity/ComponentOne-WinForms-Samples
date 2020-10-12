Imports C1.Win.C1Win7Pack

Public Class Form1

    Private _pos As Int32
    Private _lastPos As Int32

    Private Sub overlayRadioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButton1.Click, radioButton4.Click, radioButton3.Click, radioButton2.Click

        Select Case CType(sender, RadioButton).Text
            Case "None"
                taskbarButton.OverlayIcon = Nothing
            Case "Error"
                taskbarButton.OverlayIcon = My.Resources._Error
            Case "Info"
                taskbarButton.OverlayIcon = My.Resources._Info
            Case "Warning"
                taskbarButton.OverlayIcon = My.Resources._Warn
        End Select

    End Sub

    Private Sub progressCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles progressCheckBox.CheckedChanged
        If (progressCheckBox.Checked) Then
            taskbarButton.ProgressIndicator.Show()
        Else
            taskbarButton.ProgressIndicator.Hide()
        End If
    End Sub

    Private Sub progressRadioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButton5.Click, radioButton8.Click, radioButton7.Click, radioButton6.Click

        Select Case CType(sender, RadioButton).Text
            Case "Normal"
                taskbarButton.ProgressIndicator.State = TaskbarProgressState.Normal
            Case "Error"
                taskbarButton.ProgressIndicator.State = TaskbarProgressState.Error
            Case "Paused"
                taskbarButton.ProgressIndicator.State = TaskbarProgressState.Paused
            Case "Marquee"
                taskbarButton.ProgressIndicator.State = TaskbarProgressState.Indeterminate
        End Select

    End Sub

    Private Sub trackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBar1.Scroll

        taskbarButton.ProgressIndicator.Value = trackBar1.Value
        progressBar1.Value = trackBar1.Value

    End Sub

    Private Sub clipCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clipCheckBox.CheckedChanged

        If clipCheckBox.Checked Then
            taskbarButton.Thumbnail.ClipControl = pictureBox1
        Else
            taskbarButton.Thumbnail.ClipControl = Nothing
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        _lastPos = imLarge.Images.Count - 1
        pictureBox1.Image = imLarge.Images(0)
        UpdateButtons()

    End Sub

    Private Sub btnFirstImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstImage.Click
        MoveFirst()
    End Sub

    Private Sub btnLastImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastImage.Click
        MoveLast()
    End Sub

    Private Sub btnPrevImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevImage.Click
        MovePrevious()
    End Sub

    Private Sub btnNextImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextImage.Click
        MoveNext()
    End Sub

    Private Sub tm_ThumbButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1Win7Pack.ThumbButtonEventArgs) Handles taskbarButton.ThumbButtonClick

        Select Case e.Button.Name
            Case "FirstImage"
                MoveFirst()
            Case "PrevImage"
                MovePrevious()
            Case "NextImage"
                MoveNext()
            Case "LastImage"
                MoveLast()
            Case "ToggleView"
                clipCheckBox.Checked = Not clipCheckBox.Checked
        End Select

    End Sub

    Private Sub UpdateButtons()

        pictureBox1.Image = imLarge.Images(_pos)

        Dim s As String = imLarge.Images.Keys(_pos)
        labImageCaption.Text = s
        taskbarButton.Thumbnail.Tooltip = s

        Dim notFirst As Boolean = _pos > 0
        Dim notLast As Boolean = _pos < _lastPos

        btnFirstImage.Enabled = notFirst
        btnPrevImage.Enabled = notFirst
        btnNextImage.Enabled = notLast
        btnLastImage.Enabled = notLast

        Dim buttons As ThumbButtonCollection = taskbarButton.Thumbnail.Buttons
        buttons.BeginUpdate()
        buttons("FirstImage").Enabled = notFirst
        buttons("PrevImage").Enabled = notFirst
        buttons("NextImage").Enabled = notLast
        buttons("LastImage").Enabled = notLast
        buttons.EndUpdate()
    End Sub

    Private Sub MoveFirst()

        _pos = 0
        UpdateButtons()

    End Sub

    Private Sub MoveLast()

        _pos = _lastPos
        UpdateButtons()

    End Sub

    Private Sub MovePrevious()

        If _pos > 0 Then
            _pos = _pos - 1
            UpdateButtons()
        End If

    End Sub

    Private Sub MoveNext()

        If (_pos < _lastPos) Then
            _pos = _pos + 1
            UpdateButtons()
        End If

    End Sub

End Class
