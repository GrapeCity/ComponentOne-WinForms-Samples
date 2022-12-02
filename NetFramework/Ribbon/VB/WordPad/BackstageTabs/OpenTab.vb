Public Class OpenTab

    Public Sub New()
        Initilize()
    End Sub

    Protected Overrides Sub OnMenuItemClick(ByVal mi As ListItem)
        Owner.OpenDocument(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text))
        mi.Item.LDate = DateTime.Now
    End Sub

    Protected Overrides Sub OnMenuButtonClick()
        Owner.OpenDocument()
    End Sub

    Private Sub OpenTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button.ItemImage = My.Resources.Open
        Button.ItemText = My.Resources.Browse_txt
        Caption = GetElementText(My.Resources.OpenTab_txt)
    End Sub
End Class
