using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using C1.C1Report;

namespace ExtRecordset
{
    public class MyRecordsetItem
    {
        public int ID { get; set; }

        public string Caption { get; set; }
    }

    public class MyRecordset : IC1ReportRecordset
    {
        private int _recNo;
        private List<MyRecordsetItem> _items = new List<MyRecordsetItem>();

        public MyRecordset()
        {
            RecCount = 60;
        }

        public int RecCount
        {
            get { return _items.Count; }
            set
            {
                if (_items.Count == value)
                    return;
                _items.Clear();
                for (int i = 1; i <= value; i++)
                {
                    MyRecordsetItem item = new MyRecordsetItem();
                    item.ID = i;
                    item.Caption = string.Format("Caption {0}", i);
                    _items.Add(item);
                }
            }
        }

        #region IC1ReportRecordset Members

        public string[] GetFieldNames()
        {
            return new string[] { "ID", "Caption" };
        }

        public Type[] GetFieldTypes()
        {
            return new Type[] { typeof(int), typeof(string) };
        }

        public object GetFieldValue(int fieldIndex)
        {
            switch (fieldIndex)
            {
                case 0: return _items[_recNo].ID;
                case 1: return _items[_recNo].Caption;
                default: return null;
            }
        }

        public bool BOF()
        {
            return _recNo < 0;
        }

        public bool EOF()
        {
            return _recNo >= _items.Count;
        }

        public void MoveFirst()
        {
            _recNo = 0;
        }

        public void MoveLast()
        {
            _recNo = _items.Count - 1;
        }

        public void MovePrevious()
        {
            _recNo--;
        }

        public void MoveNext()
        {
            _recNo++;
        }

        public int GetBookmark()
        {
            return _recNo;
        }

        public void SetBookmark(int bkmk)
        {
            _recNo = bkmk;
        }

        public void ApplyFilter(string filter)
        {
        }

        public void ApplySort(string sort)
        {
        }
        #endregion
    }

    public class MyExtRecordset : IC1ReportExternalRecordset
    {
        private MyRecordset _recordset;

        public MyExtRecordset()
        {
            _recordset = new MyRecordset();
        }

        public int RecCount
        {
            get { return _recordset.RecCount; }
            set { _recordset.RecCount = value; }
        }

        #region IC1ReportExternalRecordset Members

        public void EditParams()
        {
            using (MyExtRecordsetForm f = new MyExtRecordsetForm())
                f.Edit(this);
        }

        public IC1ReportRecordset GetRecordset()
        {
            return _recordset;
        }

        public string Caption
        {
            get { return "External recordset sample"; }
        }

        public string Params
        {
            get
            {
                return _recordset.RecCount.ToString();
            }
            set
            {
                int count;
                if (int.TryParse(value, out count))
                    _recordset.RecCount = count;
            }
        }

        #endregion
    }
}
