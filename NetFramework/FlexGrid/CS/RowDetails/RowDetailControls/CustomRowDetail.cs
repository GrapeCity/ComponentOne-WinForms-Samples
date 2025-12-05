using System;
using System.Drawing;
using System.Data;
using C1.Win.InputPanel;
using C1.Win.FlexGrid;
using C1.Win.C1Input;
using System.Windows.Forms;

namespace RowDetails
{
    /// <summary>
    /// Custom row detail class which shows label with notes about employee.
    /// </summary>
    public class CustomRowDetail : C1Label, IC1FlexGridRowDetail
    {
        /// <summary>
        /// Used to setup control before showing of it.
        /// </summary>
        /// <param name="parentGrid">FlexGrid which displays detail control.</param>
        /// <param name="rowIndex">Index of parent detail row.</param>
        void IC1FlexGridRowDetail.Setup(C1FlexGrid parentGrid, int rowIndex)
        {
            var bs = new BindingSource(parentGrid.DataSource as DataSet, "Employees");
            bs.Position = parentGrid.Rows[rowIndex].DataIndex;

            DataField = "Notes";
            DataSource = bs;
        }

        /// <summary>
        /// Used to update size of the control.
        /// </summary>
        /// <param name="parentGrid">FlexGrid which displays detail control.</param>
        /// <param name="rowIndex">Index of parent detail row.</param>
        /// <param name="proposedSize">The proposed size for the detail control.</param>
        void IC1FlexGridRowDetail.UpdateSize(C1FlexGrid parentGrid, int rowIndex, Size proposedSize)
        {
            var scrollableRectangleWidth = parentGrid.ScrollableRectangle.Size.Width;
            var proposedWidth = proposedSize.Width;
            var width = Math.Min(scrollableRectangleWidth, proposedWidth);
            var textSize = TextRenderer.MeasureText(Text, Font, new Size(width, 1), TextFormatFlags.WordBreak);
            Size = new Size(width, textSize.Height);
        }

        /// <summary>
        /// Used to release resources of the control before the removing of it.
        /// </summary>
        /// <param name="parentGrid">FlexGrid which displays detail control.</param>
        /// <param name="rowIndex">Index of parent detail row.</param>
        void IC1FlexGridRowDetail.Removing(C1FlexGrid parentGrid, int rowIndex)
        {
            // No resources to release
        }
    }
}
