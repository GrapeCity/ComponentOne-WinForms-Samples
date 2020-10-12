using System;
using System.Linq;
using System.IO;
using C1.C1Report;
using C1.C1Preview;
using C1.C1Preview.Export;

namespace C1ReportsScheduler
{
    public abstract class ReportItemBase
    {
        private string _fileName;
        private string _reportName;
        private string[] _reportNames = new string[0];
        public event LongOperationEventHandler LongOperation;

        public abstract ReportKind ReportKind { get; }

        public abstract string Name { get; }

        public virtual string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        // override to hide report name
        public virtual string ReportName
        {
            get { return _reportName; }
            set { _reportName = value; }
        }

        public string[] ReportNames
        {
            get { return _reportNames; }
        }

        public abstract void Load();

        public abstract void UnLoad();

        public abstract bool Check(out string message);

        public abstract Type DocumentType { get; }

        public abstract object Document { get; }

        public abstract bool CanExportTo(ExportProvider exportProvider);

        protected bool CheckFileAndReportNames(bool checkReportName, out string message)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                message = "File name not specified.";
                return false;
            }
            if (!File.Exists(FileName))
            {
                message = string.Format("File {0} not found.", FileName);
                return false;
            }
            if (checkReportName)
            {
                if (string.IsNullOrEmpty(ReportName))
                {
                    message = "Report name not specified.";
                    return false;
                }
                if (!_reportNames.Contains<string>(ReportName))
                {
                    message = string.Format("Report {0} not found in {1}.", ReportName, FileName);
                    return false;
                }
            }
            message = string.Empty;
            return true;
        }

        protected void PopulateReportNames()
        {
            if (!File.Exists(FileName))
            {
                ClearReportNames(false);
                return;
            }
            try
            {
                _reportNames = C1Report.GetReportList(FileName);
            }
            catch
            {
                ClearReportNames(false);
            }
        }

        protected void ClearReportNames(bool addNa)
        {
            if (addNa)
                _reportNames = new string[1] { TaskBase.c_reportNameNa };
            else
                _reportNames = new string[0];
        }

        protected void LongOperationHandler(object sender, LongOperationEventArgs e)
        {
            if (LongOperation != null)
                LongOperation(sender, e);
        }
    }

    internal class ReportItemXmlReport : ReportItemBase
    {
        private C1Report _report;

        public override ReportKind ReportKind
        {
            get { return ReportKind.XmlReport; }
        }

        public override string Name
        {
            get { return "Xml C1Report definition"; }
        }

        public override string FileName
        {
            set
            {
                base.FileName = value;
                PopulateReportNames();
            }
        }

        public override void Load()
        {
            if (_report != null)
                return;
            try
            {
                _report = new C1Report();
                _report.LongOperation += new LongOperationEventHandler(base.LongOperationHandler);
                _report.Load(FileName, ReportName);
            }
            catch
            {
                UnLoad();
                throw;
            }
        }

        public override void UnLoad()
        {
            if (_report == null)
                return;
            _report.LongOperation -= new LongOperationEventHandler(base.LongOperationHandler);
            _report = null;
        }

        public override bool Check(out string message)
        {
            return CheckFileAndReportNames(true, out message);
        }

        public override Type DocumentType
        {
            get { return typeof(C1Report); }
        }

        public override object Document
        {
            get
            {
                Load();
                return _report;
            }
        }

        public override bool CanExportTo(ExportProvider exportProvider)
        {
            return exportProvider.CanExportObject(_report);
        }
    }

    internal class ReportItemC1dDocument : ReportItemBase
    {
        private C1PrintDocument _doc;

        public ReportItemC1dDocument()
        {
            ClearReportNames(true);
        }

        public override ReportKind ReportKind
        {
            get { return ReportKind.C1dDocument; }
        }

        public override string Name
        {
            get { return "C1D/C1DX document"; }
        }

        public override string FileName
        {
            set
            {
                base.FileName = value;
            }
        }

        public override string ReportName
        {
            get { return string.Empty; }
        }

        public override void Load()
        {
            if (_doc != null)
                return;
            try
            {
                _doc = C1PrintDocument.FromFile(FileName, C1DocumentFormatEnum.C1dx);
            }
            catch
            {
                _doc = C1PrintDocument.FromFile(FileName, C1DocumentFormatEnum.C1d);
            }
            _doc.LongOperation += new LongOperationEventHandler(base.LongOperationHandler);
        }

        public override void UnLoad()
        {
            if (_doc == null)
                return;
            _doc.LongOperation -= new LongOperationEventHandler(base.LongOperationHandler);
            _doc = null;
        }

        public override bool Check(out string message)
        {
            return CheckFileAndReportNames(false, out message);
        }

        public override Type DocumentType
        {
            get { return typeof(C1PrintDocument); }
        }

        public override object Document
        {
            get
            {
                Load();
                return _doc;
            }
        }

        public override bool CanExportTo(ExportProvider exportProvider)
        {
            return exportProvider.CanExportObject(_doc);
        }
    }

    internal class ReportItemImportedReport : ReportItemBase
    {
        private C1PrintDocument _doc;

        public override ReportKind ReportKind
        {
            get { return ReportKind.ImportedReport; }
        }

        public override string Name
        {
            get { return "Imported C1Report"; }
        }

        public override string FileName
        {
            set
            {
                base.FileName = value;
                PopulateReportNames();
            }
        }

        public override void Load()
        {
            try
            {
                _doc = new C1PrintDocument();
                _doc.LongOperation += new LongOperationEventHandler(base.LongOperationHandler);
                _doc.ImportC1Report(FileName, ReportName);
            }
            catch
            {
                UnLoad();
                throw;
            }
        }

        public override void UnLoad()
        {
            if (_doc == null)
                return;
            _doc.LongOperation -= new LongOperationEventHandler(base.LongOperationHandler);
            _doc = null;
        }

        public override bool Check(out string message)
        {
            return CheckFileAndReportNames(true, out message);
        }

        public override Type DocumentType
        {
            get { return typeof(C1PrintDocument); }
        }

        public override object Document
        {
            get
            {
                if (_doc == null)
                    Load();
                return _doc;
            }
        }

        public override bool CanExportTo(ExportProvider exportProvider)
        {
            return exportProvider.CanExportObject(_doc);
        }
    }

    internal class ReportItemProgram : ReportItemBase
    {
        public ReportItemProgram()
        {
            ClearReportNames(true);
        }

        public override ReportKind ReportKind
        {
            get { return ReportKind.Program; }
        }

        public override string Name
        {
            get { return "External program"; }
        }

        public override void Load()
        {
            if (!File.Exists(FileName))
                throw new FileNotFoundException("Program file not found", FileName);
        }

        public override void UnLoad()
        {
            // nothing to do
        }

        public override bool Check(out string message)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                message = "Program file not specified.";
                return false;
            }
            if (Path.GetExtension(FileName).ToLowerInvariant() != ".exe")
            {
                message = "Program file has invalid extension (should be \".exe\").";
                return false;
            }
            message = string.Empty;
            return true;
        }

        public override Type DocumentType
        {
            get { return null; }
        }

        public override object Document
        {
            get { return null; }
        }

        public override bool CanExportTo(ExportProvider exportProvider)
        {
            return false;
        }
    }
}
