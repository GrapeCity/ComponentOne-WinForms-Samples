using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using AR = GrapeCity.ActiveReports;
using C1R = C1.C1Report;

namespace C1Report2Rpx
{
    /// <summary>
    /// Encapsulates logic for converting C1Report fields to ARControl objects.
    /// </summary>
    internal class C1FieldConverter : ReportItemConverterBase
    {
        private AR.SectionReportModel.Section _aSection;
        private C1R.Field _c1Field;

        #region Constructors
        public C1FieldConverter(
            C1ReportConverter reportConverter,
            AR.SectionReportModel.Section aSection,
            C1R.Field c1Field)
            : base(reportConverter)
        {
            _aSection = aSection;
            _c1Field = c1Field;
        }
        #endregion

        #region Private
        private void AddLog(
            string fieldType,
            string propertyName,
            object propertyValue)
        {
            AddLog(LogEntryLevel.Warning, string.Format(Strings.Warnings.UnsupportedFieldProperty, propertyName, propertyValue, fieldType));
        }

        private void AddLog(
            LogEntryLevel level,
            string message)
        {
            Log.Add(level, LogSource, message);
        }
        #endregion

        #region Protected properties
        protected string LogSource
        {
            get { return string.Format(Strings.LogSources.Field, C1Field.Name); }
        }
        #endregion

        #region Public
        public AR.SectionReportModel.ARControl Convert()
        {
            AR.SectionReportModel.ARControl result = null;

            if (C1Field.ForcePageBreak != C1R.ForcePageBreakEnum.None)
            {
                AddLog(LogEntryLevel.Message, Strings.Messages.FieldForcePageBreak);
                if (C1Field.ForcePageBreak == C1R.ForcePageBreakEnum.Before ||
                    C1Field.ForcePageBreak == C1R.ForcePageBreakEnum.PageBefore ||
                    C1Field.ForcePageBreak == C1R.ForcePageBreakEnum.BeforeAndAfter)
                {
                    AR.SectionReportModel.PageBreak pb = new AR.SectionReportModel.PageBreak();
                    pb.Name = CheckName(null, "PageBreak");
                    pb.Left = 0;
                    pb.Top = Util.ArLength(C1Field.Top);
                    ASection.Controls.Add(pb);
                }
            }
            if (C1Field.Anchor != C1R.AnchorEnum.Top)
                AddLog(LogEntryLevel.Warning, Strings.Warnings.UnsupportedFieldAnchor);

            if (C1Field.GetType() != typeof(C1R.Field))
            {
                AddLog(LogEntryLevel.Warning, string.Format(Strings.Warnings.UnsupportedCustomField, C1Field.GetType().Name));
                var ctrl = new AR.SectionReportModel.TextBox();
                ConvertCommon(ctrl);
                result = ctrl;
            }
            else if (C1Field.CheckBox != C1R.CheckBoxEnum.NoCheckBox)
            {
                var ctrl = new AR.SectionReportModel.CheckBox();
                ConvertCommon(ctrl);
                ConvertSpecial(ctrl);
                result = ctrl;
            }
            else if (C1Field.RTF)
            {
                var ctrl = new AR.SectionReportModel.RichTextBox();
                ConvertCommon(ctrl);
                ConvertSpecial(ctrl);
                result = ctrl;
            }
            else if (C1Field.BarCode != C1R.BarCodeEnum.None)
            {
                var ctrl = new AR.SectionReportModel.Barcode();
                ConvertCommon(ctrl);
                ConvertSpecial(ctrl);
                result = ctrl;
            }
            else if (C1Field.Picture != null)
            {
                var ctrl = new AR.SectionReportModel.Picture();
                ConvertCommon(ctrl);
                ConvertSpecial(ctrl);
                result = ctrl;
            }
            else if (C1Field.ShapeType == C1R.ShapeType.Line)
            {
                var ctrl = new AR.SectionReportModel.Line();
                ConvertCommon(ctrl);
                ConvertSpecial(ctrl);
                result = ctrl;
            }
            else if (C1Field.ShapeType != C1R.ShapeType.None)
            {
                var ctrl = new AR.SectionReportModel.Shape();
                ConvertCommon(ctrl);
                ConvertSpecial(ctrl);
                result = ctrl;
            }
            else if (C1Field.Subreport != null)
            {
                var ctrl = new AR.SectionReportModel.SubReport();
                ConvertCommon(ctrl);
                ConvertSpecial(ctrl);
                result = ctrl;
            }
            else
            {
                var ctrl = new AR.SectionReportModel.TextBox();
                ConvertCommon(ctrl);
                ConvertSpecial(ctrl);
                result = ctrl;
            }

            if (C1Field.ForcePageBreak == C1R.ForcePageBreakEnum.After ||
                C1Field.ForcePageBreak == C1R.ForcePageBreakEnum.PageAfter ||
                C1Field.ForcePageBreak == C1R.ForcePageBreakEnum.BeforeAndAfter)
            {
                AR.SectionReportModel.PageBreak pb = new AR.SectionReportModel.PageBreak();
                pb.Name = CheckName(null, "PageBreak");
                pb.Left = 0;
                pb.Top = Util.ArLength(C1Field.Top + C1Field.Height);
                ASection.Controls.Add(pb);
            }

            //
            return result;
        }

        private void ConvertCommon(
            AR.SectionReportModel.ARControl ctrl)
        {
            ctrl.Name = CheckName(C1Field.Name, "Field");
            ctrl.Visible = C1Field.Visible;
            ctrl.Left = Util.ArLength(C1Field.Left);
            ctrl.Top = Util.ArLength(C1Field.Top);
            ctrl.Width = Util.ArLength(C1Field.Width);
            ctrl.Height = Util.ArLength(C1Field.Height);
            Util.ConvertBorder(C1Field, ctrl.Border);
        }

        private void ConvertSpecial(
            AR.SectionReportModel.CheckBox ctrl)
        {
            ctrl.BackColor = C1Field.BackColor;
            ctrl.ForeColor = C1Field.ForeColor;
            ctrl.CheckAlignment = Util.ConvertAlignment(C1Field.Align, string.Format(Strings.LogSources.Field, C1Field.Name), Log);
            if (C1Field.Calculated)
                ctrl.DataField = ReportConverter.ExpressionToDataField(C1Field.Text);
            if (C1Field.TextAngle != 0)
                AddLog(Strings.ARFieldTypes.CheckBox, "TextAngle", C1Field.TextAngle);
            if (C1Field.CanGrow)
                AddLog(Strings.ARFieldTypes.CheckBox, "CanGrow", C1Field.CanGrow);
            if (C1Field.CanShrink)
                AddLog(Strings.ARFieldTypes.CheckBox, "CanShrink", C1Field.CanShrink);
            if (!string.IsNullOrEmpty(C1Field.LinkTarget))
                AddLog(Strings.ARFieldTypes.CheckBox, "LinkTarget", C1Field.LinkTarget);
        }

        private void ConvertSpecial(
            AR.SectionReportModel.RichTextBox ctrl)
        {
            ctrl.BackColor = C1Field.BackColor;
            ctrl.RTF = C1Field.Text;
            if (C1Field.KeepTogether)
                AddLog(Strings.ARFieldTypes.RichText, "KeepTogether", C1Field.KeepTogether);
            if (!string.IsNullOrEmpty(C1Field.LinkTarget))
                AddLog(Strings.ARFieldTypes.RichText, "LinkTarget", C1Field.LinkTarget);
        }

        private void ConvertSpecial(
            AR.SectionReportModel.Barcode ctrl)
        {
            switch (C1Field.BarCode)
            {
                case C1R.BarCodeEnum.Codabar:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.Codabar;
                    break;
                case C1R.BarCodeEnum.Code128:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.Code_128auto;
                    break;
                case C1R.BarCodeEnum.Code39:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.Code39;
                    break;
                case C1R.BarCodeEnum.Code93:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.Code_93;
                    break;
                case C1R.BarCodeEnum.CodeI2of5:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.Code_2_of_5;
                    break;
                case C1R.BarCodeEnum.Ean128:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.EAN128FNC1;
                    break;
                case C1R.BarCodeEnum.Ean13:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.EAN_13;
                    break;
                case C1R.BarCodeEnum.Ean8:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.EAN_8;
                    break;
                case C1R.BarCodeEnum.PostNet:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.PostNet;
                    break;
                case C1R.BarCodeEnum.UpcA:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.UPC_A;
                    break;
                case C1R.BarCodeEnum.UpcE:
                    ctrl.Style = AR.SectionReportModel.BarCodeStyle.UPC_E0;
                    break;
            }
            ctrl.Text = C1Field.Text;
            if (C1Field.Calculated)
                ctrl.DataField = ReportConverter.ExpressionToDataField(C1Field.Text);
            ctrl.BackColor = C1Field.BackColor;
            ctrl.ForeColor = C1Field.ForeColor;
            if (C1Field.CanGrow)
                AddLog(Strings.ARFieldTypes.CheckBox, "CanGrow", C1Field.CanGrow);
            if (C1Field.CanShrink)
                AddLog(Strings.ARFieldTypes.CheckBox, "CanShrink", C1Field.CanShrink);
            if (C1Field.TextAngle == 90)
                ctrl.Rotation = AR.SectionReportModel.Rotation.Rotate90Degrees;
            else if (C1Field.TextAngle == 180)
                ctrl.Rotation = AR.SectionReportModel.Rotation.Rotate180Degrees;
            else if (C1Field.TextAngle == 270)
                ctrl.Rotation = AR.SectionReportModel.Rotation.Rotate270Degrees;
            else
            {
                if (C1Field.TextAngle != 0)
                    AddLog(Strings.ARFieldTypes.Barcode, "TextAngle", C1Field.TextAngle);
            }
            if (C1Field.PictureScale != C1R.PictureScaleEnum.Stretch)
            {
                AddLog(Strings.ARFieldTypes.Barcode, "PictureScale", C1Field.PictureScale);
                AddLog(Strings.ARFieldTypes.Barcode, "PictureAlign", C1Field.PictureAlign);
            }
            if (!string.IsNullOrEmpty(C1Field.LinkTarget))
                AddLog(Strings.ARFieldTypes.Barcode, "LinkTarget", C1Field.LinkTarget);
        }

        private void ConvertSpecial(
            AR.SectionReportModel.Picture ctrl)
        {
            //
            Util.ARPicture pic = Util.ConvertPicture(C1Field.Picture as C1R.Util.PictureHolder, C1Field.PictureAlign, C1Field.PictureScale, LogSource, Log);
            ctrl.Image = pic.Image;
            ctrl.DataField = pic.DataField;
            ctrl.PictureAlignment = pic.Align.Alignment;
            ctrl.SizeMode = pic.Align.SizeMode;

            //
            if (C1Field.Calculated)
                ctrl.DataField = ReportConverter.ExpressionToDataField(C1Field.Text);

            //
            ctrl.HyperLink = C1Field.LinkTarget;
            if (C1Field.CanGrow)
                AddLog(Strings.ARFieldTypes.CheckBox, "CanGrow", C1Field.CanGrow);
            if (C1Field.CanShrink)
                AddLog(Strings.ARFieldTypes.CheckBox, "CanShrink", C1Field.CanShrink);
            if (!string.IsNullOrEmpty(C1Field.LinkTarget))
                AddLog(Strings.ARFieldTypes.Barcode, "LinkTarget", C1Field.LinkTarget);
        }

        private void ConvertSpecial(
            AR.SectionReportModel.Line ctrl)
        {
            var line = (C1.C1Report.LineShape)C1Field.Shape;
            switch (line.LineSlant)
            {
                case C1R.LineSlantEnum.Down:
                    ctrl.X1 = ctrl.Left;
                    ctrl.Y1 = ctrl.Top;
                    ctrl.X2 = ctrl.Left + ctrl.Width;
                    ctrl.Y2 = ctrl.Top + ctrl.Height;
                    break;
                case C1R.LineSlantEnum.NoLine:
                    ctrl.Visible = false;
                    break;
                case C1R.LineSlantEnum.NoSlant:
                    if (ctrl.Width > ctrl.Height)
                    {
                        ctrl.Height = 0;
                    }
                    else
                    {
                        ctrl.Width = 0;
                    }
                    break;
                case C1R.LineSlantEnum.Up:
                    ctrl.X1 = ctrl.Left;
                    ctrl.Y1 = ctrl.Top + ctrl.Height;
                    ctrl.X2 = ctrl.Left + ctrl.Width;
                    ctrl.Y2 = ctrl.Top;
                    break;
            }
            ctrl.LineColor = C1Field.ForeColor;
            // If LineWeight specified as float number then it serialized/deserialized
            // to rpx incorrectly
            // serialized as 1,3333
            // and DEserialized as 13333
            ctrl.LineWeight = C1.C1Preview.Utils.Round(Util.TwipsToPixels(C1Field.LineWidth));
        }

        private void ConvertSpecial(
            AR.SectionReportModel.Shape ctrl)
        {
            switch (C1Field.ShapeType)
            {
                case C1R.ShapeType.Arc:
                case C1R.ShapeType.IsoscelesTriangle:
                case C1R.ShapeType.Pie:
                case C1R.ShapeType.RightTriangle:
                    AddLog(LogEntryLevel.Warning, string.Format(Strings.Warnings.UnsupportedShapeType, C1Field.ShapeType));
                    break;
                case C1R.ShapeType.Rectangle:
                    ctrl.Style = AR.SectionReportModel.ShapeType.Rectangle;
                    break;
                case C1R.ShapeType.Ellipse:
                    ctrl.Style = AR.SectionReportModel.ShapeType.Ellipse;
                    break;
            }
            ctrl.BackColor = C1Field.BackColor;
            ctrl.LineColor = C1Field.ForeColor;
            ctrl.LineWeight = Util.TwipsToPixels(C1Field.LineWidth);
        }

        private void ConvertSpecial(
            AR.SectionReportModel.SubReport ctrl)
        {
            AddLog(LogEntryLevel.Warning, Strings.Warnings.UnsupportedSubReport);
        }

        private void ConvertSpecial(
            AR.SectionReportModel.TextBox ctrl)
        {
            ctrl.Text = C1Field.Text;
            if (C1Field.Calculated)
                ctrl.DataField = ReportConverter.ExpressionToDataField(C1Field.Text);

            //
            switch (C1Field.Align)
            {
                case C1R.FieldAlignEnum.General:
                    // General alignment not supported by TextBox BUT warning is not added
                    // because too many warnings will be generated
                    //AddLog(LogEntryLevel.Warning, string.Format(Strings.Warnings.UnsupportedGeneralAlign));
                    ctrl.Alignment = AR.Document.Section.TextAlignment.Left;
                    ctrl.VerticalAlignment = AR.Document.Section.VerticalTextAlignment.Top;
                    break;
                case C1R.FieldAlignEnum.LeftTop:
                case C1R.FieldAlignEnum.JustTop:
                    ctrl.Alignment = AR.Document.Section.TextAlignment.Left;
                    ctrl.VerticalAlignment = AR.Document.Section.VerticalTextAlignment.Top;
                    break;
                case C1R.FieldAlignEnum.LeftMiddle:
                case C1R.FieldAlignEnum.JustMiddle:
                    ctrl.Alignment = AR.Document.Section.TextAlignment.Left;
                    ctrl.VerticalAlignment = AR.Document.Section.VerticalTextAlignment.Middle;
                    break;
                case C1R.FieldAlignEnum.LeftBottom:
                case C1R.FieldAlignEnum.JustBottom:
                    ctrl.Alignment = AR.Document.Section.TextAlignment.Left;
                    ctrl.VerticalAlignment = AR.Document.Section.VerticalTextAlignment.Bottom;
                    break;
                case C1R.FieldAlignEnum.RightTop:
                    ctrl.Alignment = AR.Document.Section.TextAlignment.Right;
                    ctrl.VerticalAlignment = AR.Document.Section.VerticalTextAlignment.Top;
                    break;
                case C1R.FieldAlignEnum.RightMiddle:
                    ctrl.Alignment = AR.Document.Section.TextAlignment.Right;
                    ctrl.VerticalAlignment = AR.Document.Section.VerticalTextAlignment.Middle;
                    break;
                case C1R.FieldAlignEnum.RightBottom:
                    ctrl.Alignment = AR.Document.Section.TextAlignment.Right;
                    ctrl.VerticalAlignment = AR.Document.Section.VerticalTextAlignment.Bottom;
                    break;
                case C1R.FieldAlignEnum.CenterTop:
                    ctrl.Alignment = AR.Document.Section.TextAlignment.Center;
                    ctrl.VerticalAlignment = AR.Document.Section.VerticalTextAlignment.Top;
                    break;
                case C1R.FieldAlignEnum.CenterMiddle:
                    ctrl.Alignment = AR.Document.Section.TextAlignment.Center;
                    ctrl.VerticalAlignment = AR.Document.Section.VerticalTextAlignment.Middle;
                    break;
                case C1R.FieldAlignEnum.CenterBottom:
                    ctrl.Alignment = AR.Document.Section.TextAlignment.Center;
                    ctrl.VerticalAlignment = AR.Document.Section.VerticalTextAlignment.Bottom;
                    break;
            }
            if (C1Field.Align == C1R.FieldAlignEnum.JustTop || C1Field.Align == C1R.FieldAlignEnum.LeftMiddle || C1Field.Align == C1R.FieldAlignEnum.LeftBottom)
                ctrl.TextJustify = AR.Document.Section.TextJustify.Auto;

            ctrl.BackColor = C1Field.BackColor;
            ctrl.Font = C1Field.Font;
            ctrl.ForeColor = C1Field.ForeColor;
            ctrl.OutputFormat = C1Field.Format;
            if (C1Field.LineSpacing != 100)
                AddLog(Strings.ARFieldTypes.TextBox, "LineSpacing", C1Field.LineSpacing);
            if (C1Field.TextAngle != 0)
                AddLog(Strings.ARFieldTypes.TextBox, "TextAngle", C1Field.TextAngle);
            if (C1Field.WordWrap)
                ctrl.WrapMode = AR.Document.Section.WrapMode.WordWrap;
            else
                ctrl.WrapMode = AR.Document.Section.WrapMode.NoWrap;
            switch (C1Field.RunningSum)
            {
                case C1R.RunningSumEnum.SumOverAll:
                    ctrl.SummaryRunning = AR.SectionReportModel.SummaryRunning.All;
                    break;
                case C1R.RunningSumEnum.SumOverGroup:
                    ctrl.SummaryRunning = AR.SectionReportModel.SummaryRunning.Group;
                    break;
            }
            if (C1Field.KeepTogether)
                AddLog(Strings.ARFieldTypes.TextBox, "KeepTogether", C1Field.KeepTogether);
            ctrl.CanGrow = C1Field.CanGrow;
            ctrl.CanShrink = C1Field.CanShrink;
            ctrl.Padding = Util.ConvertPadding(C1Field);
            ctrl.HyperLink = C1Field.LinkTarget;
        }
        #endregion

        #region Public properties
        public AR.SectionReportModel.Section ASection
        {
            get { return _aSection; }
        }

        public C1R.Field C1Field
        {
            get { return _c1Field; }
        }
        #endregion
    }
}
