using SamplesData;
using System.Windows.Forms;

namespace BoundModeITypedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1TreeView1.BindingInfo.AutoGenerateColumns = true;
            c1TreeView1.BindingInfo.ParentKeyField = "ChiefID";
            c1TreeView1.BindingInfo.KeyField = "ID";
            c1TreeView1.BindingInfo.DataSource = EmployeesTypedList.GetData();
        }        
    }
}
