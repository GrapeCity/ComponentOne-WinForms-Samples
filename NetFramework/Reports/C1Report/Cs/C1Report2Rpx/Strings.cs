using System;
using System.Collections.Generic;

namespace C1Report2Rpx
{
    internal static class Strings
    {
        public const string C1Report2RpxLongName = "ComponentOne C1Report to ActiveReports converter";
        public const string MessageBoxCaption = C1Report2RpxLongName;
        public const string C1ReportDefinitionLabel = "C1Report definition:";

        public static class ArPreviewForm
        {
            public const string CanNotLoadReport = "Cannot load ActiveReports definition:\r\n{0}";
        }

        public static class C1Urls
        {
            public const string Website = @"http://www.componentone.com";
        }

        public static class ArDesigner
        {
            public const string SaveChanged = "Save changes?";
            public const string SaveAndExit = "&Save and Exit";
            public const string Exit = "E&xit";
        }

        public static class ConvertForm
        {
            public const string ErrorParsingC1ReportXmlFile = "Can not load list of reports from file:\r\n{0}\r\nException occurs:\r\n{1}";
            public const string NoReportsInXMLFile = "File [{0}] has no report definitions.";
        }

        public static class MainForm
        {
            public const string LogHideLog = "Hide converting log";
            public const string LogShowLog = "Show converting log";
            public const string LogCaption = "Converting Log:";
            public const string LogLnkCaption = "Click to view converting log";
        }

        public static class Messages
        {
            public const string FieldForcePageBreak = "Field.ForcePageBreak imported as PageBreak ActiveReports field.";
        }

        public static class ConvertingStatus
        {
            public const string Success = "Success";
            public const string Errors = "{0} errors";
            public const string Warnings = "{0} warnings";
            public const string ErrorsAndWarnings = "{0} errors, {1} warnings";
        }

        public static class Warnings
        {
            public const string ImageEmbedded = "External image (loaded from [{0}] when report renders), converted into embedded image.";
            public const string UnsupportedFieldAlign = "Unsupported field alignment [{0}], converted to [{1}].";
            public const string UnsupportedPictureAlign = "Unsupported picture alignment [{0}, {1}], converted to [{2}, {3}].";
            public const string UnsupportedWatermarkPictureShow = "Unsupported location of watermark [{0}], ignored.";
            public const string UnsupportedPageFooterLocation = "Unsupported custom position of page footer [{0}].";
            public const string UnsupportedPageHeaderLocation = "Unsupported custom position of page header [{0}].";
            public const string GroupDoesNotExist = "C1Report does not contain Group for the group header/group footer section.";
            public const string UnsupportedGroupSorting = "Sorting specified for a section is not supported in ActiveReports, ignored.";
            public const string UnsupportedLabelsMode = "C1Report labels mode unsupported in ActiveReports.";
            public const string UnsupportedTextAngle = "Angle unsupported by ActiveReports {0} field.";
            public const string UnsupportedFieldProperty = "Unsupported property [{0}] with value [{1}] of ActiveReports [{2}] field, ignored.";
            public const string UnsupportedFieldAnchor = "Field.Anchor property unsupported in ActiveReports, ignored.";
            public const string UnsupportedShapeType = "Unsupported shape type [{0}].";
            public const string UnsupportedDataSourceConvertedToOleDb = "ActiveReports does not support [{0}] data sources, converted to OLEDB datasource.";
            public const string UnsupportedSubReport = "To handle subreports in ActiveReports, use Section.Format event (see ActiveReports help for details).";
            public const string UnsupportedCustomField = "C1Report custom field [{0}] unsupported in ActiveReports.";
        }

        public static class Errors
        {
            public const string UnsupportedExternalObjectDataSource = "ActiveReports does not support data sources defined in external assembly.";
            public const string UnsupportedDataSource = "Unsupported type of data source.";
            public const string UnknownExceptionDuringDataSourceConverting = "Exception occurred while converting data source\r\n{0}";
        }

        public static class ARFieldTypes
        {
            public const string CheckBox = "CheckBox";
            public const string RichText = "RichText";
            public const string Barcode = "Barcode";
            public const string TextBox = "TextBox";
        }

        public static class LogSources
        {
            public const string Watermark = "Watermark";
            public const string Layout = "Report layout";
            public const string Section = "Section [{0}, {1}]";
            public const string Group = "Group [{0}]";
            public const string Field = "Field [{0}]";
            public const string DataSource = "Data source";
        }
    }
}
