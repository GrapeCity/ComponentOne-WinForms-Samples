Imports System.Collections.Generic

Public Class Data
    Public Shared Function GetData() As List(Of Hyperlink)
        Dim data = New List(Of Hyperlink)()

        data.Add(New Hyperlink())
        data(0).Title = "Overview"
        data(0).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/overview.html"

        data.Add(New Hyperlink())
        data(1).Title = "Key Features"
        data(1).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/KeyFeatures.html"

        data.Add(New Hyperlink())
        data(2).Title = "Quick Start"
        data(2).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/TreeViewQuickStart.html"

        data.Add(New Hyperlink())
        data(3).Title = "Data Binding"
        data(3).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/DataBinding.html"

        data(3).Hyperlinks.Add(New Hyperlink())
        data(3).Hyperlinks(0).Title = "Binding List"
        data(3).Hyperlinks(0).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/bind-treeview-with-binding-list.html"

        data(3).Hyperlinks.Add(New Hyperlink())
        data(3).Hyperlinks(1).Title = "Self-Referencing"
        data(3).Hyperlinks(1).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/self-referencing.html"

        data(3).Hyperlinks.Add(New Hyperlink())
        data(3).Hyperlinks(2).Title = "DataSet Binding"
        data(3).Hyperlinks(2).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/binding-dataset.html"

        data(3).Hyperlinks.Add(New Hyperlink())
        data(3).Hyperlinks(3).Title = "XML Binding"
        data(3).Hyperlinks(3).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/xml-binding.html"

        data.Add(New Hyperlink())
        data(4).Title = "Node Operations"
        data(4).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/Nodes.html"

        data(4).Hyperlinks.Add(New Hyperlink())
        data(4).Hyperlinks(0).Title = "Add Nodes"
        data(4).Hyperlinks(0).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/add-nodes.html"

        data(4).Hyperlinks.Add(New Hyperlink())
        data(4).Hyperlinks(1).Title = "Remove Nodes"
        data(4).Hyperlinks(1).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/remove-nodes.html"

        data(4).Hyperlinks.Add(New Hyperlink())
        data(4).Hyperlinks(2).Title = "Drag and Drop Nodes"
        data(4).Hyperlinks(2).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/DraggingandDroppingNodes.html"

        data(4).Hyperlinks.Add(New Hyperlink())
        data(4).Hyperlinks(3).Title = "Reorder Nodes"
        data(4).Hyperlinks(3).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/ReorderingNodes.html"

        data(4).Hyperlinks.Add(New Hyperlink())
        data(4).Hyperlinks(4).Title = "Edit Nodes"
        data(4).Hyperlinks(4).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/EditingNodes.html"

        data(4).Hyperlinks.Add(New Hyperlink())
        data(4).Hyperlinks(5).Title = "Select Nodes"
        data(4).Hyperlinks(5).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/SelectingNodes.html"

        data(4).Hyperlinks.Add(New Hyperlink())
        data(4).Hyperlinks(6).Title = "Search Node"
        data(4).Hyperlinks(6).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/searchingnodes.html"

        data(4).Hyperlinks.Add(New Hyperlink())
        data(4).Hyperlinks(7).Title = "Expand and Collapse Nodes"
        data(4).Hyperlinks(7).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/ExpandingandCollapsingNodes.html"

        data(4).Hyperlinks.Add(New Hyperlink())
        data(4).Hyperlinks(8).Title = "Navigate Nodes"
        data(4).Hyperlinks(8).Url = "https://developer.mescius.com/componentone/docs/win/online-treeview/NavigatingNodes.html"

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
