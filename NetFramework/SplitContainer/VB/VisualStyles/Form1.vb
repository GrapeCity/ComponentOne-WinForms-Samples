Public Class Form1

    Private Sub cbOuterStyle_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOuterStyle.SelectionChangeCommitted

        If cbOuterStyle.SelectedIndex >= 0 Then

            Dim itemText = CType(cbOuterStyle.SelectedItem, String)
            c1SplitContainer1.VisualStyle = CType(System.Enum.Parse(GetType(C1.Win.SplitContainer.VisualStyle), itemText, False), C1.Win.SplitContainer.VisualStyle)

        End If
    End Sub

    Private Sub btnOuterReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOuterReset.Click

        cbOuterStyle.SelectedIndex = -1
        c1SplitContainer1.ResetVisualStyle()

    End Sub

    Private Sub cbInnerStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbInnerStyle.SelectedIndexChanged

        If cbInnerStyle.SelectedIndex >= 0 Then

            Dim itemText = CType(cbInnerStyle.SelectedItem, String)
            c1SplitContainer2.VisualStyle = CType(System.Enum.Parse(GetType(C1.Win.SplitContainer.VisualStyle), itemText, False), C1.Win.SplitContainer.VisualStyle)

        End If
    End Sub

    Private Sub btnInnerReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInnerReset.Click

        cbInnerStyle.SelectedIndex = -1
        c1SplitContainer2.ResetVisualStyle()

    End Sub

    Private Sub cbPanelStyle_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPanelStyle.ChangeCommitted

        If cbPanelStyle.SelectedIndex >= 0 Then

            Dim itemText = cbPanelStyle.SelectedOption.Text
            c1InputPanel1.VisualStyle = CType(System.Enum.Parse(GetType(C1.Win.InputPanel.VisualStyle), itemText, False), C1.Win.InputPanel.VisualStyle)

        End If
    End Sub

    Private Sub btnPanelReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPanelReset.Click

        cbPanelStyle.SelectedIndex = -1
        c1InputPanel1.ResetVisualStyle()

    End Sub
End Class
