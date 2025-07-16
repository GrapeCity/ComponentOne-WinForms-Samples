using C1.DataCollection;
using C1.DataCollection.BindingList;
using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.DataCollection
{
    public partial class Overview : ControlExplorer.C1DemoForm
    {
        C1DataCollection<Customer> _dataCollection;
        public Overview()
        {
            InitializeComponent();
            SetupData();
        }

        private void SetupData()
        {
            // Generate customer collection and wrap it into a data collection
            _dataCollection = new C1DataCollection<Customer>(Customer.GetCustomerList(100));
            // Use the C1DataCollectionBindingList class from C1.Win.DataCollection assembly
            // for binding with WinForms controls.
            c1FlexGrid1.DataSource = new C1DataCollectionBindingList(_dataCollection);
            _dataCollection.SortChanged += OnSortChanged;
            UpdateSortButton();
        }

        private async void sortButton_Click(object sender, EventArgs e)
        {
            if (_dataCollection != null)
            {
                var direction = GetCurrentSortDirection();
                await _dataCollection.SortAsync(x => x.FirstName, direction == SortDirection.Ascending ? SortDirection.Descending : SortDirection.Ascending);
            }
        }

        private void UpdateSortButton()
        {
            var direction = GetCurrentSortDirection();
            string imageKey = direction == SortDirection.Ascending ? "SortDescending" : "SortAscending";
            this.sortButton.LargeImage = c1Ribbon1.GetPresetImage(imageKey, 32);
            this.sortButton.SmallImage = c1Ribbon1.GetPresetImage(imageKey, 16);
        }

        private SortDirection GetCurrentSortDirection()
        {
            var sort = _dataCollection.SortDescriptions.FirstOrDefault(sd => sd.SortPath == "FirstName");
            return sort != null ? sort.Direction : SortDirection.Descending;
        }


        void OnSortChanged(object sender, EventArgs e)
        {
            UpdateSortButton();
            if (_dataCollection.SortDescriptions.Count > 0)
            {
                // update sorting glyphs in the FlexGrid
                var sort = _dataCollection.SortDescriptions[0];
                var direction = sort.Direction;
                var columnName = sort.SortPath;
                if (c1FlexGrid1.SortColumn != null && c1FlexGrid1.SortColumn.Name != columnName)
                {
                    c1FlexGrid1.SortColumn.Sort = SortFlags.None;
                }
                c1FlexGrid1.ShowSortAt(direction == SortDirection.Ascending ? SortFlags.Ascending : SortFlags.Descending, c1FlexGrid1.Cols.IndexOf(columnName));
            }
        }

        private async void txtFilter_TextChanged(object sender, EventArgs e)
        {
            await _dataCollection.FilterAsync(txtFilter.Text);
        }
    }
}
