using MultiColumnComboExplorer.Data;
using System;
using System.Windows.Forms;

namespace MultiColumnComboExplorer.Samples
{
    public partial class Overview : UserControl
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            var data = new BindingSource(DataSource.GetSalesInfo(), "");

            mccDefault.DataSource = data;
            mccDefault.DisplayMember = "Product";
            mccDefault.ValueMember = "Id";

            mccCustomStyle.DataSource = data;
            mccCustomStyle.DisplayMember = "Product";
            mccCustomStyle.ValueMember = "Id";

            mccUnboundMode.ValueMember = "Flag";
            mccUnboundMode.DisplayMember = "Name";
            mccUnboundMode.AddItem(Country.GetCountry(0).ToString());
            mccUnboundMode.AddItem(Country.GetCountry(1).ToString());
            mccUnboundMode.AddItem(Country.GetCountry(2).ToString());
            mccUnboundMode.AddItem(Country.GetCountry(3).ToString());
            mccUnboundMode.AddItem(Country.GetCountry(4).ToString());
            mccUnboundMode.ImageList = ilFlags;

            mccSearch.DataSource = DataSource.GetRows("Select * from Cities", "Cities");
            mccSearch.DisplayMember = "City";
            mccSearch.ValueMember = "ID";

            mccSearchWithFiltering.DataSource = DataSource.GetRows("Select * from Cities", "Cities");
            mccSearchWithFiltering.DisplayMember = "City";
            mccSearchWithFiltering.ValueMember = "ID";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            mccUnboundMode.AddItem(Country.GetCountry().ToString());
        }

        private void btnRemoveLastItem_Click(object sender, EventArgs e)
        {
            mccUnboundMode.RemoveItem(mccUnboundMode.ItemsCount - 1);
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            mccUnboundMode.ClearItems();
        }

        private void mccUnboundMode_SelectedValueChanged(object sender, EventArgs e)
        {
            string flag = mccUnboundMode.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(flag))
                mccUnboundMode.ImageKey = flag;
            else
                mccUnboundMode.ImageKey = string.Empty;
        }
    }
}
