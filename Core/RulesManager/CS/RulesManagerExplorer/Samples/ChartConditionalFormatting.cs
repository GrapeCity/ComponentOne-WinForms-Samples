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
            var dataSource = GetDataSource();

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

        #region DataSource

        private class Products
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int SupplierID { get; set; }
            public int CategoryID { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal UnitsInStock { get; set; }
            public decimal UnitsOnOrder { get; set; }
            public int ReorderLevel { get; set; }
            public int Discontinued { get; set; }
        }

        private DataTable GetDataSource()
        {
            var items = new List<Products>()
            {
                new Products()
                {
                    ProductID = 2,
                    ProductName = "Chang",
                    SupplierID = 1,
                    CategoryID = 1,
                    QuantityPerUnit = "24 - 12 oz bottles",
                    UnitPrice = 19.00m,
                    UnitsInStock = 17m,
                    UnitsOnOrder = 40m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 3,
                    ProductName = "Aniseed Syrup",
                    SupplierID = 1,
                    CategoryID = 2,
                    QuantityPerUnit = "12 - 550 ml bottles",
                    UnitPrice = 10.00m,
                    UnitsInStock = 13m,
                    UnitsOnOrder = 70m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 11,
                    ProductName = "Queso Cabrales",
                    SupplierID = 5,
                    CategoryID = 4,
                    QuantityPerUnit = "1 kg pkg.",
                    UnitPrice = 21.00m,
                    UnitsInStock = 22m,
                    UnitsOnOrder = 30m,
                    ReorderLevel = 30,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 21,
                    ProductName = "Sir Rodney's Scones",
                    SupplierID = 8,
                    CategoryID = 3,
                    QuantityPerUnit = "24 pkgs. x 4 pieces",
                    UnitPrice = 10.00m,
                    UnitsInStock = 3m,
                    UnitsOnOrder = 40m,
                    ReorderLevel = 5,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 32,
                    ProductName = "Mascarpone Fabioli",
                    SupplierID = 14,
                    CategoryID = 4,
                    QuantityPerUnit = "24 - 200 g pkgs.",
                    UnitPrice = 32.00m,
                    UnitsInStock = 9m,
                    UnitsOnOrder = 40m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 37,
                    ProductName = "Gravad lax",
                    SupplierID = 17,
                    CategoryID = 8,
                    QuantityPerUnit = "12 - 500 g pkgs.",
                    UnitPrice = 26.00m,
                    UnitsInStock = 11m,
                    UnitsOnOrder = 50m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 43,
                    ProductName = "Ipoh Coffee",
                    SupplierID = 20,
                    CategoryID = 1,
                    QuantityPerUnit = "16 - 500 g tins",
                    UnitPrice = 46.00m,
                    UnitsInStock = 17m,
                    UnitsOnOrder = 10m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 45,
                    ProductName = "Rogede sild",
                    SupplierID = 21,
                    CategoryID = 8,
                    QuantityPerUnit = "1k pkg.",
                    UnitPrice = 9.50m,
                    UnitsInStock = 5m,
                    UnitsOnOrder = 70m,
                    ReorderLevel = 15,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 48,
                    ProductName = "Chocolade",
                    SupplierID = 22,
                    CategoryID = 3,
                    QuantityPerUnit = "10 pkgs.",
                    UnitPrice = 12.75m,
                    UnitsInStock = 15m,
                    UnitsOnOrder = 70m,
                    ReorderLevel = 25,
                    Discontinued = 0
                },
                new Products()
                {
                    ProductID = 49,
                    ProductName = "Maxilaku",
                    SupplierID = 23,
                    CategoryID = 3,
                    QuantityPerUnit = "24 - 50 g pkgs.",
                    UnitPrice = 20.00m,
                    UnitsInStock = 10m,
                    UnitsOnOrder = 60m,
                    ReorderLevel = 15,
                    Discontinued = 0
                }
            };
            var table = new DataTable("Products");

            var properties = typeof(Products).GetProperties()
                .Where(x => x.MemberType == System.Reflection.MemberTypes.Property)
                .Select(x => new { Name = x.Name, DeclaringType = x.PropertyType });
            var columns = properties.Select(x => new DataColumn(x.Name, x.DeclaringType));
            table.Columns.AddRange(columns.ToArray());

            // Add data to DataTable
            items.ForEach(item =>
                {
                    var row = table.NewRow();
                    properties.ToList().ForEach(property =>
                    {
                        var values = item.GetType().GetProperties()
                         .Select(x => new { Name = x.Name, Value = x.GetValue(item, new object[] { }) })
                         .ToDictionary(x => x.Name, z => z.Value);

                        row[property.Name] = values[property.Name];
                    });

                    table.Rows.Add(row);
                }
            );

            return table;
        }

        #endregion

    }
}
