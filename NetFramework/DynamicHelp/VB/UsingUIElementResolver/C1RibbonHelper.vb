Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports C1.Win.C1DynamicHelp
Imports C1.Win.C1Ribbon
Imports System.Drawing
Imports System.Windows.Forms

Namespace UsingUIElementResolver
    Friend NotInheritable Class C1RibbonHelper
        Private Sub New()
        End Sub
        Friend Shared Function ResolveControl(ByVal uiElement As Object) As UIElementInfo
            ' initialize UIElementInfo object with the uiElement
            Dim info As New C1.Win.C1DynamicHelp.UIElementInfo(uiElement)
            ' check the parent object type whether we need to handle it
            If TypeOf uiElement Is C1.Win.C1Ribbon.RibbonTab Then
                Dim tab As C1.Win.C1Ribbon.RibbonTab = CType(uiElement, C1.Win.C1Ribbon.RibbonTab)
                ' set the Name and Parent properties for the UIElementInfo object
                info.Name = tab.ID
                info.Parent = tab.Ribbon
            ElseIf TypeOf uiElement Is C1.Win.C1Ribbon.RibbonGroup Then
                Dim grp As C1.Win.C1Ribbon.RibbonGroup = CType(uiElement, C1.Win.C1Ribbon.RibbonGroup)
                ' set the Name and Parent properties for the UIElementInfo object
                info.Name = grp.ID
                If (grp.Tab IsNot Nothing) Then
                    info.Parent = grp.Tab
                Else
                    info.Parent = CObj(grp.Ribbon)
                End If
            ElseIf TypeOf uiElement Is C1.Win.C1Ribbon.RibbonItem Then
                Dim item As C1.Win.C1Ribbon.RibbonItem = CType(uiElement, C1.Win.C1Ribbon.RibbonItem)
                ' set the Name property for the UIElementInfo object
                info.Name = item.ID
                ' set the Parent property for the UIElementInfo object
                ' (since a RibbonItem can be inside different parents, we need to consider all cases)
                If item.Parent IsNot Nothing Then
                    info.Parent = item.Parent
                ElseIf item.Tab IsNot Nothing Then
                    info.Parent = item.Tab
                Else
                    info.Parent = item.Ribbon
                End If
            ElseIf TypeOf uiElement Is TextBox Then
                Dim txt As TextBox = CType(uiElement, TextBox)
                ' check if this TextBox is inside a C1Ribbon, 
                ' then we can handle it here, otherwise we should return null to allow the C1DynamicHelp control to process it
                Dim parent As RibbonItem = C1Ribbon.GetHostRibbonItem(txt)
                If parent Is Nothing Then
                    Return Nothing
                End If
                info.Parent = parent
                info.Name = txt.Name
            Else
                ' the uiElement can be handled by the C1DynamicHelp control automatically, so return null
                Return Nothing
            End If

            ' check if the uiElement has a name
            If info.Name = "" Then
                ' if the name is empty, we can use the uiElement's index instead of the name to identify it later inside a parent
                Dim pos As Integer = IndexOf(info)
                If pos <> -1 Then
                    info.Name = pos.ToString()
                End If
            End If

            Return info
        End Function

        Friend Shared Function IndexOf(ByVal info As UIElementInfo) As Integer
            Dim pos As Integer = -1
            Dim parent As Object = info.Parent

            ' try to get the index of info.UIElement
            If TypeOf parent Is RibbonGroup Then
                pos = (CType(parent, RibbonGroup)).Items.IndexOf(TryCast(info.UIElement, RibbonItem))
            ElseIf TypeOf parent Is RibbonTab Then
                pos = (CType(parent, RibbonTab)).Groups.IndexOf(TryCast(info.UIElement, RibbonGroup))
            ElseIf TypeOf parent Is RibbonDropDownBase Then
                If TypeOf parent Is RibbonApplicationMenu Then
                    Dim appMenu As RibbonApplicationMenu = (CType(parent, RibbonApplicationMenu))
                    ' RibbonApplicationMenu has three child collections,
                    ' so we use index range from 0 to 999 for BottomPaneItems,
                    ' index range from 1000 to 1999 for LeftPaneItems, and
                    ' index range starting with 2000 for RightPaneItems
                    pos = appMenu.BottomPaneItems.IndexOf(TryCast(info.UIElement, RibbonItem))
                    If pos < 0 Then
                        pos = appMenu.LeftPaneItems.IndexOf(TryCast(info.UIElement, RibbonItem))
                        If pos >= 0 Then
                            pos += 1000
                        Else
                            pos = appMenu.RightPaneItems.IndexOf(TryCast(info.UIElement, RibbonItem))
                            If pos >= 0 Then
                                pos += 2000
                            End If
                        End If
                    End If
                ElseIf TypeOf parent Is RibbonComboBox Then
                    pos = (CType(parent, RibbonComboBox)).MenuItems.IndexOf(TryCast(info.UIElement, RibbonItem))
                    If pos < 0 Then
                        pos = (CType(parent, RibbonComboBox)).Items.IndexOf(TryCast(info.UIElement, RibbonItem))
                        If pos >= 0 Then
                            pos += 1000
                        End If
                    End If
                ElseIf TypeOf parent Is RibbonGallery Then
                    pos = (CType(parent, RibbonGallery)).MenuItems.IndexOf(TryCast(info.UIElement, RibbonItem))
                    If pos < 0 Then
                        pos = (CType(parent, RibbonGallery)).Items.IndexOf(TryCast(info.UIElement, RibbonItem))
                        If pos >= 0 Then
                            pos += 1000
                        End If
                    End If
                Else
                    pos = (CType(parent, RibbonDropDownBase)).Items.IndexOf(TryCast(info.UIElement, RibbonItem))
                End If
            ElseIf TypeOf parent Is RibbonItemContainer Then
                pos = (CType(parent, RibbonItemContainer)).Items.IndexOf(TryCast(info.UIElement, RibbonItem))
                If TypeOf parent Is RibbonQat AndAlso pos = -1 Then
                    pos = (CType(parent, RibbonQat)).MenuItems.IndexOf(TryCast(info.UIElement, RibbonItem))
                    If pos >= 0 Then
                        pos += 1000
                    End If
                End If
            ElseIf TypeOf parent Is RibbonListItem Then
                pos = (CType(parent, RibbonListItem)).Items.IndexOf(TryCast(info.UIElement, RibbonItem))
            ElseIf TypeOf parent Is C1Ribbon Then
                Dim ribbon As C1Ribbon = CType(parent, C1Ribbon)
                If ribbon.ApplicationMenu.Equals(info.UIElement) Then
                    pos = 0
                ElseIf ribbon.ConfigToolBar.Equals(info.UIElement) Then
                    pos = 1
                ElseIf ribbon.Qat.Equals(info.UIElement) Then
                    pos = 2
                Else
                    pos = ribbon.Tabs.IndexOf(TryCast(info.UIElement, RibbonTab))
                    If pos >= 0 Then
                        pos += 1000
                    End If
                End If
            ElseIf TypeOf parent Is C1StatusBar Then
                Dim bar As C1StatusBar = CType(parent, C1StatusBar)
                pos = bar.LeftPaneItems.IndexOf(TryCast(info.UIElement, RibbonItem))
                If pos < 0 Then
                    pos = bar.RightPaneItems.IndexOf(TryCast(info.UIElement, RibbonItem))
                    If pos >= 0 Then
                        pos += 1000
                    End If
                End If
            End If

            ' if uiElement does not have an index, return -1
            If pos < 0 Then
                pos = -1
            End If
            Return pos
        End Function

        Friend Shared Function FindUIElement(ByVal parent As Object, ByVal name As String) As Object
            Dim pos As Integer
            ' Check if the name contains the UI element's index in the parent children collection instead of its real Name.
            ' This way we handle UI elements whose Name property is not set.
            If (Not Integer.TryParse(name, pos)) Then
                pos = -1
            End If
            Dim child As Object = Nothing

            Try
                ' check the parent object type, whether we need to handle it
                If TypeOf parent Is RibbonGroup Then
                    ' if the name contains an index, try to get the child UI element by that index
                    If pos <> -1 Then
                        child = (CType(parent, RibbonGroup)).Items(pos)
                    ' otherwise, try to get the child UI element by its name
                    Else
                        child = (CType(parent, RibbonGroup)).Items(name)
                    End If
                ElseIf TypeOf parent Is RibbonTab Then
                    If pos <> -1 Then
                        child = (CType(parent, RibbonTab)).Groups(pos)
                    Else
                        child = (CType(parent, RibbonTab)).Groups(name)
                    End If
                ElseIf TypeOf parent Is RibbonDropDownBase Then
                    If TypeOf parent Is RibbonApplicationMenu Then
                        Dim appMenu As RibbonApplicationMenu = (CType(parent, RibbonApplicationMenu))
                        If pos <> -1 Then
                            ' RibbonApplicationMenu has three child collections, 
                            ' so we use index range from 0 to 999 for BottomPaneItems
                            If pos < 1000 Then
                                child = appMenu.BottomPaneItems(pos)
                            ' use index range from 1000 to 1999 for LeftPaneItems
                            ElseIf pos < 2000 Then
                                child = appMenu.LeftPaneItems(pos - 1000)
                            ' use index range starting from 2000 for RightPaneItems
                            Else
                                child = appMenu.RightPaneItems(pos - 2000)
                            End If
                        Else
                            ' RibbonApplicationMenu has three child collections,
                            ' so we look the child UI element up in all of them
                            If appMenu.BottomPaneItems.Contains(name) Then
                                child = appMenu.BottomPaneItems(name)
                            ElseIf appMenu.LeftPaneItems.Contains(name) Then
                                child = appMenu.LeftPaneItems(name)
                            Else
                                child = appMenu.RightPaneItems(name)
                            End If
                        End If
                    ElseIf TypeOf parent Is RibbonComboBox Then
                        If pos <> -1 Then
                            ' RibbonComboBox has two child collections,
                            ' so we use index range from 0 to 999 for MenuItems
                            If pos < 1000 Then
                                child = (CType(parent, RibbonComboBox)).MenuItems(pos)
                            ' use index range starting from 1000 for Items
                            Else
                                child = (CType(parent, RibbonComboBox)).Items(pos - 1000)
                            End If
                        End If
                    ElseIf TypeOf parent Is RibbonGallery Then
                        If pos <> -1 Then
                            If pos < 1000 Then
                                child = (CType(parent, RibbonGallery)).MenuItems(pos)
                            Else
                                child = (CType(parent, RibbonGallery)).Items(pos - 1000)
                            End If
                        End If
                    Else
                        If pos <> -1 Then
                            child = (CType(parent, RibbonDropDownBase)).Items(pos)
                        Else
                            child = (CType(parent, RibbonDropDownBase)).Items(name)
                        End If
                    End If
                ElseIf TypeOf parent Is RibbonItemContainer Then
                    If pos <> -1 Then
                        If pos < 1000 Then
                            child = (CType(parent, RibbonItemContainer)).Items(pos)
                        Else
                            child = (CType(parent, RibbonQat)).MenuItems(pos - 1000)
                        End If
                    Else
                        If (CType(parent, RibbonItemContainer)).Items.Contains(name) Then
                            child = (CType(parent, RibbonItemContainer)).Items(name)
                        Else
                            child = (CType(parent, RibbonQat)).MenuItems(name)
                        End If
                    End If
                ElseIf TypeOf parent Is RibbonListItem Then
                    If pos <> -1 Then
                        child = (CType(parent, RibbonListItem)).Items(pos)
                    Else
                        child = (CType(parent, RibbonListItem)).Items(name)
                    End If
                ElseIf TypeOf parent Is C1Ribbon Then
                    Dim ribbon As C1Ribbon = CType(parent, C1Ribbon)
                    If pos <> -1 Then
                        If pos = 0 Then
                            child = ribbon.ApplicationMenu
                        ElseIf pos = 1 Then
                            child = ribbon.ConfigToolBar
                        ElseIf pos = 2 Then
                            child = ribbon.Qat
                        Else
                            child = ribbon.Tabs(pos - 1000)
                        End If
                    Else
                        child = ribbon.Tabs(name)
                    End If
                ElseIf TypeOf parent Is C1StatusBar Then
                    Dim bar As C1StatusBar = CType(parent, C1StatusBar)
                    If pos <> -1 Then
                        If pos < 1000 Then
                            child = bar.LeftPaneItems(pos)
                        Else
                            child = bar.RightPaneItems(pos - 1000)
                        End If
                    Else
                        child = bar.LeftPaneItems(name)
                        If child Is Nothing Then
                            child = bar.RightPaneItems(name)
                        End If
                    End If
                End If
            ' an exception can occur if parent doesn't contain a child UI element with the specified name,
            ' in that case we return null
            Catch
            End Try
            Return child
        End Function

        Friend Shared Function GetChildAtPoint(ByVal parent As Object, ByVal pt As Point) As Object
            Dim child As Object = Nothing
            ' check the parent object type whether we need to handle it
            If TypeOf parent Is C1Ribbon Then
                Dim ribbon As C1Ribbon = CType(parent, C1Ribbon)
                ' use a method of the C1Ribbon control to get the child at the specified point
                child = ribbon.GetItemAt(ribbon.PointToClient(pt))
            End If
            Return child
        End Function
    End Class
End Namespace
