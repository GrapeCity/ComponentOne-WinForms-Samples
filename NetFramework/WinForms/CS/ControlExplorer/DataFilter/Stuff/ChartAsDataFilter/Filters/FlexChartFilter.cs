using C1.Chart;
using C1.DataCollection;
using C1.DataFilter;
using C1.Win.Chart;
using C1.Win.DataFilter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ControlExplorer.DataFilter
{
    public class FlexChartFilter : CustomFilter
    {
        #region fields
        protected FlexChartFilterView filterView;
        protected string propertyX, propertyY;
        protected IEnumerable<object> items;
        #endregion

        #region Properties
        public C1.Win.Chart.FlexChart FlexChart { get { return filterView.Chart; } }
        public double SliderLowerValue
        {
            get { return filterView.Slider.LowerValue; }
            set { filterView.Slider.LowerValue = value; }
        }
        public double SliderUpperValue
        {
            get { return filterView.Slider.UpperValue; }
            set { filterView.Slider.UpperValue = value; }
        }
        public bool ShowRangeSlider { get { return filterView.ShowRangeSlider; } set { filterView.ShowRangeSlider = value; } }
        public bool ShowSelectionMode
        {
            get { return filterView.ShowSelectionMode; }
            set
            {
                filterView.ShowSelectionMode = value;
            }
        }
        public SelectionMode SelectionMode
        {
            get { return filterView.SelectionMode; }
            set { filterView.SelectionMode = value; }
        }
        #endregion

        #region c'tor
        protected FlexChartFilter() { }
        public FlexChartFilter(IEnumerable<object> items,string xProperty, string yProperty,ChartType chartType = ChartType.Column)
        {
            filterView = new FlexChartFilterView(items,xProperty, yProperty,chartType) { Height = 250 };
            filterView.SelectionChanged += (s, e) => OnValueChanged(new ValueChangedEventArgs() { ApplyFilter = filterView.IsLoaded });
            propertyX = xProperty;
            propertyY = yProperty;            
            Control = filterView;
            this.items = items;            
        }
        #endregion
        #region Overrides
        protected override Expression GetExpression()
        {
            var exp = new CombinationExpression();            
            if(filterView.IsGroupedData)
            {
                var selectedItems = filterView.GetSelectedValues();
                if (selectedItems == null || selectedItems.Count() == 0)
                {
                    var selectedRange = filterView.GetSliderRange();
                    selectedItems = new List<object>();
                    for (int idx = (int)Math.Ceiling((double)selectedRange.Item1); idx <= (int)Math.Floor((double)selectedRange.Item2); idx++)
                        (selectedItems as IList).Add(items.ElementAt(idx));
                }
                SetGroupExpression(exp, selectedItems);
            }
            else
            {
                var selectedItems = filterView.GetSelectedValues();
                if (selectedItems == null || selectedItems.Count() == 0)
                    SetRangeExpression(exp, filterView.GetSliderRange());
                else
                    SetXYExpression(exp, selectedItems);
            }
            return exp;
        }

        protected override void SetExpression(Expression expression)
        {
            throw new NotImplementedException();
        }

        public override bool IsApplied => filterView.IsFilterApplied;
        #endregion
        #region Private Helpers
        private void SetXYExpression(CombinationExpression exp, IEnumerable<object> selectedValues)
        {
            exp.FilterCombination = FilterCombination.Or;

            foreach (var item in selectedValues)
            {
                var comboExp = new CombinationExpression() { FilterCombination = FilterCombination.And };
                comboExp.Expressions.Add(new OperationExpression
                {
                    PropertyName = propertyX,
                    Value = GetPropertyValue(propertyX, item),
                    FilterOperation = FilterOperation.Equal,
                });
                foreach(var property in propertyY.Split(','))
                {
                    comboExp.Expressions.Add(new OperationExpression
                    {
                        PropertyName = property.Trim(),
                        Value = GetPropertyValue(property.Trim(), item),
                        FilterOperation = FilterOperation.Equal,
                    });
                }
                exp.Expressions.Add(comboExp);
            }
        }
        private void SetRangeExpression(CombinationExpression exp, Tuple<object,object> sliderRange)
        {
            exp.FilterCombination = FilterCombination.And;
            
            //RangeSlider is not suggested to use for Categorical Data
            if (sliderRange != null && !isCategoricalData())
                exp.Expressions.Add(CreateRangeExpression(sliderRange.Item1, sliderRange.Item2));
        }
        private void SetGroupExpression(CombinationExpression exp, IEnumerable<object> selectedGroups)
        {
            exp.FilterCombination = FilterCombination.Or;

            foreach(GroupItem grpItem in selectedGroups)
            {
                exp.Expressions.Add(CreateRangeExpression(grpItem.Min, grpItem.Max));
            }
        }
        private CombinationExpression CreateRangeExpression(object min, object max)
        {
            var subExpression = new CombinationExpression() { FilterCombination = FilterCombination.And };
            subExpression.Expressions.Add(new OperationExpression
            {
                PropertyName = PropertyName != string.Empty ? PropertyName : propertyX,
                Value = min,
                FilterOperation = min.GetType() == typeof(string) ? FilterOperation.Equal : FilterOperation.GreaterThanOrEqual,
            });
            subExpression.Expressions.Add(new OperationExpression
            {
                PropertyName = PropertyName != string.Empty ? PropertyName : propertyX,
                Value = max,
                FilterOperation = max.GetType() == typeof(string) ? FilterOperation.Equal : FilterOperation.LessThanOrEqual,
            });
            return subExpression;
        }        
        private bool isCategoricalData()
        {
            var objType = items.First().GetType();
            return objType == typeof(GroupItem) ? true : objType.GetProperty(propertyX).GetType() == typeof(string);
        }
        protected object GetPropertyValue(string name, object obj)
        {
            var propInfo = obj.GetType().GetProperty(name);
            return propInfo.GetValue(obj);
        }
        #endregion
    }
    /// <summary>
    /// This Class should be use for filtering by Grouped data in FlexChartFilter
    /// </summary>
    public class GroupItem
    {
        public string XValue { get; set; }
        public double YValue { get; set; }
        public object Min { get; set; }
        public object Max { get; set; }
    }    
}
