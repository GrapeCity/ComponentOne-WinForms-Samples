using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RulesManagerExplorer.Samples
{
    using C1.Win;
    using C1.Win.Chart.Interaction;
    using C1.Win.Ribbon;
    using C1.Win.RulesManager;
    using System.Collections.Generic;

    public partial class ChartConditionalFormatting : UserControl
    {
        private const string xmlFileName = "ChartConditionalFormattingRules.xml";
        private string pathToXmlFile = null;
        private AccessibleObject lastRuleUnderMouse = null;
        private const string toolTipText = "Click on Rule to Edit";

        #region Initialization

        public ChartConditionalFormatting()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var dataSource = DataSources.GetDataSource();

            formattablePieChart.ToolTip.Content = "{name} : {value}";
            formattablePieChart.DataSource = dataSource;
            formattablePieChart.DataSourceChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));

            formattableFlexChart.DataSource = dataSource;
            formattableFlexChart.DataSourceChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));

            var horizontalScrollbar = new AxisScrollbar(formattableFlexChart.AxisX);
            horizontalScrollbar.ScrollButtonsVisible = false;

            ApplyRules();

            //uncomment line below to allow saving of changed rules in xml file and loading of it on startup of application
            rulesManager.RulesChanged += RulesManager_RulesChanged;
        }

        private void ApplyRules()
        {
            pathToXmlFile = Path.Combine(Directory.GetCurrentDirectory(), xmlFileName);

            if (!File.Exists(pathToXmlFile))
            {
                ApplyPredefinedRules();
            }
            else
            {
                rulesManager.LoadRules(pathToXmlFile);
            }
        }

        private void ApplyPredefinedRules()
        {
            var rule1 = new C1.Win.RulesManager.Rule()
            {
                Name = "Product rating",
                Expression = "= true",
                Style = new ItemStyle()
                {
                    Gradient = new GradientSettings()
                    {
                        IconList = IconListKey.Star,
                        IconPoints = new GradientPoint[]
                        {
                            new GradientPoint(GradientPointType.MinValue),
                            new GradientPoint(GradientPointType.MaxValue)
                        }
                    }
                }
            };
            rule1.AppliesTo.Add(new FieldRange(new string[] { "UnitsOnOrder" }));
            rulesManager.Rules.Add(rule1);

            var rule2 = new C1.Win.RulesManager.Rule()
            {
                Name = "Stock availability",
                Expression = "= true",
                Style = new ItemStyle()
                {
                    Gradient = new GradientSettings()
                    {
                        IconList = IconListKey.TrafficLight,
                        IconPoints = new GradientPoint[]
                        {
                            new GradientPoint(GradientPointType.MinValue),
                            new GradientPoint(GradientPointType.MaxValue)
                        }
                    }
                }
            };
            rule2.AppliesTo.Add(new FieldRange(new string[] { "UnitsInStock" }));
            rulesManager.Rules.Add(rule2);
        }

        private void RulesManager_RulesChanged(object sender, ListChangedEventArgs e)
        {
            rulesManager.SaveRules(pathToXmlFile);
        }

        #endregion

        private void ChartConditionalFormatting_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                LoadData();
        }

        #region Rules manager UI visibility management

        private void ribbonToggleButtonManageRules_PressedChanged(object sender, EventArgs e)
        {
            var ribbonToggleButton = sender as RibbonToggleButton;
            if (ribbonToggleButton == null)
            {
                return;
            }

            dockingTabPageConditionalFormatting.TabVisible = ribbonToggleButton.Pressed;
        }

        private void ribbonCheckBoxHeader_CheckedChanged(object sender, EventArgs e)
        {
            var ribbonCheckBox = sender as RibbonCheckBox;
            if (ribbonCheckBox == null)
            {
                return;
            }

            rulesManager.Options.IsHeaderVisible = ribbonCheckBox.Checked;
        }

        private void ribbonCheckBoxAddButton_CheckedChanged(object sender, EventArgs e)
        {
            var ribbonCheckBox = sender as RibbonCheckBox;
            if (ribbonCheckBox == null)
            {
                return;
            }

            rulesManager.Options.IsAddButtonVisible = ribbonCheckBox.Checked;
        }

        private void ribbonCheckBoxRemoveButton_CheckedChanged(object sender, EventArgs e)
        {
            var ribbonCheckBox = sender as RibbonCheckBox;
            if (ribbonCheckBox == null)
            {
                return;
            }

            rulesManager.Options.IsRemoveButtonVisible = ribbonCheckBox.Checked;
        }

        private void ribbonCheckBoxRuleName_CheckedChanged(object sender, EventArgs e)
        {
            var ribbonCheckBox = sender as RibbonCheckBox;
            if (ribbonCheckBox == null)
            {
                return;
            }

            rulesManager.Options.IsRuleNameVisible = ribbonCheckBox.Checked;
        }

        private void ribbonCheckBoxRangeSelector_CheckedChanged(object sender, EventArgs e)
        {
            var ribbonCheckBox = sender as RibbonCheckBox;
            if (ribbonCheckBox == null)
            {
                return;
            }

            rulesManager.Options.IsRangeSelectorVisible = ribbonCheckBox.Checked;
        }

        private void ribbonCheckBoxCondition_CheckedChanged(object sender, EventArgs e)
        {
            var ribbonCheckBox = sender as RibbonCheckBox;
            if (ribbonCheckBox == null)
            {
                return;
            }

            rulesManager.Options.IsConditionVisible = ribbonCheckBox.Checked;
        }

        #endregion

        #region ToolTip showing

        private void rulesManager_MouseMove(object sender, MouseEventArgs e)
        {
            var rulesManager = sender as C1RulesManager;
            if (rulesManager == null)
            {
                return;
            }

            var previousRule = lastRuleUnderMouse;
            var mousePointOnScreen = rulesManager.PointToScreen(new Point(e.X, e.Y));
            lastRuleUnderMouse = GetRuleFromMousePosition(mousePointOnScreen, rulesManager);
            if (lastRuleUnderMouse == null)
            {
                // ***
                //superTooltip.Hide(rulesManager);
                return;
            }

            if (previousRule != lastRuleUnderMouse)
            {
                // ***
                // var textWidth = TextRenderer.MeasureText(toolTipText, superTooltip.Font).Width;
                //superTooltip.Show(toolTipText, rulesManager, rulesManager.PointToClient(
                //    new Point(
                //        lastRuleUnderMouse.Bounds.X + lastRuleUnderMouse.Bounds.Width / 2 - textWidth / 2,
                //        lastRuleUnderMouse.Bounds.Y + lastRuleUnderMouse.Bounds.Height
                //        )
                //    ));
            }
        }

        private void rulesManager_MouseLeave(object sender, EventArgs e)
        {
            // ***
            //superTooltip.Hide(rulesManager);
            lastRuleUnderMouse = null;
        }

        private AccessibleObject GetRuleFromMousePosition(Point mousePoint, C1RulesManager rulesManager)
        {
            var controlChildren = rulesManager.Controls;
            if (controlChildren == null)
            {
                return null;
            }

            var controlChildrenCount = controlChildren.Count;
            if (controlChildrenCount == 0)
            {
                return null;
            }

            var xView = controlChildren[0];
            if (xView == null)
            {
                return null;
            }

            var rulesManagerPanelAccessibilityObject = xView.AccessibilityObject;
            if (rulesManagerPanelAccessibilityObject == null)
            {
                return null;
            }

            var accessibilityObjectChildrenCount = rulesManagerPanelAccessibilityObject.GetChildCount();
            if (accessibilityObjectChildrenCount == 0)
            {
                return null;
            }

            var rulesListAccessibilityObject = rulesManagerPanelAccessibilityObject.GetChild(0);
            if (rulesListAccessibilityObject == null)
            {
                return null;
            }

            var rulesListAccessibilityObjectChildrenCount = rulesListAccessibilityObject.GetChildCount();
            if (rulesListAccessibilityObjectChildrenCount == 0)
            {
                return null;
            }

            for (var childIndex = 0; childIndex < rulesListAccessibilityObjectChildrenCount; childIndex++)
            {
                var ruleAccessibilityObject = rulesListAccessibilityObject.GetChild(childIndex);
                if (ruleAccessibilityObject != null &&
                    ruleAccessibilityObject.Name == "Rule" &&
                    ruleAccessibilityObject.Bounds.Contains(mousePoint))
                {
                    return ruleAccessibilityObject;
                }
            }

            return null;
        }

        #endregion
    }
}
