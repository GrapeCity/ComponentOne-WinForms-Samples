Imports C1.Win.Themes
Imports C1.Win.Ribbon
Imports C1.Win.RulesManager
Imports C1.DataFilter
Imports C1.DataCollection
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports System.Data.OleDb

Partial Public Class MainForm

    Private _rulesForm As ConditionalFormattingForm
    Private _filterForm As FilterEditor
    Private _checkedImage As Image

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _checkedImage = My.Resources.Checked
        InitThemes()
        InitData()
        InitForms()
    End Sub

    Private Sub InitForms()
        'Apply default filter - show only invoices with discount
        _filterForm = New FilterEditor(c1FlexGrid1)
        Dim expression = New CombinationExpression()
        Dim opExpresion = New OperationExpression()
        opExpresion.PropertyName = "Discount"
        opExpresion.FilterOperation = FilterOperation.GreaterThan
        opExpresion.Value = 0
        expression.Expressions.Add(opExpresion)
        _filterForm.SetExpression(expression)

        'Apply default rule - bold text for major invoice records
        _rulesForm = New ConditionalFormattingForm(c1FlexGrid1)
        Dim rule = New C1.Win.RulesManager.Rule()
        rule.Name = "Major Invoices"
        rule.Expression = "=[ExtendedPrice] > 1000"
        rule.Style = New ItemStyle()
        rule.Style.FontStyle = FontStyle.Bold
        _rulesForm.Rules.Add(rule)
    End Sub

    Private Sub c1FlexGrid1_ColumnContextMenuOpening(sender As Object, e As C1.Win.FlexGrid.ColumnContextMenuOpeningEventArgs) Handles c1FlexGrid1.ColumnContextMenuOpening
        'Update column context menu only for non-fixed columns
        If e.Col >= c1FlexGrid1.Cols.Fixed Then
            Dim items = e.ContextMenuStrip.Items

            'Add New separator menu item
            items.Add(New ToolStripSeparator())

            'Add New conditional formatting menu item
            Dim rulesItem = New ToolStripMenuItem("Conditional Formatting")
            AddHandler rulesItem.Click, Sub(s, eargs) _rulesForm.ShowDialog()
            If _rulesForm.IsEmpty = False Then
                rulesItem.Image = _checkedImage
            End If
            items.Add(rulesItem)

            'Add New data filter menu item
            Dim filterItem = New ToolStripMenuItem("Filter")
            AddHandler filterItem.Click, Sub(s, eargs) _filterForm.ShowDialog()
            If _filterForm.IsEmpty = False Then
                filterItem.Image = _checkedImage
            End If
            items.Add(filterItem)
        End If
    End Sub
#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        C1ThemeController.ApplicationTheme = cmbThemes.SelectedItem.Text
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))

        For Each theme In themes
            cmbThemes.Items.Add(theme)
        Next
        cmbThemes.SelectedIndex = cmbThemes.Items.IndexOf("Office365Green")
    End Sub
#End Region

#Region "Data"
    'Get standard nwind mdb connection string
    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

    'Load data
    Private Sub InitData()
        Dim da = New OleDbDataAdapter("select * from Invoices", GetConnectionString())
        Dim dt = New DataTable()
        da.Fill(dt)
        c1FlexGrid1.DataSource = dt
    End Sub
#End Region

End Class
