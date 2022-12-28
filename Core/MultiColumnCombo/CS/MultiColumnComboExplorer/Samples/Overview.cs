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
            mccDefault.DataSource = DataSource.GetRows("Select * from Customers", "Customers");
            mccDefault.DisplayMember = "CompanyName";
            mccDefault.ValueMember = "CustomerID";

            mccCustomStyle.DataSource = DataSource.GetRows("Select * from Customers", "Customers");
            mccCustomStyle.DisplayMember = "CompanyName";
            mccCustomStyle.ValueMember = "CustomerID";

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

        private class Country
        {
            private static Random _random = new Random();
            private static Country[] _countries = new Country[5]
                {
                    new Country()
                    {
                         Name = "France",
                         Capital = "Paris",
                         Flag = "FR-Flag.png"
                    },
                    new Country()
                    {
                         Name = "Japan",
                         Capital = "Tokyo",
                         Flag = "JP_Flag.png"
                    },
                    new Country()
                    {
                         Name = "China",
                         Capital = "Beijing",
                         Flag = "CH_Flag.png"
                    },
                    new Country()
                    {
                         Name = "Spain",
                         Capital = "Madrid",
                         Flag = "ES-Flag.png"
                    },
                    new Country()
                    {
                         Name = "India",
                         Capital = "New Delhi",
                         Flag = "IN_Flag.png"
                    }
                };

            public string Name { get; set; }
            public string Capital { get; set; }
            public string Flag { get; set; }

            public override string ToString() => $"{Name},{Capital},{Flag}";
            public static Country GetCountry() => _countries[_random.Next(0, _countries.Length - 1)];
            public static Country GetCountry(int index) => _countries[index];
        }

    }
}
