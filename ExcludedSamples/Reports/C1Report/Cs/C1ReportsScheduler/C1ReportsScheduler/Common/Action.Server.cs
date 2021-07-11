using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Drawing.Printing;
using System.IO;
using System.Diagnostics;
using C1.C1Preview;
using C1.C1Preview.Export;
using C1.C1Report;
using C1ReportsSchedulerService;

namespace C1ReportsScheduler
{
    /// <summary>
    /// Represents an action that may be performed on a <see cref="Task"/>,
    /// such as export or print.
    /// </summary>
    public class ActionServer : ActionBase
    {
        #region private fields
        private C1.C1Preview.Export.Exporter _exporter = null;

        private static readonly ActionKind[] c_reportDocActionKinds = new ActionKind[] { ActionKind.Export, ActionKind.Print };
        private static readonly ActionKind[] c_progActionKinds = new ActionKind[] { ActionKind.Run };
        private static readonly string[] c_exportFormatsNa = new string[] { ActionBase.c_exportNa };
        #endregion

        #region construction
        /// <summary>
        /// This ctor is for XML serialization only.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        private ActionServer()
            : base()
        {
            ResetExportFormatKey();
        }

        public ActionServer(TaskBase owner)
            : base(owner)
        {
            ResetExportFormatKey();
            // use Adobe PDF by default:
            this.ExportFormatKey = C1.C1Preview.Export.ExportProviders.PdfExportProvider.FormatKey;
        }

        internal ActionServer(ActionBase source)
            : base()
        {
            lock (SyncRoot)
                Util.CopyNonXmlIgnoreProperties(this, source, typeof(ActionBase));
        }

        /*
        internal static ActionServer FromBase(ActionBase source)
        {
            return new ActionServer(source);
        }
         */

        internal static ActionBase ToBase(ActionBase source)
        {
            ActionBase ret = new ActionBase();
            Util.CopyNonXmlIgnoreProperties(ret, source, typeof(ActionBase));
            return ret;
        }

        internal string ToProxyXml()
        {
            lock (SyncRoot)
                return Util.ToXml(ToProxy(), typeof(ActionProxy));
        }

        private ActionProxy ToProxy()
        {
            ActionProxy proxy = new ActionProxy();
            proxy.Id = this.Id;
            proxy.Kind = this.Kind;
            proxy.ExportFormatKey = this.ExportFormatKey;
            proxy.OutputFileName = this.OutputFileName;
            proxy.ExportFormatName = this.ExportFormatName;
            proxy.ExportDefaultExtension = this.ExportDefaultExtension;
            proxy.Message = this.Message;
            proxy.CheckedStatus = this.CheckedStatus;
            proxy.ExportFormatNames = this.ExportFormatNames;
            proxy.ActionKinds = this.ActionKinds;
            return proxy;
        }
        #endregion construction

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);

            TaskBase owner = _owner;
            if (propertyName != "CheckedStatus" && propertyName != "State")
            {
                CheckedStatus = CheckedStatus.Unknown;
                if (owner != null)
                    owner.CheckedStatus = CheckedStatus.Unknown;
            }

            if (owner == null)
                return;

            TaskListServer tasks = owner.Owner as TaskListServer;
            if (tasks == null)
                return;

            IC1ReportsSchedulerWcfCallback callback = tasks.WcfCallback;
            if (callback != null)
            {
                try
                {
                    callback.ActionPropertyChanged(owner.Id, this.Id, ToProxyXml(), propertyName);
                }
                catch (Exception ex)
                {
                    IC1ReportsSchedulerWcf wcfService = tasks.WcfService;
                    if (wcfService != null)
                        wcfService.Disconnect(ex.Message);
                }
            }
        }

        #region public stored properties
        public override ActionKind Kind
        {
            get
            {
                try
                {
                    if (_owner == null)
                        return _kind;
                    switch (_owner.ReportKind)
                    {
                        case ReportKind.C1dDocument:
                        case ReportKind.ImportedReport:
                        case ReportKind.XmlReport:
                            if (_kind == ActionKind.Run)
                                return ActionKind.Export;
                            else
                                return _kind;
                        case ReportKind.Program:
                            return ActionKind.Run;
                        default:
                            System.Diagnostics.Debug.Assert(false);
                            return ActionKind.Export;
                    }
                }
                catch (Exception ex)
                {
                    AltUtil.ShowError(ex.Message);
                    return _kind;
                }
            }
            set
            {
                if (value != Kind)
                {
                    lock (SyncRoot)
                    {
                        _kind = value;
                        ResetExportFormatKey();
                        ResetOutputFileName();
                    }
                    OnPropertyChanged("Kind");
                    OnPropertyChanged("ExportFormatName");
                    OnPropertyChanged("OutputFileName");
                }
            }
        }

        protected override void SetExportFormatKey(string value)
        {
            lock (SyncRoot)
            {
                _exporter = null;
                _exportFormatKey = value;
                if (_owner != null && Kind == ActionKind.Export && !string.IsNullOrEmpty(_exportFormatKey))
                {
                    try
                    {
                        _exporter = C1.C1Preview.Export.ExportProviders.RegisteredProviders.FindExportProviderByFormatKey(_exportFormatKey).NewExporter();
                    }
                    catch
                    {
                        ResetExportFormatKey();
                    }
                }
            }
        }

        protected override void ResetExportFormatKey()
        {
            lock (SyncRoot)
            {
                this.SetExportFormatKey(null);
                base.ResetExportFormatKey();
            }
        }

        public override string OutputFileName
        {
            set
            {
                if (value != _outputFileName)
                {
                    lock (SyncRoot)
                        _outputFileName = value;
                    OnPropertyChanged("OutputFileName");
                }
            }
        }

        protected override void ResetOutputFileName()
        {
            switch (Kind)
            {
                case ActionKind.Export:
                    OutputFileName = string.Empty;
                    break;
                case ActionKind.Print:
                    try
                    {
                        // at least on my machine, when running as a service, no printer was marked as default.
                        // hence we use the first one installed if could not find a default.
                        bool found = false;
                        for (int i = 0; i < PrinterSettings.InstalledPrinters.Count && !found; ++i)
                        {
                            PrinterSettings ps = new PrinterSettings();
                            ps.PrinterName = PrinterSettings.InstalledPrinters[i];
                            if (ps.IsDefaultPrinter)
                            {
                                OutputFileName = ps.PrinterName;
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            AltUtil.ShowWarning(string.Format("Could not find default printer, using {0}", PrinterSettings.InstalledPrinters[0]));
                            OutputFileName = PrinterSettings.InstalledPrinters[0];
                        }
                    }
                    catch
                    {
                        OutputFileName = string.Empty;
                    }
                    break;
                case ActionKind.Run:
                    OutputFileName = string.Empty;
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false);
                    break;
            }
        }
        #endregion public stored properties

        #region public non-stored properties

        [XmlIgnore]
        public override string ExportFormatName
        {
            get
            {
                Exporter exporter = _exporter;
                if (exporter == null)
                    return c_exportNa;
                else
                    return exporter.ExportProvider.FormatName;
            }
            set
            {
                if (value != ExportFormatName)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        ResetExportFormatKey();
                    }
                    else
                    {
                        bool found = false;
                        foreach (ExportProvider ep in ExportProviders.RegisteredProviders)
                        {
                            if (ep.FormatName == value)
                            {
                                this.ExportFormatKey = ep.FormatKey;
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                            ResetExportFormatKey();
                    }
                    OnPropertyChanged("ExportFormatName");
                }
            }
        }

        [XmlIgnore]
        public override string ExportDefaultExtension
        {
            get
            {
                Exporter exporter = _exporter;
                if (exporter == null)
                    return string.Empty;
                else
                    return exporter.ExportProvider.DefaultExtension;
            }
        }

        [XmlIgnore]
        public override string[] ExportFormatNames
        {
            get
            {
                try
                {
                    switch (_owner.ReportKind)
                    {
                        case ReportKind.C1dDocument:
                        case ReportKind.ImportedReport:
                            return GetExportFormatNames(typeof(C1PrintDocument));
                        case ReportKind.XmlReport:
                            return GetExportFormatNames(typeof(C1Report));
                        case ReportKind.Program:
                            return c_exportFormatsNa;
                        default:
                            return null;

                    }
                }
                catch (Exception ex)
                {
                    AltUtil.ShowError(ex.Message);
                    return null;
                }
            }
        }

        [XmlIgnore]
        public override ActionKind[] ActionKinds
        {
            get
            {
                try
                {
                    switch (_owner.ReportKind)
                    {
                        case ReportKind.XmlReport:
                        case ReportKind.ImportedReport:
                        case ReportKind.C1dDocument:
                            return c_reportDocActionKinds;
                        case ReportKind.Program:
                            return c_progActionKinds;
                        default:
                            System.Diagnostics.Debug.Assert(false);
                            return null;
                    }
                }
                catch (Exception ex)
                {
                    AltUtil.ShowError(ex.Message);
                    return null;
                }
            }
        }
        #endregion public non-stored properties

        #region public methods
#if false // unused
        private string[] GetExportFormatNames(ReportKind reportKind)
        {
            switch (reportKind)
            {
                case ReportKind.C1dDocument:
                case ReportKind.ImportedReport:
                    return GetExportFormatNames(c_dummyC1PrintDocument);
                case ReportKind.XmlReport:
                    return GetExportFormatNames(c_dummyC1Report);
                case ReportKind.Program:
                    return c_exportFormatsNa;
                default:
                    return null;
            }
        }

        public string[] GetExportFormatNames(Type documentType)
        {
            if (typeof(C1PrintDocument).IsAssignableFrom(documentType))
                return GetExportFormatNames(c_dummyC1PrintDocument);
            else if (typeof(C1Report).IsAssignableFrom(documentType))
                return GetExportFormatNames(c_dummyC1Report);
            else
                return null;
        }
#endif

        public override bool Run()
        {
            ActionState savedState = State;
            State = ActionState.Running;
            CheckedStatus = CheckedStatus.Working;
            try
            {
                if (AltUtil.LogActions)
                {
                    string actionLog = string.Format("Running action Id {0} (task Id {1}): Type '{2}', Output file '{3}' (Export format '{4}').",
                        Id, _owner.Id, this.Kind, this.OutputFileName, this.ExportFormatName);
                    AltUtil.LogMessage(actionLog);
                }
                switch (Kind)
                {
                    case ActionKind.Export:
                        return Export();
                    case ActionKind.Print:
                        return Print();
                    case ActionKind.Run:
                        return RunProgram();
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        return false;
                }
            }
            catch (Exception ex)
            {
                AltUtil.ShowError(string.Format("Error running action Id {0} (task Id {1}): {2}.", Id, _owner.Id, ex.Message));
                throw;
            }
            finally
            {
                State = savedState;
                CheckedStatus = CheckedStatus.CheckedOk;
                if (AltUtil.LogActions)
                    AltUtil.LogMessage(string.Format("Finished running action {0}.", Id));
            }
        }

        public override bool Check()
        {
            if (CheckedStatus != CheckedStatus.Unknown)
                return CheckedStatus == CheckedStatus.CheckedOk;
            bool ok = CanRun(out _message);
            CheckedStatus = ok ? CheckedStatus.CheckedOk : CheckedStatus.Invalid;
            return ok;
        }
        #endregion public methods

        #region private methods
        // note: this assumes that a format is uniquely identified by its "name".
        private string[] GetExportFormatNames(Type docType)
        {
            List<string> formats = new List<string>();
            List<ExportProvider> providers = new List<ExportProvider>();
            List<Type> replacedProviders = new List<Type>();
            if (this.Kind == ActionKind.Export && docType != null)
            {
                // get all providers able to export our document:
                foreach (ExportProvider ep in ExportProviders.RegisteredProviders)
                {
                    //qq if (ep.CanExportObject(document) && ep.PreferredOrdinal >= 0)
                    if (ep.CanExportType(docType) && ep.PreferredOrdinal >= 0)
                    {
                        providers.Add(ep);
                        C1ReportExportProvider repEp = ep as C1ReportExportProvider;
                        if (repEp != null && repEp.ReplacesProvider != null)
                            replacedProviders.Add(repEp.ReplacesProvider);
                    }
                }
                // remove (generic) providers that are replaced by specific (c1report) ones:
                for (int i = providers.Count - 1; i >= 0; --i)
                {
                    if (replacedProviders.Contains(providers[i].GetType()))
                        providers.RemoveAt(i);
                }
                // sort by PreferredOrdinal:
                providers.Sort(
                 delegate(ExportProvider a, ExportProvider b)
                 {
                     return Comparer<int>.Default.Compare(a.PreferredOrdinal, b.PreferredOrdinal);
                 }
                );
                // build list of format names:
                foreach (ExportProvider ep in providers)
                    formats.Add(ep.FormatName);
            }
            if (formats.Count == 0)
                formats.Add(c_exportNa);
            return formats.ToArray();
        }

        private bool CanRun(out string message)
        {
            switch (Kind)
            {
                case ActionKind.Export:
                    return CanExport(out message);
                case ActionKind.Print:
                    return CanPrint(out message);
                case ActionKind.Run:
                    return CanRunProgram(out message);
                default:
                    message = "Unknown action kind.";
                    System.Diagnostics.Debug.Assert(false);
                    return false;
            }
        }

        private bool CanExport(out string message)
        {
            if (this.Kind != ActionKind.Export)
            {
                message = "Action is not \"Export\".";
                return false;
            }
            if (_owner.Document == null)
            {
                message = "Cannot load document.";
                return false;
            }
            if (string.IsNullOrEmpty(OutputFileName))
            {
                message = "Output file name not specified.";
                return false;
            }
            System.Diagnostics.Debug.Assert(_exporter != null);
            if (_exporter == null)
            {
                message = "Failed to create exporter.";
                return false;
            }
            if (!_exporter.ExportProvider.CanExportObject(_owner.Document))
            {
                message = "Cannot export this document using the specified exporter.";
                return false;
            }
            message = string.Empty;
            return true;
        }

        private bool Export()
        {
            string message;
            if (!CanExport(out message))
            {
                AltUtil.ShowError(string.Format("Cannot export: {0}", message));
                return false;
            }
            // do NOT try/catch here - exceptions should be handled by the caller (Run()):
            Exporter exporter = _exporter;
            exporter.Document = _owner.Document;
            // Note: setting ShowOptions to false should not be needed since a test
            // for IsUserInteractive was added in export (2.6.20093 or later).
            exporter.ShowOptions = false;
            // todo: add action's property to store export options, set them here:
            exporter.Export(OutputFileName);
            return true;
        }

        private bool CanPrint(out string message)
        {
            if (this.Kind != ActionKind.Print)
            {
                message = "Action is not \"Print\".";
                return false;
            }
            object document = _owner.Document;
            if (document == null)
            {
                message = "Cannot load document.";
                return false;
            }
            if (!(document is C1Report) && !(document is C1PrintDocument))
            {
                message = "Unknown document type.";
                return false;
            }
            bool printerFound = false;
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                if (printerName == this.OutputFileName)
                {
                    printerFound = true;
                    break;
                }
            }
            if (!printerFound)
            {
                message = string.Format("Printer {0} not found.", OutputFileName);
                return false;
            }
            message = string.Empty;
            return true;
        }

        private bool Print()
        {
            string message;
            if (!CanPrint(out message))
            {
                AltUtil.ShowError(string.Format("Cannot print: {0}", message));
                return false;
            }
            object document = _owner.Document;
            C1Report report = document as C1Report;
            C1PrintDocument printDoc = report == null ? (C1PrintDocument)document : report.C1Document;
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = OutputFileName;
            if (!ps.IsValid)
                return false;
            printDoc.Print(ps);
            return true;
        }

        private bool CanRunProgram(out string message)
        {
            if (this.Kind != ActionKind.Run)
            {
                message = "Action is not \"Run\".";
                return false;
            }
            if (!File.Exists(_owner.FileName))
            {
                message = string.Format("Executable file {0} not found.", _owner.FileName);
                return false;
            }
            if (Path.GetExtension(_owner.FileName).ToLowerInvariant() != ".exe")
            {
                message = string.Format("File {0} has invalid extension (should be \".exe\").", _owner.FileName);
                return false;
            }
            message = string.Empty;
            return true;
        }

        private bool RunProgram()
        {
            string message;
            if (!CanRunProgram(out message))
            {
                AltUtil.ShowError(string.Format("Cannot run program: {0}", message));
                return false;
            }
            using (Process prog = new Process())
            {
                prog.StartInfo.FileName = _owner.FileName;
                prog.StartInfo.CreateNoWindow = true;
                prog.StartInfo.UseShellExecute = false;
                prog.StartInfo.RedirectStandardError = true;
                prog.StartInfo.RedirectStandardOutput = true;
                // prog.StartInfo.Arguments = ""; todo
                prog.ErrorDataReceived += new DataReceivedEventHandler(prog_ErrorDataReceived);
                prog.OutputDataReceived += new DataReceivedEventHandler(prog_OutputDataReceived);

                prog.Start();

                prog.BeginErrorReadLine();
                prog.BeginOutputReadLine();

                // timeout 1 minute (todo: allow to specify timeout):
                int timeout = (int)(TimeSpan.TicksPerMinute / TimeSpan.TicksPerMillisecond);
                if (!prog.WaitForExit(timeout))
                    AltUtil.ShowError(string.Format("Timeout waiting for program \"{0}\" to exit (waited {1} milliseconds).", _owner.FileName, timeout));
                else
                {
                    if (AltUtil.LogActions)
                        AltUtil.LogMessage(string.Format("Program \"{0}\" ended, exit code {1}.", _owner.FileName, prog.ExitCode));
                }

                prog.Close();
            }
            return true;
        }

        private void LogOutput(Process prog, DataReceivedEventArgs e, bool error)
        {
            // ignore empty data:
            if (string.IsNullOrEmpty(e.Data))
                return;
            if (!AltUtil.LogProgramOutput)
                return;
            try
            {
                string msg = string.Format("Process \"{0}\" {1}: {2}", prog.ProcessName, error ? "ERROR" : "OUTPUT", e.Data);
                AltUtil.LogMessage(msg);
            }
            catch (Exception ex)
            {
                AltUtil.ShowError(ex.Message);
            }
        }

        private void prog_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            LogOutput(sender as Process, e, false);
        }

        private void prog_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            LogOutput(sender as Process, e, true);
        }
        #endregion private methods
    }

    public class ActionListServer : ActionList
    {
        protected override void OnAddingNew(AddingNewEventArgs e)
        {
            e.NewObject = new ActionServer(_owner);
            base.OnAddingNew(e);
        }

        protected override void RemoveItem(int index)
        {
            lock (SyncRoot)
            {
                long id = ActionId(index);
                base.RemoveItem(index);
                TaskListServer tasks = _owner.Owner as TaskListServer;
                if (tasks == null)
                    return;
                IC1ReportsSchedulerWcfCallback wcfCallback = tasks.WcfCallback;
                if (wcfCallback == null)
                    return;
                wcfCallback.ActionRemoved(_owner.Id, id);
            }
        }

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            base.OnListChanged(e);

            TaskBase owner = _owner;
            if (owner == null)
                return;

            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted)
                owner.CheckedStatus = CheckedStatus.Unknown;

            TaskListServer tasks = owner.Owner as TaskListServer;
            if (tasks == null)
                return;

            IC1ReportsSchedulerWcfCallback wcfCallback = tasks.WcfCallback;
            if (wcfCallback == null)
                return;

            try
            {
                switch (e.ListChangedType)
                {
                    case ListChangedType.ItemAdded:
                        try
                        {
                            ActionServer action = (ActionServer)this[e.NewIndex];
                            long ownerId;
                            long actionId;
                            string xml;
                            lock (action.SyncRoot)
                            {
                                ownerId = owner.Id;
                                actionId = action.Id;
                                xml = action.ToProxyXml();
                            }
                            wcfCallback.ActionAdded(ownerId, e.NewIndex, actionId, xml);
                        }
                        catch (Exception ex)
                        {
                            AltUtil.ShowError(ex.Message);
                        }
                        break;
                    case ListChangedType.ItemChanged:
                        try
                        {
                            ActionServer action = (ActionServer)this[e.NewIndex];
                            long ownerId;
                            long actionId;
                            string xml;
                            lock (action.SyncRoot)
                            {
                                ownerId = owner.Id;
                                actionId = action.Id;
                                xml = action.ToProxyXml();
                            }
                            wcfCallback.ActionPropertyChanged(ownerId, actionId, xml, e.PropertyDescriptor.Name);
                        }
                        catch (Exception ex)
                        {
                            AltUtil.ShowError(ex.Message);
                        }
                        break;
                    case ListChangedType.ItemDeleted:
                        // we need removed task's id, hence TaskRemoved must be called from RemoveItem override:
                        // wcfCallback.TaskRemoved(TaskId(e.NewIndex));
                        break;
                    case ListChangedType.ItemMoved:
                        break;
                    case ListChangedType.Reset:
                        break;
                }
            }
            catch (Exception ex)
            {
                AltUtil.ShowError(ex.Message);
                IC1ReportsSchedulerWcf wcfService = tasks.WcfService;
                if (wcfService != null)
                    wcfService.Disconnect(ex.Message);
            }
        }

        public override void MoveAction(long actionId, bool down)
        {
            lock (SyncRoot)
            {
                int index;
                ActionBase action = this.ActionById(actionId, out index);
                if (action == null)
                    return;
                if (down && index >= this.Count - 1)
                    return;
                if (!down && index <= 0)
                    return;

                this.RemoveAt(index);
                int newIdx = down ? index + 1 : index - 1;
                this.Insert(newIdx, action);
            }
        }

        public override void RemoveAction(long actionId)
        {
            lock (SyncRoot)
            {
                int index;
                ActionBase action = this.ActionById(actionId, out index);
                if (action != null)
                    this.RemoveAt(index);
            }
        }
    }
}
