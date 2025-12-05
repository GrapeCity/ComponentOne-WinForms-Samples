using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class Overview : BaseDataBoundForm
    {
        public Overview()
        {
            AddProperty("AllowAddNew", c1FlexGrid1);
            AddProperty("AllowDelete", c1FlexGrid1);
            AddProperty("AllowEditing", c1FlexGrid1);
            AddProperty("AllowSorting", c1FlexGrid1);
            AddProperty("SelectionMode", c1FlexGrid1);
            AddProperty("AllowFiltering", c1FlexGrid1);
            AddProperty("AllowMerging", c1FlexGrid1);
            AddProperty("AllowResizing", c1FlexGrid1);
            AddProperty("MinSize", c1FlexGrid1.Cols, "Column Min Width");
            AddProperty("ShowCellLabels", c1FlexGrid1);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (C1.Win.FlexGrid.Column c in c1FlexGrid1.Cols)
            {
                c.AllowMerging = true;
            }
            c1FlexGrid1.Cols["Product"].MinWidth = 120;
            c1FlexGrid1.Cols["Product"].StarWidth = "*";
        }
    }
}
