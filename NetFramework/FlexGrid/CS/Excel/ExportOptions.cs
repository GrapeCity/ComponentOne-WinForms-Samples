using C1.Win.FlexGrid;
using C1.Win.Ribbon;
using C1.Win.SuperTooltip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Excel
{
    public partial class ExportOptions : C1RibbonForm
    {
        private C1SuperTooltip toolTip1 = new C1SuperTooltip();
        private FileFlags _flags = new FileFlags();

        public ExportOptions()
        {
            InitializeComponent();
            this.c1ThemeController1.SetTheme(toolTip1, "(default)");
            this.toolTip1.RoundedCorners = true;
            this.toolTip1.SetToolTip(this.chkExcludeFooters, "Do not save footer rows when exporting.");
            this.toolTip1.SetToolTip(this.chkVisibleOnly, "Save only visible rows and columns.");
            this.toolTip1.SetToolTip(this.chkSelectedRowsOnly, "Save only selected rows.");
            this.toolTip1.SetToolTip(this.chkSaveMergedRanges, "Save merged ranges when exporting to Excel.");
            this.toolTip1.SetToolTip(this.chkOpenXml, "Save file in OpenXml (Office 2007) format. ");
            this.toolTip1.SetToolTip(this.chkNoFreezing, "Do not freeze rows and columns when exporting to Excel.");
            this.toolTip1.SetToolTip(this.chkIncludeFixedCells, "Include fixed cells when saving the grid. ");
            this.toolTip1.SetToolTip(this.chkAsDisplayed, "Save values as displayed (including formatting and mapping where available). ");
        }

        public FileFlags Flags
        {
            get { return _flags; }
            set { _flags = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool none = true;
            if (chkAsDisplayed.Checked)
            {
                _flags = _flags | FileFlags.AsDisplayed;
                none = false;
            }
            if (chkIncludeFixedCells.Checked)
            {
                _flags = _flags | FileFlags.IncludeFixedCells;
                none = false;
            }
            if (chkNoFreezing.Checked)
            {
                _flags = _flags | FileFlags.NoFreezing;
                none = false;
            }
            if (chkOpenXml.Checked)
            {
                _flags = _flags | FileFlags.OpenXml;
                none = false;
            }
            if (chkSaveMergedRanges.Checked)
            {
                _flags = _flags | FileFlags.SaveMergedRanges;
                none = false;
            }
            if (chkSelectedRowsOnly.Checked)
            {
                _flags = _flags | FileFlags.SelectedRowsOnly;
                none = false;
            }
            if (chkVisibleOnly.Checked)
            {
                _flags = _flags | FileFlags.VisibleOnly;
                none = false;
            }
            if (chkExcludeFooters.Checked)
            {
                _flags = _flags | FileFlags.ExcludeFooters;
                none = false;
            }
            if (none) _flags = FileFlags.None;
        }
    }
}
