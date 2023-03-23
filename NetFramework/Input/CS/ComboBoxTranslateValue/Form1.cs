using System;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace ComboBoxTranslateValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when Form1 loaded.
        /// </summary>
        /// <param name="sender">Form1 object. </param>
        /// <param name="e">Event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1NWindDataSet.Customer_demo' table. You can move, or remove it, as needed.
            this.customer_demoTableAdapter.Fill(this.c1NWindDataSet.Customer_demo);
            // TODO: This line of code loads data into the 'c1NWindDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.c1NWindDataSet.Order);
            LoadThemes();
        }

        /// <summary>
        /// Loads themes list from xml-file and set as data source for the themesBindingSource.
        /// </summary>
        /// <remarks>
        /// Linq2xml query is used as a data source for a BindingSource which is used as a DataSource for the themes ComboBox.
        /// </remarks>
        private void LoadThemes()
        {
            XDocument xdoc = XDocument.Load("Resources\\themes.xml");
            var themes = from theme in xdoc.Element("Themes_Table").Elements("themes")
                       select theme.Element("name").Value;
            themesBindingSource.DataSource = themes;
            _themes.Value = c1ThemeController1.Theme;
        }

        /// <summary>
        /// Occurs when selected item changed. Changes current theme of the application.
        /// </summary>
        /// <param name="sender">C1ComboBox object.</param>
        /// <param name="e">Event data.</param>
        private void _themes_SelectedItemChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = _themes.SelectedItem.ToString();
        }

        /// <summary>
        /// Occurs when Add button clicked. Adds new empty row to grid.
        /// </summary>
        /// <param name="sender">C1Button object.</param>
        /// <param name="e">Event data.</param>
        private void _addBtn_Click(object sender, EventArgs e)
        {
            var date = (System.Data.DataRowView)orderBindingSource.AddNew();
            _customerEdit.Clear();
        }
    }
}
