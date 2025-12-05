using InputExplorer.Samples.DropDowns;
using System;
using System.Windows.Forms;

namespace InputExplorer.Samples
{
    public partial class CustomDropDowns : UserControl
    {
        private CreditCards _creditCardDropDown;
        private CheckedList _checkedListBox;
        private ImageMapping _imageMapping;
        private TabbedList _tabbedList;
        private ImageListView _imageListView;
        public CustomDropDowns()
        {
            InitializeComponent();
            _creditCardDropDown = new CreditCards(ddCreditCards);
            _checkedListBox = new CheckedList(ddCheckedListBox);
            _imageMapping = new ImageMapping(c1DropDownControl1);
            _tabbedList = new TabbedList(ddTabbedLists);
            _imageListView = new ImageListView(c1DropDownControl2, c1DemoDataSet);
            ddCreditCards.Control = _creditCardDropDown;
            ddCheckedListBox.Control = _checkedListBox;
            c1DropDownControl1.Control = _imageMapping;
            ddTabbedLists.Control = _tabbedList;
            c1DropDownControl2.Control = _imageListView;
        }

        private void CustomDropDowns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Categories' table.
            this.categoriesTableAdapter.Fill(this.c1DemoDataSet.Categories);
        }


    }
}
