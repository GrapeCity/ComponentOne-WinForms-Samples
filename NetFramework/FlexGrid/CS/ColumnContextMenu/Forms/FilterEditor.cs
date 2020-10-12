using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.DataFilter;
using C1.Win.Ribbon;

namespace ColumnContextMenu.Forms
{
    public partial class FilterEditor : C1RibbonForm
    {
        private Expression _defaultExpression;

        public FilterEditor(C1FlexGrid grid)
        {
            InitializeComponent();
            c1FilterEditor1.DataSource = grid.DataSource;
        }

        public async void SetExpression(Expression expression)
        {
            c1FilterEditor1.SetExpression(expression);
            await c1FilterEditor1.ApplyFilterAsync();
        }

        public bool IsEmpty
        {
            get
            {
                var expression = c1FilterEditor1.GetExpression() as CombinationExpression;
                return expression == null || expression.Expressions.Count == 0;
            }
        }

        private void FilterEditor_Shown(object sender, System.EventArgs e)
        {
            _defaultExpression = c1FilterEditor1.GetExpression();
        }

        // Clear button clicked
        private void btnClear_Click(object sender, System.EventArgs e)
        {
            // Clear filter
            c1FilterEditor1.ClearFilter();
        }

        // Ok button clicked
        private async void btnOk_Click(object sender, System.EventArgs e)
        {
            // Apply filter and close form
            await c1FilterEditor1.ApplyFilterAsync();
            DialogResult = DialogResult.OK;
            Close();
        }

        // Cancel button clicked
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            // Undo changes and close form
            SetExpression(_defaultExpression);
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
