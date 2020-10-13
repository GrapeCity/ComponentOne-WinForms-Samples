using System;
using System.Linq;
using System.Windows.Forms;
using C1.DataCollection;
using C1.DataCollection.BindingList;
using C1DataCollection101.Resources;

namespace C1DataCollection101.View
{
    public partial class Sorting : UserControl
    {
        C1DataCollection<Customer> _dataCollection;
        Menu _owner;

        public Sorting()
        {
            InitializeComponent();
            lblTitle.Text = AppResources.SortingTitle;
            //btnSort.Text = AppResources.Sort;            
        }

        public void ShowPage(Menu owner)
        {
            _owner = owner;
            UpdateVideos();
        }

        private void UpdateVideos()
        {
            try
            {
                lblMessage.Visible = false;
                grid.Visible = false;
                //activityIndicator.IsRunning = true;
                _dataCollection = new C1DataCollection<Customer>(Customer.GetCustomerList(100));
                grid.DataSource = new C1DataCollectionBindingList(_dataCollection);

                _dataCollection.SortChanged += OnSortChanged;
                UpdateSortButton();
                grid.Visible = true;
            }
            catch
            {
                lblMessage.Text = AppResources.InternetConnectionError;
                lblMessage.Visible = true;
            }
            //finally
            //{
            //    activityIndicator.IsRunning = false;
            //}
        }

        async void OnSortClicked(object sender, EventArgs e)
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
            if (direction == SortDirection.Ascending)
            {
                btnSort.ImageKey = "sort-descending.png";                
            }
            else
            {
                btnSort.ImageKey = "sort-ascending.png";
            }
        }

        private SortDirection GetCurrentSortDirection()
        {
            var sort = _dataCollection.SortDescriptions.FirstOrDefault(sd => sd.SortPath == "FirstName");
            return sort != null ? sort.Direction : SortDirection.Descending;
        }


        void OnSortChanged(object sender, EventArgs e)
        {
            UpdateSortButton();
        }        

        private void btnBack_Click(object sender, EventArgs e)
        {
            _owner.SelectedSampleViewType = -1;
        }
    }
}
