Public Class Form1

    ' html template for super tooltip
    Dim _tip As String = _
        "<table><tr>" + _
          "<td><parm><img src='res://Target.png'></parm>" + _
          "<td><b><parm>This is a SuperTooltip</parm></b>" + _
        "</table>" + _
        "<parm><hr noshade size=1 style='margin:2' color=Darker></parm>" + _
        "<div style='margin:1 12'><parm>" + _
        "This tooltip is associated with cell (row,col).<br>" + _
        "You can show it as a balloon or as a regular<br>" + _
        "tooltip." + _
        "</parm></div>" + _
        "<parm><hr noshade size=1 style='margin:2' color=Darker></parm>" + _
        "<table><tr>" + _
          "<td><parm></parm>" + _
          "<td><b><parm>enjoy your SuperTooltip today!</parm></b>" + _
        "</table>"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' no delay for showing, very long time to hide
        C1SuperTooltip1.AutomaticDelay = 0
        C1SuperTooltip1.AutoPopDelay = Integer.MaxValue

        ' no delay for showing, very long time to hide
        ToolTip1.AutomaticDelay = 0
        ToolTip1.AutoPopDelay = Integer.MaxValue

    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged

        ' change IsBalloon for all tips
        C1SuperTooltip1.IsBalloon = checkBox1.Checked
        ToolTip1.IsBalloon = checkBox1.Checked

    End Sub

    ' update super tooltip
    Private Sub _flex_MouseHoverCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flex.MouseHoverCell
        Dim flex As C1.Win.C1FlexGrid.C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
        Dim tip As String = _tip.Replace("(row,col)", String.Format("<b>({0},{1})</b>", flex.MouseRow, flex.MouseCol))
        C1SuperTooltip1.SetToolTip(flex, tip)
    End Sub

    ' update regular tooltip
    Private Sub _flex2_MouseHoverCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flex2.MouseHoverCell
        Dim flex As C1.Win.C1FlexGrid.C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
        Dim tip As String = String.Format("This is a regular tip on cell ({0},{1})", flex.MouseRow, flex.MouseCol)
        ToolTip1.SetToolTip(flex, tip)
    End Sub

    ' update super tooltip using Show/Hide methods
    Private Sub _flex3_MouseHoverCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flex3.MouseHoverCell
        Dim flex As C1.Win.C1FlexGrid.C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
        Dim tip As String = _tip.Replace("(row,col)", String.Format("<b>({0},{1})</b>", flex.MouseRow, flex.MouseCol))
        Dim pt As Point = flex.PointToClient(Control.MousePosition)
        C1SuperTooltip1.Show(tip, flex, pt)
    End Sub
    Private Sub _flex3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flex3.MouseLeave
        Dim flex As C1.Win.C1FlexGrid.C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
        C1SuperTooltip1.Hide(flex)
    End Sub

    ' update super tooltip using Show/Hide methods
    Private Sub _flex4_MouseHoverCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flex4.MouseHoverCell
        Dim flex As C1.Win.C1FlexGrid.C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
        Dim tip As String = String.Format("This is a regular tip on cell ({0},{1})", flex.MouseRow, flex.MouseCol)
        Dim pt As Point = flex.PointToClient(Control.MousePosition)
        ToolTip1.Show(tip, flex, pt)
    End Sub
    Private Sub _flex4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flex4.MouseLeave
        Dim flex As C1.Win.C1FlexGrid.C1FlexGrid = CType(sender, C1.Win.C1FlexGrid.C1FlexGrid)
        ToolTip1.Hide(flex)
    End Sub
End Class
