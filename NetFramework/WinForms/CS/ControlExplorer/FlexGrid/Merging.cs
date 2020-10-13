using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlExplorer.FlexGrid
{
    public class Merging : BaseDataBoundForm
    {
        public Merging()
        {
            AddProperty("AllowMerging", c1FlexGrid1);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //set merging
            c1FlexGrid1.AllowMerging = AllowMergingEnum.RestrictCols;

            foreach (Column c in c1FlexGrid1.Cols)
            {
                c.AllowMerging = true;
            }
            //apply some formatting
            c1FlexGrid1.Cols["Product"].Width = 100;
            c1FlexGrid1.Cols["UnitPrice"].Format = "c";
            c1FlexGrid1.Cols["ExtendedPrice"].Format = "c";
            //sort grid by specified column
            c1FlexGrid1.Sort(SortFlags.Ascending, 1, 2);
        }
    }
}
