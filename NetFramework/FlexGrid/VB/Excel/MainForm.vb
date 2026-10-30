' Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

Imports C1.Win.Ribbon
Imports C1.Win.Themes
Imports C1.Win.FlexGrid
Imports System.IO

Public Class MainForm
    Inherits C1RibbonForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
        c1FlexGrid1.AutoResize = True
        LoadData()
    End Sub

#Region "Themes"

    Private Sub InitThemes()
        Dim themes As IEnumerable(Of String) = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))
        For Each theme In themes
            ribbonComboBoxThemes.Items.Add(theme)
        Next
        ribbonComboBoxThemes.SelectedIndex = ribbonComboBoxThemes.Items.IndexOf("Office365Green")
    End Sub

    Private Sub ribbonComboBoxThemes_SelectedIndexChanged(sender As Object, e As EventArgs)
        c1ThemeController1.Theme = ribbonComboBoxThemes.SelectedItem.Text
    End Sub

#End Region

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim conn As String = GetConnectionString()
        Dim sql = "select * from customers"
        Dim da = New OleDb.OleDbDataAdapter(sql, conn)
        Dim dt = New DataTable()
        da.Fill(dt)
        c1FlexGrid1.DataSource = dt
        'add footer
        Dim footer = New FooterDescription()
        Dim agg = New AggregateDefinition() With {
            .Aggregate = AggregateEnum.Count,
            .Column = 1
            }
        footer.Aggregates.Add(agg)
        c1FlexGrid1.Footers.Descriptions.Add(footer)
        c1FlexGrid1.Footers.Fixed = True
    End Sub

    Private Sub btnMultiSheet_Click(sender As Object, e As EventArgs)
        ' choose file
        Dim fileName As String
        Using dlg = New SaveFileDialog()
            dlg.DefaultExt = "xls"
            dlg.FileName = "*.xls"
            If dlg.ShowDialog() <> DialogResult.OK Then Return
            fileName = dlg.FileName
        End Using
        ' delete file if it's already there
        If File.Exists(fileName) Then File.Delete(fileName)

        ' prepare to load data from database
        Dim mdbfile = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common\c1nwind.mdb"
        Dim conn = "provider=microsoft.jet.oledb.4.0;data source=" & mdbfile & ";"
        Dim da As OleDb.OleDbDataAdapter

        ' save several sheets
        Dim tables = "Categories|Products|Employees|Customers|Orders".Split("|"c)
        For Each table In tables
            ' load data into grid
            Dim sql = "select * from " & table
            da = New OleDb.OleDbDataAdapter(sql, conn)
            Dim dt = New DataTable()
            da.Fill(dt)
            c1FlexGrid1.DataSource = dt
            c1FlexGrid1.Update()

            ' save into a sheet
            c1FlexGrid1.SaveExcel(fileName, table, FileFlags.VisibleOnly Or FileFlags.IncludeFixedCells)
        Next
    End Sub

    Private Sub btnImportSheet_Click(sender As Object, e As EventArgs)
        'Diplay custom ImportOptions dialog first to select FileFlags
        Dim flags As FileFlags
        Using options = New ImportOptions()
            options.c1ThemeController1.Theme = c1ThemeController1.Theme
            If options.ShowDialog() <> DialogResult.OK Then Return
            flags = options.Flags
        End Using
        Dim fileName As String
        Using ofd = New OpenFileDialog()
            ofd.Filter = "Excel (*.xls, *.xlsx)|*.xls;*.xlsx"
            If ofd.ShowDialog() <> DialogResult.OK Then Return
            fileName = ofd.FileName
        End Using
        Try
            'Load selected Excel File
            c1FlexGrid1.DataSource = Nothing
            c1FlexGrid1.LoadExcel(fileName, flags)
        Catch ex As Exception
            MessageBox.Show("Unable to import Excel file: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExportSheet_Click(sender As Object, e As EventArgs)
        'This function saves and launches Excel file from FlexGrid
        'Diplay custom ExportOptions dialog first to select FileFlags
        Dim flags As FileFlags
        Using options = New ExportOptions()
            options.c1ThemeController1.Theme = c1ThemeController1.Theme
            If options.ShowDialog() <> DialogResult.OK Then Return
            flags = options.Flags
        End Using
        Dim fileName As String
        Using sfd = New SaveFileDialog()
            If flags.ToString().Contains("OpenXml") Then
                sfd.Filter = "Excel OpenXml (*.xlsx)|*.xlsx"
            Else
                sfd.Filter = "Excel (*.xls)|*.xls"
            End If

            If sfd.ShowDialog() <> DialogResult.OK Then Return
            fileName = sfd.FileName
        End Using
        c1FlexGrid1.SaveExcel(fileName, flags)
        Process.Start(fileName)
    End Sub

    Private Function GetConnectionString() As String
        Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class