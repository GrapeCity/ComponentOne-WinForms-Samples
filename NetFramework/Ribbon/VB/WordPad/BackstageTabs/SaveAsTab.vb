Public Class SaveAsTab

    Public Sub New()
        Initilize()
    End Sub

    Protected Overrides Sub OnMenuItemClick(ByVal mi As ListItem)
        Owner.SaveDocument(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text))
        mi.Item.LDate = DateTime.Now
    End Sub

    Protected Overrides Sub OnMenuButtonClick()
        Owner.SaveDocumentAs()
    End Sub

    Private Sub SaveAsTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button.ItemImage = My.Resources.Save
        Button.ItemText = My.Resources.Browse_txt
        Caption = GetElementText(My.Resources.SaveAsTab_txt)
    End Sub
End Class
