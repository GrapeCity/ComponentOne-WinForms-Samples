using C1.Win.Ribbon;

namespace DashboardDemo
{
    public partial class ManageLayoutForm : C1RibbonForm
    {
        private SampleHelper _helper;

        public ManageLayoutForm(SampleHelper helper)
        {
            _helper = helper;
            InitializeComponent();
            Reset();
        }

        private void btnClose_Click(object sender, System.EventArgs e) => Close();

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            _helper.DeleteLayout(list1.SelectedItems[0].Text);
            Reset();
        }

        private void btnRename_Click(object sender, System.EventArgs e)
        {
            _helper.RenameLayout(list1.SelectedItems[0].Text);
            Reset();
        }

        private void list1_SelectionChanged(object sender, System.EventArgs e) => AllowButtons(true);

        private void Reset()
        {
            list1.Clear();
            var layouts = _helper.GetLayouts();
            foreach (string item in layouts)
                list1.Items.Add(item);
            AllowButtons(false);
        }

        private void AllowButtons(bool allow)
        {
            btnRename.Enabled = allow && list1.SelectedItems.Count > 0;
            btnDelete.Enabled = allow && list1.SelectedItems.Count > 0;
        }
    }
}
