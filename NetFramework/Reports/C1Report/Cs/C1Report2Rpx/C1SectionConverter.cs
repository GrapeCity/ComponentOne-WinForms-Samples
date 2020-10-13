using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using AR = GrapeCity.ActiveReports;
using C1R = C1.C1Report;

namespace C1Report2Rpx
{
    internal abstract class C1SectionConverterBase : ReportItemConverterBase
    {
        private C1R.Section _c1Section;
        private AR.SectionReportModel.Section _aSection;

        #region Constructors
        public C1SectionConverterBase(
            C1ReportConverter reportConverter,
            C1R.Section c1Section)
            : base(reportConverter)
        {
            _c1Section = c1Section;
        }
        #endregion

        #region Protected static
        protected static void ConvertForcePageBreak(
            C1R.ForcePageBreakEnum forcePageBreak,
            out AR.SectionReportModel.NewPage newPage,
            out AR.SectionReportModel.NewColumn newColumn)
        {
            newPage = AR.SectionReportModel.NewPage.None;
            newColumn = AR.SectionReportModel.NewColumn.None;
            switch (forcePageBreak)
            {
                case C1R.ForcePageBreakEnum.After:
                    newColumn = AR.SectionReportModel.NewColumn.After;
                    break;
                case C1R.ForcePageBreakEnum.Before:
                    newColumn = AR.SectionReportModel.NewColumn.Before;
                    break;
                case C1R.ForcePageBreakEnum.BeforeAndAfter:
                    newColumn = AR.SectionReportModel.NewColumn.BeforeAfter;
                    break;
                case C1R.ForcePageBreakEnum.PageAfter:
                    newPage = AR.SectionReportModel.NewPage.After;
                    break;
                case C1R.ForcePageBreakEnum.PageBefore:
                    newPage = AR.SectionReportModel.NewPage.Before;
                    break;
            }
        }
        #endregion

        #region Protected
        protected void AddLog(
            LogEntryLevel level,
            string message)
        {
            Log.Add(level, string.Format(Strings.LogSources.Section, C1Section.Type, C1Section.Name), message);
        }

        protected virtual void InternalConvert()
        {
        }
        #endregion

        #region Public
        public void Convert()
        {
            _aSection = AReport.Sections.Add(ASectionType, CheckName(C1Section.Name, "Section"));
            _aSection.CanGrow = _c1Section.CanGrow;
            _aSection.CanShrink = _c1Section.CanShrink;
            _aSection.BackColor = _c1Section.BackColor;
            _aSection.Visible = _c1Section.Visible;
            _aSection.Height = Util.ArLength(_c1Section.Height);
            InternalConvert();
        }
        #endregion

        #region Public properties
        public C1R.Section C1Section
        {
            get { return _c1Section; }
        }

        public AR.SectionReportModel.Section ASection
        {
            get { return _aSection; }
        }

        public abstract AR.Document.Section.SectionType ASectionType { get; }
        #endregion
    }

    internal class ReportHeaderConverter : C1SectionConverterBase
    {
        #region Constructors
        public ReportHeaderConverter(
            C1ReportConverter reportConverter,
            C1R.Section c1Section)
            : base(reportConverter, c1Section)
        {
        }
        #endregion

        #region Protected
        protected override void InternalConvert()
        {
            switch (C1Section.ForcePageBreak)
            {
                case C1R.ForcePageBreakEnum.After:
                case C1R.ForcePageBreakEnum.PageAfter:
                    ASection.NewPage = AR.SectionReportModel.NewPage.After;
                    break;
                case C1R.ForcePageBreakEnum.Before:
                case C1R.ForcePageBreakEnum.PageBefore:
                    ASection.NewPage = AR.SectionReportModel.NewPage.Before;
                    break;
                case C1R.ForcePageBreakEnum.BeforeAndAfter:
                    ASection.NewPage = AR.SectionReportModel.NewPage.BeforeAfter;
                    break;
                case C1R.ForcePageBreakEnum.None:
                    ASection.NewPage = AR.SectionReportModel.NewPage.None;
                    break;
            }
        }
        #endregion

        #region Public properties
        public new AR.SectionReportModel.ReportHeader ASection
        {
            get { return (AR.SectionReportModel.ReportHeader)base.ASection; }
        }

        public override AR.Document.Section.SectionType ASectionType
        {
            get { return AR.Document.Section.SectionType.ReportHeader; }
        }
        #endregion
    }

    internal class PageHeaderConverter : C1SectionConverterBase
    {
        #region Constructors
        public PageHeaderConverter(
            C1ReportConverter reportConverter,
            C1R.Section c1Section)
            : base(reportConverter, c1Section)
        {
        }
        #endregion

        #region Public properties
        public override AR.Document.Section.SectionType ASectionType
        {
            get { return AR.Document.Section.SectionType.PageHeader; }
        }
        #endregion
    }

    internal class GroupHeaderConverter : C1SectionConverterBase
    {
        #region Constructors
        public GroupHeaderConverter(
            C1ReportConverter reportConverter,
            C1R.Section c1Section)
            : base(reportConverter, c1Section)
        {
        }
        #endregion

        #region Protected
        protected override void InternalConvert()
        {
            int groupIndex = ((int)C1Section.Type - (int)C1R.SectionTypeEnum.GroupHeader1) / 2;
            if (groupIndex >= C1Report.Groups.Count)
            {
                AddLog(LogEntryLevel.Warning, Strings.Warnings.GroupDoesNotExist);
            }
            else
            {
                C1R.Group group = C1Report.Groups[groupIndex];
                ASection.DataField = ReportConverter.ExpressionToDataField(group.GroupBy);
                if (group.Sort != C1R.SortEnum.NoSort)
                    AddLog(LogEntryLevel.Warning, Strings.Warnings.UnsupportedGroupSorting);
                switch (group.KeepTogether)
                {
                    case C1R.KeepTogetherEnum.KeepFirstDetail:
                        ASection.GroupKeepTogether = AR.SectionReportModel.GroupKeepTogether.FirstDetail;
                        ASection.ColumnGroupKeepTogether = true;
                        break;
                    case C1R.KeepTogetherEnum.KeepWholeGroup:
                        ASection.GroupKeepTogether = AR.SectionReportModel.GroupKeepTogether.All;
                        ASection.ColumnGroupKeepTogether = true;
                        break;
                }
            }

            if (C1Section.Repeat)
                ASection.RepeatStyle = AR.SectionReportModel.RepeatStyle.All;

            AR.SectionReportModel.NewPage newPage;
            AR.SectionReportModel.NewColumn newColumn;
            ConvertForcePageBreak(C1Section.ForcePageBreak, out newPage, out newColumn);
            ASection.NewPage = newPage;
            ASection.NewColumn = newColumn;

            ASection.ColumnLayout = true;
        }
        #endregion

        #region Public properties
        public new AR.SectionReportModel.GroupHeader ASection
        {
            get { return (AR.SectionReportModel.GroupHeader)base.ASection; }
        }

        public override AR.Document.Section.SectionType ASectionType
        {
            get { return AR.Document.Section.SectionType.GroupHeader; }
        }
        #endregion
    }

    internal class DetailConverter : C1SectionConverterBase
    {
        #region Constructors
        public DetailConverter(
            C1ReportConverter reportConverter,
            C1R.Section c1Section)
            : base(reportConverter, c1Section)
        {
        }
        #endregion

        #region Protected
        protected override void InternalConvert()
        {
            ASection.ColumnCount = C1Report.Layout.Columns;
            switch (C1Report.Layout.ColumnLayout)
            {
                case C1R.ColumnLayoutEnum.Across:
                    ASection.ColumnDirection = AR.SectionReportModel.ColumnDirection.AcrossDown;
                    break;
                case C1R.ColumnLayoutEnum.Down:
                    ASection.ColumnDirection = AR.SectionReportModel.ColumnDirection.DownAcross;
                    break;
            }

            AR.SectionReportModel.NewPage newPage;
            AR.SectionReportModel.NewColumn newColumn;
            ConvertForcePageBreak(C1Section.ForcePageBreak, out newPage, out newColumn);
            ASection.NewPage = newPage;
            ASection.NewColumn = newColumn;
        }
        #endregion

        #region Public properties
        public new AR.SectionReportModel.Detail ASection
        {
            get { return (AR.SectionReportModel.Detail)base.ASection; }
        }

        public override AR.Document.Section.SectionType ASectionType
        {
            get { return AR.Document.Section.SectionType.Detail; }
        }
        #endregion
    }

    internal class GroupFooterConverter : C1SectionConverterBase
    {
        #region Constructors
        public GroupFooterConverter(
            C1ReportConverter reportConverter,
            C1R.Section c1Section)
            : base(reportConverter, c1Section)
        {
        }
        #endregion

        #region Protected
        protected override void InternalConvert()
        {
            ASection.PrintAtBottom = C1Section.PrintAtPageBottom;

            AR.SectionReportModel.NewPage newPage;
            AR.SectionReportModel.NewColumn newColumn;
            ConvertForcePageBreak(C1Section.ForcePageBreak, out newPage, out newColumn);
            ASection.NewPage = newPage;
            ASection.NewColumn = newColumn;

            ASection.ColumnLayout = true;
        }
        #endregion

        #region Public properties
        public new AR.SectionReportModel.GroupFooter ASection
        {
            get { return (AR.SectionReportModel.GroupFooter)base.ASection; }
        }

        public override AR.Document.Section.SectionType ASectionType
        {
            get { return AR.Document.Section.SectionType.GroupFooter; }
        }
        #endregion
    }

    internal class PageFooterConverter : C1SectionConverterBase
    {
        #region Constructors
        public PageFooterConverter(
            C1ReportConverter reportConverter,
            C1R.Section c1Section)
            : base(reportConverter, c1Section)
        {
        }
        #endregion

        #region Public properties
        public override AR.Document.Section.SectionType ASectionType
        {
            get { return AR.Document.Section.SectionType.PageFooter; }
        }
        #endregion
    }

    internal class ReportFooterConverter : C1SectionConverterBase
    {
        #region Constructors
        public ReportFooterConverter(
            C1ReportConverter reportConverter,
            C1R.Section c1Section)
            : base(reportConverter, c1Section)
        {
        }
        #endregion

        #region Protected
        protected override void InternalConvert()
        {
            ASection.PrintAtBottom = C1Section.PrintAtPageBottom;
        }
        #endregion

        #region Public properties
        public new AR.SectionReportModel.ReportFooter ASection
        {
            get { return (AR.SectionReportModel.ReportFooter)base.ASection; }
        }

        public override AR.Document.Section.SectionType ASectionType
        {
            get { return AR.Document.Section.SectionType.ReportFooter; }
        }
        #endregion
    }
}
