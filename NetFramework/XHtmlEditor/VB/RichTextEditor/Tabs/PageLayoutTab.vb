Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing
Imports C1.Win.C1Ribbon

Namespace RichTextEditor
	Class PageLayoutTab
		Inherits C1TextEditorRibbonTab
		'---------------------------------------------------------------------------
		#Region "** create tab"

		Public Sub New()
			Me.ID = InlineAssignHelper(Me.Text, "Page Layout")
			Groups.Add(CreatePageSetupGroup())
			Groups.Add(New RibbonGroup("Paragraph"))
			Groups.Add(New RibbonGroup("Arrange"))
		End Sub
		Private Function CreatePageSetupGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Page Setup")
			g.HasLauncherButton = True
			AddHandler g.DialogLauncherClick, AddressOf pageSetup_DialogLauncherClick

			g.Items.Add(CreateMenu("Margins", CreateButton("MarginNormal", "Margins"), CreateButton("MarginNarrow", "Margins"), CreateButton("MarginModerate", "Margins"), CreateButton("MarginWide", "Margins"), CreateButton("MarginOffice", "Margins"), _
				New RibbonSeparator(), CreateButton("CustomMargins")))

			g.Items.Add(CreateMenu("Orientation", CreateButton("Portrait"), CreateButton("Landscape")))

			Dim mPaperSize As RibbonMenu = CreateMenu("Size")
			For Each ps As PaperSize In New PrinterSettings().PaperSizes
				Dim btn As RibbonButton = CreateButton(ps.PaperName)
				btn.Tag = ps
				mPaperSize.Items.Add(btn)
			Next
			mPaperSize.MaxDropDownItems = 12
			mPaperSize.GripHandleVisible = True
			g.Items.Add(mPaperSize)

            For Each mainItem As RibbonItem In g.Items
                Dim m As RibbonMenu = TryCast(mainItem, RibbonMenu)
                If m IsNot Nothing Then
                    For Each item As RibbonItem In m.Items
                        Dim btn As RibbonButton = TryCast(item, RibbonButton)
                        If btn IsNot Nothing Then
                            btn.SupportedGroupSizing = SupportedGroupSizing.LargeImageOnly
                        End If
                    Next
                End If
            Next

			Return g
		End Function

		#End Region

		'---------------------------------------------------------------------------
		#Region "** handle commands"

		Friend Overloads Overrides Sub HandleItemEvent(e As RibbonEventArgs)
			Dim item As RibbonItem = DirectCast(e.Item, RibbonItem)
			If e.EventType = RibbonEventType.Click Then
				Dim ps As PageSettings

				Select Case item.ID
					' margins
					Case "MarginNormal"
						ps = Editor.PrintDocument.DefaultPageSettings
						ps.Margins = New Margins(100, 100, 100, 100)
						Exit Select
					Case "MarginNarrow"
						ps = Editor.PrintDocument.DefaultPageSettings
						ps.Margins = New Margins(50, 50, 50, 50)
						Exit Select
					Case "MarginModerate"
						ps = Editor.PrintDocument.DefaultPageSettings
						ps.Margins = New Margins(75, 75, 100, 100)
						Exit Select
					Case "MarginWide"
						ps = Editor.PrintDocument.DefaultPageSettings
						ps.Margins = New Margins(200, 200, 200, 200)
						Exit Select
					Case "MarginOffice"
						ps = Editor.PrintDocument.DefaultPageSettings
						ps.Margins = New Margins(125, 125, 100, 100)
						Exit Select
					Case "CustomMargins"
						Using dlg As PageSetupDialog = New PageSetupDialog()
							dlg.Document = Editor.PrintDocument
							dlg.ShowDialog()
						End Using
						Exit Select

					' orientation
					Case "Landscape"
						ps = Editor.PrintDocument.DefaultPageSettings
						ps.Landscape = True
						Exit Select
					Case "Portrait"
						ps = Editor.PrintDocument.DefaultPageSettings
						ps.Landscape = False
						Exit Select
					Case Else

						' paper size
						Dim paperSize As PaperSize = TryCast(item.Tag, PaperSize)
						If paperSize IsNot Nothing Then
							ps = Editor.PrintDocument.DefaultPageSettings
							ps.PaperSize = paperSize
						End If
						Exit Select
				End Select
			End If
        End Sub

		Private Sub pageSetup_DialogLauncherClick(sender As Object, e As EventArgs)
			Using dlg As PageSetupDialog = New PageSetupDialog()
				dlg.Document = Editor.PrintDocument
				dlg.ShowDialog()
			End Using
        End Sub

		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function
		#End Region
	End Class
End Namespace
