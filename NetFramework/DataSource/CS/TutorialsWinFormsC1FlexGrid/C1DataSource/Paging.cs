using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Data.DataSource;

namespace TutorialsWinFormsC1FlexGrid
{
    public partial class Paging : Form
    {
        ClientCollectionView _view;

        public Paging()
        {
            InitializeComponent();

            // Update the displayed page index and count 
            // when they change in the C1DataSource.

            _view = c1DataSource1["Orders"];

            RefreshPageInfo();
            _view.PropertyChanged += delegate { RefreshPageInfo(); };
        }

        private void RefreshPageInfo()
        {
            labelPage.Text = string.Format("Page: {0} / {1}", _view.PageIndex + 1, _view.PageCount);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            _view.MoveToPreviousPage();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _view.MoveToNextPage();
        }
    }
}
