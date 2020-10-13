Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        C1SuperTooltip1.SetToolTip(openToolStripButton, "this is the <b>openToolStripButton</b>")

    End Sub

    ' show tooltips for 1 second
    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        toolTip1.Show("standard Tooltip on button1" & vbCrLf & "for 1 second.", button1, 1000)
    End Sub
    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        C1SuperTooltip1.Show("<b>super</b> Tooltip on button1<br>for 1 second.", button1, 1000)
    End Sub
    Private Sub button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button10.Click
        C1SuperTooltip1.Show("<b>super</b> Tooltip on <b>openToolStripItem</b><br>for 1 second.", openToolStripButton, 1000)
    End Sub

    ' show tooltips for 1 second, with offset
    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button8.Click
        toolTip1.Show("standard Tooltip on button1" & vbCrLf & "for 1 second, offset.", button1, 50, 50, 1000)
    End Sub
    Private Sub button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button9.Click
        C1SuperTooltip1.Show("<b>super</b> Tooltip on button1<br>for 1 second, offset.", button1, 50, 50, 1000)
    End Sub
    Private Sub button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button11.Click
        C1SuperTooltip1.Show("<b>super</b> Tooltip on <b>openToolStripItem</b><br>for 1 second, offset.", openToolStripButton, 50, 50, 1000)
    End Sub

    ' show tooltips, no time limit
    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        toolTip1.Show("standard Tooltip on button1, no time.", button1)
    End Sub
    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        C1SuperTooltip1.Show("<b>super</b> Tooltip on button1, no time.", button1)
    End Sub
    Private Sub button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button12.Click
        C1SuperTooltip1.Show("<b>super</b> Tooltip on <b>openToolStripItem</b>,<br>no time.", openToolStripButton)
    End Sub

    ' hide tooltips
    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        toolTip1.Hide(button1)
    End Sub
    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button7.Click
        C1SuperTooltip1.Hide(button1)
    End Sub
    Private Sub button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button13.Click
        C1SuperTooltip1.Hide(openToolStripButton)
    End Sub

    ' set super tooltip properties
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Me.C1SuperTooltip1.RoundedCorners = Me.CheckBox1.Checked
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Me.C1SuperTooltip1.IsBalloon = Me.CheckBox2.Checked
    End Sub
End Class
