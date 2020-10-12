Imports System.Data.OleDb
Imports System.IO
Imports System.Xml.Serialization
Imports C1.DataCollection
Imports C1.DataFilter
Imports C1.Win.C1Input
Imports C1.Win.C1Themes

Public Class FilterEditorForm
    Private Const xmlFileName As String = "FilterExpression.xml"
    Private pathToXmlFile As String = Nothing

    Private Sub FilterEditorForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        FillComboBoxWithThemeNames()
        ApplyDataSource()
        ApplyFilter()
    End Sub

    Private Sub FillComboBoxWithThemeNames()
        Dim themes = C1ThemeController.GetThemes()

        For Each theme In themes
            ribbonCmbThemes.Items.Add(theme)
        Next

        ribbonCmbThemes.SelectedIndex = Array.IndexOf(themes, "Office2016Colorful")
    End Sub

    Private Sub ApplyDataSource()
        Dim dt = Data.GetDataSource()
        flexGrid.DataSource = dt
        filterEditor.DataSource = dt
    End Sub

    Private Sub ApplyFilter()
        pathToXmlFile = Directory.GetCurrentDirectory() & "\" & xmlFileName
        Dim filterExpression As CombinationExpression = Nothing

        If Not File.Exists(pathToXmlFile) Then
            filterExpression = GetPredefinedFilter()
        Else
            filterExpression = LoadFilterFromFile(pathToXmlFile)
        End If

        filterEditor.SetExpression(filterExpression)
        filterEditor.ApplyFilter()
    End Sub

    Private Shared Function GetPredefinedFilter() As CombinationExpression
        Dim filterExpression = New CombinationExpression()
        Dim filterExpressions = filterExpression.Expressions
        Dim hpGreaterThen200Expression = New OperationExpression() With {
            .PropertyName = "HP",
            .FilterOperation = FilterOperation.GreaterThanOrEqual,
            .Value = 200
        }
        filterExpressions.Add(hpGreaterThen200Expression)
        Dim automaticTransmissionExpression = New OperationExpression() With {
            .PropertyName = "AutomaticTransmission",
            .FilterOperation = FilterOperation.Equal,
            .Value = True
        }
        filterExpressions.Add(automaticTransmissionExpression)
        Dim sportsCategoryExpression = New OperationExpression() With {
            .PropertyName = "StartSaleDate",
            .FilterOperation = FilterOperation.GreaterThanOrEqual,
            .Value = New DateTime(2011, 1, 1)
        }
        filterExpressions.Add(sportsCategoryExpression)
        Dim brandOrExpression = New CombinationExpression()
        brandOrExpression.FilterCombination = FilterCombination.[Or]
        Dim brandExpressions = brandOrExpression.Expressions
        Dim brandEqualMercedesBenzExpression = New OperationExpression() With {
            .PropertyName = "Brand",
            .FilterOperation = FilterOperation.EqualText,
            .Value = "Mercedes-Benz"
        }
        brandExpressions.Add(brandEqualMercedesBenzExpression)
        Dim brandEqualAudiExpression = New OperationExpression() With {
            .PropertyName = "Brand",
            .FilterOperation = FilterOperation.EqualText,
            .Value = "Audi"
        }
        brandExpressions.Add(brandEqualAudiExpression)
        filterExpressions.Add(brandOrExpression)
        Return filterExpression
    End Function

    Private Function LoadFilterFromFile(ByVal filePath As String) As CombinationExpression
        Dim filterExpression As CombinationExpression
        Dim xmlSerializer = New XmlSerializer(GetType(CombinationExpression))

        Using fs = File.Open(filePath, FileMode.Open)
            filterExpression = TryCast(xmlSerializer.Deserialize(fs), CombinationExpression)
        End Using

        Return filterExpression
    End Function

    Private Sub ribbonCmbThemes_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonCmbThemes.SelectedIndexChanged
        themeController.Theme = ribbonCmbThemes.SelectedItem.Text
    End Sub

    Private Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApply.Click
        filterEditor.ApplyFilter()
    End Sub

    Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
        filterEditor.ClearFilter()
        filterEditor.ApplyFilter()
    End Sub

    Private Sub filterEditor_FilterChanged(ByVal sender As Object, ByVal e As EventArgs) Handles filterEditor.FilterChanged
        SaveFilterToFile(pathToXmlFile)
    End Sub

    Private Sub SaveFilterToFile(ByVal filePath As String)
        Dim expression = filterEditor.GetExpression()
        Dim xmlSerializer = New XmlSerializer(GetType(CombinationExpression))

        Using fs = File.Create(filePath)
            xmlSerializer.Serialize(fs, expression)
        End Using
    End Sub

    Private Sub filterEditor_CustomEditorInitializing(sender As Object, e As C1.Win.DataFilter.CustomEditorEventArgs) Handles filterEditor.CustomEditorInitializing
        If e.PropertyName = "Brand" Then
            Dim cmb = New C1ComboBox() With {
                .AutoSize = False,
                .Width = 120
            }
            cmb.ItemsDataSource = Data.GetDataSource()
            cmb.ItemsValueMember = "Brand"
            cmb.ItemsDisplayMember = "Brand"
            e.Control = cmb
        End If
    End Sub
End Class
