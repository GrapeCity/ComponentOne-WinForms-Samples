Imports C1.Win.C1Themes
Imports C1.Win.Ribbon
Imports C1.Win.C1FlexGrid

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
        Dim dbConnection = $"provider=microsoft.jet.oledb.4.0;data source={Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\ComponentOne Samples\Common\c1nwind.mdb;"
        ordersTableAdapter.Connection.ConnectionString = dbConnection
        Me.ordersTableAdapter.Fill(Me.c1NWindDataSet.Orders)
        c1FlexGrid1.AllowMerging = AllowMergingEnum.Custom
        Dim cellRange = c1FlexGrid1.GetCellRange(2, 2, 3, 3)
        c1FlexGrid1.MergedRanges.Add(cellRange)
    End Sub

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTheme.SelectedIndexChanged
        c1ThemeController1.Theme = cmbTheme.SelectedItem.Text
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office2016"))

        For Each theme In themes
            cmbTheme.Items.Add(theme)
        Next
    End Sub

#End Region

    Private Sub C1FlexGrid1_AfterSelChange(ByVal sender As Object, ByVal e As RangeEventArgs) Handles c1FlexGrid1.AfterSelChange
        toolStripLabel1.Text = $"Selection statistic: Count={c1FlexGrid1.Aggregate(AggregateEnum.Count)}; Sum={c1FlexGrid1.Aggregate(AggregateEnum.Sum)}"
    End Sub

    Private Sub rbCopyToClipboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbCopyToClipboard.Click
        c1FlexGrid1.Copy()
    End Sub

    Private Sub rbPasteFromClipboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbPasteFromClipboard.Click
        c1FlexGrid1.Paste()
    End Sub

    Private Sub rbExportToExcel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbExportToExcel.Click
        Using dialog = New SaveFileDialog()
            dialog.FileName = "MultiRangeSelection.xlsx"
            dialog.Filter = "Excel files (*.xlsx)|*.xlsx"
            If dialog.ShowDialog() = DialogResult.OK Then
                c1FlexGrid1.SaveExcel("MultiRangeSelection.xlsx", FileFlags.SelectedRangesOnly Or FileFlags.SaveMergedRanges)
                MessageBox.Show("Data exported to Excel", "FlexGrid MultiRange Selection Sample", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub rbSelectRanges_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbSelectRanges.Click
        Dim ranges = New List(Of CellRange) From {
            c1FlexGrid1.GetCellRange(1, 1, 4, 2),
            c1FlexGrid1.GetCellRange(1, 5, 4, 6)
        }
        c1FlexGrid1.[Select](ranges)
    End Sub
End Class
