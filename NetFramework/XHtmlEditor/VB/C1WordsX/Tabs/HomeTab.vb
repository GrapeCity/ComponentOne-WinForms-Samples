Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports C1.Win.C1Ribbon
Imports C1.Win.C1Editor

Namespace C1WordsX
	Class HomeTab
		Inherits C1TextEditorRibbonTab
		'---------------------------------------------------------------------------
		#Region "** constants"

		Const INDENT As Integer = 50
		' 50 pixels indent per click on indent buttons
		#End Region

		'---------------------------------------------------------------------------
		#Region "** create tab"

		Public Sub New()
			Me.ID = InlineAssignHelper(Me.Text, "Home")
			Groups.Add(CreateClipboardGroup())
			Groups.Add(CreateFontGroup())
			Groups.Add(CreateParagraphGroup())
            Groups.Add(CreateEditingGroup())
		End Sub

		Private Function CreateClipboardGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Clipboard")

			' big paste
			g.Items.Add(CreateSplitButton("Paste", CreateButton("PasteText", "Paste"), CreateButton("PasteSpecial", "Paste")))
			g.Items.Add(CreateButton("Cut"))
			g.Items.Add(CreateButton("Copy"))

			Return g
		End Function

		Private Function CreateFontGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Font")
			g.HasLauncherButton = True

			Dim tb As RibbonToolBar = New RibbonToolBar()
			g.Items.Add(tb)
			Dim cmb As RibbonComboBox = New RibbonComboBox()
			SetItemProperties(cmb, "FontFace")
			cmb.TextAreaWidth = 120
			Using bmp As Bitmap = New Bitmap(1, 1)
				Using gg As Graphics = Graphics.FromImage(bmp)
					For Each fontFamily__1 As FontFamily In FontFamily.GetFamilies(gg)
						cmb.Items.Add(New RibbonButton(fontFamily__1.Name))
					Next
				End Using
			End Using
			tb.Items.Add(cmb)

			cmb = New RibbonComboBox()
			SetItemProperties(cmb, "FontSize")
			cmb.TextAreaWidth = 30
			For Each size As Integer In New Integer() {8, 9, 10, 11, 12, 14, _
				16, 18, 20, 22, 24, 26, _
				28, 36, 48, 72}
				cmb.Items.Add(New RibbonButton(size.ToString()))
			Next
			tb.Items.Add(cmb)

			tb.Items.Add(New RibbonSeparator())
			tb.Items.Add(CreateToggleButton("IncreaseFontSize"))
			tb.Items.Add(CreateToggleButton("DecreaseFontSize"))

			tb.Items.Add(New RibbonSeparator())
			tb.Items.Add(CreateButton("ClearFormatting"))

			tb = New RibbonToolBar()
			g.Items.Add(tb)
			tb.Items.Add(CreateToggleButton("Bold"))
			tb.Items.Add(CreateToggleButton("Italic"))
			tb.Items.Add(CreateToggleButton("Underline"))
			tb.Items.Add(CreateToggleButton("Strikethrough"))
			tb.Items.Add(CreateToggleButton("Subscript"))
			tb.Items.Add(CreateToggleButton("Superscript"))
			tb.Items.Add(CreateMenu("ChangeCase", CreateButton("LowerCase"), CreateButton("UpperCase"), CreateButton("CapitalizeCase")))

			tb.Items.Add(New RibbonSeparator())

			Dim cp As RibbonColorPicker = New RibbonColorPicker()
			SetItemProperties(cp, "HighlightColor")
			cp.Color = System.Drawing.Color.Yellow
			tb.Items.Add(cp)

			cp = New RibbonColorPicker()
			SetItemProperties(cp, "FontColor")
			cp.Color = System.Drawing.Color.Red
			tb.Items.Add(cp)

			Return g
		End Function

		Private Function CreateParagraphGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Paragraph")
			g.HasLauncherButton = True

			Dim tb As RibbonToolBar = New RibbonToolBar()
			g.Items.Add(tb)

			Dim tg As RibbonToggleGroup = New RibbonToggleGroup()
			tg.Items.Add(CreateToggleButton("Bullets"))
			tg.Items.Add(CreateToggleButton("Numbering"))
            tb.Items.Add(tg)

            tb.Items.Add(New RibbonSeparator())
            tb.Items.Add(CreateButton("DecreaseIndent"))
            tb.Items.Add(CreateButton("IncreaseIndent"))

            tb.Items.Add(New RibbonSeparator())
            tb.Items.Add(CreateMenu("LineSpacing", "1.0", "1.15", "1.5", "2.0", "2.5", "3.0"))

            tb = New RibbonToolBar()
			g.Items.Add(tb)

			tg = New RibbonToggleGroup()
			tg.Items.Add(CreateToggleButton("AlignLeft"))
			tg.Items.Add(CreateToggleButton("Center"))
			tg.Items.Add(CreateToggleButton("AlignRight"))
			tg.Items.Add(CreateToggleButton("Justify"))
			tb.Items.Add(tg)

			tb.Items.Add(New RibbonSeparator())
			Dim cp As RibbonColorPicker = New RibbonColorPicker()
			SetItemProperties(cp, "BackgroundColor")
            cp.Color = System.Drawing.Color.Yellow
			tb.Items.Add(cp)

            Return g
		End Function

		Private Function CreateStylesGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Styles")
			g.HasLauncherButton = True
			Return g
		End Function

		Private Function CreateEditingGroup() As RibbonGroup
			Dim g As RibbonGroup = New RibbonGroup()
			g.Text = InlineAssignHelper(g.ID, "Editing")
            g.Items.Add(CreateSplitButton("Find", CreateButton("FindText", "Find")))
			g.Items.Add(CreateButton("Replace"))
            g.Items.Add(CreateMenu("Select", "SelectAll"))

			Return g
		End Function

		#End Region

		'---------------------------------------------------------------------------
		#Region "** update UI"

		Protected Overloads Overrides Sub OnSelect(e As EventArgs)
			MyBase.OnSelect(e)
			UpdateUI()
		End Sub

        Friend Overloads Overrides Sub UpdateUI()
            If Editor Is Nothing Then
                Exit Sub
            End If
            ' clipboard
            GetItemByID("Cut").Enabled = Editor.CanCut
            GetItemByID("Copy").Enabled = Editor.CanCopy
            GetItemByID("Paste").Enabled = Editor.CanPaste
            GetItemByID("PasteText").Enabled = Editor.CanPasteAsText

            ' font
            Dim bb As RibbonToggleButton = DirectCast(GetItemByID("Bold"), RibbonToggleButton)
            Dim bi As RibbonToggleButton = DirectCast(GetItemByID("Italic"), RibbonToggleButton)
            Dim bu As RibbonToggleButton = DirectCast(GetItemByID("Underline"), RibbonToggleButton)
            Dim bs As RibbonToggleButton = DirectCast(GetItemByID("Strikethrough"), RibbonToggleButton)
            Dim ff As RibbonComboBox = DirectCast(GetItemByID("FontFace"), RibbonComboBox)
            Dim fs As RibbonComboBox = DirectCast(GetItemByID("FontSize"), RibbonComboBox)
            Dim big As RibbonToggleButton = DirectCast(GetItemByID("IncreaseFontSize"), RibbonToggleButton)
            Dim small As RibbonToggleButton = DirectCast(GetItemByID("DecreaseFontSize"), RibbonToggleButton)
            bb.Pressed = Editor.SelectionFontBold
            bi.Pressed = Editor.SelectionFontItalic
            bu.Pressed = Editor.SelectionFontUnderline
            bs.Pressed = Editor.SelectionFontStrikethrough
            big.Pressed = Editor.SelectionFontBig
            small.Pressed = Editor.SelectionFontSmall
            ff.Text = Editor.SelectionFontName
            fs.Text = Editor.SelectionFontSize

            DirectCast(GetItemByID("Subscript"), RibbonToggleButton).Pressed = Editor.SelectionSubscript
            DirectCast(GetItemByID("Superscript"), RibbonToggleButton).Pressed = Editor.SelectionSuperscript

            Dim cp As RibbonColorPicker = DirectCast(GetItemByID("FontColor"), RibbonColorPicker)
            If Editor.SelectionColor <> System.Drawing.Color.Empty Then
                cp.Color = Editor.SelectionColor
            End If
            cp = DirectCast(GetItemByID("HighlightColor"), RibbonColorPicker)
            If Editor.SelectionBackColor <> System.Drawing.Color.Empty Then
                cp.Color = Editor.SelectionBackColor
            End If
            cp = DirectCast(GetItemByID("BackgroundColor"), RibbonColorPicker)
            If Editor.SelectionParagraphColor <> System.Drawing.Color.Empty Then
                cp.Color = Editor.SelectionParagraphColor
            End If

            ' paragraph
            DirectCast(GetItemByID("AlignLeft"), RibbonToggleButton).Pressed = False
            DirectCast(GetItemByID("Center"), RibbonToggleButton).Pressed = False
            DirectCast(GetItemByID("AlignRight"), RibbonToggleButton).Pressed = False
            DirectCast(GetItemByID("Justify"), RibbonToggleButton).Pressed = False
            Select Case Editor.SelectionAlignment
                Case TextAlignment.Left
                    DirectCast(GetItemByID("AlignLeft"), RibbonToggleButton).Pressed = True
                    Exit Select
                Case TextAlignment.Center
                    DirectCast(GetItemByID("Center"), RibbonToggleButton).Pressed = True
                    Exit Select
                Case TextAlignment.Right
                    DirectCast(GetItemByID("AlignRight"), RibbonToggleButton).Pressed = True
                    Exit Select
                Case TextAlignment.Justify
                    DirectCast(GetItemByID("Justify"), RibbonToggleButton).Pressed = True
                    Exit Select
            End Select

            Dim list As List = Editor.Editor.Selection.List
            Dim isSelectionInsideList As Boolean = Editor.IsSelectionInsideList()
            If Not isSelectionInsideList Then
                GetItemByID("IncreaseIndent").Enabled = True
                GetItemByID("DecreaseIndent").Enabled = True
            Else
                GetItemByID("IncreaseIndent").Enabled = list.CanExecute(list.Action.IncreaseLevel)
                GetItemByID("DecreaseIndent").Enabled = list.CanExecute(list.Action.DecreaseLevel)
            End If
            DirectCast(GetItemByID("Bullets"), RibbonToggleButton).Pressed = list.Type = list.ListType.Bulleted
            DirectCast(GetItemByID("Numbering"), RibbonToggleButton).Pressed = list.Type = list.ListType.Numbered
        End Sub

		#End Region

		'---------------------------------------------------------------------------
		#Region "** handle commands"

		Friend Overloads Overrides Sub HandleItemEvent(e As RibbonEventArgs)
			Dim ed As C1RibbonEditorXhtml = Editor
            Dim item As RibbonItem = DirectCast(e.Item, RibbonItem)
            Dim list As List = ed.Editor.Selection.List

			If e.EventType = RibbonEventType.Click Then
				Select Case item.ID
					' find/replace
					Case "Find"
						ed.Find()
						Exit Select
					Case "Replace"
						ed.FindAndReplace()
						Exit Select

					' clibpboard
					Case "Cut"
						ed.Cut()
						Exit Select
					Case "Copy"
						ed.Copy()
						Exit Select
					Case "Paste"
						ed.Paste(False)
						Exit Select
					Case "PasteText"
						ed.Paste(True)
						Exit Select
					Case "PasteSpecial"
						ed.Paste(True)
						Exit Select

					' font
					Case "Bold"
						ed.SelectionFontBold = DirectCast(item, RibbonToggleButton).Pressed
						Exit Select
					Case "Italic"
						ed.SelectionFontItalic = DirectCast(item, RibbonToggleButton).Pressed
						Exit Select
					Case "Underline"
						ed.SelectionFontUnderline = DirectCast(item, RibbonToggleButton).Pressed
						Exit Select
					Case "Strikethrough"
						ed.SelectionFontStrikethrough = DirectCast(item, RibbonToggleButton).Pressed
						Exit Select
					Case "IncreaseFontSize"
						ed.SelectionFontBig = DirectCast(item, RibbonToggleButton).Pressed
						Exit Select
					Case "DecreaseFontSize"
						ed.SelectionFontSmall = DirectCast(item, RibbonToggleButton).Pressed
						Exit Select
					Case "Subscript"
						Editor.SelectionSubscript = DirectCast(item, RibbonToggleButton).Pressed
						UpdateUI()
						Exit Select
					Case "Superscript"
						Editor.SelectionSuperscript = DirectCast(item, RibbonToggleButton).Pressed
						UpdateUI()
						Exit Select

					'color
					Case "FontColor"
						Editor.SelectionColor = DirectCast(item, RibbonColorPicker).Color
						Exit Select
					Case "HighlightColor"
						Editor.SelectionBackColor = DirectCast(item, RibbonColorPicker).Color
						Exit Select
					Case "BackgroundColor"
						Editor.SelectionParagraphColor = DirectCast(item, RibbonColorPicker).Color
						Exit Select

					' paragraph
					Case "AlignLeft"
						ed.SelectionAlignment = TextAlignment.Left
						Exit Select
					Case "Center"
						ed.SelectionAlignment = TextAlignment.Center
						Exit Select
					Case "AlignRight"
						ed.SelectionAlignment = TextAlignment.Right
						Exit Select
					Case "Justify"
						ed.SelectionAlignment = TextAlignment.Justify
						Exit Select
                    Case "Bullets"
                        If DirectCast(item, RibbonToggleButton).Pressed Then
                            list.Type = list.ListType.Bulleted
                        Else
                            list.Type = list.ListType.None
                        End If
                        Exit Select
                    Case "Numbering", "MultiLevel"
                        If DirectCast(item, RibbonToggleButton).Pressed Then
                            list.Type = list.ListType.Numbered
                        Else
                            list.Type = list.ListType.None
                        End If
                        Exit Select
                    Case "IncreaseIndent"
                        If ed.IsSelectionInsideList() Then
                            list.Execute(list.Action.IncreaseLevel)
                        Else
                            ed.IncreaseIndent()
                        End If

                        Exit Select
                    Case "DecreaseIndent"
                        If ed.IsSelectionInsideList() Then
                            list.Execute(list.Action.DecreaseLevel)
                        Else
                            ed.DecreaseIndent()
                        End If

                        Exit Select

                        ' clear formatting
                    Case "ClearFormatting"
                        ed.ClearFontFormatting()
                        ed.SelectionColor = System.Drawing.Color.Empty
                        ed.SelectionBackColor = System.Drawing.Color.Empty
                        ed.SelectionParagraphColor = System.Drawing.Color.Empty
                        UpdateUI()
                        Exit Select
                    Case "SelectAll"
                        ed.[Select](0, Integer.MaxValue)
                        UpdateUI()
                        Exit Select

                        ' character casing
                    Case "LowerCase"
                        ed.SelectionChangeCase(CharCasing.LowerCase)
                        Exit Select
                    Case "UpperCase"
                        ed.SelectionChangeCase(CharCasing.UpperCase)
                        Exit Select
                    Case "CapitalizeCase"
                        ed.SelectionChangeCase(CharCasing.CapitalizeWords)
                        Exit Select
                    Case Else

                        If item.Parent.Equals(GetItemByID("LineSpacing")) Then
                            Dim spacing As Single
                            Dim text As String = DirectCast(item, RibbonButton).Text
                            text = text.Replace(".", System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)
                            If Single.TryParse(text, spacing) Then
                                ed.SelectionLineSpacing = spacing
                            End If
                        ElseIf item.Parent.Equals(GetItemByID("FontColor")) Then
                            ed.SelectionColor = DirectCast(item.Parent, RibbonColorPicker).Color

                        ElseIf item.Parent.Equals(GetItemByID("HighlightColor")) Then
                            ed.SelectionBackColor = DirectCast(item.Parent, RibbonColorPicker).Color

                        ElseIf item.Parent.Equals(GetItemByID("BackgroundColor")) Then
                            ed.SelectionParagraphColor = DirectCast(item.Parent, RibbonColorPicker).Color

                        End If
                        Exit Select
                End Select
			ElseIf e.EventType = RibbonEventType.ChangeCommitted Then
				Select Case item.ID
					' font
					Case "FontFace"
						ed.SelectionFontName = (DirectCast(item, RibbonComboBox).Text)
						Exit Select
					Case "FontSize"
						ed.SelectionFontSize = (DirectCast(item, RibbonComboBox).Text)
						Exit Select
				End Select
			End If
		End Sub
		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

		#End Region
	End Class
End Namespace
