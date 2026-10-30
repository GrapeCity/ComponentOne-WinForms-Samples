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
    public partial class ImportOptions : C1RibbonForm
    {
        private C1SuperTooltip toolTip1 = new C1SuperTooltip();
        private FileFlags _flags = new FileFlags();

        public ImportOptions()
        {
            InitializeComponent();
            this.c1ThemeController1.SetTheme(toolTip1, "(default)");
            this.toolTip1.RoundedCorners = true;
            this.toolTip1.SetToolTip(this.chkLoadAsTransposed, "Load transposed grid.");
            this.toolTip1.SetToolTip(this.chkVisibleOnly, "Load only visible rows and columns.");
            this.toolTip1.SetToolTip(this.chkLoadMergedRanges, "Load merged ranges when importing from Excel.");
            this.toolTip1.SetToolTip(this.chkNoFreezing, "Do not freeze rows and columns when importing from Excel.");
            this.toolTip1.SetToolTip(this.chkIncludeFixedCells, "Include fixed cells when loading the grid. ");
        }

        public FileFlags Flags
        {
            get { return _flags; }
            set { _flags = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool none = true;
            if (chkLoadAsTransposed.Checked)
            {
                _flags = _flags | FileFlags.LoadAsTransposed;
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
            if (chkLoadMergedRanges.Checked)
            {
                _flags = _flags | FileFlags.LoadMergedRanges;
                none = false;
            }
            if (none) _flags = FileFlags.None;
        }
    }
}
