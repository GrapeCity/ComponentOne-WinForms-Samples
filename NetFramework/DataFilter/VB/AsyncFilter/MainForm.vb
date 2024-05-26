Imports System.Threading.Tasks
Imports C1.Win.C1Themes

Public Class MainForm

    Private _loader As Loader

#Region "Load"

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
        ' show animated loader
        _loader.ShowLoader()
        C1DataFilter1.Visible = False
        ' async part
        ' To prevent the user interface from freezing, load data asynchronously
        Await Task.Run(Sub()
                           Dim data = Employee.GenerateData()
                           C1DataFilter1.DataSource = data
                       End Sub)
        ' apply filter async
        Await C1DataFilter1.ApplyFilterAsync()

        C1DataFilter1.Visible = True
        ' hide animated loader
        _loader.HideLoader()
    End Sub

    Private Sub Initialize()
        For Each theme In C1ThemeController.GetThemes()
            RibbonCMBThemes.Items.Add(theme)
        Next

        ThemeName = "Office365White"
        RibbonCMBThemes.SelectedIndex = RibbonCMBThemes.Items.IndexOf(ThemeName)
        ApplyTheme(Me)

        C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.System
        _loader = New Loader()
        _loader.Visible = False
        _loader.Dock = DockStyle.Fill
        Panel1.Controls.Add(_loader)
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

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name = "PostId" AndAlso e.RowIndex >= 0 AndAlso TypeOf dgv("PostId", e.RowIndex).Value Is Integer Then
            Dim id = CInt(dgv("PostId", e.RowIndex).Value)
            e.Value = Employee.Posts.FirstOrDefault(Function(x) x.Id = id).Title
            e.FormattingApplied = True
        End If

        If dgv.Columns(e.ColumnIndex).Name = "CountryId" AndAlso e.RowIndex >= 0 AndAlso TypeOf dgv("CountryId", e.RowIndex).Value Is Integer Then
            Dim id = CInt(dgv("CountryId", e.RowIndex).Value)
            e.Value = Employee.Countries.FirstOrDefault(Function(x) x.Id = id).Name
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub C1DataFilter1_FilterAutoGenerating(sender As Object, e As C1.DataFilter.FilterAutoGeneratingEventArgs) Handles C1DataFilter1.FilterAutoGenerating
        Select Case e.[Property].Name
            Case "PostId"
                Dim postFilter = New C1.Win.DataFilter.ChecklistFilter("PostId") With {
                    .DisplayMemberPath = "Title",
                    .ValueMemberPath = "Id",
                    .SelectionMode = C1.DataFilter.SelectionMode.Single,
                    .ShowSearchBox = False,
                    .LayoutType = C1.DataFilter.LayoutType.List,
                    .MaxHeight = 200,
                    .HeaderText = e.Filter.HeaderText,
                    .ItemsSource = Employee.Posts
               }
                postFilter.Items(0).Selected = True
                e.Filter = postFilter
            Case "EmploymentDate"
                Dim eDate = CType(e.Filter, C1.Win.DataFilter.DateRangeFilter)
                Dim data = CType(C1DataFilter1.DataSource, List(Of Employee))
                eDate.Minimum = data.Min(Function(x) x.EmploymentDate)
                eDate.Maximum = data.Max(Function(x) x.EmploymentDate)
            Case "CountryId"
                Dim cntFilter = New C1.Win.DataFilter.ChecklistFilter("CountryId") With {
                    .DisplayMemberPath = "Name",
                    .ValueMemberPath = "Id",
                    .SelectionMode = C1.DataFilter.SelectionMode.Multiple,
                    .ShowSearchBox = False,
                    .ShowSelectAll = True,
                    .HeaderText = e.Filter.HeaderText,
                    .ItemsSource = Employee.Countries
               }
                cntFilter.SelectAll()
                e.Filter = cntFilter
            Case Else
                e.Cancel = True
        End Select
    End Sub

    Private Sub C1DataFilter1_FilterChanged(sender As Object, e As EventArgs) Handles C1DataFilter1.FilterChanged
        DataGridView1.DataSource = C1DataFilter1.View.ToList()
        _loader.HideLoader()
    End Sub

    Private Sub C1DataFilter1_FilterChanging(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles C1DataFilter1.FilterChanging
        _loader.ShowLoader()
    End Sub

    Private Async Sub RibbonButton1_Click(sender As Object, e As EventArgs) Handles RibbonButton1.Click
        Await C1DataFilter1.ApplyFilterAsync()
    End Sub

End Class
