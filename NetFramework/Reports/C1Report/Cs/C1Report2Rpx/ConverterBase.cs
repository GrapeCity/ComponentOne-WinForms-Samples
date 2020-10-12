using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using AR = GrapeCity.ActiveReports;
using C1R = C1.C1Report;

namespace C1Report2Rpx
{
    internal abstract class ConverterBase
    {
        #region Constructors
        public ConverterBase()
        {
        }
        #endregion

        #region Public
        public abstract string NewNameId();

        public abstract string CheckName(string name, string autoNamePrefix);
        #endregion

        #region Public properties
        public abstract C1R.C1Report C1Report { get; }

        public abstract AR.SectionReport AReport { get; }

        public abstract Log Log { get; }
        #endregion
    }

    internal abstract class ReportItemConverterBase : ConverterBase
    {
        private C1ReportConverter _reportConverter;

        #region Constructors
        public ReportItemConverterBase(
            C1ReportConverter reportConverter)
            : base()
        {
            _reportConverter = reportConverter;
        }
        #endregion

        #region Public
        public override string NewNameId()
        {
            return _reportConverter.NewNameId();
        }

        public override string CheckName(
            string name,
            string autoNamePrefix)
        {
            return _reportConverter.CheckName(name, autoNamePrefix);
        }
        #endregion

        #region Public properties
        public C1ReportConverter ReportConverter
        {
            get { return _reportConverter; }
        }

        public override C1R.C1Report C1Report
        {
            get { return _reportConverter.C1Report; }
        }

        public override AR.SectionReport AReport
        {
            get { return _reportConverter.AReport; }
        }

        public override Log Log
        {
            get { return _reportConverter.Log; }
        }
        #endregion
    }
}
