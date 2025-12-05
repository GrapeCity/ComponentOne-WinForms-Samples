
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.SuperTooltip
Imports RichTextEditor.RichTextEditor

Partial Public Class PrintTab
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        lblCaption.Text = GetElementText(Resources.PrintTab_txt)
        SetButtonSettings(btnPrint, "Print")
        SetButtonSettings(btnQPrint, "QuickPrint")
        c1PrintPreviewControl1.TopToolStripPanelVisible = False
    End Sub

    Public Property Ribbon As C1TextEditorRibbon

    Private Sub btnQPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQPrint.Click
        If Ribbon IsNot Nothing Then Ribbon.PrintDocument(False, False)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        If Ribbon IsNot Nothing Then Ribbon.PrintDocument(True, False)
    End Sub

    Private Sub SetButtonSettings(ByVal btn As Button, ByVal prefix As String)
        btn.Image = CType(Resources.ResourceManager.GetObject(prefix & "_large", Resources.Culture), Image)
        btn.TextImageRelation = TextImageRelation.ImageAboveText
        btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Dim res As String = CStr(Resources.ResourceManager.GetObject(prefix & "_txt", Resources.Culture))
        Dim textParts As String() = If(res IsNot Nothing, res.Split(vbLf), New String() {prefix})
        Dim text As String = textParts(0).Trim()
        If Not String.IsNullOrEmpty(text) Then
            btn.Text = text
        End If

        If textParts.Length > 1 Then
            If Not textParts(1).StartsWith("*") Then
                Dim toolTip As C1SuperTooltip = New C1.Win.SuperTooltip.C1SuperTooltip()
                Dim tipTitle As String = textParts(1).Trim()
                Dim tipBody As String = String.Join("<br/>", textParts, 2, textParts.Length - 2).Trim()
                toolTip.SetToolTip(btn, If(String.IsNullOrEmpty(tipBody), tipTitle, String.Format("<b>{0}</b><br/>" & "<div style='margin-left:12'>{1}</div>", tipTitle, tipBody)))
            End If
        End If
    End Sub

    Private Function GetElementText(ByVal text As String) As String
        Dim textParts As String() = If(text IsNot Nothing, text.Split(vbLf), New String() {String.Empty})
        Return textParts(0).Trim()
    End Function

    Friend Sub SetDocument()
        C1PrintPreviewControl1.Document = Ribbon.Editor.PrintDocument
    End Sub
End Class