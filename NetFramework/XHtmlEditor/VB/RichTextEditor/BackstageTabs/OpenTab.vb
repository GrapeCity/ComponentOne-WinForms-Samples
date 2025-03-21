﻿
Imports RichTextEditor.RichTextEditor

Partial Public Class OpenTab
    Inherits BackstageTabFileList

    Public Sub New()
        Button.ItemImage = Resources.Open_large
        Button.ItemText = Resources.Browse_txt
        Caption = GetElementText(Resources.OpenTab_txt)
    End Sub

    Protected Overrides Sub OnMenuItemClick(ByVal mi As BackstageTabItem)
        Dim ribbon As C1TextEditorRibbon = CType(BackstageView.Ribbon, C1TextEditorRibbon)
        ribbon.OpenDocument(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text))
        mi.Item.ItemDate = DateTime.Now
    End Sub

    Protected Overrides Sub OnMenuButtonClick()
        Dim ribbon As C1TextEditorRibbon = CType(BackstageView.Ribbon, C1TextEditorRibbon)
        ribbon.OpenDocument()
    End Sub
End Class