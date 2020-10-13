Imports System.Collections.Generic

Public Class Data
    Public Shared Function GetData() As List(Of Hyperlink)
        Dim data = New List(Of Hyperlink)()

        data.Add(New Hyperlink())
        data(0).Title = "Overview"
        data(0).Url = "http://helpcentral.componentone.com/nethelp/treeviewwin/TreeViewforWinFormsOverview.html"

        data(0).Hyperlinks.Add(New Hyperlink())
        data(0).Hyperlinks(0).Title = "Getting Started with WinForms Edition"
        data(0).Hyperlinks(0).Url = "http://helpcentral.componentone.com/nethelp/treeviewwin/GettingStartedwithWinFormsEdition.html"

        data.Add(New Hyperlink())
        data(1).Title = "Quick Start"
        data(1).Url = "http://helpcentral.componentone.com/nethelp/treeviewwin/TreeViewQuickStart.html"

        data(1).Hyperlinks.Add(New Hyperlink())
        data(1).Hyperlinks(0).Title = "Step 1: Adding TreeView to the Application"
        data(1).Hyperlinks(0).Url = "http://helpcentral.componentone.com/nethelp/treeviewwin/AddingTreeViewtotheApplication.html"

        data(1).Hyperlinks.Add(New Hyperlink())
        data(1).Hyperlinks(1).Title = "Step 2: Creating Nodes in TreeView"
        data(1).Hyperlinks(1).Url = "http://helpcentral.componentone.com/nethelp/treeviewwin/CreatingNodesinTreeView.html"

        data(1).Hyperlinks.Add(New Hyperlink())
        data(1).Hyperlinks(2).Title = "Step 3: Running the Application"
        data(1).Hyperlinks(2).Url = "http://helpcentral.componentone.com/nethelp/treeviewwin/RunningtheApplication.html"

        data.Add(New Hyperlink())
        data(2).Title = "Design-Time Support"
        data(2).Url = "http://helpcentral.componentone.com/nethelp/treeviewwin/DesignTimeSupport.html"

        data(2).Hyperlinks.Add(New Hyperlink())
        data(2).Hyperlinks(0).Title = "Collection Editors"
        data(2).Hyperlinks(0).Url = "http://helpcentral.componentone.com/nethelp/treeviewwin/CollectionEditors.html"

        data.Add(New Hyperlink())
        data(3).Title = "Structure and Elements"
        data(3).Url = "http://helpcentral.componentone.com/nethelp/treeviewwin/TreeViewStructureandElements.html"

        Return data
    End Function
End Class

Public Class Hyperlink
        Public Property Title() As String
            Get
                Return m_Title
            End Get
            Set
                m_Title = Value
            End Set
        End Property
        Private m_Title As String
        Public Property Url() As String
            Get
                Return m_Url
            End Get
            Set
                m_Url = Value
            End Set
        End Property
        Private m_Url As String
        Public Property Hyperlinks() As List(Of Hyperlink)
            Get
                Return m_Hyperlinks
            End Get
            Set
                m_Hyperlinks = Value
            End Set
        End Property
        Private m_Hyperlinks As List(Of Hyperlink)

        Public Sub New()
            Hyperlinks = New List(Of Hyperlink)()
        End Sub
    End Class
