Imports C1.Framework
Imports C1.Win.Ribbon

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
        Dim boldButton As New RibbonToggleButton()
        boldButton.IconSet.Add(New C1BitmapIcon("Bold", New Size(16, 16), Color.Transparent, "Preset_SmallImages", -1))
        toolBar1.Items.Add(boldButton)
        Dim italicButton As New RibbonToggleButton()
        italicButton.IconSet.Add(New C1BitmapIcon("Italic", New Size(16, 16), Color.Transparent, "Preset_SmallImages", -1))
        toolBar1.Items.Add(italicButton)
        Dim strikeButton As New RibbonToggleButton()
        strikeButton.IconSet.Add(New C1BitmapIcon("StrikeThrough", New Size(16, 16), Color.Transparent, "Preset_SmallImages", -1))
        toolBar1.Items.Add(strikeButton)

        ' Add a separator to visually separate the button groups.
        toolBar1.Items.Add(New RibbonSeparator())

        ' Add a toggle button group 
        Dim toggleGroup As New RibbonToggleGroup()
        toolBar1.Items.Add(toggleGroup)

        ' Add the Subscript and Superscript buttons to the toggle group.
        ' This makes the buttons behave like radio buttons (pressing one releases all others).
        Dim subButton As New RibbonToggleButton()
        subButton.IconSet.Add(New C1BitmapIcon("Subscript", New Size(16, 16), Color.Transparent, "Preset_SmallImages", -1))
        toggleGroup.Items.Add(subButton)
        Dim superButton As New RibbonToggleButton()
        superButton.IconSet.Add(New C1BitmapIcon("Superscript", New Size(16, 16), Color.Transparent, "Preset_SmallImages", -1))
        toggleGroup.Items.Add(superButton)

        ' Add another toolbar for the second row.
        Dim toolbar2 As New RibbonToolBar()
        fontGroup.Items.Add(toolbar2)

        ' Add a combo box.
        toolbar2.Items.Add(New RibbonComboBox())

    End Sub
End Class
