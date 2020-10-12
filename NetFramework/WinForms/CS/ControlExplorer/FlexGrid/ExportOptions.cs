using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class ExportOptions : Form
    {
        C1.Win.C1FlexGrid.FileFlags _flags;
        public ExportOptions()
        {
            InitializeComponent();
            _flags = new FileFlags();
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
            if (none) _flags = FileFlags.None;
        }
    }
}
