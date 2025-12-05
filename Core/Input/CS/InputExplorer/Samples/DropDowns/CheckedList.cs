using System.Windows.Forms;

namespace InputExplorer.Samples.DropDowns
{
    public partial class CheckedList : UserControl
    {
        private C1.Win.Input.C1DropDownControl _checkList;

        public CheckedList()
        {
            InitializeComponent();
        }

        public CheckedList(C1.Win.Input.C1DropDownControl checkedList)
        {
            InitializeComponent();
            _checkList = checkedList;
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string conc = "";
            foreach (string item in checkedListBox1.CheckedItems)
            {
                conc += item + ", ";
            }
            _checkList.Value = conc.TrimEnd(',', ' ');
        }
    }
}
