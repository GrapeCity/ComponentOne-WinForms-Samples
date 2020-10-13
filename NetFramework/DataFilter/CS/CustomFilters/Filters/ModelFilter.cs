using C1.DataCollection;
using C1.DataFilter;
using C1.Win.DataFilter;
using C1.Win.Input;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomFilters
{
    public class ModelFilter : CustomFilter
    {
        public ModelFilter()
        {
            Control = MultiSelect = new C1MultiSelect() { Height = 50, Placeholder = "Model of car", AutoCompleteMode = AutoCompleteMode.SuggestAppend };
            MultiSelect.Font = new Font("Calibri", 12);
            MultiSelect.SelectionChanged += MultiSelect_SelectionChanged;
        }

        public C1MultiSelect MultiSelect { get; }

        private void MultiSelect_SelectionChanged(object sender, EventArgs e)
        {
            OnValueChanged(new ValueChangedEventArgs() { ApplyFilter = true });
        }

        public void SetTagList(object tagSource)
        {
            MultiSelect.BindingInfo.DataSource = tagSource;
            MultiSelect.BindingInfo.DisplayMemberPath = "Model";
            MultiSelect.BindingInfo.ValueMemberPath = "Model";
        }

        protected override Expression GetExpression()
        {
            var ce = new CombinationExpression() { FilterCombination = FilterCombination.Or };
            foreach (var item in MultiSelect.SelectedItems)
                ce.Expressions.Add(new OperationExpression() { FilterOperation = FilterOperation.Equal, Value = item.Value, PropertyName = PropertyName });
            return ce;
        }

        protected override void SetExpression(Expression expression)
        {
            
        }

        public override bool IsApplied => base.IsApplied && MultiSelect.SelectedItems.Count > 0;
    }
}
