Imports System.Data.OleDb
Imports C1.Win.FlexGrid
Imports C1.Win.Themes
Imports C1.Win.Ribbon
Imports C1.Win.RulesManager
Imports C1.Win.RulesManager.Model

Public Class MainForm

#Region "Initialization"

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitThemes()

        flexGrid.DataSource = GetDataSource()
    End Sub

#End Region

#Region "Highlight cells rules applying"

    Private Sub ribbonButtonGreaterThan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonButtonGreaterThan.Click
        Using form = New GreaterThanForm()
            ShowSingleValueConditionalFormattingForm(form, "= [CurrentValue] > {0}")
        End Using
    End Sub

    Private Sub ribbonButtonLessThan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonButtonLessThan.Click
        Using form = New LessThanForm()
            ShowSingleValueConditionalFormattingForm(form, "= [CurrentValue] < {0}")
        End Using
    End Sub

    Private Sub ribbonButtonBetween_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonButtonBetween.Click
        Using form = New BetweenForm()
            ShowBetweenForm(form)
        End Using
    End Sub

    Private Sub ribbonButtonEqualTo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonButtonEqualTo.Click
        Using form = New EqualToForm()
            ShowSingleValueConditionalFormattingForm(form, "= [CurrentValue] = {0}")
        End Using
    End Sub

    Private Sub ribbonButtonTextThatContains_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonButtonTextThatContains.Click
        Using form = New TextThatContainsForm()
            ShowSingleValueConditionalFormattingForm(form, "= Contains([CurrentValue], {0})")
        End Using
    End Sub

#End Region

#Region "Data bars applying"

#Region "Gradient fill"

    Private Sub ribbonGalleryItemBlueGradientDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemBlueGradientDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.GradientDataBars(DataBar.Blue))
    End Sub

    Private Sub ribbonGalleryItemGreenGradientDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemGreenGradientDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.GradientDataBars(DataBar.Green))
    End Sub

    Private Sub ribbonGalleryItemRedGradientDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemRedGradientDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.GradientDataBars(DataBar.Red))
    End Sub

    Private Sub ribbonGalleryItemOrangeGradientDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemOrangeGradientDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.GradientDataBars(DataBar.Orange))
    End Sub

    Private Sub ribbonGalleryItemLightBlueGradientDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemLightBlueGradientDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.GradientDataBars(DataBar.LightBlue))
    End Sub

    Private Sub ribbonGalleryItemPurpleGradientDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemPurpleGradientDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.GradientDataBars(DataBar.Purple))
    End Sub

#End Region

#Region "Solid fill"

    Private Sub ribbonGalleryItemBlueDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemBlueDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.SolidDataBars(DataBar.Blue))
    End Sub

    Private Sub ribbonGalleryItemGreenDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemGreenDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.SolidDataBars(DataBar.Green))
    End Sub

    Private Sub ribbonGalleryItemRedDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemRedDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.SolidDataBars(DataBar.Red))
    End Sub

    Private Sub ribbonGalleryItemOrangeDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemOrangeDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.SolidDataBars(DataBar.Orange))
    End Sub

    Private Sub ribbonGalleryItemLightBlueDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemLightBlueDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.SolidDataBars(DataBar.LightBlue))
    End Sub

    Private Sub ribbonGalleryItemPurpleDataBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemPurpleDataBar.Click
        ApplyStyleToSelectedRange(StylePresets.SolidDataBars(DataBar.Purple))
    End Sub

#End Region

#End Region

#Region "Color scales applying"

    Private Sub ribbonGalleryItemGreenYellowRedColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemGreenYellowRedColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.GreenYellowRed))
    End Sub

    Private Sub ribbonGalleryItemRedYellowGreenColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemRedYellowGreenColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.RedYellowGreen))
    End Sub

    Private Sub ribbonGalleryItemGreenWhiteRedColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemGreenWhiteRedColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.GreenWhiteRed))
    End Sub

    Private Sub ribbonGalleryItemRedWhiteGreenColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemRedWhiteGreenColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.RedWhiteGreen))
    End Sub

    Private Sub ribbonGalleryItemBlueWhiteRedColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemBlueWhiteRedColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.BlueWhiteRed))
    End Sub

    Private Sub ribbonGalleryItemRedWhiteBlueColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemRedWhiteBlueColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.RedWhiteBlue))
    End Sub

    Private Sub ribbonGalleryItemWhiteRedColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemWhiteRedColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.WhiteRed))
    End Sub

    Private Sub ribbonGalleryItemRedWhiteColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemRedWhiteColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.RedWhite))
    End Sub

    Private Sub ribbonGalleryItemGreenWhiteColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemGreenWhiteColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.GreenWhite))
    End Sub

    Private Sub ribbonGalleryItemWhiteGreenColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemWhiteGreenColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.WhiteGreen))
    End Sub

    Private Sub ribbonGalleryItemGreenYellowColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemGreenYellowColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.GreenYellow))
    End Sub

    Private Sub ribbonGalleryItemYellowGreenColorScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemYellowGreenColorScale.Click
        ApplyStyleToSelectedRange(StylePresets.ColorScales(ColorScale.YellowGreen))
    End Sub

#End Region

#Region "Icon sets applying"

    Private Sub ribbonGalleryItemThreeArrowsIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemThreeArrowsIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.ThreeArrows))
    End Sub

    Private Sub ribbonGalleryItemThreeTrianglesIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemThreeTrianglesIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.ThreeTriangles))
    End Sub

    Private Sub ribbonGalleryItemFourArrowsIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemFourArrowsIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.FourArrows))
    End Sub

    Private Sub ribbonGalleryItemFiveArrowsIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemFiveArrowsIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.FiveArrows))
    End Sub

    Private Sub ribbonGalleryItemThreeTrafficLightsUnrimmedIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemThreeTrafficLightsUnrimmedIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.ThreeTrafficLightsUnrimmed))
    End Sub

    Private Sub ribbonGalleryItemThreeTrafficLightsRimmedIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemThreeTrafficLightsRimmedIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.ThreeTrafficLightsRimmed))
    End Sub

    Private Sub ribbonGalleryItemThreeSignsIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemThreeSignsIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.ThreeSigns))
    End Sub

    Private Sub ribbonGalleryItemThreeSymbolsCircledIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemThreeSymbolsCircledIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.ThreeSymbolsCircled))
    End Sub

    Private Sub ribbonGalleryItemThreeSymbolsUncircledIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemThreeSymbolsUncircledIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.ThreeSymbolsUncircled))
    End Sub

    Private Sub ribbonGalleryItemThreeFlagsIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemThreeFlagsIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.ThreeFlags))
    End Sub

    Private Sub ribbonGalleryItemThreeStarsIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemThreeStarsIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.ThreeStars))
    End Sub

    Private Sub ribbonGalleryItemFiveQuartersIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemFiveQuartersIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.FiveQuarters))
    End Sub

    Private Sub ribbonGalleryItemFiveRatingsIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemFiveRatingsIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.FiveRatings))
    End Sub

    Private Sub ribbonGalleryItemFiveBoxesIconSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonGalleryItemFiveBoxesIconSet.Click
        ApplyStyleToSelectedRange(StylePresets.IconSets(IconSet.FiveBoxes))
    End Sub

#End Region

#Region "Rules management"

    Private Sub ribbonButtonManageRules_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonButtonManageRules.Click
        dockingTabPageConditionalFormatting.TabVisible = True
    End Sub

#End Region

#Region "Rules clearing"

    Private Sub ribbonButtonClearRulesFromSelectedCells_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonButtonClearRulesFromSelectedCells.Click
        Dim rules = rulesManager?.Rules

        If rules Is Nothing Then
            Return
        End If

        Dim selection = flexGrid.Selection
        Dim rulesForRemove = New List(Of IRule)()

        For Each rule In rules

            If rule Is Nothing Then
                Continue For
            End If

            Dim ranges = rule.AppliesTo

            If ranges Is Nothing OrElse ranges.Count = 0 Then
                Dim gridCellRange = flexGrid.GetCellRange(flexGrid.Rows.Fixed, flexGrid.Cols.Fixed, flexGrid.Rows.Count - 1, flexGrid.Cols.Count - 1)

                If Equals(gridCellRange, selection) Then
                    rulesForRemove.Add(rule)
                    Continue For
                End If

                Dim diffRanges = GetDiff(gridCellRange, selection)

                If diffRanges Is Nothing OrElse diffRanges.Count = 0 Then
                    rulesForRemove.Add(rule)
                    Continue For
                End If

                For Each diffRange In diffRanges
                    ranges.Add(GetItemRange(diffRange))
                Next
            End If

            RemoveCellRangeFromItemRanges(selection, ranges)

            If ranges.Count = 0 Then
                rulesForRemove.Add(rule)
            End If
        Next

        For Each rule In rulesForRemove
            rules.Remove(rule)
        Next
    End Sub

    Private Sub ribbonButtonClearRulesFromAllCells_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonButtonClearRulesFromAllCells.Click
        rulesManager.Rules.Clear()
    End Sub

#End Region

#Region "Utilities"

#Region "Form showing"

    Private Sub ShowSingleValueConditionalFormattingForm(ByVal form As SingleValueConditionalFormattingForm, ByVal singleValueExpression As String)
        If form Is Nothing Then
            Return
        End If

        form.ShowDialog()

        If form.DialogResult <> DialogResult.OK Then
            Return
        End If

        Dim val = form.Value

        If String.IsNullOrEmpty(val) Then
            Return
        End If

        Dim itemRange = GetItemRange(flexGrid.Selection)
        Dim expressionString = String.Format(singleValueExpression, val)
        Dim stylePreset = form.SelectedStylePreset
        Dim rule = New C1.Win.RulesManager.Rule() With {
            .Name = expressionString & " on " & itemRange.ToString(),
            .Expression = expressionString,
            .Style = StylePresets.Highlights(stylePreset)
        }
        rule.AppliesTo.Add(itemRange)
        rulesManager.Rules.Add(rule)
    End Sub

    Private Sub ShowBetweenForm(ByVal form As BetweenForm)
        If form Is Nothing Then
            Return
        End If

        form.ShowDialog()

        If form.DialogResult <> DialogResult.OK Then
            Return
        End If

        Dim minimumVal = form.MinimumValue

        If String.IsNullOrEmpty(minimumVal) Then
            Return
        End If

        Dim maximumVal = form.MaximumValue

        If String.IsNullOrEmpty(maximumVal) Then
            Return
        End If

        Dim itemRange = GetItemRange(flexGrid.Selection)
        Dim expressionString = $"= {minimumVal} <= [CurrentValue] And [CurrentValue] <= {maximumVal}"
        Dim stylePreset = form.SelectedStylePreset
        Dim rule = New C1.Win.RulesManager.Rule() With {
            .Name = expressionString & " on " & itemRange.ToString(),
            .Expression = expressionString,
            .Style = StylePresets.Highlights(stylePreset)
        }
        rule.AppliesTo.Add(itemRange)
        rulesManager.Rules.Add(rule)
    End Sub

#End Region

#Region "ItemStyle applying"

    Private Sub ApplyStyleToSelectedRange(ByVal style As ItemStyle)
        Dim itemRange = GetItemRange(flexGrid.Selection)
        Dim expressionString = "= true"
        Dim rule = New C1.Win.RulesManager.Rule() With {
            .Name = expressionString & " on " & itemRange.ToString(),
            .Expression = expressionString,
            .Style = style
        }
        rule.AppliesTo.Add(itemRange)
        rulesManager.Rules.Add(rule)
    End Sub

#End Region

#Region "CellRange To ItemRange converting"

    Private Function GetItemRange(ByVal cellRange As CellRange) As IItemRange
        Dim gridCellRange = flexGrid.GetCellRange(flexGrid.Rows.Fixed, flexGrid.Cols.Fixed, flexGrid.Rows.Count - 1, flexGrid.Cols.Count - 1)

        If cellRange.LeftCol = gridCellRange.LeftCol AndAlso cellRange.RightCol = gridCellRange.RightCol Then
            Return New ItemRange(cellRange.TopRow, cellRange.BottomRow)
        End If

        Dim fields = New List(Of String)()

        For c = cellRange.LeftCol To cellRange.RightCol
            fields.Add(flexGrid.Cols(c).Name)
        Next

        If cellRange.TopRow = gridCellRange.TopRow AndAlso cellRange.BottomRow = gridCellRange.BottomRow Then
            Return New FieldRange(fields)
        End If

        Dim fieldNames = String.Join(",", fields.[Select](Function(field) $"[{field}]"))
        Return New CustomItemRange($"{cellRange.TopRow}:{cellRange.BottomRow}:{fieldNames}")
    End Function

#End Region

#Region "Exclusion Of CellRange from ItemRange"

    Private Sub RemoveCellRangeFromItemRanges(ByVal selection As CellRange, ByVal ranges As ItemRangeCollection)
        Dim rangeIndex = 0

        While rangeIndex < ranges.Count
            Dim range = ranges(rangeIndex)

            If range Is Nothing Then
                rangeIndex += 1
                Continue While
            End If

            Dim cellRanges = GetCellRanges(range)

            If cellRanges Is Nothing OrElse cellRanges.Count = 0 Then
                rangeIndex += 1
                Continue While
            End If

            Dim diffRanges = GetItemRangeDiff(cellRanges, selection)

            If diffRanges Is Nothing OrElse diffRanges.Count = 0 Then
                ranges.RemoveAt(rangeIndex)
                Continue While
            End If

            If AreRangeListsEqual(cellRanges, diffRanges) Then
                rangeIndex += 1
                Continue While
            End If

            ranges(rangeIndex) = GetItemRange(diffRanges(0))
            rangeIndex += 1

            If diffRanges.Count > 1 Then

                For diffRangeIndex = 1 To diffRanges.Count - 1
                    ranges.Insert(rangeIndex, GetItemRange(diffRanges(diffRangeIndex)))
                    rangeIndex += 1
                Next
            End If
        End While
    End Sub

#Region "ItemRange To CellRange converting"

    Private Function GetCellRanges(ByVal range As IItemRange) As List(Of CellRange)
        Dim cellRanges As List(Of CellRange) = Nothing

        If TypeOf range Is ItemRange Then
            Dim itemRange = CType(range, ItemRange)
            cellRanges = New List(Of CellRange)() From {
                flexGrid.GetCellRange(itemRange.FirstItem, flexGrid.Cols.Fixed, itemRange.LastItem, flexGrid.Cols.Count - 1)
            }
        ElseIf TypeOf range Is FieldRange Then
            Dim fieldRange = CType(range, FieldRange)
            cellRanges = GetCellRanges(fieldRange?.Fields, flexGrid.Rows.Fixed, flexGrid.Rows.Count - 1)
        ElseIf TypeOf range Is CustomItemRange Then
            Dim customItemRange = CType(range, CustomItemRange)
            cellRanges = GetCellRanges(customItemRange?.Fields, customItemRange.FirstItem, customItemRange.LastItem)
        End If

        Return cellRanges
    End Function

    Private Function GetCellRanges(ByVal fields As String(), ByVal topRowIndex As Integer, ByVal bottomRowIndex As Integer) As List(Of CellRange)
        If fields Is Nothing OrElse fields.Length = 0 Then
            Return Nothing
        End If

        Dim columns = flexGrid?.Cols

        If columns Is Nothing Then
            Return Nothing
        End If

        Dim columnIndices = GetColumnIndices(fields, columns)

        If columnIndices.Count = 0 Then
            Return Nothing
        End If

        columnIndices.Sort()
        Return GetContinuousCellRanges(columnIndices, topRowIndex, bottomRowIndex)
    End Function

#End Region

    Private Shared Function GetColumnIndices(ByVal fields As String(), ByVal columns As ColumnCollection) As List(Of Integer)
        Dim columnIndexes = New List(Of Integer)()

        For Each field In fields
            Dim column = columns(field)

            If column Is Nothing Then
                Continue For
            End If

            Dim columnIndex = column.Index

            If columnIndex = -1 Then
                Continue For
            End If

            columnIndexes.Add(columnIndex)
        Next

        Return columnIndexes
    End Function

    Private Function GetContinuousCellRanges(ByVal columnIndices As List(Of Integer), ByVal topRowIndex As Integer, ByVal bottomRowIndex As Integer) As List(Of CellRange)
        Dim cellRanges = New List(Of CellRange)()
        Dim currentColumnIndex = columnIndices(0)
        Dim leftColumnIndex = currentColumnIndex
        Dim rightColumnIndex = currentColumnIndex

        If columnIndices.Count = 1 Then
            cellRanges.Add(flexGrid.GetCellRange(topRowIndex, leftColumnIndex, bottomRowIndex, rightColumnIndex))
            Return cellRanges
        End If

        For c = 1 To columnIndices.Count - 1
            currentColumnIndex = columnIndices(c)

            If currentColumnIndex - rightColumnIndex > 1 Then
                cellRanges.Add(flexGrid.GetCellRange(topRowIndex, leftColumnIndex, bottomRowIndex, rightColumnIndex))
                leftColumnIndex = currentColumnIndex
                rightColumnIndex = currentColumnIndex
            ElseIf c = columnIndices.Count - 1 Then
                rightColumnIndex = currentColumnIndex
                cellRanges.Add(flexGrid.GetCellRange(topRowIndex, leftColumnIndex, bottomRowIndex, rightColumnIndex))
            Else
                rightColumnIndex = currentColumnIndex
            End If
        Next

        Return cellRanges
    End Function

    Private Function GetItemRangeDiff(ByVal originals As List(Of CellRange), ByVal exclusion As CellRange) As List(Of CellRange)
        Dim diff = New List(Of CellRange)()

        For Each original In originals
            diff.AddRange(GetDiff(original, exclusion))
        Next

        Return diff
    End Function

    Private Function GetDiff(ByVal original As CellRange, ByVal exclusion As CellRange) As List(Of CellRange)
        Dim diff = New List(Of CellRange)()

        If Not AreRangesIntersect(original, exclusion) Then
            diff.Add(original)
            Return diff
        End If

        Dim intersection = GetRangesIntersection(original, exclusion)

        If original.TopRow < intersection.TopRow Then
            diff.Add(flexGrid.GetCellRange(original.TopRow, original.LeftCol, intersection.TopRow - 1, original.RightCol))
        End If

        If original.LeftCol < intersection.LeftCol Then
            diff.Add(flexGrid.GetCellRange(intersection.TopRow, original.LeftCol, intersection.BottomRow, intersection.LeftCol - 1))
        End If

        If original.BottomRow > intersection.BottomRow Then
            diff.Add(flexGrid.GetCellRange(intersection.BottomRow + 1, original.LeftCol, original.BottomRow, original.RightCol))
        End If

        If original.RightCol > intersection.RightCol Then
            diff.Add(flexGrid.GetCellRange(intersection.TopRow, intersection.RightCol + 1, intersection.BottomRow, original.RightCol))
        End If

        Return diff
    End Function

#End Region

#Region "CellRange intersection"

    Private Function AreRangesIntersect(ByVal rg1 As CellRange, ByVal rg2 As CellRange) As Boolean
        If rg1.BottomRow < rg2.TopRow OrElse rg1.TopRow > rg2.BottomRow OrElse rg1.RightCol < rg2.LeftCol OrElse rg1.LeftCol > rg2.RightCol Then
            Return False
        End If

        Return True
    End Function

    Friend Function GetRangesIntersection(ByVal rg1 As CellRange, ByVal rg2 As CellRange) As CellRange
        rg1.r1 = Math.Max(rg1.TopRow, rg2.TopRow)
        rg1.r2 = Math.Min(rg1.BottomRow, rg2.BottomRow)
        rg1.c1 = Math.Max(rg1.LeftCol, rg2.LeftCol)
        rg1.c2 = Math.Min(rg1.RightCol, rg2.RightCol)
        Return rg1
    End Function

#End Region

#Region "CellRange lists comparison"

    Private Function AreRangeListsEqual(ByVal list1 As List(Of CellRange), ByVal list2 As List(Of CellRange)) As Boolean
        If list1 Is Nothing AndAlso list2 Is Nothing Then
            Return True
        End If

        If list1 Is Nothing OrElse list2 Is Nothing Then
            Return False
        End If

        If list1.Count <> list2.Count Then
            Return False
        End If

        For i = 0 To list1.Count - 1

            If Not Equals(list1(i), list2(i)) Then
                Return False
            End If
        Next

        Return True
    End Function

#End Region

#End Region

#Region "Themes"

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))

        For Each theme In themes
            ribbonComboBoxTheme.Items.Add(theme)
        Next

        ribbonComboBoxTheme.SelectedIndex = ribbonComboBoxTheme.Items.IndexOf("Office365White")
    End Sub

    Private Sub ribbonComboBoxTheme_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonComboBoxTheme.SelectedIndexChanged
        C1ThemeController.ApplicationTheme = ribbonComboBoxTheme.SelectedItem.Text
    End Sub

#End Region

#Region "DataSource"

    Private Function GetDataSource() As DataTable
        Dim rs = "select * from Products;"
        Dim cn = GetConnectionString()
        Dim da = New OleDbDataAdapter(rs, cn)
        Dim dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Private Shared Function GetConnectionString() As String
        Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

#End Region

End Class
