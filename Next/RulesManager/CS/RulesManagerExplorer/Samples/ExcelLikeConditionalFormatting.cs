using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RulesManagerExplorer.Samples
{
    using RulesManagerExplorer.Samples.Presets;
    using C1.Win.Ribbon;
    using C1.Win.RulesManager;
    using C1.Win.RulesManager.Model;
    using C1.Win.FlexGrid;
    using RulesManagerExplorer.Samples.Dialogs;
    using RulesManagerExplorer.Data;
    using System.Reflection;
    using System.Resources;
    using System.Globalization;
    using C1.Framework;

    public partial class ExcelLikeConditionalFormatting : UserControl
    {
        #region Initialization

        public ExcelLikeConditionalFormatting()
        {
            InitializeComponent();
            dockingTabPageConditionalFormatting.TabVisible = true;
        }

        private void ExcelLikeConditionalFormatting_Load(object sender, EventArgs e)
        {
            flexGrid.DataSource = DataSource.GetRows("Select * from Products Limit 100");
            InitImages();
        }

        #endregion

        #region Highlight cells rules applying

        private void ribbonButtonGreaterThan_Click(object sender, EventArgs e)
        {
            using (var form = new GreaterThanForm())
            {
                ShowSingleValueConditionalFormattingForm(form, "= [CurrentValue] > {0}");
            }
        }

        private void ribbonButtonLessThan_Click(object sender, EventArgs e)
        {
            using (var form = new LessThanForm())
            {
                ShowSingleValueConditionalFormattingForm(form, "= [CurrentValue] < {0}");
            }
        }

        private void ribbonButtonBetween_Click(object sender, EventArgs e)
        {
            using (var form = new BetweenForm())
            {
                ShowBetweenForm(form);
            }
        }

        private void ribbonButtonEqualTo_Click(object sender, EventArgs e)
        {
            using (var form = new EqualToForm())
            {
                ShowSingleValueConditionalFormattingForm(form, "= [CurrentValue] = {0}");
            }
        }

        private void ribbonButtonTextThatContains_Click(object sender, EventArgs e)
        {
            using (var form = new TextThatContainsForm())
            {
                ShowSingleValueConditionalFormattingForm(form, "= Contains([CurrentValue], {0})");
            }
        }

        #endregion

        #region Data bars applying

        #region Gradient fill

        private void ribbonGalleryItemBlueGradientDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.GradientDataBars[DataBar.Blue]);
        }

        private void ribbonGalleryItemGreenGradientDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.GradientDataBars[DataBar.Green]);
        }

        private void ribbonGalleryItemRedGradientDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.GradientDataBars[DataBar.Red]);
        }

        private void ribbonGalleryItemOrangeGradientDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.GradientDataBars[DataBar.Orange]);
        }

        private void ribbonGalleryItemLightBlueGradientDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.GradientDataBars[DataBar.LightBlue]);
        }

        private void ribbonGalleryItemPurpleGradientDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.GradientDataBars[DataBar.Purple]);
        }

        #endregion

        #region Solid fill

        private void ribbonGalleryItemBlueDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.SolidDataBars[DataBar.Blue]);
        }

        private void ribbonGalleryItemGreenDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.SolidDataBars[DataBar.Green]);
        }

        private void ribbonGalleryItemRedDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.SolidDataBars[DataBar.Red]);
        }

        private void ribbonGalleryItemOrangeDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.SolidDataBars[DataBar.Orange]);
        }

        private void ribbonGalleryItemLightBlueDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.SolidDataBars[DataBar.LightBlue]);
        }

        private void ribbonGalleryItemPurpleDataBar_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.SolidDataBars[DataBar.Purple]);
        }

        #endregion

        #endregion

        #region Color scales applying

        private void ribbonGalleryItemGreenYellowRedColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.GreenYellowRed]);
        }

        private void ribbonGalleryItemRedYellowGreenColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.RedYellowGreen]);
        }

        private void ribbonGalleryItemGreenWhiteRedColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.GreenWhiteRed]);
        }

        private void ribbonGalleryItemRedWhiteGreenColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.RedWhiteGreen]);
        }

        private void ribbonGalleryItemBlueWhiteRedColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.BlueWhiteRed]);
        }

        private void ribbonGalleryItemRedWhiteBlueColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.RedWhiteBlue]);
        }

        private void ribbonGalleryItemWhiteRedColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.WhiteRed]);
        }

        private void ribbonGalleryItemRedWhiteColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.RedWhite]);
        }

        private void ribbonGalleryItemGreenWhiteColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.GreenWhite]);
        }

        private void ribbonGalleryItemWhiteGreenColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.WhiteGreen]);
        }

        private void ribbonGalleryItemGreenYellowColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.GreenYellow]);
        }

        private void ribbonGalleryItemYellowGreenColorScale_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.ColorScales[ColorScale.YellowGreen]);
        }

        #endregion

        #region Icon sets applying

        private void ribbonGalleryItemThreeArrowsIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.ThreeArrows]);
        }

        private void ribbonGalleryItemThreeTrianglesIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.ThreeTriangles]);
        }

        private void ribbonGalleryItemFourArrowsIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.FourArrows]);
        }

        private void ribbonGalleryItemFiveArrowsIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.FiveArrows]);
        }

        private void ribbonGalleryItemThreeTrafficLightsUnrimmedIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.ThreeTrafficLightsUnrimmed]);
        }

        private void ribbonGalleryItemThreeTrafficLightsRimmedIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.ThreeTrafficLightsRimmed]);
        }

        private void ribbonGalleryItemThreeSignsIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.ThreeSigns]);
        }

        private void ribbonGalleryItemThreeSymbolsCircledIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.ThreeSymbolsCircled]);
        }

        private void ribbonGalleryItemThreeSymbolsUncircledIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.ThreeSymbolsUncircled]);
        }

        private void ribbonGalleryItemThreeFlagsIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.ThreeFlags]);
        }

        private void ribbonGalleryItemThreeStarsIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.ThreeStars]);
        }

        private void ribbonGalleryItemFiveQuartersIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.FiveQuarters]);
        }

        private void ribbonGalleryItemFiveRatingsIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.FiveRatings]);
        }

        private void ribbonGalleryItemFiveBoxesIconSet_Click(object sender, EventArgs e)
        {
            ApplyStyleToSelectedRange(StylePresets.IconSets[IconSetMode.FiveBoxes]);
        }

        #endregion

        #region Rules management

        private void ribbonButtonManageRules_Click(object sender, EventArgs e)
        {
            dockingTabPageConditionalFormatting.TabVisible = !dockingTabPageConditionalFormatting.TabVisible;
        }

        #endregion

        #region Rules clearing

        private void ribbonButtonClearRulesFromSelectedCells_Click(object sender, EventArgs e)
        {
            var rules = rulesManager?.Rules;
            if (rules == null)
            {
                return;
            }

            var selection = flexGrid.Selection;

            var rulesForRemove = new List<IRule>();
            foreach (var rule in rules)
            {
                if (rule == null)
                {
                    continue;
                }

                var ranges = rule.AppliesTo;
                if (ranges == null ||
                    ranges.Count == 0)
                {
                    var gridCellRange = flexGrid.GetCellRange(
                        flexGrid.Rows.Fixed,
                        flexGrid.Cols.Fixed,
                        flexGrid.Rows.Count - 1,
                        flexGrid.Cols.Count - 1);

                    if (Equals(gridCellRange, selection))
                    {
                        rulesForRemove.Add(rule);
                        continue;
                    }

                    var diffRanges = GetDiff(gridCellRange, selection);
                    if (diffRanges == null ||
                        diffRanges.Count == 0)
                    {
                        rulesForRemove.Add(rule);
                        continue;
                    }

                    foreach (var diffRange in diffRanges)
                    {
                        ranges.Add(GetItemRange(diffRange));
                    }
                }

                RemoveCellRangeFromItemRanges(selection, ranges);

                if (ranges.Count == 0)
                {
                    rulesForRemove.Add(rule);
                }
            }

            foreach (var rule in rulesForRemove)
            {
                rules.Remove(rule);
            }
        }

        private void ribbonButtonClearRulesFromAllCells_Click(object sender, EventArgs e)
        {
            rulesManager.Rules.Clear();
        }

        #endregion

        #region Utilities

        #region Form showing

        private void ShowSingleValueConditionalFormattingForm(SingleValueConditionalFormattingForm form, string singleValueExpression)
        {
            if (form == null)
            {
                return;
            }

            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
            {
                return;
            }

            var val = form.Value;
            if (string.IsNullOrEmpty(val))
            {
                return;
            }

            var itemRange = GetItemRange(flexGrid.Selection);
            var expressionString = string.Format(singleValueExpression, val);
            var stylePreset = form.SelectedStylePreset;
            var rule = new C1.Win.RulesManager.Rule()
            {
                Name = expressionString + " on " + itemRange.ToString(),
                Expression = expressionString,
                Style = StylePresets.Highlights[stylePreset]
            };
            rule.AppliesTo.Add(itemRange);

            rulesManager.Rules.Add(rule);
        }

        private void ShowBetweenForm(BetweenForm form)
        {
            if (form == null)
            {
                return;
            }

            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
            {
                return;
            }

            var minimumVal = form.MinimumValue;
            if (string.IsNullOrEmpty(minimumVal))
            {
                return;
            }

            var maximumVal = form.MaximumValue;
            if (string.IsNullOrEmpty(maximumVal))
            {
                return;
            }

            var itemRange = GetItemRange(flexGrid.Selection);
            var expressionString = $"= {minimumVal} <= [CurrentValue] And [CurrentValue] <= {maximumVal}";
            var stylePreset = form.SelectedStylePreset;
            var rule = new C1.Win.RulesManager.Rule()
            {
                Name = expressionString + " on " + itemRange.ToString(),
                Expression = expressionString,
                Style = StylePresets.Highlights[stylePreset]
            };
            rule.AppliesTo.Add(itemRange);

            rulesManager.Rules.Add(rule);
        }

        #endregion

        #region ItemStyle applying

        private void ApplyStyleToSelectedRange(ItemStyle style)
        {
            var itemRange = GetItemRange(flexGrid.Selection);
            var expressionString = "= true";
            var rule = new C1.Win.RulesManager.Rule()
            {
                Name = expressionString + " on " + itemRange.ToString(),
                Expression = expressionString,
                Style = style
            };

            rule.AppliesTo.Add(itemRange);

            rulesManager.Rules.Add(rule);
        }

        #endregion

        #region CellRange to ItemRange converting

        private IItemRange GetItemRange(CellRange cellRange)
        {
            var gridCellRange = flexGrid.GetCellRange(
                        flexGrid.Rows.Fixed,
                        flexGrid.Cols.Fixed,
                        flexGrid.Rows.Count - 1,
                        flexGrid.Cols.Count - 1);

            if (cellRange.LeftCol == gridCellRange.LeftCol &&
                cellRange.RightCol == gridCellRange.RightCol)
            {
                return new ItemRange(cellRange.TopRow, cellRange.BottomRow);
            }

            var fields = new List<string>();
            for (var c = cellRange.LeftCol; c <= cellRange.RightCol; c++)
            {
                fields.Add(flexGrid.Cols[c].Name);
            }

            if (cellRange.TopRow == gridCellRange.TopRow &&
                cellRange.BottomRow == gridCellRange.BottomRow)
            {
                return new FieldRange(fields);
            }

            var fieldNames = string.Join(",", fields.Select(field => $"[{field}]"));
            return new CustomItemRange($"{cellRange.TopRow}:{cellRange.BottomRow}:{fieldNames}");
        }

        #endregion

        #region Exclusion of CellRange from ItemRange

        private void RemoveCellRangeFromItemRanges(CellRange selection, ItemRangeCollection ranges)
        {
            var rangeIndex = 0;
            while (rangeIndex < ranges.Count)
            {
                var range = ranges[rangeIndex];
                if (range == null)
                {
                    rangeIndex++;
                    continue;
                }

                var cellRanges = GetCellRanges(range);
                if (cellRanges == null ||
                    cellRanges.Count == 0)
                {
                    rangeIndex++;
                    continue;
                }

                var diffRanges = GetItemRangeDiff(cellRanges, selection);
                if (diffRanges == null ||
                    diffRanges.Count == 0)
                {
                    ranges.RemoveAt(rangeIndex);
                    continue;
                }

                if (AreRangeListsEqual(cellRanges, diffRanges))
                {
                    rangeIndex++;
                    continue;
                }

                ranges[rangeIndex] = GetItemRange(diffRanges[0]);
                rangeIndex++;

                if (diffRanges.Count > 1)
                {
                    for (var diffRangeIndex = 1; diffRangeIndex < diffRanges.Count; diffRangeIndex++)
                    {
                        ranges.Insert(rangeIndex, GetItemRange(diffRanges[diffRangeIndex]));
                        rangeIndex++;
                    }
                }
            }
        }

        #region ItemRange to CellRange converting

        private List<CellRange> GetCellRanges(IItemRange range)
        {
            List<CellRange> cellRanges = null;
            if (range is ItemRange)
            {
                var itemRange = (ItemRange)range;
                cellRanges = new List<CellRange>()
                {
                    flexGrid.GetCellRange(
                        itemRange.FirstItem,
                        flexGrid.Cols.Fixed,
                        itemRange.LastItem,
                        flexGrid.Cols.Count - 1)
                };
            }
            else if (range is FieldRange)
            {
                var fieldRange = (FieldRange)range;
                cellRanges = GetCellRanges(
                    fieldRange?.Fields,
                    flexGrid.Rows.Fixed,
                    flexGrid.Rows.Count - 1);
            }
            else if (range is CustomItemRange)
            {
                var customItemRange = (CustomItemRange)range;
                cellRanges = GetCellRanges(
                    customItemRange?.Fields,
                    customItemRange.FirstItem,
                    customItemRange.LastItem);
            }

            return cellRanges;
        }

        private List<CellRange> GetCellRanges(string[] fields, int topRowIndex, int bottomRowIndex)
        {
            if (fields == null ||
                fields.Length == 0)
            {
                return null;
            }

            var columns = flexGrid?.Cols;
            if (columns == null)
            {
                return null;
            }

            var columnIndices = GetColumnIndices(fields, columns);
            if (columnIndices.Count == 0)
            {
                return null;
            }

            columnIndices.Sort();

            return GetContinuousCellRanges(columnIndices, topRowIndex, bottomRowIndex);
        }

        #endregion

        private static List<int> GetColumnIndices(string[] fields, ColumnCollection columns)
        {
            var columnIndexes = new List<int>();
            foreach (var field in fields)
            {
                var column = columns[field];
                if (column == null)
                {
                    continue;
                }

                var columnIndex = column.Index;
                if (columnIndex == -1)
                {
                    continue;
                }

                columnIndexes.Add(columnIndex);
            }

            return columnIndexes;
        }

        private List<CellRange> GetContinuousCellRanges(List<int> columnIndices, int topRowIndex, int bottomRowIndex)
        {
            var cellRanges = new List<CellRange>();
            var currentColumnIndex = columnIndices[0];
            var leftColumnIndex = currentColumnIndex;
            var rightColumnIndex = currentColumnIndex;

            if (columnIndices.Count == 1)
            {
                cellRanges.Add(flexGrid.GetCellRange(
                    topRowIndex,
                    leftColumnIndex,
                    bottomRowIndex,
                    rightColumnIndex));

                return cellRanges;
            }

            for (var c = 1; c < columnIndices.Count; c++)
            {
                currentColumnIndex = columnIndices[c];
                if (currentColumnIndex - rightColumnIndex > 1)
                {
                    cellRanges.Add(flexGrid.GetCellRange(
                        topRowIndex,
                        leftColumnIndex,
                        bottomRowIndex,
                        rightColumnIndex));

                    leftColumnIndex = currentColumnIndex;
                    rightColumnIndex = currentColumnIndex;
                }
                else if (c == columnIndices.Count - 1)
                {
                    rightColumnIndex = currentColumnIndex;

                    cellRanges.Add(flexGrid.GetCellRange(
                        topRowIndex,
                        leftColumnIndex,
                        bottomRowIndex,
                        rightColumnIndex));
                }
                else
                {
                    rightColumnIndex = currentColumnIndex;
                }
            }

            return cellRanges;
        }

        private List<CellRange> GetItemRangeDiff(List<CellRange> originals, CellRange exclusion)
        {
            var diff = new List<CellRange>();
            foreach (var original in originals)
            {
                diff.AddRange(GetDiff(original, exclusion));
            }

            return diff;
        }

        private List<CellRange> GetDiff(CellRange original, CellRange exclusion)
        {
            var diff = new List<CellRange>();
            if (!AreRangesIntersect(original, exclusion))
            {
                diff.Add(original);
                return diff;
            }

            var intersection = GetRangesIntersection(original, exclusion);
            if (original.TopRow < intersection.TopRow)
            {
                diff.Add(flexGrid.GetCellRange(
                    original.TopRow,
                    original.LeftCol,
                    intersection.TopRow - 1,
                    original.RightCol));
            }

            if (original.LeftCol < intersection.LeftCol)
            {
                diff.Add(flexGrid.GetCellRange(
                    intersection.TopRow,
                    original.LeftCol,
                    intersection.BottomRow,
                    intersection.LeftCol - 1));
            }

            if (original.BottomRow > intersection.BottomRow)
            {
                diff.Add(flexGrid.GetCellRange(
                    intersection.BottomRow + 1,
                    original.LeftCol,
                    original.BottomRow,
                    original.RightCol));
            }

            if (original.RightCol > intersection.RightCol)
            {
                diff.Add(flexGrid.GetCellRange(
                    intersection.TopRow,
                    intersection.RightCol + 1,
                    intersection.BottomRow,
                    original.RightCol));
            }

            return diff;
        }

        #endregion

        #region CellRange intersection

        private bool AreRangesIntersect(CellRange rg1, CellRange rg2)
        {
            if (rg1.BottomRow < rg2.TopRow ||
                rg1.TopRow > rg2.BottomRow ||
                rg1.RightCol < rg2.LeftCol ||
                rg1.LeftCol > rg2.RightCol)
            {
                return false;
            }

            return true;
        }

        internal CellRange GetRangesIntersection(CellRange rg1, CellRange rg2)
        {
            rg1.r1 = Math.Max(rg1.TopRow, rg2.TopRow);
            rg1.r2 = Math.Min(rg1.BottomRow, rg2.BottomRow);
            rg1.c1 = Math.Max(rg1.LeftCol, rg2.LeftCol);
            rg1.c2 = Math.Min(rg1.RightCol, rg2.RightCol);

            return rg1;
        }

        #endregion

        #region CellRange lists comparison

        private bool AreRangeListsEqual(List<CellRange> list1, List<CellRange> list2)
        {
            if (list1 == null &&
                list2 == null)
            {
                return true;
            }

            if (list1 == null ||
                list2 == null)
            {
                return false;
            }

            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (var i = 0; i < list1.Count; i++)
            {
                if (!Equals(list1[i], list2[i]))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        #endregion

        #region Init images
        static Image LoadImage(string resourceName)
        {
            var resource = "RulesManagerExplorer.Properties.Resources";
            Assembly assembly = Assembly.GetExecutingAssembly();

            var manager = new ResourceManager(resource, assembly);
            if (manager is null)
                return null;

            return manager.GetObject(resourceName, CultureInfo.InvariantCulture) as Image;
        }

        private C1BitmapIcon GetBitmapIcon(string name )
        {
            Image image = LoadImage(name);
            if (image is null)
                return null;

            return new C1BitmapIcon(name, new Size(32, 32), Color.Transparent, image);
        }

        private C1BitmapIcon GetBitmapIcon124(string name)
        {
            Image image = LoadImage(name);
            if (image is null)
                return null;

            return new C1BitmapIcon(name, new Size(124, 24), Color.Transparent, image);
        }

        private void InitImages()
        {
            ribbonMenuConditionalFormatting.IconSet.Add(GetBitmapIcon("ConditionalFormatting32x32"));
            ribbonMenuHighlightCellsRules.IconSet.Add(GetBitmapIcon("HighlightCellsRules32x32"));
            ribbonGalleryColorScales.IconSet.Add(GetBitmapIcon("ColorScales32x32"));
            ribbonGalleryIconSets.IconSet.Add(GetBitmapIcon("IconSets32x32"));
            ribbonButtonManageRules.IconSet.Add(GetBitmapIcon("ManageRules32x32"));
            ribbonMenuClearRules.IconSet.Add(GetBitmapIcon("ClearRules32x32"));
            ribbonGalleryDataBars.IconSet.Add(GetBitmapIcon("DataBars32x32"));
            ribbonButtonGreaterThan.IconSet.Add(GetBitmapIcon("GreaterThan32x32"));
            ribbonButtonLessThan.IconSet.Add(GetBitmapIcon("LessThan32x32"));
            ribbonButtonBetween.IconSet.Add(GetBitmapIcon("Between32x32"));
            ribbonButtonEqualTo.IconSet.Add(GetBitmapIcon("EqualTo32x32"));
            ribbonButtonTextThatContains.IconSet.Add(GetBitmapIcon("TextThatContains32x32"));
            // Gradient
            ribbonGalleryItemBlueGradientDataBar.IconSet.Add(GetBitmapIcon("GradientDataBarBlue32x32"));
            ribbonGalleryItemRedGradientDataBar.IconSet.Add(GetBitmapIcon("GradientDataBarRed32x32"));
            ribbonGalleryItemOrangeGradientDataBar.IconSet.Add(GetBitmapIcon("GradientDataBarOrange32x32"));
            ribbonGalleryItemLightBlueGradientDataBar.IconSet.Add(GetBitmapIcon("GradientDataBarLightBlue32x32"));
            ribbonGalleryItemPurpleGradientDataBar.IconSet.Add(GetBitmapIcon("GradientDataBarPurple32x32"));
            ribbonGalleryItemGreenGradientDataBar.IconSet.Add(GetBitmapIcon("GradientDataBarGreen32x32"));
            // Solid
            ribbonGalleryItemGreenDataBar.IconSet.Add(GetBitmapIcon("SolidDataBarGreen32x32"));
            ribbonGalleryItemBlueDataBar.IconSet.Add(GetBitmapIcon("SolidDataBarBlue32x32"));
            ribbonGalleryItemRedDataBar.IconSet.Add(GetBitmapIcon("SolidDataBarRed32x32"));
            ribbonGalleryItemOrangeDataBar.IconSet.Add(GetBitmapIcon("SolidDataBarOrange32x32"));
            ribbonGalleryItemLightBlueDataBar.IconSet.Add(GetBitmapIcon("SolidDataBarLightBlue32x32"));
            ribbonGalleryItemPurpleDataBar.IconSet.Add(GetBitmapIcon("SolidDataBarPurple32x32"));

            ribbonGalleryItemGreenYellowRedColorScale.IconSet.Add(GetBitmapIcon("ColorScaleGreenYellowRed32x32"));
            ribbonGalleryItemRedYellowGreenColorScale.IconSet.Add(GetBitmapIcon("ColorScaleRedYellowGreen32x32"));
            ribbonGalleryItemGreenWhiteRedColorScale.IconSet.Add(GetBitmapIcon("ColorScaleGreenWhiteRed32x32"));
            ribbonGalleryItemRedWhiteGreenColorScale.IconSet.Add(GetBitmapIcon("ColorScaleRedWhiteGreen32x32"));
            ribbonGalleryItemBlueWhiteRedColorScale.IconSet.Add(GetBitmapIcon("ColorScaleBlueWhiteRed32x32"));
            ribbonGalleryItemRedWhiteBlueColorScale.IconSet.Add(GetBitmapIcon("ColorScaleRedWhiteBlue32x32"));
            ribbonGalleryItemWhiteRedColorScale.IconSet.Add(GetBitmapIcon("ColorScaleWhiteRed32x32"));
            ribbonGalleryItemRedWhiteColorScale.IconSet.Add(GetBitmapIcon("ColorScaleRedWhite32x32"));
            ribbonGalleryItemGreenWhiteColorScale.IconSet.Add(GetBitmapIcon("ColorScaleGreenWhite32x32"));
            ribbonGalleryItemWhiteGreenColorScale.IconSet.Add(GetBitmapIcon("ColorScaleWhiteGreen32x32"));
            ribbonGalleryItemGreenYellowColorScale.IconSet.Add(GetBitmapIcon("ColorScaleGreenYellow32x32"));
            ribbonGalleryItemYellowGreenColorScale.IconSet.Add(GetBitmapIcon("ColorScaleYellowGreen32x32"));
            // Directional
            ribbonGalleryItemThreeArrowsIconSet.IconSet.Add(GetBitmapIcon124("IconSetThreeArrows124x24"));
            ribbonGalleryItemThreeTrianglesIconSet.IconSet.Add(GetBitmapIcon124("IconSetThreeTriangles124x24"));
            ribbonGalleryItemFourArrowsIconSet.IconSet.Add(GetBitmapIcon124("IconSetFourArrows124x24"));
            ribbonGalleryItemFiveArrowsIconSet.IconSet.Add(GetBitmapIcon124("IconSetFiveArrows124x24"));
            ribbonGalleryItemThreeTrafficLightsUnrimmedIconSet.IconSet.Add(GetBitmapIcon124("IconSetThreeTrafficLightsUnrimmed124x24"));
            ribbonGalleryItemThreeTrafficLightsRimmedIconSet.IconSet.Add(GetBitmapIcon124("IconSetThreeTrafficLightsRimmed124x24"));
            ribbonGalleryItemThreeSignsIconSet.IconSet.Add(GetBitmapIcon124("IconSetThreeSigns124x24"));
            // Indicators
            ribbonGalleryItemThreeSymbolsCircledIconSet.IconSet.Add(GetBitmapIcon124("IconSetThreeSymbolsCircled124x24"));
            ribbonGalleryItemThreeSymbolsUncircledIconSet.IconSet.Add(GetBitmapIcon124("IconSetThreeSymbolsUncircled124x24"));
            ribbonGalleryItemThreeFlagsIconSet.IconSet.Add(GetBitmapIcon124("IconSetThreeFlags124x24"));
            ribbonGalleryItemThreeStarsIconSet.IconSet.Add(GetBitmapIcon124("IconSetThreeStars124x24"));
            ribbonGalleryItemFiveQuartersIconSet.IconSet.Add(GetBitmapIcon124("IconSetFiveQuarters124x24"));
            ribbonGalleryItemFiveRatingsIconSet.IconSet.Add(GetBitmapIcon124("IconSetFiveRatings124x24"));
            ribbonGalleryItemFiveBoxesIconSet.IconSet.Add(GetBitmapIcon124("IconSetFiveBoxes124x24"));
        }

        #endregion
    }
}
