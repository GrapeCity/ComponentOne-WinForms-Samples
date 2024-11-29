Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports C1.Win.C1DynamicHelp
Imports System.Windows.Forms
Imports C1.Win.Ribbon

Namespace UsingUIElementResolver
    ' This class provides methods to find UI elements inside a control by name, coordinates, etc, 
    ' and other methods necessary for associating dynamic help to UI elements inside a control.
    Friend Class CustomUIElementResolver
        Inherits C1.Win.C1DynamicHelp.UIElementResolver
        Protected Overrides Function ActivateUIElement(ByVal uiElement As Object) As Boolean
            Dim handled As Boolean = False
            ' check whether the uiElement should be handled here; 
            ' otherwise it can be passed to the C1DynamicHelp control to be activated automatically
            If TypeOf uiElement Is RibbonItem Then
                Dim ribItem As RibbonItem = CType(uiElement, RibbonItem)
                AddHandler ribItem.Ribbon.RibbonEvent, AddressOf rib_RibbonEvent
                handled = True
            ElseIf TypeOf uiElement Is RibbonGroup Then
                Dim ribGroup As RibbonGroup = CType(uiElement, RibbonGroup)
                AddHandler ribGroup.Ribbon.RibbonEvent, AddressOf rib_RibbonEvent
                handled = True
            ElseIf TypeOf uiElement Is RibbonTab Then
                Dim ribTab As RibbonTab = CType(uiElement, RibbonTab)
                AddHandler ribTab.Ribbon.RibbonEvent, AddressOf rib_RibbonEvent
                handled = True
            End If
            If handled Then
                ' the uiElement has been activated, so we have no need to pass it to the C1DynamicHelp control
                Return True
            End If
            ' pass the uiElement to the C1DynamicHelp control to be activated
            Return MyBase.ActivateUIElement(uiElement)
        End Function

        Protected Overrides Function FindUIElement(ByVal parent As Object, ByVal name As String) As Object
            ' try to find a child UI element by its name inside the parent
            Dim child As Object = C1RibbonHelper.FindUIElement(parent, name)

            ' if a child UI element with the specified name was found, return it
            If child IsNot Nothing Then
                Return child
            End If

            ' child UI element was not found inside the parent
            Return MyBase.FindUIElement(parent, name)
        End Function

        Protected Overrides Function GetUIElementAtPoint(ByVal parent As Object, ByVal pt As System.Drawing.Point) As Object
            ' try to find a child UI element by its coordinates inside the parent
            Dim child As Object = C1RibbonHelper.GetChildAtPoint(parent, pt)

            ' if a child UI element at the specified point was found, return it
            If child IsNot Nothing Then
                Return child
            End If

            ' child UI element was not found inside the parent
            Return MyBase.GetUIElementAtPoint(parent, pt)
        End Function

        Protected Overrides Function GetUIElementInfo(ByVal uiElement As Object) As C1.Win.C1DynamicHelp.UIElementInfo
            ' Try to get Parent and Name for the specified uiElement.
            ' These properties should be stored in UIElementInfo object
            Dim info As UIElementInfo = C1RibbonHelper.ResolveControl(uiElement)

            ' if we were able to get the uiElement's parent and name, return them in a UIElementInfo object.
            If info IsNot Nothing Then
                Return info
            End If

            ' uiElement wasn't handled here, so it should be processed by the C1DynamicHelp control automatically
            Return MyBase.GetUIElementInfo(uiElement)
        End Function

        ' handles Ribbon item events to show topic in C1DynamicHelp
        Private Sub rib_RibbonEvent(ByVal sender As Object, ByVal e As RibbonEventArgs)
            Select Case e.EventType
                Case RibbonEventType.LostFocus, RibbonEventType.DeselectTab
                    ' notify the C1DynamicHelp control that the Leave event occurred for e.Item,
                    ' so a new help topic may need to be displayed
                    Me.HandleUIElementEvent(e.Item, UIElementEvents.Leave)
                Case RibbonEventType.GotFocus, RibbonEventType.SelectTab
                    ' notify the C1DynamicHelp control that the Enter event occurred for e.Item, 
                    ' so a new help topic may need to be displayed
                    Me.HandleUIElementEvent(e.Item, UIElementEvents.Enter)
            End Select
        End Sub
    End Class
End Namespace
