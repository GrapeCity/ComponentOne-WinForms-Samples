using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

using C1.AppUtils.Options;
using C1R = C1.C1Report;
using AR = GrapeCity.ActiveReports;

namespace C1Report2Rpx
{
    public partial class MainForm : BaseForm
    {
        private const int c_splitPanelMinHeight = 160;

        private Reports _reports = new Reports();
        private int _splitterDistance = 0; // used to cache last splitter distance when hiding the log window

        static MainForm()
        {
            ProgramOptions.Load();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        #region Private
        private void ShowLog()
        {
            if (!IsLogVisible)
            {
                try
                {
                    this.scMain.Panel2MinSize = c_splitPanelMinHeight;
                }
                catch
                {
                }
                this.scMain.SplitterDistance = _splitterDistance;
                this.scMain.IsSplitterFixed = false;
                Update_dgvLog();
            }
        }

        private void HideLog()
        {
            if (IsLogVisible)
            {
                _splitterDistance = this.scMain.SplitterDistance;
                try
                {
                    this.scMain.Panel2MinSize = this.tsLog.Height;
                }
                catch
                {
                }
                this.scMain.SplitterDistance = this.ClientSize.Height; // this will not go beyond Panel2MinSize
                this.scMain.IsSplitterFixed = true;
                Update_dgvLog();
            }
        }

        private void Update_dgvReports()
        {
            dgvReports.RowCount = _reports.Count;
            if (_reports.Count > 0)
            {
                dgvReports.CurrentCell = dgvReports.Rows[0].Cells[0];
                dgvReports.Invalidate();
            }
        }

        private void Update_dgvLog()
        {
            ReportItem ri = Report;
            if (IsLogVisible)
            {
                tslLogTitle.IsLink = false;
                tslLogTitle.Text = Strings.MainForm.LogCaption;
                tsbHideShowLog.Image = Util.ImgDown;
            }
            else
            {
                tslLogTitle.IsLink = true;
                tslLogTitle.Text = Strings.MainForm.LogShowLog;
                tsbHideShowLog.Image = Util.ImgUp;
            }
            if (ri == null)
            {
                tssC1ReportName.Visible = false;
                tslC1ReportName.Text = string.Empty;
                dgvLog.RowCount = 0;
            }
            else
            {
                tssC1ReportName.Visible = true;
                tslC1ReportName.Text = ri.Report.ReportName;
                dgvLog.RowCount = ri.Log.Count;
            }
            dgvLog.Invalidate();
        }

        private void UpdateControls()
        {
        }

        private void DoOpen(
            string fileName)
        {
            if (Updating)
                return;

            Reports reports = new Reports();
            string error = ConvertForm.DoConvert(this, fileName, reports);
            if (!string.IsNullOrEmpty(error))
            {
                Util.MError(this, error);
                return;
            }

            // assign new reports list
            if (_reports != null)
                _reports.Dispose();
            _reports = reports;

            // initialize controls
            BeginUpdate();
            try
            {
                Update_dgvReports();
                Update_dgvLog();
                tscbC1ReportFile.Text = fileName;
                bool hasFileName = false;
                foreach (object obj in tscbC1ReportFile.Items)
                    if (obj.ToString() == fileName)
                    {
                        hasFileName = true;
                        break;
                    }
                if (!hasFileName)
                    tscbC1ReportFile.Items.Insert(0, fileName);
            }
            finally
            {
                EndUpdate();
            }
        }

        private void DoOpen()
        {
            if (ofdC1ReportFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                DoOpen(ofdC1ReportFile.FileName);
        }

        private void DoSaveActiveReportDefinition()
        {
            ReportItem ri = Report;
            if (ri == null || ri.RpxData.Length <= 0)
                return;

            sfdARFile.FileName = Util.MakeFileName(ri.Report.ReportName);
            if (sfdARFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sfdARFile.FileName, FileMode.Create, FileAccess.Write))
                {
                    byte[] buf = ri.RpxData.ToArray();
                    fs.Write(buf, 0, buf.Length);

                    //
                    ri.FileName = sfdARFile.FileName;
                    dgvReports.Invalidate();
                }
            }
        }

        private void DoRunARDesigner()
        {
            ReportItem ri = Report;
            if (ri == null || ri.RpxData.Length <= 0)
                return;

            ArDesigner.DoEdit(this, ri);
        }

        private void DoRunARPreview()
        {
            ReportItem ri = Report;
            if (ri == null || ri.RpxData.Length <= 0)
                return;

            ArPreviewForm.DoView(this, ri);
        }

#if DEBUG
        private void DoCheckAllReports()
        {
            AR.Design.Designer dsgn = new AR.Design.Designer();

            using (StreamWriter sw = new StreamWriter(@"..\..\checkall.txt"))
            {
                string[] files = Directory.GetFiles(@"..\..\TestReports\", "*.xml");
                foreach (string file in files)
                {
                    string[] reportNames = C1R.C1Report.GetReportList(file);
                    foreach (string reportName in reportNames)
                    {
                        try
                        {
                            C1R.C1Report rep = new C1R.C1Report();
                            rep.Load(file, reportName);
                            Log log = new C1Report2Rpx.Log();
                            C1ReportConverter rc = new C1ReportConverter(rep, log);
                            rc.Convert();
                            using (MemoryStream ms = new MemoryStream())
                            {
                                rc.AReport.SaveLayout(ms);
                                ms.Seek(0, SeekOrigin.Begin);
                                dsgn.LoadReport(ms);
                            }
                        }
                        catch (Exception ex)
                        {
                            sw.WriteLine(string.Format("File  : {0}", file));
                            sw.WriteLine(string.Format("Report: {0}", reportName));
                            sw.WriteLine(ex.Message);
                            sw.WriteLine("--------------------------------------");
                            sw.WriteLine("");
                        }
                    }
                }
            }
        }
#endif
        #endregion

        #region Private properties
        private Log Log
        {
            get
            {
                ReportItem ri = Report;
                return ri == null ? null : ri.Log;
            }
        }

        private ReportItem Report
        {
            get
            {
                if (_reports == null)
                    return null;
                int rowIndex = dgvReports.CurrentCellAddress.Y;
                if (rowIndex < 0 || rowIndex >= _reports.Count)
                    return null;
                return _reports[rowIndex];
            }
        }

        private bool IsLogVisible
        {
            get { return !this.scMain.IsSplitterFixed; }
        }
        #endregion

        #region Protected
        protected override FormResolutionParams CreateFormResolutionParams()
        {
            return new ResolutionParams();
        }

        protected override void LoadFormResolutionParams(FormResolutionParams frp)
        {
            base.LoadFormResolutionParams(frp);
            ResolutionParams rp = frp as ResolutionParams;
            if (rp != null)
            {
                if (rp.SplitterDistance > 10) // sanity
                    _splitterDistance = rp.SplitterDistance;
                if (rp.LogVisible)
                    ShowLog();
                else
                    HideLog();
                tscbC1ReportFile.Items.Clear();
                foreach (string s in rp.C1ReportDefinitions)
                    tscbC1ReportFile.Items.Add(s);
            }
        }

        protected override void SaveFormResolutionParams(FormResolutionParams frp)
        {
            base.SaveFormResolutionParams(frp);
            ResolutionParams rp = frp as ResolutionParams;
            if (rp != null)
            {
                rp.SplitterDistance = scMain.SplitterDistance;
                rp.LogVisible = IsLogVisible;
                rp.C1ReportDefinitions.Clear();
                foreach (object o in tscbC1ReportFile.Items)
                    rp.C1ReportDefinitions.Add(o.ToString());
            }
        }
        #endregion

        #region Nested types
        [Serializable]
        [XmlType(TypeName = "MainForm_ResolutionParams")]
        public class ResolutionParams : C1.AppUtils.Options.FormResolutionParams
        {
            private List<string> _c1ReportDefinitions = new List<string>();

            #region Public properties
            [XmlAttribute]
            public int SplitterDistance { get; set; }

            [XmlAttribute]
            public bool LogVisible { get; set; }

            [XmlElement]
            public List<string> C1ReportDefinitions
            {
                get { return _c1ReportDefinitions; }
            }
            #endregion
        }
        #endregion

        private void MainForm2_Load(object sender, EventArgs e)
        {
            Text = Strings.C1Report2RpxLongName;

            ToolStripLabel tslC1ReportFile = new ToolStripLabel(Strings.C1ReportDefinitionLabel); // ToolStripLabel cannot be added in designer
            tslC1ReportFile.Alignment = ToolStripItemAlignment.Right;
            tslC1ReportFile.ToolTipText = tscbC1ReportFile.ToolTipText;
            msMain.Items.Insert(msMain.Items.IndexOf(tscbC1ReportFile) + 1, tslC1ReportFile);

            //
            //HideLog();
            Update_dgvLog();

            //
            Update_dgvReports();
            Update_dgvLog();
        }

        private void dgvReports_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _reports.Count)
            {
                e.Value = string.Empty;
                return;
            }

            ReportItem ri = _reports[e.RowIndex];
            switch (e.ColumnIndex)
            {
                case 0:
                    e.Value = ri.Report.ReportName;
                    break;
                case 1:
                    e.Value = ri.FileName;
                    break;
                case 2:
                    e.Value = string.Empty;
                    break;
            }
        }

        private void dgvReports_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _reports.Count)
                return;

            ReportItem ri = _reports[e.RowIndex];
            switch (e.ColumnIndex)
            {
                case 2:
                    // draw converting status column
                    bool selected = (e.State & DataGridViewElementStates.Selected) != 0;
                    e.PaintBackground(e.ClipBounds, selected);
                    LogInfo li = ri.Log.GetInfo();
                    Rectangle imageBounds = new Rectangle(
                        e.CellBounds.Left + 2,
                        e.CellBounds.Top + (e.CellBounds.Height - li.Image.Height) / 2,
                        li.Image.Width,
                        li.Image.Height);
                    e.Graphics.DrawImage(li.Image, imageBounds.Location);
                    Rectangle textBounds = new Rectangle(
                        imageBounds.Right + 2,
                        e.CellBounds.Top,
                        e.CellBounds.Right - imageBounds.Right - 2,
                        e.CellBounds.Height);
                    TextRenderer.DrawText(
                        e.Graphics,
                        li.Description,
                        e.CellStyle.Font,
                        textBounds, selected ? dgvReports.DefaultCellStyle.SelectionForeColor : e.CellStyle.ForeColor,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                    e.Handled = true;
                    break;
            }
        }

        private void dgvLog_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            Log log = Log;
            if (log == null || e.RowIndex < 0 || e.RowIndex >= log.Count)
            {
                e.Value = string.Empty;
                return;
            }

            LogEntry le = log[e.RowIndex];
            switch (e.ColumnIndex)
            {
                case 0:
                    e.Value = null;
                    break;
                case 1:
                    e.Value = e.RowIndex + 1;
                    break;
                case 2:
                    e.Value = le.Message;
                    break;
                case 3:
                    e.Value = le.Source;
                    break;
            }
        }

        private void dgvLog_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Log log = Log;
            if (log == null || e.RowIndex < 0 || e.RowIndex >= log.Count)
                return;

            LogEntry le = log[e.RowIndex];
            switch (e.ColumnIndex)
            {
                case 0:
                    Image image = null;
                    switch (le.Level)
                    {
                        case LogEntryLevel.Warning:
                            image = Util.ImgWarning;
                            break;
                        case LogEntryLevel.Error:
                            image = Util.ImgError;
                            break;
                    }
                    if (image != null)
                    {
                        e.PaintBackground(e.ClipBounds, (e.State & DataGridViewElementStates.Selected) != 0);
                        e.Graphics.DrawImage(image, e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2, e.CellBounds.Top + 2);
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void MainForm2_KeyDown(object sender, KeyEventArgs e)
        {
#if DEBUG
            if (e.Control && e.Shift && e.KeyCode == Keys.A)
                DoCheckAllReports();
#endif
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            DoOpen();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void msMain_Resize(object sender, EventArgs e)
        {
            tscbC1ReportFile.Width = msMain.ClientRectangle.Width - tsmiHelp.Bounds.Right - 300;
        }

        private void tsbHideShowLog_Click(object sender, EventArgs e)
        {
            if (IsLogVisible)
                HideLog();
            else
                ShowLog();
        }

        private void tslLogTitle_Click(object sender, EventArgs e)
        {
            ShowLog();
        }

        private void dgvReports_CurrentCellChanged(object sender, EventArgs e)
        {
            Update_dgvLog();
        }

        private void tsmiSaveConverted_Click(object sender, EventArgs e)
        {
            DoSaveActiveReportDefinition();
        }

        private void tscbC1ReportFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoOpen(tscbC1ReportFile.Text);
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutDialog.DoShow(this);
        }

        private void tsmiViewMyReadme_Click(object sender, EventArgs e)
        {
            if (File.Exists("readme.txt"))
                System.Diagnostics.Process.Start("readme.txt");
        }

        private void tsmiActions_DropDownOpening(object sender, EventArgs e)
        {
            ReportItem ri = Report;
            tsmiSaveConverted.Enabled = ri != null && ri.RpxData.Length > 0;
            tsmiRunARDesigner.Enabled = ri != null && ri.RpxData.Length > 0;
            tsmiRunARPreview.Enabled = ri != null && ri.RpxData.Length > 0;
        }

        private void tsmiRunARDesigner_Click(object sender, EventArgs e)
        {
            DoRunARDesigner();
        }

        private void tsmiRunARPreview_Click(object sender, EventArgs e)
        {
            DoRunARPreview();
        }

        private void cmsReports_Opening(object sender, CancelEventArgs e)
        {
            ReportItem ri = Report;
            cmtsmiSaveConverted.Enabled = ri != null && ri.RpxData.Length > 0;
            cmtsmiRunARDesigner.Enabled = ri != null && ri.RpxData.Length > 0;
            cmtsmiRunARPreview.Enabled = ri != null && ri.RpxData.Length > 0;
        }
    }
}
