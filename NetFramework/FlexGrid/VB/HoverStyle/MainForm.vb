Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Themes
Imports C1.Win.Ribbon

Namespace HoverStyle
    Partial Public Class MainForm
        Inherits C1RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitThemes()

            Enumerable.ToList(Of HoverMode)(Enumerable.Cast(Of HoverMode)(
                                            [Enum].GetValues(CType(GetType(HoverMode), Type)))).
                                            ForEach(Sub(x) rbHoverMode.Items.Add(x.ToString()))
            Enumerable.ToList(Of SelectionModeEnum)(Enumerable.Cast(Of SelectionModeEnum)(
                                                    [Enum].GetValues(CType(GetType(SelectionModeEnum), Type)))).
                                                    ForEach(Sub(x) rbSelectMode.Items.Add(x.ToString()))
            rbHoverMode.SelectedIndex = 3
            rbSelectMode.SelectedIndex = 0
            c1FlexGrid1.Styles.Hover.BackColor = rbHoverColor.Color

            InitData()
        End Sub

        Private Sub InitData()
            Dim dataAdapter = New OleDbDataAdapter("select * from orders", GetConnectionString())
            Dim dataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            c1FlexGrid1.DataSource = dataTable
        End Sub

        Private Function GetConnectionString() As String
            Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
            Dim conn = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
            Return String.Format(conn, path)
        End Function

#Region "Themes"

        Private Sub InitThemes()
            Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office2016"))
            For Each theme In themes
                cmbTheme.Items.Add(theme)
            Next
        End Sub

        Private Sub cmbTheme_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbTheme.SelectedIndexChanged
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text
        End Sub

#End Region

        Private Sub rbHoverMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbHoverMode.SelectedIndexChanged
            c1FlexGrid1.HoverMode = CType([Enum].Parse(GetType(HoverMode), rbHoverMode.Text), HoverMode)
        End Sub

        Private Sub rbSelectMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbSelectMode.SelectedIndexChanged
            c1FlexGrid1.SelectionMode = CType([Enum].Parse(GetType(SelectionModeEnum), rbSelectMode.Text), SelectionModeEnum)
        End Sub

        Private Sub rbHoverColor_SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbHoverColor.SelectedColorChanged
            c1FlexGrid1.Styles.Hover.BackColor = rbHoverColor.Color
        End Sub
    End Class
End Namespace
