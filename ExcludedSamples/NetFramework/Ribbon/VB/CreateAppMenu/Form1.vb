Imports C1.Win.C1Ribbon

Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CreateAppMenu()
        CreateHomeTab()
    End Sub

    Private Sub CreateAppMenu()
        ' **** create the Application menu buttons
        C1Ribbon1.ApplicationMenu.BottomPaneItems.Add(New RibbonButton("Options"))
        C1Ribbon1.ApplicationMenu.BottomPaneItems.Add(New RibbonButton("Exit"))

        ' *** create the controls for the left pane
        C1Ribbon1.ApplicationMenu.LeftPaneItems.Add(New RibbonButton("&New"))
        C1Ribbon1.ApplicationMenu.LeftPaneItems.Add(New RibbonButton("&Open"))
        C1Ribbon1.ApplicationMenu.LeftPaneItems.Add(New RibbonButton("&Save"))

        Dim split As RibbonSplitButton = New RibbonSplitButton("Save &As")
        C1Ribbon1.ApplicationMenu.LeftPaneItems.Add(split)
        split.Items.Add(New RibbonButton("Word Document"))
        split.Items.Add(New RibbonButton("D2H project file"))

        C1Ribbon1.ApplicationMenu.LeftPaneItems.Add(New RibbonSeparator())
        C1Ribbon1.ApplicationMenu.LeftPaneItems.Add(New RibbonButton("&Print"))

        CreateRecentDocumentList()
    End Sub

    Private Sub CreateRecentDocumentList()

        ' **** create the recently used document list (controls in the right pane)

        ' first create a header and make sure it's not selectable
        Dim listItem As RibbonListItem = New RibbonListItem(New RibbonLabel("Recent Documents"))
        listItem.AllowSelection = False
        C1Ribbon1.ApplicationMenu.RightPaneItems.Add(listItem)
        C1Ribbon1.ApplicationMenu.RightPaneItems.Add(New RibbonListItem(New RibbonSeparator()))

        ' create the recently used document list
        Dim recentDocuments() As String = {"Document 1", "Document 2", "Document 3"}
        Dim documentName As String

        For Each documentName In recentDocuments
            ' each item consists of the name of the document and a push pin
            listItem = New RibbonListItem()
            listItem.Items.Add(New RibbonLabel(documentName))

            ' allow the button to be selectable so we can toggle it
            Dim pin As RibbonToggleButton = New RibbonToggleButton()
            pin.SmallImage = My.Resources.unpinned
            pin.AllowSelection = True
            listItem.Items.Add(pin)
            AddHandler pin.Click, AddressOf pinButton_Click

            C1Ribbon1.ApplicationMenu.RightPaneItems.Add(listItem)
        Next
    End Sub

    Private Sub pinButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim pin As RibbonToggleButton = CType(sender, RibbonToggleButton)
        If pin.Pressed Then
            pin.SmallImage = My.Resources.pinned
        Else
            pin.SmallImage = My.Resources.unpinned
        End If
    End Sub

    Private Sub CreateHomeTab()
        C1Ribbon1.Tabs.Clear()

        Dim homeTab As RibbonTab = New RibbonTab("Home")
        Dim clipboardGroup As RibbonGroup = New RibbonGroup("Clipboard")
        Dim pasteButton As RibbonButton = New RibbonButton("Paste", Nothing, My.Resources.Paste)
        pasteButton.TextImageRelation = TextImageRelation.ImageAboveText

        clipboardGroup.Items.Add(pasteButton)
        homeTab.Groups.Add(clipboardGroup)
        C1Ribbon1.Tabs.Add(homeTab)
    End Sub

End Class
