using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using C1.Report;

namespace ExtRecordset
{
    public class MyRecordset : IC1FlexReportRecordset
    {
        private int _recNo;
        private int _recCount;

        public MyRecordset()
        {
            _recCount = 60;
        }

        public int RecCount
        {
            get { return _recCount; }
            set { _recCount = value; }
        }

        #region IC1FlexReportRecordset implementation
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
                case 0:
                    return _recNo + 1;
                case 1:
                    return string.Format("Caption {0}", _recNo + 1);
                default:
                    return null;
            }
        }

        public bool BOF()
        {
            return _recNo < 0;
        }

        public bool EOF()
        {
            return _recNo >= _recCount;
        }

        public void MoveFirst()
        {
            _recNo = 0;
        }

        public void MoveLast()
        {
            _recNo = _recCount - 1;
        }

        public void MovePrevious()
        {
            --_recNo;
        }

        public void MoveNext()
        {
            ++_recNo;
        }

        public int GetBookmark()
        {
            return _recNo;
        }

        public void SetBookmark(int bkmk)
        {
            _recNo = bkmk;
        }

        public int Count
        {
            get { return RecCount; }
        }
        #endregion
    }

    public class MyExtRecordset : IC1FlexReportExternalRecordset
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

        public IC1FlexReportRecordset GetRecordset()
        {
            return _recordset;
        }

        public string Caption
        {
            get { return "External Recordset Sample"; }
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
