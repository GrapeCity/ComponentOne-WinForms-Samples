using SamplesData.Editors;
using System.Windows.Forms;

namespace CustomEditors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1TreeView1.BindingInfo.DataMember = "Collection";
            c1TreeView1.BindingInfo.DataSource = EditorsData.GetData();
           
            c1TreeView1.Columns[2].Editor = new CustomColorPicker();
            c1TreeView1.Columns[3].Editor = new CustomDatePicker();
        }
    }
}