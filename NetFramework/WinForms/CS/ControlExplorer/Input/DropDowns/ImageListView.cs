using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace ControlExplorer.Input.DropDowns
{
    public partial class ImageListView : DropDownForm
    {
        public ImageListView()
        {
            InitializeComponent();
        }

        private void ImageListView_Load(object sender, EventArgs e)
        {
            CustomDropDowns owner = this.Owner as CustomDropDowns;
            C1DemoDataSet ds = owner.c1DemoDataSet;

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
                this.OwnerControl.Text = listView1.SelectedItems[0].Text;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            // Close the dropdown when the user selects an item by clicking it    
            this.OwnerControl.CloseDropDown(true);
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
                if (lvi.Text == this.OwnerControl.Text)        
                {            
                    lvi.Selected = true;            
                    listView1.EnsureVisible(i);            
                    return;        
                }    
            }
        }
    }
}
