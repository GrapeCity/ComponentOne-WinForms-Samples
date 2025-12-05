using System;
using System.Windows.Forms;

namespace InputExplorer.Samples.DropDowns
{
    public partial class TabbedList : UserControl
    {
        private C1.Win.Input.C1DropDownControl _tabbedList;
        public TabbedList(C1.Win.Input.C1DropDownControl tabbedList)
        {
            InitializeComponent();
            _tabbedList = tabbedList;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            _tabbedList.Value = lb.GetItemText(lb.SelectedItem);
        }
    }
}
