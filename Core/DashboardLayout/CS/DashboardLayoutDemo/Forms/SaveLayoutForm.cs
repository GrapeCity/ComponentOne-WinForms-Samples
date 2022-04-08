using System;
using System.Windows.Forms;
using C1.Win.Ribbon;

namespace DashboardDemo
{
    public partial class SaveLayoutForm : C1RibbonForm
    {
        public SaveLayoutForm(string name = null)
        {            
            InitializeComponent();
            if (name != null)
                c1TextBox1.Value = name;
        }

        public string FileName => c1TextBox1.Text;

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
