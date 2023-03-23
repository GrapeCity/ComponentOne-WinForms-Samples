using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.DataCollection;
using C1.DataCollection.BindingList;
using C1.DataFilter;

namespace DataFilterExplorer.Samples.Controls
{
    public partial class FilterEditorSummaryPanel : UserControl
    {
        private readonly FilterForm _filterForm;
        private bool _filterOnSelectedItemChanged = true;
        private bool _keepFilterExpression = false;
        private bool _filterOnCheckedChanged = true;
        private List<Expression> _expressions = new List<Expression>(); 

        public FilterEditorSummaryPanel()
        {
            InitializeComponent();
            _filterForm = new FilterForm();
            _filterForm.FilterChanged += FilterForm_FilterChanged;
        }

        public object DataSource
        {
            get => _filterForm.DataSource;
            internal set => _filterForm.DataSource = value;
        }

        public Expression Expression
        {
            get => _filterForm.Expression;
            set => _filterForm.Expression = value;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var btnRect = EditButton.Bounds;
            _filterForm.Location = PointToScreen(new Point(btnRect.Right - _filterForm.Width, btnRect.Top - _filterForm.Height));
            _filterForm.UpdateExpression();
            if (_filterForm.ShowDialog() == DialogResult.OK)
            {
                if (_keepFilterExpression && !ApplyFilterCheckBox.Checked)
                {
                    _filterOnSelectedItemChanged = false;
                    FilterSummaryCombo.SelectedItem = null;
                    _filterOnSelectedItemChanged = true;
                }
                _filterForm.ApplyFilter();
                ApplyFilterCheckBox.Checked = true;
            }
        }

        internal void ApplyFilter() => _filterForm.ApplyFilter();
        internal void ClearFilter(bool resetExpression) => _filterForm.ClearFilter(resetExpression);

        private void ApplyFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ApplyFilterCheckBox.Checked)
            {
                _keepFilterExpression = false;
                if (_filterOnCheckedChanged)
                { 
                    _filterForm.UpdateExpression();
                    ApplyFilter();
                }
            }
            else
            {
                _keepFilterExpression = true;
                _filterForm.ClearFilter(false);
                ApplyFilter();
            }
        }
        private void FilterForm_FilterChanged(object sender, EventArgs e)
        {
            _filterOnSelectedItemChanged = false;
            if (_filterForm.IsFilterActive)
            {
                _filterOnCheckedChanged = false;
                if (!_expressions.Contains(_filterForm.Expression))
                    AddFilterExpression(_filterForm.Expression, true);
                else
                {
                    int index = _expressions.IndexOf(_filterForm.Expression);
                    FilterSummaryCombo.SelectedItem = FilterSummaryCombo.Items[index];
                }
                _filterOnCheckedChanged = true;
            }
            else if (!_keepFilterExpression)
                FilterSummaryCombo.SelectedItem = null;
            _filterOnSelectedItemChanged = true;
        }
        private void AddFilterExpression(Expression expression, bool updateSelectedItem)
        {
            _expressions.Add(expression);

            var item = new C1.Win.Input.ComboBoxItem();
            item.Value = item.DisplayText = _filterForm.FilterToString();
            FilterSummaryCombo.Items.Add(item);

            if (updateSelectedItem)
                FilterSummaryCombo.SelectedItem = item;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseFilterPanel();
        }
        public void CloseFilterPanel()
        {
            _filterForm.ClearFilter(true);
            ApplyFilter();
            Visible = false;
        }
        public void ShowFilterPanel()
        {
            Visible = true;
        }

        private void FilterSummaryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterSummaryCombo.SelectedIndex > -1)
            {
                _keepFilterExpression = false;
                ApplyFilterCheckBox.Checked = true;
            }

            if (_filterOnSelectedItemChanged)
                ApplyFilterExpression(FilterSummaryCombo.SelectedIndex);

            _filterOnSelectedItemChanged = true;
        }
        private void ApplyFilterExpression(int index)
        {
            if (index >= 0 && index < _expressions.Count)
            {
                _filterForm.Expression = _expressions[index];
                ApplyFilter();
            }
        }

        internal void ApplyTheme(C1.Win.Themes.C1Theme theme)
        {
            C1.Win.Themes.C1ThemeController.ApplyThemeToControlTree(_filterForm, theme);
        }

        public void AddSampleExpressions()
        {
            var filterExpression = new CombinationExpression();

            var filterExpressions = filterExpression.Expressions;

            var hpGreaterThen200Expression = new OperationExpression()
            {
                PropertyName = "HP",
                FilterOperation = FilterOperation.GreaterThanOrEqual,
                Value = 200
            };
            filterExpressions.Add(hpGreaterThen200Expression);

            var automaticTransmissionExpression = new OperationExpression()
            {
                PropertyName = "AutomaticTransmission",
                FilterOperation = FilterOperation.Equal,
                Value = true
            };
            filterExpressions.Add(automaticTransmissionExpression);

            var sportsCategoryExpression = new OperationExpression()
            {
                PropertyName = "StartSaleDate",
                FilterOperation = FilterOperation.GreaterThanOrEqual,
                Value = new DateTime(2011, 1, 1)
            };
            filterExpressions.Add(sportsCategoryExpression);

            _filterForm.Expression = filterExpression;
            ApplyFilter();

            //filterExpressions.Clear();

            var filterExpression2 = new CombinationExpression();
            var filterExpressions2 = filterExpression2.Expressions;

            var brandOrExpression = new CombinationExpression();
            brandOrExpression.FilterCombination = FilterCombination.Or;

            var brandExpressions = brandOrExpression.Expressions;

            var brandEqualMercedesBenzExpression = new OperationExpression()
            {
                PropertyName = "Brand",
                FilterOperation = FilterOperation.EqualText,
                Value = "Mercedes-Benz"
            };
            brandExpressions.Add(brandEqualMercedesBenzExpression);

            var brandEqualAudiExpression = new OperationExpression()
            {
                PropertyName = "Brand",
                FilterOperation = FilterOperation.EqualText,
                Value = "Audi"
            };
            brandExpressions.Add(brandEqualAudiExpression);

            filterExpressions2.Add(brandOrExpression);

            _filterForm.Expression = filterExpression2;
            ApplyFilter();

            _filterForm.ClearFilter(true);
            ApplyFilter();
        }
    }
}
