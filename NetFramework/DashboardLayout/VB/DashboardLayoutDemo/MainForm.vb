Imports System
Imports System.Windows.Forms
Imports C1.Win.Layout
Imports C1.Win.Ribbon

Namespace DashboardDemo
    Public Partial Class MainForm
        Inherits Controls.BaseForm

        Public Sub New()
            InitializeComponent()
            c1ThemeController1.SetTheme(Ribbon, "(default)")
            ToolIconAppearance = c1DashboardLayout1.Options.ToolIconAppearance
            LayoutType = c1DashboardLayout1.LayoutType
        End Sub

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Init()
            labelSales.Init()
            flexPie1.Init()
            flexChart1.Init()
            c1FlexGrid1.Init()
            c1TrueDBGrid1.Init()
            c1DashboardLayout1.SaveLayout(Helper.DefaultLayoutPath)
        End Sub

        Private Sub MainForm_ApplyLayoutClicked(ByVal sender As Object, ByVal e As Controls.FilePathEventArgs)
            c1DashboardLayout1.LoadLayout(e.FilePath)
            CenterLabelPosition()
        End Sub

        Private Sub MainForm_LayoutTypeChanged(ByVal sender As Object, ByVal e As Controls.LayoutTypeEventArgs)
            c1DashboardLayout1.LayoutType = e.Type
            CenterLabelPosition()
        End Sub

        Private Sub MainForm_ResetLayoutClicked(ByVal sender As Object, ByVal e As Controls.FilePathEventArgs)
            c1DashboardLayout1.LoadLayout(e.FilePath)
            CenterLabelPosition()
        End Sub

        Private Sub MainForm_SaveLayoutClicked(ByVal sender As Object, ByVal e As Controls.FilePathEventArgs)
            c1DashboardLayout1.SaveLayout(e.FilePath)
        End Sub

        Private Sub MainForm_ToolIconAppearanceChanged(ByVal sender As Object, ByVal e As Controls.ToolIconAppearanceEventArgs)
            c1DashboardLayout1.Options.ToolIconAppearance = e.ToolIconAppearance
        End Sub

        Private ReadOnly Property Helper As SampleHelper
            Get
                Return SampleHelper.Instance
            End Get
        End Property

        Private Sub MainForm_DemoThemeChanged(ByVal sender As Object, ByVal e As C1.Win.Themes.ThemeEventArgs)
            Select Case e.ThemeName
                Case "None"
                    c1ThemeController1.Theme = Nothing
                    Helper.Theme = Nothing
                Case Else
                    c1ThemeController1.Theme = e.ThemeName
                    Helper.Theme = e.ThemeName
            End Select
        End Sub

        Private Sub c1SplitterPanel5_Resize(ByVal sender As Object, ByVal e As EventArgs)
            Helper.CenterPosition(TryCast(sender, Control), labelSales)
        End Sub

        Private Sub panel7_Resize(ByVal sender As Object, ByVal e As EventArgs)
            Helper.CenterPosition(TryCast(sender, Control), labelSales)
        End Sub

        Private Sub panel8_Resize(ByVal sender As Object, ByVal e As EventArgs)
            Helper.CenterPosition(TryCast(sender, Control), labelSales)
        End Sub

        Private Sub CenterLabelPosition()
            Select Case c1DashboardLayout1.LayoutType
                Case LayoutType.Flow
                    Helper.CenterPosition(panel8, labelSales)
                Case LayoutType.Grid
                    Helper.CenterPosition(panel7, labelSales)
                Case LayoutType.Split
                    Helper.CenterPosition(c1SplitterPanel5, labelSales)
            End Select
        End Sub
    End Class
End Namespace
