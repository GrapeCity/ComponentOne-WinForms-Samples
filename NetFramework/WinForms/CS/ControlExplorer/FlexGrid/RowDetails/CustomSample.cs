using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid.RowDetails
{
    public partial class CustomSample : C1DemoForm
    {
        public CustomSample()
        {
            InitializeComponent();
        }

        private void CustomSample_Load(object sender, EventArgs e)
        {
            flexGrid.DataSource = DemoDataSource("Employees");

            flexGrid.RowDetailProvider = (g, r) => new CustomRowDetail();
            flexGrid.RowDetailsVisibilityMode = RowDetailsVisibilityMode.VisibleWhenSelected;

            flexGrid.Cols["Notes"].Visible = false;
        }
    }

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
            var bs = new BindingSource(parentGrid.DataSource, parentGrid.DataMember);
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
            var srSz = parentGrid.ScrollableRectangle.Size;
            var sz = TextRenderer.MeasureText(Text, Font, srSz, TextFormatFlags.WordBreak);
            sz.Width = Math.Max(sz.Width + Padding.Horizontal, srSz.Width);
            sz.Height += Padding.Vertical;

            Size = sz;
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
