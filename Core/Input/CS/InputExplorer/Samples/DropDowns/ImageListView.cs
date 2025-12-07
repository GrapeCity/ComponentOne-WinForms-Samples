using System;
using System.Drawing;
using System.Windows.Forms;

namespace InputExplorer.Samples.DropDowns
{
    public partial class ImageListView : UserControl
    {
        private C1.Win.Input.C1DropDownControl _imageDropDown;
        private C1DemoDataSet _c1DemoDataSet;
        public ImageListView(C1.Win.Input.C1DropDownControl imageDropDown, C1DemoDataSet c1DemoDataSet)
        {
            InitializeComponent();
            _imageDropDown = imageDropDown;
            _c1DemoDataSet = c1DemoDataSet;
        }
        private void ImageListView_Load(object sender, EventArgs e)
        {
            C1DemoDataSet ds = _c1DemoDataSet;

            for (int i = 0; i < ds.Categories.Count; i++)
            {
                // The ImageList order matches the dataset order        
                listView1.Items.Add(ds.Categories[i].CategoryName, i);
                // Add image
                imageList1.Images.Add(Image.FromStream(new System.IO.MemoryStream(ds.Categories[i].Picture)));
            }
        }

        private void ImageListView_PostChanges(object sender, EventArgs e)
        {
            // Set the text of the parent control according to the ListView selection   
            if (listView1.SelectedItems.Count > 0)
            {
                _imageDropDown.Value = listView1.SelectedItems[0].Text;
            }
        }

        private void ImageListView_VisibleChanged(object sender, EventArgs e)
        {
            // Do nothing if the dropdown is being closed    
            if (!this.Visible)
                return;
            listView1.SelectedItems.Clear();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem lvi = listView1.Items[i];
                // Select the item that matches the text of the parent control        
                if (lvi.Text == _imageDropDown.Value)
                {
                    lvi.Selected = true;
                    listView1.EnsureVisible(i);
                    return;
                }
            }
        }
    }
}
