using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid.CustomFilters
{
    /// <summary>
    /// Represents an editor for modifying a <see cref="StringFilterEditor"/>.
    /// </summary>
    public partial class StringFilterEditor : 
        UserControl,
        C1.Win.C1FlexGrid.IC1ColumnFilterEditor
    {
        //-------------------------------------------------------------------------------
        #region ** fields

        StringFilter _filter;

        #endregion

        //-------------------------------------------------------------------------------
        #region ** ctor

        public StringFilterEditor()
        {
            InitializeComponent();
        }

        #endregion

        //-------------------------------------------------------------------------------
        #region ** IC1ColumnFilterEditor

        public void Initialize(C1.Win.C1FlexGrid.C1FlexGridBase grid, int columnIndex, C1.Win.C1FlexGrid.IC1ColumnFilter filter)
        {
            _filter = (StringFilter)filter;

            // initialize checkbox values
            foreach (var pt in _filter.Ranges)
            {
                switch ((char)pt.X)
                {
                    case 'A':
                        _chkAE.Checked = true;
                        break;
                    case 'F':
                        _chkFJ.Checked = true;
                        break;
                    case 'K':
                        _chkKO.Checked = true;
                        break;
                    case 'P':
                        _chkPT.Checked = true;
                        break;
                    case 'U':
                        _chkUZ.Checked = true;
                        break;
                }
            }
        }
        public void ApplyChanges()
        {
            // reset filter
            _filter.Ranges.Clear();

            // add selected ranges
            foreach (Control ctl in this.Controls)
            {
                var cb = ctl as CheckBox;
                if (cb != null && cb.Checked)
                {
                    var pt = new Point((int)cb.Text[0], (int)cb.Text[cb.Text.Length - 1]);
                    _filter.Ranges.Add(pt);
                }
            }
        }
        public bool KeepFormOpen
        {
            get { return false; }
        }

        #endregion

        //-------------------------------------------------------------------------------
        #region ** event handlers

        void _chkAE_CheckedChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            cb.Font = new Font(Font, cb.Checked ? FontStyle.Bold : FontStyle.Regular);
        }

        #endregion
    }
}
