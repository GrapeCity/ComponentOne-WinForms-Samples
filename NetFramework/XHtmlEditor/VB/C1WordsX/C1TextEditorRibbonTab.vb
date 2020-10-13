Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon
Imports C1.Win.C1SpellChecker
Imports Resources = C1Words.Resources

Namespace C1WordsX
	Class C1TextEditorRibbonTab
		Inherits C1.Win.C1Ribbon.RibbonTab
		'------------------------------------------------------------
#Region "** command dispatcher"

        ' update UI (button state, etc)
        Friend Overridable Sub UpdateUI()
        End Sub

        Friend Overridable Sub HandleItemEvent(ByVal e As RibbonEventArgs)
        End Sub

#End Region



        '------------------------------------------------------------
#Region "** object model"

        Friend Overridable Sub InitTab()
        End Sub

        ' gets an item by ID
        Friend Function GetItemByID(ByVal id As String) As RibbonItem
            Return DirectCast(Ribbon.GetItemByID(id), RibbonItem)
        End Function

        ' gets the parent ribbon
        Public Shadows ReadOnly Property Ribbon() As C1TextEditorRibbon
            Get
                Return DirectCast(MyBase.Ribbon, C1TextEditorRibbon)
            End Get
        End Property

        ' gets the current editor
        Friend ReadOnly Property Editor() As C1RibbonEditorXhtml
            Get
                Return Ribbon.Editor
            End Get
        End Property

        ' gets the current spell-checker
        Friend ReadOnly Property SpellChecker() As C1SpellChecker
            Get
                Return Ribbon.SpellChecker
            End Get
        End Property

        ' Creates a RibbonListItem and initializes it using a unique ID string.
        Friend Shared Function CreateHeader(ByVal id As String) As RibbonListItem
            Dim text As String = DirectCast(Resources.ResourceManager.GetObject(id & "_hdr", Resources.Culture), String)
            Dim label As RibbonLabel = New RibbonLabel(text)
            Dim header As RibbonListItem = New RibbonListItem(label)
            header.AllowSelection = False
            Return header
        End Function

        ' Creates a RibbonLabel and initializes it using a unique ID string.
        Friend Shared Function CreateHeaderLabel(ByVal id As String) As RibbonLabel
            Dim text As String = DirectCast(Resources.ResourceManager.GetObject(id & "_hdr", Resources.Culture), String)
            Return New RibbonLabel(text)
        End Function

        ' creates a RibbonButton and initializes it using a unique ID string.
        ' the ID string is used to set the button's ID and also to look up
        ' text and image resources that specify the button properties.
        Friend Shared Function CreateButton(ByVal id As String) As RibbonButton
            Return CreateButton(id, id)
        End Function

        ' creates a RibbonButton and initializes it using a unique ID string
        ' and an imageID string.
        ' the imageID string allows sharing image resources among multiple
        ' ribbon elements.
        Friend Shared Function CreateButton(ByVal id As String, ByVal imageID As String) As RibbonButton
            Dim btn As RibbonButton = New RibbonButton()
            SetItemProperties(btn, id, imageID)
            Return btn
        End Function

        ' creates a RibbonToggleButton and initializes it using a unique ID string.
        Friend Shared Function CreateToggleButton(ByVal id As String) As RibbonToggleButton
            Return CreateToggleButton(id, id)
        End Function

        ' creates a RibbonToggleButton and initializes it using a unique ID string
        ' and an imageID string.
        Friend Shared Function CreateToggleButton(ByVal id As String, ByVal imageID As String) As RibbonToggleButton
            Dim btn As RibbonToggleButton = New RibbonToggleButton()
            SetItemProperties(btn, id, imageID)
            Return btn
        End Function

        ' creates a RibbonMenu and initializes it using a unique ID string and
        ' a list of items that may contain strings or RibbonElement objects.
        Friend Shared Function CreateMenu(ByVal id As String, ByVal ParamArray items As Object()) As RibbonMenu
            Dim menu As RibbonMenu = New RibbonMenu()
            SetItemProperties(menu, id)
            AddSubItems(menu.Items, items)
            Return menu
        End Function

        ' creates a RibbonSplitButton and initializes it using a unique ID string and
        ' a list of items that may contain strings or RibbonElement objects.
        Friend Shared Function CreateSplitButton(ByVal id As String, ByVal ParamArray items As Object()) As RibbonSplitButton
            Dim split As RibbonSplitButton = New RibbonSplitButton()
            SetItemProperties(split, id)
            AddSubItems(split.Items, items)
            Return split
        End Function

        ' sets several properties on a RibbonItem object based on an ID string that
        ' identifies text and image resources.
        Friend Shared Sub SetItemProperties(ByVal item As RibbonItem, ByVal id As String)
            SetItemProperties(item, id, id)
        End Sub

        ' sets several properties on a RibbonItem object based on an ID string that
        ' identifies text resources and on an imageID string that identifies image
        ' resources.
        Friend Shared Sub SetItemProperties(ByVal item As RibbonItem, ByVal id As String, ByVal imageID As String)

            ' set ID
            item.ID = id

            ' text resources
            Dim res As String = DirectCast(Resources.ResourceManager.GetObject(id & "_txt"), String)
            Dim textParts As String()
            If res IsNot Nothing Then
                textParts = res.Split(ControlChars.Lf)
            Else
                textParts = New String() {id}
            End If
            ' 0 : text
            ' 1 : tooltip title + shortcut
            ' 2 : tooltip body

            ' Text
            Dim text As String = textParts(0).Trim()
            If Not String.IsNullOrEmpty(text) Then
                Dim pi As System.Reflection.PropertyInfo = item.[GetType]().GetProperty("Text")
                If pi IsNot Nothing Then
                    pi.SetValue(item, textParts(0), Nothing)
                End If
            End If

            ' ToolTip: text and body
            If textParts.Length > 1 Then
                ' Description: starts with '*'
                If textParts(1).StartsWith("*") Then
                    item.Description = textParts(1).Substring(1).Trim()
                Else
                    Dim tipTitle As String = textParts(1).Trim()
                    Dim tipBody As String = String.Join("<br/>", textParts, 2, textParts.Length - 2).Trim()
                    item.ToolTip = Util.IIFS(String.IsNullOrEmpty(tipBody), tipTitle, String.Format("<b>{0}</b><br/>" & "<div style='margin-left:12'>{1}</div>", tipTitle, tipBody))

                    ' Shortcut
                    Dim start As Integer = tipTitle.IndexOf("("c)
                    Dim [end] As Integer = tipTitle.LastIndexOf(")"c)
                    If start > -1 AndAlso [end] > -1 Then
                        Dim pi As System.Reflection.PropertyInfo = item.[GetType]().GetProperty("ShortcutKeys")
                        If pi IsNot Nothing Then
                            Dim shortCutString As String = tipTitle.Substring(start, [end] - start + 1)
                            pi.SetValue(item, ParseShortcut(shortCutString), Nothing)
                        End If
                    End If
                End If
            End If

            ' image resources
            item.LargeImage = DirectCast(Resources.ResourceManager.GetObject(imageID & "_large", Resources.Culture), Image)
            item.SmallImage = DirectCast(Resources.ResourceManager.GetObject(imageID & "_small", Resources.Culture), Image)

        End Sub

#End Region

        '------------------------------------------------------------
#Region "** implementation"

        ' parses a string such as "(Shift + Ctrl + A)" and returns a 
        ' Keys value that represents the shortcut.
        Private Shared Function ParseShortcut(ByVal text As String) As Keys
            Dim shortCut As Keys = Keys.None

            ' remove brackets
            If text.StartsWith("(") AndAlso text.EndsWith(")") Then
                text = text.Substring(1, text.Length - 2)
            End If

            ' parse modifiers
            If text.IndexOf("alt", StringComparison.OrdinalIgnoreCase) > -1 Then
                shortCut = shortCut Or Keys.Alt
            End If
            If text.IndexOf("ctrl", StringComparison.OrdinalIgnoreCase) > -1 Then
                shortCut = shortCut Or Keys.Control
            End If
            If text.IndexOf("shift", StringComparison.OrdinalIgnoreCase) > -1 Then
                shortCut = shortCut Or Keys.Shift
            End If

            ' parse key
            Dim pos As Integer = text.LastIndexOf(" "c)
            Dim actual As String
            If pos < 0 Then
                actual = [text]
            Else
                actual = [text].Substring(pos + 1)
            End If

            If ([Enum].IsDefined(GetType(Keys), actual)) Then
                shortCut = (shortCut Or DirectCast([Enum].Parse(GetType(Keys), actual), Keys))
            Else
                shortCut = Keys.None
            End If

            ' done
            Return shortCut
        End Function

        ' adds a list of items to a RibbonItemCollection. 
        ' items must be strings or RibbonItem objects.
        Private Shared Sub AddSubItems(ByVal ric As RibbonItemCollection, ByVal items As Object())
            For Each item As Object In items
                ' convert text into buttons
                Dim text As String = TryCast(item, String)
                If text IsNot Nothing Then
                    ric.Add(CreateButton(text))
                    Continue For
                End If

                ' paste items
                Dim ribbonItem As RibbonItem = TryCast(item, RibbonItem)
                If ribbonItem IsNot Nothing Then
                    ric.Add(ribbonItem)
                    Continue For
                End If

                ' oops
                Debug.Assert(False, "AddSubItems expected string or RibbonItem")
            Next
        End Sub

#End Region
    End Class
End Namespace
