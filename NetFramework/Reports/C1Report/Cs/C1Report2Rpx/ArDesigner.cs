using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using C1.AppUtils.Options;

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Design;
using GrapeCity.ActiveReports.Design.Toolbox;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Data;

namespace C1Report2Rpx
{
    public partial class ArDesigner : BaseForm
    {
        private bool _dirty = false;
        private ReportItem _reportItem;

        public ArDesigner()
        {
            InitializeComponent();

            //
            LoadTools();
            theDesigner.Toolbox = arToolbox;
            theDesigner.PropertyGrid = arPropertyGrid;

            // Add Menu and CommandBar to Form
            ToolStrip menuStrip = theDesigner.CreateToolStrips(DesignerToolStrips.Menu)[0];

            ToolStripDropDownItem fileMenu = (ToolStripDropDownItem)menuStrip.Items[0];

            // Add an Exit command to the File menu
            fileMenu.DropDownItems.Clear();
            fileMenu.DropDownItems.Add(new ToolStripMenuItem(Strings.ArDesigner.SaveAndExit, null,
                (ss, ee) =>
                {
                    SaveReport();
                    Close();
                }));
            fileMenu.DropDownItems.Add(new ToolStripMenuItem(Strings.ArDesigner.Exit, null,
                (ss, ee) =>
                {
                    Close();
                }));

            ToolStripPanel panel =  toolStripContainer1.TopToolStripPanel;
            panel.Join(menuStrip, 0);
            panel.Join(theDesigner.CreateToolStrips(DesignerToolStrips.Zoom)[0], 1);
            panel.Join(theDesigner.CreateToolStrips(DesignerToolStrips.Undo)[0], 1);
            panel.Join(theDesigner.CreateToolStrips(DesignerToolStrips.Edit)[0], 1);

            panel.Join(theDesigner.CreateToolStrips(DesignerToolStrips.Layout)[0], 2);
            panel.Join(theDesigner.CreateToolStrips(DesignerToolStrips.Format)[0], 2);
        }

        #region Private
        private void LoadTools()
        {
            //Add Data Providers
            this.arToolbox.AddToolboxItem(new System.Drawing.Design.ToolboxItem(typeof(System.Data.DataSet)), "Data");
            this.arToolbox.AddToolboxItem(new System.Drawing.Design.ToolboxItem(typeof(System.Data.DataView)), "Data");
            this.arToolbox.AddToolboxItem(new System.Drawing.Design.ToolboxItem(typeof(System.Data.OleDb.OleDbConnection)), "Data");
            this.arToolbox.AddToolboxItem(new System.Drawing.Design.ToolboxItem(typeof(System.Data.OleDb.OleDbDataAdapter)), "Data");
            this.arToolbox.AddToolboxItem(new System.Drawing.Design.ToolboxItem(typeof(System.Data.Odbc.OdbcConnection)), "Data");
            this.arToolbox.AddToolboxItem(new System.Drawing.Design.ToolboxItem(typeof(System.Data.Odbc.OdbcDataAdapter)), "Data");
            this.arToolbox.AddToolboxItem(new System.Drawing.Design.ToolboxItem(typeof(System.Data.SqlClient.SqlConnection)), "Data");
            this.arToolbox.AddToolboxItem(new System.Drawing.Design.ToolboxItem(typeof(System.Data.SqlClient.SqlDataAdapter)), "Data");
        }

        private void UndoManager_Changed(
            object sender,
            EventArgs e)
        {
            if (!_dirty)
            {
                _dirty = true;
                Text += "  *";
            }
        }

        private void SaveReport()
        {
            if (_dirty)
            {
                Util.SaveReport(theDesigner, _reportItem.RpxData);
                _dirty = false;
            }
        }
        #endregion

        #region Public
        public void Edit(
            IWin32Window owner,
            ReportItem reportItem)
        {
            try
            {
                Util.LoadReport(theDesigner, reportItem.RpxData);
            }
            catch (Exception ex)
            {
                Util.MError(this, ex.Message);
                return;
            }

            _reportItem = reportItem;
            Text = reportItem.Report.ReportName;

            _dirty = false;
            theDesigner.UndoManager.Changed += new EventHandler(UndoManager_Changed);

            ShowDialog(owner);
        }
        #endregion

        #region Public static
        public static void DoEdit(
            IWin32Window owner,
            ReportItem reportItem)
        {
            using (ArDesigner f = new ArDesigner())
                f.Edit(owner, reportItem);
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
                if (rp.Splitter1Distance > 10) // sanity
                    splitContainer1.SplitterDistance = rp.Splitter1Distance;
                if (rp.Splitter2Distance > 10) // sanity
                    splitContainer2.SplitterDistance = rp.Splitter2Distance;
                if (rp.Splitter3Distance > 10) // sanity
                    splitContainer3.SplitterDistance = rp.Splitter3Distance;
            }
        }

        protected override void SaveFormResolutionParams(FormResolutionParams frp)
        {
            base.SaveFormResolutionParams(frp);
            ResolutionParams rp = frp as ResolutionParams;
            if (rp != null)
            {
                rp.Splitter1Distance = splitContainer1.SplitterDistance;
                rp.Splitter2Distance = splitContainer2.SplitterDistance;
                rp.Splitter3Distance = splitContainer3.SplitterDistance;
            }
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (!_dirty)
                return;

            var res = Util.MBox(this, Strings.ArDesigner.SaveChanged, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (res)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    SaveReport();
                    break;
                case System.Windows.Forms.DialogResult.No:
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false);
                    break;
            }
        }
        #endregion

        #region Nested types
        [Serializable]
        [XmlType(TypeName = "ArDesigner_ResolutionParams")]
        public class ResolutionParams : C1.AppUtils.Options.FormResolutionParams
        {
            #region Public properties
            [XmlAttribute]
            public int Splitter1Distance { get; set; }

            [XmlAttribute]
            public int Splitter2Distance { get; set; }

            [XmlAttribute]
            public int Splitter3Distance { get; set; }
            #endregion
        }
        #endregion
    }
}
