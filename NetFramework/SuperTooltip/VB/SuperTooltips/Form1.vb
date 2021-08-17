Public Class Form1

    Dim _lastNode As TreeNode

    ' initialize
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        treeView1.ExpandAll()
        AddTipsToToolStrip(toolStrip1)
        AddTipsToTreeView(treeView1)
        AddToolboxTips(_groupToolBox.Controls)
    End Sub

    ' add Html tooltips to items in a toolstrip
    Private Sub AddTipsToToolStrip(ByVal toolStrip As ToolStrip)

        ' do not show the default tooltips
        toolStrip.ShowItemToolTips = False

        ' att Html tooltips to each item in the toolStrip
        Dim item As ToolStripItem
        For Each item In toolStrip.Items

            ' get tooltip text
            Dim text As String = item.ToolTipText
            If Not String.IsNullOrEmpty(text) Then

                ' get tooltip image
                Dim image As String = String.Empty
                If Not (item.Image Is Nothing) Then

                    Dim imageName As String = item.Name + ".Image"
                    image = "res://" + imageName
                End If

                ' build tip
                Dim tip As New System.Text.StringBuilder()
                tip.AppendFormat("<table><tr><td><img src='{0}'><td style='font:bold 11pt Tahoma'>{1}</table>", _
                        image, _
                        System.Web.HttpUtility.HtmlEncode(text))

                ' append general 'get help' tip
                If Not item.Equals(helpToolStripButton) Then

                    tip.Append("</div><hr noshade size=1 color=lightBlue>")
                    tip.AppendFormat("<table><tr><td><img src='{0}'><td>{1}</table>", _
                        "res://helpToolStripButton.Image", _
                        "Press <b>F1</b> for more help.")
                End If

                ' assign tooltip to item
                C1SuperTooltip1.SetToolTip(item, tip.ToString())
            End If
        Next
    End Sub

    ' add Html toolips to nodes in a TreeView
    Private Sub AddTipsToTreeView(ByVal treeView As TreeView)

        ' always show the same image
        ShowSameImage(treeView.Nodes)

        ' do not show the default tooltips
        treeView.ShowNodeToolTips = False

    End Sub
    Private Sub ShowSameImage(ByVal nodes As TreeNodeCollection)
        If Not (nodes Is Nothing) Then
            Dim node As TreeNode
            For Each node In nodes

                node.SelectedImageIndex = node.ImageIndex
                ShowSameImage(node.Nodes)
            Next
        End If
    End Sub

    ' update tooltip as the mouse moves
    Private Sub treeView1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeView1.MouseMove
        Dim tv As TreeView = CType(sender, TreeView)

        Dim hti As TreeViewHitTestInfo = tv.HitTest(e.X, e.Y)
        If Not Object.Equals(hti.Node, _lastNode) Then

            ' save new node
            _lastNode = hti.Node

            ' mouse is over a new node, update tip
            Dim text As String = Nothing
            If Not IsNothing(hti.Node) Then

                ' build tip
                Dim tip As New System.Text.StringBuilder()
                If Not (hti.Node.Parent Is Nothing) Then
                    tip.AppendFormat("<div style='font:bold 11pt Tahoma'>{0}/{1}</div>", _
                        hti.Node.Parent.Text, hti.Node.Text)
                    tip.AppendFormat("Click this node to see the <b>{0}</b> options.", _
                        hti.Node.Text)
                Else

                    tip.AppendFormat("<div style='font:bold 14pt Tahoma'>{0} Options</div>", _
                        hti.Node.Text)
                End If

                ' append general 'get help' tip
                tip.Append("</div><hr noshade size=1 color=lightBlue>")
                tip.AppendFormat("<table><tr><td><img src='{0}'><td>{1}</table>", _
                    "res://helpToolStripButton.Image", _
                    "Press <b>F1</b> for more help.")
                text = tip.ToString()
            End If


            ' update tip
            C1SuperTooltip1.SetToolTip(tv, text)
        End If
    End Sub

    Private Sub AddToolboxTips(ByVal controls As System.Collections.IList)

        Dim ctl As Control
        For Each ctl In controls

            ' get control information
            Dim t As Type = ctl.GetType()
            Dim name As String = t.FullName.Substring(t.Namespace.Length + 1)
            Dim version As String = t.Assembly.GetName().Version.ToString()
            Dim author As String = "unknown"
            Dim category As String = ".NET Component"
            Dim description As String = name
            Dim att As Object() = t.GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), True)
            If (att.Length > 0) Then

                Dim da As System.ComponentModel.DescriptionAttribute = CType(att(0), System.ComponentModel.DescriptionAttribute)
                description = da.Description
                att = t.Assembly.GetCustomAttributes(GetType(System.Reflection.AssemblyCompanyAttribute), True)
                If (att.Length > 0) Then
                    Dim ac As System.Reflection.AssemblyCompanyAttribute = CType(att(0), System.Reflection.AssemblyCompanyAttribute)
                    author = ac.Company

                    ' build tooltip
                    Dim tip As New System.Text.StringBuilder()
                    tip.AppendFormat(
                        "<div style='width:300px'>" +
                        "<b>{0}</b><br>" +
                        "Version {1} from {2}<br>" +
                        "{3}<br><br>" +
                        "{4} </div>",
                        name, version, author, category, description)
                    att = t.Assembly.GetCustomAttributes(GetType(System.Security.AllowPartiallyTrustedCallersAttribute), True)
                    If (att.Length > 0) Then
                        tip.Append("<hr>" +
                            "<table><tr>" +
                            "<td><img src='res://security.png'></td>" +
                            "<td>Allows partially trusted callers.</td>" +
                            "</tr></table>")
                    End If

                    ' assign tooltip
                    C1SuperTooltip1.SetToolTip(ctl, tip.ToString())
                End If
            End If
        Next
    End Sub

    ' toggle IsBalloon property
    Private Sub toolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripButton1.Click
        toolStripButton1.Checked = Not toolStripButton1.Checked
        C1SuperTooltip1.IsBalloon = toolStripButton1.Checked
    End Sub
End Class
