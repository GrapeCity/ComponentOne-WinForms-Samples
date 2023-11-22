//----------------------------------------------------------------------------
// ReportStyle.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

using Doc = C1.Win.C1Document;
using C1.Win.FlexReport;
using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp
{
    public class ReportStyle : ICloneable
    {
        // ** fields
        string  _name;
        bool    _builtIn;
        Image   _preview;
        SectionStyle[] _sections;

        // ** ctor
        public ReportStyle(string definition, bool builtIn)
        {
            _builtIn = builtIn;
            _sections = new SectionStyle[5];
            StyleDefinition = definition;
        }

        // ** ICloneable
        public object Clone()
        {
            ReportStyle clone = (ReportStyle)this.MemberwiseClone();
            for (int i = 0; i < _sections.Length; i++)
            {
                clone._sections[i] = (SectionStyle)_sections[i].Clone();
            }
            clone._builtIn = false;
            return clone;
        }

        // ** object model
        [ParenthesizePropertyName(true)]
        public string Name
        {
            get { return _name; }
            set { _name = value.Replace("{", string.Empty); }
        }
        [Browsable(false)]
        public bool IsCustom
        {
            get { return !_builtIn; }
        }
        [Browsable(false)]
        public string StyleDefinition
        {
            get { return GetDefinition(); }
            set { SetDefinition(value); }
        }
        public SectionStyle ReportHeader    { get { return _sections[0]; } set { _sections[0] = value; } }
        public SectionStyle PageHeader      { get { return _sections[1]; } set { _sections[1] = value; } }
        public SectionStyle GroupHeader     { get { return _sections[2]; } set { _sections[2] = value; } }
        public SectionStyle Detail          { get { return _sections[3]; } set { _sections[3] = value; } }
        public SectionStyle PageFooter      { get { return _sections[4]; } set { _sections[4] = value; } }

        private static string LocalizeStyleName(string styleDef)
        {
            int idx = styleDef.IndexOf('{');
            if (idx < 0)
                return styleDef;

            string styleName = styleDef.Substring(0, idx).Trim();
            styleName = styleName.Replace(' ', '_');
            PropertyInfo pi = typeof(Strings.ReportStyle.PredefinedStyleNames).GetProperty(styleName, BindingFlags.Static | BindingFlags.Public);
            if (pi == null)
                return styleDef;
            string locName = pi.GetValue(null, null) as string;// Strings.ReportStyle.GetStyleName(styleName);
            if (string.IsNullOrEmpty(locName))
                return styleDef;
            return locName + " " + styleDef.Substring(idx);
        }

        // get style list (built-ins plus whatever custom styles have been saved)
        public static List<ReportStyle> StyleList
        {
            get
            {
                string[] predefinedStyles = new string[] {
                    // Access 2007-inspired
                    "Access 2007 {Segoe UI;20;;#000000;;;}{Segoe UI;9;;#204D89;#C2DCFF;;}{Segoe UI;9;Bold;#000000;;;}{Segoe UI;9;;#000000;;;#F0F0F0}{Segoe UI;8;;#000000;;;}",
                    "Access 2003 {Tahoma;24;;#000000;;;}{Tahoma;8;;#000000;;;}{Tahoma;8;Bold;#000000;;;}{Tahoma;8;;#000000;;;}{Tahoma;8;;#000000;;;}",
                    "Apex {Lucida Sans;20;;#69676D;;;}{Book Antiqua;10;;#CEB966;#69676D;;}{Book Antiqua;10;Bold;#69676D;;a#69676D;}{Book Antiqua;10;;#000000;;;}{Book Antiqua;9;;#A0A0A0;;;}",
                    "Aspect {Verdana;18;;#323232;#E3DED1;;}{Verdana;8;;#E3DED1;#323232;;}{Verdana;8;Bold;#604878;;;}{Verdana;8;;#000000;;;}{Verdana;7;;#323232;;;}",
                    "Civic {Georgia;20;;#D6614A;;;}{Georgia;8;;#E4EEF3;#8CAEAD;;}{Georgia;8;Bold;#090000;;b#000000;}{Georgia;8;;#000000;;b#73A8D4;}{Georgia;7;;#000000;;;}",
                    "Concourse {Eras Medium ITC;20;;#282828;#2DA2BF;;}{Eras Medium ITC;9;;#EEEEEE;#282828;;}{Eras Medium ITC;9;Bold;#576793;;;}{Eras Medium ITC;9;;#282828;;;#EEEEEE}{Eras Medium ITC;8;;#2DA2BF;;;}",
                    "ComponentOne {Eras Medium ITC;20;;;#DD0000;;}{Eras Medium ITC;10;;#EEEEEE;#282828;;}{Eras Medium ITC;10;Bold;#576793;;;}{Eras Medium ITC;10;;#282828;;;#EEEEEE}{Eras Medium ITC;9;;#404040;;;}",
                    "Equity {Franklin Gothic Book;20;;;#D34817;;}{Perpetua;11;;#E9E5DC;#855D5D;;}{Perpetua;11;Bold;#9B2D1F;;;}{Perpetua;11;;#696464;;b#E9E5DC;}{Perpetua;10;;#BFBFBF;;;}",
                    "Flow {Calibri;20;;#04617B;#D1EAF0;;}{Constantia;9;;#04617B;;;}{Constantia;9;Bold;#04617B;;;}{Constantia;9;;#000000;;;}{Constantia;8;;#04617B;;;}",
                    "Foundry {Rockwell;20;;;#676A55;;}{Rockwell;9;;#EAEBDE;#676A55;;}{Rockwell;9;Bold;#EAEBDE;#676A55;;}{Rockwell;9;;#000000;;b#72A376;}{Rockwell;8;;#72A376;;;}",
                    "Median {Tw Cen Mt;20;;#FBEEC9;#775F55;;}{Tw Cen Mt;10;;#FBEEC9;#94B6D2;;}{Tw Cen Mt;10;Bold;#775F55;;;}{Tw Cen Mt;10;;#000000;;;}{Tw Cen Mt;8;;#775F55;;;}",
                    "Metro {Constantia;20;;;#000000;;}{Constantia;9;;;#000000;;}{Constantia;9;Bold;#4E5B6F;;;}{Constantia;9;;#000000;;;}{Constantia;9;;#000000;;;}",
                    "Module {Corbel;20;;;#383265;;}{Corbel;10;;;#383265;;}{Corbel;10;Bold;#000000;;;}{Corbel;10;;#000000;;;#EFEFEF}{Corbel;9;;#000000;;;}",
                    "None {Calibri;20;;#000000;;;}{Calibri;11;;#000000;;;}{Calibri;11;Bold;#000000;;;}{Calibri;11;;#000000;;;}{Calibri;11;;#000000;;;}",
                    "Northwind {Trebuchet;20;;#7F001B;;;}{Arial;9;;#F9F9F7;#C7C5BC;;}{Arial;9;Bold;#CF5216;;;}{Arial;9;;#000000;;;}{Arial;8;;#C7C5BC;;;}",
                    "Office {Cambria;20;Bold;#00224D;;;}{Calibri;9;Bold;#00224D;#79A7E3;;}{Calibri;9;Bold;#5C83B4;;;}{Calibri;9;;#000000;;;}{Calibri;8;;#000000;;;}",
                    "Opulent {Trebuchet;20;;#660066;#E9F7DD;;}{Trebuchet;9;;;#B13F9A;;}{Trebuchet;9;Bold;#B13F9A;;;}{Trebuchet;9;;#000000;;;#E9F7DD}{Trebuchet;8;;#000000;;;}",
                    "Oriel {Century Schoolbook;20;;#575F6D;;;}{Century Schoolbook;9;;#000000;;a#FF7D26;}{Century Schoolbook;9;Bold;#FF7D26;;a#000000;}{Century Schoolbook;9;;#000000;;;#FFF3EB}{Century Schoolbook;8;;#FF7D26;;;}",
                    "Origin {Bookman Old Style;20;;#DDE9EC;#46465D;;}{Gill Sans MT;10;;#DDE9EC;#46465D;;}{Gill Sans MT;10;Bold;#727CA3;;;}{Gill Sans MT;10;;#46465D;;;#DDE9EC}{Gill Sans MT;9;;#000000;;;}",
                    "Paper {Constantia;20;;#000000;#EFF2F5;;}{Constantia;9;;#EFF2F5;#4A606E;;}{Constantia;9;Bold;#4A606E;;b#000000;}{Constantia;9;;#000000;;b#95AEB1;}{Constantia;8;;#95AEB1;;;}",
                    "Solstice {Gill Sans MT;20;;#4F271C;#E7DEC9;;}{Gill Sans MT;10;;#4F271C;#E7DEC9;;}{Gill Sans MT;10;Bold;#3891A7;;;}{Gill Sans MT;10;;#4F271C;;;#E7DEC9}{Gill Sans MT;9;;#9F8D69;;;}",
                    "Technic {Franklin Gothic Book;20;;;#3B3B3B;;}{Arial;9;;#D4D2D0;#000000;;}{Arial;9;Bold;#979EA8;;b#979EA8;}{Arial;9;;#3B3B3B;;b#979EA8;}{Arial;8;;#000000;;;}",
                    "Trek {Franklin Gothic Book;20;;#4E3B30;;;}{Franklin Gothic Book;10;Bold;#4E3B30;;;}{Franklin Gothic Book;10;Bold;#A5644E;;;}{Franklin Gothic Book;10;;#4E3B30;;;#FBEEC9}{Franklin Gothic Book;9;;#000000;;;}",
                    "Urban {Trebuchet;20;;#42415A;;;}{Georgia;9;;#DEDEDE;#42415A;;}{Georgia;9;Bold;#42415A;;b#000000;}{Georgia;9;;#000000;;;#DEDEDE}{Georgia;8;;#438086;;;}",
                    "Verve {Century Gothic;20;;;#666666;;}{Century Gothic;8;;;#666666;;}{Century Gothic;8;Bold;#666666;;;}{Century Gothic;8;;#000000;;;#D2D2D2}{Century Gothic;7;;#000000;;;}",
                    "Windows Vista {Segoe UI;20;;;#000000;;}{Segoe UI;9;;#FFFFFF;#000000;;}{Segoe UI;9;Bold;#616A76;;;}{Segoe UI;9;;#373C43;;;#EBEBEB}{Segoe UI;8;;#000000;;;}",
                    // classic
                    "Bold {Times New Roman;20;Bold;#800000;;;}{Arial;10;Bold;#000000;;;}{Arial;10;Bold;#000000;;a#000000;}{Times New Roman;9;;#000000;;;}{Times New Roman;8;;#000000;;;}",
                    "Casual {Tahoma;24;Bold;#008080;;;}{Arial;10;;#000000;;;}{Arial;10;Bold;#000000;;b#008080;}{Times New Roman;9;;#000000;;;}{Times New Roman;8;;#000000;;;}",
                    "Compact {Haettenschweiler;26;Bold;#000000;;;}{Haettenschweiler;14;;#000000;;;}{Haettenschweiler;12;;#000000;;;}{Arial;9;;#000000;;;}{Arial;8;;#000000;;;}",
                    "Corporate {Times New Roman;20;Bold-Italic;#000080;;;}{Times New Roman;9;Bold-Italic;#000080;;;}{Times New Roman;9;Bold-Italic;#000080;;b#808080;}{Arial;9;;#000000;;;}{Arial;8;;#000000;;;}",
                    "Formal {Times New Roman;20;;#000000;;;}{Times New Roman;9;Bold;#000000;;;}{Times New Roman;9;Bold;#000000;;;}{Arial;9;;#000000;;;}{Arial;8;;#000000;;;}",
                    "Soft Gray {Arial;24;Bold;;#C0C0C0;;}{Arial;9;;#000000;;a#C0C0C0;}{Arial;9;Bold;#000000;;;}{Times New Roman;9;;#000000;;;}{Times New Roman;8;;#000000;;;}",
                    "Verdana {Verdana;18;Bold;;#4580B5;;}{Verdana;9;Bold;#4580B5;;a#000000;}{Verdana;9;;#4580B5;;;}{Verdana;9;;#000000;;;}{Verdana;8;;#000000;;;}",
                    "Web Report {Verdana;18;Bold;#50308C;#F5F5DC;;}{Verdana;9;Bold;#50308C;;a#000000;}{Verdana;9;;#4580B5;;;}{Verdana;9;;#000000;;;}{Verdana;8;;#000000;;;}",
                };

                // create new empty list
                List<ReportStyle> al = new List<ReportStyle>();

                foreach (string style in predefinedStyles)
                {
                    var styleDef = LocalizeStyleName(style);
                    try
                    {
                        al.Add(new ReportStyle(styleDef, true));
                    }
                    catch (Exception ex)
                    {
                        // this can happen e.g. if a font used in a predefined style is not available:
                        int idx = styleDef.IndexOf('{');
                        string styleName = idx >= 0 ? styleDef.Substring(0, idx).Trim() : Strings.ReportStyle.UnknownName;
                        string msg = string.Format(Strings.ReportStyle.ErrCannotCreateStyleFmt, styleName, ex.Message);
                        // MessageBox.Show(msg, Strings.ReportStyle.WarningTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageForm.Warn(msg);
                    }
                }

                // load user-defined styles
                foreach (string styleDef in AppSettings.LoadList("customstyles", null))
                {
                    try
                    {
                        al.Add(new ReportStyle(styleDef, false));
                    }
                    catch (Exception ex)
                    {
                        // was simply:
                        // Debug.WriteLine("failed to parse custom style...");
                        // - but we might as well show a regular warning message:
                        int idx = styleDef.IndexOf('{');
                        string styleName = idx >= 0 ? styleDef.Substring(0, idx).Trim() : "<unknown>";
                        string msg = string.Format("Cannot create custom style \"{0}\", error is:\r\n {1}", styleName, ex.Message);
                        // MessageBox.Show(msg, "Custom Styles Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageForm.Warn(msg);
                    }
                }

                // return the list
                return al;
            }
        }

        // apply the style to an existing report
        public void Apply(C1FlexReport rpt)
        {
            // default report font
            rpt.Font.Font = Detail.Font;

            // report header
            ReportHeader.Apply(rpt.Sections.Header);

            // page header
            PageHeader.Apply(rpt.Sections.PageHeader);

            // group headers
            foreach (Group group in rpt.Groups)
            {
                GroupHeader.Apply(group.SectionHeader);
            }

            // detail
            Detail.Apply(rpt.Sections.Detail);

            // report footer
            PageFooter.Apply(rpt.Sections.PageFooter);
        }

        // gets a preview image of the style suitable for display in a Wizard page
        // or Style definition dialog
        public Image GetPreview(bool forceUpdate)
        {
            if (_preview == null || forceUpdate)
            {
                // draw style preview
                Bitmap bmp = new Bitmap(150, 105);
                StringFormat sf = StringFormat.GenericTypographic;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // highest quality we can get
                    g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                    g.SmoothingMode = SmoothingMode.HighQuality;

                    // white background
                    Rectangle rc = new Rectangle(0, 0, bmp.Width, bmp.Height);
                    g.FillRectangle(Brushes.White, rc);

                    // content
                    //rc.Inflate(-3, -3);
                    rc.Height = 30;
                    int height = ReportHeader.Render(g, Name, rc);//"Title", rc);
                    rc.Offset(0, height - 1);
                    height = PageHeader.Render(g, Strings.ReportStyle.SamplePageHeaderText, rc);
                    rc.Offset(0, height - 1);
                    height = GroupHeader.Render(g, Strings.ReportStyle.SampleGroupHeaderText, rc);
                    rc.Offset(0, height - 1);
                    height = Detail.Render(g, Strings.ReportStyle.SampleDetailText, rc);
                    rc.Offset(0, height - 1);
                    using (Brush br = new SolidBrush(Detail.AlternateColor))
                    {
                        g.FillRectangle(br, rc);
                    }
                }

                // draw style preview into template
                Bitmap bmpTemplate = ReportWizard.BitmapFromStream("styleTemplate.bmp", Color.Red);
                using (Graphics g = Graphics.FromImage(bmpTemplate))
                {
                    Rectangle rc = new Rectangle(0, 71, bmp.Width, bmp.Height);
                    rc.Offset(+2, +2);
                    g.FillRectangle(Brushes.DarkGray, rc);
                    rc.Offset(-2, -2);
                    g.DrawImageUnscaled(bmp, rc);
                    g.DrawRectangle(Pens.Black, rc);
                }

                // save image for next time
                _preview = bmpTemplate;
            }

            // return the value that was asked for
            return _preview;
        }

        // build string to display in UI elements
        public override string ToString()
        {
            return IsCustom ? Name + Strings.ReportStyle.CustomNameQualifier : Name;
        }

        // ** internal
        string GetDefinition()
        {
            return string.Format("{0} {{{1}}}{{{2}}}{{{3}}}{{{4}}}{{{5}}}",
                Name,
                ReportHeader.SectionDefinition,
                PageHeader.SectionDefinition,
                GroupHeader.SectionDefinition,
                Detail.SectionDefinition,
                PageFooter.SectionDefinition);
        }
        void SetDefinition(string value)
        {
            // get name
            int pos = value.IndexOf('{');
            Name = value.Substring(0, pos).Trim();
            value = value.Substring(pos + 1).Trim();

            // get sections
            for (int i = 0; i < _sections.Length; i++)
            {
                pos = value.IndexOf('}');
                _sections[i] = new SectionStyle(value.Substring(0, pos));
                pos = value.IndexOf('{');
                value = value.Substring(pos + 1).Trim();
            }
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SectionStyle : ICloneable
    {
        // ** fields
        Font    _font;
        Color   _fore, _back, _alternate, _lines;
        bool    _lineAbove, _lineBelow;

        // ** constants
        const string STYLE_LINE_FIELD_NAME = "_styleLine";
        const string SCRIPT_PREFIX = "' -- style script start\r\n";
        const string SCRIPT_SUFFIX = "\r\n' -- style script end\r\n";
        const string SCRIPT_ONOPEN =
            SCRIPT_PREFIX +
            "_styleCtr = 0" +
            SCRIPT_SUFFIX;
        const string SCRIPT_ONPRINT = 
            SCRIPT_PREFIX +
            "detail.BackColor = iif(_styleCtr mod 2 = 0, rgb({0},{1},{2}),rgb({3},{4},{5}))\r\n" +
            "_styleCtr = _styleCtr + 1" + 
            SCRIPT_SUFFIX;
        const int    LINE_WIDTH = 30;

        // ** ctor
        public SectionStyle(string definition)
        {
            _fore = Color.Black;
            _back = _alternate = _lines = Color.Transparent;
            SectionDefinition = definition;
        }

        // ** object model
        public Font Font
        {
            get { return _font; }
            set { _font = value; }
        }
        public Color ForeColor
        {
            get { return _fore; }
            set { _fore = value; }
        }
        public Color BackColor
        {
            get { return _back; }
            set { _back = value; }
        }
        public Color AlternateColor
        {
            get { return _alternate; }
            set { _alternate = value; }
        }
        public Color LineColor
        {
            get { return _lines; }
            set { _lines = value; }
        }
        public bool LineAbove
        {
            get { return _lineAbove; }
            set { _lineAbove = value; }
        }
        public bool LineBelow
        {
            get { return _lineBelow; }
            set { _lineBelow = value; }
        }
        [Browsable(false)]
        public string SectionDefinition
        {
            get { return GetDefinition(); }
            set { SetDefinition(value); }
        }
        public int Render(Graphics g, string text, Rectangle rc)
        {
            Size sz = Size.Truncate(g.MeasureString(text, Font));
            rc.Height = sz.Height + 4;
            StringFormat sf = new StringFormat(StringFormat.GenericTypographic);
            sf.LineAlignment = StringAlignment.Center;
            using (Brush back = new SolidBrush(BackColor))
            using (Brush fore = new SolidBrush(ForeColor))
            {
                g.FillRectangle(back, rc);
                rc.X += 5;
                g.DrawString(text, Font, fore, rc, sf);
            }
            if (LineAbove || LineBelow)
            {
                using (Brush line = new SolidBrush(_lines))
                {
                    if (LineAbove)
                    {
                        g.FillRectangle(line, rc.X, rc.Y, rc.Width, 1);
                    }
                    if (LineBelow)
                    {
                        g.FillRectangle(line, rc.X, rc.Bottom - 1, rc.Width, 1);
                    }
                }
            }
            return rc.Height;
        }
        public void Apply(Section section)
        {
            // section color
            section.BackColor = BackColor;

            // field font/color
            double left = double.MaxValue;
            double right = double.MinValue;
            FieldCollection fields = section.Fields;
            foreach (FieldBase f in fields)
            {
                var t = f.GetType();
                var pdFont = t.GetProperty("Font");
                if (pdFont != null)
                {
                    var fontHolder = pdFont.GetValue(f, null) as FontHolder;
                    if (fontHolder != null)
                        fontHolder.Font = this.Font;
                }
                var pdForeColor = t.GetProperty("ForeColor");
                if (pdForeColor != null)
                    pdForeColor.SetValue(f, this.ForeColor, null);
                left = Math.Min(left, f.Left);
                right = Math.Max(right, f.Left + f.Width);
            }
            if (fields.Count == 0)
            {
                left = 0;
                right = section.ParentReport.Layout.Width;
            }

            // delete old lines
            for (int i = 0; i < fields.Count; i++)
            {
                if (fields[i].Name.StartsWith(STYLE_LINE_FIELD_NAME))
                {
                    fields.RemoveAt(i);
                    i--;
                }
            }

            // disable warnings about using Border instead of BorderColor etc:
#pragma warning disable CS0618
            // add lines
            if (section.Height > LINE_WIDTH && LineColor != Color.Transparent && (LineAbove || LineBelow))
            {
                if (LineAbove)
                {
                    string name = GetUniqueFieldName(fields, STYLE_LINE_FIELD_NAME);
                    Field f = fields.Add(name, string.Empty, left, 0, right - left, LINE_WIDTH);

                    f.BorderColor = LineColor;
                    f.BorderStyle = BorderStyleEnum.Solid;
                    f.Shape = new Doc.LineShape(Doc.LineSlantEnum.NoSlant);
                    //f.BackColor = LineColor; // not as good as lines
                }
                if (LineBelow)
                {
                    string name = GetUniqueFieldName(fields, STYLE_LINE_FIELD_NAME);
                    Field f = fields.Add(name, string.Empty, left, section.Height - LINE_WIDTH, right - left, LINE_WIDTH);

                    f.BorderColor = LineColor;
                    f.BorderStyle = BorderStyleEnum.Solid;
                    f.Shape = new Doc.LineShape(Doc.LineSlantEnum.NoSlant);
                    //f.BackColor = LineColor; // not as good as lines
                    f.Anchor = AnchorEnum.Bottom;
                }
            }
#pragma warning restore CS0618

            // create script to apply alternate back color
            C1FlexReport rpt = section.ParentReport;
            if (section == rpt.Sections.Detail)
            {
                rpt.OnOpen = RemoveStyleScript(rpt.OnOpen);
                section.OnPrint = RemoveStyleScript(section.OnPrint);
                if (!AlternateColor.Equals(Color.Transparent) && !AlternateColor.Equals(BackColor))
                {
                    rpt.OnOpen = rpt.OnOpen + SCRIPT_ONOPEN;
                    section.OnPrint = section.OnPrint + string.Format(SCRIPT_ONPRINT,
                        BackColor.R, BackColor.G, BackColor.B,
                        AlternateColor.R, AlternateColor.G, AlternateColor.B);
                }
            }
        }
        public override string ToString()
        {
            return "SectionStyle";
        }

        // ** ICloneable
        public object Clone()
        {
            return (SectionStyle)this.MemberwiseClone();
        }

        // ** internal

        string RemoveStyleScript(string script)
        {
            if (string.IsNullOrEmpty(script))
            {
                return string.Empty;
            }

            for (; ; )
            {
                int start = script.IndexOf(SCRIPT_PREFIX);
                int end = script.IndexOf(SCRIPT_SUFFIX);
                if (start < 0 || end < 0 || start >= end)
                {
                    break;
                }
                script = script.Substring(0, start) + script.Substring(end + SCRIPT_SUFFIX.Length);
            }

            return script;
        }
        string GetUniqueFieldName(FieldCollection fields, string prefix)
        {
            for (int i = 1; ; i++)
            {
                string name = prefix + i.ToString();
                if (!fields.Contains(name))
                    return name;
            }
        }
        string GetDefinition()
        {
            string lines = string.Empty;
            if ( _lineAbove && !_lineBelow) lines = "a";
            if (!_lineAbove &&  _lineBelow) lines = "b";
            if ( _lineAbove &&  _lineBelow) lines = "c";
            if (lines.Length > 0) lines += ColorTranslator.ToHtml(_lines);

            return string.Format("{0};{1:0.##};{2};{3};{4};{5};{6}",
                _font.Name, 
                _font.Size, 
                _font.Style == System.Drawing.FontStyle.Regular ? null: (object)_font.Style,
                ColorTranslator.ToHtml(_fore),
                ColorTranslator.ToHtml(_back),
                lines,
                ColorTranslator.ToHtml(_alternate));
        }
        void SetDefinition(string value)
        {
            // 0     1     2      3     4     5      6
            // Face, Size, Style, Fore, Back, Lines, Alt
            string[] atts = value.Split(';');
            if (atts.Length >= 7)
            {
                // parse font
                string fontFace = atts[0].Trim();
                float fontSize = float.Parse(atts[1], CultureInfo.InvariantCulture);
                FontStyle fontStyle = FontStyle.Regular;
                if (atts[2].IndexOf("bold", StringComparison.OrdinalIgnoreCase) > -1)       fontStyle |= FontStyle.Bold;
                if (atts[2].IndexOf("italic", StringComparison.OrdinalIgnoreCase) > -1)     fontStyle |= FontStyle.Italic;
                if (atts[2].IndexOf("underline", StringComparison.OrdinalIgnoreCase) > -1)  fontStyle |= FontStyle.Underline;
                _font = new Font(fontFace, fontSize, fontStyle);

                // parse colors
                _fore = atts[3].Length > 0 ? ColorTranslator.FromHtml(atts[3]) : Color.White;
                _back = atts[4].Length > 0 ? ColorTranslator.FromHtml(atts[4]) : Color.White;
                _alternate = atts[6].Length > 0 ? ColorTranslator.FromHtml(atts[6]) : Color.Transparent;

                // parse lines (above/below the fields)
                if (atts[5].Length >= 8)
                {
                    switch (char.ToLower(atts[5][0]))
                    {
                        case 'a':
                            _lineAbove = true;
                            break;
                        case 'b':
                            _lineBelow = true;
                            break;
                        case 'c':
                            _lineAbove = true;
                            _lineBelow = true;
                            break;
                    }
                    _lines = ColorTranslator.FromHtml(atts[5].Substring(1));
                }
            }
        }
    }
}
