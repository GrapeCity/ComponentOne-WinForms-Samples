using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Input;

namespace InputExplorer.Samples
{
    public partial class ComboBox : UserControl
    {
        public ComboBox()
        {
            InitializeComponent();

            c1ComboBox2.ItemsDataSource = GetData();
            c1ComboBox2.ItemsDisplayMember = "Name";
            c1ComboBox2.ItemsValueMember = "Phone";

            List<string> items = new List<string>();
            for (int i = 0; i < 100; i++)
                items.Add(i.ToString());
            c1ComboBox3.Items.AddRangeValues(items);

            c1ComboBox4.ItemsDataSource = _addresses;
            c1ComboBox4.AutoCompleteCustomSource.AddRange(_addresses.ToArray());

            foreach (Control control in Controls)
                if (control is C1ComboBox)
                    control.Enter += Control_GotFocus;
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
                this.propertyGrid1.SelectedObject = sender;
        }

        private List<string> _addresses = new List<string>()
        {
            "boss@mycompany.com",
            "info@mycompany.com",
            "hr@mail.com",
            "sergey.brin@google.com",
            "devil@hell.org",
            "sun@shining.com",
            "boss2@mycompany.com",
            "info2@mycompany.com",
            "hr2@mail.com",
            "sergey.brin2@google.com",
            "devil2@hell.org",
            "sun2@shining.com",
            "boss3@mycompany.com",
            "info3@mycompany.com",
            "hr3@mail.com",
            "sergey.brin3@google.com",
            "devil3@hell.org",
            "sun3@shining.com",
            "boss3@mycompany.com",
            "info3@mycompany.com",
            "hr3@mail.com",
            "sergey.brin3@google.com",
            "devil3@hell.org",
            "sun3@shining.com",
        };

        private DataTable GetData()
        {
            DataTable dt = new DataTable("Phones");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Rows.Add(new string[] { "Nancy", "(206) 555-9857" });
            dt.Rows.Add(new string[] { "Andrew", "(206) 555-9482" });
            dt.Rows.Add(new string[] { "Janet", "(206) 555-3412" });
            dt.Rows.Add(new string[] { "Margaret", "(206) 555-8122" });
            dt.Rows.Add(new string[] { "Steven", "(71) 555-4848" });
            dt.Rows.Add(new string[] { "Michael", "(71) 555-7773" });
            dt.Rows.Add(new string[] { "Robert", "(71) 555-5598" });
            dt.Rows.Add(new string[] { "Callahan", "(206) 555-1189" });
            dt.Rows.Add(new string[] { "Anne", "(71) 555-4444" });
            return dt;
        }
    }
}
