using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Data;
using System.Data.Common;
using AR = GrapeCity.ActiveReports;
using C1R = C1.C1Report;

namespace C1Report2Rpx
{
    /// <summary>
    /// Encapsulates logic for converting C1Report data source to Active report data source.
    /// </summary>
    internal abstract class C1DataSourceConverterBase : ReportItemConverterBase
    {
        #region Constructors
        public C1DataSourceConverterBase(
            C1ReportConverter reportConverter)
            : base(reportConverter)
        {
        }
        #endregion

        #region Public
        public abstract void Convert();
        #endregion

        #region Public properties
        public C1R.DataSource C1DataSource
        {
            get { return C1Report.DataSource; }
        }

        public C1R.DataLinkBase DataLink
        {
            get { return C1Report.DataSource.DataLink; }
        }
        #endregion
    }

    internal abstract class DbConverter : C1DataSourceConverterBase
    {
        private AR.Data.OleDBDataSource _aDataSource;

        #region Constructors
        public DbConverter(
            C1ReportConverter reportConverter)
            : base(reportConverter)
        {
        }
        #endregion

        #region Protected
        protected virtual string TranslateConnectionString(
            string connectionString)
        {
            return connectionString;
        }
        #endregion

        #region Public
        public override void Convert()
        {
            _aDataSource = new AR.Data.OleDBDataSource();
            _aDataSource.CommandTimeout = Math.Max(C1DataSource.CommandTimeOut, 0);

            // convert ConnectionString
            try
            {
                using (DbConnection dc = DataLink.CreateConnection(C1DataSource.ConnectionString))
                {
                    _aDataSource.ConnectionString = TranslateConnectionString(dc.ConnectionString);
                }

                // convert recordsource
                CommandType commandType;
                string commandText;
                DataLink.GetCommandParams(
                    new C1R.DataLinkParams(C1DataSource.DataProvider, C1DataSource.ConnectionString, C1DataSource.IsolationLevel, 0, 1),
                    C1DataSource.RecordSource,
                    out commandType,
                    out commandText);
                switch (commandType)
                {
                    case CommandType.TableDirect:
                    case CommandType.StoredProcedure:
                        _aDataSource.SQL = string.Format("select * from {0}", commandText);
                        break;
                    default:
                        _aDataSource.SQL = commandText;
                        break;
                }
            }
            catch (Exception ex)
            {
                _aDataSource.SQL = C1DataSource.RecordSource;
                Log.Add(LogEntryLevel.Warning, Strings.LogSources.DataSource, string.Format(Strings.Errors.UnknownExceptionDuringDataSourceConverting, ex.Message));
            }

            // assign data source
            AReport.DataSource = _aDataSource;
        }
        #endregion

        #region Public properties
        public new C1R.DbLink DataLink
        {
            get { return (C1R.DbLink)base.DataLink; }
        }
        #endregion
    }

    internal class OleDbConverter : DbConverter
    {
        #region Constructors
        public OleDbConverter(
            C1ReportConverter reportConverter)
            : base(reportConverter)
        {
        }
        #endregion
    }

    internal class OdbcConverter : DbConverter
    {
        #region Constructors
        public OdbcConverter(
            C1ReportConverter reportConverter)
            : base(reportConverter)
        {
        }
        #endregion

        #region Protected
        protected override string TranslateConnectionString(
            string connectionString)
        {
            return string.Format(@"Provider=MSDASQL;{0}", connectionString);
        }
        #endregion

        #region Public
        public override void Convert()
        {
            base.Convert();
            Log.Add(LogEntryLevel.Warning, Strings.LogSources.DataSource, string.Format(Strings.Warnings.UnsupportedDataSourceConvertedToOleDb, C1R.DataProvider.ODBC));
        }
        #endregion
    }

    internal class SqlServerCe3_5Converter : DbConverter
    {
        #region Constructors
        public SqlServerCe3_5Converter(
            C1ReportConverter reportConverter)
            : base(reportConverter)
        {
        }
        #endregion

        #region Protected
        protected override string TranslateConnectionString(
            string connectionString)
        {
            return string.Format(@"Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;{0}", connectionString);
        }
        #endregion

        #region Public
        public override void Convert()
        {
            base.Convert();
            Log.Add(LogEntryLevel.Warning, Strings.LogSources.DataSource, string.Format(Strings.Warnings.UnsupportedDataSourceConvertedToOleDb, "SQL Server Compact Edition 3.5"));
        }
        #endregion
    }

    internal class SqlServerCe4_0Converter : DbConverter
    {
        #region Constructors
        public SqlServerCe4_0Converter(
            C1ReportConverter reportConverter)
            : base(reportConverter)
        {
        }
        #endregion

        #region Protected
        protected override string TranslateConnectionString(
            string connectionString)
        {
            return string.Format(@"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;{0}", connectionString);
        }
        #endregion

        #region Public
        public override void Convert()
        {
            base.Convert();
            Log.Add(LogEntryLevel.Warning, Strings.LogSources.DataSource, string.Format(Strings.Warnings.UnsupportedDataSourceConvertedToOleDb, "SQL Server Compact Edition 4.0"));
        }
        #endregion
    }

    internal class XmlConverter : C1DataSourceConverterBase
    {
        #region Constructors
        public XmlConverter(
            C1ReportConverter reportConverter)
            : base(reportConverter)
        {
        }
        #endregion
 
        #region Public
        public override void Convert()
        {
            AR.Data.XMLDataSource aDataSource = new AR.Data.XMLDataSource();
            aDataSource.FileURL = C1DataSource.ConnectionString;
            // TODO:
            // aDataSource.RecordsetPattern should be specified but currently it is not implemented
        }
        #endregion
    }

    internal class ExternalObjectConverter : C1DataSourceConverterBase
    {
        #region Constructors
        public ExternalObjectConverter(
            C1ReportConverter reportConverter)
            : base(reportConverter)
        {
        }
        #endregion

        #region Public
        public override void Convert()
        {
            Log.Add(LogEntryLevel.Error, Strings.LogSources.DataSource, Strings.Errors.UnsupportedExternalObjectDataSource);
        }
        #endregion
    }
}