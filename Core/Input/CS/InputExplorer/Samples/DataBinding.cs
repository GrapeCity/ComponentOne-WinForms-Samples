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

namespace InputExplorer.Samples
{
    using InputExplorer.Data;
    using C1.Win.Input;
    using C1.Win.Input.Base;

    public partial class DataBinding : UserControl
    {
        private BindingSource _data;
        private List<string> _countries = new List<string>();
        public DataBinding()
        {
            InitializeComponent();
        }

        private List<IInputEditor> GetTextBoxControls(TableLayoutPanel sourcePanel)
        {
            var result = new List<IInputEditor>();

            foreach (var item in editFormPanel.Controls)
            {
                var control = item as IInputEditor;
                if (control != null)
                    result.Add(control);
            }

            return result;
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {
            _data = new BindingSource();
            var imageColumns = new List<string>() { "Photo" };
            var table = DataSource.GetRows("Select * from Employees", "Employees", imageColumns);
            _data.DataSource = table;

            var countriesTable = DataSource.GetRows("Select CountryName as Country from Countries Order by CountryName", "countries");
            _countries = (from s in countriesTable.Rows.Cast<DataRow>() select s)
                .Select(x => x["Country"].ToString()).ToList();

            var columns = (from s in table.Columns.Cast<DataColumn>() select s)
           .Select(x => x.ColumnName).ToList();

            var controls = GetTextBoxControls(editFormPanel);
            controls.ForEach(x =>
            {
                var textBox = x as C1TextBoxBase;
                if (textBox is not null)
                {
                    if (textBox.Enabled && !textBox.ReadOnly)
                    {
                        // Add data source
                        textBox.DataSource = _data;
                        var dataMember = columns.Where(y => y.IndexOf(textBox.Name, StringComparison.InvariantCultureIgnoreCase) >= 0)
                            .FirstOrDefault();
                        textBox.DataMember = dataMember;
                    }
                }
            });

            // C1ComboBox
            Country.DataSource = _data;
            Country.DataMember = "Country";
            Country.Items.AddRangeValues(_countries);

            // C1PictureBox
            picturePhoto.DataSource = _data;
            picturePhoto.DataMember = "Photo";
            labelEmploeeID.DataBindings.Add("Text", _data, "EmployeeID");

            // C1DateEdit
            BirthDate.DataSource = _data;
            BirthDate.DataMember = "BirthDate";

            c1dbNavigator1.DataSource = _data;
        }
    }
}
