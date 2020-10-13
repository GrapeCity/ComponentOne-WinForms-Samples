Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports C1.Win.C1Ribbon

Namespace RichTextEditor
	Class InsertTab
		Inherits C1TextEditorRibbonTab
		'---------------------------------------------------------------------------
		#Region "** fields"

		Private _symbolDlg As New InsertSymbol()

		#End Region

		'---------------------------------------------------------------------------
		#Region "**ctors"

		Public Sub New()
			Me.ID = InlineAssignHelper(Me.Text, "Insert")
            Groups.Add(CreateTablesGroup())
			Groups.Add(CreateIllustrationsGroup())
			Groups.Add(CreateLinksGroup())
            Groups.Add(CreateTextGroup())
		End Sub

		#End Region

		'---------------------------------------------------------------------------
		#Region "** create tab"

		Private Function CreatePagesGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Pages")
			g.Items.Add(CreateButton("CoverPage"))
			g.Items.Add(CreateButton("BlankPage"))
			g.Items.Add(CreateButton("PageBreak"))
			Return g
		End Function

		Private Function CreateTablesGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Tables")
			g.Items.Add(CreateButton("InsertTable", "Table"))
			g.Items.Add(CreateSplitButton("InsertTableItems", CreateButton("InsertRowAbove"), CreateButton("InsertRowBelow"), CreateButton("InsertColumnBefore"), CreateButton("InsertColumnAfter")))
			g.Items.Add(CreateSplitButton("DeleteTableItems", CreateButton("DeleteTable"), CreateButton("DeleteRows"), CreateButton("DeleteColumns")))
			g.Items.Add(CreateSplitButton("TableItemsProperties", CreateButton("TableProperties"), CreateButton("TableRowProperties"), CreateButton("TableColumnProperties"), CreateButton("TableCellProperties")))
			Return g
		End Function

		Private Function CreateIllustrationsGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Illustrations")
			g.Items.Add(CreateButton("Picture"))
			g.Items.Add(CreateButton("FlashMovie"))
			Return g
		End Function

		Private Function CreateLinksGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Links")
			g.Items.Add(CreateButton("Hyperlink"))
			g.Items.Add(CreateButton("Bookmark"))
            Return g
		End Function

		Private Function CreateHeaderFooterGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Header && Footer")
			g.Items.Add(CreateButton("Header"))
			g.Items.Add(CreateButton("Footer"))
			g.Items.Add(CreateButton("PageNumber"))
			Return g
		End Function

		Private Function CreateTextGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Text")
			g.Items.Add(CreateButton("DateAndTime"))
			g.Items.Add(CreateButton("Symbol"))
			Return g
		End Function

		#End Region

		'---------------------------------------------------------------------------
		#Region "** handle commands"

		Protected Overloads Overrides Sub OnSelect(e As EventArgs)
			MyBase.OnSelect(e)
			UpdateUI()
		End Sub

		Friend Overloads Overrides Sub UpdateUI()
			GetItemByID("InsertTableItems").Enabled = Editor.InsertTableRowEnabled OrElse Editor.InsertTableColumnEnabled
			GetItemByID("DeleteTableItems").Enabled = Editor.DeleteTableEnabled
			GetItemByID("TableItemsProperties").Enabled = Editor.TablePropertiesEnabled

			GetItemByID("InsertTable").Enabled = Editor.InsertTableEnabled
			GetItemByID("InsertRowAbove").Enabled = Editor.InsertTableRowEnabled
			GetItemByID("InsertRowBelow").Enabled = Editor.InsertTableRowEnabled
			GetItemByID("InsertColumnBefore").Enabled = Editor.InsertTableColumnEnabled
			GetItemByID("InsertColumnAfter").Enabled = Editor.InsertTableColumnEnabled
			GetItemByID("DeleteTable").Enabled = Editor.DeleteTableEnabled
			GetItemByID("DeleteRows").Enabled = Editor.DeleteTableRowsEnabled
			GetItemByID("DeleteColumns").Enabled = Editor.InsertTableColumnEnabled
			GetItemByID("TableProperties").Enabled = Editor.TablePropertiesEnabled
			GetItemByID("TableRowProperties").Enabled = Editor.TableRowPropertiesEnabled
			GetItemByID("TableColumnProperties").Enabled = Editor.TableColumnPropertiesEnabled
			GetItemByID("TableCellProperties").Enabled = Editor.TableCellPropertiesEnabled

			GetItemByID("Picture").Enabled = Editor.InsertPictureEnabled
			GetItemByID("FlashMovie").Enabled = Editor.InsertFlashMovieEnabled

			GetItemByID("Hyperlink").Enabled = Editor.InsertHyperlinkEnabled
			GetItemByID("Bookmark").Enabled = Editor.InsertBookmarkEnabled
		End Sub

		Friend Overloads Overrides Sub HandleItemEvent(e As RibbonEventArgs)
			Dim item As RibbonItem = DirectCast(e.Item, RibbonItem)
			If e.EventType = RibbonEventType.Click Then
				Select Case item.ID
					Case "DateAndTime"
						Using dlg As InsertDateTime = New InsertDateTime()
							dlg.ShowDialog(Editor)
						End Using
						Exit Select
					Case "Symbol"
						_symbolDlg.ShowDialog(Editor)
						Exit Select
					Case "PageBreak"
						Editor.InsertPageBreak()
						Exit Select
					Case "Picture"
						Editor.InsertPicture()
						Exit Select
					Case "FlashMovie"
						Editor.InsertFlashMovie()
						Exit Select
					Case "Hyperlink"
						Editor.InsertHyperlink()
						Exit Select
					Case "Bookmark"
						Editor.InsertBookmark()
						Exit Select
					Case "InsertTable"
						Editor.InsertTable()
						Exit Select
					Case "InsertRowAbove"
						Editor.InsertTableRowAbove()
						Exit Select
					Case "InsertRowBelow"
						Editor.InsertTableRowBelow()
						Exit Select
					Case "InsertColumnBefore"
						Editor.InsertTableColumnBefore()
						Exit Select
					Case "InsertColumnAfter"
						Editor.InsertTableColumnAfter()
						Exit Select
					Case "DeleteTable"
						Editor.DeleteTable()
						Exit Select
					Case "DeleteRows"
						Editor.DeleteTableRows()
						Exit Select
					Case "DeleteColumns"
						Editor.DeleteTableColumns()
						Exit Select
					Case "TableProperties"
						Editor.TableProperties()
						Exit Select
					Case "TableRowProperties"
						Editor.TableRowProperties()
						Exit Select
					Case "TableColumnProperties"
						Editor.TableColumnProperties()
						Exit Select
					Case "TableCellProperties"
						Editor.TableCellProperties()
						Exit Select
				End Select
			End If

			MyBase.HandleItemEvent(e)
		End Sub
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

		#End Region
	End Class
End Namespace
