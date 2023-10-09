//----------------------------------------------------------------------------
// ReportWizard.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;

// using C1.C1Report;
using FlexReportDesignerApp.Util;
using C1.Win.FlexReport;

namespace FlexReportDesignerApp
{
    public enum ReportWizardResult
    {
        Preview,
        Design,
        Cancel
    }

    /// <summary>
    /// Summary description for ReportWizard.
    /// </summary>
    public partial class ReportWizard : System.Windows.Forms.Form
    {
        // parent form
        MainForm _owner;

        // field offset from the left
        const int FIELD_OFFSET = 50;
        private DataSourcePicker _dsPicker;

        public ReportWizard()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        public ReportWizard(
            MainForm owner)
            : this()
        {
            AutoScaleMode = AutoScaleMode.None;
            Font = MainForm.DefaultAppFont;

            // save reference to owner form
            _owner = owner;

            // group report layout buttons into flat and grouped vectors
            // ** these buttons should always be the same size **
            _btnsGrp = new RadioButton[] { _btnStepped, _btnOutline, _btnAligned };
            _btnsFlat = new RadioButton[] { _btnColumnar, _btnTabular, _btnJustified };
        }

        // ** fields
        private C1FlexReport _rpt;           // the report we're creating
        private DataSourceInfo _schema;        // detailed field info
        private ArrayList _fieldList;     // field templates
        private RadioButton[] _btnsGrp;		// { _btnStepped, _btnOutline, _btnAligned };
        private RadioButton[] _btnsFlat;		// { _btnColumnar, _btnTabular, _btnJustified };

        // ** constants
        private const int DRAG_THRESHOLD = 2;
        private const int DEFCHARCOUNT = 10;
        private const int DEFFIELDHEIGHT = 280;
        private const int MAXFIELDWIDTH = 1440 * 2;
        private const int MAXFIELDHEIGHT = 1440 * 2;
        private const int OUTLINEINDENT = 500;
        private const int STEPINDENT = 1000;

        // ** object model

        new public ReportWizardResult ShowDialog()
        {
            return ShowDialog(DataProvider.OLEDB, null, null, null);
        }

        public ReportWizardResult ShowDialog(DataProvider dataProvider, string conn, string rs, Hashtable htSchema)
        {
            // initialize data picker control
            _dsPicker.DataSchema = htSchema;
            _dsPicker.DataSource = null;

            // initialize members
            _dsPicker.SetDataSource(dataProvider, conn, rs);
            //_dsPicker.ConnectionString = conn;
            //_dsPicker.RecordSource = rs;

            // hide splash screen if it's on:
            //if (_owner != null)
            //    _owner.OnSplashOff();

            // show dialog as usual
            DialogResult dr = base.ShowDialog(_owner);
            // cancel if user pressed top right X (new in FlexReport):
            if (dr == System.Windows.Forms.DialogResult.Cancel)
                _rpt = null;

            // return custom result
            if (_rpt == null)
                return ReportWizardResult.Cancel;
            if (_btnPreview.Checked)
                return ReportWizardResult.Preview;
            return ReportWizardResult.Design;
        }

        public C1FlexReport Report
        {
            get { return _rpt; }
        }

        // ** event handlers

        // initialize
        private void ReportWizard_Load(object sender, System.EventArgs e)
        {
            // hide tabs
            _tabPanel_SizeChanged(this, EventArgs.Empty);

            // create new report
            _rpt = new C1FlexReport();
            _rpt.DataSource.IsolationLevel = _owner._isolationLevel;
            _dsPicker.IsolationLevel = _owner._isolationLevel;

            // Make sections visible:
            foreach (var s in C1FlexReportDesigner.GetSectionsInDesignerOrder(_rpt))
                s.Visible = true;

            // make wizard title bold, slightly bigger
            bool largeFonts = false;
            using (Graphics tg = Graphics.FromHwnd(IntPtr.Zero))
                largeFonts = tg.DpiX > 100;
            _lblTitle.Font = new Font(Font.Name, Font.SizeInPoints + (largeFonts ? 1 : 2), FontStyle.Bold, GraphicsUnit.Point);

            // select first page (step)
            _tab.SelectedIndex = 1;
            _tab.SelectedIndex = 0;

            // initialize layout page
            _btnTabular.Checked = false;
            _btnTabular.Checked = true;

            // initialize styles page
            foreach (ReportStyle style in ReportStyle.StyleList)
            {
                // add style to list
                _lbStyles.Items.Add(style);

                // select default style
                if (string.Compare(style.Name, _owner._defaultStyleName, true) == 0)
                {
                    _lbStyles.SelectedIndex = _lbStyles.Items.Count - 1;
                }
            }
            if (_lbStyles.SelectedIndex < 0)
            {
                _lbStyles.SelectedIndex = 0;
            }

            // initialize labels page
            _picLabels.Image = BitmapFromStream("loLabels.bmp", Color.Red);
            _btnEnglish.Checked = true;
            _btnSheetFeed.Checked = true;

            // initialize report title page
            _picFinish.Image = BitmapFromStream("wizFinish.bmp", Color.Red);
            _txtReportName.Text = string.Empty;
        }

        // keep tabs hidden
        private void _tabPanel_SizeChanged(object sender, EventArgs e)
        {
            Rectangle rc = _tabPanel.ClientRectangle;
            int height = _tab.ItemSize.Height + 2;
            rc.Y -= height;
            rc.Height += height;
            _tab.Dock = DockStyle.None;
            _tab.Bounds = rc;
        }

        // update UI when tabs change
        private void _tab_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // show new title
            _lblTitle.Text = "  " + (string)_tab.SelectedTab.Tag;

            // update buttons
            _btnBack.Enabled = (_tab.SelectedTab != _pgData);
            _btnNext.Text = (_tab.SelectedTab == _pgTitle) ? Strings.ReportWizard.Finish : Strings.ReportWizard.Next;
        }

        // handle wizard buttons
        private void _btnBack_Click(object sender, System.EventArgs e)
        {
            TabPage pg = _tab.SelectedTab;
            if (pg == _pgFields) pg = _pgData;
            else if (pg == _pgLayout) pg = _pgFields;
            else if (pg == _pgStyle) pg = _pgLayout;
            else if (pg == _pgLabels) pg = _pgLayout;
            else if (pg == _pgTitle)
            {
                pg = (_btnLabels.Checked)
                    ? _pgLabels
                    : _pgStyle;
            }

            _tab.SelectedTab = pg;
            _btnNext.Text = Strings.ReportWizard.Next;
        }
        private void _btnNext_Click(object sender, System.EventArgs e)
        {
            TabPage pg = _tab.SelectedTab;

            // leaving data source page: save changes, update field lists
            if (pg == _pgData)
            {
                DataSource ds = _rpt.DataSource;
                DataProvider dataProvider = _dsPicker.DataProvider;
                string conn = _dsPicker.ConnectionString;
                string rs = _dsPicker.RecordSource;
                RecordSourceType recordSourceType = _dsPicker.RecordSourceType;
                object recordset = _dsPicker.Recordset;

                // update report's parameters
                _rpt.Parameters.Clear();
                IList<DataSourcePicker.ReportParameterDesc> prms = _dsPicker.GetRecordSourceParameters();
                if (prms != null && prms.Count > 0)
                {
                    // add parameters to the report if it does not contains it
                    foreach (DataSourcePicker.ReportParameterDesc rpd in prms)
                    {
                        ReportParameter rp = new ReportParameter() { Name = rpd.Name, DataType = rpd.Type };
                        _rpt.Parameters.Add(rp);
                    }
                }

                if (ds.DataProvider != dataProvider || ds.ConnectionString != conn || ds.Recordset != recordset || ds.RecordSource != rs || ds.RecordSourceType != recordSourceType)
                {
                    ds.DataProvider = dataProvider;
                    ds.ConnectionString = conn;
                    ds.RecordSource = rs;
                    ds.Recordset = recordset;
                    ds.RecordSourceType = recordSourceType;
                    UpdateFieldLists();
                }

                // set next page
                pg = _pgFields;
            }

            // leaving fields page: enable/disable outline layouts
            // and validate current selection
            else if (pg == _pgFields)
            {
                // enable/disable layout buttons
                bool hasGroups = _lstGroups.Items.Count > 0;
                for (int i = 0; i < _btnsGrp.Length; i++)
                {
                    // enable/disable
                    _btnsGrp[i].Enabled = hasGroups;
                    _btnsFlat[i].Enabled = !hasGroups;

                    // validate current selection
                    if (hasGroups && _btnsFlat[i].Checked)
                        _btnsGrp[i].Checked = true;
                    if (!hasGroups && _btnsGrp[i].Checked)
                        _btnsFlat[i].Checked = true;
                }

                // set next page
                pg = _pgLayout;
            }

            // leaving layout page: next is styles or labels
            else if (pg == _pgLayout)
            {
                pg = (_btnLabels.Checked)
                    ? _pgLabels
                    : _pgStyle;
            }

            // leaving style/labels pages: next is always title
            else if (pg == _pgStyle || pg == _pgLabels)
            {
                string title = _txtReportName.Text;
                if (title.Length == 0)
                {
                    title = _dsPicker.RecordSource;
                    title = (title == null || title.Length == 0 ||
                        title.IndexOfAny("*,[];".ToCharArray()) > -1)
                        ? Strings.ReportWizard.NewReport
                        : title + Strings.ReportWizard.SpaceReport;
                    _txtReportName.Text = title;
                }
                _btnNext.Text = Strings.ReportWizard.Finish;
                pg = _pgTitle;
            }

            // finish wizard
            else if (pg == _pgTitle)
            {
                // we need a report name...
                if (_txtReportName.Text.Trim().Length == 0)
                {
                    MessageForm.Warn(Strings.ReportWizard.EnterNewReportName);
                    _txtReportName.Text = Strings.ReportWizard.NewReport;
                    _txtReportName.Focus();
                    return;
                }

                // done
                CreateReport();
                DialogResult = DialogResult.OK;
                return;
            }

            // show next page
            _tab.SelectedTab = pg;
        }
        private void _btnCancel_Click(object sender, System.EventArgs e)
        {
            _rpt = null;
            DialogResult = DialogResult.Cancel;
        }

        // ** handle data source page

        private void _dsPicker_DoubleClick(object sender, System.EventArgs e)
        {
            _btnNext_Click(this, EventArgs.Empty);
        }

        // ** handle fields page

        private void _btnAddFields_Click(object sender, System.EventArgs e)
        {
            foreach (object field in _lstAvailable.Items)
                _lstDetail.Items.Add(field);
            _lstAvailable.Items.Clear();
        }
        private void _btnRemoveFields_Click(object sender, System.EventArgs e)
        {
            foreach (object field in _lstDetail.Items)
                _lstAvailable.Items.Add(field);
            _lstDetail.Items.Clear();

            foreach (string field in _lstGroups.Items)
                _lstAvailable.Items.Add(field);
            _lstGroups.Items.Clear();
        }
        private void _lstAvailable_DoubleClick(object sender, System.EventArgs e)
        {
            object item = _lstAvailable.SelectedItem;
            if (item != null)
            {
                _lstDetail.Items.Add(item);
                _lstAvailable.Items.Remove(item);
            }
        }
        private Point _ptDown;
        private int _indexDown;
        private void _lstDrag_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _ptDown = new Point(e.X, e.Y);
            _indexDown = ((ListBox)sender).SelectedIndex;
        }
        private void _lstDrag_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) != 0)
            {
                ListBox lb = (ListBox)sender;
                int index = lb.SelectedIndex;
                if (index > -1 && index == _indexDown)
                {
                    int offset = Math.Max(Math.Abs(e.X - _ptDown.X), Math.Abs(e.Y - _ptDown.Y));
                    if (offset > DRAG_THRESHOLD)
                    {
                        lb.DoDragDrop(lb, DragDropEffects.Move);
                    }
                }
            }
        }
        private void _lstDrag_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // check that we are dragging from one of our ListBoxes
            ListBox src = e.Data.GetData(typeof(ListBox)) as ListBox;
            if (src != _lstAvailable && src != _lstGroups && src != _lstDetail)
                return;

            // check that an item is selected on the source
            if (src.SelectedIndex < 0)
                return;

            // can't drag within (sorted) available list
            if (src == _lstAvailable && sender == _lstAvailable)
                return;

            // dragging is OK
            e.Effect = DragDropEffects.Move;
        }
        private void _lstDrag_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // get source and destination lists
            ListBox src = e.Data.GetData(typeof(ListBox)) as ListBox;
            ListBox dst = sender as ListBox;
            if (src == null || dst == null) return;

            // find object being dragged
            object item = src.Items[src.SelectedIndex];
            if (item == null) return;

            // find destination index
            Point pt = dst.PointToClient(new Point(e.X, e.Y));
            int index = dst.IndexFromPoint(pt);

            // remove from source, add to target
            src.Items.Remove(item);
            if (index < 0) index = dst.Items.Count;
            dst.Items.Insert(index, item);
        }

        // ** handle layout page

        private void _btnLayout_CheckedChanged(object sender, System.EventArgs e)
        {
            // update preview image
            foreach (RadioButton btn in _gbLayout.Controls)
            {
                if (btn.Checked)
                {
                    string res = (string)btn.Tag + ".bmp";
                    _picLayout.Image = BitmapFromStream(res, Color.Red);
                    break;
                }
            }
        }

        // ** handle styles page

        private void _lbStyles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ReportStyle style = _lbStyles.SelectedItem as ReportStyle;
            _picStyle.Image = (style != null) ? style.GetPreview(false) : null;
            _owner._defaultStyleName = style.Name;
        }
        private void _lbStyles_DoubleClick(object sender, EventArgs e)
        {
            _btnNext_Click(this, EventArgs.Empty);
        }

        // ** handle labels page

        private void _btnLabel_CheckedChanged(object sender, System.EventArgs e)
        {
            ReportLabel.Fill(_lvLabels, _btnMetric.Checked, _btnContinuous.Checked);
        }

        // ** private stuff

        internal static Bitmap BitmapFromStream(string resName, Color transparentColor)
        {
            Assembly a = Assembly.GetExecutingAssembly();
            foreach (string res in a.GetManifestResourceNames())
            {
                if (res.EndsWith(resName))
                {
                    System.IO.Stream stream = a.GetManifestResourceStream(res);
                    Bitmap bmp = (Bitmap)Bitmap.FromStream(stream);
                    bmp.MakeTransparent(transparentColor);
                    return bmp;
                }
            }
            return null;
        }

        // update available field list when data source changes
        private void UpdateFieldLists()
        {
            // clear field lists
            _lstAvailable.Items.Clear();
            _lstGroups.Items.Clear();
            _lstDetail.Items.Clear();

            // populate available list
            var arr = _rpt.DataSource.DataSourceInfo.TextFields;
            if (arr != null)
            {
                foreach (var field in arr)
                    _lstAvailable.Items.Add(field.Name);
            }
        }

        private string BuildName(
            string baseName,
            string suffix)
        {
            if (StringParser.IsBracket(baseName))
                return StringParser.Bracket(StringParser.Unbracket(baseName) + suffix);
            else
                return baseName + suffix;
        }

        //--------------------------------------------------------------------------
        // report creation code
        private TextField MakeTextField(string name, ScriptObjectValue text, double left, double top, double width, double height, FieldAlignEnum align)
        {
            var field = new TextField();
            //
            field.Name = name;
            field.Text = text;
            field.Left = left;
            field.Top = top;
            field.Width = width;
            field.Height = height;
            field.Align = align;
            return field;
        }


        // create report based on current user selections
        // note: at this point _rpt.DataSource is already set
        private void CreateReport()
        {
            // set report name
            _rpt.ReportName = _txtReportName.Text.Trim();

            // set up data source
            DataSource ds = _rpt.DataSource;
            ds.ConnectionString = _dsPicker.ConnectionString;
            ds.RecordSource = _dsPicker.RecordSource;

            // get schema and field template list
            _schema = _rpt.DataSource.DataSourceInfo;
            _fieldList = BuildFieldTemplateList();

            // set up layout object
            Layout lo = _rpt.Layout;
            lo.Orientation = (_btnLandscape.Checked)
                ? OrientationEnum.Landscape
                : OrientationEnum.Portrait;

            lo.Width = lo.PageSize.Width - lo.MarginLeft - lo.MarginRight;
            double width = lo.Width;

            // create report groups
            foreach (string s in _lstGroups.Items)
            {
                SortEnum sort = (IsFieldNumber(s)) ? SortEnum.Descending : SortEnum.Ascending;
                Group g = _rpt.Groups.Add(s, s, sort);
                g.KeepTogether = KeepTogetherEnum.KeepFirstDetail;
                g.OutlineLabel.Expression = s;
                // Make group header/footer visible (they are not by default, have no idea why):
                g.SectionFooter.Visible = true;
                g.SectionFooter.Visible = true;
            }

            // special handling for label reports
            if (_btnLabels.Checked)
            {
                ListViewItem lvi = (_lvLabels.SelectedItems.Count > 0)
                    ? _lvLabels.SelectedItems[0]
                    : _lvLabels.Items[0];
                ReportLabel lbl = (ReportLabel)lvi.Tag;
                BuildDetail(lbl);
                return;
            }

            // build report header (1 field)
            Section section = _rpt.Sections[SectionTypeEnum.Header];
            section.Visible = true;
            section.Height = 800;

            section.Fields.Add(
                MakeTextField("titleLbl",
                _txtReportName.Text,
                FIELD_OFFSET, 200, width, 600, FieldAlignEnum.LeftMiddle));

            // build page footer (2 fields)
            section = _rpt.Sections[SectionTypeEnum.PageFooter];
            section.Visible = true;
            section.Height = 500;

            section.Fields.Add(
                MakeTextField("ftrLeft",
                new ScriptObjectValue() { Expression = "Now()" },
                FIELD_OFFSET, 30, width / 2, 300, FieldAlignEnum.LeftTop));

            section.Fields.Add(
                MakeTextField("ftrRight",
                new ScriptObjectValue() { Expression = Strings.ReportWizard.PageOfPagesText },
                width / 2, 30, width / 2, 300, FieldAlignEnum.RightTop));

            // build other sections (these vary with selected layout)
            BuildPageHeader();
            for (int i = 0; i < _rpt.Groups.Count; i++)
            {
                BuildGroupHeader(i);
            }
            BuildDetail();

            // all done, apply selected style
            ReportStyle style = _lbStyles.SelectedItem as ReportStyle;
            if (style != null)
            {
                style.Apply(_rpt);
            }
        }
        private void BuildPageHeader()
        {
            // check if we need a page header
            if (_btnJustified.Checked || _btnOutline.Checked || _btnAligned.Checked)
                return;

            // we do, so start by making it visible
            Section section = _rpt.Sections[SectionTypeEnum.PageHeader];
            section.Visible = true;
            section.Height = 400;

            // check if we need labels in the page header
            if (_btnColumnar.Checked)
                return;

            // add the labels
            foreach (FieldTemplate ft in _fieldList)
            {
                var field = MakeTextField(BuildName(ft._name, "Lbl"),
                    new ScriptObjectValue() { Value = ft._name },
                    ft._left, 0, ft._width, 400, FieldAlignEnum.LeftBottom);
                field.WordWrap = false;
                section.Fields.Add(field);
            }
        }
        private void BuildGroupHeader(int index)
        {
            // get page width
            int pageWidth = (int)_rpt.Layout.Width;

            // get group header section
            Section section = _rpt.Groups[index].SectionHeader;

            // make it visible, repeat at the top of each page
            section.Visible = true;
            section.Height = 500;
            section.Repeat = true;

            // build stepped header:
            // just add field value at the proper position
            if (_btnStepped.Checked)
            {
                // in this case, group fields are included in the list
                FieldTemplate ft = (FieldTemplate)_fieldList[index];
                // and add the field
                var field = MakeTextField(BuildName(ft._name, "Lbl"),
                    new ScriptObjectValue() { Expression = ft._name },
                    ft._left, 100, pageWidth - ft._left, 400, FieldAlignEnum.LeftBottom);
                section.Fields.Add(field);
                return;
            }

            // build outline/aligned header :
            // add field label and value at proper indent.
            // for the last one, add labels and section format as well.
            if (_btnOutline.Checked || _btnAligned.Checked)
            {
                bool outline = _btnOutline.Checked;
                int left = outline ? index * OUTLINEINDENT : 0;
                int wid = 3 * STEPINDENT;

                // add label field
                string name = _rpt.Groups[index].Name;
                var field = MakeTextField(BuildName(name, "Lbl"),
                    name,
                    left, 50, wid, 350, FieldAlignEnum.LeftBottom);
                field.WordWrap = false;
                section.Fields.Add(field);

                // add value field
                left += wid;
                wid = pageWidth - left;
                field = MakeTextField(BuildName(name, "Ctl"),
                    new ScriptObjectValue() { Expression = name },
                    left, 50, wid, 350, FieldAlignEnum.LeftBottom);
                section.Fields.Add(field);

                // if this is the last group header, we need to add labels
                if (index == _rpt.Groups.Count - 1)
                {
                    // make room for labels
                    section.Height = 1000;

                    // add labels for detail fields
                    // (the labels have already been indented)
                    foreach (FieldTemplate ft in _fieldList)
                    {
                        field = MakeTextField(BuildName(ft._name, "Lbl"),
                            ft._name,
                            ft._left, 500 + 50, ft._width, 350, FieldAlignEnum.LeftBottom);
                        field.WordWrap = false;
                        section.Fields.Add(field);
                    }
                }
            }
        }
        private void BuildDetail()
        {
            // get page width
            int pageWidth = (int)_rpt.Layout.Width;

            // get detail section
            Section section = _rpt.Sections[SectionTypeEnum.Detail];
            section.Visible = true;
            section.Height = DEFFIELDHEIGHT;

            // build columnar detail
            if (_btnColumnar.Checked)
            {
                // calculate label width
                int lblWidth = 0;
                foreach (FieldTemplate ft in _fieldList)
                {
                    lblWidth = Math.Max(lblWidth, ft._name.Length);
                }
                lblWidth *= 1440 * 8 / 72; // << chars to twips (approximation)

                // add fields
                Field f;
                double top = 0;
                foreach (FieldTemplate ft in _fieldList)
                {
                    // skip groups
                    if (ft._group)
                        continue;

                    // add label
                    // make it overlap the value field horizontally (width = iMax + 100)
                    // so it will be pushed down when (if) the field above grows
                    var field = MakeTextField(BuildName(ft._name, "Lbl"),
                        ft._name,
                        0, top, lblWidth + 100, DEFFIELDHEIGHT, FieldAlignEnum.LeftTop);
                    section.Fields.Add(field);

                    // add value field
                    field = MakeTextField(BuildName(ft._name, "Ctl"),
                        new ScriptObjectValue() { Expression = ft._name },
                        lblWidth, top, pageWidth - lblWidth, DEFFIELDHEIGHT, FieldAlignEnum.LeftTop);
                    field.AutoHeight = AutoSizeBehavior.CanGrow;
                    section.Fields.Add(field);
                    // ready for next
                    top += DEFFIELDHEIGHT;
                }

                // add line below detail
#pragma warning disable CS0618
                f = section.Fields.Add("pushLin", null, 0, top + 100, pageWidth, 30);
#pragma warning restore CS0618
                f.BackColor = Color.Black;
                //f.BackStyle = BackStyleEnum.Opaque;

                // always allow this section to grow
                //section.Height  = top + 300;
                // section.CanGrow = true;
                section.AutoHeight = AutoSizeBehavior.CanGrow;
                return;
            }

            // build justified detail
            if (_btnJustified.Checked)
            {
                // initialize field rectangle
                Rectangle rc = Rectangle.Empty;

                // loop through the fields
                for (int i = 0; i < _fieldList.Count; i++)
                {
                    FieldTemplate ft = (FieldTemplate)_fieldList[i];
                    if (ft._group)
                        continue;

                    // get width
                    rc.Width = ft._width;

                    // skip to next line if we have to
                    if (rc.Left > 0 && rc.Right >= pageWidth)
                    {
                        rc.X = 0;
                        rc.Y += rc.Height;
                    }

                    // can't overflow page
                    if (rc.Width > pageWidth)
                        rc.Width = pageWidth;

                    // fit last field on a page to right edge
                    if (i == _fieldList.Count - 1)
                        rc.Width = pageWidth - rc.Left;
                    else
                    {
                        FieldTemplate ftNext = (FieldTemplate)_fieldList[i + 1];
                        if (rc.Right + ftNext._width > pageWidth)
                            rc.Width = pageWidth - rc.Left;
                    }

                    // compute height for this row
                    if (rc.Left == 0)
                    {
                        rc.Height = DEFFIELDHEIGHT * 2;
                        double x = 0;
                        for (int j = i; j < _fieldList.Count; j++)
                        {
                            FieldTemplate ftRow = (FieldTemplate)_fieldList[j];
                            x += ftRow._width;
                            if (x > pageWidth) break;
                            int lines = (int)(ftRow._fullWid / ftRow._width);
                            int height = 280 * (lines + 1);
                            if (height > rc.Height) rc.Height = height;
                        }

                        // sanity on memo fields
                        if (rc.Height > MAXFIELDHEIGHT)
                            rc.Height = MAXFIELDHEIGHT;
                    }

                    // add label (fixed height)
                    var field = MakeTextField(BuildName(ft._name, "Lbl"),
                        ft._name,
                        rc.Left, rc.Top, rc.Width, DEFFIELDHEIGHT, FieldAlignEnum.CenterMiddle);
                    field.BackColor = Color.FromArgb(192, 192, 192);
                    field.ForeColor = Color.White;
                    field.Border.Style = C1.Win.Document.DashStyle.Solid;
                    field.Border.Width = 30;
                    if (field.Font.Size > 11)
                        field.Font.Size = 11; // make sure these guys fit!!!
                    section.Fields.Add(field);

                    // add value field
                    field = MakeTextField(BuildName(ft._name, "Ctl"),
                        new ScriptObjectValue() { Expression = ft._name },
                        rc.Left, rc.Top + 280, rc.Width, rc.Height - DEFFIELDHEIGHT, FieldAlignEnum.LeftTop);
                    field.MarginLeft = 50;
                    field.Border.Style = C1.Win.Document.DashStyle.Solid;
                    field.Border.Color = Color.FromArgb(192, 192, 192);
                    section.Fields.Add(field);
                    // move on to next
                    rc.X += rc.Width;
                }
                section.Height = rc.Bottom;
                return;
            }

            // others are all the same (tabular)
            foreach (FieldTemplate ft in _fieldList)
            {
                // skip groups
                if (ft._group) continue;

                // add calculated field
                var field = MakeTextField(BuildName(ft._name, "Ctl"),
                    new ScriptObjectValue() { Expression = ft._name },
                    ft._left, 0, ft._width, DEFFIELDHEIGHT,
                    (IsFieldNumber(ft._name)) ? FieldAlignEnum.RightTop : FieldAlignEnum.LeftTop);
                field.AutoHeight = ft._canGrow ? AutoSizeBehavior.CanGrow : AutoSizeBehavior.None;
                section.Fields.Add(field);

                // if any of the fields can grow, so can the section
                if (ft._canGrow)
                    section.AutoHeight = AutoSizeBehavior.CanGrow;
            }
        }
        private void BuildDetail(ReportLabel lbl)
        {
            // set up the layout
            Layout lo = _rpt.Layout;
            lo.Orientation = (lbl._portrait) ? OrientationEnum.Portrait : OrientationEnum.Landscape;
            lo.MarginLeft = lbl._mleft;
            lo.MarginTop = lbl._mtop;
            lo.MarginRight = lbl._mright;
            lo.MarginBottom = lbl._mtop / 2;
            lo.Width = lbl._wid + lbl._xspc;
            lo.Columns = lbl._across;
            lo.ColumnLayout = ColumnLayoutEnum.Labels;
            lo.LabelSpacingX = lbl._xspc;
            lo.LabelSpacingY = lbl._yspc;

            // set up detail section
            Section section = _rpt.Sections[SectionTypeEnum.Detail];

            // add fields
            double left = lbl._mleftlbl;
            double top = lbl._mtoplbl;
            double wid = lbl._wid - lbl._mleftlbl;
            double hei = _rpt.Font.Size * 25; // << line height
            foreach (FieldTemplate ft in _fieldList)
            {
                // bail out if out of space
                if (top + hei + 20 > lbl._hei)
                    break;

                // add calculated field
                var field = MakeTextField(BuildName(ft._name, "Ctl"),
                    new ScriptObjectValue() { Expression = ft._name },
                    left, top, wid, hei,
                    FieldAlignEnum.LeftTop);
                field.AutoHeight = AutoSizeBehavior.CanShrink;
                section.Fields.Add(field);

                // next line
                top += hei;
            }

            // set section properties (after adding fields, for safety)
            section.Visible = true;
            // section.CanGrow = false;
            // section.CanShrink = false;
            section.AutoHeight = AutoSizeBehavior.None;
            section.Height = lbl._hei + lbl._yspc;
        }
        private ArrayList BuildFieldTemplateList()
        {
            // create list
            ArrayList list = new ArrayList();

            // ** special case:
            // if this is a stepped report, include groups
            if (_btnStepped.Checked)
            {
                foreach (string s in _lstGroups.Items)
                {
                    // create field template
                    FieldTemplate ft = new FieldTemplate();
                    ft._name = s;
                    ft._group = true;
                    ft._fullWid = ft._width = GetFieldWidth(s);

                    // shorten long entries
                    if (ft._fullWid > MAXFIELDWIDTH)
                        ft._width = MAXFIELDWIDTH;
                    if (_btnStepped.Checked && ft._width > STEPINDENT)
                        ft._width = STEPINDENT;

                    // and add to list                    
                    list.Add(ft);
                }
            }

            // include details
            foreach (string s in _lstDetail.Items)
            {
                // create field template
                FieldTemplate ft = new FieldTemplate();
                ft._name = s;
                ft._fullWid = ft._width = GetFieldWidth(s);

                // shorten long entries
                if (ft._fullWid > MAXFIELDWIDTH)
                {
                    ft._width = MAXFIELDWIDTH;
                    ft._canGrow = true;
                }

                // and add to list                    
                list.Add(ft);
            }

            // adjust left position for all field templates
            int left = FIELD_OFFSET;
            foreach (FieldTemplate ft in list)
            {
                ft._left = left;
                left += ft._width + 20;
            }

            // adjust for outlining
            if (_btnOutline.Checked)
            {
                left = OUTLINEINDENT * _lstGroups.Items.Count;
                foreach (FieldTemplate ft in list)
                    ft._left += left;
            }

            // fit to page
            int cnt = list.Count;
            if (_checkAdjust.Checked && cnt > 0 &&
                !_btnColumnar.Checked && !_btnJustified.Checked)
            {
                // get page width
                int pageWidth = (int)_rpt.Layout.Width;

                // get current width
                FieldTemplate last = (FieldTemplate)list[cnt - 1];
                double width = last._left + last._width;

                // shrink everyone if we have to
                if (pageWidth > 0 && width > pageWidth)
                {
                    double factor = pageWidth / width;
                    foreach (FieldTemplate ft in list)
                    {
                        ft._left = (int)(ft._left * factor);
                        ft._width = (int)(ft._width * factor);
                    }
                }
            }

            // done
            return list;
        }

        int GetFieldWidth(
            string fieldName)
        {
            int size = 10; // << default value in chars

            // use schema information if available
            if (_schema != null)
            {
                // C1.C1Report.FieldInfo fi = _schema[fieldName];
                C1.Win.FlexReport.FieldInfo fi = _schema.Fields.Find((fi_) => fi_.Name == fieldName);
                if (fi != null)
                {
                    switch (Type.GetTypeCode(fi.DataType))
                    {
                        case TypeCode.String:
                            size = (fi.MaxLength < 0) ? DEFCHARCOUNT : Math.Min(fi.MaxLength, 5000);
                            break;

                        case TypeCode.Boolean:
                        case TypeCode.Byte:
                            size = 3;
                            break;

                        case TypeCode.Int16:
                        case TypeCode.Int32:
                        case TypeCode.Int64:
                            size = 6;
                            break;

                        case TypeCode.Decimal:
                        case TypeCode.Single:
                        case TypeCode.Double:
                            size = 10;
                            break;

                        case TypeCode.DateTime:
                            size = 10;
                            break;

                        default:
                            Debug.WriteLine(string.Format("** don't know the width for {0}", fi.DataType));
                            break;
                    }
                }
            }

            // convert from chars to twips (approximation)
            return size * 1440 * 8 / 72;
        }

        bool IsFieldNumber(
            string fieldName)
        {
            // sanity
            if (_schema == null)
                return false;

            // check field type
            C1.Win.FlexReport.FieldInfo fi = _schema.Fields.Find((fi_) => fi_.Name == fieldName);
            if (fi == null)
                return false;

            switch (Type.GetTypeCode(fi.DataType))
            {
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    return true;
            }

            // not a number
            return false;
        }

        /// <summary>
        /// FieldTemplate is a helper class used to build reports
        /// </summary>
        internal class FieldTemplate
        {
            internal string _name;
            internal int _left;
            internal int _width;
            internal int _fullWid;
            internal bool _group;
            internal bool _canGrow;
            internal FieldTemplate() { }
        }
    }
}

