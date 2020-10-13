Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbFormStyle.SelectedIndex = 1
    End Sub

    Private Sub cbFormStyle_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFormStyle.SelectionChangeCommitted

        Dim itemText = CType(cbFormStyle.SelectedItem, String)
        Me.VisualStyle = CType(System.Enum.Parse(GetType(C1.Win.C1Ribbon.VisualStyle), itemText, False), C1.Win.C1Ribbon.VisualStyle)

        If Me.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Black Then
            label1.ForeColor = Color.White
        Else
            label1.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If

    End Sub

    Private Sub cbOuterStyle_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOuterStyle.SelectionChangeCommitted

        If cbOuterStyle.SelectedIndex >= 0 Then

            Dim itemText = CType(cbOuterStyle.SelectedItem, String)
            c1SplitContainer1.VisualStyle = CType(System.Enum.Parse(GetType(C1.Win.C1SplitContainer.VisualStyle), itemText, False), C1.Win.C1SplitContainer.VisualStyle)

        End If
    End Sub

    Private Sub btnOuterReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOuterReset.Click

        cbOuterStyle.SelectedIndex = -1
        c1SplitContainer1.ResetVisualStyle()

    End Sub

    Private Sub cbInnerStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbInnerStyle.SelectedIndexChanged

        If cbInnerStyle.SelectedIndex >= 0 Then

            Dim itemText = CType(cbInnerStyle.SelectedItem, String)
            c1SplitContainer2.VisualStyle = CType(System.Enum.Parse(GetType(C1.Win.C1SplitContainer.VisualStyle), itemText, False), C1.Win.C1SplitContainer.VisualStyle)

        End If
    End Sub

    Private Sub btnInnerReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInnerReset.Click

        cbInnerStyle.SelectedIndex = -1
        c1SplitContainer2.ResetVisualStyle()

    End Sub

    Private Sub cbPanelStyle_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPanelStyle.ChangeCommitted

        If cbPanelStyle.SelectedIndex >= 0 Then

            Dim itemText = cbPanelStyle.SelectedOption.Text
            c1InputPanel1.VisualStyle = CType(System.Enum.Parse(GetType(C1.Win.C1InputPanel.VisualStyle), itemText, False), C1.Win.C1InputPanel.VisualStyle)

        End If
    End Sub

    Private Sub btnPanelReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPanelReset.Click

        cbPanelStyle.SelectedIndex = -1
        c1InputPanel1.ResetVisualStyle()

    End Sub
End Class
