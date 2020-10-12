Imports System
Imports System.ComponentModel
Imports C1.Win.C1Ribbon
Imports C1.Win.C1Themes
Imports C1.Win.Layout

Namespace DashboardDemo.Controls
    Public Partial Class BaseForm
        Inherits C1RibbonForm
        Implements IDemo

        Private _layoutType As LayoutType

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property RibbonVisualStyle As VisualStyle
            Get
                Return c1Ribbon1.VisualStyle
            End Get
            Set(ByVal value As VisualStyle)
                c1Ribbon1.VisualStyle = value
            End Set
        End Property

        Public Property ToolIconAppearance As ToolIconAppearance

        Public Property LayoutType As LayoutType
            Get
                Return _layoutType
            End Get
            Set(ByVal value As LayoutType)

                If _layoutType <> value Then
                    _layoutType = value

                    Select Case _layoutType
                        Case LayoutType.Flow
                            btnFlow.Pressed = True
                        Case LayoutType.Grid
                            btnGrid.Pressed = True
                        Case LayoutType.Split
                            btnSplit.Pressed = True
                    End Select
                End If
            End Set
        End Property

        <Category("Sample")>
        <Description("Occurs when ItemIndex of Theme ComboBox is changed.")>
        Public Event DemoThemeChanged As EventHandler(Of ThemeEventArgs)

        Protected Sub OnDemoThemeChanged(ByVal sender As Object, ByVal themeName As String)
            RaiseEvent DemoThemeChanged(sender, New ThemeEventArgs(themeName))
        End Sub

        <Category("Sample")>
        <Description("Occurs when ItemIndex of ToolIcon ComboBox is changed.")>
        Public Event ToolIconAppearanceChanged As EventHandler(Of ToolIconAppearanceEventArgs)

        Protected Sub OnToolIconAppearanceChanged(ByVal sender As Object, ByVal tia As ToolIconAppearance)
            RaiseEvent ToolIconAppearanceChanged(sender, New ToolIconAppearanceEventArgs(tia))
        End Sub

        <Category("Sample")>
        <Description("Occurs when one of the apply layout menu button is clicked.")>
        Public Event ApplyLayoutClicked As EventHandler(Of FilePathEventArgs)

        Protected Sub OnApplyLayoutClicked(ByVal sender As Object, ByVal e As EventArgs)
            Dim btn As RibbonItem = TryCast(sender, RibbonItem)
            If btn IsNot Nothing Then RaiseEvent ApplyLayoutClicked(sender, New FilePathEventArgs(SampleHelper.Instance.GetLayoutPath(TryCast(btn.Tag, String))))
        End Sub

        <Category("Sample")>
        <Description("Occurs when save layout menu button is clicked.")>
        Public Event SaveLayoutClicked As EventHandler(Of FilePathEventArgs)

        Protected Sub OnSaveLayoutClicked(ByVal sender As Object, ByVal path As String)
            RaiseEvent SaveLayoutClicked(sender, New FilePathEventArgs(path))
        End Sub

        <Category("Sample")>
        <Description("Occurs when reset layout menu button is clicked.")>
        Public Event ResetLayoutClicked As EventHandler(Of FilePathEventArgs)

        Protected Sub OnResetLayoutClicked(ByVal sender As Object, ByVal path As String)
            RaiseEvent ResetLayoutClicked(sender, New FilePathEventArgs(path))
        End Sub

        <Category("Sample")>
        <Description("Occurs when one of the LyoutType toggle button is pressed.")>
        Public Event LayoutTypeChanged As EventHandler(Of LayoutTypeEventArgs)

        Protected Sub OnLayoutTypeChanged(ByVal sender As Object, ByVal type As LayoutType)
            RaiseEvent LayoutTypeChanged(sender, New LayoutTypeEventArgs(type))
        End Sub

        Private Sub LoadThemes()
            cmbThemes.Items.Clear()
            Dim themes = C1ThemeController.GetThemes()
            cmbThemes.Items.Add("None")

            For Each theme In themes
                If Not theme.Contains("Office2010") AndAlso Not theme.Contains("Office2007") Then cmbThemes.Items.Add(theme)
            Next

            cmbThemes.SelectedIndex = cmbThemes.Items.IndexOf("Office2016Colorful")
        End Sub

        Private Sub LoadIconAppearance()
            cmbToolicon.Items.Clear()
            Dim positions = [Enum].GetValues(GetType(ToolIconAppearance))

            For i = 0 To positions.Length - 1
                Dim value = positions.GetValue(i).ToString()
                cmbToolicon.Items.Add(value)
                If value.Equals(ToolIconAppearance.ToString()) Then cmbToolicon.SelectedIndex = i
            Next
        End Sub

        Private Sub UpdateLayouts()
            For Each item As RibbonButton In menuApply.Items
                RemoveHandler item.Click, AddressOf OnApplyLayoutClicked
            Next

            menuApply.Items.Clear()
            Dim layouts As String() = SampleHelper.Instance.GetLayouts()

            If layouts IsNot Nothing Then

                If layouts.Length = 0 Then
                    menuApply.Enabled = False
                Else
                    menuApply.Enabled = True

                    For Each item In layouts
                        Dim btn = New RibbonButton()
                        btn.Text = item.Substring(0, item.LastIndexOf("."c))
                        btn.Tag = item
                        AddHandler btn.Click, AddressOf OnApplyLayoutClicked
                        menuApply.Items.Add(btn)
                    Next
                End If
            Else
                menuApply.Enabled = False
            End If
        End Sub

        Private Sub menuSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim filePath As String

            If SampleHelper.Instance.SaveLayoutDialog(filePath) Then
                OnSaveLayoutClicked(sender, filePath)
                UpdateLayouts()
            End If
        End Sub

        Private Sub menuReset_Click(ByVal sender As Object, ByVal e As EventArgs)
            OnResetLayoutClicked(sender, SampleHelper.Instance.DefaultLayoutPath)
        End Sub

        Private Sub menuManage_Click(ByVal sender As Object, ByVal e As EventArgs)
            SampleHelper.Instance.ManageLayoutDialog()
            UpdateLayouts()
        End Sub

        Private Sub btnFlow_PressedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If btnFlow.Pressed Then OnLayoutTypeChanged(sender, LayoutType.Flow)
        End Sub

        Private Sub btnGrid_PressedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If btnGrid.Pressed Then OnLayoutTypeChanged(sender, LayoutType.Grid)
        End Sub

        Private Sub btnSplit_PressedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If btnSplit.Pressed Then OnLayoutTypeChanged(sender, LayoutType.Split)
        End Sub

        Private Sub cmbToolicon_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnToolIconAppearanceChanged(sender, CType([Enum].Parse(GetType(ToolIconAppearance), cmbToolicon.SelectedItem.Text), ToolIconAppearance))
        End Sub

        Private Sub cmbThemes_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnDemoThemeChanged(sender, cmbThemes.SelectedItem.Text)
        End Sub

        Public Sub Init() Implements IDemo.Init
            LoadThemes()
            LoadIconAppearance()
            UpdateLayouts()
        End Sub
    End Class
End Namespace
