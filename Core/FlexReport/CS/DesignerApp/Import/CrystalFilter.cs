//----------------------------------------------------------------------------
// CrystalFilter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
using System.Windows.Forms;
using System.Xml;

using C1.Win.FlexReport;

namespace FlexReportDesignerApp.Util
{
    /// <summary>
    /// AssemblyLoadContext implementation.
    /// </summary>
    internal class CollectibleAssemblyLoadContext : AssemblyLoadContext
    {
        public CollectibleAssemblyLoadContext() : base(isCollectible: true)
        { }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            return null;
        }
    }

    /// <summary>
    /// Summary description for CrystalFilter.
    /// </summary>
    internal class CrystalFilter : IC1ReportImportFilter
    {
        private const string FlexCRI = "C1.Win.FlexCRI.5";
        private const string FlexReportDesignerApp = "C1FlexReportDesigner";
        private const string CrystalFilterType = "C1.Win.FlexCRI.CrystalFilter";

        private string _crystalFileName;
        private List<C1FlexReport> _rptList;
        private readonly ImportMessages _messages = new ImportMessages();

        #region Private

        private void LoadThisAssembly()
        {
            // Load the C1FlexReportDesigner assembly to current AppDomain, to ensure the valid license can be found.
            AppDomain.CurrentDomain.Load(FlexReportDesignerApp);
        }

        private void ShowInternalError(Exception ex)
        {
            MessageForm.Error(string.Format(Strings.CrystalFilter.ErrInternalFmt, ex.Message));
        }

        private bool DoImport(string criName, bool useNewDomain)
        {
            string reportsFileName = Path.GetTempFileName();
            string messagesFileName = Path.GetTempFileName();

            try
            {
                AppDomain domain;
                if (useNewDomain)
                {
                    //var info = new AppDomainSetup();
                    //domain = AppDomain.CreateDomain(criName, null, info);
                    //domain.DoCallBack(LoadThisAssembly);
                    domain = AppDomain.CreateDomain(criName);

                    // Load the C1FlexReportDesigner assembly to current AppDomain, to ensure the valid license can be found.
                    domain.Load(FlexReportDesignerApp);
                    //AppDomain.CurrentDomain.Load(FlexReportDesignerApp);

                    //domain.Load(.DoCallBack(LoadThisAssembly);

                    //byte[] result = null; // Assembly Emit-result from Roslyn
                    //System.Runtime.Loader.AssemblyLoadContext context = new CollectibleAssemblyLoadContext();
                    //System.IO.Stream ms = new System.IO.MemoryStream(result);
                    //System.Reflection.Assembly assembly = context.LoadFromStream(ms);


                    //System.Type programType = assembly.GetType("RsEval");
                    //MyAbstractClass eval = (MyAbstractClass)System.Activator.CreateInstance(programType);
                    //eval.LoadContext = context;
                    //eval.Stream = ms;
                }
                else
                {
                    domain = AppDomain.CurrentDomain;
                }

                var filter = domain.CreateInstanceAndUnwrap(criName, CrystalFilterType);
                var method = filter.GetType()
                    .GetMethod("Import", new[] {typeof (string), typeof (string), typeof (string)});
                var errorCode =
                    (int) method.Invoke(filter, new object[] {_crystalFileName, reportsFileName, messagesFileName});

                if (errorCode == CrystalImportErrorCodes.RASNotAvailable ||
                    errorCode == CrystalImportErrorCodes.CrystalNotInstalled)
                {
                    MessageForm.Error(Strings.CrystalFilter.ErrNoCrystalWithRAS);
                    return false;
                }

                if (!File.Exists(reportsFileName) || new FileInfo(reportsFileName).Length == 0)
                    // file with reports does not exist,  or it is empty
                    return false;

                // load reports
                try
                {
                    var doc = new XmlDocument();
                    doc.Load(reportsFileName);
                    string[] reportNames = C1FlexReport.GetReportList(doc);
                    if (reportNames == null)
                        return false;

                    foreach (string name in reportNames)
                    {
                        try
                        {
                            var report = new C1FlexReport();
                            report.Load(doc, name);
                            _rptList.Add(report);
                            if (Loading != null)
                                Loading(this, EventArgs.Empty);
                        }
                        catch
                        {
                        }
                    }
                }
                catch (Exception ex)
                {
                    // some internal error occurs show error message and exit
                    ShowInternalError(ex);
                    return false;
                }

                // load messages
                if (errorCode != CrystalImportErrorCodes.ErrorSavingMessages && File.Exists(messagesFileName) &&
                    new FileInfo(reportsFileName).Length > 0)
                {
                    try
                    {
                        _messages.Load(messagesFileName);
                    }
                    catch
                    {
                    }
                }

                // looks like we have some reports now
                return true;
            }
            finally
            {
                // delete temporary files
                try
                {
                    if (File.Exists(reportsFileName))
                        File.Delete(reportsFileName);
                    if (File.Exists(messagesFileName))
                        File.Delete(messagesFileName);
                }
                catch
                {
                }
            }
        }

        #endregion

        #region IC1ReportImportFilter implementation

        public event EventHandler Loading;

        bool IC1ReportImportFilter.Import(string rptFile, List<C1FlexReport> reportList)
        {
            _rptList = reportList;
            _crystalFileName = rptFile;

            if (!DoImport(FlexCRI, false))
            {
                MessageForm.Error(Strings.CrystalFilter.ErrNoCrystal);
                return false;
            }

            // show warnings...
            if (_messages.Count > 0)
            {
                ImportMessagesForm.DoShowMessages(_messages, Strings.CrystalFilter.MessageTitle,
                    Strings.CrystalFilter.ImportErrors);
            }

            // return false (don't erase list)
            return false;
        }

        #endregion
    }
}
