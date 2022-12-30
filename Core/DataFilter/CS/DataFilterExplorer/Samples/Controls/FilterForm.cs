using C1.DataCollection;
using C1.DataCollection.BindingList;
using C1.DataFilter;
using C1.Win.Ribbon;
using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataFilterExplorer.Samples
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

        public Expression Expression
        {
            get => _expression;
            set
            {
                if (_expression != value)
                {
                    _expression = value;
                    UpdateExpression();
                }
            }
        }

        public event EventHandler FilterChanged;

        internal void ClearFilter(bool resetExpression)
        {
            c1FilterEditor1.ClearFilter();
            if(resetExpression)
                _expression = c1FilterEditor1.GetExpression();
        }

        public event EventHandler<System.ComponentModel.CancelEventArgs> FilterChanging;

        private void c1FilterEditor1_FilterChanged(object sender, EventArgs e) => FilterChanged?.Invoke(this, e);

        private void c1FilterEditor1_FilterChanging(object sender, System.ComponentModel.CancelEventArgs e) => FilterChanging?.Invoke(this, e);

        internal async void ApplyFilter() => await c1FilterEditor1.ApplyFilterAsync();

        internal void UpdateExpression() => c1FilterEditor1.SetExpression(_expression);

        private void btnApply_Click(object sender, EventArgs e)
        {
            _expression = c1FilterEditor1.GetExpression();
            DialogResult = DialogResult.OK;
            Close();
        }

        #region FilterToString
        public string FilterToString() => FilterToString(c1FilterEditor1.GetFilterExpression());
        public string FilterToString(FilterExpression expression)
        {
            string ans = BuildExpressionBody(expression);
            if (ans.Length > 0)
            {
                if (ans[0] == '(')
                    return ans.Substring(1, ans.Length - 2);
                else
                    return ans;
            }
            return ans;
        }

        private static string EscapeColumn(string columnName)
        {
             return $"[{columnName.Replace("\\", "\\\\").Replace("]", "\\]")}]";
        }

        private static string BuildExpressionBody(FilterExpression filterExpression)
        {
            switch (filterExpression)
            {
                case FilterNaryExpression naryExpression:
                    {
                        if (naryExpression.FilterCombination == FilterCombination.Or)
                        {
                            return "(" + string.Join(" OR ", naryExpression.Expressions.Select(e => BuildExpressionBody(e))) + ")";
                        }
                        else
                        {
                            return "(" + string.Join(" AND ", naryExpression.Expressions.Select(e => BuildExpressionBody(e))) + ")";
                        }
                    }
                case FilterNotExpression notExpression:
                    return $"NOT({BuildExpressionBody(notExpression.NotExpression)})";
                case FilterOperationExpression operationExpression:
                    {
                        var columnName = EscapeColumn(operationExpression.FilterPath);
                        switch (operationExpression.FilterOperation)
                        {
                            default:

                            case FilterOperation.Equal:
                                // DBNull
                                if (operationExpression.Value == DBNull.Value || operationExpression.Value == null)
                                    return $"{columnName} is Null";
                                // other
                                return $"{columnName} = '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.NotEqual:
                                // DBNull
                                if (operationExpression.Value == DBNull.Value || operationExpression.Value == null)
                                    return $"Not {columnName} is Null";
                                // other
                                return $"{columnName} != '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.GreaterThan:
                                // other
                                return $"{columnName} > '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.GreaterThanOrEqual:
                                return $"{columnName} >= '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.LessThan:
                                return $"{columnName} < '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.LessThanOrEqual:
                                // other
                                return $"{columnName} <= '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.EqualText:
                                return $"{columnName} = '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.NotEqualText:
                                return $"{columnName} <> '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.Contains:
                                return $"{columnName} Contains '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.StartsWith:
                                return $"{columnName} Starts with '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.EndsWith:
                                return $"{columnName} Ends with '{ConvertToString(operationExpression.Value)}'";

                            case FilterOperation.IsOneOf:
                                var values = ((IEnumerable)operationExpression.Value).Cast<object>();
                                var nonNullValues = values.Where(o => o != null && o != DBNull.Value).ToList();
                                var includeNulls = values.Contains(null) || values.Contains(DBNull.Value);
                                if (nonNullValues.Count == 0 && !includeNulls)
                                    return "False";
                                var stringValues = string.Join(",", nonNullValues.Select(o => $"'{o.ToString()}'").ToArray());
                                if (includeNulls)
                                    if (nonNullValues.Count == 0)
                                        return $"{columnName} is Null";
                                    else
                                        return $"({columnName} IN ({stringValues}) OR {columnName} is Null)";
                                else
                                    return $"{columnName} IN ({stringValues})";
                        }
                    }
            }
            return "";
        }

        private static string ConvertToString(object value)
        {
            string strValue;
            // DateTime                              
            if (value != null && value.GetType() == typeof(DateTime))
            {
                var dt = (DateTime)value;
                var textDateString = dt.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern, CultureInfo.CurrentCulture);
                strValue = $"{textDateString}";
            }
            else
            {
                strValue = Convert.ToString(value, CultureInfo.CurrentCulture);
            }
            return strValue;
        }
        #endregion
    }
}
