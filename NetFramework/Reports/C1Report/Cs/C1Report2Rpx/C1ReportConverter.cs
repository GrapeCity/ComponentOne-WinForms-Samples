using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

using AR = GrapeCity.ActiveReports;
using C1R = C1.C1Report;

namespace C1Report2Rpx
{
    /// <summary>
    /// Used to convert C1Report objects to AR.
    /// </summary>
    internal class C1ReportConverter : ConverterBase
    {
        // static data
        private static readonly List<SectionInfo> c_SectionInfos = new List<SectionInfo>()
        {
            // NOTE: the order corresponds to prope AR section order:
            new SectionInfo((rc, s) => new ReportHeaderConverter(rc, s), C1R.SectionTypeEnum.Header, -1),
            new SectionInfo((rc, s) => new PageHeaderConverter(rc, s), C1R.SectionTypeEnum.PageHeader, -1),
            new SectionInfo((rc, s) => new GroupHeaderConverter(rc, s), C1R.SectionTypeEnum.GroupHeader1, 0),
            new SectionInfo((rc, s) => new GroupHeaderConverter(rc, s), C1R.SectionTypeEnum.GroupHeader2, 1),
            new SectionInfo((rc, s) => new GroupHeaderConverter(rc, s), C1R.SectionTypeEnum.GroupHeader3, 2),
            new SectionInfo((rc, s) => new GroupHeaderConverter(rc, s), C1R.SectionTypeEnum.GroupHeader4, 3),
            new SectionInfo((rc, s) => new DetailConverter(rc, s), C1R.SectionTypeEnum.Detail, -1),
            new SectionInfo((rc, s) => new GroupFooterConverter(rc, s), C1R.SectionTypeEnum.GroupFooter4, 3),
            new SectionInfo((rc, s) => new GroupFooterConverter(rc, s), C1R.SectionTypeEnum.GroupFooter3, 2),
            new SectionInfo((rc, s) => new GroupFooterConverter(rc, s), C1R.SectionTypeEnum.GroupFooter2, 1),
            new SectionInfo((rc, s) => new GroupFooterConverter(rc, s), C1R.SectionTypeEnum.GroupFooter1, 0),
            new SectionInfo((rc, s) => new PageFooterConverter(rc, s), C1R.SectionTypeEnum.PageFooter, -1),
            new SectionInfo((rc, s) => new ReportFooterConverter(rc, s), C1R.SectionTypeEnum.Footer, -1),
        };

        private static readonly Dictionary<Type, CreateDataSourceConverterDelegate> c_DataSourceConverters = new Dictionary<Type, CreateDataSourceConverterDelegate>()
        {
            { typeof(C1R.OledbLink), (rc) => new OleDbConverter(rc) },
            { typeof(C1R.OdbcLink), (rc) => new OdbcConverter(rc) },
            { typeof(C1R.SqlServerCe3_5Link), (rc) => new SqlServerCe3_5Converter(rc) },
            { typeof(C1R.SqlServerCe4_0Link), (rc) => new SqlServerCe4_0Converter(rc) },
            { typeof(C1R.XmlLink), (rc) => new XmlConverter(rc) },
            { typeof(C1R.ExternalObjectLink), (rc) => new ExternalObjectConverter(rc) },
        };

        // private data
        private Log _log;
        private C1R.C1Report _c1Report;
        private AR.SectionReport _aReport;
        private int _newNameId = 0; // used to provide unique names if missing in the C1Report def
        private Dictionary<string, bool> _names = new Dictionary<string, bool>();

        #region Constructors
        public C1ReportConverter(
            C1R.C1Report c1Report,
            Log log)
            : base()
        {
            _c1Report = c1Report;
            _log = log;
        }
        #endregion

        #region Private
        private void ConvertGeneralInfo()
        {
            AReport.Name = C1Report.ReportName;
            AReport.MaxPages = C1Report.MaxPages;

            //
            AReport.PrintWidth = Util.ArLength(C1Report.Layout.Width);

            // convert watermark
            Util.ARPicture pic = Util.ConvertPicture(C1Report.Layout.Picture as C1R.Util.PictureHolder, C1Report.Layout.PictureAlign, C1Report.Layout.PictureScale, Strings.LogSources.Watermark, Log);
            AReport.Watermark = pic.Image;
            AReport.WatermarkAlignment = pic.Align.Alignment;
            AReport.WatermarkSizeMode = pic.Align.SizeMode;
            switch (C1Report.Layout.PictureShow)
            {
                case C1R.PictureShowEnum.FirstPage:
                    AReport.WatermarkPrintOnPages = "1";
                    break;
                case C1R.PictureShowEnum.AllPages:
                    // simple leave WatermarkPrintOnPages empty, it means that watermark will be printed on all pages
                    break;
                default:
                    Log.Add(LogEntryLevel.Warning, Strings.LogSources.Watermark, string.Format(Strings.Warnings.UnsupportedWatermarkPictureShow, C1Report.Layout.PictureShow));
                    break;
            }

            // page settings
            switch (C1Report.Layout.Orientation)
            {
                case C1R.OrientationEnum.Auto:
                    AReport.PageSettings.Orientation = AR.Document.Section.PageOrientation.Default;
                    break;
                case C1R.OrientationEnum.Landscape:
                    AReport.PageSettings.Orientation = AR.Document.Section.PageOrientation.Landscape;
                    break;
                case C1R.OrientationEnum.Portrait:
                    AReport.PageSettings.Orientation = AR.Document.Section.PageOrientation.Portrait;
                    break;
            }
            if (C1Report.Layout.PaperSize == PaperKind.Custom)
            {
                if (C1Report.Layout.CustomWidth == 0 && C1Report.Layout.CustomHeight == 0)
                    AReport.PageSettings.DefaultPaperSize = true;
                else
                {
                    AReport.Document.Printer.PrinterName = string.Empty;
                    AReport.PageSettings.DefaultPaperSize = false;
                    AReport.PageSettings.PaperKind = PaperKind.Custom;
                    // witout that line converted report in designer showed
                    // as DefaultPaperSize == true
                    AReport.PageSettings.PaperName = "Custom paper";
                    AReport.PageSettings.PaperWidth = Util.ArLength(C1Report.Layout.CustomWidth);
                    AReport.PageSettings.PaperHeight = Util.ArLength(C1Report.Layout.CustomHeight);
                }
            }
            else
            {
                AReport.PageSettings.DefaultPaperSize = false;
                AReport.PageSettings.PaperKind = C1Report.Layout.PaperSize;
            }
            AReport.PageSettings.Margins.Left = Util.ArLength(C1Report.Layout.MarginLeft);
            AReport.PageSettings.Margins.Top = Util.ArLength(C1Report.Layout.MarginTop);
            AReport.PageSettings.Margins.Right = Util.ArLength(C1Report.Layout.MarginRight);
            AReport.PageSettings.Margins.Bottom = Util.ArLength(C1Report.Layout.MarginBottom);

            //
            if (C1Report.Layout.PageFooter != C1R.HdrFtrEnum.AllPages)
                Log.Add(LogEntryLevel.Warning, Strings.LogSources.Layout, string.Format(Strings.Warnings.UnsupportedPageFooterLocation, C1Report.Layout.PageFooter));
            if (C1Report.Layout.PageHeader != C1R.HdrFtrEnum.AllPages)
                Log.Add(LogEntryLevel.Warning, Strings.LogSources.Layout, string.Format(Strings.Warnings.UnsupportedPageHeaderLocation, C1Report.Layout.PageHeader));

            //
            if (C1Report.Layout.ColumnLayout == C1R.ColumnLayoutEnum.Labels)
                Log.Add(LogEntryLevel.Warning, Strings.LogSources.Layout, Strings.Warnings.UnsupportedLabelsMode);

            // convert Columns, Labels later when detail section converted
        }

        private void ConvertDataSource()
        {
            CreateDataSourceConverterDelegate del;
            if (!c_DataSourceConverters.TryGetValue(C1Report.DataSource.DataLink.GetType(), out del))
            {
                Log.Add(LogEntryLevel.Error, Strings.LogSources.DataSource, Strings.Errors.UnsupportedDataSource);
                return;
            }

            C1DataSourceConverterBase dsc = del(this);
            dsc.Convert();
        }

        private AR.SectionReportModel.ARControl AddControl(
            AR.SectionReportModel.Section aSection,
            C1R.Field c1Field)
        {
            C1FieldConverter fc = new C1FieldConverter(this, aSection, c1Field);
            var arfld = fc.Convert();
            aSection.Controls.Add(arfld);
            return arfld;
        }

        private void ConvertSections()
        {
            foreach (SectionInfo si in c_SectionInfos)
            {
                if ((int)si.C1SectionType >= C1Report.Sections.Count)
                    // section does not exist in C1Report
                    continue;
                C1R.Section c1Section = C1Report.Sections[si.C1SectionType];
                
                //
                C1SectionConverterBase sc = si.CreateConverter(this, c1Section);
                sc.Convert();

                // add section's fields
                foreach (C1R.Field c1f in C1Report.Sections[si.C1SectionType].Fields)
                    AddControl(sc.ASection, c1f);
            }
        }
        #endregion

        #region Public
        public override string NewNameId()
        {
            return string.Format("c1id{0}", _newNameId++);
        }

        public override string CheckName(
            string name,
            string autoNamePrefix)
        {
            string result;
            if (string.IsNullOrEmpty(name))
                result = autoNamePrefix + "1";
            else
            {
                result = Regex.Replace(name, @"[\W]", "_");
                // possible situation when result contains only "_"
                int i;
                for (i = 0; i < result.Length && result[i] == '_'; i++) ;
                if (i >= result.Length)
                    result = autoNamePrefix + "1";
            }

            if (_names.ContainsKey(result))
            {
                int i = result.Length - 1;
                while (i >= 0 && result[i] >= '0' && result[i] <= '9')
                    i--;
                string s;
                if (i >= result.Length - 1)
                {
                    s = result;
                    i = 1;
                }
                else
                {
                    s = result.Substring(0, i + 1);
                    i = int.Parse(result.Substring(i + 1)) + 1;
                }
                while (_names.ContainsKey(s + i.ToString()))
                    i++;
                result = s + i.ToString();
            }
            _names.Add(result, true);
            return result;
        }

        public string ExpressionToDataField(
            string expressionText)
        {
            if (string.IsNullOrEmpty(expressionText))
                return string.Empty;

            if (C1Report.ParseExpression(expressionText) != null)
                // In C1Report very often Field.Calculated == true even if Field simple contains a text
                // because C1Report during rendering simple ignore errors during calculating of Field's value.
                return string.Empty;

            // very often field name specified in [ ]
            if (expressionText.StartsWith("[") && expressionText.EndsWith("]"))
                return expressionText.Substring(1, expressionText.Length - 2);
            
            return expressionText;
        }

        public void Convert()
        {
            _aReport = new AR.SectionReport();

            //
            _names.Clear();

            //
            ConvertDataSource();

            //
            ConvertGeneralInfo();
            
            //
            ConvertSections();
        }
        #endregion

        #region Public properties
        public override AR.SectionReport AReport
        {
            get { return _aReport; }
        }

        public override C1Report2Rpx.Log Log
        {
            get { return _log; }
        }

        public override C1R.C1Report C1Report
        {
            get { return _c1Report; }
        }
        #endregion

        #region Nested types
        private delegate C1SectionConverterBase CreateConverterDelegate(C1ReportConverter reportConverter, C1R.Section c1Section);

        private delegate C1DataSourceConverterBase CreateDataSourceConverterDelegate(C1ReportConverter reportConverter);

        private class SectionInfo
        {
            private CreateConverterDelegate _createConverter;
            private C1R.SectionTypeEnum _c1SectionType;
            private int _c1GroupIndex;

            #region Constructors
            public SectionInfo(
                CreateConverterDelegate createConverter,
                C1R.SectionTypeEnum c1SectionType,
                int c1GroupIndex)
            {
                _createConverter = createConverter;
                _c1SectionType = c1SectionType;
                _c1GroupIndex = c1GroupIndex;
            }
            #endregion

            #region Public properties
            public CreateConverterDelegate CreateConverter
            {
                get { return _createConverter; }
            }

            public C1R.SectionTypeEnum C1SectionType
            {
                get { return _c1SectionType; }
            }

            public int C1GroupIndex
            {
                get { return _c1GroupIndex; }
            }
            #endregion
        }
        #endregion
    }
}
