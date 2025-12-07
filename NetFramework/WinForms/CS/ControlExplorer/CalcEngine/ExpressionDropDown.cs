using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.CalcEngine;
using C1.CalcEngine.ExcelEngine;
using C1.Win.FlexGrid;
using C1.CalcEngine.ExpressionEngine;
using C1.Win.C1Input;
using C1.Win.Ribbon;

namespace ControlExplorer.CalcEngine
{
    public partial class ExpressionDropDown : C1RibbonForm
    {
        private bool _updating;
        private ExpressionEngine _engine;

        public ExpressionDropDown()
        {
            InitializeComponent();

            c1FlexGrid1.Rows[0].Visible = false;
            c1FlexGrid1.Cols[0].Visible = false;
        }

        public ExpressionEngine Engine
        {
            get { return _engine; }
            set
            {
                if(_engine != value)
                {
                    _engine = value;
                    UpdateItems();
                }
            }
        }

        public string Syntax { get; set; }

        internal Point OpenLocation { get; set; }

        private void UpdateItems()
        {
            _updating = true;
            c1FlexGrid1.Rows.RemoveRange(1, c1FlexGrid1.Rows.Count - 1);

            var functions = _engine.GetExpressionItems().Where(x => x.ItemType > ItemType.Operator);

            int idx = 1;
            foreach (var function in functions)
            {
                var row = c1FlexGrid1.Rows.Add();
                row[0] = idx++;
                row[1] = function.Syntax;
                row[2] = function.Description;
            }
            _updating = false;

            c1FlexGrid1.Row = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ExpressionDropDown_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && c1FlexGrid1.Rows.Count > 1)
            {
                c1FlexGrid1.Focus();
                c1FlexGrid1.Row = 1;
            }
            Location = OpenLocation;
        }

        private void c1FlexGrid1_SelChange(object sender, EventArgs e)
        {
            if (c1FlexGrid1.RowSel < 0 || _updating)
                return;

            Syntax = c1FlexGrid1.Rows[c1FlexGrid1.RowSel][1].ToString();
        }

        private void c1FlexGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (c1FlexGrid1.RowSel == c1FlexGrid1.MouseRow)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Location = OpenLocation;
        }
    }
}
