using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples.RowDetails
{
    using FlexGridExplorer.Data;
    public partial class CustomSample : UserControl
    {
        public CustomSample()
        {
            InitializeComponent();
        }

        private void CustomSample_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Employees";
            flexGrid.DataSource = DataSource.GetRows(sql);

            flexGrid.RowDetailProvider = (g, r) => new CustomRowDetail();
            flexGrid.RowDetailsVisibilityMode = RowDetailsVisibilityMode.VisibleWhenSelected;

            flexGrid.Cols["Notes"].Visible = false;
        }
    }

    /// <summary>
    /// Custom row detail class which shows label with notes about employee.
    /// </summary>
    public class CustomRowDetail : Label, IC1FlexGridRowDetail
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
            this.DataBindings.Add(new Binding("Text", bs, "Notes"));
        //    DataField = "Notes";
        //    DataSource = bs;
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
