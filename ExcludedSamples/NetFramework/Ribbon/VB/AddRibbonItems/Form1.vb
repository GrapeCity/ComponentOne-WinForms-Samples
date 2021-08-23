Imports C1.Win.C1Ribbon

Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Create a new instance of C1Ribbon and add it to the form.
        Dim c1Ribbon1 As New C1Ribbon()
        Me.Controls.Add(c1Ribbon1)

        ' Add the Home tab and the Font group.
        Dim homeTab As RibbonTab = c1Ribbon1.Tabs.Add("Home")
        Dim fontGroup As RibbonGroup = homeTab.Groups.Add("Font")

        ' Add a toolbar to arrange the buttons in a row.
        Dim toolBar1 As New RibbonToolBar()
        fontGroup.Items.Add(toolBar1)

        ' Add the Bold, Italic, and Strike Through buttons.
        toolBar1.Items.Add(New RibbonToggleButton(My.Resources.Bold))
        toolBar1.Items.Add(New RibbonToggleButton(My.Resources.Italic))
        toolBar1.Items.Add(New RibbonToggleButton(My.Resources.Strikethrough))

        ' Add a separator to visually separate the button groups.
        toolBar1.Items.Add(New RibbonSeparator())

        ' Add a toggle button group 
        Dim toggleGroup As New RibbonToggleGroup()
        toolBar1.Items.Add(toggleGroup)

        ' Add the Subscript and Superscript buttons to the toggle group.
        ' This makes the buttons behave like radio buttons (pressing one releases all others).
        toggleGroup.Items.Add(New RibbonToggleButton(My.Resources.Subscript))
        toggleGroup.Items.Add(New RibbonToggleButton(My.Resources.Superscript))

        ' Add another toolbar for the second row.
        Dim toolbar2 As New RibbonToolBar()
        fontGroup.Items.Add(toolbar2)

        ' Add a combo box.
        toolbar2.Items.Add(New RibbonComboBox())

    End Sub
End Class
