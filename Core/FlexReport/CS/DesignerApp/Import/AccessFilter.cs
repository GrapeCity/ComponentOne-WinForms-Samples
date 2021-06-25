//----------------------------------------------------------------------------
// AccessFilter.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Access;
using RX = System.Text.RegularExpressions;

using C1.Win.Document;
using C1.Win.FlexReport;
using Control = Access.Control;
using Field = C1.Win.FlexReport.Field;
using Form = System.Windows.Forms.Form;
using Group = C1.Win.FlexReport.Group;
using Image = System.Drawing.Image;
using Section = C1.Win.FlexReport.Section;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
	/// Summary description for AccessFilter.
	/// </summary>
	internal class AccessFilter : IC1ReportImportFilter
	{
		private Form _owner;

		// ** ctor
		public AccessFilter(Form owner)
		{
			_owner = owner;
		}

        private static float ConvertLineSpacing(int lineSpacingTw, Font f)
        {
            float fontHeightTw = f.GetHeight((float)C1.Win.Document.Unit.TwipsPerInch);
            return 100 + lineSpacingTw / fontHeightTw * 100;
        }

		// ** IC1ReportImportFilter
		public event EventHandler Loading;
        bool IC1ReportImportFilter.Import(string mdbFile, List<C1FlexReport> reportList)
        {
            // always dispose this form when done
            AccessImportForm frm = null;

            // always close Access when done
            Access.Application app = null;

            // assume user wants to clear current list before importing
            bool clearOnImport = true;

            // go to work
            try
            {
                // open mdb file
                app = new Access.ApplicationClass();
                app.OpenCurrentDatabase(mdbFile, false);

                // show import form to select which report to import
                frm = new AccessImportForm();
                foreach (Access.AccessObject obj in app.CurrentProject.AllReports)
                {
                    frm.CheckedList.Items.Add(obj.Name, CheckState.Checked);
                }

                // check that we found at least one report
                if (frm.CheckedList.Items.Count == 0)
                {
                    string msg = string.Format(Strings.AccessFilter.ErrNoReportsFmt, mdbFile);
                    // MessageBox.Show(msg, Strings.AccessFilter.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageForm.Warn(msg);
                    return false;
                }

                // let user select which reports he wants to import (or cancel the dialog)
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    return false;
                }

                // honor 'clear all' setting
                clearOnImport = frm.ClearOnImport;

                // scan again and load all selected reports
				_owner.Cursor = Cursors.WaitCursor;
				foreach (Access.AccessObject obj in app.CurrentProject.AllReports)
                {
                    // check that this one is selected
                    int index = frm.CheckedList.Items.IndexOf(obj.Name);
                    if (index > -1 && frm.CheckedList.GetItemChecked(index) == false)
                        continue;

                    // create report, add to list
                    C1FlexReport c1rpt = new C1FlexReport();
                    c1rpt.ReportName = obj.Name;
                    reportList.Add(c1rpt);

                    // fire event
                    if (Loading != null)
                        Loading(this, EventArgs.Empty);

                    // import this one
                    string name = obj.Name;
                    app.DoCmd.OpenReport(name, Access.AcView.acViewDesign, null, null);
                    TranslateReport(app.Reports[name], c1rpt);
                    app.DoCmd.Close(Access.AcObjectType.acReport, name, Access.AcCloseSave.acSaveNo);
                }

                // load dependent subreports that haven't been selected
                for (int rptIndex = 0; rptIndex < reportList.Count; rptIndex++)
                {
                    C1FlexReport c1rpt = reportList[rptIndex];
                    foreach (FieldBase c1f in c1rpt.Fields)
                    {
                        // look for subreports in this report
                        int pos = c1f.Name.IndexOf('\b');
                        if (pos < 0) continue;
                        string subName = c1f.Name.Substring(pos+1);

                        // if the report hasn't been loaded, load it now
                        int index = frm.CheckedList.Items.IndexOf(subName);
                        if (index > -1 && !frm.CheckedList.GetItemChecked(index))
                        {
                            // add report to list
                            C1FlexReport c1rptSub = new C1FlexReport();
                            c1rptSub.ReportName = subName;
                            reportList.Add(c1rptSub);

                            // import report
                            app.DoCmd.OpenReport(subName, Access.AcView.acViewDesign, null, null);
                            TranslateReport(app.Reports[subName], c1rptSub);
                            app.DoCmd.Close(Access.AcObjectType.acReport, subName, Access.AcCloseSave.acSaveNo);

                            // need to start again
                            rptIndex = 0;
                        }
                    }
                }

                // fix subreport references
                foreach (C1FlexReport c1rpt in reportList)
                {
                    foreach (FieldBase c1f in c1rpt.Fields)
                    {
                        // look for subreports in this report
                        int pos = c1f.Name.IndexOf('\b');
                        if (pos < 0) continue;
                        string subName = c1f.Name.Substring(pos+1);

                        // look for subreport on the list
                        c1f.Name = c1f.Name.Substring(0, pos);
                        foreach (C1FlexReport c1sub in reportList)
                        {
                            if (string.Compare(c1sub.ReportName, subName, true) == 0)
                            {
                                if(c1f is Field)
                                    ((Field)c1f).Subreport = c1sub;
                                else if (c1f is SubreportField)
                                {
                                    var srField = (SubreportField) c1f;
                                    srField.Subreport = c1sub;
                                    TranslateSubreportParameterValues(srField);
                                }
                                break;
                            }
                        }
                    }
                }
            }
            finally // always close Access and dispose form when done
            {
                if (app != null)
                {
                    try
                    {
                        app.CloseCurrentDatabase();
                        app.Quit(Access.AcQuitOption.acQuitSaveNone);
                    }
                    catch { }
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(app);
                    app = null;
                }
                if (frm != null)
                {
                    frm.Dispose();
                }
				_owner.Cursor = Cursors.Default;
			}

			// collect to clear Access instance
			System.GC.Collect();
			System.GC.Collect();
			System.GC.Collect();
			
			// done
            return clearOnImport;
        }

	    private void TranslateSubreportParameterValues(SubreportField c1f)
	    {
	        var masterReport = c1f.ParentReport;
	        if (masterReport == null) return;
	        var childReport = c1f.Subreport;
	        if (childReport == null) return;

	        foreach (var childParam in childReport.Parameters)
	        {
	            var paramName = childParam.Name;
                var masterParam = masterReport.Parameters.FindByName(paramName);
	            if (masterParam != null)
	            {
	                var paramValue = new ReportParameterValue {Name = paramName, Value = "=" + paramName};
	                c1f.ParameterValues.Add(paramValue);
	            }
	        }
	    }

        // ** internal/private stuff
        private bool TranslateReport(Access.Report rpt, C1FlexReport c1rpt)
        {
			//------------------------------------------------------------------------------------
			// start fresh
            c1rpt.Clear();

			//------------------------------------------------------------------------------------
			// use Access mode grow/shrink
			c1rpt.GrowShrinkMode = GrowShrinkModeEnum.Access;

			//------------------------------------------------------------------------------------
			// save report name
            c1rpt.ReportName = rpt.Name;

			//------------------------------------------------------------------------------------
			// save report tag, if any
			string tag = rpt.Tag;
			if (tag != null && tag.Length > 0)
				c1rpt.Tag = tag;

            //------------------------------------------------------------------------------------
            // save data source info
			DataSource ds = c1rpt.DataSource;
			ds.ConnectionString = rpt.Application.ADOConnectString;
            var rs = TranslateQueryDef(rpt);
            rs = ds.ParseParameters(rs, c1rpt.Parameters);
            ds.RecordSource = rs;
			ds.Filter = rpt.Filter;

			//------------------------------------------------------------------------------------
            // save layout
            var c1l = c1rpt.Layout;
			if (rpt.PrtMip is byte[]) // could be DBNull...
			{
				PRTMIP mip = new PRTMIP((byte[])rpt.PrtMip);
				c1l.Width = mip.xWidth + mip.yColumnSpacing;
				c1l.MarginLeft = mip.xLeftMargin;
				c1l.MarginRight = mip.xRightMargin;
				c1l.MarginTop = mip.yTopMargin;
				c1l.MarginBottom = mip.yBotMargin;
				c1l.Columns = mip.cxColumns;
				if (mip.cxColumns > 1 && mip.rItemLayout == 1953)
					c1l.ColumnLayout = ColumnLayoutEnum.Across;
			}
            c1l.PageHeader = (HdrFtrEnum)rpt.PageHeader;
            c1l.PageFooter = (HdrFtrEnum)rpt.PageFooter;

            // watermark
            object picData = rpt.PictureData;
            if (picData != null)
            {
                c1rpt.Watermark.Picture = TranslateImage(rpt.Application, picData);
                c1rpt.Watermark.Visibility = TranslateWatermarkVisibility(rpt.PicturePages);
                c1rpt.Watermark.PictureAlign = TranslatePictureAlignEnum(rpt.PictureAlignment);
                c1rpt.Watermark.PictureScale = TranslatePictureScaleEnum(rpt.PictureSizeMode);
            }

            //------------------------------------------------------------------------------------
            // save groups
            for (int i = 0; ; i++)
            {
                // get ith group
                Access.GroupLevel g = null;
                try
                {
                    g = rpt.get_GroupLevel(i);
                }
                catch {}
                if (g == null) break;
                string gname = string.Format("Group{0}", i + 1);
                Group c1g = c1rpt.Groups.Add(gname, string.Empty, SortEnum.NoSort); 

                c1g.GroupBy = TranslateExpression(g.ControlSource);

                // if we have a GroupOn and GroupInterval, apply the modifiers
                short groupOn = g.GroupOn;
                if (groupOn > 0)
                {
                    // get interval
                    int groupInterval = g.GroupInterval;

                    // apply modifier
                    switch (groupOn)
                    {
                        case 1: // Prefix
                            if (groupInterval < 1) groupInterval = 1;
                            c1g.GroupBy = string.Format("Left([{0}],{1})", c1g.GroupBy, groupInterval);
                            break;
                        case 2: // Year
                            c1g.GroupBy = string.Format("Year([{0}])", c1g.GroupBy);
                            break;
                        case 3: // Quarter
                            c1g.GroupBy = string.Format("DatePart(\"q\", [{0}])", c1g.GroupBy);
                            break;
                        case 9: // Interval
                            c1g.GroupBy = string.Format("Int([{0}]/{1})", c1g.GroupBy, groupInterval);
                            break;
                    }
                }

                // set group properties
                c1g.KeepTogether = (KeepTogetherEnum)g.KeepTogether;
                c1g.Sort = g.SortOrder? SortEnum.Descending: SortEnum.Ascending;
            }

            //------------------------------------------------------------------------------------
            // save sections
            int cnt = c1rpt.Sections.Count;
            for (int i = 0; i < cnt; i++) 
            {
                // get ith section
                Access._Section s = null;
                try
                {
                    s = rpt.get_Section(i);
                } 
                catch {}
                Section c1s = c1rpt.Sections[i];
                c1s.Visible = false;
                if (s == null) continue;

                // save section properties
                c1s.Name = s.Name;
                c1s.Height = s.Height;
                // disable warnings about using CanGrow/CanShrink:
#pragma warning disable CS0618
                try
                { c1s.Visible = s.Visible; }
                catch { }
                try
                { c1s.CanGrow = s.CanGrow; }
                catch { }
                try
                { c1s.CanShrink = s.CanShrink; }
                catch { }
                try
                { c1s.BackColor = ColorTranslator.FromOle(s.BackColor); }
                catch { }
                try
                { c1s.ForcePageBreak = (ForcePageBreakEnum)s.ForceNewPage; }
                catch { }
                try
                { if (s.NewRowOrCol != 0) c1s.ForcePageBreak = ForcePageBreakEnum.Before; }
                catch { }
                try
                { c1s.KeepTogether = s.KeepTogether; }
                catch { }
                try
                { c1s.Repeat = s.RepeatSection; }
                catch { }
#pragma warning restore CS0618

                // save section tag
                tag = s.Tag;
				if (tag != null && tag.Length > 0)
					c1s.Tag = tag;
            }

            //------------------------------------------------------------------------------------
            // save fields
            foreach (Access.Control ctl in rpt.Controls)
            {
                try
                {
                    SaveControl(rpt, c1rpt, ctl);
                }
                catch (Exception x)
                {
                    Debug.WriteLine(x.Message);
                }
            }

            //------------------------------------------------------------------------------------
            // set Section's CanGrow/CanShrink again in case a field messed it up
            cnt = c1rpt.Sections.Count;
            for (int i = 0; i < cnt; i++) 
            {
                try
                {
                    Access._Section s = rpt.get_Section(i);
                    Section c1s = c1rpt.Sections[i];
#pragma warning disable CS0618
                    c1s.CanGrow = s.CanGrow;
                    c1s.CanShrink = s.CanShrink;
#pragma warning restore CS0618
                }
                catch {}
            }

            //------------------------------------------------------------------------------------
            // done
            return true;
        }
        private void SaveControl(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
        {
            // get control-specific properties
            System.Reflection.PropertyInfo[] pi = ctl.GetType().GetProperties();
            if (pi != null && pi.Length > 0)
            {
                SaveControlReflection(rpt, c1rpt, ctl, pi);
            }
            else
            {
                SaveControlOriginal(rpt, c1rpt, ctl);
            }
        }
        private void SaveControlOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
        {
            var converter = AccessControlConverter.GetConverterOriginal(ctl);
            converter.SaveObjectOriginal(rpt, c1rpt, ctl);
        }
        private void SaveControlReflection(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl, System.Reflection.PropertyInfo[] pi)
        {
            var converter = AccessControlConverter.GetConverterReflection(ctl.GetType().Name);
            converter.SaveControlReflection(rpt, c1rpt, ctl, pi);

        }
        private static object GetValue(Access.Control ctl, System.Reflection.PropertyInfo[] piArr, string propertyName)
        {
            foreach (System.Reflection.PropertyInfo pi in piArr)
            {
                if (string.Compare(pi.Name, propertyName, true) == 0)
                {
                    return pi.GetValue(ctl, null);
                }
            }
            return null;
        }

	    private static DashStyle TranslateBorderStyle(byte accessValue)
	    {
	        switch (accessValue)
	        {
                case 0:
                    return DashStyle.None;
                case 1:
	                return DashStyle.Solid;
                case 2:
                case 3: 
                    return DashStyle.Dash;
                case 4:
                case 5:
	                return DashStyle.Dot;
                case 6:
                    return DashStyle.DashDot;
                case 7:
                    return DashStyle.DashDot;
                default:
	                return DashStyle.Solid;
	        }
	    }

	    private static int TranslateBorderWidth(byte accessValue)
	    {
	        return accessValue == 0 ? 15 : 20*accessValue;
	    }

	    private static AutoSizeBehavior TranslateCanGrowShrink(bool canGrow, bool canShrink)
	    {
	        var autoSize = AutoSizeBehavior.None;
            if(canGrow)autoSize|= AutoSizeBehavior.CanGrow;
            if(canShrink)autoSize|=AutoSizeBehavior.CanShrink;
	        return autoSize;
	    }

        // load bitmap image stored in Access property
        // ** REVIEW: this is a really sneaky/convoluted way to do it, but I couldn't find an
        // easier way to convert the Access binary image data into a real image...
        private static Image TranslateImage(Access.Application app, object picData)
        {
            byte[] bytes = picData as byte[];
            if (bytes == null) return null;

            // create image control
            // Set frm = g_msac.CreateForm
            // g_msac.DoCmd.OpenForm frm.Name, acViewDesign, "", "", acFormPropertySettings, acWindowNormal
            //Set img = g_msac.CreateControl(frm.Name, acImage, acDetail)
            Access.Form frm = app.CreateForm(null, null);
            app.DoCmd.OpenForm(frm.Name, Access.AcFormView.acDesign, string.Empty, string.Empty, Access.AcFormOpenDataMode.acFormPropertySettings, Access.AcWindowMode.acWindowNormal, null);
            object imgObject = app.CreateControl(frm.Name, Access.AcControlType.acImage, Access.AcSection.acDetail, null, null, null, null, null, null);
            if (imgObject == null)
            {
                return null;
            }

            // old-style object model
            Access.Image img = imgObject as Access.Image;
            if (img != null)
            {
                // copy image to image control
                img.PictureData = picData;

                // copy new control to the clipboard
                // TODO: review menu indices, try Access97
                app.DoCmd.DoMenuItem(3, 1, 7, null, 70);
                app.DoCmd.DoMenuItem(3, 1, 2, null, 70);
                //g_msac.DoCmd.DoMenuItem acFormDS, acEdit, 6, acMenuVer70        ' Form Design Bar, Edit, Select All
                //g_msac.DoCmd.DoMenuItem acFormDS, acEdit, acCopy, acMenuVer70   ' Form Design Bar, Edit, Copy

                // get image from the clipboard
                IDataObject data = Clipboard.GetDataObject();
                Bitmap bmp = data.GetData(typeof(Bitmap)) as Bitmap;

                // destroy temp form/control
                //g_msac.DoCmd.Close acForm, frm.Name, acSaveNo
                app.DoCmd.Close(Access.AcObjectType.acForm, frm.Name, Access.AcCloseSave.acSaveNo);
                Clipboard.SetDataObject(string.Empty);

                // return what we got
                return bmp;
            }

            // new style (got to use reflection)
            System.Reflection.PropertyInfo pi = imgObject.GetType().GetProperty("PictureData");
            if (pi != null)
            {
                pi.SetValue(imgObject, picData, null);
                app.DoCmd.DoMenuItem(3, 1, 7, null, 70);
                app.DoCmd.DoMenuItem(3, 1, 2, null, 70);
                IDataObject data = Clipboard.GetDataObject();
                Bitmap bmp = data.GetData(typeof(Bitmap)) as Bitmap;
                app.DoCmd.Close(Access.AcObjectType.acForm, frm.Name, Access.AcCloseSave.acSaveNo);
                Clipboard.SetDataObject(string.Empty);
                return bmp;
            }

            // failed...
            return null;
        }

        // translate enumerations
        private static FieldAlignEnum TranslateAlignEnum(int l)
        {
            switch (l) 
            {
                case 1: return FieldAlignEnum.LeftTop;
                case 2: return FieldAlignEnum.CenterTop;
                case 3: return FieldAlignEnum.RightTop;
                case 4: return FieldAlignEnum.JustTop;
            }
            return FieldAlignEnum.General;
        }
        private static PictureAlignEnum TranslatePictureAlignEnum(int lPicAlign)
        {
            switch (lPicAlign)
            {
                case 0:
                    return PictureAlignEnum.LeftTop;
                case 1:
                    return PictureAlignEnum.RightTop;
                case 2:
                    return PictureAlignEnum.CenterMiddle;
                case 3:
                    return PictureAlignEnum.LeftBottom;
                case 4:
                    return PictureAlignEnum.RightBottom;
                default:
                    return PictureAlignEnum.LeftTop;
            }
        }
        private static PictureScaleEnum TranslatePictureScaleEnum(int lSizeMode)
        {
            switch (lSizeMode)
            {
                case 0:
                    return PictureScaleEnum.Clip;
                case 1:
                    return PictureScaleEnum.Stretch;
                case 3:
                    return PictureScaleEnum.Scale;
                default:
                    return PictureScaleEnum.Scale; // is this right?.Zoom;
            }
        }
        private static WatermarkVisibility TranslateWatermarkVisibility(long l)
        {
            switch (l)
            {
                case 0: return WatermarkVisibility.AllPages;
                case 1: return WatermarkVisibility.FirstPage;
                case 2: return WatermarkVisibility.Hidden;
            }
            return WatermarkVisibility.AllPages;
        }

        // translate RecordSource QueryDefs into SQL
        private static string TranslateQueryDef(Access.Report rpt)
        {
			// get raw RecordSource
			string rs = rpt.RecordSource;

			// empty? don't even try it...
			if (rs == null || rs.Length == 0)
				return string.Empty;

			// translate QueryDefs (DAO only, may throw)
			try
			{
				DAO.Database db = rpt.Application.CurrentDb();
				if (db != null)
				{
					DAO.QueryDef qd = db.QueryDefs[rs];
					if (qd != null) rs = qd.SQL;
				}
			}
			catch {}

            // remove any references to forms
            string lower = rs.ToLower();
            if (lower.IndexOf("forms!") > -1 || lower.IndexOf("[forms]") > -1)
            {
                RX.RegexOptions opt = RX.RegexOptions.IgnoreCase | RX.RegexOptions.Multiline;
                rs = RX.Regex.Replace(rs, @"(forms|\[forms\])!\[[^\]]*\]!", string.Empty, opt);
            }

            // done
            return TranslateExpression(rs);
        }

        // translate expressions into VBScript:
        // 1: "* IS NULL"     --> "isnull(*)"
        // 2: "* IS NOT NULL" --> "not isnull(*)"
        // 3: "Year"          --> "TheYear" (to import nwind correctly)
        static string TranslateExpression(string str, bool checkExpressionPrefix = false)
        {
            string[] strRegex = 
            {
                // find																// replace
                //----------------------------------------------------------------------------------------
                //(   (expr)   |   var   |  [brk var] )
                "(\\([^()]+\\)|[\\w\\.]+|\\[[^()]+\\])\\s+IS\\s+(NOT\\s+|)NULL",	"$2IsNull($1)",
                "(^|\\W)Year($|\\W)",												"$1TheYear$2",
            };

            // use regexp only when we have to
            string lower = str.ToLower();
            if (lower.IndexOf("null") > -1 || lower.IndexOf("year") > -1)
            {
                RX.RegexOptions opt = RX.RegexOptions.IgnoreCase | RX.RegexOptions.Multiline;
                for (int i = 0; i < strRegex.Length; i += 2)
                    str = RX.Regex.Replace(str, strRegex[i], strRegex[i+1], opt);
            }

            // bracket fields with embedded delimiters
            if (str.IndexOf(' ') > -1 || str.IndexOf('.') > -1)
            {
                char[] delims = "[]()+-*/,=".ToCharArray();
                if (str.IndexOfAny(delims) < 0)
                    str = "[" + str + "]";
            }

            if (checkExpressionPrefix && str.Length > 0 && str[0] != '=')
                str = "=" + str;

            // done
            return str;
        }

        /// <summary>
        /// PRTMIP is the structure used by Access to store page layout information
        /// </summary>
        private struct PRTMIP
        {
            internal int xLeftMargin;
            internal int yTopMargin;
            internal int xRightMargin;
            internal int yBotMargin;
            internal int fDataOnly;
            internal int xWidth;
            internal int yHeight;
            internal int fDefaultSize;
            internal int cxColumns;
            internal int yColumnSpacing;
            internal int xRowSpacing;
            internal int rItemLayout;
            internal int fFastPrint;
            internal int fDatasheet;
            internal PRTMIP(byte[] data)
            {
                MemoryStream ms = new MemoryStream(data);
                BinaryReader br = new BinaryReader(ms);
                xLeftMargin    = br.ReadInt32();
                yTopMargin     = br.ReadInt32();
                xRightMargin   = br.ReadInt32();
                yBotMargin     = br.ReadInt32();
                fDataOnly      = br.ReadInt32();
                xWidth         = br.ReadInt32();
                yHeight        = br.ReadInt32();
                fDefaultSize   = br.ReadInt32();
                cxColumns      = br.ReadInt32();
                yColumnSpacing = br.ReadInt32();
                xRowSpacing    = br.ReadInt32();
                rItemLayout    = br.ReadInt32();
                fFastPrint     = br.ReadInt32();
                fDatasheet     = br.ReadInt32();
                ms.Close();
            }
        }

	    private abstract class AccessControlConverter
	    {
            public static AccessControlConverter GetConverterOriginal(Access.Control accessControl)
	        {
                if(accessControl is Access.Label)
                    return new LabelControlConverter();
                if(accessControl is Access.TextBox)
                    return new TextControlConverter();
                if(accessControl is Access.Line)
                    return new LineControlConverter();
                if(accessControl is Access.Rectangle)
                    return new RectangleControlConverter();
                if(accessControl is Access.Image)
                    return new ImageControlConverter();
                if(accessControl is Access.BoundObjectFrame)
                    return new BoundObjectFrameControlConverter();
                if(accessControl is Access.ObjectFrame)
                    return new ObjectFrameControlConverter();
                if(accessControl is Access.CheckBox)
                    return new CheckBoxControlConverter();
                if(accessControl is Access.OptionButton)
                    return new OptionButtonControlConverter();
                if(accessControl is Access.PageBreak)
                    return new PageBreakControlConverter();
	            if (accessControl is Access.SubForm)
	                return new SubFormControlConverter();

	            return new UnsupportedControlConverter();
	        }

	        public static AccessControlConverter GetConverterReflection(string typename)
	        {
	            if (typename.IndexOf("Label") > -1)
	                return new LabelControlConverter();
	            if (typename.IndexOf("TextBox") > -1)
	                return new TextControlConverter();
	            if (typename.IndexOf("Line") > -1)
	                return new LineControlConverter();
	            if (typename.IndexOf("Rectangle") > -1)
	                return new RectangleControlConverter();
	            if (typename.IndexOf("Image") > -1)
	                return new ImageControlConverter();
	            if (typename.IndexOf("BoundObjectFrame") > -1)
	                return new BoundObjectFrameControlConverter();
	            if (typename.IndexOf("ObjectFrame") > -1)
	                return new ObjectFrameControlConverter();
	            if (typename.IndexOf("CheckBox") > -1)
	                return new CheckBoxControlConverter();
	            if (typename.IndexOf("OptionButton") > -1)
	                return new OptionButtonControlConverter();
	            if (typename.IndexOf("PageBreak") > -1)
	                return new PageBreakControlConverter();
	            if (typename.IndexOf("SubForm") > -1)
	                return new SubFormControlConverter();

	            return new UnsupportedControlConverter();
	        }

	        public abstract void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl);

	        public void SaveControlReflection(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl,
	            System.Reflection.PropertyInfo[] pi)
	        {
	            var c1f = CreateFieldReflection(ctl, pi);
	            c1rpt.Fields.Add(c1f);

                SaveControlReflectionInternal(rpt, c1f, ctl, pi);
	        }

	        protected virtual bool SaveBorder
	        {
	            get { return true; }
	        }

            protected abstract FieldBase CreateFieldReflection(Access.Control ctl, PropertyInfo[] pi);

            protected virtual void SaveControlReflectionInternal(Access.Report rpt, FieldBase flexField, Access.Control ctl, System.Reflection.PropertyInfo[] pi)
            {
                var c1f = flexField;
                c1f.Name = (string)GetValue(ctl, pi, "Name");
                c1f.Section = (SectionTypeEnum)(short)GetValue(ctl, pi, "Section");
                c1f.Tag = (string)GetValue(ctl, pi, "Tag");
                c1f.Left = (short)GetValue(ctl, pi, "Left");
                c1f.Top = (short)GetValue(ctl, pi, "Top");
                c1f.Visible = (bool)GetValue(ctl, pi, "Visible");

                // set width/height (pagebreak fields don't have this)
                if (GetValue(ctl, pi, "Width") != null)
                {
                    c1f.Width = (short)GetValue(ctl, pi, "Width");
                    c1f.Height = (short)GetValue(ctl, pi, "Height");
                }
                else
                {
                    c1f.Width = 300;
                    c1f.Height = 50;
                }

                // set font
                if (GetValue(ctl, pi, "FontName") != null)
                {
                    if (c1f is TextFieldBase)
                    {
                        var textField = (TextFieldBase) c1f;
                        SaveFont(textField.Font, ctl, pi);
                        textField.Align = TranslateAlignEnum((byte)GetValue(ctl, pi, "TextAlign"));
                    }
                    else if (c1f is Field)
                    {
                        var field = (Field) c1f;
                        SaveFont(field.Font, ctl, pi);
                        field.Align = TranslateAlignEnum((byte)GetValue(ctl, pi, "TextAlign"));
                    }
                }

                // set margins
                if (GetValue(ctl, pi, "LeftMargin") != null)
                {
                    c1f.MarginLeft = (short)GetValue(ctl, pi, "LeftMargin");
                    c1f.MarginRight = (short)GetValue(ctl, pi, "RightMargin");
                    c1f.MarginTop = (short)GetValue(ctl, pi, "TopMargin");
                    c1f.MarginBottom = (short)GetValue(ctl, pi, "BottomMargin");
                    //c1f.LineSpacing = ConvertLineSpacing((short)GetValue(ctl, pi, "LineSpacing"), c1f.Font.Font);
                }

                // set border
                if (SaveBorder && GetValue(ctl, pi, "BorderStyle") != null)
                {
                    c1f.Border.Style = TranslateBorderStyle((byte) GetValue(ctl, pi, "BorderStyle"));
                    c1f.Border.Color = ColorTranslator.FromOle((int)GetValue(ctl, pi, "BorderColor"));
                    c1f.Border.Width = TranslateBorderWidth((byte) GetValue(ctl, pi, "BorderWidth"));
                }

                // set fore/back colors
                if (GetValue(ctl, pi, "ForeColor") != null)
                {
                    if(c1f is TextFieldBase)
                        ((TextFieldBase)c1f).ForeColor = ColorTranslator.FromOle((int)GetValue(ctl, pi, "ForeColor"));
                    else if(c1f is Field)
                        ((Field)c1f).ForeColor = ColorTranslator.FromOle((int)GetValue(ctl, pi, "ForeColor"));
                }
                if (GetValue(ctl, pi, "BackColor") != null)
                {
                    c1f.BackColor = ColorTranslator.FromOle((int)GetValue(ctl, pi, "BackColor"));
                    if ((byte)GetValue(ctl, pi, "BackStyle") == 0)
                    {
                        c1f.BackColor = Color.Transparent;
                    }
                }

                // set cangrow/canshrink
                if (GetValue(ctl, pi, "CanGrow") != null)
                {
                    var canGrow = (bool)GetValue(ctl, pi, "CanGrow");
                    var canShrink = (bool)GetValue(ctl, pi, "CanShrink");
                    c1f.AutoHeight = TranslateCanGrowShrink(canGrow, canShrink);
                }

                try
                {
                    var hyperlink = (string) GetValue(ctl, pi, "HyperlinkAddress");
                    if (!string.IsNullOrEmpty(hyperlink))
                        c1f.Hyperlink.LinkTarget = new ReportLinkTargetUrl(hyperlink);
                }
                catch
                {
                }
            }

	        private void SaveFont(FontHolder font, Access.Control ctl, PropertyInfo[] pi)
	        {
	            font.Name = (string) GetValue(ctl, pi, "FontName");
	            font.Size = (short) GetValue(ctl, pi, "FontSize");
	            font.Bold = (short) GetValue(ctl, pi, "FontBold") != 0;
	            font.Italic = (bool) GetValue(ctl, pi, "FontItalic");
	            font.Underline = (bool) GetValue(ctl, pi, "FontUnderline");
	        }
	    }

	    private class UnsupportedControlConverter : AccessControlConverter
	    {
	        public override void SaveObjectOriginal(Report rpt, C1FlexReport c1rpt, Control ctl)
	        {
                Console.WriteLine("*** UNTRANSLATED FIELD: {0}", ctl.GetType().ToString());
	        }

            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
	        {
	            return new TextField();
	        }

	        protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
	        {
	            base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

	            var c1f = flexField as TextField;
                Console.WriteLine("*** UNTRANSLATED FIELD: {0}", ctl.GetType().ToString());
	        }
	    }

	    private class LabelControlConverter : AccessControlConverter
	    {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                return new TextField();
            }

            protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

                var c1f = flexField as TextField;
                c1f.Text = (string)GetValue(ctl, pi, "Caption");
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
	        {
                Access.Label f = ctl as Access.Label;
                //Console.WriteLine("Label " + f.Name);
                var c1f = new TextField { Name = f.Name, Text = f.Caption };
                c1rpt.Fields.Add(c1f);
                c1f.Section = (SectionTypeEnum)f.Section;
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;

                c1f.ForeColor = ColorTranslator.FromOle(f.ForeColor);
                c1f.BackColor = ColorTranslator.FromOle(f.BackColor);
                //c1f.BackStyle = (BackStyleEnum)f.BackStyle;
                if (f.BackStyle == 0)
                    c1f.BackColor = Color.Transparent;
                c1f.Font.Name = f.FontName;
                c1f.Font.Size = f.FontSize;
                c1f.Font.Bold = f.FontBold != 0;
                c1f.Font.Italic = f.FontItalic;
                c1f.Font.Underline = f.FontUnderline;
                c1f.Align = TranslateAlignEnum(f.TextAlign);

                c1f.MarginLeft = f.LeftMargin;
                c1f.MarginRight = f.RightMargin;
                c1f.MarginTop = f.TopMargin;
                c1f.MarginBottom = f.BottomMargin;
                //c1f.LineSpacing = ConvertLineSpacing(f.LineSpacing, c1f.Font.Font);

                c1f.Border.Style = TranslateBorderStyle(f.BorderStyle);
                c1f.Border.Color = ColorTranslator.FromOle(f.BorderColor);
                c1f.Border.Width = c1f.Border.Width = TranslateBorderWidth(f.BorderWidth);

                try { ((ReportLinkTargetUrl)c1f.Hyperlink.LinkTarget).Url.Value = f.HyperlinkAddress; }
                catch { }
	        }
	    }

	    private class TextControlConverter : AccessControlConverter
	    {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                // the reference of report TextField in expression has problem,
                // use legacy Field instead.
                //return UseLegacyField(ctl, pi) ? (FieldBase) new Field() : new TextField();
                return new Field();
            }

            protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

                if (flexField is TextField)
                    SaveControlReflectionInternalTextField((TextField)flexField, ctl, pi);
                else if (flexField is Field)
                    SaveControlReflectionInternalLegacyField((Field)flexField, ctl, pi);
            }

	        private void SaveControlReflectionInternalLegacyField(Field c1f, Access.Control ctl, PropertyInfo[] pi)
	        {
                c1f.Text = TranslateExpression((string)GetValue(ctl, pi, "ControlSource"));
                c1f.Calculated = true;
                c1f.RunningSum = (RunningSumEnum)(byte)GetValue(ctl, pi, "RunningSum");
                object v = GetValue(ctl, pi, "HideDuplicates");
                if (v is bool)
                    c1f.HideDuplicates = (bool)v;
                c1f.Format = (string)GetValue(ctl, pi, "Format");
	        }

            private void SaveControlReflectionInternalTextField(TextField c1f, Access.Control ctl, PropertyInfo[] pi)
            {
                c1f.Text = TranslateExpression((string)GetValue(ctl, pi, "ControlSource"), true);
                c1f.Format = (string)GetValue(ctl, pi, "Format");
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
	        {
                Access.TextBox f = ctl as Access.TextBox;
                //Console.WriteLine("TextBox " + f.Name);
	            
	            // the reference of report TextField in expression has problem,
                // use legacy Field instead.
                //var field = UseLegacyField(f) ? ConvertToLegacyField(f) : ConvertToTextField(f);
                var field = ConvertToLegacyField(f);

                c1rpt.Fields.Add(field);
	            field.Section = (SectionTypeEnum) f.Section;
	        }

	        private FieldBase ConvertToLegacyField(Access.TextBox f)
	        {
                var c1f = new Field { Name = f.Name };
                c1f.Text = TranslateExpression(f.ControlSource);
                c1f.RunningSum = (RunningSumEnum)f.RunningSum;
                c1f.Calculated = true;
                c1f.Format = f.Format;
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;
#pragma warning disable CS0618
                c1f.CanGrow = f.CanGrow;
                c1f.CanShrink = f.CanShrink;
#pragma warning restore CS0618
                c1f.HideDuplicates = f.HideDuplicates;

                c1f.ForeColor = ColorTranslator.FromOle(f.ForeColor);
                c1f.BackColor = ColorTranslator.FromOle(f.BackColor);
                //c1f.BackStyle = (BackStyleEnum)f.BackStyle;
                if (f.BackStyle == 0)
                    c1f.BackColor = Color.Transparent;
                c1f.Font.Name = f.FontName;
                c1f.Font.Size = f.FontSize;
                c1f.Font.Bold = f.FontBold != 0;
                c1f.Font.Italic = f.FontItalic;
                c1f.Font.Underline = f.FontUnderline;
                c1f.Align = TranslateAlignEnum(f.TextAlign);

                c1f.MarginLeft = f.LeftMargin;
                c1f.MarginRight = f.RightMargin;
                c1f.MarginTop = f.TopMargin;
                c1f.MarginBottom = f.BottomMargin;
                //c1f.LineSpacing = ConvertLineSpacing(f.LineSpacing, c1f.Font.Font);

                c1f.Border.Style = TranslateBorderStyle(f.BorderStyle);
                c1f.Border.Color = ColorTranslator.FromOle(f.BorderColor);
	            c1f.Border.Width = c1f.Border.Width = TranslateBorderWidth(f.BorderWidth);

	            return c1f;
	        }

	        private FieldBase ConvertToTextField(Access.TextBox f)
	        {
                var c1f = new TextField { Name = f.Name };
                c1f.Text = TranslateExpression(f.ControlSource, true);
                c1f.Format = f.Format;
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;
	            c1f.AutoHeight = TranslateCanGrowShrink(f.CanGrow, f.CanShrink);
                
                c1f.ForeColor = ColorTranslator.FromOle(f.ForeColor);
                c1f.BackColor = ColorTranslator.FromOle(f.BackColor);
                //c1f.BackStyle = (BackStyleEnum)f.BackStyle;
                if (f.BackStyle == 0)
                    c1f.BackColor = Color.Transparent;
                c1f.Font.Name = f.FontName;
                c1f.Font.Size = f.FontSize;
                c1f.Font.Bold = f.FontBold != 0;
                c1f.Font.Italic = f.FontItalic;
                c1f.Font.Underline = f.FontUnderline;
                c1f.Align = TranslateAlignEnum(f.TextAlign);

                c1f.MarginLeft = f.LeftMargin;
                c1f.MarginRight = f.RightMargin;
                c1f.MarginTop = f.TopMargin;
                c1f.MarginBottom = f.BottomMargin;
                //c1f.LineSpacing = ConvertLineSpacing(f.LineSpacing, c1f.Font.Font);

                c1f.Border.Style = TranslateBorderStyle(f.BorderStyle);
                c1f.Border.Color = ColorTranslator.FromOle(f.BorderColor);
	            c1f.Border.Width = c1f.Border.Width = TranslateBorderWidth(f.BorderWidth);

	            return c1f;
	        }

	        private bool UseLegacyField(Access.TextBox f)
	        {
	            return f.RunningSum != 0 || f.HideDuplicates;
	        }

            private bool UseLegacyField(Access.Control ctl, PropertyInfo[] pi)
            {
                var runningSum = (byte)GetValue(ctl, pi, "RunningSum");
                var hideDuplicates = false;
                object vHideDuplicates = GetValue(ctl, pi, "HideDuplicates");
                if (vHideDuplicates is bool)
                    hideDuplicates = (bool)vHideDuplicates;
                return runningSum != 0 || hideDuplicates;
            }
	    }

	    private class LineControlConverter : AccessControlConverter
	    {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                return new ShapeField();
            }

	        protected override bool SaveBorder
	        {
	            get { return false; }
	        }

	        protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

                var c1f = flexField as ShapeField;
                c1f.ShapeType = ShapeType.Line;
                c1f.Shape = new LineShape((bool)GetValue(ctl, pi, "LineSlant") ? LineSlantEnum.Up : LineSlantEnum.Down);
                if (GetValue(ctl, pi, "BorderStyle") != null)
                {
                    c1f.Line.Style = TranslateBorderStyle((byte)GetValue(ctl, pi, "BorderStyle"));
                    c1f.Line.Color = ColorTranslator.FromOle((int)GetValue(ctl, pi, "BorderColor"));
                    c1f.Line.Width = TranslateBorderWidth((byte) GetValue(ctl, pi, "BorderWidth"));
                }
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
	        {
                Access.Line f = ctl as Access.Line;
                //Console.WriteLine("Line " + f.Name);
	            var c1f = new ShapeField() {Name = f.Name};
	            c1rpt.Fields.Add(c1f);
                c1f.Section = (SectionTypeEnum)f.Section;
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;

                c1f.ShapeType = ShapeType.Line;
                c1f.Line.Style = TranslateBorderStyle(f.BorderStyle);
                c1f.Line.Color = ColorTranslator.FromOle(f.BorderColor);
                c1f.Line.Width = TranslateBorderWidth(f.BorderWidth);
                c1f.Shape = new LineShape(f.LineSlant ? LineSlantEnum.Up : LineSlantEnum.Down);
	        }
	    }

	    private class RectangleControlConverter : AccessControlConverter
	    {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                return new ShapeField();
            }

	        protected override bool SaveBorder
	        {
	            get { return false; }
	        }

	        protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

	            var c1f = flexField as ShapeField;
                c1f.ShapeType = ShapeType.Rectangle;
                if (GetValue(ctl, pi, "BorderStyle") != null)
                {
                    c1f.Line.Style = TranslateBorderStyle((byte)GetValue(ctl, pi, "BorderStyle"));
                    c1f.Line.Color = ColorTranslator.FromOle((int)GetValue(ctl, pi, "BorderColor"));
                    c1f.Line.Width = TranslateBorderWidth((byte) GetValue(ctl, pi, "BorderWidth"));
                }
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
	        {
                Access.Rectangle f = ctl as Access.Rectangle;
                //Console.WriteLine("Rectangle " + f.Name);
	            var c1f = new ShapeField() {Name = f.Name};
	            c1rpt.Fields.Add(c1f);
                c1f.Section = (SectionTypeEnum)f.Section;
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;

                c1f.BackColor = ColorTranslator.FromOle(f.BackColor);
                //c1f.BackStyle = (BackStyleEnum)f.BackStyle;
                if (f.BackStyle == 0)
                    c1f.BackColor = Color.Transparent;

                c1f.ShapeType = ShapeType.Rectangle;
                c1f.Line.Style = TranslateBorderStyle(f.BorderStyle);
                c1f.Line.Color = ColorTranslator.FromOle(f.BorderColor);
                c1f.Line.Width = TranslateBorderWidth(f.BorderWidth);
	        }
	    }

        private class ImageControlConverter : AccessControlConverter
        {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                return new ImageField();
            }

            protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

                var c1f = flexField as ImageField;
                c1f.Picture = TranslateImage(ctl.Application, GetValue(ctl, pi, "PictureData"));
                c1f.PictureAlign = TranslatePictureAlignEnum((byte)GetValue(ctl, pi, "PictureAlignment"));
                c1f.PictureScale = TranslatePictureScaleEnum((byte)GetValue(ctl, pi, "SizeMode"));
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
            {
                Access.Image f = ctl as Access.Image;
                //Console.WriteLine("Image " + f.Name);
                var c1f = new ImageField() {Name = f.Name};
                c1rpt.Fields.Add(c1f);
                c1f.Section = (SectionTypeEnum)f.Section;
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;

                c1f.BackColor = ColorTranslator.FromOle(f.BackColor);
                //c1f.BackStyle = (BackStyleEnum)f.BackStyle;
                if (f.BackStyle == 0)
                    c1f.BackColor = Color.Transparent;
                c1f.Border.Style = TranslateBorderStyle(f.BorderStyle);
                c1f.Border.Color = ColorTranslator.FromOle(f.BorderColor);
                c1f.Border.Width = TranslateBorderWidth(f.BorderWidth);

                c1f.Picture = TranslateImage(rpt.Application, f.PictureData);
                c1f.PictureAlign = TranslatePictureAlignEnum(f.PictureAlignment);
                c1f.PictureScale = TranslatePictureScaleEnum(f.SizeMode);
            }
        }

        private class BoundObjectFrameControlConverter : AccessControlConverter
        {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                return new ImageField();
            }

            protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

                var c1f = flexField as ImageField;
                c1f.Picture = TranslateExpression((string)GetValue(ctl, pi, "ControlSource"), true);
                c1f.PictureAlign = TranslatePictureAlignEnum(0);
                c1f.PictureScale = TranslatePictureScaleEnum((byte)GetValue(ctl, pi, "SizeMode"));
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
            {
                Access.BoundObjectFrame f = ctl as Access.BoundObjectFrame;
                //Console.WriteLine("BoundObjectFrame " + f.Name);
                var c1f = new ImageField() {Name = f.Name};
                c1rpt.Fields.Add(c1f);
                c1f.Section = (SectionTypeEnum)f.Section;
                c1f.Picture = TranslateExpression(f.ControlSource, true);
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;

                c1f.BackColor = ColorTranslator.FromOle(f.BackColor);
                //c1f.BackStyle = (BackStyleEnum)f.BackStyle;
                if (f.BackStyle == 0)
                    c1f.BackColor = Color.Transparent;
                c1f.Border.Style = TranslateBorderStyle(f.BorderStyle);
                c1f.Border.Color = ColorTranslator.FromOle(f.BorderColor);
                c1f.Border.Width = TranslateBorderWidth(f.BorderWidth);

                c1f.PictureAlign = TranslatePictureAlignEnum(0);
                c1f.PictureScale = TranslatePictureScaleEnum(f.SizeMode);
            }
        }

        private class ObjectFrameControlConverter : AccessControlConverter
        {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                return new TextField();
            }

            protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

                var c1f = flexField as TextField;
                c1f.Align = FieldAlignEnum.CenterMiddle;
                c1f.Text = string.Format("** Untranslated ObjectFrame: {0} **", c1f.Name);
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
            {
                Access.ObjectFrame f = ctl as Access.ObjectFrame;
                var c1f = new TextField() {Name = f.Name};
                c1rpt.Fields.Add(c1f);
                c1f.Section = (SectionTypeEnum)f.Section;
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;

                c1f.BackColor = ColorTranslator.FromOle(f.BackColor);
                //c1f.BackStyle = (BackStyleEnum)f.BackStyle;
                if (f.BackStyle == 0)
                    c1f.BackColor = Color.Transparent;
                c1f.Border.Style = TranslateBorderStyle(f.BorderStyle);
                c1f.Border.Color = ColorTranslator.FromOle(f.BorderColor);
                c1f.Border.Width = TranslateBorderWidth(f.BorderWidth);

                c1f.Align = FieldAlignEnum.CenterMiddle;
                c1f.Text = "** Untranslated ObjectFrame: " + f.Name + " **";
            }
        }

        private class CheckBoxControlConverter : AccessControlConverter
        {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                return new CheckBoxField();
            }

            protected override bool SaveBorder
            {
                get { return false; }
            }

            protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

                var c1f = flexField as CheckBoxField;
                c1f.Value = TranslateExpression((string) GetValue(ctl, pi, "ControlSource"), true);
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
            {
                Access.CheckBox f = ctl as Access.CheckBox;
                //Console.WriteLine("CheckBox " + f.Name);
                var c1f = new CheckBoxField() {Name = f.Name, Value = TranslateExpression(f.ControlSource, true)};
                c1rpt.Fields.Add(c1f);
                c1f.Section = (SectionTypeEnum)f.Section;
                c1f.Tag = f.Tag;
                
                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;
            }
        }

        private class OptionButtonControlConverter : AccessControlConverter
        {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                return new Field();
            }

            protected override bool SaveBorder
            {
                get { return false; }
            }

            protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl,
                PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

                var c1f = flexField as Field;
                c1f.Text = TranslateExpression((string) GetValue(ctl, pi, "ControlSource"));
                c1f.Calculated = true;
                c1f.CheckBox = CheckBoxEnum.RadioButton;
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
            {
                Access.OptionButton f = ctl as Access.OptionButton;
                //Console.WriteLine("OptionButton " + f.Name);
                var c1f = new Field() {Name = f.Name};
                c1rpt.Fields.Add(c1f);
                c1f.Section = (SectionTypeEnum)f.Section;
                c1f.Text = TranslateExpression(f.ControlSource);
                c1f.Calculated = true;
                c1f.CheckBox = CheckBoxEnum.RadioButton;
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;
            }
        }

	    private class PageBreakControlConverter : AccessControlConverter
	    {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                return new TextField();
            }

	        protected override bool SaveBorder
	        {
	            get { return false; }
	        }

	        protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

                flexField.ForcePageBreak = ForcePageBreakEnum.Before;
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
	        {
	            Access.PageBreak f = ctl as Access.PageBreak;
                //Console.WriteLine("PageBreak " + f.Name);
                var c1f = new TextField() {Name = f.Name};
                c1rpt.Fields.Add(c1f);
                c1f.Section = (SectionTypeEnum)f.Section;
                c1f.ForcePageBreak = ForcePageBreakEnum.Before;
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = 300;
                c1f.Height = 50;
                c1f.Visible = f.Visible;
	        }
	    }

	    private class SubFormControlConverter : AccessControlConverter
        {
            protected override FieldBase CreateFieldReflection(Control ctl, PropertyInfo[] pi)
            {
                return new SubreportField();
            }

            protected override void SaveControlReflectionInternal(Report rpt, FieldBase flexField, Control ctl, PropertyInfo[] pi)
            {
                base.SaveControlReflectionInternal(rpt, flexField, ctl, pi);

                var c1f = flexField as SubreportField;

                // get subreport name
                string str = (string)GetValue(ctl, pi, "SourceObject");
                if (!string.IsNullOrEmpty(str))
                {
                    SaveSubreportName(c1f, str);

                    // get subreport child/master fields
                    string strChild = (string)GetValue(ctl, pi, "LinkChildFields");
                    string strMaster = (string)GetValue(ctl, pi, "LinkMasterFields");
                    SaveSubreportFilter(c1f, strChild, strMaster);
                }
            }

            public override void SaveObjectOriginal(Access.Report rpt, C1FlexReport c1rpt, Access.Control ctl)
            {
                Access.SubForm f = ctl as Access.SubForm;
                //Console.WriteLine("SubForm " + f.Name);
                var c1f = new SubreportField() {Name = f.Name};
                c1rpt.Fields.Add(c1f);
                c1f.Section = (SectionTypeEnum)f.Section;
                c1f.Tag = f.Tag;

                c1f.Left = f.Left;
                c1f.Top = f.Top;
                c1f.Width = f.Width;
                c1f.Height = f.Height;
                c1f.Visible = f.Visible;
                c1f.AutoHeight = TranslateCanGrowShrink(f.CanGrow, f.CanShrink);

                c1f.Border.Style = TranslateBorderStyle(f.BorderStyle);
                c1f.Border.Color = ColorTranslator.FromOle(f.BorderColor);
                c1f.Border.Width = TranslateBorderWidth(f.BorderWidth);

                // get subreport name
                string str = f.SourceObject;
                if (!string.IsNullOrEmpty(str))
                {
                    SaveSubreportName(c1f, str);
                    
                    // get subreport child/master fields
                    string strChild = f.LinkChildFields;
                    string strMaster = f.LinkMasterFields;
                    SaveSubreportFilter(c1f, strChild, strMaster);
                }
            }

	        private void SaveSubreportName(SubreportField c1f, string subreportName)
	        {
	            // trim report name
	            if (subreportName.StartsWith("Report."))
	                subreportName = subreportName.Substring(7);
	            else
	            {
	                // for other languages, like "报表."
	                var index = subreportName.IndexOf('.');
	                if (index > -1)
	                    subreportName = subreportName.Substring(index + 1);
	            }

                // append subreport name to field name
                // (to resolve later, since subreport may not have been loaded yet)
                // use \b as a marker to find the field later
                c1f.Name = string.Format("{0}\b{1}", c1f.Name, subreportName);
	        }

	        private void SaveSubreportFilter(SubreportField c1f, string linkChildFields, string linkMasterFields)
	        {
	            if (string.IsNullOrEmpty(linkChildFields) || string.IsNullOrEmpty(linkMasterFields))
	                return;

	            // build subreport filter
	            // this results in an expression such as:
	            // "[ChildField] = '" & [MasterField] & "'"
	            var filter = string.Empty;
	            string[] strChildArr = linkChildFields.Split(';');
	            string[] strMasterArr = linkMasterFields.Split(';');
	            int cnt = Math.Min(strChildArr.Length, strMasterArr.Length);
	            for (int i = 0; i < cnt; i++)
	            {
	                // extract a child/master pair
	                string childField = TranslateExpression(strChildArr[i]);
	                string masterField = TranslateExpression(strMasterArr[i]);

	                // add this child/master pair to filter expression
	                if (filter.Length > 0) filter += " & \" And \" & ";
	                filter += string.Format("\"{0} = '\" & {1} & \"'\"", childField, masterField);
	            }

	            // assign subreport filter to field
	            c1f.SubreportFilter = "=" + filter;
	        }
        }
	}
}
