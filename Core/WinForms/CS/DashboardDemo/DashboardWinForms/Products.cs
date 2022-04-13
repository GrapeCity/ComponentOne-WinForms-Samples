using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DashboardModel;

namespace DashboardWinForms
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
            c1DockingTabPage1.Text = Strings.Resource.All_Header;
            c1DockingTabPage2.Text = Strings.Resource.Sports_Header;
            c1DockingTabPage3.Text = Strings.Resource.City_Header;
            c1DockingTabPage4.Text = Strings.Resource.MultiUtility_Header;
            c1DockingTabPage5.Text = Strings.Resource.NewEntry_Header;
            Text = Strings.Resource.ProductsPage_Title;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            c1DockingTab1_TabClick(null, EventArgs.Empty);
        }

        private void c1DockingTab1_TabClick(object sender, EventArgs e)
        {
            var list = DataService.GetService().GetProductItemList((CategoryType)c1DockingTab1.SelectedIndex);
            listView1.Items.Clear();
            listView1.LargeImageList = new ImageList();
            listView1.LargeImageList.ImageSize = new Size(256, 256 / 2);
            int i = 0;
            foreach (var item in list)
            {
                listView1.LargeImageList.Images.Add(item.ImageSource);
                listView1.Items.Add(item.Label, i++);
            }
            listView1.Parent = c1DockingTab1.SelectedTab;
        }
    }
}
