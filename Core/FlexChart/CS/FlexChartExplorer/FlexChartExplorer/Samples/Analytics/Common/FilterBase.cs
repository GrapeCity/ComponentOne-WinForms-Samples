using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer.Samples
{
    public abstract class FilterBase : INotifyPropertyChanged
    {
        private string[] _bindings;
        private string _bindingX;
        private AggregateFunction _aggregateType = AggregateFunction.Sum;
        private SortType _sortType = SortType.None;
        private bool _sortOrder = false;
        private object _source;

        public string[] Bindings
        {
            get { return _bindings; }
            set { _bindings = value;Analyse(); }
        }
        public string BindingX
        {
            get { return _bindingX; }
            set { _bindingX = value;Analyse(); }
        }
        public AggregateFunction AggregateType
        {
            get { return _aggregateType; }
            set { _aggregateType = value;Analyse(); }
        }
        public SortType SortType
        {
            get { return _sortType; }
            set { _sortType = value;Analyse(); }
        }
        public bool SortOrder
        {
            get { return _sortOrder; }
            set { _sortOrder = value; Analyse(); }
        }
        public object Source
        {
            get { return _source; }
            set { _source = value; Analyse(); }
        }
        public object DataSource
        {
            get;
            protected set;
        }
        public abstract void Analyse();
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Util Method
        protected static void SetValue(object obj, string binding, object value)
        {
            obj.GetType().GetProperty(binding).SetValue(obj, value,null);
        }
        protected static double GetValue(object obj, string binding)
        {
            var value = Convert.ToDouble(obj.GetType().GetProperty(binding).GetValue(obj,null));
            return value;
        }
        protected static double[] GetValues(object obj, string[] bindings)
        {
            var values = from binding in bindings select Convert.ToDouble(obj.GetType().GetProperty(binding).GetValue(obj,null));
            return values.ToArray();
        }
        #endregion

    }
}
