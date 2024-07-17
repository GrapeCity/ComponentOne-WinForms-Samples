using C1.Win.Ribbon;

namespace DashboardLayoutDemo
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
            _helper.DeleteLayout(c1List1.SelectedText);
            Reset();
        }

        private void btnRename_Click(object sender, System.EventArgs e)
        {
            _helper.RenameLayout(c1List1.SelectedText);
            Reset();
        }

        private void c1List1_SelectionChanged(object sender, System.EventArgs e) => AllowButtons(true);

        private void Reset()
        {
            c1List1.DataSource = _helper.GetLayouts();
            AllowButtons(false);
        }

        private void AllowButtons(bool allow)
        {
            btnRename.Enabled = allow;
            btnDelete.Enabled = allow;
        }
    }
}
