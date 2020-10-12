using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using C1.C1Report;

namespace SimpleFilter
{
    public class CustomDataSource<T> : IC1ReportRecordset 
    {
        // ** fields
        List<T> _baseList;
        List<T> _list;
        int _index;
        PropertyInfo[] _props;
        string[] _propNames;
        Type[] _propTypes;
        static object[] _noIndex = new object[0];

        // ** ctor
        public CustomDataSource(List<T> list)
        {
            // store reference to base list
            _baseList = _list = list;

            // get list of properties, names, and types
            _props = typeof(T).GetProperties();
            _propNames = new string[_props.Length];
            _propTypes = new Type[_props.Length];
            for (int i = 0; i < _props.Length; i++)
            {
                _propNames[i] = _props[i].Name;
                _propTypes[i] = _props[i].PropertyType;
            }
        }

        // ** IC1ReportRecordset implementation
        string[] IC1ReportRecordset.GetFieldNames()
        {
            return _propNames;
        }
        Type[] IC1ReportRecordset.GetFieldTypes()
        {
            return _propTypes;
        }
        object IC1ReportRecordset.GetFieldValue(int fieldIndex)
        {
            return _props[fieldIndex].GetValue(_list[_index], _noIndex);
        }
        bool IC1ReportRecordset.BOF()
        {
            return _index == 0;
        }
        bool IC1ReportRecordset.EOF()
        {
            return _index >= _list.Count;
        }
        void IC1ReportRecordset.MoveFirst()
        {
            _index = 0;
        }
        void IC1ReportRecordset.MoveLast()
        {
            _index = _list.Count-1;
        }
        void IC1ReportRecordset.MovePrevious()
        {
            _index--;
        }
        void IC1ReportRecordset.MoveNext()
        {
            _index++;
        }
        int IC1ReportRecordset.GetBookmark()
        {
            return _index;
        }
        void IC1ReportRecordset.SetBookmark(int bkmk)
        {
            _index = bkmk;
        }

        // filter data into a new list
        void IC1ReportRecordset.ApplyFilter(string filter)
        {
            // restore base list
            _list = _baseList;

            // apply filter if any
            if (!string.IsNullOrEmpty(filter))
            {
                // create filtered list
                List<T> filteredList = new List<T>();

                // use another C1Report to evaluate filter expression
                // this is a little sneaky but very powerful, because the 
                // C1Report expression evaluator can deal with all kinds of
                // expressions (e.g. (name > "a") And (active = true)).
                C1Report rpt = new C1Report();
                rpt.DataSource.Recordset = this;
                for (_index = 0; _index < _list.Count; _index++)
                {
                    // evaluate expression (should return 0 or -1)
                    int result = Convert.ToInt32(rpt.Evaluate(filter));
                    if (result != 0)
                    {
                        filteredList.Add(_list[_index]);
                    }
                }

                // use filtered list instead of base list
                _list = filteredList;
                _index = 0;
            }
        }

        // apply sort to list data 
        // (this only supports sorting on one field)
        void IC1ReportRecordset.ApplySort(string sort)
        {
            _list.Sort(new itemComparer(this, sort));
        }
        private class itemComparer : IComparer<T>
        {
            bool _descending;
            PropertyInfo _prop;

            public itemComparer(CustomDataSource<T> owner, string sort)
            {
                string[] tokens = sort.Trim().Split(' ');
                string field = tokens[0];
                for (int i = 0; i < owner._props.Length; i++)
                {
                    if (string.Compare(owner._props[i].Name, field, true) == 0)
                    {
                        _prop = owner._props[i];
                        break;
                    }
                }
                _descending = tokens.Length > 1 && tokens[tokens.Length - 1].ToLower().EndsWith("desc");
            }
            int IComparer<T>.Compare(T item1, T item2)
            {
                object v1 = _prop.GetValue(item1, _noIndex);
                object v2 = _prop.GetValue(item2, _noIndex);
                int val = ((IComparable)v1).CompareTo(v2);
                return _descending ? -val : +val;
            }
        }
    }
}
