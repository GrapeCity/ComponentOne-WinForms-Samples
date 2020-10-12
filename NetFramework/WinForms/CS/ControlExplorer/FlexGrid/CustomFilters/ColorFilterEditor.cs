using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid.CustomFilters
{
    public partial class ColorFilterEditor : 
        UserControl, 
        C1.Win.C1FlexGrid.IC1ColumnFilterEditor
    {
        //-------------------------------------------------------------------------------
        #region ** fields

        ColorFilter _filter;
        bool _keepFormOpen;

        #endregion

        //-------------------------------------------------------------------------------
        #region ** ctor

        public ColorFilterEditor()
        {
            InitializeComponent();
        }

        #endregion

        //-------------------------------------------------------------------------------
        #region ** IC1ColumnFilterEditor Members

        public void Initialize(C1.Win.C1FlexGrid.C1FlexGridBase grid, int columnIndex, C1.Win.C1FlexGrid.IC1ColumnFilter filter)
        {
            // store reference to filter
            _filter = filter as ColorFilter;

            // initialize editor
            _target.BackColor = _filter.TargetColor;
            _threshold.Value = _filter.Tolerance;
        }
        public void ApplyChanges()
        {
            if (Validate())
            {
                // copy editor values back into the filter
                _filter.TargetColor = _target.BackColor;
                _filter.Tolerance = (int)_threshold.Value;
            }
        }
        public bool KeepFormOpen
        {
            get { return _keepFormOpen; }
            set { _keepFormOpen = value; }
        }

        #endregion

        //-------------------------------------------------------------------------------
        #region ** event handlers

        // pick target color from panel in the palette
        void panel1_Click(object sender, EventArgs e)
        {
            // copy color to target
            _target.BackColor = ((Panel)sender).BackColor;

            // apply changes and close parent form (optional)
            ApplyChanges();
            Form f = TopLevelControl as Form;
            f.DialogResult = DialogResult.OK;
            f.Close();
        }

        // pick target color using a ColorDialog
        private void _target_Click(object sender, EventArgs e)
        {
            using (var dlg = new ColorDialog())
            {
                dlg.Color = _target.BackColor;
                KeepFormOpen = true; // needed to show modal dialogs
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _target.BackColor = dlg.Color;
                }
                KeepFormOpen = false;
            }
        }
        #endregion
    }
}
