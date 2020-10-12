using System;
using System.Collections.Generic;
using System.IO;

using C1.AppUtils.Options;
using C1R = C1.C1Report;
using AR = GrapeCity.ActiveReports;

namespace C1Report2Rpx
{
    public class ReportItem : IDisposable
    {
        private C1R.C1Report _report = new C1R.C1Report();
        private MemoryStream _rpxData = new MemoryStream();
        private Log _log = new Log();
        private string _fileName;

        #region Public
        public void Dispose()
        {
            if (_rpxData != null)
            {
                _rpxData.Dispose();
                _rpxData = null;
            }
            if (_report != null)
            {
                _report.Dispose();
                _report = null;
            }
        }
        #endregion

        #region Public properties
        public C1R.C1Report Report
        {
            get { return _report; }
        }

        public MemoryStream RpxData
        {
            get { return _rpxData; }
        }

        public Log Log
        {
            get { return _log; }
        }

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        #endregion
    }

    public class Reports : List<ReportItem>, IDisposable
    {
        #region Public
        public void Dispose()
        {
            foreach (ReportItem ri in this)
                ri.Dispose();
        }
        #endregion
    }
}
