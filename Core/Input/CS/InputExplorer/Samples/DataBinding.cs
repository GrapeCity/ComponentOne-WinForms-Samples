using InputExplorer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;

namespace InputExplorer.Samples
{
    public partial class DataBinding : UserControl
    {
        private BindingSource _data;
        private List<string> _countries = new List<string>
        {
            "Portugal",
            "UK",
            "Spain",
            "France",
            "Italy",
            "Iceland",
            "Ireland",
            "Germany",
            "Belgium",
            "Netherlands",
            "Luxembourg",
            "Switzerland",
            "Austria",
            "Czech-Republic",
            "Denmark",
            "Poland",
            "Slovenia",
            "Croatia",
            "Hungary",
            "Bosnia and Herzegovina",
             "Serbia",
            "Albania",
            "Greece",
            "Macedonia",
            "Bulgaria",
            "Romania",
            "Slovakia",
            "Russia",
            "Lithuania",
            "Latvia",
            "Estonia",
            "Norway",
            "Sweden",
            "Finland",
            "Belarus",
            "Moldova",
            "Ukraine", "Canada","USA"
        };        

        public DataBinding()
        {
            InitializeComponent();
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {
            _data = new BindingSource();
            _data.DataSource = DemoDataSource.Employees;

            c1Label8.DataBindings.Add("Text", _data, "EmployeeID");

            c1TextBox1.DataSource = _data;
            c1TextBox1.DataMember = "FirstName";

            c1TextBox2.DataSource = _data;
            c1TextBox2.DataMember = "LastName";

            c1TextBox3.DataSource = _data;
            c1TextBox3.DataMember = "HomePhone";

            c1TextBox4.DataSource = _data;
            c1TextBox4.DataMember = "BirthDate";

            c1NumericEdit1.DataSource = _data;
            c1NumericEdit1.DataMember = "Extension";

            c1ComboBox1.DataSource = _data;
            c1ComboBox1.DataMember = "Country";
            c1ComboBox1.Items.AddRangeValues(_countries);

            c1PictureBox1.DataSource = _data;
            c1PictureBox1.DataMember = "Photo";
            

            UpdateButtons();
        }

        private void UpdateButtons()
        {
            c1Button1.Enabled = _data.Position != 0;
            c1Button2.Enabled = _data.Position < _data.Count - 1;
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            if(_data.Position > 0)
                _data.Position--;
            UpdateButtons();
        }

        private void c1Button2_Click(object sender, EventArgs e)
        {
            if (_data.Position < _data.Count - 1)
                _data.Position++;
            UpdateButtons();
        }
    }
}
