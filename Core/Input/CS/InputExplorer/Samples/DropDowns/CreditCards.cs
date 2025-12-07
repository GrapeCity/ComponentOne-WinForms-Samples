using System.Windows.Forms;

namespace InputExplorer.Samples.DropDowns
{
    internal partial class CreditCards : UserControl
    {
        C1.Win.Input.C1DropDownControl _customDropDowns;
        public CreditCards()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }
        public CreditCards(C1.Win.Input.C1DropDownControl customDropDowns)
        {
            InitializeComponent();
            _customDropDowns = customDropDowns;
            radioButton1.Checked = true;
        }

        private void DropDown1_PostChanges(object sender, System.EventArgs e)
        {
            _customDropDowns.Value = radioButton1.Checked ? "Visa" :
                radioButton2.Checked ? "Master Card" :
                radioButton3.Checked ? "American Express" : "Discover";
        }

    }
}
