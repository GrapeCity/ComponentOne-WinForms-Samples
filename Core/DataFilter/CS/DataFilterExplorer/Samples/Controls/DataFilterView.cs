using C1.DataCollection.BindingList;
using C1.DataEngine;
using C1.Win.DataFilter;
using DataFilterExplorer.Data;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFilterExplorer.Samples
{
    public partial class DataFilterView : UserControl
    {
        private Stopwatch _swFiltered;
        private C1DataCollectionBindingList _dataCollection;
        private Workspace _workspace;

        public DataFilterView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public int TotalCount { get; private set; }
        public int FilteredCount { get; private set; }
        public long TotalLoadTime { get; private set; }
        public long FilteredTime { get; private set; }

        public event EventHandler DataUpdated;

        public async Task LoadData()
        {
            _workspace = new Workspace();
            var (collection, count, time) = await DataService.LoadDataCollection(_workspace, "workspaceDF");
            TotalLoadTime = time;
            _dataCollection = new C1DataCollectionBindingList(collection);
            TotalCount = count;
            c1DataFilter1.AutoApply = true;
            c1DataFilter1.AutoGenerateFilters = true;
            await Task.Run(() => c1DataFilter1.DataSource = collection);
            await c1DataFilter1.ApplyFilterAsync();
            // flex grid
            await Task.Run(() => c1FlexGrid1.DataSource = _dataCollection);
            c1FlexGrid1.Cols["PostId"].Visible = false;
            c1FlexGrid1.Cols["CountryId"].Visible = false;
            c1FlexGrid1.Cols["FirstName"].Caption = "First Name";
            c1FlexGrid1.Cols["LastName"].Caption = "Last Name";
            c1FlexGrid1.Cols["EmploymentDate"].Caption = "Employment Date";
        }       

        private void c1DataFilter1_FilterAutoGenerating(object sender, C1.DataFilter.FilterAutoGeneratingEventArgs e)
        {
            switch (e.Property.Name)
            {
                case "FirstName":
                    var nameFilter = e.Filter as ChecklistFilter;
                    nameFilter.HeaderText = "First name";
                    nameFilter.ItemsSource = Employee.Names;                    
                    break;
                case "LastName":
                    var lastNameFilter = e.Filter as ChecklistFilter;
                    lastNameFilter.HeaderText = "Last name";
                    lastNameFilter.ItemsSource = Employee.LastNames;                    
                    break;
                case "CountryId":
                    var countryFilter = new ChecklistFilter(e.Property.Name);
                    dynamic country = _workspace.table("country");
                    dynamic cquery = _workspace.query("selectCountries", new
                    {
                        Id = country.Id,
                        Name = country.Name
                    });
                    cquery.Query.Execute();
                    countryFilter.ItemsSource = ClassFactory.CreateFromDataList(_workspace.GetQueryData("selectCountries"), nameof(Country));                    
                    countryFilter.DisplayMemberPath = "Name";
                    countryFilter.ValueMemberPath = "Id";
                    countryFilter.HeaderText = "Country";
                    countryFilter.ShowSelectAll = false;
                    countryFilter.SelectionMode = C1.DataFilter.SelectionMode.Single;
                    countryFilter.Items.First().Selected = true;
                    e.Filter = countryFilter;
                    break;
                case "PostId":
                    var postFilter = new ChecklistFilter(e.Property.Name);
                    dynamic post = _workspace.table("post");
                    dynamic pquery = _workspace.query("selectPosts", new
                    {
                        Id = post.Id,
                        Title = post.Title
                    });
                    pquery.Query.Execute();
                    postFilter.ItemsSource = ClassFactory.CreateFromDataList(_workspace.GetQueryData("selectPosts"), nameof(Post));
                    postFilter.DisplayMemberPath = "Title";
                    postFilter.ValueMemberPath = "Id";
                    postFilter.HeaderText = "Post";
                    postFilter.ShowSelectAll = false;
                    postFilter.SelectionMode = C1.DataFilter.SelectionMode.Single;
                    postFilter.Items.First().Selected = true;
                    e.Filter = postFilter;
                    break;
                case "EmploymentDate":
                    var dateFilter = e.Filter as DateRangeFilter;
                    dateFilter.HeaderText = "Employment date";
                    dateFilter.Maximum = DateTime.Now;
                    dateFilter.Minimum = DateTime.Now.AddYears(-70);
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void c1DataFilter1_FilterChanged(object sender, EventArgs e)
        {
            _swFiltered.Stop();
            FilteredTime = _swFiltered.ElapsedMilliseconds;
            FilteredCount = _dataCollection.Count;
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }        

        private void c1DataFilter1_FilterChanging(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _swFiltered = new Stopwatch();
            _swFiltered.Start();
        }
    }
}
