
Imports RichTextEditor.RichTextEditor

Partial Public Class SaveAsTab
    Inherits AppMenuTabFileList

    Public Sub New()
        Button.ItemImage = Resources.Open_large
        Button.ItemText = Resources.Browse_txt
        Caption = GetElementText(Resources.SaveAsTab_txt)
    End Sub

    Protected Overrides Sub OnMenuItemClick(ByVal mi As AppMenuTabItem)
        Dim ribbon As C1TextEditorRibbon = CType(RibbonApplicationMenu.Ribbon, C1TextEditorRibbon)
        ribbon.SaveDocument(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text))
        mi.Item.ItemDate = DateTime.Now
    End Sub

    Protected Overrides Sub OnMenuButtonClick()
        Dim ribbon As C1TextEditorRibbon = CType(RibbonApplicationMenu.Ribbon, C1TextEditorRibbon)
        ribbon.SaveDocumentAs()
    End Sub
End Class
