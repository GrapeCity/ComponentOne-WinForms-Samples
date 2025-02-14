using C1.Win.FlexGrid;
using System;

namespace FlexGridExplorer.Samples
{
    public class CellMerging : MergingControl
    {
        public CellMerging()
        {
            propertiesTsCbox.SelectedItem = "None";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            //set merging
            foreach (Column c in mergingFlexGrid.Cols)
            {
                c.AllowMerging = true;
            }
        }
    }
}
