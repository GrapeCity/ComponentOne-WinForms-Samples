using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlExplorer.FlexGrid
{
    public class Freezing : BaseDataBoundForm
    {
        public Freezing()
        {
            AddProperty("AllowFreezing", c1FlexGrid1);
            AddProperty("AllowDragging", c1FlexGrid1);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            c1FlexGrid1.AllowFreezing = AllowFreezingEnum.Both;
            c1FlexGrid1.AllowDragging = AllowDraggingEnum.Both;
            c1FlexGrid1.Cols.Frozen = 2;
            c1FlexGrid1.Rows.Frozen = 3;
        }
    }
}
