using C1DataCollection101.Resources;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C1DataCollection101.View
{
    public partial class Menu : UserControl
    {
        int _selectedSampleViewType = -2;

        public Menu()
        {
            InitializeComponent();

            var samples = GetSamples();
            foreach (var sample in samples)
            {
                var item = new ListViewItem()
                {
                    ImageIndex = imageList1.Images.IndexOfKey(sample.Thumbnail),
                    Text = sample.Name,
                    Tag = sample
                };
                listView1.Items.Add(item);
            }
        }

        private List<Sample> GetSamples()
        {
            return new List<Sample>
            {
                new Sample() { Name = AppResources.SortingTitle, Description= AppResources.SortingDescription, SampleViewType = 0, Thumbnail="sort.png" },
                new Sample() { Name = AppResources.FilteringTitle, Description= AppResources.FilteringDescription, SampleViewType = 1, Thumbnail="filter.png" },
                new Sample() { Name = AppResources.GroupingTitle, Description= AppResources.GroupingDescription, SampleViewType = 2, Thumbnail="flexgrid_grouping.png"},
                new Sample() { Name = AppResources.VirtualModeTitle, Description= AppResources.VirtualModeDescription, SampleViewType = 3, Thumbnail="collectionview.png"},                
            };
        }

        public int SelectedSampleViewType
        {
            get => _selectedSampleViewType;
            set
            {
                if (value != _selectedSampleViewType)
                {
                    _selectedSampleViewType = value;
                    OnSelectionChanged(EventArgs.Empty);
                }
            }
        }

        public event EventHandler<EventArgs> SelectionChanged;

        protected void OnSelectionChanged(EventArgs e) => SelectionChanged?.Invoke(this, e);        

        private void listView1_ItemClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                SelectedSampleViewType = ((Sample)listView1.SelectedItems[0].Tag).SampleViewType;
            else
                SelectedSampleViewType = -1;            
        }
    }
}
