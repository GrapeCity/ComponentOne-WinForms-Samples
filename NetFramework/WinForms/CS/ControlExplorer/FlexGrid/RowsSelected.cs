using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class RowsSelected : BaseDataBoundForm
    {
        public RowsSelected()
        {
            InitializeComponent();

            c1FlexGrid1.AfterSelChange += C1FlexGrid1_AfterSelChange;
            foreach (SelectionModeEnum mode in Enum.GetValues(typeof(SelectionModeEnum)))
            {
                c1ComboBoxSelMode.Items.Add(mode.ToString());
            }
            c1ComboBoxSelMode.SelectedIndex = 0;
        }

        private void C1FlexGrid1_AfterSelChange(object sender, RangeEventArgs e)
        {
            c1FlexGridRowsSelected.BeginUpdate();
            c1FlexGridRowsSelected.Rows.Count = 1;
            foreach (Row row in c1FlexGrid1.Rows.Selected)
            {
                c1FlexGridRowsSelected.AddItem($"row: {row.Index}");
            }
            c1FlexGridRowsSelected.EndUpdate();
        }

        private void c1ComboBoxSelMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.SelectionMode = (SelectionModeEnum)Enum.Parse(typeof(SelectionModeEnum), c1ComboBoxSelMode.Text);
        }
    }
}
