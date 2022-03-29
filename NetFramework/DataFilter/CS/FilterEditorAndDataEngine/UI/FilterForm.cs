using C1.DataFilter;
using C1.Win.Ribbon;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FilterEditorAndDataEngine.UI
{
    public partial class FilterForm : C1RibbonForm
    {
        private Expression _expression;
        public FilterForm()
        {
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            InitializeComponent();
            _expression = c1FilterEditor1.GetExpression();
        }

        public bool IsFilterActive
        {
            get
            {
                Expression expression = c1FilterEditor1.GetExpression();
                // default expression => CombinationExpression(And, Count == 0, !Not)
                return !(expression is CombinationExpression combinationExpression &&
                    combinationExpression.Expressions.Count == 0 &&
                    combinationExpression.FilterCombination == C1.DataCollection.FilterCombination.And &&
                    !combinationExpression.Not);
            }
        }

        public object DataSource
        {
            get => c1FilterEditor1.DataSource;
            set => c1FilterEditor1.DataSource = value;
        }

        public event EventHandler FilterChanged;
        public event EventHandler<CancelEventArgs> FilterChanging;

        private void c1FilterEditor1_FilterChanged(object sender, EventArgs e) => FilterChanged?.Invoke(this, e);

        private void c1FilterEditor1_FilterChanging(object sender, CancelEventArgs e) => FilterChanging?.Invoke(this, e);

        internal async void ApplyFilter() => await c1FilterEditor1.ApplyFilterAsync();

        internal void UpdateExpression() => c1FilterEditor1.SetExpression(_expression);

        private void btnApply_Click(object sender, EventArgs e)
        {
            _expression = c1FilterEditor1.GetExpression();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
