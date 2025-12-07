Imports System.Reflection
Imports System.Windows.Forms.VisualStyles
Imports C1.Win.Themes

Public Class MainForm

#Region "Ctor"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

    Private Sub Initialize()
        For Each theme In C1ThemeController.GetThemes()
            RibbonCMBThemes.Items.Add(theme)
        Next
        RibbonCMBThemes.SelectedIndex = RibbonCMBThemes.Items.IndexOf("Office365White")
        C1TreeView1.Nodes(0).CheckState = CheckState.Checked
        C1TreeView1.Nodes(1).CheckState = CheckState.Indeterminate
        C1TreeView1.Nodes(0).Expanded = True
        ribbonCBCheckBoxStates.Checked = True
        ribbonCBExpandStates.Checked = True
        ribbonCBEnabledTreeView.Checked = C1TreeView1.Enabled
    End Sub
#End Region

#Region "Themes"
    Private Sub RibbonCMBThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RibbonCMBThemes.SelectedIndexChanged
        ThemeName = RibbonCMBThemes.SelectedItem.Text
        ApplyTheme(Me)
    End Sub

    Private Property ThemeName As String

    Private Sub ApplyTheme(control As Control)
        If Not (String.IsNullOrEmpty(ThemeName)) Then
            Dim theme = C1ThemeController.GetThemeByName(ThemeName, False)
            If Not (theme Is Nothing) Then
                C1ThemeController.ApplyThemeToControlTree(control, theme)
            End If
        End If
    End Sub

#End Region

#Region "Images"

    Private Sub ribbonBtnEditCheckBox_Click(sender As Object, e As EventArgs) Handles ribbonBtnEditCheckBox.Click
        Dim imgEditor = New CheckStateImageEditor(C1TreeView1.CheckImageList)
        ApplyTheme(imgEditor)
        If imgEditor.ShowDialog() = DialogResult.OK Then
            imgEditor.FillImageList()
        End If
    End Sub

    Private Sub ribbonBtnEditExpand_Click(sender As Object, e As EventArgs) Handles ribbonBtnEditExpand.Click
        Dim imgEditor = New ButtonStateImageEditor(C1TreeView1.CheckImageList)
        ApplyTheme(imgEditor)
        If imgEditor.ShowDialog() = DialogResult.OK Then
            imgEditor.FillImageList()
        End If
    End Sub

    Private Sub ribbonCBCheckBoxStates_CheckedChanged(sender As Object, e As EventArgs) Handles ribbonCBCheckBoxStates.CheckedChanged
        If ribbonCBCheckBoxStates.Checked Then
            C1TreeView1.CheckImageList.Images.Clear()
            C1TreeView1.CheckImageList.Images.Add("Unchecked", My.Resources.UncheckedNormal)
            C1TreeView1.CheckImageList.Images.Add("Checked", My.Resources.CheckedNormal)
            C1TreeView1.CheckImageList.Images.Add("Mixed", My.Resources.MixedNormal)
        Else
            C1TreeView1.CheckImageList.Images.Clear()
            For Each key As String In [Enum].GetNames(GetType(CheckBoxState))
                C1TreeView1.CheckImageList.Images.Add(key, GetImageFromResource(key & Convert.ToString(".png")))
            Next
        End If
        C1TreeView1.Invalidate()
    End Sub

    Private Sub ribbonCBExpandStates_CheckedChanged(sender As Object, e As EventArgs) Handles ribbonCBExpandStates.CheckedChanged
        If ribbonCBExpandStates.Checked Then
            C1TreeView1.ButtonImageList.Images.Clear()
            C1TreeView1.ButtonImageList.Images.Add("Expanded", My.Resources.ExpandedNormal)
            C1TreeView1.ButtonImageList.Images.Add("Collapsed", My.Resources.CollapsedNormal)
        Else
            C1TreeView1.ButtonImageList.Images.Clear()
            C1TreeView1.ButtonImageList.Images.Add("ExpandedNormal", My.Resources.ExpandedNormal)
            C1TreeView1.ButtonImageList.Images.Add("ExpandedHot", My.Resources.ExpandedHot)
            C1TreeView1.ButtonImageList.Images.Add("ExpandedPressed", My.Resources.ExpandedPressed)
            C1TreeView1.ButtonImageList.Images.Add("ExpandedDisabled", My.Resources.ExpandedDisabled)
            C1TreeView1.ButtonImageList.Images.Add("CollapsedNormal", My.Resources.CollapsedNormal)
            C1TreeView1.ButtonImageList.Images.Add("CollapsedHot", My.Resources.CollapsedHot)
            C1TreeView1.ButtonImageList.Images.Add("CollapsedPressed", My.Resources.CollapsedPressed)
            C1TreeView1.ButtonImageList.Images.Add("CollapsedDisabled", My.Resources.CollapsedDisabled)
        End If
        C1TreeView1.Invalidate()
    End Sub

    Private Function GetImageFromResource(resourceName As String) As Image
        Dim fullResourceName = GetFullResourceName(resourceName)
        Dim asm = Assembly.GetExecutingAssembly()
        Dim img As Image
        Using stream As System.IO.Stream = asm.GetManifestResourceStream(fullResourceName)
            img = Image.FromStream(stream)
        End Using
        Return img
    End Function

    Private Function GetFullResourceName(resourceName As String) As String
        Dim asm = Assembly.GetExecutingAssembly()
        resourceName = "." + resourceName
        Dim names = asm.GetManifestResourceNames()
        Dim Name = String.Empty
        For i As Integer = 0 To names.Length
            Name = names(i)
            If Name.EndsWith(resourceName, StringComparison.OrdinalIgnoreCase) Then
                Return Name
            End If
        Next
        Return String.Empty
    End Function

#End Region

    Private Sub ribbonCBEnabledTreeView_CheckedChanged(sender As Object, e As EventArgs) Handles ribbonCBEnabledTreeView.CheckedChanged
        C1TreeView1.Enabled = ribbonCBEnabledTreeView.Checked
    End Sub

End Class
