//----------------------------------------------------------------------------
// Strings.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp
{
    public static class Strings
    {
        public static class Common
        {
            public const string None = @"(none)";
            public const string UnavailableFmt = @"{0} (unavailable)";
            public const string DuplicateName = @"Duplicate name.";
            public const string EmptyName = @"Name cannot be empty.";
            public const string DataSourceInfoNotFetched = @"Data Source info has not been fetched yet.";
            public const string UnexpectedError = @"Unexpected Error.";
            public const string EmptyExpression = @"Expression cannot be empty.";
            public const string DbFields = @"Data Fields";
            public const string CalcFields = @"Calculated Fields";
            public const string ReportParams = @"Report Parameters";
            public const string ReportFields = @"Report Fields";
            public const string ExprEditor = @"<Expression Editor...>";
            public const string FetchingDataSourceInfoTooltip = @"Fetching data source info...";
        }
        public static class MainForm
        {
            public const string CreateMainDataSourceQ = @"The current report does not have a main data source, do you want to create one now?";
            public const string RemoveDataSourceFmt = @"Are you sure you want to remove data source ""{0}""?";
            public const string ErrorSavingFileFmt = @"{0}\r\n\r\nError saving file: {1}";
            public const string OutsideChangedFileModFmt = @"{0}\r\n\r\nThe file has been modified outside of FlexReportDesigner.\r\nDo you want to reload it and lose the changes made in the designer?";
            public const string OutsideFileModFmt = @"{0}\r\n\r\nThe file has been modified outside of FlexReportDesigner.\r\nDo you want to reload it?";
            public const string RenameToFLXRWarning = @"Opening a legacy C1Report file: reports in this file will be converted to FlexReport format.The loaded file extension will be changed to FlexReport's default .FLXR extension.";
            public const string NameInAboutBox = @"ComponentOne FlexReport Designer App";
            public const string RibbonApplicationButton = @"FILE";
            public const string NewCalcFieldExprName = @"New Calculated Field";
            public const string UnlockSelectedFields = @"Unlock Selected Fields";
            public const string LockSelectedFields = @"Lock Selected Fields";
            public const string ClickToCopyErrors = @"(click here to copy the error list to the clipboard)\r\n";
            public const string AppName = @"FlexReportDesigner";
            public const string AppNameModeFmt = @"FlexReportDesigner ({0} bit mode)";
            public const string AppCaptionFmt = @"{0} - {1}{2}";
            public const string AppIn64bitModeWarning = @"The application is now running in 64 bit mode. Some data providers (such as Microsoft.Jet.OLEDB.4.0) are unavailable in this mode. If you need to use such providers, please run the 32 bit version of this application instead.";
            public const string Component = @"[Component]";
            public const string FileOpenFilter = @"FlexReport Definition Files (*.flxr)|*.flxr|Legacy C1Report Definition Files (*.xml)|*.xml|All Files|*.*";
            public const string FileSaveFilter = @"FlexReport Definition Files (*.flxr)|*.flxr|All Files|*.*";
            public const string ExportToPdfFormatName = @"Adobe PDF";
            public const string ExportToPdfAFormatName = @"Adobe PDF/A";
            public const string ExportToPlainHtmlFormatName = @"Plain HTML";
            public const string ExportToPagedHtmlFormatName = @"Paged HTML";
            public const string ExportToC1dxText = @"ComponentOne OpenXml";
            public const string ExportToC1dxToolTip = @"Export to ComponentOne OpenXml (C1DX)";
            public const string Loading = @"Loading...";
            public const string Working = @"Working...";
            public const string Ready = @"Ready";
            public const string ErrCannotFindCustomFldAsmFmt = @"Custom field assembly '{0}' (or one of its dependencies) not found.";
            public const string ErrCannotInstCustomFldFmt = @"Cannot instantiate class '{0}'.\r\nCheck custom field class name in the .settings file (it should include the namespace).";
            public const string ErrCustomFldIsNotFieldFmt = @"Class '{0}' does not derive from C1.Win.FlexReport.Field and cannot be used as a custom field.\r\nCheck customfields entry in the .settings file.";
            public const string CustomFldDescriptionFmt = @"{0} Field";
            public const string CustomFldToolTipHeaderFmt = @"Add {0}";
            public const string CustomFldToolTipFmt = @"Add custom field of type <b>{0}</b>, loaded from assembly <b>{1}</b>.";
            public const string CustomFldToolTipTemplateFmt = @"<table><tr><td><parm></parm></td><td><b><parm>{0}</parm></b></td></tr></table><parm></parm><div style='margin:1 12'><parm><p>{1}</p><p>Available custom fields are specified by the &lt;customfields&gt; section in the <b>C1FlexReportDesigner.exe.settings</b> file.</p></parm></div><parm></parm><table><tr><td><parm></parm></td><td><b><parm></parm></b></td></tr></table>";
            public const string CannotOpenDataSourceFmt = @"Failed to open the specified data source.{0}\r\n\r\nWould you like to edit the data source?";
            public const string OpenDataSourceErrDetailFmt = @"\r\n\r\n** Error details:\r\n{0}";
            public const string ErrRenderingReportFmt = @"Error rendering report:\r\n{0}";
            public const string ErrCannotOpenRecentFmt = @"File '{0}' cannot be opened and has been removed from the recent files list.";
            public const string OfPagesFmt = @"of {0}";
            public const string PercentFmt = @"{0}%";
            public const string ReportFmt = @"Report: {0}";
            public const string ReportNotSelected = @"Report: Not selected";
            public const string FallbackReportName = @"Report";
            public const string RecentFileMenuFmt = @"   {0}";
            public const string NumberedRecentFileMenuFmt = @"&{0}  {1}";
            public const string OpenFileDlgTitle = @"Open Report Definition File";
            public const string ErrCannotLoadReportFmt = @"Cannot load '{0}' because of the following error:\r\n{1}";
            public const string ErrCannotImportReportFmt = @"Cannot import '{0}' because of the following error:\r\n{1}";
            public const string ErrCannotExportReportFmt = @"Cannot export to '{0}' because of the following error:\r\n{1}";
            public const string ErrCannotFindAnyReportsFmt = @"Cannot find any reports in '{0}'.\r\nPlease make sure the file contains reports and that the reports have names.";
            public const string LoadingReportOfReportsFmt = @"Loading {0} of {1}: '{2}'";
            public const string ImportReportDlgTitle = @"Import Report Definition";
            public const string ImportFilter = @"All Supported Formats (*.mdb,*.adp,*.rpt)|*.mdb;*.adp;*.rpt|Microsoft Access Reports (*.mdb,*.adp)|*.mdb;*.adp|Crystal Reports (*.rpt)|*.rpt|All Files (*.*)|*.*";
            public const string ImportFilterBorland = @"Microsoft Access Reports (*.mdb,*.adp)|*.mdb;*.adp|All Files (*.*)|*.*";
            public const string OpenImageFilter = @"All Image Files|*.bmp;*.png;*.gif;*.jpg;*.dib;*.ico;*.cur;*.wmf;*.emf|Bitmaps (*.bmp;*.dib)|*.bmp;*.dib|Icons & Cursors (*.ico;*.cur)|*.ico;*.cur|Web Images (*.gif;*.jpg;*.png)|*.gif;*.jpg;*.png|Metafiles (*.wmf;*.emf)|*.wmf;*.emf|All Files (*.*)|*.*";
            public const string ImportingFromFmt = @"Importing from '{0}'...";
            public const string ImportingReportFmt = @"Importing '{0}'...";
            public const string SaveReportDlgTitle = @"Save Report Definition File";
            public const string SavingFmt = @"Saving {0} of {1}: '{2}'";
            public const string SaveChangesQ = @"Would you like to save the changes you made to this file?";
            public const string SaveChangesTempFileQ = @"Would you like to save the changes you made to this report?";
            public const string ExportingFmt = @"Exporting '{0}' to '{1}'...";
            public const string ExportingPercentFmt = @"Exporting '{0}' to '{1}', {2:0.0%} complete";
            public const string ExportReportDlgTitle = @"Export Report to File";
            public const string NewFieldNameFmt = @"Field{0}";
            public const string ConfirmDeleteReportFmt = @"Are you sure you want to delete the '{0}' report?\r\nThis action cannot be undone.";
            public const string FatalExcInnerFmt = @"A fatal error occurred:\n{0}\nInner exception was:\n{1}\n\nPress OK to exit.";
            public const string FatalExcFmt = @"A fatal error occurred:\n{0}\n\nPress OK to exit.";
            public const string ReportNameMustBeUnique = @"Report names must be unique. Please choose a different name.";
            public const string RenderingPressEsc = @"Rendering '{0}' (Press ESC to Cancel)...";
            public const string Rendering = @"Rendering '{0}'...";
            public const string ErrorsInReportFmt = @"** Report [{0}] contains errors:\r\n{1}";
            public const string ApplyToAllQ = @"Are you sure you want to apply this information to all reports?";
            public const string HelpUrl = @"http://helpcentral.componentone.com/nethelp/FlexReport/";
            public const string HelpUrlErrorFmt = @"Error opening URL:\r\n{0}";
            public const string ClipboardErrorFmt = @"Error accessing Clipboard:\r\n{0}";
            public const string RibbonButtonSetDataSource = @"Set as Main Data Source";
            public const string RibbonButtonEdit = @"Edit...";
            public const string RibbonButtonRemove = @"Remove";
        }
        public static class CommonFields
        {
            public const string DatePrinted = @"Date Printed";
            public const string TimePrinted = @"Time Printed";
            public const string DateCreated = @"Date Created";
            public const string TimeCreated = @"Time Created";
            public const string PageNumber = @"Page Number";
            public const string PageCount = @"Page Count";
            public const string PageNOfM = @"Page n of m";
            public const string ReportName = @"Report Name";
        }
        public static class RightToLeftConverter
        {
            public const string Default = @"Default";
        }
        public static class PreviewForm
        {
            public const string StatusFmt = @"{0:#,##0} rows";
        }
        public static class SqlBuilderDialog
        {
            public const string Connection = @"Connection";
            public const string Tables = @"Tables";
            public const string Views = @"Views";
            public const string ErrCannotBuildConnFmt = @"Cannot build connection string because:\r\n{0}";
            public const string ErrCannotGetDataFmt = @"Failed to retrieve the data:\r\n{0}";
            public const string ClearQueryQ = @"Are you sure you want to clear this query?";
            public const string SqlVerified = @"The SQL syntax has been verified against the data source.";
            public const string NotAllTablesJoined = @" ** Not all tables in the query are joined. **";
        }
        public static class ReportStyle
        {
            public const string UnknownName = @"<unknown>";
            public const string CustomNameQualifier = @" (custom)";
            public const string WarningTitle = @"Predefined Styles Warning";
            public const string ErrCannotCreateStyleFmt = @"Cannot create predefined style ""{0}"", error was:\r\n {1}";
            public const string SamplePageHeaderText = @"Page Header";
            public const string SampleGroupHeaderText = @"Group Header";
            public const string SampleDetailText = @"  Detail";
            public static class PredefinedStyleNames
            {
                public const string Windows_Vista = @"Windows Vista";
                public const string Web_Report = @"Web Report";
                public const string Northwind = @"Northwind";
                public const string Verve = @"Verve";
                public const string Verdana = @"Verdana";
                public const string Urban = @"Urban";
                public const string Trek = @"Trek";
                public const string Technic = @"Technic";
                public const string Solstice = @"Solstice";
                public const string Soft_Gray = @"Soft Gray";
                public const string Paper = @"Paper";
                public const string Origin = @"Origin";
                public const string Oriel = @"Oriel";
                public const string Opulent = @"Opulent";
                public const string Office = @"Office";
                public const string None = @"None";
                public const string Module = @"Module";
                public const string Metro = @"Metro";
                public const string Median = @"Median";
                public const string Foundry = @"Foundry";
                public const string Formal = @"Formal";
                public const string Flow = @"Flow";
                public const string Equity = @"Equity";
                public const string Corporate = @"Corporate";
                public const string Concourse = @"Concourse";
                public const string ComponentOne = @"ComponentOne";
                public const string Compact = @"Compact";
                public const string Civic = @"Civic";
                public const string Casual = @"Casual";
                public const string Bold = @"Bold";
                public const string Aspect = @"Aspect";
                public const string Apex = @"Apex";
                public const string Access_2007 = @"Access 2007";
                public const string Access_2003 = @"Access 2003";
            }
        }
        public static class AppSettings
        {
            public const string ErrCannotLoadSettingsFmt = @"Failed to load settings from '{0}'.\r\nThe existing settings file will be replaced with a new empty one.\r\nIf you want to save any of the information in the old settings file, copy it before clicking OK.";
            public const string InvalidSettingsTitle = @"Invalid Settings";
            public const string WarnEncryptedInFipsLoadingFmt = @"Warning: encrypted application settings are not supported in a FIPS compliant environment.\nNodes of {0} ""{1}"" were ignored while loading settings.";
            public const string WarnEncryptedInFipsSavingFmt = @"Warning: encrypted application settings are not supported in a FIPS compliant environment.\nNodes of {0} ""{1}"" were ignored while saving settings.";
            public const string ErrorSettingFileAssocFmt = @"Error trying to associate .flxr extension with FlexReportDesigner app:\r\n{0}";
        }
        public static class DataSourcePicker
        {
            public const string TtipBtnEditConnection = @"Edit connection string";
            public const string TtipBtnDataSourceProperties = @"Edit properties of the selected external data source";
            public const string Tables = @"Tables";
            public const string Views = @"Views";
            public const string StoredProcedures = @"Stored procedures";
            public const string Recordsets = @"Recordsets";
            public const string AutoCaption = @"Auto";
            public const string AutoShortCaption = @"Auto";
            public const string OleDbCaption = @"OLEDB Data Provider";
            public const string OleDbShortCaption = @"OLEDB";
            public const string SqlServerCe3_5Caption = @"Microsoft SQL Server Compact Data Provider 3.5";
            public const string SqlServerCe3_5ShortCaption = @"SqlServerCe 3.5";
            public const string SqlServerCe4_0Caption = @"Microsoft SQL Server Compact Data Provider 4.0";
            public const string SqlServerCe4_0ShortCaption = @"SqlServerCe 4.0";
            public const string SQLiteCaption = @"SQLite Data Provider";
            public const string SQLiteShortCaption = @"SQLite";
            public const string OdbcCaption = @"ODBC Data Provider";
            public const string OdbcShortCaption = @"ODBC";
            public const string XmlCaption = @"Connection to XML database";
            public const string XmlShortCaption = @"XML";
            public const string ExternalCaption = @"Connection to object in external assembly";
            public const string ExternalShortCaption = @"External";
            public const string ErrCannotGetTablesDbFmt = @"Cannot get list of available tables/views/stored procedures from data source:\r\n{0}\r\n\r\nError:\r\n{1}";
            public const string ErrCannotGetTablesOleDbFmt = @"Cannot get list of available tables and views from data source:\r\n{0}\r\nGetOleDbSchemaTable() returns unsupported data schema.";
            public const string ErrCannotGetStoredProcsFmt = @"Cannot get list of available stored procedures from data source:\r\n{0}\r\nGetOleDbSchemaTable() returns unsupported data schema.";
            public const string ErrCannotGetTablesOdbcFmt = @"Cannot get list of available tables from data source:\r\n{0}\r\nGetSchema() returns unsupported data schema.";
            public const string ErrCannotGetViewsOdbcFmt = @"Cannot get list of available views from data source:\r\n{0}\r\nGetSchema() returns unsupported data schema.";
            public const string ErrCannotGetStoredProcsOdbcFmt = @"Cannot get list of available stored procedures from data source:\r\n{0}\r\nGetSchema() returns unsupported data schema.";
            public const string WarnFailedToCreateDataLinks = @"Failed to create DataLinks.\r\nPlease check that oledb32.dll is properly installed and registered. (the usual location is C:\Program Files\Common Files\System\Ole DB\oledb32.dll).";
            public const string XmlDialogTitle = @"Select XML Schema Definition File";
            public const string XmlDialogFilter = @"XSD Data Files (*.xsd)|*.xsd|XML Data Files (*.xml)|*.xml|All Files|*.*";
            public const string XmlFileNotFoundFmt = @"XML file [{0}] does not exist.";
            public const string NoTablesInXmlFileFmt = @"DataSet loaded from file [{0}] does not contain any tables.";
            public const string ErrLoadingDatasetFromXmlFmt = @"Cannot load data set from XML file [{0}]. Error:\r\n{1}";
            public const string ExternalDialogTitle = @"Select Aassembly with External Data Source";
            public const string ExternalDialogFilter = @"Assemblies (*.dll)|*.dll|All Files|*.*";
            public const string ErrCannotLoadAsmbFmt = @"Cannot load assembly from file [{0}].";
            public const string ErrNoDataInAsmbFmt = @"Assembly [{0}] does not contain any supported data sources.";
            public const string ErrCannotLoadDataFromAsmbFmt = @"Cannot load data set from assembly [{0}]. Error:\r\n{1}";
            public const string ProviderNotInstalledFmt = @"{0} is not installed on the system.";
            public const string ErrCannotEditConnFmt = @"Cannot edit connection string, error:\r\n{0}";
        }
        public static class FieldPicker
        {
            public const string UnnamedReport = @"(Unnamed Report)";
            public const string UnnamedSection = @"(Unnamed Section)";
            public const string UnnamedSubSection = @"(Unnamed SubSection)";
            public const string UnnamedField = @"(Unnamed Field)";
        }
        public static class GroupEditorForm
        {
            public const string GroupingCagetory = @"Grouping and Sorting";
            public const string HeadersCagetory = @"Headers";
            public const string HeaderDescription = @"Specifies whether the group header section is visible.";
            public const string FooterDescription = @"Specifies whether the group footer section is visible.";
            public const string KeepNo = @"No";
            public const string KeepWholeGroup = @"Whole Group";
            public const string KeepFirstDetail = @"First Detail";
            public const string NewGroupName = @"New Group";
        }
        public static class LinkSubreportForm
        {
            public const string CannotFindField = @"Cannot find selected subreport field.";
            public const string CannotGetMasterFields = @"Cannot retrieve fields for master report.";
            public const string CannotGetSubreportFields = @"Cannot retrieve fields for subreport.";
        }
        public static class OptionsForm
        {
            public const string UnitsAuto = @"Automatic";
            public const string UnitsEnglish = @"English (in)";
            public const string UnitsMetric = @"Metric (cm)";
            public const string UnitsCustom = @"Custom";
            public const string FontFmt = @"{0}, {1}pt";
        }
        public static class ReportStyleForm
        {
            public const string TtipBtnApply = @"Apply selected style to the report";
            public const string TtipBtnRemove = @"Remove custom style";
            public const string TtipBtnAdd = @"Add a custom style based on the current selection";
            public const string CustomStyleCaption = @"Custom Style:";
            public const string BuiltInStyleCaption = @"Built-In Style (read-only):";
            public const string ConfirmSaveStyle = @"Do you want to save the style definition changes?";
        }
        public static class ReportWizard
        {
            public const string Finish = @"&Finish";
            public const string Next = @"&Next >";
            public const string NewReport = @"New Report";
            public const string SpaceReport = @" Report";
            public const string MessageTitle = @"Report Wizard";
            public const string EnterNewReportName = @"Please enter a name for the new report.";
            public const string PageOfPagesText = @"""Page "" & [Page] & "" of "" & [Pages]";
        }
        public static class ScriptEditorControl
        {
            public const string ConfirmSaveFmt = @"""{0}"" has changed. Do you want to save it?";
            public const string ConfirmSaveMore = @"(Turn on ""Autosave Current Script"" in VIEW | Options to auto-save changes without showing this message.)";
        }
        public static class ScriptEditorForm
        {
            public const string ColumnFmt = @"Col {0}";
            public const string LineFmt = @"Ln {0}";
            public const string CaptionEmpty = @"VBScript Editor";
            public const string CaptionFilterFmt = @"Expression Editor - DataSource.Filter {0}";
            public const string CaptionVBScriptFmt = @"VBScript Editor - {0} {1}";
            public const string MnuReportGroups = @"Report Groups";
            public const string MnuReportSections = @"Report Sections";
            public const string MnuReportVariables = @"Report Variables";
            public const string MnuAggregateFunctions = @"Aggregate Functions";
            public const string MnuBuiltinFunctions = @"Built-in Functions";
            public const string MnuStringFunctions = @"String Functions";
            public const string MnuDataConversion = @"Data Conversion";
            public const string MnuMathFunctions = @"Math Functions";
            public const string MnuDateTimeFunctions = @"Date/Time Functions";
            public const string MnuProgramLogic = @"Program Logic";
            public const string MnuConstants = @"Constants";
            public const string MnuMiscellaneous = @"Miscellaneous";
            public const string MnuFunctionsAndSubs = @"Functions and Subs";
        }
        public static class SqlServerCeConnectionStringEditorForm
        {
            public const string SdfFilter = @"Microsoft SQL Server Compact database (*.sdf)|*.sdf|All files(*.*)|*.*";
            public const string ErrSpecifyDbFileName = @"Please specify the database file name.";
            public const string ErrSpecifyTempDir = @"Temp file directory must be specified if file mode is ""Read Only"".";
            public const string FileModeRO = @"Read Only";
            public const string FileModeRW = @"Read Write";
            public const string FileModeEX = @"Exclusive";
            public const string FileModeSR = @"Shared Read";
        }
        public static class SQLiteConnectionStringEditorForm
        {
            public const string DbFilter = @"SQLite database (*.db)|*.db|All files(*.*)|*.*";
        }
        public static class AccessFilter
        {
            public const string MessageTitle = @"Access Import";
            public const string ErrNoReportsFmt = @"'{0}' does not contain any reports.";
        }
        public static class CrystalFilter
        {
            public const string MessageTitle = @"Crystal Import";
            public const string ErrInternalFmt = @"Internal error occurred during import:\r\n{0}";
            public const string ErrNoCrystal = @"Import failure. Please make sure that Crystal is installed on your system.";
            public const string ErrNoExecutables = @"Import failure. FlexReportDesigner uses external executables ({0} and {1}) to perform import of Crystal Report reports, both executables are not found, please be sure that they exists in the FlexReportDesigner application directory.";
            public const string ErrNoCRI2010 = @"Import failure. FlexReportDesigner uses external executables ({0} and {1}) to perform import of Crystal Report reports, {0} is not found, please be sure that it exists in the FlexReportDesigner application directory.";
            public const string ErrNoCRI2008 = @"Import failure. FlexReportDesigner uses external executables ({0} and {1}) to perform import of Crystal Report reports, {1} is not found, please be sure that it exists in the FlexReportDesigner application directory.";
            public const string ImportErrors = @"Import errors and warnings:";
            public const string RASNotAvailable = @"Import from Crystal Reports could not initialize RAS API. Installing Crystal Reports 13.0.2000.0 or later enables RAS and can improve import results.\nDo you want to continue without RAS?";
            public const string ErrNoCrystalWithRAS = @"Import from Crystal Reports could not intialize RAS API. Please install Crystal Reports 13.0.2000.0 or later.";
        }
        public static class DataSourceForm
        {
            public const string SelectDataSource = @"Please select data source.";
        }
        public static class CheckForUpdatesForm
        {
            public const string NoUpdatesAvailable = @"No updates are currently available.";
            public const string CannotConnect = @"Could not access ComponentOne web site, please check your internet connection or try again later.";
            public const string ErrorCheckingFmt = @"Error checking for updates:\n{0}";
            public const string NewVersionAvailableFmt = @"A newer version of FlexReports is available: {0}.\n(You are running version {1}.)\nTo get the new version, you should run C1Live and update FlexReport, which will also update FlexReportDesigner.";
            public const string ClickOkToRunC1Live = @"Click OK to exit FlexReportDesigner and run C1Live now.";
        }
        public static class MessageForm
        {
            public const string TT_chkDoNotShowAgain = @"Check to suppress showing this warning in the future.\r\nYou can review/change suppressed warnings in program options (File | Options).";
            public const string ConfirmAbort = @"Are you sure that you want to abort FlexReportDesigner and exit?";
            public const string ButtonOK = @"&OK";
            public const string ButtonCancel = @"&Cancel";
            public const string ButtonAbort = @"&Abort";
            public const string ButtonRetry = @"&Retry";
            public const string ButtonIgnore = @"&Ignore";
            public const string ButtonYes = @"&Yes";
            public const string ButtonNo = @"&No";
            public static class MessageNames
            {
                public const string WarnOnAbort = @"Confirm aborting FlexReportDesigner";
                public const string WarnImportCrystalRASNotAvailable = @"Warn if RAS API was not found when importing from Crystal Reports.";
            }
            public static class Captions
            {
                public const string Message = @"Info";
                public const string Warning = @"Warning";
                public const string Confirm = @"Confirm";
                public const string Error = @"Error";
                public const string Fatal = @"Fatal Error";
            }
        }
        public static class BackgroundEditor
        {
            public const string TransparentColor = @"Transparent";
            public const string BackgroundNotCompletelyDefined = @"Not completely defined";
            public const string EmptyColor = @"Auto";
        }
        public static class GradientBackgroundEditor
        {
            public const string LinearToolTip = @"<table><tr>  <td><parm></parm></td>  <td><b><parm>Linear</parm></b></td></tr></table><parm></parm><div style='margin:1 12'><parm>  Use linear gradient.</parm></div><parm></parm><table><tr>  <td><parm></parm></td>  <td><b><parm></parm></b></td></tr></table>";
            public const string RadialToolTip = @"<table><tr>  <td><parm></parm></td>  <td><b><parm>Radial</parm></b></td></tr></table><parm></parm><div style='margin:1 12'><parm>  Use radial gradient.</parm></div><parm></parm><table><tr>  <td><parm></parm></td>  <td><b><parm></parm></b></td></tr></table>";
        }
        public static class ColorBlendEditor
        {
            public const string AddPointToolTip = @"Add a new gradient stop point.";
            public const string RemovePointToolTip = @"Remove the current selected gradient stop point.";
            public const string PointsToolTip = @"<table><tr><td><parm></parm></td><td><b><parm>Gradient Stops</parm></b></td></tr></table><parm></parm><div style='margin:1 12'><parm>  Set the gradient stop points.<br>Use mouse to click and drag one point.<br>Use Left/Right arrow key to change current selected point, and Up/Down arrow key to change its position.</parm></div><parm></parm><table><tr>  <td><parm></parm></td>  <td><b><parm></parm></b></td></tr></table>";
            public const string PointPositionToolTip = @"Set the position of the current selected gradient stop point.";
            public const string PointColorToolTip = @"Set the color of the current selected gradient stop point.";
        }
        public static class GradientCenterEditor
        {
            public const string HorizontalToolTip = @"Set the horizontal position of the gradient center.";
            public const string VerticalToolTip = @"Set the vertical position of the gradient center.";
        }
        public static class GradientBoundsEditor
        {
            public const string StartPointToolTip = @"<table><tr>  <td><parm></parm></td>  <td><b><parm>Start Point</parm></b></td></tr></table><parm></parm><div style='margin:1 12'><parm>  Set the linear gradient start point.</parm></div><parm></parm><table><tr>  <td><parm></parm></td>  <td><b><parm></parm></b></td></tr></table>";
            public const string EndPointToolTip = @"<table><tr>  <td><parm></parm></td>  <td><b><parm>End Point</parm></b></td></tr></table><parm></parm><div style='margin:1 12'><parm>  Set the linear gradient end point.</parm></div><parm></parm><table><tr>  <td><parm></parm></td>  <td><b><parm></parm></b></td></tr></table>";
            public const string ModeToolTip = @"Select the predefined linear mode.";
            public const string StartXToolTip = @"Set the horizontal position of the gradient start point.";
            public const string StartYToolTip = @"Set the vertical position of the gradient start point.";
            public const string EndXToolTip = @"Set the horizontal position of the gradient end point.";
            public const string EndYToolTip = @"Set the vertical position of the gradient end point.";
        }
        public static class BackgroundEditorPreviewControl
        {
            public const string Initial = @"Initial";
            public const string Current = @"Current";
        }
        public static class BackgroundConverter
        {
            public const string ErrorInvalidColor = @"Cannot convert '{0}' to a valid color.";
        }
        public static class PictureAlignControl
        {
            public const string ToolTipRightTop = @"Right Top";
            public const string ToolTipLeftBottom = @"Left Bottom";
            public const string ToolTipClip = @"Clip";
            public const string ToolTipRightbottom = @"Right bottom";
            public const string ToolTipCenterTop = @"Center Top";
            public const string ToolTipStretch = @"Stretch";
            public const string ToolTipZoom = @"Zoom";
            public const string ToolTipRightMiddle = @"Right Middle";
            public const string ToolTipLeftMiddle = @"Left Middle";
            public const string ToolTipCenterbottom = @"Center bottom";
            public const string ToolTipLeftTop = @"Left Top";
            public const string ToolTipCenterMiddle = @"Center Middle";
            public const string ToolTipTile = @"Tile";
        }
        public static class PictureHolderEditor
        {
            public const string EditorText = @"<Editor...>";
        }
        public static class TextAlignControl
        {
            public const string ToolTipRightTop = @"Right Top";
            public const string ToolTipLeftBottom = @"Left Bottom";
            public const string ToolTipRightbottom = @"Right bottom";
            public const string ToolTipCenterTop = @"Center Top";
            public const string ToolTipRightMiddle = @"Right Middle";
            public const string ToolTipLeftMiddle = @"Left Middle";
            public const string ToolTipCenterbottom = @"Center bottom";
            public const string ToolTipLeftTop = @"Left Top";
            public const string ToolTipCenterMiddle = @"Center Middle";
            public const string ToolTipJustifyTop = @"Justify Top";
            public const string ToolTipJustifyMiddle = @"Justify Middle";
            public const string ToolTipJustifyBottom = @"Justify Bottom";
            public const string ToolTipGeneral = @"General";
        }
        public static class DataTree
        {
            public const string Parameters = @"Parameters";
            public const string DataSources = @"Data Sources";
            public const string CalculatedFields = @"Calculated Fields";
            public const string SortDefinitions = @"Sort Definitions";
            public const string None = @"(none)";
        }
        public static class ErrorList
        {
            public const string Tooltip_Info = @"This is an information message only.";
            public const string Tooltip_Warning = @"A warning indicates a potential problem in the report definition.";
            public const string Tooltip_Error = @"An non-critical error indicates that there is a problem but the report can still be generated.";
            public const string Tooltip_Critical = @"A critical error means that it is not possible to generate the report.";
            public const string Tooltip_Cancelled = @"The report generation has been cancelled by the user.";
            public const string ExceptionTooltipFmt = @"<b>Exception:</b><pre style=""white-space: pre-wrap;"">{0}</pre>";
            public const string CountOneTooltip = @"Repeat count for identical repeated messages (e.g. if there's an error in a detail section script, the same message would be generated for each record).";
            public const string CountManyTooltipFmt = @"This {0} was repeated {1} times in a row.";
        }
    }

}
