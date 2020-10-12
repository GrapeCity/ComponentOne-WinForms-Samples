using C1.Win.RulesManager;
using C1.Win.RulesManager.Model;
using System.Windows.Forms;
using System.Linq;
using System;
using System.Data;
using System.Drawing;
using C1.Win.C1FlexGrid;
using C1.DataFilter;
using C1.DataCollection;

namespace ControlExplorer.FlexGrid
{
    public partial class ColumnContextMenu : C1DemoForm
    {
        private Image _checkedImage;

        public ColumnContextMenu()
        {
            InitializeComponent();
            _checkedImage = ControlExplorer.Properties.Resources.Checked;
        }        

        private void HideTabs()
        {
            c1DockingTab1.Visible = false;
        }

        private void ShowTab(int idx)
        {
            c1DockingTab1.SelectedIndex = idx;
            c1DockingTab1.Visible = true;
        }

        private void InitData()
        {
            var dt = DemoDataSource("select * from Invoices", true);
            c1FlexGrid1.DataSource = dt;
            c1FilterEditor1.DataSource = dt;
        }

        private void ColumnContextMenu_Load(object sender, EventArgs e)
        {
            InitData();
            InitRules();
            InitFilter();
        }

        private void c1FlexGrid1_ColumnContextMenuOpening(object sender, ColumnContextMenuOpeningEventArgs e)
        {
            // Update column context menu only for non-fixed columns
            if (e.Col >= c1FlexGrid1.Cols.Fixed)
            {
                var items = e.ContextMenuStrip.Items;

                // Add new separator menu item
                items.Add(new ToolStripSeparator());

                // Add new conditional formatting menu item
                var rulesItem = new ToolStripMenuItem("Conditional Formatting");
                rulesItem.Click += (s, eargs) => ShowRulesEditor();
                if (!IsRulesEmpty)
                    rulesItem.Image = _checkedImage;
                items.Add(rulesItem);

                // Add new data filter menu item
                var filterItem = new ToolStripMenuItem("Filter");
                filterItem.Click += (s, eargs) => ShowFilterEditor();
                if (!IsFilterEmpty)
                    filterItem.Image = _checkedImage;
                items.Add(filterItem);
            }
        }

#region Conditional Formatting

        private RuleCollection _defaultRules;

        private bool IsRulesEmpty
        {
            get => c1RulesManager1.Rules == null || c1RulesManager1.Rules.Count == 0;
        }

        private void InitRules()
        {
            // Apply default rule - bold text for major invoice records
            var rule = new C1.Win.RulesManager.Rule()
            {
                Name = "Major Invoices",
                Expression = "=[ExtendedPrice] > 1000",
                Style = new ItemStyle()
                {
                    FontStyle = FontStyle.Bold
                }
            };
            c1RulesManager1.Rules.Add(rule);
        }

        private void ShowRulesEditor()
        {
            ShowTab(0);
            StoreRules();
        }

        private void StoreRules()
        {
            // Store the default rules to Undo changes if needed
            _defaultRules = new RuleCollection();
            _defaultRules.AddRange(c1RulesManager1.Rules.Select(x => (IRule)x.Clone()));
        }

        private void btnRulesClear_Click(object sender, EventArgs e)
        {
            // Clear rules
            c1RulesManager1.Rules.Clear();
        }

        private void btnRulesOk_Click(object sender, EventArgs e)
        {
            // Close tab
            HideTabs();
        }

        private void btnRulesCancel_Click(object sender, EventArgs e)
        {
            // Undo changes and close tab
            c1RulesManager1.Rules.Clear();
            c1RulesManager1.Rules.AddRange(_defaultRules);
            HideTabs();
        }

#endregion Conditional Formatting

#region Filter

        private Expression _defaultExpression;

        public bool IsFilterEmpty
        {
            get
            {
                var expression = c1FilterEditor1.GetExpression() as CombinationExpression;
                return expression == null || expression.Expressions.Count == 0;
            }
        }

        private async void InitFilter()
        {
            // Apply default filter - show only invoices with discount
            var expression = new CombinationExpression();
            expression.Expressions.Add(new OperationExpression()
            {
                PropertyName = "Discount",
                FilterOperation = FilterOperation.GreaterThan,
                Value = 0
            });
            c1FilterEditor1.SetExpression(expression);
            await c1FilterEditor1.ApplyFilterAsync();
        }

        private void ShowFilterEditor()
        {
            ShowTab(1);
            _defaultExpression = c1FilterEditor1.GetExpression();
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            // Clear filter
            c1FilterEditor1.ClearFilter();
        }

        private async void btnFilterOk_Click(object sender, EventArgs e)
        {
            // Apply filter and close tab
            await c1FilterEditor1.ApplyFilterAsync();
            HideTabs();
        }

        private async void btnFilterCancel_Click(object sender, EventArgs e)
        {
            // Undo changes and close tab
            c1FilterEditor1.SetExpression(_defaultExpression);
            await c1FilterEditor1.ApplyFilterAsync();
            HideTabs();
        }

#endregion Filter
    }
}
