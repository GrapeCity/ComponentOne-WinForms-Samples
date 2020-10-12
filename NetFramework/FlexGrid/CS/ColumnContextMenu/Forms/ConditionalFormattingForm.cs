using C1.Win.Ribbon;
using C1.Win.RulesManager;
using C1.Win.RulesManager.Model;
using System.Windows.Forms;
using System.Linq;

namespace ColumnContextMenu.Forms
{
    public partial class ConditionalFormattingForm : C1RibbonForm
    {
        private RuleCollection _defaultRules;

        public ConditionalFormattingForm(object grid)
        {
            InitializeComponent();
            c1RulesManager1.SetC1RulesManager(grid, c1RulesManager1);
        }

        public RuleCollection Rules => c1RulesManager1.Rules;

        public bool IsEmpty => c1RulesManager1.Rules == null || c1RulesManager1.Rules.Count == 0;

        private void ConditionalFormattingForm_Shown(object sender, System.EventArgs e)
        {
            // Store the default rules to Undo changes if needed
            _defaultRules = new RuleCollection();
            _defaultRules.AddRange(c1RulesManager1.Rules.Select(x => (IRule)x.Clone()));
        }

        // Clear button clicked
        private void btnClear_Click(object sender, System.EventArgs e)
        {
            // clear rules
            c1RulesManager1.Rules.Clear();
        }

        // Ok button clicked
        private void btnOk_Click(object sender, System.EventArgs e)
        {
            // Close form
            DialogResult = DialogResult.OK;
            Close();
        }

        // Cancel button clicked
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            // Undo changes and close form
            c1RulesManager1.Rules.Clear();
            c1RulesManager1.Rules.AddRange(_defaultRules);
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
